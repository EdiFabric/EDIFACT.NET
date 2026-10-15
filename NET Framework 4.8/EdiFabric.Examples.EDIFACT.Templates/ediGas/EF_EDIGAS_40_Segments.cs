namespace EdiFabric.Templates.Edigas40
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using EdiFabric.Core.Model.Edi.X12;
    
    
    /// <summary>
    // Accommodation allocation information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAI")]
    public class AAI
    {
        
        /// <summary>
        // ACCOMMODATION ALLOCATION INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(1)]
        public List<E997> E997_01 { get; set; }
    }
    
    /// <summary>
    // Health care claim adjudication information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ADI")]
    public class ADI
    {
        
        /// <summary>
        // OBJECT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(1)]
        public List<E206> E206_01 { get; set; }
        /// <summary>
        // SERVICE
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public List<E021> E021_02 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string ACTIONCODE_03 { get; set; }
        /// <summary>
        // MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(4)]
        public List<E017> E017_04 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public List<string> QUANTITY_05 { get; set; }
        /// <summary>
        // ADJUSTMENT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(6)]
        public List<E030> E030_06 { get; set; }
        /// <summary>
        // POLICY LIMITATION IDENTIFIER
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [DataElement("9620", typeof(EDIFACT_AN))]
        [Pos(7)]
        public List<string> POLICYLIMITATIONIDENTIFIER_07 { get; set; }
        /// <summary>
        // Product group name code
        /// </summary>
        [DataMember]
        [DataElement("5389", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string ProductGroupNameCode_08 { get; set; }
        /// <summary>
        // DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(9)]
        public E507 E507_09 { get; set; }
        /// <summary>
        // DIAGNOSIS CATEGORY CODE
        /// </summary>
        [DataMember]
        [DataElement("9639", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string DIAGNOSISCATEGORYCODE_10 { get; set; }
        /// <summary>
        // PERCENTAGE
        /// </summary>
        [DataMember]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(11)]
        public string PERCENTAGE_11 { get; set; }
    }
    
    /// <summary>
    // Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ADR")]
    public class ADR
    {
        
        /// <summary>
        // ADDRESS USAGE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C817 C817_01 { get; set; }
        /// <summary>
        // ADDRESS DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C090 C090_02 { get; set; }
        /// <summary>
        // City name
        /// </summary>
        [DataMember]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CityName_03 { get; set; }
        /// <summary>
        // POSTAL IDENTIFICATION CODE
        /// </summary>
        [DataMember]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string POSTALIDENTIFICATIONCODE_04 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(5)]
        public string COUNTRYIDENTIFIER_05 { get; set; }
        /// <summary>
        // COUNTRY SUBDIVISION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public List<C819> C819_06 { get; set; }
        /// <summary>
        // LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public List<C517> C517_07 { get; set; }
    }
    
    /// <summary>
    // Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ADS")]
    public class ADS
    {
        
        /// <summary>
        // ADDRESS USAGE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public E817 E817_01 { get; set; }
        /// <summary>
        // ADDRESS DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public E001 E001_02 { get; set; }
        /// <summary>
        // City name
        /// </summary>
        [DataMember]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CityName_03 { get; set; }
        /// <summary>
        // POSTAL IDENTIFICATION CODE
        /// </summary>
        [DataMember]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string POSTALIDENTIFICATIONCODE_04 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(5)]
        public string COUNTRYIDENTIFIER_05 { get; set; }
        /// <summary>
        // COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public E819 E819_06 { get; set; }
        /// <summary>
        // LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public E517 E517_07 { get; set; }
    }
    
    /// <summary>
    // Agreement identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AGR")]
    public class AGR
    {
        
        /// <summary>
        // AGREEMENT TYPE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C543 C543_01 { get; set; }
        /// <summary>
        // SERVICE LAYER CODE
        /// </summary>
        [DataMember]
        [DataElement("9419", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string SERVICELAYERCODE_02 { get; set; }
    }
    
    /// <summary>
    // Adjustment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AJT")]
    public class AJT
    {
        
        /// <summary>
        // Adjustment reason description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4465", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AdjustmentReasonDescriptionCode_01 { get; set; }
        /// <summary>
        // LINE ITEM IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string LINEITEMIDENTIFIER_02 { get; set; }
    }
    
    /// <summary>
    // Allowance or charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALC")]
    public class ALC
    {
        
        /// <summary>
        // ALLOWANCE OR CHARGE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string ALLOWANCEORCHARGECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C552 C552_02 { get; set; }
        /// <summary>
        // SETTLEMENT MEANS CODE
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string SETTLEMENTMEANSCODE_03 { get; set; }
        /// <summary>
        // CALCULATION SEQUENCE CODE
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string CALCULATIONSEQUENCECODE_04 { get; set; }
        /// <summary>
        // SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C214 C214_05 { get; set; }
    }
    
    /// <summary>
    // Additional information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALI")]
    public class ALI
    {
        
        /// <summary>
        // COUNTRY OF ORIGIN IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3239", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string COUNTRYOFORIGINIDENTIFIER_01 { get; set; }
        /// <summary>
        // DUTY REGIME TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("9213", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DUTYREGIMETYPECODE_02 { get; set; }
        /// <summary>
        // SPECIAL CONDITION CODE
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string SPECIALCONDITIONCODE_03 { get; set; }
        /// <summary>
        // SPECIAL CONDITION CODE
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string SPECIALCONDITIONCODE_04 { get; set; }
        /// <summary>
        // SPECIAL CONDITION CODE
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string SPECIALCONDITIONCODE_05 { get; set; }
        /// <summary>
        // SPECIAL CONDITION CODE
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string SPECIALCONDITIONCODE_06 { get; set; }
        /// <summary>
        // SPECIAL CONDITION CODE
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string SPECIALCONDITIONCODE_07 { get; set; }
    }
    
    /// <summary>
    // Additional location information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALS")]
    public class ALS
    {
        
        /// <summary>
        // Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string LocationFunctionCodeQualifier_01 { get; set; }
        /// <summary>
        // LOCATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(2)]
        public List<E975> E975_02 { get; set; }
        /// <summary>
        // LATITUDE DEGREE
        /// </summary>
        [DataMember]
        [DataElement("6000", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string LATITUDEDEGREE_03 { get; set; }
        /// <summary>
        // Longitude degree
        /// </summary>
        [DataMember]
        [DataElement("6002", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string LongitudeDegree_04 { get; set; }
    }
    
    /// <summary>
    // Additional transport details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("APD")]
    public class APD
    {
        
        /// <summary>
        // TRANSPORT DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public E961 E961_01 { get; set; }
        /// <summary>
        // TERMINAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public List<E962> E962_02 { get; set; }
        /// <summary>
        // DISTANCE OR TIME DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public E963 E963_03 { get; set; }
        /// <summary>
        // TRAVELLER TIME DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public E964 E964_04 { get; set; }
        /// <summary>
        // FACILITIES
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public List<E965> E965_05 { get; set; }
    }
    
    /// <summary>
    // Applicability
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("APP")]
    public class APP
    {
        
        /// <summary>
        // APPLICABILITY CODE QUALIFIER
        /// </summary>
        [DataMember]
        [DataElement("9051", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string APPLICABILITYCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // APPLICABILITY TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C973 C973_02 { get; set; }
    }
    
    /// <summary>
    // Additional price information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("APR")]
    public class APR
    {
        
        /// <summary>
        // TRADE CLASS CODE
        /// </summary>
        [DataMember]
        [DataElement("4043", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TRADECLASSCODE_01 { get; set; }
        /// <summary>
        // PRICE MULTIPLIER INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C138 C138_02 { get; set; }
        /// <summary>
        // REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C960 C960_03 { get; set; }
    }
    
    /// <summary>
    // Monetary amount function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ARD")]
    public class ARD
    {
        
        /// <summary>
        // MONETARY AMOUNT FUNCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C549 C549_01 { get; set; }
        /// <summary>
        // MONETARY AMOUNT FUNCTION DETAIL
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(2)]
        public List<C008> C008_02 { get; set; }
    }
    
    /// <summary>
    // Array information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ARR")]
    public class ARR
    {
        
        /// <summary>
        // POSITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C778 C778_01 { get; set; }
        /// <summary>
        // Array cell data description
        /// </summary>
        [DataMember]
        [DataElement("9424", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ArrayCellDataDescription_02 { get; set; }
    }
    
    /// <summary>
    // Service details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ASD")]
    public class ASD
    {
        
        /// <summary>
        // ADDITIONAL SERVICE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(1)]
        public List<E959> E959_01 { get; set; }
        /// <summary>
        // DATE AND TIME INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public List<E013> E013_02 { get; set; }
        /// <summary>
        // DAYS OF WEEK SET IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("2160", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DAYSOFWEEKSETIDENTIFIER_03 { get; set; }
    }
    
    /// <summary>
    // Array structure identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ASI")]
    public class ASI
    {
        
        /// <summary>
        // ARRAY STRUCTURE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C779 C779_01 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C082 C082_02 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string StatusDescriptionCode_03 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MAINTENANCEOPERATIONCODE_04 { get; set; }
    }
    
    /// <summary>
    // Tour information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ATI")]
    public class ATI
    {
        
        /// <summary>
        // TOUR DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public E993 E993_01 { get; set; }
        /// <summary>
        // STOPOVER INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public List<E994> E994_02 { get; set; }
    }
    
    /// <summary>
    // Attribute
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ATR")]
    public class ATR
    {
        
        /// <summary>
        // ATTRIBUTE FUNCTION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9017", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ATTRIBUTEFUNCTIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // ATTRIBUTE INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public E003 E003_02 { get; set; }
    }
    
    /// <summary>
    // Attribute
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ATT")]
    public class ATT
    {
        
        /// <summary>
        // ATTRIBUTE FUNCTION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9017", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ATTRIBUTEFUNCTIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // ATTRIBUTE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C955 C955_02 { get; set; }
        /// <summary>
        // ATTRIBUTE DETAIL
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public List<C956> C956_03 { get; set; }
    }
    
    /// <summary>
    // Authentication result
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AUT")]
    public class AUT
    {
        
        /// <summary>
        // VALIDATION RESULT TEXT
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9280", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string VALIDATIONRESULTTEXT_01 { get; set; }
        /// <summary>
        // VALIDATION KEY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("9282", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string VALIDATIONKEYIDENTIFIER_02 { get; set; }
    }
    
    /// <summary>
    // Basis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BAS")]
    public class BAS
    {
        
        /// <summary>
        // BASIS CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9045", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string BASISCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // BASIS TYPE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C974 C974_02 { get; set; }
    }
    
    /// <summary>
    // Benefit and coverage detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BCD")]
    public class BCD
    {
        
        /// <summary>
        // Service type code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5267", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ServiceTypeCode_01 { get; set; }
        /// <summary>
        // BENEFIT AND COVERAGE CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7517", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string BENEFITANDCOVERAGECODE_02 { get; set; }
        /// <summary>
        // BENEFIT COVERAGE CONSTITUENTS CODE
        /// </summary>
        [DataMember]
        [DataElement("3507", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string BENEFITCOVERAGECONSTITUENTSCODE_03 { get; set; }
        /// <summary>
        // PERIOD TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(4)]
        public string PERIODTYPECODE_04 { get; set; }
        /// <summary>
        // MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public E017 E017_05 { get; set; }
        /// <summary>
        // PERCENTAGE
        /// </summary>
        [DataMember]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(6)]
        public string PERCENTAGE_06 { get; set; }
        /// <summary>
        // QUANTITY TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(7)]
        public string QUANTITYTYPECODEQUALIFIER_07 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string QUANTITY_08 { get; set; }
        /// <summary>
        // YES OR NO INDICATOR CODE
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [DataElement("9607", typeof(EDIFACT_AN))]
        [Pos(9)]
        public List<string> YESORNOINDICATORCODE_09 { get; set; }
        /// <summary>
        // INSURANCE COVER TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("4497", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string INSURANCECOVERTYPECODE_10 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(11)]
        public string FreeText_11 { get; set; }
    }
    
    /// <summary>
    // Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM
    {
        
        /// <summary>
        // DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C002 C002_01 { get; set; }
        /// <summary>
        // DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C106 C106_02 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public string MessageFunctionCode_03 { get; set; }
        /// <summary>
        // RESPONSE TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string RESPONSETYPECODE_04 { get; set; }
    }
    
    /// <summary>
    // Structure identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BII")]
    public class BII
    {
        
        /// <summary>
        // INDEXING STRUCTURE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7429", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string INDEXINGSTRUCTURECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // BILL LEVEL IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C045 C045_02 { get; set; }
        /// <summary>
        // Item identifier
        /// </summary>
        [DataMember]
        [DataElement("7140", typeof(EDIFACT_ID_7140))]
        [Pos(3)]
        public string ItemIdentifier_03 { get; set; }
    }
    
    /// <summary>
    // Billable information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BLI")]
    public class BLI
    {
        
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(1)]
        public List<string> MonetaryAmount_01 { get; set; }
        /// <summary>
        // DIAGNOSIS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public List<E029> E029_02 { get; set; }
        /// <summary>
        // DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public List<E507> E507_03 { get; set; }
        /// <summary>
        // Object identifier
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [DataElement("7402", typeof(EDIFACT_ID_7402))]
        [Pos(4)]
        public List<string> ObjectIdentifier_04 { get; set; }
        /// <summary>
        // YES OR NO INDICATOR CODE
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [DataElement("9607", typeof(EDIFACT_AN))]
        [Pos(5)]
        public List<string> YESORNOINDICATORCODE_05 { get; set; }
        /// <summary>
        // RELATED CAUSE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public List<E028> E028_06 { get; set; }
    }
    
    /// <summary>
    // Business function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BUS")]
    public class BUS
    {
        
        /// <summary>
        // BUSINESS FUNCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C521 C521_01 { get; set; }
        /// <summary>
        // GEOGRAPHIC AREA CODE
        /// </summary>
        [DataMember]
        [DataElement("3279", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string GEOGRAPHICAREACODE_02 { get; set; }
        /// <summary>
        // FINANCIAL TRANSACTION TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("4487", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string FINANCIALTRANSACTIONTYPECODE_03 { get; set; }
        /// <summary>
        // BANK OPERATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C551 C551_04 { get; set; }
        /// <summary>
        // INTRA-COMPANY PAYMENT INDICATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("4463", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string INTRACOMPANYPAYMENTINDICATORCODE_05 { get; set; }
    }
    
    /// <summary>
    // Characteristic value
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CAV")]
    public class CAV
    {
        
        /// <summary>
        // CHARACTERISTIC VALUE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C889 C889_01 { get; set; }
    }
    
    /// <summary>
    // Credit cover details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CCD")]
    public class CCD
    {
        
        /// <summary>
        // CREDIT COVER REQUEST TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("4505", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CREDITCOVERREQUESTTYPECODE_01 { get; set; }
        /// <summary>
        // CREDIT COVER RESPONSE TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("4507", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string CREDITCOVERRESPONSETYPECODE_02 { get; set; }
        /// <summary>
        // CREDIT COVER RESPONSE REASON CODE
        /// </summary>
        [DataMember]
        [DataElement("4509", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CREDITCOVERRESPONSEREASONCODE_03 { get; set; }
    }
    
    /// <summary>
    // Characteristic/class id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CCI")]
    public class CCI
    {
        
        /// <summary>
        // CLASS TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("7059", typeof(EDIFACT_ID_7059))]
        [Pos(1)]
        public string CLASSTYPECODE_01 { get; set; }
        /// <summary>
        // MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C502 C502_02 { get; set; }
        /// <summary>
        // CHARACTERISTIC DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C240 C240_03 { get; set; }
        /// <summary>
        // CHARACTERISTIC RELEVANCE CODE
        /// </summary>
        [DataMember]
        [DataElement("4051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string CHARACTERISTICRELEVANCECODE_04 { get; set; }
    }
    
    /// <summary>
    // Physical or logical state
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CDI")]
    public class CDI
    {
        
        /// <summary>
        // PHYSICAL OR LOGICAL STATE TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7001", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PHYSICALORLOGICALSTATETYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // PHYSICAL OR LOGICAL STATE INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C564 C564_02 { get; set; }
    }
    
    /// <summary>
    // Code set identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CDS")]
    public class CDS
    {
        
        /// <summary>
        // CODE SET IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C702 C702_01 { get; set; }
        /// <summary>
        // DESIGNATED CLASS CODE
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DESIGNATEDCLASSCODE_02 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string MAINTENANCEOPERATIONCODE_03 { get; set; }
    }
    
    /// <summary>
    // Code value definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CDV")]
    public class CDV
    {
        
        /// <summary>
        // CODE VALUE TEXT
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9426", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CODEVALUETEXT_01 { get; set; }
        /// <summary>
        // CODE NAME
        /// </summary>
        [DataMember]
        [DataElement("9434", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string CODENAME_02 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string MAINTENANCEOPERATIONCODE_03 { get; set; }
        /// <summary>
        // CODE VALUE SOURCE CODE
        /// </summary>
        [DataMember]
        [DataElement("9453", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string CODEVALUESOURCECODE_04 { get; set; }
        /// <summary>
        // Requirement designator code
        /// </summary>
        [DataMember]
        [DataElement("7299", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string RequirementDesignatorCode_05 { get; set; }
    }
    
    /// <summary>
    // Computer environment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CED")]
    public class CED
    {
        
        /// <summary>
        // COMPUTER ENVIRONMENT DETAILS CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1501", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string COMPUTERENVIRONMENTDETAILSCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // COMPUTER ENVIRONMENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C079 C079_02 { get; set; }
        /// <summary>
        // FILE GENERATION COMMAND NAME
        /// </summary>
        [DataMember]
        [DataElement("9448", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string FILEGENERATIONCOMMANDNAME_03 { get; set; }
    }
    
    /// <summary>
    // Clinical information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CIN")]
    public class CIN
    {
        
        /// <summary>
        // CLINICAL INFORMATION TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6415", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CLINICALINFORMATIONTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // CLINICAL INFORMATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C836 C836_02 { get; set; }
        /// <summary>
        // CERTAINTY DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C837 C837_03 { get; set; }
    }
    
    /// <summary>
    // Clause identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CLA")]
    public class CLA
    {
        
        /// <summary>
        // CLAUSE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4059", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CLAUSECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // CLAUSE NAME
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C970 C970_02 { get; set; }
    }
    
    /// <summary>
    // Clinical intervention
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CLI")]
    public class CLI
    {
        
        /// <summary>
        // CLINICAL INTERVENTION TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9441", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CLINICALINTERVENTIONTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // CLINICAL INTERVENTION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C828 C828_02 { get; set; }
    }
    
    /// <summary>
    // Clear terminate information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CLT")]
    public class CLT
    {
        
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(1)]
        public string ACTIONCODE_01 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(2)]
        public List<string> MessageFunctionCode_02 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string FreeText_03 { get; set; }
    }
    
    /// <summary>
    // Commission information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CMN")]
    public class CMN
    {
        
        /// <summary>
        // COMMISSION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(1)]
        public List<E002> E002_01 { get; set; }
    }
    
    /// <summary>
    // Composite data element identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CMP")]
    public class CMP
    {
        
        /// <summary>
        // COMPOSITE DATA ELEMENT TAG IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9146", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string COMPOSITEDATAELEMENTTAGIDENTIFIER_01 { get; set; }
        /// <summary>
        // DESIGNATED CLASS CODE
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DESIGNATEDCLASSCODE_02 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string MAINTENANCEOPERATIONCODE_03 { get; set; }
    }
    
    /// <summary>
    // Consignment information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNI")]
    public class CNI
    {
        
        /// <summary>
        // CONSOLIDATION ITEM NUMBER
        /// </summary>
        [DataMember]
        [DataElement("1490", typeof(EDIFACT_N))]
        [Pos(1)]
        public string CONSOLIDATIONITEMNUMBER_01 { get; set; }
        /// <summary>
        // DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C503 C503_02 { get; set; }
        /// <summary>
        // CONSIGNMENT LOAD SEQUENCE IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("1312", typeof(EDIFACT_N))]
        [Pos(3)]
        public string CONSIGNMENTLOADSEQUENCEIDENTIFIER_03 { get; set; }
    }
    
    /// <summary>
    // Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT
    {
        
        /// <summary>
        // CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C270 C270_01 { get; set; }
    }
    
    /// <summary>
    // Connection details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNX")]
    public class CNX
    {
        
        /// <summary>
        // CONNECTION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(1)]
        public List<E999> E999_01 { get; set; }
    }
    
    /// <summary>
    // Country information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNY")]
    public class CNY
    {
        
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(1)]
        public string COUNTRYIDENTIFIER_01 { get; set; }
        /// <summary>
        // DATE AND TIME INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public List<E013> E013_02 { get; set; }
        /// <summary>
        // TIME VARIATION QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [DataElement("2031", typeof(EDIFACT_N))]
        [Pos(3)]
        public List<string> TIMEVARIATIONQUANTITY_03 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(4)]
        public string CurrencyIdentificationCode_04 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public List<string> LANGUAGENAMECODE_05 { get; set; }
    }
    
    /// <summary>
    // Component details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COD")]
    public class COD
    {
        
        /// <summary>
        // TYPE OF UNIT/COMPONENT
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C823 C823_01 { get; set; }
        /// <summary>
        // COMPONENT MATERIAL
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C824 C824_02 { get; set; }
    }
    
    /// <summary>
    // Communication contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COM")]
    public class COM
    {
        
        /// <summary>
        // COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(1)]
        public List<C076> C076_01 { get; set; }
    }
    
    /// <summary>
    // Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CON")]
    public class CON
    {
        
        /// <summary>
        // CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(1)]
        public List<E966> E966_01 { get; set; }
    }
    
    /// <summary>
    // Contribution details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COT")]
    public class COT
    {
        
        /// <summary>
        // CONTRIBUTION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5047", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CONTRIBUTIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // CONTRIBUTION TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C953 C953_02 { get; set; }
        /// <summary>
        // INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C522 C522_03 { get; set; }
        /// <summary>
        // RATE/TARIFF CLASS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C203 C203_04 { get; set; }
        /// <summary>
        // REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C960 C960_05 { get; set; }
    }
    
    /// <summary>
    // Charge payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CPI")]
    public class CPI
    {
        
        /// <summary>
        // CHARGE CATEGORY
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C229 C229_01 { get; set; }
        /// <summary>
        // METHOD OF PAYMENT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C231 C231_02 { get; set; }
        /// <summary>
        // Payment arrangement code
        /// </summary>
        [DataMember]
        [DataElement("4237", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string PaymentArrangementCode_03 { get; set; }
    }
    
    /// <summary>
    // Consignment packing sequence
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CPS")]
    public class CPS
    {
        
        /// <summary>
        // HIERARCHICAL STRUCTURE LEVEL IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string HIERARCHICALSTRUCTURELEVELIDENTIFIER_01 { get; set; }
        /// <summary>
        // HIERARCHICAL STRUCTURE PARENT IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("7166", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string HIERARCHICALSTRUCTUREPARENTIDENTIFIER_02 { get; set; }
        /// <summary>
        // Packaging level code
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string PackagingLevelCode_03 { get; set; }
    }
    
    /// <summary>
    // Account identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CPT")]
    public class CPT
    {
        
        /// <summary>
        // ACCOUNT TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4437", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ACCOUNTTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // ACCOUNT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C593 C593_02 { get; set; }
    }
    
    /// <summary>
    // Consumer reference information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRI")]
    public class CRI
    {
        
        /// <summary>
        // CONSUMER REFERENCE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(1)]
        public List<E967> E967_01 { get; set; }
    }
    
    /// <summary>
    // Customs status of goods
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CST")]
    public class CST
    {
        
        /// <summary>
        // GOODS ITEM NUMBER
        /// </summary>
        [DataMember]
        [DataElement("1496", typeof(EDIFACT_N))]
        [Pos(1)]
        public string GOODSITEMNUMBER_01 { get; set; }
        /// <summary>
        // CUSTOMS IDENTITY CODES
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C246 C246_02 { get; set; }
        /// <summary>
        // CUSTOMS IDENTITY CODES
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C246 C246_03 { get; set; }
        /// <summary>
        // CUSTOMS IDENTITY CODES
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C246 C246_04 { get; set; }
        /// <summary>
        // CUSTOMS IDENTITY CODES
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C246 C246_05 { get; set; }
        /// <summary>
        // CUSTOMS IDENTITY CODES
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C246 C246_06 { get; set; }
    }
    
    /// <summary>
    // Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA
    {
        
        /// <summary>
        // CONTACT FUNCTION CODE
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139))]
        [Pos(1)]
        public string CONTACTFUNCTIONCODE_01 { get; set; }
        /// <summary>
        // CONTACT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C056 C056_02 { get; set; }
    }
    
    /// <summary>
    // Currencies
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUR")]
    public class CUR
    {
        
        /// <summary>
        // CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public E504 E504_01 { get; set; }
        /// <summary>
        // CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public E504 E504_02 { get; set; }
        /// <summary>
        // CURRENCY EXCHANGE RATE
        /// </summary>
        [DataMember]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string CURRENCYEXCHANGERATE_03 { get; set; }
        /// <summary>
        // EXCHANGE RATE CURRENCY MARKET IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("6341", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string EXCHANGERATECURRENCYMARKETIDENTIFIER_04 { get; set; }
    }
    
    /// <summary>
    // Currencies
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUX")]
    public class CUX
    {
        
        /// <summary>
        // CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C504 C504_01 { get; set; }
        /// <summary>
        // CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C504 C504_02 { get; set; }
        /// <summary>
        // CURRENCY EXCHANGE RATE
        /// </summary>
        [DataMember]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string CURRENCYEXCHANGERATE_03 { get; set; }
        /// <summary>
        // EXCHANGE RATE CURRENCY MARKET IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("6341", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string EXCHANGERATECURRENCYMARKETIDENTIFIER_04 { get; set; }
    }
    
    /// <summary>
    // Damage
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DAM")]
    public class DAM
    {
        
        /// <summary>
        // DAMAGE DETAILS CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7493", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DAMAGEDETAILSCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // TYPE OF DAMAGE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C821 C821_02 { get; set; }
        /// <summary>
        // DAMAGE AREA
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C822 C822_03 { get; set; }
        /// <summary>
        // DAMAGE SEVERITY
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C825 C825_04 { get; set; }
        /// <summary>
        // ACTION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C826 C826_05 { get; set; }
    }
    
    /// <summary>
    // Daily availability
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DAV")]
    public class DAV
    {
        
        /// <summary>
        // Characteristic description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(1)]
        public string CharacteristicDescriptionCode_01 { get; set; }
        /// <summary>
        // DAILY AVAILABILITY INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(31)]
        [Pos(2)]
        public List<E009> E009_02 { get; set; }
    }
    
    /// <summary>
    // Definition function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DFN")]
    public class DFN
    {
        
        /// <summary>
        // DEFINITION FUNCTION CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9023", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DEFINITIONFUNCTIONCODE_01 { get; set; }
        /// <summary>
        // DEFINITION EXTENT CODE
        /// </summary>
        [DataMember]
        [DataElement("9025", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DEFINITIONEXTENTCODE_02 { get; set; }
        /// <summary>
        // DEFINITION IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("4519", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DEFINITIONIDENTIFIER_03 { get; set; }
    }
    
    /// <summary>
    // Dangerous goods
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DGS")]
    public class DGS
    {
        
        /// <summary>
        // DANGEROUS GOODS REGULATIONS CODE
        /// </summary>
        [DataMember]
        [DataElement("8273", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DANGEROUSGOODSREGULATIONSCODE_01 { get; set; }
        /// <summary>
        // HAZARD CODE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C205 C205_02 { get; set; }
        /// <summary>
        // UNDG INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C234 C234_03 { get; set; }
        /// <summary>
        // DANGEROUS GOODS SHIPMENT FLASHPOINT
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C223 C223_04 { get; set; }
        /// <summary>
        // PACKAGING DANGER LEVEL CODE
        /// </summary>
        [DataMember]
        [DataElement("8339", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string PACKAGINGDANGERLEVELCODE_05 { get; set; }
        /// <summary>
        // EMERGENCY PROCEDURE FOR SHIPS IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("8364", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string EMERGENCYPROCEDUREFORSHIPSIDENTIFIER_06 { get; set; }
        /// <summary>
        // HAZARD MEDICAL FIRST AID GUIDE IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("8410", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string HAZARDMEDICALFIRSTAIDGUIDEIDENTIFIER_07 { get; set; }
        /// <summary>
        // TRANSPORT EMERGENCY CARD IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("8126", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string TRANSPORTEMERGENCYCARDIDENTIFIER_08 { get; set; }
        /// <summary>
        // HAZARD IDENTIFICATION PLACARD DETAILS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public C235 C235_09 { get; set; }
        /// <summary>
        // DANGEROUS GOODS LABEL
        /// </summary>
        [DataMember]
        [Pos(10)]
        public C236 C236_10 { get; set; }
        /// <summary>
        // PACKING INSTRUCTION TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("8255", typeof(EDIFACT_AN))]
        [Pos(11)]
        public string PACKINGINSTRUCTIONTYPECODE_11 { get; set; }
        /// <summary>
        // TRANSPORT MEANS DESCRIPTION CODE
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(12)]
        public string TRANSPORTMEANSDESCRIPTIONCODE_12 { get; set; }
        /// <summary>
        // HAZARDOUS CARGO TRANSPORT AUTHORISATION CODE
        /// </summary>
        [DataMember]
        [DataElement("8211", typeof(EDIFACT_AN))]
        [Pos(13)]
        public string HAZARDOUSCARGOTRANSPORTAUTHORISATIONCODE_13 { get; set; }
    }
    
    /// <summary>
    // Directory identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DII")]
    public class DII
    {
        
        /// <summary>
        // VERSION IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string VERSIONIDENTIFIER_01 { get; set; }
        /// <summary>
        // Release identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1058", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ReleaseIdentifier_02 { get; set; }
        /// <summary>
        // DIRECTORY STATUS IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("9148", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DIRECTORYSTATUSIDENTIFIER_03 { get; set; }
        /// <summary>
        // Controlling agency identifier
        /// </summary>
        [DataMember]
        [DataElement("1476", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ControllingAgencyIdentifier_04 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string LANGUAGENAMECODE_05 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string MAINTENANCEOPERATIONCODE_06 { get; set; }
    }
    
    /// <summary>
    // Dimensions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DIM")]
    public class DIM
    {
        
        /// <summary>
        // DIMENSION TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6145", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DIMENSIONTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // DIMENSIONS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C211 C211_02 { get; set; }
    }
    
    /// <summary>
    // Discount information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DIS")]
    public class DIS
    {
        
        /// <summary>
        // DISCOUNT INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(1)]
        public List<E998> E998_01 { get; set; }
    }
    
    /// <summary>
    // Document line identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DLI")]
    public class DLI
    {
        
        /// <summary>
        // DOCUMENT LINE ACTION CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1073", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DOCUMENTLINEACTIONCODE_01 { get; set; }
        /// <summary>
        // LINE ITEM IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string LINEITEMIDENTIFIER_02 { get; set; }
    }
    
    /// <summary>
    // Delivery limitations
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DLM")]
    public class DLM
    {
        
        /// <summary>
        // BACK ORDER ARRANGEMENT TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("4455", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string BACKORDERARRANGEMENTTYPECODE_01 { get; set; }
        /// <summary>
        // INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C522 C522_02 { get; set; }
        /// <summary>
        // SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C214 C214_03 { get; set; }
        /// <summary>
        // SUBSTITUTION CONDITION CODE
        /// </summary>
        [DataMember]
        [DataElement("4457", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string SUBSTITUTIONCONDITIONCODE_04 { get; set; }
    }
    
    /// <summary>
    // Document/message summary
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMS")]
    public class DMS
    {
        
        /// <summary>
        // DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C106 C106_01 { get; set; }
        /// <summary>
        // DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C002 C002_02 { get; set; }
        /// <summary>
        // ITEM TOTAL QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("7240", typeof(EDIFACT_N))]
        [Pos(3)]
        public string ITEMTOTALQUANTITY_03 { get; set; }
    }
    
    /// <summary>
    // Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC
    {
        
        /// <summary>
        // DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C002 C002_01 { get; set; }
        /// <summary>
        // DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C503 C503_02 { get; set; }
        /// <summary>
        // Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CommunicationMediumTypeCode_03 { get; set; }
        /// <summary>
        // DOCUMENT COPIES REQUIRED QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string DOCUMENTCOPIESREQUIREDQUANTITY_04 { get; set; }
        /// <summary>
        // DOCUMENT ORIGINALS REQUIRED QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string DOCUMENTORIGINALSREQUIREDQUANTITY_05 { get; set; }
    }
    
    /// <summary>
    // Data representation details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DRD")]
    public class DRD
    {
        
        /// <summary>
        // STRUCTURE COMPONENT IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("7512", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string STRUCTURECOMPONENTIDENTIFIER_01 { get; set; }
        /// <summary>
        // STRUCTURE TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("7515", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string STRUCTURETYPECODE_02 { get; set; }
        /// <summary>
        // DATA REPRESENTATION TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("9169", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DATAREPRESENTATIONTYPECODE_03 { get; set; }
        /// <summary>
        // Size measure
        /// </summary>
        [DataMember]
        [DataElement("6174", typeof(EDIFACT_N))]
        [Pos(4)]
        public string SizeMeasure_04 { get; set; }
    }
    
    /// <summary>
    // Dosage administration
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DSG")]
    public class DSG
    {
        
        /// <summary>
        // DOSAGE ADMINISTRATION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6085", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DOSAGEADMINISTRATIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // DOSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C838 C838_02 { get; set; }
    }
    
    /// <summary>
    // Date and time information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTI")]
    public class DTI
    {
        
        /// <summary>
        // DATE AND TIME INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(1)]
        public List<E013> E013_01 { get; set; }
        /// <summary>
        // TIME REFERENCE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public List<E014> E014_02 { get; set; }
    }
    
    /// <summary>
    // Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM
    {
        
        /// <summary>
        // DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C507 C507_01 { get; set; }
    }
    
    /// <summary>
    // Editing details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EDT")]
    public class EDT
    {
        
        /// <summary>
        // EDIT FIELD LENGTH MEASURE
        /// </summary>
        [DataMember]
        [DataElement("6178", typeof(EDIFACT_N))]
        [Pos(1)]
        public string EDITFIELDLENGTHMEASURE_01 { get; set; }
        /// <summary>
        // EDIT MASK FORMAT IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("9026", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string EDITMASKFORMATIDENTIFIER_02 { get; set; }
        /// <summary>
        // EDIT MASK REPRESENTATION CODE
        /// </summary>
        [DataMember]
        [DataElement("9031", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string EDITMASKREPRESENTATIONCODE_03 { get; set; }
        /// <summary>
        // FREE TEXT FORMAT CODE
        /// </summary>
        [DataMember]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string FREETEXTFORMATCODE_04 { get; set; }
    }
    
    /// <summary>
    // External file link identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EFI")]
    public class EFI
    {
        
        /// <summary>
        // FILE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C077 C077_01 { get; set; }
        /// <summary>
        // FILE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C099 C099_02 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(3)]
        public string SequencePositionIdentifier_03 { get; set; }
        /// <summary>
        // FILE COMPRESSION TECHNIQUE NAME
        /// </summary>
        [DataMember]
        [DataElement("9450", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string FILECOMPRESSIONTECHNIQUENAME_04 { get; set; }
    }
    
    /// <summary>
    // Simple data element details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ELM")]
    public class ELM
    {
        
        /// <summary>
        // SIMPLE DATA ELEMENT TAG IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9150", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SIMPLEDATAELEMENTTAGIDENTIFIER_01 { get; set; }
        /// <summary>
        // SIMPLE DATA ELEMENT CHARACTER REPRESENTATION CODE
        /// </summary>
        [DataMember]
        [DataElement("9153", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string SIMPLEDATAELEMENTCHARACTERREPRESENTATIONCODE_02 { get; set; }
        /// <summary>
        // LENGTH TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("9155", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string LENGTHTYPECODE_03 { get; set; }
        /// <summary>
        // SIMPLE DATA ELEMENT MAXIMUM LENGTH MEASURE
        /// </summary>
        [DataMember]
        [DataElement("9156", typeof(EDIFACT_N))]
        [Pos(4)]
        public string SIMPLEDATAELEMENTMAXIMUMLENGTHMEASURE_04 { get; set; }
        /// <summary>
        // SIMPLE DATA ELEMENT MINIMUM LENGTH MEASURE
        /// </summary>
        [DataMember]
        [DataElement("9158", typeof(EDIFACT_N))]
        [Pos(5)]
        public string SIMPLEDATAELEMENTMINIMUMLENGTHMEASURE_05 { get; set; }
        /// <summary>
        // CODE SET INDICATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("9161", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string CODESETINDICATORCODE_06 { get; set; }
        /// <summary>
        // DESIGNATED CLASS CODE
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string DESIGNATEDCLASSCODE_07 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string MAINTENANCEOPERATIONCODE_08 { get; set; }
        /// <summary>
        // SIGNIFICANT DIGITS QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(9)]
        public string SIGNIFICANTDIGITSQUANTITY_09 { get; set; }
    }
    
    /// <summary>
    // Data element usage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ELU")]
    public class ELU
    {
        
        /// <summary>
        // DATA ELEMENT TAG IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9162", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DATAELEMENTTAGIDENTIFIER_01 { get; set; }
        /// <summary>
        // Requirement designator code
        /// </summary>
        [DataMember]
        [DataElement("7299", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string RequirementDesignatorCode_02 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(3)]
        public string SequencePositionIdentifier_03 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MAINTENANCEOPERATIONCODE_04 { get; set; }
        /// <summary>
        // OCCURRENCES MAXIMUM NUMBER
        /// </summary>
        [DataMember]
        [DataElement("6176", typeof(EDIFACT_N))]
        [Pos(5)]
        public string OCCURRENCESMAXIMUMNUMBER_05 { get; set; }
        /// <summary>
        // CODE VALUE SOURCE CODE
        /// </summary>
        [DataMember]
        [DataElement("9453", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string CODEVALUESOURCECODE_06 { get; set; }
        /// <summary>
        // VALIDATION CRITERIA CODE
        /// </summary>
        [DataMember]
        [DataElement("9285", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string VALIDATIONCRITERIACODE_07 { get; set; }
        /// <summary>
        // DATA ELEMENT USAGE TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("9175", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string DATAELEMENTUSAGETYPECODE_08 { get; set; }
    }
    
    /// <summary>
    // Element value definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ELV")]
    public class ELV
    {
        
        /// <summary>
        // VALUE DEFINITION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9029", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string VALUEDEFINITIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // VALUE TEXT
        /// </summary>
        [DataMember]
        [DataElement("9422", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string VALUETEXT_02 { get; set; }
        /// <summary>
        // Requirement designator code
        /// </summary>
        [DataMember]
        [DataElement("7299", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string RequirementDesignatorCode_03 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MAINTENANCEOPERATIONCODE_04 { get; set; }
    }
    
    /// <summary>
    // Employment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EMP")]
    public class EMP
    {
        
        /// <summary>
        // EMPLOYMENT DETAILS CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9003", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EMPLOYMENTDETAILSCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // EMPLOYMENT CATEGORY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C948 C948_02 { get; set; }
        /// <summary>
        // OCCUPATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C951 C951_03 { get; set; }
        /// <summary>
        // QUALIFICATION CLASSIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C950 C950_04 { get; set; }
        /// <summary>
        // PERSON JOB TITLE
        /// </summary>
        [DataMember]
        [DataElement("3480", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string PERSONJOBTITLE_05 { get; set; }
        /// <summary>
        // QUALIFICATION APPLICATION AREA CODE
        /// </summary>
        [DataMember]
        [DataElement("9035", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string QUALIFICATIONAPPLICATIONAREACODE_06 { get; set; }
    }
    
    /// <summary>
    // Attached equipment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQA")]
    public class EQA
    {
        
        /// <summary>
        // EQUIPMENT TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8053", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EQUIPMENTTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // EQUIPMENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C237 C237_02 { get; set; }
    }
    
    /// <summary>
    // Equipment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQD")]
    public class EQD
    {
        
        /// <summary>
        // EQUIPMENT TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8053", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EQUIPMENTTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // EQUIPMENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C237 C237_02 { get; set; }
        /// <summary>
        // EQUIPMENT SIZE AND TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C224 C224_03 { get; set; }
        /// <summary>
        // EQUIPMENT SUPPLIER CODE
        /// </summary>
        [DataMember]
        [DataElement("8077", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string EQUIPMENTSUPPLIERCODE_04 { get; set; }
        /// <summary>
        // EQUIPMENT STATUS CODE
        /// </summary>
        [DataMember]
        [DataElement("8249", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string EQUIPMENTSTATUSCODE_05 { get; set; }
        /// <summary>
        // FULL OR EMPTY INDICATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("8169", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string FULLOREMPTYINDICATORCODE_06 { get; set; }
        /// <summary>
        // MARKING INSTRUCTIONS CODE
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string MARKINGINSTRUCTIONSCODE_07 { get; set; }
    }
    
    /// <summary>
    // Number of units
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQN")]
    public class EQN
    {
        
        /// <summary>
        // NUMBER OF UNIT DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C523 C523_01 { get; set; }
    }
    
    /// <summary>
    // Application error information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ERC")]
    public class ERC
    {
        
        /// <summary>
        // APPLICATION ERROR DETAIL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C901 C901_01 { get; set; }
    }
    
    /// <summary>
    // Application error information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ERI")]
    public class ERI
    {
        
        /// <summary>
        // APPLICATION ERROR DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public E901 E901_01 { get; set; }
    }
    
    /// <summary>
    // Error point details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ERP")]
    public class ERP
    {
        
        /// <summary>
        // ERROR POINT DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C701 C701_01 { get; set; }
        /// <summary>
        // ERROR SEGMENT POINT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C853 C853_02 { get; set; }
    }
    
    /// <summary>
    // Event
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EVE")]
    public class EVE
    {
        
        /// <summary>
        // EVENT DETAILS CODE QUALIFIER
        /// </summary>
        [DataMember]
        [DataElement("9635", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EVENTDETAILSCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // EVENT CATEGORY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C004 C004_02 { get; set; }
        /// <summary>
        // EVENT TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C030 C030_03 { get; set; }
        /// <summary>
        // EVENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public List<C063> C063_04 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(5)]
        public string ACTIONCODE_05 { get; set; }
    }
    
    /// <summary>
    // Financial charges allocation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FCA")]
    public class FCA
    {
        
        /// <summary>
        // SETTLEMENT MEANS CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(1)]
        public string SETTLEMENTMEANSCODE_01 { get; set; }
        /// <summary>
        // CHARGE/ALLOWANCE ACCOUNT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C878 C878_02 { get; set; }
    }
    
    /// <summary>
    // Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII
    {
        
        /// <summary>
        // Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string PartyFunctionCodeQualifier_01 { get; set; }
        /// <summary>
        // ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C078 C078_02 { get; set; }
        /// <summary>
        // INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C088 C088_03 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string COUNTRYIDENTIFIER_04 { get; set; }
    }
    
    /// <summary>
    // Footnote set
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FNS")]
    public class FNS
    {
        
        /// <summary>
        // FOOTNOTE SET IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C783 C783_01 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C082 C082_02 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string StatusDescriptionCode_03 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MAINTENANCEOPERATIONCODE_04 { get; set; }
    }
    
    /// <summary>
    // Footnote
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FNT")]
    public class FNT
    {
        
        /// <summary>
        // FOOTNOTE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C784 C784_01 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C082 C082_02 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string StatusDescriptionCode_03 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MAINTENANCEOPERATIONCODE_04 { get; set; }
    }
    
    /// <summary>
    // Formula
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FOR")]
    public class FOR
    {
        
        /// <summary>
        // FORMULA TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9501", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FORMULATYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // Object identifier
        /// </summary>
        [DataMember]
        [DataElement("7402", typeof(EDIFACT_ID_7402))]
        [Pos(2)]
        public string ObjectIdentifier_02 { get; set; }
        /// <summary>
        // FORMULA NAME
        /// </summary>
        [DataMember]
        [DataElement("9502", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string FORMULANAME_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string FreeText_04 { get; set; }
        /// <summary>
        // FORMULA COMPLEXITY
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C961 C961_05 { get; set; }
    }
    
    /// <summary>
    // Follow-up action
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FRM")]
    public class FRM
    {
        
        /// <summary>
        // Object identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7402", typeof(EDIFACT_ID_7402))]
        [Pos(1)]
        public string ObjectIdentifier_01 { get; set; }
        /// <summary>
        // Status reason description code
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(7)]
        [DataElement("9013", typeof(EDIFACT_AN))]
        [Pos(2)]
        public List<string> StatusReasonDescriptionCode_02 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string ACTIONCODE_03 { get; set; }
    }
    
    /// <summary>
    // Frequency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FRQ")]
    public class FRQ
    {
        
        /// <summary>
        // FREQUENCY
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(1)]
        public List<E520> E520_01 { get; set; }
    }
    
    /// <summary>
    // Formula sequence
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FSQ")]
    public class FSQ
    {
        
        /// <summary>
        // FORMULA SEQUENCE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9507", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FORMULASEQUENCECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // FORMULA SEQUENCE OPERAND CODE
        /// </summary>
        [DataMember]
        [DataElement("9509", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string FORMULASEQUENCEOPERANDCODE_02 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(3)]
        public string SequencePositionIdentifier_03 { get; set; }
        /// <summary>
        // FORMULA SEQUENCE NAME
        /// </summary>
        [DataMember]
        [DataElement("9510", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string FORMULASEQUENCENAME_04 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string FreeText_05 { get; set; }
    }
    
    /// <summary>
    // Frequent traveller information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTI")]
    public class FTI
    {
        
        /// <summary>
        // FREQUENT TRAVELLER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(1)]
        public List<E970> E970_01 { get; set; }
    }
    
    /// <summary>
    // Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX
    {
        
        /// <summary>
        // TEXT SUBJECT CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public string TEXTSUBJECTCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // FREE TEXT FUNCTION CODE
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string FREETEXTFUNCTIONCODE_02 { get; set; }
        /// <summary>
        // TEXT REFERENCE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C107 C107_03 { get; set; }
        /// <summary>
        // TEXT LITERAL
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C108 C108_04 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string LANGUAGENAMECODE_05 { get; set; }
        /// <summary>
        // FREE TEXT FORMAT CODE
        /// </summary>
        [DataMember]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string FREETEXTFORMATCODE_06 { get; set; }
    }
    
    /// <summary>
    // Nature of cargo
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GDS")]
    public class GDS
    {
        
        /// <summary>
        // NATURE OF CARGO
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C703 C703_01 { get; set; }
    }
    
    /// <summary>
    // Processing information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GEI")]
    public class GEI
    {
        
        /// <summary>
        // PROCESSING INFORMATION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9649", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PROCESSINGINFORMATIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // PROCESSING INDICATOR
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C012 C012_02 { get; set; }
        /// <summary>
        // Process type description code
        /// </summary>
        [DataMember]
        [DataElement("7187", typeof(EDIFACT_ID_7187))]
        [Pos(3)]
        public string ProcessTypeDescriptionCode_03 { get; set; }
    }
    
    /// <summary>
    // Goods item details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GID")]
    public class GID
    {
        
        /// <summary>
        // GOODS ITEM NUMBER
        /// </summary>
        [DataMember]
        [DataElement("1496", typeof(EDIFACT_N))]
        [Pos(1)]
        public string GOODSITEMNUMBER_01 { get; set; }
        /// <summary>
        // NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C213 C213_02 { get; set; }
        /// <summary>
        // NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C213 C213_03 { get; set; }
        /// <summary>
        // NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C213 C213_04 { get; set; }
        /// <summary>
        // NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C213 C213_05 { get; set; }
        /// <summary>
        // NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C213 C213_06 { get; set; }
    }
    
    /// <summary>
    // Goods identity number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIN")]
    public class GIN
    {
        
        /// <summary>
        // Object identification code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7405", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ObjectIdentificationCodeQualifier_01 { get; set; }
        /// <summary>
        // IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C208 C208_02 { get; set; }
        /// <summary>
        // IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C208 C208_03 { get; set; }
        /// <summary>
        // IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C208 C208_04 { get; set; }
        /// <summary>
        // IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C208 C208_05 { get; set; }
        /// <summary>
        // IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C208 C208_06 { get; set; }
    }
    
    /// <summary>
    // Related identification numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIR")]
    public class GIR
    {
        
        /// <summary>
        // SET TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7297", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SETTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C206 C206_02 { get; set; }
        /// <summary>
        // IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C206 C206_03 { get; set; }
        /// <summary>
        // IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C206 C206_04 { get; set; }
        /// <summary>
        // IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C206 C206_05 { get; set; }
        /// <summary>
        // IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C206 C206_06 { get; set; }
    }
    
    /// <summary>
    // Governmental requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GOR")]
    public class GOR
    {
        
        /// <summary>
        // TRANSPORT MOVEMENT CODE
        /// </summary>
        [DataMember]
        [DataElement("8323", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TRANSPORTMOVEMENTCODE_01 { get; set; }
        /// <summary>
        // GOVERNMENT ACTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C232 C232_02 { get; set; }
        /// <summary>
        // GOVERNMENT ACTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C232 C232_03 { get; set; }
        /// <summary>
        // GOVERNMENT ACTION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C232 C232_04 { get; set; }
        /// <summary>
        // GOVERNMENT ACTION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C232 C232_05 { get; set; }
    }
    
    /// <summary>
    // Geographical position
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GPO")]
    public class GPO
    {
        
        /// <summary>
        // GEOGRAPHICAL POSITION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6029", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string GEOGRAPHICALPOSITIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // LATITUDE DEGREE
        /// </summary>
        [DataMember]
        [DataElement("6000", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string LATITUDEDEGREE_02 { get; set; }
        /// <summary>
        // Longitude degree
        /// </summary>
        [DataMember]
        [DataElement("6002", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string LongitudeDegree_03 { get; set; }
        /// <summary>
        // ALTITUDE
        /// </summary>
        [DataMember]
        [DataElement("6096", typeof(EDIFACT_N))]
        [Pos(4)]
        public string ALTITUDE_04 { get; set; }
    }
    
    /// <summary>
    // Segment group usage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GRU")]
    public class GRU
    {
        
        /// <summary>
        // GROUP IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string GROUPIDENTIFIER_01 { get; set; }
        /// <summary>
        // Requirement designator code
        /// </summary>
        [DataMember]
        [DataElement("7299", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string RequirementDesignatorCode_02 { get; set; }
        /// <summary>
        // OCCURRENCES MAXIMUM NUMBER
        /// </summary>
        [DataMember]
        [DataElement("6176", typeof(EDIFACT_N))]
        [Pos(3)]
        public string OCCURRENCESMAXIMUMNUMBER_03 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MAINTENANCEOPERATIONCODE_04 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(5)]
        public string SequencePositionIdentifier_05 { get; set; }
    }
    
    /// <summary>
    // Handling instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HAN")]
    public class HAN
    {
        
        /// <summary>
        // HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C524 C524_01 { get; set; }
        /// <summary>
        // HAZARDOUS MATERIAL
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C218 C218_02 { get; set; }
    }
    
    /// <summary>
    // Hardware device information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HDI")]
    public class HDI
    {
        
        /// <summary>
        // Communication address identifier
        /// </summary>
        [DataMember]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CommunicationAddressIdentifier_01 { get; set; }
        /// <summary>
        // Contact identifier
        /// </summary>
        [DataMember]
        [DataElement("3413", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ContactIdentifier_02 { get; set; }
        /// <summary>
        // Computer environment name code
        /// </summary>
        [DataMember]
        [DataElement("1511", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ComputerEnvironmentNameCode_03 { get; set; }
        /// <summary>
        // ATTRIBUTE INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public List<E003> E003_04 { get; set; }
    }
    
    /// <summary>
    // Header information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HDR")]
    public class HDR
    {
        
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(1)]
        public string StatusDescriptionCode_01 { get; set; }
        /// <summary>
        // DATE AND TIME INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(2)]
        public List<E013> E013_02 { get; set; }
        /// <summary>
        // Reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1154", typeof(EDIFACT_ID_1154))]
        [Pos(3)]
        public string ReferenceIdentifier_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string FreeText_04 { get; set; }
        /// <summary>
        // Product identifier
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [DataElement("7135", typeof(EDIFACT_AN))]
        [Pos(5)]
        public List<string> ProductIdentifier_05 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string LANGUAGENAMECODE_06 { get; set; }
    }
    
    /// <summary>
    // Health diagnosis service and delivery
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HDS")]
    public class HDS
    {
        
        /// <summary>
        // DIAGNOSIS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public E029 E029_01 { get; set; }
        /// <summary>
        // SERVICE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public E021 E021_02 { get; set; }
        /// <summary>
        // DELIVERY PATTERN
        /// </summary>
        [DataMember]
        [Pos(3)]
        public E083 E083_03 { get; set; }
    }
    
    /// <summary>
    // Hierarchy information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HYN")]
    public class HYN
    {
        
        /// <summary>
        // HIERARCHY OBJECT CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7173", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string HIERARCHYOBJECTCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // HIERARCHICAL STRUCTURE RELATIONSHIP CODE
        /// </summary>
        [DataMember]
        [DataElement("7171", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string HIERARCHICALSTRUCTURERELATIONSHIPCODE_02 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string ACTIONCODE_03 { get; set; }
        /// <summary>
        // ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C212 C212_04 { get; set; }
        /// <summary>
        // HIERARCHICAL STRUCTURE PARENT IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("7166", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string HIERARCHICALSTRUCTUREPARENTIDENTIFIER_05 { get; set; }
    }
    
    /// <summary>
    // Insurance cover description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ICD")]
    public class ICD
    {
        
        /// <summary>
        // INSURANCE COVER TYPE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C330 C330_01 { get; set; }
        /// <summary>
        // INSURANCE COVER DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C331 C331_02 { get; set; }
    }
    
    /// <summary>
    // Insurance cover information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ICI")]
    public class ICI
    {
        
        /// <summary>
        // INSURANCE COVER REQUIREMENT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public E016 E016_01 { get; set; }
        /// <summary>
        // MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public List<E017> E017_02 { get; set; }
    }
    
    /// <summary>
    // Identity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IDE")]
    public class IDE
    {
        
        /// <summary>
        // OBJECT TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7495", typeof(EDIFACT_ID_7495))]
        [Pos(1)]
        public string OBJECTTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C206 C206_02 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C082 C082_03 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(4)]
        public string StatusDescriptionCode_04 { get; set; }
        /// <summary>
        // CONFIGURATION LEVEL NUMBER
        /// </summary>
        [DataMember]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string CONFIGURATIONLEVELNUMBER_05 { get; set; }
        /// <summary>
        // POSITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public List<C778> C778_06 { get; set; }
        /// <summary>
        // CHARACTERISTIC DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public C240 C240_07 { get; set; }
    }
    
    /// <summary>
    // Information detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IFD")]
    public class IFD
    {
        
        /// <summary>
        // INFORMATION DETAILS CODE QUALIFIER
        /// </summary>
        [DataMember]
        [DataElement("9633", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string INFORMATIONDETAILSCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // INFORMATION CATEGORY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C009 C009_02 { get; set; }
        /// <summary>
        // INFORMATION TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C010 C010_03 { get; set; }
        /// <summary>
        // INFORMATION DETAIL
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public List<C011> C011_04 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string StatusDescriptionCode_05 { get; set; }
    }
    
    /// <summary>
    // Interactive free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IFT")]
    public class IFT
    {
        
        /// <summary>
        // FREE TEXT QUALIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public E971 E971_01 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public List<string> FreeText_02 { get; set; }
    }
    
    /// <summary>
    // Person characteristic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IHC")]
    public class IHC
    {
        
        /// <summary>
        // PERSON CHARACTERISTIC CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PERSONCHARACTERISTICCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // PERSON INHERITED CHARACTERISTIC DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C818 C818_02 { get; set; }
    }
    
    /// <summary>
    // Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD
    {
        
        /// <summary>
        // Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string DescriptionFormatCode_01 { get; set; }
        /// <summary>
        // ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C272 C272_02 { get; set; }
        /// <summary>
        // ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C273 C273_03 { get; set; }
        /// <summary>
        // SURFACE OR LAYER CODE
        /// </summary>
        [DataMember]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string SURFACEORLAYERCODE_04 { get; set; }
    }
    
    /// <summary>
    // Index details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IND")]
    public class IND
    {
        
        /// <summary>
        // INDEX IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C545 C545_01 { get; set; }
        /// <summary>
        // INDEX VALUE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C546 C546_02 { get; set; }
    }
    
    /// <summary>
    // Parties and instruction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INP")]
    public class INP
    {
        
        /// <summary>
        // PARTIES TO INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C849 C849_01 { get; set; }
        /// <summary>
        // INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C522 C522_02 { get; set; }
        /// <summary>
        // STATUS OF INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C850 C850_03 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(4)]
        public string ACTIONCODE_04 { get; set; }
    }
    
    /// <summary>
    // Inventory management related details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INV")]
    public class INV
    {
        
        /// <summary>
        // INVENTORY MOVEMENT DIRECTION CODE
        /// </summary>
        [DataMember]
        [DataElement("4501", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string INVENTORYMOVEMENTDIRECTIONCODE_01 { get; set; }
        /// <summary>
        // INVENTORY TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("7491", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string INVENTORYTYPECODE_02 { get; set; }
        /// <summary>
        // INVENTORY MOVEMENT REASON CODE
        /// </summary>
        [DataMember]
        [DataElement("4499", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string INVENTORYMOVEMENTREASONCODE_03 { get; set; }
        /// <summary>
        // INVENTORY BALANCE METHOD CODE
        /// </summary>
        [DataMember]
        [DataElement("4503", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string INVENTORYBALANCEMETHODCODE_04 { get; set; }
        /// <summary>
        // INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C522 C522_05 { get; set; }
    }
    
    /// <summary>
    // Information required
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IRQ")]
    public class IRQ
    {
        
        /// <summary>
        // INFORMATION REQUEST
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C333 C333_01 { get; set; }
    }
    
    /// <summary>
    // Institutional claim
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ITC")]
    public class ITC
    {
        
        /// <summary>
        // INVOICE TYPE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public E027 E027_01 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public List<string> QUANTITY_02 { get; set; }
        /// <summary>
        // ADMISSION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public E026 E026_03 { get; set; }
        /// <summary>
        // Discharge type description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9447", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DischargeTypeDescriptionCode_04 { get; set; }
        /// <summary>
        // BASIS OF SERVICE INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public List<E025> E025_05 { get; set; }
    }
    
    /// <summary>
    // Information type data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ITD")]
    public class ITD
    {
        
        /// <summary>
        // INFORMATION CATEGORY CODE
        /// </summary>
        [DataMember]
        [DataElement("9601", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string INFORMATIONCATEGORYCODE_01 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string LANGUAGENAMECODE_02 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public List<string> StatusDescriptionCode_03 { get; set; }
        /// <summary>
        // Data format description code
        /// </summary>
        [DataMember]
        [DataElement("1503", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DataFormatDescriptionCode_04 { get; set; }
    }
    
    /// <summary>
    // Dental information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DNT")]
    public class DNT
    {
        
        /// <summary>
        // Object identifier
        /// </summary>
        [DataMember]
        [DataElement("7402", typeof(EDIFACT_ID_7402))]
        [Pos(1)]
        public string ObjectIdentifier_01 { get; set; }
        /// <summary>
        // SURFACE OR LAYER CODE
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(2)]
        public List<string> SURFACEORLAYERCODE_02 { get; set; }
        /// <summary>
        // CAVITY ZONE CODE
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [DataElement("9647", typeof(EDIFACT_AN))]
        [Pos(3)]
        public List<string> CAVITYZONECODE_03 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(4)]
        public List<string> QUANTITY_04 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string StatusDescriptionCode_05 { get; set; }
    }
    
    /// <summary>
    // Data set identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DSI")]
    public class DSI
    {
        
        /// <summary>
        // DATA SET IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C782 C782_01 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C082 C082_02 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string StatusDescriptionCode_03 { get; set; }
        /// <summary>
        // SEQUENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C286 C286_04 { get; set; }
        /// <summary>
        // Revision identifier
        /// </summary>
        [DataMember]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string RevisionIdentifier_05 { get; set; }
    }
    
    /// <summary>
    // Item number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ITM")]
    public class ITM
    {
        
        /// <summary>
        // ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(1)]
        public List<E212> E212_01 { get; set; }
    }
    
    /// <summary>
    // Language
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LAN")]
    public class LAN
    {
        
        /// <summary>
        // LANGUAGE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3455", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string LANGUAGECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // LANGUAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C508 C508_02 { get; set; }
    }
    
    /// <summary>
    // Line item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LIN")]
    public class LIN
    {
        
        /// <summary>
        // LINE ITEM IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string LINEITEMIDENTIFIER_01 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public string ACTIONCODE_02 { get; set; }
        /// <summary>
        // ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C212 C212_03 { get; set; }
        /// <summary>
        // SUB-LINE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C829 C829_04 { get; set; }
        /// <summary>
        // CONFIGURATION LEVEL NUMBER
        /// </summary>
        [DataMember]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string CONFIGURATIONLEVELNUMBER_05 { get; set; }
        /// <summary>
        // CONFIGURATION OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("7083", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string CONFIGURATIONOPERATIONCODE_06 { get; set; }
    }
    
    /// <summary>
    // Level indication
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LKP")]
    public class LKP
    {
        
        /// <summary>
        // POSITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public E778 E778_01 { get; set; }
    }
    
    /// <summary>
    // Language
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LNG")]
    public class LNG
    {
        
        /// <summary>
        // LANGUAGE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3455", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string LANGUAGECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // LANGUAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public E033 E033_02 { get; set; }
    }
    
    /// <summary>
    // Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC
    {
        
        /// <summary>
        // Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string LocationFunctionCodeQualifier_01 { get; set; }
        /// <summary>
        // LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C517 C517_02 { get; set; }
        /// <summary>
        // RELATED LOCATION ONE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C519 C519_03 { get; set; }
        /// <summary>
        // RELATED LOCATION TWO IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C553 C553_04 { get; set; }
        /// <summary>
        // Relation code
        /// </summary>
        [DataMember]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(5)]
        public string RelationCode_05 { get; set; }
    }
    
    /// <summary>
    // Message application product information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MAP")]
    public class MAP
    {
        
        /// <summary>
        // INSTRUCTION INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public E022 E022_01 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PartyName_02 { get; set; }
        /// <summary>
        // MESSAGE APPLICATION PRODUCT SPECIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public E031 E031_03 { get; set; }
    }
    
    /// <summary>
    // Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA
    {
        
        /// <summary>
        // MEASUREMENT PURPOSE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public string MEASUREMENTPURPOSECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C502 C502_02 { get; set; }
        /// <summary>
        // VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C174 C174_03 { get; set; }
        /// <summary>
        // SURFACE OR LAYER CODE
        /// </summary>
        [DataMember]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string SURFACEORLAYERCODE_04 { get; set; }
    }
    
    /// <summary>
    // Membership details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEM")]
    public class MEM
    {
        
        /// <summary>
        // MEMBERSHIP TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7449", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MEMBERSHIPTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // MEMBERSHIP CATEGORY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C942 C942_02 { get; set; }
        /// <summary>
        // MEMBERSHIP STATUS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C944 C944_03 { get; set; }
        /// <summary>
        // MEMBERSHIP LEVEL
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C945 C945_04 { get; set; }
        /// <summary>
        // RATE/TARIFF CLASS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C203 C203_05 { get; set; }
        /// <summary>
        // REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C960 C960_06 { get; set; }
    }
    
    /// <summary>
    // Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MES")]
    public class MES
    {
        
        /// <summary>
        // MEASUREMENT VALUE AND DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(1)]
        public List<E175> E175_01 { get; set; }
    }
    
    /// <summary>
    // Market/sales channel information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MKS")]
    public class MKS
    {
        
        /// <summary>
        // SECTOR AREA IDENTIFICATION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7293", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SECTORAREAIDENTIFICATIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // SALES CHANNEL IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C332 C332_02 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string ACTIONCODE_03 { get; set; }
    }
    
    /// <summary>
    // Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA
    {
        
        /// <summary>
        // MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C516 C516_01 { get; set; }
    }
    
    /// <summary>
    // Car delivery instruction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOV")]
    public class MOV
    {
        
        /// <summary>
        // MOVEMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public E995 E995_01 { get; set; }
        /// <summary>
        // Units quantity
        /// </summary>
        [DataMember]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(2)]
        public string UnitsQuantity_02 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string LANGUAGENAMECODE_03 { get; set; }
    }
    
    /// <summary>
    // Message action details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MSD")]
    public class MSD
    {
        
        /// <summary>
        // MESSAGE PROCESSING DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public E972 E972_01 { get; set; }
        /// <summary>
        // RESPONSE TYPE CODE
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(2)]
        public List<string> RESPONSETYPECODE_02 { get; set; }
        /// <summary>
        // OBJECT IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public List<E206> E206_03 { get; set; }
    }
    
    /// <summary>
    // Message type identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MSG")]
    public class MSG
    {
        
        /// <summary>
        // MESSAGE IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C709 C709_01 { get; set; }
        /// <summary>
        // DESIGNATED CLASS CODE
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DESIGNATEDCLASSCODE_02 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string MAINTENANCEOPERATIONCODE_03 { get; set; }
        /// <summary>
        // RELATIONSHIP
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C941 C941_04 { get; set; }
    }
    
    /// <summary>
    // Maintenance operation details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MTD")]
    public class MTD
    {
        
        /// <summary>
        // OBJECT TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7495", typeof(EDIFACT_ID_7495))]
        [Pos(1)]
        public string OBJECTTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MAINTENANCEOPERATIONCODE_02 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION OPERATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("3005", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string MAINTENANCEOPERATIONOPERATORCODE_03 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION PAYER CODE
        /// </summary>
        [DataMember]
        [DataElement("3009", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MAINTENANCEOPERATIONPAYERCODE_04 { get; set; }
    }
    
    /// <summary>
    // Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAA")]
    public class NAA
    {
        
        /// <summary>
        // Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string PartyFunctionCodeQualifier_01 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public E082 E082_02 { get; set; }
        /// <summary>
        // Name and address description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public List<string> NameAndAddressDescription_03 { get; set; }
        /// <summary>
        // PARTY NAME
        /// </summary>
        [DataMember]
        [Pos(4)]
        public E080 E080_04 { get; set; }
        /// <summary>
        // Street and number or post office box identifier
        /// </summary>
        [DataMember]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string StreetAndNumberOrPostOfficeBoxIdentifier_05 { get; set; }
        /// <summary>
        // City name
        /// </summary>
        [DataMember]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string CityName_06 { get; set; }
        /// <summary>
        // Country subdivision identifier
        /// </summary>
        [DataMember]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string CountrySubdivisionIdentifier_07 { get; set; }
        /// <summary>
        // POSTAL IDENTIFICATION CODE
        /// </summary>
        [DataMember]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string POSTALIDENTIFICATIONCODE_08 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string COUNTRYIDENTIFIER_09 { get; set; }
    }
    
    /// <summary>
    // Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD
    {
        
        /// <summary>
        // Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string PartyFunctionCodeQualifier_01 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C082 C082_02 { get; set; }
        /// <summary>
        // NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C058 C058_03 { get; set; }
        /// <summary>
        // PARTY NAME
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C080 C080_04 { get; set; }
        /// <summary>
        // STREET
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C059 C059_05 { get; set; }
        /// <summary>
        // City name
        /// </summary>
        [DataMember]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string CityName_06 { get; set; }
        /// <summary>
        // COUNTRY SUBDIVISION DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public C819 C819_07 { get; set; }
        /// <summary>
        // POSTAL IDENTIFICATION CODE
        /// </summary>
        [DataMember]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string POSTALIDENTIFICATIONCODE_08 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string COUNTRYIDENTIFIER_09 { get; set; }
    }
    
    /// <summary>
    // Nationality
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAT")]
    public class NAT
    {
        
        /// <summary>
        // NATIONALITY CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3493", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string NATIONALITYCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // NATIONALITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C042 C042_02 { get; set; }
    }
    
    /// <summary>
    // Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NME")]
    public class NME
    {
        
        /// <summary>
        // NAME INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(1)]
        public List<E012> E012_01 { get; set; }
    }
    
    /// <summary>
    // Number of units
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NUN")]
    public class NUN
    {
        
        /// <summary>
        // NUMBER OF UNIT DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(1)]
        public List<E523> E523_01 { get; set; }
    }
    
    /// <summary>
    // Origin and destination details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ODI")]
    public class ODI
    {
        
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(1)]
        public List<string> LocationIdentifier_01 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(2)]
        public List<string> SequencePositionIdentifier_02 { get; set; }
    }
    
    /// <summary>
    // Additional product details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ODS")]
    public class ODS
    {
        
        /// <summary>
        // DATA CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9605", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DATACODEQUALIFIER_01 { get; set; }
        /// <summary>
        // PRODUCT DATA INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(2)]
        public List<E015> E015_02 { get; set; }
    }
    
    /// <summary>
    // Originator of request details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ORG")]
    public class ORG
    {
        
        /// <summary>
        // DELIVERING SYSTEM DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public E973 E973_01 { get; set; }
        /// <summary>
        // ORIGINATOR IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public E974 E974_02 { get; set; }
        /// <summary>
        // LOCATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public E975 E975_03 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PartyName_04 { get; set; }
        /// <summary>
        // ORIGINATOR TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("3457", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string ORIGINATORTYPECODE_05 { get; set; }
        /// <summary>
        // ORIGINATOR DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public E976 E976_06 { get; set; }
        /// <summary>
        // ACCESS AUTHORISATION IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3503", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string ACCESSAUTHORISATIONIDENTIFIER_07 { get; set; }
    }
    
    /// <summary>
    // Other insurance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OTI")]
    public class OTI
    {
        
        /// <summary>
        // OBJECT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(1)]
        public List<E206> E206_01 { get; set; }
        /// <summary>
        // PAYER RESPONSIBILITY LEVEL CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9645", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PAYERRESPONSIBILITYLEVELCODE_02 { get; set; }
        /// <summary>
        // DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public List<E507> E507_03 { get; set; }
        /// <summary>
        // Service type code
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [DataElement("5267", typeof(EDIFACT_AN))]
        [Pos(4)]
        public List<string> ServiceTypeCode_04 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(5)]
        public List<string> MonetaryAmount_05 { get; set; }
        /// <summary>
        // ADJUSTMENT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(6)]
        public List<E030> E030_06 { get; set; }
        /// <summary>
        // INSURANCE COVER TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("4497", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string INSURANCECOVERTYPECODE_07 { get; set; }
        /// <summary>
        // Relationship description code
        /// </summary>
        [DataMember]
        [DataElement("9143", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string RelationshipDescriptionCode_08 { get; set; }
        /// <summary>
        // YES OR NO INDICATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("9607", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string YESORNOINDICATORCODE_09 { get; set; }
    }
    
    /// <summary>
    // Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC
    {
        
        /// <summary>
        // PACKAGE QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string PACKAGEQUANTITY_01 { get; set; }
        /// <summary>
        // PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C531 C531_02 { get; set; }
        /// <summary>
        // PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C202 C202_03 { get; set; }
        /// <summary>
        // PACKAGE TYPE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C402 C402_04 { get; set; }
        /// <summary>
        // RETURNABLE PACKAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C532 C532_05 { get; set; }
    }
    
    /// <summary>
    // Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI
    {
        
        /// <summary>
        // PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C534 C534_01 { get; set; }
    }
    
    /// <summary>
    // Attendance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAS")]
    public class PAS
    {
        
        /// <summary>
        // ATTENDANCE TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9443", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ATTENDANCETYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // ATTENDEE CATEGORY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C839 C839_02 { get; set; }
        /// <summary>
        // ATTENDANCE ADMISSION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C840 C840_03 { get; set; }
        /// <summary>
        // ATTENDANCE DISCHARGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C841 C841_04 { get; set; }
    }
    
    /// <summary>
    // Premium calculation component details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCC")]
    public class PCC
    {
        
        /// <summary>
        // PREMIUM CALCULATION COMPONENT
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C820 C820_01 { get; set; }
        /// <summary>
        // PREMIUM CALCULATION COMPONENT VALUE CATEGORY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("4522", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PREMIUMCALCULATIONCOMPONENTVALUECATEGORYIDENTIFIER_02 { get; set; }
    }
    
    /// <summary>
    // Percentage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCD")]
    public class PCD
    {
        
        /// <summary>
        // PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C501 C501_01 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string StatusDescriptionCode_02 { get; set; }
    }
    
    /// <summary>
    // Package identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCI")]
    public class PCI
    {
        
        /// <summary>
        // MARKING INSTRUCTIONS CODE
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MARKINGINSTRUCTIONSCODE_01 { get; set; }
        /// <summary>
        // MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C210 C210_02 { get; set; }
        /// <summary>
        // FULL OR EMPTY INDICATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("8169", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string FULLOREMPTYINDICATORCODE_03 { get; set; }
        /// <summary>
        // TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C827 C827_04 { get; set; }
    }
    
    /// <summary>
    // Person demographic information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PDI")]
    public class PDI
    {
        
        /// <summary>
        // Gender code
        /// </summary>
        [DataMember]
        [DataElement("3499", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string GenderCode_01 { get; set; }
        /// <summary>
        // MARITAL STATUS DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C085 C085_02 { get; set; }
        /// <summary>
        // RELIGION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C101 C101_03 { get; set; }
    }
    
    /// <summary>
    // Product information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PDT")]
    public class PDT
    {
        
        /// <summary>
        // Product details type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7133", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ProductDetailsTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // PRODUCT CLASS DETAILS
        /// </summary>
        [DataMember]
        [ListCount(26)]
        [Pos(2)]
        public List<E996> E996_02 { get; set; }
    }
    
    /// <summary>
    // Period related details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER")]
    public class PER
    {
        
        /// <summary>
        // PERIOD TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [DataElement("2023", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PERIODTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // PERIOD DETAIL
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C977 C977_02 { get; set; }
    }
    
    /// <summary>
    // Product group information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PGI")]
    public class PGI
    {
        
        /// <summary>
        // PRODUCT GROUP TYPE CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5379", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PRODUCTGROUPTYPECODE_01 { get; set; }
        /// <summary>
        // PRODUCT GROUP
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C288 C288_02 { get; set; }
    }
    
    /// <summary>
    // Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA
    {
        
        /// <summary>
        // PRODUCT IDENTIFIER CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347))]
        [Pos(1)]
        public string PRODUCTIDENTIFIERCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public C212 C212_02 { get; set; }
        /// <summary>
        // ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C212 C212_03 { get; set; }
        /// <summary>
        // ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C212 C212_04 { get; set; }
        /// <summary>
        // ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C212 C212_05 { get; set; }
        /// <summary>
        // ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C212 C212_06 { get; set; }
    }
    
    /// <summary>
    // Product location information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PLI")]
    public class PLI
    {
        
        /// <summary>
        // GEOGRAPHIC DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(1)]
        public List<E008> E008_01 { get; set; }
    }
    
    /// <summary>
    // Payment information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PMT")]
    public class PMT
    {
        
        /// <summary>
        // PAYMENT DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(1)]
        public List<E977> E977_01 { get; set; }
        /// <summary>
        // CREDIT CARD INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public List<E978> E978_02 { get; set; }
    }
    
    /// <summary>
    // Party identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PNA")]
    public class PNA
    {
        
        /// <summary>
        // Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string PartyFunctionCodeQualifier_01 { get; set; }
        /// <summary>
        // IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C206 C206_02 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C082 C082_03 { get; set; }
        /// <summary>
        // NAME TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("3403", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string NAMETYPECODE_04 { get; set; }
        /// <summary>
        // Name status code
        /// </summary>
        [DataMember]
        [DataElement("3397", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string NameStatusCode_05 { get; set; }
        /// <summary>
        // NAME COMPONENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C816 C816_06 { get; set; }
        /// <summary>
        // NAME COMPONENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public C816 C816_07 { get; set; }
        /// <summary>
        // NAME COMPONENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public C816 C816_08 { get; set; }
        /// <summary>
        // NAME COMPONENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public C816 C816_09 { get; set; }
        /// <summary>
        // NAME COMPONENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(10)]
        public C816 C816_10 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(11)]
        public string ACTIONCODE_11 { get; set; }
    }
    
    /// <summary>
    // Purpose of conveyance call
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("POC")]
    public class POC
    {
        
        /// <summary>
        // PURPOSE OF CONVEYANCE CALL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C525 C525_01 { get; set; }
    }
    
    /// <summary>
    // Period of operation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("POP")]
    public class POP
    {
        
        /// <summary>
        // DATE AND TIME INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public E013 E013_01 { get; set; }
        /// <summary>
        // DAYS OF WEEK SET IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("2160", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DAYSOFWEEKSETIDENTIFIER_02 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string StatusDescriptionCode_03 { get; set; }
    }
    
    /// <summary>
    // Location and/or related time information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("POR")]
    public class POR
    {
        
        /// <summary>
        // LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public E517 E517_01 { get; set; }
        /// <summary>
        // RELATED TIME INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public List<E362> E362_02 { get; set; }
        /// <summary>
        // POSITION
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public List<E992> E992_03 { get; set; }
        /// <summary>
        // Location function code qualifier
        /// </summary>
        [DataMember]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(4)]
        public string LocationFunctionCodeQualifier_04 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(5)]
        public string SequencePositionIdentifier_05 { get; set; }
    }
    
    /// <summary>
    // Point of sale information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("POS")]
    public class POS
    {
        
        /// <summary>
        // PARTY IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(1)]
        public List<E032> E032_01 { get; set; }
        /// <summary>
        // LOCATION
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(2)]
        public List<E975> E975_02 { get; set; }
    }
    
    /// <summary>
    // Process identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRC")]
    public class PRC
    {
        
        /// <summary>
        // PROCESS TYPE AND DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C242 C242_01 { get; set; }
        /// <summary>
        // PROCESS IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C830 C830_02 { get; set; }
    }
    
    /// <summary>
    // Product identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRD")]
    public class PRD
    {
        
        /// <summary>
        // PRODUCT IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(1)]
        public List<E989> E989_01 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public List<string> PartyName_02 { get; set; }
    }
    
    /// <summary>
    // Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRE")]
    public class PRE
    {
        
        /// <summary>
        // PRICE INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(1)]
        public List<E018> E018_01 { get; set; }
        /// <summary>
        // SUB-LINE ITEM PRICE CHANGE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string SUBLINEITEMPRICECHANGEOPERATIONCODE_02 { get; set; }
    }
    
    /// <summary>
    // Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI
    {
        
        /// <summary>
        // PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C509 C509_01 { get; set; }
        /// <summary>
        // SUB-LINE ITEM PRICE CHANGE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string SUBLINEITEMPRICECHANGEOPERATIONCODE_02 { get; set; }
    }
    
    /// <summary>
    // Promotions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRO")]
    public class PRO
    {
        
        /// <summary>
        // PROMOTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(1)]
        public List<E019> E019_01 { get; set; }
    }
    
    /// <summary>
    // Party information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRT")]
    public class PRT
    {
        
        /// <summary>
        // Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string PartyFunctionCodeQualifier_01 { get; set; }
        /// <summary>
        // OBJECT IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public List<E206> E206_02 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(3)]
        public List<string> Date_03 { get; set; }
        /// <summary>
        // PARTY DEMOGRAPHIC INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public E023 E023_04 { get; set; }
    }
    
    /// <summary>
    // Proviso details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRV")]
    public class PRV
    {
        
        /// <summary>
        // PROVISO CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4071", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PROVISOCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // PROVISO TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C971 C971_02 { get; set; }
        /// <summary>
        // PROVISO CALCULATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C972 C972_03 { get; set; }
    }
    
    /// <summary>
    // Physical sample description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PSD")]
    public class PSD
    {
        
        /// <summary>
        // SAMPLE PROCESS STEP CODE
        /// </summary>
        [DataMember]
        [DataElement("4407", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SAMPLEPROCESSSTEPCODE_01 { get; set; }
        /// <summary>
        // SAMPLE SELECTION METHOD CODE
        /// </summary>
        [DataMember]
        [DataElement("7039", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string SAMPLESELECTIONMETHODCODE_02 { get; set; }
        /// <summary>
        // FREQUENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C526 C526_03 { get; set; }
        /// <summary>
        // SAMPLE STATE CODE
        /// </summary>
        [DataMember]
        [DataElement("7045", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string SAMPLESTATECODE_04 { get; set; }
        /// <summary>
        // SAMPLE DIRECTION CODE
        /// </summary>
        [DataMember]
        [DataElement("7047", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string SAMPLEDIRECTIONCODE_05 { get; set; }
        /// <summary>
        // SAMPLE LOCATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C514 C514_06 { get; set; }
        /// <summary>
        // SAMPLE LOCATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public C514 C514_07 { get; set; }
        /// <summary>
        // SAMPLE LOCATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public C514 C514_08 { get; set; }
    }
    
    /// <summary>
    // Service information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PSI")]
    public class PSI
    {
        
        /// <summary>
        // Object identifier
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [DataElement("7402", typeof(EDIFACT_ID_7402))]
        [Pos(1)]
        public List<string> ObjectIdentifier_01 { get; set; }
        /// <summary>
        // DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public List<E507> E507_02 { get; set; }
        /// <summary>
        // SERVICE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public E021 E021_03 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(4)]
        public List<string> QUANTITY_04 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(5)]
        public List<string> MonetaryAmount_05 { get; set; }
        /// <summary>
        // Index text
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [DataElement("5030", typeof(EDIFACT_AN))]
        [Pos(6)]
        public List<string> IndexText_06 { get; set; }
        /// <summary>
        // Facility type description code
        /// </summary>
        [DataMember]
        [DataElement("9039", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string FacilityTypeDescriptionCode_07 { get; set; }
        /// <summary>
        // Service type code
        /// </summary>
        [DataMember]
        [DataElement("5267", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string ServiceTypeCode_08 { get; set; }
        /// <summary>
        // SPECIAL CONDITION CODE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [DataElement("4183", typeof(EDIFACT_AN))]
        [Pos(9)]
        public List<string> SPECIALCONDITIONCODE_09 { get; set; }
        /// <summary>
        // SUPPORTING EVIDENCE
        /// </summary>
        [DataMember]
        [Pos(10)]
        public E024 E024_10 { get; set; }
    }
    
    /// <summary>
    // Priority
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PTY")]
    public class PTY
    {
        
        /// <summary>
        // PRIORITY TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4035", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PRIORITYTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // PRIORITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C585 C585_02 { get; set; }
    }
    
    /// <summary>
    // Payment terms
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PYT")]
    public class PYT
    {
        
        /// <summary>
        // PAYMENT TERMS TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279))]
        [Pos(1)]
        public string PAYMENTTERMSTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // PAYMENT TERMS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C019 C019_02 { get; set; }
        /// <summary>
        // EVENT TIME REFERENCE CODE
        /// </summary>
        [DataMember]
        [DataElement("2475", typeof(EDIFACT_ID_2475))]
        [Pos(3)]
        public string EVENTTIMEREFERENCECODE_03 { get; set; }
        /// <summary>
        // TERMS TIME RELATION CODE
        /// </summary>
        [DataMember]
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(4)]
        public string TERMSTIMERELATIONCODE_04 { get; set; }
        /// <summary>
        // PERIOD TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(5)]
        public string PERIODTYPECODE_05 { get; set; }
        /// <summary>
        // PERIOD COUNT QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(6)]
        public string PERIODCOUNTQUANTITY_06 { get; set; }
    }
    
    /// <summary>
    // Query and response
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QRS")]
    public class QRS
    {
        
        /// <summary>
        // SECTOR AREA IDENTIFICATION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7293", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SECTORAREAIDENTIFICATIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // QUESTION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C811 C811_02 { get; set; }
        /// <summary>
        // RESPONSE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C812 C812_03 { get; set; }
    }
    
    /// <summary>
    // Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTI")]
    public class QTI
    {
        
        /// <summary>
        // QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(1)]
        public List<E035> E035_01 { get; set; }
    }
    
    /// <summary>
    // Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY
    {
        
        /// <summary>
        // QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C186 C186_01 { get; set; }
    }
    
    /// <summary>
    // Qualification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QUA")]
    public class QUA
    {
        
        /// <summary>
        // QUALIFICATION TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9037", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string QUALIFICATIONTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // QUALIFICATION CLASSIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C950 C950_02 { get; set; }
    }
    
    /// <summary>
    // Quantity variances
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QVR")]
    public class QVR
    {
        
        /// <summary>
        // QUANTITY DIFFERENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C279 C279_01 { get; set; }
        /// <summary>
        // DISCREPANCY NATURE IDENTIFICATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4221", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DISCREPANCYNATUREIDENTIFICATIONCODE_02 { get; set; }
        /// <summary>
        // REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C960 C960_03 { get; set; }
    }
    
    /// <summary>
    // Reservation control information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RCI")]
    public class RCI
    {
        
        /// <summary>
        // RESERVATION CONTROL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(1)]
        public List<E979> E979_01 { get; set; }
    }
    
    /// <summary>
    // Requirements and conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RCS")]
    public class RCS
    {
        
        /// <summary>
        // SECTOR AREA IDENTIFICATION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7293", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SECTORAREAIDENTIFICATIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // REQUIREMENT/CONDITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C550 C550_02 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string ACTIONCODE_03 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string COUNTRYIDENTIFIER_04 { get; set; }
    }
    
    /// <summary>
    // Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REL")]
    public class REL
    {
        
        /// <summary>
        // RELATIONSHIP TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9141", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RELATIONSHIPTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // RELATIONSHIP
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C941 C941_02 { get; set; }
    }
    
    /// <summary>
    // Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF
    {
        
        /// <summary>
        // REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C506 C506_01 { get; set; }
    }
    
    /// <summary>
    // Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFR")]
    public class RFR
    {
        
        /// <summary>
        // REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public E506 E506_01 { get; set; }
    }
    
    /// <summary>
    // Accounting journal identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RJL")]
    public class RJL
    {
        
        /// <summary>
        // ACCOUNTING JOURNAL IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C595 C595_01 { get; set; }
        /// <summary>
        // ACCOUNTING ENTRY TYPE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C596 C596_02 { get; set; }
    }
    
    /// <summary>
    // Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RLS")]
    public class RLS
    {
        
        /// <summary>
        // RELATIONSHIP TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9141", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RELATIONSHIPTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // RELATIONSHIP
        /// </summary>
        [DataMember]
        [Pos(2)]
        public E941 E941_02 { get; set; }
    }
    
    /// <summary>
    // Range details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RNG")]
    public class RNG
    {
        
        /// <summary>
        // RANGE TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6167", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RANGETYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // RANGE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C280 C280_02 { get; set; }
    }
    
    /// <summary>
    // Risk object type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ROD")]
    public class ROD
    {
        
        /// <summary>
        // RISK OBJECT TYPE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C851 C851_01 { get; set; }
        /// <summary>
        // RISK OBJECT SUB-TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C852 C852_02 { get; set; }
    }
    
    /// <summary>
    // Quantity and action details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RPI")]
    public class RPI
    {
        
        /// <summary>
        // QUANTITY AND ACTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(1)]
        public List<E958> E958_01 { get; set; }
    }
    
    /// <summary>
    // Result
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RSL")]
    public class RSL
    {
        
        /// <summary>
        // RESULT VALUE TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6087", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RESULTVALUETYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // RESULT REPRESENTATION CODE
        /// </summary>
        [DataMember]
        [DataElement("6077", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string RESULTREPRESENTATIONCODE_02 { get; set; }
        /// <summary>
        // RESULT DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C831 C831_03 { get; set; }
        /// <summary>
        // RESULT DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C831 C831_04 { get; set; }
        /// <summary>
        // MEASUREMENT UNIT DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C848 C848_05 { get; set; }
        /// <summary>
        // RESULT NORMALCY CODE
        /// </summary>
        [DataMember]
        [DataElement("6079", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string RESULTNORMALCYCODE_06 { get; set; }
    }
    
    /// <summary>
    // Rate types
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RTC")]
    public class RTC
    {
        
        /// <summary>
        // Rate type identifier
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [DataElement("5263", typeof(EDIFACT_AN))]
        [Pos(1)]
        public List<string> RateTypeIdentifier_01 { get; set; }
    }
    
    /// <summary>
    // Rate details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RTE")]
    public class RTE
    {
        
        /// <summary>
        // RATE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C128 C128_01 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string StatusDescriptionCode_02 { get; set; }
    }
    
    /// <summary>
    // Rate details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RTI")]
    public class RTI
    {
        
        /// <summary>
        // RATE CLASS DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(1)]
        public List<E011> E011_01 { get; set; }
    }
    
    /// <summary>
    // Rule information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RUL")]
    public class RUL
    {
        
        /// <summary>
        // RULE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(1)]
        public List<E004> E004_01 { get; set; }
        /// <summary>
        // RULE TEXT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public List<E005> E005_02 { get; set; }
        /// <summary>
        // RULE STATUS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public List<E006> E006_03 { get; set; }
    }
    
    /// <summary>
    // Remuneration type identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SAL")]
    public class SAL
    {
        
        /// <summary>
        // REMUNERATION TYPE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C049 C049_01 { get; set; }
    }
    
    /// <summary>
    // Scheduling conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SCC")]
    public class SCC
    {
        
        /// <summary>
        // DELIVERY PLAN COMMITMENT LEVEL CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4017", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DELIVERYPLANCOMMITMENTLEVELCODE_01 { get; set; }
        /// <summary>
        // DELIVERY INSTRUCTION CODE
        /// </summary>
        [DataMember]
        [DataElement("4493", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DELIVERYINSTRUCTIONCODE_02 { get; set; }
        /// <summary>
        // PATTERN DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C329 C329_03 { get; set; }
    }
    
    /// <summary>
    // Structure component definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SCD")]
    public class SCD
    {
        
        /// <summary>
        // STRUCTURE COMPONENT FUNCTION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7497", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string STRUCTURECOMPONENTFUNCTIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // STRUCTURE COMPONENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C786 C786_02 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C082 C082_03 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(4)]
        public string StatusDescriptionCode_04 { get; set; }
        /// <summary>
        // CONFIGURATION LEVEL NUMBER
        /// </summary>
        [DataMember]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string CONFIGURATIONLEVELNUMBER_05 { get; set; }
        /// <summary>
        // POSITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C778 C778_06 { get; set; }
        /// <summary>
        // CHARACTERISTIC DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public C240 C240_07 { get; set; }
    }
    
    /// <summary>
    // Selection details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SDT")]
    public class SDT
    {
        
        /// <summary>
        // SELECTION DETAILS INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(1)]
        public List<E010> E010_01 { get; set; }
    }
    
    /// <summary>
    // Segment identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SEG")]
    public class SEG
    {
        
        /// <summary>
        // Segment tag identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9166", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SegmentTagIdentifier_01 { get; set; }
        /// <summary>
        // DESIGNATED CLASS CODE
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DESIGNATEDCLASSCODE_02 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string MAINTENANCEOPERATIONCODE_03 { get; set; }
    }
    
    /// <summary>
    // Seal number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SEL")]
    public class SEL
    {
        
        /// <summary>
        // TRANSPORT UNIT SEAL IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("9308", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TRANSPORTUNITSEALIDENTIFIER_01 { get; set; }
        /// <summary>
        // SEAL ISSUER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C215 C215_02 { get; set; }
        /// <summary>
        // SEAL CONDITION CODE
        /// </summary>
        [DataMember]
        [DataElement("4517", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string SEALCONDITIONCODE_03 { get; set; }
        /// <summary>
        // IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C208 C208_04 { get; set; }
        /// <summary>
        // SEAL TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("4525", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string SEALTYPECODE_05 { get; set; }
    }
    
    /// <summary>
    // Sequence details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SEQ")]
    public class SEQ
    {
        
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(1)]
        public string ACTIONCODE_01 { get; set; }
        /// <summary>
        // SEQUENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C286 C286_02 { get; set; }
    }
    
    /// <summary>
    // Facility information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SER")]
    public class SER
    {
        
        /// <summary>
        // FACILITIES
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(1)]
        public List<E965> E965_01 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public string ACTIONCODE_02 { get; set; }
        /// <summary>
        // Units quantity
        /// </summary>
        [DataMember]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(3)]
        public string UnitsQuantity_03 { get; set; }
        /// <summary>
        // DATE AND TIME INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public List<E013> E013_04 { get; set; }
        /// <summary>
        // DAYS OF WEEK SET IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("2160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string DAYSOFWEEKSETIDENTIFIER_05 { get; set; }
    }
    
    /// <summary>
    // Safety information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SFI")]
    public class SFI
    {
        
        /// <summary>
        // HIERARCHICAL STRUCTURE LEVEL IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string HIERARCHICALSTRUCTURELEVELIDENTIFIER_01 { get; set; }
        /// <summary>
        // SAFETY SECTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C814 C814_02 { get; set; }
        /// <summary>
        // ADDITIONAL SAFETY INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C815 C815_03 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MAINTENANCEOPERATIONCODE_04 { get; set; }
    }
    
    /// <summary>
    // Split goods placement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SGP")]
    public class SGP
    {
        
        /// <summary>
        // EQUIPMENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C237 C237_01 { get; set; }
        /// <summary>
        // PACKAGE QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(2)]
        public string PACKAGEQUANTITY_02 { get; set; }
    }
    
    /// <summary>
    // Segment usage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SGU")]
    public class SGU
    {
        
        /// <summary>
        // Segment tag identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9166", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SegmentTagIdentifier_01 { get; set; }
        /// <summary>
        // Requirement designator code
        /// </summary>
        [DataMember]
        [DataElement("7299", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string RequirementDesignatorCode_02 { get; set; }
        /// <summary>
        // OCCURRENCES MAXIMUM NUMBER
        /// </summary>
        [DataMember]
        [DataElement("6176", typeof(EDIFACT_N))]
        [Pos(3)]
        public string OCCURRENCESMAXIMUMNUMBER_03 { get; set; }
        /// <summary>
        // LEVEL NUMBER
        /// </summary>
        [DataMember]
        [DataElement("7168", typeof(EDIFACT_N))]
        [Pos(4)]
        public string LEVELNUMBER_04 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(5)]
        public string SequencePositionIdentifier_05 { get; set; }
        /// <summary>
        // Message section code
        /// </summary>
        [DataMember]
        [DataElement("1049", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string MessageSectionCode_06 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string MAINTENANCEOPERATIONCODE_07 { get; set; }
    }
    
    /// <summary>
    // Organisation classification details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SPR")]
    public class SPR
    {
        
        /// <summary>
        // SECTOR AREA IDENTIFICATION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7293", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SECTORAREAIDENTIFICATIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // ORGANISATION CLASSIFICATION CODE
        /// </summary>
        [DataMember]
        [DataElement("3079", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ORGANISATIONCLASSIFICATIONCODE_02 { get; set; }
        /// <summary>
        // ORGANISATION CLASSIFICATION DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C844 C844_03 { get; set; }
    }
    
    /// <summary>
    // Sampling parameters for summary statistics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SPS")]
    public class SPS
    {
        
        /// <summary>
        // FREQUENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C526 C526_01 { get; set; }
        /// <summary>
        // CONFIDENCE PERCENT
        /// </summary>
        [DataMember]
        [DataElement("6074", typeof(EDIFACT_N))]
        [Pos(2)]
        public string CONFIDENCEPERCENT_02 { get; set; }
        /// <summary>
        // SIZE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C512 C512_03 { get; set; }
        /// <summary>
        // SIZE DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C512 C512_04 { get; set; }
        /// <summary>
        // SIZE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C512 C512_05 { get; set; }
        /// <summary>
        // SIZE DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C512 C512_06 { get; set; }
        /// <summary>
        // SIZE DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public C512 C512_07 { get; set; }
    }
    
    /// <summary>
    // Special requirement details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SSR")]
    public class SSR
    {
        
        /// <summary>
        // SPECIAL REQUIREMENT TYPE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public E980 E980_01 { get; set; }
        /// <summary>
        // SPECIAL REQUIREMENT DETAILS
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(2)]
        public List<E981> E981_02 { get; set; }
    }
    
    /// <summary>
    // Statistics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STA")]
    public class STA
    {
        
        /// <summary>
        // STATISTIC TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6331", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string STATISTICTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // STATISTICAL DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C527 C527_02 { get; set; }
    }
    
    /// <summary>
    // Statistical concept
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STC")]
    public class STC
    {
        
        /// <summary>
        // STATISTICAL CONCEPT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C785 C785_01 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C082 C082_02 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string StatusDescriptionCode_03 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MAINTENANCEOPERATIONCODE_04 { get; set; }
    }
    
    /// <summary>
    // Stages
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STG")]
    public class STG
    {
        
        /// <summary>
        // PROCESS STAGE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9421", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PROCESSSTAGECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // PROCESS STAGES QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6426", typeof(EDIFACT_N))]
        [Pos(2)]
        public string PROCESSSTAGESQUANTITY_02 { get; set; }
        /// <summary>
        // PROCESS STAGES ACTUAL QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6428", typeof(EDIFACT_N))]
        [Pos(3)]
        public string PROCESSSTAGESACTUALQUANTITY_03 { get; set; }
    }
    
    /// <summary>
    // Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STS")]
    public class STS
    {
        
        /// <summary>
        // STATUS CATEGORY
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C601 C601_01 { get; set; }
        /// <summary>
        // STATUS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C555 C555_02 { get; set; }
        /// <summary>
        // STATUS REASON
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C556 C556_03 { get; set; }
        /// <summary>
        // STATUS REASON
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C556 C556_04 { get; set; }
        /// <summary>
        // STATUS REASON
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C556 C556_05 { get; set; }
        /// <summary>
        // STATUS REASON
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C556 C556_06 { get; set; }
        /// <summary>
        // STATUS REASON
        /// </summary>
        [DataMember]
        [Pos(7)]
        public C556 C556_07 { get; set; }
    }
    
    /// <summary>
    // Duty/tax/fee details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX
    {
        
        /// <summary>
        // DUTY OR TAX OR FEE FUNCTION CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string DUTYORTAXORFEEFUNCTIONCODEQUALIFIER_01 { get; set; }
        /// <summary>
        // DUTY/TAX/FEE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C241 C241_02 { get; set; }
        /// <summary>
        // DUTY/TAX/FEE ACCOUNT DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C533 C533_03 { get; set; }
        /// <summary>
        // DUTY OR TAX OR FEE ASSESSMENT BASIS QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DUTYORTAXORFEEASSESSMENTBASISQUANTITY_04 { get; set; }
        /// <summary>
        // DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C243 C243_05 { get; set; }
        /// <summary>
        // DUTY OR TAX OR FEE CATEGORY CODE
        /// </summary>
        [DataMember]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string DUTYORTAXORFEECATEGORYCODE_06 { get; set; }
        /// <summary>
        // PARTY TAX IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string PARTYTAXIDENTIFIER_07 { get; set; }
        /// <summary>
        // CALCULATION SEQUENCE CODE
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string CALCULATIONSEQUENCECODE_08 { get; set; }
        /// <summary>
        // TAX OR DUTY OR FEE PAYMENT DUE DATE CODE
        /// </summary>
        [DataMember]
        [DataElement("5307", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string TAXORDUTYORFEEPAYMENTDUEDATECODE_09 { get; set; }
    }
    
    /// <summary>
    // Charge/rate calculations
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TCC")]
    public class TCC
    {
        
        /// <summary>
        // CHARGE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C200 C200_01 { get; set; }
        /// <summary>
        // RATE/TARIFF CLASS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C203 C203_02 { get; set; }
        /// <summary>
        // COMMODITY/RATE DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C528 C528_03 { get; set; }
        /// <summary>
        // RATE/TARIFF CLASS DETAIL
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C554 C554_04 { get; set; }
    }
    
    /// <summary>
    // Time and certainty
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TCE")]
    public class TCE
    {
        
        /// <summary>
        // Date or time or period text
        /// </summary>
        [DataMember]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DateOrTimeOrPeriodText_01 { get; set; }
        /// <summary>
        // CERTAINTY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public E946 E946_02 { get; set; }
    }
    
    /// <summary>
    // Traveller document information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDI")]
    public class TDI
    {
        
        /// <summary>
        // DOCUMENT INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public E968 E968_01 { get; set; }
        /// <summary>
        // VALIDITY DATES
        /// </summary>
        [DataMember]
        [Pos(2)]
        public E969 E969_02 { get; set; }
        /// <summary>
        // FAMILY NAME
        /// </summary>
        [DataMember]
        [DataElement("3500", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string FAMILYNAME_03 { get; set; }
        /// <summary>
        // Given name
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [DataElement("3460", typeof(EDIFACT_AN))]
        [Pos(4)]
        public List<string> GivenName_04 { get; set; }
    }
    
    /// <summary>
    // Transport information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT
    {
        
        /// <summary>
        // TRANSPORT STAGE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string TRANSPORTSTAGECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // MEANS OF TRANSPORT JOURNEY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MEANSOFTRANSPORTJOURNEYIDENTIFIER_02 { get; set; }
        /// <summary>
        // MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C220 C220_03 { get; set; }
        /// <summary>
        // TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C001 C001_04 { get; set; }
        /// <summary>
        // CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C040 C040_05 { get; set; }
        /// <summary>
        // TRANSIT DIRECTION INDICATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string TRANSITDIRECTIONINDICATORCODE_06 { get; set; }
        /// <summary>
        // EXCESS TRANSPORTATION INFORMATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public C401 C401_07 { get; set; }
        /// <summary>
        // TRANSPORT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(8)]
        public C222 C222_08 { get; set; }
        /// <summary>
        // TRANSPORT MEANS OWNERSHIP INDICATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string TRANSPORTMEANSOWNERSHIPINDICATORCODE_09 { get; set; }
    }
    
    /// <summary>
    // Transport information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT", typeof(EDIFACT_ID_8051))]
    public class TDT_1
    {
        
        /// <summary>
        // TRANSPORT STAGE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string TRANSPORTSTAGECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // MEANS OF TRANSPORT JOURNEY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MEANSOFTRANSPORTJOURNEYIDENTIFIER_02 { get; set; }
        /// <summary>
        // MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C220 C220_03 { get; set; }
        /// <summary>
        // TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C001 C001_04 { get; set; }
        /// <summary>
        // CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public C040 C040_05 { get; set; }
        /// <summary>
        // TRANSIT DIRECTION INDICATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string TRANSITDIRECTIONINDICATORCODE_06 { get; set; }
        /// <summary>
        // EXCESS TRANSPORTATION INFORMATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public C401 C401_07 { get; set; }
        /// <summary>
        // TRANSPORT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(8)]
        public C222 C222_08 { get; set; }
        /// <summary>
        // TRANSPORT MEANS OWNERSHIP INDICATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string TRANSPORTMEANSOWNERSHIPINDICATORCODE_09 { get; set; }
    }
    
    /// <summary>
    // Test method
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TEM")]
    public class TEM
    {
        
        /// <summary>
        // TEST METHOD
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C244 C244_01 { get; set; }
        /// <summary>
        // TEST ADMINISTRATION METHOD CODE
        /// </summary>
        [DataMember]
        [DataElement("4419", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string TESTADMINISTRATIONMETHODCODE_02 { get; set; }
        /// <summary>
        // TEST MEDIUM CODE
        /// </summary>
        [DataMember]
        [DataElement("3077", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string TESTMEDIUMCODE_03 { get; set; }
        /// <summary>
        // MEASUREMENT PURPOSE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(4)]
        public string MEASUREMENTPURPOSECODEQUALIFIER_04 { get; set; }
        /// <summary>
        // TEST METHOD REVISION IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("7188", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string TESTMETHODREVISIONIDENTIFIER_05 { get; set; }
        /// <summary>
        // TEST REASON
        /// </summary>
        [DataMember]
        [Pos(6)]
        public C515 C515_06 { get; set; }
    }
    
    /// <summary>
    // Tariff information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TFF")]
    public class TFF
    {
        
        /// <summary>
        // TARIFF INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(1)]
        public List<E982> E982_01 { get; set; }
        /// <summary>
        // RATE INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public List<E983> E983_02 { get; set; }
        /// <summary>
        // ASSOCIATED CHARGES INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public List<E984> E984_03 { get; set; }
    }
    
    /// <summary>
    // Traveller information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TIF")]
    public class TIF
    {
        
        /// <summary>
        // TRAVELLER SURNAME AND RELATED INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public E985 E985_01 { get; set; }
        /// <summary>
        // TRAVELLER DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public List<E986> E986_02 { get; set; }
    }
    
    /// <summary>
    // Time zone information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TIZ")]
    public class TIZ
    {
        
        /// <summary>
        // TIME ZONE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public E034 E034_01 { get; set; }
    }
    
    /// <summary>
    // Transport movement details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TMD")]
    public class TMD
    {
        
        /// <summary>
        // MOVEMENT TYPE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C219 C219_01 { get; set; }
        /// <summary>
        // EQUIPMENT PLAN DESCRIPTION
        /// </summary>
        [DataMember]
        [DataElement("8332", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string EQUIPMENTPLANDESCRIPTION_02 { get; set; }
        /// <summary>
        // HAULAGE ARRANGEMENTS CODE
        /// </summary>
        [DataMember]
        [DataElement("8341", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string HAULAGEARRANGEMENTSCODE_03 { get; set; }
    }
    
    /// <summary>
    // Temperature
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TMP")]
    public class TMP
    {
        
        /// <summary>
        // TEMPERATURE TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6245", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TEMPERATURETYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // TEMPERATURE SETTING
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C239 C239_02 { get; set; }
    }
    
    /// <summary>
    // Terms of delivery or transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOD")]
    public class TOD
    {
        
        /// <summary>
        // DELIVERY OR TRANSPORT TERMS FUNCTION CODE
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DELIVERYORTRANSPORTTERMSFUNCTIONCODE_01 { get; set; }
        /// <summary>
        // Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string TransportChargesPaymentMethodCode_02 { get; set; }
        /// <summary>
        // TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C100 C100_03 { get; set; }
    }
    
    /// <summary>
    // Transport placement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TPL")]
    public class TPL
    {
        
        /// <summary>
        // TRANSPORT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C222 C222_01 { get; set; }
    }
    
    /// <summary>
    // Traffic restriction details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TRF")]
    public class TRF
    {
        
        /// <summary>
        // TRAFFIC RESTRICTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(1)]
        public List<E007> E007_01 { get; set; }
    }
    
    /// <summary>
    // Technical rules
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TRU")]
    public class TRU
    {
        
        /// <summary>
        // Object identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7402", typeof(EDIFACT_ID_7402))]
        [Pos(1)]
        public string ObjectIdentifier_01 { get; set; }
        /// <summary>
        // VERSION IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string VERSIONIDENTIFIER_02 { get; set; }
        /// <summary>
        // Release identifier
        /// </summary>
        [DataMember]
        [DataElement("1058", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ReleaseIdentifier_03 { get; set; }
        /// <summary>
        // RULE PART IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("7175", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string RULEPARTIDENTIFIER_04 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string CodeListResponsibleAgencyCode_05 { get; set; }
    }
    
    /// <summary>
    // Transport service requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TSR")]
    public class TSR
    {
        
        /// <summary>
        // CONTRACT AND CARRIAGE CONDITION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public C536 C536_01 { get; set; }
        /// <summary>
        // SERVICE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C233 C233_02 { get; set; }
        /// <summary>
        // TRANSPORT PRIORITY
        /// </summary>
        [DataMember]
        [Pos(3)]
        public C537 C537_03 { get; set; }
        /// <summary>
        // NATURE OF CARGO
        /// </summary>
        [DataMember]
        [Pos(4)]
        public C703 C703_04 { get; set; }
    }
    
    /// <summary>
    // Travel product information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TVL")]
    public class TVL
    {
        
        /// <summary>
        // PRODUCT DATE AND TIME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public E987 E987_01 { get; set; }
        /// <summary>
        // LOCATION
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public List<E975> E975_02 { get; set; }
        /// <summary>
        // COMPANY IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public E988 E988_03 { get; set; }
        /// <summary>
        // PRODUCT IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public E989 E989_04 { get; set; }
        /// <summary>
        // SEQUENCE NUMBER DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public E990 E990_05 { get; set; }
        /// <summary>
        // LINE ITEM IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string LINEITEMIDENTIFIER_06 { get; set; }
        /// <summary>
        // Processing indicator description code
        /// </summary>
        [DataMember]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string ProcessingIndicatorDescriptionCode_07 { get; set; }
    }
    
    /// <summary>
    // Taxes
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TXS")]
    public class TXS
    {
        
        /// <summary>
        // TAX DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(1)]
        public List<E020> E020_01 { get; set; }
    }
    
    /// <summary>
    // Section control
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("UNS")]
    public class UNS
    {
        
        /// <summary>
        // Section identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("0081", typeof(EDIFACT_ID_0081))]
        [Pos(1)]
        public string SectionIdentification_01 { get; set; }
    }
    
    /// <summary>
    // Vehicle
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("VEH")]
    public class VEH
    {
        
        /// <summary>
        // EQUIPMENT TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [DataElement("8053", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EQUIPMENTTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // VEHICLE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public E991 E991_02 { get; set; }
        /// <summary>
        // DIMENSIONS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public E211 E211_03 { get; set; }
        /// <summary>
        // Measure
        /// </summary>
        [DataMember]
        [DataElement("6314", typeof(EDIFACT_ID_6314))]
        [Pos(4)]
        public string Measure_04 { get; set; }
        /// <summary>
        // POSITION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public E992 E992_05 { get; set; }
        /// <summary>
        // Traveller reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1145", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string TravellerReferenceIdentifier_06 { get; set; }
    }
    
    /// <summary>
    // Value list identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("VLI")]
    public class VLI
    {
        
        /// <summary>
        // VALUE LIST IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public C780 C780_01 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public C082 C082_02 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string StatusDescriptionCode_03 { get; set; }
        /// <summary>
        // VALUE LIST NAME
        /// </summary>
        [DataMember]
        [DataElement("1514", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string VALUELISTNAME_04 { get; set; }
        /// <summary>
        // DESIGNATED CLASS CODE
        /// </summary>
        [DataMember]
        [DataElement("1507", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string DESIGNATEDCLASSCODE_05 { get; set; }
        /// <summary>
        // VALUE LIST TYPE CODE
        /// </summary>
        [DataMember]
        [DataElement("1505", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string VALUELISTTYPECODE_06 { get; set; }
        /// <summary>
        // CHARACTERISTIC DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public C240 C240_07 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string MAINTENANCEOPERATIONCODE_08 { get; set; }
    }
}
