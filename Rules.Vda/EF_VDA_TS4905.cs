using System;
using System.Collections.Generic;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Rules.Vda
{
    [Serializable()]
    [Message("VDA", "1", "4905")]
    public class TS4905 : EdiMessage
    {
        [Required]
        [Pos(1)]
        public S511 S511 { get; set; }

        [Required]
        [Pos(2)]
        public List<TS4905_S512Loop> S512Loop { get; set; }

        [Required]
        [Pos(3)]
        public S519 S519 { get; set; }        
    }
    
    [Serializable()]
    [Group("512")]
    public class TS4905_S512Loop
    {
        
        [Required]
        [Pos(1)]
        public S512 S512 { get; set; }

        [Required]
        [Pos(2)]
        public S513 S513 { get; set; }

        [Pos(3)]
        public List<S514> S514 { get; set; }

        [Pos(4)]
        public S515 S515 { get; set; }

        [Pos(5)]
        public List<S517> S517 { get; set; }
        
        [ListCount(5)]
        [Pos(6)]
        public List<S518> S518 { get; set; }
        
    }
}
