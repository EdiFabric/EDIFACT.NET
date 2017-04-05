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

namespace EdiFabric.Framework.Controls.Edifact
{
    /// <summary>
    /// This class represents EDIFACT group.
    /// Each group can only contain messages of the same type.
    /// </summary>
    /// <typeparam name="T">The type of the messages that this group can contain.</typeparam>
    public class EdifactGroup<T> : EdiContainer<UNG, T, UNE>, IEdiGroup
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="EdifactGroup{T}"/> class.
        /// </summary>
        /// <param name="header">The group header.</param>
        public EdifactGroup(UNG header)
            : base(header, (ung, i) => new UNE
            {
                GroupControlCount_1 = i.ToString(),
                GroupReferenceNumber_2 = ung.GroupReferenceNumber_5
            }, Separators.DefaultEdifact())
        {
        }
    }
}
