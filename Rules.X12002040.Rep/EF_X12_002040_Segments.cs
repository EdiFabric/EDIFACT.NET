namespace EdiFabric.Rules.X12_002040.Rep
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Annotations.Edi;
    using EdiFabric.Annotations.Validation;
    
    
    [Serializable()]
    [Segment("SE")]
    public class SE
    {
        
        [Required]
        [StringLength(1, 10)]
        [DataElement("96", typeof(X12_AN))]
        [Pos(1)]
        public string NumberofIncludedSegments_01 { get; set; }
        [Required]
        [StringLength(4, 9)]
        [DataElement("329", typeof(X12_AN))]
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("CTT")]
    public class CTT
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("354", typeof(X12_N0))]
        [Pos(1)]
        public string NumberofLineItems_01 { get; set; }
        [StringLength(1, 10)]
        [DataElement("347", typeof(X12_R))]
        [Pos(2)]
        public string HashTotal_02 { get; set; }
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(3)]
        public string Weight_03 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitofMeasurementCode_04 { get; set; }
        [StringLength(1, 8)]
        [DataElement("183", typeof(X12_R))]
        [Pos(5)]
        public string Volume_05 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(6)]
        public string UnitofMeasurementCode_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("ISS")]
    public class ISS
    {
        
        [StringLength(1, 10)]
        [DataElement("382", typeof(X12_R))]
        [Pos(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(2)]
        public string UnitofMeasurementCode_02 { get; set; }
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(3)]
        public string Weight_03 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitofMeasurementCode_04 { get; set; }
        [StringLength(1, 8)]
        [DataElement("183", typeof(X12_R))]
        [Pos(5)]
        public string Volume_05 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(6)]
        public string UnitofMeasurementCode_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("TXI")]
    public class TXI
    {
        
        [Required]
        [DataElement("963", typeof(X12_ID_963))]
        [Pos(1)]
        public string TaxTypeCode_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(3)]
        public string Percent_03 { get; set; }
        [DataElement("955", typeof(X12_ID_955))]
        [Pos(4)]
        public string TaxJurisdictionCodeQualifier_04 { get; set; }
        [StringLength(1, 10)]
        [DataElement("956", typeof(X12_AN))]
        [Pos(5)]
        public string TaxJurisdictionCode_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("ITA")]
    public class ITA
    {
        
        [Required]
        [DataElement("248", typeof(X12_ID_248))]
        [Pos(1)]
        public string AllowanceorChargeIndicator_01 { get; set; }
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AssociationQualifierCode_02 { get; set; }
        [DataElement("560", typeof(X12_ID_560))]
        [Pos(3)]
        public string SpecialServicesCode_03 { get; set; }
        [Required]
        [DataElement("331", typeof(X12_ID_331))]
        [Pos(4)]
        public string AllowanceorChargeMethodofHandlingCode_04 { get; set; }
        [StringLength(1, 16)]
        [DataElement("341", typeof(X12_AN))]
        [Pos(5)]
        public string AllowanceorChargeNumber_05 { get; set; }
        [StringLength(1, 9)]
        [DataElement("359", typeof(X12_R))]
        [Pos(6)]
        public string AllowanceorChargeRate_06 { get; set; }
        [StringLength(1, 9)]
        [DataElement("360", typeof(X12_N2))]
        [Pos(7)]
        public string AllowanceorChargeTotalAmount_07 { get; set; }
        [DataElement("378", typeof(X12_ID_378))]
        [Pos(8)]
        public string AllowanceChargePercentQualifier_08 { get; set; }
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(9)]
        public string AllowanceorChargePercent_09 { get; set; }
        [StringLength(1, 10)]
        [DataElement("339", typeof(X12_R))]
        [Pos(10)]
        public string AllowanceorChargeQuantity_10 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(11)]
        public string UnitofMeasurementCode_11 { get; set; }
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        public string Quantity_12 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(13)]
        public string Description_13 { get; set; }
        [DataElement("150", typeof(X12_ID_150))]
        [Pos(14)]
        public string SpecialChargeCode_14 { get; set; }
    }
    
    [Serializable()]
    [Segment("CAD")]
    public class CAD
    {
        
        [DataElement("91", typeof(X12_ID_91))]
        [Pos(1)]
        public string TransportationMethodCode_01 { get; set; }
        [StringLength(1, 4)]
        [DataElement("206", typeof(X12_AN))]
        [Pos(2)]
        public string EquipmentInitial_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("207", typeof(X12_AN))]
        [Pos(3)]
        public string EquipmentNumber_03 { get; set; }
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_ID))]
        [Pos(4)]
        public string StandardCarrierAlphaCode_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("387", typeof(X12_AN))]
        [Pos(5)]
        public string Routing_05 { get; set; }
        [DataElement("368", typeof(X12_ID_368))]
        [Pos(6)]
        public string ShipmentOrderStatusCode_06 { get; set; }
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(7)]
        public string ReferenceNumberQualifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(8)]
        public string ReferenceNumber_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("TDS")]
    public class TDS
    {
        
        [Required]
        [StringLength(1, 10)]
        [DataElement("361", typeof(X12_N2))]
        [Pos(1)]
        public string TotalInvoiceAmount_01 { get; set; }
        [StringLength(1, 10)]
        [DataElement("390", typeof(X12_N2))]
        [Pos(2)]
        public string AmountSubjecttoTermsDiscount_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("391", typeof(X12_N2))]
        [Pos(3)]
        public string DiscountedAmountDue_03 { get; set; }
        [StringLength(1, 10)]
        [DataElement("362", typeof(X12_N2))]
        [Pos(4)]
        public string TermsDiscountAmount_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PER")]
    public class PER
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [StringLength(7, 21)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
    }


    [Serializable()]
    [Segment("REF")]
    public class REF
    {

        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public List<string> ReferenceNumberQualifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public List<C127> ReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4
    {
        
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string CityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string StateorProvinceCode_02 { get; set; }
        [StringLength(5, 9)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string PostalCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [StringLength(1, 25)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AddressInformation_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AddressInformation_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("N2")]
    public class N2
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(1)]
        public string Name_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("N1")]
    public class N1
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PID")]
    public class PID
    {
        
        [Required]
        [DataElement("349", typeof(X12_ID_349))]
        [Pos(1)]
        public string ItemDescriptionType_01 { get; set; }
        [DataElement("750", typeof(X12_ID_750))]
        [Pos(2)]
        public string ProductProcessCharacteristicCode_02 { get; set; }
        [DataElement("348", typeof(X12_ID_348))]
        [Pos(3)]
        public string ItemDescriptionQualifier_03 { get; set; }
        [StringLength(1, 12)]
        [DataElement("751", typeof(X12_ID))]
        [Pos(4)]
        public string ProductDescriptionCode_04 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        public string Description_05 { get; set; }
        [DataElement("752", typeof(X12_ID_752))]
        [Pos(6)]
        public string SurfaceLayerPositionCode_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("SLN")]
    public class SLN
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(2)]
        public string AssignedIdentification_02 { get; set; }
        [Required]
        [DataElement("661", typeof(X12_ID_661))]
        [Pos(3)]
        public string ConfigurationCode_03 { get; set; }
        [Required]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        public string UnitofMeasurementCode_05 { get; set; }
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(6)]
        public string UnitPrice_06 { get; set; }
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(7)]
        public string BasisofUnitPriceCode_07 { get; set; }
        [DataElement("662", typeof(X12_ID_662))]
        [Pos(8)]
        public string SublinePriceChangeCodeID_08 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(11)]
        public string ProductServiceIDQualifier_11 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(12)]
        public string ProductServiceID_12 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(13)]
        public string ProductServiceIDQualifier_13 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(14)]
        public string ProductServiceID_14 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(15)]
        public string ProductServiceIDQualifier_15 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(16)]
        public string ProductServiceID_16 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(17)]
        public string ProductServiceIDQualifier_17 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(18)]
        public string ProductServiceID_18 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(19)]
        public string ProductServiceIDQualifier_19 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(20)]
        public string ProductServiceID_20 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(21)]
        public string ProductServiceIDQualifier_21 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(22)]
        public string ProductServiceID_22 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(23)]
        public string ProductServiceIDQualifier_23 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(24)]
        public string ProductServiceID_24 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(25)]
        public string ProductServiceIDQualifier_25 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(26)]
        public string ProductServiceID_26 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(27)]
        public string ProductServiceIDQualifier_27 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(28)]
        public string ProductServiceID_28 { get; set; }
    }
    
    [Serializable()]
    [Segment("L7")]
    public class L7
    {
        
        [StringLength(1, 3)]
        [DataElement("213", typeof(X12_N0))]
        [Pos(1)]
        public string LadingLineItemNumber_01 { get; set; }
        [StringLength(1, 4)]
        [DataElement("168", typeof(X12_ID))]
        [Pos(2)]
        public string TariffAgencyCode_02 { get; set; }
        [StringLength(1, 7)]
        [DataElement("171", typeof(X12_AN))]
        [Pos(3)]
        public string TariffNumber_03 { get; set; }
        [StringLength(1, 2)]
        [DataElement("172", typeof(X12_N0))]
        [Pos(4)]
        public string TariffSection_04 { get; set; }
        [StringLength(1, 16)]
        [DataElement("169", typeof(X12_AN))]
        [Pos(5)]
        public string TariffItemNumber_05 { get; set; }
        [StringLength(1, 2)]
        [DataElement("170", typeof(X12_N0))]
        [Pos(6)]
        public string TariffItemPart_06 { get; set; }
        [StringLength(2, 5)]
        [DataElement("59", typeof(X12_ID))]
        [Pos(7)]
        public string FreightClassCode_07 { get; set; }
        [StringLength(1, 4)]
        [DataElement("173", typeof(X12_AN))]
        [Pos(8)]
        public string TariffSupplementIdentifier_08 { get; set; }
        [StringLength(4, 4)]
        [DataElement("46", typeof(X12_AN))]
        [Pos(9)]
        public string ExParte_09 { get; set; }
        [StringLength(6, 6)]
        [DataElement("37", typeof(X12_DT))]
        [Pos(10)]
        public string EffectiveDate_10 { get; set; }
        [StringLength(2, 6)]
        [DataElement("119", typeof(X12_AN))]
        [Pos(11)]
        public string RateBasisNumber_11 { get; set; }
        [StringLength(1, 2)]
        [DataElement("227", typeof(X12_AN))]
        [Pos(12)]
        public string TariffColumn_12 { get; set; }
        [StringLength(1, 5)]
        [DataElement("294", typeof(X12_N0))]
        [Pos(13)]
        public string TariffDistance_13 { get; set; }
        [DataElement("295", typeof(X12_ID_295))]
        [Pos(14)]
        public string DistanceQualifier_14 { get; set; }
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(15)]
        public string CityName_15 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(16)]
        public string StateorProvinceCode_16 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class DTM
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(3)]
        public string Time_03 { get; set; }
        [DataElement("623", typeof(X12_ID_623))]
        [Pos(4)]
        public string TimeCode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("SDQ")]
    public class SDQ
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public string UnitofMeasurementCode_01 { get; set; }
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(2)]
        public string IdentificationCodeQualifier_02 { get; set; }
        [Required]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(3)]
        public string IdentificationCode_03 { get; set; }
        [Required]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(5)]
        public string IdentificationCode_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(7)]
        public string IdentificationCode_07 { get; set; }
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(8)]
        public string Quantity_08 { get; set; }
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(9)]
        public string IdentificationCode_09 { get; set; }
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(10)]
        public string Quantity_10 { get; set; }
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(11)]
        public string IdentificationCode_11 { get; set; }
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        public string Quantity_12 { get; set; }
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(13)]
        public string IdentificationCode_13 { get; set; }
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(14)]
        public string Quantity_14 { get; set; }
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(15)]
        public string IdentificationCode_15 { get; set; }
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(16)]
        public string Quantity_16 { get; set; }
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(17)]
        public string IdentificationCode_17 { get; set; }
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(18)]
        public string Quantity_18 { get; set; }
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(19)]
        public string IdentificationCode_19 { get; set; }
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(20)]
        public string Quantity_20 { get; set; }
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(21)]
        public string IdentificationCode_21 { get; set; }
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(22)]
        public string Quantity_22 { get; set; }
    }
    
    [Serializable()]
    [Segment("ITD")]
    public class ITD
    {
        
        [DataElement("336", typeof(X12_ID_336))]
        [Pos(1)]
        public string TermsTypeCode_01 { get; set; }
        [Required]
        [DataElement("333", typeof(X12_ID_333))]
        [Pos(2)]
        public string TermsBasisDateCode_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("338", typeof(X12_R))]
        [Pos(3)]
        public string TermsDiscountPercent_03 { get; set; }
        [StringLength(6, 6)]
        [DataElement("370", typeof(X12_DT))]
        [Pos(4)]
        public string TermsDiscountDueDate_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("351", typeof(X12_N0))]
        [Pos(5)]
        public string TermsDiscountDaysDue_05 { get; set; }
        [StringLength(6, 6)]
        [DataElement("446", typeof(X12_DT))]
        [Pos(6)]
        public string TermsNetDueDate_06 { get; set; }
        [StringLength(1, 3)]
        [DataElement("386", typeof(X12_N0))]
        [Pos(7)]
        public string TermsNetDays_07 { get; set; }
        [StringLength(1, 10)]
        [DataElement("362", typeof(X12_N2))]
        [Pos(8)]
        public string TermsDiscountAmount_08 { get; set; }
        [StringLength(6, 6)]
        [DataElement("388", typeof(X12_DT))]
        [Pos(9)]
        public string TermsDeferredDueDate_09 { get; set; }
        [StringLength(1, 10)]
        [DataElement("389", typeof(X12_N2))]
        [Pos(10)]
        public string DeferredAmountDue_10 { get; set; }
        [StringLength(1, 5)]
        [DataElement("342", typeof(X12_R))]
        [Pos(11)]
        public string PercentofInvoicePayable_11 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(12)]
        public string Description_12 { get; set; }
        [StringLength(1, 2)]
        [DataElement("765", typeof(X12_N0))]
        [Pos(13)]
        public string DayofMonth_13 { get; set; }
    }
    
    [Serializable()]
    [Segment("PO4")]
    public class PO4
    {
        
        [StringLength(1, 6)]
        [DataElement("356", typeof(X12_N0))]
        [Pos(1)]
        public string Pack_01 { get; set; }
        [StringLength(1, 8)]
        [DataElement("357", typeof(X12_R))]
        [Pos(2)]
        public string Size_02 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        [StringLength(5, 5)]
        [DataElement("103", typeof(X12_ID))]
        [Pos(4)]
        public string PackagingCode_04 { get; set; }
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(5)]
        public string WeightQualifier_05 { get; set; }
        [StringLength(1, 9)]
        [DataElement("384", typeof(X12_R))]
        [Pos(6)]
        public string GrossWeightperPack_06 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitofMeasurementCode_07 { get; set; }
        [StringLength(1, 9)]
        [DataElement("385", typeof(X12_R))]
        [Pos(8)]
        public string GrossVolumeperPack_08 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(9)]
        public string UnitofMeasurementCode_09 { get; set; }
        [StringLength(1, 6)]
        [DataElement("82", typeof(X12_R))]
        [Pos(10)]
        public string Length_10 { get; set; }
        [StringLength(1, 8)]
        [DataElement("189", typeof(X12_R))]
        [Pos(11)]
        public string Width_11 { get; set; }
        [StringLength(1, 6)]
        [DataElement("65", typeof(X12_R))]
        [Pos(12)]
        public string Height_12 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public string UnitofMeasurementCode_13 { get; set; }
    }
    
    [Serializable()]
    [Segment("PKG")]
    public class PKG
    {
        
        [Required]
        [DataElement("349", typeof(X12_ID_349))]
        [Pos(1)]
        public string ItemDescriptionType_01 { get; set; }
        [DataElement("753", typeof(X12_ID_753))]
        [Pos(2)]
        public string PackagingCharacteristicCode_02 { get; set; }
        [DataElement("348", typeof(X12_ID_348))]
        [Pos(3)]
        public string ItemDescriptionQualifier_03 { get; set; }
        [StringLength(1, 7)]
        [DataElement("754", typeof(X12_ID))]
        [Pos(4)]
        public string PackagingDescriptionCode_04 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        public string Description_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("PWK")]
    public class PWK
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(1)]
        public string ReportTypeCode_01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756))]
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_ID))]
        [Pos(6)]
        public string IdentificationCode_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("MEA")]
    public class MEA
    {
        
        [DataElement("737", typeof(X12_ID_737))]
        [Pos(1)]
        public string MeasurementReferenceIDCode_01 { get; set; }
        [DataElement("738", typeof(X12_ID_738))]
        [Pos(2)]
        public string MeasurementQualifier_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("739", typeof(X12_R))]
        [Pos(3)]
        public string MeasurementValue_03 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitofMeasurementCode_04 { get; set; }
        [StringLength(1, 10)]
        [DataElement("740", typeof(X12_R))]
        [Pos(5)]
        public string RangeMinimum_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("741", typeof(X12_R))]
        [Pos(6)]
        public string RangeMaximum_06 { get; set; }
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(7)]
        public string MeasurementSignificanceCode_07 { get; set; }
        [DataElement("936", typeof(X12_ID_936))]
        [Pos(8)]
        public string MeasurementAttributeCode_08 { get; set; }
        [DataElement("752", typeof(X12_ID_752))]
        [Pos(9)]
        public string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("CTP")]
    public class CTP
    {
        
        [DataElement("687", typeof(X12_ID_687))]
        [Pos(1)]
        public string ClassofTradeCode_01 { get; set; }
        [DataElement("236", typeof(X12_ID_236))]
        [Pos(2)]
        public string PriceQualifier_02 { get; set; }
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(3)]
        public string UnitPrice_03 { get; set; }
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        public string UnitofMeasurementCode_05 { get; set; }
        [DataElement("648", typeof(X12_ID_648))]
        [Pos(6)]
        public string PriceMultiplierQualifier_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(7)]
        public string Multiplier_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("IT3")]
    public class IT3
    {
        
        [StringLength(1, 10)]
        [DataElement("382", typeof(X12_R))]
        [Pos(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(2)]
        public string UnitofMeasurementCode_02 { get; set; }
        [DataElement("368", typeof(X12_ID_368))]
        [Pos(3)]
        public string ShipmentOrderStatusCode_03 { get; set; }
        [StringLength(1, 9)]
        [DataElement("383", typeof(X12_R))]
        [Pos(4)]
        public string QuantityDifference_04 { get; set; }
        [DataElement("371", typeof(X12_ID_371))]
        [Pos(5)]
        public string ChangeReasonCode_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("CUR")]
    public class CUR
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_ID))]
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
        [StringLength(4, 6)]
        [DataElement("280", typeof(X12_R))]
        [Pos(3)]
        public string ExchangeRate_03 { get; set; }
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_ID))]
        [Pos(5)]
        public string CurrencyCode_05 { get; set; }
        [DataElement("669", typeof(X12_ID_669))]
        [Pos(6)]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(8)]
        public string Date_08 { get; set; }
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(9)]
        public string Time_09 { get; set; }
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(11)]
        public string Date_11 { get; set; }
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(12)]
        public string Time_12 { get; set; }
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(13)]
        public string DateTimeQualifier_13 { get; set; }
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(14)]
        public string Date_14 { get; set; }
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(15)]
        public string Time_15 { get; set; }
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(16)]
        public string DateTimeQualifier_16 { get; set; }
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(17)]
        public string Date_17 { get; set; }
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(18)]
        public string Time_18 { get; set; }
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(19)]
        public string DateTimeQualifier_19 { get; set; }
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(20)]
        public string Date_20 { get; set; }
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(21)]
        public string Time_21 { get; set; }
    }
    
    [Serializable()]
    [Segment("IT1")]
    public class IT1
    {
        
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        [Required]
        [StringLength(1, 10)]
        [DataElement("358", typeof(X12_R))]
        [Pos(2)]
        public string QuantityInvoiced_02 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        [Required]
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(4)]
        public string UnitPrice_04 { get; set; }
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
    }
    
    [Serializable()]
    [Segment("FOB")]
    public class FOB
    {
        
        [Required]
        [DataElement("146", typeof(X12_ID_146))]
        [Pos(1)]
        public string ShipmentMethodofPayment_01 { get; set; }
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [DataElement("334", typeof(X12_ID_334))]
        [Pos(4)]
        public string TransportationTermsQualifierCode_04 { get; set; }
        [DataElement("335", typeof(X12_ID_335))]
        [Pos(5)]
        public string TransportationTermsCode_05 { get; set; }
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(6)]
        public string LocationQualifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [DataElement("54", typeof(X12_ID_54))]
        [Pos(8)]
        public string RiskofLossQualifier_08 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(9)]
        public string Description_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("NTE")]
    public class NTE
    {
        
        [DataElement("363", typeof(X12_ID_363))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("3", typeof(X12_AN))]
        [Pos(2)]
        public string FreeFormMessage_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("BIG")]
    public class BIG
    {
        
        [Required]
        [StringLength(6, 6)]
        [DataElement("245", typeof(X12_DT))]
        [Pos(1)]
        public string InvoiceDate_01 { get; set; }
        [Required]
        [StringLength(1, 22)]
        [DataElement("76", typeof(X12_AN))]
        [Pos(2)]
        public string InvoiceNumber_02 { get; set; }
        [StringLength(6, 6)]
        [DataElement("323", typeof(X12_DT))]
        [Pos(3)]
        public string PurchaseOrderDate_03 { get; set; }
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(4)]
        public string PurchaseOrderNumber_04 { get; set; }
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(5)]
        public string ReleaseNumber_05 { get; set; }
        [StringLength(1, 8)]
        [DataElement("327", typeof(X12_AN))]
        [Pos(6)]
        public string ChangeOrderSequenceNumber_06 { get; set; }
        [DataElement("640", typeof(X12_ID_640))]
        [Pos(7)]
        public string TransactionTypeCode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("ST")]
    public class ST
    {
        
        [Required]
        [StringLength(3, 3)]
        [DataElement("143", typeof(X12_AN))]
        [Pos(1)]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [Required]
        [StringLength(4, 9)]
        [DataElement("329", typeof(X12_AN))]
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
        [StringLength(1, 9)]
        [DataElement("1705", typeof(X12_AN))]
        [Pos(3)]
        public string ImplementationConventionPreference_03 { get; set; }
    }
}
