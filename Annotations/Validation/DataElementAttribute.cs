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
using EdiFabric.Annotations.Model;

namespace EdiFabric.Annotations.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DataElementAttribute : ValidationAttribute
    {
        public string Code { get; set; }
        public Type DataType { get; set; }

        public DataElementAttribute(string code, Type dataType) : base(4)
        {
            Code = code;
            DataType = dataType;
        }

        public override List<SegmentErrorContext> IsValid(InstanceContext instanceContext, int segmentIndex,
            int inSegmentIndex, int inCompositeIndex)
        {
            var result = new List<SegmentErrorContext>();
            return result;
        }
    }
}
