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
using System.Linq;
using System.Reflection;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework
{
    /// <summary>
    /// The context of an EDI transaction set (or message).
    /// </summary>
    public class MessageContext
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
        /// The internal type of the relevant EDI spec.
        /// </summary>
        public Type SystemType { get; private set; }
        /// <summary>
        /// The name of XSD file of the EDI spec.
        /// </summary>
        public string XsdName
        {
            get
            {
                return "EF_" + Format + "_" + Version + "_" + Tag + ".xsd";
            }            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="tag">The message tag or ID.</param>
        /// <param name="controlNumber">The message control number.</param>
        /// <param name="version">The message version.</param>
        /// <param name="format">The message format.</param>
        /// <param name="rulesAssembly">The delegate to return the assembly containing the EDI classes.</param>
        /// <param name="rulesNamespacePrefix">The delegate to return the namespace prefix for the EDI classes. The default is EdiFabric.Rules.</param>
        public MessageContext(string tag, string controlNumber, string version, string format,
            Func<MessageContext, Assembly> rulesAssembly, Func<MessageContext, string> rulesNamespacePrefix)
        {
            Tag = tag;
            ControlNumber = controlNumber;
            Version = version;
            Format = format;
            SystemType = ToSystemType(rulesAssembly, rulesNamespacePrefix);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="message">The EDI document instance.</param>
        public MessageContext(object message)
        {
            var typeName = message.GetType().FullName;
            var parts = typeName.Split('.');

            if (parts.Length < 2)
                throw new Exception(string.Format("Unable to determine XSD from {0}.", typeName));

            Version = parts[parts.Length - 2];
            Tag = parts.Last().Replace("M_", "");
            if (Version.StartsWith("X12", StringComparison.Ordinal))
            {
                Version = Version.Replace("X12", "");
                Format = "X12";
            }
            else if (Version.StartsWith("Edifact", StringComparison.Ordinal))
            {
                Version = Version.Replace("Edifact", "");
                Format = "EDIFACT";
            }
            else
                throw new Exception(string.Format("Unable to determine XSD from {0}.", typeName));

            Version = Version.Replace(Tag, "");
            SystemType = message.GetType();
        }

        private Type ToSystemType(Func<MessageContext, Assembly> rulesAssembly, Func<MessageContext, string> rulesNamespacePrefix)
        {
            var assembly = rulesAssembly(this);
            var ns = rulesNamespacePrefix(this);
            var typeFullName = ns.TrimEnd('.') + "." + Format + Version + Tag + ".M_" + Tag;
            var errorMsg = String.Format(
                            "Type '{0}' was not found in assembly '{1}'.",
                            typeFullName, assembly.FullName);
            try
            {
                var systemType = Type.GetType(typeFullName + ", " + assembly.FullName);
                if (systemType == null)
                    throw new ParsingException(ErrorCodes.InvalidInterchangeContent, errorMsg, null,
                        new MessageErrorContext(Tag, ControlNumber, ErrorCodes.UnexpectedMessage));

                return systemType;
            }
            catch (Exception)
            {
                throw new ParsingException(ErrorCodes.UnexpectedMessage, errorMsg);
            }
        }
    }   
}
