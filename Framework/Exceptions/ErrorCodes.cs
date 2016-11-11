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
    /// System error codes for all know error conditions.
    /// </summary>
    public enum ErrorCodes
    {
        /// <summary>
        /// N/A
        /// </summary>
        Unknown,

        /// <summary>
        /// Invalid control structure
        /// </summary>
        InvalidControlStructure,

        /// <summary>
        /// Invalid interchange content
        /// </summary>
        InvalidInterchangeContent,

        /// <summary>
        /// Improper end of file
        /// </summary>
        ImproperEndOfFile,

        /// <summary>
        /// The name of the rules assembly was not set 
        /// </summary>
        RulesAssemblyNameNotSet,

        /// <summary>
        /// Unexpected message
        /// </summary>
        UnexpectedMessage,

        /// <summary>
        /// Unexpected segment
        /// </summary>
        UnexpectedSegment,

        /// <summary>
        /// Unexpected segment
        /// </summary>
        UnrecognizedSegment,

        /// <summary>
        /// Data elements are too many
        /// </summary>
        DataElementsTooMany,

        /// <summary>
        /// Component data elements are too many
        /// </summary>
        ComponentDataElementsTooMany,

        /// <summary>
        /// Data elements are too many
        /// </summary>
        UnableToResolveHl,

        /// <summary>
        /// Missing required item
        /// </summary>
        RequiredMissing,

        /// <summary>
        /// Unexpected item
        /// </summary>
        Unexpected,

        /// <summary>
        /// DataElement length is wrong.
        /// </summary>
        DataElementLengthWrong,

        /// <summary>
        /// DataElement is too short.
        /// </summary>
        DataElementTooShort,

        /// <summary>
        /// DataElement is too long.
        /// </summary>
        DataElementTooLong,

        /// <summary>
        /// DataElement value is wrong.
        /// </summary>
        DataElementValueWrong

    }
}
