using EdiFabric.Core.Annotations;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Rules.EDIFACT_D00A.Rep
{
    using System;
    using System.Collections.Generic;


    [Serializable()]
    [Message("EDIFACT", "D00A", "INVOIC")]
    public class TSINVOIC : EdiMessage
    {
        
        [Pos(1)]
        public UNH UNH { get; set; }
        [Required]
        [Pos(2)]
        public BGM BGM { get; set; }
        [Required]
        [ListCount(35)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [Required]
        [Pos(4)]
        public PAI PAI { get; set; }
        [ListCount(2, 5)]
        [Pos(5)]
        public List<ALI> ALI { get; set; }
        [Pos(6)]
        public IMD IMD { get; set; }
        [ListCount(99)]
        [Pos(7)]
        public List<FTX> FTX { get; set; }
        [ListCount(10)]
        [Pos(8)]
        public List<LOC> LOC { get; set; }
        [ListCount(10)]
        [Pos(9)]
        public List<GIS> GIS { get; set; }
        [Pos(10)]
        public DGS DGS { get; set; }
        [ListCount(10)]
        [Pos(11)]
        public List<GIR> GIR { get; set; }
        [ListCount(99999)]
        [Pos(12)]
        public List<TSINVOIC_RFFLoop1> RFFLoop1 { get; set; }
        [ListCount(99)]
        [Pos(13)]
        public List<TSINVOIC_NADLoop1> NADLoop1 { get; set; }
        [ListCount(2, 5)]
        [Pos(14)]
        public List<TSINVOIC_TAXLoop1> TAXLoop1 { get; set; }
        [ListCount(99)]
        [Pos(15)]
        public List<TSINVOIC_CUXLoop1> CUXLoop1 { get; set; }
        [ListCount(10)]
        [Pos(16)]
        public List<TSINVOIC_PATLoop1> PATLoop1 { get; set; }
        [ListCount(10)]
        [Pos(17)]
        public List<TSINVOIC_TDTLoop1> TDTLoop1 { get; set; }
        [ListCount(5)]
        [Pos(18)]
        public List<TSINVOIC_TODLoop1> TODLoop1 { get; set; }
        [ListCount(99)]
        [Pos(19)]
        public List<TSINVOIC_EQDLoop1> EQDLoop1 { get; set; }
        [ListCount(1000)]
        [Pos(20)]
        public List<TSINVOIC_PACLoop1> PACLoop1 { get; set; }
        [ListCount(9999)]
        [Pos(21)]
        public List<TSINVOIC_ALCLoop1> ALCLoop1 { get; set; }
        [ListCount(100)]
        [Pos(22)]
        public List<TSINVOIC_RCSLoop1> RCSLoop1 { get; set; }
        [Pos(23)]
        public TSINVOIC_AJTLoop1 AJTLoop1 { get; set; }
        [Pos(24)]
        public TSINVOIC_INPLoop1 INPLoop1 { get; set; }
        [ListCount(9999999)]
        [Pos(25)]
        public List<TSINVOIC_LINLoop1> LINLoop1 { get; set; }
        [Required]
        [Pos(26)]
        public UNS UNS { get; set; }
        [ListCount(10)]
        [Pos(27)]
        public List<CNT> CNT { get; set; }
        [Required]
        [ListCount(100)]
        [Pos(28)]
        public List<TSINVOIC_MOALoop4> MOALoop4 { get; set; }
        [ListCount(10)]
        [Pos(29)]
        public List<TSINVOIC_TAXLoop5> TAXLoop5 { get; set; }
        [ListCount(15)]
        [Pos(30)]
        public List<TSINVOIC_ALCLoop3> ALCLoop3 { get; set; }
        [Pos(31)]
        public UNT UNT { get; set; }
    }
    
    [Serializable()]
    [Group("ALC")]
    public class TSINVOIC_ALCLoop3
    {
        
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        [Pos(2)]
        public ALI ALI { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<MOA> MOA { get; set; }
        [Pos(4)]
        public FTX FTX { get; set; }
    }
    
    [Serializable()]
    [Group("TAX")]
    public class TSINVOIC_TAXLoop5
    {
        
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<MOA> MOA { get; set; }
    }
    
    [Serializable()]
    [Group("MOA")]
    public class TSINVOIC_MOALoop4
    {
        
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
        [Pos(2)]
        public TSINVOIC_RFFLoop7 RFFLoop7 { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop7
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("LIN")]
    public class TSINVOIC_LINLoop1 : EdiItem
    {
        
        [Required]
        [Pos(1)]
        public LIN LIN { get; set; }
        [ListCount(25)]
        [Pos(2)]
        public List<PIA> PIA { get; set; }
        [ListCount(99)]
        [Pos(3)]
        public List<IMD> IMD { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<MEA> MEA { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<QTY> QTY { get; set; }
        [Pos(6)]
        public PCD PCD { get; set; }
        [ListCount(5)]
        [Pos(7)]
        public List<ALI> ALI { get; set; }
        [ListCount(35)]
        [Pos(8)]
        public List<DTM> DTM { get; set; }
        [ListCount(1000)]
        [Pos(9)]
        public List<GIN> GIN { get; set; }
        [ListCount(1000)]
        [Pos(10)]
        public List<GIR> GIR { get; set; }
        [Pos(11)]
        public QVR QVR { get; set; }
        [Pos(12)]
        public EQD EQD { get; set; }
        [ListCount(99)]
        [Pos(13)]
        public List<FTX> FTX { get; set; }
        [Pos(14)]
        public DGS DGS { get; set; }
        [ListCount(99)]
        [Pos(15)]
        public List<TSINVOIC_MOALoop2> MOALoop2 { get; set; }
        [ListCount(10)]
        [Pos(16)]
        public List<TSINVOIC_PATLoop2> PATLoop2 { get; set; }
        [ListCount(25)]
        [Pos(17)]
        public List<TSINVOIC_PRILoop1> PRILoop1 { get; set; }
        [ListCount(10)]
        [Pos(18)]
        public List<TSINVOIC_RFFLoop5> RFFLoop5 { get; set; }
        [ListCount(10)]
        [Pos(19)]
        public List<TSINVOIC_PACLoop2> PACLoop2 { get; set; }
        [ListCount(9999)]
        [Pos(20)]
        public List<TSINVOIC_LOCLoop2> LOCLoop2 { get; set; }
        [ListCount(99)]
        [Pos(21)]
        public List<TSINVOIC_TAXLoop3> TAXLoop3 { get; set; }
        [ListCount(99)]
        [Pos(22)]
        public List<TSINVOIC_NADLoop2> NADLoop2 { get; set; }
        [ListCount(30)]
        [Pos(23)]
        public List<TSINVOIC_ALCLoop2> ALCLoop2 { get; set; }
        [ListCount(10)]
        [Pos(24)]
        public List<TSINVOIC_TDTLoop2> TDTLoop2 { get; set; }
        [ListCount(5)]
        [Pos(25)]
        public List<TSINVOIC_TODLoop2> TODLoop2 { get; set; }
        [ListCount(100)]
        [Pos(26)]
        public List<TSINVOIC_RCSLoop2> RCSLoop2 { get; set; }
        [ListCount(10)]
        [Pos(27)]
        public List<TSINVOIC_GISLoop1> GISLoop1 { get; set; }
    }
    
    [Serializable()]
    [Group("GIS")]
    public class TSINVOIC_GISLoop1
    {
        
        [Required]
        [Pos(1)]
        public GIS GIS { get; set; }
        [Pos(2)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<GIR> GIR { get; set; }
        [ListCount(2)]
        [Pos(5)]
        public List<LOC> LOC { get; set; }
        [ListCount(5)]
        [Pos(6)]
        public List<MEA> MEA { get; set; }
        [ListCount(2)]
        [Pos(7)]
        public List<QTY> QTY { get; set; }
        [ListCount(5)]
        [Pos(8)]
        public List<FTX> FTX { get; set; }
        [ListCount(2)]
        [Pos(9)]
        public List<MOA> MOA { get; set; }
    }
    
    [Serializable()]
    [Group("RCS")]
    public class TSINVOIC_RCSLoop2
    {
        
        [Required]
        [Pos(1)]
        public RCS RCS { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<RFF> RFF { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<FTX> FTX { get; set; }
    }
    
    [Serializable()]
    [Group("TOD")]
    public class TSINVOIC_TODLoop2
    {
        
        [Required]
        [Pos(1)]
        public TOD TOD { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
    }
    
    [Serializable()]
    [Group("TDT")]
    public class TSINVOIC_TDTLoop2
    {
        
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<TSINVOIC_LOCLoop3> LOCLoop3 { get; set; }
    }
    
    [Serializable()]
    [Group("LOC")]
    public class TSINVOIC_LOCLoop3
    {
        
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("ALC")]
    public class TSINVOIC_ALCLoop2
    {
        
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<ALI> ALI { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [Pos(4)]
        public FTX FTX { get; set; }
        [Pos(5)]
        public TSINVOIC_QTYLoop2 QTYLoop2 { get; set; }
        [Pos(6)]
        public TSINVOIC_PCDLoop2 PCDLoop2 { get; set; }
        [ListCount(2)]
        [Pos(7)]
        public List<TSINVOIC_MOALoop3> MOALoop3 { get; set; }
        [Pos(8)]
        public TSINVOIC_RTELoop2 RTELoop2 { get; set; }
        [ListCount(5)]
        [Pos(9)]
        public List<TSINVOIC_TAXLoop4> TAXLoop4 { get; set; }
    }
    
    [Serializable()]
    [Group("TAX")]
    public class TSINVOIC_TAXLoop4
    {
        
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<MOA> MOA { get; set; }
    }
    
    [Serializable()]
    [Group("RTE")]
    public class TSINVOIC_RTELoop2
    {
        
        [Required]
        [Pos(1)]
        public RTE RTE { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group("MOA")]
    public class TSINVOIC_MOALoop3
    {
        
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
        [Pos(3)]
        public CUX CUX { get; set; }
        [Pos(4)]
        public DTM DTM { get; set; }
    }
    
    [Serializable()]
    [Group("PCD")]
    public class TSINVOIC_PCDLoop2
    {
        
        [Required]
        [Pos(1)]
        public PCD PCD { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group("QTY")]
    public class TSINVOIC_QTYLoop2
    {
        
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group("NAD")]
    public class TSINVOIC_NADLoop2
    {
        
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<FII> FII { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<TSINVOIC_RFFLoop6> RFFLoop6 { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<TSINVOIC_DOCLoop2> DOCLoop2 { get; set; }
        [ListCount(5)]
        [Pos(6)]
        public List<TSINVOIC_CTALoop2> CTALoop2 { get; set; }
    }
    
    [Serializable()]
    [Group("CTA")]
    public class TSINVOIC_CTALoop2
    {
        
        [Required]
        [Pos(1)]
        public CTA CTA { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<COM> COM { get; set; }
    }
    
    [Serializable()]
    [Group("DOC")]
    public class TSINVOIC_DOCLoop2
    {
        
        [Required]
        [Pos(1)]
        public DOC DOC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop6
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("TAX")]
    public class TSINVOIC_TAXLoop3
    {
        
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<MOA> MOA { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<LOC> LOC { get; set; }
    }
    
    [Serializable()]
    [Group("LOC")]
    public class TSINVOIC_LOCLoop2
    {
        
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        [ListCount(100)]
        [Pos(2)]
        public List<QTY> QTY { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("PAC")]
    public class TSINVOIC_PACLoop2
    {
        
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }
        [Pos(3)]
        public EQD EQD { get; set; }
        [ListCount(10)]
        [Pos(4)]
        public List<TSINVOIC_PCILoop2> PCILoop2 { get; set; }
    }
    
    [Serializable()]
    [Group("PCI")]
    public class TSINVOIC_PCILoop2
    {
        
        [Required]
        [Pos(1)]
        public PCI PCI { get; set; }
        [Pos(2)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [ListCount(10)]
        [Pos(4)]
        public List<GIN> GIN { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop5
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("PRI")]
    public class TSINVOIC_PRILoop1
    {
        
        [Required]
        [Pos(1)]
        public PRI PRI { get; set; }
        [Pos(2)]
        public CUX CUX { get; set; }
        [Pos(3)]
        public APR APR { get; set; }
        [Pos(4)]
        public RNG RNG { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("PAT")]
    public class TSINVOIC_PATLoop2
    {
        
        [Required]
        [Pos(1)]
        public PAT PAT { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        [ListCount(99)]
        [Pos(3)]
        public List<PCD> PCD { get; set; }
        [Pos(4)]
        public MOA MOA { get; set; }
    }
    
    [Serializable()]
    [Group("MOA")]
    public class TSINVOIC_MOALoop2
    {
        
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
        [Pos(2)]
        public CUX CUX { get; set; }
    }
    
    [Serializable()]
    [Group("INP")]
    public class TSINVOIC_INPLoop1
    {
        
        [Required]
        [Pos(1)]
        public INP INP { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<FTX> FTX { get; set; }
    }
    
    [Serializable()]
    [Group("AJT")]
    public class TSINVOIC_AJTLoop1
    {
        
        [Required]
        [Pos(1)]
        public AJT AJT { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<FTX> FTX { get; set; }
    }
    
    [Serializable()]
    [Group("RCS")]
    public class TSINVOIC_RCSLoop1
    {
        
        [Required]
        [Pos(1)]
        public RCS RCS { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<RFF> RFF { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<FTX> FTX { get; set; }
    }
    
    [Serializable()]
    [Group("ALC")]
    public class TSINVOIC_ALCLoop1
    {
        
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<ALI> ALI { get; set; }
        [Pos(3)]
        public FTX FTX { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<TSINVOIC_RFFLoop4> RFFLoop4 { get; set; }
        [Pos(5)]
        public TSINVOIC_QTYLoop1 QTYLoop1 { get; set; }
        [Pos(6)]
        public TSINVOIC_PCDLoop1 PCDLoop1 { get; set; }
        [ListCount(2)]
        [Pos(7)]
        public List<TSINVOIC_MOALoop1> MOALoop1 { get; set; }
        [Pos(8)]
        public TSINVOIC_RTELoop1 RTELoop1 { get; set; }
        [ListCount(5)]
        [Pos(9)]
        public List<TSINVOIC_TAXLoop2> TAXLoop2 { get; set; }
    }
    
    [Serializable()]
    [Group("TAX")]
    public class TSINVOIC_TAXLoop2
    {
        
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        [Pos(2)]
        public MOA MOA { get; set; }
    }
    
    [Serializable()]
    [Group("RTE")]
    public class TSINVOIC_RTELoop1
    {
        
        [Required]
        [Pos(1)]
        public RTE RTE { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group("MOA")]
    public class TSINVOIC_MOALoop1
    {
        
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
        [Pos(3)]
        public CUX CUX { get; set; }
        [Pos(4)]
        public DTM DTM { get; set; }
    }
    
    [Serializable()]
    [Group("PCD")]
    public class TSINVOIC_PCDLoop1
    {
        
        [Required]
        [Pos(1)]
        public PCD PCD { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group("QTY")]
    public class TSINVOIC_QTYLoop1
    {
        
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        [Pos(2)]
        public RNG RNG { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop4
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("PAC")]
    public class TSINVOIC_PACLoop1
    {
        
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }
        [Pos(3)]
        public EQD EQD { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<TSINVOIC_PCILoop1> PCILoop1 { get; set; }
    }
    
    [Serializable()]
    [Group("PCI")]
    public class TSINVOIC_PCILoop1
    {
        
        [Required]
        [Pos(1)]
        public PCI PCI { get; set; }
        [Pos(2)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<GIN> GIN { get; set; }
    }
    
    [Serializable()]
    [Group("EQD")]
    public class TSINVOIC_EQDLoop1
    {
        
        [Required]
        [Pos(1)]
        public EQD EQD { get; set; }
        [ListCount(9)]
        [Pos(2)]
        public List<SEL> SEL { get; set; }
    }
    
    [Serializable()]
    [Group("TOD")]
    public class TSINVOIC_TODLoop1
    {
        
        [Required]
        [Pos(1)]
        public TOD TOD { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
    }
    
    [Serializable()]
    [Group("TDT")]
    public class TSINVOIC_TDTLoop1
    {
        
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }
        [Pos(2)]
        public TSR TSR { get; set; }
        [ListCount(10)]
        [Pos(3)]
        public List<TSINVOIC_LOCLoop1> LOCLoop1 { get; set; }
        [ListCount(9999)]
        [Pos(4)]
        public List<TSINVOIC_RFFLoop3> RFFLoop3 { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop3
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("LOC")]
    public class TSINVOIC_LOCLoop1
    {
        
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("PAT")]
    public class TSINVOIC_PATLoop1
    {
        
        [Required]
        [Pos(1)]
        public PAT PAT { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        [Pos(3)]
        public PCD PCD { get; set; }
        [Pos(4)]
        public MOA MOA { get; set; }
        [Pos(5)]
        public PAI PAI { get; set; }
        [Pos(6)]
        public FII FII { get; set; }
    }
    
    [Serializable()]
    [Group("CUX")]
    public class TSINVOIC_CUXLoop1
    {
        
        [Required]
        [Pos(1)]
        public CUX CUX { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("TAX")]
    public class TSINVOIC_TAXLoop1
    {
        
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }
        [Pos(2)]
        public MOA MOA { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<LOC> LOC { get; set; }
    }
    
    [Serializable()]
    [Group("NAD")]
    public class TSINVOIC_NADLoop1
    {
        
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }
        [ListCount(25)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<FII> FII { get; set; }
        [ListCount(99)]
        [Pos(4)]
        public List<MOA> MOA { get; set; }
        [ListCount(9999)]
        [Pos(5)]
        public List<TSINVOIC_RFFLoop2> RFFLoop2 { get; set; }
        [ListCount(5)]
        [Pos(6)]
        public List<TSINVOIC_DOCLoop1> DOCLoop1 { get; set; }
        [ListCount(5)]
        [Pos(7)]
        public List<TSINVOIC_CTALoop1> CTALoop1 { get; set; }
    }
    
    [Serializable()]
    [Group("CTA")]
    public class TSINVOIC_CTALoop1
    {
        
        [Required]
        [Pos(1)]
        public CTA CTA { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<COM> COM { get; set; }
    }
    
    [Serializable()]
    [Group("DOC")]
    public class TSINVOIC_DOCLoop1
    {
        
        [Required]
        [Pos(1)]
        public DOC DOC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop2
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop1
    {
        
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<GIR> GIR { get; set; }
        [ListCount(2)]
        [Pos(4)]
        public List<LOC> LOC { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<MEA> MEA { get; set; }
        [ListCount(2)]
        [Pos(6)]
        public List<QTY> QTY { get; set; }
        [ListCount(5)]
        [Pos(7)]
        public List<FTX> FTX { get; set; }
        [ListCount(2)]
        [Pos(8)]
        public List<MOA> MOA { get; set; }
        [ListCount(99)]
        [Pos(9)]
        public List<RTE> RTE { get; set; }
    }
}
