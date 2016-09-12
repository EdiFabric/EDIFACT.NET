using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework
{
    public class EdiReader : IDisposable
    {
        private readonly Separators _separators;
        private readonly StreamReader _streamReader;
        private SegmentContext _interchangeHeader;
        private SegmentContext _groupHeader;
        private EdiMessage _message;
        private string _definitionsAssemblyName;
        public EdiMessage Message { get { return _message; } }

        public static EdiReader Create(Stream ediStream, string definitionsAssemblyName, Encoding encoding = null)
        {
            return new EdiReader(ediStream, definitionsAssemblyName, encoding);
        }

        private EdiReader(Stream ediStream, string definitionsAssemblyName, Encoding encoding)
        {
            _streamReader = new StreamReader(ediStream, encoding ?? Encoding.Default, false);
            _separators = new Separators(ExtractHeader());
            _definitionsAssemblyName = definitionsAssemblyName;
        }

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
                        _message = new EdiMessage(msg, _interchangeHeader.Value, _groupHeader.Value);
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

        public IEnumerable<EdiMessage> ReadAllMessages()
        {
            while (ReadMessage())
            {
                yield return Message;
            }
        }

        /// <summary>
        /// Extracts the interchange header from the EDI stream.
        /// </summary>
        /// <returns>
        /// The first 106 chars from the stream.
        /// </returns>
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
        /// Disposes the stream.
        /// </summary>
        public void Dispose()
        {
            if (_streamReader != null)
                _streamReader.Dispose();
        }
    }
}
