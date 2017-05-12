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
    public enum MessageErrorCode
    {
        MessageTrailerMissing,

        /// <summary>
        /// Missing or invalid transaction set identifier.
        /// </summary>
        InvalidTransactionSetIdentifier,

        /// <summary>
        /// Transaction set control number in header and trailer do not match.
        /// </summary>
        ControlNumberNotMatching,

        /// <summary>
        /// Number of included segments does not match actual count.
        /// </summary>
        SegmentsCountNotMatching,

        /// <summary>
        /// Invalid transaction set control number.
        /// </summary>
        DuplicateMessageControlNumber,

        /// <summary>
        /// Segment has data element errors.
        /// </summary>
        SegmentWithErrors,

        /// <summary>
        /// One or more segments in error.
        /// </summary>
        MessageWithErrors,

        /// <summary>
        /// Invalid group control number.
        /// </summary>
        DuplicateGroupControlNumber,

        /// <summary>
        /// Invalid interchange control number.
        /// </summary>
        DuplicateInterchangeControlNumber
    }
}
