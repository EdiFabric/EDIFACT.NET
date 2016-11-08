using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Framework.Constants;
using EdiFabric.Framework.Controls;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Parses X12 messages into .NET objects.
    /// </summary>
    public sealed class X12Reader : EdiReader
    {
        private readonly List<SegmentContext> _currentMessage = new List<SegmentContext>();
        private SegmentContext _currentGs;

        private X12Reader(Stream ediStream, ReaderSettings settings) : base(ediStream, settings)
        {
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="X12Reader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="settings">The additional settings.</param>
        /// <returns>A new instance of the <see cref="X12Reader"/> class.</returns>
        public static X12Reader Create(Stream ediStream, ReaderSettings settings = null)
        {
            return new X12Reader(ediStream, settings ?? new ReaderSettings());
        }

        /// <summary>
        /// Reads an EDI item from the stream.
        /// Items can be: control segment, message or error.
        /// </summary>
        /// <returns>If a new message was read.</returns>
        public override bool Read(Action<object> collect = null)
        {
            Item = null;

            try
            {
                while (StreamReader.Peek() >= 0 && Item == null)
                {
                    var currentSegment = ReadSegment();
                    if (Separators == null || string.IsNullOrEmpty(currentSegment)) break;

                    var segmentContext = new SegmentContext(currentSegment, Separators);
                    switch (segmentContext.Tag)
                    {
                        // X12
                        case SegmentTags.ISA:
                            _currentMessage.Clear();
                            _currentGs = null;
                            Item = segmentContext.Value.ParseSegment<S_ISA>(Separators);
                            break;
                        case SegmentTags.GS:
                            _currentMessage.Clear();
                            _currentGs = segmentContext;
                            Item = segmentContext.Value.ParseSegment<S_GS>(Separators);
                            break;
                        case SegmentTags.ST:
                            if (_currentMessage.Any(s => !s.IsControl))
                            {
                                _currentMessage.Add(_currentGs);
                                Item = ParseMessage(_currentMessage);
                                _currentMessage.Clear();
                            }
                            _currentMessage.Add(segmentContext);
                            break;
                        case SegmentTags.SE:
                            _currentMessage.Add(segmentContext);
                            _currentMessage.Add(_currentGs);
                            Item = ParseMessage(_currentMessage);
                            _currentMessage.Clear();
                            break;
                        case SegmentTags.GE:
                            _currentMessage.Clear();
                            _currentGs = null;
                            Item = segmentContext.Value.ParseSegment<S_GE>(Separators);
                            break;
                        case SegmentTags.IEA:
                            _currentMessage.Clear();
                            _currentGs = null;
                            Item = segmentContext.Value.ParseSegment<S_IEA>(Separators);
                            Separators = null;
                            break;
                        default:
                            _currentMessage.Add(segmentContext);
                            break;
                    }
                }

                if (StreamReader.EndOfStream && _currentMessage.Any(s => !s.IsControl))
                    throw new ParsingException(ErrorCodes.ImproperEndOfFile);
            }
            catch (ParsingException ex)
            {
                Item = ex;
                _currentMessage.Clear();
            }
            catch (Exception ex)
            {
                Item = new ParsingException(ErrorCodes.Unknown, ex.Message, ex);
                _currentMessage.Clear();
            }

            if (collect != null && Item != null) collect(Item);

            return Item != null;
        }

        private object ParseMessage(List<SegmentContext> currentMessage)
        {
            try
            {
                var type = currentMessage.ToX12Type(Separators, RulesAssemblyName, RulesNamespacePrefix);
                return currentMessage.Analyze(Separators, type, RulesAssemblyName);
            }
            catch (Exception ex)
            {
                return new ParsingException(ErrorCodes.Unknown, ex.Message, ex);
            }
        }

        protected override bool TryReadControl(string segmentName, out string probed)
        {
            probed = "";

            try
            {
                if (segmentName == "ISA")
                {
                    var dataElement = StreamReader.Read(1)[0];
                    var isa = StreamReader.ReadIsa(dataElement);
                    probed = segmentName + dataElement + isa;
                    var isaElements = isa.Split(dataElement);
                    if (isaElements.Length != 16)
                        throw new Exception("ISA is invalid. Too little data elements.");
                    if (isaElements[15].Count() != 2)
                        throw new Exception("ISA is invalid. Segment terminator was not found.");
                    var componentDataElement = isaElements[15].First();
                    char? repetitionDataElement = null;
                    if (isaElements[10].First() != 'U')
                        repetitionDataElement = isaElements[10].First();
                    var segment = isaElements[15].Last();

                    Separators = Separators.SeparatorsX12(segment, componentDataElement, dataElement,
                        repetitionDataElement);
                    
                    return true;
                }
            }
            catch
            {
                // ignored
            }
            
            return false;
        }
    }
}
