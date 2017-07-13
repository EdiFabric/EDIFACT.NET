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

namespace EdiFabric.Framework.Model
{
    /// <summary>
    /// Extends a segment line with additional attributes inferred from the data.
    /// </summary>
    sealed class SegmentContext
    {
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
        /// The value of the third data element.
        /// </summary>
        public string ThirdValue { get; private set; }

        /// <summary>
        /// The original segment line.
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// If it is HL that is not a direct child of its parent.
        /// </summary>
        public bool IsJump{ get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentContext"/> class.
        /// </summary>
        /// <param name="ediSegment">The segment line.</param>
        /// <param name="separators">The separators.</param>
        public SegmentContext(string ediSegment, Separators separators)
        {
            if (string.IsNullOrEmpty(ediSegment)) throw new ArgumentNullException("ediSegment");
            if (separators == null) throw new ArgumentNullException("separators");

            var dataElements = ediSegment.Split(new[] {separators.DataElement}, StringSplitOptions.None);
            Name = ediSegment.StartsWith("UNA", StringComparison.Ordinal)
                ? "UNA"
                : string.Concat(dataElements[0].TakeWhile(d => d != separators.Segment));
            Value = ediSegment;

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
                    if (!string.IsNullOrEmpty(secondComponentDataElements[0]))
                        SecondValue = secondComponentDataElements[0];
                }

                if (Name == "HL" && dataElements.Length > 3)
                {
                    var thirdComponentDataElements = dataElements[3].Split(new[] { separators.ComponentDataElement },
                    StringSplitOptions.None);
                    if (!string.IsNullOrEmpty(thirdComponentDataElements[0]))
                        ThirdValue = thirdComponentDataElements[0];
                }
            }

            IsJump = Jump();
        }

        private bool Jump()
        {
            if (Name != "HL")
                return false;

            int fv;
            int sv;

            //  All top level: HL*2**, HL*3**, etc.
            if (int.TryParse(FirstValue, out fv) && fv > 1 && string.IsNullOrEmpty(SecondValue))
                return true;

            if (int.TryParse(SecondValue, out sv) && (fv - sv > 1))
                return true;

            return false;
        }
    }
}
