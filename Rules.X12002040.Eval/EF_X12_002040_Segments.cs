namespace EdiFabric.Rules.X12_002040
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Segment("PID")]
    public class PID
    {
        
        [Pos(1)]
        public string ItemDescriptionType_01 { get; set; }
        [Pos(2)]
        public string ProductProcessCharacteristicCode_02 { get; set; }
        [Pos(3)]
        public string ItemDescriptionQualifier_03 { get; set; }
        [Pos(4)]
        public string ProductDescriptionCode_04 { get; set; }
        [Pos(5)]
        public string Description_05 { get; set; }
        [Pos(6)]
        public string SurfaceLayerPositionCode_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("FOB")]
    public class FOB
    {
        
        [Pos(1)]
        public string ShipmentMethodofPayment_01 { get; set; }
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public string TransportationTermsQualifierCode_04 { get; set; }
        [Pos(5)]
        public string TransportationTermsCode_05 { get; set; }
        [Pos(6)]
        public string LocationQualifier_06 { get; set; }
        [Pos(7)]
        public string Description_07 { get; set; }
        [Pos(8)]
        public string RiskofLossQualifier_08 { get; set; }
        [Pos(9)]
        public string Description_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class DTM
    {
        
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Pos(2)]
        public string Date_02 { get; set; }
        [Pos(3)]
        public string Time_03 { get; set; }
        [Pos(4)]
        public string TimeCode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("ITD")]
    public class ITD
    {
        
        [Pos(1)]
        public string TermsTypeCode_01 { get; set; }
        [Pos(2)]
        public string TermsBasisDateCode_02 { get; set; }
        [Pos(3)]
        public string TermsDiscountPercent_03 { get; set; }
        [Pos(4)]
        public string TermsDiscountDueDate_04 { get; set; }
        [Pos(5)]
        public string TermsDiscountDaysDue_05 { get; set; }
        [Pos(6)]
        public string TermsNetDueDate_06 { get; set; }
        [Pos(7)]
        public string TermsNetDays_07 { get; set; }
        [Pos(8)]
        public string TermsDiscountAmount_08 { get; set; }
        [Pos(9)]
        public string TermsDeferredDueDate_09 { get; set; }
        [Pos(10)]
        public string DeferredAmountDue_10 { get; set; }
        [Pos(11)]
        public string PercentofInvoicePayable_11 { get; set; }
        [Pos(12)]
        public string Description_12 { get; set; }
        [Pos(13)]
        public string DayofMonth_13 { get; set; }
    }
    
    [Serializable()]
    [Segment("PER")]
    public class PER
    {
        
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [Pos(2)]
        public string Name_02 { get; set; }
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF")]
    public class REF
    {
        
        [Pos(1)]
        public string ReferenceNumberQualifier_01 { get; set; }
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        [Pos(3)]
        public string Description_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4
    {
        
        [Pos(1)]
        public string CityName_01 { get; set; }
        [Pos(2)]
        public string StateorProvinceCode_02 { get; set; }
        [Pos(3)]
        public string PostalCode_03 { get; set; }
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
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
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("CUR")]
    public class CUR
    {
        
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
        [Pos(3)]
        public string ExchangeRate_03 { get; set; }
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [Pos(5)]
        public string CurrencyCode_05 { get; set; }
        [Pos(6)]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        [Pos(8)]
        public string Date_08 { get; set; }
        [Pos(9)]
        public string Time_09 { get; set; }
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        [Pos(11)]
        public string Date_11 { get; set; }
        [Pos(12)]
        public string Time_12 { get; set; }
        [Pos(13)]
        public string DateTimeQualifier_13 { get; set; }
        [Pos(14)]
        public string Date_14 { get; set; }
        [Pos(15)]
        public string Time_15 { get; set; }
        [Pos(16)]
        public string DateTimeQualifier_16 { get; set; }
        [Pos(17)]
        public string Date_17 { get; set; }
        [Pos(18)]
        public string Time_18 { get; set; }
        [Pos(19)]
        public string DateTimeQualifier_19 { get; set; }
        [Pos(20)]
        public string Date_20 { get; set; }
        [Pos(21)]
        public string Time_21 { get; set; }
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
        [Pos(3)]
        public string PurchaseOrderDate_03 { get; set; }
        [Pos(4)]
        public string PurchaseOrderNumber_04 { get; set; }
        [Pos(5)]
        public string ReleaseNumber_05 { get; set; }
        [Pos(6)]
        public string ChangeOrderSequenceNumber_06 { get; set; }
        [Pos(7)]
        public string TransactionTypeCode_07 { get; set; }
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
}
