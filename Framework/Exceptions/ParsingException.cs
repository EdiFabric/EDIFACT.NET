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
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        public ParsingException(ErrorCodes errorCode) : base(errorCode.ToDescription())
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        public ParsingException(ErrorCodes errorCode, Exception ex)
            : base(errorCode.ToDescription(), ex)
        {
            ErrorCode = errorCode;
        }
    }
}
