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

namespace EdiFabric.Framework.Segments.Edifact
{
    /// <summary>
    /// Functional Group header.
    /// </summary>
    public class UNG : IEdiItem
    {
        [D(1)]
        public string MessageGroupIdentification_1 { get; set; }

        [C(2)]
        public S006 APPLICATIONSENDERIDENTIFICATION_2 { get; set; }

        [C(3)]
        public S007 APPLICATIONRECIPIENTIDENTIFICATION_3 { get; set; }

        [C(4)]
        public S004 DATEANDTIMEOFPREPARATION_4 { get; set; }

        [D(5)]
        public string GroupReferenceNumber_5 { get; set; }

        [D(6)]
        public string ControllingAgency_6 { get; set; }

        [C(7)]
        public S008 MESSAGEVERSION { get; set; }

        [D(8)]
        public string D_0058_8 { get; set; }
    }

    /// <summary>
    /// APPLICATION SENDER IDENTIFICATION.
    /// </summary>
    public class S006
    {
        [D(1)]
        public string ApplicationSenderIdentification_1 { get; set; }

        [D(2)]
        public string IdentificationCodeQualifier_2 { get; set; }
    }

    /// <summary>
    /// APPLICATION RECIPIENT IDENTIFICATION.
    /// </summary>
    public class S007
    {
        [D(1)]
        public string ApplicationRecipientIdentification_1 { get; set; }

        [D(2)]
        public string IdentificationCodeQualifier_2 { get; set; }
    }

    /// <summary>
    /// MESSAGE VERSION.
    /// </summary>
    public class S008
    {
        [D(1)]
        public string MessageVersionNumber_1 { get; set; }

        [D(2)]
        public string MessageReleaseNumber_2 { get; set; }

        [D(3)]
        public string AssociationAssignedCode_3 { get; set; }
    }
}
