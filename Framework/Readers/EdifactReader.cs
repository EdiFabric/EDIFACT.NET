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
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Core.Model.Edi.Exceptions;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Model;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Reads Edifact documents into .NET objects.
    /// </summary>
    public sealed class EdifactReader : EdiReader
    {
        private UNB _currentUnb;

        private static readonly List<string> SyntaxId = new List<string>
        {
            "UNOA",
            "UNOB",
            "UNOC",
            "UNOD",
            "UNOE",
            "UNOF",
            "UNOG",
            "UNOH",
            "UNOI",
            "UNOJ",
            "UNOX",
            "UNOY",
            "KECA"
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="EdifactReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssembly">The name of the assembly containing the EDI classes.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <returns>A new instance of the <see cref="EdifactReader"/> class.</returns>
        public EdifactReader(Stream ediStream, string rulesAssembly, Encoding encoding = null)
            : base(ediStream, rulesAssembly, encoding)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdifactReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssembly">The delegate to return the assembly containing the EDI classes.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <returns>A new instance of the <see cref="EdifactReader"/> class.</returns>
        public EdifactReader(Stream ediStream, Func<MessageContext, Assembly> rulesAssembly, Encoding encoding = null)
            : base(ediStream, rulesAssembly, encoding)
        {
        }

        protected override bool TryReadHeader(string segmentName, out string probed, out Separators separators)
        {
            probed = "";
            separators = null;

            try
            {
                if (segmentName == "UNB")
                {
                    probed = segmentName + Read(6);
                    if (IsUnb(probed, Separators.Edifact.DataElement,
                        Separators.Edifact.ComponentDataElement))
                    {
                        separators = Separators.Edifact;
                        return true;
                    }
                }

                if (segmentName == "UNA")
                {
                    var una = Read(6);
                    probed = segmentName + una;
                    var unaChars = una.ToArray();
                    var componentDataElement = unaChars[0];
                    var dataElement = unaChars[1];
                    char? escape = unaChars[3];
                    var repetitionDataElement = Separators.Edifact.RepetitionDataElement;
                    var segment = unaChars[5];

                    var tmp = ReadWithTrims(9);
                    probed += tmp;
                    if (IsUnb(tmp, dataElement, componentDataElement))
                    {
                        separators = new Separators(segment, componentDataElement, dataElement,
                            repetitionDataElement, escape);
                        probed = tmp;
                        return true;
                    }
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
                case "UNA":
                case "UNB":
                case "UNG":
                case "UNH":
                case "UNE":
                case "UNZ":
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
                case "UNA":
                    break;
                case "UNB":
                    var unb = ParseSegment<UNB>(segmentContext.Value, Separators);
                    _currentUnb = unb;
                    Item = unb;
                    break;
                case "UNG":
                    Item = ParseSegment<UNG>(segmentContext.Value, Separators);
                    break;
                case "UNH":
                    CurrentSegments.Add(segmentContext);
                    break;
                case "UNT":
                    CurrentSegments.Add(segmentContext);
                    ParseSegments();
                    break;
                case "UNE":
                    Item = ParseSegment<UNE>(segmentContext.Value, Separators);
                    break;
                case "UNZ":
                    Item = ParseSegment<UNZ>(segmentContext.Value, Separators);
                    _currentUnb = null;
                    break;
                default:
                    CurrentSegments.Add(segmentContext);
                    break;
            }
        }

        protected override MessageContext BuildContext()
        {
            if (_currentUnb == null)
                throw new ReaderException("Interchange header is missing.", ReaderErrorCode.InvalidControlStructure);

            var unh = CurrentSegments.SingleOrDefault(es => es.Name == "UNH");
            if (unh == null)
                throw new ReaderException("UNH was not found.", ReaderErrorCode.InvalidInterchangeContent);

            var ediCompositeDataElements = unh.Value.GetDataElements(Separators);
            if (ediCompositeDataElements.Count() < 2)
                throw new ReaderException("UNH is invalid. Too little data elements.", ReaderErrorCode.InvalidInterchangeContent);

            var ediDataElements = ediCompositeDataElements[1].GetComponentDataElements(Separators);
            if (ediDataElements.Count() < 3)
                throw new ReaderException("UNH is invalid. Unable to read message type or version.",
                    ReaderErrorCode.InvalidInterchangeContent);

            var tag = ediDataElements[0];
            var version = ediDataElements[1] + ediDataElements[2];
            var controlNumber = ediCompositeDataElements[0];

            return new MessageContext(tag, controlNumber, version, "EDIFACT",
                _currentUnb.INTERCHANGESENDER_2.InterchangeSenderIdentification_1,
                _currentUnb.INTERCHANGESENDER_2.IdentificationCodeQualifier_2,
                _currentUnb.INTERCHANGERECIPIENT_3.InterchangeRecipientIdentification_1,
                _currentUnb.INTERCHANGERECIPIENT_3.IdentificationCodeQualifier_2);
        }

        private bool IsUnb(string toCompare, char dataElementSep, char componentSep)
        {
            return SyntaxId.Select(e => "UNB" + dataElementSep + e + componentSep).ToList().Contains(toCompare);
        }
    }
}
