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
    /// Interchange header.
    /// </summary>
    public class UNB : IEdiItem
    {
        [C(1)]
        public S001 SYNTAXIDENTIFIER_1 { get; set; }

        [C(2)]
        public S002 INTERCHANGESENDER_2 { get; set; }

        [C(3)]
        public S003 INTERCHANGERECIPIENT_3 { get; set; }

        [C(4)]
        public S004 DATEANDTIMEOFPREPARATION_4 { get; set; }

        [D(5)]
        public string InterchangeControlReference_5 { get; set; }

        [C(6)]
        public S005 RECIPIENTSREFERENCEPASSWORDDETAILS_6 { get; set; }

        [D(7)]
        public string ApplicationReference_7 { get; set; }

        [D(8)]
        public string ProcessingPriorityCode_8 { get; set; }

        [D(9)]
        public string AcknowledgementRequest_9 { get; set; }

        [D(10)]
        public string InterchangeAgreementIdentifier_10 { get; set; }

        [D(11)]
        public string TestIndicator_11 { get; set; }
    }

    /// <summary>
    /// SYNTAX IDENTIFIER.
    /// </summary>
    public class S001
    {
        [D(1)]
        public string SyntaxIdentifier_1 { get; set; }

        [D(2)]
        public string SyntaxVersionNumber_2 { get; set; }

        [D(3)]
        public string ServiceCodeListDirectoryVersionNumber_3 { get; set; }

        [D(4)]
        public string CharacterEncoding_4 { get; set; }
    }

    /// <summary>
    /// INTERCHANGE SENDER.
    /// </summary>
    public class S002
    {
        [D(1)]
        public string InterchangeSenderIdentification_1 { get; set; }

        [D(2)]
        public string IdentificationCodeQualifier_2 { get; set; }

        [D(3)]
        public string InterchangeSenderInternalIdentification_3 { get; set; }

        [D(4)]
        public string InterchangeSenderInternalSubIdentification_4 { get; set; }
    }

    /// <summary>
    /// INTERCHANGE RECIPIENT.
    /// </summary>
    public class S003
    {
        [D(1)]
        public string InterchangeRecipientIdentification_1 { get; set; }

        [D(2)]
        public string IdentificationCodeQualifier_2 { get; set; }

        [D(3)]
        public string InterchangeRecipientInternalIdentification_3 { get; set; }

        [D(4)]
        public string InterchangeRecipientInternalSubIdentification_4 { get; set; }
    }

    /// <summary>
    /// DATE AND TIME OF PREPARATION.
    /// </summary>
    public class S004
    {
        [D(1)]
        public string Date_1 { get; set; }

        [D(2)]
        public string Time_2 { get; set; }
    }

    /// <summary>
    /// RECIPIENT'S REFERENCE/PASSWORD DETAILS.
    /// </summary>
    public class S005
    {
        [D(1)]
        public string RecipientReferencePassword_1 { get; set; }

        [D(2)]
        public string RecipientReferencePasswordQualifier_2 { get; set; }
    }
}
