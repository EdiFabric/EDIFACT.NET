using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Framework.Envelopes;
using EdiFabric.Framework.Envelopes.Edifact;
using EdiFabric.Framework.Envelopes.X12;
using EdiFabric.Framework.Messages;
using EdiFabric.Framework.Messages.Segments;

namespace EdiFabric.Framework
{
    /// <summary>
    /// Streaming for large files
    /// </summary>
    public class EdiStream : IDisposable
    {
        private readonly InterchangeContext _interchangeContext;
        private readonly StreamReader _streamReader;
        private readonly List<string> _envelope = new List<string>();

        public EdiStream(Stream ediStream, string definitionsAssemblyName = null)
        {
            _streamReader = new StreamReader(ediStream);
            _interchangeContext = new InterchangeContext(_streamReader, definitionsAssemblyName);
            ediStream.Position = 0;
            _streamReader.DiscardBufferedData();
        }

        public Message Message { get; private set; }
        public object InterchangeHeader { get; private set; }
        public object InterchangeGroup { get; private set; }

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
                        InterchangeHeader = SegmentParser.ParseLine<S_UNB>(segment, _interchangeContext).Deserialize<S_UNB>();
                        break;
                    case EdiSegments.Isa:
                        InterchangeHeader = SegmentParser.ParseLine<S_ISA>(segment, _interchangeContext).Deserialize<S_ISA>();
                        break;
                    case EdiSegments.Unz:
                    case EdiSegments.Iea:
                        break;
                    case EdiSegments.Ung:
                        InterchangeGroup = SegmentParser.ParseLine<S_UNG>(segment, _interchangeContext).Deserialize<S_UNG>();
                        break;
                    case EdiSegments.Gs:
                        InterchangeGroup = SegmentParser.ParseLine<S_GS>(segment, _interchangeContext).Deserialize<S_GS>();
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
                        Message = MessageLexer.Analyze(message, _envelope, _interchangeContext);
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
