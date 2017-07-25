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
using System.Collections.Generic;
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

    /// <summary>
    /// Functional Group header.
    /// </summary>
    [Serializable()]
    [Segment("GS")]
    public class GS : EdiSegment
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

    /// <summary>
    /// Transaction header.
    /// </summary>
    [Serializable()]
    [Segment("ST")]
    public class ST : EdiSegment
    {

        [Pos(1)]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
        [Pos(3)]
        public string ImplementationConventionPreference_03 { get; set; }
    }

    /// <summary>
    /// Transaction trailer.
    /// </summary>
    [Serializable()]
    [Segment("SE")]
    public class SE : EdiSegment
    {

        [Pos(1)]
        public string NumberofIncludedSegments_01 { get; set; }
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
    }

    /// <summary>
    /// Functional Group trailer.
    /// </summary>
    [Serializable()]
    [Segment("GE")]
    public class GE : EdiSegment
    {
        [Required]
        [StringLength(1, 6)]
        [DataElement("97", typeof(X12_N0))]
        [Pos(1)]
        public string NumberOfIncludedSets_1 { get; set; }

        [Required]
        [StringLength(1, 9)]
        [DataElement("28", typeof(X12_N0))]
        [Pos(2)]
        public string GroupControlNumber_2 { get; set; }
    }

    /// <summary>
    /// Interchange trailer.
    /// </summary>
    [Serializable()]
    [Segment("IEA")]
    public class IEA : EdiSegment
    {
        [Required]
        [StringLength(1, 5)]
        [DataElement("I16", typeof(X12_N0))]
        [Pos(1)]
        public string NumberOfIncludedGroups_1 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("I12", typeof(X12_N0))]
        [Pos(2)]
        public string InterchangeControlNumber_2 { get; set; }
    }

    [Serializable()]
    [Segment("AK9")]
    public class AK9
    {

        [Pos(1)]
        public string FunctionalGroupAcknowledgeCode_01 { get; set; }
        [Pos(2)]
        public string NumberofTransactionSetsIncluded_02 { get; set; }
        [Pos(3)]
        public string NumberofReceivedTransactionSets_03 { get; set; }
        [Pos(4)]
        public string NumberofAcceptedTransactionSets_04 { get; set; }
        [Pos(5)]
        public string FunctionalGroupSyntaxErrorCode_05 { get; set; }
        [Pos(6)]
        public string FunctionalGroupSyntaxErrorCode_06 { get; set; }
        [Pos(7)]
        public string FunctionalGroupSyntaxErrorCode_07 { get; set; }
        [Pos(8)]
        public string FunctionalGroupSyntaxErrorCode_08 { get; set; }
        [Pos(9)]
        public string FunctionalGroupSyntaxErrorCode_09 { get; set; }
    }

    [Serializable()]
    [Segment("AK5")]
    public class AK5
    {

        [Pos(1)]
        public string TransactionSetAcknowledgmentCode_01 { get; set; }
        [Pos(2)]
        public string TransactionSetSyntaxErrorCode_02 { get; set; }
        [Pos(3)]
        public string TransactionSetSyntaxErrorCode_03 { get; set; }
        [Pos(4)]
        public string TransactionSetSyntaxErrorCode_04 { get; set; }
        [Pos(5)]
        public string TransactionSetSyntaxErrorCode_05 { get; set; }
        [Pos(6)]
        public string TransactionSetSyntaxErrorCode_06 { get; set; }
    }

    [Serializable()]
    [Segment("AK4")]
    public class AK4
    {

        [Pos(1)]
        public C030 PositioninSegment_01 { get; set; }
        [Pos(2)]
        public string DataElementReferenceNumber_02 { get; set; }
        [Pos(3)]
        public string DataElementSyntaxErrorCode_03 { get; set; }
        [Pos(4)]
        public string CopyofBadDataElement_04 { get; set; }
    }

    [Serializable()]
    [Segment("AK3")]
    public class AK3
    {

        [Pos(1)]
        public string SegmentIDCode_01 { get; set; }
        [Pos(2)]
        public string SegmentPositioninTransactionSet_02 { get; set; }
        [Pos(3)]
        public string LoopIdentifierCode_03 { get; set; }
        [Pos(4)]
        public string SegmentSyntaxErrorCode_04 { get; set; }
    }

    [Serializable()]
    [Segment("AK2")]
    public class AK2
    {

        [Pos(1)]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
        [Pos(3)]
        public string ImplementationConventionReference_03 { get; set; }
    }

    [Serializable()]
    [Segment("AK1")]
    public class AK1
    {

        [Pos(1)]
        public string FunctionalIdentifierCode_01 { get; set; }
        [Pos(2)]
        public string GroupControlNumber_02 { get; set; }
        [Pos(3)]
        public string VersionReleaseIndustryIdentifierCode_03 { get; set; }
    }

    [Serializable()]
    [Segment("IK5")]
    public class IK5
    {

        [Pos(1)]
        public string TransactionSetAcknowledgmentCode_01 { get; set; }
        [Pos(2)]
        public string ImplementationTransactionSetSyntaxErrorCode_02 { get; set; }
        [Pos(3)]
        public string ImplementationTransactionSetSyntaxErrorCode_03 { get; set; }
        [Pos(4)]
        public string ImplementationTransactionSetSyntaxErrorCode_04 { get; set; }
        [Pos(5)]
        public string ImplementationTransactionSetSyntaxErrorCode_05 { get; set; }
        [Pos(6)]
        public string ImplementationTransactionSetSyntaxErrorCode_06 { get; set; }
    }

    [Serializable()]
    [Segment("CTX")]
    public class CTX
    {

        [Pos(1)]
        public List<C998> ContextIdentification_01 { get; set; }
        [Pos(2)]
        public string SegmentIDCode_02 { get; set; }
        [Pos(3)]
        public string SegmentPositioninTransactionSet_03 { get; set; }
        [Pos(4)]
        public string LoopIdentifierCode_04 { get; set; }
        [Pos(5)]
        public C030 PositioninSegment_05 { get; set; }
        [Pos(6)]
        public C999 ReferenceinSegment_06 { get; set; }
    }

    [Serializable()]
    [Segment("IK4")]
    public class IK4
    {

        [Pos(1)]
        public C030 PositioninSegment_01 { get; set; }
        [Pos(2)]
        public string DataElementReferenceNumber_02 { get; set; }
        [Pos(3)]
        public string ImplementationDataElementSyntaxErrorCode_03 { get; set; }
        [Pos(4)]
        public string CopyofBadDataElement_04 { get; set; }
    }

    [Serializable()]
    [Segment("IK3")]
    public class IK3
    {

        [Pos(1)]
        public string SegmentIDCode_01 { get; set; }
        [Pos(2)]
        public string SegmentPositioninTransactionSet_02 { get; set; }
        [Pos(3)]
        public string LoopIdentifierCode_03 { get; set; }
        [Pos(4)]
        public string ImplementationSegmentSyntaxErrorCode_04 { get; set; }
    }

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
