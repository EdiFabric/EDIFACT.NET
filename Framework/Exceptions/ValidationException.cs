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

namespace EdiFabric.Framework.Exceptions
{
    /// <summary>
    /// Validation exception.
    /// </summary>
    public class ValidationException : Exception
    {
        /// <summary>
        /// The error code.
        /// </summary>
        public ErrorCodes ErrorCode { get; private set; }

        /// <summary>
        /// The error context.
        /// </summary>
        public ErrorContext ErrorContext { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="message">The error message.</param>
        /// <param name="context">The error context.</param>
        public ValidationException(ErrorCodes errorCode, string message, ErrorContext context = null)
            : base(message)
        {
            ErrorCode = errorCode;
            ErrorContext = context;
        }
    }
}
