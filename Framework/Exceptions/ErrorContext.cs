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

namespace EdiFabric.Framework.Exceptions
{
    /// <summary>
    /// The error context of what and where had failed. 
    /// </summary>
    public class ErrorContext
    {
        /// <summary>
        /// The segment tag.
        /// </summary>
        public string SegmentName { get; set; }
        /// <summary>
        /// The 1 based segment position within the message.
        /// </summary>
        public int SegmentPosition { get; set; }
        /// <summary>
        /// Whether the segment is supported in the rules class.
        /// </summary>
        public bool SegmentNotSupported { get; set; }
        /// <summary>
        /// Whether the segment is for a loop.
        /// </summary>
        public bool SegmentForLoop { get; set; }
        /// <summary>
        /// The name of the data element.
        /// </summary>
        public string DataElementName { get; set; }
        /// <summary>
        /// The position of the data element within the segment.
        /// </summary>
        public int DataElementPosition { get; set; }
        /// <summary>
        /// The position of the component data element within the data element.
        /// </summary>
        public int ComponentDataElementPosition { get; set; }
        /// <summary>
        /// The value of the data element that failed to be parsed.
        /// </summary>
        public string DataElementValue { get; set; }
    }
}
