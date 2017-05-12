using System;
using System.Collections.Generic;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Core.Model.Ack.X12
{
    [Serializable()]
    [Message("X12", "005010", "999")]
    public class TS999 : EdiMessage
    {
        
        [Pos(1)]
        public ST ST { get; set; }
        [Pos(2)]
        public AK1 AK1 { get; set; }
        [Pos(3)]
        public List<TS999_AK2Loop1> AK2Loop1 { get; set; }
        [Pos(4)]
        public AK9 AK9 { get; set; }
        [Pos(5)]
        public SE SE { get; set; }
    }
    
    [Serializable()]
    [Group("AK2")]
    public class TS999_AK2Loop1
    {
        
        [Pos(1)]
        public AK2 AK2 { get; set; }
        [Pos(2)]
        public List<TS999_IK3Loop1> IK3Loop1 { get; set; }
        [Pos(3)]
        public IK5 IK5 { get; set; }
    }
    
    [Serializable()]
    [Group("IK3")]
    public class TS999_IK3Loop1
    {
        
        [Pos(1)]
        public IK3 IK3 { get; set; }
        [Pos(2)]
        public List<CTX> CTX { get; set; }
        [Pos(3)]
        public List<TS999_IK4Loop1> IK4Loop1 { get; set; }
    }
    
    [Serializable()]
    [Group("IK4")]
    public class TS999_IK4Loop1
    {
        
        [Pos(1)]
        public IK4 IK4 { get; set; }
        [Pos(2)]
        public List<CTX> CTX { get; set; }
    }
}
