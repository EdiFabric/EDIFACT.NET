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

namespace EdiFabric.Core.Model.Edifact
{
    /// <summary>
    /// Functional Group header.
    /// </summary>
    [Serializable()]
    [Segment("UNG")]
    public class UNG : IEdiItem
    {
        [Pos(1)]
        public string MessageGroupIdentification_1 { get; set; }

        [Pos(2)]
        public S006 APPLICATIONSENDERIDENTIFICATION_2 { get; set; }

        [Pos(3)]
        public S007 APPLICATIONRECIPIENTIDENTIFICATION_3 { get; set; }

        [Pos(4)]
        public S004 DATEANDTIMEOFPREPARATION_4 { get; set; }

        [Pos(5)]
        public string GroupReferenceNumber_5 { get; set; }

        [Pos(6)]
        public string ControllingAgency_6 { get; set; }

        [Pos(7)]
        public S008 MESSAGEVERSION { get; set; }

        [Pos(8)]
        public string D_0058_8 { get; set; }
    }

    /// <summary>
    /// APPLICATION SENDER IDENTIFICATION.
    /// </summary>
    [Serializable()]
    [Composite("S006")]
    public class S006
    {
        [Pos(1)]
        public string ApplicationSenderIdentification_1 { get; set; }

        [Pos(2)]
        public string IdentificationCodeQualifier_2 { get; set; }
    }

    /// <summary>
    /// APPLICATION RECIPIENT IDENTIFICATION.
    /// </summary>
    [Serializable()]
    [Composite("S007")]
    public class S007
    {
        [Pos(1)]
        public string ApplicationRecipientIdentification_1 { get; set; }

        [Pos(2)]
        public string IdentificationCodeQualifier_2 { get; set; }
    }

    /// <summary>
    /// MESSAGE VERSION.
    /// </summary>
    [Serializable()]
    [Composite("S008")]
    public class S008
    {
        [Pos(1)]
        public string MessageVersionNumber_1 { get; set; }

        [Pos(2)]
        public string MessageReleaseNumber_2 { get; set; }

        [Pos(3)]
        public string AssociationAssignedCode_3 { get; set; }
    }
}
