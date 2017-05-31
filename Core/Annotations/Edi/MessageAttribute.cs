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
    /// Attribute to mark a transaction set.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class MessageAttribute : EdiAttribute
    {
        /// <summary>
        /// EDI standard.
        /// </summary>
        public string Format { get; private set; }
        /// <summary>
        /// EDI version.
        /// </summary>
        public string Version { get; private set; }
        /// <summary>
        /// Specifies if the spec is for evaluation.
        /// </summary>
        public bool IsEvaluation { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageAttribute"/> class.
        /// </summary>
        /// <param name="format">EDI standard.</param>
        /// <param name="version">EDI version.</param>
        /// <param name="id">EDI transaction set id.</param>
        /// <param name="isEvaluation">Specifies if the spec is for evaluation.</param>
        public MessageAttribute(string format, string version, string id, bool isEvaluation = false)
            : base(id)
        {
            Format = format;
            Version = version;
            IsEvaluation = isEvaluation;
        }
    }
}
