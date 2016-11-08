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
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework.Exceptions
{
    /// <summary>
    /// General parsing exceptions.
    /// </summary>
    public class ParsingException : Exception
    {
        /// <summary>
        /// The error code.
        /// </summary>
        public ErrorCodes ErrorCode { get; private set; }

        /// <summary>
        /// The parsing details.
        /// </summary>
        public ParsingDetails Details { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="details">The parsing details.</param>
        public ParsingException(ErrorCodes errorCode, ParsingDetails details = null) : base(errorCode.ToDescription())
        {
            ErrorCode = errorCode;
            Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="message">The error message.</param>
        /// /// <param name="details">The parsing details.</param>
        public ParsingException(ErrorCodes errorCode, string message, ParsingDetails details = null)
            : base(message)
        {
            ErrorCode = errorCode;
            Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="ex">The inner exception.</param>
        /// /// <param name="details">The parsing details.</param>
        public ParsingException(ErrorCodes errorCode, Exception ex, ParsingDetails details = null)
            : base(errorCode.ToDescription(), ex)
        {
            ErrorCode = errorCode;
            Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="message">The error message.</param>
        /// <param name="ex">The inner exception.</param>
        /// /// <param name="details">The parsing details.</param>
        public ParsingException(ErrorCodes errorCode, string message, Exception ex, ParsingDetails details = null)
            : base(message, ex)
        {
            ErrorCode = errorCode;
            Details = details;
        }
    }
}
