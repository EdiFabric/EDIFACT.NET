using System;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.X12;

namespace EdiFabric.Core.Model.Ack.X12
{
    [Serializable()]
    [Message("X12", "", "TA1")]
    public class TSTA1 : EdiMessage
    {
        [Pos(1)]
        public TA1 TA1 { get; set; }
    }
}
