namespace EdiFabric.Rules.EDIFACT_D00A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Message("EDIFACT", "D00A", "INVOIC")]
    public class TSINVOICEval : EdiMessage
    {
        
        [Pos(1)]
        public UNH UNH { get; set; }
        [Pos(2)]
        public BGM BGM { get; set; }
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        [Pos(4)]
        public PAI PAI { get; set; }
        [Pos(5)]
        public List<ALI> ALI { get; set; }
        [Pos(6)]
        public IMD IMD { get; set; }
        [Pos(7)]
        public List<FTX> FTX { get; set; }
        [Pos(8)]
        public List<LOC> LOC { get; set; }
        [Pos(9)]
        public List<GIS> GIS { get; set; }
        [Pos(10)]
        public DGS DGS { get; set; }
    }
}
