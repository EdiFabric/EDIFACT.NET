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
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Parses EDI messages into .NET object.
    /// </summary>
    /// <typeparam name="T">The type of the interchange header.</typeparam>
    /// <typeparam name="TU">The type of the group header.</typeparam>
    public class EdiReader<T, TU> : IDisposable
    {
        private readonly StreamReader _streamReader;
        private readonly string _rulesAssemblyName;
        private readonly string _rulesNamespacePrefix;
        private Separators _separators;
        private SegmentContext _interchangeHeader;
        private SegmentContext _groupHeader;
        private char[] _trims = { '\r', '\n', ' ' };

        /// <summary>
        /// The EDI message containing the parsed object and the group and interchange headers
        /// </summary>
        public EdiMessage<T, TU> Message { get; private set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EdiReader{T, TU}"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssemblyName">The full assembly name of the assembly containing the EDI classes. The default is Edifabric.Rules.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <param name="rulesNamespacePrefix">The namespace prefix for the EDI classes. The default is Edifabric.Rules.</param>
        protected EdiReader(Stream ediStream, string rulesAssemblyName, Encoding encoding, string rulesNamespacePrefix)
        {
            if (ediStream == null) throw new ArgumentNullException("ediStream");

            _streamReader = new StreamReader(ediStream, encoding ?? Encoding.Default, true);
            _rulesAssemblyName = rulesAssemblyName;
            _rulesNamespacePrefix = rulesNamespacePrefix;
        }

        /// <summary>
        /// Reads an EDI message from the stream.
        /// </summary>
        /// <returns>If a new message was read.</returns>
        public bool ReadMessage()
        {
            var currentMessage = new List<SegmentContext>();
            var result = false;
            
            while (_streamReader.Peek() >= 0 && !result)
            {
                var currentSegment = ReadSegment();
                if (string.IsNullOrEmpty(currentSegment)) break;
                
                var segmentContext = new SegmentContext(currentSegment, _separators);
                switch (segmentContext.Tag)
                {
                    case SegmentTags.UNA:
                        break;
                    case SegmentTags.UNZ:
                    case SegmentTags.IEA:
                        _interchangeHeader = null;
                        _separators = null;
                        break;
                    case SegmentTags.UNE:
                    case SegmentTags.GE:
                        _groupHeader = null;
                        break;
                    case SegmentTags.UNB:
                    case SegmentTags.ISA:
                        _interchangeHeader = segmentContext;
                        break;
                    case SegmentTags.UNG:
                    case SegmentTags.GS:
                        _groupHeader = segmentContext;
                        break;
                    case SegmentTags.UNT:
                    case SegmentTags.SE:
                        currentMessage.Add(segmentContext);
                        if (segmentContext.Tag == SegmentTags.SE)
                            currentMessage.Add(_groupHeader);
                        Message = ReadMessage(segmentContext, currentMessage);
                        result = true;
                        currentMessage.Clear();
                        break;
                    default:
                        currentMessage.Add(segmentContext);
                        break;
                }
            }

            return result;
        }

        /// <summary>
        /// Reads the stream to the end.
        /// </summary>
        /// <returns>All the messages that were read.</returns>
        public IEnumerable<EdiMessage<T, TU>> ReadAllMessages()
        {
            while (ReadMessage())
            {
                yield return Message;
            }
        }

        private string ReadSegment()
        {
            var first3 = _streamReader.Read(3, _trims);
            if (string.IsNullOrEmpty(first3)) return null;
            var header = _streamReader.ReadHeader(first3);
            if (header.Item2 != null && _separators == null)
            {
                _separators = header.Item2;
                _trims = _trims.Except(new[] {_separators.Segment}).ToArray();
            }

            if (_separators == null)
                throw new ParserException(
                    string.Format("Invalid EDI message. The first segment must be either {0} or {1} or {2}.",
                        SegmentTags.UNA, SegmentTags.UNB, SegmentTags.ISA));

            return header.Item1 ?? first3 + _streamReader.ReadSegment(_separators);
        }

        private EdiMessage<T, TU> ReadMessage(SegmentContext segmentContext, List<SegmentContext> currentMessage)
        {
            var type = segmentContext.Tag == SegmentTags.SE
                ? currentMessage.ToX12Type(_separators, _rulesAssemblyName, _rulesNamespacePrefix)
                : currentMessage.ToEdifactType(_separators, _rulesAssemblyName, _rulesNamespacePrefix);
            var messageInstance = currentMessage.Analyze(_separators, type, _rulesAssemblyName);

            return new EdiMessage<T, TU>(messageInstance,
                _interchangeHeader.ParseSegment<T>(_separators),
                _groupHeader != null ? _groupHeader.ParseSegment<TU>(_separators) : default(TU), _separators);
        }

        /// <summary>
        /// Disposes the reader.
        /// </summary>
        public void Dispose()
        {
            if (_streamReader != null)
                _streamReader.Dispose();
        }
    }
}
