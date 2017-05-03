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
using System.Runtime.Serialization;
using EdiFabric.Annotations.Model;

namespace EdiFabric.Framework.Exceptions
{
    /// <summary>
    /// Parsing exception.
    /// Raised during the parsing of EDI documents.
    /// </summary>
    [Serializable]
    public class ParsingException : Exception, ISerializable, IEdiItem
    {
        /// <summary>
        /// The syntax error code.
        /// </summary>
        public string PositionInRule
        {
            get
            {
                return (Data.Contains("PositionInRule")) ? (string)Data["PositionInRule"] : null;
            }

            private set
            {
                if (value == null && Data.Contains("PositionInRule"))
                {
                    Data.Remove("PositionInRule");
                }
                else
                {
                    Data["PositionInRule"] = value;
                }
            }
        }

        /// <summary>
        /// The syntax error code.
        /// </summary>
        public ErrorCodes ErrorCode
        {
            get
            {
                return ((ErrorCodes)Data["ErrorCode"]);
            }

            private set
            {
                Data["ErrorCode"] = value;
            }
        }

        /// <summary>
        /// The line (or segment) that failed.
        /// </summary>
        public string FailedLine
        {
            get
            {
                return (Data.Contains("FailedLine")) ? (string)Data["FailedLine"] : null;
            }

            private set
            {
                if (value == null && Data.Contains("FailedLine"))
                {
                    Data.Remove("FailedLine");
                }
                else
                {
                    Data["FailedLine"] = value;
                }
            }
        }

        /// <summary>
        /// The message error context.
        /// </summary>
        public MessageErrorContext ErrorContext
        {
            get
            {
                return (Data.Contains("ErrorContext")) ? (MessageErrorContext)Data["ErrorContext"] : null;
            }

            private set
            {
                if (value == null && Data.Contains("MessageErrorContext"))
                {
                    Data.Remove("MessageErrorContext");
                }
                else
                {
                    Data["MessageErrorContext"] = value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        /// <param name="errorCode">The syntax error code.</param>
        /// <param name="message">The error message.</param>
        public ParsingException(ErrorCodes errorCode, string message)
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
        public ParsingException(ErrorCodes errorCode, string message, string failedLine)
            : base(message)
        {
            ErrorCode = errorCode;
            FailedLine = failedLine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        /// <param name="errorCode">The syntax error code.</param>
        /// <param name="message">The error message.</param>
        /// <param name="failedLine">The line that failed.</param>
        /// <param name="context">The error context.</param>
        public ParsingException(ErrorCodes errorCode, string message, string failedLine, MessageErrorContext context)
            : base(message)
        {
            ErrorCode = errorCode;
            FailedLine = failedLine;
            ErrorContext = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingException"/> class.
        /// </summary>
        /// <param name="ex">The inner exception.</param>
        public ParsingException(Exception ex)
            : base(ex.Message, ex)
        {
            ErrorCode = ErrorCodes.Unknown;
        }


        #region ISerializable Implementation

        /// <summary>
        /// Deserialization constructor
        /// </summary>
        protected ParsingException(SerializationInfo info, StreamingContext context) : base (info, context)
        {
        }
       
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        #endregion ISerializable
    }
}
