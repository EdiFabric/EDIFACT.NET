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
using EdiFabric.Annotations.Model;

namespace EdiFabric.Framework
{
    /// <summary>
    /// Parsing exception.
    /// Raised during the parsing of EDI documents.
    /// </summary>
    public class ParsingException : Exception, IEdiItem
    {
        /// <summary>
        /// The syntax error code.
        /// </summary>
        public ErrorCode ErrorCode { get; set; }
        
        /// <summary>
        /// The line (or segment) that failed.
        /// </summary>
        public string FailedLine { get; set; }

        /// <summary>
        /// The message name.
        /// </summary>
        public string MessageName { get; set; }

        /// <summary>
        /// The message control number.
        /// </summary>
        public string MessageControlNumber { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        /// <param name="errorCode">The syntax error code.</param>
        /// <param name="message">The error message.</param>
        public ParsingException(ErrorCode errorCode, string message)
            : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        /// <param name="errorCode">The syntax error code.</param>
        /// <param name="message">The error message.</param>
        /// <param name="failedLine">The line that failed.</param>
        /// <param name="messageName">The message name.</param>
        /// <param name="messageControlNumber">The message control number.</param>
        public ParsingException(ErrorCode errorCode, string message, string failedLine, string messageName, string messageControlNumber)
            : base(message)
        {
            if (string.IsNullOrEmpty(failedLine))
                throw new ArgumentNullException("failedLine");
            if (string.IsNullOrEmpty(messageName))
                throw new ArgumentNullException("messageName");
            if (string.IsNullOrEmpty(messageControlNumber))
                throw new ArgumentNullException("messageControlNumber");

            ErrorCode = errorCode;
            FailedLine = failedLine;
            MessageName = messageName;
            MessageControlNumber = messageControlNumber;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        /// <param name="ex">The inner exception.</param>
        public ParsingException(Exception ex)
            : base(ex.Message, ex)
        {
            ErrorCode = ErrorCode.Unknown;
        }
    }
}
