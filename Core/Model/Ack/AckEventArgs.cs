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
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Core.Model.Ack
{
    /// <summary>
    /// This class contains the data raised by the message event.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public abstract class AckEventArgs<T, U> : EventArgs
    {
        /// <summary>
        /// The interchange header.
        /// </summary>
        public T InterchangeHeader { get; private set; }
        /// <summary>
        /// The group header.
        /// </summary>
        public U GroupHeader { get; private set; }
        /// <summary>
        /// The EDI message.
        /// </summary>
        public EdiMessage Message { get; private set; }
        /// <summary>
        /// The acknowledgment type.
        /// </summary>
        public AckType AckType { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AckEventArgs{T, U}"/> class.
        /// </summary>
        /// <param name="interchangeHeader">The interchange header.</param>
        /// <param name="groupHeader">The group header.</param>
        /// <param name="message">The EDI message.</param>
        /// <param name="ackType">The acknowledgment type.</param>
        protected AckEventArgs(T interchangeHeader, U groupHeader, EdiMessage message, AckType ackType)
        {
            InterchangeHeader = interchangeHeader;
            GroupHeader = groupHeader;
            Message = message;
            AckType = ackType;
        }
    }
}
