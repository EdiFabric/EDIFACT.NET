namespace EdiFabric.Rules.EDIFACT_D00A
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using EdiFabric.Attributes;
    
    
    [M("EDIFACT", "D00A", "INVOIC")]
    public class TSINVOIC
    {
        
        /// <summary>
        /// Message Header
        /// </summary>
        [S("UNH", 1)]
        public UNH UNH { get; set; }
        /// <summary>
        /// BEGINNING OF MESSAGE
        /// </summary>
        [S("BGM", 2)]
        public BGM BGM { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTIONS
        /// </summary>
        [S("PAI", 4)]
        public PAI PAI { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [S("ALI", 5)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [S("IMD", 6)]
        public IMD IMD { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [S("FTX", 7)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 8)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// GENERAL INDICATOR
        /// </summary>
        [S("GIS", 9)]
        public List<GIS> GIS { get; set; }
        /// <summary>
        /// DANGEROUS GOODS
        /// </summary>
        [S("DGS", 10)]
        public DGS DGS { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [S("GIR", 11)]
        public List<GIR> GIR { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [G(12)]
        public List<TSINVOIC_RFFLoop1> RFFLoop1 { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [G(13)]
        public List<TSINVOIC_NADLoop1> NADLoop1 { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [G(14)]
        public List<TSINVOIC_TAXLoop1> TAXLoop1 { get; set; }
        /// <summary>
        /// Loop for CURRENCIES
        /// </summary>
        [G(15)]
        public List<TSINVOIC_CUXLoop1> CUXLoop1 { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [G(16)]
        public List<TSINVOIC_PATLoop1> PATLoop1 { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [G(17)]
        public List<TSINVOIC_TDTLoop1> TDTLoop1 { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [G(18)]
        public List<TSINVOIC_TODLoop1> TODLoop1 { get; set; }
        /// <summary>
        /// Loop for EQUIPMENT DETAILS
        /// </summary>
        [G(19)]
        public List<TSINVOIC_EQDLoop1> EQDLoop1 { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [G(20)]
        public List<TSINVOIC_PACLoop1> PACLoop1 { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [G(21)]
        public List<TSINVOIC_ALCLoop1> ALCLoop1 { get; set; }
        /// <summary>
        /// Loop for REQUIREMENTS AND CONDITIONS
        /// </summary>
        [G(22)]
        public List<TSINVOIC_RCSLoop1> RCSLoop1 { get; set; }
        /// <summary>
        /// Loop for ADJUSTMENT DETAILS
        /// </summary>
        [G(23)]
        public TSINVOIC_AJTLoop1 AJTLoop1 { get; set; }
        /// <summary>
        /// Loop for PARTIES AND INSTRUCTION
        /// </summary>
        [G(24)]
        public TSINVOIC_INPLoop1 INPLoop1 { get; set; }
        /// <summary>
        /// Loop for LINE ITEM
        /// </summary>
        [G(25)]
        public List<TSINVOIC_LINLoop1> LINLoop1 { get; set; }
        /// <summary>
        /// SECTION CONTROL
        /// </summary>
        [S("UNS", 26)]
        public UNS UNS { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [S("CNT", 27)]
        public List<CNT> CNT { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [G(28)]
        public List<TSINVOIC_MOALoop4> MOALoop4 { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [G(29)]
        public List<TSINVOIC_TAXLoop5> TAXLoop5 { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [G(30)]
        public List<TSINVOIC_ALCLoop3> ALCLoop3 { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [S("UNT", 31)]
        public UNT UNT { get; set; }
    }
    
    public class TSINVOIC_ALCLoop3
    {
        
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [S("ALC", 1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [S("ALI", 2)]
        public ALI ALI { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 3)]
        public List<MOA> MOA { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [S("FTX", 4)]
        public FTX FTX { get; set; }
    }
    
    public class TSINVOIC_TAXLoop5
    {
        
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [S("TAX", 1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 2)]
        public List<MOA> MOA { get; set; }
    }
    
    public class TSINVOIC_MOALoop4
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 1)]
        public MOA MOA { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [G(2)]
        public TSINVOIC_RFFLoop7 RFFLoop7 { get; set; }
    }
    
    public class TSINVOIC_RFFLoop7
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_LINLoop1
    {
        
        /// <summary>
        /// LINE ITEM
        /// </summary>
        [S("LIN", 1)]
        public LIN LIN { get; set; }
        /// <summary>
        /// ADDITIONAL PRODUCT ID
        /// </summary>
        [S("PIA", 2)]
        public List<PIA> PIA { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [S("IMD", 3)]
        public List<IMD> IMD { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [S("MEA", 4)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [S("QTY", 5)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [S("PCD", 6)]
        public PCD PCD { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [S("ALI", 7)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 8)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [S("GIN", 9)]
        public List<GIN> GIN { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [S("GIR", 10)]
        public List<GIR> GIR { get; set; }
        /// <summary>
        /// QUANTITY VARIANCES
        /// </summary>
        [S("QVR", 11)]
        public QVR QVR { get; set; }
        /// <summary>
        /// EQUIPMENT DETAILS
        /// </summary>
        [S("EQD", 12)]
        public EQD EQD { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [S("FTX", 13)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// DANGEROUS GOODS
        /// </summary>
        [S("DGS", 14)]
        public DGS DGS { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [G(15)]
        public List<TSINVOIC_MOALoop2> MOALoop2 { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [G(16)]
        public List<TSINVOIC_PATLoop2> PATLoop2 { get; set; }
        /// <summary>
        /// Loop for PRICE DETAILS
        /// </summary>
        [G(17)]
        public List<TSINVOIC_PRILoop1> PRILoop1 { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [G(18)]
        public List<TSINVOIC_RFFLoop5> RFFLoop5 { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [G(19)]
        public List<TSINVOIC_PACLoop2> PACLoop2 { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [G(20)]
        public List<TSINVOIC_LOCLoop2> LOCLoop2 { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [G(21)]
        public List<TSINVOIC_TAXLoop3> TAXLoop3 { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [G(22)]
        public List<TSINVOIC_NADLoop2> NADLoop2 { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [G(23)]
        public List<TSINVOIC_ALCLoop2> ALCLoop2 { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [G(24)]
        public List<TSINVOIC_TDTLoop2> TDTLoop2 { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [G(25)]
        public List<TSINVOIC_TODLoop2> TODLoop2 { get; set; }
        /// <summary>
        /// Loop for REQUIREMENTS AND CONDITIONS
        /// </summary>
        [G(26)]
        public List<TSINVOIC_RCSLoop2> RCSLoop2 { get; set; }
        /// <summary>
        /// Loop for GENERAL INDICATOR
        /// </summary>
        [G(27)]
        public List<TSINVOIC_GISLoop1> GISLoop1 { get; set; }
    }
    
    public class TSINVOIC_GISLoop1
    {
        
        /// <summary>
        /// GENERAL INDICATOR
        /// </summary>
        [S("GIS", 1)]
        public GIS GIS { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 2)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [S("GIR", 4)]
        public List<GIR> GIR { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 5)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [S("MEA", 6)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [S("QTY", 7)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [S("FTX", 8)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 9)]
        public List<MOA> MOA { get; set; }
    }
    
    public class TSINVOIC_RCSLoop2
    {
        
        /// <summary>
        /// REQUIREMENTS AND CONDITIONS
        /// </summary>
        [S("RCS", 1)]
        public RCS RCS { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 2)]
        public List<RFF> RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [S("FTX", 4)]
        public List<FTX> FTX { get; set; }
    }
    
    public class TSINVOIC_TODLoop2
    {
        
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [S("TOD", 1)]
        public TOD TOD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 2)]
        public List<LOC> LOC { get; set; }
    }
    
    public class TSINVOIC_TDTLoop2
    {
        
        /// <summary>
        /// DETAILS OF TRANSPORT
        /// </summary>
        [S("TDT", 1)]
        public TDT TDT { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [G(2)]
        public List<TSINVOIC_LOCLoop3> LOCLoop3 { get; set; }
    }
    
    public class TSINVOIC_LOCLoop3
    {
        
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 1)]
        public LOC LOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_ALCLoop2
    {
        
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [S("ALC", 1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [S("ALI", 2)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [S("FTX", 4)]
        public FTX FTX { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [G(5)]
        public TSINVOIC_QTYLoop2 QTYLoop2 { get; set; }
        /// <summary>
        /// Loop for PERCENTAGE DETAILS
        /// </summary>
        [G(6)]
        public TSINVOIC_PCDLoop2 PCDLoop2 { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [G(7)]
        public List<TSINVOIC_MOALoop3> MOALoop3 { get; set; }
        /// <summary>
        /// Loop for RATE DETAILS
        /// </summary>
        [G(8)]
        public TSINVOIC_RTELoop2 RTELoop2 { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [G(9)]
        public List<TSINVOIC_TAXLoop4> TAXLoop4 { get; set; }
    }
    
    public class TSINVOIC_TAXLoop4
    {
        
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [S("TAX", 1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 2)]
        public List<MOA> MOA { get; set; }
    }
    
    public class TSINVOIC_RTELoop2
    {
        
        /// <summary>
        /// RATE DETAILS
        /// </summary>
        [S("RTE", 1)]
        public RTE RTE { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [S("RNG", 2)]
        public RNG RNG { get; set; }
    }
    
    public class TSINVOIC_MOALoop3
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 1)]
        public MOA MOA { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [S("RNG", 2)]
        public RNG RNG { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [S("CUX", 3)]
        public CUX CUX { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 4)]
        public DTM DTM { get; set; }
    }
    
    public class TSINVOIC_PCDLoop2
    {
        
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [S("PCD", 1)]
        public PCD PCD { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [S("RNG", 2)]
        public RNG RNG { get; set; }
    }
    
    public class TSINVOIC_QTYLoop2
    {
        
        /// <summary>
        /// QUANTITY
        /// </summary>
        [S("QTY", 1)]
        public QTY QTY { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [S("RNG", 2)]
        public RNG RNG { get; set; }
    }
    
    public class TSINVOIC_NADLoop2
    {
        
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [S("NAD", 1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 2)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// FINANCIAL INSTITUTION INFORMATION
        /// </summary>
        [S("FII", 3)]
        public List<FII> FII { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [G(4)]
        public List<TSINVOIC_RFFLoop6> RFFLoop6 { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [G(5)]
        public List<TSINVOIC_DOCLoop2> DOCLoop2 { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [G(6)]
        public List<TSINVOIC_CTALoop2> CTALoop2 { get; set; }
    }
    
    public class TSINVOIC_CTALoop2
    {
        
        /// <summary>
        /// CONTACT INFORMATION
        /// </summary>
        [S("CTA", 1)]
        public CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [S("COM", 2)]
        public List<COM> COM { get; set; }
    }
    
    public class TSINVOIC_DOCLoop2
    {
        
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [S("DOC", 1)]
        public DOC DOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_RFFLoop6
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_TAXLoop3
    {
        
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [S("TAX", 1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 2)]
        public List<MOA> MOA { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 3)]
        public List<LOC> LOC { get; set; }
    }
    
    public class TSINVOIC_LOCLoop2
    {
        
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 1)]
        public LOC LOC { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [S("QTY", 2)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 3)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_PACLoop2
    {
        
        /// <summary>
        /// PACKAGE
        /// </summary>
        [S("PAC", 1)]
        public PAC PAC { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [S("MEA", 2)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// EQUIPMENT DETAILS
        /// </summary>
        [S("EQD", 3)]
        public EQD EQD { get; set; }
        /// <summary>
        /// Loop for PACKAGE IDENTIFICATION
        /// </summary>
        [G(4)]
        public List<TSINVOIC_PCILoop2> PCILoop2 { get; set; }
    }
    
    public class TSINVOIC_PCILoop2
    {
        
        /// <summary>
        /// PACKAGE IDENTIFICATION
        /// </summary>
        [S("PCI", 1)]
        public PCI PCI { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 2)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [S("GIN", 4)]
        public List<GIN> GIN { get; set; }
    }
    
    public class TSINVOIC_RFFLoop5
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_PRILoop1
    {
        
        /// <summary>
        /// PRICE DETAILS
        /// </summary>
        [S("PRI", 1)]
        public PRI PRI { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [S("CUX", 2)]
        public CUX CUX { get; set; }
        /// <summary>
        /// ADDITIONAL PRICE INFORMATION
        /// </summary>
        [S("APR", 3)]
        public APR APR { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [S("RNG", 4)]
        public RNG RNG { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 5)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_PATLoop2
    {
        
        /// <summary>
        /// PAYMENT TERMS BASIS
        /// </summary>
        [S("PAT", 1)]
        public PAT PAT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [S("PCD", 3)]
        public List<PCD> PCD { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 4)]
        public MOA MOA { get; set; }
    }
    
    public class TSINVOIC_MOALoop2
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 1)]
        public MOA MOA { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [S("CUX", 2)]
        public CUX CUX { get; set; }
    }
    
    public class TSINVOIC_INPLoop1
    {
        
        /// <summary>
        /// PARTIES AND INSTRUCTION
        /// </summary>
        [S("INP", 1)]
        public INP INP { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [S("FTX", 2)]
        public List<FTX> FTX { get; set; }
    }
    
    public class TSINVOIC_AJTLoop1
    {
        
        /// <summary>
        /// ADJUSTMENT DETAILS
        /// </summary>
        [S("AJT", 1)]
        public AJT AJT { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [S("FTX", 2)]
        public List<FTX> FTX { get; set; }
    }
    
    public class TSINVOIC_RCSLoop1
    {
        
        /// <summary>
        /// REQUIREMENTS AND CONDITIONS
        /// </summary>
        [S("RCS", 1)]
        public RCS RCS { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 2)]
        public List<RFF> RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [S("FTX", 4)]
        public List<FTX> FTX { get; set; }
    }
    
    public class TSINVOIC_ALCLoop1
    {
        
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [S("ALC", 1)]
        public ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [S("ALI", 2)]
        public List<ALI> ALI { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [S("FTX", 3)]
        public FTX FTX { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [G(4)]
        public List<TSINVOIC_RFFLoop4> RFFLoop4 { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [G(5)]
        public TSINVOIC_QTYLoop1 QTYLoop1 { get; set; }
        /// <summary>
        /// Loop for PERCENTAGE DETAILS
        /// </summary>
        [G(6)]
        public TSINVOIC_PCDLoop1 PCDLoop1 { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [G(7)]
        public List<TSINVOIC_MOALoop1> MOALoop1 { get; set; }
        /// <summary>
        /// Loop for RATE DETAILS
        /// </summary>
        [G(8)]
        public TSINVOIC_RTELoop1 RTELoop1 { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [G(9)]
        public List<TSINVOIC_TAXLoop2> TAXLoop2 { get; set; }
    }
    
    public class TSINVOIC_TAXLoop2
    {
        
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [S("TAX", 1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 2)]
        public MOA MOA { get; set; }
    }
    
    public class TSINVOIC_RTELoop1
    {
        
        /// <summary>
        /// RATE DETAILS
        /// </summary>
        [S("RTE", 1)]
        public RTE RTE { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [S("RNG", 2)]
        public RNG RNG { get; set; }
    }
    
    public class TSINVOIC_MOALoop1
    {
        
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 1)]
        public MOA MOA { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [S("RNG", 2)]
        public RNG RNG { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [S("CUX", 3)]
        public CUX CUX { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 4)]
        public DTM DTM { get; set; }
    }
    
    public class TSINVOIC_PCDLoop1
    {
        
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [S("PCD", 1)]
        public PCD PCD { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [S("RNG", 2)]
        public RNG RNG { get; set; }
    }
    
    public class TSINVOIC_QTYLoop1
    {
        
        /// <summary>
        /// QUANTITY
        /// </summary>
        [S("QTY", 1)]
        public QTY QTY { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [S("RNG", 2)]
        public RNG RNG { get; set; }
    }
    
    public class TSINVOIC_RFFLoop4
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_PACLoop1
    {
        
        /// <summary>
        /// PACKAGE
        /// </summary>
        [S("PAC", 1)]
        public PAC PAC { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [S("MEA", 2)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// EQUIPMENT DETAILS
        /// </summary>
        [S("EQD", 3)]
        public EQD EQD { get; set; }
        /// <summary>
        /// Loop for PACKAGE IDENTIFICATION
        /// </summary>
        [G(4)]
        public List<TSINVOIC_PCILoop1> PCILoop1 { get; set; }
    }
    
    public class TSINVOIC_PCILoop1
    {
        
        /// <summary>
        /// PACKAGE IDENTIFICATION
        /// </summary>
        [S("PCI", 1)]
        public PCI PCI { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 2)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [S("GIN", 4)]
        public List<GIN> GIN { get; set; }
    }
    
    public class TSINVOIC_EQDLoop1
    {
        
        /// <summary>
        /// EQUIPMENT DETAILS
        /// </summary>
        [S("EQD", 1)]
        public EQD EQD { get; set; }
        /// <summary>
        /// SEAL NUMBER
        /// </summary>
        [S("SEL", 2)]
        public List<SEL> SEL { get; set; }
    }
    
    public class TSINVOIC_TODLoop1
    {
        
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [S("TOD", 1)]
        public TOD TOD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 2)]
        public List<LOC> LOC { get; set; }
    }
    
    public class TSINVOIC_TDTLoop1
    {
        
        /// <summary>
        /// DETAILS OF TRANSPORT
        /// </summary>
        [S("TDT", 1)]
        public TDT TDT { get; set; }
        /// <summary>
        /// TRANSPORT SERVICE REQUIREMENTS
        /// </summary>
        [S("TSR", 2)]
        public TSR TSR { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [G(3)]
        public List<TSINVOIC_LOCLoop1> LOCLoop1 { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [G(4)]
        public List<TSINVOIC_RFFLoop3> RFFLoop3 { get; set; }
    }
    
    public class TSINVOIC_RFFLoop3
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_LOCLoop1
    {
        
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 1)]
        public LOC LOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_PATLoop1
    {
        
        /// <summary>
        /// PAYMENT TERMS BASIS
        /// </summary>
        [S("PAT", 1)]
        public PAT PAT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [S("PCD", 3)]
        public PCD PCD { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 4)]
        public MOA MOA { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTIONS
        /// </summary>
        [S("PAI", 5)]
        public PAI PAI { get; set; }
        /// <summary>
        /// FINANCIAL INSTITUTION INFORMATION
        /// </summary>
        [S("FII", 6)]
        public FII FII { get; set; }
    }
    
    public class TSINVOIC_CUXLoop1
    {
        
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [S("CUX", 1)]
        public CUX CUX { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_TAXLoop1
    {
        
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [S("TAX", 1)]
        public TAX TAX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 2)]
        public MOA MOA { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 3)]
        public List<LOC> LOC { get; set; }
    }
    
    public class TSINVOIC_NADLoop1
    {
        
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [S("NAD", 1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 2)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// FINANCIAL INSTITUTION INFORMATION
        /// </summary>
        [S("FII", 3)]
        public List<FII> FII { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 4)]
        public List<MOA> MOA { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [G(5)]
        public List<TSINVOIC_RFFLoop2> RFFLoop2 { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [G(6)]
        public List<TSINVOIC_DOCLoop1> DOCLoop1 { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [G(7)]
        public List<TSINVOIC_CTALoop1> CTALoop1 { get; set; }
    }
    
    public class TSINVOIC_CTALoop1
    {
        
        /// <summary>
        /// CONTACT INFORMATION
        /// </summary>
        [S("CTA", 1)]
        public CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [S("COM", 2)]
        public List<COM> COM { get; set; }
    }
    
    public class TSINVOIC_DOCLoop1
    {
        
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [S("DOC", 1)]
        public DOC DOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_RFFLoop2
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
    }
    
    public class TSINVOIC_RFFLoop1
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [S("RFF", 1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [S("DTM", 2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [S("GIR", 3)]
        public List<GIR> GIR { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [S("LOC", 4)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [S("MEA", 5)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [S("QTY", 6)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [S("FTX", 7)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [S("MOA", 8)]
        public List<MOA> MOA { get; set; }
        /// <summary>
        /// RATE DETAILS
        /// </summary>
        [S("RTE", 9)]
        public List<RTE> RTE { get; set; }
    }
}
