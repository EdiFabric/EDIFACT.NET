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
    /// The internal error codes for all known error conditions.
    /// </summary>
    public enum ErrorCodes
    {
        /// <summary>
        /// N/A
        /// </summary>
        Unknown,

        /// <summary>
        /// Interchange control structure is invalid.
        /// </summary>
        InvalidControlStructure,

        /// <summary>
        /// Invalid interchange content.
        /// </summary>
        InvalidInterchangeContent,

        /// <summary>
        /// Unprocessed segments found before the end of the file.
        /// </summary>
        ImproperEndOfFile,

        /// <summary>
        /// The rules assembly is not set. 
        /// </summary>
        RulesAssemblyNameNotSet,

        /// <summary>
        /// Transaction set is not supported.
        /// </summary>
        UnexpectedMessage,

        /// <summary>
        /// Segment is not expected at this position.
        /// </summary>
        UnexpectedSegment,

        /// <summary>
        /// Segment is not in defined transaction set.
        /// </summary>
        UnrecognizedSegment,

        /// <summary>
        /// Too many data elements.
        /// </summary>
        DataElementsTooMany,

        /// <summary>
        /// Too many component data elements.
        /// </summary>
        ComponentDataElementsTooMany,

        /// <summary>
        /// Mandatory item is missing.
        /// </summary>
        RequiredMissing,

        /// <summary>
        /// Item exceeds maximum use.
        /// </summary>
        Unexpected,

        /// <summary>
        /// Data element has incorrect length.
        /// </summary>
        DataElementLengthWrong,

        /// <summary>
        /// Data element is too short.
        /// </summary>
        DataElementTooShort,

        /// <summary>
        /// Data element is too long.
        /// </summary>
        DataElementTooLong,

        /// <summary>
        /// Invalid code value.
        /// </summary>
        DataElementValueWrong,

        /// <summary>
        /// Message validation failed.
        /// </summary>
        ValidationFailed,

        /// <summary>
        /// Transaction set trailer missing.
        /// </summary>
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
