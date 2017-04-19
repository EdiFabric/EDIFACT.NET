namespace EdiFabric.Rules.X12_002040
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using EdiFabric.Attributes;
    
    
    public class SE
    {
        
        [D(1)]
        public string NumberofIncludedSegments_01 { get; set; }
        [D(2)]
        public string TransactionSetControlNumber_02 { get; set; }
    }
    
    public class CTT
    {
        
        [D(1)]
        public string NumberofLineItems_01 { get; set; }
        [D(2)]
        public string HashTotal_02 { get; set; }
        [D(3)]
        public string Weight_03 { get; set; }
        [D(4)]
        public string UnitofMeasurementCode_04 { get; set; }
        [D(5)]
        public string Volume_05 { get; set; }
        [D(6)]
        public string UnitofMeasurementCode_06 { get; set; }
        [D(7)]
        public string Description_07 { get; set; }
    }
    
    public class ISS
    {
        
        [D(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        [D(2)]
        public string UnitofMeasurementCode_02 { get; set; }
        [D(3)]
        public string Weight_03 { get; set; }
        [D(4)]
        public string UnitofMeasurementCode_04 { get; set; }
        [D(5)]
        public string Volume_05 { get; set; }
        [D(6)]
        public string UnitofMeasurementCode_06 { get; set; }
    }
    
    public class TXI
    {
        
        [D(1)]
        public string TaxTypeCode_01 { get; set; }
        [D(2)]
        public string MonetaryAmount_02 { get; set; }
        [D(3)]
        public string Percent_03 { get; set; }
        [D(4)]
        public string TaxJurisdictionCodeQualifier_04 { get; set; }
        [D(5)]
        public string TaxJurisdictionCode_05 { get; set; }
    }
    
    public class ITA
    {
        
        [D(1)]
        public string AllowanceorChargeIndicator_01 { get; set; }
        [D(2)]
        public string AssociationQualifierCode_02 { get; set; }
        [D(3)]
        public string SpecialServicesCode_03 { get; set; }
        [D(4)]
        public string AllowanceorChargeMethodofHandlingCode_04 { get; set; }
        [D(5)]
        public string AllowanceorChargeNumber_05 { get; set; }
        [D(6)]
        public string AllowanceorChargeRate_06 { get; set; }
        [D(7)]
        public string AllowanceorChargeTotalAmount_07 { get; set; }
        [D(8)]
        public string AllowanceChargePercentQualifier_08 { get; set; }
        [D(9)]
        public string AllowanceorChargePercent_09 { get; set; }
        [D(10)]
        public string AllowanceorChargeQuantity_10 { get; set; }
        [D(11)]
        public string UnitofMeasurementCode_11 { get; set; }
        [D(12)]
        public string Quantity_12 { get; set; }
        [D(13)]
        public string Description_13 { get; set; }
        [D(14)]
        public string SpecialChargeCode_14 { get; set; }
    }
    
    public class CAD
    {
        
        [D(1)]
        public string TransportationMethodCode_01 { get; set; }
        [D(2)]
        public string EquipmentInitial_02 { get; set; }
        [D(3)]
        public string EquipmentNumber_03 { get; set; }
        [D(4)]
        public string StandardCarrierAlphaCode_04 { get; set; }
        [D(5)]
        public string Routing_05 { get; set; }
        [D(6)]
        public string ShipmentOrderStatusCode_06 { get; set; }
        [D(7)]
        public string ReferenceNumberQualifier_07 { get; set; }
        [D(8)]
        public string ReferenceNumber_08 { get; set; }
    }
    
    public class TDS
    {
        
        [D(1)]
        public string TotalInvoiceAmount_01 { get; set; }
        [D(2)]
        public string AmountSubjecttoTermsDiscount_02 { get; set; }
        [D(3)]
        public string DiscountedAmountDue_03 { get; set; }
        [D(4)]
        public string TermsDiscountAmount_04 { get; set; }
    }
    
    public class PER
    {
        
        [D(1)]
        public string ContactFunctionCode_01 { get; set; }
        [D(2)]
        public string Name_02 { get; set; }
        [D(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4)]
        public string CommunicationNumber_04 { get; set; }
    }
    
    public class REF
    {
        
        [D(1)]
        public string ReferenceNumberQualifier_01 { get; set; }
        [D(2)]
        public string ReferenceNumber_02 { get; set; }
        [D(3)]
        public string Description_03 { get; set; }
    }
    
    public class N4
    {
        
        [D(1)]
        public string CityName_01 { get; set; }
        [D(2)]
        public string StateorProvinceCode_02 { get; set; }
        [D(3)]
        public string PostalCode_03 { get; set; }
        [D(4)]
        public string CountryCode_04 { get; set; }
        [D(5)]
        public string LocationQualifier_05 { get; set; }
        [D(6)]
        public string LocationIdentifier_06 { get; set; }
    }
    
    public class N3
    {
        
        [D(1)]
        public string AddressInformation_01 { get; set; }
        [D(2)]
        public string AddressInformation_02 { get; set; }
    }
    
    public class N2
    {
        
        [D(1)]
        public string Name_01 { get; set; }
        [D(2)]
        public string Name_02 { get; set; }
    }
    
    public class N1
    {
        
        [D(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2)]
        public string Name_02 { get; set; }
        [D(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        [D(4)]
        public string IdentificationCode_04 { get; set; }
    }
    
    public class PID
    {
        
        [D(1)]
        public string ItemDescriptionType_01 { get; set; }
        [D(2)]
        public string ProductProcessCharacteristicCode_02 { get; set; }
        [D(3)]
        public string ItemDescriptionQualifier_03 { get; set; }
        [D(4)]
        public string ProductDescriptionCode_04 { get; set; }
        [D(5)]
        public string Description_05 { get; set; }
        [D(6)]
        public string SurfaceLayerPositionCode_06 { get; set; }
    }
    
    public class SLN
    {
        
        [D(1)]
        public string AssignedIdentification_01 { get; set; }
        [D(2)]
        public string AssignedIdentification_02 { get; set; }
        [D(3)]
        public string ConfigurationCode_03 { get; set; }
        [D(4)]
        public string Quantity_04 { get; set; }
        [D(5)]
        public string UnitofMeasurementCode_05 { get; set; }
        [D(6)]
        public string UnitPrice_06 { get; set; }
        [D(7)]
        public string BasisofUnitPriceCode_07 { get; set; }
        [D(8)]
        public string SublinePriceChangeCodeID_08 { get; set; }
        [D(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        [D(10)]
        public string ProductServiceID_10 { get; set; }
        [D(11)]
        public string ProductServiceIDQualifier_11 { get; set; }
        [D(12)]
        public string ProductServiceID_12 { get; set; }
        [D(13)]
        public string ProductServiceIDQualifier_13 { get; set; }
        [D(14)]
        public string ProductServiceID_14 { get; set; }
        [D(15)]
        public string ProductServiceIDQualifier_15 { get; set; }
        [D(16)]
        public string ProductServiceID_16 { get; set; }
        [D(17)]
        public string ProductServiceIDQualifier_17 { get; set; }
        [D(18)]
        public string ProductServiceID_18 { get; set; }
        [D(19)]
        public string ProductServiceIDQualifier_19 { get; set; }
        [D(20)]
        public string ProductServiceID_20 { get; set; }
        [D(21)]
        public string ProductServiceIDQualifier_21 { get; set; }
        [D(22)]
        public string ProductServiceID_22 { get; set; }
        [D(23)]
        public string ProductServiceIDQualifier_23 { get; set; }
        [D(24)]
        public string ProductServiceID_24 { get; set; }
        [D(25)]
        public string ProductServiceIDQualifier_25 { get; set; }
        [D(26)]
        public string ProductServiceID_26 { get; set; }
        [D(27)]
        public string ProductServiceIDQualifier_27 { get; set; }
        [D(28)]
        public string ProductServiceID_28 { get; set; }
    }
    
    public class L7
    {
        
        [D(1)]
        public string LadingLineItemNumber_01 { get; set; }
        [D(2)]
        public string TariffAgencyCode_02 { get; set; }
        [D(3)]
        public string TariffNumber_03 { get; set; }
        [D(4)]
        public string TariffSection_04 { get; set; }
        [D(5)]
        public string TariffItemNumber_05 { get; set; }
        [D(6)]
        public string TariffItemPart_06 { get; set; }
        [D(7)]
        public string FreightClassCode_07 { get; set; }
        [D(8)]
        public string TariffSupplementIdentifier_08 { get; set; }
        [D(9)]
        public string ExParte_09 { get; set; }
        [D(10)]
        public string EffectiveDate_10 { get; set; }
        [D(11)]
        public string RateBasisNumber_11 { get; set; }
        [D(12)]
        public string TariffColumn_12 { get; set; }
        [D(13)]
        public string TariffDistance_13 { get; set; }
        [D(14)]
        public string DistanceQualifier_14 { get; set; }
        [D(15)]
        public string CityName_15 { get; set; }
        [D(16)]
        public string StateorProvinceCode_16 { get; set; }
    }
    
    public class DTM
    {
        
        [D(1)]
        public string DateTimeQualifier_01 { get; set; }
        [D(2)]
        public string Date_02 { get; set; }
        [D(3)]
        public string Time_03 { get; set; }
        [D(4)]
        public string TimeCode_04 { get; set; }
    }
    
    public class SDQ
    {
        
        [D(1)]
        public string UnitofMeasurementCode_01 { get; set; }
        [D(2)]
        public string IdentificationCodeQualifier_02 { get; set; }
        [D(3)]
        public string IdentificationCode_03 { get; set; }
        [D(4)]
        public string Quantity_04 { get; set; }
        [D(5)]
        public string IdentificationCode_05 { get; set; }
        [D(6)]
        public string Quantity_06 { get; set; }
        [D(7)]
        public string IdentificationCode_07 { get; set; }
        [D(8)]
        public string Quantity_08 { get; set; }
        [D(9)]
        public string IdentificationCode_09 { get; set; }
        [D(10)]
        public string Quantity_10 { get; set; }
        [D(11)]
        public string IdentificationCode_11 { get; set; }
        [D(12)]
        public string Quantity_12 { get; set; }
        [D(13)]
        public string IdentificationCode_13 { get; set; }
        [D(14)]
        public string Quantity_14 { get; set; }
        [D(15)]
        public string IdentificationCode_15 { get; set; }
        [D(16)]
        public string Quantity_16 { get; set; }
        [D(17)]
        public string IdentificationCode_17 { get; set; }
        [D(18)]
        public string Quantity_18 { get; set; }
        [D(19)]
        public string IdentificationCode_19 { get; set; }
        [D(20)]
        public string Quantity_20 { get; set; }
        [D(21)]
        public string IdentificationCode_21 { get; set; }
        [D(22)]
        public string Quantity_22 { get; set; }
    }
    
    public class ITD
    {
        
        [D(1)]
        public string TermsTypeCode_01 { get; set; }
        [D(2)]
        public string TermsBasisDateCode_02 { get; set; }
        [D(3)]
        public string TermsDiscountPercent_03 { get; set; }
        [D(4)]
        public string TermsDiscountDueDate_04 { get; set; }
        [D(5)]
        public string TermsDiscountDaysDue_05 { get; set; }
        [D(6)]
        public string TermsNetDueDate_06 { get; set; }
        [D(7)]
        public string TermsNetDays_07 { get; set; }
        [D(8)]
        public string TermsDiscountAmount_08 { get; set; }
        [D(9)]
        public string TermsDeferredDueDate_09 { get; set; }
        [D(10)]
        public string DeferredAmountDue_10 { get; set; }
        [D(11)]
        public string PercentofInvoicePayable_11 { get; set; }
        [D(12)]
        public string Description_12 { get; set; }
        [D(13)]
        public string DayofMonth_13 { get; set; }
    }
    
    public class PO4
    {
        
        [D(1)]
        public string Pack_01 { get; set; }
        [D(2)]
        public string Size_02 { get; set; }
        [D(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        [D(4)]
        public string PackagingCode_04 { get; set; }
        [D(5)]
        public string WeightQualifier_05 { get; set; }
        [D(6)]
        public string GrossWeightperPack_06 { get; set; }
        [D(7)]
        public string UnitofMeasurementCode_07 { get; set; }
        [D(8)]
        public string GrossVolumeperPack_08 { get; set; }
        [D(9)]
        public string UnitofMeasurementCode_09 { get; set; }
        [D(10)]
        public string Length_10 { get; set; }
        [D(11)]
        public string Width_11 { get; set; }
        [D(12)]
        public string Height_12 { get; set; }
        [D(13)]
        public string UnitofMeasurementCode_13 { get; set; }
    }
    
    public class PKG
    {
        
        [D(1)]
        public string ItemDescriptionType_01 { get; set; }
        [D(2)]
        public string PackagingCharacteristicCode_02 { get; set; }
        [D(3)]
        public string ItemDescriptionQualifier_03 { get; set; }
        [D(4)]
        public string PackagingDescriptionCode_04 { get; set; }
        [D(5)]
        public string Description_05 { get; set; }
    }
    
    public class PWK
    {
        
        [D(1)]
        public string ReportTypeCode_01 { get; set; }
        [D(2)]
        public string ReportTransmissionCode_02 { get; set; }
        [D(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6)]
        public string IdentificationCode_06 { get; set; }
        [D(7)]
        public string Description_07 { get; set; }
    }
    
    public class MEA
    {
        
        [D(1)]
        public string MeasurementReferenceIDCode_01 { get; set; }
        [D(2)]
        public string MeasurementQualifier_02 { get; set; }
        [D(3)]
        public string MeasurementValue_03 { get; set; }
        [D(4)]
        public string UnitofMeasurementCode_04 { get; set; }
        [D(5)]
        public string RangeMinimum_05 { get; set; }
        [D(6)]
        public string RangeMaximum_06 { get; set; }
        [D(7)]
        public string MeasurementSignificanceCode_07 { get; set; }
        [D(8)]
        public string MeasurementAttributeCode_08 { get; set; }
        [D(9)]
        public string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    public class CTP
    {
        
        [D(1)]
        public string ClassofTradeCode_01 { get; set; }
        [D(2)]
        public string PriceQualifier_02 { get; set; }
        [D(3)]
        public string UnitPrice_03 { get; set; }
        [D(4)]
        public string Quantity_04 { get; set; }
        [D(5)]
        public string UnitofMeasurementCode_05 { get; set; }
        [D(6)]
        public string PriceMultiplierQualifier_06 { get; set; }
        [D(7)]
        public string Multiplier_07 { get; set; }
    }
    
    public class IT3
    {
        
        [D(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        [D(2)]
        public string UnitofMeasurementCode_02 { get; set; }
        [D(3)]
        public string ShipmentOrderStatusCode_03 { get; set; }
        [D(4)]
        public string QuantityDifference_04 { get; set; }
        [D(5)]
        public string ChangeReasonCode_05 { get; set; }
    }
    
    public class CUR
    {
        
        [D(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2)]
        public string CurrencyCode_02 { get; set; }
        [D(3)]
        public string ExchangeRate_03 { get; set; }
        [D(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5)]
        public string CurrencyCode_05 { get; set; }
        [D(6)]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        [D(7)]
        public string DateTimeQualifier_07 { get; set; }
        [D(8)]
        public string Date_08 { get; set; }
        [D(9)]
        public string Time_09 { get; set; }
        [D(10)]
        public string DateTimeQualifier_10 { get; set; }
        [D(11)]
        public string Date_11 { get; set; }
        [D(12)]
        public string Time_12 { get; set; }
        [D(13)]
        public string DateTimeQualifier_13 { get; set; }
        [D(14)]
        public string Date_14 { get; set; }
        [D(15)]
        public string Time_15 { get; set; }
        [D(16)]
        public string DateTimeQualifier_16 { get; set; }
        [D(17)]
        public string Date_17 { get; set; }
        [D(18)]
        public string Time_18 { get; set; }
        [D(19)]
        public string DateTimeQualifier_19 { get; set; }
        [D(20)]
        public string Date_20 { get; set; }
        [D(21)]
        public string Time_21 { get; set; }
    }
    
    public class IT1
    {
        
        [D(1)]
        public string AssignedIdentification_01 { get; set; }
        [D(2)]
        public string QuantityInvoiced_02 { get; set; }
        [D(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        [D(4)]
        public string UnitPrice_04 { get; set; }
        [D(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        [D(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        [D(7)]
        public string ProductServiceID_07 { get; set; }
        [D(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        [D(9)]
        public string ProductServiceID_09 { get; set; }
        [D(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        [D(11)]
        public string ProductServiceID_11 { get; set; }
        [D(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        [D(13)]
        public string ProductServiceID_13 { get; set; }
        [D(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        [D(15)]
        public string ProductServiceID_15 { get; set; }
        [D(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        [D(17)]
        public string ProductServiceID_17 { get; set; }
        [D(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        [D(19)]
        public string ProductServiceID_19 { get; set; }
        [D(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        [D(21)]
        public string ProductServiceID_21 { get; set; }
        [D(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        [D(23)]
        public string ProductServiceID_23 { get; set; }
        [D(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        [D(25)]
        public string ProductServiceID_25 { get; set; }
    }
    
    public class FOB
    {
        
        [D(1)]
        public string ShipmentMethodofPayment_01 { get; set; }
        [D(2)]
        public string LocationQualifier_02 { get; set; }
        [D(3)]
        public string Description_03 { get; set; }
        [D(4)]
        public string TransportationTermsQualifierCode_04 { get; set; }
        [D(5)]
        public string TransportationTermsCode_05 { get; set; }
        [D(6)]
        public string LocationQualifier_06 { get; set; }
        [D(7)]
        public string Description_07 { get; set; }
        [D(8)]
        public string RiskofLossQualifier_08 { get; set; }
        [D(9)]
        public string Description_09 { get; set; }
    }
    
    public class NTE
    {
        
        [D(1)]
        public string NoteReferenceCode_01 { get; set; }
        [D(2)]
        public string FreeFormMessage_02 { get; set; }
    }
    
    public class BIG
    {
        
        [D(1)]
        public string InvoiceDate_01 { get; set; }
        [D(2)]
        public string InvoiceNumber_02 { get; set; }
        [D(3)]
        public string PurchaseOrderDate_03 { get; set; }
        [D(4)]
        public string PurchaseOrderNumber_04 { get; set; }
        [D(5)]
        public string ReleaseNumber_05 { get; set; }
        [D(6)]
        public string ChangeOrderSequenceNumber_06 { get; set; }
        [D(7)]
        public string TransactionTypeCode_07 { get; set; }
    }
    
    public class ST
    {
        
        [D(1)]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [D(2)]
        public string TransactionSetControlNumber_02 { get; set; }
        [D(3)]
        public string ImplementationConventionPreference_03 { get; set; }
    }
}
