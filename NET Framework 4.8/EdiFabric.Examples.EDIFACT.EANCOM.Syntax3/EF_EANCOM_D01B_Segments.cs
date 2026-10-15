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
    /// Adjustment details
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
        /// Adjustment reason description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4465", typeof(EDIFACT_ID_4465))]
        [Pos(1)]
        public string Adjustmentreasondescriptioncode_01 { get; set; }
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
    /// Adjustment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AJT")]
    public class AJT_2 : I_AJT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Adjustment reason description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4465", typeof(EDIFACT_ID_4465_2))]
        [Pos(1)]
        public string Adjustmentreasondescriptioncode_01 { get; set; }
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
    /// Adjustment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AJT")]
    public class AJT_3 : I_AJT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Adjustment reason description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4465", typeof(EDIFACT_ID_4465_3))]
        [Pos(1)]
        public string Adjustmentreasondescriptioncode_01 { get; set; }
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
    /// Adjustment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AJT")]
    public class AJT_4 : I_AJT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Adjustment reason description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4465", typeof(EDIFACT_ID_4465_4))]
        [Pos(1)]
        public string Adjustmentreasondescriptioncode_01 { get; set; }
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
    /// Adjustment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AJT")]
    public class AJT_5 : I_AJT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Adjustment reason description code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4465", typeof(EDIFACT_ID_4465_5))]
        [Pos(1)]
        public string Adjustmentreasondescriptioncode_01 { get; set; }
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
    /// Allowance or charge
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
        /// Allowance or charge code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C214 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// Allowance or charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALC")]
    public class ALC_2 : I_ALC<C552_2, C214_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C552_2 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471_2))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C214_2 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// Allowance or charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALC")]
    public class ALC_3 : I_ALC<C552_3, C214_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C552_3 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471_2))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C214_2 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// Allowance or charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALC")]
    public class ALC_4 : I_ALC<C552, C214_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463_2))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471_3))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C214_3 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// Allowance or charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALC")]
    public class ALC_5 : I_ALC<C552_4, C214_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C552_4 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471_4))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C214_4 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// Allowance or charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALC")]
    public class ALC_6 : I_ALC<C552_5, C214_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C552_5 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471_5))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C214_5 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// Allowance or charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALC")]
    public class ALC_7 : I_ALC<C552_5, C214_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463_2))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C552_5 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471_2))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C214_7 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// Allowance or charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALC")]
    public class ALC_8 : I_ALC<C552_5, C214_8>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or charge code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        /// <summary>
        /// ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C552_5 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataMember]
        [DataElement("4471", typeof(EDIFACT_ID_4471_2))]
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        /// <summary>
        /// SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C214_8 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// <summary>
    /// Additional information
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
        /// Country of origin name code
        /// </summary>
        [DataMember]
        [DataElement("3239", typeof(EDIFACT_ID_3239))]
        [Pos(1)]
        public string Countryoforiginnamecode_01 { get; set; }
        /// <summary>
        /// Duty regime type code
        /// </summary>
        [DataMember]
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string Dutyregimetypecode_02 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditioncode_03 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditioncode_04 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditioncode_05 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditioncode_06 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditioncode_07 { get; set; }
    }
    
    /// <summary>
    /// Additional information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALI")]
    public class ALI_2 : I_ALI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Country of origin name code
        /// </summary>
        [DataMember]
        [DataElement("3239", typeof(EDIFACT_ID_3239))]
        [Pos(1)]
        public string Countryoforiginnamecode_01 { get; set; }
        /// <summary>
        /// Duty regime type code
        /// </summary>
        [DataMember]
        [DataElement("9213", typeof(EDIFACT_ID_9213_2))]
        [Pos(2)]
        public string Dutyregimetypecode_02 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditioncode_03 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditioncode_04 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditioncode_05 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditioncode_06 { get; set; }
        /// <summary>
        /// Special condition code
        /// </summary>
        [DataMember]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditioncode_07 { get; set; }
    }
    
    /// <summary>
    /// Additional price information
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
        /// Trade class code
        /// </summary>
        [DataMember]
        [DataElement("4043", typeof(EDIFACT_ID_4043))]
        [Pos(1)]
        public string Tradeclasscode_01 { get; set; }
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
    /// Additional price information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("APR")]
    public class APR_2 : I_APR<C138, C960_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Trade class code
        /// </summary>
        [DataMember]
        [DataElement("4043", typeof(EDIFACT_ID_4043_2))]
        [Pos(1)]
        public string Tradeclasscode_01 { get; set; }
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
        public virtual C960_2 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// Authentication result
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AUT")]
    public class AUT : I_AUT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Validation result value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("9280", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Validationresultvalue_01 { get; set; }
        /// <summary>
        /// Validation key identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9282", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Validationkeyidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM : I_BGM<C002_18, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_18 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_10 : I_BGM<C002_23, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_23 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_8))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_11 : I_BGM<C002_5, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_5 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_9))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_4))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_12 : I_BGM<C002_24, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_24 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_2))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_13 : I_BGM<C002_25, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_25 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_10))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_14 : I_BGM<C002_26, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_26 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_2))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_2))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_15 : I_BGM<C002_27, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_27 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_11))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_16 : I_BGM<C002_6, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_6 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_12))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_17 : I_BGM<C002_28, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_28 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_13))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_18 : I_BGM<C002_29, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_29 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_10))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_5))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_19 : I_BGM<C002_7, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_7 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_14))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_2 : I_BGM<C002_19, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_19 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_2))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_20 : I_BGM<C002_8, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_8 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_14))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_21 : I_BGM<C002_30, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_30 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_2))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_22 : I_BGM<C002_31, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_31 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_15))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_23 : I_BGM<C002_32, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_32 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_16))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_6))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }

        public static implicit operator BGM_23(BGM v)
        {
            throw new NotImplementedException();
        }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_24 : I_BGM<C002_33, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_33 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_6))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_25 : I_BGM<C002_34, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_34 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_17))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_26 : I_BGM<C002_35, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_35 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_18))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_2))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_27 : I_BGM<C002_36, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_36 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_19))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_3))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_28 : I_BGM<C002_37, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_37 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_20))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_2))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_29 : I_BGM<C002_9, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_9 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_2))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_3 : I_BGM<C002_20, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_20 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_3))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_2))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_30 : I_BGM<C002_10, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_10 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_2))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_31 : I_BGM<C002_11, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_11 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_21))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_32 : I_BGM<C002_12, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_12 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_9))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_33 : I_BGM<C002_38, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_38 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_22))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_7))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_34 : I_BGM<C002_17, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_17 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_23))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_35 : I_BGM<C002_39, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_39 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_24))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_36 : I_BGM<C002_40, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_40 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_25))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_37 : I_BGM<C002_41, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_41 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_26))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_2))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_38 : I_BGM<C002_42, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_42 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_27))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_39 : I_BGM<C002_13, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_13 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_28))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_4 : I_BGM<C002, C106>
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
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_2))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_40 : I_BGM<C002_43, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_43 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_26))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_2))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_41 : I_BGM<C002_14, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_14 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_29))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_42 : I_BGM<C002_15, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_15 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_29))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_43 : I_BGM<C002_44, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_44 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_30))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_44 : I_BGM<C002_45, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_45 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_31))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_45 : I_BGM<C002_16, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_16 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_10))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_5 : I_BGM<C002_2, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_2 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_4))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_6 : I_BGM<C002_21, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_21 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_5))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_7 : I_BGM<C002_3, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_3 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_6))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_8 : I_BGM<C002_4, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_4 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_6))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Beginning of message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM_9 : I_BGM<C002_22, C106>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002_22 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Message function code
        /// </summary>
        [DataMember]
        [DataElement("1225", typeof(EDIFACT_ID_1225_7))]
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        /// <summary>
        /// Response type code
        /// </summary>
        [DataMember]
        [DataElement("4343", typeof(EDIFACT_ID_4343_3))]
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    /// <summary>
    /// Business function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BUS")]
    public class BUS : I_BUS<C521, C551>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// BUSINESS FUNCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C521 BUSINESSFUNCTION_01 { get; set; }
        /// <summary>
        /// Geographic area code
        /// </summary>
        [DataMember]
        [DataElement("3279", typeof(EDIFACT_ID_3279))]
        [Pos(2)]
        public string Geographicareacode_02 { get; set; }
        /// <summary>
        /// Financial transaction type code
        /// </summary>
        [DataMember]
        [DataElement("4487", typeof(EDIFACT_ID_4487))]
        [Pos(3)]
        public string Financialtransactiontypecode_03 { get; set; }
        /// <summary>
        /// BANK OPERATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C551 BANKOPERATION_04 { get; set; }
        /// <summary>
        /// Intra-company payment indicator code
        /// </summary>
        [DataMember]
        [DataElement("4463", typeof(EDIFACT_ID_4463))]
        [Pos(5)]
        public string Intracompanypaymentindicatorcode_05 { get; set; }
    }
    
    /// <summary>
    /// Business function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BUS")]
    public class BUS_2 : I_BUS<C521, C551>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// BUSINESS FUNCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C521 BUSINESSFUNCTION_01 { get; set; }
        /// <summary>
        /// Geographic area code
        /// </summary>
        [DataMember]
        [DataElement("3279", typeof(EDIFACT_ID_3279_2))]
        [Pos(2)]
        public string Geographicareacode_02 { get; set; }
        /// <summary>
        /// Financial transaction type code
        /// </summary>
        [DataMember]
        [DataElement("4487", typeof(EDIFACT_ID_4487))]
        [Pos(3)]
        public string Financialtransactiontypecode_03 { get; set; }
        /// <summary>
        /// BANK OPERATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C551 BANKOPERATION_04 { get; set; }
        /// <summary>
        /// Intra-company payment indicator code
        /// </summary>
        [DataMember]
        [DataElement("4463", typeof(EDIFACT_ID_4463))]
        [Pos(5)]
        public string Intracompanypaymentindicatorcode_05 { get; set; }
    }
    
    /// <summary>
    /// Business function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BUS")]
    public class BUS_3 : I_BUS<C521_2, C551>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// BUSINESS FUNCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C521_2 BUSINESSFUNCTION_01 { get; set; }
        /// <summary>
        /// Geographic area code
        /// </summary>
        [DataMember]
        [DataElement("3279", typeof(EDIFACT_ID_3279))]
        [Pos(2)]
        public string Geographicareacode_02 { get; set; }
        /// <summary>
        /// Financial transaction type code
        /// </summary>
        [DataMember]
        [DataElement("4487", typeof(EDIFACT_ID_4487_2))]
        [Pos(3)]
        public string Financialtransactiontypecode_03 { get; set; }
        /// <summary>
        /// BANK OPERATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C551 BANKOPERATION_04 { get; set; }
        /// <summary>
        /// Intra-company payment indicator code
        /// </summary>
        [DataMember]
        [DataElement("4463", typeof(EDIFACT_ID_4463))]
        [Pos(5)]
        public string Intracompanypaymentindicatorcode_05 { get; set; }
    }
    
    /// <summary>
    /// Characteristic value
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
        [Required]
        [Pos(1)]
        public virtual C889 CHARACTERISTICVALUE_01 { get; set; }
    }
    
    /// <summary>
    /// Characteristic/class id
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
        /// Class type code
        /// </summary>
        [DataMember]
        [DataElement("7059", typeof(EDIFACT_ID_7059))]
        [Pos(1)]
        public string Classtypecode_01 { get; set; }
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
        /// <summary>
        /// Characteristic relevance code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristicrelevancecode_04 { get; set; }
    }
    
    /// <summary>
    /// Characteristic/class id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CCI")]
    public class CCI_2 : I_CCI<C502, C240_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Class type code
        /// </summary>
        [DataMember]
        [DataElement("7059", typeof(EDIFACT_ID_7059_2))]
        [Pos(1)]
        public string Classtypecode_01 { get; set; }
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
        public virtual C240_2 PRODUCTCHARACTERISTIC_03 { get; set; }
        /// <summary>
        /// Characteristic relevance code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristicrelevancecode_04 { get; set; }
    }
    
    /// <summary>
    /// Characteristic/class id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CCI")]
    public class CCI_3 : I_CCI<C502, C240_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Class type code
        /// </summary>
        [DataMember]
        [DataElement("7059", typeof(EDIFACT_ID_7059_3))]
        [Pos(1)]
        public string Classtypecode_01 { get; set; }
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
        public virtual C240_2 PRODUCTCHARACTERISTIC_03 { get; set; }
        /// <summary>
        /// Characteristic relevance code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristicrelevancecode_04 { get; set; }
    }
    
    /// <summary>
    /// Characteristic/class id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CCI")]
    public class CCI_4 : I_CCI<C502, C240_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Class type code
        /// </summary>
        [DataMember]
        [DataElement("7059", typeof(EDIFACT_ID_7059_4))]
        [Pos(1)]
        public string Classtypecode_01 { get; set; }
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
        public virtual C240_2 PRODUCTCHARACTERISTIC_03 { get; set; }
        /// <summary>
        /// Characteristic relevance code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristicrelevancecode_04 { get; set; }
    }
    
    /// <summary>
    /// Physical or logical state
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CDI")]
    public class CDI : I_CDI<C564>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Physical or logical state type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7001", typeof(EDIFACT_ID_7001))]
        [Pos(1)]
        public string Physicalorlogicalstatetypecodequalifier_01 { get; set; }
        /// <summary>
        /// PHYSICAL OR LOGICAL STATE INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C564 PHYSICALORLOGICALSTATEINFORMATION_02 { get; set; }
    }
    
    /// <summary>
    /// Physical or logical state
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CDI")]
    public class CDI_2 : I_CDI<C564_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Physical or logical state type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7001", typeof(EDIFACT_ID_7001_2))]
        [Pos(1)]
        public string Physicalorlogicalstatetypecodequalifier_01 { get; set; }
        /// <summary>
        /// PHYSICAL OR LOGICAL STATE INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C564_2 PHYSICALORLOGICALSTATEINFORMATION_02 { get; set; }
    }
    
    /// <summary>
    /// Computer environment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CED")]
    public class CED : I_CED<C079>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Computer environment details code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1501", typeof(EDIFACT_ID_1501))]
        [Pos(1)]
        public string Computerenvironmentdetailscodequalifier_01 { get; set; }
        /// <summary>
        /// COMPUTER ENVIRONMENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C079 COMPUTERENVIRONMENTIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// File generation command name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9448", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Filegenerationcommandname_03 { get; set; }
    }
    
    /// <summary>
    /// Consignment information
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
        [StringLength(1, 4)]
        [DataElement("1490", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Consolidationitemnumber_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Consignment load sequence identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("1312", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Consignmentloadsequenceidentifier_03 { get; set; }
    }
    
    /// <summary>
    /// Control total
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
        [Required]
        [Pos(1)]
        public virtual C270 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT_10 : I_CNT<C270_10>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270_10 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT_11 : I_CNT<C270_11>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270_11 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT_12 : I_CNT<C270_12>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270_12 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT_2 : I_CNT<C270_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270_2 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT_3 : I_CNT<C270_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270_3 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT_4 : I_CNT<C270_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270_4 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT_5 : I_CNT<C270_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270_5 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT_6 : I_CNT<C270_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270_6 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT_7 : I_CNT<C270_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270_7 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT_8 : I_CNT<C270_8>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270_8 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Control total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT_9 : I_CNT<C270_9>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270_9 CONTROL_01 { get; set; }
    }
    
    /// <summary>
    /// Communication contact
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
        [Required]
        [Pos(1)]
        public virtual C076 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    /// <summary>
    /// Communication contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COM")]
    public class COM_2 : I_COM<C076_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C076_2 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    /// <summary>
    /// Communication contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COM")]
    public class COM_3 : I_COM<C076_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C076_3 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    /// <summary>
    /// Communication contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COM")]
    public class COM_4 : I_COM<C076_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C076_4 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    /// <summary>
    /// Consignment packing sequence
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
        /// Hierarchical structure level identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hierarchicalstructurelevelidentifier_01 { get; set; }
        /// <summary>
        /// Hierarchical structure parent identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7166", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Hierarchicalstructureparentidentifier_02 { get; set; }
        /// <summary>
        /// Packaging level code
        /// </summary>
        [DataMember]
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(3)]
        public string Packaginglevelcode_03 { get; set; }
    }
    
    /// <summary>
    /// Contact information
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
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_10 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_10))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_11 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_11))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_12 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_12))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_13 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_13))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_14 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_14))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_15 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_15))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_16 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_16))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_17 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_17))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_18 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_18))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_2 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_2))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_3 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_3))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_4 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_4))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_5 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_5))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_6 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_6))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_7 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_7))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_8 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_9))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Contact information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA_9 : I_CTA<C056>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact function code
        /// </summary>
        [DataMember]
        [DataElement("3139", typeof(EDIFACT_ID_3139_8))]
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        /// <summary>
        /// DEPARTMENT OR EMPLOYEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Currencies
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
        /// Currency exchange rate
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Currencyexchangerate_03 { get; set; }
        /// <summary>
        /// Exchange rate currency market identifier
        /// </summary>
        [DataMember]
        [DataElement("6341", typeof(EDIFACT_ID_6341))]
        [Pos(4)]
        public string Exchangeratecurrencymarketidentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Currencies
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUX")]
    public class CUX_2 : I_CUX<C504_2, C504_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C504_2 CURRENCYDETAILS_01 { get; set; }
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C504_2 CURRENCYDETAILS_02 { get; set; }
        /// <summary>
        /// Currency exchange rate
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Currencyexchangerate_03 { get; set; }
        /// <summary>
        /// Exchange rate currency market identifier
        /// </summary>
        [DataMember]
        [DataElement("6341", typeof(EDIFACT_ID_6341))]
        [Pos(4)]
        public string Exchangeratecurrencymarketidentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Currencies
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUX")]
    public class CUX_3 : I_CUX<C504_3, C504_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C504_3 CURRENCYDETAILS_01 { get; set; }
        /// <summary>
        /// CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C504_3 CURRENCYDETAILS_02 { get; set; }
        /// <summary>
        /// Currency exchange rate
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Currencyexchangerate_03 { get; set; }
        /// <summary>
        /// Exchange rate currency market identifier
        /// </summary>
        [DataMember]
        [DataElement("6341", typeof(EDIFACT_ID_6341))]
        [Pos(4)]
        public string Exchangeratecurrencymarketidentifier_04 { get; set; }
    }
    
    /// <summary>
    /// Dangerous goods
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
        /// Dangerous goods regulations code
        /// </summary>
        [DataMember]
        [DataElement("8273", typeof(EDIFACT_ID_8273))]
        [Pos(1)]
        public string Dangerousgoodsregulationscode_01 { get; set; }
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
        /// Packaging danger level code
        /// </summary>
        [DataMember]
        [DataElement("8339", typeof(EDIFACT_ID_8339))]
        [Pos(5)]
        public string Packagingdangerlevelcode_05 { get; set; }
        /// <summary>
        /// Emergency procedure for ships identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("8364", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Emergencyprocedureforshipsidentifier_06 { get; set; }
        /// <summary>
        /// Hazard medical first aid guide identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8410", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Hazardmedicalfirstaidguideidentifier_07 { get; set; }
        /// <summary>
        /// Transport emergency card identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("8126", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Transportemergencycardidentifier_08 { get; set; }
        /// <summary>
        /// HAZARD IDENTIFICATION PLACARD DETAILS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C235 HAZARDIDENTIFICATIONPLACARDDETAILS_09 { get; set; }
        /// <summary>
        /// DANGEROUS GOODS LABEL
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C236 DANGEROUSGOODSLABEL_10 { get; set; }
        /// <summary>
        /// Packing instruction type code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8255", typeof(EDIFACT_AN))]
        [Pos(11)]
        public string Packinginstructiontypecode_11 { get; set; }
        /// <summary>
        /// Hazardous means of transport category code
        /// </summary>
        [DataMember]
        [DataElement("8325", typeof(EDIFACT_ID_8325))]
        [Pos(12)]
        public string Hazardousmeansoftransportcategorycode_12 { get; set; }
        /// <summary>
        /// Hazardous cargo transport authorisation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8211", typeof(EDIFACT_AN))]
        [Pos(13)]
        public string Hazardouscargotransportauthorisationcode_13 { get; set; }
    }
    
    /// <summary>
    /// Dangerous goods
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DGS")]
    public class DGS_2 : I_DGS<C205, C234, C223, C235, C236>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dangerous goods regulations code
        /// </summary>
        [DataMember]
        [DataElement("8273", typeof(EDIFACT_ID_8273_2))]
        [Pos(1)]
        public string Dangerousgoodsregulationscode_01 { get; set; }
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
        /// Packaging danger level code
        /// </summary>
        [DataMember]
        [DataElement("8339", typeof(EDIFACT_ID_8339))]
        [Pos(5)]
        public string Packagingdangerlevelcode_05 { get; set; }
        /// <summary>
        /// Emergency procedure for ships identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("8364", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Emergencyprocedureforshipsidentifier_06 { get; set; }
        /// <summary>
        /// Hazard medical first aid guide identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8410", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Hazardmedicalfirstaidguideidentifier_07 { get; set; }
        /// <summary>
        /// Transport emergency card identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("8126", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Transportemergencycardidentifier_08 { get; set; }
        /// <summary>
        /// HAZARD IDENTIFICATION PLACARD DETAILS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C235 HAZARDIDENTIFICATIONPLACARDDETAILS_09 { get; set; }
        /// <summary>
        /// DANGEROUS GOODS LABEL
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C236 DANGEROUSGOODSLABEL_10 { get; set; }
        /// <summary>
        /// Packing instruction type code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8255", typeof(EDIFACT_AN))]
        [Pos(11)]
        public string Packinginstructiontypecode_11 { get; set; }
        /// <summary>
        /// Hazardous means of transport category code
        /// </summary>
        [DataMember]
        [DataElement("8325", typeof(EDIFACT_ID_8325))]
        [Pos(12)]
        public string Hazardousmeansoftransportcategorycode_12 { get; set; }
        /// <summary>
        /// Hazardous cargo transport authorisation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8211", typeof(EDIFACT_AN))]
        [Pos(13)]
        public string Hazardouscargotransportauthorisationcode_13 { get; set; }
    }
    
    /// <summary>
    /// Dangerous goods
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DGS")]
    public class DGS_3 : I_DGS<C205, C234, C223_2, C235, C236>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dangerous goods regulations code
        /// </summary>
        [DataMember]
        [DataElement("8273", typeof(EDIFACT_ID_8273))]
        [Pos(1)]
        public string Dangerousgoodsregulationscode_01 { get; set; }
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
        public virtual C223_2 DANGEROUSGOODSSHIPMENTFLASHPOINT_04 { get; set; }
        /// <summary>
        /// Packaging danger level code
        /// </summary>
        [DataMember]
        [DataElement("8339", typeof(EDIFACT_ID_8339))]
        [Pos(5)]
        public string Packagingdangerlevelcode_05 { get; set; }
        /// <summary>
        /// Emergency procedure for ships identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("8364", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Emergencyprocedureforshipsidentifier_06 { get; set; }
        /// <summary>
        /// Hazard medical first aid guide identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8410", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Hazardmedicalfirstaidguideidentifier_07 { get; set; }
        /// <summary>
        /// Transport emergency card identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("8126", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Transportemergencycardidentifier_08 { get; set; }
        /// <summary>
        /// HAZARD IDENTIFICATION PLACARD DETAILS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C235 HAZARDIDENTIFICATIONPLACARDDETAILS_09 { get; set; }
        /// <summary>
        /// DANGEROUS GOODS LABEL
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C236 DANGEROUSGOODSLABEL_10 { get; set; }
        /// <summary>
        /// Packing instruction type code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8255", typeof(EDIFACT_AN))]
        [Pos(11)]
        public string Packinginstructiontypecode_11 { get; set; }
        /// <summary>
        /// Hazardous means of transport category code
        /// </summary>
        [DataMember]
        [DataElement("8325", typeof(EDIFACT_ID_8325))]
        [Pos(12)]
        public string Hazardousmeansoftransportcategorycode_12 { get; set; }
        /// <summary>
        /// Hazardous cargo transport authorisation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8211", typeof(EDIFACT_AN))]
        [Pos(13)]
        public string Hazardouscargotransportauthorisationcode_13 { get; set; }
    }
    
    /// <summary>
    /// Dimensions
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
        /// Dimension type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6145", typeof(EDIFACT_ID_6145_2))]
        [Pos(1)]
        public string Dimensiontypecodequalifier_01 { get; set; }
        /// <summary>
        /// DIMENSIONS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C211 DIMENSIONS_02 { get; set; }
    }
    
    /// <summary>
    /// Dimensions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DIM")]
    public class DIM_2 : I_DIM<C211>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dimension type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6145", typeof(EDIFACT_ID_6145))]
        [Pos(1)]
        public string Dimensiontypecodequalifier_01 { get; set; }
        /// <summary>
        /// DIMENSIONS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C211 DIMENSIONS_02 { get; set; }
    }
    
    /// <summary>
    /// Dimensions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DIM")]
    public class DIM_3 : I_DIM<C211_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Dimension type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6145", typeof(EDIFACT_ID_6145))]
        [Pos(1)]
        public string Dimensiontypecodequalifier_01 { get; set; }
        /// <summary>
        /// DIMENSIONS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C211_2 DIMENSIONS_02 { get; set; }
    }
    
    /// <summary>
    /// Document line identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DLI")]
    public class DLI : I_DLI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document line action code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1073", typeof(EDIFACT_ID_1073))]
        [Pos(1)]
        public string Documentlineactioncode_01 { get; set; }
        /// <summary>
        /// Line item identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Lineitemidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// Document line identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DLI")]
    public class DLI_2 : I_DLI
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Document line action code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1073", typeof(EDIFACT_ID_1073_2))]
        [Pos(1)]
        public string Documentlineactioncode_01 { get; set; }
        /// <summary>
        /// Line item identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Lineitemidentifier_02 { get; set; }
    }
    
    /// <summary>
    /// Delivery limitations
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DLM")]
    public class DLM : I_DLM<C522, C214_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Back order arrangement type code
        /// </summary>
        [DataMember]
        [DataElement("4455", typeof(EDIFACT_ID_4455))]
        [Pos(1)]
        public string Backorderarrangementtypecode_01 { get; set; }
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
        public virtual C214_6 SPECIALSERVICESIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Substitution condition code
        /// </summary>
        [DataMember]
        [DataElement("4457", typeof(EDIFACT_ID_4457))]
        [Pos(4)]
        public string Substitutionconditioncode_04 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC : I_DOC<C002_6, C503>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_6 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_10 : I_DOC<C002_7, C503>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_7 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_11 : I_DOC<C002_9, C503>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_9 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_12 : I_DOC<C002_10, C503>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_10 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_13 : I_DOC<C002_11, C503_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_11 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503_6 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153_2))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_14 : I_DOC<C002_12, C503_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_12 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503_4 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_15 : I_DOC<C002_13, C503_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_13 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503_7 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_16 : I_DOC<C002_16, C503>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_16 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_17 : I_DOC<C002_17, C503>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_17 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_2 : I_DOC<C002_8, C503>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_8 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_3 : I_DOC<C002_14, C503>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_14 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_4 : I_DOC<C002_15, C503_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_15 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503_2 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_5 : I_DOC<C002, C503>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_6 : I_DOC<C002_2, C503_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_2 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503_3 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_7 : I_DOC<C002_3, C503_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_3 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503_4 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_8 : I_DOC<C002_4, C503_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_4 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503_4 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Document/message details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC_9 : I_DOC<C002_5, C503_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002_5 DOCUMENTMESSAGENAME_01 { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503_5 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        /// <summary>
        /// Communication medium type code
        /// </summary>
        [DataMember]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        /// <summary>
        /// Document copies required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        /// <summary>
        /// Document originals required quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
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
        [Required]
        [Pos(1)]
        public virtual C507 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_10 : I_DTM<C507_10>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_10 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_11 : I_DTM<C507_11>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_11 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_12 : I_DTM<C507_12>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_12 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_13 : I_DTM<C507_13>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_13 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_14 : I_DTM<C507_14>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_14 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_15 : I_DTM<C507_15>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_15 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_16 : I_DTM<C507_16>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_16 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_17 : I_DTM<C507_17>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_17 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_18 : I_DTM<C507_18>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_18 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_19 : I_DTM<C507_19>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_19 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_2 : I_DTM<C507_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_2 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_20 : I_DTM<C507_20>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_20 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_21 : I_DTM<C507_21>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_21 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_22 : I_DTM<C507_22>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_22 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_23 : I_DTM<C507_23>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_23 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_24 : I_DTM<C507_24>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_24 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_25 : I_DTM<C507_25>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_25 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_26 : I_DTM<C507_26>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_26 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_27 : I_DTM<C507_27>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_27 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_28 : I_DTM<C507_28>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_28 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_29 : I_DTM<C507_29>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_29 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_3 : I_DTM<C507_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_3 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_30 : I_DTM<C507_30>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_30 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_31 : I_DTM<C507_31>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_31 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_32 : I_DTM<C507_32>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_32 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_33 : I_DTM<C507_33>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_33 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_34 : I_DTM<C507_34>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_34 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_35 : I_DTM<C507_35>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_35 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_36 : I_DTM<C507_36>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_36 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_37 : I_DTM<C507_37>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_37 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_38 : I_DTM<C507_38>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_38 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_39 : I_DTM<C507_39>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_39 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_4 : I_DTM<C507_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_4 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_40 : I_DTM<C507_40>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_40 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_41 : I_DTM<C507_41>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_41 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_42 : I_DTM<C507_42>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_42 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_43 : I_DTM<C507_43>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_43 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_44 : I_DTM<C507_44>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_44 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_5 : I_DTM<C507_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_5 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_6 : I_DTM<C507_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_6 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_7 : I_DTM<C507_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_7 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_8 : I_DTM<C507_8>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_8 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM_9 : I_DTM<C507_9>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507_9 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// <summary>
    /// External file link identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EFI")]
    public class EFI : I_EFI<C077, C099>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// FILE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C077 FILEIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// FILE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C099 FILEDETAILS_02 { get; set; }
        /// <summary>
        /// Sequence position identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("1050", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Sequencepositionidentifier_03 { get; set; }
        /// <summary>
        /// File compression technique name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9450", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Filecompressiontechniquename_04 { get; set; }
    }
    
    /// <summary>
    /// Equipment details
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
        /// Equipment type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8053", typeof(EDIFACT_ID_8053))]
        [Pos(1)]
        public string Equipmenttypecodequalifier_01 { get; set; }
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
        /// Equipment supplier code
        /// </summary>
        [DataMember]
        [DataElement("8077", typeof(EDIFACT_ID_8077))]
        [Pos(4)]
        public string Equipmentsuppliercode_04 { get; set; }
        /// <summary>
        /// Equipment status code
        /// </summary>
        [DataMember]
        [DataElement("8249", typeof(EDIFACT_ID_8249))]
        [Pos(5)]
        public string Equipmentstatuscode_05 { get; set; }
        /// <summary>
        /// Full or empty indicator code
        /// </summary>
        [DataMember]
        [DataElement("8169", typeof(EDIFACT_ID_8169))]
        [Pos(6)]
        public string Fulloremptyindicatorcode_06 { get; set; }
    }
    
    /// <summary>
    /// Equipment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQD")]
    public class EQD_2 : I_EQD<C237, C224_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8053", typeof(EDIFACT_ID_8053))]
        [Pos(1)]
        public string Equipmenttypecodequalifier_01 { get; set; }
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
        public virtual C224_2 EQUIPMENTSIZEANDTYPE_03 { get; set; }
        /// <summary>
        /// Equipment supplier code
        /// </summary>
        [DataMember]
        [DataElement("8077", typeof(EDIFACT_ID_8077))]
        [Pos(4)]
        public string Equipmentsuppliercode_04 { get; set; }
        /// <summary>
        /// Equipment status code
        /// </summary>
        [DataMember]
        [DataElement("8249", typeof(EDIFACT_ID_8249))]
        [Pos(5)]
        public string Equipmentstatuscode_05 { get; set; }
        /// <summary>
        /// Full or empty indicator code
        /// </summary>
        [DataMember]
        [DataElement("8169", typeof(EDIFACT_ID_8169_2))]
        [Pos(6)]
        public string Fulloremptyindicatorcode_06 { get; set; }
    }
    
    /// <summary>
    /// Equipment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQD")]
    public class EQD_3 : I_EQD<C237, C224_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8053", typeof(EDIFACT_ID_8053_2))]
        [Pos(1)]
        public string Equipmenttypecodequalifier_01 { get; set; }
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
        public virtual C224_2 EQUIPMENTSIZEANDTYPE_03 { get; set; }
        /// <summary>
        /// Equipment supplier code
        /// </summary>
        [DataMember]
        [DataElement("8077", typeof(EDIFACT_ID_8077))]
        [Pos(4)]
        public string Equipmentsuppliercode_04 { get; set; }
        /// <summary>
        /// Equipment status code
        /// </summary>
        [DataMember]
        [DataElement("8249", typeof(EDIFACT_ID_8249))]
        [Pos(5)]
        public string Equipmentstatuscode_05 { get; set; }
        /// <summary>
        /// Full or empty indicator code
        /// </summary>
        [DataMember]
        [DataElement("8169", typeof(EDIFACT_ID_8169_2))]
        [Pos(6)]
        public string Fulloremptyindicatorcode_06 { get; set; }
    }
    
    /// <summary>
    /// Equipment details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQD")]
    public class EQD_4 : I_EQD<C237, C224_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8053", typeof(EDIFACT_ID_8053_3))]
        [Pos(1)]
        public string Equipmenttypecodequalifier_01 { get; set; }
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
        public virtual C224_2 EQUIPMENTSIZEANDTYPE_03 { get; set; }
        /// <summary>
        /// Equipment supplier code
        /// </summary>
        [DataMember]
        [DataElement("8077", typeof(EDIFACT_ID_8077))]
        [Pos(4)]
        public string Equipmentsuppliercode_04 { get; set; }
        /// <summary>
        /// Equipment status code
        /// </summary>
        [DataMember]
        [DataElement("8249", typeof(EDIFACT_ID_8249))]
        [Pos(5)]
        public string Equipmentstatuscode_05 { get; set; }
        /// <summary>
        /// Full or empty indicator code
        /// </summary>
        [DataMember]
        [DataElement("8169", typeof(EDIFACT_ID_8169_2))]
        [Pos(6)]
        public string Fulloremptyindicatorcode_06 { get; set; }
    }
    
    /// <summary>
    /// Number of units
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
        [Required]
        [Pos(1)]
        public virtual C523 NUMBEROFUNITDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Application error information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ERC")]
    public class ERC : I_ERC<C901>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// APPLICATION ERROR DETAIL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C901 APPLICATIONERRORDETAIL_01 { get; set; }
    }
    
    /// <summary>
    /// Financial charges allocation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FCA")]
    public class FCA : I_FCA<C878>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4471", typeof(EDIFACT_ID_4471_2))]
        [Pos(1)]
        public string Settlementmeanscode_01 { get; set; }
        /// <summary>
        /// CHARGE/ALLOWANCE ACCOUNT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C878 CHARGEALLOWANCEACCOUNT_02 { get; set; }
    }
    
    /// <summary>
    /// Financial charges allocation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FCA")]
    public class FCA_2 : I_FCA<C878>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Settlement means code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4471", typeof(EDIFACT_ID_4471_6))]
        [Pos(1)]
        public string Settlementmeanscode_01 { get; set; }
        /// <summary>
        /// CHARGE/ALLOWANCE ACCOUNT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C878 CHARGEALLOWANCEACCOUNT_02 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
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
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_10 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_10))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_11 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_11))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_12 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_12))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_13 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_13))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_2 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_3))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_3 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_4))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_4 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_5))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_5 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_9))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_6 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_6))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_7 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_8))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_8 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_7))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Financial institution information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII_9 : I_FII<C078, C088>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_2))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Free text
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
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_22))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_10 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_4))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_3))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_11 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_6))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_12 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_13))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_13 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_14))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_14 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_15))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_3))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_15 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_16))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_3))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_16 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_15))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_17 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_19))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_18 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_20))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_3))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_19 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_21))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_2 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_7))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_3))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_20 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_17))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_21 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_18))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_22 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_23 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_12))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_24 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_29))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_25 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_27))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_26 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_25))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_27 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_23))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_28 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_26))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_29 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_24))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_3 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_8))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_30 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_28))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_4 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_9))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_4))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_5 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_10))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_3))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_6 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_3))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_7 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_5))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_8 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_11))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_3))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX_9 : I_FTX<C107, C108>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Text subject code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451_2))]
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Free text function code
        /// </summary>
        [DataMember]
        [DataElement("4453", typeof(EDIFACT_ID_4453_2))]
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
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
        /// Language name code
        /// </summary>
        [DataMember]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        /// <summary>
        /// Free text format code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4447", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    /// <summary>
    /// Nature of cargo
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GDS")]
    public class GDS : I_GDS<C703_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// NATURE OF CARGO
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C703_2 NATUREOFCARGO_01 { get; set; }
    }
    
    /// <summary>
    /// Nature of cargo
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GDS")]
    public class GDS_2 : I_GDS<C703>
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
    /// Goods item details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GID")]
    public class GID : I_GID<C213, C213, C213, C213, C213>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Goods item number
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("1496", typeof(EDIFACT_N))]
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
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C213 NUMBERANDTYPEOFPACKAGES_05 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C213 NUMBERANDTYPEOFPACKAGES_06 { get; set; }
    }
    
    /// <summary>
    /// Goods item details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GID")]
    public class GID_2 : I_GID<C213_2, C213_2, C213_2, C213_2, C213_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Goods item number
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("1496", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Goodsitemnumber_01 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C213_2 NUMBERANDTYPEOFPACKAGES_02 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C213_2 NUMBERANDTYPEOFPACKAGES_03 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C213_2 NUMBERANDTYPEOFPACKAGES_04 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C213_2 NUMBERANDTYPEOFPACKAGES_05 { get; set; }
        /// <summary>
        /// NUMBER AND TYPE OF PACKAGES
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C213_2 NUMBERANDTYPEOFPACKAGES_06 { get; set; }
    }
    
    /// <summary>
    /// Goods identity number
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
        /// Object identification code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405_2))]
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Required]
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
    /// Goods identity number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIN")]
    public class GIN_2 : I_GIN<C208, C208, C208, C208, C208>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Object identification code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405_3))]
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Required]
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
    /// Goods identity number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIN")]
    public class GIN_3 : I_GIN<C208, C208, C208, C208, C208>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Object identification code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Required]
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
    /// Goods identity number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIN")]
    public class GIN_4 : I_GIN<C208, C208, C208, C208, C208>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Object identification code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405_4))]
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Required]
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
    /// Goods identity number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIN")]
    public class GIN_5 : I_GIN<C208, C208, C208, C208, C208>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Object identification code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405_5))]
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Required]
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
    /// Goods identity number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIN")]
    public class GIN_6 : I_GIN<C208, C208, C208, C208, C208>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Object identification code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405_6))]
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Required]
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
    /// Goods identity number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIN")]
    public class GIN_7 : I_GIN<C208, C208, C208, C208, C208>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Object identification code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405_7))]
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Required]
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
    /// General indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIS")]
    public class GIS : I_GIS<C529>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PROCESSING INDICATOR
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C529 PROCESSINGINDICATOR_01 { get; set; }
    }
    
    /// <summary>
    /// General indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIS")]
    public class GIS_2 : I_GIS<C529_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PROCESSING INDICATOR
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C529_2 PROCESSINGINDICATOR_01 { get; set; }
    }
    
    /// <summary>
    /// General indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GIS")]
    public class GIS_3 : I_GIS<C529_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PROCESSING INDICATOR
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C529_3 PROCESSINGINDICATOR_01 { get; set; }
    }
    
    /// <summary>
    /// Governmental requirements
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
        /// Transport movement code
        /// </summary>
        [DataMember]
        [DataElement("8323", typeof(EDIFACT_ID_8323))]
        [Pos(1)]
        public string Transportmovementcode_01 { get; set; }
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
    /// Handling instructions
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
    /// Handling instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HAN")]
    public class HAN_2 : I_HAN<C524_2, C218>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C524_2 HANDLINGINSTRUCTIONS_01 { get; set; }
        /// <summary>
        /// HAZARDOUS MATERIAL
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C218 HAZARDOUSMATERIAL_02 { get; set; }
    }
    
    /// <summary>
    /// Handling instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HAN")]
    public class HAN_3 : I_HAN<C524_3, C218>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C524_3 HANDLINGINSTRUCTIONS_01 { get; set; }
        /// <summary>
        /// HAZARDOUS MATERIAL
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C218 HAZARDOUSMATERIAL_02 { get; set; }
    }
    
    /// <summary>
    /// Handling instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HAN")]
    public class HAN_4 : I_HAN<C524_4, C218>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C524_4 HANDLINGINSTRUCTIONS_01 { get; set; }
        /// <summary>
        /// HAZARDOUS MATERIAL
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C218 HAZARDOUSMATERIAL_02 { get; set; }
    }
    
    /// <summary>
    /// Handling instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HAN")]
    public class HAN_5 : I_HAN<C524_5, C218>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C524_5 HANDLINGINSTRUCTIONS_01 { get; set; }
        /// <summary>
        /// HAZARDOUS MATERIAL
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C218 HAZARDOUSMATERIAL_02 { get; set; }
    }
    
    /// <summary>
    /// Handling instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HAN")]
    public class HAN_6 : I_HAN<C524_6, C218>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C524_6 HANDLINGINSTRUCTIONS_01 { get; set; }
        /// <summary>
        /// HAZARDOUS MATERIAL
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C218 HAZARDOUSMATERIAL_02 { get; set; }
    }
    
    /// <summary>
    /// Hierarchy information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HYN")]
    public class HYN : I_HYN<C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hierarchy object code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7173", typeof(EDIFACT_ID_7173_2))]
        [Pos(1)]
        public string Hierarchyobjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Hierarchical structure relationship code
        /// </summary>
        [DataMember]
        [DataElement("7171", typeof(EDIFACT_ID_7171))]
        [Pos(2)]
        public string Hierarchicalstructurerelationshipcode_02 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string Actionrequestnotificationdescriptioncode_03 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C212 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// Hierarchical structure parent identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7166", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Hierarchicalstructureparentidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// Hierarchy information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HYN")]
    public class HYN_2 : I_HYN<C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hierarchy object code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7173", typeof(EDIFACT_ID_7173))]
        [Pos(1)]
        public string Hierarchyobjectcodequalifier_01 { get; set; }
        /// <summary>
        /// Hierarchical structure relationship code
        /// </summary>
        [DataMember]
        [DataElement("7171", typeof(EDIFACT_ID_7171))]
        [Pos(2)]
        public string Hierarchicalstructurerelationshipcode_02 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string Actionrequestnotificationdescriptioncode_03 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C212 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        /// <summary>
        /// Hierarchical structure parent identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7166", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Hierarchicalstructureparentidentifier_05 { get; set; }
    }
    
    /// <summary>
    /// Identity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IDE")]
    public class IDE : I_IDE<C206, C082, C778, C240_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Object type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7495", typeof(EDIFACT_ID_7495))]
        [Pos(1)]
        public string Objecttypecodequalifier_01 { get; set; }
        /// <summary>
        /// IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C206 IDENTIFICATIONNUMBER_02 { get; set; }
        /// <summary>
        /// PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C082 PARTYIDENTIFICATIONDETAILS_03 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(4)]
        public string Statusdescriptioncode_04 { get; set; }
        /// <summary>
        /// Configuration level number
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevelnumber_05 { get; set; }
        /// <summary>
        /// POSITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C778 POSITIONIDENTIFICATION_06 { get; set; }
        /// <summary>
        /// PRODUCT CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C240_2 PRODUCTCHARACTERISTIC_07 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD : I_IMD<C272, C273>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_10 : I_IMD<C272_6, C273_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_6 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_3 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_11 : I_IMD<C272_2, C273_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077_3))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_2 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_6 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_12 : I_IMD<C272_7, C273_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_7 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_7 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_13 : I_IMD<C272_2, C273_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077_2))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_2 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_6 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_14 : I_IMD<C272_2, C273_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077_3))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_2 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_3 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_15 : I_IMD<C272_2, C273_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077_4))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_2 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_3 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_2 : I_IMD<C272_2, C273_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_2 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_2 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_3 : I_IMD<C272_2, C273_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_2 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_3 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_4 : I_IMD<C272_2, C273_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_2 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_4 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_5 : I_IMD<C272_2, C273_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077_2))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_2 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_3 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_6 : I_IMD<C272_3, C273_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_3 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_3 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_7 : I_IMD<C272_2, C273_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077_3))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_2 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_5 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_8 : I_IMD<C272_4, C273_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_4 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_3 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Item description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD_9 : I_IMD<C272_5, C273_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description format code
        /// </summary>
        [DataMember]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        /// <summary>
        /// ITEM CHARACTERISTIC
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C272_5 ITEMCHARACTERISTIC_02 { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273_3 ITEMDESCRIPTION_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Parties and instruction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INP")]
    public class INP : I_INP<C849, C522_2, C850>
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
        public virtual C522_2 INSTRUCTION_02 { get; set; }
        /// <summary>
        /// STATUS OF INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C850 STATUSOFINSTRUCTION_03 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(4)]
        public string Actionrequestnotificationdescriptioncode_04 { get; set; }
    }
    
    /// <summary>
    /// Parties and instruction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INP")]
    public class INP_2 : I_INP<C849_2, C522_3, C850>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PARTIES TO INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C849_2 PARTIESTOINSTRUCTION_01 { get; set; }
        /// <summary>
        /// INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C522_3 INSTRUCTION_02 { get; set; }
        /// <summary>
        /// STATUS OF INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C850 STATUSOFINSTRUCTION_03 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(4)]
        public string Actionrequestnotificationdescriptioncode_04 { get; set; }
    }
    
    /// <summary>
    /// Parties and instruction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INP")]
    public class INP_3 : I_INP<C849_3, C522_4, C850>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PARTIES TO INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C849_3 PARTIESTOINSTRUCTION_01 { get; set; }
        /// <summary>
        /// INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C522_4 INSTRUCTION_02 { get; set; }
        /// <summary>
        /// STATUS OF INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C850 STATUSOFINSTRUCTION_03 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(4)]
        public string Actionrequestnotificationdescriptioncode_04 { get; set; }
    }
    
    /// <summary>
    /// Parties and instruction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INP")]
    public class INP_4 : I_INP<C849_4, C522_3, C850>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PARTIES TO INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C849_4 PARTIESTOINSTRUCTION_01 { get; set; }
        /// <summary>
        /// INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C522_3 INSTRUCTION_02 { get; set; }
        /// <summary>
        /// STATUS OF INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C850 STATUSOFINSTRUCTION_03 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(4)]
        public string Actionrequestnotificationdescriptioncode_04 { get; set; }
    }
    
    /// <summary>
    /// Parties and instruction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INP")]
    public class INP_5 : I_INP<C849_5, C522_3, C850>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PARTIES TO INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C849_5 PARTIESTOINSTRUCTION_01 { get; set; }
        /// <summary>
        /// INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C522_3 INSTRUCTION_02 { get; set; }
        /// <summary>
        /// STATUS OF INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C850 STATUSOFINSTRUCTION_03 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(4)]
        public string Actionrequestnotificationdescriptioncode_04 { get; set; }
    }
    
    /// <summary>
    /// Inventory management related details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("INV")]
    public class INV : I_INV<C522>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Inventory movement direction code
        /// </summary>
        [DataMember]
        [DataElement("4501", typeof(EDIFACT_ID_4501))]
        [Pos(1)]
        public string Inventorymovementdirectioncode_01 { get; set; }
        /// <summary>
        /// Inventory type code
        /// </summary>
        [DataMember]
        [DataElement("7491", typeof(EDIFACT_ID_7491))]
        [Pos(2)]
        public string Inventorytypecode_02 { get; set; }
        /// <summary>
        /// Inventory movement reason code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4499", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Inventorymovementreasoncode_03 { get; set; }
        /// <summary>
        /// Inventory balance method code
        /// </summary>
        [DataMember]
        [DataElement("4503", typeof(EDIFACT_ID_4503))]
        [Pos(4)]
        public string Inventorybalancemethodcode_04 { get; set; }
        /// <summary>
        /// INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C522 INSTRUCTION_05 { get; set; }
    }
    
    /// <summary>
    /// Information required
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IRQ")]
    public class IRQ : I_IRQ<C333>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// INFORMATION REQUEST
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C333 INFORMATIONREQUEST_01 { get; set; }
    }
    
    /// <summary>
    /// Line item
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
        /// Line item identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Lineitemidentifier_01 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public string Actionrequestnotificationdescriptioncode_02 { get; set; }
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
        /// Configuration level number
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevelnumber_05 { get; set; }
        /// <summary>
        /// Configuration operation code
        /// </summary>
        [DataMember]
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string Configurationoperationcode_06 { get; set; }
    }
    
    /// <summary>
    /// Line item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LIN")]
    public class LIN_2 : I_LIN<C212, C829>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line item identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Lineitemidentifier_01 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229_2))]
        [Pos(2)]
        public string Actionrequestnotificationdescriptioncode_02 { get; set; }
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
        /// Configuration level number
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevelnumber_05 { get; set; }
        /// <summary>
        /// Configuration operation code
        /// </summary>
        [DataMember]
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string Configurationoperationcode_06 { get; set; }
    }
    
    /// <summary>
    /// Line item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LIN")]
    public class LIN_3 : I_LIN<C212, C829>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line item identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Lineitemidentifier_01 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229_3))]
        [Pos(2)]
        public string Actionrequestnotificationdescriptioncode_02 { get; set; }
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
        /// Configuration level number
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevelnumber_05 { get; set; }
        /// <summary>
        /// Configuration operation code
        /// </summary>
        [DataMember]
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string Configurationoperationcode_06 { get; set; }
    }
    
    /// <summary>
    /// Line item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LIN")]
    public class LIN_4 : I_LIN<C212, C829>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line item identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Lineitemidentifier_01 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229_4))]
        [Pos(2)]
        public string Actionrequestnotificationdescriptioncode_02 { get; set; }
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
        /// Configuration level number
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevelnumber_05 { get; set; }
        /// <summary>
        /// Configuration operation code
        /// </summary>
        [DataMember]
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string Configurationoperationcode_06 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
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
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_2))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_10 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_4))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_11 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_3))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_12 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_12))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_13 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_14 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_9))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_15 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_17))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_16 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_16))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_17 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_18))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_18 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_19))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_19 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_20))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_2 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_6))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_20 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_22))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_21 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_15))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_22 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_21))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_3 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_13))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_4 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_14))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_5 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_5))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_6 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_7))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_7 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_10))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_8 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_11))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Place/location identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC_9 : I_LOC<C517, C519, C553>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Location function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227_8))]
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
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
        /// Relation code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA : I_MEA<C502_2, C174>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502_2 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_10 : I_MEA<C502, C174_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_12))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
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
        public virtual C174_5 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_11 : I_MEA<C502, C174>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_11))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
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
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_12 : I_MEA<C502_5, C174>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_10))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502_5 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_13 : I_MEA<C502_6, C174_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_9))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502_6 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174_6 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_14 : I_MEA<C502_6, C174>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_9))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502_6 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_15 : I_MEA<C502_7, C174>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_9))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502_7 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_16 : I_MEA<C502_8, C174_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_9))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502_8 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174_7 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_17 : I_MEA<C502_9, C174_8>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_9))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502_9 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174_8 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_2 : I_MEA<C502, C174_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_7))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
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
        public virtual C174_2 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_3 : I_MEA<C502, C174>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_6))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
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
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_4 : I_MEA<C502, C174_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_7))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
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
        public virtual C174_3 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_5 : I_MEA<C502, C174_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_8))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
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
        public virtual C174_4 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_6 : I_MEA<C502_3, C174>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_2))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502_3 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_7 : I_MEA<C502, C174>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_3))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
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
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_8 : I_MEA<C502_3, C174>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_4))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502_3 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA_9 : I_MEA<C502_4, C174>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement purpose code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311_5))]
        [Pos(1)]
        public string Measurementpurposecodequalifier_01 { get; set; }
        /// <summary>
        /// MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502_4 MEASUREMENTDETAILS_02 { get; set; }
        /// <summary>
        /// VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174 VALUERANGE_03 { get; set; }
        /// <summary>
        /// Surface or layer code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
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
        [Required]
        [Pos(1)]
        public virtual C516 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_10 : I_MOA<C516_10>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_10 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_11 : I_MOA<C516_11>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_11 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_12 : I_MOA<C516_12>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_12 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_13 : I_MOA<C516_13>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_13 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_14 : I_MOA<C516_14>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_14 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_15 : I_MOA<C516_15>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_15 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_16 : I_MOA<C516_16>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_16 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_17 : I_MOA<C516_17>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_17 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_18 : I_MOA<C516_18>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_18 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_19 : I_MOA<C516_19>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_19 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_2 : I_MOA<C516_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_2 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_20 : I_MOA<C516_20>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_20 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_21 : I_MOA<C516_21>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_21 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_22 : I_MOA<C516_22>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_22 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_23 : I_MOA<C516_23>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_23 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_24 : I_MOA<C516_24>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_24 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_25 : I_MOA<C516_25>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_25 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_26 : I_MOA<C516_26>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_26 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_3 : I_MOA<C516_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_3 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_4 : I_MOA<C516_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_4 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_5 : I_MOA<C516_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_5 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_6 : I_MOA<C516_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_6 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_7 : I_MOA<C516_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_7 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_8 : I_MOA<C516_8>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_8 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Monetary amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA_9 : I_MOA<C516_9>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516_9 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_13))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_10 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_15))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_11 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_5))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_12 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_17))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_13 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_18))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_14 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_20))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_15 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_21))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_16 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_22))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_17 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_23))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_18 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_24))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_19 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_7))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_2 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_19))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_20 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_25))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_21 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_11))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_22 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_12))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_23 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_26))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_24 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_8))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_25 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_9))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_26 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_27))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_27 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_28))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_28 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_30))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_29 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_31))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_3 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_29))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_30 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_32))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_31 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_33))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_32 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_34))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_33 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_10))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_34 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_6))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_35 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_35))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_36 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_36))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_37 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_37))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_38 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_38))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_39 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_39))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_4 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_16))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_40 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_40))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_41 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_41))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_42 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_42))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_43 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_43))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_5 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_14))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_6 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_7 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_2))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_8 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_3))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Name and address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD_9 : I_NAD<C082, C058, C080, C059, C819>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035_4))]
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
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
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }
        /// <summary>
        /// COUNTRY SUB-ENTITY DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        /// <summary>
        /// Postal identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    /// <summary>
    /// Package
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
        /// Package quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Packagequantity_01 { get; set; }
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
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC_10 : I_PAC<C531_7, C202_2, C402, C532>
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
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531_7 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202_2 PACKAGETYPE_03 { get; set; }
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
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC_11 : I_PAC<C531_2, C202_5, C402, C532_2>
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
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531_2 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202_5 PACKAGETYPE_03 { get; set; }
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
        public virtual C532_2 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC_12 : I_PAC<C531_8, C202_8, C402, C532_2>
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
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531_8 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202_8 PACKAGETYPE_03 { get; set; }
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
        public virtual C532_2 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC_2 : I_PAC<C531_2, C202_2, C402, C532_2>
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
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531_2 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202_2 PACKAGETYPE_03 { get; set; }
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
        public virtual C532_2 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC_3 : I_PAC<C531_3, C202_2, C402, C532_2>
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
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531_3 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202_2 PACKAGETYPE_03 { get; set; }
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
        public virtual C532_2 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC_4 : I_PAC<C531_4, C202_3, C402, C532>
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
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531_4 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202_3 PACKAGETYPE_03 { get; set; }
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
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC_5 : I_PAC<C531_5, C202_4, C402, C532_2>
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
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531_5 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202_4 PACKAGETYPE_03 { get; set; }
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
        public virtual C532_2 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC_6 : I_PAC<C531_5, C202_5, C402, C532_2>
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
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531_5 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202_5 PACKAGETYPE_03 { get; set; }
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
        public virtual C532_2 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC_7 : I_PAC<C531_6, C202_6, C402, C532_2>
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
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531_6 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202_6 PACKAGETYPE_03 { get; set; }
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
        public virtual C532_2 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC_8 : I_PAC<C531_7, C202_5, C402, C532>
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
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531_7 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202_5 PACKAGETYPE_03 { get; set; }
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
    /// Package
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAC")]
    public class PAC_9 : I_PAC<C531_3, C202_7, C402, C532_2>
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
        /// PACKAGING DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C531_3 PACKAGINGDETAILS_02 { get; set; }
        /// <summary>
        /// PACKAGE TYPE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C202_7 PACKAGETYPE_03 { get; set; }
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
        public virtual C532_2 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
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
        [Required]
        [Pos(1)]
        public virtual C534 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI_10 : I_PAI<C534_10>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534_10 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI_11 : I_PAI<C534_11>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534_11 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI_2 : I_PAI<C534_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534_2 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI_3 : I_PAI<C534_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534_3 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI_4 : I_PAI<C534_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534_4 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI_5 : I_PAI<C534_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534_5 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI_6 : I_PAI<C534_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534_6 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI_7 : I_PAI<C534_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534_7 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI_8 : I_PAI<C534_8>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534_8 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI_9 : I_PAI<C534_9>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534_9 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Payment terms basis
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
        /// Payment terms type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
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
    /// Payment terms basis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT")]
    public class PAT_2 : I_PAT<C110, C112_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment terms type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279_2))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
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
        public virtual C112_2 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    /// <summary>
    /// Payment terms basis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT")]
    public class PAT_3 : I_PAT<C110_2, C112_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment terms type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279_5))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
        /// <summary>
        /// PAYMENT TERMS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C110_2 PAYMENTTERMS_02 { get; set; }
        /// <summary>
        /// TERMS/TIME INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C112_2 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    /// <summary>
    /// Payment terms basis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT")]
    public class PAT_4 : I_PAT<C110, C112_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment terms type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279_3))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
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
        public virtual C112_3 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    /// <summary>
    /// Payment terms basis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT")]
    public class PAT_5 : I_PAT<C110_3, C112_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment terms type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279_4))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
        /// <summary>
        /// PAYMENT TERMS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C110_3 PAYMENTTERMS_02 { get; set; }
        /// <summary>
        /// TERMS/TIME INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C112_4 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    /// <summary>
    /// Payment terms basis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT")]
    public class PAT_6 : I_PAT<C110_3, C112_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment terms type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279_2))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
        /// <summary>
        /// PAYMENT TERMS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C110_3 PAYMENTTERMS_02 { get; set; }
        /// <summary>
        /// TERMS/TIME INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C112_4 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    /// <summary>
    /// Payment terms basis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT")]
    public class PAT_7 : I_PAT<C110_3, C112_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment terms type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279_4))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
        /// <summary>
        /// PAYMENT TERMS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C110_3 PAYMENTTERMS_02 { get; set; }
        /// <summary>
        /// TERMS/TIME INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C112_5 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    /// <summary>
    /// Percentage details
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
        [Required]
        [Pos(1)]
        public virtual C501 PERCENTAGEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Percentage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCD")]
    public class PCD_2 : I_PCD<C501_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C501_2 PERCENTAGEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Percentage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCD")]
    public class PCD_3 : I_PCD<C501_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C501_3 PERCENTAGEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Percentage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCD")]
    public class PCD_4 : I_PCD<C501_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C501_4 PERCENTAGEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Percentage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCD")]
    public class PCD_5 : I_PCD<C501_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C501_5 PERCENTAGEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Percentage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCD")]
    public class PCD_6 : I_PCD<C501_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C501_6 PERCENTAGEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Percentage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCD")]
    public class PCD_7 : I_PCD<C501_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C501_7 PERCENTAGEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Percentage details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCD")]
    public class PCD_8 : I_PCD<C501_8>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C501_8 PERCENTAGEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Package identification
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
        /// Marking instructions code
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// Package identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCI")]
    public class PCI_2 : I_PCI<C210, C827>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marking instructions code
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233_2))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// Package identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCI")]
    public class PCI_3 : I_PCI<C210, C827>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marking instructions code
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233_3))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// Package identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCI")]
    public class PCI_4 : I_PCI<C210, C827>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marking instructions code
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233_4))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// Package identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCI")]
    public class PCI_5 : I_PCI<C210, C827>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marking instructions code
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233_8))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// Package identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCI")]
    public class PCI_6 : I_PCI<C210, C827>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marking instructions code
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233_5))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// Package identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCI")]
    public class PCI_7 : I_PCI<C210, C827>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marking instructions code
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233_6))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// Package identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCI")]
    public class PCI_8 : I_PCI<C210, C827>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marking instructions code
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233_7))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// Package identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCI")]
    public class PCI_9 : I_PCI<C210, C827>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marking instructions code
        /// </summary>
        [DataMember]
        [DataElement("4233", typeof(EDIFACT_ID_4233_9))]
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        /// <summary>
        /// MARKS & LABELS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C210 MARKSLABELS_02 { get; set; }
        /// <summary>
        /// Container or package contents indicator code
        /// </summary>
        [DataMember]
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        /// <summary>
        /// TYPE OF MARKING
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// <summary>
    /// Product group information
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
        /// Product group type code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5379", typeof(EDIFACT_ID_5379))]
        [Pos(1)]
        public string Productgrouptypecode_01 { get; set; }
        /// <summary>
        /// PRODUCT GROUP
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C288 PRODUCTGROUP_02 { get; set; }
    }
    
    /// <summary>
    /// Product group information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PGI")]
    public class PGI_2 : I_PGI<C288>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product group type code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5379", typeof(EDIFACT_ID_5379_3))]
        [Pos(1)]
        public string Productgrouptypecode_01 { get; set; }
        /// <summary>
        /// PRODUCT GROUP
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C288 PRODUCTGROUP_02 { get; set; }
    }
    
    /// <summary>
    /// Product group information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PGI")]
    public class PGI_3 : I_PGI<C288>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product group type code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5379", typeof(EDIFACT_ID_5379_2))]
        [Pos(1)]
        public string Productgrouptypecode_01 { get; set; }
        /// <summary>
        /// PRODUCT GROUP
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C288 PRODUCTGROUP_02 { get; set; }
    }
    
    /// <summary>
    /// Additional product id
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
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
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
    /// Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA_10 : I_PIA<C212, C212, C212, C212, C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347_10))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
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
    /// Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA_11 : I_PIA<C212, C212, C212, C212, C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347_11))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
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
    /// Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA_2 : I_PIA<C212, C212, C212, C212, C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347_2))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
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
    /// Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA_3 : I_PIA<C212, C212, C212, C212, C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347_4))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
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
    /// Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA_4 : I_PIA<C212, C212, C212, C212, C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347_3))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
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
    /// Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA_5 : I_PIA<C212, C212, C212, C212, C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347_7))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
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
    /// Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA_6 : I_PIA<C212, C212, C212, C212, C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347_5))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
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
    /// Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA_7 : I_PIA<C212, C212, C212, C212, C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347_6))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
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
    /// Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA_8 : I_PIA<C212, C212, C212, C212, C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347_8))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
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
    /// Additional product id
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PIA")]
    public class PIA_9 : I_PIA<C212, C212, C212, C212, C212>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product identifier code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347_9))]
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        /// <summary>
        /// ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
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
    /// Process identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRC")]
    public class PRC : I_PRC<C242, C830>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PROCESS TYPE AND DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C242 PROCESSTYPEANDDESCRIPTION_01 { get; set; }
        /// <summary>
        /// PROCESS IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C830 PROCESSIDENTIFICATIONDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Process identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRC")]
    public class PRC_2 : I_PRC<C242_2, C830>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PROCESS TYPE AND DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C242_2 PROCESSTYPEANDDESCRIPTION_01 { get; set; }
        /// <summary>
        /// PROCESS IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C830 PROCESSIDENTIFICATIONDETAILS_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
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
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI_10 : I_PRI<C509_10>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509_10 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI_11 : I_PRI<C509_11>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509_11 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI_12 : I_PRI<C509_12>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509_12 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI_2 : I_PRI<C509_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509_2 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI_3 : I_PRI<C509_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509_3 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI_4 : I_PRI<C509_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509_4 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI_5 : I_PRI<C509_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509_5 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI_6 : I_PRI<C509_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509_6 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI_7 : I_PRI<C509_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509_7 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI_8 : I_PRI<C509_8>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509_8 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Price details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI_9 : I_PRI<C509_9>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509_9 PRICEINFORMATION_01 { get; set; }
        /// <summary>
        /// Sub-line item price change operation code
        /// </summary>
        [DataMember]
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    /// <summary>
    /// Payment terms
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PYT")]
    public class PYT : I_PYT<C019>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment terms type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279_6))]
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
        /// <summary>
        /// PAYMENT TERMS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C019 PAYMENTTERMS_02 { get; set; }
        /// <summary>
        /// Time reference code
        /// </summary>
        [DataMember]
        [DataElement("2475", typeof(EDIFACT_ID_2475_6))]
        [Pos(3)]
        public string Timereferencecode_03 { get; set; }
        /// <summary>
        /// Terms time relation code
        /// </summary>
        [DataMember]
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(4)]
        public string Termstimerelationcode_04 { get; set; }
        /// <summary>
        /// Period type code
        /// </summary>
        [DataMember]
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(5)]
        public string Periodtypecode_05 { get; set; }
        /// <summary>
        /// Period count quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(6)]
        public string Periodcountquantity_06 { get; set; }
    }
    
    /// <summary>
    /// Quantity
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
        [Required]
        [Pos(1)]
        public virtual C186 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_10 : I_QTY<C186_10>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_10 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_11 : I_QTY<C186_11>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_11 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_12 : I_QTY<C186_12>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_12 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_13 : I_QTY<C186_13>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_13 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_14 : I_QTY<C186_14>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_14 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_15 : I_QTY<C186_15>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_15 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_16 : I_QTY<C186_16>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_16 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_17 : I_QTY<C186_17>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_17 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_18 : I_QTY<C186_18>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_18 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_19 : I_QTY<C186_19>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_19 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_2 : I_QTY<C186_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_2 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_20 : I_QTY<C186_20>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_20 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_21 : I_QTY<C186_21>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_21 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_22 : I_QTY<C186_22>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_22 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_23 : I_QTY<C186_23>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_23 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_24 : I_QTY<C186_24>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_24 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_25 : I_QTY<C186_25>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_25 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_3 : I_QTY<C186_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_3 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_4 : I_QTY<C186_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_4 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_5 : I_QTY<C186_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_5 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_6 : I_QTY<C186_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_6 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_7 : I_QTY<C186_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_7 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_8 : I_QTY<C186_8>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_8 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY_9 : I_QTY<C186_9>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186_9 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// <summary>
    /// Quantity variances
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QVR")]
    public class QVR : I_QVR<C279, C960_3>
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
        /// Discrepancy nature identification code
        /// </summary>
        [DataMember]
        [DataElement("4221", typeof(EDIFACT_ID_4221))]
        [Pos(2)]
        public string Discrepancynatureidentificationcode_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C960_3 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// Quantity variances
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QVR")]
    public class QVR_2 : I_QVR<C279_2, C960_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DIFFERENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C279_2 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        /// <summary>
        /// Discrepancy nature identification code
        /// </summary>
        [DataMember]
        [DataElement("4221", typeof(EDIFACT_ID_4221_3))]
        [Pos(2)]
        public string Discrepancynatureidentificationcode_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C960_2 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// Quantity variances
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QVR")]
    public class QVR_3 : I_QVR<C279_3, C960_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DIFFERENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C279_3 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        /// <summary>
        /// Discrepancy nature identification code
        /// </summary>
        [DataMember]
        [DataElement("4221", typeof(EDIFACT_ID_4221_4))]
        [Pos(2)]
        public string Discrepancynatureidentificationcode_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C960_4 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// Quantity variances
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QVR")]
    public class QVR_4 : I_QVR<C279_4, C960_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DIFFERENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C279_4 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        /// <summary>
        /// Discrepancy nature identification code
        /// </summary>
        [DataMember]
        [DataElement("4221", typeof(EDIFACT_ID_4221))]
        [Pos(2)]
        public string Discrepancynatureidentificationcode_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C960_5 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// Quantity variances
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QVR")]
    public class QVR_5 : I_QVR<C279_5, C960_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DIFFERENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C279_5 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        /// <summary>
        /// Discrepancy nature identification code
        /// </summary>
        [DataMember]
        [DataElement("4221", typeof(EDIFACT_ID_4221_2))]
        [Pos(2)]
        public string Discrepancynatureidentificationcode_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C960_6 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// Quantity variances
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QVR")]
    public class QVR_6 : I_QVR<C279_6, C960_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY DIFFERENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C279_6 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        /// <summary>
        /// Discrepancy nature identification code
        /// </summary>
        [DataMember]
        [DataElement("4221", typeof(EDIFACT_ID_4221_2))]
        [Pos(2)]
        public string Discrepancynatureidentificationcode_02 { get; set; }
        /// <summary>
        /// REASON FOR CHANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C960_7 REASONFORCHANGE_03 { get; set; }
    }
    
    /// <summary>
    /// Requirements and conditions
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
        /// Sector area identification code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7293", typeof(EDIFACT_ID_7293))]
        [Pos(1)]
        public string Sectorareaidentificationcodequalifier_01 { get; set; }
        /// <summary>
        /// REQUIREMENT/CONDITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C550 REQUIREMENTCONDITIONIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string Actionrequestnotificationdescriptioncode_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Requirements and conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RCS")]
    public class RCS_2 : I_RCS<C550>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sector area identification code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7293", typeof(EDIFACT_ID_7293_2))]
        [Pos(1)]
        public string Sectorareaidentificationcodequalifier_01 { get; set; }
        /// <summary>
        /// REQUIREMENT/CONDITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C550 REQUIREMENTCONDITIONIDENTIFICATION_02 { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string Actionrequestnotificationdescriptioncode_03 { get; set; }
        /// <summary>
        /// Country name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    /// <summary>
    /// Reference
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
        [Required]
        [Pos(1)]
        public virtual C506 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_10 : I_RFF<C506_10>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_10 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_11 : I_RFF<C506_11>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_11 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_12 : I_RFF<C506_12>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_12 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_13 : I_RFF<C506_13>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_13 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_14 : I_RFF<C506_14>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_14 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_15 : I_RFF<C506_15>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_15 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_16 : I_RFF<C506_16>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_16 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_17 : I_RFF<C506_17>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_17 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_18 : I_RFF<C506_18>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_18 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_19 : I_RFF<C506_19>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_19 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_2 : I_RFF<C506_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_2 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_20 : I_RFF<C506_20>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_20 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_21 : I_RFF<C506_21>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_21 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_22 : I_RFF<C506_22>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_22 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_23 : I_RFF<C506_23>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_23 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_24 : I_RFF<C506_24>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_24 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_25 : I_RFF<C506_25>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_25 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_26 : I_RFF<C506_26>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_26 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_27 : I_RFF<C506_27>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_27 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_28 : I_RFF<C506_28>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_28 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_29 : I_RFF<C506_29>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_29 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_3 : I_RFF<C506_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_3 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_30 : I_RFF<C506_30>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_30 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_31 : I_RFF<C506_31>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_31 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_32 : I_RFF<C506_32>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_32 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_33 : I_RFF<C506_33>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_33 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_34 : I_RFF<C506_34>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_34 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_35 : I_RFF<C506_35>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_35 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_36 : I_RFF<C506_36>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_36 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_37 : I_RFF<C506_37>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_37 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_38 : I_RFF<C506_38>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_38 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_39 : I_RFF<C506_39>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_39 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_4 : I_RFF<C506_4>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_4 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_40 : I_RFF<C506_40>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_40 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_41 : I_RFF<C506_41>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_41 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_42 : I_RFF<C506_42>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_42 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_43 : I_RFF<C506_43>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_43 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_44 : I_RFF<C506_44>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_44 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_5 : I_RFF<C506_5>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_5 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_6 : I_RFF<C506_6>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_6 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_7 : I_RFF<C506_7>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_7 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_8 : I_RFF<C506_8>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_8 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF_9 : I_RFF<C506_9>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506_9 REFERENCE_01 { get; set; }
    }
    
    /// <summary>
    /// Range details
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
        /// Range type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6167", typeof(EDIFACT_ID_6167))]
        [Pos(1)]
        public string Rangetypecodequalifier_01 { get; set; }
        /// <summary>
        /// RANGE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C280 RANGE_02 { get; set; }
    }
    
    /// <summary>
    /// Range details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RNG")]
    public class RNG_2 : I_RNG<C280>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Range type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6167", typeof(EDIFACT_ID_6167_2))]
        [Pos(1)]
        public string Rangetypecodequalifier_01 { get; set; }
        /// <summary>
        /// RANGE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C280 RANGE_02 { get; set; }
    }
    
    /// <summary>
    /// Range details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RNG")]
    public class RNG_3 : I_RNG<C280>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Range type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6167", typeof(EDIFACT_ID_6167_3))]
        [Pos(1)]
        public string Rangetypecodequalifier_01 { get; set; }
        /// <summary>
        /// RANGE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C280 RANGE_02 { get; set; }
    }
    
    /// <summary>
    /// Range details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RNG")]
    public class RNG_4 : I_RNG<C280>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Range type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6167", typeof(EDIFACT_ID_6167_4))]
        [Pos(1)]
        public string Rangetypecodequalifier_01 { get; set; }
        /// <summary>
        /// RANGE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C280 RANGE_02 { get; set; }
    }
    
    /// <summary>
    /// Range details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RNG")]
    public class RNG_5 : I_RNG<C280>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Range type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6167", typeof(EDIFACT_ID_6167_5))]
        [Pos(1)]
        public string Rangetypecodequalifier_01 { get; set; }
        /// <summary>
        /// RANGE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C280 RANGE_02 { get; set; }
    }
    
    /// <summary>
    /// Range details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RNG")]
    public class RNG_6 : I_RNG<C280_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Range type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6167", typeof(EDIFACT_ID_6167_6))]
        [Pos(1)]
        public string Rangetypecodequalifier_01 { get; set; }
        /// <summary>
        /// RANGE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C280_2 RANGE_02 { get; set; }
    }
    
    /// <summary>
    /// Rate details
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
        [Required]
        [Pos(1)]
        public virtual C128 RATEDETAILS_01 { get; set; }
        /// <summary>
        /// Status description code
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    /// <summary>
    /// Scheduling conditions
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
        /// Delivery plan commitment level code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4017", typeof(EDIFACT_ID_4017))]
        [Pos(1)]
        public string Deliveryplancommitmentlevelcode_01 { get; set; }
        /// <summary>
        /// Delivery instruction code
        /// </summary>
        [DataMember]
        [DataElement("4493", typeof(EDIFACT_ID_4493))]
        [Pos(2)]
        public string Deliveryinstructioncode_02 { get; set; }
        /// <summary>
        /// PATTERN DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C329 PATTERNDESCRIPTION_03 { get; set; }
    }
    
    /// <summary>
    /// Scheduling conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SCC")]
    public class SCC_2 : I_SCC<C329_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery plan commitment level code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4017", typeof(EDIFACT_ID_4017_2))]
        [Pos(1)]
        public string Deliveryplancommitmentlevelcode_01 { get; set; }
        /// <summary>
        /// Delivery instruction code
        /// </summary>
        [DataMember]
        [DataElement("4493", typeof(EDIFACT_ID_4493_2))]
        [Pos(2)]
        public string Deliveryinstructioncode_02 { get; set; }
        /// <summary>
        /// PATTERN DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C329_2 PATTERNDESCRIPTION_03 { get; set; }
    }
    
    /// <summary>
    /// Scheduling conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SCC")]
    public class SCC_3 : I_SCC<C329_3>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery plan commitment level code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4017", typeof(EDIFACT_ID_4017_3))]
        [Pos(1)]
        public string Deliveryplancommitmentlevelcode_01 { get; set; }
        /// <summary>
        /// Delivery instruction code
        /// </summary>
        [DataMember]
        [DataElement("4493", typeof(EDIFACT_ID_4493_3))]
        [Pos(2)]
        public string Deliveryinstructioncode_02 { get; set; }
        /// <summary>
        /// PATTERN DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C329_3 PATTERNDESCRIPTION_03 { get; set; }
    }
    
    /// <summary>
    /// Seal number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SEL")]
    public class SEL : I_SEL<C215, C208>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Seal identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9308", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Sealidentifier_01 { get; set; }
        /// <summary>
        /// SEAL ISSUER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C215 SEALISSUER_02 { get; set; }
        /// <summary>
        /// Seal condition code
        /// </summary>
        [DataMember]
        [DataElement("4517", typeof(EDIFACT_ID_4517))]
        [Pos(3)]
        public string Sealconditioncode_03 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C208 IDENTITYNUMBERRANGE_04 { get; set; }
    }
    
    /// <summary>
    /// Seal number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SEL")]
    public class SEL_2 : I_SEL<C215_2, C208>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Seal identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9308", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Sealidentifier_01 { get; set; }
        /// <summary>
        /// SEAL ISSUER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C215_2 SEALISSUER_02 { get; set; }
        /// <summary>
        /// Seal condition code
        /// </summary>
        [DataMember]
        [DataElement("4517", typeof(EDIFACT_ID_4517))]
        [Pos(3)]
        public string Sealconditioncode_03 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C208 IDENTITYNUMBERRANGE_04 { get; set; }
    }
    
    /// <summary>
    /// Seal number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SEL")]
    public class SEL_3 : I_SEL<C215_3, C208>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Seal identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9308", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Sealidentifier_01 { get; set; }
        /// <summary>
        /// SEAL ISSUER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C215_3 SEALISSUER_02 { get; set; }
        /// <summary>
        /// Seal condition code
        /// </summary>
        [DataMember]
        [DataElement("4517", typeof(EDIFACT_ID_4517))]
        [Pos(3)]
        public string Sealconditioncode_03 { get; set; }
        /// <summary>
        /// IDENTITY NUMBER RANGE
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C208 IDENTITYNUMBERRANGE_04 { get; set; }
    }
    
    /// <summary>
    /// Sequence details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SEQ")]
    public class SEQ : I_SEQ<C286>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Action request/notification description code
        /// </summary>
        [DataMember]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(1)]
        public string Actionrequestnotificationdescriptioncode_01 { get; set; }
        /// <summary>
        /// SEQUENCE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C286 SEQUENCEINFORMATION_02 { get; set; }
    }
    
    /// <summary>
    /// Split goods placement
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
        [Required]
        [Pos(1)]
        public virtual C237 EQUIPMENTIDENTIFICATION_01 { get; set; }
        /// <summary>
        /// Package quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Packagequantity_02 { get; set; }
    }
    
    /// <summary>
    /// Status
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
        /// STATUS CATEGORY
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C601 STATUSCATEGORY_01 { get; set; }
        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C555 STATUS_02 { get; set; }
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
    /// Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STS")]
    public class STS_2 : I_STS<C601_2, C555_2, C556, C556, C556, C556, C556>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// STATUS CATEGORY
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C601_2 STATUSCATEGORY_01 { get; set; }
        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C555_2 STATUS_02 { get; set; }
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
    /// Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STS")]
    public class STS_3 : I_STS<C601_3, C555_3, C556, C556, C556, C556, C556>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// STATUS CATEGORY
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C601_3 STATUSCATEGORY_01 { get; set; }
        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C555_3 STATUS_02 { get; set; }
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
    /// Duty/tax/fee details
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
        /// Duty or tax or fee function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
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
        /// Duty or tax or fee assessment basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// Duty or tax or fee category code
        /// </summary>
        [DataMember]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        /// <summary>
        /// Party tax identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    /// <summary>
    /// Duty/tax/fee details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX_2 : I_TAX<C241_2, C533, C243>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty or tax or fee function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C241_2 DUTYTAXFEETYPE_02 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE ACCOUNT DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee assessment basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// Duty or tax or fee category code
        /// </summary>
        [DataMember]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        /// <summary>
        /// Party tax identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    /// <summary>
    /// Duty/tax/fee details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX_3 : I_TAX<C241_3, C533, C243>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty or tax or fee function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283_2))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C241_3 DUTYTAXFEETYPE_02 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE ACCOUNT DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee assessment basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// Duty or tax or fee category code
        /// </summary>
        [DataMember]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        /// <summary>
        /// Party tax identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    /// <summary>
    /// Duty/tax/fee details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX_4 : I_TAX<C241_4, C533, C243>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty or tax or fee function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C241_4 DUTYTAXFEETYPE_02 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE ACCOUNT DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee assessment basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// Duty or tax or fee category code
        /// </summary>
        [DataMember]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        /// <summary>
        /// Party tax identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    /// <summary>
    /// Duty/tax/fee details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX_5 : I_TAX<C241_5, C533, C243>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty or tax or fee function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283_2))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C241_5 DUTYTAXFEETYPE_02 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE ACCOUNT DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee assessment basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// Duty or tax or fee category code
        /// </summary>
        [DataMember]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        /// <summary>
        /// Party tax identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    /// <summary>
    /// Duty/tax/fee details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX_6 : I_TAX<C241_4, C533, C243>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty or tax or fee function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283_3))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C241_4 DUTYTAXFEETYPE_02 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE ACCOUNT DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        /// <summary>
        /// Duty or tax or fee assessment basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// Duty or tax or fee category code
        /// </summary>
        [DataMember]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        /// <summary>
        /// Party tax identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    /// <summary>
    /// Duty/tax/fee details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX_7 : I_TAX<C241, C533, C243>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Duty or tax or fee function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283_3))]
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
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
        /// Duty or tax or fee assessment basis value
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C243 DUTYTAXFEEDETAIL_05 { get; set; }
        /// <summary>
        /// Duty or tax or fee category code
        /// </summary>
        [DataMember]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        /// <summary>
        /// Party tax identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        /// <summary>
        /// Calculation sequence code
        /// </summary>
        [DataMember]
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
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
        /// Transport stage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
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
        /// Transit direction indicator code
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
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
        /// Transport means ownership indicator code
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT_10 : I_TDT<C220_4, C228_7, C040, C401, C222>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051_2))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C220_4 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C228_7 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
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
        /// Transport means ownership indicator code
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT_2 : I_TDT<C220_2, C228_2, C040, C401, C222>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C220_2 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C228_2 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
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
        /// Transport means ownership indicator code
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT_3 : I_TDT<C220_3, C228_2, C040, C401, C222>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051_2))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C220_3 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C228_2 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
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
        /// Transport means ownership indicator code
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT_4 : I_TDT<C220_3, C228_2, C040, C401, C222>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051_3))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C220_3 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C228_2 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
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
        /// Transport means ownership indicator code
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT_5 : I_TDT<C220_3, C228_3, C040, C401, C222>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051_3))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C220_3 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C228_3 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
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
        /// Transport means ownership indicator code
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT_6 : I_TDT<C220_3, C228_4, C040, C401, C222>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051_3))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C220_3 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C228_4 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
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
        /// Transport means ownership indicator code
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT_7 : I_TDT<C220_2, C228_2, C040, C401, C222>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051_2))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C220_2 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C228_2 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
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
        /// Transport means ownership indicator code
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT_8 : I_TDT<C220_3, C228_5, C040, C401, C222>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051_2))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C220_3 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C228_5 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
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
        /// Transport means ownership indicator code
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Details of transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT_9 : I_TDT<C220_3, C228_6, C040, C401, C222>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transport stage code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051_2))]
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        /// <summary>
        /// Means of transport journey identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        /// <summary>
        /// MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C220_3 MODEOFTRANSPORT_03 { get; set; }
        /// <summary>
        /// TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C228_6 TRANSPORTMEANS_04 { get; set; }
        /// <summary>
        /// CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040 CARRIER_05 { get; set; }
        /// <summary>
        /// Transit direction indicator code
        /// </summary>
        [DataMember]
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
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
        /// Transport means ownership indicator code
        /// </summary>
        [DataMember]
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    /// <summary>
    /// Temperature
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
        /// Temperature type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6245", typeof(EDIFACT_ID_6245))]
        [Pos(1)]
        public string Temperaturetypecodequalifier_01 { get; set; }
        /// <summary>
        /// TEMPERATURE SETTING
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C239 TEMPERATURESETTING_02 { get; set; }
    }
    
    /// <summary>
    /// Temperature
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TMP")]
    public class TMP_2 : I_TMP<C239>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Temperature type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6245", typeof(EDIFACT_ID_6245_2))]
        [Pos(1)]
        public string Temperaturetypecodequalifier_01 { get; set; }
        /// <summary>
        /// TEMPERATURE SETTING
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C239 TEMPERATURESETTING_02 { get; set; }
    }
    
    /// <summary>
    /// Terms of delivery or transport
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
        /// Delivery or transport terms function code
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// Terms of delivery or transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOD")]
    public class TOD_2 : I_TOD<C100>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery or transport terms function code
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055_2))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215_2))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// Terms of delivery or transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOD")]
    public class TOD_3 : I_TOD<C100>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery or transport terms function code
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055_2))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215_3))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// Terms of delivery or transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOD")]
    public class TOD_4 : I_TOD<C100>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery or transport terms function code
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055_3))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215_2))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// Terms of delivery or transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOD")]
    public class TOD_5 : I_TOD<C100>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery or transport terms function code
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055_4))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215_4))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// Terms of delivery or transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOD")]
    public class TOD_6 : I_TOD<C100>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery or transport terms function code
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055_5))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215_5))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// Terms of delivery or transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOD")]
    public class TOD_7 : I_TOD<C100>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery or transport terms function code
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055_2))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215_6))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// Terms of delivery or transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOD")]
    public class TOD_8 : I_TOD<C100>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery or transport terms function code
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055_6))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215_7))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// Terms of delivery or transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TOD")]
    public class TOD_9 : I_TOD<C100>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Delivery or transport terms function code
        /// </summary>
        [DataMember]
        [DataElement("4055", typeof(EDIFACT_ID_4055_2))]
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215_8))]
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// <summary>
    /// Technical rules
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TRU")]
    public class TRU : I_TRU
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
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Versionidentifier_02 { get; set; }
        /// <summary>
        /// Release identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1058", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Releaseidentifier_03 { get; set; }
        /// <summary>
        /// Rule part identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7175", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Rulepartidentifier_04 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    /// <summary>
    /// Transport service requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TSR")]
    public class TSR : I_TSR<C536, C233, C537, C703_2>
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
        public virtual C703_2 NATUREOFCARGO_04 { get; set; }
    }
    
    /// <summary>
    /// Transport service requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TSR")]
    public class TSR_2 : I_TSR<C536_2, C233, C537_2, C703_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTRACT AND CARRIAGE CONDITION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C536_2 CONTRACTANDCARRIAGECONDITION_01 { get; set; }
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
        public virtual C537_2 TRANSPORTPRIORITY_03 { get; set; }
        /// <summary>
        /// NATURE OF CARGO
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C703_2 NATUREOFCARGO_04 { get; set; }
    }
    
    /// <summary>
    /// Transport service requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TSR")]
    public class TSR_3 : I_TSR<C536_3, C233, C537, C703_2>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTRACT AND CARRIAGE CONDITION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C536_3 CONTRACTANDCARRIAGECONDITION_01 { get; set; }
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
        public virtual C703_2 NATUREOFCARGO_04 { get; set; }
    }
    
    /// <summary>
    /// Transport service requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TSR")]
    public class TSR_4 : I_TSR<C536_3, C233, C537, C703>
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTRACT AND CARRIAGE CONDITION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C536_3 CONTRACTANDCARRIAGECONDITION_01 { get; set; }
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
    /// Section control
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
        [Required]
        [StringLength(1, 1)]
        [DataElement("0081", typeof(EDIFACT_A))]
        [Pos(1)]
        public string Sectionidentification_01 { get; set; }
    }
}
