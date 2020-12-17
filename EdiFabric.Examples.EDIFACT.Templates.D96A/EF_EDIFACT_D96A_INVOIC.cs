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
    /// Loop for ADJUSTMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AJT))]
    public class Loop_AJT_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ADJUSTMENT DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AJT AJT { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_QTY_INVOIC QTYLoop { get; set; }
        /// <summary>
        /// Loop for PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_PCD_INVOIC PCDLoop { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for RATE DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_RTE_INVOIC RTELoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<Loop_TAX_INVOIC_2> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_QTY_INVOIC QTYLoop { get; set; }
        /// <summary>
        /// Loop for PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_PCD_INVOIC PCDLoop { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for RATE DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_RTE_INVOIC RTELoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<Loop_TAX_INVOIC_2> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ALI ALI { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_CTA_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for CURRENCIES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CUX))]
    public class Loop_CUX_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CUX CUX { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DOC))]
    public class Loop_DOC_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DOC DOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(INP))]
    public class Loop_INP_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PARTIES TO INSTRUCTION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual INP INP { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for LINE ITEM
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// LINE ITEM
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// ADDITIONAL PRODUCT ID
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(2)]
        public virtual List<PIA> PIA { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<IMD> IMD { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PCD PCD { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(35)]
        [Pos(8)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(9)]
        public virtual List<GIN> GIN { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(10)]
        public virtual List<GIR> GIR { get; set; }
        /// <summary>
        /// QUANTITY VARIANCES
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual QVR QVR { get; set; }
        /// <summary>
        /// EQUIPMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual EQD EQD { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(13)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(14)]
        public virtual List<Loop_MOA_INVOIC_2> MOALoop { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<Loop_PAT_INVOIC_2> PATLoop { get; set; }
        /// <summary>
        /// Loop for PRICE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(16)]
        public virtual List<Loop_PRI_INVOIC> PRILoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(17)]
        public virtual List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(18)]
        public virtual List<Loop_PAC_INVOIC> PACLoop { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(19)]
        public virtual List<Loop_LOC_INVOIC_2> LOCLoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(20)]
        public virtual List<Loop_TAX_INVOIC> TAXLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(21)]
        public virtual List<Loop_NAD_INVOIC_2> NADLoop { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(22)]
        public virtual List<Loop_ALC_INVOIC_2> ALCLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(23)]
        public virtual List<Loop_TDT_INVOIC_2> TDTLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(24)]
        public virtual List<Loop_TOD_INVOIC> TODLoop { get; set; }
        /// <summary>
        /// Loop for REQUIREMENTS AND CONDITIONS
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(25)]
        public virtual List<Loop_RCS_INVOIC> RCSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LOC))]
    public class Loop_LOC_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LOC))]
    public class Loop_LOC_INVOIC_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MOA))]
    public class Loop_MOA_INVOIC
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
        public virtual MOA MOA { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RNG RNG { get; set; }
    }
    
    /// <summary>
    /// Loop for MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MOA))]
    public class Loop_MOA_INVOIC_2
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
        public virtual MOA MOA { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUX CUX { get; set; }
    }
    
    /// <summary>
    /// Loop for MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MOA))]
    public class Loop_MOA_INVOIC_3
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
        public virtual MOA MOA { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_RFF_INVOIC RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NAD NAD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(2)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// FINANCIAL INSTITUTION INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<FII> FII { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_DOC_INVOIC> DOCLoop { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_CTA_INVOIC> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_INVOIC_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NAD NAD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<Loop_DOC_INVOIC> DOCLoop { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_CTA_INVOIC> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAC))]
    public class Loop_PAC_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PACKAGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAC PAC { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Loop for PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<Loop_PCI_INVOIC> PCILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PAYMENT TERMS BASIS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAT))]
    public class Loop_PAT_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAT PAT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PCD PCD { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MOA MOA { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PAI PAI { get; set; }
        /// <summary>
        /// FINANCIAL INSTITUTION INFORMATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual FII FII { get; set; }
    }
    
    /// <summary>
    /// Loop for PAYMENT TERMS BASIS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAT))]
    public class Loop_PAT_INVOIC_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAT PAT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PCD PCD { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCD))]
    public class Loop_PCD_INVOIC
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
        public virtual PCD PCD { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RNG RNG { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCI))]
    public class Loop_PCI_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PCI PCI { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<GIN> GIN { get; set; }
    }
    
    /// <summary>
    /// Loop for PRICE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PRI))]
    public class Loop_PRI_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PRI PRI { get; set; }
        /// <summary>
        /// ADDITIONAL PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual APR APR { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual RNG RNG { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for QUANTITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RNG RNG { get; set; }
    }
    
    /// <summary>
    /// Loop for REQUIREMENTS AND CONDITIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RCS))]
    public class Loop_RCS_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REQUIREMENTS AND CONDITIONS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RCS RCS { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_INVOIC
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
        public virtual RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for RATE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RTE))]
    public class Loop_RTE_INVOIC
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
        public virtual RTE RTE { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RNG RNG { get; set; }
    }
    
    /// <summary>
    /// Loop for DUTY/TAX/FEE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TAX))]
    public class Loop_TAX_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MOA MOA { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<LOC> LOC { get; set; }
    }
    
    /// <summary>
    /// Loop for DUTY/TAX/FEE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TAX))]
    public class Loop_TAX_INVOIC_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for DUTY/TAX/FEE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TAX))]
    public class Loop_TAX_INVOIC_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for DETAILS OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TDT))]
    public class Loop_TDT_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TDT TDT { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Loop_LOC_INVOIC> LOCLoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<Loop_RFF_INVOIC> RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for DETAILS OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TDT))]
    public class Loop_TDT_INVOIC_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TDT TDT { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Loop_LOC_INVOIC> LOCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TOD))]
    public class Loop_TOD_INVOIC
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TOD TOD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<LOC> LOC { get; set; }
    }
    
    /// <summary>
    /// Invoice message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D96A", "INVOIC")]
    public class TSINVOIC : EdiMessage
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Message Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual UNH UNH { get; set; }
        /// <summary>
        /// BEGINNING OF MESSAGE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGM BGM { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(35)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PAI PAI { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual IMD IMD { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(9)]
        public virtual List<Loop_NAD_INVOIC> NADLoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<Loop_TAX_INVOIC> TAXLoop { get; set; }
        /// <summary>
        /// Loop for CURRENCIES
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<Loop_CUX_INVOIC> CUXLoop { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<Loop_PAT_INVOIC> PATLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public virtual List<Loop_TDT_INVOIC> TDTLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(14)]
        public virtual List<Loop_TOD_INVOIC> TODLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(15)]
        public virtual List<Loop_PAC_INVOIC> PACLoop { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(16)]
        public virtual List<Loop_ALC_INVOIC> ALCLoop { get; set; }
        /// <summary>
        /// Loop for REQUIREMENTS AND CONDITIONS
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(17)]
        public virtual List<Loop_RCS_INVOIC> RCSLoop { get; set; }
        /// <summary>
        /// Loop for ADJUSTMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual Loop_AJT_INVOIC AJTLoop { get; set; }
        /// <summary>
        /// Loop for PARTIES TO INSTRUCTION
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual Loop_INP_INVOIC INPLoop { get; set; }
        /// <summary>
        /// Loop for LINE ITEM
        /// </summary>
        [DataMember]
        [ListCount(9999999)]
        [Pos(20)]
        public virtual List<Loop_LIN_INVOIC> LINLoop { get; set; }
        /// <summary>
        /// SECTION CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(21)]
        public virtual UNS UNS { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(22)]
        public virtual List<CNT> CNT { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(23)]
        public virtual List<Loop_MOA_INVOIC_3> MOALoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(24)]
        public virtual List<Loop_TAX_INVOIC_3> TAXLoop2 { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(25)]
        public virtual List<Loop_ALC_INVOIC_3> ALCLoop2 { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual UNT UNT { get; set; }
    }
}
