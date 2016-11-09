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
using System.Configuration;
using System.IO;
using System.Linq;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Parsing;

namespace EdiFabric.Framework.Readers
{
    internal static class EdiReaderExtensions
    {
        private static readonly string RulesAssembly;

        static EdiReaderExtensions()
        {
            try
            {
                RulesAssembly = ConfigurationManager.AppSettings["EdiFabric.RulesAssemblyName"];
            }
            catch(Exception)
            {
                // ignored
            }
        }

        internal static T ParseSegment<T>(this string segmentValue, Separators separators)
        {
            var parseNode = ParseNode.BuldTree(typeof(T), false);
            parseNode.ParseSegment(segmentValue, separators);
            return (T)parseNode.ToInstance();
        }

        internal static string Read(this StreamReader reader, int bytes, char[] trims)
        {
            string result = null;
            var counter = 0;
            while (counter < bytes && !reader.EndOfStream)
            {
                var symbol = reader.Read(1).Trim(trims);
                if (!String.IsNullOrEmpty(symbol))
                    counter += 1;
                result += symbol;
            }

            return result;
        }

        internal static SegmentTags ToSegmentTag(this string segment, Separators separators)
        {
            if (String.IsNullOrEmpty(segment) || String.IsNullOrWhiteSpace(segment) || segment.Length < 3)
                return SegmentTags.Regular;

            if (segment.StartsWith(SegmentTags.UNA.ToString(), StringComparison.Ordinal)) return SegmentTags.UNA;

            var segmentTag = segment.Split(new[] {separators.DataElement}, StringSplitOptions.None).FirstOrDefault();

            SegmentTags tag;
            return Enum.TryParse(segmentTag, out tag) ? tag : SegmentTags.Regular;
        }

        internal static string Read(this StreamReader reader, int bytes)
        {
            var result = new char[bytes];
            reader.Read(result, 0, result.Length);
            return String.Concat(result);
        }

        internal static string ReadIsa(this StreamReader reader, char dataElementSeparator)
        {
            var line = "";
            var counter = 0;

            while (reader.Peek() >= 0 && counter < 15 && line.Length < 100)
            {
                var symbol = reader.Read(1)[0];
                line = line + symbol;

                if (dataElementSeparator == symbol)
                {
                    counter = counter + 1;
                }
            }

            return line + reader.Read(2);
        }

        internal static Type ToType(string format, string version, string tag, string rulesAssemblyName, string rulesNamespacePrefix)
        {
            if (String.IsNullOrEmpty(version)) throw new ArgumentNullException("version");
            if (String.IsNullOrEmpty(tag)) throw new ArgumentNullException("tag");

            var rulesAssembly = rulesAssemblyName ?? RulesAssembly;
            if (String.IsNullOrEmpty(rulesAssembly))
                throw new ParsingException(ErrorCodes.RulesAssemblyNameNotSet,
                    "The name of the rules assembly was neither set in .config nor passed explicitly.");
            var namespacePrefix = rulesNamespacePrefix ?? "EdiFabric.Rules";
            var typeFullName = namespacePrefix.TrimEnd('.') + "." + format + version + tag;
            typeFullName = typeFullName + ".M_" + tag;
            var errorMsg = String.Format(
                            "Type '{0}' was not found in assembly '{1}'.",
                            typeFullName, rulesAssemblyName);
            try
            {
                var systemType = Type.GetType(typeFullName + ", " + rulesAssembly);
                if (systemType == null)
                    throw new ParsingException(ErrorCodes.UnexpectedMessage, errorMsg);

                return systemType;
            }
            catch (Exception)
            {
                throw new ParsingException(ErrorCodes.UnexpectedMessage, errorMsg);
            }
        }

        internal static string[] GetDataElements(this string segment, Separators separators)
        {
            if (String.IsNullOrEmpty(segment)) throw new ArgumentNullException("segment");
            if (separators == null) throw new ArgumentNullException("separators");

            if (!separators.Escape.HasValue)
            {
                return segment.Split(separators.DataElement).Skip(1).ToArray();
            }

            return segment.SplitWithEscape(separators.Escape.Value,
                separators.DataElement).Skip(1).ToArray();
        }

