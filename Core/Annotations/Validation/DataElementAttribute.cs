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
using EdiFabric.Core.Model.Validation;

namespace EdiFabric.Core.Annotations.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class DataElementAttribute : ValidationAttribute
    {
        public string Code { get; set; }
        public Type DataType { get; set; }

        public DataElementAttribute(string code, Type dataType) : base(4)
        {
            Code = code;
            DataType = dataType;
        }

        public override List<ErrorContextSegment> IsValid(InstanceContext instanceContext, int segmentIndex,
            int inSegmentIndex, int inCompositeIndex, int repetitionIndex)
        {
            var result = new List<ErrorContextSegment>();

            if (instanceContext.Instance == null)
                return result;

            var value = instanceContext.Instance as string;
            if (string.IsNullOrEmpty(value))
                return result;

            if (instanceContext.Property.GetGenericType() != typeof(string))
                return result;

            var eAttr = DataType.GetCustomAttribute<EdiCodesAttribute>();
            if (eAttr == null)
                return result;

            if (eAttr.Codes.Contains("," + value + ","))
                return result;

            result.Add(ValidateDataElement(value, instanceContext, segmentIndex, inSegmentIndex,
                inCompositeIndex, repetitionIndex));
            return result;
        }

        private ErrorContextSegment ValidateDataElement(string value, InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex, int inCompositeIndex, int repetitionIndex)
        {
            if (instanceContext.Parent == null)
                throw new Exception(
                    string.Format("Parent of data element {0} must be either a segment or a composite.",
                        instanceContext.Property.Name));

            var segmentName = instanceContext.Parent.IsPropertyOfType<SegmentAttribute>()
                ? instanceContext.Parent.GetId()
                : instanceContext.Parent.GetDeclaringTypeId();

            var dataElementAttr = instanceContext.Property.GetCustomAttribute<DataElementAttribute>();
            var name = dataElementAttr == null ? "" : dataElementAttr.Code;

            var result = new ErrorContextSegment(segmentName, segmentIndex);
            result.Add(name, inSegmentIndex, ValidationResult.InvalidCodeValue, inCompositeIndex, repetitionIndex,
                value);
            return result;
        }
    }
}
