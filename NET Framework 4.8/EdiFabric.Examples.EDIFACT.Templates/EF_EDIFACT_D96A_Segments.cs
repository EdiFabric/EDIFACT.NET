namespace EdiFabric.Templates.Edifact
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    /// <summary>
    /// ADJUSTMENT DETAILS
    /// </summary>
    [Serializable()]
    [Segment("AJT")]
    public class AJT
    {
        
        /// <summary>
        /// Adjustment reason, coded
        /// </summary>
        [Required]
        [DataElement("4465", typeof(EDIFACT_ID_4465))]
        [Pos(1)]
        public string Adjustmentreasoncoded_01 { get; set; }
        /// <summary>
        /// Line item number
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lineitemnumber_02 { get; set; }
    }
    
    /// <summary>
    /// ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [Segment("ALC")]
    public class ALC
    {
        
        /// <summary>
        /// Allowance or charge qualifier
        /// </summary>
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [Pos(2)]
        public C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement, coded
        /// </summary>
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string Settlementcoded_03 { get; set; }
        /// <summary>
        /// Calculation sequence indicator, coded
        /// </summary>
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequenceindicatorcoded_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [Pos(5)]
        public C214 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// ADDITIONAL INFORMATION
    /// </summary>
    [Serializable()]
    [Segment("ALI")]
    public class ALI
    {
        
        /// <summary>
        /// Country of origin, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("3239", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Countryoforigincoded_01 { get; set; }
        /// <summary>
        /// Type of duty regime, coded
        /// </summary>
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string Typeofdutyregimecoded_02 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditionscoded_03 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditionscoded_04 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditionscoded_05 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditionscoded_06 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditionscoded_07 { get; set; }
    }
    
    /// <summary>
    /// ADDITIONAL PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [Segment("APR")]
    public class APR
    {
        
        /// <summary>
        /// Class of trade, coded
        /// </summary>
        [DataElement("4043", typeof(EDIFACT_ID_4043))]
        [Pos(1)]
        public string Classoftradecoded_01 { get; set; }
        /// <summary>
        /// PRICE MULTIPLIER INFORMATION
        /// </summary>
        [Pos(2)]
        public C138 PRICEMULTIPLIERINFORMATION_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [Pos(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// BEGINNING OF MESSAGE
    /// </summary>
    [Serializable()]
    [Segment("BGM")]
    public class BGM
    {
        
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// Document/message number
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Documentmessagenumber_02 { get; set; }
        /// <summary>
        /// Message function, coded
        /// </summary>
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public string Messagefunctioncoded_03 { get; set; }
        /// <summary>
        /// Response type, coded
        /// </summary>
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecoded_04 { get; set; }
    }
    
    /// <summary>
    /// CHARACTERISTIC VALUE
    /// </summary>
    [Serializable()]
    [Segment("CAV")]
    public class CAV
    {
        
        /// <summary>
        /// CHARACTERISTIC VALUE
        /// </summary>
        [Required]
        [Pos(1)]
        public C889 CHARACTERISTICVALUE_01 { get; set; }
    }
    
    /// <summary>
    /// CHARACTERISTIC/CLASS ID
    /// </summary>
    [Serializable()]
    [Segment("CCI")]
    public class CCI
    {
        
        /// <summary>
        /// Property class, coded
        /// </summary>
        [DataElement("7059", typeof(EDIFACT_ID_7059))]
        [Pos(1)]
        public string Propertyclasscoded_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [Pos(2)]
        public C502 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// PRODUCT CHARACTERISTIC
        /// </summary>
        [Pos(3)]
        public C240 PRODUCTCHARACTERISTIC_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL TOTAL
    /// </summary>
    [Serializable()]
    [Segment("CNT")]
    public class CNT
    {
        
        /// <summary>
        /// CONTROL
        /// </summary>
        [Required]
        [Pos(1)]
        public C270 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [Segment("COM")]
    public class COM
    {
        
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [Required]
        [Pos(1)]
        public C076 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    /// <summary>
    /// CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [Segment("CTA")]
    public class CTA
    {
        
        /// <summary>
        /// Contact function, coded
        /// </summary>
        [DataElement("3139", typeof(EDIFACT_ID_3139))]
        [Pos(1)]
        public string Contactfunctioncoded_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [Pos(2)]
        public C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// CURRENCIES
    /// </summary>
    [Serializable()]
    [Segment("CUX")]
    public class CUX
    {
        
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [Pos(1)]
        public C504 CURRENCYDETAILS_01 { get; set; }
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [Pos(2)]
        public C504 CURRENCYDETAILS_02 { get; set; }
        /// <summary>
        /// Rate of exchange
        /// </summary>
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rateofexchange_03 { get; set; }
        /// <summary>
        /// Currency market exchange, coded
        /// </summary>
        [DataElement("6341", typeof(EDIFACT_ID_6341))]
        [Pos(4)]
        public string Currencymarketexchangecoded_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [Segment("DOC")]
    public class DOC
    {
        
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [Required]
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [Pos(2)]
        public C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication channel identifier, coded
        /// </summary>
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationchannelidentifiercoded_03 { get; set; }
        /// <summary>
        /// Number of copies of document required
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Numberofcopiesofdocumentrequired_04 { get; set; }
        /// <summary>
        /// Number of originals of document required
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Numberoforiginalsofdocumentrequired_05 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [Segment("DTM")]
    public class DTM
    {
        
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Required]
        [Pos(1)]
        public C507 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// EQUIPMENT DETAILS
    /// </summary>
    [Serializable()]
    [Segment("EQD")]
    public class EQD
    {
        
        /// <summary>
        /// Equipment qualifier
        /// </summary>
        [Required]
        [DataElement("8053", typeof(EDIFACT_ID_8053))]
        [Pos(1)]
        public string Equipmentqualifier_01 { get; set; }
        /// <summary>
        /// EQUIPMENT IDENTIFICATION
        /// </summary>
        [Pos(2)]
        public C237 EQUIPMENTIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// EQUIPMENT SIZE AND TYPE
        /// </summary>
        [Pos(3)]
        public C224 EQUIPMENTSIZEANDTYPE_03 { get; set; }
        /// <summary>
        /// Equipment supplier, coded
        /// </summary>
        [DataElement("8077", typeof(EDIFACT_ID_8077))]
        [Pos(4)]
        public string Equipmentsuppliercoded_04 { get; set; }
        /// <summary>
        /// Equipment status, coded
        /// </summary>
        [DataElement("8249", typeof(EDIFACT_ID_8249))]
        [Pos(5)]
        public string Equipmentstatuscoded_05 { get; set; }
        /// <summary>
        /// Full/empty indicator, coded
        /// </summary>
        [DataElement("8169", typeof(EDIFACT_ID_8169))]
        [Pos(6)]
        public string Fullemptyindicatorcoded_06 { get; set; }
    }
    
    /// <summary>
    /// FINANCIAL INSTITUTION INFORMATION
    /// </summary>
    [Serializable()]
    [Segment("FII")]
    public class FII
    {
        
        /// <summary>
        /// Party qualifier
        /// </summary>
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyqualifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT IDENTIFICATION
        /// </summary>
        [Pos(2)]
        public C078 ACCOUNTIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [Pos(3)]
        public C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrycoded_04 { get; set; }
    }
    
    /// <summary>
    /// FREE TEXT
    /// </summary>
    [Serializable()]
    [Segment("FTX")]
    public class FTX
    {
        
        /// <summary>
        /// Text subject qualifier
        /// </summary>
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public string Textsubjectqualifier_01 { get; set; }
        /// <summary>
        /// Text function, coded
        /// </summary>
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Textfunctioncoded_02 { get; set; }
        /// <summary>
        /// TEXT REFERENCE
        /// </summary>
        [Pos(3)]
        public C107 TEXTREFERENCE_03 { get; set; }
        /// <summary>
        /// TEXT LITERAL
        /// </summary>
        [Pos(4)]
        public C108 TEXTLITERAL_04 { get; set; }
        /// <summary>
        /// Language, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Languagecoded_05 { get; set; }
    }
    
    /// <summary>
    /// GOODS IDENTITY NUMBER
    /// </summary>
    [Serializable()]
    [Segment("GIN")]
    public class GIN
    {
        
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(1)]
        public string Identitynumberqualifier_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [Required]
        [Pos(2)]
        public C208 IDENTITYNUMBERRANGE_02 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [Pos(3)]
        public C208 IDENTITYNUMBERRANGE_03 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [Pos(4)]
        public C208 IDENTITYNUMBERRANGE_04 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [Pos(5)]
        public C208 IDENTITYNUMBERRANGE_05 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [Pos(6)]
        public C208 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    /// <summary>
    /// RELATED IDENTIFICATION NUMBERS
    /// </summary>
    [Serializable()]
    [Segment("GIR")]
    public class GIR
    {
        
        /// <summary>
        /// Set identification qualifier
        /// </summary>
        [Required]
        [DataElement("7297", typeof(EDIFACT_ID_7297))]
        [Pos(1)]
        public string Setidentificationqualifier_01 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [Required]
        [Pos(2)]
        public C206 IDENTIFICATIONNUMBER_02 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [Pos(3)]
        public C206 IDENTIFICATIONNUMBER_03 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [Pos(4)]
        public C206 IDENTIFICATIONNUMBER_04 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [Pos(5)]
        public C206 IDENTIFICATIONNUMBER_05 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [Pos(6)]
        public C206 IDENTIFICATIONNUMBER_06 { get; set; }
    }
    
    /// <summary>
    /// HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [Segment("HAN")]
    public class HAN
    {
        
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [Pos(1)]
        public C524 HANDLINGINSTRUCTIONS_01 { get; set; }
        /// <summary>
        /// HAZARDOUS MATERIAL
        /// </summary>
        [Pos(2)]
        public C218 HAZARDOUSMATERIAL_02 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [Segment("IMD")]
    public class IMD
    {
        
        /// <summary>
        /// Item description type, coded
        /// </summary>
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Itemdescriptiontypecoded_01 { get; set; }
        /// <summary>
        /// Item characteristic, coded
        /// </summary>
        [DataElement("7081", typeof(EDIFACT_ID_7081))]
        [Pos(2)]
        public string Itemcharacteristiccoded_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [Pos(3)]
        public C273 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface/layer indicator, coded
        /// </summary>
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public string Surfacelayerindicatorcoded_04 { get; set; }
    }
    
    /// <summary>
    /// PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [Segment("INP")]
    public class INP
    {
        
        /// <summary>
        /// PARTIES TO INSTRUCTION
        /// </summary>
        [Pos(1)]
        public C849 PARTIESTOINSTRUCTION_01 { get; set; }
        /// <summary>
        /// INSTRUCTION
        /// </summary>
        [Pos(2)]
        public C522 INSTRUCTION_02 { get; set; }
        /// <summary>
        /// STATUS OF INSTRUCTION
        /// </summary>
        [Pos(3)]
        public C850 STATUSOFINSTRUCTION_03 { get; set; }
        /// <summary>
        /// Action request/notification, coded
        /// </summary>
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(4)]
        public string Actionrequestnotificationcoded_04 { get; set; }
    }
    
    /// <summary>
    /// LINE ITEM
    /// </summary>
    [Serializable()]
    [Segment("LIN")]
    public class LIN
    {
        
        /// <summary>
        /// Line item number
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Lineitemnumber_01 { get; set; }
        /// <summary>
        /// Action request/notification, coded
        /// </summary>
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public string Actionrequestnotificationcoded_02 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// SUB-LINE INFORMATION
        /// </summary>
        [Pos(4)]
        public C829 SUBLINEINFORMATION_04 { get; set; }
        /// <summary>
        /// Configuration level
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevel_05 { get; set; }
        /// <summary>
        /// Configuration, coded
        /// </summary>
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string Configurationcoded_06 { get; set; }
    }
    
    /// <summary>
    /// PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Segment("LOC")]
    public class LOC
    {
        
        /// <summary>
        /// Place/location qualifier
        /// </summary>
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string Placelocationqualifier_01 { get; set; }
        /// <summary>
        /// LOCATION IDENTIFICATION
        /// </summary>
        [Pos(2)]
        public C517 LOCATIONIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// RELATED LOCATION ONE IDENTIFICATION
        /// </summary>
        [Pos(3)]
        public C519 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// RELATED LOCATION TWO IDENTIFICATION
        /// </summary>
        [Pos(4)]
        public C553 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// Relation, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcoded_05 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENTS
    /// </summary>
    [Serializable()]
    [Segment("MEA")]
    public class MEA
    {
        
        /// <summary>
        /// Measurement application qualifier
        /// </summary>
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public string Measurementapplicationqualifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [Pos(2)]
        public C502 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [Pos(3)]
        public C174 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface/layer indicator, coded
        /// </summary>
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public string Surfacelayerindicatorcoded_04 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [Segment("MOA")]
    public class MOA
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [Required]
        [Pos(1)]
        public C516 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [Segment("NAD")]
    public class NAD
    {
        
        /// <summary>
        /// Party qualifier
        /// </summary>
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyqualifier_01 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Pos(3)]
        public C058 NAMEANDADDRESS_03 { get; set; }
        /// <summary>
        /// PARTY NAME
        /// </summary>
        [Pos(4)]
        public C080 PARTYNAME_04 { get; set; }
        /// <summary>
        /// STREET
        /// </summary>
        [Pos(5)]
        public C059 STREET_05 { get; set; }
        /// <summary>
        /// City name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// Country sub-entity identification
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Countrysubentityidentification_07 { get; set; }
        /// <summary>
        /// Postcode identification
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postcodeidentification_08 { get; set; }
        /// <summary>
        /// Country, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Countrycoded_09 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE
    /// </summary>
    [Serializable()]
    [Segment("PAC")]
    public class PAC
    {
        
        /// <summary>
        /// Number of packages
        /// </summary>
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Numberofpackages_01 { get; set; }
        /// <summary>
        /// PACKAGING DETAILS
        /// </summary>
        [Pos(2)]
        public C531 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [Pos(3)]
        public C202 PACKAGETYPE_03 { get; set; }
        /// <summary>
        /// PACKAGE TYPE IDENTIFICATION
        /// </summary>
        [Pos(4)]
        public C402 PACKAGETYPEIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// RETURNABLE PACKAGE DETAILS
        /// </summary>
        [Pos(5)]
        public C532 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [Segment("PAI")]
    public class PAI
    {
        
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public C534 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT TERMS BASIS
    /// </summary>
    [Serializable()]
    [Segment("PAT")]
    public class PAT
    {
        
        /// <summary>
        /// Payment terms type qualifier
        /// </summary>
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279))]
        [Pos(1)]
        public string Paymenttermstypequalifier_01 { get; set; }
        /// <summary>
        /// PAYMENT TERMS
        /// </summary>
        [Pos(2)]
        public C110 PAYMENTTERMS_02 { get; set; }
        /// <summary>
        /// TERMS/TIME INFORMATION
        /// </summary>
        [Pos(3)]
        public C112 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [Segment("PCD")]
    public class PCD
    {
        
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public C501 PERCENTAGEDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Segment("PCI")]
    public class PCI
    {
        
        /// <summary>
        /// Marking instructions, coded
        /// </summary>
        [DataElement("4233", typeof(EDIFACT_ID_4233))]
        [Pos(1)]
        public string Markinginstructionscoded_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [Pos(2)]
        public C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container/package status, coded
        /// </summary>
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerpackagestatuscoded_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [Pos(4)]
        public C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// ADDITIONAL PRODUCT ID
    /// </summary>
    [Serializable()]
    [Segment("PIA")]
    public class PIA
    {
        
        /// <summary>
        /// Product id. function qualifier
        /// </summary>
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347))]
        [Pos(1)]
        public string Productidfunctionqualifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Required]
        [Pos(2)]
        public C212 ITEMNUMBERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Pos(4)]
        public C212 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Pos(5)]
        public C212 ITEMNUMBERIDENTIFICATION_05 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [Pos(6)]
        public C212 ITEMNUMBERIDENTIFICATION_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE DETAILS
    /// </summary>
    [Serializable()]
    [Segment("PRI")]
    public class PRI
    {
        
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [Pos(1)]
        public C509 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line price change, coded
        /// </summary>
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublinepricechangecoded_02 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY
    /// </summary>
    [Serializable()]
    [Segment("QTY")]
    public class QTY
    {
        
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public C186 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY VARIANCES
    /// </summary>
    [Serializable()]
    [Segment("QVR")]
    public class QVR
    {
        
        /// <summary>
        /// QUANTITY DIFFERENCE INFORMATION
        /// </summary>
        [Pos(1)]
        public C279 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        /// <summary>
        /// Discrepancy, coded
        /// </summary>
        [DataElement("4221", typeof(EDIFACT_ID_4221))]
        [Pos(2)]
        public string Discrepancycoded_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [Pos(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// REQUIREMENTS AND CONDITIONS
    /// </summary>
    [Serializable()]
    [Segment("RCS")]
    public class RCS
    {
        
        /// <summary>
        /// Sector/subject identification qualifier
        /// </summary>
        [Required]
        [DataElement("7293", typeof(EDIFACT_ID_7293))]
        [Pos(1)]
        public string Sectorsubjectidentificationqualifier_01 { get; set; }
        /// <summary>
        /// REQUIREMENT/CONDITION IDENTIFICATION
        /// </summary>
        [Pos(2)]
        public C550 REQUIREMENTCONDITIONIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Action request/notification, coded
        /// </summary>
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string Actionrequestnotificationcoded_03 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [Segment("RFF")]
    public class RFF
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Required]
        [Pos(1)]
        public C506 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// RANGE DETAILS
    /// </summary>
    [Serializable()]
    [Segment("RNG")]
    public class RNG
    {
        
        /// <summary>
        /// Range type qualifier
        /// </summary>
        [Required]
        [DataElement("6167", typeof(EDIFACT_ID_6167))]
        [Pos(1)]
        public string Rangetypequalifier_01 { get; set; }
        /// <summary>
        /// RANGE
        /// </summary>
        [Pos(2)]
        public C280 RANGE_02 { get; set; }
    }
    
    /// <summary>
    /// RATE DETAILS
    /// </summary>
    [Serializable()]
    [Segment("RTE")]
    public class RTE
    {
        
        /// <summary>
        /// RATE DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public C128 RATEDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// SCHEDULING CONDITIONS
    /// </summary>
    [Serializable()]
    [Segment("SCC")]
    public class SCC
    {
        
        /// <summary>
        /// Delivery plan status indicator, coded
        /// </summary>
        [Required]
        [DataElement("4017", typeof(EDIFACT_ID_4017))]
        [Pos(1)]
        public string Deliveryplanstatusindicatorcoded_01 { get; set; }
        /// <summary>
        /// Delivery requirements, coded
        /// </summary>
        [DataElement("4493", typeof(EDIFACT_ID_4493))]
        [Pos(2)]
        public string Deliveryrequirementscoded_02 { get; set; }
        /// <summary>
        /// PATTERN DESCRIPTION
        /// </summary>
        [Pos(3)]
        public C329 PATTERNDESCRIPTION_03 { get; set; }
    }
    
    /// <summary>
    /// STAGES
    /// </summary>
    [Serializable()]
    [Segment("STG")]
    public class STG
    {
        
        /// <summary>
        /// Stages qualifier
        /// </summary>
        [Required]
        [StringLength(1, 3)]
        [DataElement("9421", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Stagesqualifier_01 { get; set; }
        /// <summary>
        /// Number of stages
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("6426", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Numberofstages_02 { get; set; }
        /// <summary>
        /// Actual stage count
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("6428", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Actualstagecount_03 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE DETAILS
    /// </summary>
    [Serializable()]
    [Segment("TAX")]
    public class TAX
    {
        
        /// <summary>
        /// Duty/tax/fee function qualifier
        /// </summary>
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutytaxfeefunctionqualifier_01 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE TYPE
        /// </summary>
        [Pos(2)]
        public C241 DUTYTAXFEETYPE_02 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE ACCOUNT DETAIL
        /// </summary>
        [Pos(3)]
        public C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        /// <summary>
        /// Duty/tax/fee assessment basis
        /// </summary>
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeeassessmentbasis_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [Pos(5)]
        public C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// Duty/tax/fee category, coded
        /// </summary>
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutytaxfeecategorycoded_06 { get; set; }
        /// <summary>
        /// Party tax identification number
        /// </summary>
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentificationnumber_07 { get; set; }
    }
    
    /// <summary>
    /// DETAILS OF TRANSPORT
    /// </summary>
    [Serializable()]
    [Segment("TDT")]
    public class TDT
    {
        
        /// <summary>
        /// Transport stage qualifier
        /// </summary>
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string Transportstagequalifier_01 { get; set; }
        /// <summary>
        /// Conveyance reference number
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Conveyancereferencenumber_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [Pos(3)]
        public C220 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [Pos(4)]
        public C228 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [Pos(5)]
        public C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction, coded
        /// </summary>
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectioncoded_06 { get; set; }
        /// <summary>
        /// EXCESS TRANSPORTATION INFORMATION
        /// </summary>
        [Pos(7)]
        public C401 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        /// <summary>
        /// TRANSPORT IDENTIFICATION
        /// </summary>
        [Pos(8)]
        public C222 TRANSPORTIDENTIFICATION_08 { get; set; }
        /// <summary>
        /// Transport ownership, coded
        /// </summary>
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportownershipcoded_09 { get; set; }
    }
    
    /// <summary>
    /// TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [Segment("TOD")]
    public class TOD
    {
        
        /// <summary>
        /// Terms of delivery or transport function, coded
        /// </summary>
        [DataElement("4055", typeof(EDIFACT_ID_4055))]
        [Pos(1)]
        public string Termsofdeliveryortransportfunctioncoded_01 { get; set; }
        /// <summary>
        /// Transport charges method of payment, coded
        /// </summary>
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(2)]
        public string Transportchargesmethodofpaymentcoded_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [Pos(3)]
        public C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// SECTION CONTROL
    /// </summary>
    [Serializable()]
    [Segment("UNS")]
    public class UNS
    {
        
        /// <summary>
        /// Section identification
        /// </summary>
        [Required]
        [StringLength(1, 1)]
        [DataElement("0081", typeof(EDIFACT_A))]
        [Pos(1)]
        public string Sectionidentification_01 { get; set; }
    }
}
