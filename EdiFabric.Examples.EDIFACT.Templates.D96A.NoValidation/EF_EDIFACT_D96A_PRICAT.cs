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
    public class Loop_ALC_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_QTY_PRICAT QTYLoop { get; set; }
        /// <summary>
        /// Loop for PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_PCD_PRICAT PCDLoop { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_MOA_PRICAT> MOALoop { get; set; }
        /// <summary>
        /// Loop for RATE DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_RTE_PRICAT RTELoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_TAX_PRICAT> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for ALLOWANCE OR CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ALC))]
    public class Loop_ALC_PRICAT_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ALC ALC { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_QTY_PRICAT QTYLoop { get; set; }
        /// <summary>
        /// Loop for PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_PCD_PRICAT PCDLoop { get; set; }
        /// <summary>
        /// Loop for MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_MOA_PRICAT> MOALoop { get; set; }
        /// <summary>
        /// Loop for RATE DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_RTE_PRICAT RTELoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_TAX_PRICAT> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for CHARACTERISTIC/CLASS ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CCI))]
    public class Loop_CCI_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CHARACTERISTIC/CLASS ID
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual CCI CCI { get; set; }
        /// <summary>
        /// CHARACTERISTIC VALUE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<CAV> CAV { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_CTA_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for CURRENCIES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CUX))]
    public class Loop_CUX_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual CUX CUX { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for LINE ITEM
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// LINE ITEM
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// ADDITIONAL PRODUCT ID
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PIA> PIA { get; set; }
        /// <summary>
        /// ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<IMD> IMD { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<HAN> HAN { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<NAD> NAD { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual RFF RFF { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual DOC DOC { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for CHARACTERISTIC/CLASS ID
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_CCI_PRICAT> CCILoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_TAX_PRICAT> TAXLoop { get; set; }
        /// <summary>
        /// Loop for CURRENCIES
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_CUX_PRICAT> CUXLoop { get; set; }
        /// <summary>
        /// Loop for PRICE DETAILS
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_PRI_PRICAT_2> PRILoop { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_ALC_PRICAT> ALCLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<Loop_PAC_PRICAT> PACLoop { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<Loop_PAT_PRICAT> PATLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual List<Loop_TDT_PRICAT> TDTLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual List<Loop_TOD_PRICAT> TODLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MOA))]
    public class Loop_MOA_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
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
    public class Loop_NAD_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual NAD NAD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_RFF_PRICAT> RFFLoop { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_CTA_PRICAT> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAC))]
    public class Loop_PAC_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PACKAGE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual PAC PAC { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<HAN> HAN { get; set; }
    }
    
    /// <summary>
    /// Loop for PAYMENT TERMS BASIS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAT))]
    public class Loop_PAT_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual PAT PAT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
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
    public class Loop_PCD_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
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
    /// Loop for PRODUCT GROUP INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PGI))]
    public class Loop_PGI_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRODUCT GROUP INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual PGI PGI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for CURRENCIES
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_CUX_PRICAT> CUXLoop { get; set; }
        /// <summary>
        /// Loop for PRICE DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_PRI_PRICAT> PRILoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_TAX_PRICAT> TAXLoop { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_ALC_PRICAT_2> ALCLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_NAD_PRICAT> NADLoop { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_PAT_PRICAT> PATLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_TDT_PRICAT> TDTLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_TOD_PRICAT> TODLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_PAC_PRICAT> PACLoop { get; set; }
        /// <summary>
        /// Loop for LINE ITEM
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_LIN_PRICAT> LINLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PRICE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PRI))]
    public class Loop_PRI_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE DETAILS
        /// </summary>
        [DataMember]
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
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for PRICE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PRI))]
    public class Loop_PRI_PRICAT_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PRICE DETAILS
        /// </summary>
        [DataMember]
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
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<PCD> PCD { get; set; }
    }
    
    /// <summary>
    /// Loop for QUANTITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
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
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for RATE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RTE))]
    public class Loop_RTE_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// RATE DETAILS
        /// </summary>
        [DataMember]
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
    public class Loop_TAX_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
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
    public class Loop_TDT_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TDT TDT { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<LOC> LOC { get; set; }
    }
    
    /// <summary>
    /// Loop for TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TOD))]
    public class Loop_TOD_PRICAT
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TOD TOD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<LOC> LOC { get; set; }
    }
    
    /// <summary>
    /// Price/sales catalogue message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D96A", "PRICAT")]
    public class TSPRICAT : EdiMessage
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
        [Pos(2)]
        public virtual BGM BGM { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_RFF_PRICAT> RFFLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_NAD_PRICAT> NADLoop { get; set; }
        /// <summary>
        /// Loop for DUTY/TAX/FEE DETAILS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_TAX_PRICAT> TAXLoop { get; set; }
        /// <summary>
        /// Loop for CURRENCIES
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_CUX_PRICAT> CUXLoop { get; set; }
        /// <summary>
        /// Loop for PAYMENT TERMS BASIS
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_PAT_PRICAT> PATLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_TDT_PRICAT> TDTLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_TOD_PRICAT> TODLoop { get; set; }
        /// <summary>
        /// Loop for ALLOWANCE OR CHARGE
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_ALC_PRICAT> ALCLoop { get; set; }
        /// <summary>
        /// Loop for PRODUCT GROUP INFORMATION
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_PGI_PRICAT> PGILoop { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual UNT UNT { get; set; }
    }
}
