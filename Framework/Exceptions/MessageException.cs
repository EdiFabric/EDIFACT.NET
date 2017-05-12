using System;
using EdiFabric.Core.ErrorCodes;

namespace EdiFabric.Framework.Exceptions
{
    class MessageException : Exception
    {
        /// <summary>
        /// The error code.
        /// </summary>
        public MessageErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderException"/> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="errorCode">The error code.</param>
        public MessageException(string message, MessageErrorCode errorCode)
            : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
