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
        public List<TSCONTRL_UCMLoop1> UCMLoop1 { get; set; }
        [ListCount(999999)]
        [Pos(4)]
        public List<TSCONTRL_UCFLoop1> UCFLoop1 { get; set; }
        [Pos(5)]
        public UNT UNT { get; set; }
    }
    
    [Serializable()]
    [Group("UCF")]
    public class TSCONTRL_UCFLoop1
    {
        
        [Required]
        [Pos(1)]
        public UCF UCF { get; set; }
        [ListCount(999999)]
        [Pos(2)]
        public List<TSCONTRL_UCMLoop2> UCMLoop2 { get; set; }
    }
    
    [Serializable()]
    [Group("UCM")]
    public class TSCONTRL_UCMLoop2
    {
        
        [Required]
        [Pos(1)]
        public UCM UCM { get; set; }
        [ListCount(999)]
        [Pos(2)]
        public List<TSCONTRL_UCSLoop2> UCSLoop2 { get; set; }
    }
    
    [Serializable()]
    [Group("UCS")]
    public class TSCONTRL_UCSLoop2
    {
        
        [Required]
        [Pos(1)]
        public UCS UCS { get; set; }
        [ListCount(99)]
        [Pos(2)]
        public List<UCD> UCD { get; set; }
    }
    
    [Serializable()]
    [Group("UCM")]
    public class TSCONTRL_UCMLoop1
    {
        
        [Required]
        [Pos(1)]
        public UCM UCM { get; set; }
        [ListCount(999)]
        [Pos(2)]
        public List<TSCONTRL_UCSLoop1> UCSLoop1 { get; set; }
    }
    
    [Serializable()]
    [Group("UCS")]
    public class TSCONTRL_UCSLoop1
    {
        
        [Required]
        [Pos(1)]
        public UCS UCS { get; set; }
        [ListCount(99)]
        [Pos(2)]
        public List<UCD> UCD { get; set; }
    }
}
