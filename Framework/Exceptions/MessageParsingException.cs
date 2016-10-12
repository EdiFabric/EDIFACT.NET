using System;
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework.Exceptions
{
    public class MessageParsingException : ParsingException
    {
        public MessageParsingException(ErrorCodes errorCode) : base(errorCode)
        {
        }

        public MessageParsingException(ErrorCodes errorCode, Exception ex) : base(errorCode, ex)
        {
        }
    }
}
