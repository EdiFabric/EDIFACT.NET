using EdiFabric.Annotations.Model;

namespace EdiFabric.Rules.X12_002040
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Annotations.Edi;
    using EdiFabric.Annotations.Validation;
    
    
    [Serializable()]
    [Message("X12", "002040", "820")]
    public class TS8201 : EdiMessage
    {
    }
}
