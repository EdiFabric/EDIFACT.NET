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
using EdiFabric.Core.Annotations.Edi;

namespace EdiFabric.Core.Model.Edi.X12
{
    /// <summary>
    /// Functional Group trailer.
    /// </summary>
    [Serializable()]
    [Segment("GE")]
    public class GE : EdiItem
    {
        [Pos(1)]
        public string NumberOfIncludedSets_1 { get; set; }

        [Pos(2)]
        public string GroupControlNumber_2 { get; set; }
    }
}
