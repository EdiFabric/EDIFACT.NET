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
using System.Xml.Linq;
using EdiFabric.Framework.Envelopes;
using EdiFabric.Framework.Messages.Segments;

namespace EdiFabric.Framework.Messages
{
    /// <summary>
    /// The lexer for EDI messages.
    /// </summary>
    class MessageLexer
    {
        /// <summary>
        /// Lexically analyses a message.
        /// </summary>
        /// <param name="segments">The EDI segments.</param>
        /// <param name="envelopes">The EDI envelopes.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>The passed Edi message.</returns>
        public static Message Analyze(List<string> segments, List<string> envelopes, InterchangeContext interchangeContext)
        {
            // Read the message context from the envelope headers
            var messageContext = new MessageContext(envelopes, interchangeContext);

            // This will read through the grammar and will build an XML

            // Get the grammar from the context
            var messageGrammar = ParseTree.LoadFrom(messageContext.SystemType,
                pt => pt.IsMessage || pt.IsGroup || pt.IsChoice || pt.IsAll || pt.IsLoopOfLoops);
            // Set the position in the grammar
            var lastSegment = messageGrammar.Children.First();

            // Create the XML root of the parsed EDI
            var ediXml = ToXml(messageGrammar, interchangeContext);
            // Set the position in the XML
            var lastXElement = ediXml;
            
            // Iterate trough the segment lines
            foreach (var segment in segments)
            {
                try
                {
                    var segmentContext = new SegmentContext(segment, interchangeContext, messageContext.Format);

                    Logger.Log(string.Format("Segment to find: {0}", segmentContext.ToPropertiesString()));

                    // Jump back to HL segment if needed
                    if (segmentContext.IsJump())
                    {
                        XElement hlParent;
                        if (segmentContext.ParentId != null)
                        {
                            // Parent HL, start right after it
                            hlParent = ediXml.Descendants().Single(d => d.Name.LocalName.StartsWith("S_HL") &&
                                                                        d.Elements().First().Value ==
                                                                        segmentContext.ParentId);
                            var hl = messageGrammar.Descendants().Single(pt => pt.Name == hlParent.Name.LocalName);
                            lastSegment = hl.Parent.Children[1];
                        }
                        else
                        {
                            // Root HL, start from it
                            hlParent = ediXml.Descendants().First(d => d.Name.LocalName.StartsWith("S_HL"));
                            var hl = messageGrammar.Descendants().Single(pt => pt.Name == hlParent.Name.LocalName);
                            lastSegment = hl;
                        }
                    }

                    // Find the next segment grammar
                    var currSeg = lastSegment.FindNextSegment(segmentContext);

                    Logger.Log(string.Format("Segment found: {0}", currSeg.Name));

                    // Build the segment hierarchy
                    // This will move to the required level up for the segment parents: groups, choices, all and loop of loops,
                    // until another group is reached.
                    var segmentTree = GetSegmentTree(currSeg, lastSegment);
                    // Intersect the grammar with the parsed XML.
                    // The new chunk will be attached to this intersection point.
                    lastXElement =
                        lastXElement.AncestorsAndSelf().Last(xe => xe.Name.LocalName == segmentTree.First().Parent.Name);

                    // Attach each bit
                    foreach (var parseTree in segmentTree)
                    {
                        // Parse if a segment, otherwise convert to XML
                        var element = parseTree.IsSegment
                            ? SegmentParser.ParseLine(parseTree, segment, interchangeContext)
                            : ToXml(parseTree, interchangeContext);

                        // Attach to the XML
                        lastXElement.Add(element);
                        // Set the last attached as the attachment point as we iterate from the top parent to the bottom segment
                        lastXElement = element;
                    }

                    // Reset the position in the grammar
                    lastSegment = currSeg;
                }
                catch (Exception ex)
                {
                    throw new ParserException("Failed at line: " + segment, ex);
                }
            }

            return new Message(ediXml, messageContext);
        }

        /// <summary>
        /// Convert a parse tree to a root XML node.
        /// Without the hierarchy, only the name.
        /// </summary>
        /// <param name="parseTree">The parse tree.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>A XML node.</returns>
        private static XElement ToXml(ParseTree parseTree, InterchangeContext interchangeContext)
        {
            XNamespace ns = interchangeContext.TargetNamespace;
            return new XElement(ns + parseTree.Name);
        }

        /// <summary>
        /// Get ancestors of a segment until a group is reached, excluding the parent group.
        /// </summary>
        /// <param name="segment">
        /// The segment grammar.
        /// </param>
        /// <param name="lastFoundSegment">
        /// The last segment that was found.
        /// </param>
        /// <returns>
        /// List of segment ancestors.
        /// </returns>
        private static IEnumerable<ParseTree> GetSegmentTree(ParseTree segment, ParseTree lastFoundSegment)
        {
            var result = new List<ParseTree>();

            // Do only for segments with parent different than message
            if (!segment.Parent.IsMessage && segment.IsSegment)
            {
                // Trigger segments, e.g. the first segment in a group
                if (segment.IsTrigger && segment.Parent != null && segment.Parent.IsGroup)
                {
                    // A->G->S
                    if (segment.Parent.Parent != null && segment.Parent.Parent.IsAll)
                    {
                        var lastFoundParents =
                            lastFoundSegment.GetParents(
                                s => s.Parent != null && !s.Parent.IsMessage)
                                .Where(p => !p.IsChoice)
                                .ToList();
                        var segmentParents =
                            segment.GetParents(s => s.Parent != null && !s.Parent.IsGroup && !s.Parent.IsMessage)
                                .Where(p => !p.IsChoice)
                                .ToList();

                        if (
                            !lastFoundParents.Where(p => p.IsAll)
                                .Select(n => n.Name)
                                .Intersect(segmentParents.Where(p => p.IsAll).Select(n => n.Name))
                                .Any() &&
                            !lastFoundParents.Where(p => p.IsGroup)
                                .Select(n => n.Name)
                                .Intersect(segmentParents.Where(p => p.IsGroup).Select(n => n.Name))
                                .Any())
                        {
                            result.Add(segment.Parent.Parent);
                        }
                    }

                    // A->U->G->S
                    if (segment.Parent.Parent != null && segment.Parent.Parent.IsLoopOfLoops)
                    {
                        var lastFoundGroupName = lastFoundSegment.Parent.IsGroup || lastFoundSegment.Parent.IsMessage
                            ? lastFoundSegment.Parent.Name
                            : lastFoundSegment.Parent.Parent.Name;

                        if (lastFoundGroupName != segment.Parent.Name)
                        {
                            result.Add(segment.Parent.Parent.Parent);
                            result.Add(segment.Parent.Parent);
                        }
                    }

                    // G->S
                    result.Add(segment.Parent);
                }
                else
                {
                    // A->S or I->S
                    if ((segment.Parent.IsAll || segment.Parent.IsChoice) &&
                        lastFoundSegment.Parent.Name != segment.Parent.Name)
                    {
                        result.Add(segment.Parent);
                    }
                }
            }
            
            result.Add(segment);

            return result;
        }
    }
}
