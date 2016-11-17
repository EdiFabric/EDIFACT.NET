//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace EdiFabric.Framework.Exceptions
{
    /// <summary>
    /// Validation exception.
    /// </summary>
    public class ValidationException : Exception
    {
        /// <summary>
        /// The error context.
        /// </summary>
        public MessageErrorContext ErrorContext { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="context">The error context.</param>
        public ValidationException(string message, MessageErrorContext context)
            : base(message)
        {
            ErrorContext = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="context">The error context.</param>
        /// <param name="ex">The inner exception.</param>
        public ValidationException(string message, MessageErrorContext context, Exception ex)
            : base(message, ex)
        {
            ErrorContext = context;
        }

        /// <summary>
        /// Flattens the error hierarchy.
        /// </summary>
        /// <returns>
        /// Collection of error strings.
        /// </returns>
        public IEnumerable<string> Flatten()
        {
            if (ErrorContext != null)
            {
                foreach (var code in ErrorContext.Codes)
                {
                    yield return
                        string.Format("[{0} with control nr {1}] {2}", ErrorContext.Name,
                            ErrorContext.ControlNumber, code.ToDescription());
                }

                foreach (var error in ErrorContext.Errors)
                {
                    foreach (var code in error.Codes)
                    {
                        var errorMsg = string.Format("[{0}", error.Name);

                        if (error.Position > 0)
                            errorMsg = string.Concat(errorMsg, string.Format(" at pos {0}", error.Position));

                        errorMsg = string.Concat(errorMsg, string.Format("] {0}", code.ToDescription()));
                        yield return errorMsg;
                    }

                    foreach (var deError in error.Errors)
                    {
                        var errorMsg = string.Format(
                            "[{0} at pos {1}] [{2}",
                            error.Name, error.Position, deError.Name);

                        if (deError.Position > 0)
                            errorMsg = string.Concat(errorMsg, string.Format(" at pos {0}", deError.Position));

                        if (deError.ComponentPosition > 1)
                            errorMsg = string.Concat(errorMsg,
                                string.Format(" and at component pos {0}", deError.ComponentPosition));
                        if (deError.RepetitionPosition > 1)
                            errorMsg = string.Concat(errorMsg,
                                string.Format(" and at repetition pos {0}", deError.RepetitionPosition));
                        if (!string.IsNullOrEmpty(deError.Value))
                            errorMsg = string.Concat(errorMsg, string.Format(" with value {0}", deError.Value));

                        errorMsg = string.Concat(errorMsg, string.Format("] {0}", deError.Code.ToDescription()));

                        yield return errorMsg;
                    }
                }
            }
        }
    }
}