        internal static string[] GetComponentDataElements(this string dataElement, Separators separators)
        {
            if (separators == null) throw new ArgumentNullException("separators");
            if (String.IsNullOrEmpty(dataElement)) throw new ArgumentNullException("dataElement");

            if (!separators.Escape.HasValue)
            {
                return dataElement.Split(separators.ComponentDataElement);
            }

            return dataElement.SplitWithEscape(separators.Escape.Value,
                separators.ComponentDataElement).ToArray();
        }

        internal static IEnumerable<string> SplitWithEscape(this string input, char escapeCharacter, char separator)
        {
            var startOfSegment = 0;
            var index = 0;
            while (index < input.Length)
            {
                index = input.IndexOf(separator.ToString(), index, StringComparison.Ordinal);
                if (index > 0 && input[index - 1] == escapeCharacter)
                {
                    if (index > 1)
                    {
                        if (input[index - 2] != escapeCharacter)
                        {
                            index += 1;
                            continue;
                        }
                    }
                    else
                    {
                        index += 1;
                        continue;
                    }
                }
                if (index == -1)
                {
                    break;
                }
                yield return input.Substring(startOfSegment, index - startOfSegment);
                index += 1;
                startOfSegment = index;
            }
            yield return input.Substring(startOfSegment);
        }

        internal static object Analyze(this List<SegmentContext> segments, Separators separators, Type type,
            string rulesAssemblyName)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");
            if (type == null) throw new ArgumentNullException("type");

            var messageGrammar = ParseNode.BuldTree(type, true);

            if (messageGrammar.Prefix != Prefixes.M)
                throw new Exception(String.Format("Only messages are supported: {0}", messageGrammar.Name));

            var segmentPosition = messageGrammar.Children.First();
            var instancePosition = new ParseNode(type);

            foreach (var segment in segments)
            {
                if (segment.IsControl) continue;

                Logger.Log(String.Format("Segment to match: {0}", segment.LogName));
                // Jump back to HL segment if needed
                if (segment.IsJump)
                {
                    try
                    {
                        segmentPosition = messageGrammar.JumpToHl(instancePosition.Root(), segment.ParentId);
                    }
                    catch (Exception ex)
                    {
                        var ec = new ErrorContext
                        {
                            SegmentName = segment.Name,
                            SegmentSupported = true,
                            SegmentPosition = segments.IndexOf(segment) + 1
                        };

                        throw new ParsingException(ErrorCodes.UnableToResolveHl,
                             "Unable to resolve HL.", ex, segment.Value, ec);
                    }                   
                }

                var currSeg = segmentPosition.TraverseSegmentsDepthFirst().FirstOrDefault(n => n.IsEqual(segment));
                if (currSeg == null)
                {
                    var ec = new ErrorContext
                    {
                        SegmentName = segment.Name,
                        SegmentSupported = true,
                        SegmentPosition = segments.IndexOf(segment) + 1
                    };

                    if (messageGrammar.Descendants().All(d => d.Name != segment.Name))
                    {
                        ec.SegmentSupported = false;
                        throw new ParsingException(ErrorCodes.UnexpectedSegment,
                            "Segment is not supported in rules class.", segment.Value, ec);                        
                    }

                    throw new ParsingException(ErrorCodes.UnexpectedSegment,
                             "Segment was not in the correct position according to the rules class.", segment.Value, ec);
                }

                var segmentTree = currSeg.AncestorsToIntersection(segmentPosition);
                instancePosition =
                    instancePosition.AncestorsAndSelf().Last(nt => nt.Name == segmentTree.First().Parent.Name);
                foreach (var parseTree in segmentTree)
                {
                    instancePosition = instancePosition.AddChild(parseTree.Type, parseTree.Type.Name);
                    if (parseTree.Prefix == Prefixes.S)
                        instancePosition.ParseSegment(segment.Value, separators);
                }
                segmentPosition = currSeg;
                Logger.Log(String.Format("Matched segment: {0}", segmentPosition.Name));
            }

            return instancePosition.Root().ToInstance();
        }

