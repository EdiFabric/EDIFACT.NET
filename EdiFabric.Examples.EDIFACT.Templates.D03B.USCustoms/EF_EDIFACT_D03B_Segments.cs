namespace EdiFabric.Templates.EdifactD03B
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;

    /// <summary>
    /// ATTRIBUTE
    /// </summary>
    [Serializable()]
    [Segment("ATT")]
    public class ATT
    {

        /// <summary>
        /// Attribute function code qualifier
        /// </summary>
        [Pos(1)]
        public string Attributefunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ATTRIBUTE TYPE
        /// </summary>
        [Pos(2)]
        public C955 ATTRIBUTETYPE_02 { get; set; }
        /// <summary>
        /// ATTRIBUTE DETAIL
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<C956> ATTRIBUTEDETAIL_03 { get; set; }
    }

    /// <summary>
    /// AUTHENTICATION RESULT
    /// </summary>
    [Serializable()]
    [Segment("AUT")]
    public class AUT
    {
        
        /// <summary>
        /// Validation result text
        /// </summary>
        [Pos(1)]
        public string Validationresulttext_01 { get; set; }
        /// <summary>
        /// Validation key identifier
        /// </summary>
        [Pos(2)]
        public string Validationkeyidentifier_02 { get; set; }
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
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [Pos(2)]
        public C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// CONSIGNMENT INFORMATION
    /// </summary>
    [Serializable()]
    [Segment("CNI")]
    public class CNI
    {
        
        /// <summary>
        /// Consolidation item number
        /// </summary>
        [Pos(1)]
        public string Consolidationitemnumber_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [Pos(2)]
        public C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Consignment load sequence identifier
        /// </summary>
        [Pos(3)]
        public string Consignmentloadsequenceidentifier_03 { get; set; }
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
        [Pos(1)]
        public List<C076> COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    /// <summary>
    /// CHARGE PAYMENT INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [Segment("CPI")]
    public class CPI
    {
        
        /// <summary>
        /// CHARGE CATEGORY
        /// </summary>
        [Pos(1)]
        public C229 CHARGECATEGORY_01 { get; set; }
        /// <summary>
        /// METHOD OF PAYMENT
        /// </summary>
        [Pos(2)]
        public C231 METHODOFPAYMENT_02 { get; set; }
        /// <summary>
        /// Payment arrangement code
        /// </summary>
        [Pos(3)]
        public string Paymentarrangementcode_03 { get; set; }
    }
    
    /// <summary>
    /// CUSTOMS STATUS OF GOODS
    /// </summary>
    [Serializable()]
    [Segment("CST")]
    public class CST
    {
        
        /// <summary>
        /// Goods item number
        /// </summary>
        [Pos(1)]
        public string Goodsitemnumber_01 { get; set; }
        /// <summary>
        /// CUSTOMS IDENTITY CODES
        /// </summary>
        [Pos(2)]
        public C246 CUSTOMSIDENTITYCODES_02 { get; set; }
        /// <summary>
        /// CUSTOMS IDENTITY CODES
        /// </summary>
        [Pos(3)]
        public C246 CUSTOMSIDENTITYCODES_03 { get; set; }
        /// <summary>
        /// CUSTOMS IDENTITY CODES
        /// </summary>
        [Pos(4)]
        public C246 CUSTOMSIDENTITYCODES_04 { get; set; }
        /// <summary>
        /// CUSTOMS IDENTITY CODES
        /// </summary>
        [Pos(5)]
        public C246 CUSTOMSIDENTITYCODES_05 { get; set; }
        /// <summary>
        /// CUSTOMS IDENTITY CODES
        /// </summary>
        [Pos(6)]
        public C246 CUSTOMSIDENTITYCODES_06 { get; set; }
    }
    
    /// <summary>
    /// CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [Segment("CTA")]
    public class CTA
    {
        
        /// <summary>
        /// Contact function code
        /// </summary>
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
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
        /// Currency exchange rate
        /// </summary>
        [Pos(3)]
        public string Currencyexchangerate_03 { get; set; }
        /// <summary>
        /// Exchange rate currency market identifier
        /// </summary>
        [Pos(4)]
        public string Exchangeratecurrencymarketidentifier_04 { get; set; }
    }
    
    /// <summary>
    /// DANGEROUS GOODS
    /// </summary>
    [Serializable()]
    [Segment("DGS")]
    public class DGS
    {
        
        /// <summary>
        /// Dangerous goods regulations code
        /// </summary>
        [Pos(1)]
        public string Dangerousgoodsregulationscode_01 { get; set; }
        /// <summary>
        /// HAZARD CODE
        /// </summary>
        [Pos(2)]
        public C205 HAZARDCODE_02 { get; set; }
        /// <summary>
        /// UNDG INFORMATION
        /// </summary>
        [Pos(3)]
        public C234 UNDGINFORMATION_03 { get; set; }
        /// <summary>
        /// DANGEROUS GOODS SHIPMENT FLASHPOINT
        /// </summary>
        [Pos(4)]
        public C223 DANGEROUSGOODSSHIPMENTFLASHPOINT_04 { get; set; }
        /// <summary>
        /// Packaging danger level code
        /// </summary>
        [Pos(5)]
        public string Packagingdangerlevelcode_05 { get; set; }
        /// <summary>
        /// Emergency procedure for ships identifier
        /// </summary>
        [Pos(6)]
        public string Emergencyprocedureforshipsidentifier_06 { get; set; }
        /// <summary>
        /// Hazard medical first aid guide identifier
        /// </summary>
        [Pos(7)]
        public string Hazardmedicalfirstaidguideidentifier_07 { get; set; }
        /// <summary>
        /// Transport emergency card identifier
        /// </summary>
        [Pos(8)]
        public string Transportemergencycardidentifier_08 { get; set; }
        /// <summary>
        /// HAZARD IDENTIFICATION PLACARD DETAILS
        /// </summary>
        [Pos(9)]
        public C235 HAZARDIDENTIFICATIONPLACARDDETAILS_09 { get; set; }
        /// <summary>
        /// DANGEROUS GOODS LABEL
        /// </summary>
        [Pos(10)]
        public C236 DANGEROUSGOODSLABEL_10 { get; set; }
        /// <summary>
        /// Packing instruction type code
        /// </summary>
        [Pos(11)]
        public string Packinginstructiontypecode_11 { get; set; }
        /// <summary>
        /// Hazardous means of transport category code
        /// </summary>
        [Pos(12)]
        public string Hazardousmeansoftransportcategorycode_12 { get; set; }
        /// <summary>
        /// Hazardous cargo transport authorisation code
        /// </summary>
        [Pos(13)]
        public string Hazardouscargotransportauthorisationcode_13 { get; set; }
    }
    
    /// <summary>
    /// DIMENSIONS
    /// </summary>
    [Serializable()]
    [Segment("DIM")]
    public class DIM
    {
        
        /// <summary>
        /// Dimension type code qualifier
        /// </summary>
        [Pos(1)]
        public string Dimensiontypecodequalifier_01 { get; set; }
        /// <summary>
        /// DIMENSIONS
        /// </summary>
        [Pos(2)]
        public C211 DIMENSIONS_02 { get; set; }
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
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [Pos(2)]
        public C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }

    /// <summary>
    /// EMPLOYMENT DETAILS
    /// </summary>
    [Serializable()]
    [Segment("EMP")]
    public class EMP
    {

        /// <summary>
        /// Employment details code qualifier
        /// </summary>
        [Pos(1)]
        public string Employmentdetailscodequalifier_01 { get; set; }
        /// <summary>
        /// EMPLOYMENT CATEGORY
        /// </summary>
        [Pos(2)]
        public C948 EMPLOYMENTCATEGORY_02 { get; set; }
        /// <summary>
        /// OCCUPATION
        /// </summary>
        [Pos(3)]
        public C951 OCCUPATION_03 { get; set; }
        /// <summary>
        /// QUALIFICATION CLASSIFICATION
        /// </summary>
        [Pos(4)]
        public C950 QUALIFICATIONCLASSIFICATION_04 { get; set; }
        /// <summary>
        /// Job title description
        /// </summary>
        [Pos(5)]
        public string Jobtitledescription_05 { get; set; }
        /// <summary>
        /// Qualification application area code
        /// </summary>
        [Pos(6)]
        public string Qualificationapplicationareacode_06 { get; set; }
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
        /// Equipment type code qualifier
        /// </summary>
        [Pos(1)]
        public string Equipmenttypecodequalifier_01 { get; set; }
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
        /// Equipment supplier code
        /// </summary>
        [Pos(4)]
        public string Equipmentsuppliercode_04 { get; set; }
        /// <summary>
        /// Equipment status code
        /// </summary>
        [Pos(5)]
        public string Equipmentstatuscode_05 { get; set; }
        /// <summary>
        /// Full or empty indicator code
        /// </summary>
        [Pos(6)]
        public string Fulloremptyindicatorcode_06 { get; set; }
    }
    
    /// <summary>
    /// FREE TEXT
    /// </summary>
    [Serializable()]
    [Segment("FTX")]
    public class FTX
    {
        
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// PROCESSING INFORMATION
    /// </summary>
    [Serializable()]
    [Segment("GEI")]
    public class GEI
    {
        
        /// <summary>
        /// Processing information code qualifier
        /// </summary>
        [Pos(1)]
        public string Processinginformationcodequalifier_01 { get; set; }
        /// <summary>
        /// PROCESSING INDICATOR
        /// </summary>
        [Pos(2)]
        public C012 PROCESSINGINDICATOR_02 { get; set; }
        /// <summary>
        /// Process type description code
        /// </summary>
        [Pos(3)]
        public string Processtypedescriptioncode_03 { get; set; }
    }
    
    /// <summary>
    /// GOODS ITEM DETAILS
    /// </summary>
    [Serializable()]
    [Segment("GID")]
    public class GID
    {
        
        /// <summary>
        /// Goods item number
        /// </summary>
        [Pos(1)]
        public string Goodsitemnumber_01 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [Pos(2)]
        public C213 NUMBERANDTYPEOFPACKAGES_02 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [Pos(3)]
        public C213 NUMBERANDTYPEOFPACKAGES_03 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [Pos(4)]
        public C213 NUMBERANDTYPEOFPACKAGES_04 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [Pos(5)]
        public C213 NUMBERANDTYPEOFPACKAGES_05 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [Pos(6)]
        public C213 NUMBERANDTYPEOFPACKAGES_06 { get; set; }
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
    /// PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Segment("LOC")]
    public class LOC
    {
        
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENTS
    /// </summary>
    [Serializable()]
    [Segment("MEA")]
    public class MEA
    {
        
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
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
        /// Surface or layer code
        /// </summary>
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
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
        /// Party function code qualifier
        /// </summary>
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [Pos(7)]
        public C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }

    /// <summary>
    /// NATIONALITY
    /// </summary>
    [Serializable()]
    [Segment("NAT")]
    public class NAT
    {

        /// <summary>
        /// Nationality code qualifier
        /// </summary>
        [Pos(1)]
        public string Nationalitycodequalifier_01 { get; set; }
        /// <summary>
        /// NATIONALITY DETAILS
        /// </summary>
        [Pos(2)]
        public C042 NATIONALITYDETAILS_02 { get; set; }
    }

    /// <summary>
    /// PACKAGE
    /// </summary>
    [Serializable()]
    [Segment("PAC")]
    public class PAC
    {
        
        /// <summary>
        /// Package quantity
        /// </summary>
        [Pos(1)]
        public string Packagequantity_01 { get; set; }
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
    /// PACKAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Segment("PCI")]
    public class PCI
    {
        
        /// <summary>
        /// Marking instructions code
        /// </summary>
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [Pos(2)]
        public C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [Pos(4)]
        public C827 TYPEOFMARKING_04 { get; set; }
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
        [Pos(1)]
        public C186 QUANTITYDETAILS_01 { get; set; }
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
        /// Range type code qualifier
        /// </summary>
        [Pos(1)]
        public string Rangetypecodequalifier_01 { get; set; }
        /// <summary>
        /// RANGE
        /// </summary>
        [Pos(2)]
        public C280 RANGE_02 { get; set; }
    }
    
    /// <summary>
    /// SEAL NUMBER
    /// </summary>
    [Serializable()]
    [Segment("SEL")]
    public class SEL
    {
        
        /// <summary>
        /// Transport unit seal identifier
        /// </summary>
        [Pos(1)]
        public string Transportunitsealidentifier_01 { get; set; }
        /// <summary>
        /// SEAL ISSUER
        /// </summary>
        [Pos(2)]
        public C215 SEALISSUER_02 { get; set; }
        /// <summary>
        /// Seal condition code
        /// </summary>
        [Pos(3)]
        public string Sealconditioncode_03 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [Pos(4)]
        public C208 IDENTITYNUMBERRANGE_04 { get; set; }
    }
    
    /// <summary>
    /// SPLIT GOODS PLACEMENT
    /// </summary>
    [Serializable()]
    [Segment("SGP")]
    public class SGP
    {
        
        /// <summary>
        /// EQUIPMENT IDENTIFICATION
        /// </summary>
        [Pos(1)]
        public C237 EQUIPMENTIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// Package quantity
        /// </summary>
        [Pos(2)]
        public string Packagequantity_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT INFORMATION
    /// </summary>
    [Serializable()]
    [Segment("TDT")]
    public class TDT
    {
        
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [Pos(3)]
        public C220 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [Pos(4)]
        public C001 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [Pos(5)]
        public C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
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
        /// Transport means ownership indicator code
        /// </summary>
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT MOVEMENT DETAILS
    /// </summary>
    [Serializable()]
    [Segment("TMD")]
    public class TMD
    {
        
        /// <summary>
        /// MOVEMENT TYPE
        /// </summary>
        [Pos(1)]
        public C219 MOVEMENTTYPE_01 { get; set; }
        /// <summary>
        /// Equipment plan description
        /// </summary>
        [Pos(2)]
        public string Equipmentplandescription_02 { get; set; }
        /// <summary>
        /// Haulage arrangements code
        /// </summary>
        [Pos(3)]
        public string Haulagearrangementscode_03 { get; set; }
    }
    
    /// <summary>
    /// TEMPERATURE
    /// </summary>
    [Serializable()]
    [Segment("TMP")]
    public class TMP
    {
        
        /// <summary>
        /// Temperature type code qualifier
        /// </summary>
        [Pos(1)]
        public string Temperaturetypecodequalifier_01 { get; set; }
        /// <summary>
        /// TEMPERATURE SETTING
        /// </summary>
        [Pos(2)]
        public C239 TEMPERATURESETTING_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT SERVICE REQUIREMENTS
    /// </summary>
    [Serializable()]
    [Segment("TSR")]
    public class TSR
    {
        
        /// <summary>
        /// CONTRACT AND CARRIAGE CONDITION
        /// </summary>
        [Pos(1)]
        public C536 CONTRACTANDCARRIAGECONDITION_01 { get; set; }
        /// <summary>
        /// SERVICE
        /// </summary>
        [Pos(2)]
        public C233 SERVICE_02 { get; set; }
        /// <summary>
        /// TRANSPORT PRIORITY
        /// </summary>
        [Pos(3)]
        public C537 TRANSPORTPRIORITY_03 { get; set; }
        /// <summary>
        /// NATURE OF CARGO
        /// </summary>
        [Pos(4)]
        public C703 NATUREOFCARGO_04 { get; set; }
    }
}
