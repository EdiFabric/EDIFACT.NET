namespace EdiFabric.Templates.EancomD01B
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Allowance or charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALC")]
    public class ALC : I_ALC<C552, C214>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C214 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// Additional information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALI")]
    public class ALI : I_ALI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Country of origin name code
        /// </summary>
        [DataMember]
        [DataElement("3239", typeof(EDIFACT_ID_3239))]
        [Pos(1)]
        public string Countryoforiginnamecode_01 { get; set; }
        /// <summary>
        /// Duty regime type code
        /// </summary>
        [DataMember]
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string Dutyregimetypecode_02 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditioncode_03 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditioncode_04 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditioncode_05 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditioncode_06 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditioncode_07 { get; set; }
    }
    
    /// <summary>
    /// Additional price information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("APR")]
    public class APR : I_APR<C138, C960>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Trade class code
        /// </summary>
        [DataMember]
        [DataElement("4043", typeof(EDIFACT_ID_4043))]
        [Pos(1)]
        public string Tradeclasscode_01 { get; set; }
        /// <summary>
        /// PRICE MULTIPLIER INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C138 PRICEMULTIPLIERINFORMATION_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C960 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM : I_BGM<C002, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT : I_CNT<C270>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Communication contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COM")]
    public class COM : I_COM<C076>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C076 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Currencies
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUX")]
    public class CUX : I_CUX<C504, C504>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C504 CURRENCYDETAILS_01 { get; set; }
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C504 CURRENCYDETAILS_02 { get; set; }
        /// <summary>
        /// Currency exchange rate
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Currencyexchangerate_03 { get; set; }
        /// <summary>
        /// Exchange rate currency market identifier
        /// </summary>
        [DataMember]
        [DataElement("6341", typeof(EDIFACT_ID_6341))]
        [Pos(4)]
        public string Exchangeratecurrencymarketidentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM : I_DTM<C507>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
        /// <summary>
        /// TEXT REFERENCE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C107 TEXTREFERENCE_03 { get; set; }
        /// <summary>
        /// TEXT LITERAL
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C108 TEXTLITERAL_04 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Goods identity number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIN")]
    public class GIN : I_GIN<C208, C208, C208, C208, C208>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Object identification code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C208 IDENTITYNUMBERRANGE_02 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C208 IDENTITYNUMBERRANGE_03 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C208 IDENTITYNUMBERRANGE_04 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C208 IDENTITYNUMBERRANGE_05 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C208 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD : I_IMD<C272, C273>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Line item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LIN")]
    public class LIN : I_LIN<C212, C829>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line item identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Lineitemidentifier_01 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public string Actionrequestnotificationdescriptioncode_02 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// SUB-LINE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C829 SUBLINEINFORMATION_04 { get; set; }
        /// <summary>
        /// Configuration level number
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevelnumber_05 { get; set; }
        /// <summary>
        /// Configuration operation code
        /// </summary>
        [DataMember]
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string Configurationoperationcode_06 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C517 LOCATIONIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// RELATED LOCATION ONE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C519 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// RELATED LOCATION TWO IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C553 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA : I_MEA<C502, C174>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA : I_MOA<C516>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C058 NAMEANDADDRESS_03 { get; set; }
        /// <summary>
        /// PARTY NAME
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C080 PARTYNAME_04 { get; set; }
        /// <summary>
        /// STREET
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C059 STREET_05 { get; set; }
        /// <summary>
        /// City name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC : I_PAC<C531, C202, C402, C532>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Package quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Packagequantity_01 { get; set; }
        /// <summary>
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202 PACKAGETYPE_03 { get; set; }
        /// <summary>
        /// PACKAGE TYPE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C402 PACKAGETYPEIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// RETURNABLE PACKAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C532 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI : I_PAI<C534>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment terms basis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT")]
    public class PAT : I_PAT<C110, C112>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment terms type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
        /// <summary>
        /// PAYMENT TERMS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C110 PAYMENTTERMS_02 { get; set; }
        /// <summary>
        /// TERMS/TIME INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C112 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    /// <summary>
    /// Percentage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCD")]
    public class PCD : I_PCD<C501>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C501 PERCENTAGEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Package identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCI")]
    public class PCI : I_PCI<C210, C827>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marking instructions code
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA : I_PIA<C212, C212, C212, C212, C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C212 ITEMNUMBERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C212 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C212 ITEMNUMBERIDENTIFICATION_05 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C212 ITEMNUMBERIDENTIFICATION_06 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI : I_PRI<C509>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY : I_QTY<C186>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity variances
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QVR")]
    public class QVR : I_QVR<C279, C960>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DIFFERENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C279 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        /// <summary>
        /// Discrepancy nature identification code
        /// </summary>
        [DataMember]
        [DataElement("4221", typeof(EDIFACT_ID_4221))]
        [Pos(2)]
        public string Discrepancynatureidentificationcode_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C960 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF : I_RFF<C506>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Rate details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RTE")]
    public class RTE : I_RTE<C128>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// RATE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C128 RATEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Duty/tax/fee details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX : I_TAX<C241, C533, C243>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty or tax or fee function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C241 DUTYTAXFEETYPE_02 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE ACCOUNT DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee assessment basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// Duty or tax or fee category code
        /// </summary>
        [DataMember]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        /// <summary>
        /// Party tax identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT : I_TDT<C220, C228, C040, C401, C222>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C220 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C228 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
        /// <summary>
        /// EXCESS TRANSPORTATION INFORMATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C401 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        /// <summary>
        /// TRANSPORT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C222 TRANSPORTIDENTIFICATION_08 { get; set; }
        /// <summary>
        /// Transport means ownership indicator code
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Terms of delivery or transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOD")]
    public class TOD : I_TOD<C100>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery or transport terms function code
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// Section control
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("UNS")]
    public class UNS : I_UNS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Section identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("0081", typeof(EDIFACT_A))]
        [Pos(1)]
        public string Sectionidentification_01 { get; set; }
    }
}
