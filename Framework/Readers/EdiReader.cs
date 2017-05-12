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
using EdiFabric.Core.Annotations.Edi;
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
    public abstract class EdiReader : IDisposable
    {
        private readonly Func<MessageContext, Assembly> _rulesAssembly;
        private readonly Queue<char> _buffer;
        private readonly StreamReader _streamReader;
        private char[] _trims;
        
        /// <summary>
        /// The current list of segments.
        /// </summary>
        protected List<SegmentContext> CurrentSegments { get; private set; }
        
        /// <summary>
        /// EDI separators.
        /// </summary>
        public Separators Separators { get; private set; }

        /// <summary>
        /// The last item that was read.
        /// </summary>
        public IEdiItem Item { get; protected set; }
        
        /// <summary>
        /// Indicates whether the current stream position is at the end of the stream.
        /// </summary>
        public bool EndOfStream
        {
            get { return _streamReader.EndOfStream; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssembly">The name of the assembly containing the EDI classes.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        protected EdiReader(Stream ediStream, string rulesAssembly, Encoding encoding)
        {
            if (ediStream == null) throw new ArgumentNullException("ediStream");
            if (string.IsNullOrEmpty(rulesAssembly)) throw new ArgumentNullException("rulesAssembly");
            
            _streamReader = new StreamReader(ediStream, encoding ?? Encoding.Default, true);
            _rulesAssembly = mc => Assembly.Load(rulesAssembly); 
            CurrentSegments = new List<SegmentContext>();
            _buffer = new Queue<char>();
            _trims = new[] { '\r', '\n', ' ' };        
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssembly">The delegate to return the assembly containing the EDI classes.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        protected EdiReader(Stream ediStream, Func<MessageContext, Assembly> rulesAssembly, Encoding encoding)
        {
            if (ediStream == null) throw new ArgumentNullException("ediStream");
            if (rulesAssembly == null) throw new ArgumentNullException("rulesAssembly");

            _streamReader = new StreamReader(ediStream, encoding ?? Encoding.Default, true);
            _rulesAssembly = rulesAssembly;   
            CurrentSegments = new List<SegmentContext>();
            _buffer = new Queue<char>();
            _trims = new[] { '\r', '\n', ' ' };
        }

        /// <summary>
        /// Reads an EDI item from the stream.
        /// An EDI item is an IEdiControl or a message or a ParsingException.
        /// </summary>
        /// <returns>Indication if an item was read.</returns>
        public bool Read()
        {
            Item = null;
           
            try
            {
                while ((!_streamReader.EndOfStream || _buffer.Any()) && Item == null)
                {
                    var segment = ReadSegment();

                    if (Separators == null)
                    {
                        Item = new ReaderErrorContext(ReaderErrorCode.InvalidControlStructure);
                        continue;
                    }

                    if(string.IsNullOrEmpty(segment))
                        continue;

                    ProcessSegment(segment);
                }               
            }
            catch (ReaderException ex)
            {
                Item = new ReaderErrorContext(ex, ex.ErrorCode);
            }
            catch (Exception ex)
            {
                Item = new ReaderErrorContext(ex, ReaderErrorCode.Unknown);
            }

            if (_streamReader.EndOfStream && CurrentSegments.Any())
                Item = new ReaderErrorContext(ReaderErrorCode.ImproperEndOfFile);

            if (Item is ReaderErrorContext || Item is MessageErrorContext)
                CurrentSegments.Clear();

            return Item != null;
        }

        /// <summary>
        /// Reads the stream to the end.
        /// </summary>
        /// <returns>All items that were found in the stream.</returns>
        public IEnumerable<object> ReadToEnd()
        {
            while (Read())
            {
                yield return Item;
            }
        }

        /// <summary>
        /// Probes for interchange header.
        /// Sets the separators if header was found.
        /// </summary>
        /// <param name="segmentName">The probed segment name.</param>
        /// <param name="probed">The probed text.</param>
        /// <param name="separators">The new separators.</param>
        /// <returns>Indicates if an interchange header was found.</returns>
        protected abstract bool TryReadHeader(string segmentName, out string probed, out Separators separators);

        /// <summary>
        /// Converts EDI segments into typed objects. 
        /// </summary>
        /// <param name="segment">The segment to be processed.</param>
        protected abstract void ProcessSegment(string segment);

        /// <summary>
        /// Extracts the format, the version and the tag of the EDI document.
        /// </summary>
        /// <returns>The message context.</returns>
        protected abstract MessageContext BuildContext();
        
        /// <summary>
        /// Reads from the stream until a non-escaped segment terminator was reached.
        /// Breaks if no segment terminator was encountered after 10000 symbols were read. 
        /// This is to avoid loading large and corrupt files. 
        /// </summary>
        /// <returns>
        /// An EDI segment.
        /// </returns>
        private string ReadSegment()
        {
            var line = "";
            while (!_streamReader.EndOfStream || _buffer.Any())
            {
                var symbol = _buffer.Any()
                    ? _buffer.Dequeue().ToString()
                    : Read(1);

                line = line + symbol;
                if (line.Length > 2)
                {
                    var last3 = line.Substring(line.Length - 3);
                    Separators separators;
                    string probed;
                    if (TryReadHeader(last3, out probed, out separators))
                    {
                        Separators = separators;
                        _trims = _trims.Except(new[] {Separators.Segment}).ToArray();
                        line = probed;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(probed))
                            Buffer(probed.Skip(3));                            
                    }
                }

                // Segment terminator may never be reached
                if (line.Count() > 5000)
                {
                    line = "";
                    continue;
                }

                if (Separators == null)
                    continue;

                if (!line.EndsWith(Separators.Segment.ToString(), StringComparison.Ordinal)) 
                    continue;

                if (Separators.Escape.HasValue &&
                    line.EndsWith(string.Concat(Separators.Escape.Value, Separators.Segment),
                        StringComparison.Ordinal))
                    continue;

                var index = line.LastIndexOf(Separators.Segment.ToString(), StringComparison.Ordinal);
                if (index > 0)
                    line = line.Remove(index);

                if (!string.IsNullOrEmpty(line))
                    break;
            }

            return line.Trim(_trims);
        }

        /// <summary>
        /// Parses the accumulated segments.
        /// </summary>
        protected void ParseSegments()
        {
            var messageContext = BuildContext();
            try
            {
                var message = new TransactionSet(GetType(messageContext));
                message.Analyze(CurrentSegments, Separators);
                Item = (EdiMessage) message.ToInstance();
            }
            catch (SegmentException ex)
            {
                var errorContext = new MessageErrorContext(messageContext.Name, messageContext.ControlNumber, ex.Message);
                errorContext.Add(ex.ErrorContext);
                Item = errorContext;
            }
            catch (MessageException ex)
            {
                var errorContext = new MessageErrorContext(messageContext.Name, messageContext.ControlNumber, ex.Message,
                    ex.ErrorCode);
                Item = errorContext;
            }
            catch (Exception ex)
            {
                var errorContext = new MessageErrorContext(messageContext.Name, messageContext.ControlNumber, ex.Message,
                    MessageErrorCode.MessageWithErrors);
                Item = errorContext;
            }
            finally
            {
                CurrentSegments.Clear();
            }
        }

        /// <summary>
        /// Enqueues a string to the internal buffer.
        /// </summary>
        /// <param name="data">The data to buffer.</param>
        protected void Buffer(string data)
        {
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
            while (counter < bytes && !_streamReader.EndOfStream)
            {
                var symbol = Read(1).Trim(_trims);
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
            var result = new char[bytes];
            _streamReader.Read(result, 0, result.Length);
            return String.Concat(result);
        }

        /// <summary>
        /// Parses a segment.
        /// </summary>
        /// <param name="segmentValue">The segment string.</param>
        /// <param name="separators">The separators.</param>
        /// <typeparam name="T">The type of segment.</typeparam>
        /// <returns>The parsed segment.</returns>
        protected static T ParseSegment<T>(string segmentValue, Separators separators)
        {
            var parseNode = new Segment(typeof(T));
            try
            {
                parseNode.Parse(segmentValue, separators);
            }
            catch (Exception ex)
            {
                if(typeof(T).Name == "ISA" || typeof(T).Name == "UNB" || typeof(T).Name == "UNA")
                    throw new ReaderException(ex.Message, ReaderErrorCode.InvalidControlStructure);

                throw new ReaderException(ex.Message, ReaderErrorCode.InvalidInterchangeContent);
            }
            
            return (T)parseNode.ToInstance();
        }
        
        /// <summary>
        /// Disposes the reader.
        /// </summary>
        public void Dispose()
        {
            if (_streamReader != null)
                _streamReader.Dispose();
        }

        private Type GetType(MessageContext messageContext)
        {
            Assembly assembly;
            try
            {
                assembly = _rulesAssembly(messageContext);
            }
            catch (Exception ex)
            {
                throw new MessageException(ex.Message, MessageErrorCode.TransactionSetNotSupported);
            }

            var matches = assembly.GetTypes().Where(m =>
            {
                var att = ((MessageAttribute)m.GetCustomAttribute(typeof(MessageAttribute)));
                if (att == null) return false;
                return att.Format == messageContext.Format && att.Version == messageContext.Version && att.Id == messageContext.Name;
            }).ToList();

            var attribute = "[Message(" + messageContext.Format + ", " + messageContext.Version + ", " + messageContext.Name + ")]";

            if (!matches.Any())
            {
                var msg = String.Format("Type with attribute'{0}' was not found in assembly '{1}'.", attribute,
                    assembly.FullName);

                throw new MessageException(msg, MessageErrorCode.TransactionSetNotSupported);
            }

            if (matches.Count > 1)
            {
                var msg = String.Format("Multiple types with attribute'{0}' were found in assembly '{1}'.", attribute,
                    assembly.FullName);

                throw new MessageException(msg, MessageErrorCode.TransactionSetNotSupported);
            }

            return matches.First();
        }

        private void Buffer(IEnumerable<char> data)
        {
            foreach (var c in data)
                _buffer.Enqueue(c);
        }
    }
}
