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
    /// ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ADR")]
    public class ADR : I_ADR<C817, C090, C819, C517>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ADDRESS USAGE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C817 ADDRESSUSAGE_01 { get; set; }
        /// <summary>
        /// ADDRESS DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C090 ADDRESSDETAILS_02 { get; set; }
        /// <summary>
        /// City name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Cityname_03 { get; set; }
        /// <summary>
        /// Postcode identification
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Postcodeidentification_04 { get; set; }
        /// <summary>
        /// Country, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Countrycoded_05 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_06 { get; set; }
        /// <summary>
        /// LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C517 LOCATIONIDENTIFICATION_07 { get; set; }
    }
    
    /// <summary>
    /// AGREEMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AGR")]
    public class AGR : I_AGR<C543>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// AGREEMENT TYPE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C543 AGREEMENTTYPEIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// Service layer, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9419", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Servicelayercoded_02 { get; set; }
    }
    
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
    /// AMOUNTS RELATIONSHIP DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ARD")]
    public class ARD : I_ARD<C549>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY FUNCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C549 MONETARYFUNCTION_01 { get; set; }
    }
    
    /// <summary>
    /// ARRAY INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ARR")]
    public class ARR : I_ARR<C778, C770>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// POSITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C778 POSITIONIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// ARRAY CELL DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C770 ARRAYCELLDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// ARRAY STRUCTURE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ASI")]
    public class ASI : I_ASI<C779, C082>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ARRAY STRUCTURE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C779 ARRAYSTRUCTUREIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
    }
    
    /// <summary>
    /// ATTRIBUTE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ATT")]
    public class ATT : I_ATT<C955, C956>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Attribute function qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9017", typeof(EDIFACT_ID_9017))]
        [Pos(1)]
        public string Attributefunctionqualifier_01 { get; set; }
        /// <summary>
        /// ATTRIBUTE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C955 ATTRIBUTETYPE_02 { get; set; }
        /// <summary>
        /// ATTRIBUTE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C956 ATTRIBUTEDETAILS_03 { get; set; }
    }
    
    /// <summary>
    /// AUTHENTICATION RESULT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AUT")]
    public class AUT : I_AUT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Validation result
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("9280", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Validationresult_01 { get; set; }
        /// <summary>
        /// Validation key identification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9282", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Validationkeyidentification_02 { get; set; }
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
    /// STRUCTURE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BII")]
    public class BII : I_BII<C045>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Indexing structure qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7429", typeof(EDIFACT_ID_7429))]
        [Pos(1)]
        public string Indexingstructurequalifier_01 { get; set; }
        /// <summary>
        /// BILL LEVEL IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C045 BILLLEVELIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Item number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Itemnumber_03 { get; set; }
    }
    
    /// <summary>
    /// BUSINESS FUNCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BUS")]
    public class BUS : I_BUS<C521, C551>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// BUSINESS FUNCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C521 BUSINESSFUNCTION_01 { get; set; }
        /// <summary>
        /// Geographic environment, coded
        /// </summary>
        [DataMember]
        [DataElement("3279", typeof(EDIFACT_ID_3279))]
        [Pos(2)]
        public string Geographicenvironmentcoded_02 { get; set; }
        /// <summary>
        /// Type of financial transaction, coded
        /// </summary>
        [DataMember]
        [DataElement("4487", typeof(EDIFACT_ID_4487))]
        [Pos(3)]
        public string Typeoffinancialtransactioncoded_03 { get; set; }
        /// <summary>
        /// BANK OPERATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C551 BANKOPERATION_04 { get; set; }
        /// <summary>
        /// Intra-company payment, coded
        /// </summary>
        [DataMember]
        [DataElement("4463", typeof(EDIFACT_ID_4463))]
        [Pos(5)]
        public string Intracompanypaymentcoded_05 { get; set; }
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
    /// CREDIT COVER DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CCD")]
    public class CCD : I_CCD
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Credit cover request, coded
        /// </summary>
        [DataMember]
        [DataElement("4505", typeof(EDIFACT_ID_4505))]
        [Pos(1)]
        public string Creditcoverrequestcoded_01 { get; set; }
        /// <summary>
        /// Credit cover response, coded
        /// </summary>
        [DataMember]
        [DataElement("4507", typeof(EDIFACT_ID_4507))]
        [Pos(2)]
        public string Creditcoverresponsecoded_02 { get; set; }
        /// <summary>
        /// Credit cover reason, coded
        /// </summary>
        [DataMember]
        [DataElement("4509", typeof(EDIFACT_ID_4509))]
        [Pos(3)]
        public string Creditcoverreasoncoded_03 { get; set; }
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
    /// PHYSICAL OR LOGICAL STATE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CDI")]
    public class CDI : I_CDI<C564>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Physical or logical state qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7001", typeof(EDIFACT_ID_7001))]
        [Pos(1)]
        public string Physicalorlogicalstatequalifier_01 { get; set; }
        /// <summary>
        /// PHYSICAL OR LOGICAL STATE INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C564 PHYSICALORLOGICALSTATEINFORMATION_02 { get; set; }
    }
    
    /// <summary>
    /// CODE SET IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CDS")]
    public class CDS : I_CDS<C702>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CODE SET IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C702 CODESETIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// Class designator, coded
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(2)]
        public string Classdesignatorcoded_02 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(3)]
        public string Maintenanceoperationcoded_03 { get; set; }
    }
    
    /// <summary>
    /// CODE VALUE DEFINITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CDV")]
    public class CDV : I_CDV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Code value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("9426", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Codevalue_01 { get; set; }
        /// <summary>
        /// Code name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("9434", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Codename_02 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(3)]
        public string Maintenanceoperationcoded_03 { get; set; }
    }
    
    /// <summary>
    /// COMPUTER ENVIRONMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CED")]
    public class CED : I_CED<C079>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Computer environment details qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1501", typeof(EDIFACT_ID_1501))]
        [Pos(1)]
        public string Computerenvironmentdetailsqualifier_01 { get; set; }
        /// <summary>
        /// COMPUTER ENVIRONMENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C079 COMPUTERENVIRONMENTIDENTIFICATION_02 { get; set; }
    }
    
    /// <summary>
    /// COMPOSITE DATA ELEMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CMP")]
    public class CMP : I_CMP
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Composite data element tag
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("9146", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Compositedataelementtag_01 { get; set; }
        /// <summary>
        /// Class designator, coded
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(2)]
        public string Classdesignatorcoded_02 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(3)]
        public string Maintenanceoperationcoded_03 { get; set; }
    }
    
    /// <summary>
    /// CONSIGNMENT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNI")]
    public class CNI : I_CNI<C503>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Consolidation item number
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("1490", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Consolidationitemnumber_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Consignment load sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("1312", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Consignmentloadsequencenumber_03 { get; set; }
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
    /// COMPONENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COD")]
    public class COD : I_COD<C823, C824>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TYPE OF UNIT/COMPONENT
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C823 TYPEOFUNITCOMPONENT_01 { get; set; }
        /// <summary>
        /// COMPONENT MATERIAL
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C824 COMPONENTMATERIAL_02 { get; set; }
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
    /// CONTRIBUTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COT")]
    public class COT : I_COT<C953, C522, C203, C960>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contribution qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5047", typeof(EDIFACT_ID_5047))]
        [Pos(1)]
        public string Contributionqualifier_01 { get; set; }
        /// <summary>
        /// CONTRIBUTION TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C953 CONTRIBUTIONTYPE_02 { get; set; }
        /// <summary>
        /// INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C522 INSTRUCTION_03 { get; set; }
        /// <summary>
        /// RATE/TARIFF CLASS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C203 RATETARIFFCLASS_04 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C960 REASONFORCHANGE_05 { get; set; }
    }
    
    /// <summary>
    /// CHARGE PAYMENT INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CPI")]
    public class CPI : I_CPI<C229, C231>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CHARGE CATEGORY
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C229 CHARGECATEGORY_01 { get; set; }
        /// <summary>
        /// METHOD OF PAYMENT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C231 METHODOFPAYMENT_02 { get; set; }
        /// <summary>
        /// Prepaid/collect indicator, coded
        /// </summary>
        [DataMember]
        [DataElement("4237", typeof(EDIFACT_ID_4237))]
        [Pos(3)]
        public string Prepaidcollectindicatorcoded_03 { get; set; }
    }
    
    /// <summary>
    /// CONSIGNMENT PACKING SEQUENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CPS")]
    public class CPS : I_CPS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hierarchical id. number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 12)]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hierarchicalidnumber_01 { get; set; }
        /// <summary>
        /// Hierarchical parent id.
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("7166", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Hierarchicalparentid_02 { get; set; }
        /// <summary>
        /// Packaging level, coded
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(3)]
        public string Packaginglevelcoded_03 { get; set; }
    }
    
    /// <summary>
    /// CUSTOMS STATUS OF GOODS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CST")]
    public class CST : I_CST<C246, C246, C246, C246, C246>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Goods item number
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("1496", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Goodsitemnumber_01 { get; set; }
        /// <summary>
        /// CUSTOMS IDENTITY CODES
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C246 CUSTOMSIDENTITYCODES_02 { get; set; }
        /// <summary>
        /// CUSTOMS IDENTITY CODES
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C246 CUSTOMSIDENTITYCODES_03 { get; set; }
        /// <summary>
        /// CUSTOMS IDENTITY CODES
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C246 CUSTOMSIDENTITYCODES_04 { get; set; }
        /// <summary>
        /// CUSTOMS IDENTITY CODES
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C246 CUSTOMSIDENTITYCODES_05 { get; set; }
        /// <summary>
        /// CUSTOMS IDENTITY CODES
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C246 CUSTOMSIDENTITYCODES_06 { get; set; }
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
    /// DAMAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DAM")]
    public class DAM : I_DAM<C821, C822, C825, C826>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Damage details qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7493", typeof(EDIFACT_ID_7493))]
        [Pos(1)]
        public string Damagedetailsqualifier_01 { get; set; }
        /// <summary>
        /// TYPE OF DAMAGE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C821 TYPEOFDAMAGE_02 { get; set; }
        /// <summary>
        /// DAMAGE AREA
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C822 DAMAGEAREA_03 { get; set; }
        /// <summary>
        /// DAMAGE SEVERITY
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C825 DAMAGESEVERITY_04 { get; set; }
        /// <summary>
        /// ACTION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C826 ACTION_05 { get; set; }
    }
    
    /// <summary>
    /// DANGEROUS GOODS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DGS")]
    public class DGS : I_DGS<C205, C234, C223, C235, C236>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dangerous goods regulations, coded
        /// </summary>
        [DataMember]
        [DataElement("8273", typeof(EDIFACT_ID_8273))]
        [Pos(1)]
        public string Dangerousgoodsregulationscoded_01 { get; set; }
        /// <summary>
        /// HAZARD CODE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C205 HAZARDCODE_02 { get; set; }
        /// <summary>
        /// UNDG INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C234 UNDGINFORMATION_03 { get; set; }
        /// <summary>
        /// DANGEROUS GOODS SHIPMENT FLASHPOINT
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C223 DANGEROUSGOODSSHIPMENTFLASHPOINT_04 { get; set; }
        /// <summary>
        /// Packing group, coded
        /// </summary>
        [DataMember]
        [DataElement("8339", typeof(EDIFACT_ID_8339))]
        [Pos(5)]
        public string Packinggroupcoded_05 { get; set; }
        /// <summary>
        /// EMS number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("8364", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string EMSnumber_06 { get; set; }
        /// <summary>
        /// MFAG
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8410", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string MFAG_07 { get; set; }
        /// <summary>
        /// Trem card number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("8126", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Tremcardnumber_08 { get; set; }
        /// <summary>
        /// HAZARD IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C235 HAZARDIDENTIFICATION_09 { get; set; }
        /// <summary>
        /// DANGEROUS GOODS LABEL
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C236 DANGEROUSGOODSLABEL_10 { get; set; }
        /// <summary>
        /// Packing instruction, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8255", typeof(EDIFACT_AN))]
        [Pos(11)]
        public string Packinginstructioncoded_11 { get; set; }
        /// <summary>
        /// Category of means of transport, coded
        /// </summary>
        [DataMember]
        [DataElement("8325", typeof(EDIFACT_ID_8325))]
        [Pos(12)]
        public string Categoryofmeansoftransportcoded_12 { get; set; }
        /// <summary>
        /// Permission for transport, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8211", typeof(EDIFACT_AN))]
        [Pos(13)]
        public string Permissionfortransportcoded_13 { get; set; }
    }
    
    /// <summary>
    /// DIRECTORY IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DII")]
    public class DII : I_DII
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Version
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Version_01 { get; set; }
        /// <summary>
        /// Release
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 9)]
        [DataElement("1058", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Release_02 { get; set; }
        /// <summary>
        /// Directory status
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9148", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Directorystatus_03 { get; set; }
        /// <summary>
        /// Control agency
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1476", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Controlagency_04 { get; set; }
        /// <summary>
        /// Language, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Languagecoded_05 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(6)]
        public string Maintenanceoperationcoded_06 { get; set; }
    }
    
    /// <summary>
    /// DIMENSIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DIM")]
    public class DIM : I_DIM<C211>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dimension qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6145", typeof(EDIFACT_ID_6145))]
        [Pos(1)]
        public string Dimensionqualifier_01 { get; set; }
        /// <summary>
        /// DIMENSIONS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C211 DIMENSIONS_02 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT LINE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DLI")]
    public class DLI : I_DLI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document line indicator, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1073", typeof(EDIFACT_ID_1073))]
        [Pos(1)]
        public string Documentlineindicatorcoded_01 { get; set; }
        /// <summary>
        /// Line item number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lineitemnumber_02 { get; set; }
    }
    
    /// <summary>
    /// DELIVERY LIMITATIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DLM")]
    public class DLM : I_DLM<C522, C214>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Back order, coded
        /// </summary>
        [DataMember]
        [DataElement("4455", typeof(EDIFACT_ID_4455))]
        [Pos(1)]
        public string Backordercoded_01 { get; set; }
        /// <summary>
        /// INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C522 INSTRUCTION_02 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C214 SPECIALSERVICESIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Product/service substitution, coded
        /// </summary>
        [DataMember]
        [DataElement("4457", typeof(EDIFACT_ID_4457))]
        [Pos(4)]
        public string Productservicesubstitutioncoded_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE SUMMARY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMS")]
    public class DMS : I_DMS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document/message number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentmessagenumber_01 { get; set; }
        /// <summary>
        /// Document/message name, coded
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(2)]
        public string Documentmessagenamecoded_02 { get; set; }
        /// <summary>
        /// Total number of items
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7240", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Totalnumberofitems_03 { get; set; }
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
    /// DATA SET IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DSI")]
    public class DSI : I_DSI<C782, C082, C286>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATA SET IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C782 DATASETIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        /// <summary>
        /// SEQUENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C286 SEQUENCEINFORMATION_04 { get; set; }
        /// <summary>
        /// Revision number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionnumber_05 { get; set; }
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
    /// EXTERNAL FILE LINK IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EFI")]
    public class EFI : I_EFI<C077, C099>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// FILE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C077 FILEIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// FILE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C099 FILEDETAILS_02 { get; set; }
        /// <summary>
        /// Sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Sequencenumber_03 { get; set; }
    }
    
    /// <summary>
    /// SIMPLE DATA ELEMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ELM")]
    public class ELM : I_ELM
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Simple data element tag
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("9150", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Simpledataelementtag_01 { get; set; }
        /// <summary>
        /// Simple data element character representation, coded
        /// </summary>
        [DataMember]
        [DataElement("9153", typeof(EDIFACT_ID_9153))]
        [Pos(2)]
        public string Simpledataelementcharacterrepresentationcoded_02 { get; set; }
        /// <summary>
        /// Simple data element length type, coded
        /// </summary>
        [DataMember]
        [DataElement("9155", typeof(EDIFACT_ID_9155))]
        [Pos(3)]
        public string Simpledataelementlengthtypecoded_03 { get; set; }
        /// <summary>
        /// Simple data element maximum length
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9156", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Simpledataelementmaximumlength_04 { get; set; }
        /// <summary>
        /// Simple data element minimum length
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9158", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Simpledataelementminimumlength_05 { get; set; }
        /// <summary>
        /// Code set indicator, coded
        /// </summary>
        [DataMember]
        [DataElement("9161", typeof(EDIFACT_ID_9161))]
        [Pos(6)]
        public string Codesetindicatorcoded_06 { get; set; }
        /// <summary>
        /// Class designator, coded
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(7)]
        public string Classdesignatorcoded_07 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(8)]
        public string Maintenanceoperationcoded_08 { get; set; }
    }
    
    /// <summary>
    /// DATA ELEMENT USAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ELU")]
    public class ELU : I_ELU
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Data element tag
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("9162", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dataelementtag_01 { get; set; }
        /// <summary>
        /// Requirement designator, coded
        /// </summary>
        [DataMember]
        [DataElement("7299", typeof(EDIFACT_ID_7299))]
        [Pos(2)]
        public string Requirementdesignatorcoded_02 { get; set; }
        /// <summary>
        /// Sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Sequencenumber_03 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
    }
    
    /// <summary>
    /// EMPLOYMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EMP")]
    public class EMP : I_EMP<C948, C951, C950>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Employment qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9003", typeof(EDIFACT_ID_9003))]
        [Pos(1)]
        public string Employmentqualifier_01 { get; set; }
        /// <summary>
        /// EMPLOYMENT CATEGORY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C948 EMPLOYMENTCATEGORY_02 { get; set; }
        /// <summary>
        /// OCCUPATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C951 OCCUPATION_03 { get; set; }
        /// <summary>
        /// QUALIFICATION CLASSIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C950 QUALIFICATIONCLASSIFICATION_04 { get; set; }
        /// <summary>
        /// Job title
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3494", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Jobtitle_05 { get; set; }
        /// <summary>
        /// Qualification area, coded
        /// </summary>
        [DataMember]
        [DataElement("9035", typeof(EDIFACT_ID_9035))]
        [Pos(6)]
        public string Qualificationareacoded_06 { get; set; }
    }
    
    /// <summary>
    /// ATTACHED EQUIPMENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQA")]
    public class EQA : I_EQA<C237>
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
    /// NUMBER OF UNITS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQN")]
    public class EQN : I_EQN<C523>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// NUMBER OF UNIT DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C523 NUMBEROFUNITDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// APPLICATION ERROR INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ERC")]
    public class ERC : I_ERC<C901>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// APPLICATION ERROR DETAIL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C901 APPLICATIONERRORDETAIL_01 { get; set; }
    }
    
    /// <summary>
    /// ERROR POINT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ERP")]
    public class ERP : I_ERP<C701>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ERROR POINT DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C701 ERRORPOINTDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// FINANCIAL CHARGES ALLOCATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FCA")]
    public class FCA : I_FCA<C878>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Settlement, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(1)]
        public string Settlementcoded_01 { get; set; }
        /// <summary>
        /// CHARGE/ALLOWANCE ACCOUNT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C878 CHARGEALLOWANCEACCOUNT_02 { get; set; }
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
    /// FOOTNOTE SET
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FNS")]
    public class FNS : I_FNS<C783, C082>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// FOOTNOTE SET IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C783 FOOTNOTESETIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
    }
    
    /// <summary>
    /// FOOTNOTE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FNT")]
    public class FNT : I_FNT<C784, C082>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// FOOTNOTE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C784 FOOTNOTEIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
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
    /// NATURE OF CARGO
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GDS")]
    public class GDS : I_GDS<C703>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// NATURE OF CARGO
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C703 NATUREOFCARGO_01 { get; set; }
    }
    
    /// <summary>
    /// GOODS ITEM DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GID")]
    public class GID : I_GID<C213, C213, C213>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Goods item number
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("1496", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Goodsitemnumber_01 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C213 NUMBERANDTYPEOFPACKAGES_02 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C213 NUMBERANDTYPEOFPACKAGES_03 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C213 NUMBERANDTYPEOFPACKAGES_04 { get; set; }
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
    /// GENERAL INDICATOR
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIS")]
    public class GIS : I_GIS<C529>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PROCESSING INDICATOR
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C529 PROCESSINGINDICATOR_01 { get; set; }
    }
    
    /// <summary>
    /// GOVERNMENTAL REQUIREMENTS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GOR")]
    public class GOR : I_GOR<C232, C232, C232, C232>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport movement, coded
        /// </summary>
        [DataMember]
        [DataElement("8323", typeof(EDIFACT_ID_8323))]
        [Pos(1)]
        public string Transportmovementcoded_01 { get; set; }
        /// <summary>
        /// GOVERNMENT ACTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C232 GOVERNMENTACTION_02 { get; set; }
        /// <summary>
        /// GOVERNMENT ACTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C232 GOVERNMENTACTION_03 { get; set; }
        /// <summary>
        /// GOVERNMENT ACTION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C232 GOVERNMENTACTION_04 { get; set; }
        /// <summary>
        /// GOVERNMENT ACTION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C232 GOVERNMENTACTION_05 { get; set; }
    }
    
    /// <summary>
    /// SEGMENT GROUP USAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GRU")]
    public class GRU : I_GRU
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Group identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("9164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Groupidentification_01 { get; set; }
        /// <summary>
        /// Requirement designator, coded
        /// </summary>
        [DataMember]
        [DataElement("7299", typeof(EDIFACT_ID_7299))]
        [Pos(2)]
        public string Requirementdesignatorcoded_02 { get; set; }
        /// <summary>
        /// Maximum number of occurrences
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("6176", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Maximumnumberofoccurrences_03 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
        /// <summary>
        /// Sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Sequencenumber_05 { get; set; }
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
    /// INSURANCE COVER DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ICD")]
    public class ICD : I_ICD<C330, C331>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// INSURANCE COVER TYPE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C330 INSURANCECOVERTYPE_01 { get; set; }
        /// <summary>
        /// INSURANCE COVER DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C331 INSURANCECOVERDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// IDENTITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IDE")]
    public class IDE : I_IDE<C206, C082, C778, C240>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Identification qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7495", typeof(EDIFACT_ID_7495))]
        [Pos(1)]
        public string Identificationqualifier_01 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C206 IDENTIFICATIONNUMBER_02 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C082 PARTYIDENTIFICATIONDETAILS_03 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(4)]
        public string Statuscoded_04 { get; set; }
        /// <summary>
        /// Configuration level
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevel_05 { get; set; }
        /// <summary>
        /// POSITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C778 POSITIONIDENTIFICATION_06 { get; set; }
        /// <summary>
        /// PRODUCT CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C240 PRODUCTCHARACTERISTIC_07 { get; set; }
    }
    
    /// <summary>
    /// PERSON CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IHC")]
    public class IHC : I_IHC<C818>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Person characteristic qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3289", typeof(EDIFACT_ID_3289))]
        [Pos(1)]
        public string Personcharacteristicqualifier_01 { get; set; }
        /// <summary>
        /// PERSON INHERITED CHARACTERISTIC DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C818 PERSONINHERITEDCHARACTERISTICDETAILS_02 { get; set; }
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
    /// INDEX DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IND")]
    public class IND : I_IND<C545, C546>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// INDEX IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C545 INDEXIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// INDEX VALUE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C546 INDEXVALUE_02 { get; set; }
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
    /// INVENTORY MANAGEMENT RELATED DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INV")]
    public class INV : I_INV<C522>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Inventory movement direction, coded
        /// </summary>
        [DataMember]
        [DataElement("4501", typeof(EDIFACT_ID_4501))]
        [Pos(1)]
        public string Inventorymovementdirectioncoded_01 { get; set; }
        /// <summary>
        /// Type of inventory affected, coded
        /// </summary>
        [DataMember]
        [DataElement("7491", typeof(EDIFACT_ID_7491))]
        [Pos(2)]
        public string Typeofinventoryaffectedcoded_02 { get; set; }
        /// <summary>
        /// Reason for inventory movement, coded
        /// </summary>
        [DataMember]
        [DataElement("4499", typeof(EDIFACT_ID_4499))]
        [Pos(3)]
        public string Reasonforinventorymovementcoded_03 { get; set; }
        /// <summary>
        /// Inventory balance method, coded
        /// </summary>
        [DataMember]
        [DataElement("4503", typeof(EDIFACT_ID_4503))]
        [Pos(4)]
        public string Inventorybalancemethodcoded_04 { get; set; }
        /// <summary>
        /// INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C522 INSTRUCTION_05 { get; set; }
    }
    
    /// <summary>
    /// INFORMATION REQUIRED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IRQ")]
    public class IRQ : I_IRQ<C333>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// INFORMATION REQUEST
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C333 INFORMATIONREQUEST_01 { get; set; }
    }
    
    /// <summary>
    /// LANGUAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LAN")]
    public class LAN : I_LAN<C508>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Language qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3455", typeof(EDIFACT_ID_3455))]
        [Pos(1)]
        public string Languagequalifier_01 { get; set; }
        /// <summary>
        /// LANGUAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C508 LANGUAGEDETAILS_02 { get; set; }
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
    /// MEMBERSHIP DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEM")]
    public class MEM : I_MEM<C942, C944, C945, C203, C960>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Membership qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7449", typeof(EDIFACT_ID_7449))]
        [Pos(1)]
        public string Membershipqualifier_01 { get; set; }
        /// <summary>
        /// MEMBERSHIP CATEGORY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C942 MEMBERSHIPCATEGORY_02 { get; set; }
        /// <summary>
        /// MEMBERSHIP STATUS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C944 MEMBERSHIPSTATUS_03 { get; set; }
        /// <summary>
        /// MEMBERSHIP LEVEL
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C945 MEMBERSHIPLEVEL_04 { get; set; }
        /// <summary>
        /// RATE/TARIFF CLASS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C203 RATETARIFFCLASS_05 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C960 REASONFORCHANGE_06 { get; set; }
    }
    
    /// <summary>
    /// MARKET/SALES CHANNEL INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MKS")]
    public class MKS : I_MKS<C332>
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
        /// SALES CHANNEL IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C332 SALESCHANNELIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Action request/notification, coded
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string Actionrequestnotificationcoded_03 { get; set; }
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
    /// MESSAGE TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MSG")]
    public class MSG : I_MSG<C709>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MESSAGE IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C709 MESSAGEIDENTIFIER_01 { get; set; }
        /// <summary>
        /// Class designator, coded
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(2)]
        public string Classdesignatorcoded_02 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(3)]
        public string Maintenanceoperationcoded_03 { get; set; }
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
    /// NATIONALITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAT")]
    public class NAT : I_NAT<C042>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Nationality qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3493", typeof(EDIFACT_ID_3493))]
        [Pos(1)]
        public string Nationalityqualifier_01 { get; set; }
        /// <summary>
        /// NATIONALITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C042 NATIONALITYDETAILS_02 { get; set; }
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
    /// PERSON DEMOGRAPHIC INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PDI")]
    public class PDI : I_PDI<C085, C101>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sex, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3499", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Sexcoded_01 { get; set; }
        /// <summary>
        /// MARITAL STATUS DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C085 MARITALSTATUSDETAILS_02 { get; set; }
        /// <summary>
        /// RELIGION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C101 RELIGIONDETAILS_03 { get; set; }
    }
    
    /// <summary>
    /// PRODUCT GROUP INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PGI")]
    public class PGI : I_PGI<C288>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product group type, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5379", typeof(EDIFACT_ID_5379))]
        [Pos(1)]
        public string Productgrouptypecoded_01 { get; set; }
        /// <summary>
        /// PRODUCT GROUP
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C288 PRODUCTGROUP_02 { get; set; }
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
    /// PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PNA")]
    public class PNA : I_PNA<C206, C082, C816, C816, C816, C816, C816>
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
        /// IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C206 IDENTIFICATIONNUMBER_02 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C082 PARTYIDENTIFICATIONDETAILS_03 { get; set; }
        /// <summary>
        /// Name type, coded
        /// </summary>
        [DataMember]
        [DataElement("3403", typeof(EDIFACT_ID_3403))]
        [Pos(4)]
        public string Nametypecoded_04 { get; set; }
        /// <summary>
        /// Name status, coded
        /// </summary>
        [DataMember]
        [DataElement("3397", typeof(EDIFACT_ID_3397))]
        [Pos(5)]
        public string Namestatuscoded_05 { get; set; }
        /// <summary>
        /// NAME COMPONENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C816 NAMECOMPONENTDETAILS_06 { get; set; }
        /// <summary>
        /// NAME COMPONENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C816 NAMECOMPONENTDETAILS_07 { get; set; }
        /// <summary>
        /// NAME COMPONENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C816 NAMECOMPONENTDETAILS_08 { get; set; }
        /// <summary>
        /// NAME COMPONENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C816 NAMECOMPONENTDETAILS_09 { get; set; }
        /// <summary>
        /// NAME COMPONENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C816 NAMECOMPONENTDETAILS_10 { get; set; }
    }
    
    /// <summary>
    /// PROCESS IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRC")]
    public class PRC : I_PRC<C242>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PROCESS TYPE AND DESCRIPTION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C242 PROCESSTYPEANDDESCRIPTION_01 { get; set; }
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
    /// PHYSICAL SAMPLE DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PSD")]
    public class PSD : I_PSD<C526, C514, C514, C514>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sample process status, coded
        /// </summary>
        [DataMember]
        [DataElement("4407", typeof(EDIFACT_ID_4407))]
        [Pos(1)]
        public string Sampleprocessstatuscoded_01 { get; set; }
        /// <summary>
        /// Sample selection method, coded
        /// </summary>
        [DataMember]
        [DataElement("7039", typeof(EDIFACT_ID_7039))]
        [Pos(2)]
        public string Sampleselectionmethodcoded_02 { get; set; }
        /// <summary>
        /// FREQUENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C526 FREQUENCYDETAILS_03 { get; set; }
        /// <summary>
        /// Sample description, coded
        /// </summary>
        [DataMember]
        [DataElement("7045", typeof(EDIFACT_ID_7045))]
        [Pos(4)]
        public string Sampledescriptioncoded_04 { get; set; }
        /// <summary>
        /// Sample direction, coded
        /// </summary>
        [DataMember]
        [DataElement("7047", typeof(EDIFACT_ID_7047))]
        [Pos(5)]
        public string Sampledirectioncoded_05 { get; set; }
        /// <summary>
        /// SAMPLE LOCATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C514 SAMPLELOCATIONDETAILS_06 { get; set; }
        /// <summary>
        /// SAMPLE LOCATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C514 SAMPLELOCATIONDETAILS_07 { get; set; }
        /// <summary>
        /// SAMPLE LOCATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C514 SAMPLELOCATIONDETAILS_08 { get; set; }
    }
    
    /// <summary>
    /// PRIORITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PTY")]
    public class PTY : I_PTY<C585>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Priority qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4035", typeof(EDIFACT_ID_4035))]
        [Pos(1)]
        public string Priorityqualifier_01 { get; set; }
        /// <summary>
        /// PRIORITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C585 PRIORITYDETAILS_02 { get; set; }
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
    /// RELATIONSHIP
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REL")]
    public class REL : I_REL<C941>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Relationship qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9141", typeof(EDIFACT_ID_9141))]
        [Pos(1)]
        public string Relationshipqualifier_01 { get; set; }
        /// <summary>
        /// RELATIONSHIP
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C941 RELATIONSHIP_02 { get; set; }
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
    /// REMUNERATION TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SAL")]
    public class SAL : I_SAL<C049>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REMUNERATION TYPE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C049 REMUNERATIONTYPEIDENTIFICATION_01 { get; set; }
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
    /// STRUCTURE COMPONENT DEFINITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SCD")]
    public class SCD : I_SCD<C786, C082, C778, C240>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Component function qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7497", typeof(EDIFACT_ID_7497))]
        [Pos(1)]
        public string Componentfunctionqualifier_01 { get; set; }
        /// <summary>
        /// STRUCTURE COMPONENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C786 STRUCTURECOMPONENTIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C082 PARTYIDENTIFICATIONDETAILS_03 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(4)]
        public string Statuscoded_04 { get; set; }
        /// <summary>
        /// Configuration level
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevel_05 { get; set; }
        /// <summary>
        /// POSITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C778 POSITIONIDENTIFICATION_06 { get; set; }
        /// <summary>
        /// PRODUCT CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C240 PRODUCTCHARACTERISTIC_07 { get; set; }
    }
    
    /// <summary>
    /// SEGMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SEG")]
    public class SEG : I_SEG
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Segment tag
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9166", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Segmenttag_01 { get; set; }
        /// <summary>
        /// Class designator, coded
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(2)]
        public string Classdesignatorcoded_02 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(3)]
        public string Maintenanceoperationcoded_03 { get; set; }
    }
    
    /// <summary>
    /// SEAL NUMBER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SEL")]
    public class SEL : I_SEL<C215>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Seal number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("9308", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Sealnumber_01 { get; set; }
        /// <summary>
        /// SEAL ISSUER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C215 SEALISSUER_02 { get; set; }
        /// <summary>
        /// Seal condition, coded
        /// </summary>
        [DataMember]
        [DataElement("4517", typeof(EDIFACT_ID_4517))]
        [Pos(3)]
        public string Sealconditioncoded_03 { get; set; }
    }
    
    /// <summary>
    /// SEQUENCE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SEQ")]
    public class SEQ : I_SEQ<C286>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Status indicator, coded
        /// </summary>
        [DataMember]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(1)]
        public string Statusindicatorcoded_01 { get; set; }
        /// <summary>
        /// SEQUENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C286 SEQUENCEINFORMATION_02 { get; set; }
    }
    
    /// <summary>
    /// SAFETY INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SFI")]
    public class SFI : I_SFI<C814, C815>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hierarchical id. number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 12)]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hierarchicalidnumber_01 { get; set; }
        /// <summary>
        /// SAFETY SECTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C814 SAFETYSECTION_02 { get; set; }
        /// <summary>
        /// ADDITIONAL SAFETY INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C815 ADDITIONALSAFETYINFORMATION_03 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
    }
    
    /// <summary>
    /// SPLIT GOODS PLACEMENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SGP")]
    public class SGP : I_SGP<C237>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// EQUIPMENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C237 EQUIPMENTIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// Number of packages
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Numberofpackages_02 { get; set; }
    }
    
    /// <summary>
    /// SEGMENT USAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SGU")]
    public class SGU : I_SGU
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Segment tag
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9166", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Segmenttag_01 { get; set; }
        /// <summary>
        /// Requirement designator, coded
        /// </summary>
        [DataMember]
        [DataElement("7299", typeof(EDIFACT_ID_7299))]
        [Pos(2)]
        public string Requirementdesignatorcoded_02 { get; set; }
        /// <summary>
        /// Maximum number of occurrences
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("6176", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Maximumnumberofoccurrences_03 { get; set; }
        /// <summary>
        /// Level number
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("7168", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Levelnumber_04 { get; set; }
        /// <summary>
        /// Sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Sequencenumber_05 { get; set; }
        /// <summary>
        /// Message section, coded
        /// </summary>
        [DataMember]
        [DataElement("1049", typeof(EDIFACT_ID_1049))]
        [Pos(6)]
        public string Messagesectioncoded_06 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(7)]
        public string Maintenanceoperationcoded_07 { get; set; }
    }
    
    /// <summary>
    /// SAMPLING PARAMETERS FOR SUMMARY STATISTICS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SPS")]
    public class SPS : I_SPS<C526, C512, C512, C512, C512, C512>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// FREQUENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C526 FREQUENCYDETAILS_01 { get; set; }
        /// <summary>
        /// Confidence limit
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("6074", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Confidencelimit_02 { get; set; }
        /// <summary>
        /// SIZE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C512 SIZEDETAILS_03 { get; set; }
        /// <summary>
        /// SIZE DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C512 SIZEDETAILS_04 { get; set; }
        /// <summary>
        /// SIZE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C512 SIZEDETAILS_05 { get; set; }
        /// <summary>
        /// SIZE DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C512 SIZEDETAILS_06 { get; set; }
        /// <summary>
        /// SIZE DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C512 SIZEDETAILS_07 { get; set; }
    }
    
    /// <summary>
    /// STATISTICS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STA")]
    public class STA : I_STA<C527>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Statistic type, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6331", typeof(EDIFACT_ID_6331))]
        [Pos(1)]
        public string Statistictypecoded_01 { get; set; }
        /// <summary>
        /// STATISTICAL DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C527 STATISTICALDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// STATISTICAL CONCEPT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STC")]
    public class STC : I_STC<C785, C082>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// STATISTICAL CONCEPT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C785 STATISTICALCONCEPTIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(4)]
        public string Maintenanceoperationcoded_04 { get; set; }
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
    /// STATUS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STS")]
    public class STS : I_STS<C601, C555, C556, C556, C556, C556, C556>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// STATUS TYPE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C601 STATUSTYPE_01 { get; set; }
        /// <summary>
        /// STATUS EVENT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C555 STATUSEVENT_02 { get; set; }
        /// <summary>
        /// STATUS REASON
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C556 STATUSREASON_03 { get; set; }
        /// <summary>
        /// STATUS REASON
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C556 STATUSREASON_04 { get; set; }
        /// <summary>
        /// STATUS REASON
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C556 STATUSREASON_05 { get; set; }
        /// <summary>
        /// STATUS REASON
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C556 STATUSREASON_06 { get; set; }
        /// <summary>
        /// STATUS REASON
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C556 STATUSREASON_07 { get; set; }
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
    /// TRANSPORT CHARGE/RATE CALCULATIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TCC")]
    public class TCC : I_TCC<C200, C203, C528, C554>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CHARGE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C200 CHARGE_01 { get; set; }
        /// <summary>
        /// RATE/TARIFF CLASS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C203 RATETARIFFCLASS_02 { get; set; }
        /// <summary>
        /// COMMODITY/RATE DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C528 COMMODITYRATEDETAIL_03 { get; set; }
        /// <summary>
        /// RATE/TARIFF CLASS DETAIL
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C554 RATETARIFFCLASSDETAIL_04 { get; set; }
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
    /// TEST METHOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TEM")]
    public class TEM : I_TEM<C244, C515>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TEST METHOD
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C244 TESTMETHOD_01 { get; set; }
        /// <summary>
        /// Test route of administering, coded
        /// </summary>
        [DataMember]
        [DataElement("4419", typeof(EDIFACT_ID_4419))]
        [Pos(2)]
        public string Testrouteofadministeringcoded_02 { get; set; }
        /// <summary>
        /// Test media, coded
        /// </summary>
        [DataMember]
        [DataElement("3077", typeof(EDIFACT_ID_3077))]
        [Pos(3)]
        public string Testmediacoded_03 { get; set; }
        /// <summary>
        /// Measurement application qualifier
        /// </summary>
        [DataMember]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(4)]
        public string Measurementapplicationqualifier_04 { get; set; }
        /// <summary>
        /// Test revision number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("7188", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Testrevisionnumber_05 { get; set; }
        /// <summary>
        /// TEST REASON
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C515 TESTREASON_06 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT MOVEMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TMD")]
    public class TMD : I_TMD<C219>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MOVEMENT TYPE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C219 MOVEMENTTYPE_01 { get; set; }
        /// <summary>
        /// Equipment plan
        /// </summary>
        [DataMember]
        [StringLength(1, 26)]
        [DataElement("8332", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Equipmentplan_02 { get; set; }
        /// <summary>
        /// Haulage arrangements, coded
        /// </summary>
        [DataMember]
        [DataElement("8341", typeof(EDIFACT_ID_8341))]
        [Pos(3)]
        public string Haulagearrangementscoded_03 { get; set; }
    }
    
    /// <summary>
    /// TEMPERATURE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TMP")]
    public class TMP : I_TMP<C239>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Temperature qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6245", typeof(EDIFACT_ID_6245))]
        [Pos(1)]
        public string Temperaturequalifier_01 { get; set; }
        /// <summary>
        /// TEMPERATURE SETTING
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C239 TEMPERATURESETTING_02 { get; set; }
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
    /// TRANSPORT PLACEMENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TPL")]
    public class TPL : I_TPL<C222>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TRANSPORT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C222 TRANSPORTIDENTIFICATION_01 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT SERVICE REQUIREMENTS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TSR")]
    public class TSR : I_TSR<C536, C233, C537, C703>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTRACT AND CARRIAGE CONDITION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C536 CONTRACTANDCARRIAGECONDITION_01 { get; set; }
        /// <summary>
        /// SERVICE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C233 SERVICE_02 { get; set; }
        /// <summary>
        /// TRANSPORT PRIORITY
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C537 TRANSPORTPRIORITY_03 { get; set; }
        /// <summary>
        /// NATURE OF CARGO
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C703 NATUREOFCARGO_04 { get; set; }
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
    
    /// <summary>
    /// VALUE LIST IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("VLI")]
    public class VLI : I_VLI<C780, C082, C240>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// VALUE LIST IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C780 VALUELISTIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
        /// <summary>
        /// Value list name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1514", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Valuelistname_04 { get; set; }
        /// <summary>
        /// Class designator, coded
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_ID_1507))]
        [Pos(5)]
        public string Classdesignatorcoded_05 { get; set; }
        /// <summary>
        /// Value list type, coded
        /// </summary>
        [DataMember]
        [DataElement("1505", typeof(EDIFACT_ID_1505))]
        [Pos(6)]
        public string Valuelisttypecoded_06 { get; set; }
        /// <summary>
        /// PRODUCT CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C240 PRODUCTCHARACTERISTIC_07 { get; set; }
        /// <summary>
        /// Maintenance operation, coded
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_ID_4513))]
        [Pos(8)]
        public string Maintenanceoperationcoded_08 { get; set; }
    }
}
