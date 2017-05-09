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
    public sealed class ListCountAttribute : ValidationAttribute
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
            int inSegmentIndex, int inCompositeIndex, int repetitionIndex)
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
                result.Add(ValidateGroup(list, instanceContext, segmentIndex));
                return result;
            }

            if (instanceContext.IsPropertyOfType<SegmentAttribute>())
            {
                result.Add(ValidateSegment(list, instanceContext, segmentIndex));
                return result;
            }

            if (instanceContext.IsPropertyOfType<CompositeAttribute>())
            {
                result.Add(ValidateComposite(list, instanceContext, segmentIndex, inSegmentIndex));
                return result;
            }

            if (instanceContext.Property.GetGenericType() == typeof (string))
            {
                result.Add(ValidateDataElement(list, instanceContext, segmentIndex, inSegmentIndex,
                    inCompositeIndex));
                return result;
            }

            throw new Exception(string.Format("Property {0} of type {1} is not supported.",
                instanceContext.Property.Name,
                instanceContext.Property.GetGenericType().Name));
        }

        private SegmentErrorContext ValidateGroup(IList list, InstanceContext instanceContext, int segmentIndex)
        {
            var errorCode = list.Count > MaxCount
                    ? ValidationResult.CountExceededGroup
                    : ValidationResult.RequiredMissingGroup;

            return new SegmentErrorContext(instanceContext.GetId(), segmentIndex, errorCode);
        }

        private SegmentErrorContext ValidateSegment(IList list, InstanceContext instanceContext, int segmentIndex)
        {
            var errorCode = list.Count > MaxCount
                    ? ValidationResult.CountExceededSegment
                    : ValidationResult.RequiredMissingSegment;

            return new SegmentErrorContext(instanceContext.GetId(), segmentIndex, errorCode);
        }

        private SegmentErrorContext ValidateComposite(IList list, InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex)
        {
            if (instanceContext.Parent == null || !instanceContext.Parent.IsPropertyOfType<SegmentAttribute>())
                throw new Exception(string.Format("Parent of composite {0} must be a segment.",
                    instanceContext.Property.Name));

            var errorCode = list.Count > MaxCount
                ? ValidationResult.CountExceededComposite
                : ValidationResult.RequiredMissingComposite;

            var repIndex = list.Count > MaxCount
                ? MaxCount + 1
                : MinCount - list.Count + 1;

            var result = new SegmentErrorContext(instanceContext.Parent.GetId(), segmentIndex);
            result.Add(instanceContext.GetId(), inSegmentIndex, errorCode, 0, repIndex, null);
            return result;
        }

        private SegmentErrorContext ValidateDataElement(IList list, InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex, int inCompositeIndex)
        {
            if (instanceContext.Parent == null)
                throw new Exception(
                    string.Format("Parent of data element {0} must be either a segment or a composite.",
                        instanceContext.Property.Name));

            var errorCode = list.Count > MaxCount
                ? ValidationResult.CountExceededDataElement
                : ValidationResult.RequiredMissingDataElement;

            var repIndex = list.Count > MaxCount
                ? MaxCount + 1
                : MinCount - list.Count + 1;

            var segmentName = instanceContext.Parent.IsPropertyOfType<SegmentAttribute>()
                ? instanceContext.Parent.GetId()
                : instanceContext.Parent.GetDeclaringTypeId();

            var dataElementAttr = instanceContext.Property.GetCustomAttribute<DataElementAttribute>();
            var name = dataElementAttr == null ? "" : dataElementAttr.Code;

            var result = new SegmentErrorContext(segmentName, segmentIndex);
            result.Add(name, inSegmentIndex, errorCode, inCompositeIndex, repIndex, null);
            return result;
        }
    }
}
