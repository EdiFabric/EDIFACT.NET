namespace EdiFabric.Rules.EDIFACT_41
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Segment("UNT")]
    public class UNT
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
        public S007 APPLICATIONRECIPIENTIDENTIFICATION_03 { get; set; }
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
    
    [Serializable()]
    [Segment("UNH")]
    public class UNH
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
}
