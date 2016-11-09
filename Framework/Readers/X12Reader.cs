
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
using EdiFabric.Framework.Controls;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Parsing;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Parses X12 messages into .NET objects.
    /// </summary>
    public sealed class X12Reader : EdiReader
    {
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

        protected override bool TryReadControl(string segmentName, out string probed, out Separators separators)
        {
            probed = "";
            separators = null;

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

                    separators = Separators.SeparatorsX12(segment, componentDataElement, dataElement,
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

        protected override void ProcessSegment(string segment)
        {
            if (string.IsNullOrEmpty(segment) || Separators == null)
                return;

            var segmentContext = new SegmentContext(segment, Separators);
            
            if (Flush(segmentContext, SegmentTags.ST))
                return;

            switch (segmentContext.Tag)
            {
                // X12
                case SegmentTags.ISA:
                    Item = segmentContext.Value.ParseSegment<S_ISA>(Separators);
                    break;
                case SegmentTags.GS:
                    Item = segmentContext.Value.ParseSegment<S_GS>(Separators);
                    CurrentGroupHeader = segmentContext;
                    break;
                case SegmentTags.ST:
                    CurrentMessage.Add(segmentContext);                   
                    break;
                case SegmentTags.SE:
                    try
                    {
                        CurrentMessage.Add(segmentContext);
                        CurrentMessage.Add(CurrentGroupHeader);
                        Item = CurrentMessage.Analyze(Separators, ToType(), RulesAssemblyName);
                    }
                    finally 
                    {
                        CurrentMessage.Clear();                  
                    }
                    break;
                case SegmentTags.GE:
                    Item = segmentContext.Value.ParseSegment<S_GE>(Separators);
                    break;
                case SegmentTags.IEA:
                    Item = segmentContext.Value.ParseSegment<S_IEA>(Separators);
                    break;
                default:
                    CurrentMessage.Add(segmentContext);
                    break;
            }

            if (segmentContext.IsControl)
            {
                if (segmentContext.Tag != SegmentTags.GS)
                    CurrentGroupHeader = null;
            }
        }

        protected override Type ToType()
        {
            var gs = CurrentMessage.SingleOrDefault(es => es.Tag == SegmentTags.GS);
            if (gs == null)
                throw new ParsingException(ErrorCodes.InvalidInterchangeContent, "GS was not found.");
            var ediCompositeDataElementsGs = gs.Value.GetDataElements(Separators);
            if (ediCompositeDataElementsGs.Count() < 8)
                throw new ParsingException(ErrorCodes.InvalidInterchangeContent, "GS is invalid. Too little data elements.");
            var version = ediCompositeDataElementsGs[7];

            var st = CurrentMessage.SingleOrDefault(es => es.Tag == SegmentTags.ST);
            if (st == null)
                throw new ParsingException(ErrorCodes.InvalidInterchangeContent, "ST was not found.");
            var ediCompositeDataElementsSt = st.Value.GetDataElements(Separators);
            var tag = ediCompositeDataElementsSt[0];

            if (ediCompositeDataElementsSt.Count() == 3)
            {
                version = ediCompositeDataElementsSt[2];
            }

            return EdiReaderExtensions.ToType("X12", version, tag, RulesAssemblyName, RulesNamespacePrefix);
        }
    }
}
