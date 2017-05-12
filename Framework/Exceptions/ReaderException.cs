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

using System;
using EdiFabric.Core.ErrorCodes;

namespace EdiFabric.Framework.Exceptions
{
    /// <summary>
    /// Parsing exception.
    /// Raised during the parsing of EDI documents.
    /// </summary>
    class ReaderException : Exception
    {
        /// <summary>
        /// The reader error code.
        /// </summary>
        public ReaderErrorCode ErrorCode { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderException"/> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="errorCode">The reader error code.</param>
        public ReaderException(string message, ReaderErrorCode errorCode)
            : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
