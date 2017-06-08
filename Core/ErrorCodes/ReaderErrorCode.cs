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
    /// The reader error codes.
    /// </summary>
    public enum ReaderErrorCode
    {
        /// <summary>
        /// N/A
        /// </summary>
        Unknown,

        /// <summary>
        /// When the spec cannot be loaded (custom).
        /// </summary>
        InvalidSpecOrAssembly,

        /// <summary>
        /// 022
        /// </summary>
        InvalidControlStructure,

        /// <summary>
        /// 023
        /// </summary>
        ImproperEndOfFile,

        /// <summary>
        /// 024
        /// </summary>
        InvalidInterchangeContent
    }
}
