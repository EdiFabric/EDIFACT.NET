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
    /// Parses the messages in the EDI envelope sequentially one by one by reading a single segment at a time.
    /// Can be used for parsing of large files.
    /// </summary>
    /// <example>
    /// Streaming for large files.
    /// <code lang="C#">
    /// using(var es = new EdiStream(File.OpenRead(@"c:\verylarge.edi")))
    /// {
    ///     while (es.GetNextMessage())
    ///     {
    ///         var message = es.Message;
    ///         var header = es.InterchangeHeader;
    ///         var group = es.InterchangeGroup;
    ///     }
    /// }
    /// </code>
    /// </example>
    public class EdiStream : IDisposable
    {
        /// <summary>
        /// The interchange context.
        /// </summary>
        private readonly InterchangeContext _interchangeContext;
        /// <summary>
        /// The stream reader.
        /// </summary>
        private readonly StreamReader _streamReader;
        /// <summary>
        /// The current envelope headers.
        /// Includes the interchange header and the current group header.
        /// </summary>
        private readonly List<string> _envelope = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiStream"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream.</param>
        /// <param name="definitionsAssemblyName">The optional assembly name for the class definitions.</param>
        public EdiStream(Stream ediStream, string definitionsAssemblyName = null)
        {
            _streamReader = new StreamReader(ediStream);
            _interchangeContext = new InterchangeContext(ExtractHeader(), definitionsAssemblyName);
            ediStream.Position = 0;
            _streamReader.DiscardBufferedData();
        }

        /// <summary>
        /// The current message
        /// </summary>
        public Message Message { get; private set; }
        /// <summary>
        /// The interchange header
        /// </summary>
        public object InterchangeHeader { get; private set; }
        /// <summary>
        /// The current group header
        /// </summary>
        public object InterchangeGroup { get; private set; }

        /// <summary>
        /// Reads the next message in the EDI stream.
        /// </summary>
        /// <returns>If reached the end of the stream.</returns>
        /// <example>
        /// This sample shows how to call the <see cref="GetNextMessage"/> method.
        /// <code lang="C#">
        /// using(var es = new EdiStream(File.OpenRead(@"c:\verylarge.edi")))
        /// {
        ///     while (es.GetNextMessage())
        ///     {
        ///         var message = es.Message;
        ///         var header = es.InterchangeHeader;
        ///         var group = es.InterchangeGroup;
        ///     }
        /// }
        /// </code>
        /// </example>
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
            return string.Concat(header);
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
