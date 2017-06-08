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
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Core.Annotations.Validation
{
    /// <summary>
    /// Validation attribute for mandatory items. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class RequiredAttribute : ValidationAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredAttribute"/> class.
        /// </summary>
        public RequiredAttribute()
            : base(1)
        {
        }

        /// <summary>
        /// Detects if an item is mandatory and exists.
        /// </summary>
        /// <param name="instanceContext">The instance context.</param>
        /// <param name="segmentIndex">The segment position.</param>
        /// <param name="inSegmentIndex">The position within the segment.</param>
        /// <param name="inCompositeIndex">The position within the component if any.</param>
        /// <param name="repetitionIndex">The repetition position.</param>
        /// <returns>A list of segment errors if invalid, otherwise nothing.</returns>
        internal override List<SegmentErrorContext> IsValid(InstanceContext instanceContext, int segmentIndex,
            int inSegmentIndex, int inCompositeIndex, int repetitionIndex)
        {
            var result = new List<SegmentErrorContext>();

            if (instanceContext.Instance != null)
                return result;

            if (instanceContext.IsPropertyOfType<AllAttribute>())
            {
                result.AddRange(ValidateAll(instanceContext, segmentIndex));
                return result;
            }

            if (instanceContext.IsPropertyOfType<GroupAttribute>())
            {
                result.Add(ValidateGroup(instanceContext, segmentIndex));
                return result;
            }

            if (instanceContext.IsPropertyOfType<SegmentAttribute>())
            {
                result.Add(ValidateSegment(instanceContext, segmentIndex));
                return result;
            }

            if (instanceContext.IsPropertyOfType<CompositeAttribute>())
            {
                result.Add(ValidateComposite(instanceContext, segmentIndex, inSegmentIndex));
                return result;
            }

            if (instanceContext.Property.GetGenericType() == typeof(string))
            {
                result.Add(ValidateDataElement(instanceContext, segmentIndex, inSegmentIndex, inCompositeIndex));
                return result;
            }

            throw new Exception(string.Format("Property {0} of type {1} is not supported.", instanceContext.Property.Name,
                instanceContext.Property.GetGenericType().Name));
        }

        private List<SegmentErrorContext> ValidateAll(InstanceContext instanceContext, int segmentIndex)
        {
            var result = new List<SegmentErrorContext>();

            var mandatoryNames =
                    instanceContext.Property.GetGenericType()
                        .GetProperties()
                        .Where(p => p.GetCustomAttribute<RequiredAttribute>() != null)
                        .Select(s => s.GetGenericType().GetCustomAttribute<EdiAttribute>().Id);

            result.AddRange(
                mandatoryNames.Select(
                    name => new SegmentErrorContext(name, segmentIndex + 1, SegmentErrorCode.RequiredSegmentMissing)));

            return result;
        }

        private SegmentErrorContext ValidateGroup(InstanceContext instanceContext, int segmentIndex)
        {
            return new SegmentErrorContext(instanceContext.GetId(), segmentIndex + 1,
                SegmentErrorCode.RequiredSegmentMissing);
        }

        private SegmentErrorContext ValidateSegment(InstanceContext instanceContext, int segmentIndex)
        {
            return new SegmentErrorContext(instanceContext.GetId(), segmentIndex + 1,
                SegmentErrorCode.RequiredSegmentMissing);
        }

        private SegmentErrorContext ValidateComposite(InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex)
        {
            if (instanceContext.Parent == null || !instanceContext.Parent.IsPropertyOfType<SegmentAttribute>())
                throw new Exception(string.Format("Parent of composite {0} must be a segment.",
                    instanceContext.Property.Name));

            var result = new SegmentErrorContext(instanceContext.Parent.GetId(), segmentIndex);
            var errorContext = new DataElementErrorContext(instanceContext.GetId(), inSegmentIndex,
                DataElementErrorCode.RequiredDataElementMissing, 0, 0, null);
            result.Add(errorContext);
            
            return result;
        }

        private SegmentErrorContext ValidateDataElement(InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex, int inCompositeIndex)
        {
            if (instanceContext.Parent == null)
                throw new Exception(string.Format("Parent of data element {0} must be either a segment or a composite.",
                    instanceContext.Property.Name));

            var segmentName = instanceContext.Parent.IsPropertyOfType<SegmentAttribute>()
                ? instanceContext.Parent.GetId()
                : instanceContext.Parent.GetDeclaringTypeId();

            if (string.IsNullOrEmpty(segmentName) && instanceContext.Parent.Instance != null)
            {
                var ediAttribute = instanceContext.Parent.Instance.GetType().GetCustomAttribute<EdiAttribute>();
                if (ediAttribute == null)
                    throw new Exception(string.Format("Can't find segment name for {0}", GetType().Name));

                segmentName = ediAttribute.Id;
            }

            var dataElementAttr = instanceContext.Property.GetCustomAttribute<DataElementAttribute>();
            var name = dataElementAttr == null ? "" : dataElementAttr.Code;

            var result = new SegmentErrorContext(segmentName, segmentIndex);
            var errorContext = new DataElementErrorContext(name, inSegmentIndex,
                DataElementErrorCode.RequiredDataElementMissing, inCompositeIndex, 0, null);
            result.Add(errorContext);

            return result;
        }
    }
}
