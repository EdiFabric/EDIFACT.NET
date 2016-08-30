//---------------------------------------------------------------------
// This file is part of EDIFabric
//
// Copyright (c) EDIFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Linq;
using System.Security;
using System.Xml.Linq;
using EdiFabric.Framework.Envelopes;

namespace EdiFabric.Framework.Messages.Segments
{
    /// <summary>
    /// This class is used to parse EDI segments into XML and vice verse.
    /// </summary>
    class SegmentParser
    {
        /// <summary>
        /// Parses EDI line according to a grammar.
        /// The grammar is loaded from the specified .NET type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="line">The EDI line.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>The parsed XML.</returns>
        public static XElement ParseLine<T>(string line, InterchangeContext interchangeContext)
        {
            if (string.IsNullOrEmpty(line)) throw new ArgumentNullException("line");

            var systemType = typeof(T);

            if (systemType == null)
                throw new ParserException(string.Format("Can't find type."));

            return Parse(new ParseTree(systemType, false), line, interchangeContext);
        }

        /// <summary>
        /// Parses EDI line according to a grammar.
        /// </summary>
        /// <param name="grammar">The grammar.</param>
        /// <param name="line">The EDI line.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>The parsed XML.</returns>
        public static XElement ParseLine(ParseTree grammar, string line, InterchangeContext interchangeContext)
        {
            if (grammar == null) throw new ArgumentNullException("grammar");

            if (!grammar.Children.Any())
            {
                return Parse(new ParseTree(grammar.Type, false)
                    , line, interchangeContext);
            }

            return Parse(grammar, line, interchangeContext);
        }

        /// <summary>
        /// Parses EDI XML according to a grammar.
        /// The grammar is loaded from the specified .NET type.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="xml">The EDI XML.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>The parsed line.</returns>
        public static string ParseXml<T>(XElement xml, InterchangeContext interchangeContext)
        {
            if (null == xml) throw new ArgumentNullException("xml");

            var systemType = typeof(T);

            if (systemType == null)
                throw new ParserException(string.Format("Can't find type."));

            return Parse(xml, new ParseTree(systemType, false), interchangeContext);
        }

        /// <summary>
        /// Parses EDI XML according to a grammar.
        /// </summary>
        /// <param name="systemType">The system type.</param>
        /// <param name="xml">The EDI XML.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>The parsed line.</returns>
        public static string ParseXml(Type systemType, XElement xml, InterchangeContext interchangeContext)
        {
            // Find the grammar by system type
            return Parse(xml,
                new ParseTree(FindType(systemType, xml.Name.LocalName), false),
                interchangeContext);
        }

        /// <summary>
        /// Parses a segment. 
        /// </summary>
        /// <param name="line">The segment line.</param>
        /// <param name="grammar">The segment grammar.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>The parsed XML.</returns>
        private static XElement Parse(ParseTree grammar, string line, InterchangeContext interchangeContext)
        {
            if (grammar.Prefix != EdiPrefix.S) throw new Exception("Not a segment.");

            XNamespace ns = interchangeContext.TargetNamespace;
            var result = new XElement(ns + grammar.Name);

            // Gets the composite data elements from the segment string
            var dataElements = EdiHelper.GetEdiCompositeDataElements(line, interchangeContext).ToList();

            // Index the composite data elements from the class definition
            var indexedGrammar = grammar.Children.Select((g, p) => new { Grammar = g, Position = p }).ToList();
            // Index the composite data elements from the EDI string
            var indexedValues = dataElements.Select((v, p) => new { Value = v, Position = p }).ToList();

            // This will try to parse the EDI string into the class definition
            // Load a parse tree against each value
            // If there are more values in the EDI string than in the class definition - they will be ignored
            // If there are less values in the EDI string than in the class definition - it will throw an exception
            var indexedList = from ig in indexedGrammar
                              from iv in indexedValues
                              where ig.Position == iv.Position
                              select new { ig.Grammar, iv.Value, ig.Position };

            foreach (var dataElement in indexedList)
            {
                // Skip the blank elements
                // This massively reduces the generated XML
                if (string.IsNullOrEmpty(dataElement.Value))
                {
                    // Don't skip for header segments as they are positional
                    if (!grammar.IsEnvelope)
                        continue;
                }

                // If the current element is out of the range of elements defined in the definition class, then it's a repetition
                // The repetitions are always for the last defined element
                var elementGrammar = dataElement.Position >= grammar.Children.Count
                    ? grammar.Children.Last()
                    : grammar.Children.ElementAt(dataElement.Position);

                // Handle the repetitions
                var elementRepetitions = grammar.IsEnvelope
                    ? new[] {dataElement.Value}
                    : EdiHelper.GetRepetitions(dataElement.Value, interchangeContext);
                  
                // Parse each repetition
                foreach (var elementRepetition in elementRepetitions)
                {
                    result.Add(ParseElement(elementGrammar, elementRepetition, interchangeContext));
                }
            }

            return result;
        }

