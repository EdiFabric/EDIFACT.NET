using EdiFabric.Annotations.Model;

namespace EdiFabric.Rules.EDIFACT_D00A.Rep
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Annotations.Edi;
    using EdiFabric.Annotations.Validation;
    
    
    [Serializable()]
    [Message("EDIFACT", "D00A", "INVALL")]
    public class TSINVOICAll : EdiMessage
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
        public All_Test PAI { get; set; }
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

    [All()]
    public class All_Test
    {
        [Required]
        [Pos(1)]
        public PAI PAITest { get; set; }
        [Pos(2)]
        public UNH UNHTest { get; set; }
        [Required]
        [Pos(3)]
        public UNT UNTTest { get; set; }
    }
    
}
