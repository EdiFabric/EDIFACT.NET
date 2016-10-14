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
    /// System error codes for all know error conditions.
    /// </summary>
    public enum ErrorCodes
    {
        /// <summary>
        /// N/A
        /// </summary>
        Unknown,

        /// <summary>
        /// Invalid Control Structure
        /// </summary>
        InvalidControlStructure,

        /// <summary>
        /// Invalid Interchange Content
        /// </summary>
        InvalidInterchangeContent,

        /// <summary>
        /// Improper End of File
        /// </summary>
        ImproperEndOfFile,

        /// <summary>
        /// Invalid Segment Terminator
        /// </summary>
        InvalidSegmentTerminator,

        /// <summary>
        /// Segment is blank
        /// </summary>
        BlankSegment,

        /// <summary>
        /// Segment Id is unknown
        /// </summary>
        UnrecognizedSegmentId,
    }
}
