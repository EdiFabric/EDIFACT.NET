using System;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Framework.Exceptions
{
    class ParserMessageException : Exception
    {
        public MessageErrorContext MessageErrorContext { get; private set; }

        public ParserMessageException(MessageErrorContext messageErrorContext)
            : base(messageErrorContext.Message)
        {
            MessageErrorContext = messageErrorContext;
        }
    }
}
