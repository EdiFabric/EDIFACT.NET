namespace EdiFabric.Templates.Edifact
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;

    /// <summary>
    /// Invoice message
    /// </summary>
    [Serializable()]
    [Message("EDIFACT", "D96A", "INVOIC")]
    public class TSINVOIC : EdiMessage
    {

        /// <summary>
        /// Message Header
        /// </summary>
        [Pos(1)]
        public UNH UNH { get; set; }
        /// <summary>
        /// BEGINNING OF MESSAGE
        /// </summary>
        [Required]
        [Pos(2)]
        public BGM BGM { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Required]
        [ListCount(35)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTIONS
        /// </summary>
        [Pos(4)]
        public PAI PAI { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [ListCount(5)]
        [Pos(5)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [Pos(6)]
        public IMD IMD { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [ListCount(10)]
        [Pos(7)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [ListCount(99)]
        [Pos(8)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [ListCount(99)]
        [Pos(9)]
        public List<Loop_NAD_INVOIC> NADLoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [ListCount(5)]
        [Pos(10)]
        public List<Loop_TAX_INVOIC> TAXLoop { get; set; }
        /// <summary>
        /// Loop for CURRENCIES
        /// </summary>
        [ListCount(5)]
        [Pos(11)]
        public List<Loop_CUX_INVOIC> CUXLoop { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [ListCount(10)]
        [Pos(12)]
        public List<Loop_PAT_INVOIC> PATLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [ListCount(10)]
        [Pos(13)]
        public List<Loop_TDT_INVOIC> TDTLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [ListCount(5)]
        [Pos(14)]
        public List<Loop_TOD_INVOIC> TODLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [ListCount(1000)]
        [Pos(15)]
        public List<Loop_PAC_INVOIC> PACLoop { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [ListCount(9999)]
        [Pos(16)]
        public List<Loop_ALC_INVOIC> ALCLoop { get; set; }
        /// <summary>
        /// Loop for REQUIREMENTS AND CONDITIONS
        /// </summary>
        [ListCount(100)]
        [Pos(17)]
        public List<Loop_RCS_INVOIC> RCSLoop { get; set; }
        /// <summary>
        /// Loop for ADJUSTMENT DETAILS
        /// </summary>
        [Pos(18)]
        public Loop_AJT_INVOIC AJTLoop { get; set; }
        /// <summary>
        /// Loop for PARTIES TO INSTRUCTION
        /// </summary>
        [Pos(19)]
        public Loop_INP_INVOIC INPLoop { get; set; }
        /// <summary>
        /// Loop for LINE ITEM
        /// </summary>
        [ListCount(9999999)]
        [Pos(20)]
        public List<Loop_LIN_INVOIC> LINLoop { get; set; }
        /// <summary>
        /// SECTION CONTROL
        /// </summary>
        [Required]
        [Pos(21)]
        public UNS UNS { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [ListCount(10)]
        [Pos(22)]
        public List<CNT> CNT { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [Required]
        [ListCount(100)]
        [Pos(23)]
        public List<Loop_MOA_INVOIC_3> MOALoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [ListCount(10)]
        [Pos(24)]
        public List<Loop_TAX_INVOIC_3> TAXLoop2 { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [ListCount(15)]
        [Pos(25)]
        public List<Loop_ALC_INVOIC_3> ALCLoop2 { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [Pos(26)]
        public UNT UNT { get; set; }
    }

    /// <summary>
    /// Loop for ADJUSTMENT DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(AJT))]
    public class Loop_AJT_INVOIC
    {
        
        /// <summary>
        /// ADJUSTMENT DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public AJT AJT { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC
    {
        
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [Pos(4)]
        public Loop_QTY_INVOIC QTYLoop { get; set; }
        /// <summary>
        /// Loop for PERCENTAGE DETAILS
        /// </summary>
        [Pos(5)]
        public Loop_PCD_INVOIC PCDLoop { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [ListCount(2)]
        [Pos(6)]
        public List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for RATE DETAILS
        /// </summary>
        [Pos(7)]
        public Loop_RTE_INVOIC RTELoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [ListCount(5)]
        [Pos(8)]
        public List<Loop_TAX_INVOIC_2> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC_2
    {
        
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [Pos(4)]
        public Loop_QTY_INVOIC QTYLoop { get; set; }
        /// <summary>
        /// Loop for PERCENTAGE DETAILS
        /// </summary>
        [Pos(5)]
        public Loop_PCD_INVOIC PCDLoop { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [ListCount(2)]
        [Pos(6)]
        public List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for RATE DETAILS
        /// </summary>
        [Pos(7)]
        public Loop_RTE_INVOIC RTELoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [ListCount(5)]
        [Pos(8)]
        public List<Loop_TAX_INVOIC_2> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [Group(typeof(ALC))]
    public class Loop_ALC_INVOIC_3
    {
        
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [Pos(2)]
        public ALI ALI { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [ListCount(2)]
        [Pos(3)]
        public List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [Group(typeof(CTA))]
    public class Loop_CTA_INVOIC
    {
        
        /// <summary>
        /// CONTACT INFORMATION
        /// </summary>
        [Required]
        [Pos(1)]
        public CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for CURRENCIES
    /// </summary>
    [Serializable()]
    [Group(typeof(CUX))]
    public class Loop_CUX_INVOIC
    {
        
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [Required]
        [Pos(1)]
        public CUX CUX { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(DOC))]
    public class Loop_DOC_INVOIC
    {
        
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public DOC DOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [Group(typeof(INP))]
    public class Loop_INP_INVOIC
    {
        
        /// <summary>
        /// PARTIES TO INSTRUCTION
        /// </summary>
        [Required]
        [Pos(1)]
        public INP INP { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for LINE ITEM
    /// </summary>
    [Serializable()]
    [Group(typeof(LIN))]
    public class Loop_LIN_INVOIC
    {
        
        /// <summary>
        /// LINE ITEM
        /// </summary>
        [Required]
        [Pos(1)]
        public LIN LIN { get; set; }
        /// <summary>
        /// ADDITIONAL PRODUCT ID
        /// </summary>
        [ListCount(25)]
        [Pos(2)]
        public List<PIA> PIA { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [ListCount(10)]
        [Pos(3)]
        public List<IMD> IMD { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [ListCount(5)]
        [Pos(4)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [ListCount(5)]
        [Pos(5)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [Pos(6)]
        public PCD PCD { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [ListCount(5)]
        [Pos(7)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(35)]
        [Pos(8)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [ListCount(1000)]
        [Pos(9)]
        public List<GIN> GIN { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [ListCount(1000)]
        [Pos(10)]
        public List<GIR> GIR { get; set; }
        /// <summary>
        /// QUANTITY VARIANCES
        /// </summary>
        [Pos(11)]
        public QVR QVR { get; set; }
        /// <summary>
        /// EQUIPMENT DETAILS
        /// </summary>
        [Pos(12)]
        public EQD EQD { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [ListCount(5)]
        [Pos(13)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [ListCount(5)]
        [Pos(14)]
        public List<Loop_MOA_INVOIC_2> MOALoop { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [ListCount(10)]
        [Pos(15)]
        public List<Loop_PAT_INVOIC_2> PATLoop { get; set; }
        /// <summary>
        /// Loop for PRICE DETAILS
        /// </summary>
        [ListCount(25)]
        [Pos(16)]
        public List<Loop_PRI_INVOIC> PRILoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [ListCount(10)]
        [Pos(17)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [ListCount(10)]
        [Pos(18)]
        public List<Loop_PAC_INVOIC> PACLoop { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [ListCount(9999)]
        [Pos(19)]
        public List<Loop_LOC_INVOIC_2> LOCLoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [ListCount(99)]
        [Pos(20)]
        public List<Loop_TAX_INVOIC> TAXLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [ListCount(20)]
        [Pos(21)]
        public List<Loop_NAD_INVOIC_2> NADLoop { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [ListCount(15)]
        [Pos(22)]
        public List<Loop_ALC_INVOIC_2> ALCLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [ListCount(10)]
        [Pos(23)]
        public List<Loop_TDT_INVOIC_2> TDTLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [ListCount(5)]
        [Pos(24)]
        public List<Loop_TOD_INVOIC> TODLoop { get; set; }
        /// <summary>
        /// Loop for REQUIREMENTS AND CONDITIONS
        /// </summary>
        [ListCount(100)]
        [Pos(25)]
        public List<Loop_RCS_INVOIC> RCSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Group(typeof(LOC))]
    public class Loop_LOC_INVOIC
    {
        
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Group(typeof(LOC))]
    public class Loop_LOC_INVOIC_2
    {
        
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [ListCount(100)]
        [Pos(2)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [Group(typeof(MOA))]
    public class Loop_MOA_INVOIC
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    /// <summary>
    /// Loop for MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [Group(typeof(MOA))]
    public class Loop_MOA_INVOIC_2
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [Pos(2)]
        public CUX CUX { get; set; }
    }
    
    /// <summary>
    /// Loop for MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [Group(typeof(MOA))]
    public class Loop_MOA_INVOIC_3
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [Pos(2)]
        public Loop_RFF_INVOIC RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [Group(typeof(NAD))]
    public class Loop_NAD_INVOIC
    {
        
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [ListCount(25)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// FINANCIAL INSTITUTION INFORMATION
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<FII> FII { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [ListCount(9999)]
        [Pos(4)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [ListCount(5)]
        [Pos(5)]
        public List<Loop_DOC_INVOIC> DOCLoop { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [ListCount(5)]
        [Pos(6)]
        public List<Loop_CTA_INVOIC> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [Group(typeof(NAD))]
    public class Loop_NAD_INVOIC_2
    {
        
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [ListCount(5)]
        [Pos(4)]
        public List<Loop_DOC_INVOIC> DOCLoop { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [ListCount(5)]
        [Pos(5)]
        public List<Loop_CTA_INVOIC> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE
    /// </summary>
    [Serializable()]
    [Group(typeof(PAC))]
    public class Loop_PAC_INVOIC
    {
        
        /// <summary>
        /// PACKAGE
        /// </summary>
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// Loop for PACKAGE IDENTIFICATION
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<Loop_PCI_INVOIC> PCILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PAYMENT TERMS BASIS
    /// </summary>
    [Serializable()]
    [Group(typeof(PAT))]
    public class Loop_PAT_INVOIC
    {
        
        /// <summary>
        /// PAYMENT TERMS BASIS
        /// </summary>
        [Required]
        [Pos(1)]
        public PAT PAT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [Pos(3)]
        public PCD PCD { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [Pos(4)]
        public MOA MOA { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTIONS
        /// </summary>
        [Pos(5)]
        public PAI PAI { get; set; }
        /// <summary>
        /// FINANCIAL INSTITUTION INFORMATION
        /// </summary>
        [Pos(6)]
        public FII FII { get; set; }
    }
    
    /// <summary>
    /// Loop for PAYMENT TERMS BASIS
    /// </summary>
    [Serializable()]
    [Group(typeof(PAT))]
    public class Loop_PAT_INVOIC_2
    {
        
        /// <summary>
        /// PAYMENT TERMS BASIS
        /// </summary>
        [Required]
        [Pos(1)]
        public PAT PAT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [Pos(3)]
        public PCD PCD { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [Pos(4)]
        public MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(PCD))]
    public class Loop_PCD_INVOIC
    {
        
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public PCD PCD { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Group(typeof(PCI))]
    public class Loop_PCI_INVOIC
    {
        
        /// <summary>
        /// PACKAGE IDENTIFICATION
        /// </summary>
        [Required]
        [Pos(1)]
        public PCI PCI { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(2)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [ListCount(5)]
        [Pos(4)]
        public List<GIN> GIN { get; set; }
    }
    
    /// <summary>
    /// Loop for PRICE DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(PRI))]
    public class Loop_PRI_INVOIC
    {
        
        /// <summary>
        /// PRICE DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public PRI PRI { get; set; }
        /// <summary>
        /// ADDITIONAL PRICE INFORMATION
        /// </summary>
        [Pos(2)]
        public APR APR { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [Pos(3)]
        public RNG RNG { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(5)]
        [Pos(4)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for QUANTITY
    /// </summary>
    [Serializable()]
    [Group(typeof(QTY))]
    public class Loop_QTY_INVOIC
    {
        
        /// <summary>
        /// QUANTITY
        /// </summary>
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    /// <summary>
    /// Loop for REQUIREMENTS AND CONDITIONS
    /// </summary>
    [Serializable()]
    [Group(typeof(RCS))]
    public class Loop_RCS_INVOIC
    {
        
        /// <summary>
        /// REQUIREMENTS AND CONDITIONS
        /// </summary>
        [Required]
        [Pos(1)]
        public RCS RCS { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<RFF> RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [ListCount(5)]
        [Pos(4)]
        public List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [Group(typeof(RFF))]
    public class Loop_RFF_INVOIC
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for RATE DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(RTE))]
    public class Loop_RTE_INVOIC
    {
        
        /// <summary>
        /// RATE DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public RTE RTE { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    /// <summary>
    /// Loop for DUTY/TAX/FEE DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(TAX))]
    public class Loop_TAX_INVOIC
    {
        
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [Pos(2)]
        public MOA MOA { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [ListCount(5)]
        [Pos(3)]
        public List<LOC> LOC { get; set; }
    }
    
    /// <summary>
    /// Loop for DUTY/TAX/FEE DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(TAX))]
    public class Loop_TAX_INVOIC_2
    {
        
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [Pos(2)]
        public MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for DUTY/TAX/FEE DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(TAX))]
    public class Loop_TAX_INVOIC_3
    {
        
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [ListCount(2)]
        [Pos(2)]
        public List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for DETAILS OF TRANSPORT
    /// </summary>
    [Serializable()]
    [Group(typeof(TDT))]
    public class Loop_TDT_INVOIC
    {
        
        /// <summary>
        /// DETAILS OF TRANSPORT
        /// </summary>
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [ListCount(10)]
        [Pos(2)]
        public List<Loop_LOC_INVOIC> LOCLoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [ListCount(9999)]
        [Pos(3)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for DETAILS OF TRANSPORT
    /// </summary>
    [Serializable()]
    [Group(typeof(TDT))]
    public class Loop_TDT_INVOIC_2
    {
        
        /// <summary>
        /// DETAILS OF TRANSPORT
        /// </summary>
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [ListCount(10)]
        [Pos(2)]
        public List<Loop_LOC_INVOIC> LOCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [Group(typeof(TOD))]
    public class Loop_TOD_INVOIC
    {
        
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [Required]
        [Pos(1)]
        public TOD TOD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [ListCount(2)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
    }
}
