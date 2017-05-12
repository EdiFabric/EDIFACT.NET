//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Core.Model.Ack.X12
{
    [Serializable()]
    [Message("X12", "005010", "997")]
    public class TS997 : EdiMessage
    {
        
        [Pos(1)]
        public ST ST { get; set; }
        [Pos(2)]
        public AK1 AK1 { get; set; }
        [Pos(3)]
        public List<TS997_AK2Loop1> AK2Loop1 { get; set; }
        [Pos(4)]
        public AK9 AK9 { get; set; }
        [Pos(5)]
        public SE SE { get; set; }
    }
    
    [Serializable()]
    [Group("AK2")]
    public class TS997_AK2Loop1
    {
        
        [Pos(1)]
        public AK2 AK2 { get; set; }
        [Pos(2)]
        public List<TS997_AK3Loop1> AK3Loop1 { get; set; }
        [Pos(3)]
        public AK5 AK5 { get; set; }
    }
    
    [Serializable()]
    [Group("AK3")]
    public class TS997_AK3Loop1
    {
        
        [Pos(1)]
        public AK3 AK3 { get; set; }
        [Pos(2)]
        public List<AK4> AK4 { get; set; }
    }
}
