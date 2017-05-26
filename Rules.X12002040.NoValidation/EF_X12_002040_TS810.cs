namespace EdiFabric.Rules.X12_002040
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Message("X12", "002040", "810")]
    public class TS810NoValidation : EdiMessage
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
        [Pos(11)]
        public List<PID> PID { get; set; }
        [Pos(12)]
        public List<MEA> MEA { get; set; }
        [Pos(13)]
        public List<PWK> PWK { get; set; }
        [Pos(14)]
        public List<PKG> PKG { get; set; }
        [Pos(15)]
        public L7 L7 { get; set; }
        [Pos(16)]
        public List<TS810_IT1Loop1> IT1Loop1 { get; set; }
        [Pos(17)]
        public TDS TDS { get; set; }
        [Pos(18)]
        public List<TXI> TXI { get; set; }
        [Pos(19)]
        public CAD CAD { get; set; }
        [Pos(20)]
        public List<TS810_ITALoop2> ITALoop2 { get; set; }
        [Pos(21)]
        public List<ISS> ISS { get; set; }
        [Pos(22)]
        public CTT CTT { get; set; }
        [Pos(23)]
        public SE SE { get; set; }
    }
    
    [Serializable()]
    [Group("ITA")]
    public class TS810_ITALoop2
    {
        
        [Pos(1)]
        public ITA ITA { get; set; }
        [Pos(2)]
        public List<TXI> TXI { get; set; }
    }
    
    [Serializable()]
    [Group("IT1")]
    public class TS810_IT1Loop1
    {
        
        [Pos(1)]
        public IT1 IT1 { get; set; }
        [Pos(2)]
        public CUR CUR { get; set; }
        [Pos(3)]
        public List<IT3> IT3 { get; set; }
        [Pos(4)]
        public List<TXI> TXI { get; set; }
        [Pos(5)]
        public List<CTP> CTP { get; set; }
        [Pos(6)]
        public List<PID> PID { get; set; }
        [Pos(7)]
        public List<MEA> MEA { get; set; }
        [Pos(8)]
        public List<PWK> PWK { get; set; }
        [Pos(9)]
        public List<PKG> PKG { get; set; }
        [Pos(10)]
        public PO4 PO4 { get; set; }
        [Pos(11)]
        public List<ITD> ITD { get; set; }
        [Pos(12)]
        public List<REF> REF { get; set; }
        [Pos(13)]
        public List<PER> PER { get; set; }
        [Pos(14)]
        public List<SDQ> SDQ { get; set; }
        [Pos(15)]
        public List<DTM> DTM { get; set; }
        [Pos(16)]
        public List<CAD> CAD { get; set; }
        [Pos(17)]
        public List<L7> L7 { get; set; }
        [Pos(18)]
        public List<TS810_ITALoop1> ITALoop1 { get; set; }
        [Pos(19)]
        public List<TS810_SLNLoop1> SLNLoop1 { get; set; }
        [Pos(20)]
        public List<TS810_N1Loop2> N1Loop2 { get; set; }
    }
    
    [Serializable()]
    [Group("N1")]
    public class TS810_N1Loop2
    {
        
        [Pos(1)]
        public N1 N1 { get; set; }
        [Pos(2)]
        public List<N2> N2 { get; set; }
        [Pos(3)]
        public List<N3> N3 { get; set; }
        [Pos(4)]
        public N4 N4 { get; set; }
        [Pos(5)]
        public List<REF> REF { get; set; }
        [Pos(6)]
        public List<PER> PER { get; set; }
    }
    
    [Serializable()]
    [Group("SLN")]
    public class TS810_SLNLoop1
    {
        
        [Pos(1)]
        public SLN SLN { get; set; }
        [Pos(2)]
        public List<REF> REF { get; set; }
        [Pos(3)]
        public List<PID> PID { get; set; }
        [Pos(4)]
        public List<ITA> ITA { get; set; }
    }
    
    [Serializable()]
    [Group("ITA")]
    public class TS810_ITALoop1
    {
        
        [Pos(1)]
        public ITA ITA { get; set; }
        [Pos(2)]
        public List<TXI> TXI { get; set; }
    }
    
    [Serializable()]
    [Group("N1")]
    public class TS810_N1Loop1
    {
        
        [Pos(1)]
        public N1 N1 { get; set; }
        [Pos(2)]
        public List<N2> N2 { get; set; }
        [Pos(3)]
        public List<N3> N3 { get; set; }
        [Pos(4)]
        public N4 N4 { get; set; }
        [Pos(5)]
        public List<REF> REF { get; set; }
        [Pos(6)]
        public List<PER> PER { get; set; }
    }
}
