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

namespace EdiFabric.Framework.Exceptions
{
    /// <summary>
    /// The error context of what and where had failed. 
    /// </summary>
    public class DataElementErrorContext
    {
        /// <summary>
        /// The name of the data element.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The 1 based position of the data element within the segment.
        /// </summary>
        public int Position { get; private set; }
        /// <summary>
        /// The error code.
        /// </summary>
        public ErrorCodes Code { get; private set; }
        /// <summary>
        /// The value of the data element that failed to be parsed.
        /// </summary>
        public string Value { get; private set; }
        /// <summary>
        /// The position of the component data element within the data element.
        /// </summary>
        public int ComponentPosition { get; private set; }
        /// <summary>
        /// The position of the item within the parent.
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
        /// <param name="value">The data element value;</param>
        public DataElementErrorContext(string name, int position, ErrorCodes code, int componentPosition,
            int repetitionPosition, string value)
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
