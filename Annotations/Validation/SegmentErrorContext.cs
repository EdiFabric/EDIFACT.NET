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

namespace EdiFabric.Annotations.Validation
{
    /// <summary>
    /// Information for the data, error codes and the context of the data elements that failed.
    /// </summary>
    [Serializable]
    public class SegmentErrorContext
    {
        /// <summary>
        /// The segment ID.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The numerical count position of the data segment from the start of the transaction set.
        /// The transaction set header is count position 1.
        /// </summary>
        public int Position { get; private set; }

        private readonly List<ValidationResult> _codes = new List<ValidationResult>();
        /// <summary>
        /// The syntax error codes.
        /// </summary>
        public IReadOnlyCollection<ValidationResult> Codes
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
        {
            Name = name;
            Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentErrorContext"/> class.
        /// </summary>
        /// <param name="name">The segment ID.</param>
        /// <param name="position">The segment position.</param>
        /// <param name="errorCode">The syntax error code.</param>
        public SegmentErrorContext(string name, int position, ValidationResult errorCode)
            : this(name, position)
        {
            _codes.Add(errorCode);
        }

        /// <summary>
        /// Adds a syntax error code to the error codes collection.
        /// </summary>
        /// <param name="errorCode">The syntax error code.</param>
        public void Add(ValidationResult errorCode)
        {
            _codes.Add(errorCode);
        }

        /// <summary>
        /// Adds a new data element context into the errors collection.
        /// </summary>
        /// <param name="name">The data element name.</param>
        /// <param name="position">The data element position.</param>
        /// <param name="code">The error code.</param>
        /// <param name="componentPosition">The component data element position.</param>
        /// <param name="repetitionPosition">The repetition position.</param>
        /// <param name="value">The data element value;</param>
        public void Add(string name, int position, ValidationResult code, int componentPosition,
            int repetitionPosition, string value)
        {
            _errors.Add(new DataElementErrorContext(name, position, code, componentPosition, repetitionPosition, value));
        }
    }
}
