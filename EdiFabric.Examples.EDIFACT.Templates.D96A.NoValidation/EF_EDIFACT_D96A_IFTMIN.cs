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
    /// Loop for CHARGE PAYMENT INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CPI))]
    public class Loop_CPI_IFTMIN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// CHARGE PAYMENT INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual CPI CPI { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUX CUX { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_CTA_IFTMIN
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
    public class Loop_DGS_IFTMIN
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
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_CTA_IFTMIN> CTALoop { get; set; }
        /// <summary>
        /// Loop for MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_MEA_IFTMIN> MEALoop { get; set; }
        /// <summary>
        /// Loop for SPLIT GOODS PLACEMENT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_SGP_IFTMIN> SGPLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for DIMENSIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DIM))]
    public class Loop_DIM_IFTMIN
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
    /// Loop for DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DOC))]
    public class Loop_DOC_IFTMIN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DOC DOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DOC))]
    public class Loop_DOC_IFTMIN_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual DOC DOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for ATTACHED EQUIPMENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EQA))]
    public class Loop_EQA_IFTMIN
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
        /// NUMBER OF UNITS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual EQN EQN { get; set; }
    }
    
    /// <summary>
    /// Loop for EQUIPMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EQD))]
    public class Loop_EQD_IFTMIN
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
        /// NUMBER OF UNITS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual EQN EQN { get; set; }
        /// <summary>
        /// TRANSPORT MOVEMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TMD TMD { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// DIMENSIONS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<DIM> DIM { get; set; }
        /// <summary>
        /// SEAL NUMBER
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<SEL> SEL { get; set; }
        /// <summary>
        /// TRANSPORT PLACEMENT
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<TPL> TPL { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual HAN HAN { get; set; }
        /// <summary>
        /// TEMPERATURE
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual TMP TMP { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for TRANSPORT CHARGE/RATE CALCULATIONS
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_TCC_IFTMIN_2> TCCLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_NAD_IFTMIN_3> NADLoop { get; set; }
        /// <summary>
        /// Loop for ATTACHED EQUIPMENT
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_EQA_IFTMIN> EQALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for GOODS ITEM DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(GID))]
    public class Loop_GID_IFTMIN
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
        public virtual HAN HAN { get; set; }
        /// <summary>
        /// TEMPERATURE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TMP TMP { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual RNG RNG { get; set; }
        /// <summary>
        /// TRANSPORT MOVEMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual TMD TMD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// ADDITIONAL PRODUCT ID
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<PIA> PIA { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_NAD_IFTMIN_2> NADLoop { get; set; }
        /// <summary>
        /// NATURE OF CARGO
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<GDS> GDS { get; set; }
        /// <summary>
        /// Loop for MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_MEA_IFTMIN> MEALoop { get; set; }
        /// <summary>
        /// Loop for DIMENSIONS
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_DIM_IFTMIN> DIMLoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_RFF_IFTMIN> RFFLoop { get; set; }
        /// <summary>
        /// Loop for PACKAGE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_PCI_IFTMIN> PCILoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_DOC_IFTMIN_2> DOCLoop { get; set; }
        /// <summary>
        /// Loop for GOVERNMENTAL REQUIREMENTS
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_GOR_IFTMIN> GORLoop { get; set; }
        /// <summary>
        /// Loop for TRANSPORT PLACEMENT
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_TPL_IFTMIN> TPLLoop { get; set; }
        /// <summary>
        /// Loop for SPLIT GOODS PLACEMENT
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<Loop_SGP_IFTMIN> SGPLoop { get; set; }
        /// <summary>
        /// Loop for TRANSPORT CHARGE/RATE CALCULATIONS
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<Loop_TCC_IFTMIN_3> TCCLoop { get; set; }
        /// <summary>
        /// Loop for DANGEROUS GOODS
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual List<Loop_DGS_IFTMIN> DGSLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for GOVERNMENTAL REQUIREMENTS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(GOR))]
    public class Loop_GOR_IFTMIN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// GOVERNMENTAL REQUIREMENTS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual GOR GOR { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// SEAL NUMBER
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<SEL> SEL { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_DOC_IFTMIN> DOCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LOC))]
    public class Loop_LOC_IFTMIN
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
    public class Loop_LOC_IFTMIN_2
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
        public virtual DTM DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for MEASUREMENTS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MEA))]
    public class Loop_MEA_IFTMIN
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
    public class Loop_NAD_IFTMIN
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
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_CTA_IFTMIN> CTALoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_DOC_IFTMIN> DOCLoop { get; set; }
        /// <summary>
        /// Loop for TRANSPORT CHARGE/RATE CALCULATIONS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_TCC_IFTMIN_2> TCCLoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_RFF_IFTMIN> RFFLoop { get; set; }
        /// <summary>
        /// Loop for CHARGE PAYMENT INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_CPI_IFTMIN> CPILoop { get; set; }
        /// <summary>
        /// Loop for TRANSPORT SERVICE REQUIREMENTS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_TSR_IFTMIN> TSRLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_IFTMIN_2
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
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_NAD_IFTMIN_3
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
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_CTA_IFTMIN> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for PACKAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCI))]
    public class Loop_PCI_IFTMIN
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
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// GOODS IDENTITY NUMBER
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<GIN> GIN { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_IFTMIN
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
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_IFTMIN_2
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
    public class Loop_SGP_IFTMIN
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
        /// Loop for MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_MEA_IFTMIN> MEALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for TRANSPORT CHARGE/RATE CALCULATIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TCC))]
    public class Loop_TCC_IFTMIN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TRANSPORT CHARGE/RATE CALCULATIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TCC TCC { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual FTX FTX { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CUX CUX { get; set; }
        /// <summary>
        /// PRICE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PRI PRI { get; set; }
        /// <summary>
        /// NUMBER OF UNITS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual EQN EQN { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PCD PCD { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for TRANSPORT CHARGE/RATE CALCULATIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TCC))]
    public class Loop_TCC_IFTMIN_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TRANSPORT CHARGE/RATE CALCULATIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TCC TCC { get; set; }
        /// <summary>
        /// PRICE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRI PRI { get; set; }
        /// <summary>
        /// NUMBER OF UNITS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual EQN EQN { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PCD PCD { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for TRANSPORT CHARGE/RATE CALCULATIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TCC))]
    public class Loop_TCC_IFTMIN_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TRANSPORT CHARGE/RATE CALCULATIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TCC TCC { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUX CUX { get; set; }
        /// <summary>
        /// PRICE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PRI PRI { get; set; }
        /// <summary>
        /// NUMBER OF UNITS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual EQN EQN { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PCD PCD { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<LOC> LOC { get; set; }
    }
    
    /// <summary>
    /// Loop for DETAILS OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TDT))]
    public class Loop_TDT_IFTMIN
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
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// TRANSPORT SERVICE REQUIREMENTS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<TSR> TSR { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_LOC_IFTMIN_2> LOCLoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_RFF_IFTMIN_2> RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TOD))]
    public class Loop_TOD_IFTMIN
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
    /// Loop for TRANSPORT PLACEMENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TPL))]
    public class Loop_TPL_IFTMIN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TRANSPORT PLACEMENT
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TPL TPL { get; set; }
        /// <summary>
        /// Loop for MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_MEA_IFTMIN> MEALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for TRANSPORT SERVICE REQUIREMENTS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TSR))]
    public class Loop_TSR_IFTMIN
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// TRANSPORT SERVICE REQUIREMENTS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual TSR TSR { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RFF RFF { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// TRANSPORT PLACEMENT
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual TPL TPL { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Instruction message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D96A", "IFTMIN")]
    public class TSIFTMIN : EdiMessage
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
        /// CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// TRANSPORT SERVICE REQUIREMENTS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<TSR> TSR { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<CUX> CUX { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<CNT> CNT { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<DOC> DOC { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_LOC_IFTMIN> LOCLoop { get; set; }
        /// <summary>
        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_TOD_IFTMIN> TODLoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_RFF_IFTMIN> RFFLoop { get; set; }
        /// <summary>
        /// Loop for GOVERNMENTAL REQUIREMENTS
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_GOR_IFTMIN> GORLoop { get; set; }
        /// <summary>
        /// Loop for CHARGE PAYMENT INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual List<Loop_CPI_IFTMIN> CPILoop { get; set; }
        /// <summary>
        /// Loop for TRANSPORT CHARGE/RATE CALCULATIONS
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual List<Loop_TCC_IFTMIN> TCCLoop { get; set; }
        /// <summary>
        /// Loop for DETAILS OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual List<Loop_TDT_IFTMIN> TDTLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual List<Loop_NAD_IFTMIN> NADLoop { get; set; }
        /// <summary>
        /// Loop for GOODS ITEM DETAILS
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual List<Loop_GID_IFTMIN> GIDLoop { get; set; }
        /// <summary>
        /// Loop for EQUIPMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual List<Loop_EQD_IFTMIN> EQDLoop { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual UNT UNT { get; set; }
    }
}
