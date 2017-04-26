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

using EdiFabric.Attributes;

namespace EdiFabric.Framework.Segments.Edifact
{
    /// <summary>
    /// Functional Group trailer.
    /// </summary>
    public class UNE : IEdiItem
    {
        [D(1)]
        public string GroupControlCount_1 { get; set; }

        [D(2)]
        public string GroupReferenceNumber_2 { get; set; }
    }
}
