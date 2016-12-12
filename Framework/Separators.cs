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

using EdiFabric.Framework.Parsing;

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
        public char? Escape { get; private set; }

        ///<summary>
        /// Separator for data elements.
        /// </summary>
        public char DataElement { get; private set; }

        /// <summary>
        /// Separator for repetitions of data elements.
        /// </summary>
        public char? RepetitionDataElement { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Separators"/> class.
        /// </summary>
        /// <param name="segment">Segment separator.</param>
        /// <param name="componentDataElement">Component data element separator.</param>
        /// <param name="dataElement">Data element separator.</param>
        /// <param name="repetitionDataElement">Repetition separator.</param>
        /// <param name="escape">Escape delimiter.</param>
        public Separators(char segment, char componentDataElement, char dataElement,
            char? repetitionDataElement, char? escape)
        {
            ComponentDataElement = componentDataElement;
            DataElement = dataElement;
            Escape = escape;
            RepetitionDataElement = repetitionDataElement;
            Segment = segment;
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="Separators"/> class.
        /// Uses the default X12 separators.
        /// </summary>
        /// <returns>A new instance of the <see cref="Separators"/> class with all default separators.</returns>
        public static Separators DefaultX12()
        {
            return new Separators('~', '>', '*', '^', null);
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="Separators"/> class.
        /// Uses the default EDIFACT separators.
        /// </summary>
        /// <returns>A new instance of the <see cref="Separators"/> class with all default separators.</returns>
        public static Separators DefaultEdifact()
        {
            return new Separators('\'', ':', '+', '*', '?');
        }

        /// <summary>
        /// Creates UNA segment.
        /// </summary>
        /// <returns>The separators.</returns>
        internal string ToUna()
        {
            return SegmentTags.UNA.ToString() + ComponentDataElement + DataElement + "." + Escape + " " + Segment;
        }
    }
}
