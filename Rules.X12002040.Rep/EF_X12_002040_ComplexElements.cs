namespace EdiFabric.Rules.X12_002040.Rep
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Annotations.Edi;
    using EdiFabric.Annotations.Validation;

    [Serializable()]
    [Composite("C127")]
    public class C127
    {
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string C127_01 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string C127_02 { get; set; }
    }
}
