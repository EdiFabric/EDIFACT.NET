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
using System.Linq;
using EdiFabric.Framework.Constants;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework
{
    static class MessageLexer
    {
        private static readonly string RulesAssembly;

        static MessageLexer()
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

        internal static object Analyze(this List<SegmentContext> segments, Separators separators, Type type,
            string rulesAssemblyName)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");
            if (type == null) throw new ArgumentNullException("type");

            var messageGrammar = ParseNode.BuldTree(type, true);

            if (messageGrammar.Prefix != Prefixes.M)
                throw new Exception(string.Format("Only messages are supported: {0}", messageGrammar.Name));

            var segmentPosition = messageGrammar.Children.First();
            var instancePosition = new ParseNode(type);

            foreach (var segment in segments)
            {
                if (segment.IsControl) continue;

                Logger.Log(string.Format("Segment to match: {0}", segment.LogName));
                // Jump back to HL segment if needed
                if (segment.IsJump)
                    segmentPosition = messageGrammar.JumpToHl(instancePosition.Root(), segment.ParentId);

                var currSeg = segmentPosition.TraverseSegmentsDepthFirst().FirstOrDefault(n => n.IsEqual(segment));
                if (currSeg == null)
                {
                    if(messageGrammar.Descendants().Any(d => d.Name == segment.Name))
                        throw new ParsingException(ErrorCodes.SegmentNotDefined, segment.Value);
                    
                    throw new ParsingException(ErrorCodes.SegmentNotFound, segment.Value);
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
                Logger.Log(string.Format("Matched segment: {0}", segmentPosition.Name));
            }

            return instancePosition.Root().ToInstance();
        }

        internal static Type ToX12Type(this List<SegmentContext> segments, Separators separators,
            string rulesAssemblyName, string rulesNamespacePrefix)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");

            var gs = segments.SingleOrDefault(es => es.Tag == SegmentTags.GS);
            if (gs == null)
                throw new ParsingException(ErrorCodes.GsNotFound);
            var ediCompositeDataElementsGs = gs.Value.GetDataElements(separators);
            if (ediCompositeDataElementsGs.Count() < 8)
                throw new ParsingException(ErrorCodes.GsInvalid);
            var version = ediCompositeDataElementsGs[7];

            var st = segments.SingleOrDefault(es => es.Tag == SegmentTags.ST);
            if (st == null)
                throw new ParsingException(ErrorCodes.StNotFound);
            var ediCompositeDataElementsSt = st.Value.GetDataElements(separators);
            var tag = ediCompositeDataElementsSt[0];

            if (ediCompositeDataElementsSt.Count() == 3)
            {
                version = ediCompositeDataElementsSt[2];
            }

            return ToType(Formats.X12, version, tag, rulesAssemblyName, rulesNamespacePrefix);
        }

        internal static Type ToEdifactType(this List<SegmentContext> segments, Separators separators,
            string rulesAssemblyName, string rulesNamespacePrefix)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");

            var unh = segments.SingleOrDefault(es => es.Tag == SegmentTags.UNH);
            if (unh == null)
                throw new ParsingException(ErrorCodes.UnhNotFound);
            var ediCompositeDataElements = unh.Value.GetDataElements(separators);
            if (ediCompositeDataElements.Count() < 2)
                throw new ParsingException(ErrorCodes.UnhInvalid);
            var ediDataElements = ediCompositeDataElements[1].GetComponentDataElements(separators);
            if (ediDataElements.Count() < 3)
                throw new ParsingException(ErrorCodes.UnhInvalid);

            var tag = ediDataElements[0];
            var version = ediDataElements[1] + ediDataElements[2];
            
            return ToType(Formats.Edifact, version, tag, rulesAssemblyName, rulesNamespacePrefix);
        }

        private static Type ToType(Formats format, string version, string tag, string rulesAssemblyName, string rulesNamespacePrefix)
        {
            if (string.IsNullOrEmpty(version)) throw new ArgumentNullException("version");
            if (string.IsNullOrEmpty(tag)) throw new ArgumentNullException("tag");
            
            var rulesAssembly = rulesAssemblyName ?? RulesAssembly;
            if(string.IsNullOrEmpty(rulesAssembly)) throw new ParsingException(ErrorCodes.RulesAssemblyNameNotSet);
            var namespacePrefix = rulesNamespacePrefix ?? "EdiFabric.Rules";
            var typeFullName = namespacePrefix.TrimEnd('.') + "." + format + version + tag;
            typeFullName = typeFullName + ".M_" + tag;
            var errorMsg = string.Format(
                            "Type '{0}' was not found in assembly '{1}'.",
                            typeFullName, rulesAssemblyName);
            try
            {
                var systemType = Type.GetType(typeFullName + ", " + rulesAssembly);
                if (systemType == null)
                    throw new ParsingException(ErrorCodes.TypeNotFound, errorMsg);

                return systemType;
            }
            catch (Exception)
            {
                throw new ParsingException(ErrorCodes.TypeNotFound, errorMsg);
            }
        }

        internal static string[] GetDataElements(this string segment, Separators separators)
        {
            if (string.IsNullOrEmpty(segment)) throw new ArgumentNullException("segment");
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
            if (string.IsNullOrEmpty(dataElement)) throw new ArgumentNullException("dataElement");

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
    }
}
