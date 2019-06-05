namespace EdiFabric.Templates.EdifactD96A
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
    /// ADJUSTMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AJT")]
    public class AJT : I_AJT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Adjustment reason, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4465", typeof(EDIFACT_ID_4465))]
        [Pos(1)]
        public string Adjustmentreasoncoded_01 { get; set; }
        /// <summary>
        /// Line item number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lineitemnumber_02 { get; set; }
    }
    
    /// <summary>
    /// ALLOWANCE OR CHARGE
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
        /// Allowance or charge qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement, coded
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string Settlementcoded_03 { get; set; }
        /// <summary>
        /// Calculation sequence indicator, coded
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequenceindicatorcoded_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C214 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// ADDITIONAL INFORMATION
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
        /// Country of origin, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3239", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Countryoforigincoded_01 { get; set; }
        /// <summary>
        /// Type of duty regime, coded
        /// </summary>
        [DataMember]
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string Typeofdutyregimecoded_02 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditionscoded_03 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditionscoded_04 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditionscoded_05 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditionscoded_06 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditionscoded_07 { get; set; }
    }
    
    /// <summary>
    /// ADDITIONAL PRICE INFORMATION
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
        /// Class of trade, coded
        /// </summary>
        [DataMember]
        [DataElement("4043", typeof(EDIFACT_ID_4043))]
        [Pos(1)]
        public string Classoftradecoded_01 { get; set; }
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
    /// BEGINNING OF MESSAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM : I_BGM<C002>
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
        /// Document/message number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Documentmessagenumber_02 { get; set; }
        /// <summary>
        /// Message function, coded
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public string Messagefunctioncoded_03 { get; set; }
        /// <summary>
        /// Response type, coded
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecoded_04 { get; set; }
    }
    
    /// <summary>
    /// CHARACTERISTIC VALUE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CAV")]
    public class CAV : I_CAV<C889>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CHARACTERISTIC VALUE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C889 CHARACTERISTICVALUE_01 { get; set; }
    }
    
    /// <summary>
    /// CHARACTERISTIC/CLASS ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CCI")]
    public class CCI : I_CCI<C502, C240>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Property class, coded
        /// </summary>
        [DataMember]
        [DataElement("7059", typeof(EDIFACT_ID_7059))]
        [Pos(1)]
        public string Propertyclasscoded_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// PRODUCT CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C240 PRODUCTCHARACTERISTIC_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL TOTAL
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
    /// COMMUNICATION CONTACT
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
    /// CONTACT INFORMATION
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
        /// Contact function, coded
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139))]
        [Pos(1)]
        public string Contactfunctioncoded_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// CURRENCIES
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
        /// Rate of exchange
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rateofexchange_03 { get; set; }
        /// <summary>
        /// Currency market exchange, coded
        /// </summary>
        [DataMember]
        [DataElement("6341", typeof(EDIFACT_ID_6341))]
        [Pos(4)]
        public string Currencymarketexchangecoded_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC : I_DOC<C002, C503>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication channel identifier, coded
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationchannelidentifiercoded_03 { get; set; }
        /// <summary>
        /// Number of copies of document required
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Numberofcopiesofdocumentrequired_04 { get; set; }
        /// <summary>
        /// Number of originals of document required
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Numberoforiginalsofdocumentrequired_05 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
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
    /// EQUIPMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQD")]
    public class EQD : I_EQD<C237, C224>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8053", typeof(EDIFACT_ID_8053))]
        [Pos(1)]
        public string Equipmentqualifier_01 { get; set; }
        /// <summary>
        /// EQUIPMENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C237 EQUIPMENTIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// EQUIPMENT SIZE AND TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C224 EQUIPMENTSIZEANDTYPE_03 { get; set; }
        /// <summary>
        /// Equipment supplier, coded
        /// </summary>
        [DataMember]
        [DataElement("8077", typeof(EDIFACT_ID_8077))]
        [Pos(4)]
        public string Equipmentsuppliercoded_04 { get; set; }
        /// <summary>
        /// Equipment status, coded
        /// </summary>
        [DataMember]
        [DataElement("8249", typeof(EDIFACT_ID_8249))]
        [Pos(5)]
        public string Equipmentstatuscoded_05 { get; set; }
        /// <summary>
        /// Full/empty indicator, coded
        /// </summary>
        [DataMember]
        [DataElement("8169", typeof(EDIFACT_ID_8169))]
        [Pos(6)]
        public string Fullemptyindicatorcoded_06 { get; set; }
    }
    
    /// <summary>
    /// FINANCIAL INSTITUTION INFORMATION
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
        /// Party qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyqualifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrycoded_04 { get; set; }
    }
    
    /// <summary>
    /// FREE TEXT
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
        /// Text subject qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public string Textsubjectqualifier_01 { get; set; }
        /// <summary>
        /// Text function, coded
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Textfunctioncoded_02 { get; set; }
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
        /// Language, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Languagecoded_05 { get; set; }
    }
    
    /// <summary>
    /// GOODS IDENTITY NUMBER
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
        /// Identity number qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(1)]
        public string Identitynumberqualifier_01 { get; set; }
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
    /// RELATED IDENTIFICATION NUMBERS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIR")]
    public class GIR : I_GIR<C206, C206, C206, C206, C206>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Set identification qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7297", typeof(EDIFACT_ID_7297))]
        [Pos(1)]
        public string Setidentificationqualifier_01 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C206 IDENTIFICATIONNUMBER_02 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C206 IDENTIFICATIONNUMBER_03 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C206 IDENTIFICATIONNUMBER_04 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C206 IDENTIFICATIONNUMBER_05 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C206 IDENTIFICATIONNUMBER_06 { get; set; }
    }
    
    /// <summary>
    /// HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HAN")]
    public class HAN : I_HAN<C524, C218>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C524 HANDLINGINSTRUCTIONS_01 { get; set; }
        /// <summary>
        /// HAZARDOUS MATERIAL
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C218 HAZARDOUSMATERIAL_02 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD : I_IMD<C273>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item description type, coded
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Itemdescriptiontypecoded_01 { get; set; }
        /// <summary>
        /// Item characteristic, coded
        /// </summary>
        [DataMember]
        [DataElement("7081", typeof(EDIFACT_ID_7081))]
        [Pos(2)]
        public string Itemcharacteristiccoded_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface/layer indicator, coded
        /// </summary>
        [DataMember]
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public string Surfacelayerindicatorcoded_04 { get; set; }
    }
    
    /// <summary>
    /// PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INP")]
    public class INP : I_INP<C849, C522, C850>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PARTIES TO INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C849 PARTIESTOINSTRUCTION_01 { get; set; }
        /// <summary>
        /// INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C522 INSTRUCTION_02 { get; set; }
        /// <summary>
        /// STATUS OF INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C850 STATUSOFINSTRUCTION_03 { get; set; }
        /// <summary>
        /// Action request/notification, coded
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(4)]
        public string Actionrequestnotificationcoded_04 { get; set; }
    }
    
    /// <summary>
    /// LINE ITEM
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
        /// Line item number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Lineitemnumber_01 { get; set; }
        /// <summary>
        /// Action request/notification, coded
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public string Actionrequestnotificationcoded_02 { get; set; }
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
        /// Configuration level
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevel_05 { get; set; }
        /// <summary>
        /// Configuration, coded
        /// </summary>
        [DataMember]
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string Configurationcoded_06 { get; set; }
    }
    
    /// <summary>
    /// PLACE/LOCATION IDENTIFICATION
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
        /// Place/location qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string Placelocationqualifier_01 { get; set; }
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
        /// Relation, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcoded_05 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENTS
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
        /// Measurement application qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public string Measurementapplicationqualifier_01 { get; set; }
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
        /// Surface/layer indicator, coded
        /// </summary>
        [DataMember]
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public string Surfacelayerindicatorcoded_04 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
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
    /// NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD : I_NAD<C082, C058, C080, C059>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyqualifier_01 { get; set; }
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
        /// Country sub-entity identification
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Countrysubentityidentification_07 { get; set; }
        /// <summary>
        /// Postcode identification
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postcodeidentification_08 { get; set; }
        /// <summary>
        /// Country, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Countrycoded_09 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE
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
        /// Number of packages
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Numberofpackages_01 { get; set; }
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
    /// PAYMENT INSTRUCTIONS
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
    /// PAYMENT TERMS BASIS
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
        /// Payment terms type qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279))]
        [Pos(1)]
        public string Paymenttermstypequalifier_01 { get; set; }
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
    /// PERCENTAGE DETAILS
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
    }
    
    /// <summary>
    /// PACKAGE IDENTIFICATION
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
        /// Marking instructions, coded
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233))]
        [Pos(1)]
        public string Markinginstructionscoded_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container/package status, coded
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerpackagestatuscoded_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// ADDITIONAL PRODUCT ID
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
        /// Product id. function qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347))]
        [Pos(1)]
        public string Productidfunctionqualifier_01 { get; set; }
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
    /// PRICE DETAILS
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
        /// Sub-line price change, coded
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublinepricechangecoded_02 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY
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
    /// QUANTITY VARIANCES
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
        /// Discrepancy, coded
        /// </summary>
        [DataMember]
        [DataElement("4221", typeof(EDIFACT_ID_4221))]
        [Pos(2)]
        public string Discrepancycoded_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C960 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// REQUIREMENTS AND CONDITIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RCS")]
    public class RCS : I_RCS<C550>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sector/subject identification qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7293", typeof(EDIFACT_ID_7293))]
        [Pos(1)]
        public string Sectorsubjectidentificationqualifier_01 { get; set; }
        /// <summary>
        /// REQUIREMENT/CONDITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C550 REQUIREMENTCONDITIONIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Action request/notification, coded
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string Actionrequestnotificationcoded_03 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
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
    /// RANGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RNG")]
    public class RNG : I_RNG<C280>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Range type qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6167", typeof(EDIFACT_ID_6167))]
        [Pos(1)]
        public string Rangetypequalifier_01 { get; set; }
        /// <summary>
        /// RANGE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C280 RANGE_02 { get; set; }
    }
    
    /// <summary>
    /// RATE DETAILS
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
    }
    
    /// <summary>
    /// SCHEDULING CONDITIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SCC")]
    public class SCC : I_SCC<C329>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery plan status indicator, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4017", typeof(EDIFACT_ID_4017))]
        [Pos(1)]
        public string Deliveryplanstatusindicatorcoded_01 { get; set; }
        /// <summary>
        /// Delivery requirements, coded
        /// </summary>
        [DataMember]
        [DataElement("4493", typeof(EDIFACT_ID_4493))]
        [Pos(2)]
        public string Deliveryrequirementscoded_02 { get; set; }
        /// <summary>
        /// PATTERN DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C329 PATTERNDESCRIPTION_03 { get; set; }
    }
    
    /// <summary>
    /// STAGES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STG")]
    public class STG : I_STG
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stages qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9421", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Stagesqualifier_01 { get; set; }
        /// <summary>
        /// Number of stages
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6426", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Numberofstages_02 { get; set; }
        /// <summary>
        /// Actual stage count
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6428", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Actualstagecount_03 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE DETAILS
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
        /// Duty/tax/fee function qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutytaxfeefunctionqualifier_01 { get; set; }
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
        /// Duty/tax/fee assessment basis
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeeassessmentbasis_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// Duty/tax/fee category, coded
        /// </summary>
        [DataMember]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutytaxfeecategorycoded_06 { get; set; }
        /// <summary>
        /// Party tax identification number
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentificationnumber_07 { get; set; }
    }
    
    /// <summary>
    /// DETAILS OF TRANSPORT
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
        /// Transport stage qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string Transportstagequalifier_01 { get; set; }
        /// <summary>
        /// Conveyance reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Conveyancereferencenumber_02 { get; set; }
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
        /// Transit direction, coded
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectioncoded_06 { get; set; }
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
        /// Transport ownership, coded
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportownershipcoded_09 { get; set; }
    }
    
    /// <summary>
    /// TERMS OF DELIVERY OR TRANSPORT
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
        /// Terms of delivery or transport function, coded
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055))]
        [Pos(1)]
        public string Termsofdeliveryortransportfunctioncoded_01 { get; set; }
        /// <summary>
        /// Transport charges method of payment, coded
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(2)]
        public string Transportchargesmethodofpaymentcoded_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// SECTION CONTROL
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
