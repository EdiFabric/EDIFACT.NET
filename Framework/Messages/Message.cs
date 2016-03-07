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
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace EdiFabric.Framework.Messages
{
    /// <summary>
    /// This class represents the internal EDI message and its context.
    /// </summary>
    /// <example>
    /// Add message to Interchange.
    /// <code lang="C#">
    /// var interchange = new Interchange();
    /// // Construct the object...
    /// var m_810 = new M_810();
    /// // Construct the message...
    /// var message = new Message(m_810);
    /// // Add the message to the interchange
    /// interchange.Groups[0].Messages.Add(message);
    /// </code>
    /// </example>
    public class Message
    {
        /// <summary>
        /// The EDI XML.
        /// </summary>
        public XElement Item { get; set; }

        /// <summary>
        /// The context. 
        /// </summary>
        public MessageContext Context { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// The parameterless constructor is needed for XML serialization.
        /// </summary>
        // ReSharper disable once UnusedMember.Local
        private Message()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="instance">
        /// Edi object.
        /// </param>
        /// <example>
        /// Set UNT segments count.
        /// <code lang="C#">
        /// var mInvoic = new M_INVOIC();
        /// // ... build the message
        ///                 
        /// var msg = new Message(mInvoic);
        /// var segCount = msg.Item.Descendants().Count(d => d.Name.LocalName.StartsWith("S_"));
        ///                 
        /// var nmn = new XmlNamespaceManager(new NameTable());
        /// nmn.AddNamespace("p", "www.edifabric.com/edifact");
        /// 
        /// var untSegCount = msg.Item.XPathSelectElement("./p:S_UNT/p:D_0074_1", nmn);
        /// untSegCount.SetValue(segCount);
        /// </code>
        /// </example>
        public Message(object instance)
        {
            Context = new MessageContext(instance.GetType());
            Item = EdiHelper.Serialize(instance);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="context">Edi XML.</param>
        /// <param name="item">Context.</param>
        public Message(XElement item, MessageContext context)
        {
            Context = context;
            Item = item;
        }

        /// <summary>
        /// Converts to object.
        /// </summary>
        /// <typeparam name="T">
        /// The type of object.
        /// </typeparam>
        /// <returns>
        /// The object.
        /// </returns>
        public T DeserializeItem<T>()
        {
            return Item.Deserialize<T>();
        }

        /// <summary>
        /// Validates the XML EDI against XSD.
        /// Dynamically finds the appropriate XSD from the validation assembly.
        /// </summary>
        /// <param name="definitionsAssemblyName">
        /// The assembly name of the project containing the classes.
        /// </param>
        /// <returns>
        /// List of broken rules.
        /// This lists out all of the validation failures.
        /// </returns>
        /// <example>
        /// Validate message with XSD in the default assembly EdiFabric.Validators.dll.
        /// <code lang="C#">
        /// var interchange = new Interchange();
        /// // Construct the object...
        /// List&lt;string&gt; brokenRules = (List&lt;string&gt;)interchange.Groups[0].Messages[0].Validate();
        /// </code>
        /// </example>
        public IEnumerable<string> Validate(string definitionsAssemblyName = null)
        {
            var validators = definitionsAssemblyName ?? GetAssemblyName();

            var result = new List<string>();
            var schemas = new XmlSchemaSet();

            // Find the assembly containing the XSD
            var assembly = Assembly.Load(new AssemblyName(validators));
            if (assembly == null)
                throw new Exception(
                    string.Format("Can't load assembly {0}. Please make sure your project has a reference to it.",
                        validators));

            // Build the XSD name
            var postfix = HipaaHelper.GetPostfix(Context.Origin);
            var format = Context.Format.ToString().ToUpper();
            if (Context.Format == EdiFormats.Edifact) format = "EFCT";
            var resource = string.Format("{0}.EF_{1}_{2}_{3}{4}.xsd", validators, format, Context.Version,
                Context.Tag, postfix != null ? "_" + postfix : "");

            // Get the XSD
            var stream = assembly.GetManifestResourceStream(resource);
            if (stream == null)
                throw new Exception(
                    string.Format(
                        "Can't find resource {0} in assembly {1}. Please make sure that it exists, VS default namespace is the same as the assembly name and its Build Action is set to Embedded Resource.",
                        resource, validators));

            schemas.Add(Item.Name.Namespace.NamespaceName, XmlReader.Create(stream));

            // Validate against the XSD
            var xDoc = new XDocument(Item);
            xDoc.Validate(schemas, (o, e) => result.Add(e.Message));

            return result;
        }

        /// <summary>
        /// Retrieves the validators assembly name.
        /// Returns the default if nothing was specified in the config. This is to ensure backwards compatibility with previous versions.
        /// </summary>
        /// <returns>
        /// The assembly name of the validators project.
        /// </returns>
        private static string GetAssemblyName()
        {
            try
            {
                return System.Configuration.ConfigurationManager.AppSettings["EdiFabric.Validators"] ?? "EdiFabric.Validators";
            }
            catch
            {
                return "EdiFabric.Validators";
            }

        }
    }
}
