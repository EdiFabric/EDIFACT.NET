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

namespace EdiFabric.Core.Model.Edi.ErrorContexts
{
    /// <summary>
    /// The abstract error context.
    /// </summary>
    public abstract class ErrorContext : EdiItem
    {
        /// <summary>
        /// Error message.
        /// </summary>
        protected string Message { get; private set; }

        /// <summary>
        /// Protected constructor. Initializes a new instance of the <see cref="ErrorContext"/> class.
        /// </summary>
        /// <param name="message">Error message.</param>
        protected ErrorContext(string message)
        {
            Message = message;
        }
    }
}
