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

namespace EdiFabric.Framework.Constants
{
    /// <summary>
    /// Standard error codes.
    /// </summary>
    public enum ErrorCodes1
    {
        /// <summary>
        /// N/A
        /// </summary>
        Unknown,
        /// <summary>
        /// Success
        /// </summary>
        C0,
        /// <summary>
        /// The Interchange Control Numbers in the header ISA 13 and trailer IEA02 do not match
        /// Unrecognized segment ID
        /// Mandatory data element missing
        /// Transaction set not supported
        /// Functional group not supported
        /// </summary>
        C1,
        /// <summary>
        /// Standard in ISA11 (Control Standards) is not supported
        /// Unexpected segment
        /// Conditional required data element missing
        /// Transaction set trailer missing
        /// Functional group version not supported
        /// </summary>
        C2,
        /// <summary>
        /// Version of the controls is not supported
        /// Syntax version or level not supported
        /// Mandatory segment missing
        /// Too many data elements
        /// Transaction set control number in header and trailer do not match
        /// Functional group trailer missing
        /// </summary>
        C3,
        /// <summary>
        /// Segment Terminator is Invalid
        /// Loop occurs over maximum times
        /// Data element is too short
        /// Number of included segments does not match actual count
        /// Group control number in the functional group header and trailer do not agree
        /// </summary>
        C4,
        /// <summary>
        /// Invalid Interchange ID Qualifier for Sender
        /// Segment exceeds maximum use
        /// Data element is too long
        /// One or more segments in error
        /// Number of included transaction sets does not match actual count
        /// </summary>
        C5,
        /// <summary>
        /// Invalid Interchange Sender ID 
        /// Segment not in defined transaction set
        /// Invalid character in data element
        /// Missing or invalid transaction set identifier
        /// Group control number violates syntax (a duplicate group control number may have occurred)
        /// </summary>
        C6,
        /// <summary>
        /// Invalid Interchange ID Qualifier for Receiver
        /// Segment not in proper sequence
        /// Invalid code value
        /// Missing or invalid transaction set control number (a duplicate transaction number may have occurred)
        /// </summary>
        C7,
        /// <summary>
        /// Invalid Interchange Receiver ID
        /// Interchange recipient not actual recipient
        /// Segment has data element errors
        /// Invalid date
        /// </summary>
        C8,
        /// <summary>
        /// Unknown Interchange Receiver ID
        /// Invalid time
        /// </summary>
        C9,
        /// <summary>
        /// Invalid Authorization Information Qualifier value
        /// Exclusion condition violated
        /// </summary>
        C10,
        /// <summary>
        /// Invalid Authorization Information value
        /// </summary>
        C11,
        /// <summary>
        /// Invalid Security Information Qualifier value
        /// Invalid value
        /// </summary>
        C12,
        /// <summary>
        /// Invalid Security Information value
        /// Missing
        /// </summary>
        C13,
        /// <summary>
        /// Invalid Interchange Date value
        /// Value not supported in this position
        /// </summary>
        C14,
        /// <summary>
        /// Invalid Interchange Time value
        /// Not supported in this position
        /// </summary>
        C15,
        /// <summary>
        /// Invalid Interchange Standards Identifier value
        /// Too many constituents
        /// </summary>
        C16,
        /// <summary>
        /// Invalid Interchange Version ID value
        /// No agreement
        /// </summary>
        C17,
        /// <summary>
        /// Invalid Interchange Control Number value
        /// Unspecified error
        /// </summary>
        C18,
        /// <summary>
        /// Invalid Acknowledgment Requested value
        /// Invalid decimal notation
        /// </summary>
        C19,
        /// <summary>
        /// Invalid Test Indicator value
        /// Character invalid as service character
        /// </summary>
        C20,
        /// <summary>
        /// Invalid Number of Included Groups value
        /// Invalid character(s)
        /// </summary>
        C21,
        /// <summary>
        /// Invalid Control Structure
        /// Invalid service character(s)
        /// </summary>
        C22,
        /// <summary>
        /// Improper (Premature) End-of-File (Transmission)
        /// Unknown Interchange sender
        /// </summary>
        C23,
        /// <summary>
        /// Invalid Interchange Content (e.g., Invalid GS segment)
        /// Too old
        /// </summary>
        C24,
        /// <summary>
        /// Duplicate Interchange Control Number
        /// Test indicator not supported
        /// </summary>
        C25,
        /// <summary>
        /// Invalid Data Element Separator
        /// Duplicate detected
        /// </summary>
        C26,
        /// <summary>
        /// Invalid Component Element Separator
        /// Security function not supported
        /// </summary>
        C27,
        /// <summary>
        /// References do not match
        /// </summary>
        C28,
        /// <summary>
        /// Control count does not match number of instances received
        /// </summary>
        C29,
        /// <summary>
        /// Groups and messages/packages mixed
        /// </summary>
        C30,
        /// <summary>
        /// More than one message type in group
        /// </summary>
        C31,
        /// <summary>
        /// Lower level empty
        /// </summary>
        C32,
        /// <summary>
        /// Invalid occurrence outside message, package, or group
        /// </summary>
        C33,
        /// <summary>
        /// Nesting indicator not allowed
        /// </summary>
        C34,
        /// <summary>
        /// Too many data element or segment repetitions
        /// </summary>
        C35,
        /// <summary>
        /// Too many segment group repetitions
        /// </summary>
        C36,
        /// <summary>
        /// Invalid type of character(s)
        /// </summary>
        C37,
        /// <summary>
        /// Missing digit in front of decimal sign
        /// </summary>
        C38,
        /// <summary>
        /// Data element too long
        /// </summary>
        C39,
        /// <summary>
        /// Data element too short
        /// </summary>
        C40,
        /// <summary>
        /// Permanent communication network error
        /// </summary>
        C41,
        /// <summary>
        /// Temporary communication network error
        /// </summary>
        C42,
        /// <summary>
        /// Unknown interchange recipient
        /// </summary>
        C43,
        /// <summary>
        /// Trailing separator
        /// </summary>
        C45,
        /// <summary>
        /// Character set not supported
        /// </summary>
        C46,
        /// <summary>
        /// Envelope functionality not supported
        /// </summary>
        C47,
        /// <summary>
        /// Dependency Notes condition violated
        /// </summary>
        C48,
        /// <summary>
        /// Trailing separators encountered (custom code)
        /// </summary>
        C511
    }
}
