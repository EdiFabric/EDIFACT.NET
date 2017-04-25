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

namespace EdiFabric.Framework.Controls.X12
{
    /// <summary>
    /// This class represents X12 group.
    /// Each group can only contain messages of the same type.
    /// </summary>
    /// <typeparam name="T">The type of the messages that this group can contain.</typeparam>
    public class X12Group<T> : EdiContainer<GS, T, GE>, IEdiGroup
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="X12Group{T}"/> class.
        /// </summary>
        /// <param name="header">The group header.</param>
        public X12Group(GS header)
            : base(header, (gs, i) => new GE
            {
                NumberOfIncludedSets_1 = i.ToString(),
                GroupControlNumber_2 = gs.GroupControlNumber_6
            }, Separators.DefaultX12)
        {
        }
    }
}
