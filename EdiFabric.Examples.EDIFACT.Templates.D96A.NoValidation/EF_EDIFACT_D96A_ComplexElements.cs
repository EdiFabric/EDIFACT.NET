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
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document/message name, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Documentmessagenamecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Document/message name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Documentmessagename_04 { get; set; }
    }
    
    /// <summary>
    /// CARRIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040 : I_C040
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Carrier identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Carrieridentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Carrier name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Carriername_04 { get; set; }
    }
    
    /// <summary>
    /// DEPARTMENT OR EMPLOYEE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C056")]
    public class C056 : I_C056
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Department or employee identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Departmentoremployeeidentification_01 { get; set; }
        /// <summary>
        /// Department or employee
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Departmentoremployee_02 { get; set; }
    }
    
    /// <summary>
    /// NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C058")]
    public class C058 : I_C058
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Nameandaddressline_01 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Nameandaddressline_02 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Nameandaddressline_03 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Nameandaddressline_04 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Nameandaddressline_05 { get; set; }
    }
    
    /// <summary>
    /// STREET
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C059")]
    public class C059 : I_C059
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Streetandnumberpobox_01 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Streetandnumberpobox_02 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Streetandnumberpobox_03 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Streetandnumberpobox_04 { get; set; }
    }
    
    /// <summary>
    /// COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C076")]
    public class C076 : I_C076
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Communication number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Communicationnumber_01 { get; set; }
        /// <summary>
        /// Communication channel qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Communicationchannelqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// ACCOUNT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C078")]
    public class C078 : I_C078
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Account holder number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Accountholdernumber_01 { get; set; }
        /// <summary>
        /// Account holder name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Accountholdername_02 { get; set; }
        /// <summary>
        /// Account holder name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Accountholdername_03 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Currencycoded_04 { get; set; }
    }
    
    /// <summary>
    /// PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C080")]
    public class C080 : I_C080
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Partyname_01 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Partyname_02 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Partyname_03 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Partyname_04 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Partyname_05 { get; set; }
        /// <summary>
        /// Party name format, coded
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Partynameformatcoded_06 { get; set; }
    }
    
    /// <summary>
    /// PARTY IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C082")]
    public class C082 : I_C082
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party id. identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Partyididentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// INSTITUTION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C088")]
    public class C088 : I_C088
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Institution name identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Institutionnameidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Institution branch number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Institutionbranchnumber_04 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Codelistqualifier_05 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Codelistresponsibleagencycoded_06 { get; set; }
        /// <summary>
        /// Institution name
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Institutionname_07 { get; set; }
        /// <summary>
        /// Institution branch place
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Institutionbranchplace_08 { get; set; }
    }
    
    /// <summary>
    /// TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C100")]
    public class C100 : I_C100
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Terms of delivery or transport, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Termsofdeliveryortransportcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Terms of delivery or transport
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Termsofdeliveryortransport_04 { get; set; }
        /// <summary>
        /// Terms of delivery or transport
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Termsofdeliveryortransport_05 { get; set; }
    }
    
    /// <summary>
    /// TEXT REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C107")]
    public class C107 : I_C107
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Free text, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Freetextcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// TEXT LITERAL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C108")]
    public class C108 : I_C108
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Freetext_01 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Freetext_02 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Freetext_03 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Freetext_04 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Freetext_05 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT TERMS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C110")]
    public class C110 : I_C110
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Terms of payment identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Termsofpaymentidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Terms of payment
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Termsofpayment_04 { get; set; }
        /// <summary>
        /// Terms of payment
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Termsofpayment_05 { get; set; }
    }
    
    /// <summary>
    /// TERMS/TIME INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C112")]
    public class C112 : I_C112
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment time reference, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Paymenttimereferencecoded_01 { get; set; }
        /// <summary>
        /// Time relation, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Timerelationcoded_02 { get; set; }
        /// <summary>
        /// Type of period, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Typeofperiodcoded_03 { get; set; }
        /// <summary>
        /// Number of periods
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Numberofperiods_04 { get; set; }
    }
    
    /// <summary>
    /// RATE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C128")]
    public class C128 : I_C128
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rate type qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Ratetypequalifier_01 { get; set; }
        /// <summary>
        /// Rate per unit
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Rateperunit_02 { get; set; }
        /// <summary>
        /// Unit price basis
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Unitpricebasis_03 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Measureunitqualifier_04 { get; set; }
    }
    
    /// <summary>
    /// PRICE MULTIPLIER INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C138")]
    public class C138 : I_C138
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price multiplier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Pricemultiplier_01 { get; set; }
        /// <summary>
        /// Price multiplier qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Pricemultiplierqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C174")]
    public class C174 : I_C174
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Rangeminimum_03 { get; set; }
        /// <summary>
        /// Range maximum
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Rangemaximum_04 { get; set; }
        /// <summary>
        /// Significant digits
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Significantdigits_05 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Quantityqualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }
    
    /// <summary>
    /// CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C200")]
    public class C200 : I_C200
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Freight and charges identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Freightandchargesidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Freight and charges
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Freightandcharges_04 { get; set; }
        /// <summary>
        /// Prepaid/collect indicator, coded
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Prepaidcollectindicatorcoded_05 { get; set; }
        /// <summary>
        /// Item number
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Itemnumber_06 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C202")]
    public class C202 : I_C202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Type of packages identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Typeofpackagesidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
    }
    
    /// <summary>
    /// RATE/TARIFF CLASS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C203")]
    public class C203 : I_C203
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rate/tariff class identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Ratetariffclassidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Rate/tariff class
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Ratetariffclass_04 { get; set; }
        /// <summary>
        /// Supplementary rate/tariff basis identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Supplementaryratetariffbasisidentification_05 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Codelistqualifier_06 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Codelistresponsibleagencycoded_07 { get; set; }
        /// <summary>
        /// Supplementary rate/tariff basis identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Supplementaryratetariffbasisidentification_08 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Codelistqualifier_09 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Codelistresponsibleagencycoded_10 { get; set; }
    }
    
    /// <summary>
    /// HAZARD CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C205")]
    public class C205 : I_C205
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazard code identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Hazardcodeidentification_01 { get; set; }
        /// <summary>
        /// Hazard substance/item/page number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Hazardsubstanceitempagenumber_02 { get; set; }
        /// <summary>
        /// Hazard code version number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Hazardcodeversionnumber_03 { get; set; }
    }
    
    /// <summary>
    /// IDENTIFICATION NUMBER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C206")]
    public class C206 : I_C206
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Identity number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Identitynumber_01 { get; set; }
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
    }
    
    /// <summary>
    /// IDENTITY NUMBER RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C208")]
    public class C208 : I_C208
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Identity number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Identitynumber_01 { get; set; }
        /// <summary>
        /// Identity number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Identitynumber_02 { get; set; }
    }
    
    /// <summary>
    /// MARKS & LABELS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C210")]
    public class C210 : I_C210
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Shippingmarks_01 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Shippingmarks_02 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Shippingmarks_03 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Shippingmarks_04 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Shippingmarks_05 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Shippingmarks_06 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Shippingmarks_07 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Shippingmarks_08 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Shippingmarks_09 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Shippingmarks_10 { get; set; }
    }
    
    /// <summary>
    /// DIMENSIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C211")]
    public class C211 : I_C211
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }
        /// <summary>
        /// Length dimension
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Lengthdimension_02 { get; set; }
        /// <summary>
        /// Width dimension
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Widthdimension_03 { get; set; }
        /// <summary>
        /// Height dimension
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Heightdimension_04 { get; set; }
    }
    
    /// <summary>
    /// ITEM NUMBER IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C212")]
    public class C212 : I_C212
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Itemnumber_01 { get; set; }
        /// <summary>
        /// Item number type, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Itemnumbertypecoded_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
    }
    
    /// <summary>
    /// NUMBER AND TYPE OF PACKAGES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C213")]
    public class C213 : I_C213
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
        /// Type of packages identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Typeofpackagesidentification_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Typeofpackages_05 { get; set; }
    }
    
    /// <summary>
    /// SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C214")]
    public class C214 : I_C214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special services, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Specialservicescoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Special service
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Specialservice_04 { get; set; }
        /// <summary>
        /// Special service
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Specialservice_05 { get; set; }
    }
    
    /// <summary>
    /// SEAL ISSUER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C215")]
    public class C215 : I_C215
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sealing party, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Sealingpartycoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Sealing party
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Sealingparty_04 { get; set; }
    }
    
    /// <summary>
    /// HAZARDOUS MATERIAL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C218")]
    public class C218 : I_C218
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous material class code, identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Hazardousmaterialclasscodeidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// MOVEMENT TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C219")]
    public class C219 : I_C219
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Movement type, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Movementtypecoded_01 { get; set; }
        /// <summary>
        /// Movement type
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Movementtype_02 { get; set; }
    }
    
    /// <summary>
    /// MODE OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C220")]
    public class C220 : I_C220
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Mode of transport, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Modeoftransportcoded_01 { get; set; }
        /// <summary>
        /// Mode of transport
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Modeoftransport_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C222")]
    public class C222 : I_C222
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Id. of means of transport identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Idofmeansoftransportidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Id. of the means of transport
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Idofthemeansoftransport_04 { get; set; }
        /// <summary>
        /// Nationality of means of transport, coded
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Nationalityofmeansoftransportcoded_05 { get; set; }
    }
    
    /// <summary>
    /// DANGEROUS GOODS SHIPMENT FLASHPOINT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C223")]
    public class C223 : I_C223
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment flashpoint
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Shipmentflashpoint_01 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Measureunitqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// EQUIPMENT SIZE AND TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C224")]
    public class C224 : I_C224
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment size and type identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Equipmentsizeandtypeidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Equipment size and type
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Equipmentsizeandtype_04 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C228")]
    public class C228 : I_C228
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Type of means of transport identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Typeofmeansoftransportidentification_01 { get; set; }
        /// <summary>
        /// Type of means of transport
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Typeofmeansoftransport_02 { get; set; }
    }
    
    /// <summary>
    /// CHARGE CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C229")]
    public class C229 : I_C229
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Charge category, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Chargecategorycoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// METHOD OF PAYMENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C231")]
    public class C231 : I_C231
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport charges method of payment, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Transportchargesmethodofpaymentcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// GOVERNMENT ACTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C232")]
    public class C232 : I_C232
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Government agency, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Governmentagencycoded_01 { get; set; }
        /// <summary>
        /// Government involvement, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Governmentinvolvementcoded_02 { get; set; }
        /// <summary>
        /// Government action, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Governmentactioncoded_03 { get; set; }
        /// <summary>
        /// Government procedure, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Governmentprocedurecoded_04 { get; set; }
    }
    
    /// <summary>
    /// SERVICE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C233")]
    public class C233 : I_C233
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service requirement, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Servicerequirementcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Service requirement, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Servicerequirementcoded_04 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Codelistqualifier_05 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Codelistresponsibleagencycoded_06 { get; set; }
    }
    
    /// <summary>
    /// UNDG INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C234")]
    public class C234 : I_C234
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// UNDG number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string UNDGnumber_01 { get; set; }
        /// <summary>
        /// Dangerous goods flashpoint
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Dangerousgoodsflashpoint_02 { get; set; }
    }
    
    /// <summary>
    /// HAZARD IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C235")]
    public class C235 : I_C235
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazard identification number, upper part
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Hazardidentificationnumberupperpart_01 { get; set; }
        /// <summary>
        /// Substance identification number, lower part
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Substanceidentificationnumberlowerpart_02 { get; set; }
    }
    
    /// <summary>
    /// DANGEROUS GOODS LABEL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C236")]
    public class C236 : I_C236
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dangerous goods label marking
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Dangerousgoodslabelmarking_01 { get; set; }
        /// <summary>
        /// Dangerous goods label marking
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Dangerousgoodslabelmarking_02 { get; set; }
        /// <summary>
        /// Dangerous goods label marking
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Dangerousgoodslabelmarking_03 { get; set; }
    }
    
    /// <summary>
    /// EQUIPMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C237")]
    public class C237 : I_C237
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment identification number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Equipmentidentificationnumber_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Country, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Countrycoded_04 { get; set; }
    }
    
    /// <summary>
    /// TEMPERATURE SETTING
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C239")]
    public class C239 : I_C239
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Temperature setting
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Temperaturesetting_01 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Measureunitqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// PRODUCT CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C240")]
    public class C240 : I_C240
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Characteristic identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Characteristicidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Characteristic
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Characteristic_04 { get; set; }
        /// <summary>
        /// Characteristic
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Characteristic_05 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C241")]
    public class C241 : I_C241
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty/tax/fee type, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Dutytaxfeetypecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Duty/tax/fee type
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Dutytaxfeetype_04 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C243")]
    public class C243 : I_C243
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty/tax/fee rate identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Dutytaxfeerateidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Duty/tax/fee rate
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Dutytaxfeerate_04 { get; set; }
        /// <summary>
        /// Duty/tax/fee rate basis identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Dutytaxfeeratebasisidentification_05 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Codelistqualifier_06 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Codelistresponsibleagencycoded_07 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Controlqualifier_01 { get; set; }
        /// <summary>
        /// Control value
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Controlvalue_02 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C273")]
    public class C273 : I_C273
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item description identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Itemdescriptionidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language, coded
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Languagecoded_06 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DIFFERENCE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C279")]
    public class C279 : I_C279
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity difference
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Quantitydifference_01 { get; set; }
        /// <summary>
        /// Quantity qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Quantityqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C280")]
    public class C280 : I_C280
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }
        /// <summary>
        /// Range minimum
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Rangeminimum_02 { get; set; }
        /// <summary>
        /// Range maximum
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Rangemaximum_03 { get; set; }
    }
    
    /// <summary>
    /// PRODUCT GROUP
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C288")]
    public class C288 : I_C288
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product group, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Productgroupcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Product group
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Productgroup_04 { get; set; }
    }
    
    /// <summary>
    /// PATTERN DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C329")]
    public class C329 : I_C329
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Frequency, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Frequencycoded_01 { get; set; }
        /// <summary>
        /// Despatch pattern, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Despatchpatterncoded_02 { get; set; }
        /// <summary>
        /// Despatch pattern timing, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Despatchpatterntimingcoded_03 { get; set; }
    }
    
    /// <summary>
    /// EXCESS TRANSPORTATION INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C401")]
    public class C401 : I_C401
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Excess transportation reason, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Excesstransportationreasoncoded_01 { get; set; }
        /// <summary>
        /// Excess transportation responsibility, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Excesstransportationresponsibilitycoded_02 { get; set; }
        /// <summary>
        /// Customer authorization number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Customerauthorizationnumber_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGE TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C402")]
    public class C402 : I_C402
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
        /// Type of packages
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Typeofpackages_02 { get; set; }
        /// <summary>
        /// Item number type, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Itemnumbertypecoded_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
        /// <summary>
        /// Item number type, coded
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Itemnumbertypecoded_05 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C501")]
    public class C501 : I_C501
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Percentage qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Percentagequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Percentagebasiscoded_03 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Codelistqualifier_04 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Codelistresponsibleagencycoded_05 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502 : I_C502
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement dimension, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Measurementdimensioncoded_01 { get; set; }
        /// <summary>
        /// Measurement significance, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Measurementsignificancecoded_02 { get; set; }
        /// <summary>
        /// Measurement attribute, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Measurementattributecoded_03 { get; set; }
        /// <summary>
        /// Measurement attribute
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Measurementattribute_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C503")]
    public class C503 : I_C503
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document/message number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Documentmessagenumber_01 { get; set; }
        /// <summary>
        /// Document/message status, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Documentmessagestatuscoded_02 { get; set; }
        /// <summary>
        /// Document/message source
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Documentmessagesource_03 { get; set; }
        /// <summary>
        /// Language, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Languagecoded_04 { get; set; }
    }
    
    /// <summary>
    /// CURRENCY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C504")]
    public class C504 : I_C504
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Currency details qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Currencydetailsqualifier_01 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Currencycoded_02 { get; set; }
        /// <summary>
        /// Currency qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Currencyqualifier_03 { get; set; }
        /// <summary>
        /// Currency rate base
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Currencyratebase_04 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Referencequalifier_01 { get; set; }
        /// <summary>
        /// Reference number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Referencenumber_02 { get; set; }
        /// <summary>
        /// Line number
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Linenumber_03 { get; set; }
        /// <summary>
        /// Reference version number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Referenceversionnumber_04 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date/time/period qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Datetimeperiodqualifier_01 { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Datetimeperiod_02 { get; set; }
        /// <summary>
        /// Date/time/period format qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Datetimeperiodformatqualifier_03 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Pricequalifier_01 { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Price_02 { get; set; }
        /// <summary>
        /// Price type, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Pricetypecoded_03 { get; set; }
        /// <summary>
        /// Price type qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Pricetypequalifier_04 { get; set; }
        /// <summary>
        /// Unit price basis
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Unitpricebasis_05 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Measureunitqualifier_06 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Monetaryamounttypequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Currencycoded_03 { get; set; }
        /// <summary>
        /// Currency qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Currencyqualifier_04 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Statuscoded_05 { get; set; }
    }
    
    /// <summary>
    /// LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C517")]
    public class C517 : I_C517
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Place/location identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Placelocationidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Place/location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Placelocation_04 { get; set; }
    }
    
    /// <summary>
    /// RELATED LOCATION ONE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C519")]
    public class C519 : I_C519
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Related place/location one identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Relatedplacelocationoneidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Related place/location one
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Relatedplacelocationone_04 { get; set; }
    }
    
    /// <summary>
    /// INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C522")]
    public class C522 : I_C522
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Instruction qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Instructionqualifier_01 { get; set; }
        /// <summary>
        /// Instruction, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Instructioncoded_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        /// <summary>
        /// Instruction
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Instruction_05 { get; set; }
    }
    
    /// <summary>
    /// NUMBER OF UNIT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C523")]
    public class C523 : I_C523
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Number of units
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Numberofunits_01 { get; set; }
        /// <summary>
        /// Number of units qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Numberofunitsqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C524")]
    public class C524 : I_C524
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Handling instructions, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Handlinginstructionscoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Handling instructions
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Handlinginstructions_04 { get; set; }
    }
    
    /// <summary>
    /// COMMODITY/RATE DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C528")]
    public class C528 : I_C528
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Commodity/rate identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Commodityrateidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C531")]
    public class C531 : I_C531
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Packaging level, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Packaginglevelcoded_01 { get; set; }
        /// <summary>
        /// Packaging related information, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Packagingrelatedinformationcoded_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Packagingtermsandconditionscoded_03 { get; set; }
    }
    
    /// <summary>
    /// RETURNABLE PACKAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C532")]
    public class C532 : I_C532
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Returnable package freight payment responsibility, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycoded_01 { get; set; }
        /// <summary>
        /// Returnable package load contents, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Returnablepackageloadcontentscoded_02 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE ACCOUNT DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C533")]
    public class C533 : I_C533
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty/tax/fee account identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Dutytaxfeeaccountidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534 : I_C534
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment conditions, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Paymentconditionscoded_01 { get; set; }
        /// <summary>
        /// Payment guarantee, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Paymentguaranteecoded_02 { get; set; }
        /// <summary>
        /// Payment means, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Paymentmeanscoded_03 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Codelistqualifier_04 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Codelistresponsibleagencycoded_05 { get; set; }
        /// <summary>
        /// Payment channel, coded
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Paymentchannelcoded_06 { get; set; }
    }
    
    /// <summary>
    /// CONTRACT AND CARRIAGE CONDITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C536")]
    public class C536 : I_C536
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contract and carriage condition, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Contractandcarriageconditioncoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT PRIORITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C537")]
    public class C537 : I_C537
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport priority, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Transportprioritycoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// REQUIREMENT/CONDITION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C550")]
    public class C550 : I_C550
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Requirement/condition identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Requirementconditionidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Requirement or condition
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Requirementorcondition_04 { get; set; }
    }
    
    /// <summary>
    /// ALLOWANCE/CHARGE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C552")]
    public class C552 : I_C552
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Allowanceorchargenumber_01 { get; set; }
        /// <summary>
        /// Charge/allowance description, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Chargeallowancedescriptioncoded_02 { get; set; }
    }
    
    /// <summary>
    /// RELATED LOCATION TWO IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C553")]
    public class C553 : I_C553
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Related place/location two identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Relatedplacelocationtwoidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Related place/location two
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Relatedplacelocationtwo_04 { get; set; }
    }
    
    /// <summary>
    /// RATE/TARIFF CLASS DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C554")]
    public class C554 : I_C554
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Rate/tariff class identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Ratetariffclassidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// STATUS EVENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C555")]
    public class C555 : I_C555
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Status event, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Statuseventcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Status event
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Statusevent_04 { get; set; }
    }
    
    /// <summary>
    /// STATUS REASON
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C556")]
    public class C556 : I_C556
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Status reason, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Statusreasoncoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Status reason
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Statusreason_04 { get; set; }
    }
    
    /// <summary>
    /// STATUS TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C601")]
    public class C601 : I_C601
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Status type, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Statustypecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// NATURE OF CARGO
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C703")]
    public class C703 : I_C703
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Nature of cargo, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Natureofcargocoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// TYPE OF MARKING
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C827")]
    public class C827 : I_C827
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Type of marking, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Typeofmarkingcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// SUB-LINE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C829")]
    public class C829 : I_C829
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sub-line indicator, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Sublineindicatorcoded_01 { get; set; }
        /// <summary>
        /// Line item number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Lineitemnumber_02 { get; set; }
    }
    
    /// <summary>
    /// PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C849")]
    public class C849 : I_C849
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party enacting instruction identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Partyenactinginstructionidentification_01 { get; set; }
        /// <summary>
        /// Recipient of the instruction identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Recipientoftheinstructionidentification_02 { get; set; }
    }
    
    /// <summary>
    /// STATUS OF INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C850")]
    public class C850 : I_C850
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Statuscoded_01 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Partyname_02 { get; set; }
    }
    
    /// <summary>
    /// CHARACTERISTIC VALUE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C889")]
    public class C889 : I_C889
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Characteristic value, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Characteristicvaluecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Characteristic value
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Characteristicvalue_04 { get; set; }
        /// <summary>
        /// Characteristic value
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Characteristicvalue_05 { get; set; }
    }
    
    /// <summary>
    /// REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C960")]
    public class C960 : I_C960
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Change reason, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Changereasoncoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Change reason
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Changereason_04 { get; set; }
    }
}
