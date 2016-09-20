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
using System.Linq;
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework
{
    /// <summary>
    /// EDI separators.
    /// </summary>
    public sealed class Separators
    {
        /// <summary>
        /// Separator for segments.
        /// </summary>
        public string Segment { get; private set; }

        /// <summary>
        /// Separator for component data elements.
        /// </summary>
        public string ComponentDataElement { get; private set; }

        /// <summary>
        /// Release indicator for escaping terminators.
        /// </summary>
        public string Escape { get; private set; }

        ///<summary>
        /// Separator for data elements.
        /// </summary>
        public string DataElement { get; private set; }

        /// <summary>
        /// Separator for repetitions of data elements.
        /// </summary>
        public string RepetitionDataElement { get; private set; }

        /// <summary>
        /// The format of the interchange, e.g. the format of the envelope.
        /// </summary>
        public Formats Format { get; private set; }
        
        internal Separators(string contents)
        {
            if (contents == null) throw new ArgumentNullException("contents");

            switch (contents.ToSegmentTag(null))
            {
                case SegmentTags.ISA:
                    try
                    {
                        // Parse X12 separators, they are always contained within the envelope
                        DataElement = string.Concat(contents[3]);
                        var isa = string.Concat(contents.Take(106));
                        var isaElements = isa.Split(DataElement.ToCharArray());
                        ComponentDataElement = string.Concat(isaElements[16].First());
                        // Repetition is either the default ^ or else if explicitly specified when U is present
                        RepetitionDataElement = isaElements[11] != "U"
                            ? isaElements[11]
                            : DefaultSeparatorsX12().RepetitionDataElement;
                        // Handle carriage return \ new line segment terminators
                        var segment = isaElements[16].ToCharArray();
                        Segment = segment.Length > 1 && !char.IsWhiteSpace(segment[1])
                            ? string.Concat(segment[1])
                            : Environment.NewLine;
                        // No release terminator for X12
                        Escape = string.Empty;
                        Format = Formats.X12;                        
                    }
                    catch (Exception ex)
                    {
                        throw new ParserException("Unable to extract X12 interchange delimiters", ex);
                    }
                    break;
                case SegmentTags.UNB:
                    var defaultSeparators = DefaultSeparatorsEdifact();
                    //  Default EDIFACT separators
                    ComponentDataElement = defaultSeparators.ComponentDataElement;
                    DataElement = defaultSeparators.DataElement;
                    Escape = defaultSeparators.Escape;
                    RepetitionDataElement = defaultSeparators.RepetitionDataElement;
                    Segment = defaultSeparators.Segment;
                    Format = Formats.Edifact;                    
                    break;
                case SegmentTags.UNA:
                    try
                    {
                        //  Parse UNA separators
                        var una = contents.Replace(SegmentTags.UNA.ToString(), "").Take(6).ToArray();
                        ComponentDataElement = string.Concat(una[0]);
                        DataElement = string.Concat(una[1]);
                        Escape = string.Concat(una[3]);
                        RepetitionDataElement = DefaultSeparatorsEdifact().RepetitionDataElement;
                        Segment = string.Concat(una[5]);
                        Format = Formats.Edifact;                       
                    }
                    catch (Exception ex)
                    {
                        throw new ParserException("Unable to extract UNA interchange delimiters", ex);
                    }
                    break;
                default:
                    throw new ParserException(
                        string.Format("Invalid EDI message. The first segment must be one of {0}, {1}, {2}.", SegmentTags.UNA,
                            SegmentTags.UNB, SegmentTags.ISA));
            }
            
        }

        internal Separators(Formats format, string segment, string componentDataElement, string dataElement,
            string repetitionDataElement, string escape = null)
        {
            Format = format;
            ComponentDataElement = componentDataElement;
            DataElement = dataElement;
            Escape = escape ?? string.Empty;
            RepetitionDataElement = repetitionDataElement;
            Segment = segment;
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="Separators"/> class.
        /// </summary>
        public static Separators SeparatorsX12(string segment, string componentDataElement, string dataElement,
            string repetitionDataElement)
        {
            var deafult = DefaultSeparatorsX12();

            return new Separators(Formats.X12, segment ?? deafult.Segment,
                componentDataElement ?? deafult.ComponentDataElement, dataElement ?? deafult.DataElement,
                repetitionDataElement ?? deafult.RepetitionDataElement);
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="Separators"/> class.
        /// </summary>
        public static Separators SeparatorsEdifact(string segment, string componentDataElement, string dataElement,
            string repetitionDataElement, string escape)
        {
            var deafult = DefaultSeparatorsEdifact();

            return new Separators(Formats.Edifact, segment ?? deafult.Segment,
                componentDataElement ?? deafult.ComponentDataElement,
                dataElement ?? deafult.DataElement,
                repetitionDataElement ?? deafult.RepetitionDataElement,
                escape ?? deafult.Escape);
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="Separators"/> class.
        /// Uses the default X12 separators.
        /// </summary>
        public static Separators DefaultSeparatorsX12()
        {
            return new Separators(Formats.X12, "~", ":", "*", "^");
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="Separators"/> class.
        /// Uses the default EDIFACT separators.
        /// </summary>
        public static Separators DefaultSeparatorsEdifact()
        {
            return new Separators(Formats.Edifact, "'", ":", "+", "*", "?");
        }

        /// <summary>
        /// Creates UNA segment.
        /// </summary>
        /// <returns>The separators.</returns>
        public string ToUna()
        {
            return SegmentTags.UNA + ComponentDataElement + DataElement + "." + Escape + " " + Segment;
        }
    }
}
