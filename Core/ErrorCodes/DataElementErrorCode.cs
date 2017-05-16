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

namespace EdiFabric.Core.ErrorCodes
{
    /// <summary>
    /// EDI data element error codes.
    /// Used in AK403 or IK403.
    /// </summary>
    public enum DataElementErrorCode
    {
        /// <summary>
        /// 1
        /// </summary>
        RequiredDataElementMissing,

        /// <summary>
        /// 3
        /// </summary>
        TooManyDataElements,

        /// <summary>
        /// 4
        /// </summary>
        DataElementTooShort,

        /// <summary>
        /// 5
        /// </summary>
        DataElementTooLong,

        /// <summary>
        /// 7
        /// </summary>
        InvalidCodeValue,

        /// <summary>
        /// 12
        /// </summary>
        TooManyRepetitions,

        /// <summary>
        /// 13
        /// </summary>
        TooManyComponents,

        /// <summary>
        /// I11
        /// </summary>
        TooFewRepetitions
    }
}
