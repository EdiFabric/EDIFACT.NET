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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using EdiFabric.Annotations.Validation;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Validators
{
    /// <summary>
    /// Validates EDI objects.
    /// Caches internally all of the serializers and compiled XSD and clears the caches if the maximum threshold is reached.
    /// The serializers cache uses the Type.FullName as the key. 
    /// The XSD cache uses the XsdName as the key.
    /// </summary>
    //public class EdiValidator
    //{
    //    private static readonly FieldInfo ValidationRes = typeof (XmlSchemaException).GetField("res",
    //        BindingFlags.NonPublic | BindingFlags.Instance);
       
    //    private static readonly ConcurrentDictionary<string, XmlSerializer> SerializerCache =
    //        new ConcurrentDictionary<string, XmlSerializer>();

    //    private static readonly ConcurrentDictionary<string, XmlSchemaSet> XsdCache =
    //        new ConcurrentDictionary<string, XmlSchemaSet>();

    //    private readonly Func<MessageContext, Stream> _xsdStream;
    //    /// <summary>
    //    /// The maximum number of cached serializers. The cache is cleared when this is exceeded. The default is 20.
    //    /// </summary>
    //    public int SerializerCacheMax { get; private set; }
    //    /// <summary>
    //    /// The maximum number of cached xsd. The cache is cleared when this is exceeded. The default is 20.
    //    /// </summary>
    //    public int XsdCacheMax{ get; private set; }

    //    private EdiValidator(string xsdAssemblyName, int serializerCacheMax, int xsdCacheMax)
    //        : this(key => Assembly.Load(xsdAssemblyName)
    //            .GetManifestResourceStream(string.Format("{0}.{1}", xsdAssemblyName, key.XsdName)), serializerCacheMax, xsdCacheMax)
    //    {
    //    }

    //    private EdiValidator(Func<MessageContext, Stream> xsdStream, int serializerCacheMax, int xsdCacheMax)
    //    {
    //        if (xsdStream == null) throw new ArgumentNullException("xsdStream");

    //        _xsdStream = xsdStream;
    //        SerializerCacheMax = serializerCacheMax;
    //        XsdCacheMax = xsdCacheMax;
    //    }

    //    /// <summary>
    //    /// Factory method to initialize a new instance of the <see cref="EdiValidator"/> class.
    //    /// </summary>
    //    /// <param name="xsdStream">The delegate to return the XSD stream.</param>
    //    /// <param name="serializerCacheMax">The maximum number of cached serializers. The cache is cleared when this is exceeded. The default is 20.</param>
    //    /// <param name="xsdCacheMax">The maximum number of cached serializers. The cache is cleared when this is exceeded. The default is 20.</param>
    //    /// <returns>A new instance of the <see cref="EdiValidator"/> class.</returns>
    //    public static EdiValidator Create(Func<MessageContext, Stream> xsdStream, int serializerCacheMax = 20, int xsdCacheMax = 20)
    //    {
    //        return new EdiValidator(xsdStream, serializerCacheMax, xsdCacheMax);
    //    }

    //    /// <summary>
    //    /// Factory method to initialize a new instance of the <see cref="EdiValidator"/> class.
    //    /// </summary>
    //    /// <param name="xsdAssemblyName">The name of the assembly containing the XSD files.</param>
    //    /// <param name="serializerCacheMax">The maximum number of cached serializers. The cache is cleared when this is exceeded. The default is 20.</param>
    //    /// <param name="xsdCacheMax">The maximum number of cached serializers. The cache is cleared when this is exceeded. The default is 20.</param>
    //    /// <returns>A new instance of the <see cref="EdiValidator"/> class.</returns>
    //    public static EdiValidator Create(string xsdAssemblyName, int serializerCacheMax = 20, int xsdCacheMax = 20)
    //    {
    //        return new EdiValidator(xsdAssemblyName, serializerCacheMax, xsdCacheMax);
    //    }
        
    //    /// <summary>
    //    /// Validates EDI document instance.
    //    /// </summary>
    //    /// <param name="message">The EDI document instance.</param>
    //    /// <returns>A collection of validation errors.</returns>
    //    /// <exception cref="Exception">Throws an exception if the instance is not a valid ediFabric spec.</exception>
    //    public ValidationException Validate(object message)
    //    {
    //        if (message == null)
    //            throw new ArgumentNullException("message");

    //        string messageName = null;
    //        string controlNumber = null;
    //        try
    //        {
    //            var xDoc = Serialize(message);
    //            if (xDoc.Root == null)
    //                throw new Exception("Failed to serialize instance.");

    //            string format;
    //            if (!TryGetMessageContext(xDoc.Root, out messageName, out controlNumber, out format))
    //            {
    //                throw new Exception("Failed to extract message name or control number.");
    //            }

    //            if (XsdCache.Count > XsdCacheMax) XsdCache.Clear();

    //            var schemas = XsdCache.GetOrAdd(message.GetType().FullName,
    //                key => NewSchemaSet(_xsdStream(new MessageContext(message)), xDoc.Root.Name.Namespace.NamespaceName));

    //            var messageContext = new MessageErrorContext(messageName, controlNumber);
    //            xDoc.Validate(schemas,
    //                (o, e) =>
    //                {
    //                    var errorCode = MapErrorCode(GetErrorCode(e));
    //                    var segmentContext = BuildContext(o as XElement, schemas, errorCode);
    //                    messageContext.Add(segmentContext);
    //                });

    //            foreach (var code in ValidateStructure(xDoc.Root, controlNumber, format))
    //                messageContext.Add(code);
                
    //            return new ValidationException("Validation successful.", messageContext);
    //        }
    //        catch (Exception ex)
    //        {
    //            if (!string.IsNullOrEmpty(messageName) && !string.IsNullOrEmpty(controlNumber))
    //            {
    //                var messageContext = new MessageErrorContext(messageName, controlNumber);
    //                messageContext.Add(ErrorCodes.Unknown);
    //                return new ValidationException("Validation failed.", messageContext, ex);
    //            }

    //            return new ValidationException("Validation failed.", null, ex);
    //        }
    //    }

    //    private XDocument Serialize(object instance)
    //    {
    //        if (instance == null)
    //            throw new ArgumentNullException("instance");

    //        var type = instance.GetType();

    //        var nameSpace = type.Namespace;
    //        if (type.FullName.Contains("X12"))
    //            nameSpace = "www.edifabric.com/x12";
    //        if (type.FullName.Contains("Edifact"))
    //            nameSpace = "www.edifabric.com/edifact";

    //        if (SerializerCache.Count > SerializerCacheMax) SerializerCache.Clear();
    //        var serializer = SerializerCache.GetOrAdd(type.FullName, key => new XmlSerializer(type, nameSpace));
    //        using (var ms = new MemoryStream())
    //        {
    //            serializer.Serialize(ms, instance);
    //            ms.Position = 0;
    //            return XDocument.Load(ms, LoadOptions.PreserveWhitespace);
    //        }
    //    }

    //    private static XmlSchemaSet NewSchemaSet(Stream xsd, string nameSpace)
    //    {
    //        var schemas = new XmlSchemaSet();

    //        using (var reader = XmlReader.Create(xsd))
    //        {
    //            schemas.Add(nameSpace, reader);
    //            schemas.Compile();
    //        }

    //        return schemas;
    //    }

    //    private static bool TryGetMessageContext(XElement xml, out string messageName, out string controlNumber, out string format)
    //    {
    //        messageName = null;
    //        controlNumber = null;
    //        format = null;

    //        if (xml.Elements().Any())
    //        {
    //            var st =
    //                xml.Elements()
    //                    .SingleOrDefault(e => e.Name.LocalName.StartsWith("S_ST", StringComparison.Ordinal));
    //            if (st != null && st.Elements().Any())
    //            {
    //                messageName = st.Elements().ElementAt(0).Value;
    //                if (st.Elements().Count() > 1)
    //                    controlNumber = st.Elements().ElementAt(1).Value;
    //                format = "X12";
    //                return true;
    //            }
    //            var unh =
    //                xml.Elements()
    //                    .SingleOrDefault(e => e.Name.LocalName.StartsWith("S_UNH", StringComparison.Ordinal));
    //            if (unh != null && unh.Elements().Any())
    //            {
    //                if (unh.Elements().Count() > 1)
    //                {
    //                    controlNumber = unh.Elements().ElementAt(0).Value;
    //                    messageName = unh.Elements().ElementAt(1).Elements().ElementAt(0).Value;
    //                    format = "Edifact";
    //                    return true;
    //                }
    //            }
    //        }

    //        return false;
    //    }

    //    private static string GetErrorCode(ValidationEventArgs e)
    //    {
    //        if (ValidationRes == null || e.Exception == null) return null;

    //        if (e.Exception.InnerException != null)
    //            return (string)ValidationRes.GetValue(e.Exception.InnerException);

    //        return (string)ValidationRes.GetValue(e.Exception);
    //    }

    //    private static ErrorCodes MapErrorCode(string errorCode)
    //    {
    //        switch (errorCode)
    //        {
    //            case "Sch_LengthConstraintFailed":
    //                return ErrorCodes.DataElementLengthWrong;
    //            case "Sch_MinLengthConstraintFailed":
    //                return ErrorCodes.DataElementTooShort;
    //            case "Sch_MaxLengthConstraintFailed":
    //                return ErrorCodes.DataElementTooLong;
    //            case "Sch_EnumerationConstraintFailed":
    //                return ErrorCodes.DataElementValueWrong;
    //            case "Sch_InvalidElementContent":
    //            case "Sch_InvalidElementContentExpecting":
    //                return ErrorCodes.Unexpected;
    //            case "Sch_IncompleteContent":
    //            case "Sch_IncompleteContentExpecting":
    //                return ErrorCodes.RequiredMissing;
    //        }

    //        return ErrorCodes.Unknown;
    //    }
        
    //    private static SegmentErrorContext BuildContext(XElement failedElement, XmlSchemaSet schemas, ErrorCodes errorCode)
    //    {
    //        if (failedElement == null)
    //            return null;

    //        try
    //        {
    //            if (failedElement.Name.LocalName.StartsWith("D_", StringComparison.Ordinal))
    //                return BuildDataElementContext(failedElement.Name.LocalName, failedElement.Parent,
    //                    failedElement.Value, errorCode);

    //            if (errorCode == ErrorCodes.Unexpected)
    //                return ResolveUnexpected(failedElement.Parent, schemas, errorCode);

    //            if (errorCode == ErrorCodes.RequiredMissing)
    //                return ResolveUnexpected(failedElement, schemas, errorCode);
    //        }
    //        catch
    //        {
    //            // ignored
    //        }

    //        return null;
    //    }

    //    private static SegmentErrorContext BuildDataElementContext(string failedElement, XElement originalParent, string value, ErrorCodes errorCode)
    //    {
    //        if (failedElement == null || originalParent == null || originalParent.Parent == null || originalParent.Document == null)
    //            return null;

    //        var segments = originalParent.Document.Descendants()
    //                        .Where(d => d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal))
    //                        .ToList();

    //        var parent = originalParent.Name.LocalName.StartsWith("C_", StringComparison.Ordinal)
    //            ? originalParent.Parent
    //            : originalParent;
    //        var context = new SegmentErrorContext(ExtractName(parent.Name.LocalName), segments.IndexOf(parent) + 1);
            
    //        string dataElementName = ExtractName(failedElement);
    //        int componentDataElementPosition = 0;
    //        int dataElementPosition = 0;
    //        int repetitionDataElementPosition = 0;
    //        var lastElement = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);
    //        var firstElement = originalParent.Elements().FirstOrDefault(e => e.Name.LocalName == failedElement);
    //        if (lastElement != null && firstElement != null)
    //        {
    //            if (originalParent.Name.LocalName.StartsWith("C_", StringComparison.Ordinal))
    //            {
    //                componentDataElementPosition = originalParent.Elements().ToList().IndexOf(lastElement) + 1;
    //                dataElementPosition = parent.Elements().ToList().IndexOf(originalParent) + 1;
    //            }
    //            else
    //            {
    //                dataElementPosition = parent.Elements().ToList().IndexOf(firstElement) + 1;
    //            }

    //            repetitionDataElementPosition = lastElement.ElementsBeforeSelf().Count(e => e.Name.LocalName == failedElement) + 1;
    //        }
    //        var newErroCode = dataElementPosition == 0 ? ErrorCodes.RequiredMissing : errorCode;
    //        context.Add(dataElementName, dataElementPosition, newErroCode, componentDataElementPosition, repetitionDataElementPosition, value);
            
    //        return context;
    //    }

    //    private static SegmentErrorContext BuildCompositeDataElementContext(string failedElement, XElement originalParent, ErrorCodes errorCode)
    //    {
    //        if (failedElement == null || originalParent == null || originalParent.Document == null)
    //            return null;
            
    //        var segments = originalParent.Document.Descendants()
    //            .Where(
    //                d =>
    //                    d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal))
    //            .ToList();

    //        int dataElementPosition = 0;
    //        int repetitionPosition = 0;
    //        var lastElement = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);
    //        var firstElement = originalParent.Elements().FirstOrDefault(e => e.Name.LocalName == failedElement);
    //        if (lastElement != null && firstElement != null)
    //        {
    //            dataElementPosition = originalParent.Elements().ToList().IndexOf(firstElement) + 1;
    //            repetitionPosition = lastElement.ElementsBeforeSelf().Count(e => e.Name.LocalName == failedElement) + 1;
    //        }

    //        var newErroCode = dataElementPosition == 0 ? ErrorCodes.RequiredMissing : errorCode;
    //        var context = new SegmentErrorContext(ExtractName(originalParent.Name.LocalName), segments.IndexOf(originalParent) + 1);
    //        context.Add(ExtractName(failedElement), dataElementPosition, newErroCode, 0, repetitionPosition, null);

    //        return context;
    //    }

    //    private static SegmentErrorContext BuildSegmentContext(string failedElement, XElement originalParent, ErrorCodes errorCode)
    //    {
    //        if (failedElement == null || originalParent == null || originalParent.Document == null)
    //            return null;
            
    //        var segments = originalParent.Document.Descendants()
    //            .Where(
    //                d =>
    //                    d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal))
    //            .ToList();
    //        var element = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);
            
    //        var segmentPosition = element != null ? segments.IndexOf(element) + 1 : 0;
    //        var newErroCode = segmentPosition == 0 ? ErrorCodes.RequiredMissing : errorCode;

    //        return new SegmentErrorContext(ExtractName(failedElement), segmentPosition, ValidationResult.Valid);
    //        //return new SegmentErrorContext(ExtractName(failedElement), segmentPosition, newErroCode);
    //    }

    //    private static SegmentErrorContext BuildOtherContext(XmlSchemaElement failedXsdElement, XElement originalParent, ErrorCodes errorCode)
    //    {
    //        if (failedXsdElement == null || originalParent == null || originalParent.Document == null)
    //            return null;

    //        var failedElement = failedXsdElement.QualifiedName.Name;

    //        var segments = originalParent.Document.Descendants()
    //            .Where(
    //                d =>
    //                    d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal) ||
    //                    d.Name.LocalName == failedElement)
    //            .ToList();
    //        var element = originalParent.Elements().LastOrDefault(e => e.Name.LocalName == failedElement);
            
    //        var segmentPosition = element != null ? segments.IndexOf(element) + 1 : 0;
    //        var newErroCode = segmentPosition == 0 ? ErrorCodes.RequiredMissing : errorCode;

    //        return new SegmentErrorContext(ExtractName(GetName(failedXsdElement)), segmentPosition, ValidationResult.Valid);
    //        //return new SegmentErrorContext(ExtractName(GetName(failedXsdElement)), segmentPosition, newErroCode);
    //    }

    //    private static SegmentErrorContext ResolveUnexpected(XElement failedElement, XmlSchemaSet schemas, ErrorCodes errorCode)
    //    {
    //        foreach (XmlSchema schema in schemas.Schemas())
    //        {
    //            foreach (XmlSchemaElement element in schema.Elements.Values)
    //            {
    //                if (element.QualifiedName.Name == failedElement.Name.LocalName)
    //                {
    //                    var complexType = element.ElementSchemaType as XmlSchemaComplexType;

    //                    if (complexType != null)
    //                    {
    //                        XmlSchemaObjectCollection items = null;
    //                        var sequence = complexType.ContentTypeParticle as XmlSchemaSequence;
    //                        if (sequence != null)
    //                            items = sequence.Items;

    //                        if (sequence == null)
    //                        {
    //                            var all = complexType.ContentTypeParticle as XmlSchemaAll;
    //                            if (all != null)
    //                                items = all.Items;
    //                        }

    //                        if (items == null) continue;

    //                        foreach (var item in items)
    //                        {
    //                            var childElement = (XmlSchemaElement) item;
    //                            var match = failedElement.Elements()
    //                                .Where(e => e.Name.LocalName == childElement.QualifiedName.Name).ToList();

    //                            if ((!match.Any() && Decimal.ToInt32(childElement.MinOccurs) == 1) ||
    //                                (match.Any() && Decimal.ToInt32(childElement.MaxOccurs) < match.Count))
    //                            {
    //                                if (childElement.QualifiedName.Name.StartsWith("S_", StringComparison.Ordinal))
    //                                    return BuildSegmentContext(childElement.QualifiedName.Name,
    //                                        failedElement, errorCode);

    //                                if (childElement.QualifiedName.Name.StartsWith("C_", StringComparison.Ordinal))
    //                                    return BuildCompositeDataElementContext(childElement.QualifiedName.Name,
    //                                        failedElement, errorCode);

    //                                if (childElement.QualifiedName.Name.StartsWith("D_", StringComparison.Ordinal))
    //                                    return BuildDataElementContext(childElement.QualifiedName.Name,
    //                                        failedElement, null, errorCode);

    //                                return BuildOtherContext(childElement, failedElement, errorCode);
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //        }

    //        return null;
    //    }

    //    private static string GetName(XmlSchemaElement element)
    //    {
    //        var complexType = element.ElementSchemaType as XmlSchemaComplexType;
    //        if (complexType != null)
    //        {
    //            XmlSchemaObjectCollection items = null;
    //            var sequence = complexType.ContentTypeParticle as XmlSchemaSequence;
    //            if (sequence != null)
    //                items = sequence.Items;

    //            if (sequence == null)
    //            {
    //                var all = complexType.ContentTypeParticle as XmlSchemaAll;
    //                if (all != null)
    //                    items = all.Items;
    //            }

    //            if (items == null) return null;

    //            foreach (var item in items)
    //            {
    //                var childElement = (XmlSchemaElement)item;
    //                if (childElement.QualifiedName.Name.StartsWith("S_", StringComparison.Ordinal))
    //                    return childElement.QualifiedName.Name;

    //                return GetName(childElement);
    //            }
    //        }

    //        return null;
    //    }

    //    private static string ExtractName(string name)
    //    {
    //        var parts = name.Split('_');
    //        if (parts.Length < 2)
    //            return name;

    //        return parts[1];
    //    }

    //    private static IEnumerable<ErrorCodes> ValidateStructure(XElement xml, string controlNumber, string format)
    //    {
    //        var result = new List<ErrorCodes>();
    //        if (string.IsNullOrEmpty(controlNumber))
    //            result.Add(ErrorCodes.InvalidTransactionSetIdentifier);

    //        XElement trailer = null;

    //        if (format == "X12")
    //            trailer =
    //                xml.Elements().SingleOrDefault(e => e.Name.LocalName.StartsWith("S_SE", StringComparison.Ordinal));

    //        if (format == "Edifact")
    //            trailer =
    //                xml.Elements().SingleOrDefault(e => e.Name.LocalName.StartsWith("S_UNT", StringComparison.Ordinal));

    //        if (trailer == null)
    //        {
    //            result.Add(ErrorCodes.MessageTrailerMissing);
    //            return result;
    //        }

    //        if (trailer.Elements().Count() != 2)
    //        {
    //            result.Add(ErrorCodes.InvalidTransactionSetIdentifier);
    //            return result;
    //        }

    //        var trailerControlNumber = trailer.Elements().ElementAt(1).Value;
    //        var numberOfSegments = trailer.Elements().ElementAt(0).Value;

    //        if (string.IsNullOrEmpty(trailerControlNumber) || string.IsNullOrEmpty(numberOfSegments))
    //        {
    //            result.Add(ErrorCodes.InvalidTransactionSetIdentifier);
    //            return result;
    //        }

    //        int trailerSegmentsNumber;
    //        if (!Int32.TryParse(numberOfSegments, out trailerSegmentsNumber))
    //        {
    //            result.Add(ErrorCodes.InvalidTransactionSetIdentifier);
    //            return result;
    //        }

    //        var messageSegmentsNumber = xml.Descendants().Count(d =>
    //            d.Name.LocalName.StartsWith("S_", StringComparison.Ordinal));

    //        if (messageSegmentsNumber != trailerSegmentsNumber)
    //            result.Add(ErrorCodes.SegmentsCountNotMatching);

    //        if (controlNumber != trailerControlNumber)
    //            result.Add(ErrorCodes.ControlNumberNotMatching);

    //        return result;
    //    }
    //}
}
