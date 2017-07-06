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

namespace EdiFabric.Core.Model.Edi.X12
{
    /// <summary>
    /// Interchange acknowledgment.
    /// </summary>
    [Serializable()]
    [Segment("TA1")]
    public class TA1 : EdiSegment
    {
        [Required]
        [StringLength(9, 9)]
        [DataElement("I12", typeof(X12_N0))]
        [Pos(1)]
        public string InterchangeControlNumber_1 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("I08", typeof(X12_DT))]
        [Pos(2)]
        public string InterchangeDate_2 { get; set; }

        [Required]
        [StringLength(4, 4)]
        [DataElement("I09", typeof(X12_TM))]
        [Pos(3)]
        public string InterchangeTime_3 { get; set; }

        [Required]
        [DataElement("I17", typeof(X12_ID_I17))]
        [Pos(4)]
        public string InterchangeAcknowledgmentCode_4 { get; set; }

        [Required]
        [DataElement("I18", typeof(X12_ID_I18))]
        [Pos(5)]
        public string InterchangeNoteCode_5 { get; set; }        
    }      
}
