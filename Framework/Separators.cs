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
        public char Segment { get; private set; }

        /// <summary>
        /// Separator for component data elements.
        /// </summary>
        public char ComponentDataElement { get; private set; }

        /// <summary>
        /// Release indicator for escaping terminators.
        /// </summary>
        public char Escape { get; private set; }

        ///<summary>
        /// Separator for data elements.
        /// </summary>
        public char DataElement { get; private set; }

        /// <summary>
        /// Separator for repetitions of data elements.
        /// </summary>
        public char RepetitionDataElement { get; private set; }

        internal Separators(char segment, char componentDataElement, char dataElement,
            char repetitionDataElement, char escape)
        {
            ComponentDataElement = componentDataElement;
            DataElement = dataElement;
            Escape = escape;
            RepetitionDataElement = repetitionDataElement;
            Segment = segment;
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="Separators"/> class.
        /// </summary>
        public static Separators SeparatorsX12(char segment, char componentDataElement, char dataElement,
            char repetitionDataElement)
        {
            return new Separators(segment, componentDataElement, dataElement, repetitionDataElement, '\0');
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="Separators"/> class.
        /// </summary>
        public static Separators SeparatorsEdifact(char segment, char componentDataElement, char dataElement,
            char repetitionDataElement, char escape)
        {
            return new Separators(segment, componentDataElement, dataElement, repetitionDataElement, escape);
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="Separators"/> class.
        /// Uses the default X12 separators.
        /// </summary>
        public static Separators DefaultSeparatorsX12()
        {
            return new Separators('~', ':', '*', '^', '\0');
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="Separators"/> class.
        /// Uses the default EDIFACT separators.
        /// </summary>
        public static Separators DefaultSeparatorsEdifact()
        {
            return new Separators('\'', ':', '+', '*', '?');
        }

        /// <summary>
        /// Creates UNA segment.
        /// </summary>
        /// <returns>The separators.</returns>
        public string ToUna()
        {
            return SegmentTags.UNA.ToString() + ComponentDataElement + DataElement + "." + Escape + " " + Segment;
        }
    }
}
