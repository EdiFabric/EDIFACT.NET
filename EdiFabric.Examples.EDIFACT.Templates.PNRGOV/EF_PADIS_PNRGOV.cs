namespace EdiFabric.Templates.Padis
{
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System;
    using System.Collections.Generic;

    [Serializable()]
    [Message("EDIFACT", "131", "PNRGOV")]
    public class TSPNRGOV : EdiMessage
    {
        
        [Pos(1)]
        public UNH UNH { get; set; }

        
        [Pos(2)]
        public MSG MSG { get; set; }

        
        [Pos(3)]
        public ORG ORG { get; set; }

        
        [Pos(4)]
        public TVL TVL { get; set; }

        
        [Pos(5)]
        public EQN EQN { get; set; }

        
        [Pos(7)]
        public List<GR1_SRCLoop> GR1_SRCLoop { get; set; }

        
        [Pos(8)]
        public UNT UNT { get; set; }
    }

    [Serializable()]
    [Group(typeof(SRC))]
    public class GR1_SRCLoop
    {

        
        [Pos(1)]
        public SRC SRC { get; set; }
        
        [Pos(2)]
        public RCI RCI { get; set; }
        
        [Pos(3)]
        public List<SSR> SSR { get; set; }
        [Pos(4)]
        public DAT DAT { get; set; }
        
        [Pos(5)]
        public List<IFT> IFT { get; set; }
        
        [Pos(6)]
        public ORG ORG { get; set; }
        
        [Pos(7)]
        public List<ADD> ADD { get; set; }
        
        [Pos(8)]
        public List<EBD> EBD { get; set; }
        
        [Pos(9)]
        public List<GR2_TIFLoop> GR2_TIFLoop { get; set; }
        
        [Pos(10)]
        public List<GR5_TVLLoop> GR5_TVLLoop { get; set; }
        
        [Pos(11)]
        public List<GR8_EQNLoop> GR8_EQNLoop { get; set; }
        
        [Pos(12)]
        public List<GR9_MSGLoop> GR9_MSGLoop { get; set; }
        
        [Pos(13)]
        public List<GR10_ABILoop> GR10_ABILoop { get; set; }
        
        [Pos(14)]
        public List<LTS> LTS { get; set; }

    }

    [Serializable()]
    [Group(typeof(TIF))]
    public class GR2_TIFLoop
    {

        
        [Pos(1)]
        public TIF TIF { get; set; }
        [Pos(2)]
        public FTI FTI { get; set; }
        
        [Pos(3)]
        public List<IFT> IFT { get; set; }
        [Pos(4)]
        public REF REF { get; set; }
        [Pos(5)]
        public EBD EBD { get; set; }
        
        [Pos(6)]
        public List<FAR> FAR { get; set; }
        
        [Pos(7)]
        public List<SSR> SSR { get; set; }
        
        [Pos(8)]
        public List<ADD> ADD { get; set; }
        
        [Pos(9)]
        public List<GR3_TKTLoop> GR3_TKTLoop { get; set; }
    }

    [Serializable()]
    [Group(typeof(TKT))]
    public class GR3_TKTLoop
    {

        
        [Pos(1)]
        public TKT TKT { get; set; }
        [Pos(2)]
        public MON MON { get; set; }
        [Pos(3)]
        public PTK PTK { get; set; }
        
        [Pos(4)]
        public List<TXD> TXD { get; set; }
        [Pos(5)]
        public DAT DAT { get; set; }
        [Pos(6)]
        public GR4_FOPLoop GR4_FOPLoop { get; set; }
    }

    [Serializable()]
    [Group(typeof(FOP))]
    public class GR4_FOPLoop
    {

        
        [Pos(1)]
        public FOP FOP { get; set; }
        [Pos(2)]
        public IFT IFT { get; set; }
        [Pos(3)]
        public ADD ADD { get; set; }
    }

    [Serializable()]
    [Group(typeof(TVL))]
    public class GR5_TVLLoop
    {

        
        [Pos(1)]
        public TVL TVL { get; set; }
        [Pos(2)]
        public TRA TRA { get; set; }
        [Pos(3)]
        public RPI RPI { get; set; }
        [Pos(4)]
        public APD APD { get; set; }
        
        [Pos(5)]
        public List<SSR> SSR { get; set; }
        [Pos(6)]
        public RCI RCI { get; set; }
        
        [Pos(7)]
        public List<IFT> IFT { get; set; }
        
        [Pos(8)]
        public List<GR6_DATLoop> GR6_DATLoop { get; set; }
    }

    [Serializable()]
    [Group(typeof(DAT))]
    public class GR6_DATLoop
    {

        
        [Pos(1)]
        public DAT DAT { get; set; }
        [Pos(2)]
        public ORG ORG { get; set; }
        
        [Pos(3)]
        public List<GR7_TRILoop> GR7_TRILoop { get; set; }
    }

    [Serializable()]
    [Group(typeof(TRI))]
    public class GR7_TRILoop
    {

        
        [Pos(1)]
        public TRI TRI { get; set; }
        [Pos(2)]
        public TIF TIF { get; set; }
        [Pos(3)]
        public SSD SSD { get; set; }
        [Pos(4)]
        public TBD TBD { get; set; }
    }

    [Serializable()]
    [Group(typeof(EQN))]
    public class GR8_EQNLoop
    {

        
        [Pos(1)]
        public EQN EQN { get; set; }
        
        [Pos(2)]
        public RCI RCI { get; set; }
    }

    [Serializable()]
    [Group(typeof(MSG))]
    public class GR9_MSGLoop
    {

        
        [Pos(1)]
        public MSG MSG { get; set; }
        
        [Pos(2)]
        public List<TVL> TVL { get; set; }
    }

    [Serializable()]
    [Group(typeof(ABI))]
    public class GR10_ABILoop
    {

        
        [Pos(1)]
        public ABI ABI { get; set; }
        [Pos(2)]
        public DAT DAT { get; set; }
        
        [Pos(3)]
        public List<GR11_SACLoop> GR11_SACLoop { get; set; }
    }

    [Serializable()]
    [Group(typeof(SAC))]
    public class GR11_SACLoop
    {

        
        [Pos(1)]
        public SAC SAC { get; set; }
        [Pos(2)]
        public TIF TIF { get; set; }
        [Pos(3)]
        public SSR SSR { get; set; }
        [Pos(4)]
        public IFT IFT { get; set; }
        [Pos(5)]
        public TBD TBD { get; set; }
        
        [Pos(6)]
        public List<GR12_TVLLoop> GR12_TVLLoop { get; set; }
    }

    [Serializable()]
    [Group(typeof(TVL))]
    public class GR12_TVLLoop
    {

        
        [Pos(1)]
        public TVL TVL { get; set; }
        [Pos(2)]
        public RPI RPI { get; set; }
    }
}
