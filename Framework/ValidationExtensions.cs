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

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EdiFabric.Framework
{
    /// <summary>
    /// This class contains XML serialization and validation functionality.
    /// </summary>
    public static class ValidationExtensions
    {
        private static readonly ConcurrentDictionary<string, XmlSerializer> SerializerCache =
            new ConcurrentDictionary<string, XmlSerializer>();

        /// <summary>
        /// Validates an EDIFACT instance.
        /// It serializes the instance to XML and validates the XML against the specified XSD.
        /// </summary>
        /// <param name="message">The instance to validate.</param>
        /// <param name="xsd">The XSD to validate against.</param>
        /// <typeparam name="T">The type of the instance.</typeparam>
        /// <returns>List of errors. An empty list if instance is valid.</returns>
        public static IEnumerable<string> ValidateEdifact<T>(this T message, Stream xsd)
        {
            return message.Validate(xsd, "www.edifabric.com/edifact");
        }

        /// <summary>
        /// Validates an X12 instance.
        /// It serializes the instance to XML and validates the XML against the specified XSD.
        /// </summary>
        /// <param name="message">The instance to validate.</param>
        /// <param name="xsd">The XSD to validate against.</param>
        /// <typeparam name="T">The type of the instance.</typeparam>
        /// <returns>List of errors. An empty list if instance is valid.</returns>
        public static IEnumerable<string> ValidateX12<T>(this T message, Stream xsd)
        {
            return message.Validate(xsd, "www.edifabric.com/x12");
        }

        private static IEnumerable<string> Validate<T>(this T message, Stream xsd, string nameSpace)
        {
            var result = new List<string>();
            var schemas = new XmlSchemaSet();
            var xDoc = message.Serialize(nameSpace);
            using (var reader = XmlReader.Create(xsd))
            {
                schemas.Add(nameSpace, reader);
                xDoc.Validate(schemas, (o, e) => result.Add(e.Message));
            }
            
            return result;
        }

        private static XDocument Serialize<T>(this T instance, string nameSpace)
        {
            var type = typeof (T);
            var serializer = SerializerCache.GetOrAdd(type.FullName, new XmlSerializer(type, nameSpace));
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, instance);
                ms.Position = 0;
                return XDocument.Load(ms, LoadOptions.PreserveWhitespace);
            }
        }
    }
}
