using System;
using System.Collections.Generic;
using EdiFabric.Core.Annotations.Edi;

namespace EdiFabric.Core.Model.Ack.X12
{
    [Serializable()]
    [Segment("SE")]
    public class SE
    {
        
        [Pos(1)]
        public string NumberofIncludedSegments_01 { get; set; }
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
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
    [Segment("ST")]
    public class ST
    {
        
        [Pos(1)]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
        [Pos(3)]
        public string ImplementationConventionPreference_03 { get; set; }
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
}
