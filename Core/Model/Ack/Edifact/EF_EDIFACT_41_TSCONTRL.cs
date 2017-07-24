namespace EdiFabric.Rules.EDIFACT_41
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Message("EDIFACT", "41", "CONTRL")]
    public class TSCONTRL : EdiMessage
    {
        
        [Pos(1)]
        public UNH UNH { get; set; }
        [Required]
        [Pos(2)]
        public UCI UCI { get; set; }
        [ListCount(999999)]
        [Pos(3)]
        public List<TSCONTRL_UCMLoop> UCMLoop { get; set; }
        [ListCount(999999)]
        [Pos(4)]
        public List<TSCONTRL_UCFLoop> UCFLoop { get; set; }
        [Pos(5)]
        public UNT UNT { get; set; }
    }
    
    [Serializable()]
    [Group("UCF")]
    public class TSCONTRL_UCFLoop
    {
        
        [Required]
        [Pos(1)]
        public UCF UCF { get; set; }
        [ListCount(999999)]
        [Pos(2)]
        public List<TSCONTRL_UCMLoop> UCMLoop { get; set; }
    }
    
    [Serializable()]
    [Group("UCM")]
    public class TSCONTRL_UCMLoop
    {
        
        [Required]
        [Pos(1)]
        public UCM UCM { get; set; }
        [ListCount(999)]
        [Pos(2)]
        public List<TSCONTRL_UCSLoop> UCSLoop { get; set; }
    }
    
    [Serializable()]
    [Group("UCS")]
    public class TSCONTRL_UCSLoop
    {
        
        [Required]
        [Pos(1)]
        public UCS UCS { get; set; }
        [ListCount(99)]
        [Pos(2)]
        public List<UCD> UCD { get; set; }
    }
}
