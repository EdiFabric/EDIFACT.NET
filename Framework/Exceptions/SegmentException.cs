using System;
using EdiFabric.Core.Model.Edi.Exceptions;

namespace EdiFabric.Framework.Exceptions
{
    class SegmentException : Exception
    {
        /// <summary>
        /// The segment error context.
        /// </summary>
        public ErrorContextSegment ErrorContext { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderException"/> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="errorContext">The segment error context.</param>
        public SegmentException(string message, ErrorContextSegment errorContext)
            : base(message)
        {
            ErrorContext = errorContext;
        }
    }
}
