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

namespace EdiFabric.Annotations.Validation
{
    /// <summary>
    /// The internal error codes for all known error conditions.
    /// </summary>
    public enum ValidationResult
    {
        RequiredMissingAll,
        RequiredMissingGroup,
        RequiredMissingSegment,
        RequiredMissingComposite,
        RequiredMissingDataElement,
        CountExceededGroup,
        CountExceededSegment,
        CountExceededComposite,
        CountExceededDataElement,
        DataElementTooShort,
        DataElementTooLong,
        InvalidCodeValue,
    }
}
