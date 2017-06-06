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
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Framework.Exceptions
{
    /// <summary>
    /// Thrown during parsing.
    /// </summary>
    class ParserSegmentException : Exception
    {
        /// <summary>
        /// The error context.
        /// </summary>
        public DataElementErrorContext ErrorContext { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ParserSegmentException"/> class.
        /// </summary>
        /// <param name="errorContext">The data element error context.</param>
        public ParserSegmentException(DataElementErrorContext errorContext)
            : base(errorContext.Message)
        {
            ErrorContext = errorContext;
        }
    }
}
