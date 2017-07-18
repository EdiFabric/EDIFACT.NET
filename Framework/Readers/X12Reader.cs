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
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Model;

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
        /// <param name="encoding">The encoding. The default is Encoding.UTF8.</param>
        /// <param name="continueOnError">Whether to continue searching for valid data after an error occurs.</param>
        /// <param name="maxSegmentLength">The maximum length of a segment after which the search for segment terminator seizes.</param>
        /// <returns>A new instance of the <see cref="X12Reader"/> class.</returns>
        public X12Reader(Stream ediStream, string rulesAssembly, Encoding encoding = null, bool continueOnError = false,
            int maxSegmentLength = 5000)
            : base(ediStream, mc => Assembly.Load(new AssemblyName(rulesAssembly)), encoding, continueOnError, maxSegmentLength)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="X12Reader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssembly">The delegate to return the assembly containing the EDI classes.</param>
        /// <param name="encoding">The encoding. The default is Encoding.UTF8.</param>
        /// <param name="continueOnError">Whether to continue searching for valid data after an error occurs.</param>
        /// <param name="maxSegmentLength">The maximum length of a segment after which the search for segment terminator seizes.</param>
        /// <returns>A new instance of the <see cref="X12Reader"/> class.</returns>
        public X12Reader(Stream ediStream, Func<MessageContext, Assembly> rulesAssembly, Encoding encoding = null,
            bool continueOnError = false, int maxSegmentLength = 5000)
            : base(ediStream, rulesAssembly, encoding, continueOnError, maxSegmentLength)
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

                    var noSegmentTerminator = probed.Substring(0, probed.Length - 1);
                    if (noSegmentTerminator.Contains(segment) || isaElements.Any(string.IsNullOrEmpty) ||
                        noSegmentTerminator.Contains('\r') || noSegmentTerminator.Contains('\n') ||
                        char.IsUpper(segment) || char.IsNumber(segment))
                        return false;

                    separators = new Separators(segment, componentDataElement, dataElement,
                        repetitionDataElement, null);
                    return true;            
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return false;
        }

        protected override EdiItem Process(string segment)
        {
            EdiItem result = null;

            var segmentContext = new SegmentContext(segment, Separators);
            switch (segmentContext.Name)
            {
                case "ISA":
                case "GS":
                case "ST":
                case "GE":
                case "IEA":
                    result = Flush(segment);
                    if (result != null)
                        return result;
                    break;
            }

            switch (segmentContext.Name)
            {
                case "ISA":
                    var isa = ParseSegment<ISA>(segmentContext.Value, Separators);
                    _currentIsa = isa;
                    result = isa;
                    _currentGroupHeader = null;
                    break;
                case "TA1":
                    result = ParseSegment<TA1>(segmentContext.Value, Separators);
                    _currentGroupHeader = null;
                    break;
                case "GS":
                    result = ParseSegment<GS>(segmentContext.Value, Separators);
                    _currentGroupHeader = segmentContext;
                    break;
                case "ST":
                    CurrentSegments.Add(segmentContext);
                    CurrentMessageContext = BuildContext();
                    SegmentIndex = 0;
                    PartsIndex = 0;
                    break;
                case "SE":
                    CurrentSegments.Add(segmentContext);
                    result = ParseSegments();
                    CurrentMessageContext = null;
                    SegmentIndex = 0;
                    PartsIndex = 0;
                    break;
                case "GE":
                    result = ParseSegment<GE>(segmentContext.Value, Separators);
                    _currentGroupHeader = null;
                    break;
                case "IEA":
                    result = ParseSegment<IEA>(segmentContext.Value, Separators);
                    _currentGroupHeader = null;
                    _currentIsa = null;
                    break;
                default:
                    CurrentSegments.Add(segmentContext);
                    break;
            }

            return result;
        }

        private MessageContext BuildContext()
        {
            if (_currentIsa == null)
                throw new Exception("Interchange header is missing.");

            if (CurrentSegments.Count == 1)
            {
                var ta1 = CurrentSegments.SingleOrDefault(es => es.Name == "TA1");
                if (ta1 != null)
                {
                    return new MessageContext("TA1", "", "", "X12", _currentIsa.InterchangeSenderID_6,
                        _currentIsa.SenderIDQualifier_5, _currentIsa.InterchangeReceiverID_8,
                        _currentIsa.ReceiverIDQualifier_7, RulesAssembly);
                }
            }

            if (_currentGroupHeader == null)
                throw new Exception("GS was not found.");

            var ediCompositeDataElementsGs = _currentGroupHeader.Value.GetDataElements(Separators);
            if (ediCompositeDataElementsGs.Count() < 8)
                throw new Exception("GS is invalid. Too little data elements.");

            var version = ediCompositeDataElementsGs[7];

            var st = CurrentSegments.SingleOrDefault(es => es.Name == "ST");
            if (st == null)
                throw new Exception("ST was not found.");

            var ediCompositeDataElementsSt = st.Value.GetDataElements(Separators);
            var tag = ediCompositeDataElementsSt[0];
            if (ediCompositeDataElementsSt.Count() == 3)
            {
                version = ediCompositeDataElementsSt[2];
            }
            if (ediCompositeDataElementsSt.Count() < 2)
                throw new Exception("ST is invalid.Too little data elements.");

            var controlNumber = ediCompositeDataElementsSt[1];

            return new MessageContext(tag, controlNumber, version, "X12", _currentIsa.InterchangeSenderID_6,
                _currentIsa.SenderIDQualifier_5, _currentIsa.InterchangeReceiverID_8, _currentIsa.ReceiverIDQualifier_7, RulesAssembly);
        }
    }
}
