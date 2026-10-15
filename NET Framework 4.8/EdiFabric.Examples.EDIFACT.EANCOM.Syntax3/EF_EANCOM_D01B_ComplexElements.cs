namespace EdiFabric.Templates.EancomD01B.S3
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System.Xml.Serialization;
    using EdiFabric.Templates.EancomD01B;

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
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_10 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_10))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_11 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_11))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_12 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_12))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_13 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_14))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_14 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_15))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_15 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_16))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_16 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_17))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_17 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_13))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_18 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_18))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_19 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_19))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_2 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_2))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_20 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_20))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_21 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_21))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_22 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_22))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_23 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_23))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_24 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_24))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_25 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_25))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_26 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_26))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_27 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_27))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_28 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_28))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_29 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_29))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_3 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_3))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_30 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_30))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_31 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_31))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_32 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_32))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_33 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_33))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_34 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_34))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_35 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_35))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_36 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_36))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_37 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_37))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_38 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_38))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_39 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_39))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_4 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_4))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_40 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_40))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_41 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_41))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_42 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_42))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_43 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_43))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_44 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_44))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_45 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_45))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_5 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_5))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_6 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_6))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_7 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_7))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_8 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_8))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002_9 : I_C002
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001_9))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT TERMS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C019")]
    public class C019 : I_C019
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment terms description identifier
        /// </summary>
        [DataMember]
        [DataElement("4277", typeof(EDIFACT_ID_4277))]
        [Pos(1)]
        public string Paymenttermsdescriptionidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Payment terms description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Paymenttermsdescription_04 { get; set; }
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
        /// Carrier identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Carrieridentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Department or employee name code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3413", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Departmentoremployeenamecode_01 { get; set; }
        /// <summary>
        /// Department or employee name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3412", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Departmentoremployeename_02 { get; set; }
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
        /// Name and address description
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Nameandaddressdescription_01 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Nameandaddressdescription_02 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Nameandaddressdescription_03 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nameandaddressdescription_04 { get; set; }
        /// <summary>
        /// Name and address description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nameandaddressdescription_05 { get; set; }
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
        /// Street and number or post office box identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Streetandnumberorpostofficeboxidentifier_01 { get; set; }
        /// <summary>
        /// Street and number or post office box identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Streetandnumberorpostofficeboxidentifier_02 { get; set; }
        /// <summary>
        /// Street and number or post office box identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Streetandnumberorpostofficeboxidentifier_03 { get; set; }
        /// <summary>
        /// Street and number or post office box identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Streetandnumberorpostofficeboxidentifier_04 { get; set; }
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
        /// Communication address identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 512)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Communicationaddressidentifier_01 { get; set; }
        /// <summary>
        /// Communication address code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155))]
        [Pos(2)]
        public string Communicationaddresscodequalifier_02 { get; set; }
    }
    
    /// <summary>
    /// COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C076")]
    public class C076_2 : I_C076
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Communication address identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 512)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Communicationaddressidentifier_01 { get; set; }
        /// <summary>
        /// Communication address code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155_3))]
        [Pos(2)]
        public string Communicationaddresscodequalifier_02 { get; set; }
    }
    
    /// <summary>
    /// COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C076")]
    public class C076_3 : I_C076
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Communication address identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 512)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Communicationaddressidentifier_01 { get; set; }
        /// <summary>
        /// Communication address code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155_2))]
        [Pos(2)]
        public string Communicationaddresscodequalifier_02 { get; set; }
    }
    
    /// <summary>
    /// COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C076")]
    public class C076_4 : I_C076
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Communication address identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 512)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Communicationaddressidentifier_01 { get; set; }
        /// <summary>
        /// Communication address code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155_4))]
        [Pos(2)]
        public string Communicationaddresscodequalifier_02 { get; set; }
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
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Itemdescription_02 { get; set; }
    }
    
    /// <summary>
    /// ACCOUNT HOLDER IDENTIFICATION
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
        /// Account holder identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Accountholderidentifier_01 { get; set; }
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
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(4)]
        public string Currencyidentificationcode_04 { get; set; }
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
        /// Computer environment name code
        /// </summary>
        [DataMember]
        [DataElement("1511", typeof(EDIFACT_ID_1511))]
        [Pos(1)]
        public string Computerenvironmentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Computer environment name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1510", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Computerenvironmentname_04 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Versionidentifier_05 { get; set; }
        /// <summary>
        /// Release identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1058", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Releaseidentifier_06 { get; set; }
        /// <summary>
        /// Object identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Objectidentifier_07 { get; set; }
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
        /// Party name format code
        /// </summary>
        [DataMember]
        [DataElement("3045", typeof(EDIFACT_ID_3045))]
        [Pos(6)]
        public string Partynameformatcode_06 { get; set; }
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
        /// Party identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("3039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Institution name code
        /// </summary>
        [DataMember]
        [DataElement("3433", typeof(EDIFACT_ID_3433))]
        [Pos(1)]
        public string Institutionnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Institution branch identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Institutionbranchidentifier_04 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistidentificationcode_05 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string Codelistresponsibleagencycode_06 { get; set; }
        /// <summary>
        /// Institution name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3432", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Institutionname_07 { get; set; }
        /// <summary>
        /// Institution branch location name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3436", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Institutionbranchlocationname_08 { get; set; }
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
        /// File format name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("1516", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Fileformatname_01 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Versionidentifier_02 { get; set; }
        /// <summary>
        /// Data format description code
        /// </summary>
        [DataMember]
        [DataElement("1503", typeof(EDIFACT_ID_1503))]
        [Pos(3)]
        public string Dataformatdescriptioncode_03 { get; set; }
        /// <summary>
        /// Data format description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1502", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dataformatdescription_04 { get; set; }
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
        /// Delivery or transport terms description code
        /// </summary>
        [DataMember]
        [DataElement("4053", typeof(EDIFACT_ID_4053))]
        [Pos(1)]
        public string Deliveryortransporttermsdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Delivery or transport terms description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Deliveryortransporttermsdescription_04 { get; set; }
        /// <summary>
        /// Delivery or transport terms description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Deliveryortransporttermsdescription_05 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C106")]
    public class C106 : I_C106
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Versionidentifier_02 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Revisionidentifier_03 { get; set; }
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
        /// Free text value code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4441", typeof(EDIFACT_ID_4441))]
        [Pos(1)]
        public string Freetextvaluecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Free text value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetextvalue_01 { get; set; }
        /// <summary>
        /// Free text value
        /// </summary>
        [DataMember]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Freetextvalue_02 { get; set; }
        /// <summary>
        /// Free text value
        /// </summary>
        [DataMember]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Freetextvalue_03 { get; set; }
        /// <summary>
        /// Free text value
        /// </summary>
        [DataMember]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freetextvalue_04 { get; set; }
        /// <summary>
        /// Free text value
        /// </summary>
        [DataMember]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Freetextvalue_05 { get; set; }
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
        /// Payment terms description identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4277", typeof(EDIFACT_ID_4277))]
        [Pos(1)]
        public string Paymenttermsdescriptionidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Payment terms description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Paymenttermsdescription_04 { get; set; }
        /// <summary>
        /// Payment terms description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Paymenttermsdescription_05 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT TERMS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C110")]
    public class C110_2 : I_C110
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment terms description identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4277", typeof(EDIFACT_ID_4277_3))]
        [Pos(1)]
        public string Paymenttermsdescriptionidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Payment terms description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Paymenttermsdescription_04 { get; set; }
        /// <summary>
        /// Payment terms description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Paymenttermsdescription_05 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT TERMS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C110")]
    public class C110_3 : I_C110
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment terms description identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4277", typeof(EDIFACT_ID_4277_2))]
        [Pos(1)]
        public string Paymenttermsdescriptionidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Payment terms description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Paymenttermsdescription_04 { get; set; }
        /// <summary>
        /// Payment terms description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Paymenttermsdescription_05 { get; set; }
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
        /// Time reference code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475))]
        [Pos(1)]
        public string Timereferencecode_01 { get; set; }
        /// <summary>
        /// Terms time relation code
        /// </summary>
        [DataMember]
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Termstimerelationcode_02 { get; set; }
        /// <summary>
        /// Period type code
        /// </summary>
        [DataMember]
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(3)]
        public string Periodtypecode_03 { get; set; }
        /// <summary>
        /// Period count quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Periodcountquantity_04 { get; set; }
    }
    
    /// <summary>
    /// TERMS/TIME INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C112")]
    public class C112_2 : I_C112
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Time reference code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475_2))]
        [Pos(1)]
        public string Timereferencecode_01 { get; set; }
        /// <summary>
        /// Terms time relation code
        /// </summary>
        [DataMember]
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Termstimerelationcode_02 { get; set; }
        /// <summary>
        /// Period type code
        /// </summary>
        [DataMember]
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(3)]
        public string Periodtypecode_03 { get; set; }
        /// <summary>
        /// Period count quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Periodcountquantity_04 { get; set; }
    }
    
    /// <summary>
    /// TERMS/TIME INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C112")]
    public class C112_3 : I_C112
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Time reference code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475_3))]
        [Pos(1)]
        public string Timereferencecode_01 { get; set; }
        /// <summary>
        /// Terms time relation code
        /// </summary>
        [DataMember]
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Termstimerelationcode_02 { get; set; }
        /// <summary>
        /// Period type code
        /// </summary>
        [DataMember]
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(3)]
        public string Periodtypecode_03 { get; set; }
        /// <summary>
        /// Period count quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Periodcountquantity_04 { get; set; }
    }
    
    /// <summary>
    /// TERMS/TIME INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C112")]
    public class C112_4 : I_C112
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Time reference code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475_4))]
        [Pos(1)]
        public string Timereferencecode_01 { get; set; }
        /// <summary>
        /// Terms time relation code
        /// </summary>
        [DataMember]
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Termstimerelationcode_02 { get; set; }
        /// <summary>
        /// Period type code
        /// </summary>
        [DataMember]
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(3)]
        public string Periodtypecode_03 { get; set; }
        /// <summary>
        /// Period count quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Periodcountquantity_04 { get; set; }
    }
    
    /// <summary>
    /// TERMS/TIME INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C112")]
    public class C112_5 : I_C112
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Time reference code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475_5))]
        [Pos(1)]
        public string Timereferencecode_01 { get; set; }
        /// <summary>
        /// Terms time relation code
        /// </summary>
        [DataMember]
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Termstimerelationcode_02 { get; set; }
        /// <summary>
        /// Period type code
        /// </summary>
        [DataMember]
        [DataElement("2151", typeof(EDIFACT_ID_2151_2))]
        [Pos(3)]
        public string Periodtypecode_03 { get; set; }
        /// <summary>
        /// Period count quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Periodcountquantity_04 { get; set; }
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
        /// Rate type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5419", typeof(EDIFACT_ID_5419))]
        [Pos(1)]
        public string Ratetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Unit price basis rate
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("5420", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Unitpricebasisrate_02 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Unitpricebasisvalue_03 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(4)]
        public string Measurementunitcode_04 { get; set; }
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
        /// Price multiplier rate
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 12)]
        [DataElement("5394", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Pricemultiplierrate_01 { get; set; }
        /// <summary>
        /// Price multiplier type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("5393", typeof(EDIFACT_ID_5393))]
        [Pos(2)]
        public string Pricemultipliertypecodequalifier_02 { get; set; }
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
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        /// <summary>
        /// Range maximum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        /// <summary>
        /// Significant digits quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C174")]
    public class C174_2 : I_C174
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411_3))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        /// <summary>
        /// Range maximum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        /// <summary>
        /// Significant digits quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C174")]
    public class C174_3 : I_C174
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411_2))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        /// <summary>
        /// Range maximum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        /// <summary>
        /// Significant digits quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C174")]
    public class C174_4 : I_C174
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411_4))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        /// <summary>
        /// Range maximum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        /// <summary>
        /// Significant digits quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C174")]
    public class C174_5 : I_C174
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411_8))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        /// <summary>
        /// Range maximum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        /// <summary>
        /// Significant digits quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C174")]
    public class C174_6 : I_C174
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411_5))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        /// <summary>
        /// Range maximum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        /// <summary>
        /// Significant digits quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C174")]
    public class C174_7 : I_C174
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411_7))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        /// <summary>
        /// Range maximum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        /// <summary>
        /// Significant digits quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C174")]
    public class C174_8 : I_C174
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411_6))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        /// <summary>
        /// Range maximum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        /// <summary>
        /// Significant digits quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
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
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_11))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411_2))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_10 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_13))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_11 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_10))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_12 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_13 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_2))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411_5))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_14 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_21))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_15 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_19))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411_8))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_16 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_14))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411_10))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_17 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_16))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_18 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_15))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_19 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_20))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411_4))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_2 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_3))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_20 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_23))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_21 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_18))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411_11))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_22 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_17))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_23 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_22))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_24 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_24))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_25 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_25))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_3 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_5))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_4 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_6))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_5 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_7))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_6 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_8))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_7 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_9))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411_9))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_8 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_12))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186_9 : I_C186
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063_4))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411_6))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
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
        /// Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_ID_7065))]
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C202")]
    public class C202_2 : I_C202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_ID_7065_2))]
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C202")]
    public class C202_3 : I_C202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_ID_7065_3))]
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C202")]
    public class C202_4 : I_C202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_ID_7065_4))]
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C202")]
    public class C202_5 : I_C202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_ID_7065_5))]
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C202")]
    public class C202_6 : I_C202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_ID_7065_6))]
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C202")]
    public class C202_7 : I_C202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_ID_7065_7))]
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C202")]
    public class C202_8 : I_C202
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_ID_7065_8))]
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Hazard identification code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 7)]
        [DataElement("8351", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hazardidentificationcode_01 { get; set; }
        /// <summary>
        /// Additional hazard classification identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("8078", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Additionalhazardclassificationidentifier_02 { get; set; }
        /// <summary>
        /// Hazard code version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("8092", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Hazardcodeversionidentifier_03 { get; set; }
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
        /// Object identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        /// <summary>
        /// Object identification code qualifier
        /// </summary>
        [DataMember]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Objectidentificationcodequalifier_02 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statusdescriptioncode_03 { get; set; }
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
        /// Object identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        /// <summary>
        /// Object identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
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
        /// Shipping marks description
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Shippingmarksdescription_01 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Shippingmarksdescription_02 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Shippingmarksdescription_03 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Shippingmarksdescription_04 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Shippingmarksdescription_05 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Shippingmarksdescription_06 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Shippingmarksdescription_07 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Shippingmarksdescription_08 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Shippingmarksdescription_09 { get; set; }
        /// <summary>
        /// Shipping marks description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string Shippingmarksdescription_10 { get; set; }
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
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Length dimension value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6168", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lengthdimensionvalue_02 { get; set; }
        /// <summary>
        /// Width dimension value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6140", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Widthdimensionvalue_03 { get; set; }
        /// <summary>
        /// Height dimension value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6008", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Heightdimensionvalue_04 { get; set; }
    }
    
    /// <summary>
    /// DIMENSIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C211")]
    public class C211_2 : I_C211
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411_7))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Length dimension value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6168", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lengthdimensionvalue_02 { get; set; }
        /// <summary>
        /// Width dimension value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6140", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Widthdimensionvalue_03 { get; set; }
        /// <summary>
        /// Height dimension value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6008", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Heightdimensionvalue_04 { get; set; }
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
        /// Item identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemidentifier_01 { get; set; }
        /// <summary>
        /// Item type identification code
        /// </summary>
        [DataMember]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemtypeidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
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
        /// Package quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Packagequantity_01 { get; set; }
        /// <summary>
        /// Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_ID_7065_9))]
        [Pos(2)]
        public string Packagetypedescriptioncode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Typeofpackages_05 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(6)]
        public string Packagingrelateddescriptioncode_06 { get; set; }
    }
    
    /// <summary>
    /// NUMBER AND TYPE OF PACKAGES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C213")]
    public class C213_2 : I_C213
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Package quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Packagequantity_01 { get; set; }
        /// <summary>
        /// Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_ID_7065_10))]
        [Pos(2)]
        public string Packagetypedescriptioncode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Typeofpackages_05 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(6)]
        public string Packagingrelateddescriptioncode_06 { get; set; }
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
        /// Special service description code
        /// </summary>
        [DataMember]
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    /// <summary>
    /// SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C214")]
    public class C214_2 : I_C214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special service description code
        /// </summary>
        [DataMember]
        [DataElement("7161", typeof(EDIFACT_ID_7161_2))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    /// <summary>
    /// SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C214")]
    public class C214_3 : I_C214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special service description code
        /// </summary>
        [DataMember]
        [DataElement("7161", typeof(EDIFACT_ID_7161_4))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    /// <summary>
    /// SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C214")]
    public class C214_4 : I_C214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special service description code
        /// </summary>
        [DataMember]
        [DataElement("7161", typeof(EDIFACT_ID_7161_5))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    /// <summary>
    /// SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C214")]
    public class C214_5 : I_C214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special service description code
        /// </summary>
        [DataMember]
        [DataElement("7161", typeof(EDIFACT_ID_7161_6))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    /// <summary>
    /// SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C214")]
    public class C214_6 : I_C214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special service description code
        /// </summary>
        [DataMember]
        [DataElement("7161", typeof(EDIFACT_ID_7161_3))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    /// <summary>
    /// SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C214")]
    public class C214_7 : I_C214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special service description code
        /// </summary>
        [DataMember]
        [DataElement("7161", typeof(EDIFACT_ID_7161_7))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    /// <summary>
    /// SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C214")]
    public class C214_8 : I_C214
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special service description code
        /// </summary>
        [DataMember]
        [DataElement("7161", typeof(EDIFACT_ID_7161_8))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        /// <summary>
        /// Special service description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
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
        /// Sealing party name code
        /// </summary>
        [DataMember]
        [DataElement("9303", typeof(EDIFACT_ID_9303))]
        [Pos(1)]
        public string Sealingpartynamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Sealing party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9302", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Sealingpartyname_04 { get; set; }
    }
    
    /// <summary>
    /// SEAL ISSUER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C215")]
    public class C215_2 : I_C215
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sealing party name code
        /// </summary>
        [DataMember]
        [DataElement("9303", typeof(EDIFACT_ID_9303_2))]
        [Pos(1)]
        public string Sealingpartynamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Sealing party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9302", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Sealingpartyname_04 { get; set; }
    }
    
    /// <summary>
    /// SEAL ISSUER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C215")]
    public class C215_3 : I_C215
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sealing party name code
        /// </summary>
        [DataMember]
        [DataElement("9303", typeof(EDIFACT_ID_9303_3))]
        [Pos(1)]
        public string Sealingpartynamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Sealing party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9302", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Sealingpartyname_04 { get; set; }
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
        /// Hazardous material category name code
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7419", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hazardousmaterialcategorynamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Hazardous material category name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7418", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Hazardousmaterialcategoryname_04 { get; set; }
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
        /// Transport mode name code
        /// </summary>
        [DataMember]
        [DataElement("8067", typeof(EDIFACT_ID_8067))]
        [Pos(1)]
        public string Transportmodenamecode_01 { get; set; }
        /// <summary>
        /// Transport mode name
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmodename_02 { get; set; }
    }
    
    /// <summary>
    /// MODE OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C220")]
    public class C220_2 : I_C220
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport mode name code
        /// </summary>
        [DataMember]
        [DataElement("8067", typeof(EDIFACT_ID_8067_2))]
        [Pos(1)]
        public string Transportmodenamecode_01 { get; set; }
        /// <summary>
        /// Transport mode name
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmodename_02 { get; set; }
    }
    
    /// <summary>
    /// MODE OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C220")]
    public class C220_3 : I_C220
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport mode name code
        /// </summary>
        [DataMember]
        [DataElement("8067", typeof(EDIFACT_ID_8067_3))]
        [Pos(1)]
        public string Transportmodenamecode_01 { get; set; }
        /// <summary>
        /// Transport mode name
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmodename_02 { get; set; }
    }
    
    /// <summary>
    /// MODE OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C220")]
    public class C220_4 : I_C220
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport mode name code
        /// </summary>
        [DataMember]
        [DataElement("8067", typeof(EDIFACT_ID_8067_4))]
        [Pos(1)]
        public string Transportmodenamecode_01 { get; set; }
        /// <summary>
        /// Transport mode name
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmodename_02 { get; set; }
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
        /// Transport means identification name identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("8213", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Transportmeansidentificationnameidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Transport means identification name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Transportmeansidentificationname_04 { get; set; }
        /// <summary>
        /// Transport means nationality code
        /// </summary>
        [DataMember]
        [DataElement("8453", typeof(EDIFACT_ID_8453))]
        [Pos(5)]
        public string Transportmeansnationalitycode_05 { get; set; }
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
        /// Shipment flashpoint value
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("7106", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Shipmentflashpointvalue_01 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(2)]
        public string Measurementunitcode_02 { get; set; }
    }
    
    /// <summary>
    /// DANGEROUS GOODS SHIPMENT FLASHPOINT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C223")]
    public class C223_2 : I_C223
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment flashpoint value
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("7106", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Shipmentflashpointvalue_01 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411_2))]
        [Pos(2)]
        public string Measurementunitcode_02 { get; set; }
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
        /// Equipment size and type description code
        /// </summary>
        [DataMember]
        [DataElement("8155", typeof(EDIFACT_ID_8155))]
        [Pos(1)]
        public string Equipmentsizeandtypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Equipment size and type description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("8154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Equipmentsizeandtypedescription_04 { get; set; }
    }
    
    /// <summary>
    /// EQUIPMENT SIZE AND TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C224")]
    public class C224_2 : I_C224
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment size and type description code
        /// </summary>
        [DataMember]
        [DataElement("8155", typeof(EDIFACT_ID_8155_2))]
        [Pos(1)]
        public string Equipmentsizeandtypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Equipment size and type description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("8154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Equipmentsizeandtypedescription_04 { get; set; }
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
        /// Transport means description code
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_ID_8179))]
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        /// <summary>
        /// Transport means description
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C228")]
    public class C228_2 : I_C228
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport means description code
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_ID_8179_2))]
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        /// <summary>
        /// Transport means description
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C228")]
    public class C228_3 : I_C228
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport means description code
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_ID_8179_3))]
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        /// <summary>
        /// Transport means description
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C228")]
    public class C228_4 : I_C228
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport means description code
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_ID_8179_4))]
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        /// <summary>
        /// Transport means description
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C228")]
    public class C228_5 : I_C228
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport means description code
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_ID_8179_5))]
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        /// <summary>
        /// Transport means description
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C228")]
    public class C228_6 : I_C228
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport means description code
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_ID_8179_6))]
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        /// <summary>
        /// Transport means description
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C228")]
    public class C228_7 : I_C228
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport means description code
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_ID_8179_7))]
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        /// <summary>
        /// Transport means description
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
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
        /// Government agency identification code
        /// </summary>
        [DataMember]
        [DataElement("9415", typeof(EDIFACT_ID_9415))]
        [Pos(1)]
        public string Governmentagencyidentificationcode_01 { get; set; }
        /// <summary>
        /// Government involvement code
        /// </summary>
        [DataMember]
        [DataElement("9411", typeof(EDIFACT_ID_9411))]
        [Pos(2)]
        public string Governmentinvolvementcode_02 { get; set; }
        /// <summary>
        /// Government action code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9417", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Governmentactioncode_03 { get; set; }
        /// <summary>
        /// Government procedure code
        /// </summary>
        [DataMember]
        [DataElement("9353", typeof(EDIFACT_ID_9353))]
        [Pos(4)]
        public string Governmentprocedurecode_04 { get; set; }
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
        /// Service requirement code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7273", typeof(EDIFACT_ID_7273))]
        [Pos(1)]
        public string Servicerequirementcode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Service requirement code
        /// </summary>
        [DataMember]
        [DataElement("7273", typeof(EDIFACT_ID_7273))]
        [Pos(4)]
        public string Servicerequirementcode_04 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistidentificationcode_05 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string Codelistresponsibleagencycode_06 { get; set; }
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
        /// United Nations Dangerous Goods (UNDG) identifier
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("7124", typeof(EDIFACT_N))]
        [Pos(1)]
        public string UnitedNationsDangerousGoodsUNDGidentifier_01 { get; set; }
        /// <summary>
        /// Dangerous goods flashpoint value
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("7088", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dangerousgoodsflashpointvalue_02 { get; set; }
    }
    
    /// <summary>
    /// HAZARD IDENTIFICATION PLACARD DETAILS
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
        /// Orange hazard placard upper part identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8158", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Orangehazardplacardupperpartidentifier_01 { get; set; }
        /// <summary>
        /// Orange hazard placard lower part identifier
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("8186", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Orangehazardplacardlowerpartidentifier_02 { get; set; }
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
        /// Dangerous goods marking identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dangerousgoodsmarkingidentifier_01 { get; set; }
        /// <summary>
        /// Dangerous goods marking identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dangerousgoodsmarkingidentifier_02 { get; set; }
        /// <summary>
        /// Dangerous goods marking identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Dangerousgoodsmarkingidentifier_03 { get; set; }
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
        /// Equipment identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8260", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Equipmentidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
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
        /// Temperature value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6246", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Temperaturevalue_01 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(2)]
        public string Measurementunitcode_02 { get; set; }
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
        /// Characteristic description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(1)]
        public string Characteristicdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Characteristic description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristicdescription_04 { get; set; }
        /// <summary>
        /// Characteristic description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Characteristicdescription_05 { get; set; }
    }
    
    /// <summary>
    /// PRODUCT CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C240")]
    public class C240_2 : I_C240
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Characteristic description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7037", typeof(EDIFACT_ID_7037_2))]
        [Pos(1)]
        public string Characteristicdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Characteristic description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristicdescription_04 { get; set; }
        /// <summary>
        /// Characteristic description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Characteristicdescription_05 { get; set; }
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
        /// Duty or tax or fee type name code
        /// </summary>
        [DataMember]
        [DataElement("5153", typeof(EDIFACT_ID_5153_2))]
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee type name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C241")]
    public class C241_2 : I_C241
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty or tax or fee type name code
        /// </summary>
        [DataMember]
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee type name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C241")]
    public class C241_3 : I_C241
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty or tax or fee type name code
        /// </summary>
        [DataMember]
        [DataElement("5153", typeof(EDIFACT_ID_5153_3))]
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee type name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C241")]
    public class C241_4 : I_C241
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty or tax or fee type name code
        /// </summary>
        [DataMember]
        [DataElement("5153", typeof(EDIFACT_ID_5153_4))]
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee type name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    /// <summary>
    /// DUTY/TAX/FEE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C241")]
    public class C241_5 : I_C241
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty or tax or fee type name code
        /// </summary>
        [DataMember]
        [DataElement("5153", typeof(EDIFACT_ID_5153_5))]
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee type name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
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
        /// Process type description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7187", typeof(EDIFACT_ID_7187))]
        [Pos(1)]
        public string Processtypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Process type description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7186", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Processtypedescription_04 { get; set; }
        /// <summary>
        /// Process type description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7186", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Processtypedescription_05 { get; set; }
    }
    
    /// <summary>
    /// PROCESS TYPE AND DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C242")]
    public class C242_2 : I_C242
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Process type description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7187", typeof(EDIFACT_ID_7187_2))]
        [Pos(1)]
        public string Processtypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Process type description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7186", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Processtypedescription_04 { get; set; }
        /// <summary>
        /// Process type description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7186", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Processtypedescription_05 { get; set; }
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
        /// Duty or tax or fee rate code
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeratecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee rate
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeerate_04 { get; set; }
        /// <summary>
        /// Duty or tax or fee rate basis code
        /// </summary>
        [DataMember]
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string Dutyortaxorfeeratebasiscode_05 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistidentificationcode_06 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycode_07 { get; set; }
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
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270_10 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069_10))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270_11 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069_11))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270_12 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069_12))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270_2 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069_3))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270_3 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069_2))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270_4 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069_4))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270_5 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069_5))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270_6 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069_6))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270_7 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069_7))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270_8 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069_8))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270_9 : I_C270
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Control total type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069_9))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control total value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    /// <summary>
    /// ITEM CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C272")]
    public class C272 : I_C272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item characteristic code
        /// </summary>
        [DataMember]
        [DataElement("7081", typeof(EDIFACT_ID_7081_7))]
        [Pos(1)]
        public string Itemcharacteristiccode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// ITEM CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C272")]
    public class C272_2 : I_C272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item characteristic code
        /// </summary>
        [DataMember]
        [DataElement("7081", typeof(EDIFACT_ID_7081))]
        [Pos(1)]
        public string Itemcharacteristiccode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// ITEM CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C272")]
    public class C272_3 : I_C272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item characteristic code
        /// </summary>
        [DataMember]
        [DataElement("7081", typeof(EDIFACT_ID_7081_2))]
        [Pos(1)]
        public string Itemcharacteristiccode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// ITEM CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C272")]
    public class C272_4 : I_C272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item characteristic code
        /// </summary>
        [DataMember]
        [DataElement("7081", typeof(EDIFACT_ID_7081_3))]
        [Pos(1)]
        public string Itemcharacteristiccode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// ITEM CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C272")]
    public class C272_5 : I_C272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item characteristic code
        /// </summary>
        [DataMember]
        [DataElement("7081", typeof(EDIFACT_ID_7081_4))]
        [Pos(1)]
        public string Itemcharacteristiccode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// ITEM CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C272")]
    public class C272_6 : I_C272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item characteristic code
        /// </summary>
        [DataMember]
        [DataElement("7081", typeof(EDIFACT_ID_7081_5))]
        [Pos(1)]
        public string Itemcharacteristiccode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// ITEM CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C272")]
    public class C272_7 : I_C272
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item characteristic code
        /// </summary>
        [DataMember]
        [DataElement("7081", typeof(EDIFACT_ID_7081_6))]
        [Pos(1)]
        public string Itemcharacteristiccode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009_7))]
        [Pos(1)]
        public string Itemdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(6)]
        public string Languagenamecode_06 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C273")]
    public class C273_2 : I_C273
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(1)]
        public string Itemdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(6)]
        public string Languagenamecode_06 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C273")]
    public class C273_3 : I_C273
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009_2))]
        [Pos(1)]
        public string Itemdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(6)]
        public string Languagenamecode_06 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C273")]
    public class C273_4 : I_C273
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009_3))]
        [Pos(1)]
        public string Itemdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(6)]
        public string Languagenamecode_06 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C273")]
    public class C273_5 : I_C273
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009_4))]
        [Pos(1)]
        public string Itemdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(6)]
        public string Languagenamecode_06 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C273")]
    public class C273_6 : I_C273
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009_5))]
        [Pos(1)]
        public string Itemdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(6)]
        public string Languagenamecode_06 { get; set; }
    }
    
    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C273")]
    public class C273_7 : I_C273
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item description code
        /// </summary>
        [DataMember]
        [DataElement("7009", typeof(EDIFACT_ID_7009_6))]
        [Pos(1)]
        public string Itemdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(6)]
        public string Languagenamecode_06 { get; set; }
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
        /// Quantity variance value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantityvariancevalue_01 { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6063", typeof(EDIFACT_ID_6063_13))]
        [Pos(2)]
        public string Quantitytypecodequalifier_02 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DIFFERENCE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C279")]
    public class C279_2 : I_C279
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity variance value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantityvariancevalue_01 { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6063", typeof(EDIFACT_ID_6063_5))]
        [Pos(2)]
        public string Quantitytypecodequalifier_02 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DIFFERENCE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C279")]
    public class C279_3 : I_C279
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity variance value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantityvariancevalue_01 { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6063", typeof(EDIFACT_ID_6063_6))]
        [Pos(2)]
        public string Quantitytypecodequalifier_02 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DIFFERENCE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C279")]
    public class C279_4 : I_C279
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity variance value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantityvariancevalue_01 { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6063", typeof(EDIFACT_ID_6063_7))]
        [Pos(2)]
        public string Quantitytypecodequalifier_02 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DIFFERENCE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C279")]
    public class C279_5 : I_C279
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity variance value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantityvariancevalue_01 { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6063", typeof(EDIFACT_ID_6063_8))]
        [Pos(2)]
        public string Quantitytypecodequalifier_02 { get; set; }
    }
    
    /// <summary>
    /// QUANTITY DIFFERENCE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C279")]
    public class C279_6 : I_C279
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity variance value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantityvariancevalue_01 { get; set; }
        /// <summary>
        /// Quantity type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6063", typeof(EDIFACT_ID_6063_3))]
        [Pos(2)]
        public string Quantitytypecodequalifier_02 { get; set; }
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
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Range minimum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Rangeminimumvalue_02 { get; set; }
        /// <summary>
        /// Range maximum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangemaximumvalue_03 { get; set; }
    }
    
    /// <summary>
    /// RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C280")]
    public class C280_2 : I_C280
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411_3))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Range minimum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Rangeminimumvalue_02 { get; set; }
        /// <summary>
        /// Range maximum value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangemaximumvalue_03 { get; set; }
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
        /// Sequence position identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Sequencepositionidentifier_01 { get; set; }
        /// <summary>
        /// Sequence identifier source code
        /// </summary>
        [DataMember]
        [DataElement("1159", typeof(EDIFACT_ID_1159))]
        [Pos(2)]
        public string Sequenceidentifiersourcecode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
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
        /// Product group name code
        /// </summary>
        [DataMember]
        [DataElement("5389", typeof(EDIFACT_ID_5389))]
        [Pos(1)]
        public string Productgroupnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Product group name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5388", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Productgroupname_04 { get; set; }
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
        /// Frequency code
        /// </summary>
        [DataMember]
        [DataElement("2013", typeof(EDIFACT_ID_2013))]
        [Pos(1)]
        public string Frequencycode_01 { get; set; }
        /// <summary>
        /// Despatch pattern code
        /// </summary>
        [DataMember]
        [DataElement("2015", typeof(EDIFACT_ID_2015))]
        [Pos(2)]
        public string Despatchpatterncode_02 { get; set; }
        /// <summary>
        /// Despatch pattern timing code
        /// </summary>
        [DataMember]
        [DataElement("2017", typeof(EDIFACT_ID_2017))]
        [Pos(3)]
        public string Despatchpatterntimingcode_03 { get; set; }
    }
    
    /// <summary>
    /// PATTERN DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C329")]
    public class C329_2 : I_C329
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Frequency code
        /// </summary>
        [DataMember]
        [DataElement("2013", typeof(EDIFACT_ID_2013_2))]
        [Pos(1)]
        public string Frequencycode_01 { get; set; }
        /// <summary>
        /// Despatch pattern code
        /// </summary>
        [DataMember]
        [DataElement("2015", typeof(EDIFACT_ID_2015_2))]
        [Pos(2)]
        public string Despatchpatterncode_02 { get; set; }
        /// <summary>
        /// Despatch pattern timing code
        /// </summary>
        [DataMember]
        [DataElement("2017", typeof(EDIFACT_ID_2017))]
        [Pos(3)]
        public string Despatchpatterntimingcode_03 { get; set; }
    }
    
    /// <summary>
    /// PATTERN DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C329")]
    public class C329_3 : I_C329
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Frequency code
        /// </summary>
        [DataMember]
        [DataElement("2013", typeof(EDIFACT_ID_2013_2))]
        [Pos(1)]
        public string Frequencycode_01 { get; set; }
        /// <summary>
        /// Despatch pattern code
        /// </summary>
        [DataMember]
        [DataElement("2015", typeof(EDIFACT_ID_2015_3))]
        [Pos(2)]
        public string Despatchpatterncode_02 { get; set; }
        /// <summary>
        /// Despatch pattern timing code
        /// </summary>
        [DataMember]
        [DataElement("2017", typeof(EDIFACT_ID_2017_2))]
        [Pos(3)]
        public string Despatchpatterntimingcode_03 { get; set; }
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
        /// Requested information description code
        /// </summary>
        [DataMember]
        [DataElement("4511", typeof(EDIFACT_ID_4511))]
        [Pos(1)]
        public string Requestedinformationdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Requested information description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4510", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Requestedinformationdescription_04 { get; set; }
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
        /// Excess transportation reason code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("8457", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Excesstransportationreasoncode_01 { get; set; }
        /// <summary>
        /// Excess transportation responsibility code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("8459", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Excesstransportationresponsibilitycode_02 { get; set; }
        /// <summary>
        /// Customer shipment authorisation identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Customershipmentauthorisationidentifier_03 { get; set; }
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
        /// Description format code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
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
        /// Item type identification code
        /// </summary>
        [DataMember]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(3)]
        public string Itemtypeidentificationcode_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
        /// <summary>
        /// Item type identification code
        /// </summary>
        [DataMember]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(5)]
        public string Itemtypeidentificationcode_05 { get; set; }
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
        /// Percentage type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245_2))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis identification code
        /// </summary>
        [DataMember]
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C501")]
    public class C501_2 : I_C501
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Percentage type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis identification code
        /// </summary>
        [DataMember]
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C501")]
    public class C501_3 : I_C501
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Percentage type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245_3))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis identification code
        /// </summary>
        [DataMember]
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C501")]
    public class C501_4 : I_C501
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Percentage type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245_4))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis identification code
        /// </summary>
        [DataMember]
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C501")]
    public class C501_5 : I_C501
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Percentage type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245_5))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis identification code
        /// </summary>
        [DataMember]
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C501")]
    public class C501_6 : I_C501
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Percentage type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245_6))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis identification code
        /// </summary>
        [DataMember]
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C501")]
    public class C501_7 : I_C501
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Percentage type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245_7))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis identification code
        /// </summary>
        [DataMember]
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C501")]
    public class C501_8 : I_C501
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Percentage type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245_7))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis identification code
        /// </summary>
        [DataMember]
        [DataElement("5249", typeof(EDIFACT_ID_5249_2))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
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
        /// Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313_3))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502_2 : I_C502
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502_3 : I_C502
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313_2))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321_2))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502_4 : I_C502
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313_4))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321_2))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502_5 : I_C502
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313_8))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321_2))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502_6 : I_C502
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313_5))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321_2))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502_7 : I_C502
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313_9))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321_2))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502_8 : I_C502
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313_7))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502_9 : I_C502
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313_6))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance code
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321_2))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
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
        /// Document identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        /// <summary>
        /// Document status code
        /// </summary>
        [DataMember]
        [DataElement("1373", typeof(EDIFACT_ID_1373))]
        [Pos(2)]
        public string Documentstatuscode_02 { get; set; }
        /// <summary>
        /// Document source description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentsourcedescription_03 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(4)]
        public string Languagenamecode_04 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Versionidentifier_05 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Revisionidentifier_06 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C503")]
    public class C503_2 : I_C503
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        /// <summary>
        /// Document status code
        /// </summary>
        [DataMember]
        [DataElement("1373", typeof(EDIFACT_ID_1373_2))]
        [Pos(2)]
        public string Documentstatuscode_02 { get; set; }
        /// <summary>
        /// Document source description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentsourcedescription_03 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(4)]
        public string Languagenamecode_04 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Versionidentifier_05 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Revisionidentifier_06 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C503")]
    public class C503_3 : I_C503
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        /// <summary>
        /// Document status code
        /// </summary>
        [DataMember]
        [DataElement("1373", typeof(EDIFACT_ID_1373_3))]
        [Pos(2)]
        public string Documentstatuscode_02 { get; set; }
        /// <summary>
        /// Document source description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentsourcedescription_03 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(4)]
        public string Languagenamecode_04 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Versionidentifier_05 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Revisionidentifier_06 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C503")]
    public class C503_4 : I_C503
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        /// <summary>
        /// Document status code
        /// </summary>
        [DataMember]
        [DataElement("1373", typeof(EDIFACT_ID_1373_4))]
        [Pos(2)]
        public string Documentstatuscode_02 { get; set; }
        /// <summary>
        /// Document source description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentsourcedescription_03 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(4)]
        public string Languagenamecode_04 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Versionidentifier_05 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Revisionidentifier_06 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C503")]
    public class C503_5 : I_C503
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        /// <summary>
        /// Document status code
        /// </summary>
        [DataMember]
        [DataElement("1373", typeof(EDIFACT_ID_1373_5))]
        [Pos(2)]
        public string Documentstatuscode_02 { get; set; }
        /// <summary>
        /// Document source description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentsourcedescription_03 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(4)]
        public string Languagenamecode_04 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Versionidentifier_05 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Revisionidentifier_06 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C503")]
    public class C503_6 : I_C503
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        /// <summary>
        /// Document status code
        /// </summary>
        [DataMember]
        [DataElement("1373", typeof(EDIFACT_ID_1373_6))]
        [Pos(2)]
        public string Documentstatuscode_02 { get; set; }
        /// <summary>
        /// Document source description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentsourcedescription_03 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(4)]
        public string Languagenamecode_04 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Versionidentifier_05 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Revisionidentifier_06 { get; set; }
    }
    
    /// <summary>
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C503")]
    public class C503_7 : I_C503
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        /// <summary>
        /// Document status code
        /// </summary>
        [DataMember]
        [DataElement("1373", typeof(EDIFACT_ID_1373_7))]
        [Pos(2)]
        public string Documentstatuscode_02 { get; set; }
        /// <summary>
        /// Document source description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentsourcedescription_03 { get; set; }
        /// <summary>
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(4)]
        public string Languagenamecode_04 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Versionidentifier_05 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Revisionidentifier_06 { get; set; }
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
        /// Currency usage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string Currencyusagecodequalifier_01 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(2)]
        public string Currencyidentificationcode_02 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string Currencytypecodequalifier_03 { get; set; }
        /// <summary>
        /// Currency rate value
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Currencyratevalue_04 { get; set; }
    }
    
    /// <summary>
    /// CURRENCY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C504")]
    public class C504_2 : I_C504
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Currency usage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347_2))]
        [Pos(1)]
        public string Currencyusagecodequalifier_01 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(2)]
        public string Currencyidentificationcode_02 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string Currencytypecodequalifier_03 { get; set; }
        /// <summary>
        /// Currency rate value
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Currencyratevalue_04 { get; set; }
    }
    
    /// <summary>
    /// CURRENCY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C504")]
    public class C504_3 : I_C504
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Currency usage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string Currencyusagecodequalifier_01 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(2)]
        public string Currencyidentificationcode_02 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343_2))]
        [Pos(3)]
        public string Currencytypecodequalifier_03 { get; set; }
        /// <summary>
        /// Currency rate value
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Currencyratevalue_04 { get; set; }
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
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_34))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_10 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_3))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_11 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_5))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_12 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_6))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_13 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_7))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_14 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_8))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_15 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_11))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_16 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_12))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_17 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_13))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_18 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_14))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_19 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_15))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_2 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_4))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_20 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_16))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_21 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_17))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_22 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_19))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_23 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_20))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_24 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_21))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_25 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_22))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_26 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_23))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_27 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_24))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_28 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_25))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_29 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_27))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_3 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_38))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_30 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_29))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_31 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_30))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_32 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_31))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_33 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_32))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_34 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_33))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_35 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_35))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_36 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_36))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_37 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_37))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_38 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_39))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_39 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_10))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_4 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_9))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_40 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_18))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_41 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_41))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_42 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_43))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_43 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_44))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_44 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_42))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_5 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_28))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_6 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_40))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_7 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_26))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_8 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506_9 : I_C506
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153_2))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        /// <summary>
        /// Reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Document line identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        /// <summary>
        /// Reference version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
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
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_4))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_3))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_10 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_37))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_6))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_11 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_10))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_6))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_12 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_29))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_13 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_30))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_14 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_39))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_15 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_40))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_16 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_14))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_6))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_17 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_15))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_9))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_18 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_18))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_11))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_19 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_32))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_2 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_20 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_20))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_6))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_21 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_13))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_8))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_22 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_11))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_6))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_23 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_12))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_7))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_24 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_16))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_25 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_17))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_10))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_26 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_19))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_6))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_27 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_10))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_12))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_28 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_21))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_6))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_29 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_22))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_3 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_8))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_3))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_30 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_23))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_2))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_31 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_24))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_13))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_32 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_26))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_13))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_33 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_27))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_34 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_28))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_14))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_35 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_31))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_15))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_36 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_34))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_37 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_35))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_6))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_38 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_36))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_39 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_38))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_3))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_4 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_2))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_2))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_40 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_41))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_41 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_42))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_42 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_43))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_43 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_25))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_13))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_44 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_33))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_16))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_5 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_3))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_2))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_6 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_9))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_3))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_7 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_5))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_4))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_8 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_6))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_5))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507_9 : I_C507
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or time or period function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005_7))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date or time or period value
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date or time or period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379_5))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
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
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509_10 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125_3))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375_3))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387_8))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509_11 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125_3))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375_3))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387_9))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509_12 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125_8))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375_3))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387_5))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509_2 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125_2))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375_2))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387_2))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509_3 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125_5))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375_3))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387_5))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509_4 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125_7))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375_3))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387_10))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509_5 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125_3))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375_3))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509_6 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125_3))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375_3))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387_3))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509_7 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125_4))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375_3))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387_4))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509_8 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125_6))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375_3))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387_6))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509_9 : I_C509
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Price code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125_3))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        /// <summary>
        /// Price amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        /// <summary>
        /// Price type code
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375_3))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        /// <summary>
        /// Price specification code
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387_7))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_ID_6411_3))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
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
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_10 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_19))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_11 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_5))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_12 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_12))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_13 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_13))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_14 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_4))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_15 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_17))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_16 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_10))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_17 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_9))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_18 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_20))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343_3))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_19 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_16))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_2 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_2))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_20 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_11))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_21 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_23))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_22 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_24))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343_4))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_23 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_25))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_24 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_24))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_25 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_21))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_26 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_22))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_3 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_3))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_4 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_18))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_5 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_14))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_6 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_6))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_7 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_8))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_8 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_15))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516_9 : I_C516
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary amount type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025_7))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
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
        /// Location name code
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Locationnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Location name
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Locationname_04 { get; set; }
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
        /// First related location name code
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Firstrelatedlocationnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// First related location name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Firstrelatedlocationname_04 { get; set; }
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
        /// Business function type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4027", typeof(EDIFACT_ID_4027))]
        [Pos(1)]
        public string Businessfunctiontypecodequalifier_01 { get; set; }
        /// <summary>
        /// Business function code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4025", typeof(EDIFACT_ID_4025))]
        [Pos(2)]
        public string Businessfunctioncode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
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
    /// BUSINESS FUNCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C521")]
    public class C521_2 : I_C521
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Business function type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4027", typeof(EDIFACT_ID_4027))]
        [Pos(1)]
        public string Businessfunctiontypecodequalifier_01 { get; set; }
        /// <summary>
        /// Business function code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4025", typeof(EDIFACT_ID_4025_2))]
        [Pos(2)]
        public string Businessfunctioncode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
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
        /// Instruction type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4403", typeof(EDIFACT_ID_4403))]
        [Pos(1)]
        public string Instructiontypecodequalifier_01 { get; set; }
        /// <summary>
        /// Instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4401", typeof(EDIFACT_ID_4401))]
        [Pos(2)]
        public string Instructiondescriptioncode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
        /// <summary>
        /// Instruction description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4400", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Instructiondescription_05 { get; set; }
    }
    
    /// <summary>
    /// INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C522")]
    public class C522_2 : I_C522
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Instruction type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4403", typeof(EDIFACT_ID_4403_2))]
        [Pos(1)]
        public string Instructiontypecodequalifier_01 { get; set; }
        /// <summary>
        /// Instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4401", typeof(EDIFACT_ID_4401))]
        [Pos(2)]
        public string Instructiondescriptioncode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
        /// <summary>
        /// Instruction description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4400", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Instructiondescription_05 { get; set; }
    }
    
    /// <summary>
    /// INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C522")]
    public class C522_3 : I_C522
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Instruction type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4403", typeof(EDIFACT_ID_4403_3))]
        [Pos(1)]
        public string Instructiontypecodequalifier_01 { get; set; }
        /// <summary>
        /// Instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4401", typeof(EDIFACT_ID_4401_2))]
        [Pos(2)]
        public string Instructiondescriptioncode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
        /// <summary>
        /// Instruction description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4400", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Instructiondescription_05 { get; set; }
    }
    
    /// <summary>
    /// INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C522")]
    public class C522_4 : I_C522
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Instruction type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4403", typeof(EDIFACT_ID_4403_3))]
        [Pos(1)]
        public string Instructiontypecodequalifier_01 { get; set; }
        /// <summary>
        /// Instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4401", typeof(EDIFACT_ID_4401_3))]
        [Pos(2)]
        public string Instructiondescriptioncode_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
        /// <summary>
        /// Instruction description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4400", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Instructiondescription_05 { get; set; }
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
        /// Units quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Unitsquantity_01 { get; set; }
        /// <summary>
        /// Unit type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6353", typeof(EDIFACT_ID_6353))]
        [Pos(2)]
        public string Unittypecodequalifier_02 { get; set; }
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
        /// Handling instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4079", typeof(EDIFACT_ID_4079))]
        [Pos(1)]
        public string Handlinginstructiondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Handling instruction description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Handlinginstructiondescription_04 { get; set; }
    }
    
    /// <summary>
    /// HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C524")]
    public class C524_2 : I_C524
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Handling instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4079", typeof(EDIFACT_ID_4079_2))]
        [Pos(1)]
        public string Handlinginstructiondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Handling instruction description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Handlinginstructiondescription_04 { get; set; }
    }
    
    /// <summary>
    /// HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C524")]
    public class C524_3 : I_C524
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Handling instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4079", typeof(EDIFACT_ID_4079_3))]
        [Pos(1)]
        public string Handlinginstructiondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Handling instruction description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Handlinginstructiondescription_04 { get; set; }
    }
    
    /// <summary>
    /// HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C524")]
    public class C524_4 : I_C524
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Handling instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4079", typeof(EDIFACT_ID_4079_4))]
        [Pos(1)]
        public string Handlinginstructiondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Handling instruction description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Handlinginstructiondescription_04 { get; set; }
    }
    
    /// <summary>
    /// HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C524")]
    public class C524_5 : I_C524
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Handling instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4079", typeof(EDIFACT_ID_4079_5))]
        [Pos(1)]
        public string Handlinginstructiondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Handling instruction description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Handlinginstructiondescription_04 { get; set; }
    }
    
    /// <summary>
    /// HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C524")]
    public class C524_6 : I_C524
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Handling instruction description code
        /// </summary>
        [DataMember]
        [DataElement("4079", typeof(EDIFACT_ID_4079_6))]
        [Pos(1)]
        public string Handlinginstructiondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Handling instruction description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Handlinginstructiondescription_04 { get; set; }
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
        /// Processing indicator description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7365", typeof(EDIFACT_ID_7365))]
        [Pos(1)]
        public string Processingindicatordescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Process type description code
        /// </summary>
        [DataMember]
        [DataElement("7187", typeof(EDIFACT_ID_7187))]
        [Pos(4)]
        public string Processtypedescriptioncode_04 { get; set; }
    }
    
    /// <summary>
    /// PROCESSING INDICATOR
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C529")]
    public class C529_2 : I_C529
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Processing indicator description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7365", typeof(EDIFACT_ID_7365_3))]
        [Pos(1)]
        public string Processingindicatordescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Process type description code
        /// </summary>
        [DataMember]
        [DataElement("7187", typeof(EDIFACT_ID_7187))]
        [Pos(4)]
        public string Processtypedescriptioncode_04 { get; set; }
    }
    
    /// <summary>
    /// PROCESSING INDICATOR
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C529")]
    public class C529_3 : I_C529
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Processing indicator description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7365", typeof(EDIFACT_ID_7365_2))]
        [Pos(1)]
        public string Processingindicatordescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Process type description code
        /// </summary>
        [DataMember]
        [DataElement("7187", typeof(EDIFACT_ID_7187))]
        [Pos(4)]
        public string Processtypedescriptioncode_04 { get; set; }
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
        /// Packaging level code
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions code
        /// </summary>
        [DataMember]
        [DataElement("7073", typeof(EDIFACT_ID_7073))]
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C531")]
    public class C531_2 : I_C531
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Packaging level code
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233_2))]
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions code
        /// </summary>
        [DataMember]
        [DataElement("7073", typeof(EDIFACT_ID_7073))]
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C531")]
    public class C531_3 : I_C531
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Packaging level code
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233_2))]
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions code
        /// </summary>
        [DataMember]
        [DataElement("7073", typeof(EDIFACT_ID_7073_2))]
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C531")]
    public class C531_4 : I_C531
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Packaging level code
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233_3))]
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions code
        /// </summary>
        [DataMember]
        [DataElement("7073", typeof(EDIFACT_ID_7073_2))]
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C531")]
    public class C531_5 : I_C531
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Packaging level code
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233_2))]
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions code
        /// </summary>
        [DataMember]
        [DataElement("7073", typeof(EDIFACT_ID_7073_3))]
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C531")]
    public class C531_6 : I_C531
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Packaging level code
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233_2))]
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions code
        /// </summary>
        [DataMember]
        [DataElement("7073", typeof(EDIFACT_ID_7073_4))]
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C531")]
    public class C531_7 : I_C531
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Packaging level code
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233_2))]
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions code
        /// </summary>
        [DataMember]
        [DataElement("7073", typeof(EDIFACT_ID_7073_5))]
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C531")]
    public class C531_8 : I_C531
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Packaging level code
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions code
        /// </summary>
        [DataMember]
        [DataElement("7073", typeof(EDIFACT_ID_7073_2))]
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
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
        /// Returnable package freight payment responsibility code
        /// </summary>
        [DataMember]
        [DataElement("8395", typeof(EDIFACT_ID_8395))]
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycode_01 { get; set; }
        /// <summary>
        /// Returnable package load contents code
        /// </summary>
        [DataMember]
        [DataElement("8393", typeof(EDIFACT_ID_8393))]
        [Pos(2)]
        public string Returnablepackageloadcontentscode_02 { get; set; }
    }
    
    /// <summary>
    /// RETURNABLE PACKAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C532")]
    public class C532_2 : I_C532
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Returnable package freight payment responsibility code
        /// </summary>
        [DataMember]
        [DataElement("8395", typeof(EDIFACT_ID_8395_2))]
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycode_01 { get; set; }
        /// <summary>
        /// Returnable package load contents code
        /// </summary>
        [DataMember]
        [DataElement("8393", typeof(EDIFACT_ID_8393))]
        [Pos(2)]
        public string Returnablepackageloadcontentscode_02 { get; set; }
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
        /// Duty or tax or fee account code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeaccountcode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534_10 : I_C534
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439_2))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431_2))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461_7))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435_2))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534_11 : I_C534
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439_4))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431_2))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461_9))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435_2))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534_2 : I_C534
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439_3))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461_10))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534_3 : I_C534
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439_3))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461_4))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435_3))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534_4 : I_C534
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439_3))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461_5))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435_4))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534_5 : I_C534
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439_4))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431_2))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534_6 : I_C534
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439_3))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461_3))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534_7 : I_C534
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439_3))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461_8))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435_4))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534_8 : I_C534
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439_2))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431_2))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461_2))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435_2))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534_9 : I_C534
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment conditions code
        /// </summary>
        [DataMember]
        [DataElement("4439", typeof(EDIFACT_ID_4439_2))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        /// <summary>
        /// Payment guarantee means code
        /// </summary>
        [DataMember]
        [DataElement("4431", typeof(EDIFACT_ID_4431_2))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        /// <summary>
        /// Payment means code
        /// </summary>
        [DataMember]
        [DataElement("4461", typeof(EDIFACT_ID_4461_6))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        /// <summary>
        /// Payment channel code
        /// </summary>
        [DataMember]
        [DataElement("4435", typeof(EDIFACT_ID_4435_2))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
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
        /// Contract and carriage condition code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4065", typeof(EDIFACT_ID_4065))]
        [Pos(1)]
        public string Contractandcarriageconditioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTRACT AND CARRIAGE CONDITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C536")]
    public class C536_2 : I_C536
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contract and carriage condition code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4065", typeof(EDIFACT_ID_4065_2))]
        [Pos(1)]
        public string Contractandcarriageconditioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// CONTRACT AND CARRIAGE CONDITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C536")]
    public class C536_3 : I_C536
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contract and carriage condition code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4065", typeof(EDIFACT_ID_4065_3))]
        [Pos(1)]
        public string Contractandcarriageconditioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Transport service priority code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4219", typeof(EDIFACT_ID_4219))]
        [Pos(1)]
        public string Transportserviceprioritycode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// TRANSPORT PRIORITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C537")]
    public class C537_2 : I_C537
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport service priority code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4219", typeof(EDIFACT_ID_4219_2))]
        [Pos(1)]
        public string Transportserviceprioritycode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Requirement or condition description identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("7295", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Requirementorconditiondescriptionidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Requirement or condition description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Requirementorconditiondescription_04 { get; set; }
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
        /// Bank operation code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4383", typeof(EDIFACT_ID_4383))]
        [Pos(1)]
        public string Bankoperationcode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Allowance or charge identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargeidentifier_01 { get; set; }
        /// <summary>
        /// Allowance or charge identification code
        /// </summary>
        [DataMember]
        [DataElement("5189", typeof(EDIFACT_ID_5189))]
        [Pos(2)]
        public string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    /// <summary>
    /// ALLOWANCE/CHARGE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C552")]
    public class C552_2 : I_C552
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargeidentifier_01 { get; set; }
        /// <summary>
        /// Allowance or charge identification code
        /// </summary>
        [DataMember]
        [DataElement("5189", typeof(EDIFACT_ID_5189_2))]
        [Pos(2)]
        public string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    /// <summary>
    /// ALLOWANCE/CHARGE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C552")]
    public class C552_3 : I_C552
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargeidentifier_01 { get; set; }
        /// <summary>
        /// Allowance or charge identification code
        /// </summary>
        [DataMember]
        [DataElement("5189", typeof(EDIFACT_ID_5189_3))]
        [Pos(2)]
        public string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    /// <summary>
    /// ALLOWANCE/CHARGE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C552")]
    public class C552_4 : I_C552
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargeidentifier_01 { get; set; }
        /// <summary>
        /// Allowance or charge identification code
        /// </summary>
        [DataMember]
        [DataElement("5189", typeof(EDIFACT_ID_5189_4))]
        [Pos(2)]
        public string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    /// <summary>
    /// ALLOWANCE/CHARGE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C552")]
    public class C552_5 : I_C552
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargeidentifier_01 { get; set; }
        /// <summary>
        /// Allowance or charge identification code
        /// </summary>
        [DataMember]
        [DataElement("5189", typeof(EDIFACT_ID_5189_5))]
        [Pos(2)]
        public string Allowanceorchargeidentificationcode_02 { get; set; }
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
        /// Second related location name code
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Secondrelatedlocationnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Second related location name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Secondrelatedlocationname_04 { get; set; }
    }
    
    /// <summary>
    /// STATUS
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
        /// Status description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(1)]
        public string Statusdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Status description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4404", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Statusdescription_04 { get; set; }
    }
    
    /// <summary>
    /// STATUS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C555")]
    public class C555_2 : I_C555
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4405", typeof(EDIFACT_ID_4405_3))]
        [Pos(1)]
        public string Statusdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Status description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4404", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Statusdescription_04 { get; set; }
    }
    
    /// <summary>
    /// STATUS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C555")]
    public class C555_3 : I_C555
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4405", typeof(EDIFACT_ID_4405_2))]
        [Pos(1)]
        public string Statusdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Status description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4404", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Statusdescription_04 { get; set; }
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
        /// Status reason description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(1)]
        public string Statusreasondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Status reason description
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("9012", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Statusreasondescription_04 { get; set; }
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
        /// Physical or logical state description code
        /// </summary>
        [DataMember]
        [DataElement("7007", typeof(EDIFACT_ID_7007))]
        [Pos(1)]
        public string Physicalorlogicalstatedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Physical or logical state description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("7006", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Physicalorlogicalstatedescription_04 { get; set; }
    }
    
    /// <summary>
    /// PHYSICAL OR LOGICAL STATE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C564")]
    public class C564_2 : I_C564
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Physical or logical state description code
        /// </summary>
        [DataMember]
        [DataElement("7007", typeof(EDIFACT_ID_7007_2))]
        [Pos(1)]
        public string Physicalorlogicalstatedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Physical or logical state description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("7006", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Physicalorlogicalstatedescription_04 { get; set; }
    }
    
    /// <summary>
    /// STATUS CATEGORY
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
        /// Status category code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9015", typeof(EDIFACT_ID_9015))]
        [Pos(1)]
        public string Statuscategorycode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// STATUS CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C601")]
    public class C601_2 : I_C601
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Status category code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9015", typeof(EDIFACT_ID_9015_3))]
        [Pos(1)]
        public string Statuscategorycode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// STATUS CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C601")]
    public class C601_3 : I_C601
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Status category code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9015", typeof(EDIFACT_ID_9015_2))]
        [Pos(1)]
        public string Statuscategorycode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Cargo type classification code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7085", typeof(EDIFACT_ID_7085_2))]
        [Pos(1)]
        public string Cargotypeclassificationcode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    /// <summary>
    /// NATURE OF CARGO
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C703")]
    public class C703_2 : I_C703
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Cargo type classification code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7085", typeof(EDIFACT_ID_7085))]
        [Pos(1)]
        public string Cargotypeclassificationcode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Hierarchical structure level identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hierarchicalstructurelevelidentifier_01 { get; set; }
        /// <summary>
        /// Sequence position identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Sequencepositionidentifier_02 { get; set; }
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
        /// Country sub-entity name code
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Countrysubentitynamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Country sub-entity name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrysubentityname_04 { get; set; }
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
        /// Marking type code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Markingtypecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Sub-line indicator code
        /// </summary>
        [DataMember]
        [DataElement("5495", typeof(EDIFACT_ID_5495))]
        [Pos(1)]
        public string Sublineindicatorcode_01 { get; set; }
        /// <summary>
        /// Line item identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Lineitemidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// PROCESS IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C830")]
    public class C830 : I_C830
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Process description code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7191", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Processdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Process description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("7190", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Processdescription_04 { get; set; }
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
        /// Enacting party identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3301", typeof(EDIFACT_ID_3301))]
        [Pos(1)]
        public string Enactingpartyidentifier_01 { get; set; }
        /// <summary>
        /// Instruction receiving party identifier
        /// </summary>
        [DataMember]
        [DataElement("3285", typeof(EDIFACT_ID_3285))]
        [Pos(2)]
        public string Instructionreceivingpartyidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C849")]
    public class C849_2 : I_C849
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Enacting party identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3301", typeof(EDIFACT_ID_3301_2))]
        [Pos(1)]
        public string Enactingpartyidentifier_01 { get; set; }
        /// <summary>
        /// Instruction receiving party identifier
        /// </summary>
        [DataMember]
        [DataElement("3285", typeof(EDIFACT_ID_3285_2))]
        [Pos(2)]
        public string Instructionreceivingpartyidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C849")]
    public class C849_3 : I_C849
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Enacting party identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3301", typeof(EDIFACT_ID_3301_3))]
        [Pos(1)]
        public string Enactingpartyidentifier_01 { get; set; }
        /// <summary>
        /// Instruction receiving party identifier
        /// </summary>
        [DataMember]
        [DataElement("3285", typeof(EDIFACT_ID_3285_3))]
        [Pos(2)]
        public string Instructionreceivingpartyidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C849")]
    public class C849_4 : I_C849
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Enacting party identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3301", typeof(EDIFACT_ID_3301_4))]
        [Pos(1)]
        public string Enactingpartyidentifier_01 { get; set; }
        /// <summary>
        /// Instruction receiving party identifier
        /// </summary>
        [DataMember]
        [DataElement("3285", typeof(EDIFACT_ID_3285_4))]
        [Pos(2)]
        public string Instructionreceivingpartyidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C849")]
    public class C849_5 : I_C849
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Enacting party identifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3301", typeof(EDIFACT_ID_3301_4))]
        [Pos(1)]
        public string Enactingpartyidentifier_01 { get; set; }
        /// <summary>
        /// Instruction receiving party identifier
        /// </summary>
        [DataMember]
        [DataElement("3285", typeof(EDIFACT_ID_3285_5))]
        [Pos(2)]
        public string Instructionreceivingpartyidentifier_02 { get; set; }
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
        /// Status description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(1)]
        public string Statusdescriptioncode_01 { get; set; }
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
        /// Institution branch identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Institutionbranchidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Account holder identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Accountholderidentifier_04 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(5)]
        public string Currencyidentificationcode_05 { get; set; }
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
        /// Characteristic value description code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Characteristicvaluedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Characteristic value description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristicvaluedescription_04 { get; set; }
        /// <summary>
        /// Characteristic value description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Characteristicvaluedescription_05 { get; set; }
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
        /// Application error code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 8)]
        [DataElement("9321", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Applicationerrorcode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
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
        /// Change reason description code
        /// </summary>
        [DataMember]
        [DataElement("4295", typeof(EDIFACT_ID_4295_2))]
        [Pos(1)]
        public string Changereasondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Change reason description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereasondescription_04 { get; set; }
    }
    
    /// <summary>
    /// REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C960")]
    public class C960_2 : I_C960
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Change reason description code
        /// </summary>
        [DataMember]
        [DataElement("4295", typeof(EDIFACT_ID_4295))]
        [Pos(1)]
        public string Changereasondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Change reason description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereasondescription_04 { get; set; }
    }
    
    /// <summary>
    /// REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C960")]
    public class C960_3 : I_C960
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Change reason description code
        /// </summary>
        [DataMember]
        [DataElement("4295", typeof(EDIFACT_ID_4295_3))]
        [Pos(1)]
        public string Changereasondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Change reason description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereasondescription_04 { get; set; }
    }
    
    /// <summary>
    /// REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C960")]
    public class C960_4 : I_C960
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Change reason description code
        /// </summary>
        [DataMember]
        [DataElement("4295", typeof(EDIFACT_ID_4295_5))]
        [Pos(1)]
        public string Changereasondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Change reason description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereasondescription_04 { get; set; }
    }
    
    /// <summary>
    /// REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C960")]
    public class C960_5 : I_C960
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Change reason description code
        /// </summary>
        [DataMember]
        [DataElement("4295", typeof(EDIFACT_ID_4295_6))]
        [Pos(1)]
        public string Changereasondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Change reason description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereasondescription_04 { get; set; }
    }
    
    /// <summary>
    /// REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C960")]
    public class C960_6 : I_C960
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Change reason description code
        /// </summary>
        [DataMember]
        [DataElement("4295", typeof(EDIFACT_ID_4295_7))]
        [Pos(1)]
        public string Changereasondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Change reason description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereasondescription_04 { get; set; }
    }
    
    /// <summary>
    /// REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C960")]
    public class C960_7 : I_C960
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Change reason description code
        /// </summary>
        [DataMember]
        [DataElement("4295", typeof(EDIFACT_ID_4295_4))]
        [Pos(1)]
        public string Changereasondescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Change reason description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereasondescription_04 { get; set; }
    }
}
