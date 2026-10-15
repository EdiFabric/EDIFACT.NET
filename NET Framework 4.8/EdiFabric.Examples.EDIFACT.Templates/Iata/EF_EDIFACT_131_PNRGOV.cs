namespace EdiFabric.Templates.Iata131
{
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    [DataContract()]
    [Serializable()]
    [Message("EDIFACT", "PNRGOV")]
    public class TSPNRGOV : EdiMessage
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual UNH UNH { get; set; }

        [Required]
        [DataMember()]
        [Pos(2)]
        public virtual MSG MSG { get; set; }

        [Required]
        [DataMember()]
        [Pos(3)]
        public virtual ORG ORG { get; set; }

        [Required]
        [DataMember()]
        [Pos(4)]
        public virtual TVL TVL { get; set; }

        [Required]
        [DataMember()]
        [Pos(5)]
        public virtual EQN EQN { get; set; }

        [ListCount(999)]
        [DataMember()]
        [Pos(7)]
        public virtual List<GR1_SRCLoop> GR1_SRCLoop { get; set; }

        [Required]
        [DataMember()]
        [Pos(8)]
        public virtual UNT UNT { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(SRC))]
    public class GR1_SRCLoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual SRC SRC { get; set; }
        [Required]
        [DataMember()]
        [Pos(2)]
        public virtual RCI RCI { get; set; }
        [ListCount(999)]
        [DataMember()]
        [Pos(3)]
        public virtual List<SSR> SSR { get; set; }
        [DataMember()]
        [Pos(4)]
        public virtual DAT DAT { get; set; }
        [ListCount(999)]
        [DataMember()]
        [Pos(5)]
        public virtual List<IFT> IFT { get; set; }
        [Required]
        [DataMember()]
        [Pos(6)]
        public virtual ORG ORG { get; set; }
        [ListCount(99)]
        [DataMember()]
        [Pos(7)]
        public virtual List<ADD> ADD { get; set; }
        [ListCount(9)]
        [DataMember()]
        [Pos(8)]
        public virtual List<EBD> EBD { get; set; }
        [ListCount(999)]
        [DataMember()]
        [Pos(9)]
        public virtual List<GR2_TIFLoop> GR2_TIFLoop { get; set; }
        [ListCount(999)]
        [DataMember()]
        [Pos(10)]
        public virtual List<GR5_TVLLoop> GR5_TVLLoop { get; set; }
        [ListCount(99)]
        [DataMember()]
        [Pos(11)]
        public virtual List<GR8_EQNLoop> GR8_EQNLoop { get; set; }
        [ListCount(9)]
        [DataMember()]
        [Pos(12)]
        public virtual List<GR9_MSGLoop> GR9_MSGLoop { get; set; }
        [ListCount(999)]
        [DataMember()]
        [Pos(13)]
        public virtual List<GR10_ABILoop> GR10_ABILoop { get; set; }
        [ListCount(9)]
        [DataMember()]
        [Pos(14)]
        public virtual List<LTS> LTS { get; set; }

    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(TIF))]
    public class GR2_TIFLoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual TIF TIF { get; set; }
        [DataMember()]
        [Pos(2)]
        public virtual FTI FTI { get; set; }
        [ListCount(99)]
        [DataMember()]
        [Pos(3)]
        public virtual List<IFT> IFT { get; set; }
        [DataMember()]
        [Pos(4)]
        public virtual REF REF { get; set; }
        [DataMember()]
        [Pos(5)]
        public virtual EBD EBD { get; set; }
        [ListCount(9)]
        [DataMember()]
        [Pos(6)]
        public virtual List<FAR> FAR { get; set; }
        [ListCount(999)]
        [DataMember()]
        [Pos(7)]
        public virtual List<SSR> SSR { get; set; }
        [ListCount(99)]
        [DataMember()]
        [Pos(8)]
        public virtual List<ADD> ADD { get; set; }
        [ListCount(999)]
        [DataMember()]
        [Pos(9)]
        public virtual List<GR3_TKTLoop> GR3_TKTLoop { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(TKT))]
    public class GR3_TKTLoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual TKT TKT { get; set; }
        [DataMember()]
        [Pos(2)]
        public virtual MON MON { get; set; }
        [DataMember()]
        [Pos(3)]
        public virtual PTK PTK { get; set; }
        [ListCount(99)]
        [DataMember()]
        [Pos(4)]
        public virtual List<TXD> TXD { get; set; }
        [DataMember()]
        [Pos(5)]
        public virtual DAT DAT { get; set; }
        [DataMember()]
        [Pos(6)]
        public virtual GR4_FOPLoop GR4_FOPLoop { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(FOP))]
    public class GR4_FOPLoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual FOP FOP { get; set; }
        [DataMember()]
        [Pos(2)]
        public virtual IFT IFT { get; set; }
        [DataMember()]
        [Pos(3)]
        public virtual ADD ADD { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(TVL))]
    public class GR5_TVLLoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual TVL TVL { get; set; }
        [DataMember()]
        [Pos(2)]
        public virtual TRA TRA { get; set; }
        [DataMember()]
        [Pos(3)]
        public virtual RPI RPI { get; set; }
        [DataMember()]
        [Pos(4)]
        public virtual APD APD { get; set; }
        [ListCount(99)]
        [DataMember()]
        [Pos(5)]
        public virtual List<SSR> SSR { get; set; }
        [DataMember()]
        [Pos(6)]
        public virtual RCI RCI { get; set; }
        [ListCount(99)]
        [DataMember()]
        [Pos(7)]
        public virtual List<IFT> IFT { get; set; }
        [ListCount(999)]
        [DataMember()]
        [Pos(8)]
        public virtual List<GR6_DATLoop> GR6_DATLoop { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(DAT))]
    public class GR6_DATLoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual DAT DAT { get; set; }
        [DataMember()]
        [Pos(2)]
        public virtual ORG ORG { get; set; }
        [ListCount(999)]
        [DataMember()]
        [Pos(3)]
        public virtual List<GR7_TRILoop> GR7_TRILoop { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(TRI))]
    public class GR7_TRILoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual TRI TRI { get; set; }
        [DataMember()]
        [Pos(2)]
        public virtual TIF TIF { get; set; }
        [DataMember()]
        [Pos(3)]
        public virtual SSD SSD { get; set; }
        [DataMember()]
        [Pos(4)]
        public virtual TBD TBD { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(EQN))]
    public class GR8_EQNLoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual EQN EQN { get; set; }
        [Required]
        [DataMember()]
        [Pos(2)]
        public virtual RCI RCI { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(MSG))]
    public class GR9_MSGLoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual MSG MSG { get; set; }
        [ListCount(99)]
        [DataMember()]
        [Pos(2)]
        public virtual List<TVL> TVL { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(ABI))]
    public class GR10_ABILoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual ABI ABI { get; set; }
        [DataMember()]
        [Pos(2)]
        public virtual DAT DAT { get; set; }
        [ListCount(99)]
        [DataMember()]
        [Pos(3)]
        public virtual List<GR11_SACLoop> GR11_SACLoop { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(SAC))]
    public class GR11_SACLoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual SAC SAC { get; set; }
        [DataMember()]
        [Pos(2)]
        public virtual TIF TIF { get; set; }
        [DataMember()]
        [Pos(3)]
        public virtual SSR SSR { get; set; }
        [DataMember()]
        [Pos(4)]
        public virtual IFT IFT { get; set; }
        [DataMember()]
        [Pos(5)]
        public virtual TBD TBD { get; set; }
        [ListCount(2)]
        [DataMember()]
        [Pos(6)]
        public virtual List<GR12_TVLLoop> GR12_TVLLoop { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(TVL))]
    public class GR12_TVLLoop
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        [Required]
        [DataMember()]
        [Pos(1)]
        public virtual TVL TVL { get; set; }
        [DataMember()]
        [Pos(2)]
        public virtual RPI RPI { get; set; }
    }
}
