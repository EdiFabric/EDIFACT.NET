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
    /// Parsing exceptions for messages.
    /// Only thrown when parsing messages.
    /// </summary>
    public class MessageParsingException : ParsingException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageParsingException"/> class.
        /// The error message is what corresponds to the error code.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        public MessageParsingException(ErrorCodes errorCode) : base(errorCode)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageParsingException"/> class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="message">The error message.</param>
        public MessageParsingException(ErrorCodes errorCode, string message)
            : base(errorCode, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageParsingException"/> class.
        /// The error message is what corresponds to the error code.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="ex">The inner exception.</param>
        public MessageParsingException(ErrorCodes errorCode, Exception ex) : base(errorCode, ex)
        {
        }
    }
}
