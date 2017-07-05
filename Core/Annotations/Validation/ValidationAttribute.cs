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
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Core.Annotations.Validation
{
    /// <summary>
    /// Abstract attribute for validation.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class ValidationAttribute : Attribute
    {
        /// <summary>
        /// Protected constructor. Initializes a new instance of the <see cref="ValidationAttribute"/> class.
        /// </summary>
        /// <param name="priority"></param>
        protected ValidationAttribute(int priority)
        {
            Priority = priority;
        }

        /// <summary>
        /// The validation attribute priority.
        /// </summary>
        public int Priority { get; private set; }

        /// <summary>
        /// Detects if an item is valid.
        /// </summary>
        /// <param name="instanceContext">The instance context.</param>
        /// <param name="segmentIndex">The segment position.</param>
        /// <param name="inSegmentIndex">The position within the segment.</param>
        /// <param name="inCompositeIndex">The position within the component if any.</param>
        /// <param name="repetitionIndex">The repetition position.</param>
        /// <returns>A list of segment errors if invalid, otherwise nothing.</returns>
        public abstract List<SegmentErrorContext> IsValid(InstanceContext instanceContext, int segmentIndex, int inSegmentIndex,
            int inCompositeIndex, int repetitionIndex);
    }
}