        /// <summary>
        /// Parses a data element
        /// </summary>
        /// <param name="parseTree">The data element grammar.</param>
        /// <param name="value">The data element line.</param>
        /// <param name="interchangeContext"></param>
        /// <returns>The parsed XML.</returns>
        private static XElement ParseElement(ParseTree parseTree, string value, InterchangeContext interchangeContext)
        {
            if (value == null) throw new ArgumentNullException("value");
            if (parseTree.Prefix != EdiPrefix.C && parseTree.Prefix != EdiPrefix.D) throw new Exception("Not a data element.");

            XNamespace ns = interchangeContext.TargetNamespace;
            var result = new XElement(ns + parseTree.Name);

            if (parseTree.Prefix == EdiPrefix.C)
            {
                if (value == string.Empty)
                {
                    // Only deal with blank values for envelope headers
                    if (parseTree.IsEnvelope)
                    {
                        foreach (var dataElement in parseTree.Children)
                        {
                            var element = new XElement(ns + dataElement.Name);
                            element.SetValue(string.Empty);
                            result.Add(element);
                        }
                    }
                }
                else
                {
                    // Get the simple data elements
                    var componentDataElements =
                        EdiHelper.GetEdiComponentDataElements(value, interchangeContext).ToList();

                    // Index the composite data elements from the class definition
                    var indexedGrammar =
                        parseTree.Children.Select((g, p) => new { Grammar = g, Position = p }).ToList();
                    // Index the composite data elements from the EDI string
                    var indexedValues = componentDataElements.Select((v, p) => new { Value = v, Position = p }).ToList();

                    // This will try to parse the EDI string into the class definition
                    // Load a parse tree against each value
                    // If there are more values in the EDI string than in the class definition - they will be ignored
                    // If there are less values in the EDI string than in the class definition - it will throw an exception
                    var indexedList = from ig in indexedGrammar
                                      from iv in indexedValues
                                      where ig.Position == iv.Position
                                      select new { ig.Position, iv.Value };

                    // Index the list so we can position each element
                    //var indexed = componentDataElements.Select((a, i) => new {Item = a, Position = i}).ToList();

                    foreach (var dataElement in indexedList)
                    {
                        // Skip blank data elements otherwise this will produce blank XML nodes
                        if (string.IsNullOrEmpty(dataElement.Value))
                        {
                            if (!parseTree.IsEnvelope)
                                continue;
                        }

                        // Handle the repetitions
                        // If the children the EDI string are more than the class definition,
                        // Then the extra ones are considered repetitions of the last child in the class definition
                        var objectToParse = dataElement.Position >= parseTree.Children.Count
                                                ? parseTree.Children.Last()
                                                : parseTree.Children.ElementAt(dataElement.Position);

                        var element = new XElement(ns + objectToParse.Name);
                        // Set the value and escape to prevent faulty XML
                        element.SetValue(SecurityElement.Escape(dataElement.Value) ?? string.Empty);
                        result.Add(element);
                    }
                }
            }
            else
            {
                // Prevent faulty XML
                result.SetValue(SecurityElement.Escape(value) ?? string.Empty);
            }

            return result;
        }

