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
        SegmentTerminatorNotFound,

        /// <summary>
        /// The name of the rules assembly was not set in config
        /// </summary>
        RulesAssemblyNameNotSet,

        /// <summary>
        /// Type not found in assembly
        /// </summary>
        TypeNotFound,

        /// <summary>
        /// Invalid GS
        /// </summary>
        GsInvalid,

        /// <summary>
        /// Missing GS
        /// </summary>
        GsNotFound,

        /// <summary>
        /// Missing ST
        /// </summary>
        StNotFound,

        /// <summary>
        /// Invalid UNH
        /// </summary>
        UnhInvalid,

        /// <summary>
        /// Missing UNH
        /// </summary>
        UnhNotFound,

        /// <summary>
        /// Missing segment
        /// </summary>
        SegmentNotFound,

        /// <summary>
        /// Data elements count is different
        /// </summary>
        DataElementsNumberMismatch,

        /// <summary>
        /// Segment not defined in class
        /// </summary>
        SegmentNotDefined,

        
    }
}
