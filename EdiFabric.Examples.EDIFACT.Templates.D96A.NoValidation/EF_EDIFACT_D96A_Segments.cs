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
        [Pos(1)]
        public string Adjustmentreasoncoded_01 { get; set; }
        /// <summary>
        /// Line item number
        /// </summary>
        [DataMember]
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
        [Pos(3)]
        public string Settlementcoded_03 { get; set; }
        /// <summary>
        /// Calculation sequence indicator, coded
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Countryoforigincoded_01 { get; set; }
        /// <summary>
        /// Type of duty regime, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Typeofdutyregimecoded_02 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Specialconditionscoded_03 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Specialconditionscoded_04 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Specialconditionscoded_05 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Specialconditionscoded_06 { get; set; }
        /// <summary>
        /// Special conditions, coded
        /// </summary>
        [DataMember]
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
        [Pos(2)]
        public string Documentmessagenumber_02 { get; set; }
        /// <summary>
        /// Message function, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Messagefunctioncoded_03 { get; set; }
        /// <summary>
        /// Response type, coded
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public virtual C076 COMMUNICATIONCONTACT_01 { get; set; }
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
        [Pos(1)]
        public string Hierarchicalidnumber_01 { get; set; }
        /// <summary>
        /// Hierarchical parent id.
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Hierarchicalparentid_02 { get; set; }
        /// <summary>
        /// Packaging level, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Packaginglevelcoded_03 { get; set; }
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
        [Pos(3)]
        public string Rateofexchange_03 { get; set; }
        /// <summary>
        /// Currency market exchange, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Currencymarketexchangecoded_04 { get; set; }
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
        [Pos(5)]
        public string Packinggroupcoded_05 { get; set; }
        /// <summary>
        /// EMS number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string EMSnumber_06 { get; set; }
        /// <summary>
        /// MFAG
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string MFAG_07 { get; set; }
        /// <summary>
        /// Trem card number
        /// </summary>
        [DataMember]
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
        [Pos(11)]
        public string Packinginstructioncoded_11 { get; set; }
        /// <summary>
        /// Category of means of transport, coded
        /// </summary>
        [DataMember]
        [Pos(12)]
        public string Categoryofmeansoftransportcoded_12 { get; set; }
        /// <summary>
        /// Permission for transport, coded
        /// </summary>
        [DataMember]
        [Pos(13)]
        public string Permissionfortransportcoded_13 { get; set; }
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
        [Pos(1)]
        public string Dimensionqualifier_01 { get; set; }
        /// <summary>
        /// DIMENSIONS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C211 DIMENSIONS_02 { get; set; }
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
        [Pos(4)]
        public string Productservicesubstitutioncoded_04 { get; set; }
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
        [Pos(3)]
        public string Communicationchannelidentifiercoded_03 { get; set; }
        /// <summary>
        /// Number of copies of document required
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Numberofcopiesofdocumentrequired_04 { get; set; }
        /// <summary>
        /// Number of originals of document required
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public virtual C507 DATETIMEPERIOD_01 { get; set; }
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
        [Pos(4)]
        public string Equipmentsuppliercoded_04 { get; set; }
        /// <summary>
        /// Equipment status, coded
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Equipmentstatuscoded_05 { get; set; }
        /// <summary>
        /// Full/empty indicator, coded
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public virtual C523 NUMBEROFUNITDETAILS_01 { get; set; }
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
        [Pos(1)]
        public string Textsubjectqualifier_01 { get; set; }
        /// <summary>
        /// Text function, coded
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Identitynumberqualifier_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Setidentificationqualifier_01 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Itemdescriptiontypecoded_01 { get; set; }
        /// <summary>
        /// Item characteristic, coded
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Lineitemnumber_01 { get; set; }
        /// <summary>
        /// Action request/notification, coded
        /// </summary>
        [DataMember]
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
        [Pos(5)]
        public string Configurationlevel_05 { get; set; }
        /// <summary>
        /// Configuration, coded
        /// </summary>
        [DataMember]
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
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// Country sub-entity identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Countrysubentityidentification_07 { get; set; }
        /// <summary>
        /// Postcode identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Postcodeidentification_08 { get; set; }
        /// <summary>
        /// Country, coded
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Productidfunctionqualifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Deliveryplanstatusindicatorcoded_01 { get; set; }
        /// <summary>
        /// Delivery requirements, coded
        /// </summary>
        [DataMember]
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
        [Pos(3)]
        public string Sealconditioncoded_03 { get; set; }
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
        [Pos(1)]
        public virtual C237 EQUIPMENTIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// Number of packages
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Numberofpackages_02 { get; set; }
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
        [Pos(1)]
        public string Stagesqualifier_01 { get; set; }
        /// <summary>
        /// Number of stages
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Numberofstages_02 { get; set; }
        /// <summary>
        /// Actual stage count
        /// </summary>
        [DataMember]
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
        [Pos(6)]
        public string Dutytaxfeecategorycoded_06 { get; set; }
        /// <summary>
        /// Party tax identification number
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Transportstagequalifier_01 { get; set; }
        /// <summary>
        /// Conveyance reference number
        /// </summary>
        [DataMember]
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
        [Pos(9)]
        public string Transportownershipcoded_09 { get; set; }
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
        [Pos(2)]
        public string Equipmentplan_02 { get; set; }
        /// <summary>
        /// Haulage arrangements, coded
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Termsofdeliveryortransportfunctioncoded_01 { get; set; }
        /// <summary>
        /// Transport charges method of payment, coded
        /// </summary>
        [DataMember]
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
        [Pos(1)]
        public string Sectionidentification_01 { get; set; }
    }
}
