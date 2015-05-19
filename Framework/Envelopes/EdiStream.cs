using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Framework.Messages;

namespace EdiFabric.Framework.Envelopes
{
    public class EdiStream : IDisposable
    {
        private readonly InterchangeContext _interchangeContext;
        private readonly StreamReader _streamReader;
        public Message Item;
        private readonly List<string> _envelope = new List<string>();

        public EdiStream(Stream ediStream)
        {
            _streamReader = new StreamReader(ediStream);
            _interchangeContext = new InterchangeContext(_streamReader);
            ediStream.Position = 0;
            _streamReader.DiscardBufferedData();
        }

        public bool GetNextMessage()
        {
            var message = new List<string>();
            
            var result = false;

            while (_streamReader.Peek() >= 0 && !result)
            {
                var segment = _streamReader.ReadSegment(_interchangeContext.ReleaseIndicator, _interchangeContext.SegmentTerminator);
                switch (EdiHelper.GetSegmentName(segment, _interchangeContext))
                {
                    case EdiSegments.Una:
                        break;
                    case EdiSegments.Unb:
                    case EdiSegments.Isa:
                        break;
                    case EdiSegments.Unz:
                    case EdiSegments.Iea:
                        break;
                    case EdiSegments.Ung:
                        break;
                    case EdiSegments.Gs:
                        _envelope.Add(segment);
                        break;
                    case EdiSegments.Une:
                    case EdiSegments.Ge:
                        _envelope.Clear();
                        break;
                    case EdiSegments.Unh:
                    case EdiSegments.St:
                        message.Add(segment);
                        _envelope.Add(segment);
                        break;
                    case EdiSegments.Unt:
                    case EdiSegments.Se:
                        message.Add(segment);
                        Item = MessageLexer.Analyze(message, _envelope, _interchangeContext);
                        result = true;
                        // For X12 the ST segment is included in the headers
                        // Once the message is parsed - it's removed
                        _envelope.Remove(_envelope.Last());
                        message.Clear();
                        break;
                    default:
                        message.Add(segment);
                        break;  
                }
            }

            return result;
        }

        public void Dispose()
        {
            if (_streamReader != null)
                _streamReader.Dispose();
        }
    }
}
