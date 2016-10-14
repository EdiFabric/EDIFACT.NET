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
    /// Abstract EDI item
    /// </summary>
    public abstract class EdiItem
    {
        /// <summary>
        /// The value of the item.
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiItem"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        protected EdiItem(object value)
        {
            Value = value;
        }
    }
}
