using System;
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework.Exceptions
{
    public class ControlParsingException : ParsingException
    {
        public ControlParsingException(ErrorCodes errorCode) : base(errorCode)
        {
        }

        public ControlParsingException(ErrorCodes errorCode, Exception ex)
            : base(errorCode, ex)
        {
        }
    }
}
