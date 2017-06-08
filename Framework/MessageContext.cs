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
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Exceptions;

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
        public string Name { get; private set; }

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
        /// UNB 2.1 or ISA6 .
        /// </summary>
        public string SenderId { get; private set; }

        /// <summary>
        /// UNB 2.2 or ISA5 .
        /// </summary>
        public string SenderQualifier { get; private set; }

        /// <summary>
        /// UNB 3.1 or ISA8 .
        /// </summary>
        public string ReceiverId { get; private set; }

        /// <summary>
        /// UNB 3.2 or ISA7 .
        /// </summary>
        public string ReceiverQualifier { get; private set; }

        /// <summary>
        /// The type of message.
        /// </summary>
        public Type MessageType { get; private set; }

        /// <summary>
        /// Whether allows partial reading.
        /// </summary>
        public bool PartialAllowed { get; private set; }

         /// <summary>
        /// The value to split by.
        /// </summary>
        public string SplitterValue { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="name">The message tag or ID.</param>
        /// <param name="controlNumber">The message control number.</param>
        /// <param name="version">The message version.</param>
        /// <param name="format">The message format.</param>
        /// <param name="senderId">UNB 2.1 or ISA6 .</param>
        /// <param name="senderQualifier">UNB 2.2 or ISA5 .</param>
        /// <param name="receiverId">UNB 3.1 or ISA8 .</param>
        /// <param name="receiverQualifier">UNB 3.2 or ISA7 .</param>
        /// <param name="rulesAssembly">Delegate to retrieve the assembly containing the specs.</param>
        public MessageContext(string name, string controlNumber, string version, string format, string senderId,
            string senderQualifier, string receiverId, string receiverQualifier, Func<MessageContext, Assembly> rulesAssembly)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            if (string.IsNullOrEmpty(version)) throw new ArgumentNullException("version");
            if (string.IsNullOrEmpty(format)) throw new ArgumentNullException("format");
            if (string.IsNullOrEmpty(senderId)) throw new ArgumentNullException("senderId");
            if (string.IsNullOrEmpty(senderQualifier)) throw new ArgumentNullException("senderQualifier");
            if (string.IsNullOrEmpty(receiverId)) throw new ArgumentNullException("receiverId");
            if (string.IsNullOrEmpty(receiverQualifier)) throw new ArgumentNullException("receiverQualifier");

            Name = name;
            ControlNumber = controlNumber;
            Version = version;
            Format = format;
            SenderId = senderId;
            SenderQualifier = senderQualifier;
            ReceiverId = receiverId;
            ReceiverQualifier = receiverQualifier;

            ReadAttributes(rulesAssembly);
        }

        private void ReadAttributes(Func<MessageContext, Assembly> rulesAssembly)
        {
            if (rulesAssembly == null) throw new ArgumentNullException("rulesAssembly");

            if (MessageType != null)
                return;

            Assembly assembly;
            try
            {
                assembly = rulesAssembly(this);
            }
            catch (Exception ex)
            {
                var errorContext = new MessageErrorContext(Name, ControlNumber, 0, ex.Message,
                    MessageErrorCode.TransactionSetNotSupported);
                throw new ParserMessageException(errorContext);
            }

            var matches = assembly.GetTypes().Where(m =>
            {
                var att = ((MessageAttribute)m.GetCustomAttribute(typeof(MessageAttribute)));
                if (att == null) return false;

                if (att.Format == Format && att.Version == Version && att.Id == Name)
                {
                    PartialAllowed = att.IsEvaluation;
                    SplitterValue = att.Splitter;
                    return true;
                }
                return false;
            }).ToList();

            var attribute = "[Message(" + Format + ", " + Version + ", " + Name + ")]";

            if (!matches.Any())
            {
                var msg = String.Format("Type with attribute'{0}' was not found in assembly '{1}'.", attribute,
                    assembly.FullName);

                var errorContext = new MessageErrorContext(Name, ControlNumber, 0, msg,
                    MessageErrorCode.TransactionSetNotSupported);
                throw new ParserMessageException(errorContext);
            }

            if (matches.Count > 1)
            {
                var msg = String.Format("Multiple types with attribute'{0}' were found in assembly '{1}'.", attribute,
                    assembly.FullName);

                var errorContext = new MessageErrorContext(Name, ControlNumber, 0, msg,
                                   MessageErrorCode.TransactionSetNotSupported);
                throw new ParserMessageException(errorContext);
            }

            MessageType = matches.First();
        }
    }
}
