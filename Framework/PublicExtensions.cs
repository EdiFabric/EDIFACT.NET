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

        private static readonly ConcurrentDictionary<string, XmlSchemaSet> XsdCache =
            new ConcurrentDictionary<string, XmlSchemaSet>();

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
        public static IEnumerable<ValidationException> Validate(this object message, Stream xsd = null)
        {
            if (message == null)
                throw new ArgumentNullException("message");

            var result = new List<ValidationException>();
            
            var xDoc = message.Serialize();
            if (xDoc.Root == null)
                throw new Exception("Failed to serialize instance.");

            var schemas = xsd == null
                ? XsdCache.GetOrAdd(message.GetType().FullName,
                    NewSchemaSet(message.LoadXsd(), xDoc.Root.Name.Namespace.NamespaceName))
                : NewSchemaSet(xsd, xDoc.Root.Name.Namespace.NamespaceName);

            xDoc.Validate(schemas,
                (o, e) =>
                {
                    var errorCode = MapErrorCode(GetErrorCode(e));
                    var errorContext = BuildContext(o as XElement, schemas, errorCode);
                    if (errorCode == ErrorCodes.Unexpected)
                    {
                        if (errorContext.SegmentPosition == 0)
                            errorCode = ErrorCodes.RequiredMissing;

                        if (!string.IsNullOrEmpty(errorContext.DataElementName) &&
                            errorContext.DataElementPosition == 0)
                            errorCode = ErrorCodes.RequiredMissing;
                    }
                    result.Add(new ValidationException(errorCode, e.Message, errorContext));
                }, true);


            return result;
        }

        private static XmlSchemaSet NewSchemaSet(Stream xsd, string nameSpace)
        {
            var schemas = new XmlSchemaSet();

            using (var reader = XmlReader.Create(xsd))
            {
                schemas.Add(nameSpace, reader);
                schemas.Compile();
            }

            return schemas;
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

        private static ErrorContext BuildContext(XElement failedElement, XmlSchemaSet schemas, ErrorCodes errorCode)
        {
            try
            {
                if (failedElement != null && failedElement.Document != null)
                {
                    if (failedElement.Name.LocalName.StartsWith("D_", StringComparison.Ordinal))
                    {
                        return BuildDataElementContext(failedElement.Name.LocalName, failedElement.Parent, failedElement.Value);
                    }

                    if (errorCode == ErrorCodes.Unexpected && failedElement.Parent != null)
                        return ResolveUnexpected(failedElement.Parent, schemas);

                    if (errorCode == ErrorCodes.RequiredMissing)
                        return ResolveUnexpected(failedElement, schemas);

                    return null;
                }
            }
            catch
            {
                // ignored
            }

            return null;
        }

        private static ErrorContext BuildDataElementContext(string failedElement, XElement originalParent, string value)
        {
            if (originalParent == null || originalParent.Parent == null)
                return null;

            var element = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);

            if (originalParent.Document == null)
                return null;

            var segments = originalParent.Document.Descendants()
                            .Where(d => d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal))
                            .ToList();
            
            var context = new ErrorContext();

            var parent = originalParent;
            if (originalParent.Name.LocalName.StartsWith("C_", StringComparison.Ordinal))
            {
                parent = originalParent.Parent;
                if (parent == null)
                    return null;

                if (element != null)
                {
                    context.ComponentDataElementPosition = originalParent.Elements().ToList().IndexOf(element) + 1;
                    context.DataElementPosition = parent.Elements().ToList().IndexOf(originalParent) + 1;
                }
            }
            else
            {
                if (element != null)
                    context.DataElementPosition = originalParent.Elements().ToList().IndexOf(element) + 1;
            }

            context.SegmentName = ExtractName(parent.Name.LocalName);
            context.SegmentPosition = segments.IndexOf(parent) + 1;
            context.DataElementName = ExtractName(failedElement);
            if(element != null)
                context.RepetitionPosition = element.ElementsBeforeSelf().Count(e => e.Name.LocalName == failedElement) + 1;
            context.DataElementValue = value;

            return context;
        }

        private static ErrorContext BuildCompositeDataElementContext(string failedElement, XElement originalParent)
        {
            if (failedElement == null || originalParent == null || originalParent.Document == null)
                return null;

            var element = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);

            if (originalParent.Document == null)
                return null;

            var segments = originalParent.Document.Descendants()
                .Where(
                    d =>
                        d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal))
                .ToList();

            var dataElementPosition = element != null ? originalParent.Elements().ToList().IndexOf(element) + 1 : 0;
            var repetitionPosition = element != null ? element.ElementsBeforeSelf().Count(e => e.Name.LocalName == failedElement) + 1 : 0 ; 

            return new ErrorContext
            {
                DataElementName = ExtractName(failedElement),
                DataElementPosition = dataElementPosition,
                ComponentDataElementPosition = dataElementPosition,
                RepetitionPosition = repetitionPosition,
                SegmentName = ExtractName(originalParent.Name.LocalName),
                SegmentPosition = segments.IndexOf(originalParent) + 1
            };
        }

        private static ErrorContext BuildSegmentContext(string failedElement, XElement originalParent)
        {
            if (failedElement == null || originalParent == null || originalParent.Document == null)
                return null;
            
            var element = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);

            if (originalParent.Document == null)
                return null;

            var segments = originalParent.Document.Descendants()
                .Where(
                    d =>
                        d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal))
                .ToList();

            var segmentPosition = element != null ? segments.IndexOf(element) + 1 : 0;
            var repetitionPosition = element != null ? element.ElementsBeforeSelf().Count(e => e.Name.LocalName == failedElement) + 1 : 0; 

            return new ErrorContext
            {
                SegmentName = ExtractName(failedElement),
                SegmentPosition = segmentPosition,
                RepetitionPosition = repetitionPosition
            };
        }

        private static ErrorContext BuildOtherContext(XmlSchemaElement failedXsdElement, XElement originalParent)
        {
            if (failedXsdElement == null || originalParent == null || originalParent.Document == null)
                return null;

            var failedElement = failedXsdElement.QualifiedName.Name;

            var element = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);

            if (originalParent.Document == null)
                return null;

            var segments = originalParent.Document.Descendants()
                .Where(
                    d =>
                        d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal) ||
                        d.Name.LocalName == failedElement)
                .ToList();

            var segmentPosition = element != null ? segments.IndexOf(element) + 1 : 0;
            var repetitionPosition = element != null ? element.ElementsBeforeSelf().Count(e => e.Name.LocalName == failedElement) + 1 : 0;
            
            return new ErrorContext
            {
                SegmentName = ExtractName(GetName(failedXsdElement)),
                SegmentPosition = segmentPosition,
                RepetitionPosition = repetitionPosition
            };
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
                case "Sch_InvalidElementContentExpecting":
                    return ErrorCodes.Unexpected;
                case "Sch_IncompleteContent":
                case "Sch_IncompleteContentExpecting":
                    return ErrorCodes.RequiredMissing;
            }

            return ErrorCodes.Unknown;
        }

        private static ErrorContext ResolveUnexpected(XElement failedElement, XmlSchemaSet schemas)
        {
            foreach (XmlSchema schema in schemas.Schemas())
            {
                foreach (XmlSchemaElement element in schema.Elements.Values)
                {
                    if (element.QualifiedName.Name == failedElement.Name.LocalName)
                    {
                        var complexType = element.ElementSchemaType as XmlSchemaComplexType;

                        if (complexType != null)
                        {
                            XmlSchemaObjectCollection items = null;
                            var sequence = complexType.ContentTypeParticle as XmlSchemaSequence;
                            if (sequence != null)
                                items = sequence.Items;

                            if (sequence == null)
                            {
                                var all = complexType.ContentTypeParticle as XmlSchemaAll;
                                if (all != null)
                                    items = all.Items;
                            }

                            if (items == null) continue;

                            foreach (var item in items)
                            {
                                var childElement = (XmlSchemaElement) item;
                                var match = failedElement.Elements()
                                    .Where(e => e.Name.LocalName == childElement.QualifiedName.Name).ToList();

                                if ((!match.Any() && Decimal.ToInt32(childElement.MinOccurs) == 1) ||
                                    (match.Any() && Decimal.ToInt32(childElement.MaxOccurs) < match.Count))
                                {
                                    if (childElement.QualifiedName.Name.StartsWith("S_", StringComparison.Ordinal))
                                        return BuildSegmentContext(childElement.QualifiedName.Name,
                                            failedElement);

                                    if (childElement.QualifiedName.Name.StartsWith("C_", StringComparison.Ordinal))
                                        return BuildCompositeDataElementContext(childElement.QualifiedName.Name,
                                            failedElement);

                                    if (childElement.QualifiedName.Name.StartsWith("D_", StringComparison.Ordinal))
                                        return BuildDataElementContext(childElement.QualifiedName.Name,
                                            failedElement, null);

                                    return BuildOtherContext(childElement, failedElement);
                                }
                            }
                        }
                    }
                }
            }

            return null;
        }

        private static string GetName(XmlSchemaElement element)
        {
            var complexType = element.ElementSchemaType as XmlSchemaComplexType;
            if (complexType != null)
            {
                XmlSchemaObjectCollection items = null;
                var sequence = complexType.ContentTypeParticle as XmlSchemaSequence;
                if (sequence != null)
                    items = sequence.Items;

                if (sequence == null)
                {
                    var all = complexType.ContentTypeParticle as XmlSchemaAll;
                    if (all != null)
                        items = all.Items;
                }

                if (items == null) return null;

                foreach (var item in items)
                {
                    var childElement = (XmlSchemaElement)item;
                    if (childElement.QualifiedName.Name.StartsWith("S_", StringComparison.Ordinal))
                        return childElement.QualifiedName.Name;

                    return GetName(childElement);
                }
            }

            return null;
        }

        private static string ExtractName(string name)
        {
            var parts = name.Split('_');
            if (parts.Length < 2)
                return name;

            return parts[1];
        }
    }
}