        internal static void ParseSegment(this ParseNode parseNode, string line, Separators separators)
        {
            if (parseNode == null) throw new ArgumentNullException("parseNode");
            if (String.IsNullOrEmpty(line)) throw new ArgumentNullException("line");
            if (separators == null) throw new ArgumentNullException("separators");

            if (parseNode.Prefix != Prefixes.S)
                throw new Exception(String.Format("Only segments are supported: {0}", parseNode.Name));

            var dataElementsGrammar = ParseNode.BuldTree(parseNode.Type, false).Children;
            var dataElements = line.GetDataElements(separators);
            for (var deIndex = 0; deIndex < dataElements.Length; deIndex++)
            {
                var currentDataElement = dataElements[deIndex];
                if (String.IsNullOrEmpty(currentDataElement)) continue;
                if (dataElementsGrammar.Count <= deIndex)
                {
                    var ec = new ErrorContext
                    {
                        SegmentName = parseNode.EdiName,
                        SegmentSupported = true,
                        SegmentPosition = parseNode.IndexInParent() + 1
                    };

                    throw new ParsingException(ErrorCodes.DataElementsTooMany, "Too many data elements in segment.", line, ec);
                }

                var currentDataElementGrammar = dataElementsGrammar.ElementAt(deIndex);

                var repetitions = currentDataElementGrammar.IsX12RepetitionSeparator()
                    ? new[] { currentDataElement }
                    : currentDataElement.GetRepetitions(separators);
                foreach (var repetition in repetitions)
                {
                    if (String.IsNullOrEmpty(repetition)) continue;

                    var childParseNode = parseNode.AddChild(currentDataElementGrammar.Type,
                        currentDataElementGrammar.Name,
                        currentDataElementGrammar.Prefix == Prefixes.D ? repetition.UnEscapeLine(separators) : null);

                    if (currentDataElementGrammar.Prefix != Prefixes.C) continue;

                    var componentDataElementsGrammar = currentDataElementGrammar.Children;
                    var componentDataElements = repetition.GetComponentDataElements(separators);
                    for (var cdeIndex = 0; cdeIndex < componentDataElements.Length; cdeIndex++)
                    {
                        var currentComponentDataElement = componentDataElements[cdeIndex];
                        if (String.IsNullOrEmpty(currentComponentDataElement)) continue;
                        if (componentDataElementsGrammar.Count <= cdeIndex)
                        {
                            var ec = new ErrorContext
                            {
                                SegmentName = parseNode.EdiName,
                                SegmentSupported = true,
                                SegmentPosition = parseNode.IndexInParent() + 1
                            };

                            throw new ParsingException(ErrorCodes.DataElementsTooMany, "Too many data elements in segment.", line, ec);
                        }
                        var currentComponentDataElementGrammar = componentDataElementsGrammar.ElementAt(cdeIndex);

                        childParseNode.AddChild(currentComponentDataElementGrammar.Type,
                            currentComponentDataElementGrammar.Name,
                            currentComponentDataElement.UnEscapeLine(separators));
                    }
                }
            }
        }

        private static string UnEscapeLine(this string line, Separators separators)
        {
            if (String.IsNullOrEmpty(line))
                return String.Empty;

            var result = String.Empty;
            var temp = separators.Escape.HasValue
                ? line.SplitWithEscape(separators.Escape.Value, separators.Escape.Value)
                : new List<string> { line };
            foreach (var str in temp)
            {
                result = result + str;
            }

            if (separators.Escape.HasValue && !line.EndsWith(String.Concat(separators.Escape.Value, separators.Escape.Value), StringComparison.Ordinal))
                result = result.TrimEnd(separators.Escape.Value);

            return result;
        }

        private static string[] GetRepetitions(this string value, Separators separators)
        {
            if (separators == null) throw new ArgumentNullException("separators");
            if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("value");

            if (!separators.RepetitionDataElement.HasValue)
                return new[] { value };

            if (!separators.Escape.HasValue)
            {
                return value.Split(separators.RepetitionDataElement.Value);
            }

            return value.SplitWithEscape(separators.Escape.Value,
                separators.RepetitionDataElement.Value).ToArray();
        }

        private static bool IsX12RepetitionSeparator(this ParseNode parseNode)
        {
            return parseNode.Parent != null && parseNode.Parent.Name == "S_ISA" &&
                   parseNode.Name == "D_726_11";
        }        
    }
}
