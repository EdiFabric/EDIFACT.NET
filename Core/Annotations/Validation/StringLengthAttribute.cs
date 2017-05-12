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
using System.Reflection;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Core.Annotations.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class StringLengthAttribute : ValidationAttribute
    {
        public int MinLen { get; set; }
        public int MaxLen { get; set; }

        public StringLengthAttribute(int minLen, int maxLen) : base(3)
        {
            MinLen = minLen;
            MaxLen = maxLen;
        }

        public override List<SegmentErrorContext> IsValid(InstanceContext instanceContext, int segmentIndex,
            int inSegmentIndex, int inCompositeIndex, int repetitionIndex)
        {
            var result = new List<SegmentErrorContext>();

            if (instanceContext.Instance == null)
                return result;

            var value = instanceContext.Instance as string;
            if (string.IsNullOrEmpty(value))
                return result;

            if (instanceContext.Property.GetGenericType() != typeof(string))
                return result;

            if (value.Length >= MinLen && value.Length <= MaxLen)
                return result;
            
                result.Add(ValidateDataElement(value, instanceContext, segmentIndex, inSegmentIndex,
                    inCompositeIndex, repetitionIndex));
                return result;
        }

        private SegmentErrorContext ValidateDataElement(string value, InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex, int inCompositeIndex, int repetitionIndex)
        {
            if (instanceContext.Parent == null)
                throw new Exception(
                    string.Format("Parent of data element {0} must be either a segment or a composite.",
                        instanceContext.Property.Name));

            var errorCode = value.Length < MinLen
                ? DataElementErrorCode.DataElementTooShort
                : DataElementErrorCode.DataElementTooLong;

            var segmentName = instanceContext.Parent.IsPropertyOfType<SegmentAttribute>()
                ? instanceContext.Parent.GetId()
                : instanceContext.Parent.GetDeclaringTypeId();

            var dataElementAttr = instanceContext.Property.GetCustomAttribute<DataElementAttribute>();
            var name = dataElementAttr == null ? "" : dataElementAttr.Code;

            var result = new SegmentErrorContext(segmentName, segmentIndex);
            result.Add(name, inSegmentIndex, errorCode, inCompositeIndex, repetitionIndex, value);
            return result;
        }
    }
}
