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
using System.Linq;
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework
{
    static class MessageLexer
    {
        internal static object Analyze(this List<SegmentContext> segments, Separators separators, string definitionsAssemblyName)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");
            if (string.IsNullOrEmpty(definitionsAssemblyName)) throw new ArgumentNullException("definitionsAssemblyName");

            var type = segments.ToType(separators, definitionsAssemblyName);
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
                                "Reference to segment {0} was not found in the definition class. Last found segment was {1}.",
                                segment.Value, segmentPosition.EdiName));
                    
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

        private static Type ToType(this List<SegmentContext> segments, Separators separators, string definitionsAssemblyName)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");
            if (string.IsNullOrEmpty(definitionsAssemblyName)) throw new ArgumentNullException("definitionsAssemblyName");

            switch (separators.Format)
            {
                case Formats.Edifact:
                    return segments.ToEdifactType(separators, definitionsAssemblyName);
                case Formats.X12:
                    return segments.ToX12Type(separators, definitionsAssemblyName);
                default:
                    throw new Exception(string.Format("Unsupported format: {0}", separators.Format));
            }
        }

        private static Type ToX12Type(this List<SegmentContext> segments, Separators separators, string definitionsAssemblyName)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");
            if (string.IsNullOrEmpty(definitionsAssemblyName)) throw new ArgumentNullException("definitionsAssemblyName");

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

            return ToType(separators.Format, version, tag, definitionsAssemblyName);
        }

        private static Type ToEdifactType(this List<SegmentContext> segments, Separators separators, string definitionsAssemblyName)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");
            if (string.IsNullOrEmpty(definitionsAssemblyName)) throw new ArgumentNullException("definitionsAssemblyName");

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

            return ToType(separators.Format, version, tag, definitionsAssemblyName);
        }

        private static Type ToType(Formats format, string version, string tag, string definitionsAssemblyName)
        {
            if (string.IsNullOrEmpty(version)) throw new ArgumentNullException("version");
            if (string.IsNullOrEmpty(tag)) throw new ArgumentNullException("tag");
            if (string.IsNullOrEmpty(definitionsAssemblyName)) throw new ArgumentNullException("definitionsAssemblyName");

            var typeFullName = "EdiFabric.Rules." + format + version + tag;

            typeFullName = typeFullName + ".M_" + tag;
            var systemType = Type.GetType(typeFullName + ", " + definitionsAssemblyName);

            if (systemType == null)
                throw new ParserException(
                    string.Format(
                        "Type '{0}' was not found in assembly '{1}'.",
                        typeFullName, definitionsAssemblyName));

            return systemType;
        }
    }
}
