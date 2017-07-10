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
    /// UNA.
    /// </summary>
    [Serializable()]
    [Segment("UNA")]
    public class UNA : EdiSegment
    {
        [Required]
        [Pos(1)]
        public char ComponentDataElement { get; set; }

        [Required]
        [Pos(2)]
        public char DataElement { get; set; }

        [Required]
        [Pos(3)]
        public char DecimalNotation { get; set; }

        [Required]
        [Pos(4)]
        public char ReleaseIndicator { get; set; }

        [Required]
        [Pos(5)]
        public char Reserved { get; set; }

        [Required]
        [Pos(6)]
        public char Segment { get; set; }

        public string GenerateSegment()
        {
            return "UNA" + ComponentDataElement + DataElement + DecimalNotation + ReleaseIndicator + Reserved + Segment;
        }
    }  
}
