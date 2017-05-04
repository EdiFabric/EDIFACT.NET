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

namespace EdiFabric.Annotations.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class StringLengthAttribute : ValidationAttribute
    {
        public int MinLen { get; set; }
        public int MaxLen { get; set; }

        public StringLengthAttribute(int minLen, int maxLen) : base(3)
        {
            MinLen = minLen;
            MaxLen = maxLen;
        }

        public override ValidationResult IsValid(object intance)
        {
            var value = intance as string;
            if (value == null)
                throw new Exception(string.Format("{0} can only be applied to data elements.", GetType().Name));

            if (value.Length > MaxLen)
                return ValidationResult.DataElementTooLong;

            if (value.Length < MinLen)
                return ValidationResult.DataElementTooShort;

            return ValidationResult.Valid;
        }
    }
}
