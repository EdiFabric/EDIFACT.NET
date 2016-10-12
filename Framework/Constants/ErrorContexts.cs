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

namespace EdiFabric.Framework.Constants
{
    /// <summary>
    /// The segment within the acknowledgment and the format.
    /// </summary>
    public enum ErrorContexts
    {
        /// <summary>
        /// N/A
        /// </summary>
        Unknown,
        /// <summary>
        /// X12 TA1
        /// </summary>
        X12Ta1,
        /// <summary>
        /// EDIFACT CONTRL
        /// </summary>
        EdifactContrl,
        /// <summary>
        /// X12 997 AK304 Error Codes
        /// </summary>
        X12997Ak3,
        /// <summary>
        /// X12 997 AK403 Error Codes
        /// </summary>
        X12997Ak4,
        /// <summary>
        /// X12 997 AK502 through AK506 Error Codes
        /// </summary>
        X12997Ak5,
        /// <summary>
        /// X12 997 AK905 through AK909 Error Codes
        /// </summary>
        X12997Ak9
    }
}
