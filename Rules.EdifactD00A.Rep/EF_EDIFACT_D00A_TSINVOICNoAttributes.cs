using EdiFabric.Core.Annotations;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Model;

namespace EdiFabric.Rules.EDIFACT_D00A.Rep
{
    using System;
    using System.Collections.Generic;


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
