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
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Model;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// The base reader.
    /// </summary>
    public abstract class BaseReader : IDisposable
    {
        protected readonly Queue<char> InternalBuffer;
        protected readonly StreamReader StreamReader;
        protected char[] Trims;
        protected readonly bool ContinueOnError;
        protected readonly int MaxSegmentLength;

        /// <summary>
        /// The currently accumulated segments.
        /// </summary>
        protected List<SegmentContext> CurrentSegments { get; private set; }
        protected MessageContext CurrentMessageContext;
        protected int SegmentIndex;
        protected int PartsIndex;

        /// <summary>
        /// EDI separators.
        /// </summary>
        public Separators Separators { get; protected set; }
       
        /// <summary>
        /// The last item that was read.
        /// </summary>
        public EdiItem Item { get; protected set; }
        
        /// <summary>
        /// Indicates whether the current stream position is at the end of the stream.
        /// </summary>
        public bool EndOfStream
        {
            get { return StreamReader.EndOfStream; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseReader"/> class.
        /// </summary>
        /// <param name="ediStream">The stream to read from.</param>
        /// <param name="encoding">The encoding. The default is UTF8.</param>
        /// <param name="continueOnError">Whether to continue searching for valid data after an error occurs.</param>
        /// <param name="maxSegmentLength">The maximum length of a segment after which the search for segment terminator seizes.</param>
        protected BaseReader(Stream ediStream, Encoding encoding, bool continueOnError, int maxSegmentLength)
        {
            if (ediStream == null) throw new ArgumentNullException("ediStream");
            
            StreamReader = new StreamReader(ediStream, encoding ?? Encoding.UTF8, true);
            CurrentSegments = new List<SegmentContext>();
            InternalBuffer = new Queue<char>();
            Trims = new[] {'\r', '\n', ' '};
            ContinueOnError = continueOnError;
            MaxSegmentLength = maxSegmentLength;
        }

        /// <summary>
        /// Reads an item from the stream.
        /// </summary>
        /// <returns>Indication if an item was read.</returns>
        public abstract bool Read();

        /// <summary>
        /// Converts EDI segments into typed objects. 
        /// </summary>
        /// <param name="segment">The segment to be processed.</param>
        protected abstract EdiItem Process(string segment);
        
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
        /// Disposes the reader.
        /// </summary>
        public void Dispose()
        {
            if (StreamReader != null)
                StreamReader.Dispose();
        }

        /// <summary>
        /// Reads from the stream until a non-escaped segment terminator was reached.
        /// Breaks if no segment terminator was encountered after the max segment length symbols were read. 
        /// This is to avoid loading large and corrupt files. 
        /// </summary>
        /// <returns>
        /// The segment.
        /// </returns>
        protected abstract string ReadSegment();
        
        /// <summary>
        /// Splits a message by a regex match on segment.
        /// </summary>
        /// <param name="segment">The segment to match.</param>
        /// <returns>The message part.</returns>
        protected EdiItem Split(string segment)
        {
            if (CurrentMessageContext == null ||
                string.IsNullOrEmpty(CurrentMessageContext.SplitterRegex) ||
                CurrentSegments.Count == 0 ||
                !Regex.IsMatch(segment, CurrentMessageContext.SplitterRegex))
                return null;

            PartsIndex++;
            Buffer(segment + Separators.Segment);
            return ParseSegments();
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
                var errorContext = message.Analyze(CurrentSegments, CurrentMessageContext, Separators, PartsIndex,
                    SegmentIndex);

                var ediMessage = (EdiMessage) message.ToInstance();
                ediMessage.MessagePart = PartsIndex;
                ediMessage.ControlNumber = CurrentMessageContext.ControlNumber;
                ediMessage.ErrorContext = errorContext;
                result = ediMessage;
            }
            catch (Exception ex)
            {
                result = new ReaderErrorContext(ex, ReaderErrorCode.InvalidSpecOrAssembly,
                    new MessageErrorContext(CurrentMessageContext.Name,
                        CurrentMessageContext.ControlNumber, CurrentMessageContext.Version, PartsIndex, ex.Message,
                        MessageErrorCode.MissingOrInvalidTransactionSet));
            }
            finally
            {
                SegmentIndex = SegmentIndex + CurrentSegments.Count;
                CurrentSegments.Clear();
            }

            return result;
        }

        /// <summary>
        /// Enqueues a string to the internal buffer.
        /// </summary>
        /// <param name="data">The data to buffer.</param>
        protected void Buffer(string data)
        {
            if(!string.IsNullOrEmpty(data))
                Buffer(data.ToCharArray());
        }        

        /// <summary>
        /// Reads number of bytes from the stream.
        /// Skips over any known trim symbol.
        /// </summary>
        /// <param name="bytes">The number of bytes.</param>
        /// <returns>The string read from the stream.</returns>
        protected string ReadWithTrims(int bytes)
        {
            string result = null;
            var counter = 0;
            while (counter < bytes && !StreamReader.EndOfStream)
            {
                var symbol = Read(1).Trim(Trims);
                if (!String.IsNullOrEmpty(symbol))
                    counter += 1;
                result += symbol;
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
                if (InternalBuffer.Count > 0)
                    result += InternalBuffer.Dequeue().ToString();
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
            StreamReader.Read(result, 0, result.Length);
            return String.Concat(result);
        }

        /// <summary>
        /// Parses a segment.
        /// </summary>
        /// <param name="segmentValue">The segment string.</param>
        /// <param name="separators">The separators.</param>
        /// <typeparam name="T">The type of segment.</typeparam>
        /// <returns>The parsed segment.</returns>
        protected T ParseSegment<T>(string segmentValue, Separators separators) where T : EdiItem
        {
            var parseNode = new Segment(typeof(T).GetTypeInfo());
            try
            {
                parseNode.Parse(segmentValue, separators, false);
            }
            catch (Exception ex)
            {
                throw new ReaderException(ex.Message, ReaderErrorCode.InvalidInterchangeContent);
            }
            
            return (T)parseNode.ToInstance();
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
            if (Separators != null)
                Buffer(segment + Separators.Segment);
            else
                Buffer(segment);
            
            var result = ParseSegments() ?? new ReaderErrorContext(
                new Exception(string.Format("Invalid control structure beginning with {0}",
                    firstSegment)), ReaderErrorCode.InvalidControlStructure);
            CurrentMessageContext = null;
            SegmentIndex = 0;
            PartsIndex = 0;

            return result;           
        }

        /// <summary>
        /// Adds data to the internal buffer.
        /// If the buffer is not empty, the new data will be pushed before any existing data.
        /// </summary>
        /// <param name="data">The data to add.</param>
        protected void Buffer(IEnumerable<char> data)
        {
            var existing = new List<char>();

            while (InternalBuffer.Any())
                    existing.Add(InternalBuffer.Dequeue());

            foreach (var c in data)
                InternalBuffer.Enqueue(c);

            foreach (var c in existing)
                InternalBuffer.Enqueue(c);
        }
    }
}
