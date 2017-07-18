//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Model;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Reads EDI documents into .NET objects.
    /// </summary>
    public abstract class PositionalReader : IDisposable
    {
        private readonly Queue<char> _buffer;
        private readonly StreamReader _streamReader;
        private readonly bool _continueOnError;
        private readonly int _segmentLength;
        private readonly string _postFix;
        
        internal List<SegmentContext> CurrentSegments { get; private set; }
        internal MessageContext CurrentMessageContext;
        internal readonly Func<string, MessageContext> MessageContext;
        
        /// <summary>
        /// The last item that was read.
        /// </summary>
        public EdiItem Item { get; protected set; }
        
        /// <summary>
        /// Indicates whether the current stream position is at the end of the stream.
        /// </summary>
        public bool EndOfStream
        {
            get { return _streamReader.EndOfStream; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionalReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="messageContext">The delegate to return the message context.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <param name="postFix">The postfix.</param>
        /// <param name="continueOnError">Whether to continue searching for valid data after an error occurs.</param>
        /// <param name="segmentLength">The maximum length of a segment after which the search for segment terminator seizes.</param>
        protected PositionalReader(Stream ediStream, Func<string, MessageContext> messageContext, Encoding encoding,
            int segmentLength, string postFix, bool continueOnError = false)
        {
            if (ediStream == null) throw new ArgumentNullException("ediStream");
            if (messageContext == null) throw new ArgumentNullException("messageContext");

            _streamReader = new StreamReader(ediStream, encoding ?? Encoding.UTF8, true);
            MessageContext = messageContext;
            CurrentSegments = new List<SegmentContext>();
            _continueOnError = continueOnError;
            _segmentLength = segmentLength;
            _postFix = postFix;
            _buffer = new Queue<char>();
        }

        /// <summary>
        /// Reads an EDI item from the stream.
        /// </summary>
        /// <returns>Indication if an item was read.</returns>
        public bool Read()
        {
            if (Item is ReaderErrorContext && !_continueOnError)
                return false;

            Item = null;

            try
            {
                while ((!_streamReader.EndOfStream || _buffer.Any()) && Item == null)
                {
                    var segment = ReadSegment();

                   if (string.IsNullOrEmpty(segment))
                        continue;

                    Item = Process(segment);
                }
            }
            catch (ReaderException ex)
            {
                Item = new ReaderErrorContext(ex, ex.ErrorCode);
            }
            catch (ParserMessageException ex)
            {
                Item = new ReaderErrorContext(ex, ReaderErrorCode.InvalidSpecOrAssembly, ex.MessageErrorContext);
            }
            catch (Exception ex)
            {
                Item = new ReaderErrorContext(ex, ReaderErrorCode.Unknown);
            }

            if (_streamReader.EndOfStream && CurrentSegments.Any())
                Item = new ReaderErrorContext(new Exception("Improper end of file."), ReaderErrorCode.ImproperEndOfFile);

            var readerErrorContext = Item as ReaderErrorContext;
            if (readerErrorContext != null)
            {
                CurrentSegments.Clear();              
            }

            return Item != null;
        }

        /// <summary>
        /// Reads the stream to the end.
        /// </summary>
        /// <returns>All items that were found in the stream.</returns>
        public IEnumerable<EdiItem> ReadToEnd()
        {
            while (Read())
            {
                yield return Item;
            }
        }

        /// <summary>
        /// Converts EDI segments into typed objects. 
        /// </summary>
        /// <param name="segment">The segment to be processed.</param>
        protected abstract EdiItem Process(string segment);
        
        /// <summary>
        /// Reads from the stream until a non-escaped segment terminator was reached.
        /// Breaks if no segment terminator was encountered after 5000 symbols were read. 
        /// This is to avoid loading large and corrupt files. 
        /// </summary>
        /// <returns>
        /// An EDI segment.
        /// </returns>
        private string ReadSegment()
        {
            var line = "";
            var postFix = "";
            while ((!_streamReader.EndOfStream || _buffer.Any()) && line.Length < _segmentLength)
            {
                line = line + Read(1); 
            }

            while (!string.IsNullOrEmpty(_postFix) && !_streamReader.EndOfStream && postFix.Length < _postFix.Length)
            {
                postFix = postFix + Read(1); 
            }

            if (!string.IsNullOrEmpty(_postFix) && postFix != _postFix)
                throw new Exception(string.Format("Postfix {0} is different than the expected {1}", postFix, _postFix));            

            return line;
        }

        /// <summary>
        /// Parses the accumulated segments.
        /// </summary>
        protected EdiItem ParseSegments()
        {
            if (CurrentMessageContext == null)
            {
                CurrentSegments.Clear();
                return null;
            }

            EdiItem result;
            try
            {
                var message = new TransactionSet(CurrentMessageContext.MessageType);
                var errorContext = message.Analyze(CurrentSegments, CurrentMessageContext, null, 0,
                    0);

                var ediMessage = (EdiMessage) message.ToInstance();
                ediMessage.MessagePart = 0;
                ediMessage.ControlNumber = CurrentMessageContext.ControlNumber;
                ediMessage.ErrorContext = errorContext;
                result = ediMessage;
            }
            catch (Exception ex)
            {
                result = new ReaderErrorContext(ex, ReaderErrorCode.InvalidSpecOrAssembly,
                    new MessageErrorContext(CurrentMessageContext.Name,
                        CurrentMessageContext.ControlNumber, 0, ex.Message,
                        MessageErrorCode.MissingOrInvalidTransactionSet));
            }
            finally
            {
                CurrentSegments.Clear();
            }

            return result;
        }


        /// <summary>
        /// Reads number of bytes from the stream.
        /// </summary>
        /// <param name="bytes">The number of bytes.</param>
        /// <returns>The string read from the stream.</returns>
        protected string Read(int bytes)
        {
            var result = "";
            var index = 0;
            while (index < bytes)
            {
                if (_buffer.Count > 0)
                    result += _buffer.Dequeue().ToString();
                else
                    result += ReadFromStream(1);

                index++;
            }

            return result;
        }
        
        /// <summary>
        /// Reads number of bytes from the stream.
        /// </summary>
        /// <param name="bytes">The number of bytes.</param>
        /// <returns>The string read from the stream.</returns>
        protected string ReadFromStream(int bytes)
        {
            var result = new char[bytes];
            _streamReader.Read(result, 0, result.Length);
            return String.Concat(result);
        }
        
        /// <summary>
        /// Disposes the reader.
        /// </summary>
        public void Dispose()
        {
            if (_streamReader != null)
                _streamReader.Dispose();
        }

        /// <summary>
        /// Flushes any remaining data before a control segment.
        /// </summary>
        /// <param name="segment">The control segment.</param>
        /// <returns>The parsed segments.</returns>
        protected EdiItem Flush(string segment)
        {
            if (!CurrentSegments.Any()) return null;
            
            var firstSegment = CurrentSegments.First().Value;
            Buffer(segment);
            var result = ParseSegments() ?? new ReaderErrorContext(
                new Exception(string.Format("Invalid control structure beginning with {0}",
                    firstSegment)), ReaderErrorCode.InvalidControlStructure);
            CurrentMessageContext = null;
           
            return result;           
        }

        /// <summary>
        /// Enqueues a string to the internal buffer.
        /// </summary>
        /// <param name="data">The data to buffer.</param>
        protected void Buffer(string data)
        {
            Buffer(data.ToCharArray());
        }    

        private void Buffer(IEnumerable<char> data)
        {
            var existing = new List<char>();

            while (_buffer.Any())
                existing.Add(_buffer.Dequeue());

            foreach (var c in data)
                _buffer.Enqueue(c);

            foreach (var c in existing)
                _buffer.Enqueue(c);
        }
    }
}
