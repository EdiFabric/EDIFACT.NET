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

        internal static object Analyze(this List<SegmentContext> segments, Separators separators, Type type, string rulesAssemblyName)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");
            if (type == null) throw new ArgumentNullException("type");

            var messageGrammar = ParseNode.BuldTree(type, true);
            var segmentPosition = messageGrammar.Children.First();
            var instancePosition = new ParseNode(type);

            foreach (var segment in segments)
            {
                if (segment.IsHeader) continue;

                Logger.Log(string.Format("Segment to match: {0}", segment.LogName));
                try
                {
                    // Jump back to HL segment if needed
                    if (segment.IsJump) segmentPosition = segmentPosition.JumpToHl(instancePosition, segment.ParentId);

                    var currSeg = segmentPosition.TraverseSegmentsDepthFirst().FirstOrDefault(n => n.IsEqual(segment));
                    if (currSeg == null)
                        throw new Exception(
                            string.Format(
                                "Segment {0} was not found after segment {1} in class {2}.",
                                segment.Value, segmentPosition.EdiName, type.Name));
                    
                    var segmentTree = currSeg.AncestorsToIntersection(segmentPosition);
                    instancePosition = instancePosition.AncestorsAndSelf().Last(nt => nt.Name == segmentTree.First().Parent.Name);
                    foreach (var parseTree in segmentTree)
                    {
                        instancePosition = instancePosition.AddChild(parseTree.Type, parseTree.Type.Name);
                        if (parseTree.Prefix == Prefixes.S)
                            instancePosition.ParseSegment(segment.Value, separators);
                    }

                    segmentPosition = currSeg;
                }
                catch (Exception ex)
                {
                    throw new ParserException("Failed at line: " + segment.Value, ex);
                }
                Logger.Log(string.Format("Matched segment: {0}", segmentPosition.Name));
            }

            return instancePosition.Root().ToInstance();
        }

        internal static Type ToX12Type(this List<SegmentContext> segments, Separators separators, string rulesAssemblyName, string rulesNamespacePrefix)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");
           
            string version;
            string tag;

            try
            {
                var gs = segments.Single(es => es.Tag == SegmentTags.GS);
                var ediCompositeDataElementsGs = gs.Value.GetDataElements(separators);
                version = ediCompositeDataElementsGs[7];
            }
            catch (Exception ex)
            {
                throw new ParserException("Invalid GS segment.", ex);
            }

            try
            {
                var st = segments.Single(es => es.Tag == SegmentTags.ST);
                var ediCompositeDataElementsSt = st.Value.GetDataElements(separators);
                tag = ediCompositeDataElementsSt[0];
            }
            catch (Exception ex)
            {
                throw new ParserException("Invalid ST segment.", ex);
            }

            return ToType(Formats.X12, version, tag, rulesAssemblyName, rulesNamespacePrefix);
        }

        internal static Type ToEdifactType(this List<SegmentContext> segments, Separators separators, string rulesAssemblyName, string rulesNamespacePrefix)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");
            
            string version;
            string tag;
            try
            {
                var unh = segments.Single(es => es.Tag == SegmentTags.UNH);
                var ediCompositeDataElements = unh.Value.GetDataElements(separators);
                var ediDataElements = ediCompositeDataElements[1].GetComponentDataElements(separators);

                tag = ediDataElements[0];
                version = ediDataElements[1] + ediDataElements[2];
            }
            catch (Exception ex)
            {
                throw new ParserException("Invalid UNH segment.", ex);
            }

            return ToType(Formats.Edifact, version, tag, rulesAssemblyName, rulesNamespacePrefix);
        }

        private static Type ToType(Formats format, string version, string tag, string rulesAssemblyName, string rulesNamespacePrefix)
        {
            if (string.IsNullOrEmpty(version)) throw new ArgumentNullException("version");
            if (string.IsNullOrEmpty(tag)) throw new ArgumentNullException("tag");
            
            var rulesAssembly = rulesAssemblyName ?? RulesAssembly;
            if(string.IsNullOrEmpty(rulesAssembly)) throw new ParserException("Fully qualified EDI rules assembly name is blank.");
            var namespacePrefix = rulesNamespacePrefix ?? "EdiFabric.Rules";
            var typeFullName = namespacePrefix.TrimEnd('.') + "." + format + version + tag;
            typeFullName = typeFullName + ".M_" + tag;
            var systemType = Type.GetType(typeFullName + ", " + rulesAssembly);

            if (systemType == null)
                throw new ParserException(
                    string.Format(
                        "Type '{0}' was not found in assembly '{1}'.",
                        typeFullName, rulesAssemblyName));

            return systemType;
        }

        internal static string[] GetDataElements(this string segment, Separators separators)
        {
            if (string.IsNullOrEmpty(segment)) throw new ArgumentNullException("segment");
            if (separators == null) throw new ArgumentNullException("separators");

            return segment.SplitWithEscape(separators.Escape,
                separators.DataElement).Skip(1).ToArray();
        }

        internal static string[] GetComponentDataElements(this string dataElement, Separators separators)
        {
            if (separators == null) throw new ArgumentNullException("separators");
            if (string.IsNullOrEmpty(dataElement)) throw new ArgumentNullException("dataElement");

            return dataElement.SplitWithEscape(separators.Escape,
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
