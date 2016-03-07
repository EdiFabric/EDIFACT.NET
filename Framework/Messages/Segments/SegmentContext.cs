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
using EdiFabric.Framework.Envelopes;

namespace EdiFabric.Framework.Messages.Segments
{
    /// <summary>
    /// This class represents the context of a segment.
    /// </summary>
    internal class SegmentContext
    {
        /// <summary>
        /// The name of the segment.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The value of the first data element of that segment.
        /// </summary>
        public string FirstValue { get; private set; }

        /// <summary>
        /// The value of the second data element of that segment.
        /// </summary>
        public string SecondValue { get; private set; }

        /// <summary>
        /// The parent id in case it is HL segment (Hipaa specific).
        /// </summary>
        public string ParentId { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentContext"/> class.
        /// </summary>
        /// <param name="ediSegment">The EDI segment.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <param name="format">The EDI format.</param>
        public SegmentContext(string ediSegment, InterchangeContext interchangeContext, EdiFormats format)
        {
            if (string.IsNullOrEmpty(ediSegment)) throw new ArgumentNullException("ediSegment");
            if (interchangeContext == null) throw new ArgumentNullException("interchangeContext");

            // Blank segments shouldn't have gone that far
            var splitted = ediSegment.Split(interchangeContext.DataElementSeparator.ToCharArray(), StringSplitOptions.None);
            if (splitted.Length < 2) throw new Exception("Segment is blank.");

            Name = splitted[0];
            FirstValue = null;
            SecondValue = null;
            ParentId = null;

            // UNA segments don't have values
            if (ediSegment.StartsWith(EdiSegments.Una))
            {
                Name = EdiSegments.Una;
            }

            // Handle blank segments, e.g. BHT+'
            if (format == EdiFormats.Hipaa)
            {
                var splittedElement = splitted[1].Split(interchangeContext.ComponentDataElementSeparator.ToCharArray(), StringSplitOptions.None);
                FirstValue = splittedElement[0];
                if (splitted.Length > 2)
                {
                    var splittedSecondElement = splitted[2].Split(interchangeContext.ComponentDataElementSeparator.ToCharArray(), StringSplitOptions.None);
                    SecondValue = splittedSecondElement[0];
                }
                if (ediSegment.StartsWith(EdiSegments.Hl) && !string.IsNullOrEmpty(splitted[2])) ParentId = splitted[2];
            }
        }

        /// <summary>
        /// Checks if it is a "jump" segment, e.g. if it the parsing process needs to go back in the hierarchy.
        /// EDI parsing is always forward going apart from some HL jumps in Hipaa.
        /// This is Hipaa specific.
        /// </summary>
        /// <returns></returns>
        public bool IsJump()
        {
            if(Name == EdiSegments.Hl)
                if(FirstValue != null)
                    if(FirstValue != "1")
                        if (int.Parse(FirstValue) - int.Parse(ParentId ?? "0") > 1)
                            return true;

            return false;
        }

        /// <summary>
        /// Represents the segment context as a string.
        /// Used for logging.
        /// </summary>
        /// <returns>
        /// The formated string denoting the segment context.
        /// </returns>
        public string ToPropertiesString()
        {
            return string.Format("Name = {0} FirstValue = {1} SecondValue = {2} ParentId = {3}", Name, FirstValue, SecondValue, ParentId);
        }
    }
}
