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
    /// <summary>
    /// Validation attribute for the data type of data elements.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DataElementAttribute : ValidationAttribute
    {
        /// <summary>
        /// EDI code for the data element.
        /// </summary>
        public string Code { get; private set; }
        /// <summary>
        /// The type of the data element.
        /// </summary>
        public TypeInfo DataType { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataElementAttribute"/> class.
        /// </summary>
        /// <param name="code">EDI code for the data element.</param>
        /// <param name="dataType">The type of the data element.</param>
        public DataElementAttribute(string code, Type dataType) : base(4)
        {
            Code = code;
            if (dataType != null)
                DataType = dataType.GetTypeInfo();
        }

        /// <summary>
        /// Detects if a data element is valid according to its type.
        /// </summary>
        /// <param name="instanceContext">The instance context.</param>
        /// <param name="segmentIndex">The segment position.</param>
        /// <param name="inSegmentIndex">The position within the segment.</param>
        /// <param name="inCompositeIndex">The position within the component if any.</param>
        /// <param name="repetitionIndex">The repetition position.</param>
        /// <returns>A list of segment errors if invalid, otherwise nothing.</returns>
        public override List<SegmentErrorContext> Validate(InstanceContext instanceContext, int segmentIndex,
            int inSegmentIndex, int inCompositeIndex, int repetitionIndex)
        {
            var result = new List<SegmentErrorContext>();

            if (instanceContext.Instance == null)
                return result;

            var value = instanceContext.Instance as string;
            if (string.IsNullOrEmpty(value))
                return result;

            if (!instanceContext.Property.IsString())
                return result;

            if(DataType == null)
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

        private SegmentErrorContext ValidateDataElement(string value, InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex, int inCompositeIndex, int repetitionIndex)
        {
            if (instanceContext.Parent == null)
                throw new Exception(
                    string.Format("Parent of data element {0} must be either a segment or a composite.",
                        instanceContext.Property.Name));

            var segmentName = instanceContext.Parent.IsPropertyOfType<SegmentAttribute>()
                ? instanceContext.Parent.GetId()
                : instanceContext.Parent.GetDeclaringTypeId();

            if (string.IsNullOrEmpty(segmentName) && instanceContext.Parent.Instance != null)
            {
                var ediAttribute = instanceContext.Parent.Instance.GetStandardType().GetCustomAttribute<EdiAttribute>();
                if(ediAttribute == null)
                    throw new Exception(string.Format("Can't find segment name for {0}", GetType().Name));

                segmentName = ediAttribute.Id;
            }

            var dataElementAttr = instanceContext.Property.GetCustomAttribute<DataElementAttribute>();
            var name = dataElementAttr == null ? "" : dataElementAttr.Code;

            var result = new SegmentErrorContext(segmentName, segmentIndex);
            var errorContext = new DataElementErrorContext(name, inSegmentIndex, DataElementErrorCode.InvalidCodeValue,
                inCompositeIndex, repetitionIndex,
                value);
            result.Add(errorContext);
            return result;
        }
    }
}
