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

namespace EdiFabric.Core.Annotations.Edi
{
    /// <summary>
    /// Attribute to mark a no-sequence group.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class AllAttribute : EdiAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllAttribute"/> class.
        /// </summary>
        public AllAttribute()
            : base(null)
        {
        }
    }
}
