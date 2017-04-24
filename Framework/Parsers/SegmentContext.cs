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

namespace EdiFabric.Framework.Parsers
{
    /// <summary>
    /// Extends a segment line with additional attributes inferred from the data.
    /// </summary>
    class SegmentContext
    {
        private const string Hl = "HL";

        /// <summary>
        /// The segment ID.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The value of the first data element.
        /// </summary>
        public string FirstValue { get; private set; }
        /// <summary>
        /// The value of the second data element.
        /// </summary>
        public string SecondValue { get; private set; }
        /// <summary>
        /// The id of HL.
        /// </summary>
        public string Id { get; private set; }
        /// <summary>
        /// The id of the parent HL if any.
        /// </summary>
        public string ParentId { get; private set; }
        /// <summary>
        /// The original segment line.
        /// </summary>
        public string Value { get; private set; }
        /// <summary>
        /// If it is HL that is not a direct child of its parent.
        /// </summary>
        public bool IsJump{ get; private set; }
        /// <summary>
        /// If it is a control segment.
        /// </summary>
        public bool IsControl{ get; private set; }
        /// <summary>
        /// Descriptive name for logging.
        /// </summary>
        public string LogName { get; private set; }
        /// <summary>
        /// The segment name as tag.
        /// </summary>
        public SegmentId Tag { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentContext"/> class.
        /// </summary>
        /// <param name="ediSegment">The segment line.</param>
        /// <param name="separators">The separators.</param>
        public SegmentContext(string ediSegment, Separators separators)
        {
            if (string.IsNullOrEmpty(ediSegment)) throw new ArgumentNullException("ediSegment");
            if (separators == null) throw new ArgumentNullException("separators");

            var dataElements = ediSegment.Split(new [] {separators.DataElement}, StringSplitOptions.None);
            // Support for blank/situational segments
            if (dataElements[0] == ediSegment)
                dataElements[0] = dataElements[0].TrimEnd(separators.Segment);

            Name = string.Concat(dataElements[0].Take(3));
            Value = ediSegment;

            // UNA segments don't have values
            if (ediSegment.StartsWith(SegmentId.UNA.ToString(), StringComparison.Ordinal)) Name = SegmentId.UNA.ToString();

            if (dataElements.Length > 1)
            {
                // Handle blank segments, e.g. BHT+'
                var firstComponentDataElements = dataElements[1].Split(new[] {separators.ComponentDataElement},
                    StringSplitOptions.None);
                FirstValue = firstComponentDataElements[0];
                if (dataElements.Length > 2)
                {
                    var secondComponentDataElements =
                        dataElements[2].Split(new[] {separators.ComponentDataElement},
                            StringSplitOptions.None);
                    SecondValue = secondComponentDataElements[0];
                }
                if (Name == Hl)
                {
                    Id = dataElements[1];
                    if (!string.IsNullOrEmpty(dataElements[2]))
                        ParentId = dataElements[2];
                }
            }

            IsJump = Jump();
            Tag = ediSegment.ToSegmentTag(separators);
            IsControl = Control();
            LogName = ToLogName();
        }

        private string ToLogName()
        {
            var result = string.Format("Name = {0}", Name);

            if (!string.IsNullOrEmpty(FirstValue))
                result = result + string.Format(" FirstValue = {0}", FirstValue);

            if (!string.IsNullOrEmpty(SecondValue))
                result = result + string.Format(" SecondValue = {0}", SecondValue);

            if (!string.IsNullOrEmpty(ParentId))
                result = result + string.Format(" ParentId = {0}", ParentId);

            return result;
        }

        private bool Control()
        {
            return Tag == SegmentId.UNB || Tag == SegmentId.UNG || Tag == SegmentId.UNE || Tag == SegmentId.UNZ ||
                   Tag == SegmentId.UNA ||
                   Tag == SegmentId.ISA || Tag == SegmentId.GS || Tag == SegmentId.GE || Tag == SegmentId.IEA;
        }

        private bool Jump()
        {
            int fv;
            int p;
            return Name == Hl && FirstValue != null && FirstValue != "1" && int.TryParse(FirstValue, out fv) &&
                     int.TryParse(ParentId ?? "0", out p) &&
                     (fv - p > 1);
        }
    }
}
