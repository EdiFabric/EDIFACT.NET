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
    /// AK501 / TA104 . 
    /// </summary>
    public enum ErrorCodes2
    {
        /// <summary>
        /// N/A
        /// </summary>
        Unknown,
        /// <summary>
        /// Accepted
        /// </summary>
        A,
        /// <summary>
        /// Accepted, but errors were noted
        /// Interchange accepted with errors
        /// </summary>
        E,
        /// <summary>
        /// Rejected, message authentication code (MAC) failed
        /// </summary>
        M,
        /// <summary>
        /// Partially accepted, at least one transaction set was rejected
        /// </summary>
        P,
        /// <summary>
        /// Rejected
        /// Interchange rejected/suspended
        /// </summary>
        R,
        /// <summary>
        /// Rejected, assurance failed validity tests
        /// </summary>
        W,
        /// <summary>
        /// Rejected, content after decryption could not be analyzed
        /// </summary>
        X
    }
}
