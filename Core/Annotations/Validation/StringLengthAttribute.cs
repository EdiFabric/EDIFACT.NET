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
    /// Validation attribute for the correct length of data elements.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class StringLengthAttribute : ValidationAttribute
    {
        /// <summary>
        /// The minimum allowed length.
        /// </summary>
        public int MinLen { get; private set; }
        /// <summary>
        /// The maximum allowed length.
        /// </summary>
        public int MaxLen { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringLengthAttribute"/> class.
        /// </summary>
        /// <param name="minLen">The minimum allowed length.</param>
        /// <param name="maxLen">The maximum allowed length.</param>
        public StringLengthAttribute(int minLen, int maxLen) : base(3)
        {
            MinLen = minLen;
            MaxLen = maxLen;
        }

        /// <summary>
        /// Detects if the length of a data element is correct.
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

            var segmentType = instanceContext.Parent.IsPropertyOfType<SegmentAttribute>()
                ? instanceContext.Parent.GetStandardType()
                : instanceContext.Parent.Property.GetStandardDeclaringType();

            if (string.IsNullOrEmpty(segmentName) && instanceContext.Parent.Instance != null)
            {
                var type = instanceContext.Parent.Instance.GetStandardType();
                var ediAttribute = type.GetCustomAttribute<EdiAttribute>();
                if (ediAttribute == null)
                    throw new Exception(string.Format("Can't find segment name for {0}", GetType().Name));

                segmentName = ediAttribute.Id;
                segmentType = type;
            }

            var dataElementAttr = instanceContext.Property.GetCustomAttribute<DataElementAttribute>();
            var name = dataElementAttr == null ? "" : dataElementAttr.Code;

            var result = new SegmentErrorContext(segmentName, segmentIndex, segmentType);
            var errorContext = new DataElementErrorContext(name, inSegmentIndex, errorCode, inCompositeIndex,
                repetitionIndex, value);
            result.Add(errorContext);
            return result;
        }
    }
}
