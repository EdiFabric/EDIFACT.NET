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
using EdiFabric.Framework.Constants;
using EdiFabric.Framework.Controls;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Parses Edifact messages into .NET objects.
    /// </summary>
    public sealed class EdifactReader : EdiReader
    {
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

        private EdifactReader(Stream ediStream, ReaderSettings settings)
            : base(ediStream, settings)
        {
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="EdifactReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="settings">The additional settings.</param>
        /// <returns>A new instance of the <see cref="EdifactReader"/> class.</returns>
        public static EdifactReader Create(Stream ediStream, ReaderSettings settings = null)
        {
            return new EdifactReader(ediStream, settings ?? new ReaderSettings());
        }

        protected override bool TryReadControl(string segmentName, out string probed, out Separators separators)
        {
            probed = "";
            separators = null;

            try
            {
                if (segmentName == "UNB")
                {
                    probed = segmentName + StreamReader.Read(6);
                    if (IsUnb(probed, Separators.DefaultSeparatorsEdifact().DataElement,
                        Separators.DefaultSeparatorsEdifact().ComponentDataElement))
                    {
                        separators = Separators.DefaultSeparatorsEdifact();
                        return true;
                    }
                }

                if (segmentName == "UNA")
                {
                    var una = StreamReader.Read(6);
                    probed = segmentName + una;
                    var unaChars = una.ToArray();
                    var componentDataElement = unaChars[0];
                    var dataElement = unaChars[1];
                    char? escape = unaChars[3];
                    var repetitionDataElement = Separators.DefaultSeparatorsEdifact().RepetitionDataElement;
                    var segment = unaChars[5];

                    var tmp = StreamReader.Read(9, Trims);
                    probed += tmp;
                    if (IsUnb(tmp, dataElement, componentDataElement))
                    {
                        separators = Separators.SeparatorsEdifact(segment, componentDataElement, dataElement,
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
            switch (segmentContext.Tag)
            {
                case SegmentTags.UNA:
                    CurrentMessage.Clear();
                    break;
                case SegmentTags.UNB:
                    CurrentMessage.Clear();
                    Item = segmentContext.Value.ParseSegment<S_UNB>(Separators);
                    break;
                case SegmentTags.UNG:
                    CurrentMessage.Clear();
                    Item = segmentContext.Value.ParseSegment<S_UNG>(Separators);
                    break;
                case SegmentTags.UNH:
                    if (CurrentMessage.Any(s => !s.IsControl))
                    {
                        Item = ParseMessage();
                        CurrentMessage.Clear();
                    }
                    CurrentMessage.Add(segmentContext);
                    break;
                case SegmentTags.UNT:
                    CurrentMessage.Add(segmentContext);
                    Item = ParseMessage();
                    CurrentMessage.Clear();
                    break;
                case SegmentTags.UNE:
                    Item = segmentContext.Value.ParseSegment<S_UNE>(Separators);
                    CurrentMessage.Clear();
                    break;
                case SegmentTags.UNZ:
                    Item = segmentContext.Value.ParseSegment<S_UNZ>(Separators);
                    CurrentMessage.Clear();
                    break;
                default:
                    CurrentMessage.Add(segmentContext);
                    break;
            }
        }

        private object ParseMessage()
        {
            try
            {
                return CurrentMessage.Analyze(Separators, ToType(), RulesAssemblyName);
            }
            catch (Exception ex)
            {
                return new ParsingException(ErrorCodes.Unknown, ex.Message, ex);
            }
        }

        private Type ToType()
        {
            var unh = CurrentMessage.SingleOrDefault(es => es.Tag == SegmentTags.UNH);
            if (unh == null)
                throw new ParsingException(ErrorCodes.UnhNotFound);
            var ediCompositeDataElements = unh.Value.GetDataElements(Separators);
            if (ediCompositeDataElements.Count() < 2)
                throw new ParsingException(ErrorCodes.UnhInvalid);
            var ediDataElements = ediCompositeDataElements[1].GetComponentDataElements(Separators);
            if (ediDataElements.Count() < 3)
                throw new ParsingException(ErrorCodes.UnhInvalid);

            var tag = ediDataElements[0];
            var version = ediDataElements[1] + ediDataElements[2];

            return EdiReaderExtensions.ToType("Edifact", version, tag, RulesAssemblyName, RulesNamespacePrefix);
        }

        private bool IsUnb(string toCompare, char dataElementSep, char componentSep)
        {
            return SyntaxId.Select(e => "UNB" + dataElementSep + e + componentSep).ToList().Contains(toCompare);
        }
    }
}
