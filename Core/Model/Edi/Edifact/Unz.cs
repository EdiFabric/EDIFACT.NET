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
using EdiFabric.Core.Annotations.Validation;

namespace EdiFabric.Core.Model.Edi.Edifact
{
    /// <summary>
    /// Interchange trailer.
    /// </summary>
    [Serializable()]
    [Segment("UNZ")]
    public class UNZ : EdiSegment
    {
        [Required]
        [StringLength(1, 6)]
        [DataElement("0036", typeof(EDIFACT_N))]
        [Pos(1)]
        public string InterchangeControlCount_1 { get; set; }

        [Required]
        [StringLength(1, 14)]
        [DataElement("0020", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string InterchangeControlReference_2 { get; set; }
    }  
}
