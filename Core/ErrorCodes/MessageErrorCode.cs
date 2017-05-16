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
    /// EDI message error codes.
    /// Used in AK502 or IK502.
    /// </summary>
    public enum MessageErrorCode
    {
        /// <summary>
        /// 1
        /// </summary>
        TransactionSetNotSupported,

        /// <summary>
        /// 2
        /// </summary>
        MessageTrailerMissing,
        
        /// <summary>
        /// 3
        /// </summary>
        ControlNumberNotMatching,

        /// <summary>
        /// 4
        /// </summary>
        SegmentsCountNotMatching,

        /// <summary>
        /// 5
        /// </summary>
        MessageWithErrors,

        /// <summary>
        /// 6
        /// </summary>
        MissingOrInvalidTransactionSet,

        /// <summary>
        /// 7
        /// </summary>
        MissingOrInvalidControlNumber,

        /// <summary>
        /// 23
        /// </summary>
        DuplicateMessageControlNumber
    }
}
