using System;
using System.Collections.Generic;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Rules.X12_002040.Rep
{
    [Serializable()]
    [Message("X12", "002050", "810", @"^(N1\*)")]
    public class TS810Split : EdiMessage
    {
        [Pos(1)]
        public ST ST { get; set; }
        [Required]
        [Pos(2)]
        public BIG BIG { get; set; }
        [ListCount(100)]
        [Pos(3)]
        public List<NTE> NTE { get; set; }
        [Pos(4)]
        public CUR CUR { get; set; }
        [ListCount(12)]
        [Pos(5)]
        public List<REF> REF { get; set; }
        [ListCount(3)]
        [Pos(6)]
        public List<PER> PER { get; set; }
        [ListCount(200)]
        [Pos(7)]
        public List<TS810_N1Loop1> N1Loop1 { get; set; }
        [ListCount(5)]
        [Pos(8)]
        public List<ITD> ITD { get; set; }
        [ListCount(10)]
        [Pos(9)]
        public List<DTM> DTM { get; set; }
        [Pos(10)]
        public FOB FOB { get; set; }
        [ListCount(200)]
        [Pos(11)]
        public List<PID> PID { get; set; }
        [ListCount(40)]
        [Pos(12)]
        public List<MEA> MEA { get; set; }
        [ListCount(25)]
        [Pos(13)]
        public List<PWK> PWK { get; set; }
        [ListCount(25)]
        [Pos(14)]
        public List<PKG> PKG { get; set; }
        [Pos(15)]
        public L7 L7 { get; set; }
        [ListCount(200000)]
        [Pos(16)]
        public List<TS810_IT1Loop1> IT1Loop1 { get; set; }
        [Required]
        [Pos(17)]
        public TDS TDS { get; set; }
        [ListCount(10)]
        [Pos(18)]
        public List<TXI> TXI { get; set; }
        [Pos(19)]
        public CAD CAD { get; set; }
        [ListCount(10)]
        [Pos(20)]
        public List<TS810_ITALoop2> ITALoop2 { get; set; }
        [ListCount(5)]
        [Pos(21)]
        public List<ISS> ISS { get; set; }
        [Required]
        [Pos(22)]
        public CTT CTT { get; set; }
        [Pos(23)]
        public SE SE { get; set; }
    }
}
