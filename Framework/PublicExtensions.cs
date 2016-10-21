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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EdiFabric.Framework
{
    /// <summary>
    /// This class contains XML serialization and validation functionality.
    /// </summary>
    public static class PublicExtensions
    {
        private static readonly string XsdAssemblyName;
        private static readonly ConcurrentDictionary<string, XmlSerializer> SerializerCache =
            new ConcurrentDictionary<string, XmlSerializer>();

        static PublicExtensions()
        {
            try
            {
                XsdAssemblyName = ConfigurationManager.AppSettings["EdiFabric.XsdAssemblyName"];
            }
            catch(Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Validates an instance against XSD.
        /// </summary>
        /// <param name="message">The EDI instance.</param>
        /// <param name="xsd">The XSD to validate against. This is optional. 
        /// If not specified an XSD is loaded from the specified XSD assembly in the config.
        /// </param>
        /// <returns>A collection of validation errors.</returns>
        /// <exception cref="Exception">Throws an exception should the instance is not of ediFabric type.</exception>
        public static IEnumerable<string> Validate(this object message, Stream xsd = null)
        {
            if(message == null)
                throw new ArgumentNullException("message");

            var result = new List<string>();
            var schemas = new XmlSchemaSet();
            var xDoc = message.Serialize();
            if (xDoc.Root == null)
                throw new Exception("Failed to serialize instance.");

            if (xsd == null)
                xsd = message.LoadXsd();

            using (var reader = XmlReader.Create(xsd))
            {
                schemas.Add(xDoc.Root.Name.Namespace.NamespaceName, reader);
                xDoc.Validate(schemas, (o, e) => result.Add(e.Message));
            }

            return result;
        }

        /// <summary>
        /// Serializes an instance into XML.
        /// </summary>
        /// <param name="instance">The instance to serialize.</param>
        /// <returns>The instance serialized to XML.</returns>
        /// <exception cref="Exception">Throws an exception should the instance is not of ediFabric type.</exception>
        public static XDocument Serialize(this object instance)
        {
            if (instance == null)
                throw new ArgumentNullException("instance");

            var type = instance.GetType();
            
            var nameSpace = "www.edifabric.com/";
            if (type.FullName.Contains("X12"))
                nameSpace += "x12";
            else if (type.FullName.Contains("Edifact"))
                nameSpace += "edifact";
            else
                nameSpace = type.Namespace;
            
            var serializer = SerializerCache.GetOrAdd(type.FullName, new XmlSerializer(type, nameSpace));
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, instance);
                ms.Position = 0;
                return XDocument.Load(ms, LoadOptions.PreserveWhitespace);
            }
        }

        private static Stream LoadXsd(this object message)
        {
            if (XsdAssemblyName == null)
                throw new Exception("XsdAssemblyName not specified in config.");

            var type = message.GetType();
            var parts = type.FullName.Split('.');

            if(parts.Length < 2)
                throw new Exception(string.Format("Unable to determine XSD from {0}.", type));

            string format;
            var version = parts[parts.Length - 2];
            var tag = parts.Last().Replace("M_", "");
            if (version.StartsWith("X12", StringComparison.Ordinal))
            {
                version = version.Replace("X12", "");
                format = "X12";
            }
            else if (version.StartsWith("Edifact", StringComparison.Ordinal))
            {
                version = version.Replace("Edifact", "");
                format = "EDIFACT";
            }
            else
                throw new Exception(string.Format("Unable to determine XSD from {0}.", type));

            version = version.Replace(tag, "");

            var xsdName = "EF_" + format + "_" + version + "_" + tag + ".xsd";

            var result = Assembly.Load(new AssemblyName(XsdAssemblyName))
                    .GetManifestResourceStream(string.Format("{0}.{1}", XsdAssemblyName, xsdName));

            if (result == null)
                throw new Exception(
                    string.Format(
                        "Unable to load xsd {0} from project {1}. Ensure that the xsd exist in that project and its Build Action is set to Embedded Resource",
                        xsdName, XsdAssemblyName));

            return result;
        }
    }
}
