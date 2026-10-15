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
    // TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C001")]
    public class C001
    {
        
        /// <summary>
        // TRANSPORT MEANS DESCRIPTION CODE
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TRANSPORTMEANSDESCRIPTIONCODE_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Transport means description
        /// </summary>
        [DataMember]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string TransportMeansDescription_04 { get; set; }
    }
    
    /// <summary>
    // DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002
    {
        
        /// <summary>
        // Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(1)]
        public string DocumentNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Document name
        /// </summary>
        [DataMember]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DocumentName_04 { get; set; }
    }
    
    /// <summary>
    // EVENT CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C004")]
    public class C004
    {
        
        /// <summary>
        // Event category description code
        /// </summary>
        [DataMember]
        [DataElement("9637", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EventCategoryDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Event category description
        /// </summary>
        [DataMember]
        [DataElement("9636", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string EventCategoryDescription_04 { get; set; }
    }
    
    /// <summary>
    // MONETARY AMOUNT FUNCTION DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C008")]
    public class C008
    {
        
        /// <summary>
        // Monetary amount function detail description code
        /// </summary>
        [DataMember]
        [DataElement("5105", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MonetaryAmountFunctionDetailDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Monetary amount function detail description
        /// </summary>
        [DataMember]
        [DataElement("5104", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MonetaryAmountFunctionDetailDescription_04 { get; set; }
    }
    
    /// <summary>
    // INFORMATION CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C009")]
    public class C009
    {
        
        /// <summary>
        // Information category description code
        /// </summary>
        [DataMember]
        [DataElement("9615", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InformationCategoryDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Information category description
        /// </summary>
        [DataMember]
        [DataElement("9614", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string InformationCategoryDescription_04 { get; set; }
    }
    
    /// <summary>
    // INFORMATION TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C010")]
    public class C010
    {
        
        /// <summary>
        // Information type code
        /// </summary>
        [DataMember]
        [DataElement("4473", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InformationTypeCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Information type
        /// </summary>
        [DataMember]
        [DataElement("4472", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string InformationType_04 { get; set; }
    }
    
    /// <summary>
    // INFORMATION DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C011")]
    public class C011
    {
        
        /// <summary>
        // Information detail description code
        /// </summary>
        [DataMember]
        [DataElement("9617", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InformationDetailDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Information detail description
        /// </summary>
        [DataMember]
        [DataElement("9616", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string InformationDetailDescription_04 { get; set; }
    }
    
    /// <summary>
    // PROCESSING INDICATOR
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C012")]
    public class C012
    {
        
        /// <summary>
        // Processing indicator description code
        /// </summary>
        [DataMember]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ProcessingIndicatorDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Processing indicator description
        /// </summary>
        [DataMember]
        [DataElement("7364", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ProcessingIndicatorDescription_04 { get; set; }
    }
    
    /// <summary>
    // PAYMENT TERMS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C019")]
    public class C019
    {
        
        /// <summary>
        // Payment terms description identifier
        /// </summary>
        [DataMember]
        [DataElement("4277", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PaymentTermsDescriptionIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Payment terms description
        /// </summary>
        [DataMember]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PaymentTermsDescription_04 { get; set; }
    }
    
    /// <summary>
    // EVENT TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C030")]
    public class C030
    {
        
        /// <summary>
        // Event type description code
        /// </summary>
        [DataMember]
        [DataElement("9171", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EventTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Event type description
        /// </summary>
        [DataMember]
        [DataElement("9170", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string EventTypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // CARRIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040
    {
        
        /// <summary>
        // Carrier identifier
        /// </summary>
        [DataMember]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public string CarrierIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Carrier name
        /// </summary>
        [DataMember]
        [DataElement("3126", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string CarrierName_04 { get; set; }
    }
    
    /// <summary>
    // NATIONALITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C042")]
    public class C042
    {
        
        /// <summary>
        // Nationality name code
        /// </summary>
        [DataMember]
        [DataElement("3293", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string NationalityNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Nationality name
        /// </summary>
        [DataMember]
        [DataElement("3292", typeof(EDIFACT_A))]
        [Pos(4)]
        public string NationalityName_04 { get; set; }
    }
    
    /// <summary>
    // BILL LEVEL IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C045")]
    public class C045
    {
        
        /// <summary>
        // Level one identifier
        /// </summary>
        [DataMember]
        [DataElement("7436", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string LevelOneIdentifier_01 { get; set; }
        /// <summary>
        // Level two identifier
        /// </summary>
        [DataMember]
        [DataElement("7438", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string LevelTwoIdentifier_02 { get; set; }
        /// <summary>
        // Level three identifier
        /// </summary>
        [DataMember]
        [DataElement("7440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string LevelThreeIdentifier_03 { get; set; }
        /// <summary>
        // Level four identifier
        /// </summary>
        [DataMember]
        [DataElement("7442", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string LevelFourIdentifier_04 { get; set; }
        /// <summary>
        // Level five identifier
        /// </summary>
        [DataMember]
        [DataElement("7444", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string LevelFiveIdentifier_05 { get; set; }
        /// <summary>
        // Level six identifier
        /// </summary>
        [DataMember]
        [DataElement("7446", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string LevelSixIdentifier_06 { get; set; }
    }
    
    /// <summary>
    // REMUNERATION TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C049")]
    public class C049
    {
        
        /// <summary>
        // Remuneration type name code
        /// </summary>
        [DataMember]
        [DataElement("5315", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RemunerationTypeNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Remuneration type name
        /// </summary>
        [DataMember]
        [DataElement("5314", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string RemunerationTypeName_04 { get; set; }
        /// <summary>
        // Remuneration type name
        /// </summary>
        [DataMember]
        [DataElement("5314", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string RemunerationTypeName_05 { get; set; }
    }
    
    /// <summary>
    // CONTACT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C056")]
    public class C056
    {
        
        /// <summary>
        // Contact identifier
        /// </summary>
        [DataMember]
        [DataElement("3413", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ContactIdentifier_01 { get; set; }
        /// <summary>
        // Contact name
        /// </summary>
        [DataMember]
        [DataElement("3412", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ContactName_02 { get; set; }
    }
    
    /// <summary>
    // NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C058")]
    public class C058
    {
        
        /// <summary>
        // Name and address description
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string NameAndAddressDescription_01 { get; set; }
        /// <summary>
        // Name and address description
        /// </summary>
        [DataMember]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string NameAndAddressDescription_02 { get; set; }
        /// <summary>
        // Name and address description
        /// </summary>
        [DataMember]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string NameAndAddressDescription_03 { get; set; }
        /// <summary>
        // Name and address description
        /// </summary>
        [DataMember]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string NameAndAddressDescription_04 { get; set; }
        /// <summary>
        // Name and address description
        /// </summary>
        [DataMember]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string NameAndAddressDescription_05 { get; set; }
    }
    
    /// <summary>
    // STREET
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C059")]
    public class C059
    {
        
        /// <summary>
        // Street and number or post office box identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string StreetAndNumberOrPostOfficeBoxIdentifier_01 { get; set; }
        /// <summary>
        // Street and number or post office box identifier
        /// </summary>
        [DataMember]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string StreetAndNumberOrPostOfficeBoxIdentifier_02 { get; set; }
        /// <summary>
        // Street and number or post office box identifier
        /// </summary>
        [DataMember]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string StreetAndNumberOrPostOfficeBoxIdentifier_03 { get; set; }
        /// <summary>
        // Street and number or post office box identifier
        /// </summary>
        [DataMember]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string StreetAndNumberOrPostOfficeBoxIdentifier_04 { get; set; }
    }
    
    /// <summary>
    // EVENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C063")]
    public class C063
    {
        
        /// <summary>
        // Event description code
        /// </summary>
        [DataMember]
        [DataElement("9173", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EventDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Event
        /// </summary>
        [DataMember]
        [DataElement("9172", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Event_04 { get; set; }
    }
    
    /// <summary>
    // COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C076")]
    public class C076
    {
        
        /// <summary>
        // Communication address identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CommunicationAddressIdentifier_01 { get; set; }
        /// <summary>
        // Communication means type code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155))]
        [Pos(2)]
        public string CommunicationMeansTypeCode_02 { get; set; }
    }
    
    /// <summary>
    // FILE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C077")]
    public class C077
    {
        
        /// <summary>
        // File name
        /// </summary>
        [DataMember]
        [DataElement("1508", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FileName_01 { get; set; }
        /// <summary>
        // Item description
        /// </summary>
        [DataMember]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ItemDescription_02 { get; set; }
    }
    
    /// <summary>
    // ACCOUNT HOLDER IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C078")]
    public class C078
    {
        
        /// <summary>
        // Account holder identifier
        /// </summary>
        [DataMember]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AccountHolderIdentifier_01 { get; set; }
        /// <summary>
        // Account holder name
        /// </summary>
        [DataMember]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string AccountHolderName_02 { get; set; }
        /// <summary>
        // Account holder name
        /// </summary>
        [DataMember]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string AccountHolderName_03 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(4)]
        public string CurrencyIdentificationCode_04 { get; set; }
    }
    
    /// <summary>
    // COMPUTER ENVIRONMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C079")]
    public class C079
    {
        
        /// <summary>
        // Computer environment name code
        /// </summary>
        [DataMember]
        [DataElement("1511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ComputerEnvironmentNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Computer environment name
        /// </summary>
        [DataMember]
        [DataElement("1510", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ComputerEnvironmentName_04 { get; set; }
        /// <summary>
        // VERSION IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string VERSIONIDENTIFIER_05 { get; set; }
        /// <summary>
        // Release identifier
        /// </summary>
        [DataMember]
        [DataElement("1058", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string ReleaseIdentifier_06 { get; set; }
        /// <summary>
        // Object identifier
        /// </summary>
        [DataMember]
        [DataElement("7402", typeof(EDIFACT_ID_7402))]
        [Pos(7)]
        public string ObjectIdentifier_07 { get; set; }
    }
    
    /// <summary>
    // PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C080")]
    public class C080
    {
        
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PartyName_01 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PartyName_02 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string PartyName_03 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PartyName_04 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string PartyName_05 { get; set; }
        /// <summary>
        // Party name format code
        /// </summary>
        [DataMember]
        [DataElement("3045", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string PartyNameFormatCode_06 { get; set; }
    }
    
    /// <summary>
    // PARTY IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C082")]
    public class C082
    {
        
        /// <summary>
        // Party identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3039", typeof(EDIFACT_ID_3039))]
        [Pos(1)]
        public string PartyIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // MARITAL STATUS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C085")]
    public class C085
    {
        
        /// <summary>
        // Marital status description code
        /// </summary>
        [DataMember]
        [DataElement("3479", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MaritalStatusDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Marital status description
        /// </summary>
        [DataMember]
        [DataElement("3478", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MaritalStatusDescription_04 { get; set; }
    }
    
    /// <summary>
    // INSTITUTION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C088")]
    public class C088
    {
        
        /// <summary>
        // Institution name code
        /// </summary>
        [DataMember]
        [DataElement("3433", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InstitutionNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Institution branch identifier
        /// </summary>
        [DataMember]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string InstitutionBranchIdentifier_04 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string CodeListIdentificationCode_05 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string CodeListResponsibleAgencyCode_06 { get; set; }
        /// <summary>
        // Institution name
        /// </summary>
        [DataMember]
        [DataElement("3432", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string InstitutionName_07 { get; set; }
        /// <summary>
        // Institution branch location name
        /// </summary>
        [DataMember]
        [DataElement("3436", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string InstitutionBranchLocationName_08 { get; set; }
    }
    
    /// <summary>
    // ADDRESS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C090")]
    public class C090
    {
        
        /// <summary>
        // Address format code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3477", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AddressFormatCode_01 { get; set; }
        /// <summary>
        // Address component description
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string AddressComponentDescription_02 { get; set; }
        /// <summary>
        // Address component description
        /// </summary>
        [DataMember]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string AddressComponentDescription_03 { get; set; }
        /// <summary>
        // Address component description
        /// </summary>
        [DataMember]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string AddressComponentDescription_04 { get; set; }
        /// <summary>
        // Address component description
        /// </summary>
        [DataMember]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string AddressComponentDescription_05 { get; set; }
        /// <summary>
        // Address component description
        /// </summary>
        [DataMember]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string AddressComponentDescription_06 { get; set; }
    }
    
    /// <summary>
    // FILE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C099")]
    public class C099
    {
        
        /// <summary>
        // File format name
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1516", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FileFormatName_01 { get; set; }
        /// <summary>
        // VERSION IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string VERSIONIDENTIFIER_02 { get; set; }
        /// <summary>
        // Data format description code
        /// </summary>
        [DataMember]
        [DataElement("1503", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DataFormatDescriptionCode_03 { get; set; }
        /// <summary>
        // Data format description
        /// </summary>
        [DataMember]
        [DataElement("1502", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DataFormatDescription_04 { get; set; }
    }
    
    /// <summary>
    // TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C100")]
    public class C100
    {
        
        /// <summary>
        // Delivery or transport terms description code
        /// </summary>
        [DataMember]
        [DataElement("4053", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DeliveryOrTransportTermsDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Delivery or transport terms description
        /// </summary>
        [DataMember]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DeliveryOrTransportTermsDescription_04 { get; set; }
        /// <summary>
        // Delivery or transport terms description
        /// </summary>
        [DataMember]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string DeliveryOrTransportTermsDescription_05 { get; set; }
    }
    
    /// <summary>
    // RELIGION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C101")]
    public class C101
    {
        
        /// <summary>
        // Religion name code
        /// </summary>
        [DataMember]
        [DataElement("3483", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ReligionNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Religion name
        /// </summary>
        [DataMember]
        [DataElement("3482", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ReligionName_04 { get; set; }
    }
    
    /// <summary>
    // DOCUMENT/MESSAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C106")]
    public class C106
    {
        
        /// <summary>
        // Document identifier
        /// </summary>
        [DataMember]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DocumentIdentifier_01 { get; set; }
        /// <summary>
        // VERSION IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string VERSIONIDENTIFIER_02 { get; set; }
        /// <summary>
        // Revision identifier
        /// </summary>
        [DataMember]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string RevisionIdentifier_03 { get; set; }
    }
    
    /// <summary>
    // TEXT REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C107")]
    public class C107
    {
        
        /// <summary>
        // Free text description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4441", typeof(EDIFACT_ID_4441))]
        [Pos(1)]
        public string FreeTextDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // TEXT LITERAL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C108")]
    public class C108
    {
        
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FreeText_01 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string FreeText_02 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string FreeText_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string FreeText_04 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string FreeText_05 { get; set; }
    }
    
    /// <summary>
    // RATE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C128")]
    public class C128
    {
        
        /// <summary>
        // Rate type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5419", typeof(EDIFACT_ID_5419))]
        [Pos(1)]
        public string RateTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // Unit price basis rate
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5420", typeof(EDIFACT_N))]
        [Pos(2)]
        public string UnitPriceBasisRate_02 { get; set; }
        /// <summary>
        // Unit price basis quantity
        /// </summary>
        [DataMember]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(3)]
        public string UnitPriceBasisQuantity_03 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(4)]
        public string MeasurementUnitCode_04 { get; set; }
    }
    
    /// <summary>
    // PRICE MULTIPLIER INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C138")]
    public class C138
    {
        
        /// <summary>
        // Price multiplier rate
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5394", typeof(EDIFACT_N))]
        [Pos(1)]
        public string PriceMultiplierRate_01 { get; set; }
        /// <summary>
        // Price multiplier type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("5393", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PriceMultiplierTypeCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // VALUE/RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C174")]
    public class C174
    {
        
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public string MeasurementUnitCode_01 { get; set; }
        /// <summary>
        // Measure
        /// </summary>
        [DataMember]
        [DataElement("6314", typeof(EDIFACT_ID_6314))]
        [Pos(2)]
        public string Measure_02 { get; set; }
        /// <summary>
        // Range minimum quantity
        /// </summary>
        [DataMember]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string RangeMinimumQuantity_03 { get; set; }
        /// <summary>
        // Range maximum quantity
        /// </summary>
        [DataMember]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string RangeMaximumQuantity_04 { get; set; }
        /// <summary>
        // SIGNIFICANT DIGITS QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string SIGNIFICANTDIGITSQUANTITY_05 { get; set; }
    }
    
    /// <summary>
    // QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186
    {
        
        /// <summary>
        // QUANTITY TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string QUANTITYTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string QUANTITY_02 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string MeasurementUnitCode_03 { get; set; }
    }
    
    /// <summary>
    // CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C200")]
    public class C200
    {
        
        /// <summary>
        // Freight and other charges description identifier
        /// </summary>
        [DataMember]
        [DataElement("8023", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FreightAndOtherChargesDescriptionIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Freight and other charges description
        /// </summary>
        [DataMember]
        [DataElement("8022", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string FreightAndOtherChargesDescription_04 { get; set; }
        /// <summary>
        // Payment arrangement code
        /// </summary>
        [DataMember]
        [DataElement("4237", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string PaymentArrangementCode_05 { get; set; }
        /// <summary>
        // Item identifier
        /// </summary>
        [DataMember]
        [DataElement("7140", typeof(EDIFACT_ID_7140))]
        [Pos(6)]
        public string ItemIdentifier_06 { get; set; }
    }
    
    /// <summary>
    // PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C202")]
    public class C202
    {
        
        /// <summary>
        // Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PackageTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Type of packages
        /// </summary>
        [DataMember]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string TypeOfPackages_04 { get; set; }
    }
    
    /// <summary>
    // RATE/TARIFF CLASS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C203")]
    public class C203
    {
        
        /// <summary>
        // Rate or tariff class description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5243", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RateOrTariffClassDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Rate or tariff class description
        /// </summary>
        [DataMember]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string RateOrTariffClassDescription_04 { get; set; }
        /// <summary>
        // Supplementary rate or tariff code
        /// </summary>
        [DataMember]
        [DataElement("5275", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string SupplementaryRateOrTariffCode_05 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string CodeListIdentificationCode_06 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string CodeListResponsibleAgencyCode_07 { get; set; }
        /// <summary>
        // Supplementary rate or tariff code
        /// </summary>
        [DataMember]
        [DataElement("5275", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string SupplementaryRateOrTariffCode_08 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(9)]
        public string CodeListIdentificationCode_09 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(10)]
        public string CodeListResponsibleAgencyCode_10 { get; set; }
    }
    
    /// <summary>
    // HAZARD CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C205")]
    public class C205
    {
        
        /// <summary>
        // Hazard identification code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8351", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string HazardIdentificationCode_01 { get; set; }
        /// <summary>
        // Additional hazard classification identifier
        /// </summary>
        [DataMember]
        [DataElement("8078", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string AdditionalHazardClassificationIdentifier_02 { get; set; }
        /// <summary>
        // Hazard code version identifier
        /// </summary>
        [DataMember]
        [DataElement("8092", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string HazardCodeVersionIdentifier_03 { get; set; }
    }
    
    /// <summary>
    // IDENTIFICATION NUMBER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C206")]
    public class C206
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
        // Object identification code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ObjectIdentificationCodeQualifier_02 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string StatusDescriptionCode_03 { get; set; }
    }
    
    /// <summary>
    // IDENTITY NUMBER RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C208")]
    public class C208
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
        // Object identifier
        /// </summary>
        [DataMember]
        [DataElement("7402", typeof(EDIFACT_ID_7402))]
        [Pos(2)]
        public string ObjectIdentifier_02 { get; set; }
    }
    
    /// <summary>
    // MARKS & LABELS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C210")]
    public class C210
    {
        
        /// <summary>
        // Shipping marks description
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ShippingMarksDescription_01 { get; set; }
        /// <summary>
        // Shipping marks description
        /// </summary>
        [DataMember]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ShippingMarksDescription_02 { get; set; }
        /// <summary>
        // Shipping marks description
        /// </summary>
        [DataMember]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ShippingMarksDescription_03 { get; set; }
        /// <summary>
        // Shipping marks description
        /// </summary>
        [DataMember]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ShippingMarksDescription_04 { get; set; }
        /// <summary>
        // Shipping marks description
        /// </summary>
        [DataMember]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string ShippingMarksDescription_05 { get; set; }
        /// <summary>
        // Shipping marks description
        /// </summary>
        [DataMember]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string ShippingMarksDescription_06 { get; set; }
        /// <summary>
        // Shipping marks description
        /// </summary>
        [DataMember]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string ShippingMarksDescription_07 { get; set; }
        /// <summary>
        // Shipping marks description
        /// </summary>
        [DataMember]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string ShippingMarksDescription_08 { get; set; }
        /// <summary>
        // Shipping marks description
        /// </summary>
        [DataMember]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string ShippingMarksDescription_09 { get; set; }
        /// <summary>
        // Shipping marks description
        /// </summary>
        [DataMember]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string ShippingMarksDescription_10 { get; set; }
    }
    
    /// <summary>
    // DIMENSIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C211")]
    public class C211
    {
        
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public string MeasurementUnitCode_01 { get; set; }
        /// <summary>
        // Length measure
        /// </summary>
        [DataMember]
        [DataElement("6168", typeof(EDIFACT_N))]
        [Pos(2)]
        public string LengthMeasure_02 { get; set; }
        /// <summary>
        // Width measure
        /// </summary>
        [DataMember]
        [DataElement("6140", typeof(EDIFACT_N))]
        [Pos(3)]
        public string WidthMeasure_03 { get; set; }
        /// <summary>
        // Height measure
        /// </summary>
        [DataMember]
        [DataElement("6008", typeof(EDIFACT_N))]
        [Pos(4)]
        public string HeightMeasure_04 { get; set; }
    }
    
    /// <summary>
    // ITEM NUMBER IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C212")]
    public class C212
    {
        
        /// <summary>
        // Item identifier
        /// </summary>
        [DataMember]
        [DataElement("7140", typeof(EDIFACT_ID_7140))]
        [Pos(1)]
        public string ItemIdentifier_01 { get; set; }
        /// <summary>
        // Item type identification code
        /// </summary>
        [DataMember]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string ItemTypeIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string CodeListIdentificationCode_03 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string CodeListResponsibleAgencyCode_04 { get; set; }
    }
    
    /// <summary>
    // NUMBER AND TYPE OF PACKAGES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C213")]
    public class C213
    {
        
        /// <summary>
        // PACKAGE QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string PACKAGEQUANTITY_01 { get; set; }
        /// <summary>
        // Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PackageTypeDescriptionCode_02 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string CodeListIdentificationCode_03 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string CodeListResponsibleAgencyCode_04 { get; set; }
        /// <summary>
        // Type of packages
        /// </summary>
        [DataMember]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string TypeOfPackages_05 { get; set; }
        /// <summary>
        // Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string PackagingRelatedDescriptionCode_06 { get; set; }
    }
    
    /// <summary>
    // SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C214")]
    public class C214
    {
        
        /// <summary>
        // Special service description code
        /// </summary>
        [DataMember]
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public string SpecialServiceDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Special service description
        /// </summary>
        [DataMember]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string SpecialServiceDescription_04 { get; set; }
        /// <summary>
        // Special service description
        /// </summary>
        [DataMember]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string SpecialServiceDescription_05 { get; set; }
    }
    
    /// <summary>
    // SEAL ISSUER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C215")]
    public class C215
    {
        
        /// <summary>
        // Sealing party name code
        /// </summary>
        [DataMember]
        [DataElement("9303", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SealingPartyNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Sealing party name
        /// </summary>
        [DataMember]
        [DataElement("9302", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string SealingPartyName_04 { get; set; }
    }
    
    /// <summary>
    // HAZARDOUS MATERIAL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C218")]
    public class C218
    {
        
        /// <summary>
        // Hazardous material category name code
        /// </summary>
        [DataMember]
        [DataElement("7419", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string HazardousMaterialCategoryNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Hazardous material category name
        /// </summary>
        [DataMember]
        [DataElement("7418", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string HazardousMaterialCategoryName_04 { get; set; }
    }
    
    /// <summary>
    // MOVEMENT TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C219")]
    public class C219
    {
        
        /// <summary>
        // Movement type description code
        /// </summary>
        [DataMember]
        [DataElement("8335", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MovementTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Movement type description
        /// </summary>
        [DataMember]
        [DataElement("8334", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MovementTypeDescription_02 { get; set; }
    }
    
    /// <summary>
    // MODE OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C220")]
    public class C220
    {
        
        /// <summary>
        // Transport mode name code
        /// </summary>
        [DataMember]
        [DataElement("8067", typeof(EDIFACT_ID_8067))]
        [Pos(1)]
        public string TransportModeNameCode_01 { get; set; }
        /// <summary>
        // Transport mode name
        /// </summary>
        [DataMember]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string TransportModeName_02 { get; set; }
    }
    
    /// <summary>
    // TRANSPORT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C222")]
    public class C222
    {
        
        /// <summary>
        // Transport means identification name identifier
        /// </summary>
        [DataMember]
        [DataElement("8213", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TransportMeansIdentificationNameIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Transport means identification name
        /// </summary>
        [DataMember]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string TransportMeansIdentificationName_04 { get; set; }
        /// <summary>
        // Transport means nationality code
        /// </summary>
        [DataMember]
        [DataElement("8453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string TransportMeansNationalityCode_05 { get; set; }
    }
    
    /// <summary>
    // DANGEROUS GOODS SHIPMENT FLASHPOINT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C223")]
    public class C223
    {
        
        /// <summary>
        // Shipment flashpoint degree
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("7106", typeof(EDIFACT_N))]
        [Pos(1)]
        public string ShipmentFlashpointDegree_01 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(2)]
        public string MeasurementUnitCode_02 { get; set; }
    }
    
    /// <summary>
    // EQUIPMENT SIZE AND TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C224")]
    public class C224
    {
        
        /// <summary>
        // Equipment size and type description code
        /// </summary>
        [DataMember]
        [DataElement("8155", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EquipmentSizeAndTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Equipment size and type description
        /// </summary>
        [DataMember]
        [DataElement("8154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string EquipmentSizeAndTypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // CHARGE CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C229")]
    public class C229
    {
        
        /// <summary>
        // Charge category code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5237", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ChargeCategoryCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // METHOD OF PAYMENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C231")]
    public class C231
    {
        
        /// <summary>
        // Transport charges payment method code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4215", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TransportChargesPaymentMethodCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // GOVERNMENT ACTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C232")]
    public class C232
    {
        
        /// <summary>
        // Government agency identification code
        /// </summary>
        [DataMember]
        [DataElement("9415", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string GovernmentAgencyIdentificationCode_01 { get; set; }
        /// <summary>
        // Government involvement code
        /// </summary>
        [DataMember]
        [DataElement("9411", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string GovernmentInvolvementCode_02 { get; set; }
        /// <summary>
        // Government action code
        /// </summary>
        [DataMember]
        [DataElement("9417", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string GovernmentActionCode_03 { get; set; }
        /// <summary>
        // Government procedure code
        /// </summary>
        [DataMember]
        [DataElement("9353", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string GovernmentProcedureCode_04 { get; set; }
    }
    
    /// <summary>
    // SERVICE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C233")]
    public class C233
    {
        
        /// <summary>
        // Service requirement code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7273", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ServiceRequirementCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Service requirement code
        /// </summary>
        [DataMember]
        [DataElement("7273", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ServiceRequirementCode_04 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string CodeListIdentificationCode_05 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string CodeListResponsibleAgencyCode_06 { get; set; }
    }
    
    /// <summary>
    // UNDG INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C234")]
    public class C234
    {
        
        /// <summary>
        // United Nations Dangerous Goods (UNDG) identifier
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("7124", typeof(EDIFACT_N))]
        [Pos(1)]
        public string UnitedNationsDangerousGoods_01 { get; set; }
        /// <summary>
        // Dangerous goods flashpoint description
        /// </summary>
        [DataMember]
        [DataElement("7088", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DangerousGoodsFlashpointDescription_02 { get; set; }
    }
    
    /// <summary>
    // HAZARD IDENTIFICATION PLACARD DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C235")]
    public class C235
    {
        
        /// <summary>
        // Orange hazard placard upper part identifier
        /// </summary>
        [DataMember]
        [DataElement("8158", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string OrangeHazardPlacardUpperPartIdentifier_01 { get; set; }
        /// <summary>
        // Orange hazard placard lower part identifier
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("8186", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string OrangeHazardPlacardLowerPartIdentifier_02 { get; set; }
    }
    
    /// <summary>
    // DANGEROUS GOODS LABEL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C236")]
    public class C236
    {
        
        /// <summary>
        // Dangerous goods marking identifier
        /// </summary>
        [DataMember]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DangerousGoodsMarkingIdentifier_01 { get; set; }
        /// <summary>
        // Dangerous goods marking identifier
        /// </summary>
        [DataMember]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DangerousGoodsMarkingIdentifier_02 { get; set; }
        /// <summary>
        // Dangerous goods marking identifier
        /// </summary>
        [DataMember]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DangerousGoodsMarkingIdentifier_03 { get; set; }
    }
    
    /// <summary>
    // EQUIPMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C237")]
    public class C237
    {
        
        /// <summary>
        // Equipment identifier
        /// </summary>
        [DataMember]
        [DataElement("8260", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EquipmentIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string COUNTRYIDENTIFIER_04 { get; set; }
    }
    
    /// <summary>
    // TEMPERATURE SETTING
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C239")]
    public class C239
    {
        
        /// <summary>
        // Temperature degree
        /// </summary>
        [DataMember]
        [DataElement("6246", typeof(EDIFACT_N))]
        [Pos(1)]
        public string TemperatureDegree_01 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(2)]
        public string MeasurementUnitCode_02 { get; set; }
    }
    
    /// <summary>
    // CHARACTERISTIC DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C240")]
    public class C240
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
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Characteristic description
        /// </summary>
        [DataMember]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string CharacteristicDescription_04 { get; set; }
        /// <summary>
        // Characteristic description
        /// </summary>
        [DataMember]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string CharacteristicDescription_05 { get; set; }
    }
    
    /// <summary>
    // DUTY/TAX/FEE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C241")]
    public class C241
    {
        
        /// <summary>
        // Duty or tax or fee type name code
        /// </summary>
        [DataMember]
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string DutyOrTaxOrFeeTypeNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Duty or tax or fee type name
        /// </summary>
        [DataMember]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DutyOrTaxOrFeeTypeName_04 { get; set; }
    }
    
    /// <summary>
    // PROCESS TYPE AND DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C242")]
    public class C242
    {
        
        /// <summary>
        // Process type description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7187", typeof(EDIFACT_ID_7187))]
        [Pos(1)]
        public string ProcessTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Process type description
        /// </summary>
        [DataMember]
        [DataElement("7186", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ProcessTypeDescription_04 { get; set; }
        /// <summary>
        // Process type description
        /// </summary>
        [DataMember]
        [DataElement("7186", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string ProcessTypeDescription_05 { get; set; }
    }
    
    /// <summary>
    // DUTY/TAX/FEE DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C243")]
    public class C243
    {
        
        /// <summary>
        // Duty or tax or fee rate code
        /// </summary>
        [DataMember]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DutyOrTaxOrFeeRateCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Duty or tax or fee rate
        /// </summary>
        [DataMember]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DutyOrTaxOrFeeRate_04 { get; set; }
        /// <summary>
        // Duty or tax or fee rate basis code
        /// </summary>
        [DataMember]
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string DutyOrTaxOrFeeRateBasisCode_05 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string CodeListIdentificationCode_06 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string CodeListResponsibleAgencyCode_07 { get; set; }
    }
    
    /// <summary>
    // TEST METHOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C244")]
    public class C244
    {
        
        /// <summary>
        // Test method identifier
        /// </summary>
        [DataMember]
        [DataElement("4415", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TestMethodIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Test description
        /// </summary>
        [DataMember]
        [DataElement("4416", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string TestDescription_04 { get; set; }
    }
    
    /// <summary>
    // CUSTOMS IDENTITY CODES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C246")]
    public class C246
    {
        
        /// <summary>
        // Customs goods identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7361", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CustomsGoodsIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270
    {
        
        /// <summary>
        // Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069))]
        [Pos(1)]
        public string ControlTotalTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // Control total quantity
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string ControlTotalQuantity_02 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string MeasurementUnitCode_03 { get; set; }
    }
    
    /// <summary>
    // ITEM CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C272")]
    public class C272
    {
        
        /// <summary>
        // Item characteristic code
        /// </summary>
        [DataMember]
        [DataElement("7081", typeof(EDIFACT_ID_7081))]
        [Pos(1)]
        public string ItemCharacteristicCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C273")]
    public class C273
    {
        
        /// <summary>
        // Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(1)]
        public string ItemDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Item description
        /// </summary>
        [DataMember]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ItemDescription_04 { get; set; }
        /// <summary>
        // Item description
        /// </summary>
        [DataMember]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string ItemDescription_05 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string LANGUAGENAMECODE_06 { get; set; }
    }
    
    /// <summary>
    // QUANTITY DIFFERENCE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C279")]
    public class C279
    {
        
        /// <summary>
        // Variance quantity
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string VarianceQuantity_01 { get; set; }
        /// <summary>
        // QUANTITY TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(2)]
        public string QUANTITYTYPECODEQUALIFIER_02 { get; set; }
    }
    
    /// <summary>
    // RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C280")]
    public class C280
    {
        
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public string MeasurementUnitCode_01 { get; set; }
        /// <summary>
        // Range minimum quantity
        /// </summary>
        [DataMember]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(2)]
        public string RangeMinimumQuantity_02 { get; set; }
        /// <summary>
        // Range maximum quantity
        /// </summary>
        [DataMember]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(3)]
        public string RangeMaximumQuantity_03 { get; set; }
    }
    
    /// <summary>
    // SEQUENCE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C286")]
    public class C286
    {
        
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(1)]
        public string SequencePositionIdentifier_01 { get; set; }
        /// <summary>
        // Sequence identifier source code
        /// </summary>
        [DataMember]
        [DataElement("1159", typeof(EDIFACT_ID_1159))]
        [Pos(2)]
        public string SequenceIdentifierSourceCode_02 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string CodeListIdentificationCode_03 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string CodeListResponsibleAgencyCode_04 { get; set; }
    }
    
    /// <summary>
    // PRODUCT GROUP
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C288")]
    public class C288
    {
        
        /// <summary>
        // Product group name code
        /// </summary>
        [DataMember]
        [DataElement("5389", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ProductGroupNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Product group name
        /// </summary>
        [DataMember]
        [DataElement("5388", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ProductGroupName_04 { get; set; }
    }
    
    /// <summary>
    // PATTERN DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C329")]
    public class C329
    {
        
        /// <summary>
        // Frequency code
        /// </summary>
        [DataMember]
        [DataElement("2013", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FrequencyCode_01 { get; set; }
        /// <summary>
        // Despatch pattern code
        /// </summary>
        [DataMember]
        [DataElement("2015", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DespatchPatternCode_02 { get; set; }
        /// <summary>
        // Despatch pattern timing code
        /// </summary>
        [DataMember]
        [DataElement("2017", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DespatchPatternTimingCode_03 { get; set; }
    }
    
    /// <summary>
    // INSURANCE COVER TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C330")]
    public class C330
    {
        
        /// <summary>
        // INSURANCE COVER TYPE CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4497", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string INSURANCECOVERTYPECODE_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // INSURANCE COVER DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C331")]
    public class C331
    {
        
        /// <summary>
        // Insurance cover description code
        /// </summary>
        [DataMember]
        [DataElement("4495", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InsuranceCoverDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Insurance cover description
        /// </summary>
        [DataMember]
        [DataElement("4494", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string InsuranceCoverDescription_04 { get; set; }
        /// <summary>
        // Insurance cover description
        /// </summary>
        [DataMember]
        [DataElement("4494", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string InsuranceCoverDescription_05 { get; set; }
    }
    
    /// <summary>
    // SALES CHANNEL IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C332")]
    public class C332
    {
        
        /// <summary>
        // Sales channel identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3496", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SalesChannelIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // INFORMATION REQUEST
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C333")]
    public class C333
    {
        
        /// <summary>
        // Requested information description code
        /// </summary>
        [DataMember]
        [DataElement("4511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RequestedInformationDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Requested information description
        /// </summary>
        [DataMember]
        [DataElement("4510", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string RequestedInformationDescription_04 { get; set; }
    }
    
    /// <summary>
    // EXCESS TRANSPORTATION INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C401")]
    public class C401
    {
        
        /// <summary>
        // Excess transportation reason code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8457", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ExcessTransportationReasonCode_01 { get; set; }
        /// <summary>
        // Excess transportation responsibility code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8459", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ExcessTransportationResponsibilityCode_02 { get; set; }
        /// <summary>
        // Customer shipment authorisation identifier
        /// </summary>
        [DataMember]
        [DataElement("7130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CustomerShipmentAuthorisationIdentifier_03 { get; set; }
    }
    
    /// <summary>
    // PACKAGE TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C402")]
    public class C402
    {
        
        /// <summary>
        // Description format code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string DescriptionFormatCode_01 { get; set; }
        /// <summary>
        // Type of packages
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string TypeOfPackages_02 { get; set; }
        /// <summary>
        // Item type identification code
        /// </summary>
        [DataMember]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(3)]
        public string ItemTypeIdentificationCode_03 { get; set; }
        /// <summary>
        // Type of packages
        /// </summary>
        [DataMember]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string TypeOfPackages_04 { get; set; }
        /// <summary>
        // Item type identification code
        /// </summary>
        [DataMember]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(5)]
        public string ItemTypeIdentificationCode_05 { get; set; }
    }
    
    /// <summary>
    // PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C501")]
    public class C501
    {
        
        /// <summary>
        // Percentage type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string PercentageTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // PERCENTAGE
        /// </summary>
        [DataMember]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string PERCENTAGE_02 { get; set; }
        /// <summary>
        // Percentage basis identification code
        /// </summary>
        [DataMember]
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string PercentageBasisIdentificationCode_03 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string CodeListIdentificationCode_04 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string CodeListResponsibleAgencyCode_05 { get; set; }
    }
    
    /// <summary>
    // MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502
    {
        
        /// <summary>
        // Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public string MeasuredAttributeCode_01 { get; set; }
        /// <summary>
        // Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string MeasurementSignificanceCode_02 { get; set; }
        /// <summary>
        // Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string NondiscreteMeasurementNameCode_03 { get; set; }
        /// <summary>
        // Non-discrete measurement name
        /// </summary>
        [DataMember]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string NondiscreteMeasurementName_04 { get; set; }
    }
    
    /// <summary>
    // DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C503")]
    public class C503
    {
        
        /// <summary>
        // Document identifier
        /// </summary>
        [DataMember]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DocumentIdentifier_01 { get; set; }
        /// <summary>
        // Document status code
        /// </summary>
        [DataMember]
        [DataElement("1373", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DocumentStatusCode_02 { get; set; }
        /// <summary>
        // Document source description
        /// </summary>
        [DataMember]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DocumentSourceDescription_03 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string LANGUAGENAMECODE_04 { get; set; }
        /// <summary>
        // VERSION IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string VERSIONIDENTIFIER_05 { get; set; }
        /// <summary>
        // Revision identifier
        /// </summary>
        [DataMember]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string RevisionIdentifier_06 { get; set; }
    }
    
    /// <summary>
    // CURRENCY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C504")]
    public class C504
    {
        
        /// <summary>
        // Currency usage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string CurrencyUsageCodeQualifier_01 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(2)]
        public string CurrencyIdentificationCode_02 { get; set; }
        /// <summary>
        // Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string CurrencyTypeCodeQualifier_03 { get; set; }
        /// <summary>
        // Currency rate
        /// </summary>
        [DataMember]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string CurrencyRate_04 { get; set; }
    }
    
    /// <summary>
    // REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506
    {
        
        /// <summary>
        // Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string ReferenceCodeQualifier_01 { get; set; }
        /// <summary>
        // Reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1154", typeof(EDIFACT_ID_1154))]
        [Pos(2)]
        public string ReferenceIdentifier_02 { get; set; }
        /// <summary>
        // Document line identifier
        /// </summary>
        [DataMember]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DocumentLineIdentifier_03 { get; set; }
        /// <summary>
        // VERSION IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string VERSIONIDENTIFIER_04 { get; set; }
        /// <summary>
        // Revision identifier
        /// </summary>
        [DataMember]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string RevisionIdentifier_05 { get; set; }
    }
    
    /// <summary>
    // DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507
    {
        
        /// <summary>
        // Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string DateOrTimeOrPeriodFunctionCodeQualifier_01 { get; set; }
        /// <summary>
        // Date or time or period text
        /// </summary>
        [DataMember]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DateOrTimeOrPeriodText_02 { get; set; }
        /// <summary>
        // Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string DateOrTimeOrPeriodFormatCode_03 { get; set; }
    }
    
    /// <summary>
    // LANGUAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C508")]
    public class C508
    {
        
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string LANGUAGENAMECODE_01 { get; set; }
        /// <summary>
        // Language name
        /// </summary>
        [DataMember]
        [DataElement("3452", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string LanguageName_02 { get; set; }
    }
    
    /// <summary>
    // PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509
    {
        
        /// <summary>
        // Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125))]
        [Pos(1)]
        public string PriceCodeQualifier_01 { get; set; }
        /// <summary>
        // Price amount
        /// </summary>
        [DataMember]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string PriceAmount_02 { get; set; }
        /// <summary>
        // Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375))]
        [Pos(3)]
        public string PriceTypeCode_03 { get; set; }
        /// <summary>
        // Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public string PriceSpecificationCode_04 { get; set; }
        /// <summary>
        // Unit price basis quantity
        /// </summary>
        [DataMember]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string UnitPriceBasisQuantity_05 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string MeasurementUnitCode_06 { get; set; }
    }
    
    /// <summary>
    // SIZE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C512")]
    public class C512
    {
        
        /// <summary>
        // Size type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6173", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SizeTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // Size measure
        /// </summary>
        [DataMember]
        [DataElement("6174", typeof(EDIFACT_N))]
        [Pos(2)]
        public string SizeMeasure_02 { get; set; }
    }
    
    /// <summary>
    // SAMPLE LOCATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C514")]
    public class C514
    {
        
        /// <summary>
        // Sample location description code
        /// </summary>
        [DataMember]
        [DataElement("3237", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SampleLocationDescriptionCode_01 { get; set; }
        /// <summary>
        // Sample location description
        /// </summary>
        [DataMember]
        [DataElement("3236", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string SampleLocationDescription_02 { get; set; }
    }
    
    /// <summary>
    // TEST REASON
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C515")]
    public class C515
    {
        
        /// <summary>
        // Test reason name code
        /// </summary>
        [DataMember]
        [DataElement("4425", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TestReasonNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Test reason name
        /// </summary>
        [DataMember]
        [DataElement("4424", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string TestReasonName_04 { get; set; }
    }
    
    /// <summary>
    // MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516
    {
        
        /// <summary>
        // Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string MonetaryAmountTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string CurrencyIdentificationCode_03 { get; set; }
        /// <summary>
        // Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string CurrencyTypeCodeQualifier_04 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string StatusDescriptionCode_05 { get; set; }
    }
    
    /// <summary>
    // LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C517")]
    public class C517
    {
        
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(1)]
        public string LocationIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Location name
        /// </summary>
        [DataMember]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string LocationName_04 { get; set; }
    }
    
    /// <summary>
    // RELATED LOCATION ONE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C519")]
    public class C519
    {
        
        /// <summary>
        // First related location identifier
        /// </summary>
        [DataMember]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FirstRelatedLocationIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // First related location name
        /// </summary>
        [DataMember]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string FirstRelatedLocationName_04 { get; set; }
    }
    
    /// <summary>
    // BUSINESS FUNCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C521")]
    public class C521
    {
        
        /// <summary>
        // Business function type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4027", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string BusinessFunctionTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // Business function code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4025", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string BusinessFunctionCode_02 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string CodeListIdentificationCode_03 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string CodeListResponsibleAgencyCode_04 { get; set; }
        /// <summary>
        // Business description
        /// </summary>
        [DataMember]
        [DataElement("4022", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string BusinessDescription_05 { get; set; }
    }
    
    /// <summary>
    // INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C522")]
    public class C522
    {
        
        /// <summary>
        // Instruction type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4403", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InstructionTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // Instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4401", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string InstructionDescriptionCode_02 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string CodeListIdentificationCode_03 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string CodeListResponsibleAgencyCode_04 { get; set; }
        /// <summary>
        // Instruction description
        /// </summary>
        [DataMember]
        [DataElement("4400", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string InstructionDescription_05 { get; set; }
    }
    
    /// <summary>
    // NUMBER OF UNIT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C523")]
    public class C523
    {
        
        /// <summary>
        // Units quantity
        /// </summary>
        [DataMember]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(1)]
        public string UnitsQuantity_01 { get; set; }
        /// <summary>
        // Unit type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6353", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string UnitTypeCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C524")]
    public class C524
    {
        
        /// <summary>
        // Handling instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4079", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string HandlingInstructionDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Handling instruction description
        /// </summary>
        [DataMember]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string HandlingInstructionDescription_04 { get; set; }
    }
    
    /// <summary>
    // PURPOSE OF CONVEYANCE CALL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C525")]
    public class C525
    {
        
        /// <summary>
        // Conveyance call purpose description code
        /// </summary>
        [DataMember]
        [DataElement("8025", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ConveyanceCallPurposeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Conveyance call purpose description
        /// </summary>
        [DataMember]
        [DataElement("8024", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ConveyanceCallPurposeDescription_04 { get; set; }
    }
    
    /// <summary>
    // FREQUENCY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C526")]
    public class C526
    {
        
        /// <summary>
        // Frequency code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6071", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FrequencyCodeQualifier_01 { get; set; }
        /// <summary>
        // Frequency rate
        /// </summary>
        [DataMember]
        [DataElement("6072", typeof(EDIFACT_N))]
        [Pos(2)]
        public string FrequencyRate_02 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string MeasurementUnitCode_03 { get; set; }
    }
    
    /// <summary>
    // STATISTICAL DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C527")]
    public class C527
    {
        
        /// <summary>
        // Measure
        /// </summary>
        [DataMember]
        [DataElement("6314", typeof(EDIFACT_ID_6314))]
        [Pos(1)]
        public string Measure_01 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(2)]
        public string MeasurementUnitCode_02 { get; set; }
        /// <summary>
        // Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(3)]
        public string MeasuredAttributeCode_03 { get; set; }
        /// <summary>
        // Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(4)]
        public string MeasurementSignificanceCode_04 { get; set; }
    }
    
    /// <summary>
    // COMMODITY/RATE DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C528")]
    public class C528
    {
        
        /// <summary>
        // Commodity identification code
        /// </summary>
        [DataMember]
        [DataElement("7357", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CommodityIdentificationCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C531")]
    public class C531
    {
        
        /// <summary>
        // Packaging level code
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PackagingLevelCode_01 { get; set; }
        /// <summary>
        // Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PackagingRelatedDescriptionCode_02 { get; set; }
        /// <summary>
        // Packaging terms and conditions code
        /// </summary>
        [DataMember]
        [DataElement("7073", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string PackagingTermsAndConditionsCode_03 { get; set; }
    }
    
    /// <summary>
    // RETURNABLE PACKAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C532")]
    public class C532
    {
        
        /// <summary>
        // Returnable package freight payment responsibility code
        /// </summary>
        [DataMember]
        [DataElement("8395", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ReturnablePackageFreightPaymentResponsibilityCode_01 { get; set; }
        /// <summary>
        // Returnable package load contents code
        /// </summary>
        [DataMember]
        [DataElement("8393", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ReturnablePackageLoadContentsCode_02 { get; set; }
    }
    
    /// <summary>
    // DUTY/TAX/FEE ACCOUNT DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C533")]
    public class C533
    {
        
        /// <summary>
        // Duty or tax or fee account code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DutyOrTaxOrFeeAccountCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534
    {
        
        /// <summary>
        // Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public string PaymentConditionsCode_01 { get; set; }
        /// <summary>
        // Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PaymentGuaranteeMeansCode_02 { get; set; }
        /// <summary>
        // Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461))]
        [Pos(3)]
        public string PaymentMeansCode_03 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string CodeListIdentificationCode_04 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string CodeListResponsibleAgencyCode_05 { get; set; }
        /// <summary>
        // Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string PaymentChannelCode_06 { get; set; }
    }
    
    /// <summary>
    // CONTRACT AND CARRIAGE CONDITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C536")]
    public class C536
    {
        
        /// <summary>
        // Contract and carriage condition code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4065", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ContractAndCarriageConditionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // TRANSPORT PRIORITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C537")]
    public class C537
    {
        
        /// <summary>
        // Transport service priority code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4219", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TransportServicePriorityCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // AGREEMENT TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C543")]
    public class C543
    {
        
        /// <summary>
        // Agreement type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7431", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AgreementTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // Agreement type description code
        /// </summary>
        [DataMember]
        [DataElement("7433", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string AgreementTypeDescriptionCode_02 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string CodeListIdentificationCode_03 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string CodeListResponsibleAgencyCode_04 { get; set; }
        /// <summary>
        // Agreement type description
        /// </summary>
        [DataMember]
        [DataElement("7434", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string AgreementTypeDescription_05 { get; set; }
    }
    
    /// <summary>
    // INDEX IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C545")]
    public class C545
    {
        
        /// <summary>
        // Index code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5013", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string IndexCodeQualifier_01 { get; set; }
        /// <summary>
        // Index type identifier
        /// </summary>
        [DataMember]
        [DataElement("5027", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string IndexTypeIdentifier_02 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string CodeListIdentificationCode_03 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string CodeListResponsibleAgencyCode_04 { get; set; }
    }
    
    /// <summary>
    // INDEX VALUE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C546")]
    public class C546
    {
        
        /// <summary>
        // Index text
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5030", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string IndexText_01 { get; set; }
        /// <summary>
        // Index representation code
        /// </summary>
        [DataMember]
        [DataElement("5039", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string IndexRepresentationCode_02 { get; set; }
    }
    
    /// <summary>
    // MONETARY AMOUNT FUNCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C549")]
    public class C549
    {
        
        /// <summary>
        // Monetary amount function description code
        /// </summary>
        [DataMember]
        [DataElement("5007", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MonetaryAmountFunctionDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Monetary amount function description
        /// </summary>
        [DataMember]
        [DataElement("5006", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MonetaryAmountFunctionDescription_04 { get; set; }
    }
    
    /// <summary>
    // REQUIREMENT/CONDITION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C550")]
    public class C550
    {
        
        /// <summary>
        // Requirement or condition description identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7295", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RequirementOrConditionDescriptionIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Requirement or condition description
        /// </summary>
        [DataMember]
        [DataElement("7294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string RequirementOrConditionDescription_04 { get; set; }
    }
    
    /// <summary>
    // BANK OPERATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C551")]
    public class C551
    {
        
        /// <summary>
        // Bank operation code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4383", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string BankOperationCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // ALLOWANCE/CHARGE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C552")]
    public class C552
    {
        
        /// <summary>
        // Allowance or charge identifier
        /// </summary>
        [DataMember]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AllowanceOrChargeIdentifier_01 { get; set; }
        /// <summary>
        // Allowance or charge identification code
        /// </summary>
        [DataMember]
        [DataElement("5189", typeof(EDIFACT_ID_5189))]
        [Pos(2)]
        public string AllowanceOrChargeIdentificationCode_02 { get; set; }
    }
    
    /// <summary>
    // RELATED LOCATION TWO IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C553")]
    public class C553
    {
        
        /// <summary>
        // Second related location identifier
        /// </summary>
        [DataMember]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SecondRelatedLocationIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Second related location name
        /// </summary>
        [DataMember]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string SecondRelatedLocationName_04 { get; set; }
    }
    
    /// <summary>
    // RATE/TARIFF CLASS DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C554")]
    public class C554
    {
        
        /// <summary>
        // Rate or tariff class description code
        /// </summary>
        [DataMember]
        [DataElement("5243", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RateOrTariffClassDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // STATUS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C555")]
    public class C555
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
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Status description
        /// </summary>
        [DataMember]
        [DataElement("4404", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string StatusDescription_04 { get; set; }
    }
    
    /// <summary>
    // STATUS REASON
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C556")]
    public class C556
    {
        
        /// <summary>
        // Status reason description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9013", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string StatusReasonDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Status reason description
        /// </summary>
        [DataMember]
        [DataElement("9012", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string StatusReasonDescription_04 { get; set; }
    }
    
    /// <summary>
    // PHYSICAL OR LOGICAL STATE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C564")]
    public class C564
    {
        
        /// <summary>
        // Physical or logical state description code
        /// </summary>
        [DataMember]
        [DataElement("7007", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PhysicalOrLogicalStateDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Physical or logical state description
        /// </summary>
        [DataMember]
        [DataElement("7006", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PhysicalOrLogicalStateDescription_04 { get; set; }
    }
    
    /// <summary>
    // PRIORITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C585")]
    public class C585
    {
        
        /// <summary>
        // Priority description code
        /// </summary>
        [DataMember]
        [DataElement("4037", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PriorityDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Priority description
        /// </summary>
        [DataMember]
        [DataElement("4036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PriorityDescription_04 { get; set; }
    }
    
    /// <summary>
    // ACCOUNT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C593")]
    public class C593
    {
        
        /// <summary>
        // Account identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1147", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AccountIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Account abbreviated name
        /// </summary>
        [DataMember]
        [DataElement("1148", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string AccountAbbreviatedName_04 { get; set; }
        /// <summary>
        // Account name
        /// </summary>
        [DataMember]
        [DataElement("1146", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string AccountName_05 { get; set; }
        /// <summary>
        // Account name
        /// </summary>
        [DataMember]
        [DataElement("1146", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string AccountName_06 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(7)]
        public string CurrencyIdentificationCode_07 { get; set; }
    }
    
    /// <summary>
    // ACCOUNTING JOURNAL IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C595")]
    public class C595
    {
        
        /// <summary>
        // Accounting journal identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1171", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AccountingJournalIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Accounting journal name
        /// </summary>
        [DataMember]
        [DataElement("1170", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string AccountingJournalName_04 { get; set; }
    }
    
    /// <summary>
    // ACCOUNTING ENTRY TYPE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C596")]
    public class C596
    {
        
        /// <summary>
        // Accounting entry type name code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4475", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AccountingEntryTypeNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Accounting entry type name
        /// </summary>
        [DataMember]
        [DataElement("4474", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string AccountingEntryTypeName_04 { get; set; }
    }
    
    /// <summary>
    // STATUS CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C601")]
    public class C601
    {
        
        /// <summary>
        // Status category code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9015", typeof(EDIFACT_ID_9015))]
        [Pos(1)]
        public string StatusCategoryCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // ERROR POINT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C701")]
    public class C701
    {
        
        /// <summary>
        // Message section code
        /// </summary>
        [DataMember]
        [DataElement("1049", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MessageSectionCode_01 { get; set; }
        /// <summary>
        // Message item identifier
        /// </summary>
        [DataMember]
        [DataElement("1052", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MessageItemIdentifier_02 { get; set; }
        /// <summary>
        // Message sub-item identifier
        /// </summary>
        [DataMember]
        [DataElement("1054", typeof(EDIFACT_N))]
        [Pos(3)]
        public string MessageSubitemIdentifier_03 { get; set; }
    }
    
    /// <summary>
    // CODE SET IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C702")]
    public class C702
    {
        
        /// <summary>
        // SIMPLE DATA ELEMENT TAG IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("9150", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SIMPLEDATAELEMENTTAGIDENTIFIER_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // NATURE OF CARGO
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C703")]
    public class C703
    {
        
        /// <summary>
        // Cargo type classification code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7085", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CargoTypeClassificationCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // MESSAGE IDENTIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C709")]
    public class C709
    {
        
        /// <summary>
        // Message type code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1003", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MessageTypeCode_01 { get; set; }
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
        // Controlling agency identifier
        /// </summary>
        [DataMember]
        [DataElement("1476", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ControllingAgencyIdentifier_04 { get; set; }
        /// <summary>
        // Message implementation identification code
        /// </summary>
        [DataMember]
        [DataElement("1523", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string MessageImplementationIdentificationCode_05 { get; set; }
        /// <summary>
        // Revision identifier
        /// </summary>
        [DataMember]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string RevisionIdentifier_06 { get; set; }
        /// <summary>
        // Document status code
        /// </summary>
        [DataMember]
        [DataElement("1373", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string DocumentStatusCode_07 { get; set; }
    }
    
    /// <summary>
    // POSITION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C778")]
    public class C778
    {
        
        /// <summary>
        // HIERARCHICAL STRUCTURE LEVEL IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string HIERARCHICALSTRUCTURELEVELIDENTIFIER_01 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(2)]
        public string SequencePositionIdentifier_02 { get; set; }
    }
    
    /// <summary>
    // ARRAY STRUCTURE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C779")]
    public class C779
    {
        
        /// <summary>
        // Array cell structure identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9428", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ArrayCellStructureIdentifier_01 { get; set; }
        /// <summary>
        // Object identification code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ObjectIdentificationCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // VALUE LIST IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C780")]
    public class C780
    {
        
        /// <summary>
        // Value list identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1518", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ValueListIdentifier_01 { get; set; }
        /// <summary>
        // Object identification code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ObjectIdentificationCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // DATA SET IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C782")]
    public class C782
    {
        
        /// <summary>
        // Data set identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1520", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DataSetIdentifier_01 { get; set; }
        /// <summary>
        // Object identification code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ObjectIdentificationCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // FOOTNOTE SET IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C783")]
    public class C783
    {
        
        /// <summary>
        // Footnote set identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9430", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FootnoteSetIdentifier_01 { get; set; }
        /// <summary>
        // Object identification code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ObjectIdentificationCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // FOOTNOTE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C784")]
    public class C784
    {
        
        /// <summary>
        // Footnote identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9432", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FootnoteIdentifier_01 { get; set; }
        /// <summary>
        // Object identification code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ObjectIdentificationCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // STATISTICAL CONCEPT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C785")]
    public class C785
    {
        
        /// <summary>
        // Statistical concept identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6434", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string StatisticalConceptIdentifier_01 { get; set; }
        /// <summary>
        // Object identification code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ObjectIdentificationCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // STRUCTURE COMPONENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C786")]
    public class C786
    {
        
        /// <summary>
        // STRUCTURE COMPONENT IDENTIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7512", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string STRUCTURECOMPONENTIDENTIFIER_01 { get; set; }
        /// <summary>
        // Object identification code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ObjectIdentificationCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // QUESTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C811")]
    public class C811
    {
        
        /// <summary>
        // Question description code
        /// </summary>
        [DataMember]
        [DataElement("4057", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string QuestionDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Question description
        /// </summary>
        [DataMember]
        [DataElement("4056", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string QuestionDescription_04 { get; set; }
    }
    
    /// <summary>
    // RESPONSE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C812")]
    public class C812
    {
        
        /// <summary>
        // Response description code
        /// </summary>
        [DataMember]
        [DataElement("4345", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ResponseDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Response description
        /// </summary>
        [DataMember]
        [DataElement("4344", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ResponseDescription_04 { get; set; }
    }
    
    /// <summary>
    // SAFETY SECTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C814")]
    public class C814
    {
        
        /// <summary>
        // Safety section number
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4046", typeof(EDIFACT_N))]
        [Pos(1)]
        public string SafetySectionNumber_01 { get; set; }
        /// <summary>
        // Safety section name
        /// </summary>
        [DataMember]
        [DataElement("4044", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string SafetySectionName_02 { get; set; }
    }
    
    /// <summary>
    // ADDITIONAL SAFETY INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C815")]
    public class C815
    {
        
        /// <summary>
        // Additional safety information description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AdditionalSafetyInformationDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Additional safety information description
        /// </summary>
        [DataMember]
        [DataElement("4038", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string AdditionalSafetyInformationDescription_04 { get; set; }
    }
    
    /// <summary>
    // NAME COMPONENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C816")]
    public class C816
    {
        
        /// <summary>
        // Name component type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3405", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string NameComponentTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // Name component description
        /// </summary>
        [DataMember]
        [DataElement("3398", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string NameComponentDescription_02 { get; set; }
        /// <summary>
        // Name component usage code
        /// </summary>
        [DataMember]
        [DataElement("3401", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string NameComponentUsageCode_03 { get; set; }
        /// <summary>
        // Name original alphabet code
        /// </summary>
        [DataMember]
        [DataElement("3295", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string NameOriginalAlphabetCode_04 { get; set; }
    }
    
    /// <summary>
    // ADDRESS USAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C817")]
    public class C817
    {
        
        /// <summary>
        // Address purpose code
        /// </summary>
        [DataMember]
        [DataElement("3299", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AddressPurposeCode_01 { get; set; }
        /// <summary>
        // Address type code
        /// </summary>
        [DataMember]
        [DataElement("3131", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string AddressTypeCode_02 { get; set; }
        /// <summary>
        // Address status code
        /// </summary>
        [DataMember]
        [DataElement("3475", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string AddressStatusCode_03 { get; set; }
    }
    
    /// <summary>
    // PERSON INHERITED CHARACTERISTIC DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C818")]
    public class C818
    {
        
        /// <summary>
        // Inherited characteristic description code
        /// </summary>
        [DataMember]
        [DataElement("3311", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InheritedCharacteristicDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Inherited characteristic description
        /// </summary>
        [DataMember]
        [DataElement("3310", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string InheritedCharacteristicDescription_04 { get; set; }
    }
    
    /// <summary>
    // COUNTRY SUBDIVISION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C819")]
    public class C819
    {
        
        /// <summary>
        // Country subdivision identifier
        /// </summary>
        [DataMember]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CountrySubdivisionIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Country subdivision name
        /// </summary>
        [DataMember]
        [DataElement("3228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string CountrySubdivisionName_04 { get; set; }
    }
    
    /// <summary>
    // PREMIUM CALCULATION COMPONENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C820")]
    public class C820
    {
        
        /// <summary>
        // Premium calculation component identifier
        /// </summary>
        [DataMember]
        [DataElement("4521", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PremiumCalculationComponentIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // TYPE OF DAMAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C821")]
    public class C821
    {
        
        /// <summary>
        // Damage type description code
        /// </summary>
        [DataMember]
        [DataElement("7501", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DamageTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Damage type description
        /// </summary>
        [DataMember]
        [DataElement("7500", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DamageTypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // DAMAGE AREA
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C822")]
    public class C822
    {
        
        /// <summary>
        // Damage area description code
        /// </summary>
        [DataMember]
        [DataElement("7503", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DamageAreaDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Damage area description
        /// </summary>
        [DataMember]
        [DataElement("7502", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DamageAreaDescription_04 { get; set; }
    }
    
    /// <summary>
    // TYPE OF UNIT/COMPONENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C823")]
    public class C823
    {
        
        /// <summary>
        // Unit or component type description code
        /// </summary>
        [DataMember]
        [DataElement("7505", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string UnitOrComponentTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Unit or component type description
        /// </summary>
        [DataMember]
        [DataElement("7504", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string UnitOrComponentTypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // COMPONENT MATERIAL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C824")]
    public class C824
    {
        
        /// <summary>
        // Component material description code
        /// </summary>
        [DataMember]
        [DataElement("7507", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ComponentMaterialDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Component material description
        /// </summary>
        [DataMember]
        [DataElement("7506", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ComponentMaterialDescription_04 { get; set; }
    }
    
    /// <summary>
    // DAMAGE SEVERITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C825")]
    public class C825
    {
        
        /// <summary>
        // Damage severity description code
        /// </summary>
        [DataMember]
        [DataElement("7509", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DamageSeverityDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Damage severity description
        /// </summary>
        [DataMember]
        [DataElement("7508", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DamageSeverityDescription_04 { get; set; }
    }
    
    /// <summary>
    // ACTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C826")]
    public class C826
    {
        
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(1)]
        public string ACTIONCODE_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Action description
        /// </summary>
        [DataMember]
        [DataElement("1228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ActionDescription_04 { get; set; }
    }
    
    /// <summary>
    // TYPE OF MARKING
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C827")]
    public class C827
    {
        
        /// <summary>
        // Marking type code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MarkingTypeCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // CLINICAL INTERVENTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C828")]
    public class C828
    {
        
        /// <summary>
        // Clinical intervention description code
        /// </summary>
        [DataMember]
        [DataElement("9437", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ClinicalInterventionDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Clinical intervention description
        /// </summary>
        [DataMember]
        [DataElement("9436", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ClinicalInterventionDescription_04 { get; set; }
    }
    
    /// <summary>
    // SUB-LINE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C829")]
    public class C829
    {
        
        /// <summary>
        // Sub-line indicator code
        /// </summary>
        [DataMember]
        [DataElement("5495", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SublineIndicatorCode_01 { get; set; }
        /// <summary>
        // LINE ITEM IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string LINEITEMIDENTIFIER_02 { get; set; }
    }
    
    /// <summary>
    // PROCESS IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C830")]
    public class C830
    {
        
        /// <summary>
        // Process description code
        /// </summary>
        [DataMember]
        [DataElement("7191", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ProcessDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Process description
        /// </summary>
        [DataMember]
        [DataElement("7190", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ProcessDescription_04 { get; set; }
    }
    
    /// <summary>
    // RESULT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C831")]
    public class C831
    {
        
        /// <summary>
        // Measure
        /// </summary>
        [DataMember]
        [DataElement("6314", typeof(EDIFACT_ID_6314))]
        [Pos(1)]
        public string Measure_01 { get; set; }
        /// <summary>
        // Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string MeasurementSignificanceCode_02 { get; set; }
        /// <summary>
        // Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string NondiscreteMeasurementNameCode_03 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string CodeListIdentificationCode_04 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string CodeListResponsibleAgencyCode_05 { get; set; }
        /// <summary>
        // Non-discrete measurement name
        /// </summary>
        [DataMember]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string NondiscreteMeasurementName_06 { get; set; }
    }
    
    /// <summary>
    // CLINICAL INFORMATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C836")]
    public class C836
    {
        
        /// <summary>
        // Clinical information description identifier
        /// </summary>
        [DataMember]
        [DataElement("6413", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ClinicalInformationDescriptionIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Clinical information description
        /// </summary>
        [DataMember]
        [DataElement("6412", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ClinicalInformationDescription_04 { get; set; }
    }
    
    /// <summary>
    // CERTAINTY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C837")]
    public class C837
    {
        
        /// <summary>
        // Certainty description code
        /// </summary>
        [DataMember]
        [DataElement("4049", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CertaintyDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Certainty description
        /// </summary>
        [DataMember]
        [DataElement("4048", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string CertaintyDescription_04 { get; set; }
    }
    
    /// <summary>
    // DOSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C838")]
    public class C838
    {
        
        /// <summary>
        // Dosage description identifier
        /// </summary>
        [DataMember]
        [DataElement("6083", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DosageDescriptionIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Dosage description
        /// </summary>
        [DataMember]
        [DataElement("6082", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DosageDescription_04 { get; set; }
    }
    
    /// <summary>
    // ATTENDEE CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C839")]
    public class C839
    {
        
        /// <summary>
        // Attendee category description code
        /// </summary>
        [DataMember]
        [DataElement("7459", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AttendeeCategoryDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Attendee category description
        /// </summary>
        [DataMember]
        [DataElement("7458", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string AttendeeCategoryDescription_04 { get; set; }
    }
    
    /// <summary>
    // ATTENDANCE ADMISSION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C840")]
    public class C840
    {
        
        /// <summary>
        // Admission type description code
        /// </summary>
        [DataMember]
        [DataElement("9445", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AdmissionTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Admission type description
        /// </summary>
        [DataMember]
        [DataElement("9444", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string AdmissionTypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // ATTENDANCE DISCHARGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C841")]
    public class C841
    {
        
        /// <summary>
        // Discharge type description code
        /// </summary>
        [DataMember]
        [DataElement("9447", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string DischargeTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Discharge type description
        /// </summary>
        [DataMember]
        [DataElement("9446", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DischargeTypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // ORGANISATION CLASSIFICATION DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C844")]
    public class C844
    {
        
        /// <summary>
        // Organisational class name code
        /// </summary>
        [DataMember]
        [DataElement("3083", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string OrganisationalClassNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Organisational class name
        /// </summary>
        [DataMember]
        [DataElement("3082", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string OrganisationalClassName_04 { get; set; }
    }
    
    /// <summary>
    // MEASUREMENT UNIT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C848")]
    public class C848
    {
        
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public string MeasurementUnitCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Measurement unit name
        /// </summary>
        [DataMember]
        [DataElement("6410", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MeasurementUnitName_04 { get; set; }
    }
    
    /// <summary>
    // PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C849")]
    public class C849
    {
        
        /// <summary>
        // Enacting party identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3301", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EnactingPartyIdentifier_01 { get; set; }
        /// <summary>
        // Instruction receiving party identifier
        /// </summary>
        [DataMember]
        [DataElement("3285", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string InstructionReceivingPartyIdentifier_02 { get; set; }
    }
    
    /// <summary>
    // STATUS OF INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C850")]
    public class C850
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
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PartyName_02 { get; set; }
    }
    
    /// <summary>
    // RISK OBJECT TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C851")]
    public class C851
    {
        
        /// <summary>
        // Risk object type identifier
        /// </summary>
        [DataMember]
        [DataElement("7179", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RiskObjectTypeIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // RISK OBJECT SUB-TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C852")]
    public class C852
    {
        
        /// <summary>
        // Risk object sub-type description identifier
        /// </summary>
        [DataMember]
        [DataElement("7177", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RiskObjectSubtypeDescriptionIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Risk object sub-type description
        /// </summary>
        [DataMember]
        [DataElement("7176", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string RiskObjectSubtypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // ERROR SEGMENT POINT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C853")]
    public class C853
    {
        
        /// <summary>
        // Segment tag identifier
        /// </summary>
        [DataMember]
        [DataElement("9166", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SegmentTagIdentifier_01 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(2)]
        public string SequencePositionIdentifier_02 { get; set; }
        /// <summary>
        // Sequence identifier source code
        /// </summary>
        [DataMember]
        [DataElement("1159", typeof(EDIFACT_ID_1159))]
        [Pos(3)]
        public string SequenceIdentifierSourceCode_03 { get; set; }
    }
    
    /// <summary>
    // CHARGE/ALLOWANCE ACCOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C878")]
    public class C878
    {
        
        /// <summary>
        // Institution branch identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InstitutionBranchIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Account holder identifier
        /// </summary>
        [DataMember]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string AccountHolderIdentifier_04 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(5)]
        public string CurrencyIdentificationCode_05 { get; set; }
    }
    
    /// <summary>
    // CHARACTERISTIC VALUE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C889")]
    public class C889
    {
        
        /// <summary>
        // Characteristic value description code
        /// </summary>
        [DataMember]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CharacteristicValueDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Characteristic value description
        /// </summary>
        [DataMember]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string CharacteristicValueDescription_04 { get; set; }
        /// <summary>
        // Characteristic value description
        /// </summary>
        [DataMember]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string CharacteristicValueDescription_05 { get; set; }
    }
    
    /// <summary>
    // APPLICATION ERROR DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C901")]
    public class C901
    {
        
        /// <summary>
        // Application error code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9321", typeof(EDIFACT_ID_9321))]
        [Pos(1)]
        public string ApplicationErrorCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // RELATIONSHIP
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C941")]
    public class C941
    {
        
        /// <summary>
        // Relationship description code
        /// </summary>
        [DataMember]
        [DataElement("9143", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RelationshipDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Relationship description
        /// </summary>
        [DataMember]
        [DataElement("9142", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string RelationshipDescription_04 { get; set; }
    }
    
    /// <summary>
    // MEMBERSHIP CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C942")]
    public class C942
    {
        
        /// <summary>
        // Membership category description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7451", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MembershipCategoryDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Membership category description
        /// </summary>
        [DataMember]
        [DataElement("7450", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MembershipCategoryDescription_04 { get; set; }
    }
    
    /// <summary>
    // MEMBERSHIP STATUS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C944")]
    public class C944
    {
        
        /// <summary>
        // Membership status description code
        /// </summary>
        [DataMember]
        [DataElement("7453", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MembershipStatusDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Membership status description
        /// </summary>
        [DataMember]
        [DataElement("7452", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MembershipStatusDescription_04 { get; set; }
    }
    
    /// <summary>
    // MEMBERSHIP LEVEL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C945")]
    public class C945
    {
        
        /// <summary>
        // Membership level code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7455", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MembershipLevelCodeQualifier_01 { get; set; }
        /// <summary>
        // Membership level description code
        /// </summary>
        [DataMember]
        [DataElement("7457", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MembershipLevelDescriptionCode_02 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string CodeListIdentificationCode_03 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string CodeListResponsibleAgencyCode_04 { get; set; }
        /// <summary>
        // Membership level description
        /// </summary>
        [DataMember]
        [DataElement("7456", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string MembershipLevelDescription_05 { get; set; }
    }
    
    /// <summary>
    // EMPLOYMENT CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C948")]
    public class C948
    {
        
        /// <summary>
        // Employment category description code
        /// </summary>
        [DataMember]
        [DataElement("9005", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EmploymentCategoryDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Employment category description
        /// </summary>
        [DataMember]
        [DataElement("9004", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string EmploymentCategoryDescription_04 { get; set; }
    }
    
    /// <summary>
    // QUALIFICATION CLASSIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C950")]
    public class C950
    {
        
        /// <summary>
        // Qualification classification description code
        /// </summary>
        [DataMember]
        [DataElement("9007", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string QualificationClassificationDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Qualification classification description
        /// </summary>
        [DataMember]
        [DataElement("9006", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string QualificationClassificationDescription_04 { get; set; }
        /// <summary>
        // Qualification classification description
        /// </summary>
        [DataMember]
        [DataElement("9006", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string QualificationClassificationDescription_05 { get; set; }
    }
    
    /// <summary>
    // OCCUPATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C951")]
    public class C951
    {
        
        /// <summary>
        // Occupation description code
        /// </summary>
        [DataMember]
        [DataElement("9009", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string OccupationDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Occupation description
        /// </summary>
        [DataMember]
        [DataElement("9008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string OccupationDescription_04 { get; set; }
        /// <summary>
        // Occupation description
        /// </summary>
        [DataMember]
        [DataElement("9008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string OccupationDescription_05 { get; set; }
    }
    
    /// <summary>
    // CONTRIBUTION TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C953")]
    public class C953
    {
        
        /// <summary>
        // Contribution type description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5049", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ContributionTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Contribution type description
        /// </summary>
        [DataMember]
        [DataElement("5048", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ContributionTypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // ATTRIBUTE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C955")]
    public class C955
    {
        
        /// <summary>
        // Attribute type description code
        /// </summary>
        [DataMember]
        [DataElement("9021", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AttributeTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Attribute type description
        /// </summary>
        [DataMember]
        [DataElement("9020", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string AttributeTypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // ATTRIBUTE DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C956")]
    public class C956
    {
        
        /// <summary>
        // Attribute description code
        /// </summary>
        [DataMember]
        [DataElement("9019", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AttributeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Attribute description
        /// </summary>
        [DataMember]
        [DataElement("9018", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string AttributeDescription_04 { get; set; }
    }
    
    /// <summary>
    // REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C960")]
    public class C960
    {
        
        /// <summary>
        // Change reason description code
        /// </summary>
        [DataMember]
        [DataElement("4295", typeof(EDIFACT_ID_4295))]
        [Pos(1)]
        public string ChangeReasonDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Change reason description
        /// </summary>
        [DataMember]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ChangeReasonDescription_04 { get; set; }
    }
    
    /// <summary>
    // FORMULA COMPLEXITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C961")]
    public class C961
    {
        
        /// <summary>
        // Formula complexity code
        /// </summary>
        [DataMember]
        [DataElement("9505", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FormulaComplexityCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // CLAUSE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C970")]
    public class C970
    {
        
        /// <summary>
        // Clause name code
        /// </summary>
        [DataMember]
        [DataElement("4069", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ClauseNameCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Clause name
        /// </summary>
        [DataMember]
        [DataElement("4068", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ClauseName_04 { get; set; }
    }
    
    /// <summary>
    // PROVISO TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C971")]
    public class C971
    {
        
        /// <summary>
        // Proviso type description code
        /// </summary>
        [DataMember]
        [DataElement("4073", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ProvisoTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Proviso type description
        /// </summary>
        [DataMember]
        [DataElement("4072", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ProvisoTypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // PROVISO CALCULATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C972")]
    public class C972
    {
        
        /// <summary>
        // Proviso calculation description code
        /// </summary>
        [DataMember]
        [DataElement("4075", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ProvisoCalculationDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Proviso calculation description
        /// </summary>
        [DataMember]
        [DataElement("4074", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ProvisoCalculationDescription_04 { get; set; }
    }
    
    /// <summary>
    // APPLICABILITY TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C973")]
    public class C973
    {
        
        /// <summary>
        // Applicability type description code
        /// </summary>
        [DataMember]
        [DataElement("9049", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ApplicabilityTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Applicability type description
        /// </summary>
        [DataMember]
        [DataElement("9048", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ApplicabilityTypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // BASIS TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C974")]
    public class C974
    {
        
        /// <summary>
        // Basis type description code
        /// </summary>
        [DataMember]
        [DataElement("9047", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string BasisTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Basis type description
        /// </summary>
        [DataMember]
        [DataElement("9046", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string BasisTypeDescription_04 { get; set; }
    }
    
    /// <summary>
    // PERIOD DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C977")]
    public class C977
    {
        
        /// <summary>
        // Period detail description code
        /// </summary>
        [DataMember]
        [DataElement("2119", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PeriodDetailDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Period detail description
        /// </summary>
        [DataMember]
        [DataElement("2118", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PeriodDetailDescription_04 { get; set; }
    }
    
    /// <summary>
    // ADDRESS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E001")]
    public class E001
    {
        
        /// <summary>
        // Address format code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3477", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AddressFormatCode_01 { get; set; }
        /// <summary>
        // Address component description
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string AddressComponentDescription_02 { get; set; }
        /// <summary>
        // Address component description
        /// </summary>
        [DataMember]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string AddressComponentDescription_03 { get; set; }
        /// <summary>
        // Address component description
        /// </summary>
        [DataMember]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string AddressComponentDescription_04 { get; set; }
        /// <summary>
        // Address component description
        /// </summary>
        [DataMember]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string AddressComponentDescription_05 { get; set; }
        /// <summary>
        // Address component description
        /// </summary>
        [DataMember]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string AddressComponentDescription_06 { get; set; }
        /// <summary>
        // Address component description
        /// </summary>
        [DataMember]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string AddressComponentDescription_07 { get; set; }
    }
    
    /// <summary>
    // COMMISSION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E002")]
    public class E002
    {
        
        /// <summary>
        // Payment conditions code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public string PaymentConditionsCode_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string CurrencyIdentificationCode_03 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PartyName_04 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string FreeText_05 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(6)]
        public string ACTIONCODE_06 { get; set; }
    }
    
    /// <summary>
    // ATTRIBUTE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E003")]
    public class E003
    {
        
        /// <summary>
        // Attribute type description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9021", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AttributeTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Attribute description
        /// </summary>
        [DataMember]
        [DataElement("9018", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string AttributeDescription_02 { get; set; }
    }
    
    /// <summary>
    // RULE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E004")]
    public class E004
    {
        
        /// <summary>
        // SPECIAL CONDITION CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4183", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SPECIALCONDITIONCODE_01 { get; set; }
        /// <summary>
        // Units quantity
        /// </summary>
        [DataMember]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(2)]
        public string UnitsQuantity_02 { get; set; }
        /// <summary>
        // Unit type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6353", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string UnitTypeCodeQualifier_03 { get; set; }
        /// <summary>
        // Relation code
        /// </summary>
        [DataMember]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(4)]
        public string RelationCode_04 { get; set; }
        /// <summary>
        // DAYS OF WEEK SET IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("2160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string DAYSOFWEEKSETIDENTIFIER_05 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(6)]
        public string MonetaryAmount_06 { get; set; }
        /// <summary>
        // Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(7)]
        public string MonetaryAmountTypeCodeQualifier_07 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(8)]
        public string CurrencyIdentificationCode_08 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string FreeText_09 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string FreeText_10 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(11)]
        public string FreeText_11 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(12)]
        public string FreeText_12 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(13)]
        public string FreeText_13 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(14)]
        public string FreeText_14 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(15)]
        public string FreeText_15 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(16)]
        public string FreeText_16 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(17)]
        public string FreeText_17 { get; set; }
    }
    
    /// <summary>
    // RULE TEXT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E005")]
    public class E005
    {
        
        /// <summary>
        // SPECIAL CONDITION CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4183", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SPECIALCONDITIONCODE_01 { get; set; }
        /// <summary>
        // Information type code
        /// </summary>
        [DataMember]
        [DataElement("4473", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string InformationTypeCode_02 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string FreeText_03 { get; set; }
    }
    
    /// <summary>
    // RULE STATUS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E006")]
    public class E006
    {
        
        /// <summary>
        // SPECIAL CONDITION CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4183", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SPECIALCONDITIONCODE_01 { get; set; }
        /// <summary>
        // Processing indicator description code
        /// </summary>
        [DataMember]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ProcessingIndicatorDescriptionCode_02 { get; set; }
    }
    
    /// <summary>
    // TRAFFIC RESTRICTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E007")]
    public class E007
    {
        
        /// <summary>
        // Traffic restriction code
        /// </summary>
        [DataMember]
        [DataElement("8015", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TrafficRestrictionCode_01 { get; set; }
        /// <summary>
        // Traffic restriction application code
        /// </summary>
        [DataMember]
        [DataElement("8017", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string TrafficRestrictionApplicationCode_02 { get; set; }
        /// <summary>
        // Traffic restriction type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("8035", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string TrafficRestrictionTypeCodeQualifier_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string FreeText_04 { get; set; }
    }
    
    /// <summary>
    // GEOGRAPHIC DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E008")]
    public class E008
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
        // Location name
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string LocationName_02 { get; set; }
        /// <summary>
        // Relation code
        /// </summary>
        [DataMember]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(3)]
        public string RelationCode_03 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string QUANTITY_04 { get; set; }
        /// <summary>
        // QUANTITY TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(5)]
        public string QUANTITYTYPECODEQUALIFIER_05 { get; set; }
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(6)]
        public string Time_06 { get; set; }
        /// <summary>
        // TRANSPORT MEANS DESCRIPTION CODE
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string TRANSPORTMEANSDESCRIPTIONCODE_07 { get; set; }
        /// <summary>
        // TRANSPORT MEANS DESCRIPTION CODE
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string TRANSPORTMEANSDESCRIPTIONCODE_08 { get; set; }
        /// <summary>
        // TRANSPORT MEANS DESCRIPTION CODE
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string TRANSPORTMEANSDESCRIPTIONCODE_09 { get; set; }
        /// <summary>
        // TRANSPORT MEANS DESCRIPTION CODE
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string TRANSPORTMEANSDESCRIPTIONCODE_10 { get; set; }
        /// <summary>
        // TRANSPORT MEANS DESCRIPTION CODE
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(11)]
        public string TRANSPORTMEANSDESCRIPTIONCODE_11 { get; set; }
        /// <summary>
        // LATITUDE DEGREE
        /// </summary>
        [DataMember]
        [DataElement("6000", typeof(EDIFACT_AN))]
        [Pos(12)]
        public string LATITUDEDEGREE_12 { get; set; }
        /// <summary>
        // Longitude degree
        /// </summary>
        [DataMember]
        [DataElement("6002", typeof(EDIFACT_AN))]
        [Pos(13)]
        public string LongitudeDegree_13 { get; set; }
    }
    
    /// <summary>
    // DAILY AVAILABILITY INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E009")]
    public class E009
    {
        
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Date_01 { get; set; }
        /// <summary>
        // Requested information description
        /// </summary>
        [DataMember]
        [DataElement("4510", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string RequestedInformationDescription_02 { get; set; }
    }
    
    /// <summary>
    // SELECTION DETAILS INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E010")]
    public class E010
    {
        
        /// <summary>
        // Option code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4009", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string OptionCode_01 { get; set; }
        /// <summary>
        // Related information description
        /// </summary>
        [DataMember]
        [DataElement("4018", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string RelatedInformationDescription_02 { get; set; }
    }
    
    /// <summary>
    // RATE CLASS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E011")]
    public class E011
    {
        
        /// <summary>
        // Rate or tariff class description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5243", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RateOrTariffClassDescriptionCode_01 { get; set; }
        /// <summary>
        // Processing indicator description code
        /// </summary>
        [DataMember]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ProcessingIndicatorDescriptionCode_02 { get; set; }
    }
    
    /// <summary>
    // NAME INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E012")]
    public class E012
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
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PartyName_02 { get; set; }
        /// <summary>
        // Party identifier
        /// </summary>
        [DataMember]
        [DataElement("3039", typeof(EDIFACT_ID_3039))]
        [Pos(3)]
        public string PartyIdentifier_03 { get; set; }
        /// <summary>
        // Name status code
        /// </summary>
        [DataMember]
        [DataElement("3397", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string NameStatusCode_04 { get; set; }
    }
    
    /// <summary>
    // DATE AND TIME INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E013")]
    public class E013
    {
        
        /// <summary>
        // Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string DateOrTimeOrPeriodFunctionCodeQualifier_01 { get; set; }
        /// <summary>
        // Date or time or period text
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DateOrTimeOrPeriodText_02 { get; set; }
        /// <summary>
        // Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string DateOrTimeOrPeriodFormatCode_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string FreeText_04 { get; set; }
    }
    
    /// <summary>
    // TIME REFERENCE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E014")]
    public class E014
    {
        
        /// <summary>
        // Reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1154", typeof(EDIFACT_ID_1154))]
        [Pos(1)]
        public string ReferenceIdentifier_01 { get; set; }
        /// <summary>
        // Reference code qualifier
        /// </summary>
        [DataMember]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(2)]
        public string ReferenceCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // PRODUCT DATA INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E015")]
    public class E015
    {
        
        /// <summary>
        // Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(1)]
        public string ItemDescriptionCode_01 { get; set; }
        /// <summary>
        // Item description
        /// </summary>
        [DataMember]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ItemDescription_02 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string QUANTITY_03 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(4)]
        public string MonetaryAmount_04 { get; set; }
        /// <summary>
        // Charge period type code
        /// </summary>
        [DataMember]
        [DataElement("2155", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string ChargePeriodTypeCode_05 { get; set; }
        /// <summary>
        // Charge unit code
        /// </summary>
        [DataMember]
        [DataElement("5261", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string ChargeUnitCode_06 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(7)]
        public string CurrencyIdentificationCode_07 { get; set; }
        /// <summary>
        // Information type code
        /// </summary>
        [DataMember]
        [DataElement("4473", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string InformationTypeCode_08 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string FreeText_09 { get; set; }
    }
    
    /// <summary>
    // INSURANCE COVER REQUIREMENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E016")]
    public class E016
    {
        
        /// <summary>
        // INSURANCE COVER TYPE CODE
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4497", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string INSURANCECOVERTYPECODE_01 { get; set; }
        /// <summary>
        // Requirement designator code
        /// </summary>
        [DataMember]
        [DataElement("7299", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string RequirementDesignatorCode_02 { get; set; }
    }
    
    /// <summary>
    // MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E017")]
    public class E017
    {
        
        /// <summary>
        // Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string MonetaryAmountTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string CurrencyIdentificationCode_03 { get; set; }
        /// <summary>
        // Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string CurrencyTypeCodeQualifier_04 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string StatusDescriptionCode_05 { get; set; }
    }
    
    /// <summary>
    // PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E018")]
    public class E018
    {
        
        /// <summary>
        // Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125))]
        [Pos(1)]
        public string PriceCodeQualifier_01 { get; set; }
        /// <summary>
        // Price amount
        /// </summary>
        [DataMember]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string PriceAmount_02 { get; set; }
        /// <summary>
        // Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375))]
        [Pos(3)]
        public string PriceTypeCode_03 { get; set; }
    }
    
    /// <summary>
    // PROMOTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E019")]
    public class E019
    {
        
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PartyName_01 { get; set; }
        /// <summary>
        // YES OR NO INDICATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("9607", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string YESORNOINDICATORCODE_02 { get; set; }
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
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string FreeText_05 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string FreeText_06 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string FreeText_07 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string FreeText_08 { get; set; }
    }
    
    /// <summary>
    // TAX DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E020")]
    public class E020
    {
        
        /// <summary>
        // Duty or tax or fee type name code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string DutyOrTaxOrFeeTypeNameCode_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Duty or tax or fee rate
        /// </summary>
        [DataMember]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DutyOrTaxOrFeeRate_03 { get; set; }
    }
    
    /// <summary>
    // SERVICE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E021")]
    public class E021
    {
        
        /// <summary>
        // Product identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7135", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ProductIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Procedure modification code
        /// </summary>
        [DataMember]
        [DataElement("9629", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ProcedureModificationCode_03 { get; set; }
        /// <summary>
        // Procedure modification code
        /// </summary>
        [DataMember]
        [DataElement("9629", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ProcedureModificationCode_04 { get; set; }
        /// <summary>
        // Procedure modification code
        /// </summary>
        [DataMember]
        [DataElement("9629", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string ProcedureModificationCode_05 { get; set; }
        /// <summary>
        // Procedure modification code
        /// </summary>
        [DataMember]
        [DataElement("9629", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string ProcedureModificationCode_06 { get; set; }
    }
    
    /// <summary>
    // INSTRUCTION INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E022")]
    public class E022
    {
        
        /// <summary>
        // Instruction description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4401", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InstructionDescriptionCode_01 { get; set; }
        /// <summary>
        // Instruction type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("4403", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string InstructionTypeCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // PARTY DEMOGRAPHIC INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E023")]
    public class E023
    {
        
        /// <summary>
        // Relationship description code
        /// </summary>
        [DataMember]
        [DataElement("9143", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RelationshipDescriptionCode_01 { get; set; }
        /// <summary>
        // Gender code
        /// </summary>
        [DataMember]
        [DataElement("3499", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string GenderCode_02 { get; set; }
        /// <summary>
        // Employment category description code
        /// </summary>
        [DataMember]
        [DataElement("9005", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string EmploymentCategoryDescriptionCode_03 { get; set; }
        /// <summary>
        // Marital status description code
        /// </summary>
        [DataMember]
        [DataElement("3479", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string MaritalStatusDescriptionCode_04 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string StatusDescriptionCode_05 { get; set; }
        /// <summary>
        // YES OR NO INDICATOR CODE
        /// </summary>
        [DataMember]
        [DataElement("9607", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string YESORNOINDICATORCODE_06 { get; set; }
    }
    
    /// <summary>
    // SUPPORTING EVIDENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E024")]
    public class E024
    {
        
        /// <summary>
        // Supporting evidence type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9643", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SupportingEvidenceTypeCodeQualifier_01 { get; set; }
        /// <summary>
        // Reference identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1154", typeof(EDIFACT_ID_1154))]
        [Pos(2)]
        public string ReferenceIdentifier_02 { get; set; }
        /// <summary>
        // Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CommunicationMediumTypeCode_03 { get; set; }
    }
    
    /// <summary>
    // BASIS OF SERVICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E025")]
    public class E025
    {
        
        /// <summary>
        // Service basis code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9641", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ServiceBasisCodeQualifier_01 { get; set; }
        /// <summary>
        // Product identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7135", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ProductIdentifier_02 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string CodeListIdentificationCode_03 { get; set; }
        /// <summary>
        // Date or time or period text
        /// </summary>
        [DataMember]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string DateOrTimeOrPeriodText_04 { get; set; }
        /// <summary>
        // Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(5)]
        public string DateOrTimeOrPeriodFormatCode_05 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(6)]
        public string MonetaryAmount_06 { get; set; }
    }
    
    /// <summary>
    // ADMISSION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E026")]
    public class E026
    {
        
        /// <summary>
        // Admission type description code
        /// </summary>
        [DataMember]
        [DataElement("9445", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AdmissionTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Admission source code
        /// </summary>
        [DataMember]
        [DataElement("9627", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string AdmissionSourceCode_02 { get; set; }
    }
    
    /// <summary>
    // INVOICE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E027")]
    public class E027
    {
        
        /// <summary>
        // Invoice type code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9631", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string InvoiceTypeCode_01 { get; set; }
        /// <summary>
        // Frequency code
        /// </summary>
        [DataMember]
        [DataElement("2013", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string FrequencyCode_02 { get; set; }
    }
    
    /// <summary>
    // RELATED CAUSE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E028")]
    public class E028
    {
        
        /// <summary>
        // Related cause code
        /// </summary>
        [DataMember]
        [DataElement("9625", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RelatedCauseCode_01 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        // Country subdivision identifier
        /// </summary>
        [DataMember]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CountrySubdivisionIdentifier_03 { get; set; }
    }
    
    /// <summary>
    // DIAGNOSIS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E029")]
    public class E029
    {
        
        /// <summary>
        // Product identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7135", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ProductIdentifier_01 { get; set; }
        /// <summary>
        // Diagnosis type code
        /// </summary>
        [DataMember]
        [DataElement("9623", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DiagnosisTypeCode_02 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string CodeListIdentificationCode_03 { get; set; }
    }
    
    /// <summary>
    // ADJUSTMENT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E030")]
    public class E030
    {
        
        /// <summary>
        // Adjustment category code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9619", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AdjustmentCategoryCode_01 { get; set; }
        /// <summary>
        // Adjustment reason description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4465", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string AdjustmentReasonDescriptionCode_02 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
    }
    
    /// <summary>
    // MESSAGE APPLICATION PRODUCT SPECIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E031")]
    public class E031
    {
        
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(1)]
        public string MessageFunctionCode_01 { get; set; }
        /// <summary>
        // Process description code
        /// </summary>
        [DataMember]
        [DataElement("7191", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ProcessDescriptionCode_02 { get; set; }
        /// <summary>
        // Process description code
        /// </summary>
        [DataMember]
        [DataElement("7191", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ProcessDescriptionCode_03 { get; set; }
    }
    
    /// <summary>
    // PARTY IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E032")]
    public class E032
    {
        
        /// <summary>
        // Party identifier
        /// </summary>
        [DataMember]
        [DataElement("3039", typeof(EDIFACT_ID_3039))]
        [Pos(1)]
        public string PartyIdentifier_01 { get; set; }
        /// <summary>
        // Party function code qualifier
        /// </summary>
        [DataMember]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(2)]
        public string PartyFunctionCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // LANGUAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E033")]
    public class E033
    {
        
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string LANGUAGENAMECODE_01 { get; set; }
        /// <summary>
        // Language name
        /// </summary>
        [DataMember]
        [DataElement("3452", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string LanguageName_02 { get; set; }
    }
    
    /// <summary>
    // TIME ZONE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E034")]
    public class E034
    {
        
        /// <summary>
        // Time zone identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2029", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TimeZoneIdentifier_01 { get; set; }
        /// <summary>
        // Time zone difference quantity
        /// </summary>
        [DataMember]
        [DataElement("2116", typeof(EDIFACT_N))]
        [Pos(2)]
        public string TimeZoneDifferenceQuantity_02 { get; set; }
    }
    
    /// <summary>
    // QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E035")]
    public class E035
    {
        
        /// <summary>
        // QUANTITY TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string QUANTITYTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string QUANTITY_02 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string MeasurementUnitCode_03 { get; set; }
    }
    
    /// <summary>
    // PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E080")]
    public class E080
    {
        
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PartyName_01 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PartyName_02 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string PartyName_03 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PartyName_04 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string PartyName_05 { get; set; }
        /// <summary>
        // Party name format code
        /// </summary>
        [DataMember]
        [DataElement("3045", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string PartyNameFormatCode_06 { get; set; }
    }
    
    /// <summary>
    // PARTY IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E082")]
    public class E082
    {
        
        /// <summary>
        // Party identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3039", typeof(EDIFACT_ID_3039))]
        [Pos(1)]
        public string PartyIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // DELIVERY PATTERN
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E083")]
    public class E083
    {
        
        /// <summary>
        // QUANTITY TYPE CODE QUALIFIER
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string QUANTITYTYPECODEQUALIFIER_01 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string QUANTITY_02 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string MeasurementUnitCode_03 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string QUANTITY_04 { get; set; }
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
        /// <summary>
        // Despatch pattern code
        /// </summary>
        [DataMember]
        [DataElement("2015", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string DespatchPatternCode_07 { get; set; }
        /// <summary>
        // Despatch pattern timing code
        /// </summary>
        [DataMember]
        [DataElement("2017", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string DespatchPatternTimingCode_08 { get; set; }
    }
    
    /// <summary>
    // MEASUREMENT VALUE AND DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E175")]
    public class E175
    {
        
        /// <summary>
        // Measure
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6314", typeof(EDIFACT_ID_6314))]
        [Pos(1)]
        public string Measure_01 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(2)]
        public string MeasurementUnitCode_02 { get; set; }
        /// <summary>
        // Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(3)]
        public string MeasuredAttributeCode_03 { get; set; }
        /// <summary>
        // Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(4)]
        public string MeasurementSignificanceCode_04 { get; set; }
    }
    
    /// <summary>
    // OBJECT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E206")]
    public class E206
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
        // Object identification code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ObjectIdentificationCodeQualifier_02 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string StatusDescriptionCode_03 { get; set; }
    }
    
    /// <summary>
    // DIMENSIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E211")]
    public class E211
    {
        
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public string MeasurementUnitCode_01 { get; set; }
        /// <summary>
        // Length measure
        /// </summary>
        [DataMember]
        [DataElement("6168", typeof(EDIFACT_N))]
        [Pos(2)]
        public string LengthMeasure_02 { get; set; }
        /// <summary>
        // Width measure
        /// </summary>
        [DataMember]
        [DataElement("6140", typeof(EDIFACT_N))]
        [Pos(3)]
        public string WidthMeasure_03 { get; set; }
        /// <summary>
        // Height measure
        /// </summary>
        [DataMember]
        [DataElement("6008", typeof(EDIFACT_N))]
        [Pos(4)]
        public string HeightMeasure_04 { get; set; }
    }
    
    /// <summary>
    // ITEM NUMBER IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E212")]
    public class E212
    {
        
        /// <summary>
        // Item identifier
        /// </summary>
        [DataMember]
        [DataElement("7140", typeof(EDIFACT_ID_7140))]
        [Pos(1)]
        public string ItemIdentifier_01 { get; set; }
        /// <summary>
        // Item type identification code
        /// </summary>
        [DataMember]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string ItemTypeIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string CodeListIdentificationCode_03 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string CodeListResponsibleAgencyCode_04 { get; set; }
    }
    
    /// <summary>
    // RELATED TIME INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E362")]
    public class E362
    {
        
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Time_01 { get; set; }
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Time_02 { get; set; }
        /// <summary>
        // Time zone difference quantity
        /// </summary>
        [DataMember]
        [DataElement("2116", typeof(EDIFACT_N))]
        [Pos(3)]
        public string TimeZoneDifferenceQuantity_03 { get; set; }
        /// <summary>
        // Date variation number
        /// </summary>
        [DataMember]
        [DataElement("2148", typeof(EDIFACT_N))]
        [Pos(4)]
        public string DateVariationNumber_04 { get; set; }
    }
    
    /// <summary>
    // CURRENCY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E504")]
    public class E504
    {
        
        /// <summary>
        // Currency usage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string CurrencyUsageCodeQualifier_01 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(2)]
        public string CurrencyIdentificationCode_02 { get; set; }
        /// <summary>
        // Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string CurrencyTypeCodeQualifier_03 { get; set; }
        /// <summary>
        // Currency rate
        /// </summary>
        [DataMember]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string CurrencyRate_04 { get; set; }
    }
    
    /// <summary>
    // REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E506")]
    public class E506
    {
        
        /// <summary>
        // Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string ReferenceCodeQualifier_01 { get; set; }
        /// <summary>
        // Reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1154", typeof(EDIFACT_ID_1154))]
        [Pos(2)]
        public string ReferenceIdentifier_02 { get; set; }
        /// <summary>
        // Document line identifier
        /// </summary>
        [DataMember]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DocumentLineIdentifier_03 { get; set; }
        /// <summary>
        // Reference version identifier
        /// </summary>
        [DataMember]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ReferenceVersionIdentifier_04 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string PartyName_05 { get; set; }
    }
    
    /// <summary>
    // DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E507")]
    public class E507
    {
        
        /// <summary>
        // Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string DateOrTimeOrPeriodFunctionCodeQualifier_01 { get; set; }
        /// <summary>
        // Date or time or period text
        /// </summary>
        [DataMember]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DateOrTimeOrPeriodText_02 { get; set; }
        /// <summary>
        // Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string DateOrTimeOrPeriodFormatCode_03 { get; set; }
    }
    
    /// <summary>
    // LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E517")]
    public class E517
    {
        
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(1)]
        public string LocationIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Location name
        /// </summary>
        [DataMember]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string LocationName_04 { get; set; }
    }
    
    /// <summary>
    // FREQUENCY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E520")]
    public class E520
    {
        
        /// <summary>
        // Frequency rate
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6072", typeof(EDIFACT_N))]
        [Pos(1)]
        public string FrequencyRate_01 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(2)]
        public string MeasurementUnitCode_02 { get; set; }
        /// <summary>
        // Date or time or period text
        /// </summary>
        [DataMember]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string DateOrTimeOrPeriodText_03 { get; set; }
        /// <summary>
        // Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(4)]
        public string DateOrTimeOrPeriodFormatCode_04 { get; set; }
    }
    
    /// <summary>
    // NUMBER OF UNIT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E523")]
    public class E523
    {
        
        /// <summary>
        // Units quantity
        /// </summary>
        [DataMember]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(1)]
        public string UnitsQuantity_01 { get; set; }
        /// <summary>
        // Unit type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6353", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string UnitTypeCodeQualifier_02 { get; set; }
    }
    
    /// <summary>
    // POSITION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E778")]
    public class E778
    {
        
        /// <summary>
        // HIERARCHICAL STRUCTURE LEVEL IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string HIERARCHICALSTRUCTURELEVELIDENTIFIER_01 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(2)]
        public string SequencePositionIdentifier_02 { get; set; }
    }
    
    /// <summary>
    // ADDRESS USAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E817")]
    public class E817
    {
        
        /// <summary>
        // Address purpose code
        /// </summary>
        [DataMember]
        [DataElement("3299", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AddressPurposeCode_01 { get; set; }
        /// <summary>
        // Address type code
        /// </summary>
        [DataMember]
        [DataElement("3131", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string AddressTypeCode_02 { get; set; }
        /// <summary>
        // Address status code
        /// </summary>
        [DataMember]
        [DataElement("3475", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string AddressStatusCode_03 { get; set; }
    }
    
    /// <summary>
    // COUNTRY SUB-ENTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E819")]
    public class E819
    {
        
        /// <summary>
        // Country subdivision identifier
        /// </summary>
        [DataMember]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CountrySubdivisionIdentifier_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Country subdivision name
        /// </summary>
        [DataMember]
        [DataElement("3228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string CountrySubdivisionName_04 { get; set; }
    }
    
    /// <summary>
    // APPLICATION ERROR DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E901")]
    public class E901
    {
        
        /// <summary>
        // Application error code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9321", typeof(EDIFACT_ID_9321))]
        [Pos(1)]
        public string ApplicationErrorCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
    }
    
    /// <summary>
    // RELATIONSHIP
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E941")]
    public class E941
    {
        
        /// <summary>
        // Relationship description code
        /// </summary>
        [DataMember]
        [DataElement("9143", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RelationshipDescriptionCode_01 { get; set; }
        /// <summary>
        // Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string CodeListIdentificationCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Relationship description
        /// </summary>
        [DataMember]
        [DataElement("9142", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string RelationshipDescription_04 { get; set; }
    }
    
    /// <summary>
    // CERTAINTY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E946")]
    public class E946
    {
        
        /// <summary>
        // Certainty description code
        /// </summary>
        [DataMember]
        [DataElement("4049", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CertaintyDescriptionCode_01 { get; set; }
        /// <summary>
        // Certainty description
        /// </summary>
        [DataMember]
        [DataElement("4048", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string CertaintyDescription_02 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string LANGUAGENAMECODE_03 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string CodeListResponsibleAgencyCode_04 { get; set; }
    }
    
    /// <summary>
    // QUANTITY AND ACTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E958")]
    public class E958
    {
        
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string QUANTITY_01 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string StatusDescriptionCode_02 { get; set; }
    }
    
    /// <summary>
    // ADDITIONAL SERVICE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E959")]
    public class E959
    {
        
        /// <summary>
        // Special service description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public string SpecialServiceDescriptionCode_01 { get; set; }
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Time_02 { get; set; }
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        // Location name
        /// </summary>
        [DataMember]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string LocationName_05 { get; set; }
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        /// <summary>
        // Location function code qualifier
        /// </summary>
        [DataMember]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(7)]
        public string LocationFunctionCodeQualifier_07 { get; set; }
        /// <summary>
        // Characteristic description code
        /// </summary>
        [DataMember]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(8)]
        public string CharacteristicDescriptionCode_08 { get; set; }
        /// <summary>
        // First related location identifier
        /// </summary>
        [DataMember]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string FirstRelatedLocationIdentifier_09 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(10)]
        public string COUNTRYIDENTIFIER_10 { get; set; }
        /// <summary>
        // Special service description
        /// </summary>
        [DataMember]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(11)]
        public string SpecialServiceDescription_11 { get; set; }
        /// <summary>
        // Characteristic description
        /// </summary>
        [DataMember]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(12)]
        public string CharacteristicDescription_12 { get; set; }
        /// <summary>
        // ACTION CODE
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(13)]
        public string ACTIONCODE_13 { get; set; }
        /// <summary>
        // Second related location identifier
        /// </summary>
        [DataMember]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(14)]
        public string SecondRelatedLocationIdentifier_14 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(15)]
        public string LANGUAGENAMECODE_15 { get; set; }
        /// <summary>
        // Frequency rate
        /// </summary>
        [DataMember]
        [DataElement("6072", typeof(EDIFACT_N))]
        [Pos(16)]
        public string FrequencyRate_16 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(17)]
        public string MeasurementUnitCode_17 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(18)]
        public string QUANTITY_18 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(19)]
        public string PartyName_19 { get; set; }
    }
    
    /// <summary>
    // TRANSPORT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E961")]
    public class E961
    {
        
        /// <summary>
        // TRANSPORT MEANS DESCRIPTION CODE
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string TRANSPORTMEANSDESCRIPTIONCODE_01 { get; set; }
        /// <summary>
        // Journey stops quantity
        /// </summary>
        [DataMember]
        [DataElement("8216", typeof(EDIFACT_N))]
        [Pos(2)]
        public string JourneyStopsQuantity_02 { get; set; }
        /// <summary>
        // Journey leg duration quantity
        /// </summary>
        [DataMember]
        [DataElement("2162", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string JourneyLegDurationQuantity_03 { get; set; }
        /// <summary>
        // PERCENTAGE
        /// </summary>
        [DataMember]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(4)]
        public string PERCENTAGE_04 { get; set; }
        /// <summary>
        // DAYS OF WEEK SET IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("2160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string DAYSOFWEEKSETIDENTIFIER_05 { get; set; }
        /// <summary>
        // Date or time or period text
        /// </summary>
        [DataMember]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string DateOrTimeOrPeriodText_06 { get; set; }
        /// <summary>
        // Transport means change indicator code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("8215", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string TransportMeansChangeIndicatorCode_07 { get; set; }
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(8)]
        public string LocationIdentifier_08 { get; set; }
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(9)]
        public string LocationIdentifier_09 { get; set; }
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(10)]
        public string LocationIdentifier_10 { get; set; }
    }
    
    /// <summary>
    // TERMINAL INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E962")]
    public class E962
    {
        
        /// <summary>
        // Gate identifier
        /// </summary>
        [DataMember]
        [DataElement("3463", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string GateIdentifier_01 { get; set; }
        /// <summary>
        // First related location identifier
        /// </summary>
        [DataMember]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string FirstRelatedLocationIdentifier_02 { get; set; }
        /// <summary>
        // First related location identifier
        /// </summary>
        [DataMember]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string FirstRelatedLocationIdentifier_03 { get; set; }
    }
    
    /// <summary>
    // DISTANCE OR TIME DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E963")]
    public class E963
    {
        
        /// <summary>
        // Measure
        /// </summary>
        [DataMember]
        [DataElement("6314", typeof(EDIFACT_ID_6314))]
        [Pos(1)]
        public string Measure_01 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(2)]
        public string MeasurementUnitCode_02 { get; set; }
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Time_03 { get; set; }
    }
    
    /// <summary>
    // TRAVELLER TIME DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E964")]
    public class E964
    {
        
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Time_01 { get; set; }
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Time_02 { get; set; }
        /// <summary>
        // Check-in time
        /// </summary>
        [DataMember]
        [DataElement("2156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CheckinTime_03 { get; set; }
    }
    
    /// <summary>
    // FACILITIES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E965")]
    public class E965
    {
        
        /// <summary>
        // Facility type description code
        /// </summary>
        [DataMember]
        [DataElement("9039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FacilityTypeDescriptionCode_01 { get; set; }
        /// <summary>
        // Facility type description
        /// </summary>
        [DataMember]
        [DataElement("9038", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string FacilityTypeDescription_02 { get; set; }
        /// <summary>
        // Product details type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7133", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ProductDetailsTypeCodeQualifier_03 { get; set; }
        /// <summary>
        // Characteristic description code
        /// </summary>
        [DataMember]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(4)]
        public string CharacteristicDescriptionCode_04 { get; set; }
    }
    
    /// <summary>
    // CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E966")]
    public class E966
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
        // Communication address identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string CommunicationAddressIdentifier_02 { get; set; }
        /// <summary>
        // Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CommunicationMediumTypeCode_03 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PartyName_04 { get; set; }
        /// <summary>
        // Reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1154", typeof(EDIFACT_ID_1154))]
        [Pos(5)]
        public string ReferenceIdentifier_05 { get; set; }
    }
    
    /// <summary>
    // CONSUMER REFERENCE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E967")]
    public class E967
    {
        
        /// <summary>
        // Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string ReferenceCodeQualifier_01 { get; set; }
        /// <summary>
        // Reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1154", typeof(EDIFACT_ID_1154))]
        [Pos(2)]
        public string ReferenceIdentifier_02 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string PartyName_03 { get; set; }
        /// <summary>
        // Traveller reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1145", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string TravellerReferenceIdentifier_04 { get; set; }
    }
    
    /// <summary>
    // DOCUMENT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E968")]
    public class E968
    {
        
        /// <summary>
        // Document name code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(1)]
        public string DocumentNameCode_01 { get; set; }
        /// <summary>
        // Document identifier
        /// </summary>
        [DataMember]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string DocumentIdentifier_02 { get; set; }
        /// <summary>
        // Characteristic value description code
        /// </summary>
        [DataMember]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string CharacteristicValueDescriptionCode_03 { get; set; }
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(4)]
        public string LocationIdentifier_04 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(5)]
        public string COUNTRYIDENTIFIER_05 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(6)]
        public string COUNTRYIDENTIFIER_06 { get; set; }
        /// <summary>
        // City name
        /// </summary>
        [DataMember]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string CityName_07 { get; set; }
    }
    
    /// <summary>
    // VALIDITY DATES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E969")]
    public class E969
    {
        
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Date_01 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Date_02 { get; set; }
    }
    
    /// <summary>
    // FREQUENT TRAVELLER IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E970")]
    public class E970
    {
        
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PartyName_01 { get; set; }
        /// <summary>
        // Frequent traveller identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3459", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string FrequentTravellerIdentifier_02 { get; set; }
        /// <summary>
        // Traveller reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1145", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string TravellerReferenceIdentifier_03 { get; set; }
    }
    
    /// <summary>
    // FREE TEXT QUALIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E971")]
    public class E971
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
        // Information type code
        /// </summary>
        [DataMember]
        [DataElement("4473", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string InformationTypeCode_02 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string StatusDescriptionCode_03 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PartyName_04 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string LANGUAGENAMECODE_05 { get; set; }
    }
    
    /// <summary>
    // MESSAGE PROCESSING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E972")]
    public class E972
    {
        
        /// <summary>
        // Business function code
        /// </summary>
        [DataMember]
        [DataElement("4025", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string BusinessFunctionCode_01 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(2)]
        public string MessageFunctionCode_02 { get; set; }
        /// <summary>
        // Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string CodeListResponsibleAgencyCode_03 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(4)]
        public string MessageFunctionCode_04 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(5)]
        public string MessageFunctionCode_05 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(6)]
        public string MessageFunctionCode_06 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(7)]
        public string MessageFunctionCode_07 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(8)]
        public string MessageFunctionCode_08 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(9)]
        public string MessageFunctionCode_09 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(10)]
        public string MessageFunctionCode_10 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(11)]
        public string MessageFunctionCode_11 { get; set; }
        /// <summary>
        // Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(12)]
        public string MessageFunctionCode_12 { get; set; }
    }
    
    /// <summary>
    // DELIVERING SYSTEM DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E973")]
    public class E973
    {
        
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PartyName_01 { get; set; }
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(2)]
        public string LocationIdentifier_02 { get; set; }
        /// <summary>
        // Location name
        /// </summary>
        [DataMember]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string LocationName_03 { get; set; }
    }
    
    /// <summary>
    // ORIGINATOR IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E974")]
    public class E974
    {
        
        /// <summary>
        // Agent identifier
        /// </summary>
        [DataMember]
        [DataElement("3197", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string AgentIdentifier_01 { get; set; }
        /// <summary>
        // In-house identifier
        /// </summary>
        [DataMember]
        [DataElement("3465", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string InhouseIdentifier_02 { get; set; }
        /// <summary>
        // Agent identifier
        /// </summary>
        [DataMember]
        [DataElement("3197", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string AgentIdentifier_03 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PartyName_04 { get; set; }
    }
    
    /// <summary>
    // LOCATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E975")]
    public class E975
    {
        
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(1)]
        public string LocationIdentifier_01 { get; set; }
        /// <summary>
        // Location name
        /// </summary>
        [DataMember]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string LocationName_02 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(3)]
        public string COUNTRYIDENTIFIER_03 { get; set; }
        /// <summary>
        // Location function code qualifier
        /// </summary>
        [DataMember]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(4)]
        public string LocationFunctionCodeQualifier_04 { get; set; }
    }
    
    /// <summary>
    // ORIGINATOR DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E976")]
    public class E976
    {
        
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(1)]
        public string COUNTRYIDENTIFIER_01 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(2)]
        public string CurrencyIdentificationCode_02 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string LANGUAGENAMECODE_03 { get; set; }
    }
    
    /// <summary>
    // PAYMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E977")]
    public class E977
    {
        
        /// <summary>
        // Payment method code
        /// </summary>
        [DataMember]
        [DataElement("4467", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PaymentMethodCode_01 { get; set; }
        /// <summary>
        // Payment purpose code
        /// </summary>
        [DataMember]
        [DataElement("4469", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PaymentPurposeCode_02 { get; set; }
        /// <summary>
        // Service type code
        /// </summary>
        [DataMember]
        [DataElement("5267", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ServiceTypeCode_03 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(4)]
        public string MonetaryAmount_04 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(5)]
        public string CurrencyIdentificationCode_05 { get; set; }
        /// <summary>
        // Reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1154", typeof(EDIFACT_ID_1154))]
        [Pos(6)]
        public string ReferenceIdentifier_06 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Date_07 { get; set; }
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(8)]
        public string LocationIdentifier_08 { get; set; }
    }
    
    /// <summary>
    // CREDIT CARD INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E978")]
    public class E978
    {
        
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PartyName_01 { get; set; }
        /// <summary>
        // Reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1154", typeof(EDIFACT_ID_1154))]
        [Pos(2)]
        public string ReferenceIdentifier_02 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        // Bank identifier
        /// </summary>
        [DataMember]
        [DataElement("3449", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string BankIdentifier_04 { get; set; }
        /// <summary>
        // Traveller reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1145", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string TravellerReferenceIdentifier_05 { get; set; }
    }
    
    /// <summary>
    // RESERVATION CONTROL INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E979")]
    public class E979
    {
        
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PartyName_01 { get; set; }
        /// <summary>
        // Reservation identifier
        /// </summary>
        [DataMember]
        [DataElement("9040", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ReservationIdentifier_02 { get; set; }
        /// <summary>
        // Reservation identifier code qualifier
        /// </summary>
        [DataMember]
        [DataElement("9043", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ReservationIdentifierCodeQualifier_03 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        // Millisecond time
        /// </summary>
        [DataMember]
        [StringLength(9, 9)]
        [DataElement("2164", typeof(EDIFACT_N))]
        [Pos(5)]
        public string MillisecondTime_05 { get; set; }
        /// <summary>
        // Reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1154", typeof(EDIFACT_ID_1154))]
        [Pos(6)]
        public string ReferenceIdentifier_06 { get; set; }
        /// <summary>
        // Adjustment reason description code
        /// </summary>
        [DataMember]
        [DataElement("4465", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string AdjustmentReasonDescriptionCode_07 { get; set; }
    }
    
    /// <summary>
    // SPECIAL REQUIREMENT TYPE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E980")]
    public class E980
    {
        
        /// <summary>
        // Special requirement type code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4187", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SpecialRequirementTypeCode_01 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string StatusDescriptionCode_02 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string QUANTITY_03 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string PartyName_04 { get; set; }
        /// <summary>
        // Processing indicator description code
        /// </summary>
        [DataMember]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string ProcessingIndicatorDescriptionCode_05 { get; set; }
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(7)]
        public string LocationIdentifier_07 { get; set; }
        /// <summary>
        // Characteristic description code
        /// </summary>
        [DataMember]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(8)]
        public string CharacteristicDescriptionCode_08 { get; set; }
    }
    
    /// <summary>
    // SPECIAL REQUIREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E981")]
    public class E981
    {
        
        /// <summary>
        // Special requirement description
        /// </summary>
        [DataMember]
        [DataElement("4184", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string SpecialRequirementDescription_01 { get; set; }
        /// <summary>
        // Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(2)]
        public string MeasurementUnitCode_02 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string QUANTITY_03 { get; set; }
        /// <summary>
        // Traveller reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1145", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string TravellerReferenceIdentifier_04 { get; set; }
        /// <summary>
        // Characteristic value description code
        /// </summary>
        [DataMember]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string CharacteristicValueDescriptionCode_05 { get; set; }
        /// <summary>
        // Characteristic value description code
        /// </summary>
        [DataMember]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string CharacteristicValueDescriptionCode_06 { get; set; }
        /// <summary>
        // Characteristic value description code
        /// </summary>
        [DataMember]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string CharacteristicValueDescriptionCode_07 { get; set; }
        /// <summary>
        // Characteristic value description code
        /// </summary>
        [DataMember]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string CharacteristicValueDescriptionCode_08 { get; set; }
        /// <summary>
        // Characteristic value description code
        /// </summary>
        [DataMember]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string CharacteristicValueDescriptionCode_09 { get; set; }
    }
    
    /// <summary>
    // TARIFF INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E982")]
    public class E982
    {
        
        /// <summary>
        // Rate type identifier
        /// </summary>
        [DataMember]
        [DataElement("5263", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RateTypeIdentifier_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string CurrencyIdentificationCode_03 { get; set; }
        /// <summary>
        // Rate plan code
        /// </summary>
        [DataMember]
        [DataElement("5501", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string RatePlanCode_04 { get; set; }
        /// <summary>
        // Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(5)]
        public string MonetaryAmountTypeCodeQualifier_05 { get; set; }
        /// <summary>
        // PERIOD COUNT QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(6)]
        public string PERIODCOUNTQUANTITY_06 { get; set; }
        /// <summary>
        // Price change type code
        /// </summary>
        [DataMember]
        [DataElement("5377", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string PriceChangeTypeCode_07 { get; set; }
        /// <summary>
        // Total monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5160", typeof(EDIFACT_N))]
        [Pos(8)]
        public string TotalMonetaryAmount_08 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Date_09 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string Date_10 { get; set; }
        /// <summary>
        // SPECIAL CONDITION CODE
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_AN))]
        [Pos(11)]
        public string SPECIALCONDITIONCODE_11 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(12)]
        public string QUANTITY_12 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(13)]
        public string StatusDescriptionCode_13 { get; set; }
    }
    
    /// <summary>
    // RATE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E983")]
    public class E983
    {
        
        /// <summary>
        // Rate or tariff class description code
        /// </summary>
        [DataMember]
        [DataElement("5243", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string RateOrTariffClassDescriptionCode_01 { get; set; }
        /// <summary>
        // Range minimum quantity
        /// </summary>
        [DataMember]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(2)]
        public string RangeMinimumQuantity_02 { get; set; }
        /// <summary>
        // Range maximum quantity
        /// </summary>
        [DataMember]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(3)]
        public string RangeMaximumQuantity_03 { get; set; }
        /// <summary>
        // Processing indicator description code
        /// </summary>
        [DataMember]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ProcessingIndicatorDescriptionCode_04 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(5)]
        public string CurrencyIdentificationCode_05 { get; set; }
    }
    
    /// <summary>
    // ASSOCIATED CHARGES INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E984")]
    public class E984
    {
        
        /// <summary>
        // Charge unit code
        /// </summary>
        [DataMember]
        [DataElement("5261", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ChargeUnitCode_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Item description
        /// </summary>
        [DataMember]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ItemDescription_03 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string QUANTITY_04 { get; set; }
        /// <summary>
        // Charge period type code
        /// </summary>
        [DataMember]
        [DataElement("2155", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string ChargePeriodTypeCode_05 { get; set; }
        /// <summary>
        // Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(6)]
        public string CurrencyIdentificationCode_06 { get; set; }
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(7)]
        public string LocationIdentifier_07 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string FreeText_08 { get; set; }
        /// <summary>
        // MAINTENANCE OPERATION CODE
        /// </summary>
        [DataMember]
        [DataElement("4513", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string MAINTENANCEOPERATIONCODE_09 { get; set; }
        /// <summary>
        // Requirement designator code
        /// </summary>
        [DataMember]
        [DataElement("7299", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string RequirementDesignatorCode_10 { get; set; }
        /// <summary>
        // Age
        /// </summary>
        [DataMember]
        [DataElement("2018", typeof(EDIFACT_N))]
        [Pos(11)]
        public string Age_11 { get; set; }
        /// <summary>
        // PERCENTAGE
        /// </summary>
        [DataMember]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(12)]
        public string PERCENTAGE_12 { get; set; }
    }
    
    /// <summary>
    // TRAVELLER SURNAME AND RELATED INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E985")]
    public class E985
    {
        
        /// <summary>
        // FAMILY NAME
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3500", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FAMILYNAME_01 { get; set; }
        /// <summary>
        // Party function code qualifier
        /// </summary>
        [DataMember]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(2)]
        public string PartyFunctionCodeQualifier_02 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string QUANTITY_03 { get; set; }
        /// <summary>
        // Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(4)]
        public string StatusDescriptionCode_04 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string LANGUAGENAMECODE_05 { get; set; }
    }
    
    /// <summary>
    // TRAVELLER DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E986")]
    public class E986
    {
        
        /// <summary>
        // Given name
        /// </summary>
        [DataMember]
        [DataElement("3460", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string GivenName_01 { get; set; }
        /// <summary>
        // Party function code qualifier
        /// </summary>
        [DataMember]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(2)]
        public string PartyFunctionCodeQualifier_02 { get; set; }
        /// <summary>
        // Traveller reference identifier
        /// </summary>
        [DataMember]
        [DataElement("1145", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string TravellerReferenceIdentifier_03 { get; set; }
        /// <summary>
        // Given name title description
        /// </summary>
        [DataMember]
        [DataElement("3504", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string GivenNameTitleDescription_04 { get; set; }
        /// <summary>
        // Traveller accompanied by infant indicator code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("8219", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string TravellerAccompaniedByInfantIndicatorCode_05 { get; set; }
        /// <summary>
        // LANGUAGE NAME CODE
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string LANGUAGENAMECODE_06 { get; set; }
        /// <summary>
        // Gender code
        /// </summary>
        [DataMember]
        [DataElement("3499", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string GenderCode_07 { get; set; }
        /// <summary>
        // Age
        /// </summary>
        [DataMember]
        [DataElement("2018", typeof(EDIFACT_N))]
        [Pos(8)]
        public string Age_08 { get; set; }
    }
    
    /// <summary>
    // PRODUCT DATE AND TIME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E987")]
    public class E987
    {
        
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Date_01 { get; set; }
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Time_02 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Time_04 { get; set; }
        /// <summary>
        // Date variation number
        /// </summary>
        [DataMember]
        [DataElement("2148", typeof(EDIFACT_N))]
        [Pos(5)]
        public string DateVariationNumber_05 { get; set; }
    }
    
    /// <summary>
    // COMPANY IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E988")]
    public class E988
    {
        
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string PartyName_01 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PartyName_02 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string PartyName_03 { get; set; }
    }
    
    /// <summary>
    // PRODUCT IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E989")]
    public class E989
    {
        
        /// <summary>
        // Product identifier
        /// </summary>
        [DataMember]
        [DataElement("7135", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ProductIdentifier_01 { get; set; }
        /// <summary>
        // Characteristic description code
        /// </summary>
        [DataMember]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(2)]
        public string CharacteristicDescriptionCode_02 { get; set; }
        /// <summary>
        // Product characteristic identification code
        /// </summary>
        [DataMember]
        [DataElement("7139", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ProductCharacteristicIdentificationCode_03 { get; set; }
        /// <summary>
        // Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(4)]
        public string ItemDescriptionCode_04 { get; set; }
        /// <summary>
        // Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(5)]
        public string ItemDescriptionCode_05 { get; set; }
        /// <summary>
        // Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(6)]
        public string ItemDescriptionCode_06 { get; set; }
        /// <summary>
        // Product name
        /// </summary>
        [DataMember]
        [DataElement("9608", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string ProductName_07 { get; set; }
    }
    
    /// <summary>
    // SEQUENCE NUMBER DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E990")]
    public class E990
    {
        
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(1)]
        public string SequencePositionIdentifier_01 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(2)]
        public string SequencePositionIdentifier_02 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(3)]
        public string SequencePositionIdentifier_03 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(4)]
        public string SequencePositionIdentifier_04 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(5)]
        public string SequencePositionIdentifier_05 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(6)]
        public string SequencePositionIdentifier_06 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(7)]
        public string SequencePositionIdentifier_07 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(8)]
        public string SequencePositionIdentifier_08 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(9)]
        public string SequencePositionIdentifier_09 { get; set; }
    }
    
    /// <summary>
    // VEHICLE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E991")]
    public class E991
    {
        
        /// <summary>
        // Equipment size and type description
        /// </summary>
        [DataMember]
        [DataElement("8154", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string EquipmentSizeAndTypeDescription_01 { get; set; }
        /// <summary>
        // Object identifier
        /// </summary>
        [DataMember]
        [DataElement("7402", typeof(EDIFACT_ID_7402))]
        [Pos(2)]
        public string ObjectIdentifier_02 { get; set; }
    }
    
    /// <summary>
    // POSITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E992")]
    public class E992
    {
        
        /// <summary>
        // First related location identifier
        /// </summary>
        [DataMember]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string FirstRelatedLocationIdentifier_01 { get; set; }
        /// <summary>
        // Second related location identifier
        /// </summary>
        [DataMember]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string SecondRelatedLocationIdentifier_02 { get; set; }
    }
    
    /// <summary>
    // TOUR DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E993")]
    public class E993
    {
        
        /// <summary>
        // Product identifier
        /// </summary>
        [DataMember]
        [DataElement("7135", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ProductIdentifier_01 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PartyName_02 { get; set; }
        /// <summary>
        // Length measure
        /// </summary>
        [DataMember]
        [DataElement("6168", typeof(EDIFACT_N))]
        [Pos(3)]
        public string LengthMeasure_03 { get; set; }
        /// <summary>
        // Journey stops quantity
        /// </summary>
        [DataMember]
        [DataElement("8216", typeof(EDIFACT_N))]
        [Pos(4)]
        public string JourneyStopsQuantity_04 { get; set; }
        /// <summary>
        // DAYS OF WEEK SET IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("2160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string DAYSOFWEEKSETIDENTIFIER_05 { get; set; }
        /// <summary>
        // Units quantity
        /// </summary>
        [DataMember]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(6)]
        public string UnitsQuantity_06 { get; set; }
        /// <summary>
        // QUANTITY
        /// </summary>
        [DataMember]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string QUANTITY_07 { get; set; }
    }
    
    /// <summary>
    // STOPOVER INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E994")]
    public class E994
    {
        
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(1)]
        public string LocationIdentifier_01 { get; set; }
        /// <summary>
        // Units quantity
        /// </summary>
        [DataMember]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(2)]
        public string UnitsQuantity_02 { get; set; }
    }
    
    /// <summary>
    // MOVEMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E995")]
    public class E995
    {
        
        /// <summary>
        // Service requirement code
        /// </summary>
        [DataMember]
        [DataElement("7273", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ServiceRequirementCode_01 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [DataElement("2000", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Time_03 { get; set; }
    }
    
    /// <summary>
    // PRODUCT CLASS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E996")]
    public class E996
    {
        
        /// <summary>
        // Characteristic description code
        /// </summary>
        [DataMember]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(1)]
        public string CharacteristicDescriptionCode_01 { get; set; }
        /// <summary>
        // Requested information description
        /// </summary>
        [DataMember]
        [DataElement("4510", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string RequestedInformationDescription_02 { get; set; }
        /// <summary>
        // Special service description code
        /// </summary>
        [DataMember]
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(3)]
        public string SpecialServiceDescriptionCode_03 { get; set; }
        /// <summary>
        // Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(4)]
        public string ItemDescriptionCode_04 { get; set; }
        /// <summary>
        // Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(5)]
        public string ItemDescriptionCode_05 { get; set; }
        /// <summary>
        // Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(6)]
        public string ItemDescriptionCode_06 { get; set; }
        /// <summary>
        // Product characteristic identification code
        /// </summary>
        [DataMember]
        [DataElement("7139", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string ProductCharacteristicIdentificationCode_07 { get; set; }
    }
    
    /// <summary>
    // ACCOMMODATION ALLOCATION INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E997")]
    public class E997
    {
        
        /// <summary>
        // Reference identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1154", typeof(EDIFACT_ID_1154))]
        [Pos(1)]
        public string ReferenceIdentifier_01 { get; set; }
        /// <summary>
        // Relationship description code
        /// </summary>
        [DataMember]
        [DataElement("9143", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string RelationshipDescriptionCode_02 { get; set; }
        /// <summary>
        // Special requirement type code
        /// </summary>
        [DataMember]
        [DataElement("4187", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string SpecialRequirementTypeCode_03 { get; set; }
        /// <summary>
        // Characteristic value description code
        /// </summary>
        [DataMember]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string CharacteristicValueDescriptionCode_04 { get; set; }
        /// <summary>
        // Special requirement description
        /// </summary>
        [DataMember]
        [DataElement("4184", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string SpecialRequirementDescription_05 { get; set; }
    }
    
    /// <summary>
    // DISCOUNT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E998")]
    public class E998
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
        // PERCENTAGE
        /// </summary>
        [DataMember]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string PERCENTAGE_02 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string PartyName_03 { get; set; }
        /// <summary>
        // Units quantity
        /// </summary>
        [DataMember]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(4)]
        public string UnitsQuantity_04 { get; set; }
    }
    
    /// <summary>
    // CONNECTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E999")]
    public class E999
    {
        
        /// <summary>
        // Location identifier
        /// </summary>
        [DataMember]
        [DataElement("3225", typeof(EDIFACT_ID_3225))]
        [Pos(1)]
        public string LocationIdentifier_01 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string PartyName_02 { get; set; }
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        // Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("2002", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Time_04 { get; set; }
        /// <summary>
        // Location name
        /// </summary>
        [DataMember]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string LocationName_05 { get; set; }
        /// <summary>
        // Location function code qualifier
        /// </summary>
        [DataMember]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(6)]
        public string LocationFunctionCodeQualifier_06 { get; set; }
        /// <summary>
        // COUNTRY IDENTIFIER
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(7)]
        public string COUNTRYIDENTIFIER_07 { get; set; }
        /// <summary>
        // Sequence position identifier
        /// </summary>
        [DataMember]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(8)]
        public string SequencePositionIdentifier_08 { get; set; }
    }
}
