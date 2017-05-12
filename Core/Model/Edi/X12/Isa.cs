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

namespace EdiFabric.Core.Model.Edi.X12
{
    /// <summary>
    /// Interchange header.
    /// </summary>
    [Serializable()]
    [Segment("ISA")]
    public class ISA : IEdiItem
    {
        [Pos(1)]
        public string AuthorizationInformationQualifier_1 { get; set; }

        [Pos(2)]
        public string AuthorizationInformation_2 { get; set; }

        [Pos(3)]
        public string SecurityInformationQualifier_3 { get; set; }

        [Pos(4)]
        public string SecurityInformation_4 { get; set; }

        [Pos(5)]
        public string SenderIDQualifier_5 { get; set; }

        [Pos(6)]
        public string InterchangeSenderID_6 { get; set; }

        [Pos(7)]
        public string ReceiverIDQualifier_7 { get; set; }

        [Pos(8)]
        public string InterchangeReceiverID_8 { get; set; }

        [Pos(9)]
        public string InterchangeDate_9 { get; set; }

        [Pos(10)]
        public string InterchangeTime_10 { get; set; }

        [Pos(11)]
        public string InterchangeControlStandardsIdentifier_11 { get; set; }

        [Pos(12)]
        public string InterchangeControlVersionNumber_12 { get; set; }

        [Pos(13)]
        public string InterchangeControlNumber_13 { get; set; }

        [Pos(14)]
        public string AcknowledgementRequested_14 { get; set; }

        [Pos(15)]
        public string UsageIndicator_15 { get; set; }

        [Pos(16)]
        public string ComponentElementSeparator_16 { get; set; }
    }
}
