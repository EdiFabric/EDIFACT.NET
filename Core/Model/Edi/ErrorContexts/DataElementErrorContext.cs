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

using EdiFabric.Core.ErrorCodes;

namespace EdiFabric.Core.Model.Edi.ErrorContexts
{
    /// <summary>
    /// Information for the position, data and error code of the data element that failed. 
    /// </summary>
    public sealed class DataElementErrorContext : ErrorContext
    {
        /// <summary>
        /// The reference number to locate the data element.
        /// </summary>
        public string Name { get; private set; }
        
        /// <summary>
        /// The relative position of the simple data element, or the relative position
        /// of a composite data structure in error within the segment, count beginning with 1
        /// for the position immediately following the segment ID.
        /// </summary>
        public int Position { get; private set; }
        
        /// <summary>
        /// The syntax error code.
        /// </summary>
        public DataElementErrorCode Code { get; private set; }
        
        /// <summary>
        /// The copy of the data element in error.
        /// </summary>
        public string Value { get; private set; }
        
        /// <summary>
        /// The component data element position within the composite that is an error.
        /// </summary>
        public int ComponentPosition { get; private set; }
        
        /// <summary>
        /// The specific repetition of a data element that is an error.
        /// </summary>
        public int RepetitionPosition { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataElementErrorContext"/> class.
        /// </summary>
        /// <param name="name">The data element name.</param>
        /// <param name="position">The data element position.</param>
        /// <param name="code">The error code.</param>
        /// <param name="componentPosition">The component data element position.</param>
        /// <param name="repetitionPosition">The repetition position.</param>
        /// <param name="value">The data element value.</param>
        /// <param name="message">The message.</param>
        public DataElementErrorContext(string name, int position, DataElementErrorCode code, int componentPosition,
            int repetitionPosition, string value, string message = null)
            : base(message)
        {
            Name = name;
            Position = position;
            Code = code;
            ComponentPosition = componentPosition;
            RepetitionPosition = repetitionPosition;
            Value = value;
        }
    }
}
