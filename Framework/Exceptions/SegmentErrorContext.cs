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

using System.Collections.Generic;

namespace EdiFabric.Framework.Exceptions
{
    /// <summary>
    /// The error context of what and where had failed. 
    /// </summary>
    public class SegmentErrorContext
    {
        /// <summary>
        /// The segment tag.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The 1 based segment position within the message.
        /// </summary>
        public int Position { get; private set; }

        private readonly List<ErrorCodes> _codes = new List<ErrorCodes>();

        /// <summary>
        /// The error codes.
        /// </summary>
        public IReadOnlyCollection<ErrorCodes> Codes
        {
            get { return _codes.AsReadOnly(); }
        }

        private readonly List<DataElementErrorContext> _errors = new List<DataElementErrorContext>();

        /// <summary>
        /// The segment errors.
        /// </summary>
        public IReadOnlyCollection<DataElementErrorContext> Errors
        {
            get { return _errors.AsReadOnly(); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentErrorContext"/> class.
        /// </summary>
        /// <param name="name">The segment name.</param>
        /// <param name="position">The segment position.</param>
        internal SegmentErrorContext(string name, int position)
        {
            Name = name;
            Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentErrorContext"/> class.
        /// </summary>
        /// <param name="name">The segment name.</param>
        /// <param name="position">The segment position.</param>
        /// <param name="errorCode">The error code.</param>
        internal SegmentErrorContext(string name, int position, ErrorCodes errorCode)
            : this(name, position)
        {
            _codes.Add(errorCode);
        }

        /// <summary>
        /// Adds error code.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        internal void Add(ErrorCodes errorCode)
        {
            _codes.Add(errorCode);
        }

        /// <summary>
        /// Adds data element context to the errors collection.
        /// </summary>
        /// <param name="name">The data element name.</param>
        /// <param name="position">The data element position.</param>
        /// <param name="code">The error code.</param>
        /// <param name="componentPosition">The component data element position.</param>
        /// <param name="repetitionPosition">The repetition position.</param>
        /// <param name="value">The data element value;</param>
        internal void Add(string name, int position, ErrorCodes code, int componentPosition,
            int repetitionPosition, string value)
        {
            _errors.Add(new DataElementErrorContext(name, position, code, componentPosition, repetitionPosition, value));
        }
    }
}
