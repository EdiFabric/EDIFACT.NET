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
using System.Linq;

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
            if (context == null) throw new ArgumentNullException("context");

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
            foreach (var code in ErrorContext.Codes)
            {
                yield return
                    string.Format("[Message {0} with ControlNr {1}] failed with {2} .", ErrorContext.Name,
                        ErrorContext.ControlNumber, code.ToString());
            }

            foreach (var error in ErrorContext.Errors)
            {
                foreach (var code in error.Codes)
                {
                    yield return
                        string.Format("[Message {0} with ControlNr {1}] [Segment {2} with Position {3}] failed with {4} .",
                            ErrorContext.Name,
                            ErrorContext.ControlNumber, error.Name, error.Position, code.ToString());
                }

                foreach (var deError in error.Errors)
                {
                    var errorMsg = string.Format(
                            "[Message {0} with ControlNr {1}] [Segment {2} with Position {3}] [DataElement {4} with Position {5}",
                            ErrorContext.Name,
                            ErrorContext.ControlNumber, error.Name, error.Position, deError.Name, deError.Position);

                    if (deError.ComponentPosition > 1)
                        errorMsg = string.Concat(errorMsg, string.Format(" and ComponentPosition {0}", deError.ComponentPosition));
                    if (deError.RepetitionPosition > 1)
                        errorMsg = string.Concat(errorMsg, string.Format(" and RepetitionPosition {0}", deError.RepetitionPosition));
                    if (!string.IsNullOrEmpty(deError.Value))
                        errorMsg = string.Concat(errorMsg, string.Format(" and Value {0}", deError.Value));

                    errorMsg = string.Concat(errorMsg, string.Format("] failed with {0} .", deError.Code.ToString()));

                    yield return errorMsg;
                }
            }
        }
    }
}
