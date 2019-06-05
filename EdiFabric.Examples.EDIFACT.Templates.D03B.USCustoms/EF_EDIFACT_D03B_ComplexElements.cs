namespace EdiFabric.Templates.EdifactD03B
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
    /// PROCESSING INDICATOR
    /// </summary>
    [Serializable()]
    [Composite("C012")]
    public class C012
    {
        
        /// <summary>
        /// Processing indicator description code
        /// </summary>
        [Pos(1)]
        public string Processingindicatordescriptioncode_01 { get; set; }
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
        /// Processing indicator description
        /// </summary>
        [Pos(4)]
        public string Processingindicatordescription_04 { get; set; }
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
    /// NATIONALITY DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C042")]
    public class C042
    {

        /// <summary>
        /// Nationality name code
        /// </summary>
        [Pos(1)]
        public string Nationalitynamecode_01 { get; set; }
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
        /// Nationality name
        /// </summary>
        [Pos(4)]
        public string Nationalityname_04 { get; set; }
    }

    /// <summary>
    /// DEPARTMENT OR EMPLOYEE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C056")]
    public class C056
    {
        
        /// <summary>
        /// Department or employee name code
        /// </summary>
        [Pos(1)]
        public string Departmentoremployeenamecode_01 { get; set; }
        /// <summary>
        /// Department or employee name
        /// </summary>
        [Pos(2)]
        public string Departmentoremployeename_02 { get; set; }
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
        /// Communication address code qualifier
        /// </summary>
        [Pos(2)]
        public string Communicationaddresscodequalifier_02 { get; set; }
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
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C186")]
    public class C186
    {
        
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [Composite("C202")]
    public class C202
    {
        
        /// <summary>
        /// Package type description code
        /// </summary>
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
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
        /// Type of packages
        /// </summary>
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
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
    /// IDENTITY NUMBER RANGE
    /// </summary>
    [Serializable()]
    [Composite("C208")]
    public class C208
    {
        
        /// <summary>
        /// Object identifier
        /// </summary>
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        /// <summary>
        /// Object identifier
        /// </summary>
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// MARKS & LABELS
    /// </summary>
    [Serializable()]
    [Composite("C210")]
    public class C210
    {
        
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [Pos(1)]
        public string Shippingmarksdescription_01 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [Pos(2)]
        public string Shippingmarksdescription_02 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [Pos(3)]
        public string Shippingmarksdescription_03 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [Pos(4)]
        public string Shippingmarksdescription_04 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [Pos(5)]
        public string Shippingmarksdescription_05 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [Pos(6)]
        public string Shippingmarksdescription_06 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [Pos(7)]
        public string Shippingmarksdescription_07 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [Pos(8)]
        public string Shippingmarksdescription_08 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [Pos(9)]
        public string Shippingmarksdescription_09 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [Pos(10)]
        public string Shippingmarksdescription_10 { get; set; }
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
    /// SEAL ISSUER
    /// </summary>
    [Serializable()]
    [Composite("C215")]
    public class C215
    {
        
        /// <summary>
        /// Sealing party name code
        /// </summary>
        [Pos(1)]
        public string Sealingpartynamecode_01 { get; set; }
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
        /// Sealing party name
        /// </summary>
        [Pos(4)]
        public string Sealingpartyname_04 { get; set; }
    }
    
    /// <summary>
    /// HAZARDOUS MATERIAL
    /// </summary>
    [Serializable()]
    [Composite("C218")]
    public class C218
    {
        
        /// <summary>
        /// Hazardous material category name code
        /// </summary>
        [Pos(1)]
        public string Hazardousmaterialcategorynamecode_01 { get; set; }
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
        /// Hazardous material category name
        /// </summary>
        [Pos(4)]
        public string Hazardousmaterialcategoryname_04 { get; set; }
    }
    
    /// <summary>
    /// MOVEMENT TYPE
    /// </summary>
    [Serializable()]
    [Composite("C219")]
    public class C219
    {
        
        /// <summary>
        /// Movement type description code
        /// </summary>
        [Pos(1)]
        public string Movementtypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Movement type description
        /// </summary>
        [Pos(2)]
        public string Movementtypedescription_02 { get; set; }
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
    /// CHARGE CATEGORY
    /// </summary>
    [Serializable()]
    [Composite("C229")]
    public class C229
    {
        
        /// <summary>
        /// Charge category code
        /// </summary>
        [Pos(1)]
        public string Chargecategorycode_01 { get; set; }
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
    /// METHOD OF PAYMENT
    /// </summary>
    [Serializable()]
    [Composite("C231")]
    public class C231
    {
        
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [Pos(1)]
        public string Transportchargespaymentmethodcode_01 { get; set; }
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
        /// Country name code
        /// </summary>
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
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
    /// CUSTOMS IDENTITY CODES
    /// </summary>
    [Serializable()]
    [Composite("C246")]
    public class C246
    {
        
        /// <summary>
        /// Customs goods identifier
        /// </summary>
        [Pos(1)]
        public string Customsgoodsidentifier_01 { get; set; }
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
    /// CONTROL
    /// </summary>
    [Serializable()]
    [Composite("C270")]
    public class C270
    {
        
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total quantity
        /// </summary>
        [Pos(2)]
        public string Controltotalquantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
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
    /// PACKAGE TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C402")]
    public class C402
    {
        
        /// <summary>
        /// Description format code
        /// </summary>
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [Pos(2)]
        public string Typeofpackages_02 { get; set; }
        /// <summary>
        /// Item type identification code
        /// </summary>
        [Pos(3)]
        public string Itemtypeidentificationcode_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
        /// <summary>
        /// Item type identification code
        /// </summary>
        [Pos(5)]
        public string Itemtypeidentificationcode_05 { get; set; }
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
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C503")]
    public class C503
    {
        
        /// <summary>
        /// Document identifier
        /// </summary>
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        /// <summary>
        /// Document status code
        /// </summary>
        [Pos(2)]
        public string Documentstatuscode_02 { get; set; }
        /// <summary>
        /// Document source description
        /// </summary>
        [Pos(3)]
        public string Documentsourcedescription_03 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [Pos(4)]
        public string Languagenamecode_04 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [Pos(5)]
        public string Versionidentifier_05 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [Pos(6)]
        public string Revisionidentifier_06 { get; set; }
    }
    
    /// <summary>
    /// CURRENCY DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C504")]
    public class C504
    {
        
        /// <summary>
        /// Currency usage code qualifier
        /// </summary>
        [Pos(1)]
        public string Currencyusagecodequalifier_01 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [Pos(2)]
        public string Currencyidentificationcode_02 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [Pos(3)]
        public string Currencytypecodequalifier_03 { get; set; }
        /// <summary>
        /// Currency rate
        /// </summary>
        [Pos(4)]
        public string Currencyrate_04 { get; set; }
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
        /// Reference version identifier
        /// </summary>
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
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
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [Composite("C516")]
    public class C516
    {
        
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C517")]
    public class C517
    {
        
        /// <summary>
        /// Location name code
        /// </summary>
        [Pos(1)]
        public string Locationnamecode_01 { get; set; }
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
        /// First related location name code
        /// </summary>
        [Pos(1)]
        public string Firstrelatedlocationnamecode_01 { get; set; }
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
        /// Handling instruction description code
        /// </summary>
        [Pos(1)]
        public string Handlinginstructiondescriptioncode_01 { get; set; }
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
        /// Handling instruction description
        /// </summary>
        [Pos(4)]
        public string Handlinginstructiondescription_04 { get; set; }
    }
    
    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C531")]
    public class C531
    {
        
        /// <summary>
        /// Packaging level code
        /// </summary>
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions code
        /// </summary>
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    /// <summary>
    /// RETURNABLE PACKAGE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C532")]
    public class C532
    {
        
        /// <summary>
        /// Returnable package freight payment responsibility code
        /// </summary>
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycode_01 { get; set; }
        /// <summary>
        /// Returnable package load contents code
        /// </summary>
        [Pos(2)]
        public string Returnablepackageloadcontentscode_02 { get; set; }
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
        /// Second related location name code
        /// </summary>
        [Pos(1)]
        public string Secondrelatedlocationnamecode_01 { get; set; }
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
    /// COUNTRY SUB-ENTITY DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C819")]
    public class C819
    {
        
        /// <summary>
        /// Country sub-entity name code
        /// </summary>
        [Pos(1)]
        public string Countrysubentitynamecode_01 { get; set; }
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
        /// Country sub-entity name
        /// </summary>
        [Pos(4)]
        public string Countrysubentityname_04 { get; set; }
    }
    
    /// <summary>
    /// TYPE OF MARKING
    /// </summary>
    [Serializable()]
    [Composite("C827")]
    public class C827
    {
        
        /// <summary>
        /// Marking type code
        /// </summary>
        [Pos(1)]
        public string Markingtypecode_01 { get; set; }
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
    /// EMPLOYMENT CATEGORY
    /// </summary>
    [Serializable()]
    [Composite("C948")]
    public class C948
    {

        /// <summary>
        /// Employment category description code
        /// </summary>
        [Pos(1)]
        public string Employmentcategorydescriptioncode_01 { get; set; }
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
        /// Employment category description
        /// </summary>
        [Pos(4)]
        public string Employmentcategorydescription_04 { get; set; }
    }

    /// <summary>
    /// QUALIFICATION CLASSIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C950")]
    public class C950
    {

        /// <summary>
        /// Qualification classification description code
        /// </summary>
        [Pos(1)]
        public string Qualificationclassificationdescriptioncode_01 { get; set; }
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
        /// Qualification classification description
        /// </summary>
        [Pos(4)]
        public string Qualificationclassificationdescription_04 { get; set; }
        /// <summary>
        /// Qualification classification description
        /// </summary>
        [Pos(5)]
        public string Qualificationclassificationdescription_05 { get; set; }
    }

    /// <summary>
    /// OCCUPATION
    /// </summary>
    [Serializable()]
    [Composite("C951")]
    public class C951
    {

        /// <summary>
        /// Occupation description code
        /// </summary>
        [Pos(1)]
        public string Occupationdescriptioncode_01 { get; set; }
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
        /// Occupation description
        /// </summary>
        [Pos(4)]
        public string Occupationdescription_04 { get; set; }
        /// <summary>
        /// Occupation description
        /// </summary>
        [Pos(5)]
        public string Occupationdescription_05 { get; set; }
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
