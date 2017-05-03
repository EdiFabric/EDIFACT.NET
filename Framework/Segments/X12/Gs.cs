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
using EdiFabric.Annotations.Edi;
using EdiFabric.Annotations.Model;

namespace EdiFabric.Framework.Segments.X12
{
    /// <summary>
    /// Functional Group header.
    /// </summary>
    [Serializable()]
    [Segment("GS")]
    public class GS : IEdiItem
    {
        [Pos(1)]
        public string CodeIdentifyingInformationType_1 { get; set; }

        [Pos(2)]
        public string SenderIDCode_2 { get; set; }

        [Pos(3)]
        public string ReceiverIDCode_3 { get; set; }

        [Pos(4)]
        public string Date_4 { get; set; }

        [Pos(5)]
        public string Time_5 { get; set; }

        [Pos(6)]
        public string GroupControlNumber_6 { get; set; }

        [Pos(7)]
        public string TransactionTypeCode_7 { get; set; }

        [Pos(8)]
        public string VersionAndRelease_8 { get; set; }
    }
}
