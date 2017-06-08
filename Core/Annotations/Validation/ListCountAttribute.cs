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
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Core.Annotations.Validation
{
    /// <summary>
    /// Validation attribute for lists. Sets the minimum and maximum of the contained items.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ListCountAttribute : ValidationAttribute
    {
        /// <summary>
        /// The minimum allowed items.
        /// </summary>
        public int MinCount { get; private set; }
        /// <summary>
        /// The maximum allowed items.
        /// </summary>
        public int MaxCount { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCountAttribute"/> class.
        /// </summary>
        /// <param name="minCount">The minimum allowed items.</param>
        /// <param name="maxCount">The maximum allowed items.</param>
        public ListCountAttribute(int minCount, int maxCount) : base(2)
        {
            MinCount = minCount;
            MaxCount = maxCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCountAttribute"/> class.
        /// </summary>
        /// <param name="maxCount">The maximum allowed items.</param>
        public ListCountAttribute(int maxCount) : base(2)
        {
            MinCount = 0;
            MaxCount = maxCount;
        }

        /// <summary>
        /// Detects if a list has a valid number of items.
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
                    ? SegmentErrorCode.LoopExceedsMaximumUse
                    : SegmentErrorCode.LoopBelowMinimumUse;

            var repIndex = list.Count > MaxCount
                    ? segmentIndex + 1 + MaxCount
                    : segmentIndex + MinCount;

            return new SegmentErrorContext(instanceContext.GetId(), repIndex, errorCode);
        }

        private SegmentErrorContext ValidateSegment(IList list, InstanceContext instanceContext, int segmentIndex)
        {
            var errorCode = list.Count > MaxCount
                    ? SegmentErrorCode.SegmentExceedsMaximumUse
                    : SegmentErrorCode.SegmentBelowMinimumUse;

            var repIndex = list.Count > MaxCount
                    ? segmentIndex + 1 + MaxCount
                    : segmentIndex + MinCount;

            return new SegmentErrorContext(instanceContext.GetId(), repIndex, errorCode);
        }

        private SegmentErrorContext ValidateComposite(IList list, InstanceContext instanceContext,
            int segmentIndex, int inSegmentIndex)
        {
            if (instanceContext.Parent == null || !instanceContext.Parent.IsPropertyOfType<SegmentAttribute>())
                throw new Exception(string.Format("Parent of composite {0} must be a segment.",
                    instanceContext.Property.Name));

            var errorCode = list.Count > MaxCount
                ? DataElementErrorCode.TooManyRepetitions
                : DataElementErrorCode.TooFewRepetitions;

            var repIndex = list.Count > MaxCount
                ? MaxCount + 1
                : MinCount - list.Count + 1;

            var result = new SegmentErrorContext(instanceContext.Parent.GetId(), segmentIndex);
            var errorContext = new DataElementErrorContext(instanceContext.GetId(), inSegmentIndex, errorCode, 0,
                repIndex, null);
            result.Add(errorContext);
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
                ? DataElementErrorCode.TooManyRepetitions
                : DataElementErrorCode.TooFewRepetitions;

            var repIndex = list.Count > MaxCount
                ? MaxCount + 1
                : MinCount - list.Count + 1;

            var value = list.Count > MaxCount
                ? list[MaxCount] as string
                : null;

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
            var errorContext = new DataElementErrorContext(name, inSegmentIndex, errorCode, inCompositeIndex, repIndex, value);
            result.Add(errorContext);
            return result;
        }
    }
}
