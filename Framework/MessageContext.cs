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
using EdiFabric.Annotations.Edi;
using EdiFabric.Annotations.Model;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Parsers;

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
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="tag">The message tag or ID.</param>
        /// <param name="controlNumber">The message control number.</param>
        /// <param name="version">The message version.</param>
        /// <param name="format">The message format.</param>
        /// <param name="rulesAssembly">The delegate to return the assembly containing the EDI classes.</param>
        public MessageContext(string tag, string controlNumber, string version, string format,
            Func<MessageContext, Assembly> rulesAssembly)
        {
            Tag = tag;
            ControlNumber = controlNumber;
            Version = version;
            Format = format;
            SystemType = ToSystemType(rulesAssembly);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="message">The EDI document instance.</param>
        public MessageContext(EdiMessage message)
        {
            var type = message.GetType();
            var msgAttr = type.GetCustomAttribute<MessageAttribute>();
            if(msgAttr == null)
                throw new Exception(string.Format("[Message] attribute was not found in {0} .", type.FullName));

            Format = msgAttr.Format;
            Version = msgAttr.Version;
            Tag = msgAttr.Id;
            ControlNumber = GetControlNumber(message);
            SystemType = type;
        }

        private Type ToSystemType(Func<MessageContext, Assembly> rulesAssembly)
        {
            Assembly assembly;
            try
            {
                assembly = rulesAssembly(this);
            }
            catch (Exception ex)
            {
                throw new ParsingException(ErrorCodes.RulesAssemblyNotFound, ex.Message);
            }
            
            var matches = assembly.GetTypes().Where(m =>
            {
                var att = ((MessageAttribute)m.GetCustomAttribute(typeof(MessageAttribute)));
                if (att == null) return false;
                return att.Format == Format && att.Version == Version && att.Id == Tag;
            }).ToList();

            if (!matches.Any())
                HandleException(assembly, "Type with attribute'{0}' was not found in assembly '{1}'.", ErrorCodes.UnexpectedMessage);                
            
            if(matches.Count > 1)
                HandleException(assembly, "Multiple types with attribute'{0}' were found in assembly '{1}'.", ErrorCodes.DuplicateTypeFound); 

            return matches.First();
        }

        private string GetControlNumber(EdiMessage message)
        {
            var messageProperties = message.GetType().GetProperties().Sort();
            
            var firstProperty = messageProperties.FirstOrDefault();
            if (firstProperty == null)
                throw new Exception("Transaction set has no properties.");

            var firstValue = firstProperty.GetValue(message);

            if (Format == "X12")
            {
                var stProperties = firstValue.GetType().GetProperties().Sort();
                return stProperties.ElementAt(1).GetValue(firstValue) as string;               
            }

            if (Format == "EDIFACT")
            {
                var stProperties = firstValue.GetType().GetProperties().Sort();
                return stProperties.ElementAt(0).GetValue(firstValue) as string;
            }

            throw new NotImplementedException(Format);
        }

        private void HandleException(Assembly assembly, string message, ErrorCodes errorCode)
        {
            var attribute = "[Message(" + Format + ", " + Version + ", " + Tag + ")]";
            var errorMsg = String.Format(message, attribute, assembly.FullName);

            throw new ParsingException(errorCode, errorMsg);
        }
    }   
}
