namespace EdiFabric.Templates.EancomD01B
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
    /// Loop for INVOIC:0:0410
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
        /// Allowance or charge
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ALC ALC { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0430
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_QTY_INVOIC QTYLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0450
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_PCD_INVOIC PCDLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0470
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0490
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_RTE_INVOIC RTELoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0510
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_TAX_INVOIC> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0950
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
        /// Allowance or charge
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ALC ALC { get; set; }
        /// <summary>
        /// Additional information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0990
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_QTY_INVOIC QTYLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1010
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual Loop_PCD_INVOIC PCDLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1030
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1050
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_RTE_INVOIC RTELoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1070
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<Loop_TAX_INVOIC_2> TAXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:1250
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
        /// Allowance or charge
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ALC ALC { get; set; }
        /// <summary>
        /// Additional information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ALI ALI { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0150
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
        /// Contact information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CTA CTA { get; set; }
        /// <summary>
        /// Communication contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0210
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
        /// Currencies
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CUX CUX { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0540
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
        /// Line item
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Additional product id
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(2)]
        public virtual List<PIA> PIA { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<IMD> IMD { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Additional information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [DataMember]
        [ListCount(35)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Goods identity number
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(8)]
        public virtual List<GIN> GIN { get; set; }
        /// <summary>
        /// Quantity variances
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual QVR QVR { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(10)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0650
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(11)]
        public virtual List<Loop_MOA_INVOIC> MOALoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0670
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<Loop_PAT_INVOIC_2> PATLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0720
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(13)]
        public virtual List<Loop_PRI_INVOIC> PRILoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0750
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(14)]
        public virtual List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0780
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<Loop_PAC_INVOIC_2> PACLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0840
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(16)]
        public virtual List<Loop_LOC_INVOIC_2> LOCLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0880
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(17)]
        public virtual List<Loop_TAX_INVOIC_2> TAXLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0910
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(18)]
        public virtual List<Loop_NAD_INVOIC_2> NADLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0950
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(19)]
        public virtual List<Loop_ALC_INVOIC_2> ALCLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1100
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(20)]
        public virtual List<Loop_TDT_INVOIC_2> TDTLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1120
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(21)]
        public virtual List<Loop_TOD_INVOIC> TODLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0330
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
        /// Place/location identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0840
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
        /// Place/location identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LOC LOC { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0470
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
        /// Monetary amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:1170
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
        /// Monetary amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MOA MOA { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1190
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_RFF_INVOIC RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0100
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
        /// Name and address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NAD NAD { get; set; }
        /// <summary>
        /// Financial institution information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<FII> FII { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0130
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<Loop_RFF_INVOIC_2> RFFLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0150
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<Loop_CTA_INVOIC> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0910
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
        /// Name and address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NAD NAD { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0930
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<Loop_RFF_INVOIC_2> RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0390
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
        /// Package
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAC PAC { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0780
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAC))]
    public class Loop_PAC_INVOIC_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Package
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAC PAC { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0810
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<Loop_PCI_INVOIC> PCILoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0240
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
        /// Payment terms basis
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAT PAT { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Percentage details
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PCD PCD { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MOA MOA { get; set; }
        /// <summary>
        /// Payment instructions
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PAI PAI { get; set; }
        /// <summary>
        /// Financial institution information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual FII FII { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0670
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
        /// Payment terms basis
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAT PAT { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Percentage details
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<PCD> PCD { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0450
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
        /// Percentage details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PCD PCD { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0810
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
        /// Package identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PCI PCI { get; set; }
        /// <summary>
        /// Goods identity number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<GIN> GIN { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0720
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
        /// Price details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PRI PRI { get; set; }
        /// <summary>
        /// Additional price information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual APR APR { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0430
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
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual QTY QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0070
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
        /// Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RFF RFF { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0130
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_INVOIC_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RFF RFF { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0490
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
        /// Rate details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RTE RTE { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0180
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
        /// Duty/tax/fee details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TAX TAX { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MOA MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0880
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
        /// Duty/tax/fee details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TAX TAX { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:1220
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
        /// Duty/tax/fee details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TAX TAX { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<MOA> MOA { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0310
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
        /// Details of transport
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TDT TDT { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0330
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Loop_LOC_INVOIC> LOCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:1100
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
        /// Details of transport
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TDT TDT { get; set; }
    }
    
    /// <summary>
    /// Loop for INVOIC:0:0360
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
        /// Terms of delivery or transport
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TOD TOD { get; set; }
        /// <summary>
        /// Place/location identification
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
    [Message("EDIFACT", "D01B", "INVOIC")]
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
        /// Beginning of message
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGM BGM { get; set; }
        /// <summary>
        /// Date/time/period
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(35)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Payment instructions
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PAI PAI { get; set; }
        /// <summary>
        /// Additional information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<ALI> ALI { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0070
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_RFF_INVOIC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0100
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<Loop_NAD_INVOIC> NADLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0180
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<Loop_TAX_INVOIC> TAXLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0210
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(10)]
        public virtual List<Loop_CUX_INVOIC> CUXLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0240
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<Loop_PAT_INVOIC> PATLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0310
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<Loop_TDT_INVOIC> TDTLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0360
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(13)]
        public virtual List<Loop_TOD_INVOIC> TODLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0390
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(14)]
        public virtual List<Loop_PAC_INVOIC> PACLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0410
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(15)]
        public virtual List<Loop_ALC_INVOIC> ALCLoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:0540
        /// </summary>
        [DataMember]
        [ListCount(9999999)]
        [Pos(16)]
        public virtual List<Loop_LIN_INVOIC> LINLoop { get; set; }
        /// <summary>
        /// Section control
        /// </summary>
        [DataMember]
        [Required]
        [Pos(17)]
        public virtual UNS UNS { get; set; }
        /// <summary>
        /// Control total
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(18)]
        public virtual List<CNT> CNT { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1170
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(19)]
        public virtual List<Loop_MOA_INVOIC_2> MOALoop { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1220
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(20)]
        public virtual List<Loop_TAX_INVOIC_3> TAXLoop2 { get; set; }
        /// <summary>
        /// Loop for INVOIC:0:1250
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(21)]
        public virtual List<Loop_ALC_INVOIC_3> ALCLoop2 { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual UNT UNT { get; set; }
    }
}
