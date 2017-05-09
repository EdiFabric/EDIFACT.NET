
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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Framework.Model;
using EdiFabric.Framework.Segments.X12;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Reads X12 documents into .NET objects.
    /// </summary>
    public sealed class X12Reader : EdiReader
    {
        private SegmentContext _currentGroupHeader;
        private ISA _currentIsa;

        /// <summary>
        /// Initializes a new instance of the <see cref="X12Reader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssembly">The name of the assembly containing the EDI classes.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <returns>A new instance of the <see cref="X12Reader"/> class.</returns>
        public X12Reader(Stream ediStream, string rulesAssembly, Encoding encoding = null)
            : base(ediStream, rulesAssembly, encoding)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="X12Reader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssembly">The delegate to return the assembly containing the EDI classes.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <returns>A new instance of the <see cref="X12Reader"/> class.</returns>
        
        public X12Reader(Stream ediStream, Func<MessageContext, Assembly> rulesAssembly, Encoding encoding = null)
            : base(ediStream, rulesAssembly, encoding)
        {
        }

        protected override bool TryReadHeader(string segmentName, out string probed, out Separators separators)
        {
            probed = "";
            separators = null;

            try
            {
                if (segmentName == "ISA")
                {
                    var dataElement = Read(1)[0];
                    var isa = Read(102);
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

                    separators = new Separators(segment, componentDataElement, dataElement,
                        repetitionDataElement, null);

                    return true;
                }
            }
            catch
            {
                // ignored
            }

            return false;
        }

        protected override void ProcessSegment(string segment)
        {
            var segmentContext = new SegmentContext(segment, Separators);
            switch (segmentContext.Name)
            {
                case "ISA":
                case "GS":
                case "ST":
                case "GE":
                case "IEA":
                    if (CurrentSegments.Any())
                    {
                        Buffer(segment + Separators.Segment);
                        ParseSegments();
                        return;
                    }
                    break;
            }

            switch (segmentContext.Name)
            {
                case "ISA":
                    var isa = ParseSegment<ISA>(segmentContext.Value, Separators);
                    _currentIsa = isa;
                    Item = isa;
                    _currentGroupHeader = null;
                    break;
                case "TA1":
                    Item = ParseSegment<TA1>(segmentContext.Value, Separators);
                    _currentGroupHeader = null;
                    break;
                case "GS":
                    Item = ParseSegment<GS>(segmentContext.Value, Separators);
                    _currentGroupHeader = segmentContext;
                    break;
                case "ST":
                    CurrentSegments.Add(segmentContext);                   
                    break;
                case "SE":
                    CurrentSegments.Add(segmentContext);
                    ParseSegments();
                    break;
                case "GE":
                    Item = ParseSegment<GE>(segmentContext.Value, Separators);
                    _currentGroupHeader = null;
                    break;
                case "IEA":
                    Item = ParseSegment<IEA>(segmentContext.Value, Separators);
                    _currentGroupHeader = null;
                    _currentIsa = null;
                    break;
                default:
                    CurrentSegments.Add(segmentContext);
                    break;
            }
        }

        protected override MessageContext BuildContext()
        {
            if (_currentIsa == null)
                throw new ParsingException(ErrorCode.InvalidInterchangeContent, "Interchange header is missing.");

            if (CurrentSegments.Count == 1)
            {
                var ta1 = CurrentSegments.SingleOrDefault(es => es.Name == "TA1");
                if (ta1 != null)
                {
                    return new MessageContext("TA1", "", "", "X12", _currentIsa.InterchangeSenderID_6,
                        _currentIsa.SenderIDQualifier_5, _currentIsa.InterchangeReceiverID_8,
                        _currentIsa.ReceiverIDQualifier_7);
                }
            }

            if (_currentGroupHeader == null)
                throw new ParsingException(ErrorCode.InvalidInterchangeContent, "GS was not found.");
            var ediCompositeDataElementsGs = _currentGroupHeader.Value.GetDataElements(Separators);
            if (ediCompositeDataElementsGs.Count() < 8)
                throw new ParsingException(ErrorCode.InvalidInterchangeContent,
                    "GS is invalid. Too little data elements.");
            var version = ediCompositeDataElementsGs[7];

            var st = CurrentSegments.SingleOrDefault(es => es.Name == "ST");
            if (st == null)
                throw new ParsingException(ErrorCode.InvalidInterchangeContent, "ST was not found.");
            var ediCompositeDataElementsSt = st.Value.GetDataElements(Separators);
            var tag = ediCompositeDataElementsSt[0];
            if (ediCompositeDataElementsSt.Count() == 3)
            {
                version = ediCompositeDataElementsSt[2];
            }
            if (ediCompositeDataElementsSt.Count() < 2)
                throw new ParsingException(ErrorCode.InvalidInterchangeContent,
                    "ST is invalid.Too little data elements.");
            var controlNumber = ediCompositeDataElementsSt[1];

            return new MessageContext(tag, controlNumber, version, "X12", _currentIsa.InterchangeSenderID_6,
                _currentIsa.SenderIDQualifier_5, _currentIsa.InterchangeReceiverID_8, _currentIsa.ReceiverIDQualifier_7);
        }
    }
}
