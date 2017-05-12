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
