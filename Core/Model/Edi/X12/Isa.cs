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
    /// Interchange header.
    /// </summary>
    [Serializable()]
    [Segment("ISA")]
    public class ISA : EdiSegment
    {
        [Required]
        [DataElement("I01", typeof(X12_ID_I01))]
        [Pos(1)]
        public string AuthorizationInformationQualifier_1 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("I02", typeof(X12_AN))]
        [Pos(2)]
        public string AuthorizationInformation_2 { get; set; }

        [Required]
        [DataElement("I03", typeof(X12_ID_I03))]
        [Pos(3)]
        public string SecurityInformationQualifier_3 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("I04", typeof(X12_AN))]
        [Pos(4)]
        public string SecurityInformation_4 { get; set; }

        [Required]
        [DataElement("I05", typeof(X12_ID_I05))]
        [Pos(5)]
        public string SenderIDQualifier_5 { get; set; }

        [Required]
        [StringLength(15, 15)]
        [DataElement("I06", typeof(X12_AN))]
        [Pos(6)]
        public string InterchangeSenderID_6 { get; set; }

        [Required]
        [DataElement("I05", typeof(X12_ID_I05))]
        [Pos(7)]
        public string ReceiverIDQualifier_7 { get; set; }

        [Required]
        [StringLength(15, 15)]
        [DataElement("I07", typeof(X12_AN))]
        [Pos(8)]
        public string InterchangeReceiverID_8 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("I08", typeof(X12_DT))]
        [Pos(9)]
        public string InterchangeDate_9 { get; set; }

        [Required]
        [StringLength(4, 4)]
        [DataElement("I09", typeof(X12_TM))]
        [Pos(10)]
        public string InterchangeTime_10 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("I65", typeof(X12_TM))]
        [Pos(11)]
        public string InterchangeControlStandardsIdentifier_11 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [Pos(12)]
        public string InterchangeControlVersionNumber_12 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("I12", typeof(X12_N0))]
        [Pos(13)]
        public string InterchangeControlNumber_13 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("I13", null)]
        [Pos(14)]
        public string AcknowledgementRequested_14 { get; set; }

        [Required]
        [DataElement("I14", typeof(X12_ID_I14))]
        [Pos(15)]
        public string UsageIndicator_15 { get; set; }

        [Required]
        [DataElement("I15", null)]
        [Pos(16)]
        public string ComponentElementSeparator_16 { get; set; }
    }  
}
