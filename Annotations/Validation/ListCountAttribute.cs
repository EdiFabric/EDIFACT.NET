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
namespace EdiFabric.Annotations.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ListCountAttribute : ValidationAttribute
    {
        public int MinCount { get; set; }
        public int MaxCount { get; set; }

        public ListCountAttribute(int minCount, int maxCount)
        {
            MinCount = minCount;
            MaxCount = maxCount;
        }

        public ListCountAttribute(int maxCount)
        {
            MinCount = 0;
            MaxCount = maxCount;
        }

        public override ValidationResult IsValid(object intance)
        {
            var list = intance as IList;
            if (list == null)
                throw new Exception("[EdiMax] attribute can only be applied to lists.");

            if (list.Count > MaxCount)
                return ValidationResult.Unexpected;

            if (list.Count < MinCount)
                return ValidationResult.RequiredMissing;

            return ValidationResult.Valid;
        }
    }
}
