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
    /// Functional Group header.
    /// </summary>
    [Serializable()]
    [Segment("UNG")]
    public class UNG : EdiSegment
    {
        [StringLength(1, 6)]
        [DataElement("0038", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MessageGroupIdentification_1 { get; set; }

        [Pos(2)]
        public S006 APPLICATIONSENDERIDENTIFICATION_2 { get; set; }

        [Pos(3)]
        public S007 APPLICATIONRECIPIENTIDENTIFICATION_3 { get; set; }

        [Pos(4)]
        public S004 DATEANDTIMEOFPREPARATION_4 { get; set; }

        [Required]
        [StringLength(1, 14)]
        [DataElement("0048", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string GroupReferenceNumber_5 { get; set; }

        [Required]
        [StringLength(1, 2)]
        [DataElement("0051", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string ControllingAgency_6 { get; set; }

        [Pos(7)]
        public S008 MESSAGEVERSION_7 { get; set; }

        [StringLength(1, 14)]
        [DataElement("0058 ", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string D_ApplicationPassword_8 { get; set; }
    }

    /// <summary>
    /// APPLICATION SENDER IDENTIFICATION.
    /// </summary>
    [Serializable()]
    [Composite("S006")]
    public class S006
    {
        [Required]
        [StringLength(1, 35)]
        [DataElement("0040", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ApplicationSenderIdentification_1 { get; set; }

        [DataElement("0007", typeof(EDIFACT_ID_0007))]
        [Pos(2)]
        public string IdentificationCodeQualifier_2 { get; set; }
    }

    /// <summary>
    /// APPLICATION RECIPIENT IDENTIFICATION.
    /// </summary>
    [Serializable()]
    [Composite("S007")]
    public class S007
    {
        [Required]
        [StringLength(1, 35)]
        [DataElement("0044", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ApplicationRecipientIdentification_1 { get; set; }

        [DataElement("0007", typeof(EDIFACT_ID_0007))]
        [Pos(2)]
        public string IdentificationCodeQualifier_2 { get; set; }
    }

    /// <summary>
    /// MESSAGE VERSION.
    /// </summary>
    [Serializable()]
    [Composite("S008")]
    public class S008
    {
        [Required]
        [StringLength(1, 3)]
        [DataElement("0052 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MessageVersionNumber_1 { get; set; }

        [Required]
        [StringLength(1, 3)]
        [DataElement("0054 ", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MessageReleaseNumber_2 { get; set; }

        [StringLength(1, 6)]
        [DataElement("0057 ", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string AssociationAssignedCode_3 { get; set; }
    }
}
