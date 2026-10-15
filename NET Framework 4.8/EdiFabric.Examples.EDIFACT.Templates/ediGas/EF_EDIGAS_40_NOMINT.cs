namespace EdiFabric.Templates.Edigas40
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using EdiFabric.Core.Model.Edi.X12;
    
    
    /// <summary>
    // Nomination Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "NOMINT")]
    public class TSNOMINT : EdiMessage
    {
        
        /// <summary>
        // Message header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public UNH UNH { get; set; }
        /// <summary>
        // Beginning of message
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public BGM BGM { get; set; }
        /// <summary>
        // Date/time/period
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(35)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public List<Loop_1_TSNOMINT> P1Loop { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(5)]
        public List<Loop_2_TSNOMINT> P2Loop { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public List<Loop_6_TSNOMINT> P6Loop { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public List<Loop_7_TSNOMINT> P7Loop { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public List<Loop_8_TSNOMINT> P8Loop { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public List<Loop_10_TSNOMINT> P10Loop { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public List<Loop_12_TSNOMINT> P12Loop { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(11)]
        public List<Loop_13_TSNOMINT> P13Loop { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public List<Loop_15_TSNOMINT> P15Loop { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public List<Loop_16_TSNOMINT> P16Loop { get; set; }
        [DataMember]
        [ListCount(25)]
        [Pos(14)]
        public List<Loop_18_TSNOMINT> P18Loop { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(15)]
        public List<Loop_19_TSNOMINT> P19Loop { get; set; }
        [DataMember]
        [ListCount(999)]
        [Pos(16)]
        public List<Loop_25_TSNOMINT> P25Loop { get; set; }
        [DataMember]
        [ListCount(999)]
        [Pos(17)]
        public List<Loop_26_TSNOMINT> P26Loop { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(18)]
        public List<Loop_28_TSNOMINT> P28Loop { get; set; }
        [DataMember]
        [ListCount(200000)]
        [Pos(19)]
        public List<Loop_29_TSNOMINT> P29Loop { get; set; }
        /// <summary>
        // Section control
        /// </summary>
        [DataMember]
        [Required]
        [Pos(20)]
        public UNS UNS { get; set; }
        /// <summary>
        // Message trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(21)]
        public UNT UNT { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_1_TSNOMINT
    {
        
        /// <summary>
        // Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_2_TSNOMINT
    {
        
        /// <summary>
        // Name and address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public List<Loop_3_TSNOMINT> P3Loop { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public List<Loop_4_TSNOMINT> P4Loop { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public List<Loop_5_TSNOMINT> P5Loop { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TAX))]
    public class Loop_6_TSNOMINT
    {
        
        /// <summary>
        // Duty/tax/fee details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(CUX))]
    public class Loop_7_TSNOMINT
    {
        
        /// <summary>
        // Currencies
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public CUX CUX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PYT))]
    public class Loop_8_TSNOMINT
    {
        
        /// <summary>
        // Payment terms
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PYT PYT { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public List<Loop_9_TSNOMINT> P9Loop { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TDT))]
    public class Loop_10_TSNOMINT
    {
        
        /// <summary>
        // Transport information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public List<Loop_11_TSNOMINT> P11Loop { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TOD))]
    public class Loop_12_TSNOMINT
    {
        
        /// <summary>
        // Terms of delivery or transport
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public TOD TOD { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAC))]
    public class Loop_13_TSNOMINT
    {
        
        /// <summary>
        // Package
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public List<Loop_14_TSNOMINT> P14Loop { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(EQD))]
    public class Loop_15_TSNOMINT
    {
        
        /// <summary>
        // Equipment details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public EQD EQD { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCC))]
    public class Loop_16_TSNOMINT
    {
        
        /// <summary>
        // Scheduling conditions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public SCC SCC { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public List<Loop_17_TSNOMINT> P17Loop { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(APR))]
    public class Loop_18_TSNOMINT
    {
        
        /// <summary>
        // Additional price information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public APR APR { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ALC))]
    public class Loop_19_TSNOMINT
    {
        
        /// <summary>
        // Allowance or charge
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        [DataMember]
        [Pos(2)]
        public Loop_QTY_TSNOMINT QTYLoop { get; set; }
        [DataMember]
        [Pos(3)]
        public Loop_PCD_TSNOMINT PCDLoop { get; set; }
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public List<Loop_22_TSNOMINT> P22Loop { get; set; }
        [DataMember]
        [Pos(5)]
        public Loop_RTE_TSNOMINT RTELoop { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public List<Loop_24_TSNOMINT> P24Loop { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RCS))]
    public class Loop_25_TSNOMINT
    {
        
        /// <summary>
        // Requirements and conditions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public RCS RCS { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(DGS))]
    public class Loop_26_TSNOMINT
    {
        
        /// <summary>
        // Dangerous goods
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public DGS DGS { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public List<Loop_27_TSNOMINT> P27Loop { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(EFI))]
    public class Loop_28_TSNOMINT
    {
        
        /// <summary>
        // External file link identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public EFI EFI { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_29_TSNOMINT
    {
        
        /// <summary>
        // Line item
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public LIN LIN { get; set; }
        /// <summary>
        // Item description
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public List<IMD> IMD { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        // Date/time/period
        /// </summary>
        [DataMember]
        [ListCount(35)]
        [Pos(4)]
        public List<DTM> DTM { get; set; }
        [DataMember]
        [ListCount(999)]
        [Pos(5)]
        public List<Loop_30_TSNOMINT> P30Loop { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public List<Loop_31_TSNOMINT> P31Loop { get; set; }
        [DataMember]
        [ListCount(25)]
        [Pos(7)]
        public List<Loop_33_TSNOMINT> P33Loop { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(8)]
        public List<Loop_34_TSNOMINT> P34Loop { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(9)]
        public List<Loop_35_TSNOMINT> P35Loop { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(10)]
        public List<Loop_38_TSNOMINT> P38Loop { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public List<Loop_40_TSNOMINT> P40Loop { get; set; }
        [DataMember]
        [ListCount(999)]
        [Pos(12)]
        public List<Loop_41_TSNOMINT> P41Loop { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(CCI))]
    public class Loop_30_TSNOMINT
    {
        
        /// <summary>
        // Characteristic/class id
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public CCI CCI { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PYT))]
    public class Loop_31_TSNOMINT
    {
        
        /// <summary>
        // Payment terms
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PYT PYT { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public List<Loop_32_TSNOMINT> P32Loop { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PRI))]
    public class Loop_33_TSNOMINT
    {
        
        /// <summary>
        // Price details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PRI PRI { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_34_TSNOMINT
    {
        
        /// <summary>
        // Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAC))]
    public class Loop_35_TSNOMINT
    {
        
        /// <summary>
        // Package
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }
        [DataMember]
        [Pos(2)]
        public Loop_RFF_TSNOMINT RFFLoop { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public List<Loop_37_TSNOMINT> P37Loop { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LOC))]
    public class Loop_38_TSNOMINT
    {
        
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        /// <summary>
        // Date/time/period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public DTM DTM { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public List<Loop_39_TSNOMINT> P39Loop { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TAX))]
    public class Loop_40_TSNOMINT
    {
        
        /// <summary>
        // Duty/tax/fee details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NAD))]
    public class Loop_41_TSNOMINT
    {
        
        /// <summary>
        // Name and address
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_39_TSNOMINT
    {
        
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        /// <summary>
        // Status
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public List<STS> STS { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_RFF_TSNOMINT
    {
        
        /// <summary>
        // Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCI))]
    public class Loop_37_TSNOMINT
    {
        
        /// <summary>
        // Package identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PCI PCI { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(MOA))]
    public class Loop_32_TSNOMINT
    {
        
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_27_TSNOMINT
    {
        
        /// <summary>
        // Contact information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public CTA CTA { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_TSNOMINT
    {
        
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCD))]
    public class Loop_PCD_TSNOMINT
    {
        
        /// <summary>
        // Percentage details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PCD PCD { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(MOA))]
    public class Loop_22_TSNOMINT
    {
        
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RTE))]
    public class Loop_RTE_TSNOMINT
    {
        
        /// <summary>
        // Rate details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public RTE RTE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TAX))]
    public class Loop_24_TSNOMINT
    {
        
        /// <summary>
        // Duty/tax/fee details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_17_TSNOMINT
    {
        
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCI))]
    public class Loop_14_TSNOMINT
    {
        
        /// <summary>
        // Package identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public PCI PCI { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LOC))]
    public class Loop_11_TSNOMINT
    {
        
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(MOA))]
    public class Loop_9_TSNOMINT
    {
        
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RFF))]
    public class Loop_3_TSNOMINT
    {
        
        /// <summary>
        // Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(DOC))]
    public class Loop_4_TSNOMINT
    {
        
        /// <summary>
        // Document/message details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public DOC DOC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(CTA))]
    public class Loop_5_TSNOMINT
    {
        
        /// <summary>
        // Contact information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public CTA CTA { get; set; }
    }
}
