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

namespace EdiFabric.Framework.Items
{
    /// <summary>
    /// EDI Message.
    /// </summary>
    public class EdiMessage : EdiItem
    {
        /// <summary>
        /// The separators.
        /// </summary>
        public Separators Separators { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiMessage"/> class.
        /// </summary>
        /// <param name="value">The message.</param>
        /// <param name="separators">The separators.</param>
        public EdiMessage(object value, Separators separators) : base(value)
        {
            Separators = separators;
        }
    }
}
