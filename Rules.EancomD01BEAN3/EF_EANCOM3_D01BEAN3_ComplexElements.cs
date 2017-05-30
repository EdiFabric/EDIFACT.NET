namespace EdiFabric.Rules.EANCOM_D01BEAN3
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Composite("TSINVOIC_C516_12")]
    public class TSINVOIC_C516_12
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C214_3")]
    public class TSINVOIC_C214_3
    {
        
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C552_3")]
    public class TSINVOIC_C552_3
    {
        
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargeidentifier_01 { get; set; }
        [DataElement("5189", typeof(EDIFACT_ID_5189))]
        [Pos(2)]
        public string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C516_11")]
    public class TSINVOIC_C516_11
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C243_5")]
    public class TSINVOIC_C243_5
    {
        
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeratecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeerate_04 { get; set; }
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string Dutyortaxorfeeratebasiscode_05 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistidentificationcode_06 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycode_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C533_5")]
    public class TSINVOIC_C533_5
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeaccountcode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C241_5")]
    public class TSINVOIC_C241_5
    {
        
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C507_11")]
    public class TSINVOIC_C507_11
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C506_5")]
    public class TSINVOIC_C506_5
    {
        
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C516_10")]
    public class TSINVOIC_C516_10
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C270")]
    public class TSINVOIC_C270
    {
        
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C553_4")]
    public class TSINVOIC_C553_4
    {
        
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Secondrelatedlocationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Secondrelatedlocationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C519_4")]
    public class TSINVOIC_C519_4
    {
        
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Firstrelatedlocationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Firstrelatedlocationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C517_4")]
    public class TSINVOIC_C517_4
    {
        
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Locationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 256)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Locationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C100_2")]
    public class TSINVOIC_C100_2
    {
        
        [DataElement("4053", typeof(EDIFACT_ID_4053))]
        [Pos(1)]
        public string Deliveryortransporttermsdescriptioncode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Deliveryortransporttermsdescription_04 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Deliveryortransporttermsdescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C222_2")]
    public class TSINVOIC_C222_2
    {
        
        [StringLength(1, 9)]
        [DataElement("8213", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Transportmeansidentificationnameidentifier_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Transportmeansidentificationname_04 { get; set; }
        [DataElement("8453", typeof(EDIFACT_ID_8453))]
        [Pos(5)]
        public string Transportmeansnationalitycode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C401_2")]
    public class TSINVOIC_C401_2
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("8457", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Excesstransportationreasoncode_01 { get; set; }
        [Required]
        [StringLength(1, 3)]
        [DataElement("8459", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Excesstransportationresponsibilitycode_02 { get; set; }
        [StringLength(1, 17)]
        [DataElement("7130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Customershipmentauthorisationidentifier_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C040_2")]
    public class TSINVOIC_C040_2
    {
        
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Carrieridentifier_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3128", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Carriername_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C228_2")]
    public class TSINVOIC_C228_2
    {
        
        [DataElement("8179", typeof(EDIFACT_ID_8179))]
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C220_2")]
    public class TSINVOIC_C220_2
    {
        
        [DataElement("8067", typeof(EDIFACT_ID_8067))]
        [Pos(1)]
        public string Transportmodenamecode_01 { get; set; }
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmodename_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C516_9")]
    public class TSINVOIC_C516_9
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C243_4")]
    public class TSINVOIC_C243_4
    {
        
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeratecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeerate_04 { get; set; }
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string Dutyortaxorfeeratebasiscode_05 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistidentificationcode_06 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycode_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C533_4")]
    public class TSINVOIC_C533_4
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeaccountcode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C241_4")]
    public class TSINVOIC_C241_4
    {
        
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C128_2")]
    public class TSINVOIC_C128_2
    {
        
        [Required]
        [DataElement("5419", typeof(EDIFACT_ID_5419))]
        [Pos(1)]
        public string Ratetypecodequalifier_01 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("5420", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Unitpricebasisrate_02 { get; set; }
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Unitpricebasisvalue_03 { get; set; }
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(4)]
        public string Measurementunitcode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C516_8")]
    public class TSINVOIC_C516_8
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C501_4")]
    public class TSINVOIC_C501_4
    {
        
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C186_4")]
    public class TSINVOIC_C186_4
    {
        
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C507_10")]
    public class TSINVOIC_C507_10
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C214_2")]
    public class TSINVOIC_C214_2
    {
        
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C552_2")]
    public class TSINVOIC_C552_2
    {
        
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargeidentifier_01 { get; set; }
        [DataElement("5189", typeof(EDIFACT_ID_5189))]
        [Pos(2)]
        public string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C506_4")]
    public class TSINVOIC_C506_4
    {
        
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C819_2")]
    public class TSINVOIC_C819_2
    {
        
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Countrysubentitynamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrysubentityname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C059_2")]
    public class TSINVOIC_C059_2
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Streetandnumberorpostofficeboxidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Streetandnumberorpostofficeboxidentifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Streetandnumberorpostofficeboxidentifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Streetandnumberorpostofficeboxidentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C080_2")]
    public class TSINVOIC_C080_2
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyname_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Partyname_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Partyname_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Partyname_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Partyname_05 { get; set; }
        [DataElement("3045", typeof(EDIFACT_ID_3045))]
        [Pos(6)]
        public string Partynameformatcode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C058_2")]
    public class TSINVOIC_C058_2
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Nameandaddressdescription_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Nameandaddressdescription_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Nameandaddressdescription_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nameandaddressdescription_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nameandaddressdescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C082_2")]
    public class TSINVOIC_C082_2
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyidentifier_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C516_7")]
    public class TSINVOIC_C516_7
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C243_3")]
    public class TSINVOIC_C243_3
    {
        
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeratecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeerate_04 { get; set; }
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string Dutyortaxorfeeratebasiscode_05 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistidentificationcode_06 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycode_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C533_3")]
    public class TSINVOIC_C533_3
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeaccountcode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C241_3")]
    public class TSINVOIC_C241_3
    {
        
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C507_9")]
    public class TSINVOIC_C507_9
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C186_3")]
    public class TSINVOIC_C186_3
    {
        
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C553_3")]
    public class TSINVOIC_C553_3
    {
        
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Secondrelatedlocationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Secondrelatedlocationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C519_3")]
    public class TSINVOIC_C519_3
    {
        
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Firstrelatedlocationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Firstrelatedlocationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C517_3")]
    public class TSINVOIC_C517_3
    {
        
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Locationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 256)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Locationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C208_10")]
    public class TSINVOIC_C208_10
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C208_9")]
    public class TSINVOIC_C208_9
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C208_8")]
    public class TSINVOIC_C208_8
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C208_7")]
    public class TSINVOIC_C208_7
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C208_6")]
    public class TSINVOIC_C208_6
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C827")]
    public class TSINVOIC_C827
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("7511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Markingtypecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C210")]
    public class TSINVOIC_C210
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Shippingmarksdescription_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Shippingmarksdescription_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Shippingmarksdescription_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Shippingmarksdescription_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Shippingmarksdescription_05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Shippingmarksdescription_06 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Shippingmarksdescription_07 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Shippingmarksdescription_08 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Shippingmarksdescription_09 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string Shippingmarksdescription_10 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C174_2")]
    public class TSINVOIC_C174_2
    {
        
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C502_2")]
    public class TSINVOIC_C502_2
    {
        
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C532_2")]
    public class TSINVOIC_C532_2
    {
        
        [DataElement("8395", typeof(EDIFACT_ID_8395))]
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycode_01 { get; set; }
        [DataElement("8393", typeof(EDIFACT_ID_8393))]
        [Pos(2)]
        public string Returnablepackageloadcontentscode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C402_2")]
    public class TSINVOIC_C402_2
    {
        
        [Required]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofpackages_02 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(3)]
        public string Itemtypeidentificationcode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(5)]
        public string Itemtypeidentificationcode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C202_2")]
    public class TSINVOIC_C202_2
    {
        
        [DataElement("7065", typeof(EDIFACT_ID_7065))]
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C531_2")]
    public class TSINVOIC_C531_2
    {
        
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        [DataElement("7073", typeof(EDIFACT_ID_7073))]
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C507_8")]
    public class TSINVOIC_C507_8
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C506_3")]
    public class TSINVOIC_C506_3
    {
        
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C960_2")]
    public class TSINVOIC_C960_2
    {
        
        [DataElement("4295", typeof(EDIFACT_ID_4295))]
        [Pos(1)]
        public string Changereasondescriptioncode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereasondescription_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C138")]
    public class TSINVOIC_C138
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("5394", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Pricemultiplierrate_01 { get; set; }
        [DataElement("5393", typeof(EDIFACT_ID_5393))]
        [Pos(2)]
        public string Pricemultipliertypecodequalifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C509")]
    public class TSINVOIC_C509
    {
        
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125))]
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        [DataElement("5375", typeof(EDIFACT_ID_5375))]
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C516_6")]
    public class TSINVOIC_C516_6
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C501_3")]
    public class TSINVOIC_C501_3
    {
        
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C507_7")]
    public class TSINVOIC_C507_7
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C112_2")]
    public class TSINVOIC_C112_2
    {
        
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475))]
        [Pos(1)]
        public string Timereferencecode_01 { get; set; }
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Termstimerelationcode_02 { get; set; }
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(3)]
        public string Periodtypecode_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Periodcountquantity_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C110_2")]
    public class TSINVOIC_C110_2
    {
        
        [Required]
        [DataElement("4277", typeof(EDIFACT_ID_4277))]
        [Pos(1)]
        public string Paymenttermsdescriptionidentifier_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Paymenttermsdescription_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Paymenttermsdescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C516_5")]
    public class TSINVOIC_C516_5
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C108_2")]
    public class TSINVOIC_C108_2
    {
        
        [Required]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetextvalue_01 { get; set; }
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Freetextvalue_02 { get; set; }
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Freetextvalue_03 { get; set; }
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freetextvalue_04 { get; set; }
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Freetextvalue_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C107_2")]
    public class TSINVOIC_C107_2
    {
        
        [Required]
        [DataElement("4441", typeof(EDIFACT_ID_4441))]
        [Pos(1)]
        public string Freetextvaluecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C960")]
    public class TSINVOIC_C960
    {
        
        [DataElement("4295", typeof(EDIFACT_ID_4295))]
        [Pos(1)]
        public string Changereasondescriptioncode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereasondescription_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C279")]
    public class TSINVOIC_C279
    {
        
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantityvariancevalue_01 { get; set; }
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(2)]
        public string Quantitytypecodequalifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C208_5")]
    public class TSINVOIC_C208_5
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C208_4")]
    public class TSINVOIC_C208_4
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C208_3")]
    public class TSINVOIC_C208_3
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C208_2")]
    public class TSINVOIC_C208_2
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C208")]
    public class TSINVOIC_C208
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C507_6")]
    public class TSINVOIC_C507_6
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C186_2")]
    public class TSINVOIC_C186_2
    {
        
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C174")]
    public class TSINVOIC_C174
    {
        
        [Required]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C502")]
    public class TSINVOIC_C502
    {
        
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C273")]
    public class TSINVOIC_C273
    {
        
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(1)]
        public string Itemdescriptioncode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        [StringLength(1, 256)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(6)]
        public string Languagenamecode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C272")]
    public class TSINVOIC_C272
    {
        
        [DataElement("7081", typeof(EDIFACT_ID_7081))]
        [Pos(1)]
        public string Itemcharacteristiccode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C212_6")]
    public class TSINVOIC_C212_6
    {
        
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemidentifier_01 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemtypeidentificationcode_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C212_5")]
    public class TSINVOIC_C212_5
    {
        
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemidentifier_01 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemtypeidentificationcode_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C212_4")]
    public class TSINVOIC_C212_4
    {
        
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemidentifier_01 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemtypeidentificationcode_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C212_3")]
    public class TSINVOIC_C212_3
    {
        
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemidentifier_01 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemtypeidentificationcode_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C212_2")]
    public class TSINVOIC_C212_2
    {
        
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemidentifier_01 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemtypeidentificationcode_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C829")]
    public class TSINVOIC_C829
    {
        
        [DataElement("5495", typeof(EDIFACT_ID_5495))]
        [Pos(1)]
        public string Sublineindicatorcode_01 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Lineitemidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C212")]
    public class TSINVOIC_C212
    {
        
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemidentifier_01 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemtypeidentificationcode_02 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C516_4")]
    public class TSINVOIC_C516_4
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C243_2")]
    public class TSINVOIC_C243_2
    {
        
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeratecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeerate_04 { get; set; }
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string Dutyortaxorfeeratebasiscode_05 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistidentificationcode_06 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycode_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C533_2")]
    public class TSINVOIC_C533_2
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeaccountcode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C241_2")]
    public class TSINVOIC_C241_2
    {
        
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C128")]
    public class TSINVOIC_C128
    {
        
        [Required]
        [DataElement("5419", typeof(EDIFACT_ID_5419))]
        [Pos(1)]
        public string Ratetypecodequalifier_01 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("5420", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Unitpricebasisrate_02 { get; set; }
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Unitpricebasisvalue_03 { get; set; }
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(4)]
        public string Measurementunitcode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C516_3")]
    public class TSINVOIC_C516_3
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C501_2")]
    public class TSINVOIC_C501_2
    {
        
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C186")]
    public class TSINVOIC_C186
    {
        
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C214")]
    public class TSINVOIC_C214
    {
        
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C552")]
    public class TSINVOIC_C552
    {
        
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargeidentifier_01 { get; set; }
        [DataElement("5189", typeof(EDIFACT_ID_5189))]
        [Pos(2)]
        public string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C532")]
    public class TSINVOIC_C532
    {
        
        [DataElement("8395", typeof(EDIFACT_ID_8395))]
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycode_01 { get; set; }
        [DataElement("8393", typeof(EDIFACT_ID_8393))]
        [Pos(2)]
        public string Returnablepackageloadcontentscode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C402")]
    public class TSINVOIC_C402
    {
        
        [Required]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofpackages_02 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(3)]
        public string Itemtypeidentificationcode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(5)]
        public string Itemtypeidentificationcode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C202")]
    public class TSINVOIC_C202
    {
        
        [DataElement("7065", typeof(EDIFACT_ID_7065))]
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C531")]
    public class TSINVOIC_C531
    {
        
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        [DataElement("7073", typeof(EDIFACT_ID_7073))]
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C553_2")]
    public class TSINVOIC_C553_2
    {
        
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Secondrelatedlocationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Secondrelatedlocationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C519_2")]
    public class TSINVOIC_C519_2
    {
        
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Firstrelatedlocationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Firstrelatedlocationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C517_2")]
    public class TSINVOIC_C517_2
    {
        
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Locationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 256)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Locationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C100")]
    public class TSINVOIC_C100
    {
        
        [DataElement("4053", typeof(EDIFACT_ID_4053))]
        [Pos(1)]
        public string Deliveryortransporttermsdescriptioncode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Deliveryortransporttermsdescription_04 { get; set; }
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Deliveryortransporttermsdescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C507_5")]
    public class TSINVOIC_C507_5
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C553")]
    public class TSINVOIC_C553
    {
        
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Secondrelatedlocationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Secondrelatedlocationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C519")]
    public class TSINVOIC_C519
    {
        
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Firstrelatedlocationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Firstrelatedlocationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C517")]
    public class TSINVOIC_C517
    {
        
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Locationnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 256)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Locationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C222")]
    public class TSINVOIC_C222
    {
        
        [StringLength(1, 9)]
        [DataElement("8213", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Transportmeansidentificationnameidentifier_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Transportmeansidentificationname_04 { get; set; }
        [DataElement("8453", typeof(EDIFACT_ID_8453))]
        [Pos(5)]
        public string Transportmeansnationalitycode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C401")]
    public class TSINVOIC_C401
    {
        
        [Required]
        [StringLength(1, 3)]
        [DataElement("8457", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Excesstransportationreasoncode_01 { get; set; }
        [Required]
        [StringLength(1, 3)]
        [DataElement("8459", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Excesstransportationresponsibilitycode_02 { get; set; }
        [StringLength(1, 17)]
        [DataElement("7130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Customershipmentauthorisationidentifier_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C040")]
    public class TSINVOIC_C040
    {
        
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Carrieridentifier_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3128", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Carriername_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C228")]
    public class TSINVOIC_C228
    {
        
        [DataElement("8179", typeof(EDIFACT_ID_8179))]
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C220")]
    public class TSINVOIC_C220
    {
        
        [DataElement("8067", typeof(EDIFACT_ID_8067))]
        [Pos(1)]
        public string Transportmodenamecode_01 { get; set; }
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmodename_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C088_2")]
    public class TSINVOIC_C088_2
    {
        
        [DataElement("3433", typeof(EDIFACT_ID_3433))]
        [Pos(1)]
        public string Institutionnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Institutionbranchidentifier_04 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistidentificationcode_05 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string Codelistresponsibleagencycode_06 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3432", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Institutionname_07 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3436", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Institutionbranchlocationname_08 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C078_2")]
    public class TSINVOIC_C078_2
    {
        
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Accountholderidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Accountholdername_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Accountholdername_03 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(4)]
        public string Currencyidentificationcode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C534_2")]
    public class TSINVOIC_C534_2
    {
        
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        [DataElement("4461", typeof(EDIFACT_ID_4461))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        [DataElement("4435", typeof(EDIFACT_ID_4435))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C516_2")]
    public class TSINVOIC_C516_2
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C501")]
    public class TSINVOIC_C501
    {
        
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C507_4")]
    public class TSINVOIC_C507_4
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C112")]
    public class TSINVOIC_C112
    {
        
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475))]
        [Pos(1)]
        public string Timereferencecode_01 { get; set; }
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Termstimerelationcode_02 { get; set; }
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(3)]
        public string Periodtypecode_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Periodcountquantity_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C110")]
    public class TSINVOIC_C110
    {
        
        [Required]
        [DataElement("4277", typeof(EDIFACT_ID_4277))]
        [Pos(1)]
        public string Paymenttermsdescriptionidentifier_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Paymenttermsdescription_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Paymenttermsdescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C507_3")]
    public class TSINVOIC_C507_3
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C504_2")]
    public class TSINVOIC_C504_2
    {
        
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string Currencyusagecodequalifier_01 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(2)]
        public string Currencyidentificationcode_02 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string Currencytypecodequalifier_03 { get; set; }
        [StringLength(1, 4)]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Currencyratevalue_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C504")]
    public class TSINVOIC_C504
    {
        
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string Currencyusagecodequalifier_01 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(2)]
        public string Currencyidentificationcode_02 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string Currencytypecodequalifier_03 { get; set; }
        [StringLength(1, 4)]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Currencyratevalue_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C516")]
    public class TSINVOIC_C516
    {
        
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C243")]
    public class TSINVOIC_C243
    {
        
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeratecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeerate_04 { get; set; }
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string Dutyortaxorfeeratebasiscode_05 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistidentificationcode_06 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycode_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C533")]
    public class TSINVOIC_C533
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutyortaxorfeeaccountcode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C241")]
    public class TSINVOIC_C241
    {
        
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C076")]
    public class TSINVOIC_C076
    {
        
        [Required]
        [StringLength(1, 512)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Communicationaddressidentifier_01 { get; set; }
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155))]
        [Pos(2)]
        public string Communicationaddresscodequalifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C056")]
    public class TSINVOIC_C056
    {
        
        [StringLength(1, 17)]
        [DataElement("3413", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Departmentoremployeenamecode_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3412", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Departmentoremployeename_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C506_2")]
    public class TSINVOIC_C506_2
    {
        
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C088")]
    public class TSINVOIC_C088
    {
        
        [DataElement("3433", typeof(EDIFACT_ID_3433))]
        [Pos(1)]
        public string Institutionnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Institutionbranchidentifier_04 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistidentificationcode_05 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string Codelistresponsibleagencycode_06 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3432", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Institutionname_07 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3436", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Institutionbranchlocationname_08 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C078")]
    public class TSINVOIC_C078
    {
        
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Accountholderidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Accountholdername_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Accountholdername_03 { get; set; }
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(4)]
        public string Currencyidentificationcode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C819")]
    public class TSINVOIC_C819
    {
        
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Countrysubentitynamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 70)]
        [DataElement("3228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrysubentityname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C059")]
    public class TSINVOIC_C059
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Streetandnumberorpostofficeboxidentifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Streetandnumberorpostofficeboxidentifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Streetandnumberorpostofficeboxidentifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Streetandnumberorpostofficeboxidentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C080")]
    public class TSINVOIC_C080
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyname_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Partyname_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Partyname_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Partyname_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Partyname_05 { get; set; }
        [DataElement("3045", typeof(EDIFACT_ID_3045))]
        [Pos(6)]
        public string Partynameformatcode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C058")]
    public class TSINVOIC_C058
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Nameandaddressdescription_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Nameandaddressdescription_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Nameandaddressdescription_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nameandaddressdescription_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nameandaddressdescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C082")]
    public class TSINVOIC_C082
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("3039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyidentifier_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C507_2")]
    public class TSINVOIC_C507_2
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C506")]
    public class TSINVOIC_C506
    {
        
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencecodequalifier_01 { get; set; }
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C108")]
    public class TSINVOIC_C108
    {
        
        [Required]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetextvalue_01 { get; set; }
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Freetextvalue_02 { get; set; }
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Freetextvalue_03 { get; set; }
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freetextvalue_04 { get; set; }
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Freetextvalue_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C107")]
    public class TSINVOIC_C107
    {
        
        [Required]
        [DataElement("4441", typeof(EDIFACT_ID_4441))]
        [Pos(1)]
        public string Freetextvaluecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C534")]
    public class TSINVOIC_C534
    {
        
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        [DataElement("4461", typeof(EDIFACT_ID_4461))]
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        [DataElement("4435", typeof(EDIFACT_ID_4435))]
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C507")]
    public class TSINVOIC_C507
    {
        
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C106")]
    public class TSINVOIC_C106
    {
        
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Versionidentifier_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Revisionidentifier_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_C002")]
    public class TSINVOIC_C002
    {
        
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_S018")]
    public class TSINVOIC_S018
    {
        
        [Required]
        [StringLength(1, 14)]
        [DataElement("0127", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string ScenarioIdentification_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0128", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string ScenarioVersionNumber_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string ScenarioReleaseNumber_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ControllingAgencyCoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_S017")]
    public class TSINVOIC_S017
    {
        
        [Required]
        [StringLength(1, 14)]
        [DataElement("0121", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MessageImplementationGuidelineIdentification_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0122", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MessageImplementationGuidelineVersionNumber_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string MessageImplementationGuidelineReleaseNumber_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ControllingAgencyCoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_S016")]
    public class TSINVOIC_S016
    {
        
        [Required]
        [StringLength(1, 14)]
        [DataElement("0115", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MessageSubsetIdentification_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0116", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MessageSubsetVersionNumber_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0118", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string MessageSubsetReleaseNumber_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("0051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ControllingAgencyCoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_S010")]
    public class TSINVOIC_S010
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("0070", typeof(EDIFACT_N))]
        [Pos(1)]
        public string SequenceMessageTransferNumber_01 { get; set; }
        [StringLength(1, 1)]
        [DataElement("0073", typeof(EDIFACT_A))]
        [Pos(2)]
        public string FirstLastSequenceMessageTransferIndication_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("TSINVOIC_S009")]
    public class TSINVOIC_S009
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("0065", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string MessageTypeIdentifier_01 { get; set; }
        [Required]
        [StringLength(1, 3)]
        [DataElement("0052", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string MessageTypeVersionNumber_02 { get; set; }
        [Required]
        [StringLength(1, 3)]
        [DataElement("0054", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string MessageTypeReleaseNumber_03 { get; set; }
        [Required]
        [StringLength(1, 3)]
        [DataElement("0051", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string ControllingAgency_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("0057", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string AssociationAssignedCode_05 { get; set; }
        [StringLength(1, 6)]
        [DataElement("0110", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string CodeListDirectoryVersionNumber_06 { get; set; }
        [StringLength(1, 6)]
        [DataElement("0113", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string MessageTypeSubfunctionIdentification_07 { get; set; }
    }
}
