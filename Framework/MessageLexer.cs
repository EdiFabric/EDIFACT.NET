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
        internal static object Analyze(this List<SegmentContext> segments, Separators separators, string definitionsAssembly)
        {
            var type = segments.ToType(separators, definitionsAssembly);
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

        private static Type ToType(this List<SegmentContext> envelopes, Separators separators, string definitionsAssembly)
        {
            switch (separators.Format)
            {
                case Formats.Edifact:
                    return envelopes.ToEdifactType(separators, definitionsAssembly);
                case Formats.X12:
                    return envelopes.ToX12Type(separators, definitionsAssembly);
                default:
                    throw new Exception(string.Format("Unsupported format: {0}", separators.Format));
            }
        }

        private static Type ToX12Type(this List<SegmentContext> envelopes, Separators separators, string definitionsAssembly)
        {
            string version;
            string tag;

            try
            {
                var gs = envelopes.Single(es => es.Value.StartsWith(SegmentTags.GS.ToString()));
                var ediCompositeDataElementsGs = gs.Value.GetDataElements(separators);
                version = ediCompositeDataElementsGs[7];
            }
            catch (Exception ex)
            {
                throw new ParserException("Can't parse GS segment.", ex);
            }

            try
            {
                var st = envelopes.Single(es => es.Value.StartsWith(SegmentTags.ST.ToString()));
                var ediCompositeDataElementsSt = st.Value.GetDataElements(separators);
                tag = ediCompositeDataElementsSt[0];
            }
            catch (Exception ex)
            {
                throw new ParserException("Can't parse ST segment.", ex);
            }

            return ToType(separators.Format, version, tag, definitionsAssembly);
        }

        private static Type ToEdifactType(this List<SegmentContext> envelopes, Separators separators, string definitionsAssembly)
        {
            string version;
            string tag;
            try
            {
                var unh = envelopes.Single(es => es.Value.StartsWith(SegmentTags.UNH.ToString()));
                var ediCompositeDataElements = unh.Value.GetDataElements(separators);
                var ediDataElements = ediCompositeDataElements[1].GetComponentDataElements(separators);

                tag = ediDataElements[0];
                version = ediDataElements[1] + ediDataElements[2];
            }
            catch (Exception ex)
            {
                throw new ParserException("Can't parse UNH segment.", ex);
            }

            return ToType(separators.Format, version, tag, definitionsAssembly);
        }

        private static Type ToType(Formats format, string version, string tag, string definitionsAssemblyName)
        {
            if (string.IsNullOrEmpty(version)) throw new NullReferenceException("version");
            if (string.IsNullOrEmpty(tag)) throw new NullReferenceException("tag");
            if (string.IsNullOrEmpty(definitionsAssemblyName))
                throw new NullReferenceException("definitionsAssemblyName");

            var typeFullName = "EdiFabric.Definitions" + "." + format + "_" + version + "_" + tag;

            typeFullName = typeFullName + ".M_" + tag;
            typeFullName = typeFullName + ", " + definitionsAssemblyName;

            var systemType = Type.GetType(typeFullName);

            if (systemType == null)
                throw new ParserException(
                    string.Format(
                        "Can't find type for type name = {0} .Please ensure that the correct class was added to the definitions project and that you pointed to the definitions project in your .config file.",
                        typeFullName));

            return systemType;
        }
    }
}
