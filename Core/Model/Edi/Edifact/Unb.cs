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
    /// Interchange header.
    /// </summary>
    [Serializable()]
    [Segment("UNB")]
    public class UNB : EdiSegment
    {
        [Required]
        [Pos(1)]
        public S001 SYNTAXIDENTIFIER_1 { get; set; }

        [Required]
        [Pos(2)]
        public S002 INTERCHANGESENDER_2 { get; set; }

        [Required]
        [Pos(3)]
        public S003 INTERCHANGERECIPIENT_3 { get; set; }

        [Required]
        [Pos(4)]
        public S004 DATEANDTIMEOFPREPARATION_4 { get; set; }

        [StringLength(1, 14)]
        [DataElement("0020", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string InterchangeControlReference_5 { get; set; }

        [Pos(6)]
        public S005 RECIPIENTSREFERENCEPASSWORDDETAILS_6 { get; set; }

        [StringLength(1, 14)]
        [DataElement("0026", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string ApplicationReference_7 { get; set; }

        [DataElement("0029", typeof(EDIFACT_ID_0029))]
        [Pos(8)]
        public string ProcessingPriorityCode_8 { get; set; }

        [StringLength(1, 1)]
        [DataElement("0031", typeof(EDIFACT_N))]
        [Pos(9)]
        public string AcknowledgementRequest_9 { get; set; }

        [StringLength(1, 35)]
        [DataElement("0032", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string InterchangeAgreementIdentifier_10 { get; set; }

        [DataElement("0035", typeof(EDIFACT_ID_0035))]
        [Pos(11)]
        public string TestIndicator_11 { get; set; }
    }

    /// <summary>
    /// SYNTAX IDENTIFIER.
    /// </summary>
    [Serializable()]
    [Composite("S001")]
    public class S001
    {
        [Required]
        [DataElement("0001", typeof(EDIFACT_ID_0001))]
        [Pos(1)]
        public string SyntaxIdentifier_1 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("0002", typeof(EDIFACT_N))]
        [Pos(2)]
        public string SyntaxVersionNumber_2 { get; set; }

        [StringLength(1, 6)]
        [DataElement("0080", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ServiceCodeListDirectoryVersionNumber_3 { get; set; }

        [DataElement("0133", typeof(EDIFACT_ID_0133))]
        [Pos(4)]
        public string CharacterEncoding_4 { get; set; }
    }

    /// <summary>
    /// INTERCHANGE SENDER.
    /// </summary>
    [Serializable()]
    [Composite("S002")]
    public class S002
    {
        [Required]
        [StringLength(1, 35)]
        [DataElement("0004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InterchangeSenderIdentification_1 { get; set; }

        [DataElement("0007", typeof(EDIFACT_ID_0007))]
        [Pos(2)]
        public string IdentificationCodeQualifier_2 { get; set; }

        [StringLength(1, 35)]
        [DataElement("0008", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string InterchangeSenderInternalIdentification_3 { get; set; }

        [StringLength(1, 35)]
        [DataElement("0042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string InterchangeSenderInternalSubIdentification_4 { get; set; }
    }

    /// <summary>
    /// INTERCHANGE RECIPIENT.
    /// </summary>
    [Serializable()]
    [Composite("S003")]
    public class S003
    {
        [Required]
        [StringLength(1, 35)]
        [DataElement("0010", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InterchangeRecipientIdentification_1 { get; set; }

        [DataElement("0007", typeof(EDIFACT_ID_0007))]
        [Pos(2)]
        public string IdentificationCodeQualifier_2 { get; set; }

        [StringLength(1, 35)]
        [DataElement("0014", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string InterchangeRecipientInternalIdentification_3 { get; set; }

        [StringLength(1, 35)]
        [DataElement("0046", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string InterchangeRecipientInternalSubIdentification_4 { get; set; }
    }

    /// <summary>
    /// DATE AND TIME OF PREPARATION.
    /// </summary>
    [Serializable()]
    [Composite("S004")]
    public class S004
    {
        [Required]
        [StringLength(6, 8)]
        [DataElement("0017", typeof(EDIFACT_DT))]
        [Pos(1)]
        public string Date_1 { get; set; }

        [Required]
        [StringLength(4, 4)]
        [DataElement("0019", typeof(EDIFACT_TM))]
        [Pos(2)]
        public string Time_2 { get; set; }
    }

    /// <summary>
    /// RECIPIENT'S REFERENCE/PASSWORD DETAILS.
    /// </summary>
    [Serializable()]
    [Composite("S005")]
    public class S005
    {
        [Required]
        [StringLength(1, 14)]
        [DataElement("0022", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RecipientReferencePassword_1 { get; set; }

        [DataElement("0025", typeof(EDIFACT_ID_0025))]
        [Pos(2)]
        public string RecipientReferencePasswordQualifier_2 { get; set; }
    }
}
