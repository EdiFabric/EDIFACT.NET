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

namespace EdiFabric.Framework
{
    /// <summary>
    /// Parses EDI messages into .NET object.
    /// </summary>
    public class EdiReader : IDisposable
    {
        private readonly Separators _separators;
        private readonly StreamReader _streamReader;
        private readonly string _definitionsAssemblyName;
        private SegmentContext _interchangeHeader;
        private SegmentContext _groupHeader;

        /// <summary>
        /// The EDI message containing the parsed object and the group and interchange headers
        /// </summary>
        public EdiMessage Message { get; private set; }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="EdiReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream.</param>
        /// <param name="definitionsAssemblyName">The full assembly name of the assembly with the definition classes.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns></returns>
        public static EdiReader Create(Stream ediStream, string definitionsAssemblyName, Encoding encoding = null)
        {
            return new EdiReader(ediStream, definitionsAssemblyName, encoding);
        }

        private EdiReader(Stream ediStream, string definitionsAssemblyName, Encoding encoding)
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
                    case SegmentTags.Una:
                    case SegmentTags.Unz:
                    case SegmentTags.Iea:
                    case SegmentTags.Une:
                    case SegmentTags.Ge:
                        break;
                    case SegmentTags.Unb:
                    case SegmentTags.Isa:
                        _interchangeHeader = segmentContext;
                        break;
                    case SegmentTags.Ung:
                    case SegmentTags.Gs:
                        _groupHeader = segmentContext;
                        break;
                    case SegmentTags.Unt:
                    case SegmentTags.Se:
                        currentMessage.Add(segmentContext);
                        currentMessage.Add(_groupHeader);
                        var msg = currentMessage.Analyze(_separators, _definitionsAssemblyName);
                        var iHeader = _interchangeHeader.ParseHeaderSegment(_separators);
                        var gHeader = _groupHeader.ParseHeaderSegment(_separators);
                        Message = new EdiMessage(msg, iHeader, gHeader);
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
        public IEnumerable<EdiMessage> ReadAllMessages()
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
