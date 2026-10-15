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
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(1)]
        public string Documentmessagenamecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Document/message name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
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
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Carrieridentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Carrier name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3128", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Carriername_04 { get; set; }
    }
    
    /// <summary>
    /// NATIONALITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C042")]
    public class C042 : I_C042
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Nationality, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3293", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Nationalitycoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Nationality
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3292", typeof(EDIFACT_A))]
        [Pos(4)]
        public string Nationality_04 { get; set; }
    }
    
    /// <summary>
    /// BILL LEVEL IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C045")]
    public class C045 : I_C045
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Level one id.
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7436", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Leveloneid_01 { get; set; }
        /// <summary>
        /// Level two id.
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7438", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Leveltwoid_02 { get; set; }
        /// <summary>
        /// Level three id.
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Levelthreeid_03 { get; set; }
        /// <summary>
        /// Level four id.
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7442", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Levelfourid_04 { get; set; }
        /// <summary>
        /// Level five id.
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7444", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Levelfiveid_05 { get; set; }
        /// <summary>
        /// Level six id.
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7446", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Levelsixid_06 { get; set; }
    }
    
    /// <summary>
    /// REMUNERATION TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C049")]
    public class C049 : I_C049
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Remuneration type, coded
        /// </summary>
        [DataMember]
        [DataElement("5315", typeof(EDIFACT_ID_5315))]
        [Pos(1)]
        public string Remunerationtypecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Remuneration type
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5314", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Remunerationtype_04 { get; set; }
        /// <summary>
        /// Remuneration type
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5314", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Remunerationtype_05 { get; set; }
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
        [StringLength(1, 17)]
        [DataElement("3413", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Departmentoremployeeidentification_01 { get; set; }
        /// <summary>
        /// Department or employee
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3412", typeof(EDIFACT_AN))]
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
        [Required]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Nameandaddressline_01 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Nameandaddressline_02 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Nameandaddressline_03 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nameandaddressline_04 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
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
        [Required]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Streetandnumberpobox_01 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Streetandnumberpobox_02 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Streetandnumberpobox_03 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
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
        [Required]
        [StringLength(1, 512)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Communicationnumber_01 { get; set; }
        /// <summary>
        /// Communication channel qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155))]
        [Pos(2)]
        public string Communicationchannelqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// FILE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C077")]
    public class C077 : I_C077
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// File name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1508", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Filename_01 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Itemdescription_02 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Accountholdernumber_01 { get; set; }
        /// <summary>
        /// Account holder name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Accountholdername_02 { get; set; }
        /// <summary>
        /// Account holder name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Accountholdername_03 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Currencycoded_04 { get; set; }
    }
    
    /// <summary>
    /// COMPUTER ENVIRONMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C079")]
    public class C079 : I_C079
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Computer environment, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Computerenvironmentcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Computer environment
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1510", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Computerenvironment_04 { get; set; }
        /// <summary>
        /// Version
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Version_05 { get; set; }
        /// <summary>
        /// Release
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1058", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Release_06 { get; set; }
        /// <summary>
        /// Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Identitynumber_07 { get; set; }
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
        [Required]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyname_01 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Partyname_02 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Partyname_03 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Partyname_04 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Partyname_05 { get; set; }
        /// <summary>
        /// Party name format, coded
        /// </summary>
        [DataMember]
        [DataElement("3045", typeof(EDIFACT_ID_3045))]
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
        [Required]
        [StringLength(1, 35)]
        [DataElement("3039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyididentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// MARITAL STATUS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C085")]
    public class C085 : I_C085
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marital status, coded
        /// </summary>
        [DataMember]
        [DataElement("3479", typeof(EDIFACT_ID_3479))]
        [Pos(1)]
        public string Maritalstatuscoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Marital status
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3478", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Maritalstatus_04 { get; set; }
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
        [StringLength(1, 11)]
        [DataElement("3433", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Institutionnameidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Institution branch number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Institutionbranchnumber_04 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistqualifier_05 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string Codelistresponsibleagencycoded_06 { get; set; }
        /// <summary>
        /// Institution name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3432", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Institutionname_07 { get; set; }
        /// <summary>
        /// Institution branch place
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3436", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Institutionbranchplace_08 { get; set; }
    }
    
    /// <summary>
    /// ADDRESS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C090")]
    public class C090 : I_C090
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Address format, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3477", typeof(EDIFACT_ID_3477))]
        [Pos(1)]
        public string Addressformatcoded_01 { get; set; }
        /// <summary>
        /// Address component
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 70)]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Addresscomponent_02 { get; set; }
        /// <summary>
        /// Address component
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Addresscomponent_03 { get; set; }
        /// <summary>
        /// Address component
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Addresscomponent_04 { get; set; }
        /// <summary>
        /// Address component
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Addresscomponent_05 { get; set; }
        /// <summary>
        /// Address component
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3286", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Addresscomponent_06 { get; set; }
    }
    
    /// <summary>
    /// FILE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C099")]
    public class C099 : I_C099
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// File format
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("1516", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Fileformat_01 { get; set; }
        /// <summary>
        /// Version
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Version_02 { get; set; }
        /// <summary>
        /// Data format, coded
        /// </summary>
        [DataMember]
        [DataElement("1503", typeof(EDIFACT_ID_1503))]
        [Pos(3)]
        public string Dataformatcoded_03 { get; set; }
        /// <summary>
        /// Data format
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1502", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dataformat_04 { get; set; }
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
        [StringLength(1, 3)]
        [DataElement("4053", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Termsofdeliveryortransportcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Terms of delivery or transport
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Termsofdeliveryortransport_04 { get; set; }
        /// <summary>
        /// Terms of delivery or transport
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Termsofdeliveryortransport_05 { get; set; }
    }
    
    /// <summary>
    /// RELIGION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C101")]
    public class C101 : I_C101
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Religion, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3483", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Religioncoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Religion
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3482", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Religion_04 { get; set; }
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
        [Required]
        [StringLength(1, 3)]
        [DataElement("4441", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetextcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [Required]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetext_01 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Freetext_02 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Freetext_03 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freetext_04 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
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
        [Required]
        [DataElement("4277", typeof(EDIFACT_ID_4277))]
        [Pos(1)]
        public string Termsofpaymentidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Terms of payment
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Termsofpayment_04 { get; set; }
        /// <summary>
        /// Terms of payment
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
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
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475))]
        [Pos(1)]
        public string Paymenttimereferencecoded_01 { get; set; }
        /// <summary>
        /// Time relation, coded
        /// </summary>
        [DataMember]
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Timerelationcoded_02 { get; set; }
        /// <summary>
        /// Type of period, coded
        /// </summary>
        [DataMember]
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(3)]
        public string Typeofperiodcoded_03 { get; set; }
        /// <summary>
        /// Number of periods
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
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
        [Required]
        [DataElement("5419", typeof(EDIFACT_ID_5419))]
        [Pos(1)]
        public string Ratetypequalifier_01 { get; set; }
        /// <summary>
        /// Rate per unit
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("5420", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Rateperunit_02 { get; set; }
        /// <summary>
        /// Unit price basis
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Unitpricebasis_03 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
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
        [Required]
        [StringLength(1, 12)]
        [DataElement("5394", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Pricemultiplier_01 { get; set; }
        /// <summary>
        /// Price multiplier qualifier
        /// </summary>
        [DataMember]
        [DataElement("5393", typeof(EDIFACT_ID_5393))]
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
        [Required]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimum_03 { get; set; }
        /// <summary>
        /// Range maximum
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximum_04 { get; set; }
        /// <summary>
        /// Significant digits
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
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
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string Quantityqualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
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
        [StringLength(1, 17)]
        [DataElement("8023", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freightandchargesidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Freight and charges
        /// </summary>
        [DataMember]
        [StringLength(1, 26)]
        [DataElement("8022", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freightandcharges_04 { get; set; }
        /// <summary>
        /// Prepaid/collect indicator, coded
        /// </summary>
        [DataMember]
        [DataElement("4237", typeof(EDIFACT_ID_4237))]
        [Pos(5)]
        public string Prepaidcollectindicatorcoded_05 { get; set; }
        /// <summary>
        /// Item number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
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
        [StringLength(1, 17)]
        [DataElement("7065", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofpackagesidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
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
        [Required]
        [DataElement("5243", typeof(EDIFACT_ID_5243))]
        [Pos(1)]
        public string Ratetariffclassidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Rate/tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Ratetariffclass_04 { get; set; }
        /// <summary>
        /// Supplementary rate/tariff basis identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("5275", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Supplementaryratetariffbasisidentification_05 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistqualifier_06 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycoded_07 { get; set; }
        /// <summary>
        /// Supplementary rate/tariff basis identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("5275", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Supplementaryratetariffbasisidentification_08 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(9)]
        public string Codelistqualifier_09 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [Required]
        [StringLength(1, 7)]
        [DataElement("8351", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hazardcodeidentification_01 { get; set; }
        /// <summary>
        /// Hazard substance/item/page number
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("8078", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Hazardsubstanceitempagenumber_02 { get; set; }
        /// <summary>
        /// Hazard code version number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("8092", typeof(EDIFACT_AN))]
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
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Identitynumber_01 { get; set; }
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
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
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Identitynumber_01 { get; set; }
        /// <summary>
        /// Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
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
        [Required]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Shippingmarks_01 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Shippingmarks_02 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Shippingmarks_03 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Shippingmarks_04 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Shippingmarks_05 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Shippingmarks_06 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Shippingmarks_07 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Shippingmarks_08 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Shippingmarks_09 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
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
        [Required]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }
        /// <summary>
        /// Length dimension
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6168", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lengthdimension_02 { get; set; }
        /// <summary>
        /// Width dimension
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6140", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Widthdimension_03 { get; set; }
        /// <summary>
        /// Height dimension
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6008", typeof(EDIFACT_N))]
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
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemnumber_01 { get; set; }
        /// <summary>
        /// Item number type, coded
        /// </summary>
        [DataMember]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemnumbertypecoded_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Numberofpackages_01 { get; set; }
        /// <summary>
        /// Type of packages identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7065", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofpackagesidentification_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
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
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public string Specialservicescoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Special service
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservice_04 { get; set; }
        /// <summary>
        /// Special service
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
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
        [DataElement("9303", typeof(EDIFACT_ID_9303))]
        [Pos(1)]
        public string Sealingpartycoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Sealing party
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9302", typeof(EDIFACT_AN))]
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
        [StringLength(1, 4)]
        [DataElement("7419", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hazardousmaterialclasscodeidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [DataElement("8335", typeof(EDIFACT_ID_8335))]
        [Pos(1)]
        public string Movementtypecoded_01 { get; set; }
        /// <summary>
        /// Movement type
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("8334", typeof(EDIFACT_AN))]
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
        [StringLength(1, 3)]
        [DataElement("8067", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Modeoftransportcoded_01 { get; set; }
        /// <summary>
        /// Mode of transport
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
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
        [StringLength(1, 9)]
        [DataElement("8213", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Idofmeansoftransportidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Id. of the means of transport
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Idofthemeansoftransport_04 { get; set; }
        /// <summary>
        /// Nationality of means of transport, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8453", typeof(EDIFACT_AN))]
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
        [StringLength(3, 3)]
        [DataElement("7106", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Shipmentflashpoint_01 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
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
        [DataElement("8155", typeof(EDIFACT_ID_8155))]
        [Pos(1)]
        public string Equipmentsizeandtypeidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Equipment size and type
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("8154", typeof(EDIFACT_AN))]
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
        [DataElement("8179", typeof(EDIFACT_ID_8179))]
        [Pos(1)]
        public string Typeofmeansoftransportidentification_01 { get; set; }
        /// <summary>
        /// Type of means of transport
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
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
        [Required]
        [DataElement("5237", typeof(EDIFACT_ID_5237))]
        [Pos(1)]
        public string Chargecategorycoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [Required]
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(1)]
        public string Transportchargesmethodofpaymentcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [DataElement("9415", typeof(EDIFACT_ID_9415))]
        [Pos(1)]
        public string Governmentagencycoded_01 { get; set; }
        /// <summary>
        /// Government involvement, coded
        /// </summary>
        [DataMember]
        [DataElement("9411", typeof(EDIFACT_ID_9411))]
        [Pos(2)]
        public string Governmentinvolvementcoded_02 { get; set; }
        /// <summary>
        /// Government action, coded
        /// </summary>
        [DataMember]
        [DataElement("9417", typeof(EDIFACT_ID_9417))]
        [Pos(3)]
        public string Governmentactioncoded_03 { get; set; }
        /// <summary>
        /// Government procedure, coded
        /// </summary>
        [DataMember]
        [DataElement("9353", typeof(EDIFACT_ID_9353))]
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
        [Required]
        [DataElement("7273", typeof(EDIFACT_ID_7273))]
        [Pos(1)]
        public string Servicerequirementcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Service requirement, coded
        /// </summary>
        [DataMember]
        [DataElement("7273", typeof(EDIFACT_ID_7273))]
        [Pos(4)]
        public string Servicerequirementcoded_04 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistqualifier_05 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [StringLength(4, 4)]
        [DataElement("7124", typeof(EDIFACT_N))]
        [Pos(1)]
        public string UNDGnumber_01 { get; set; }
        /// <summary>
        /// Dangerous goods flashpoint
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("7088", typeof(EDIFACT_AN))]
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
        [StringLength(1, 4)]
        [DataElement("8158", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hazardidentificationnumberupperpart_01 { get; set; }
        /// <summary>
        /// Substance identification number, lower part
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("8186", typeof(EDIFACT_AN))]
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
        [StringLength(1, 4)]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dangerousgoodslabelmarking_01 { get; set; }
        /// <summary>
        /// Dangerous goods label marking
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dangerousgoodslabelmarking_02 { get; set; }
        /// <summary>
        /// Dangerous goods label marking
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8246", typeof(EDIFACT_AN))]
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
        [StringLength(1, 17)]
        [DataElement("8260", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Equipmentidentificationnumber_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
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
        [StringLength(3, 3)]
        [DataElement("6246", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Temperaturesetting_01 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
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
        [Required]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Characteristicidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristic_04 { get; set; }
        /// <summary>
        /// Characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
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
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string Dutytaxfeetypecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Duty/tax/fee type
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeetype_04 { get; set; }
    }
    
    /// <summary>
    /// PROCESS TYPE AND DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C242")]
    public class C242 : I_C242
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Process type identification
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7187", typeof(EDIFACT_ID_7187))]
        [Pos(1)]
        public string Processtypeidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Process type
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7186", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Processtype_04 { get; set; }
        /// <summary>
        /// Process type
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7186", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Processtype_05 { get; set; }
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
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutytaxfeerateidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Duty/tax/fee rate
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeerate_04 { get; set; }
        /// <summary>
        /// Duty/tax/fee rate basis identification
        /// </summary>
        [DataMember]
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string Dutytaxfeeratebasisidentification_05 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistqualifier_06 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycoded_07 { get; set; }
    }
    
    /// <summary>
    /// TEST METHOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C244")]
    public class C244 : I_C244
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Test method identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("4415", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Testmethodidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Test description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4416", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Testdescription_04 { get; set; }
    }
    
    /// <summary>
    /// CUSTOMS IDENTITY CODES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C246")]
    public class C246 : I_C246
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Customs code identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("7361", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Customscodeidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
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
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069))]
        [Pos(1)]
        public string Controlqualifier_01 { get; set; }
        /// <summary>
        /// Control value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controlvalue_02 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
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
        [StringLength(1, 17)]
        [DataElement("7009", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemdescriptionidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
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
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantitydifference_01 { get; set; }
        /// <summary>
        /// Quantity qualifier
        /// </summary>
        [DataMember]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
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
        [Required]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }
        /// <summary>
        /// Range minimum
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Rangeminimum_02 { get; set; }
        /// <summary>
        /// Range maximum
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangemaximum_03 { get; set; }
    }
    
    /// <summary>
    /// SEQUENCE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C286")]
    public class C286 : I_C286
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sequence number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Sequencenumber_01 { get; set; }
        /// <summary>
        /// Sequence number source, coded
        /// </summary>
        [DataMember]
        [DataElement("1159", typeof(EDIFACT_ID_1159))]
        [Pos(2)]
        public string Sequencenumbersourcecoded_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
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
        [StringLength(1, 3)]
        [DataElement("5389", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Productgroupcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Product group
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5388", typeof(EDIFACT_AN))]
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
        [DataElement("2013", typeof(EDIFACT_ID_2013))]
        [Pos(1)]
        public string Frequencycoded_01 { get; set; }
        /// <summary>
        /// Despatch pattern, coded
        /// </summary>
        [DataMember]
        [DataElement("2015", typeof(EDIFACT_ID_2015))]
        [Pos(2)]
        public string Despatchpatterncoded_02 { get; set; }
        /// <summary>
        /// Despatch pattern timing, coded
        /// </summary>
        [DataMember]
        [DataElement("2017", typeof(EDIFACT_ID_2017))]
        [Pos(3)]
        public string Despatchpatterntimingcoded_03 { get; set; }
    }
    
    /// <summary>
    /// INSURANCE COVER TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C330")]
    public class C330 : I_C330
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Insurance cover type, coded
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("4497", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Insurancecovertypecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// INSURANCE COVER DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C331")]
    public class C331 : I_C331
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Insurance cover identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("4495", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Insurancecoveridentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Insurance cover
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4494", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Insurancecover_04 { get; set; }
        /// <summary>
        /// Insurance cover
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4494", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Insurancecover_05 { get; set; }
    }
    
    /// <summary>
    /// SALES CHANNEL IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C332")]
    public class C332 : I_C332
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sales channel identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("3496", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Saleschannelidentifier_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// INFORMATION REQUEST
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C333")]
    public class C333 : I_C333
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Requested information, coded
        /// </summary>
        [DataMember]
        [DataElement("4511", typeof(EDIFACT_ID_4511))]
        [Pos(1)]
        public string Requestedinformationcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Requested information
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4510", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Requestedinformation_04 { get; set; }
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
        [Required]
        [DataElement("8457", typeof(EDIFACT_ID_8457))]
        [Pos(1)]
        public string Excesstransportationreasoncoded_01 { get; set; }
        /// <summary>
        /// Excess transportation responsibility, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8459", typeof(EDIFACT_ID_8459))]
        [Pos(2)]
        public string Excesstransportationresponsibilitycoded_02 { get; set; }
        /// <summary>
        /// Customer authorization number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7130", typeof(EDIFACT_AN))]
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
        [Required]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Itemdescriptiontypecoded_01 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofpackages_02 { get; set; }
        /// <summary>
        /// Item number type, coded
        /// </summary>
        [DataMember]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(3)]
        public string Itemnumbertypecoded_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
        /// <summary>
        /// Item number type, coded
        /// </summary>
        [DataMember]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
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
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string Percentagequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis, coded
        /// </summary>
        [DataMember]
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasiscoded_03 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistqualifier_04 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public string Measurementdimensioncoded_01 { get; set; }
        /// <summary>
        /// Measurement significance, coded
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string Measurementsignificancecoded_02 { get; set; }
        /// <summary>
        /// Measurement attribute, coded
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Measurementattributecoded_03 { get; set; }
        /// <summary>
        /// Measurement attribute
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
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
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentmessagenumber_01 { get; set; }
        /// <summary>
        /// Document/message status, coded
        /// </summary>
        [DataMember]
        [DataElement("1373", typeof(EDIFACT_ID_1373))]
        [Pos(2)]
        public string Documentmessagestatuscoded_02 { get; set; }
        /// <summary>
        /// Document/message source
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentmessagesource_03 { get; set; }
        /// <summary>
        /// Language, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
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
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string Currencydetailsqualifier_01 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Currencycoded_02 { get; set; }
        /// <summary>
        /// Currency qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string Currencyqualifier_03 { get; set; }
        /// <summary>
        /// Currency rate base
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6348", typeof(EDIFACT_N))]
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
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencequalifier_01 { get; set; }
        /// <summary>
        /// Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referencenumber_02 { get; set; }
        /// <summary>
        /// Line number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Linenumber_03 { get; set; }
        /// <summary>
        /// Reference version number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
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
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Datetimeperiodqualifier_01 { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Datetimeperiod_02 { get; set; }
        /// <summary>
        /// Date/time/period format qualifier
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Datetimeperiodformatqualifier_03 { get; set; }
    }
    
    /// <summary>
    /// LANGUAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C508")]
    public class C508 : I_C508
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Language, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Languagecoded_01 { get; set; }
        /// <summary>
        /// Language
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3452", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Language_02 { get; set; }
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
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125))]
        [Pos(1)]
        public string Pricequalifier_01 { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Price_02 { get; set; }
        /// <summary>
        /// Price type, coded
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375))]
        [Pos(3)]
        public string Pricetypecoded_03 { get; set; }
        /// <summary>
        /// Price type qualifier
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public string Pricetypequalifier_04 { get; set; }
        /// <summary>
        /// Unit price basis
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasis_05 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Measureunitqualifier_06 { get; set; }
    }
    
    /// <summary>
    /// SIZE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C512")]
    public class C512 : I_C512
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Size qualifier
        /// </summary>
        [DataMember]
        [DataElement("6173", typeof(EDIFACT_ID_6173))]
        [Pos(1)]
        public string Sizequalifier_01 { get; set; }
        /// <summary>
        /// Size
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6174", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Size_02 { get; set; }
    }
    
    /// <summary>
    /// SAMPLE LOCATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C514")]
    public class C514 : I_C514
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sample location, coded
        /// </summary>
        [DataMember]
        [DataElement("3237", typeof(EDIFACT_ID_3237))]
        [Pos(1)]
        public string Samplelocationcoded_01 { get; set; }
        /// <summary>
        /// Sample location
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3236", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Samplelocation_02 { get; set; }
    }
    
    /// <summary>
    /// TEST REASON
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C515")]
    public class C515 : I_C515
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Test reason identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("4425", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Testreasonidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Test reason
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4424", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Testreason_04 { get; set; }
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
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Currencycoded_03 { get; set; }
        /// <summary>
        /// Currency qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencyqualifier_04 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
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
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Placelocationidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Place/location
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3224", typeof(EDIFACT_AN))]
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
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relatedplacelocationoneidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Related place/location one
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Relatedplacelocationone_04 { get; set; }
    }
    
    /// <summary>
    /// BUSINESS FUNCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C521")]
    public class C521 : I_C521
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Business function qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4027", typeof(EDIFACT_ID_4027))]
        [Pos(1)]
        public string Businessfunctionqualifier_01 { get; set; }
        /// <summary>
        /// Business function, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4025", typeof(EDIFACT_ID_4025))]
        [Pos(2)]
        public string Businessfunctioncoded_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        /// <summary>
        /// Business description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4022", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Businessdescription_05 { get; set; }
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
        [Required]
        [DataElement("4403", typeof(EDIFACT_ID_4403))]
        [Pos(1)]
        public string Instructionqualifier_01 { get; set; }
        /// <summary>
        /// Instruction, coded
        /// </summary>
        [DataMember]
        [DataElement("4401", typeof(EDIFACT_ID_4401))]
        [Pos(2)]
        public string Instructioncoded_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        /// <summary>
        /// Instruction
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4400", typeof(EDIFACT_AN))]
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
        [StringLength(1, 15)]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Numberofunits_01 { get; set; }
        /// <summary>
        /// Number of units qualifier
        /// </summary>
        [DataMember]
        [DataElement("6353", typeof(EDIFACT_ID_6353))]
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
        [StringLength(1, 3)]
        [DataElement("4079", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Handlinginstructionscoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Handling instructions
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Handlinginstructions_04 { get; set; }
    }
    
    /// <summary>
    /// FREQUENCY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C526")]
    public class C526 : I_C526
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Frequency qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6071", typeof(EDIFACT_ID_6071))]
        [Pos(1)]
        public string Frequencyqualifier_01 { get; set; }
        /// <summary>
        /// Frequency value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("6072", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Frequencyvalue_02 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }
    
    /// <summary>
    /// STATISTICAL DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C527")]
    public class C527 : I_C527
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Measurementvalue_01 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measureunitqualifier_02 { get; set; }
        /// <summary>
        /// Measurement dimension, coded
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(3)]
        public string Measurementdimensioncoded_03 { get; set; }
        /// <summary>
        /// Measurement significance, coded
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(4)]
        public string Measurementsignificancecoded_04 { get; set; }
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
        [StringLength(1, 18)]
        [DataElement("7357", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Commodityrateidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// PROCESSING INDICATOR
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C529")]
    public class C529 : I_C529
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Processing indicator, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7365", typeof(EDIFACT_ID_7365))]
        [Pos(1)]
        public string Processingindicatorcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Process type identification
        /// </summary>
        [DataMember]
        [DataElement("7187", typeof(EDIFACT_ID_7187))]
        [Pos(4)]
        public string Processtypeidentification_04 { get; set; }
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
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcoded_01 { get; set; }
        /// <summary>
        /// Packaging related information, coded
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(2)]
        public string Packagingrelatedinformationcoded_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions, coded
        /// </summary>
        [DataMember]
        [DataElement("7073", typeof(EDIFACT_ID_7073))]
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
        [DataElement("8395", typeof(EDIFACT_ID_8395))]
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycoded_01 { get; set; }
        /// <summary>
        /// Returnable package load contents, coded
        /// </summary>
        [DataMember]
        [DataElement("8393", typeof(EDIFACT_ID_8393))]
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
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutytaxfeeaccountidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public string Paymentconditionscoded_01 { get; set; }
        /// <summary>
        /// Payment guarantee, coded
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteecoded_02 { get; set; }
        /// <summary>
        /// Payment means, coded
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461))]
        [Pos(3)]
        public string Paymentmeanscoded_03 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistqualifier_04 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycoded_05 { get; set; }
        /// <summary>
        /// Payment channel, coded
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435))]
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
        [Required]
        [DataElement("4065", typeof(EDIFACT_ID_4065))]
        [Pos(1)]
        public string Contractandcarriageconditioncoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [Required]
        [DataElement("4219", typeof(EDIFACT_ID_4219))]
        [Pos(1)]
        public string Transportprioritycoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// AGREEMENT TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C543")]
    public class C543 : I_C543
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Agreement type qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7431", typeof(EDIFACT_ID_7431))]
        [Pos(1)]
        public string Agreementtypequalifier_01 { get; set; }
        /// <summary>
        /// Agreement type, coded
        /// </summary>
        [DataMember]
        [DataElement("7433", typeof(EDIFACT_ID_7433))]
        [Pos(2)]
        public string Agreementtypecoded_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        /// <summary>
        /// Agreement type description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("7434", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Agreementtypedescription_05 { get; set; }
    }
    
    /// <summary>
    /// INDEX IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C545")]
    public class C545 : I_C545
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Index qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5013", typeof(EDIFACT_ID_5013))]
        [Pos(1)]
        public string Indexqualifier_01 { get; set; }
        /// <summary>
        /// Index type, coded
        /// </summary>
        [DataMember]
        [DataElement("5027", typeof(EDIFACT_ID_5027))]
        [Pos(2)]
        public string Indextypecoded_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
    }
    
    /// <summary>
    /// INDEX VALUE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C546")]
    public class C546 : I_C546
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Index value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("5030", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Indexvalue_01 { get; set; }
        /// <summary>
        /// Index value representation, coded
        /// </summary>
        [DataMember]
        [DataElement("5039", typeof(EDIFACT_ID_5039))]
        [Pos(2)]
        public string Indexvaluerepresentationcoded_02 { get; set; }
    }
    
    /// <summary>
    /// MONETARY FUNCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C549")]
    public class C549 : I_C549
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary function, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5007", typeof(EDIFACT_ID_5007))]
        [Pos(1)]
        public string Monetaryfunctioncoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [Required]
        [StringLength(1, 17)]
        [DataElement("7295", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Requirementconditionidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Requirement or condition
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Requirementorcondition_04 { get; set; }
    }
    
    /// <summary>
    /// BANK OPERATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C551")]
    public class C551 : I_C551
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Bank operation, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4383", typeof(EDIFACT_ID_4383))]
        [Pos(1)]
        public string Bankoperationcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargenumber_01 { get; set; }
        /// <summary>
        /// Charge/allowance description, coded
        /// </summary>
        [DataMember]
        [DataElement("5189", typeof(EDIFACT_ID_5189))]
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
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relatedplacelocationtwoidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Related place/location two
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
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
        [DataElement("5243", typeof(EDIFACT_ID_5243))]
        [Pos(1)]
        public string Ratetariffclassidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [Required]
        [DataElement("9011", typeof(EDIFACT_ID_9011))]
        [Pos(1)]
        public string Statuseventcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Status event
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9010", typeof(EDIFACT_AN))]
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
        [Required]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(1)]
        public string Statusreasoncoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Status reason
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9012", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Statusreason_04 { get; set; }
    }
    
    /// <summary>
    /// PHYSICAL OR LOGICAL STATE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C564")]
    public class C564 : I_C564
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Physical or logical state, coded
        /// </summary>
        [DataMember]
        [DataElement("7007", typeof(EDIFACT_ID_7007))]
        [Pos(1)]
        public string Physicalorlogicalstatecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Physical or logical state description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7006", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Physicalorlogicalstatedescription_04 { get; set; }
    }
    
    /// <summary>
    /// PRIORITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C585")]
    public class C585 : I_C585
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Priority, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4037", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Prioritycoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Priority
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Priority_04 { get; set; }
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
        [Required]
        [DataElement("9015", typeof(EDIFACT_ID_9015))]
        [Pos(1)]
        public string Statustypecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// ERROR POINT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C701")]
    public class C701 : I_C701
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Message section, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1049", typeof(EDIFACT_ID_1049))]
        [Pos(1)]
        public string Messagesectioncoded_01 { get; set; }
        /// <summary>
        /// Message item number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1052", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Messageitemnumber_02 { get; set; }
        /// <summary>
        /// Message sub-item number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1054", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Messagesubitemnumber_03 { get; set; }
    }
    
    /// <summary>
    /// CODE SET IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C702")]
    public class C702 : I_C702
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Simple data element tag
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9150", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Simpledataelementtag_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [Required]
        [DataElement("7085", typeof(EDIFACT_ID_7085))]
        [Pos(1)]
        public string Natureofcargocoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// MESSAGE IDENTIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C709")]
    public class C709 : I_C709
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Message type identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("1475", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Messagetypeidentifier_01 { get; set; }
        /// <summary>
        /// Version
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Version_02 { get; set; }
        /// <summary>
        /// Release
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 9)]
        [DataElement("1058", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Release_03 { get; set; }
        /// <summary>
        /// Control agency
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("1476", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Controlagency_04 { get; set; }
        /// <summary>
        /// Association assigned identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1523", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Associationassignedidentification_05 { get; set; }
        /// <summary>
        /// Revision number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Revisionnumber_06 { get; set; }
    }
    
    /// <summary>
    /// ARRAY CELL DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C770")]
    public class C770 : I_C770
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Array cell information
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9424", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Arraycellinformation_01 { get; set; }
    }
    
    /// <summary>
    /// POSITION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C778")]
    public class C778 : I_C778
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hierarchical id. number
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hierarchicalidnumber_01 { get; set; }
        /// <summary>
        /// Sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Sequencenumber_02 { get; set; }
    }
    
    /// <summary>
    /// ARRAY STRUCTURE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C779")]
    public class C779 : I_C779
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Array structure identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("9428", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Arraystructureidentifier_01 { get; set; }
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// VALUE LIST IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C780")]
    public class C780 : I_C780
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Value list identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("1518", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Valuelistidentifier_01 { get; set; }
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// DATA SET IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C782")]
    public class C782 : I_C782
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Data set identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("1520", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Datasetidentifier_01 { get; set; }
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// FOOTNOTE SET IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C783")]
    public class C783 : I_C783
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Footnote set identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("9430", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Footnotesetidentifier_01 { get; set; }
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// FOOTNOTE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C784")]
    public class C784 : I_C784
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Footnote identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("9432", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Footnoteidentifier_01 { get; set; }
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// STATISTICAL CONCEPT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C785")]
    public class C785 : I_C785
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Statistical concept identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6434", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Statisticalconceptidentifier_01 { get; set; }
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// STRUCTURE COMPONENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C786")]
    public class C786 : I_C786
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Structure component identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("7512", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Structurecomponentidentifier_01 { get; set; }
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
    }
    
    /// <summary>
    /// SAFETY SECTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C814")]
    public class C814 : I_C814
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Safety section
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("4046", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Safetysection_01 { get; set; }
        /// <summary>
        /// Safety section name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4044", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Safetysectionname_02 { get; set; }
    }
    
    /// <summary>
    /// ADDITIONAL SAFETY INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C815")]
    public class C815 : I_C815
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Additional safety information, coded
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("4039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Additionalsafetyinformationcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Additional safety information
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4038", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Additionalsafetyinformation_04 { get; set; }
    }
    
    /// <summary>
    /// NAME COMPONENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C816")]
    public class C816 : I_C816
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name component qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3405", typeof(EDIFACT_ID_3405))]
        [Pos(1)]
        public string Namecomponentqualifier_01 { get; set; }
        /// <summary>
        /// Name component
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3398", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Namecomponent_02 { get; set; }
        /// <summary>
        /// Name component status, coded
        /// </summary>
        [DataMember]
        [DataElement("3401", typeof(EDIFACT_ID_3401))]
        [Pos(3)]
        public string Namecomponentstatuscoded_03 { get; set; }
        /// <summary>
        /// Name component original representation, coded
        /// </summary>
        [DataMember]
        [DataElement("3295", typeof(EDIFACT_ID_3295))]
        [Pos(4)]
        public string Namecomponentoriginalrepresentationcoded_04 { get; set; }
    }
    
    /// <summary>
    /// ADDRESS USAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C817")]
    public class C817 : I_C817
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Address purpose, coded
        /// </summary>
        [DataMember]
        [DataElement("3299", typeof(EDIFACT_ID_3299))]
        [Pos(1)]
        public string Addresspurposecoded_01 { get; set; }
        /// <summary>
        /// Address type, coded
        /// </summary>
        [DataMember]
        [DataElement("3131", typeof(EDIFACT_ID_3131))]
        [Pos(2)]
        public string Addresstypecoded_02 { get; set; }
        /// <summary>
        /// Address status, coded
        /// </summary>
        [DataMember]
        [DataElement("3475", typeof(EDIFACT_ID_3475))]
        [Pos(3)]
        public string Addressstatuscoded_03 { get; set; }
    }
    
    /// <summary>
    /// PERSON INHERITED CHARACTERISTIC DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C818")]
    public class C818 : I_C818
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Person inherited characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("3311", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Personinheritedcharacteristicidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Person inherited characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3310", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Personinheritedcharacteristic_04 { get; set; }
    }
    
    /// <summary>
    /// COUNTRY SUB-ENTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C819")]
    public class C819 : I_C819
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Country sub-entity identification
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Countrysubentityidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Country sub-entity
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrysubentity_04 { get; set; }
    }
    
    /// <summary>
    /// TYPE OF DAMAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C821")]
    public class C821 : I_C821
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Type of damage, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7501", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofdamagecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Type of damage
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7500", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofdamage_04 { get; set; }
    }
    
    /// <summary>
    /// DAMAGE AREA
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C822")]
    public class C822 : I_C822
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Damage area identification
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("7503", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Damageareaidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Damage area
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7502", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Damagearea_04 { get; set; }
    }
    
    /// <summary>
    /// TYPE OF UNIT/COMPONENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C823")]
    public class C823 : I_C823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Type of unit/component, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7505", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofunitcomponentcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Type of unit/component
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7504", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofunitcomponent_04 { get; set; }
    }
    
    /// <summary>
    /// COMPONENT MATERIAL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C824")]
    public class C824 : I_C824
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Component material, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7507", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Componentmaterialcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Component material
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7506", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Componentmaterial_04 { get; set; }
    }
    
    /// <summary>
    /// DAMAGE SEVERITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C825")]
    public class C825 : I_C825
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Damage severity, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7509", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Damageseveritycoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Damage severity
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7508", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Damageseverity_04 { get; set; }
    }
    
    /// <summary>
    /// ACTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C826")]
    public class C826 : I_C826
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Action request/notification, coded
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(1)]
        public string Actionrequestnotificationcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Action request/notification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Actionrequestnotification_04 { get; set; }
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
        [Required]
        [StringLength(1, 3)]
        [DataElement("7511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofmarkingcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
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
        [DataElement("5495", typeof(EDIFACT_ID_5495))]
        [Pos(1)]
        public string Sublineindicatorcoded_01 { get; set; }
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
        [Required]
        [DataElement("3301", typeof(EDIFACT_ID_3301))]
        [Pos(1)]
        public string Partyenactinginstructionidentification_01 { get; set; }
        /// <summary>
        /// Recipient of the instruction identification
        /// </summary>
        [DataMember]
        [DataElement("3285", typeof(EDIFACT_ID_3285))]
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
        [Required]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(1)]
        public string Statuscoded_01 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Partyname_02 { get; set; }
    }
    
    /// <summary>
    /// CHARGE/ALLOWANCE ACCOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C878")]
    public class C878 : I_C878
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Institution branch number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Institutionbranchnumber_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Account holder number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Accountholdernumber_04 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Currencycoded_05 { get; set; }
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
        [StringLength(1, 3)]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Characteristicvaluecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Characteristic value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristicvalue_04 { get; set; }
        /// <summary>
        /// Characteristic value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Characteristicvalue_05 { get; set; }
    }
    
    /// <summary>
    /// APPLICATION ERROR DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C901")]
    public class C901 : I_C901
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Application error identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 8)]
        [DataElement("9321", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Applicationerroridentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// RELATIONSHIP
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C941")]
    public class C941 : I_C941
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Relationship, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9143", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relationshipcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Relationship
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9142", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Relationship_04 { get; set; }
    }
    
    /// <summary>
    /// MEMBERSHIP CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C942")]
    public class C942 : I_C942
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Membership category identification
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7451", typeof(EDIFACT_ID_7451))]
        [Pos(1)]
        public string Membershipcategoryidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Membership category
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7450", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Membershipcategory_04 { get; set; }
    }
    
    /// <summary>
    /// MEMBERSHIP STATUS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C944")]
    public class C944 : I_C944
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Membership status, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7453", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Membershipstatuscoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Membership status
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7452", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Membershipstatus_04 { get; set; }
    }
    
    /// <summary>
    /// MEMBERSHIP LEVEL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C945")]
    public class C945 : I_C945
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Membership level qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7455", typeof(EDIFACT_ID_7455))]
        [Pos(1)]
        public string Membershiplevelqualifier_01 { get; set; }
        /// <summary>
        /// Membership level identification
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("7457", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Membershiplevelidentification_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        /// <summary>
        /// Membership level
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7456", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Membershiplevel_05 { get; set; }
    }
    
    /// <summary>
    /// EMPLOYMENT CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C948")]
    public class C948 : I_C948
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Employment category, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9005", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Employmentcategorycoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Employment category
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9004", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Employmentcategory_04 { get; set; }
    }
    
    /// <summary>
    /// QUALIFICATION CLASSIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C950")]
    public class C950 : I_C950
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Qualification classification, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9007", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Qualificationclassificationcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Qualification classification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9006", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Qualificationclassification_04 { get; set; }
        /// <summary>
        /// Qualification classification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9006", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Qualificationclassification_05 { get; set; }
    }
    
    /// <summary>
    /// OCCUPATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C951")]
    public class C951 : I_C951
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Occupation, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9009", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Occupationcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Occupation
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Occupation_04 { get; set; }
        /// <summary>
        /// Occupation
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Occupation_05 { get; set; }
    }
    
    /// <summary>
    /// CONTRIBUTION TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C953")]
    public class C953 : I_C953
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contribution type, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5049", typeof(EDIFACT_ID_5049))]
        [Pos(1)]
        public string Contributiontypecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Contribution type
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5048", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Contributiontype_04 { get; set; }
    }
    
    /// <summary>
    /// ATTRIBUTE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C955")]
    public class C955 : I_C955
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Attribute type, coded
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9021", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Attributetypecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    /// <summary>
    /// ATTRIBUTE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C956")]
    public class C956 : I_C956
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Attribute, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9019", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Attributecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Attribute
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9018", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Attribute_04 { get; set; }
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
        [DataElement("4295", typeof(EDIFACT_ID_4295))]
        [Pos(1)]
        public string Changereasoncoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Change reason
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereason_04 { get; set; }
    }
}
