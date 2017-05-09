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
using EdiFabric.Core.Model.Validation;

namespace EdiFabric.Core.Annotations.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class ValidationAttribute : Attribute
    {
        protected ValidationAttribute(int priority)
        {
            Priority = priority;
        }

        public int Priority { get; private set; }

        public abstract List<ErrorContextSegment> IsValid(InstanceContext instanceContext, int segmentIndex, int inSegmentIndex,
            int inCompositeIndex, int repetitionIndex);
    }
}
