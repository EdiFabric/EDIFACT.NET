using EdiFabric.Annotations.Model;

namespace EdiFabric.Rules.EDIFACT_D00A.Rep
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Annotations.Edi;
    using EdiFabric.Annotations.Validation;
    
    
    [Serializable()]
    [Message("EDIFACT", "D00A", "NoAtt")]
    public class TSINVOICNoAttributes : EdiMessage
    {
        [Pos(1)]
        public UNH UNH { get; set; }
        [Pos(2)]
        public All_Test PAI { get; set; }       
    }

}
