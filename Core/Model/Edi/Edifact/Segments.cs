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
    /// Transaction header.
    /// </summary>
    [Serializable()]
    [Segment("UNH")]
    public class UNH : EdiSegment
    {

        [Required]
        [StringLength(1, 14)]
        [DataElement("0062", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MessageReferenceNumber_01 { get; set; }
        [Required]
        [Pos(2)]
        public S009 MessageIdentifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("0068", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CommonAccessReference_03 { get; set; }
        [Pos(4)]
        public S010 StatusoftheTransfer_04 { get; set; }
        [Pos(5)]
        public S016 MessageSubsetIdentification_05 { get; set; }
        [Pos(6)]
        public S017 MessageImplementationGuidelineIdentification_06 { get; set; }
        [Pos(7)]
        public S018 ScenarioIdentification_07 { get; set; }
    }

    /// <summary>
    /// Transaction trailer.
    /// </summary>
    [Serializable()]
    [Segment("UNT")]
    public class UNT : EdiSegment
    {

        [Required]
        [StringLength(1, 10)]
        [DataElement("0074", typeof(EDIFACT_N))]
        [Pos(1)]
        public string NumberofSegmentsinaMessage_01 { get; set; }
        [Required]
        [StringLength(1, 14)]
        [DataElement("0062", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MessageReferenceNumber_02 { get; set; }
    }

    /// <summary>
    /// Functional Group trailer.
    /// </summary>
    [Serializable()]
    [Segment("UNE")]
    public class UNE : EdiSegment
    {
        [Required]
        [StringLength(1, 6)]
        [DataElement("0060", typeof(EDIFACT_N))]
        [Pos(1)]
        public string GroupControlCount_1 { get; set; }

        [Required]
        [StringLength(1, 14)]
        [DataElement("0048", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string GroupReferenceNumber_2 { get; set; }
    }

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

    [Serializable()]
    [Segment("UCD")]
    public class UCD
    {

        [Required]
        [DataElement("0085", typeof(EDIFACT_ID_0085))]
        [Pos(1)]
        public string Syntaxerrorcoded_01 { get; set; }
        [Required]
        [Pos(2)]
        public S011 DATAELEMENTIDENTIFICATION_02 { get; set; }
    }

    [Serializable()]
    [Segment("UCS")]
    public class UCS
    {

        [Required]
        [StringLength(1, 6)]
        [DataElement("0096", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Segmentpositioninmessagebody_01 { get; set; }
        [DataElement("0085", typeof(EDIFACT_ID_0085))]
        [Pos(2)]
        public string Syntaxerrorcoded_02 { get; set; }
    }

    [Serializable()]
    [Segment("UCM")]
    public class UCM
    {

        [StringLength(1, 14)]
        [DataElement("0062", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Messagereferencenumber_01 { get; set; }
        [Pos(2)]
        public S009 MESSAGEIDENTIFIER_02 { get; set; }
        [Required]
        [DataElement("0083", typeof(EDIFACT_ID_0083))]
        [Pos(3)]
        public string Actioncoded_03 { get; set; }
        [DataElement("0085", typeof(EDIFACT_ID_0085))]
        [Pos(4)]
        public string Syntaxerrorcoded_04 { get; set; }
        [DataElement("0135", typeof(EDIFACT_ID_0135))]
        [Pos(5)]
        public string Servicesegmenttagcoded_05 { get; set; }
        [Pos(6)]
        public S011 DATAELEMENTIDENTIFICATION_06 { get; set; }
        [StringLength(1, 35)]
        [DataElement("0800", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Packagereferencenumber_07 { get; set; }
        [ListCount(99)]
        [Pos(8)]
        public List<S020> REFERENCEIDENTIFICATION_08 { get; set; }
        [StringLength(1, 14)]
        [DataElement("0534", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Securityreferencenumber_09 { get; set; }
        [StringLength(1, 6)]
        [DataElement("0138", typeof(EDIFACT_N))]
        [Pos(10)]
        public string Securitysegmentposition_10 { get; set; }
    }

    [Serializable()]
    [Segment("UCF")]
    public class UCF
    {

        [Required]
        [StringLength(1, 14)]
        [DataElement("0048", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Groupreferencenumber_01 { get; set; }
        [Pos(2)]
        public S006 APPLICATIONSENDERIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public S007_UCF APPLICATIONRECIPIENTIDENTIFICATION_03 { get; set; }
        [Required]
        [DataElement("0083", typeof(EDIFACT_ID_0083))]
        [Pos(4)]
        public string Actioncoded_04 { get; set; }
        [DataElement("0085", typeof(EDIFACT_ID_0085))]
        [Pos(5)]
        public string Syntaxerrorcoded_05 { get; set; }
        [DataElement("0135", typeof(EDIFACT_ID_0135))]
        [Pos(6)]
        public string Servicesegmenttagcoded_06 { get; set; }
        [Pos(7)]
        public S011 DATAELEMENTIDENTIFICATION_07 { get; set; }
        [StringLength(1, 14)]
        [DataElement("0534", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Securityreferencenumber_08 { get; set; }
        [StringLength(1, 6)]
        [DataElement("0138", typeof(EDIFACT_N))]
        [Pos(9)]
        public string Securitysegmentposition_09 { get; set; }
    }

    [Serializable()]
    [Segment("UCI")]
    public class UCI
    {

        [Required]
        [StringLength(1, 14)]
        [DataElement("0020", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Interchangecontrolreference_01 { get; set; }
        [Required]
        [Pos(2)]
        public S002 INTERCHANGESENDER_02 { get; set; }
        [Required]
        [Pos(3)]
        public S003 INTERCHANGERECIPIENT_03 { get; set; }
        [Required]
        [DataElement("0083", typeof(EDIFACT_ID_0083))]
        [Pos(4)]
        public string Actioncoded_04 { get; set; }
        [DataElement("0085", typeof(EDIFACT_ID_0085))]
        [Pos(5)]
        public string Syntaxerrorcoded_05 { get; set; }
        [DataElement("0135", typeof(EDIFACT_ID_0135))]
        [Pos(6)]
        public string Servicesegmenttagcoded_06 { get; set; }
        [Pos(7)]
        public S011 DATAELEMENTIDENTIFICATION_07 { get; set; }
        [StringLength(1, 14)]
        [DataElement("0534", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Securityreferencenumber_08 { get; set; }
        [StringLength(1, 6)]
        [DataElement("0138", typeof(EDIFACT_N))]
        [Pos(9)]
        public string Securitysegmentposition_09 { get; set; }
    }
}
