using System;
using EdiFabric.Core.Annotations.Edi;

namespace EdiFabric.Core.Model.Ack.X12
{
    [Serializable()]
    [Composite("C030")]
    public class C030
    {
        
        [Pos(1)]
        public string ElementPositioninSegment_01 { get; set; }
        [Pos(2)]
        public string ComponentDataElementPositioninComposite_02 { get; set; }
        [Pos(3)]
        public string RepeatingDataElementPosition_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C999")]
    public class C999
    {
        
        [Pos(1)]
        public string DataElementReferenceNumber_01 { get; set; }
        [Pos(2)]
        public string DataElementReferenceNumber_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C998")]
    public class C998
    {
        
        [Pos(1)]
        public string ContextName_01 { get; set; }
        [Pos(2)]
        public string ContextReference_02 { get; set; }
    }
}
