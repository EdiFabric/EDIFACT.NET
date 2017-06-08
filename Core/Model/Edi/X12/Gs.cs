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
    /// Functional Group header.
    /// </summary>
    [Serializable()]
    [Segment("GS")]
    public class GS : EdiItem
    {
        [Required]
        [StringLength(2, 2)]
        [DataElement("479", null)]
        [Pos(1)]
        public string CodeIdentifyingInformationType_1 { get; set; }

        [Required]
        [StringLength(2, 15)]
        [DataElement("142", typeof(X12_AN))]
        [Pos(2)]
        public string SenderIDCode_2 { get; set; }

        [Required]
        [StringLength(2, 15)]
        [DataElement("124", typeof(X12_AN))]
        [Pos(3)]
        public string ReceiverIDCode_3 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_4 { get; set; }

        [Required]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(5)]
        public string Time_5 { get; set; }

        [Required]
        [StringLength(1, 9)]
        [DataElement("28", typeof(X12_N0))]
        [Pos(6)]
        public string GroupControlNumber_6 { get; set; }

        [Required]
        [StringLength(1, 2)]
        [DataElement("455", null)]
        [Pos(7)]
        public string TransactionTypeCode_7 { get; set; }
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("480", typeof(X12_AN))]
        [Pos(8)]
        public string VersionAndRelease_8 { get; set; }
    }
}
