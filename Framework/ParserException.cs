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

namespace EdiFabric.Framework
{
    /// <summary>
    /// The exception that is thrown for all known parsing failures.
    /// Always includes the line which failed to parse.
    /// </summary>
    /// <example>
    /// Catch line parsing exception.
    /// <code lang="C#">
    /// try
    /// {
    ///     var interchange = Interchange.LoadFrom(File.OpenRead(@"c:\test.edi"));
    /// }
    /// catch (ParserException ex)
    /// {
    ///     // ex.Message contains the line that failed
    ///     // ex.InnerException contains the real exception
    /// }
    /// </code>
    /// </example>
    public class ParserException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParserException"/> class.
        /// </summary>
        public ParserException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParserException"/> class.
        /// </summary>
        /// <param name="message">
        /// Custom message
        /// </param>
        public ParserException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParserException"/> class.
        /// </summary>
        /// <param name="message">
        /// Custom message
        /// </param>
        /// <param name="inner">
        /// The inner exception
        /// </param>
        public ParserException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
