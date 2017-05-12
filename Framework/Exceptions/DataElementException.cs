using System;
using EdiFabric.Core.ErrorCodes;

namespace EdiFabric.Framework.Exceptions 
{
    class DataElementException: Exception
    {
        public string Name { get; private set; }
        public int Position { get; private set; }
        public DataElementErrorCode ErrorCode { get; private set; }
        public string Value { get; private set; }
        public int ComponentPosition { get; private set; }
        public int RepetitionPosition { get; private set; }

        public DataElementException(string message, string name, int position, DataElementErrorCode errorCode, string value,
            int compositePosition, int repetitionPosition)
            : base(message)
        {
            Name = name;
            Position = position;
            ErrorCode = errorCode;
            Value = value;
            ComponentPosition = compositePosition;
            RepetitionPosition = repetitionPosition;
        }

        public DataElementException(string message, DataElementErrorCode errorCode, int compositePosition)
            : base(message)
        {
            ErrorCode = errorCode;
            ComponentPosition = compositePosition;
        }
    }
}
