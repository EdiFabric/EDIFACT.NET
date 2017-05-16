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

namespace EdiFabric.Core.Annotations.Edi
{
    /// <summary>
    /// Attribute for EDI codes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class EdiCodesAttribute : Attribute
    {
        /// <summary>
        /// The list of EDI codes.
        /// </summary>
        public string Codes { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdiCodesAttribute"/> class.
        /// </summary>
        /// <param name="codes"></param>
        public EdiCodesAttribute(string codes)
        {
            Codes = codes;
        }
    }
}
