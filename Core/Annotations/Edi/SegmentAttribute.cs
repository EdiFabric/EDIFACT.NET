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
    /// Attribute to mark a segment.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class SegmentAttribute : EdiAttribute
    {
        /// <summary>
        /// The EDI codes to match first.
        /// </summary>
        public Type First { get; private set; }
        /// <summary>
        /// The EDI codes to match second.
        /// </summary>
        public Type Second { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentAttribute"/> class.
        /// </summary>
        /// <param name="id">The segment id.</param>
        /// <param name="first">he EDI codes to match first.</param>
        /// <param name="second">The EDI codes to match second.</param>
        public SegmentAttribute(string id, Type first = null, Type second = null)
            : base(id)
        {
            First = first;
            Second = second;
        }
    }
}
