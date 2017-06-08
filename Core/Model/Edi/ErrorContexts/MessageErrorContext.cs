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
using System.Linq;
using EdiFabric.Core.ErrorCodes;

namespace EdiFabric.Core.Model.Edi.ErrorContexts
{
    /// <summary>
    /// Information for the data, error codes and the context of the message that failed.  
    /// </summary>
    public sealed class MessageErrorContext : ErrorContext
    {
        /// <summary>
        /// The type of message (or its tag).
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The message control number.
        /// </summary>
        public string ControlNumber { get; private set; }

        /// <summary>
        /// Message part index.
        /// </summary>
        public int MessagePart { get; private set; }
        
        private readonly List<MessageErrorCode> _codes = new List<MessageErrorCode>();
        /// <summary>
        /// The syntax error codes.
        /// </summary>
        public IReadOnlyCollection<MessageErrorCode> Codes
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
        /// <param name="messagePart">Message part index.</param>
        /// <param name="message">The error message.</param>
        public MessageErrorContext(string name, string controlNumber, int messagePart, string message) 
            : base(message)
        {
            Name = name;
            ControlNumber = controlNumber;
            MessagePart = messagePart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageErrorContext"/> class.
        /// </summary>
        /// <param name="name">The message name (or tag).</param>
        /// <param name="controlNumber">The message control number.</param>
        /// <param name="messagePart">Message part index.</param>
        /// <param name="message">The error message.</param>
        /// <param name="errorCode">The syntax error code.</param>
        public MessageErrorContext(string name, string controlNumber, int messagePart, string message, MessageErrorCode errorCode)
            : this(name, controlNumber, messagePart, message)
        {
            _codes.Add(errorCode);
        }
        
        /// <summary>
        /// Merges a segment context into the errors collection.
        /// There can be only one reference for a segment, containing all the errors for that segment.
        /// A segment is identified by its name (or segment ID) and its position.
        /// </summary>
        /// <param name="segmentContexts">The segment error contexts to merge.</param>
        public void AddRange(IEnumerable<SegmentErrorContext> segmentContexts)
        {
            foreach (var segmentContext in segmentContexts)
                Add(segmentContext);
        }

        /// <summary>
        /// Merges segment contexts into the errors collection.
        /// </summary>
        /// <param name="segmentContext">The segment error contexts to merge.</param>
        public void Add(SegmentErrorContext segmentContext)
        {
            var key = segmentContext.Name + segmentContext.Position;
            if (_errors.ContainsKey(key))
            {
                foreach (var error in segmentContext.Errors)
                    _errors[key].Add(new DataElementErrorContext(error.Name, error.Position, error.Code, error.ComponentPosition,
                        error.RepetitionPosition, error.Value));
            }
            else
            {
                _errors.Add(key, segmentContext);
            }
        }

        /// <summary>
        /// Merges error codes into the error codes collection.
        /// </summary>
        /// <param name="errorCodes">The error codes to merge.</param>
        public void AddRange(IEnumerable<MessageErrorCode> errorCodes)
        {
            foreach (var errorCode in errorCodes)
                Add(errorCode);
        }

        /// <summary>
        /// Adds a syntax error code to the error codes collection.
        /// </summary>
        /// <param name="errorCode">The syntax error code.</param>
        public void Add(MessageErrorCode errorCode)
        {
            if (!_codes.Contains(errorCode))
                _codes.Add(errorCode);
        }

        /// <summary>
        /// Flattens the error hierarchy.
        /// Iterates through all errors in all contexts and outputs an easy to read error message
        /// for each error or code found.
        /// </summary>
        /// <returns>
        /// A collection of formatted error messages.
        /// </returns>
        public IEnumerable<string> Flatten()
        {
            foreach (var code in Codes)
            {
                yield return
                    string.Format("[{0} with control nr {1}] {2}", Name,
                        ControlNumber, code);
            }

            foreach (var error in Errors)
            {
                foreach (var code in error.Codes)
                {
                    var errorMsg = string.Format("[{0}", error.Name);

                    if (error.Position > 0)
                        errorMsg = string.Concat(errorMsg, string.Format(" at pos {0}", error.Position));

                    errorMsg = string.Concat(errorMsg, string.Format("] {0}", code));
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

                    errorMsg = string.Concat(errorMsg, string.Format("] {0}", deError.Code));

                    yield return errorMsg;
                }
            }
        }
    }
}
