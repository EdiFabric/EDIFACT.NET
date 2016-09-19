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
using System.Text;
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Parses EDI messages into .NET object.
    /// </summary>
    public class EdiReader<T, TU> : IDisposable
    {
        private readonly Separators _separators;
        private readonly StreamReader _streamReader;
        private readonly string _definitionsAssemblyName;
        private SegmentContext _interchangeHeader;
        private SegmentContext _groupHeader;

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
            _streamReader = new StreamReader(ediStream.ToSeekStream(), encoding ?? Encoding.Default, false);
            _separators = new Separators(ExtractHeader());
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
                var segment = _streamReader.ReadSegment(_separators);
                var segmentContext = new SegmentContext(segment, _separators);

                switch (segmentContext.Tag)
                {
                    case SegmentTags.UNA:
                    case SegmentTags.UNZ:
                    case SegmentTags.IEA:
                    case SegmentTags.UNE:
                    case SegmentTags.GE:
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
                        var messageInstance = currentMessage.Analyze(_separators, _definitionsAssemblyName);
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

        private string ExtractHeader()
        {
            var header = new char[106];
            _streamReader.Read(header, 0, header.Length);
            var result = string.Concat(header);
            _streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            _streamReader.DiscardBufferedData();
            return result;
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
