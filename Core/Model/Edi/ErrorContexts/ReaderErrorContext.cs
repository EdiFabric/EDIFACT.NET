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
using EdiFabric.Core.ErrorCodes;

namespace EdiFabric.Core.Model.Edi.ErrorContexts
{
    /// <summary>
    /// The reason for any reader failure.
    /// </summary>
    public sealed class ReaderErrorContext : EdiItem
    {
        /// <summary>
        /// The reader exception.
        /// </summary>
        public Exception Exception { get; private set; }

        /// <summary>
        /// The reader error code.
        /// </summary>
        public ReaderErrorCode ReaderErrorCode { get; private set; }

        /// <summary>
        /// The message context if any.
        /// </summary>
        public MessageErrorContext MessageErrorContext { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderErrorContext"/> class.
        /// </summary>
        /// <param name="exception">The reader exception.</param>
        /// <param name="readerErrorCode">The reader error code.</param>
        /// <param name="messageErrorContext">The message context if any.</param>
        public ReaderErrorContext(Exception exception, ReaderErrorCode readerErrorCode,
            MessageErrorContext messageErrorContext = null)
        {
            Exception = exception;
            ReaderErrorCode = readerErrorCode;
            MessageErrorContext = messageErrorContext;
        }
    }
}
