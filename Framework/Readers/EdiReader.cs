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
    public class EdiReader<T, TU> : IDisposable
    {
        private readonly StreamReader _streamReader;
        private readonly string _definitionsAssemblyName;
        private Separators _separators;
        private SegmentContext _interchangeHeader;
        private SegmentContext _groupHeader;
        private char[] _trims = new[] { '\r', '\n' };

        /// <summary>
        /// The EDI message containing the parsed object and the group and interchange headers
        /// </summary>
        public EdiMessage<T, TU> Message { get; private set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EdiReader{T, TU}"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream.</param>
        /// <param name="definitionsAssemblyName">The full assembly name of the assembly with the definition classes.</param>
        /// <param name="encoding">The encoding.</param>
        protected EdiReader(Stream ediStream, string definitionsAssemblyName, Encoding encoding)
        {
            _streamReader = new StreamReader(ediStream.ToSeekStream(), encoding ?? Encoding.Default, true);
            _definitionsAssemblyName = definitionsAssemblyName;
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
                var first3 = _streamReader.Read(3, _trims);
                var header = _streamReader.ReadHeader(first3);
                if (header.Item2 != null && _separators == null)
                {
                    _separators = header.Item2;
                    _trims = _trims.Except(_separators.Segment.ToCharArray()).ToArray();
                }

                if(_separators == null)
                    throw new ParserException(
                        string.Format("Invalid EDI message. The first segment must be one of {0}, {1}, {2}.", SegmentTags.UNA,
                            SegmentTags.UNB, SegmentTags.ISA));               

                var segment = header.Item1 ?? first3 + _streamReader.ReadSegment(_separators);
                var segmentContext = new SegmentContext(segment, _separators);
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
                        if (_groupHeader != null)
                            currentMessage.Add(_groupHeader);
                        var type = segmentContext.Tag == SegmentTags.SE
                            ? currentMessage.ToX12Type(_separators, _definitionsAssemblyName)
                            : currentMessage.ToEdifactType(_separators, _definitionsAssemblyName);
                        var messageInstance = currentMessage.Analyze(_separators, _definitionsAssemblyName, type);
                        Message = new EdiMessage<T, TU>(messageInstance,
                            _interchangeHeader.ParseSegment<T>(_separators),
                            _groupHeader != null ? _groupHeader.ParseSegment<TU>(_separators) : default(TU));
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
