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
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Core.Model.Ack
{
    /// <summary>
    /// This class contains the data raised by the message event.
    /// </summary>
    public abstract class MessageEventArgs<T, U> : EventArgs
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
        /// The message error context.
        /// </summary>
        public MessageErrorContext ErrorContext { get; private set; }  
        /// <summary>
        /// Detects if the message is part of a duplicate group.
        /// </summary>
        public bool InDuplicateGroup { get; private set; }
        /// <summary>
        /// Detects if the message is part of a duplicate interchange.
        /// </summary>
        public bool InDuplicateInterchange { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageEventArgs{T, U}"/> class.
        /// </summary>
        /// <param name="message">The EDI message.</param>
        /// <param name="errorContext">The message error context.</param>
        /// <param name="groupHeader">The group header.</param>
        /// <param name="interchangeHeader">The interchange header.</param>
        /// <param name="inDuplicateGroup">Detects if the message is part of a duplicate group.</param>
        /// <param name="inDuplicateInterchange">Detects if the message is part of a duplicate interchange.</param>
        protected MessageEventArgs(T interchangeHeader, U groupHeader, EdiMessage message, MessageErrorContext errorContext,
            bool inDuplicateGroup, bool inDuplicateInterchange)
        {
            InterchangeHeader = interchangeHeader;
            GroupHeader = groupHeader;
            Message = message;
            ErrorContext = errorContext;
            InDuplicateGroup = inDuplicateGroup;
            InDuplicateInterchange = inDuplicateInterchange;
        }
    }
}
