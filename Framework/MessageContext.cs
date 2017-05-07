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

namespace EdiFabric.Framework
{
    /// <summary>
    /// The context of an EDI transaction set (or message).
    /// </summary>
    public sealed class MessageContext
    {
        /// <summary>
        /// The message tag or ID.
        /// </summary>
        public string Tag { get; private set; }
        /// <summary>
        /// The message control number.
        /// </summary>
        public string ControlNumber { get; private set; }
        /// <summary>
        /// The message version (derived from the group if not explicitly set in the message).
        /// </summary>
        public string Version { get; private set; }
        /// <summary>
        /// The message format (X12 or Edifact or other).
        /// </summary>
        public string Format { get; private set; }          

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="tag">The message tag or ID.</param>
        /// <param name="controlNumber">The message control number.</param>
        /// <param name="version">The message version.</param>
        /// <param name="format">The message format.</param>
        public MessageContext(string tag, string controlNumber, string version, string format)
        {
            if (string.IsNullOrEmpty(tag)) throw new ArgumentNullException("tag");
            if (string.IsNullOrEmpty(controlNumber)) throw new ArgumentNullException("controlNumber");
            if (string.IsNullOrEmpty(version)) throw new ArgumentNullException("version");
            if (string.IsNullOrEmpty(format)) throw new ArgumentNullException("format");
            
            Tag = tag;
            ControlNumber = controlNumber;
            Version = version;
            Format = format;
        }
    }   
}
