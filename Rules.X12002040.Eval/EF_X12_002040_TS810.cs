namespace EdiFabric.Rules.X12_002040
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Message("X12", "002040", "810")]
    public class TS810Eval : EdiMessage
    {
        
        [Pos(1)]
        public ST ST { get; set; }
        [Pos(2)]
        public BIG BIG { get; set; }
        [Pos(3)]
        public List<NTE> NTE { get; set; }
        [Pos(4)]
        public CUR CUR { get; set; }
        [Pos(5)]
        public List<REF> REF { get; set; }
        [Pos(6)]
        public List<PER> PER { get; set; }
        [Pos(7)]
        public List<TS810_N1Loop1> N1Loop1 { get; set; }
        [Pos(8)]
        public List<ITD> ITD { get; set; }
        [Pos(9)]
        public List<DTM> DTM { get; set; }
        [Pos(10)]
        public FOB FOB { get; set; }
    }
    
    [Serializable()]
    [Group("N1")]
    public class TS810_N1Loop1
    {
        
        [Pos(1)]
        public N1 N1 { get; set; }
        [Pos(2)]
        public List<N2> N2 { get; set; }
    }
}
