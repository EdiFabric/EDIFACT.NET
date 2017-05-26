namespace EdiFabric.Rules.X12_002040
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Segment("FOB")]
    public class FOB
    {
        
        [Pos(1)]
        public string ShipmentMethodofPayment_01 { get; set; }
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class DTM
    {
        
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Pos(2)]
        public string Date_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("ITD")]
    public class ITD
    {
        
        [Pos(1)]
        public string TermsTypeCode_01 { get; set; }
        [Pos(2)]
        public string TermsBasisDateCode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("PER")]
    public class PER
    {
        
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [Pos(2)]
        public string Name_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF")]
    public class REF
    {
        
        [Pos(1)]
        public string ReferenceNumberQualifier_01 { get; set; }
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4
    {
        
        [Pos(1)]
        public string CityName_01 { get; set; }
        [Pos(2)]
        public string StateorProvinceCode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3
    {
        
        [Pos(1)]
        public string AddressInformation_01 { get; set; }
        [Pos(2)]
        public string AddressInformation_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("N2")]
    public class N2
    {
        
        [Pos(1)]
        public string Name_01 { get; set; }
        [Pos(2)]
        public string Name_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("N1")]
    public class N1
    {
        
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Pos(2)]
        public string Name_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("CUR")]
    public class CUR
    {
        
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NTE")]
    public class NTE
    {
        
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        [Pos(2)]
        public string FreeFormMessage_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("BIG")]
    public class BIG
    {
        
        [Pos(1)]
        public string InvoiceDate_01 { get; set; }
        [Pos(2)]
        public string InvoiceNumber_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("ST")]
    public class ST
    {
        
        [Pos(1)]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
    }
}
