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

using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace EdiFabric.Framework.Messages
{
    /// <summary>
    /// Message is edi xml with context 
    /// </summary>
    public class Message
    {
        /// <summary>
        /// The edi xml
        /// </summary>
        public XElement Item { get; set; }

        /// <summary>
        /// The context 
        /// </summary>
        public MessageContext Context { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// The parameterless constructor is needed for xml serialization
        /// </summary>
        private Message()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="instance">
        /// Edi object
        /// </param>
        public Message(object instance)
        {
            Context = new MessageContext(instance.GetType());
            Item = EdiHelper.Serialize(instance);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="context">Edi xml</param>
        /// <param name="item">Context</param>
        public Message(XElement item, MessageContext context)
        {
            Context = context;
            Item = item;
        }

        /// <summary>
        /// Converts to object
        /// </summary>
        /// <typeparam name="T">
        /// The type of object
        /// </typeparam>
        /// <returns>
        /// The object
        /// </returns>
        public T DeserializeItem<T>()
        {
            return Item.Deserialize<T>();
        }

        /// <summary>
        /// Validates the xml edi against xsd
        /// </summary>
        /// <returns>
        /// List of broken rules.
        /// </returns>
        public IEnumerable<string> Validate(string definitionsAssemblyName = null)
        {
            var validators = definitionsAssemblyName ?? GetAssemblyName();

            var result = new List<string>();
            var schemas = new XmlSchemaSet();

            // Find the assembly containing the xsd
            var assembly = Assembly.Load(new AssemblyName(validators));
            if (assembly == null)
                throw new ValidationException(
                    string.Format("Can't load assembly {0}. Please make sure your project has a reference to it.",
                        validators));

            // Build the xsd name
            var postfix = HipaaHelper.GetPostfix(Context.Origin);
            var format = Context.Format.ToString().ToUpper();
            if (Context.Format == EdiFormats.Edifact) format = "EFCT";
            var resource = string.Format("{0}.EF_{1}_{2}_{3}{4}.xsd", validators, format, Context.Version,
                Context.Tag, postfix != null ? "_" + postfix : "");

            // Get the xsd
            var stream = assembly.GetManifestResourceStream(resource);
            if (stream == null)
                throw new ValidationException(
                    string.Format(
                        "Can't find resource {0} in assembly {1}. Please make sure that it exists, VS default namespace is the same as the assembly name and its Build Action is set to Embedded Resource.",
                        resource, validators));

            schemas.Add(Item.Name.Namespace.NamespaceName, XmlReader.Create(stream));

            // Validate against the xsd
            var xDoc = new XDocument(Item);
            xDoc.Validate(schemas, (o, e) => result.Add(e.Message));

            return result;
        }

        public static string GetAssemblyName()
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
