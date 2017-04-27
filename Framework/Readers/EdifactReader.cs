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
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Parsers;
using EdiFabric.Framework.Segments.Edifact;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Reads Edifact documents into .NET objects.
    /// </summary>
    public sealed class EdifactReader : EdiReader
    {
        private Func<MessageContext, Assembly> RulesAssembly { get; set; }
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
            : base(ediStream, encoding)
        {
            RulesAssembly = mc => Assembly.Load(rulesAssembly);            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdifactReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssembly">The delegate to return the assembly containing the EDI classes.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <returns>A new instance of the <see cref="EdifactReader"/> class.</returns>
        public EdifactReader(Stream ediStream, Func<MessageContext, Assembly> rulesAssembly, Encoding encoding = null)
            : base(ediStream, encoding)
        {
            RulesAssembly = rulesAssembly;            
        }

        protected override bool TryReadControl(string segmentName, out string probed, out Separators separators)
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
            if (string.IsNullOrEmpty(segment) || Separators == null)
                return;

            var segmentContext = new SegmentContext(segment, Separators);
            if ((segmentContext.IsControl || segmentContext.Tag == SegmentId.UNH) && CurrentMessage.Any())
            {
                Flush(segmentContext.Value);
                return;
            }

            switch (segmentContext.Tag)
            {
                case SegmentId.UNA:
                    break;
                case SegmentId.UNB:
                    Item = segmentContext.Value.ParseSegment<UNB>(Separators);
                    break;
                case SegmentId.UNG:
                    Item = segmentContext.Value.ParseSegment<UNG>(Separators);
                    break;
                case SegmentId.UNH:
                    CurrentMessage.Add(segmentContext);
                    break;
                case SegmentId.UNT:
                    try
                    {
                        CurrentMessage.Add(segmentContext);
                        Item = CurrentMessage.ParseTransactionSet(Separators, BuildContext());
                    }
                    finally
                    {
                        CurrentMessage.Clear();
                    }
                    break;
                case SegmentId.UNE:
                    Item = segmentContext.Value.ParseSegment<UNE>(Separators);
                    break;
                case SegmentId.UNZ:
                    Item = segmentContext.Value.ParseSegment<UNZ>(Separators);
                    break;
                default:
                    CurrentMessage.Add(segmentContext);
                    break;
            }
        }

        protected override MessageContext BuildContext()
        {
            var unh = CurrentMessage.SingleOrDefault(es => es.Tag == SegmentId.UNH);
            if (unh == null)
                throw new ParsingException(ErrorCodes.InvalidInterchangeContent, "UNH was not found.");
            var ediCompositeDataElements = unh.Value.GetDataElements(Separators);
            if (ediCompositeDataElements.Count() < 2)
            {
                throw new ParsingException(ErrorCodes.InvalidInterchangeContent,
                    "UNH is invalid. Too little data elements.", unh.Value);
            }
            var ediDataElements = ediCompositeDataElements[1].GetComponentDataElements(Separators);
            if (ediDataElements.Count() < 3)
            {
                throw new ParsingException(ErrorCodes.InvalidInterchangeContent,
                    "UNH is invalid. Unable to read message type or version.", unh.Value);
            }

            var tag = ediDataElements[0];
            var version = ediDataElements[1] + ediDataElements[2];
            var controlNumber = ediCompositeDataElements[0];

            return new MessageContext(tag, controlNumber, version, "EDIFACT", RulesAssembly);
        }

        private bool IsUnb(string toCompare, char dataElementSep, char componentSep)
        {
            return SyntaxId.Select(e => "UNB" + dataElementSep + e + componentSep).ToList().Contains(toCompare);
        }
    }
}
