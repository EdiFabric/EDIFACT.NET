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

        internal Separators(string segment, string componentDataElement, string dataElement,
            string repetitionDataElement, string escape = null)
        {
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

            return new Separators(segment ?? deafult.Segment,
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

            return new Separators(segment ?? deafult.Segment,
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
            return new Separators("~", ":", "*", "^");
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="Separators"/> class.
        /// Uses the default EDIFACT separators.
        /// </summary>
        public static Separators DefaultSeparatorsEdifact()
        {
            return new Separators("'", ":", "+", "*", "?");
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
