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
using EdiFabric.Framework.Constants;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Framework
{
    class SegmentContext
    {
        private const string Hl = "HL";

        public string Name { get; private set; }
        public string FirstValue { get; private set; }
        public string SecondValue { get; private set; }
        public string ParentId { get; private set; }
        public string Value { get; private set; }
        public bool IsJump{ get; private set; }
        public bool IsControl{ get; private set; }
        public string LogName { get; private set; }
        public SegmentTags Tag { get; private set; }
        
        public SegmentContext(string ediSegment, Separators separators)
        {
            if (string.IsNullOrEmpty(ediSegment)) throw new ArgumentNullException("ediSegment");
            if (separators == null) throw new ArgumentNullException("separators");

            var dataElements = ediSegment.Split(new [] {separators.DataElement}, StringSplitOptions.None);
            
            Name = dataElements[0];
            Value = ediSegment;

            // UNA segments don't have values
            if (ediSegment.StartsWith(SegmentTags.UNA.ToString(), StringComparison.OrdinalIgnoreCase)) Name = SegmentTags.UNA.ToString();

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
                if (Name == Hl && !string.IsNullOrEmpty(dataElements[2]))
                    ParentId = dataElements[2];
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
            return Tag == SegmentTags.UNB || Tag == SegmentTags.UNG || Tag == SegmentTags.UNE || Tag == SegmentTags.UNZ ||
                   Tag == SegmentTags.UNA ||
                   Tag == SegmentTags.ISA || Tag == SegmentTags.GS || Tag == SegmentTags.GE || Tag == SegmentTags.IEA;
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
