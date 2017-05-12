using System;

namespace EdiFabric.Core.Model.Edi.Exceptions
{
    public class ErrorContextReader : IEdiItem
    {
        /// <summary>
        /// The reader error code.
        /// </summary>
        public ReaderErrorCode ReaderErrorCode { get; private set; }

        /// <summary>
        /// The reader exception.
        /// </summary>
        public Exception Exception { get; private set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorContextReader"/> class.
        /// </summary>

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorContextReader"/> class.
        /// </summary>
        /// <param name="errorCode">The reader error code.</param>
        public ErrorContextReader(ReaderErrorCode errorCode)
        {
            ReaderErrorCode = errorCode;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorContextReader"/> class.
        /// </summary>
        /// <param name="exception">The reader exception.</param>
        /// <param name="errorCode">The reader error code.</param>
        public ErrorContextReader(Exception exception, ReaderErrorCode errorCode)
        {
            Exception = exception;
            ReaderErrorCode = errorCode;
        }
    }
}
