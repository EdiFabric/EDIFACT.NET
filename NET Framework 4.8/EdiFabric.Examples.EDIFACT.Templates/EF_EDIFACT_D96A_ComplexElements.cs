namespace EdiFabric.Templates.Edifact
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [Composite("C002")]
    public class C002
    {
        
        /// <summary>
        /// Document/message name, coded
        /// </summary>
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(1)]
        public string Documentmessagenamecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Document/message name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentmessagename_04 { get; set; }
    }
    
    /// <summary>
    /// CARRIER
    /// </summary>
    [Serializable()]
    [Composite("C040")]
    public class C040
    {
        
        /// <summary>
        /// Carrier identification
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Carrieridentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Carrier name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3128", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Carriername_04 { get; set; }
    }
    
    /// <summary>
    /// DEPARTMENT OR EMPLOYEE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C056")]
    public class C056
    {
        
        /// <summary>
        /// Department or employee identification
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("3413", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Departmentoremployeeidentification_01 { get; set; }
        /// <summary>
        /// Department or employee
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3412", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Departmentoremployee_02 { get; set; }
    }
    
    /// <summary>
    /// NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [Composite("C058")]
    public class C058
    {
        
        /// <summary>
        /// Name and address line
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Nameandaddressline_01 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Nameandaddressline_02 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Nameandaddressline_03 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nameandaddressline_04 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nameandaddressline_05 { get; set; }
    }
    
    /// <summary>
    /// STREET
    /// </summary>
    [Serializable()]
    [Composite("C059")]
    public class C059
    {
        
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Streetandnumberpobox_01 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Streetandnumberpobox_02 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Streetandnumberpobox_03 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Streetandnumberpobox_04 { get; set; }
    }
    
    /// <summary>
    /// COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [Composite("C076")]
    public class C076
    {
        
        /// <summary>
        /// Communication number
        /// </summary>
        [Required]
        [StringLength(1, 512)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Communicationnumber_01 { get; set; }
        /// <summary>
        /// Communication channel qualifier
        /// </summary>
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155))]
        [Pos(2)]
        public string Communicationchannelqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// ACCOUNT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C078")]
    public class C078
    {
        
        /// <summary>
        /// Account holder number
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Accountholdernumber_01 { get; set; }
        /// <summary>
        /// Account holder name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Accountholdername_02 { get; set; }
        /// <summary>
        /// Account holder name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Accountholdername_03 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Currencycoded_04 { get; set; }
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
        [Required]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyname_01 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Partyname_02 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Partyname_03 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Partyname_04 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Partyname_05 { get; set; }
        /// <summary>
        /// Party name format, coded
        /// </summary>
        [DataElement("3045", typeof(EDIFACT_ID_3045))]
        [Pos(6)]
        public string Partynameformatcoded_06 { get; set; }
    }
    
    /// <summary>
    /// PARTY IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C082")]
    public class C082
    {
        
        /// <summary>
        /// Party id. identification
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("3039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyididentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// INSTITUTION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C088")]
    public class C088
    {
        
        /// <summary>
        /// Institution name identification
        /// </summary>
        [StringLength(1, 11)]
        [DataElement("3433", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Institutionnameidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Institution branch number
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Institutionbranchnumber_04 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistqualifier_05 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string Codelistresponsibleagencycoded_06 { get; set; }
        /// <summary>
        /// Institution name
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("3432", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Institutionname_07 { get; set; }
        /// <summary>
        /// Institution branch place
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("3436", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Institutionbranchplace_08 { get; set; }
    }
    
    /// <summary>
    /// TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [Composite("C100")]
    public class C100
    {
        
        /// <summary>
        /// Terms of delivery or transport, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("4053", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Termsofdeliveryortransportcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Terms of delivery or transport
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Termsofdeliveryortransport_04 { get; set; }
        /// <summary>
        /// Terms of delivery or transport
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Termsofdeliveryortransport_05 { get; set; }
    }
    
    /// <summary>
    /// TEXT REFERENCE
    /// </summary>
    [Serializable()]
    [Composite("C107")]
    public class C107
    {
        
        /// <summary>
        /// Free text, coded
        /// </summary>
        [Required]
        [StringLength(1, 3)]
        [DataElement("4441", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetextcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
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
        [Required]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetext_01 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Freetext_02 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Freetext_03 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freetext_04 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Freetext_05 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT TERMS
    /// </summary>
    [Serializable()]
    [Composite("C110")]
    public class C110
    {
        
        /// <summary>
        /// Terms of payment identification
        /// </summary>
        [Required]
        [DataElement("4277", typeof(EDIFACT_ID_4277))]
        [Pos(1)]
        public string Termsofpaymentidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Terms of payment
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Termsofpayment_04 { get; set; }
        /// <summary>
        /// Terms of payment
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Termsofpayment_05 { get; set; }
    }
    
    /// <summary>
    /// TERMS/TIME INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C112")]
    public class C112
    {
        
        /// <summary>
        /// Payment time reference, coded
        /// </summary>
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475))]
        [Pos(1)]
        public string Paymenttimereferencecoded_01 { get; set; }
        /// <summary>
        /// Time relation, coded
        /// </summary>
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Timerelationcoded_02 { get; set; }
        /// <summary>
        /// Type of period, coded
        /// </summary>
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(3)]
        public string Typeofperiodcoded_03 { get; set; }
        /// <summary>
        /// Number of periods
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Numberofperiods_04 { get; set; }
    }
    
    /// <summary>
    /// RATE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C128")]
    public class C128
    {
        
        /// <summary>
        /// Rate type qualifier
        /// </summary>
        [Required]
        [DataElement("5419", typeof(EDIFACT_ID_5419))]
        [Pos(1)]
        public string Ratetypequalifier_01 { get; set; }
        /// <summary>
        /// Rate per unit
        /// </summary>
        [Required]
        [StringLength(1, 15)]
        [DataElement("5420", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Rateperunit_02 { get; set; }
        /// <summary>
        /// Unit price basis
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Unitpricebasis_03 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Measureunitqualifier_04 { get; set; }
    }
    
    /// <summary>
    /// PRICE MULTIPLIER INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C138")]
    public class C138
    {
        
        /// <summary>
        /// Price multiplier
        /// </summary>
        [Required]
        [StringLength(1, 12)]
        [DataElement("5394", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Pricemultiplier_01 { get; set; }
        /// <summary>
        /// Price multiplier qualifier
        /// </summary>
        [DataElement("5393", typeof(EDIFACT_ID_5393))]
        [Pos(2)]
        public string Pricemultiplierqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [Composite("C174")]
    public class C174
    {
        
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [Required]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimum_03 { get; set; }
        /// <summary>
        /// Range maximum
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximum_04 { get; set; }
        /// <summary>
        /// Significant digits
        /// </summary>
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigits_05 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C186")]
    public class C186
    {
        
        /// <summary>
        /// Quantity qualifier
        /// </summary>
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string Quantityqualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [Required]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [Composite("C202")]
    public class C202
    {
        
        /// <summary>
        /// Type of packages identification
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("7065", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofpackagesidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
    }
    
    /// <summary>
    /// IDENTIFICATION NUMBER
    /// </summary>
    [Serializable()]
    [Composite("C206")]
    public class C206
    {
        
        /// <summary>
        /// Identity number
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Identitynumber_01 { get; set; }
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
    }
    
    /// <summary>
    /// IDENTITY NUMBER RANGE
    /// </summary>
    [Serializable()]
    [Composite("C208")]
    public class C208
    {
        
        /// <summary>
        /// Identity number
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Identitynumber_01 { get; set; }
        /// <summary>
        /// Identity number
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Identitynumber_02 { get; set; }
    }
    
    /// <summary>
    /// MARKS & LABELS
    /// </summary>
    [Serializable()]
    [Composite("C210")]
    public class C210
    {
        
        /// <summary>
        /// Shipping marks
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Shippingmarks_01 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Shippingmarks_02 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Shippingmarks_03 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Shippingmarks_04 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Shippingmarks_05 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Shippingmarks_06 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Shippingmarks_07 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Shippingmarks_08 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Shippingmarks_09 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string Shippingmarks_10 { get; set; }
    }
    
    /// <summary>
    /// ITEM NUMBER IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C212")]
    public class C212
    {
        
        /// <summary>
        /// Item number
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemnumber_01 { get; set; }
        /// <summary>
        /// Item number type, coded
        /// </summary>
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemnumbertypecoded_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
    }
    
    /// <summary>
    /// SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C214")]
    public class C214
    {
        
        /// <summary>
        /// Special services, coded
        /// </summary>
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public string Specialservicescoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Special service
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservice_04 { get; set; }
        /// <summary>
        /// Special service
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservice_05 { get; set; }
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
        [StringLength(1, 4)]
        [DataElement("7419", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hazardousmaterialclasscodeidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        /// Mode of transport, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("8067", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Modeoftransportcoded_01 { get; set; }
        /// <summary>
        /// Mode of transport
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Modeoftransport_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C222")]
    public class C222
    {
        
        /// <summary>
        /// Id. of means of transport identification
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("8213", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Idofmeansoftransportidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Id. of the means of transport
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Idofthemeansoftransport_04 { get; set; }
        /// <summary>
        /// Nationality of means of transport, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("8453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nationalityofmeansoftransportcoded_05 { get; set; }
    }
    
    /// <summary>
    /// EQUIPMENT SIZE AND TYPE
    /// </summary>
    [Serializable()]
    [Composite("C224")]
    public class C224
    {
        
        /// <summary>
        /// Equipment size and type identification
        /// </summary>
        [DataElement("8155", typeof(EDIFACT_ID_8155))]
        [Pos(1)]
        public string Equipmentsizeandtypeidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Equipment size and type
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("8154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Equipmentsizeandtype_04 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [Composite("C228")]
    public class C228
    {
        
        /// <summary>
        /// Type of means of transport identification
        /// </summary>
        [DataElement("8179", typeof(EDIFACT_ID_8179))]
        [Pos(1)]
        public string Typeofmeansoftransportidentification_01 { get; set; }
        /// <summary>
        /// Type of means of transport
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofmeansoftransport_02 { get; set; }
    }
    
    /// <summary>
    /// EQUIPMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C237")]
    public class C237
    {
        
        /// <summary>
        /// Equipment identification number
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("8260", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Equipmentidentificationnumber_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Country, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrycoded_04 { get; set; }
    }
    
    /// <summary>
    /// PRODUCT CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [Composite("C240")]
    public class C240
    {
        
        /// <summary>
        /// Characteristic identification
        /// </summary>
        [Required]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Characteristicidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Characteristic
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristic_04 { get; set; }
        /// <summary>
        /// Characteristic
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Characteristic_05 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE TYPE
    /// </summary>
    [Serializable()]
    [Composite("C241")]
    public class C241
    {
        
        /// <summary>
        /// Duty/tax/fee type, coded
        /// </summary>
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string Dutytaxfeetypecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Duty/tax/fee type
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeetype_04 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE DETAIL
    /// </summary>
    [Serializable()]
    [Composite("C243")]
    public class C243
    {
        
        /// <summary>
        /// Duty/tax/fee rate identification
        /// </summary>
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutytaxfeerateidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Duty/tax/fee rate
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeerate_04 { get; set; }
        /// <summary>
        /// Duty/tax/fee rate basis identification
        /// </summary>
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string Dutytaxfeeratebasisidentification_05 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistqualifier_06 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycoded_07 { get; set; }
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
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069))]
        [Pos(1)]
        public string Controlqualifier_01 { get; set; }
        /// <summary>
        /// Control value
        /// </summary>
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controlvalue_02 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [Composite("C273")]
    public class C273
    {
        
        /// <summary>
        /// Item description identification
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("7009", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemdescriptionidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Languagecoded_06 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DIFFERENCE INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C279")]
    public class C279
    {
        
        /// <summary>
        /// Quantity difference
        /// </summary>
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantitydifference_01 { get; set; }
        /// <summary>
        /// Quantity qualifier
        /// </summary>
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(2)]
        public string Quantityqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// RANGE
    /// </summary>
    [Serializable()]
    [Composite("C280")]
    public class C280
    {
        
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [Required]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }
        /// <summary>
        /// Range minimum
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Rangeminimum_02 { get; set; }
        /// <summary>
        /// Range maximum
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangemaximum_03 { get; set; }
    }
    
    /// <summary>
    /// PATTERN DESCRIPTION
    /// </summary>
    [Serializable()]
    [Composite("C329")]
    public class C329
    {
        
        /// <summary>
        /// Frequency, coded
        /// </summary>
        [DataElement("2013", typeof(EDIFACT_ID_2013))]
        [Pos(1)]
        public string Frequencycoded_01 { get; set; }
        /// <summary>
        /// Despatch pattern, coded
        /// </summary>
        [DataElement("2015", typeof(EDIFACT_ID_2015))]
        [Pos(2)]
        public string Despatchpatterncoded_02 { get; set; }
        /// <summary>
        /// Despatch pattern timing, coded
        /// </summary>
        [DataElement("2017", typeof(EDIFACT_ID_2017))]
        [Pos(3)]
        public string Despatchpatterntimingcoded_03 { get; set; }
    }
    
    /// <summary>
    /// EXCESS TRANSPORTATION INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C401")]
    public class C401
    {
        
        /// <summary>
        /// Excess transportation reason, coded
        /// </summary>
        [Required]
        [DataElement("8457", typeof(EDIFACT_ID_8457))]
        [Pos(1)]
        public string Excesstransportationreasoncoded_01 { get; set; }
        /// <summary>
        /// Excess transportation responsibility, coded
        /// </summary>
        [Required]
        [DataElement("8459", typeof(EDIFACT_ID_8459))]
        [Pos(2)]
        public string Excesstransportationresponsibilitycoded_02 { get; set; }
        /// <summary>
        /// Customer authorization number
        /// </summary>
        [StringLength(1, 17)]
        [DataElement("7130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Customerauthorizationnumber_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C402")]
    public class C402
    {
        
        /// <summary>
        /// Item description type, coded
        /// </summary>
        [Required]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Itemdescriptiontypecoded_01 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofpackages_02 { get; set; }
        /// <summary>
        /// Item number type, coded
        /// </summary>
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(3)]
        public string Itemnumbertypecoded_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
        /// <summary>
        /// Item number type, coded
        /// </summary>
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(5)]
        public string Itemnumbertypecoded_05 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C501")]
    public class C501
    {
        
        /// <summary>
        /// Percentage qualifier
        /// </summary>
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string Percentagequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis, coded
        /// </summary>
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasiscoded_03 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistqualifier_04 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycoded_05 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C502")]
    public class C502
    {
        
        /// <summary>
        /// Measurement dimension, coded
        /// </summary>
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public string Measurementdimensioncoded_01 { get; set; }
        /// <summary>
        /// Measurement significance, coded
        /// </summary>
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string Measurementsignificancecoded_02 { get; set; }
        /// <summary>
        /// Measurement attribute, coded
        /// </summary>
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Measurementattributecoded_03 { get; set; }
        /// <summary>
        /// Measurement attribute
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Measurementattribute_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C503")]
    public class C503
    {
        
        /// <summary>
        /// Document/message number
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentmessagenumber_01 { get; set; }
        /// <summary>
        /// Document/message status, coded
        /// </summary>
        [DataElement("1373", typeof(EDIFACT_ID_1373))]
        [Pos(2)]
        public string Documentmessagestatuscoded_02 { get; set; }
        /// <summary>
        /// Document/message source
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentmessagesource_03 { get; set; }
        /// <summary>
        /// Language, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Languagecoded_04 { get; set; }
    }
    
    /// <summary>
    /// CURRENCY DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C504")]
    public class C504
    {
        
        /// <summary>
        /// Currency details qualifier
        /// </summary>
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string Currencydetailsqualifier_01 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Currencycoded_02 { get; set; }
        /// <summary>
        /// Currency qualifier
        /// </summary>
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string Currencyqualifier_03 { get; set; }
        /// <summary>
        /// Currency rate base
        /// </summary>
        [StringLength(1, 4)]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Currencyratebase_04 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [Composite("C506")]
    public class C506
    {
        
        /// <summary>
        /// Reference qualifier
        /// </summary>
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencequalifier_01 { get; set; }
        /// <summary>
        /// Reference number
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referencenumber_02 { get; set; }
        /// <summary>
        /// Line number
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Linenumber_03 { get; set; }
        /// <summary>
        /// Reference version number
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionnumber_04 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [Composite("C507")]
    public class C507
    {
        
        /// <summary>
        /// Date/time/period qualifier
        /// </summary>
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Datetimeperiodqualifier_01 { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Datetimeperiod_02 { get; set; }
        /// <summary>
        /// Date/time/period format qualifier
        /// </summary>
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Datetimeperiodformatqualifier_03 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C509")]
    public class C509
    {
        
        /// <summary>
        /// Price qualifier
        /// </summary>
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125))]
        [Pos(1)]
        public string Pricequalifier_01 { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Price_02 { get; set; }
        /// <summary>
        /// Price type, coded
        /// </summary>
        [DataElement("5375", typeof(EDIFACT_ID_5375))]
        [Pos(3)]
        public string Pricetypecoded_03 { get; set; }
        /// <summary>
        /// Price type qualifier
        /// </summary>
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public string Pricetypequalifier_04 { get; set; }
        /// <summary>
        /// Unit price basis
        /// </summary>
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasis_05 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Measureunitqualifier_06 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [Composite("C516")]
    public class C516
    {
        
        /// <summary>
        /// Monetary amount type qualifier
        /// </summary>
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Currencycoded_03 { get; set; }
        /// <summary>
        /// Currency qualifier
        /// </summary>
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencyqualifier_04 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statuscoded_05 { get; set; }
    }
    
    /// <summary>
    /// LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C517")]
    public class C517
    {
        
        /// <summary>
        /// Place/location identification
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Placelocationidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Place/location
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Placelocation_04 { get; set; }
    }
    
    /// <summary>
    /// RELATED LOCATION ONE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C519")]
    public class C519
    {
        
        /// <summary>
        /// Related place/location one identification
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relatedplacelocationoneidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Related place/location one
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Relatedplacelocationone_04 { get; set; }
    }
    
    /// <summary>
    /// INSTRUCTION
    /// </summary>
    [Serializable()]
    [Composite("C522")]
    public class C522
    {
        
        /// <summary>
        /// Instruction qualifier
        /// </summary>
        [Required]
        [DataElement("4403", typeof(EDIFACT_ID_4403))]
        [Pos(1)]
        public string Instructionqualifier_01 { get; set; }
        /// <summary>
        /// Instruction, coded
        /// </summary>
        [DataElement("4401", typeof(EDIFACT_ID_4401))]
        [Pos(2)]
        public string Instructioncoded_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        /// <summary>
        /// Instruction
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("4400", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Instruction_05 { get; set; }
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
        [StringLength(1, 3)]
        [DataElement("4079", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Handlinginstructionscoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Handling instructions
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Handlinginstructions_04 { get; set; }
    }
    
    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C531")]
    public class C531
    {
        
        /// <summary>
        /// Packaging level, coded
        /// </summary>
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcoded_01 { get; set; }
        /// <summary>
        /// Packaging related information, coded
        /// </summary>
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(2)]
        public string Packagingrelatedinformationcoded_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions, coded
        /// </summary>
        [DataElement("7073", typeof(EDIFACT_ID_7073))]
        [Pos(3)]
        public string Packagingtermsandconditionscoded_03 { get; set; }
    }
    
    /// <summary>
    /// RETURNABLE PACKAGE DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C532")]
    public class C532
    {
        
        /// <summary>
        /// Returnable package freight payment responsibility, coded
        /// </summary>
        [DataElement("8395", typeof(EDIFACT_ID_8395))]
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycoded_01 { get; set; }
        /// <summary>
        /// Returnable package load contents, coded
        /// </summary>
        [DataElement("8393", typeof(EDIFACT_ID_8393))]
        [Pos(2)]
        public string Returnablepackageloadcontentscoded_02 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE ACCOUNT DETAIL
    /// </summary>
    [Serializable()]
    [Composite("C533")]
    public class C533
    {
        
        /// <summary>
        /// Duty/tax/fee account identification
        /// </summary>
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutytaxfeeaccountidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [Composite("C534")]
    public class C534
    {
        
        /// <summary>
        /// Payment conditions, coded
        /// </summary>
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public string Paymentconditionscoded_01 { get; set; }
        /// <summary>
        /// Payment guarantee, coded
        /// </summary>
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteecoded_02 { get; set; }
        /// <summary>
        /// Payment means, coded
        /// </summary>
        [DataElement("4461", typeof(EDIFACT_ID_4461))]
        [Pos(3)]
        public string Paymentmeanscoded_03 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistqualifier_04 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycoded_05 { get; set; }
        /// <summary>
        /// Payment channel, coded
        /// </summary>
        [DataElement("4435", typeof(EDIFACT_ID_4435))]
        [Pos(6)]
        public string Paymentchannelcoded_06 { get; set; }
    }
    
    /// <summary>
    /// REQUIREMENT/CONDITION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C550")]
    public class C550
    {
        
        /// <summary>
        /// Requirement/condition identification
        /// </summary>
        [Required]
        [StringLength(1, 17)]
        [DataElement("7295", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Requirementconditionidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Requirement or condition
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Requirementorcondition_04 { get; set; }
    }
    
    /// <summary>
    /// ALLOWANCE/CHARGE INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C552")]
    public class C552
    {
        
        /// <summary>
        /// Allowance or charge number
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargenumber_01 { get; set; }
        /// <summary>
        /// Charge/allowance description, coded
        /// </summary>
        [DataElement("5189", typeof(EDIFACT_ID_5189))]
        [Pos(2)]
        public string Chargeallowancedescriptioncoded_02 { get; set; }
    }
    
    /// <summary>
    /// RELATED LOCATION TWO IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Composite("C553")]
    public class C553
    {
        
        /// <summary>
        /// Related place/location two identification
        /// </summary>
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relatedplacelocationtwoidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Related place/location two
        /// </summary>
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Relatedplacelocationtwo_04 { get; set; }
    }
    
    /// <summary>
    /// TYPE OF MARKING
    /// </summary>
    [Serializable()]
    [Composite("C827")]
    public class C827
    {
        
        /// <summary>
        /// Type of marking, coded
        /// </summary>
        [Required]
        [StringLength(1, 3)]
        [DataElement("7511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofmarkingcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// SUB-LINE INFORMATION
    /// </summary>
    [Serializable()]
    [Composite("C829")]
    public class C829
    {
        
        /// <summary>
        /// Sub-line indicator, coded
        /// </summary>
        [DataElement("5495", typeof(EDIFACT_ID_5495))]
        [Pos(1)]
        public string Sublineindicatorcoded_01 { get; set; }
        /// <summary>
        /// Line item number
        /// </summary>
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lineitemnumber_02 { get; set; }
    }
    
    /// <summary>
    /// PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [Composite("C849")]
    public class C849
    {
        
        /// <summary>
        /// Party enacting instruction identification
        /// </summary>
        [Required]
        [DataElement("3301", typeof(EDIFACT_ID_3301))]
        [Pos(1)]
        public string Partyenactinginstructionidentification_01 { get; set; }
        /// <summary>
        /// Recipient of the instruction identification
        /// </summary>
        [DataElement("3285", typeof(EDIFACT_ID_3285))]
        [Pos(2)]
        public string Recipientoftheinstructionidentification_02 { get; set; }
    }
    
    /// <summary>
    /// STATUS OF INSTRUCTION
    /// </summary>
    [Serializable()]
    [Composite("C850")]
    public class C850
    {
        
        /// <summary>
        /// Status, coded
        /// </summary>
        [Required]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(1)]
        public string Statuscoded_01 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Partyname_02 { get; set; }
    }
    
    /// <summary>
    /// CHARACTERISTIC VALUE
    /// </summary>
    [Serializable()]
    [Composite("C889")]
    public class C889
    {
        
        /// <summary>
        /// Characteristic value, coded
        /// </summary>
        [StringLength(1, 3)]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Characteristicvaluecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Characteristic value
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristicvalue_04 { get; set; }
        /// <summary>
        /// Characteristic value
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Characteristicvalue_05 { get; set; }
    }
    
    /// <summary>
    /// REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [Composite("C960")]
    public class C960
    {
        
        /// <summary>
        /// Change reason, coded
        /// </summary>
        [DataElement("4295", typeof(EDIFACT_ID_4295))]
        [Pos(1)]
        public string Changereasoncoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Change reason
        /// </summary>
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereason_04 { get; set; }
    }
}
