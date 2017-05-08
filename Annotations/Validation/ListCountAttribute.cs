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
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using EdiFabric.Annotations.Edi;
using EdiFabric.Annotations.Model;

namespace EdiFabric.Annotations.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ListCountAttribute : ValidationAttribute
    {
        public int MinCount { get; set; }
        public int MaxCount { get; set; }

        public ListCountAttribute(int minCount, int maxCount) : base(2)
        {
            MinCount = minCount;
            MaxCount = maxCount;
        }

        public ListCountAttribute(int maxCount) : base(2)
        {
            MinCount = 0;
            MaxCount = maxCount;
        }

        public override List<SegmentErrorContext> IsValid(InstanceContext instanceContext, int segmentIndex,
            int inSegmentIndex, int inCompositeIndex)
        {
            var result = new List<SegmentErrorContext>();

            if (instanceContext.Instance == null)
                return result;

            var list = instanceContext.Instance as IList;
            if (list == null)
                return result;               

            if (list.Count <= MaxCount && list.Count >= MinCount)
                return result;

            if (instanceContext.IsPropertyOfType<AllAttribute>())
            {
                throw new Exception(string.Format("{0} is not applicable to All Groups.", GetType().Name));
            }

            if (instanceContext.IsPropertyOfType<GroupAttribute>())
            {
                result.AddRange(ValidateGroup(list, instanceContext, segmentIndex));
                return result;
            }

            if (instanceContext.IsPropertyOfType<SegmentAttribute>())
            {
                result.AddRange(ValidateSegment(list, instanceContext, segmentIndex));
                return result;
            }

            if (instanceContext.IsPropertyOfType<CompositeAttribute>())
            {
                result.AddRange(ValidateComposite(list, instanceContext, segmentIndex, inSegmentIndex));
                return result;
            }

            if (instanceContext.Property.GetGenericType() == typeof (string))
            {
                result.AddRange(ValidateDataElement(list, instanceContext, segmentIndex, inSegmentIndex,
                    inCompositeIndex));
                return result;
            }

            throw new Exception(string.Format("Property {0} of type {1} is not supported.",
                instanceContext.Property.Name,
                instanceContext.Property.GetGenericType().Name));
        }

        private List<SegmentErrorContext> ValidateGroup(IList list, InstanceContext instanceContext, int segmentIndex)
        {
            var result = new List<SegmentErrorContext>();

            var errorCode = list.Count > MaxCount
                    ? ValidationResult.CountExceededGroup
                    : ValidationResult.RequiredMissingGroup;

            result.Add(new SegmentErrorContext(instanceContext.GetId(), segmentIndex, errorCode));
            
            return result;
        }

        private List<SegmentErrorContext> ValidateSegment(IList list, InstanceContext instanceContext, int segmentIndex)
        {
            var result = new List<SegmentErrorContext>();

            var errorCode = list.Count > MaxCount
                    ? ValidationResult.CountExceededSegment
                    : ValidationResult.RequiredMissingSegment;

            result.Add(new SegmentErrorContext(instanceContext.GetId(), segmentIndex, errorCode));

            return result;
        }

        private List<SegmentErrorContext> ValidateComposite(IList list, InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex)
        {
            if (instanceContext.Parent == null || !instanceContext.Parent.IsPropertyOfType<SegmentAttribute>())
                throw new Exception(string.Format("Parent of composite {0} must be a segment.",
                    instanceContext.Property.Name));

            var result = new List<SegmentErrorContext>();

            var errorCode = list.Count > MaxCount
                ? ValidationResult.CountExceededComposite
                : ValidationResult.RequiredMissingComposite;

            var error = new SegmentErrorContext(instanceContext.Parent.GetId(), segmentIndex);
            error.Add(instanceContext.GetId(), inSegmentIndex, errorCode, 0, MaxCount + 1, null);
            result.Add(error);

            return result;
        }

        private List<SegmentErrorContext> ValidateDataElement(IList list, InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex, int inCompositeIndex)
        {
            if (instanceContext.Parent == null)
                throw new Exception(
                    string.Format("Parent of data element {0} must be either a segment or a composite.",
                        instanceContext.Property.Name));

            var result = new List<SegmentErrorContext>();

            var errorCode = list.Count > MaxCount
                ? ValidationResult.CountExceededDataElement
                : ValidationResult.RequiredMissingDataElement;

            var segmentName = instanceContext.Parent.IsPropertyOfType<SegmentAttribute>()
                ? instanceContext.Parent.GetId()
                : instanceContext.Parent.GetDeclaringTypeId();

            var dataElementAttr = instanceContext.Property.GetCustomAttribute<DataElementAttribute>();
            var name = dataElementAttr == null ? "" : dataElementAttr.Code;

            var error = new SegmentErrorContext(segmentName, segmentIndex);
            error.Add(name, inSegmentIndex, errorCode, inCompositeIndex, MaxCount + 1, null);
            result.Add(error);

            return result;
        }
    }
}
