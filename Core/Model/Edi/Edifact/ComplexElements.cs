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
    
    [Serializable()]
    [Composite("S009")]
    public class S009
    {

        [Required]
        [DataElement("0065", typeof(EDIFACT_ID_0065))]
        [Pos(1)]
        public string Messagetype_01 { get; set; }
        [Required]
        [DataElement("0052", typeof(EDIFACT_ID_0052))]
        [Pos(2)]
        public string Messageversionnumber_02 { get; set; }
        [Required]
        [DataElement("0054", typeof(EDIFACT_ID_0054))]
        [Pos(3)]
        public string Messagereleasenumber_03 { get; set; }
        [Required]
        [DataElement("0051", typeof(EDIFACT_ID_0051))]
        [Pos(4)]
        public string Controllingagencycoded_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("0057", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Associationassignedcode_05 { get; set; }
        [StringLength(1, 6)]
        [DataElement("0110", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Codelistdirectoryversionnumber_06 { get; set; }
        [DataElement("0113", typeof(EDIFACT_ID_0113))]
        [Pos(7)]
        public string Messagetypesubfunctionidentification_07 { get; set; }
    }

    [Serializable()]
    [Composite("S010")]
    public class S010
    {

        [Required]
        [StringLength(1, 2)]
        [DataElement("0070", typeof(EDIFACT_N))]
        [Pos(1)]
        public string SequenceMessageTransferNumber_01 { get; set; }
        [StringLength(1, 1)]
        [DataElement("0073", typeof(EDIFACT_A))]
        [Pos(2)]
        public string FirstLastSequenceMessageTransferIndication_02 { get; set; }
    }

    [Serializable()]
    [Composite("S011")]
    public class S011
    {

        [Required]
        [StringLength(1, 3)]
        [DataElement("0098", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Erroneousdataelementpositioninsegment_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0104", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Erroneouscomponentdataelementposition_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("0136", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Erroneousdataelementoccurrence_03 { get; set; }
    }

    [Serializable()]
    [Composite("S016")]
    public class S016
    {

        [Required]
        [StringLength(1, 14)]
        [DataElement("0115", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MessageSubsetIdentification_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0116", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MessageSubsetVersionNumber_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0118", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string MessageSubsetReleaseNumber_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ControllingAgencyCoded_04 { get; set; }
    }

    [Serializable()]
    [Composite("S017")]
    public class S017
    {

        [Required]
        [StringLength(1, 14)]
        [DataElement("0121", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MessageImplementationGuidelineIdentification_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0122", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MessageImplementationGuidelineVersionNumber_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string MessageImplementationGuidelineReleaseNumber_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ControllingAgencyCoded_04 { get; set; }
    }

    [Serializable()]
    [Composite("S018")]
    public class S018
    {

        [Required]
        [StringLength(1, 14)]
        [DataElement("0127", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ScenarioIdentification_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0128", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ScenarioVersionNumber_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ScenarioReleaseNumber_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ControllingAgencyCoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("S020")]
    public class S020
    {

        [Required]
        [DataElement("0813", typeof(EDIFACT_ID_0813))]
        [Pos(1)]
        public string Referencequalifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("0802", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentificationnumber_02 { get; set; }
    }
}
