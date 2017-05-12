using System;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Framework.Exceptions
{
    class SegmentException : Exception
    {
        /// <summary>
        /// The segment error context.
        /// </summary>
        public SegmentErrorContext ErrorContext { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderException"/> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="errorContext">The segment error context.</param>
        public SegmentException(string message, SegmentErrorContext errorContext)
            : base(message)
        {
            ErrorContext = errorContext;
        }
    }
}
