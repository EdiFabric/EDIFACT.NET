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

namespace EdiFabric.Core.Model.Ack
{
    /// <summary>
    /// This class represents an acknowledgment container.
    /// </summary>
    public abstract class AckContainer <T, U, V>
    {
        /// <summary>
        /// The interchange or group header.
        /// </summary>
        public T Header { get; set; }

        /// <summary>
        /// The collection of trailers. Can be more than one for corrupt EDI documents.
        /// </summary>
        public List<U> Trailers { get; private set; }

        /// <summary>
        /// The collection of message error contexts.
        /// </summary>
        public List<V> Errors { get; private set; }

        /// <summary>
        /// If the header is a duplicate.
        /// </summary>
        public bool IsDuplicate { get; set; }

        /// <summary>
        /// Whether an acknowledgments was already generated for this container.
        /// </summary>
        public bool AckGenerated { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AckContainer{T, U, V}"/> class.
        /// </summary>
        protected AckContainer()
        {
            Trailers = new List<U>();
            Errors = new List<V>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AckContainer{T, U, V}"/> class.
        /// </summary>
        /// <param name="header">The interchange or group header.</param>
        /// <param name="isDuplicate">If the header is a duplicate.</param>
        protected AckContainer(T header, bool isDuplicate)
        {
            if (header == null) throw new ArgumentNullException("header");
            
            Header = header;
            Trailers = new List<U>();
            IsDuplicate = isDuplicate;
            Errors = new List<V>();
        }

        /// <summary>
        /// Create a new header from the existing header by swapping the sender and receiver and assigning a new control number.
        /// </summary>
        /// <param name="controlNr">The control number to use.</param>
        /// <param name="version">The version to use.</param>
        /// <returns>Returns a new interchange or group header.</returns>
        public abstract T ToAckHeader(int controlNr, string version);


        /// <summary>
        /// Validates the container.
        /// </summary>
        /// <returns>Returns a list of validation errors if any.</returns>
        public abstract List<string> Validate();       
    }
}
