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
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework
{
    /// <summary>
    /// This class contains XML serialization and validation functionality.
    /// </summary>
    public static class PublicExtensions
    {
        private static readonly string XsdAssemblyName;
        private static readonly FieldInfo ValidationRes;

        private static readonly ConcurrentDictionary<string, XmlSerializer> SerializerCache =
            new ConcurrentDictionary<string, XmlSerializer>();

        static PublicExtensions()
        {
            try
            {
                XsdAssemblyName = ConfigurationManager.AppSettings["EdiFabric.XsdAssemblyName"];
                ValidationRes = typeof(XmlSchemaException).GetField("res", BindingFlags.NonPublic | BindingFlags.Instance);
            }
            catch (Exception)
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
        public static IEnumerable<ParsingException> Validate(this object message, Stream xsd = null)
        {
            if (message == null)
                throw new ArgumentNullException("message");

            var result = new List<ParsingException>();
            var schemas = new XmlSchemaSet();
            var xDoc = message.Serialize();
            if (xDoc.Root == null)
                throw new Exception("Failed to serialize instance.");

            if (xsd == null)
                xsd = message.LoadXsd();

            using (var reader = XmlReader.Create(xsd))
            {
                schemas.Add(xDoc.Root.Name.Namespace.NamespaceName, reader);
                xDoc.Validate(schemas,
                    (o, e) =>
                        result.Add(new ParsingException(MapErrorCode(GetErrorCode(e)), e.Message, null, BuildContext(o))));
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

            var nameSpace = type.Namespace;
            if (type.FullName.Contains("X12"))
                nameSpace = "www.edifabric.com/x12";
            if (type.FullName.Contains("Edifact"))
                nameSpace = "www.edifabric.com/edifact";

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

            if (parts.Length < 2)
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
                        "Unable to load xsd {0} from project {1}. Ensure that the xsd exist in that project and its Build Action is set to Embedded Resource.",
                        xsdName, XsdAssemblyName));

            return result;
        }

        private static ErrorContext BuildContext(object sender)
        {
            try
            {
                var failedElement = sender as XElement;

                if (failedElement != null && failedElement.Document != null)
                {
                    var messageSegments =
                        failedElement.Document.Descendants()
                            .Where(d => d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal))
                            .ToList();

                    if (failedElement.Name.LocalName.StartsWith("D_", StringComparison.Ordinal) ||
                        failedElement.Name.LocalName.StartsWith("C_", StringComparison.Ordinal))
                    {
                        return BuildDataElementContext(failedElement, messageSegments);
                    }

                    if (failedElement.Name.LocalName.StartsWith("S_", StringComparison.Ordinal) ||
                        failedElement.Name.LocalName.StartsWith("G_", StringComparison.Ordinal) ||
                        failedElement.Name.LocalName.StartsWith("A_", StringComparison.Ordinal) ||
                        failedElement.Name.LocalName.StartsWith("U_", StringComparison.Ordinal))
                    {
                        return BuildSegmentContext(failedElement, messageSegments);
                    }
                }
            }
            catch
            {
                // ignored
            }

            return null;
        }

        private static ErrorContext BuildDataElementContext(XElement failedElement, IList<XElement> segments)
        {
            if (failedElement.Parent == null || failedElement.Parent.Parent == null) return null;
            
            var context = new ErrorContext();
            var element = failedElement;
            var parent = failedElement.Parent;

            if (failedElement.Parent.Name.LocalName.StartsWith("C_", StringComparison.Ordinal))
            {
                element = failedElement.Parent;
                parent = failedElement.Parent.Parent;
                    
                context.ComponentDataElementPosition =
                    failedElement.Parent.Elements().ToList().IndexOf(failedElement) + 1;                    
            }

            context.SegmentName = parent.Name.LocalName;
            context.SegmentPosition = segments.IndexOf(parent) + 1;
            context.DataElementName = element.Name.LocalName;
            context.DataElementPosition = parent.Elements().ToList().IndexOf(element) + 1;
                
            if (context.DataElementName.StartsWith("D_", StringComparison.Ordinal))
                context.DataElementValue = element.Value;

            return context;
        }

        private static ErrorContext BuildSegmentContext(XElement failedElement, IList<XElement> segments)
        {
            var forLoop = false;
            var segment =
                failedElement.Descendants()
                    .FirstOrDefault(d => d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal));
            
            if (failedElement.Name.LocalName.StartsWith("S_", StringComparison.Ordinal))
                segment = failedElement;

            if (failedElement.Name.LocalName.StartsWith("G_", StringComparison.Ordinal) ||
                failedElement.Name.LocalName.StartsWith("U_", StringComparison.Ordinal))
                forLoop = true;
            
            if (segment != null)
                return new ErrorContext
                {
                    SegmentName = segment.Name.LocalName,
                    SegmentPosition = segments.IndexOf(segment) + 1,
                    SegmentForLoop = forLoop
                };

            return null;
        }

        private static string GetErrorCode(ValidationEventArgs e)
        {
            if (ValidationRes == null || e.Exception == null) return null;

            if (e.Exception.InnerException != null)
                return (string) ValidationRes.GetValue(e.Exception.InnerException);
            
            return (string) ValidationRes.GetValue(e.Exception);
        }

        private static ErrorCodes MapErrorCode(string errorCode)
        {
            switch (errorCode)
            {
                case "Sch_LengthConstraintFailed":
                    return ErrorCodes.DataElementLengthWrong;
                case "Sch_MinLengthConstraintFailed":
                    return ErrorCodes.DataElementTooShort;
                case "Sch_MaxLengthConstraintFailed":
                    return ErrorCodes.DataElementTooLong;
                case "Sch_EnumerationConstraintFailed":
                    return ErrorCodes.DataElementValueWrong;
                case "Sch_InvalidElementContent":
                    return ErrorCodes.TooManyRepetitions;
                case "Sch_InvalidElementContentExpecting":
                    return ErrorCodes.RequiredMissing;
                case "Sch_IncompleteContentExpecting":
                    return ErrorCodes.UnexpectedSegment;
            }

            return ErrorCodes.Unknown;
        }
    }
}
