using System;
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework.Exceptions
{
    public class ParsingException : Exception
    {
        /// <summary>
        /// The error code.
        /// </summary>
        public ErrorCodes ErrorCode { get; private set; }

        public ParsingException(ErrorCodes errorCode) : base(errorCode.ToDescription())
        {
            ErrorCode = errorCode;
        }

        public ParsingException(ErrorCodes errorCode, Exception ex)
            : base(errorCode.ToDescription(), ex)
        {
            ErrorCode = errorCode;
        }
    }
}
