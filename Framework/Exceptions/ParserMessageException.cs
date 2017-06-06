using System;
using EdiFabric.Core.ErrorCodes;

namespace EdiFabric.Framework.Exceptions
{
    class ParserMessageException : Exception
    {
        public MessageErrorCode ErrorCode { get; set; }
        public string Name { get; private set; }
        public string ControlNumber { get; private set; }

        public ParserMessageException(string name, string controlNumber, string message, MessageErrorCode errorCode)
            : base(message)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            if (string.IsNullOrEmpty(controlNumber)) throw new ArgumentNullException("controlNumber");

            Name = name;
            ControlNumber = controlNumber;
            ErrorCode = errorCode;
        }
    }
}
