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

using EdiFabric.Attributes;

namespace EdiFabric.Framework.Controls.X12
{
    /// <summary>
    /// Interchange header.
    /// </summary>
    public class ISA : IEdiControl
    {
        [D(1)]
        public string AuthorizationInformationQualifier_1 { get; set; }

        [D(2)]
        public string AuthorizationInformation_2 { get; set; }

        [D(3)]
        public string SecurityInformationQualifier_3 { get; set; }

        [D(4)]
        public string SecurityInformation_4 { get; set; }

        [D(5)]
        public string SenderIDQualifier_5 { get; set; }

        [D(6)]
        public string InterchangeSenderID_6 { get; set; }

        [D(7)]
        public string ReceiverIDQualifier_7 { get; set; }

        [D(8)]
        public string InterchangeReceiverID_8 { get; set; }

        [D(9)]
        public string InterchangeDate_9 { get; set; }

        [D(10)]
        public string InterchangeTime_10 { get; set; }

        [D(11)]
        public string InterchangeControlStandardsIdentifier_11 { get; set; }

        [D(12)]
        public string InterchangeControlVersionNumber_12 { get; set; }

        [D(13)]
        public string InterchangeControlNumber_13 { get; set; }

        [D(14)]
        public string AcknowledgementRequested_14 { get; set; }

        [D(15)]
        public string UsageIndicator_15 { get; set; }

        [D(16)]
        public string ComponentElementSeparator_16 { get; set; }
    }

    /// <summary>
    /// Functional Group header.
    /// </summary>
    public class GS : IEdiControl
    {
        [D(1)]
        public string CodeIdentifyingInformationType_1 { get; set; }

        [D(2)]
        public string SenderIDCode_2 { get; set; }

        [D(3)]
        public string ReceiverIDCode_3 { get; set; }

        [D(4)]
        public string Date_4 { get; set; }

        [D(5)]
        public string Time_5 { get; set; }

        [D(6)]
        public string GroupControlNumber_6 { get; set; }

        [D(7)]
        public string TransactionTypeCode_7 { get; set; }

        [D(8)]
        public string VersionAndRelease_8 { get; set; }
    }

    /// <summary>
    /// Functional Group trailer.
    /// </summary>
    public class GE : IEdiControl
    {
        [D(1)]
        public string NumberOfIncludedSets_1 { get; set; }

        [D(2)]
        public string GroupControlNumber_2 { get; set; }
    }

    /// <summary>
    /// Interchange trailer.
    /// </summary>
    public class IEA : IEdiControl 
    {
        [D(1)]
        public string NumberOfIncludedGroups_1 { get; set; }

        [D(2)]
        public string InterchangeControlNumber_2 { get; set; }
    }

    /// <summary>
    /// Interchange acknowledgment.
    /// </summary>
    public class TA1 : IEdiControl
    {
        [D(1)]
        public string InterchangeControlNumber_1 { get; set; }

        [D(2)]
        public string InterchangeDate_2 { get; set; }

        [D(3)]
        public string InterchangeTime_3 { get; set; }

        [D(4)]
        public string InterchangeAcknowledgmentCode_4 { get; set; }

        [D(5)]
        public string InterchangeNoteCode_5 { get; set; }
    }      
}
