namespace EdiFabric.Rules.EANCOM_D01BEAN3
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Segment("UNT")]
    public class TSINVOIC_UNT
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
    [Segment("MOA")]
    public class TSINVOIC_MOA_12
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516_12 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALI")]
    public class TSINVOIC_ALI_4
    {
        
        [DataElement("3239", typeof(EDIFACT_ID_3239))]
        [Pos(1)]
        public string Countryoforiginnamecode_01 { get; set; }
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string Dutyregimetypecode_02 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditioncode_03 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditioncode_04 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditioncode_05 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditioncode_06 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditioncode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALC")]
    public class TSINVOIC_ALC_3
    {
        
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C552_3 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C214_3 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class TSINVOIC_MOA_11
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516_11 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("TAX")]
    public class TSINVOIC_TAX_5
    {
        
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C241_5 DUTYTAXFEETYPE_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C533_5 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C243_5 DUTYTAXFEEDETAIL_05 { get; set; }
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class TSINVOIC_DTM_11
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C507_11 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("RFF")]
    public class TSINVOIC_RFF_5
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C506_5 REFERENCE_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class TSINVOIC_MOA_10
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516_10 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("CNT")]
    public class TSINVOIC_CNT
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C270 CONTROL_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("UNS")]
    public class TSINVOIC_UNS
    {
        
        [Required]
        [StringLength(1, 1)]
        [DataElement("0081", typeof(EDIFACT_A))]
        [Pos(1)]
        public string Sectionidentification_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("LOC")]
    public class TSINVOIC_LOC_4
    {
        
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C517_4 LOCATIONIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C519_4 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C553_4 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("TOD")]
    public class TSINVOIC_TOD_2
    {
        
        [DataElement("4055", typeof(EDIFACT_ID_4055))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C100_2 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("TDT")]
    public class TSINVOIC_TDT_2
    {
        
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C220_2 MODEOFTRANSPORT_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C228_2 TRANSPORTMEANS_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C040_2 CARRIER_05 { get; set; }
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
        [Pos(7)]
        public TSINVOIC_C401_2 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        [Pos(8)]
        public TSINVOIC_C222_2 TRANSPORTIDENTIFICATION_08 { get; set; }
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class TSINVOIC_MOA_9
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516_9 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("TAX")]
    public class TSINVOIC_TAX_4
    {
        
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C241_4 DUTYTAXFEETYPE_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C533_4 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C243_4 DUTYTAXFEEDETAIL_05 { get; set; }
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("RTE")]
    public class TSINVOIC_RTE_2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C128_2 RATEDETAILS_01 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class TSINVOIC_MOA_8
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516_8 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("PCD")]
    public class TSINVOIC_PCD_4
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C501_4 PERCENTAGEDETAILS_01 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("QTY")]
    public class TSINVOIC_QTY_4
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C186_4 QUANTITYDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class TSINVOIC_DTM_10
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C507_10 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALI")]
    public class TSINVOIC_ALI_3
    {
        
        [DataElement("3239", typeof(EDIFACT_ID_3239))]
        [Pos(1)]
        public string Countryoforiginnamecode_01 { get; set; }
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string Dutyregimetypecode_02 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditioncode_03 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditioncode_04 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditioncode_05 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditioncode_06 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditioncode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALC")]
    public class TSINVOIC_ALC_2
    {
        
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C552_2 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C214_2 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("RFF")]
    public class TSINVOIC_RFF_4
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C506_4 REFERENCE_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("NAD")]
    public class TSINVOIC_NAD_2
    {
        
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C082_2 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C058_2 NAMEANDADDRESS_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C080_2 PARTYNAME_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C059_2 STREET_05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        [Pos(7)]
        public TSINVOIC_C819_2 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class TSINVOIC_MOA_7
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516_7 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("TAX")]
    public class TSINVOIC_TAX_3
    {
        
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C241_3 DUTYTAXFEETYPE_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C533_3 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C243_3 DUTYTAXFEEDETAIL_05 { get; set; }
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class TSINVOIC_DTM_9
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C507_9 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("QTY")]
    public class TSINVOIC_QTY_3
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C186_3 QUANTITYDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("LOC")]
    public class TSINVOIC_LOC_3
    {
        
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C517_3 LOCATIONIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C519_3 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C553_3 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("GIN")]
    public class TSINVOIC_GIN_2
    {
        
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public TSINVOIC_C208_6 IDENTITYNUMBERRANGE_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C208_7 IDENTITYNUMBERRANGE_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C208_8 IDENTITYNUMBERRANGE_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C208_9 IDENTITYNUMBERRANGE_05 { get; set; }
        [Pos(6)]
        public TSINVOIC_C208_10 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PCI")]
    public class TSINVOIC_PCI
    {
        
        [DataElement("4233", typeof(EDIFACT_ID_4233))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C210 MARKSLABELS_02 { get; set; }
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C827 TYPEOFMARKING_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("MEA")]
    public class TSINVOIC_MEA_2
    {
        
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C502_2 MEASUREMENTDETAILS_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C174_2 VALUERANGE_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAC")]
    public class TSINVOIC_PAC_2
    {
        
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Packagequantity_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C531_2 PACKAGINGDETAILS_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C202_2 PACKAGETYPE_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C402_2 PACKAGETYPEIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C532_2 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class TSINVOIC_DTM_8
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C507_8 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("RFF")]
    public class TSINVOIC_RFF_3
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C506_3 REFERENCE_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("APR")]
    public class TSINVOIC_APR
    {
        
        [DataElement("4043", typeof(EDIFACT_ID_4043))]
        [Pos(1)]
        public string Tradeclasscode_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C138 PRICEMULTIPLIERINFORMATION_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C960_2 REASONFORCHANGE_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRI")]
    public class TSINVOIC_PRI
    {
        
        [Pos(1)]
        public TSINVOIC_C509 PRICEINFORMATION_01 { get; set; }
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class TSINVOIC_MOA_6
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516_6 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("PCD")]
    public class TSINVOIC_PCD_3
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C501_3 PERCENTAGEDETAILS_01 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class TSINVOIC_DTM_7
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C507_7 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAT")]
    public class TSINVOIC_PAT_2
    {
        
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C110_2 PAYMENTTERMS_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C112_2 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class TSINVOIC_MOA_5
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516_5 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("FTX")]
    public class TSINVOIC_FTX_2
    {
        
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C107_2 TEXTREFERENCE_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C108_2 TEXTLITERAL_04 { get; set; }
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("QVR")]
    public class TSINVOIC_QVR
    {
        
        [Pos(1)]
        public TSINVOIC_C279 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        [DataElement("4221", typeof(EDIFACT_ID_4221))]
        [Pos(2)]
        public string Discrepancynatureidentificationcode_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C960 REASONFORCHANGE_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("GIN")]
    public class TSINVOIC_GIN
    {
        
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public TSINVOIC_C208 IDENTITYNUMBERRANGE_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C208_2 IDENTITYNUMBERRANGE_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C208_3 IDENTITYNUMBERRANGE_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C208_4 IDENTITYNUMBERRANGE_05 { get; set; }
        [Pos(6)]
        public TSINVOIC_C208_5 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class TSINVOIC_DTM_6
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C507_6 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALI")]
    public class TSINVOIC_ALI_2
    {
        
        [DataElement("3239", typeof(EDIFACT_ID_3239))]
        [Pos(1)]
        public string Countryoforiginnamecode_01 { get; set; }
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string Dutyregimetypecode_02 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditioncode_03 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditioncode_04 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditioncode_05 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditioncode_06 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditioncode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("QTY")]
    public class TSINVOIC_QTY_2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C186_2 QUANTITYDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("MEA")]
    public class TSINVOIC_MEA
    {
        
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C502 MEASUREMENTDETAILS_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C174 VALUERANGE_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("IMD")]
    public class TSINVOIC_IMD
    {
        
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C272 ITEMCHARACTERISTIC_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C273 ITEMDESCRIPTION_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PIA")]
    public class TSINVOIC_PIA
    {
        
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        [Required]
        [Pos(2)]
        public TSINVOIC_C212_2 ITEMNUMBERIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C212_3 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C212_4 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C212_5 ITEMNUMBERIDENTIFICATION_05 { get; set; }
        [Pos(6)]
        public TSINVOIC_C212_6 ITEMNUMBERIDENTIFICATION_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("LIN")]
    public class TSINVOIC_LIN
    {
        
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Lineitemidentifier_01 { get; set; }
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public string Actionrequestnotificationdescriptioncode_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C829 SUBLINEINFORMATION_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevelnumber_05 { get; set; }
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string Configurationoperationcode_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class TSINVOIC_MOA_4
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516_4 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("TAX")]
    public class TSINVOIC_TAX_2
    {
        
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C241_2 DUTYTAXFEETYPE_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C533_2 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C243_2 DUTYTAXFEEDETAIL_05 { get; set; }
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("RTE")]
    public class TSINVOIC_RTE
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C128 RATEDETAILS_01 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class TSINVOIC_MOA_3
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516_3 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("PCD")]
    public class TSINVOIC_PCD_2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C501_2 PERCENTAGEDETAILS_01 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("QTY")]
    public class TSINVOIC_QTY
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C186 QUANTITYDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALC")]
    public class TSINVOIC_ALC
    {
        
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C214 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAC")]
    public class TSINVOIC_PAC
    {
        
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Packagequantity_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C531 PACKAGINGDETAILS_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C202 PACKAGETYPE_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C402 PACKAGETYPEIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C532 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("LOC")]
    public class TSINVOIC_LOC_2
    {
        
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C517_2 LOCATIONIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C519_2 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C553_2 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("TOD")]
    public class TSINVOIC_TOD
    {
        
        [DataElement("4055", typeof(EDIFACT_ID_4055))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class TSINVOIC_DTM_5
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C507_5 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("LOC")]
    public class TSINVOIC_LOC
    {
        
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C517 LOCATIONIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C519 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C553 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("TDT")]
    public class TSINVOIC_TDT
    {
        
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C220 MODEOFTRANSPORT_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C228 TRANSPORTMEANS_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C040 CARRIER_05 { get; set; }
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
        [Pos(7)]
        public TSINVOIC_C401 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        [Pos(8)]
        public TSINVOIC_C222 TRANSPORTIDENTIFICATION_08 { get; set; }
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("FII")]
    public class TSINVOIC_FII_2
    {
        
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C078_2 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C088_2 INSTITUTIONIDENTIFICATION_03 { get; set; }
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAI")]
    public class TSINVOIC_PAI_2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C534_2 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class TSINVOIC_MOA_2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516_2 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("PCD")]
    public class TSINVOIC_PCD
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C501 PERCENTAGEDETAILS_01 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class TSINVOIC_DTM_4
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C507_4 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAT")]
    public class TSINVOIC_PAT
    {
        
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C110 PAYMENTTERMS_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C112 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class TSINVOIC_DTM_3
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C507_3 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("CUX")]
    public class TSINVOIC_CUX
    {
        
        [Pos(1)]
        public TSINVOIC_C504 CURRENCYDETAILS_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C504_2 CURRENCYDETAILS_02 { get; set; }
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Currencyexchangerate_03 { get; set; }
        [DataElement("6341", typeof(EDIFACT_ID_6341))]
        [Pos(4)]
        public string Exchangeratecurrencymarketidentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class TSINVOIC_MOA
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C516 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("TAX")]
    public class TSINVOIC_TAX
    {
        
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C241 DUTYTAXFEETYPE_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C243 DUTYTAXFEEDETAIL_05 { get; set; }
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("COM")]
    public class TSINVOIC_COM
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C076 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("CTA")]
    public class TSINVOIC_CTA
    {
        
        [DataElement("3139", typeof(EDIFACT_ID_3139))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("RFF")]
    public class TSINVOIC_RFF_2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C506_2 REFERENCE_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("FII")]
    public class TSINVOIC_FII
    {
        
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NAD")]
    public class TSINVOIC_NAD
    {
        
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C058 NAMEANDADDRESS_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C080 PARTYNAME_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_C059 STREET_05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        [Pos(7)]
        public TSINVOIC_C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class TSINVOIC_DTM_2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C507_2 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("RFF")]
    public class TSINVOIC_RFF
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C506 REFERENCE_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("FTX")]
    public class TSINVOIC_FTX
    {
        
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
        [Pos(3)]
        public TSINVOIC_C107 TEXTREFERENCE_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_C108 TEXTLITERAL_04 { get; set; }
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALI")]
    public class TSINVOIC_ALI
    {
        
        [DataElement("3239", typeof(EDIFACT_ID_3239))]
        [Pos(1)]
        public string Countryoforiginnamecode_01 { get; set; }
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string Dutyregimetypecode_02 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditioncode_03 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditioncode_04 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditioncode_05 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditioncode_06 { get; set; }
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditioncode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAI")]
    public class TSINVOIC_PAI
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C534 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class TSINVOIC_DTM
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_C507 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("BGM")]
    public class TSINVOIC_BGM
    {
        
        [Pos(1)]
        public TSINVOIC_C002 DOCUMENTMESSAGENAME_01 { get; set; }
        [Pos(2)]
        public TSINVOIC_C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("UNH")]
    public class TSINVOIC_UNH
    {
        
        [Required]
        [StringLength(1, 14)]
        [DataElement("0062", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MessageReferenceNumber_01 { get; set; }
        [Required]
        [Pos(2)]
        public TSINVOIC_S009 MessageIdentifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("0068", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CommonAccessReference_03 { get; set; }
        [Pos(4)]
        public TSINVOIC_S010 StatusoftheTransfer_04 { get; set; }
        [Pos(5)]
        public TSINVOIC_S016 MessageSubsetIdentification_05 { get; set; }
        [Pos(6)]
        public TSINVOIC_S017 MessageImplementationGuidelineIdentification_06 { get; set; }
        [Pos(7)]
        public TSINVOIC_S018 ScenarioIdentification_07 { get; set; }
    }
}
