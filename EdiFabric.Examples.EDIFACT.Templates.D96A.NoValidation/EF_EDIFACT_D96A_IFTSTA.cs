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
    /// Loop for CONSIGNMENT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CNI))]
    public class Loop_CNI_IFTSTA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CONSIGNMENT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual CNI CNI { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<CNT> CNT { get; set; }
        /// <summary>
        /// Loop for STATUS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_STS_IFTSTA> STSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_CTA_IFTSTA
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
    /// Loop for DIMENSIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DIM))]
    public class Loop_DIM_IFTSTA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DIMENSIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DIM DIM { get; set; }
        /// <summary>
        /// NUMBER OF UNITS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual EQN EQN { get; set; }
    }
    
    /// <summary>
    /// Loop for ATTACHED EQUIPMENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EQA))]
    public class Loop_EQA_IFTSTA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// ATTACHED EQUIPMENT
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual EQA EQA { get; set; }
        /// <summary>
        /// SEAL NUMBER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<SEL> SEL { get; set; }
    }
    
    /// <summary>
    /// Loop for EQUIPMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EQD))]
    public class Loop_EQD_IFTSTA
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
        /// DIMENSIONS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DIM> DIM { get; set; }
        /// <summary>
        /// SEAL NUMBER
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<SEL> SEL { get; set; }
        /// <summary>
        /// Loop for ATTACHED EQUIPMENT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_EQA_IFTSTA> EQALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for GOODS ITEM DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(GID))]
    public class Loop_GID_IFTSTA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// GOODS ITEM DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual GID GID { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<HAN> HAN { get; set; }
        /// <summary>
        /// Loop for MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_MEA_IFTSTA> MEALoop { get; set; }
        /// <summary>
        /// Loop for DIMENSIONS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_DIM_IFTSTA> DIMLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_PCI_IFTSTA> PCILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for MEASUREMENTS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MEA))]
    public class Loop_MEA_IFTSTA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual MEA MEA { get; set; }
        /// <summary>
        /// NUMBER OF UNITS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual EQN EQN { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_IFTSTA
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
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_CTA_IFTSTA> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCI))]
    public class Loop_PCI_IFTSTA
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
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<GIN> GIN { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_IFTSTA
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
    /// Loop for STATUS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(STS))]
    public class Loop_STS_IFTSTA
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual STS STS { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DOC DOC { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<NAD> NAD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<PCI> PCI { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_TDT_IFTSTA> TDTLoop { get; set; }
        /// <summary>
        /// Loop for EQUIPMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_EQD_IFTSTA> EQDLoop { get; set; }
        /// <summary>
        /// Loop for GOODS ITEM DETAILS
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_GID_IFTSTA> GIDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for DETAILS OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TDT))]
    public class Loop_TDT_IFTSTA
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
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// International multimodal status report message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D96A", "IFTSTA")]
    public class TSIFTSTA : EdiMessage
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
        /// TRANSPORT SERVICE REQUIREMENTS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual TSR TSR { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_NAD_IFTSTA> NADLoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_RFF_IFTSTA> RFFLoop { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<CNT> CNT { get; set; }
        /// <summary>
        /// Loop for CONSIGNMENT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_CNI_IFTSTA> CNILoop { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual UNT UNT { get; set; }
    }
}
