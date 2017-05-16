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
    /// EDI segment error codes.
    /// Used in AK304 or IK304.
    /// </summary>
    public enum SegmentErrorCode
    {
        /// <summary>
        /// 1
        /// </summary>
        UnrecognizedSegment,

        /// <summary>
        /// 3
        /// </summary>
        RequiredSegmentMissing,

        /// <summary>
        /// 4
        /// </summary>
        LoopExceedsMaximumUse,

        /// <summary>
        /// 5
        /// </summary>
        SegmentExceedsMaximumUse,

        /// <summary>
        /// 7
        /// </summary>
        SegmentNotInProperSequence,
                
        /// <summary>
        /// I7
        /// </summary>
        LoopBelowMinimumUse,
        /// <summary>
        /// I8
        /// </summary>
        SegmentBelowMinimumUse
    }
}
