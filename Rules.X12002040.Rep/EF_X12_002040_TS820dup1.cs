using EdiFabric.Core.Annotations;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Model;

namespace EdiFabric.Rules.X12_002040
{
    using System;
    using System.Collections.Generic;


    [Serializable()]
    [Message("X12", "002040", "820")]
    public class TS8201 : EdiMessage
    {
    }
}