        /// <summary>
        /// Parses segment XML
        /// </summary>
        /// <param name="segment">The segment XML.</param>
        /// <param name="parseTree">The segment grammar.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>The parsed line.</returns>
        private static string Parse(XElement segment, ParseTree parseTree, InterchangeContext interchangeContext)
        {
            // Start with the segment name
            // BHT+, etc.
            var result = parseTree.EdiName + interchangeContext.DataElementSeparator;

            // For all elements in the parse tree - append to the segment name to build the EDI string
            // BHT+88, etc.
            // Parse according to the parse tree
            foreach (var element in parseTree.Children)
            {
                var currentElement = element;
                // Find the matching elements by name
                // If > 1 found, then there are repetitions
                var matchingElements = segment.Elements().Where(e => e.Name.LocalName == currentElement.Name);

                string line = string.Empty;
                foreach (var matchingElement in matchingElements)
                {
                    // Parse the element and split the repetitions
                    line = line + ParseElement(matchingElement, element, interchangeContext)
                           + interchangeContext.RepetitionSeparator;
                }

                // Make sure the trailing repetitions separator is removed
                // To avoid stripping the default repetitions separator in case there is something like 88:55::
                // The result should be 88:55:, therefore we can't just strip the trailing separators
                line = line.EndsWith(interchangeContext.RepetitionSeparator + interchangeContext.RepetitionSeparator)
                    ? line.Substring(0, line.Length - 1)
                    : line.TrimEnd(interchangeContext.RepetitionSeparator.ToCharArray());

                // Add to the segment string
                // BHT+88:55:+
                result = result + line + interchangeContext.DataElementSeparator;
            }

            // Remove the trailing data element separator
            // BHT+88:55:
            result = CleanupTrailingSeparators(result, interchangeContext.DataElementSeparator, interchangeContext); //result.TrimEnd(interchangeContext.DataElementSeparator.ToCharArray());
            // Append the segment terminator
            // BHT+88:55:'
            result = result + interchangeContext.SegmentTerminator;

            return result;
        }

        /// <summary>
        /// Parses data element XML
        /// </summary>
        /// <param name="dataElement">The data element XML.</param>
        /// <param name="parseTree">The data element grammar.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>The parsed line.</returns>
        private static string ParseElement(XElement dataElement, ParseTree parseTree, InterchangeContext interchangeContext)
        {
            if (parseTree.Prefix == EdiPrefix.C)
            {
                var line = string.Empty;
                // If complex data element, build a line from all the children in the parse tree
                foreach (var element in parseTree.Children)
                {
                    // Can be only one match
                    // If the XML contains data element that is not defined in the class, it will be skipped
                    // This way only know data elements will be parsed
                    var matchingElement =
                        dataElement.Elements().SingleOrDefault(e => e.Name.LocalName == element.Name);

                    // Build the line
                    line = line +
                           GetValidDataElementValue(matchingElement, interchangeContext) +
                           interchangeContext.ComponentDataElementSeparator;
                }

                // Remove the trailing composite terminator
                return CleanupTrailingSeparators(line, interchangeContext.ComponentDataElementSeparator, interchangeContext);
                //return line.TrimEnd(interchangeContext.ComponentDataElementSeparator.ToCharArray());
            }

            // If simple just escape the value
            return GetValidDataElementValue(dataElement, interchangeContext);
        }

        /// <summary>
        /// Escapes a string value to be valid in XML.
        /// </summary>
        /// <param name="dataElement">The XML element.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>The valid XML value.</returns>
        private static string GetValidDataElementValue(XElement dataElement, InterchangeContext interchangeContext)
        {
            var dataElementValue = dataElement == null ? string.Empty : dataElement.Value;

            // Secure non valid XML symbols
            // Currently only &
            if (dataElementValue.Contains("&"))
            {
                var securityElement = SecurityElement.FromString("<parse>" + dataElementValue + "</parse>");
                if (securityElement == null)
                {
                    throw new ParserException("Can't parse value " + dataElementValue);
                }

                dataElementValue = securityElement.Text;
            }

            //  Escape all terminator symbols
            return interchangeContext.EscapeLine(dataElementValue);
        }

        /// <summary>
        /// Finds a type from another type
        /// </summary>
        /// <param name="source">The source type.</param>
        /// <param name="segment">The name to search for.</param>
        /// <returns>The found type.</returns>
        private static Type FindType(Type source, string segment)
        {
            if (source.AssemblyQualifiedName == null)
                throw new ParserException(string.Format("Can't find assembly for type name = {0} .Please ensure that the correct class was added to the definitions project and that you pointed to the definitions project in your .config file.", source.FullName));

            var result = Type.GetType(source.AssemblyQualifiedName.Replace(source.Name, segment));

            if (result == null)
                throw new ParserException(string.Format("Can't find type for type name = {0}", source.FullName));

            return result;
        }

        /// <summary>
        /// Trims a string from trailing chars with escaping.
        /// </summary>
        /// <param name="result">The string to trim.</param>
        /// <param name="separator">The string to be trimmed.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>The trimmed string.</returns>
        private static string CleanupTrailingSeparators(string result, string separator, InterchangeContext interchangeContext)
        {
            while (result.EndsWith(separator))
            {
                if (!string.IsNullOrEmpty(interchangeContext.ReleaseIndicator) && result.EndsWith(interchangeContext.ReleaseIndicator + separator))
                {
                    break;
                }

                result = result.Substring(0, result.Length - separator.Length);
            }

            return result;
        }
    }
}
