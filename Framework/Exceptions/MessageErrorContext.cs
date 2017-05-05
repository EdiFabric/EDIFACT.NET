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
using EdiFabric.Annotations.Validation;

namespace EdiFabric.Framework.Exceptions
{
    /// <summary>
    /// Information for the data, error codes and the context of the segments that failed.  
    /// </summary>
    [Serializable]
    public class MessageErrorContext
    {
        /// <summary>
        /// The type of message (or its tag).
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The message control number.
        /// </summary>
        public string ControlNumber { get; private set; }
        
        private readonly List<ErrorCodes> _codes = new List<ErrorCodes>();
        /// <summary>
        /// The syntax error codes.
        /// </summary>
        public IReadOnlyCollection<ErrorCodes> Codes
        {
            get { return _codes.AsReadOnly(); }
        }

        private readonly Dictionary<string, SegmentErrorContext> _errors = new Dictionary<string, SegmentErrorContext>();
        /// <summary>
        /// The segment error contexts.
        /// </summary>
        public IReadOnlyCollection<SegmentErrorContext> Errors
        {
            get { return _errors.Values.ToList().AsReadOnly(); }
        }
        
        /// <summary>
        /// Indicates if the message had any errors when parsed.
        /// </summary>
        public bool HasErrors
        {
            get { return Errors.Any() || Codes.Any(); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageErrorContext"/> class.
        /// </summary>
        /// <param name="name">The message name (or tag).</param>
        /// <param name="controlNumber">The message control number.</param>
        public MessageErrorContext(string name, string controlNumber)
        {
            Name = name;
            ControlNumber = controlNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageErrorContext"/> class.
        /// </summary>
        /// <param name="name">The message name (or tag).</param>
        /// <param name="controlNumber">The message control number.</param>
        /// <param name="errorCode">The syntax error code.</param>
        public MessageErrorContext(string name, string controlNumber, ErrorCodes errorCode)
            : this(name, controlNumber)
        {
            _codes.Add(errorCode);
        }        

        /// <summary>
        /// Merges a segment context into the errors collection.
        /// There can be only one reference for a segment, containing all the errors for that segment.
        /// A segment is identified by its name (or segment ID) and its position.
        /// </summary>
        /// <param name="segmentContext">The segment error context to merge.</param>
        public void Add(SegmentErrorContext segmentContext)
        {
            var key = segmentContext.Name + segmentContext.Position;
            if (_errors.ContainsKey(key))
            {
                foreach (var error in segmentContext.Errors)
                    _errors[key].Add(error.Name, error.Position, error.Code, error.ComponentPosition,
                        error.RepetitionPosition, error.Value);
            }
            else
            {
                _errors.Add(key, segmentContext);
            }
        }

        /// <summary>
        /// Merges a segment context into the errors collection.
        /// There can be only one reference for a segment, containing all the errors for that segment.
        /// A segment is identified by its name (or segment ID) and its position.
        /// </summary>
        /// <param name="segmentContexts">The collection of segment error contexts to merge.</param>
        public void AddRange(IEnumerable<SegmentErrorContext> segmentContexts)
        {
            foreach (var segmentContext in segmentContexts)
            {
                Add(segmentContext);
            }
        }

        /// <summary>
        /// Merges a segment context into the errors collection.
        /// There can be only one reference for a segment, containing all the errors for that segment.
        /// A segment is identified by its name (or segment ID) and its position.
        /// </summary>
        /// <param name="segmentName">The segment name.</param>
        /// <param name="segmentPosition">The segment position.</param>
        /// <param name="errorCode">The syntax error code.</param>
        public void Add(string segmentName, int segmentPosition, ValidationResult errorCode)
        {
            var key = segmentName + segmentPosition;
            if (_errors.ContainsKey(key))
            {
                _errors[key].Add(errorCode);
            }
            else
            {
                _errors.Add(key, new SegmentErrorContext(segmentName, segmentPosition, errorCode));
            }
        }

        /// <summary>
        /// Merges a segment context into the errors collection.
        /// There can be only one reference for a segment, containing all the errors for that segment.
        /// A segment is identified by its name (or segment ID) and its position.
        /// </summary>
        /// <param name="segmentName">The segment name.</param>
        /// <param name="segmentPosition">The segment position.</param>
        /// <param name="name">The data element name.</param>
        /// <param name="position">The data element position.</param>
        /// <param name="code">The syntax error code.</param>
        /// <param name="componentPosition">The component data element position.</param>
        /// <param name="repetitionPosition">The repetition position.</param>
        /// <param name="value">The data element value;</param>
        public void Add(string segmentName, int segmentPosition, string name, int position, ValidationResult code, int componentPosition,
            int repetitionPosition, string value)
        {
            var key = segmentName + segmentPosition;
            if (_errors.ContainsKey(key))
            {
                _errors[key].Add(name, position, code, componentPosition, repetitionPosition, value);
            }
            else
            {
                var segmentContext = new SegmentErrorContext(segmentName, segmentPosition);
                segmentContext.Add(name, position, code, componentPosition, repetitionPosition, value);
                _errors.Add(key, segmentContext);
            }
        }

        /// <summary>
        /// Adds a syntax error code to the error codes collection.
        /// </summary>
        /// <param name="errorCode">The syntax error code.</param>
        public void Add(ErrorCodes errorCode)
        {
            _codes.Add(errorCode);
        }
    }
}
