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
    /// Loop for CONSIGNMENT PACKING SEQUENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CPS))]
    public class Loop_CPS_DESADV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONSIGNMENT PACKING SEQUENCE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual CPS CPS { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for PACKAGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_PAC_DESADV> PACLoop { get; set; }
        /// <summary>
        /// Loop for LINE ITEM
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_LIN_DESADV> LINLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_CTA_DESADV
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
    /// Loop for DANGEROUS GOODS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DGS))]
    public class Loop_DGS_DESADV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DANGEROUS GOODS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DGS DGS { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for EQUIPMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EQD))]
    public class Loop_EQD_DESADV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// EQUIPMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual EQD EQD { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// SEAL NUMBER
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<SEL> SEL { get; set; }
        /// <summary>
        /// ATTACHED EQUIPMENT
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<EQA> EQA { get; set; }
        /// <summary>
        /// Loop for HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_HAN_DESADV> HANLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for GOODS IDENTITY NUMBER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(GIN))]
    public class Loop_GIN_DESADV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual GIN GIN { get; set; }
        /// <summary>
        /// DELIVERY LIMITATIONS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DLM> DLM { get; set; }
    }
    
    /// <summary>
    /// Loop for HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HAN))]
    public class Loop_HAN_DESADV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HAN HAN { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(HAN))]
    public class Loop_HAN_DESADV_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual HAN HAN { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<GIN> GIN { get; set; }
    }
    
    /// <summary>
    /// Loop for LINE ITEM
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_LIN_DESADV
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
        /// ADDITIONAL INFORMATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<GIN> GIN { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<GIR> GIR { get; set; }
        /// <summary>
        /// DELIVERY LIMITATIONS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<DLM> DLM { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_RFF_DESADV> RFFLoop { get; set; }
        /// <summary>
        /// Loop for DANGEROUS GOODS
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_DGS_DESADV> DGSLoop { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_LOC_DESADV_2> LOCLoop { get; set; }
        /// <summary>
        /// Loop for SPLIT GOODS PLACEMENT
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_SGP_DESADV> SGPLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_PCI_DESADV_2> PCILoop { get; set; }
        /// <summary>
        /// Loop for QUANTITY VARIANCES
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_QVR_DESADV> QVRLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LOC))]
    public class Loop_LOC_DESADV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LOC))]
    public class Loop_LOC_DESADV_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NAD NAD { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_DESADV
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
        public virtual List<Loop_RFF_DESADV> RFFLoop { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_CTA_DESADV> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAC))]
    public class Loop_PAC_DESADV
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
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Loop for HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_HAN_DESADV> HANLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_PCI_DESADV> PCILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCI))]
    public class Loop_PCI_DESADV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
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
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// RELATED IDENTIFICATION NUMBERS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<GIR> GIR { get; set; }
        /// <summary>
        /// Loop for GOODS IDENTITY NUMBER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_GIN_DESADV> GINLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCI))]
    public class Loop_PCI_DESADV_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual PCI PCI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Loop for GOODS IDENTITY NUMBER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_GIN_DESADV> GINLoop { get; set; }
        /// <summary>
        /// Loop for HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_HAN_DESADV_2> HANLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for QUANTITY VARIANCES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QVR))]
    public class Loop_QVR_DESADV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// QUANTITY VARIANCES
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual QVR QVR { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_DESADV
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
        public virtual DTM DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for SPLIT GOODS PLACEMENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SGP))]
    public class Loop_SGP_DESADV
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// SPLIT GOODS PLACEMENT
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual SGP SGP { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for DETAILS OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TDT))]
    public class Loop_TDT_DESADV
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
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<PCD> PCD { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_LOC_DESADV> LOCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TOD))]
    public class Loop_TOD_DESADV
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
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Despatch advice message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D96A", "DESADV")]
    public class TSDESADV : EdiMessage
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
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_RFF_DESADV> RFFLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_NAD_DESADV> NADLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_TOD_DESADV> TODLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_TDT_DESADV> TDTLoop { get; set; }
        /// <summary>
        /// Loop for EQUIPMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_EQD_DESADV> EQDLoop { get; set; }
        /// <summary>
        /// Loop for CONSIGNMENT PACKING SEQUENCE
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_CPS_DESADV> CPSLoop { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<CNT> CNT { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual UNT UNT { get; set; }
    }
}
