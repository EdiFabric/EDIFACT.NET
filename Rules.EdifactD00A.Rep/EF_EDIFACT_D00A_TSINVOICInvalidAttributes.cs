using EdiFabric.Core.Annotations;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Rules.EDIFACT_D00A.Rep
{
    using System;
    using System.Collections.Generic;


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
