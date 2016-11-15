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
        /// <returns>A collection of validation errors.</returns>
        /// <exception cref="Exception">Throws an exception should the instance is not of ediFabric type.</exception>
        public static ValidationException Validate(this object message)
        {
            if (message == null)
                throw new ArgumentNullException("message");

            var xDoc = message.Serialize();
            if (xDoc.Root == null)
                throw new Exception("Failed to serialize instance.");

            var schemas = XsdCache.GetOrAdd(message.GetType().FullName,
                NewSchemaSet(message.LoadXsd(), xDoc.Root.Name.Namespace.NamespaceName));

            string messageName;
            string controlNumber;
            string format;
            if (!TryGetMessageContext(xDoc.Root, out messageName, out controlNumber, out format))
            {
                throw new Exception("Failed to extract message context.");
            }

            var messageContext = new MessageErrorContext(messageName, controlNumber);
            xDoc.Validate(schemas,
                (o, e) =>
                {
                    var errorCode = MapErrorCode(GetErrorCode(e));
                    var segmentContext = BuildContext(o as XElement, schemas, errorCode);
                    messageContext.Add(segmentContext);
                });

            if (messageContext.Codes.Any() || messageContext.Errors.Any())
                return new ValidationException("Validation Errors.", messageContext);

            // TODO: add message structure validation
            
            return null;
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

        private static bool TryGetMessageContext(XElement xml, out string messageName, out string controlNumber, out string format)
        {
            try
            {
                var st =
                    xml.Elements().SingleOrDefault(e => e.Name.LocalName.StartsWith("S_ST", StringComparison.Ordinal));
                if (st != null)
                {
                    messageName = st.Elements().ElementAt(0).Value;
                    controlNumber = st.Elements().ElementAt(1).Value;
                    format = "X12";
                    return true;
                }
                var unh =
                    xml.Elements().SingleOrDefault(e => e.Name.LocalName.StartsWith("S_UNH", StringComparison.Ordinal));
                if (unh != null)
                {
                    controlNumber = unh.Elements().ElementAt(0).Value;
                    messageName = unh.Elements().ElementAt(1).Elements().ElementAt(0).Value;
                    format = "Edifact";
                    return true;
                }
            }
            catch
            {
                // ignored
            }

            messageName = null;
            controlNumber = null;
            format = null;

            return false;
        }

        private static string GetErrorCode(ValidationEventArgs e)
        {
            if (ValidationRes == null || e.Exception == null) return null;

            if (e.Exception.InnerException != null)
                return (string)ValidationRes.GetValue(e.Exception.InnerException);

            return (string)ValidationRes.GetValue(e.Exception);
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
        
        private static SegmentErrorContext BuildContext(XElement failedElement, XmlSchemaSet schemas, ErrorCodes errorCode)
        {
            if (failedElement == null)
                return null;

            try
            {
                if (failedElement.Name.LocalName.StartsWith("D_", StringComparison.Ordinal))
                    return BuildDataElementContext(failedElement.Name.LocalName, failedElement.Parent,
                        failedElement.Value, errorCode);

                if (errorCode == ErrorCodes.Unexpected)
                    return ResolveUnexpected(failedElement.Parent, schemas, errorCode);

                if (errorCode == ErrorCodes.RequiredMissing)
                    return ResolveUnexpected(failedElement, schemas, errorCode);
            }
            catch
            {
                // ignored
            }

            return null;
        }

        private static SegmentErrorContext BuildDataElementContext(string failedElement, XElement originalParent, string value, ErrorCodes errorCode)
        {
            if (failedElement == null || originalParent == null || originalParent.Parent == null || originalParent.Document == null)
                return null;

            //var element = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);
            var segments = originalParent.Document.Descendants()
                            .Where(d => d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal))
                            .ToList();

            var parent = originalParent.Name.LocalName.StartsWith("C_", StringComparison.Ordinal)
                ? originalParent.Parent
                : originalParent;
            var context = new SegmentErrorContext(ExtractName(parent.Name.LocalName), segments.IndexOf(parent) + 1);
            
            string dataElementName = ExtractName(failedElement);
            int componentDataElementPosition = 0;
            int dataElementPosition = 0;
            int repetitionDataElementPosition = 0;
            var lastElement = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);
            var firstElement = originalParent.Elements().FirstOrDefault(e => e.Name.LocalName == failedElement);
            if (lastElement != null && firstElement != null)
            {
                if (originalParent.Name.LocalName.StartsWith("C_", StringComparison.Ordinal))
                {
                    componentDataElementPosition = originalParent.Elements().ToList().IndexOf(lastElement) + 1;
                    dataElementPosition = parent.Elements().ToList().IndexOf(originalParent) + 1;
                }
                else
                {
                    dataElementPosition = parent.Elements().ToList().IndexOf(firstElement) + 1;
                }

                repetitionDataElementPosition = lastElement.ElementsBeforeSelf().Count(e => e.Name.LocalName == failedElement) + 1;
            }
            var newErroCode = dataElementPosition == 0 ? ErrorCodes.RequiredMissing : errorCode;
            context.Add(dataElementName, dataElementPosition, newErroCode, componentDataElementPosition, repetitionDataElementPosition, value);
            
            return context;
        }

        private static SegmentErrorContext BuildCompositeDataElementContext(string failedElement, XElement originalParent, ErrorCodes errorCode)
        {
            if (failedElement == null || originalParent == null || originalParent.Document == null)
                return null;
            
            var segments = originalParent.Document.Descendants()
                .Where(
                    d =>
                        d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal))
                .ToList();

            int dataElementPosition = 0;
            int repetitionPosition = 0;
            var lastElement = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);
            var firstElement = originalParent.Elements().FirstOrDefault(e => e.Name.LocalName == failedElement);
            if (lastElement != null && firstElement != null)
            {
                dataElementPosition = originalParent.Elements().ToList().IndexOf(firstElement) + 1;
                repetitionPosition = lastElement.ElementsBeforeSelf().Count(e => e.Name.LocalName == failedElement) + 1;
            }

            var newErroCode = dataElementPosition == 0 ? ErrorCodes.RequiredMissing : errorCode;
            var context = new SegmentErrorContext(ExtractName(originalParent.Name.LocalName), segments.IndexOf(originalParent) + 1);
            context.Add(ExtractName(failedElement), dataElementPosition, newErroCode, 0, repetitionPosition, null);

            return context;
        }

        private static SegmentErrorContext BuildSegmentContext(string failedElement, XElement originalParent, ErrorCodes errorCode)
        {
            if (failedElement == null || originalParent == null || originalParent.Document == null)
                return null;
            
            var element = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);
            var segments = originalParent.Document.Descendants()
                .Where(
                    d =>
                        d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal))
                .ToList();

            var segmentPosition = element != null ? segments.IndexOf(element) + 1 : 0;
            var newErroCode = segmentPosition == 0 ? ErrorCodes.RequiredMissing : errorCode;

            return new SegmentErrorContext(ExtractName(failedElement), segmentPosition, newErroCode);
        }

        private static SegmentErrorContext BuildOtherContext(XmlSchemaElement failedXsdElement, XElement originalParent, ErrorCodes errorCode)
        {
            if (failedXsdElement == null || originalParent == null || originalParent.Document == null)
                return null;

            var failedElement = failedXsdElement.QualifiedName.Name;

            var element = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);
            var segments = originalParent.Document.Descendants()
                .Where(
                    d =>
                        d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal) ||
                        d.Name.LocalName == failedElement)
                .ToList();

            var segmentPosition = element != null ? segments.IndexOf(element) + 1 : 0;
            var newErroCode = segmentPosition == 0 ? ErrorCodes.RequiredMissing : errorCode;

            return new SegmentErrorContext(ExtractName(GetName(failedXsdElement)), segmentPosition, newErroCode);
        }

        private static SegmentErrorContext ResolveUnexpected(XElement failedElement, XmlSchemaSet schemas, ErrorCodes errorCode)
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
                                            failedElement, errorCode);

                                    if (childElement.QualifiedName.Name.StartsWith("C_", StringComparison.Ordinal))
                                        return BuildCompositeDataElementContext(childElement.QualifiedName.Name,
                                            failedElement, errorCode);

                                    if (childElement.QualifiedName.Name.StartsWith("D_", StringComparison.Ordinal))
                                        return BuildDataElementContext(childElement.QualifiedName.Name,
                                            failedElement, null, errorCode);

                                    return BuildOtherContext(childElement, failedElement, errorCode);
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
