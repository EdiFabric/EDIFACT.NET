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
    /// Segment full name is segment name + the value of the first data element.
    /// </summary>
    public class SegmentFullName
    {
        /// <summary>
        /// The name of the segment
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The value of the first data element of that segment
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentFullName"/> class.
        /// </summary>
        /// <param name="ediSegment">The edi segment.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <param name="format">The edi format.</param>
        public SegmentFullName(string ediSegment, InterchangeContext interchangeContext, EdiFormats format)
        {
            if (string.IsNullOrEmpty(ediSegment)) throw new ArgumentNullException("ediSegment");
            if (interchangeContext == null) throw new ArgumentNullException("interchangeContext");

            // Blank segments shouldn't have gone that far
            var splitted = ediSegment.Split(interchangeContext.DataElementSeparator.ToCharArray(), StringSplitOptions.None);
            if (splitted.Length < 2) throw new Exception("Segment is blank.");

            Name = splitted[0];
            Value = null;

            // UNA segments don't have values
            if (ediSegment.StartsWith(EdiSegments.Una))
            {
                Name = EdiSegments.Una;
            }

            // Handle blank segments, e.g. BHT+'
            if (format == EdiFormats.Hipaa && !splitted[1].Contains(interchangeContext.ComponentDataElementSeparator))
            {
                Value = splitted[1];
            }
        }
    }
}
