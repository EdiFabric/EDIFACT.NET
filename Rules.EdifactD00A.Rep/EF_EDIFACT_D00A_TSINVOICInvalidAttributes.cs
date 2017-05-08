using EdiFabric.Annotations.Model;

namespace EdiFabric.Rules.EDIFACT_D00A.Rep
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Annotations.Edi;
    using EdiFabric.Annotations.Validation;
    
    
    [Serializable()]
    [Message("EDIFACT", "D00A", "InvAtt")]
    public class TSINVOICInvalidAttributes : EdiMessage
    {
        [StringLength(1, 10)]
        [Pos(1)]
        public UNH UNH { get; set; }
        [Required]
        [ListCount(15)]
        [Pos(2)]
        public All_Test PAI { get; set; }       
    }

}
