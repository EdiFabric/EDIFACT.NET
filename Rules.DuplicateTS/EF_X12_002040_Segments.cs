namespace EdiFabric.Rules.X12_002040
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using EdiFabric.Attributes;
    
    
    public class SE
    {
        
        [D(1, "96")]
        public string NumberofIncludedSegments_01 { get; set; }
        [D(2, "329")]
        public string TransactionSetControlNumber_02 { get; set; }
    }
    
    public class CTT
    {
        
        [D(1, "354")]
        public string NumberofLineItems_01 { get; set; }
        [D(2, "347")]
        public string HashTotal_02 { get; set; }
        [D(3, "81")]
        public string Weight_03 { get; set; }
        [D(4, "355")]
        public string UnitofMeasurementCode_04 { get; set; }
        [D(5, "183")]
        public string Volume_05 { get; set; }
        [D(6, "355")]
        public string UnitofMeasurementCode_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
    }
    
    public class ISS
    {
        
        [D(1, "382")]
        public string NumberofUnitsShipped_01 { get; set; }
        [D(2, "355")]
        public string UnitofMeasurementCode_02 { get; set; }
        [D(3, "81")]
        public string Weight_03 { get; set; }
        [D(4, "355")]
        public string UnitofMeasurementCode_04 { get; set; }
        [D(5, "183")]
        public string Volume_05 { get; set; }
        [D(6, "355")]
        public string UnitofMeasurementCode_06 { get; set; }
    }
    
    public class TXI
    {
        
        [D(1, "963")]
        public string TaxTypeCode_01 { get; set; }
        [D(2, "782")]
        public string MonetaryAmount_02 { get; set; }
        [D(3, "954")]
        public string Percent_03 { get; set; }
        [D(4, "955")]
        public string TaxJurisdictionCodeQualifier_04 { get; set; }
        [D(5, "956")]
        public string TaxJurisdictionCode_05 { get; set; }
    }
    
    public class ITA
    {
        
        [D(1, "248")]
        public string AllowanceorChargeIndicator_01 { get; set; }
        [D(2, "559")]
        public string AssociationQualifierCode_02 { get; set; }
        [D(3, "560")]
        public string SpecialServicesCode_03 { get; set; }
        [D(4, "331")]
        public string AllowanceorChargeMethodofHandlingCode_04 { get; set; }
        [D(5, "341")]
        public string AllowanceorChargeNumber_05 { get; set; }
        [D(6, "359")]
        public string AllowanceorChargeRate_06 { get; set; }
        [D(7, "360")]
        public string AllowanceorChargeTotalAmount_07 { get; set; }
        [D(8, "378")]
        public string AllowanceChargePercentQualifier_08 { get; set; }
        [D(9, "332")]
        public string AllowanceorChargePercent_09 { get; set; }
        [D(10, "339")]
        public string AllowanceorChargeQuantity_10 { get; set; }
        [D(11, "355")]
        public string UnitofMeasurementCode_11 { get; set; }
        [D(12, "380")]
        public string Quantity_12 { get; set; }
        [D(13, "352")]
        public string Description_13 { get; set; }
        [D(14, "150")]
        public string SpecialChargeCode_14 { get; set; }
    }
    
    public class CAD
    {
        
        [D(1, "91")]
        public string TransportationMethodCode_01 { get; set; }
        [D(2, "206")]
        public string EquipmentInitial_02 { get; set; }
        [D(3, "207")]
        public string EquipmentNumber_03 { get; set; }
        [D(4, "140")]
        public string StandardCarrierAlphaCode_04 { get; set; }
        [D(5, "387")]
        public string Routing_05 { get; set; }
        [D(6, "368")]
        public string ShipmentOrderStatusCode_06 { get; set; }
        [D(7, "128")]
        public string ReferenceNumberQualifier_07 { get; set; }
        [D(8, "127")]
        public string ReferenceNumber_08 { get; set; }
    }
    
    public class TDS
    {
        
        [D(1, "361")]
        public string TotalInvoiceAmount_01 { get; set; }
        [D(2, "390")]
        public string AmountSubjecttoTermsDiscount_02 { get; set; }
        [D(3, "391")]
        public string DiscountedAmountDue_03 { get; set; }
        [D(4, "362")]
        public string TermsDiscountAmount_04 { get; set; }
    }
    
    public class PER
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, "93")]
        public string Name_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, "364")]
        public string CommunicationNumber_04 { get; set; }
    }
    
    public class REF
    {
        
        [D(1, "128")]
        public string ReferenceNumberQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
    }
    
    public class N4
    {
        
        [D(1, "19")]
        public string CityName_01 { get; set; }
        [D(2, "156")]
        public string StateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string PostalCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
    }
    
    public class N3
    {
        
        [D(1, "166")]
        public string AddressInformation_01 { get; set; }
        [D(2, "166")]
        public string AddressInformation_02 { get; set; }
    }
    
    public class N2
    {
        
        [D(1, "93")]
        public string Name_01 { get; set; }
        [D(2, "93")]
        public string Name_02 { get; set; }
    }
    
    public class N1
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "93")]
        public string Name_02 { get; set; }
        [D(3, "66")]
        public string IdentificationCodeQualifier_03 { get; set; }
        [D(4, "67")]
        public string IdentificationCode_04 { get; set; }
    }
    
    public class PID
    {
        
        [D(1, "349")]
        public string ItemDescriptionType_01 { get; set; }
        [D(2, "750")]
        public string ProductProcessCharacteristicCode_02 { get; set; }
        [D(3, "348")]
        public string ItemDescriptionQualifier_03 { get; set; }
        [D(4, "751")]
        public string ProductDescriptionCode_04 { get; set; }
        [D(5, "352")]
        public string Description_05 { get; set; }
        [D(6, "752")]
        public string SurfaceLayerPositionCode_06 { get; set; }
    }
    
    public class SLN
    {
        
        [D(1, "350")]
        public string AssignedIdentification_01 { get; set; }
        [D(2, "350")]
        public string AssignedIdentification_02 { get; set; }
        [D(3, "661")]
        public string ConfigurationCode_03 { get; set; }
        [D(4, "380")]
        public string Quantity_04 { get; set; }
        [D(5, "355")]
        public string UnitofMeasurementCode_05 { get; set; }
        [D(6, "212")]
        public string UnitPrice_06 { get; set; }
        [D(7, "639")]
        public string BasisofUnitPriceCode_07 { get; set; }
        [D(8, "662")]
        public string SublinePriceChangeCodeID_08 { get; set; }
        [D(9, "235")]
        public string ProductServiceIDQualifier_09 { get; set; }
        [D(10, "234")]
        public string ProductServiceID_10 { get; set; }
        [D(11, "235")]
        public string ProductServiceIDQualifier_11 { get; set; }
        [D(12, "234")]
        public string ProductServiceID_12 { get; set; }
        [D(13, "235")]
        public string ProductServiceIDQualifier_13 { get; set; }
        [D(14, "234")]
        public string ProductServiceID_14 { get; set; }
        [D(15, "235")]
        public string ProductServiceIDQualifier_15 { get; set; }
        [D(16, "234")]
        public string ProductServiceID_16 { get; set; }
        [D(17, "235")]
        public string ProductServiceIDQualifier_17 { get; set; }
        [D(18, "234")]
        public string ProductServiceID_18 { get; set; }
        [D(19, "235")]
        public string ProductServiceIDQualifier_19 { get; set; }
        [D(20, "234")]
        public string ProductServiceID_20 { get; set; }
        [D(21, "235")]
        public string ProductServiceIDQualifier_21 { get; set; }
        [D(22, "234")]
        public string ProductServiceID_22 { get; set; }
        [D(23, "235")]
        public string ProductServiceIDQualifier_23 { get; set; }
        [D(24, "234")]
        public string ProductServiceID_24 { get; set; }
        [D(25, "235")]
        public string ProductServiceIDQualifier_25 { get; set; }
        [D(26, "234")]
        public string ProductServiceID_26 { get; set; }
        [D(27, "235")]
        public string ProductServiceIDQualifier_27 { get; set; }
        [D(28, "234")]
        public string ProductServiceID_28 { get; set; }
    }
    
    public class L7
    {
        
        [D(1, "213")]
        public string LadingLineItemNumber_01 { get; set; }
        [D(2, "168")]
        public string TariffAgencyCode_02 { get; set; }
        [D(3, "171")]
        public string TariffNumber_03 { get; set; }
        [D(4, "172")]
        public string TariffSection_04 { get; set; }
        [D(5, "169")]
        public string TariffItemNumber_05 { get; set; }
        [D(6, "170")]
        public string TariffItemPart_06 { get; set; }
        [D(7, "59")]
        public string FreightClassCode_07 { get; set; }
        [D(8, "173")]
        public string TariffSupplementIdentifier_08 { get; set; }
        [D(9, "46")]
        public string ExParte_09 { get; set; }
        [D(10, "37")]
        public string EffectiveDate_10 { get; set; }
        [D(11, "119")]
        public string RateBasisNumber_11 { get; set; }
        [D(12, "227")]
        public string TariffColumn_12 { get; set; }
        [D(13, "294")]
        public string TariffDistance_13 { get; set; }
        [D(14, "295")]
        public string DistanceQualifier_14 { get; set; }
        [D(15, "19")]
        public string CityName_15 { get; set; }
        [D(16, "156")]
        public string StateorProvinceCode_16 { get; set; }
    }
    
    public class DTM
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "373")]
        public string Date_02 { get; set; }
        [D(3, "337")]
        public string Time_03 { get; set; }
        [D(4, "623")]
        public string TimeCode_04 { get; set; }
    }
    
    public class SDQ
    {
        
        [D(1, "355")]
        public string UnitofMeasurementCode_01 { get; set; }
        [D(2, "66")]
        public string IdentificationCodeQualifier_02 { get; set; }
        [D(3, "67")]
        public string IdentificationCode_03 { get; set; }
        [D(4, "380")]
        public string Quantity_04 { get; set; }
        [D(5, "67")]
        public string IdentificationCode_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "67")]
        public string IdentificationCode_07 { get; set; }
        [D(8, "380")]
        public string Quantity_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "380")]
        public string Quantity_10 { get; set; }
        [D(11, "67")]
        public string IdentificationCode_11 { get; set; }
        [D(12, "380")]
        public string Quantity_12 { get; set; }
        [D(13, "67")]
        public string IdentificationCode_13 { get; set; }
        [D(14, "380")]
        public string Quantity_14 { get; set; }
        [D(15, "67")]
        public string IdentificationCode_15 { get; set; }
        [D(16, "380")]
        public string Quantity_16 { get; set; }
        [D(17, "67")]
        public string IdentificationCode_17 { get; set; }
        [D(18, "380")]
        public string Quantity_18 { get; set; }
        [D(19, "67")]
        public string IdentificationCode_19 { get; set; }
        [D(20, "380")]
        public string Quantity_20 { get; set; }
        [D(21, "67")]
        public string IdentificationCode_21 { get; set; }
        [D(22, "380")]
        public string Quantity_22 { get; set; }
    }
    
    public class ITD
    {
        
        [D(1, "336")]
        public string TermsTypeCode_01 { get; set; }
        [D(2, "333")]
        public string TermsBasisDateCode_02 { get; set; }
        [D(3, "338")]
        public string TermsDiscountPercent_03 { get; set; }
        [D(4, "370")]
        public string TermsDiscountDueDate_04 { get; set; }
        [D(5, "351")]
        public string TermsDiscountDaysDue_05 { get; set; }
        [D(6, "446")]
        public string TermsNetDueDate_06 { get; set; }
        [D(7, "386")]
        public string TermsNetDays_07 { get; set; }
        [D(8, "362")]
        public string TermsDiscountAmount_08 { get; set; }
        [D(9, "388")]
        public string TermsDeferredDueDate_09 { get; set; }
        [D(10, "389")]
        public string DeferredAmountDue_10 { get; set; }
        [D(11, "342")]
        public string PercentofInvoicePayable_11 { get; set; }
        [D(12, "352")]
        public string Description_12 { get; set; }
        [D(13, "765")]
        public string DayofMonth_13 { get; set; }
    }
    
    public class PO4
    {
        
        [D(1, "356")]
        public string Pack_01 { get; set; }
        [D(2, "357")]
        public string Size_02 { get; set; }
        [D(3, "355")]
        public string UnitofMeasurementCode_03 { get; set; }
        [D(4, "103")]
        public string PackagingCode_04 { get; set; }
        [D(5, "187")]
        public string WeightQualifier_05 { get; set; }
        [D(6, "384")]
        public string GrossWeightperPack_06 { get; set; }
        [D(7, "355")]
        public string UnitofMeasurementCode_07 { get; set; }
        [D(8, "385")]
        public string GrossVolumeperPack_08 { get; set; }
        [D(9, "355")]
        public string UnitofMeasurementCode_09 { get; set; }
        [D(10, "82")]
        public string Length_10 { get; set; }
        [D(11, "189")]
        public string Width_11 { get; set; }
        [D(12, "65")]
        public string Height_12 { get; set; }
        [D(13, "355")]
        public string UnitofMeasurementCode_13 { get; set; }
    }
    
    public class PKG
    {
        
        [D(1, "349")]
        public string ItemDescriptionType_01 { get; set; }
        [D(2, "753")]
        public string PackagingCharacteristicCode_02 { get; set; }
        [D(3, "348")]
        public string ItemDescriptionQualifier_03 { get; set; }
        [D(4, "754")]
        public string PackagingDescriptionCode_04 { get; set; }
        [D(5, "352")]
        public string Description_05 { get; set; }
    }
    
    public class PWK
    {
        
        [D(1, "755")]
        public string ReportTypeCode_01 { get; set; }
        [D(2, "756")]
        public string ReportTransmissionCode_02 { get; set; }
        [D(3, "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, "67")]
        public string IdentificationCode_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
    }
    
    public class MEA
    {
        
        [D(1, "737")]
        public string MeasurementReferenceIDCode_01 { get; set; }
        [D(2, "738")]
        public string MeasurementQualifier_02 { get; set; }
        [D(3, "739")]
        public string MeasurementValue_03 { get; set; }
        [D(4, "355")]
        public string UnitofMeasurementCode_04 { get; set; }
        [D(5, "740")]
        public string RangeMinimum_05 { get; set; }
        [D(6, "741")]
        public string RangeMaximum_06 { get; set; }
        [D(7, "935")]
        public string MeasurementSignificanceCode_07 { get; set; }
        [D(8, "936")]
        public string MeasurementAttributeCode_08 { get; set; }
        [D(9, "752")]
        public string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    public class CTP
    {
        
        [D(1, "687")]
        public string ClassofTradeCode_01 { get; set; }
        [D(2, "236")]
        public string PriceQualifier_02 { get; set; }
        [D(3, "212")]
        public string UnitPrice_03 { get; set; }
        [D(4, "380")]
        public string Quantity_04 { get; set; }
        [D(5, "355")]
        public string UnitofMeasurementCode_05 { get; set; }
        [D(6, "648")]
        public string PriceMultiplierQualifier_06 { get; set; }
        [D(7, "649")]
        public string Multiplier_07 { get; set; }
    }
    
    public class IT3
    {
        
        [D(1, "382")]
        public string NumberofUnitsShipped_01 { get; set; }
        [D(2, "355")]
        public string UnitofMeasurementCode_02 { get; set; }
        [D(3, "368")]
        public string ShipmentOrderStatusCode_03 { get; set; }
        [D(4, "383")]
        public string QuantityDifference_04 { get; set; }
        [D(5, "371")]
        public string ChangeReasonCode_05 { get; set; }
    }
    
    public class CUR
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "100")]
        public string CurrencyCode_02 { get; set; }
        [D(3, "280")]
        public string ExchangeRate_03 { get; set; }
        [D(4, "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, "100")]
        public string CurrencyCode_05 { get; set; }
        [D(6, "669")]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        [D(7, "374")]
        public string DateTimeQualifier_07 { get; set; }
        [D(8, "373")]
        public string Date_08 { get; set; }
        [D(9, "337")]
        public string Time_09 { get; set; }
        [D(10, "374")]
        public string DateTimeQualifier_10 { get; set; }
        [D(11, "373")]
        public string Date_11 { get; set; }
        [D(12, "337")]
        public string Time_12 { get; set; }
        [D(13, "374")]
        public string DateTimeQualifier_13 { get; set; }
        [D(14, "373")]
        public string Date_14 { get; set; }
        [D(15, "337")]
        public string Time_15 { get; set; }
        [D(16, "374")]
        public string DateTimeQualifier_16 { get; set; }
        [D(17, "373")]
        public string Date_17 { get; set; }
        [D(18, "337")]
        public string Time_18 { get; set; }
        [D(19, "374")]
        public string DateTimeQualifier_19 { get; set; }
        [D(20, "373")]
        public string Date_20 { get; set; }
        [D(21, "337")]
        public string Time_21 { get; set; }
    }
    
    public class IT1
    {
        
        [D(1, "350")]
        public string AssignedIdentification_01 { get; set; }
        [D(2, "358")]
        public string QuantityInvoiced_02 { get; set; }
        [D(3, "355")]
        public string UnitofMeasurementCode_03 { get; set; }
        [D(4, "212")]
        public string UnitPrice_04 { get; set; }
        [D(5, "639")]
        public string BasisofUnitPriceCode_05 { get; set; }
        [D(6, "235")]
        public string ProductServiceIDQualifier_06 { get; set; }
        [D(7, "234")]
        public string ProductServiceID_07 { get; set; }
        [D(8, "235")]
        public string ProductServiceIDQualifier_08 { get; set; }
        [D(9, "234")]
        public string ProductServiceID_09 { get; set; }
        [D(10, "235")]
        public string ProductServiceIDQualifier_10 { get; set; }
        [D(11, "234")]
        public string ProductServiceID_11 { get; set; }
        [D(12, "235")]
        public string ProductServiceIDQualifier_12 { get; set; }
        [D(13, "234")]
        public string ProductServiceID_13 { get; set; }
        [D(14, "235")]
        public string ProductServiceIDQualifier_14 { get; set; }
        [D(15, "234")]
        public string ProductServiceID_15 { get; set; }
        [D(16, "235")]
        public string ProductServiceIDQualifier_16 { get; set; }
        [D(17, "234")]
        public string ProductServiceID_17 { get; set; }
        [D(18, "235")]
        public string ProductServiceIDQualifier_18 { get; set; }
        [D(19, "234")]
        public string ProductServiceID_19 { get; set; }
        [D(20, "235")]
        public string ProductServiceIDQualifier_20 { get; set; }
        [D(21, "234")]
        public string ProductServiceID_21 { get; set; }
        [D(22, "235")]
        public string ProductServiceIDQualifier_22 { get; set; }
        [D(23, "234")]
        public string ProductServiceID_23 { get; set; }
        [D(24, "235")]
        public string ProductServiceIDQualifier_24 { get; set; }
        [D(25, "234")]
        public string ProductServiceID_25 { get; set; }
    }
    
    public class FOB
    {
        
        [D(1, "146")]
        public string ShipmentMethodofPayment_01 { get; set; }
        [D(2, "309")]
        public string LocationQualifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [D(4, "334")]
        public string TransportationTermsQualifierCode_04 { get; set; }
        [D(5, "335")]
        public string TransportationTermsCode_05 { get; set; }
        [D(6, "309")]
        public string LocationQualifier_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
        [D(8, "54")]
        public string RiskofLossQualifier_08 { get; set; }
        [D(9, "352")]
        public string Description_09 { get; set; }
    }
    
    public class NTE
    {
        
        [D(1, "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, "3")]
        public string FreeFormMessage_02 { get; set; }
    }
    
    public class BIG
    {
        
        [D(1, "245")]
        public string InvoiceDate_01 { get; set; }
        [D(2, "76")]
        public string InvoiceNumber_02 { get; set; }
        [D(3, "323")]
        public string PurchaseOrderDate_03 { get; set; }
        [D(4, "324")]
        public string PurchaseOrderNumber_04 { get; set; }
        [D(5, "328")]
        public string ReleaseNumber_05 { get; set; }
        [D(6, "327")]
        public string ChangeOrderSequenceNumber_06 { get; set; }
        [D(7, "640")]
        public string TransactionTypeCode_07 { get; set; }
    }
    
    public class ST
    {
        
        [D(1, "143")]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [D(2, "329")]
        public string TransactionSetControlNumber_02 { get; set; }
        [D(3, "1705")]
        public string ImplementationConventionPreference_03 { get; set; }
    }
}
