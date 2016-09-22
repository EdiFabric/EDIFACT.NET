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

namespace EdiFabric.Framework
{
    /// <summary>
    /// EDI Message.
    /// </summary>
    public class EdiMessage<T, TU>
    {
        /// <summary>
        /// The interchange header.
        /// </summary>
        public T InterchangeHeader { get; private set; }
        /// <summary>
        /// The group header.
        /// </summary>
        public TU GroupHeader { get; private set; }
        /// <summary>
        /// The EDI message
        /// </summary>
        public object Value { get; private set; }
        /// <summary>
        /// The separators.
        /// </summary>
        public Separators Separators { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiMessage{T, TU}"/> class.
        /// </summary>
        /// <param name="value">The message.</param>
        /// <param name="interchangeHeader">The interchange header.</param>
        /// <param name="groupHeader">The group header.</param>
        /// <param name="separators">The separators.</param>
        public EdiMessage(object value, T interchangeHeader, TU groupHeader, Separators separators)
        {
            InterchangeHeader = interchangeHeader;
            GroupHeader = groupHeader;
            Value = value;
            Separators = separators;
        }
    }
}
