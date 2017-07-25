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

namespace EdiFabric.Core.Model.Ack
{
    /// <summary>
    /// The type of acknowledgment.
    /// </summary>
    public enum AckType
    {
        /// <summary>
        /// Technical acknowledgment TA1 or CONTRL.
        /// </summary>
        Technical,
        /// <summary>
        /// Functional acknowledgment 997 or CONTRL.
        /// </summary>
        Functional,
        /// <summary>
        /// Implementation acknowledgment 999.
        /// </summary>
        Implementation
    }
}
