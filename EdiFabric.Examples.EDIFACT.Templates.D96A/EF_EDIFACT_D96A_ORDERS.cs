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
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ALC))]
    public class Loop_ALC_ORDERS
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
        public virtual Loop_QTY_ORDERS_2 QTYLoop { get; set; }
        /// <summary>
        /// Loop for PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_PCD_ORDERS PCDLoop { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<Loop_MOA_ORDERS> MOALoop { get; set; }
        /// <summary>
        /// Loop for RATE DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_RTE_ORDERS RTELoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<Loop_TAX_ORDERS_2> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ALC))]
    public class Loop_ALC_ORDERS_2
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
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for ADDITIONAL PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(APR))]
    public class Loop_APR_ORDERS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ADDITIONAL PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual APR APR { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual RNG RNG { get; set; }
    }
    
    /// <summary>
    /// Loop for CHARACTERISTIC/CLASS ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CCI))]
    public class Loop_CCI_ORDERS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CHARACTERISTIC/CLASS ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CCI CCI { get; set; }
        /// <summary>
        /// CHARACTERISTIC VALUE
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<CAV> CAV { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_CTA_ORDERS
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
    public class Loop_CUX_ORDERS
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
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<PCD> PCD { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DOC))]
    public class Loop_DOC_ORDERS
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
    /// Loop for EQUIPMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EQD))]
    public class Loop_EQD_ORDERS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// EQUIPMENT DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EQD EQD { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<HAN> HAN { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for LINE ITEM
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public partial class Loop_LIN_ORDERS
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
        [ListCount(99)]
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
        [ListCount(10)]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<PCD> PCD { get; set; }
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
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(10)]
        public virtual List<GIN> GIN { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(11)]
        public virtual List<GIR> GIR { get; set; }
        /// <summary>
        /// QUANTITY VARIANCES
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual QVR QVR { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(13)]
        public virtual List<DOC> DOC { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual PAI PAI { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(15)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for CHARACTERISTIC/CLASS ID
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(16)]
        public virtual List<Loop_CCI_ORDERS> CCILoop { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(17)]
        public virtual List<Loop_PAT_ORDERS> PATLoop { get; set; }
        /// <summary>
        /// Loop for PRICE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(18)]
        public virtual List<Loop_PRI_ORDERS> PRILoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(19)]
        public virtual List<Loop_RFF_ORDERS> RFFLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(20)]
        public virtual List<Loop_PAC_ORDERS_2> PACLoop { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(21)]
        public virtual List<Loop_LOC_ORDERS_2> LOCLoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(22)]
        public virtual List<Loop_TAX_ORDERS> TAXLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(23)]
        public virtual List<Loop_NAD_ORDERS_2> NADLoop { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(24)]
        public virtual List<Loop_ALC_ORDERS> ALCLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(25)]
        public virtual List<Loop_TDT_ORDERS> TDTLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(26)]
        public virtual List<Loop_TOD_ORDERS> TODLoop { get; set; }
        /// <summary>
        /// Loop for EQUIPMENT DETAILS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(27)]
        public virtual List<Loop_EQD_ORDERS> EQDLoop { get; set; }
        /// <summary>
        /// Loop for SCHEDULING CONDITIONS
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(28)]
        public virtual List<Loop_SCC_ORDERS> SCCLoop { get; set; }
        /// <summary>
        /// Loop for REQUIREMENTS AND CONDITIONS
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(29)]
        public virtual List<Loop_RCS_ORDERS> RCSLoop { get; set; }
        /// <summary>
        /// Loop for STAGES
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(30)]
        public virtual List<Loop_STG_ORDERS> STGLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LOC))]
    public class Loop_LOC_ORDERS
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
    public class Loop_LOC_ORDERS_2
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
        [Pos(2)]
        public virtual QTY QTY { get; set; }
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
    public class Loop_MOA_ORDERS
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
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_ORDERS
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
        [ListCount(10)]
        [Pos(4)]
        public virtual List<Loop_RFF_ORDERS> RFFLoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_DOC_ORDERS> DOCLoop { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_CTA_ORDERS> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_ORDERS_2
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
        public virtual List<Loop_RFF_ORDERS> RFFLoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<Loop_DOC_ORDERS> DOCLoop { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_CTA_ORDERS> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAC))]
    public class Loop_PAC_ORDERS
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
        public virtual List<Loop_PCI_ORDERS> PCILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAC))]
    public class Loop_PAC_ORDERS_2
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
        /// QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_RFF_ORDERS RFFLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_PCI_ORDERS> PCILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PAYMENT TERMS BASIS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAT))]
    public class Loop_PAT_ORDERS
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
    public class Loop_PCD_ORDERS
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
    public class Loop_PCI_ORDERS
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
        [ListCount(10)]
        [Pos(4)]
        public virtual List<GIN> GIN { get; set; }
    }
    
    /// <summary>
    /// Loop for PRICE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PRI))]
    public class Loop_PRI_ORDERS
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
        /// CURRENCIES
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUX CUX { get; set; }
        /// <summary>
        /// ADDITIONAL PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual APR APR { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual RNG RNG { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for QUANTITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_ORDERS
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
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for QUANTITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_ORDERS_2
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
    /// Loop for QUANTITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_ORDERS_3
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
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for REQUIREMENTS AND CONDITIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RCS))]
    public class Loop_RCS_ORDERS
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
    public class Loop_RFF_ORDERS
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
    public class Loop_RTE_ORDERS
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
    /// Loop for SCHEDULING CONDITIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCC))]
    public class Loop_SCC_ORDERS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// SCHEDULING CONDITIONS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SCC SCC { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<Loop_QTY_ORDERS> QTYLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for STAGES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(STG))]
    public class Loop_STG_ORDERS
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// STAGES
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual STG STG { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<Loop_QTY_ORDERS_3> QTYLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for DUTY/TAX/FEE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TAX))]
    public class Loop_TAX_ORDERS
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
    public class Loop_TAX_ORDERS_2
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
    /// Loop for DETAILS OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TDT))]
    public class Loop_TDT_ORDERS
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
        public virtual List<Loop_LOC_ORDERS> LOCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TOD))]
    public class Loop_TOD_ORDERS
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
    /// Purchase order message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERS : EdiMessage
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
        [ListCount(99)]
        [Pos(7)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<Loop_RFF_ORDERS> RFFLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(9)]
        public virtual List<Loop_NAD_ORDERS> NADLoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<Loop_TAX_ORDERS> TAXLoop { get; set; }
        /// <summary>
        /// Loop for CURRENCIES
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<Loop_CUX_ORDERS> CUXLoop { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<Loop_PAT_ORDERS> PATLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public virtual List<Loop_TDT_ORDERS> TDTLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(14)]
        public virtual List<Loop_TOD_ORDERS> TODLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<Loop_PAC_ORDERS> PACLoop { get; set; }
        /// <summary>
        /// Loop for EQUIPMENT DETAILS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(16)]
        public virtual List<Loop_EQD_ORDERS> EQDLoop { get; set; }
        /// <summary>
        /// Loop for SCHEDULING CONDITIONS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(17)]
        public virtual List<Loop_SCC_ORDERS> SCCLoop { get; set; }
        /// <summary>
        /// Loop for ADDITIONAL PRICE INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(18)]
        public virtual List<Loop_APR_ORDERS> APRLoop { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(19)]
        public virtual List<Loop_ALC_ORDERS> ALCLoop { get; set; }
        /// <summary>
        /// Loop for REQUIREMENTS AND CONDITIONS
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(20)]
        public virtual List<Loop_RCS_ORDERS> RCSLoop { get; set; }
        /// <summary>
        /// Loop for LINE ITEM
        /// </summary>
        [Splitter]
        [DataMember]
        [ListCount(200000)]
        [Pos(21)]
        public virtual List<Loop_LIN_ORDERS> LINLoop { get; set; }
        /// <summary>
        /// SECTION CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(22)]
        public virtual UNS UNS { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(23)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(24)]
        public virtual List<CNT> CNT { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(25)]
        public virtual List<Loop_ALC_ORDERS_2> ALCLoop2 { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual UNT UNT { get; set; }
    }
}
