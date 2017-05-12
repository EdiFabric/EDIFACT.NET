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
    /// Interchange trailer.
    /// </summary>
    [Serializable()]
    [Segment("IEA")]
    public class IEA : IEdiItem 
    {
        [Pos(1)]
        public string NumberOfIncludedGroups_1 { get; set; }

        [Pos(2)]
        public string InterchangeControlNumber_2 { get; set; }
    }     
}
