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
using EdiFabric.Annotations.Edi;
using EdiFabric.Annotations.Model;

namespace EdiFabric.Annotations.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredAttribute : ValidationAttribute
    {
        public RequiredAttribute()
            : base(1)
        {
        }

        public override List<SegmentErrorContext> IsValid(InstanceContext instanceContext, int segmentIndex,
            int inSegmentIndex, int inCompositeIndex)
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
                result.AddRange(ValidateGroup(instanceContext, segmentIndex));
                return result;
            }

            if (instanceContext.IsPropertyOfType<SegmentAttribute>())
            {
                result.AddRange(ValidateSegment(instanceContext, segmentIndex));
                return result;
            }

            if (instanceContext.IsPropertyOfType<CompositeAttribute>())
            {
                result.AddRange(ValidateComposite(instanceContext, segmentIndex, inSegmentIndex));
                return result;
            }

            if (instanceContext.Property.GetGenericType() == typeof(string))
            {
                result.AddRange(ValidateDataElement(instanceContext, segmentIndex, inSegmentIndex, inCompositeIndex));
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
                    name => new SegmentErrorContext(name, segmentIndex + 1, ValidationResult.RequiredMissingAll)));

            return result;
        }

        private List<SegmentErrorContext> ValidateGroup(InstanceContext instanceContext, int segmentIndex)
        {
            var result = new List<SegmentErrorContext>
            {
                new SegmentErrorContext(instanceContext.GetId(), segmentIndex + 1,
                    ValidationResult.RequiredMissingGroup)
            };

            return result;
        }

        private List<SegmentErrorContext> ValidateSegment(InstanceContext instanceContext, int segmentIndex)
        {
            var result = new List<SegmentErrorContext>
            {
                new SegmentErrorContext(instanceContext.GetId(), segmentIndex + 1,
                    ValidationResult.RequiredMissingSegment)
            };

            return result;
        }

        private List<SegmentErrorContext> ValidateComposite(InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex)
        {
            if (instanceContext.Parent == null || !instanceContext.Parent.IsPropertyOfType<SegmentAttribute>())
                throw new Exception(string.Format("Parent of composite {0} must be a segment.",
                    instanceContext.Property.Name));

            var result = new List<SegmentErrorContext>();
            var error = new SegmentErrorContext(instanceContext.Parent.GetId(), segmentIndex);
            error.Add(instanceContext.GetId(), inSegmentIndex, ValidationResult.RequiredMissingComposite, 0, 0, null);
            result.Add(error);

            return result;
        }

        private List<SegmentErrorContext> ValidateDataElement(InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex, int inCompositeIndex)
        {
            if (instanceContext.Parent == null)
                throw new Exception(string.Format("Parent of data element {0} must be either a segment or a composite.",
                    instanceContext.Property.Name));

            var segmentName = instanceContext.Parent.IsPropertyOfType<SegmentAttribute>()
                ? instanceContext.Parent.GetId()
                : instanceContext.Parent.GetDeclaringTypeId();

            var dataElementAttr = instanceContext.Property.GetCustomAttribute<DataElementAttribute>();
            var name = dataElementAttr == null ? "" : dataElementAttr.Code;

            var result = new List<SegmentErrorContext>();
            var error = new SegmentErrorContext(segmentName, segmentIndex);
            error.Add(name, inSegmentIndex, ValidationResult.RequiredMissingDataElement, inCompositeIndex, 0, null);
            result.Add(error);

            return result;
        }
    }
}
