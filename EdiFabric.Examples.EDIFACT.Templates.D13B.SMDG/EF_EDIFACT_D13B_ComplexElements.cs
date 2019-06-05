namespace EdiFabric.Templates.EdifactD13B
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    /// <summary>
    /// TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [Composite("C001")]
    public class C001
    {
        
        /// <summary>
        /// Transport means description code
        /// </summary>
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Transport means description
        /// </summary>
        [Pos(4)]
        public string Transportmeansdescription_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [Composite("C002")]
    public class C002
    {
        
        /// <summary>
        /// Document name code
        /// </summary>
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// CARRIER
    /// </summary>
    [Serializable()]
    [Composite("C040")]
    public class C040
    {
        
        /// <summary>
        /// Carrier identifier
        /// </summary>
        [Pos(1)]
        public string Carrieridentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Carrier name
        /// </summary>
        [Pos(4)]
        public string Carriername_04 { get; set; }
    }
    
    /// <summary>
    /// CONTACT DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C056")]
    public class C056
    {
        
        /// <summary>
        /// Contact identifier
        /// </summary>
        [Pos(1)]
        public string Contactidentifier_01 { get; set; }
        /// <summary>
        /// Contact name
        /// </summary>
        [Pos(2)]
        public string Contactname_02 { get; set; }
    }
    
    /// <summary>
    /// NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [Composite("C058")]
    public class C058
    {
        
        /// <summary>
        /// Name and address description
        /// </summary>
        [Pos(1)]
        public string Nameandaddressdescription_01 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [Pos(2)]
        public string Nameandaddressdescription_02 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [Pos(3)]
        public string Nameandaddressdescription_03 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [Pos(4)]
        public string Nameandaddressdescription_04 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [Pos(5)]
        public string Nameandaddressdescription_05 { get; set; }
    }
    
    /// <summary>
    /// STREET
    /// </summary>
    [Serializable()]
    [Composite("C059")]
    public class C059
    {
        
        /// <summary>
        /// Street and number or post office box identifier
        /// </summary>
        [Pos(1)]
        public string Streetandnumberorpostofficeboxidentifier_01 { get; set; }
        /// <summary>
        /// Street and number or post office box identifier
        /// </summary>
        [Pos(2)]
        public string Streetandnumberorpostofficeboxidentifier_02 { get; set; }
        /// <summary>
        /// Street and number or post office box identifier
        /// </summary>
        [Pos(3)]
        public string Streetandnumberorpostofficeboxidentifier_03 { get; set; }
        /// <summary>
        /// Street and number or post office box identifier
        /// </summary>
        [Pos(4)]
        public string Streetandnumberorpostofficeboxidentifier_04 { get; set; }
    }
    
    /// <summary>
    /// COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [Composite("C076")]
    public class C076
    {
        
        /// <summary>
        /// Communication address identifier
        /// </summary>
        [Pos(1)]
        public string Communicationaddressidentifier_01 { get; set; }
        /// <summary>
        /// Communication means type code
        /// </summary>
        [Pos(2)]
        public string Communicationmeanstypecode_02 { get; set; }
    }
    
    /// <summary>
    /// PARTY NAME
    /// </summary>
    [Serializable()]
    [Composite("C080")]
    public class C080
    {
        
        /// <summary>
        /// Party name
        /// </summary>
        [Pos(1)]
        public string Partyname_01 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [Pos(2)]
        public string Partyname_02 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [Pos(3)]
        public string Partyname_03 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [Pos(4)]
        public string Partyname_04 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [Pos(5)]
        public string Partyname_05 { get; set; }
        /// <summary>
        /// Party name format code
        /// </summary>
        [Pos(6)]
        public string Partynameformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// PARTY IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C082")]
    public class C082
    {
        
        /// <summary>
        /// Party identifier
        /// </summary>
        [Pos(1)]
        public string Partyidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C106")]
    public class C106
    {
        
        /// <summary>
        /// Document identifier
        /// </summary>
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [Pos(2)]
        public string Versionidentifier_02 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [Pos(3)]
        public string Revisionidentifier_03 { get; set; }
    }
    
    /// <summary>
    /// TEXT REFERENCE
    /// </summary>
    [Serializable()]
    [Composite("C107")]
    public class C107
    {
        
        /// <summary>
        /// Free text description code
        /// </summary>
        [Pos(1)]
        public string Freetextdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// TEXT LITERAL
    /// </summary>
    [Serializable()]
    [Composite("C108")]
    public class C108
    {
        
        /// <summary>
        /// Free text
        /// </summary>
        [Pos(1)]
        public string Freetext_01 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [Pos(2)]
        public string Freetext_02 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [Pos(3)]
        public string Freetext_03 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [Pos(4)]
        public string Freetext_04 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [Pos(5)]
        public string Freetext_05 { get; set; }
    }
    
    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [Composite("C174")]
    public class C174
    {
        
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Measure
        /// </summary>
        [Pos(2)]
        public string Measure_02 { get; set; }
        /// <summary>
        /// Range minimum quantity
        /// </summary>
        [Pos(3)]
        public string Rangeminimumquantity_03 { get; set; }
        /// <summary>
        /// Range maximum quantity
        /// </summary>
        [Pos(4)]
        public string Rangemaximumquantity_04 { get; set; }
        /// <summary>
        /// Significant digits quantity
        /// </summary>
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    /// <summary>
    /// HAZARD CODE
    /// </summary>
    [Serializable()]
    [Composite("C205")]
    public class C205
    {
        
        /// <summary>
        /// Hazard identification code
        /// </summary>
        [Pos(1)]
        public string Hazardidentificationcode_01 { get; set; }
        /// <summary>
        /// Additional hazard classification identifier
        /// </summary>
        [Pos(2)]
        public string Additionalhazardclassificationidentifier_02 { get; set; }
        /// <summary>
        /// Hazard code version identifier
        /// </summary>
        [Pos(3)]
        public string Hazardcodeversionidentifier_03 { get; set; }
    }
    
    /// <summary>
    /// DIMENSIONS
    /// </summary>
    [Serializable()]
    [Composite("C211")]
    public class C211
    {
        
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Length measure
        /// </summary>
        [Pos(2)]
        public string Lengthmeasure_02 { get; set; }
        /// <summary>
        /// Width measure
        /// </summary>
        [Pos(3)]
        public string Widthmeasure_03 { get; set; }
        /// <summary>
        /// Height measure
        /// </summary>
        [Pos(4)]
        public string Heightmeasure_04 { get; set; }
    }
    
    /// <summary>
    /// NUMBER AND TYPE OF PACKAGES
    /// </summary>
    [Serializable()]
    [Composite("C213")]
    public class C213
    {
        
        /// <summary>
        /// Package quantity
        /// </summary>
        [Pos(1)]
        public string Packagequantity_01 { get; set; }
        /// <summary>
        /// Package type description code
        /// </summary>
        [Pos(2)]
        public string Packagetypedescriptioncode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [Pos(5)]
        public string Typeofpackages_05 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [Pos(6)]
        public string Packagingrelateddescriptioncode_06 { get; set; }
    }

    /// <summary>
    /// HAZARDOUS MATERIAL
    /// </summary>
    [Serializable()]
    [Composite("C218")]
    public class C218
    {

        /// <summary>
        /// Hazardous material class code, identification
        /// </summary>
        [Pos(1)]
        public string Hazardousmaterialclasscodeidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }

    /// <summary>
    /// MODE OF TRANSPORT
    /// </summary>
    [Serializable()]
    [Composite("C220")]
    public class C220
    {
        
        /// <summary>
        /// Transport mode name code
        /// </summary>
        [Pos(1)]
        public string Transportmodenamecode_01 { get; set; }
        /// <summary>
        /// Transport mode name
        /// </summary>
        [Pos(2)]
        public string Transportmodename_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C222")]
    public class C222
    {
        
        /// <summary>
        /// Transport means identification name identifier
        /// </summary>
        [Pos(1)]
        public string Transportmeansidentificationnameidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Transport means identification name
        /// </summary>
        [Pos(4)]
        public string Transportmeansidentificationname_04 { get; set; }
        /// <summary>
        /// Transport means nationality code
        /// </summary>
        [Pos(5)]
        public string Transportmeansnationalitycode_05 { get; set; }
    }
    
    /// <summary>
    /// DANGEROUS GOODS SHIPMENT FLASHPOINT
    /// </summary>
    [Serializable()]
    [Composite("C223")]
    public class C223
    {
        
        /// <summary>
        /// Shipment flashpoint degree
        /// </summary>
        [Pos(1)]
        public string Shipmentflashpointdegree_01 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [Pos(2)]
        public string Measurementunitcode_02 { get; set; }
    }
    
    /// <summary>
    /// EQUIPMENT SIZE AND TYPE
    /// </summary>
    [Serializable()]
    [Composite("C224")]
    public class C224
    {
        
        /// <summary>
        /// Equipment size and type description code
        /// </summary>
        [Pos(1)]
        public string Equipmentsizeandtypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Equipment size and type description
        /// </summary>
        [Pos(4)]
        public string Equipmentsizeandtypedescription_04 { get; set; }
    }

    /// <summary>
    /// SERVICE
    /// </summary>
    [Serializable()]
    [Composite("C233")]
    public class C233
    {

        /// <summary>
        /// Service requirement code
        /// </summary>
        [Pos(1)]
        public string Servicerequirementcode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Service requirement code
        /// </summary>
        [Pos(4)]
        public string Servicerequirementcode_04 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(5)]
        public string Codelistidentificationcode_05 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(6)]
        public string Codelistresponsibleagencycode_06 { get; set; }
    }

    /// <summary>
    /// UNDG INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C234")]
    public class C234
    {
        
        /// <summary>
        /// United Nations Dangerous Goods (UNDG) identifier
        /// </summary>
        [Pos(1)]
        public string UnitedNationsDangerousGoodsUNDGidentifier_01 { get; set; }
        /// <summary>
        /// Dangerous goods flashpoint description
        /// </summary>
        [Pos(2)]
        public string Dangerousgoodsflashpointdescription_02 { get; set; }
    }
    
    /// <summary>
    /// HAZARD IDENTIFICATION PLACARD DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C235")]
    public class C235
    {
        
        /// <summary>
        /// Orange hazard placard upper part identifier
        /// </summary>
        [Pos(1)]
        public string Orangehazardplacardupperpartidentifier_01 { get; set; }
        /// <summary>
        /// Orange hazard placard lower part identifier
        /// </summary>
        [Pos(2)]
        public string Orangehazardplacardlowerpartidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// DANGEROUS GOODS LABEL
    /// </summary>
    [Serializable()]
    [Composite("C236")]
    public class C236
    {
        
        /// <summary>
        /// Dangerous goods marking identifier
        /// </summary>
        [Pos(1)]
        public string Dangerousgoodsmarkingidentifier_01 { get; set; }
        /// <summary>
        /// Dangerous goods marking identifier
        /// </summary>
        [Pos(2)]
        public string Dangerousgoodsmarkingidentifier_02 { get; set; }
        /// <summary>
        /// Dangerous goods marking identifier
        /// </summary>
        [Pos(3)]
        public string Dangerousgoodsmarkingidentifier_03 { get; set; }
        /// <summary>
        /// Dangerous goods marking identifier
        /// </summary>
        [Pos(4)]
        public string Dangerousgoodsmarkingidentifier_04 { get; set; }
    }
    
    /// <summary>
    /// EQUIPMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C237")]
    public class C237
    {
        
        /// <summary>
        /// Equipment identifier
        /// </summary>
        [Pos(1)]
        public string Equipmentidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Country identifier
        /// </summary>
        [Pos(4)]
        public string Countryidentifier_04 { get; set; }
    }
    
    /// <summary>
    /// TEMPERATURE SETTING
    /// </summary>
    [Serializable()]
    [Composite("C239")]
    public class C239
    {
        
        /// <summary>
        /// Temperature degree
        /// </summary>
        [Pos(1)]
        public string Temperaturedegree_01 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [Pos(2)]
        public string Measurementunitcode_02 { get; set; }
    }

    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [Composite("C270")]
    public class C270
    {

        /// <summary>
        /// Control qualifier
        /// </summary>
        [Pos(1)]
        public string Controlqualifier_01 { get; set; }
        /// <summary>
        /// Control value
        /// </summary>
        [Pos(2)]
        public string Controlvalue_02 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }

    /// <summary>
    /// RANGE
    /// </summary>
    [Serializable()]
    [Composite("C280")]
    public class C280
    {
        
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Range minimum quantity
        /// </summary>
        [Pos(2)]
        public string Rangeminimumquantity_02 { get; set; }
        /// <summary>
        /// Range maximum quantity
        /// </summary>
        [Pos(3)]
        public string Rangemaximumquantity_03 { get; set; }
    }
    
    /// <summary>
    /// PRODUCT GROUP
    /// </summary>
    [Serializable()]
    [Composite("C288")]
    public class C288
    {
        
        /// <summary>
        /// Product group name code
        /// </summary>
        [Pos(1)]
        public string Productgroupnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Product group name
        /// </summary>
        [Pos(4)]
        public string Productgroupname_04 { get; set; }
    }
    
    /// <summary>
    /// TUNNEL RESTRICTION
    /// </summary>
    [Serializable()]
    [Composite("C289")]
    public class C289
    {
        
        /// <summary>
        /// Tunnel Restriction Code
        /// </summary>
        [Pos(1)]
        public string TunnelRestrictionCode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// EXCESS TRANSPORTATION INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C401")]
    public class C401
    {
        
        /// <summary>
        /// Excess transportation reason code
        /// </summary>
        [Pos(1)]
        public string Excesstransportationreasoncode_01 { get; set; }
        /// <summary>
        /// Excess transportation responsibility code
        /// </summary>
        [Pos(2)]
        public string Excesstransportationresponsibilitycode_02 { get; set; }
        /// <summary>
        /// Customer shipment authorisation identifier
        /// </summary>
        [Pos(3)]
        public string Customershipmentauthorisationidentifier_03 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C502")]
    public class C502
    {
        
        /// <summary>
        /// Measured attribute code
        /// </summary>
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance code
        /// </summary>
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [Composite("C506")]
    public class C506
    {
        
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [Pos(4)]
        public string Versionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [Composite("C507")]
    public class C507
    {
        
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period text
        /// </summary>
        [Pos(2)]
        public string Dateortimeorperiodtext_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C517")]
    public class C517
    {
        
        /// <summary>
        /// Location identifier
        /// </summary>
        [Pos(1)]
        public string Locationidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Location name
        /// </summary>
        [Pos(4)]
        public string Locationname_04 { get; set; }
    }
    
    /// <summary>
    /// RELATED LOCATION ONE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C519")]
    public class C519
    {
        
        /// <summary>
        /// First related location identifier
        /// </summary>
        [Pos(1)]
        public string Firstrelatedlocationidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// First related location name
        /// </summary>
        [Pos(4)]
        public string Firstrelatedlocationname_04 { get; set; }
    }

    /// <summary>
    /// HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [Composite("C524")]
    public class C524
    {

        /// <summary>
        /// Handling instructions, coded
        /// </summary>
        [Pos(1)]
        public string Handlinginstructionscoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Handling instructions
        /// </summary>
        [Pos(4)]
        public string Handlinginstructions_04 { get; set; }
    }

    /// <summary>
    /// CONTRACT AND CARRIAGE CONDITION
    /// </summary>
    [Serializable()]
    [Composite("C536")]
    public class C536
    {

        /// <summary>
        /// Contract and carriage condition code
        /// </summary>
        [Pos(1)]
        public string Contractandcarriageconditioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }

    /// <summary>
    /// TRANSPORT PRIORITY
    /// </summary>
    [Serializable()]
    [Composite("C537")]
    public class C537
    {

        /// <summary>
        /// Transport service priority code
        /// </summary>
        [Pos(1)]
        public string Transportserviceprioritycode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }

    /// <summary>
    /// RELATED LOCATION TWO IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C553")]
    public class C553
    {
        
        /// <summary>
        /// Second related location identifier
        /// </summary>
        [Pos(1)]
        public string Secondrelatedlocationidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Second related location name
        /// </summary>
        [Pos(4)]
        public string Secondrelatedlocationname_04 { get; set; }
    }
    
    /// <summary>
    /// NATURE OF CARGO
    /// </summary>
    [Serializable()]
    [Composite("C703")]
    public class C703
    {
        
        /// <summary>
        /// Cargo type classification code
        /// </summary>
        [Pos(1)]
        public string Cargotypeclassificationcode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// COUNTRY SUBDIVISION DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C819")]
    public class C819
    {
        
        /// <summary>
        /// Country subdivision identifier
        /// </summary>
        [Pos(1)]
        public string Countrysubdivisionidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Country subdivision name
        /// </summary>
        [Pos(4)]
        public string Countrysubdivisionname_04 { get; set; }
    }

    /// <summary>
    /// ATTRIBUTE TYPE
    /// </summary>
    [Serializable()]
    [Composite("C955")]
    public class C955
    {

        /// <summary>
        /// Attribute type description code
        /// </summary>
        [Pos(1)]
        public string Attributetypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Attribute type description
        /// </summary>
        [Pos(4)]
        public string Attributetypedescription_04 { get; set; }
    }

    /// <summary>
    /// ATTRIBUTE DETAIL
    /// </summary>
    [Serializable()]
    [Composite("C956")]
    public class C956
    {

        /// <summary>
        /// Attribute description code
        /// </summary>
        [Pos(1)]
        public string Attributedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Attribute description
        /// </summary>
        [Pos(4)]
        public string Attributedescription_04 { get; set; }
    }
}
