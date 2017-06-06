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
using EdiFabric.Core.ErrorCodes;

namespace EdiFabric.Core.Model.Edi.ErrorContexts
{
    /// <summary>
    /// Information for the data, error codes and the context of the segments that failed.
    /// </summary>
    public sealed class SegmentErrorContext : ErrorContext
    {
        /// <summary>
        /// The segment ID.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The numerical count position of the segment from the start of the transaction set.
        /// The transaction set header is count position 1.
        /// </summary>
        public int Position { get; private set; }

        /// <summary>
        /// The segment line.
        /// </summary>
        public string Value { get; private set; }

        private readonly List<SegmentErrorCode> _codes = new List<SegmentErrorCode>();
        /// <summary>
        /// The syntax error codes.
        /// </summary>
        public IReadOnlyCollection<SegmentErrorCode> Codes
        {
            get { return _codes.AsReadOnly(); }
        }

        private readonly List<DataElementErrorContext> _errors = new List<DataElementErrorContext>();
        /// <summary>
        /// The data element error contexts.
        /// </summary>
        public IReadOnlyCollection<DataElementErrorContext> Errors
        {
            get { return _errors.AsReadOnly(); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentErrorContext"/> class.
        /// </summary>
        /// <param name="name">The segment ID.</param>
        /// <param name="position">The segment position.</param>
        public SegmentErrorContext(string name, int position)
            : base(null)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            if (position <= 0)
                throw new Exception("position must be greater tan zero.");

            Name = name;
            Position = position;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentErrorContext"/> class.
        /// </summary>
        /// <param name="name">The segment ID.</param>
        /// <param name="position">The segment position.</param>
        /// <param name="value">The segment line.</param>
        /// <param name="message">The message.</param>
        public SegmentErrorContext(string name, int position, string value, string message = null)
            : base(message)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            if (position <= 0)
                throw new Exception("position must be greater tan zero.");

            Name = name;
            Position = position;
            Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentErrorContext"/> class.
        /// </summary>
        /// <param name="name">The segment ID.</param>
        /// <param name="position">The segment position.</param>
        /// <param name="value">The segment line.</param>
        /// <param name="errorCode">The error code.</param>
        /// <param name="message">The message.</param>
        public SegmentErrorContext(string name, int position, string value, SegmentErrorCode errorCode, string message = null)
            : this(name, position, message)
        {
            Value = value;
            _codes.Add(errorCode);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentErrorContext"/> class.
        /// </summary>
        /// <param name="name">The segment ID.</param>
        /// <param name="position">The segment position.</param>
        /// <param name="errorCode">The error code.</param>
        /// <param name="message">The message.</param>
        public SegmentErrorContext(string name, int position, SegmentErrorCode errorCode, string message = null)
            : this(name, position, message)
        {
            _codes.Add(errorCode);
        }
        
        /// <summary>
        /// Adds a syntax error code to the error codes collection.
        /// </summary>
        /// <param name="errorCode">The syntax error code.</param>
        public void Add(SegmentErrorCode errorCode)
        {
            _codes.Add(errorCode);
        }

        /// <summary>
        /// Adds a new data element context into the errors collection.
        /// </summary>
        /// <param name="errorContext">The data element error context.</param>
        public void Add(DataElementErrorContext errorContext)
        {
            _errors.Add(errorContext);
        }
    }
}
