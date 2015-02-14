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
    /// The lexer for edi messages
    /// </summary>
    class MessageLexer
    {
        /// <summary>
        /// Lexical analysis of the message
        /// </summary>
        /// <param name="segments">The edi segments.</param>
        /// <param name="envelopes">The edi envelopes.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>The pased edi message.</returns>
        public static Message Analyze(List<string> segments, List<string> envelopes, InterchangeContext interchangeContext)
        {
            // Read the message context from the envelope headers
            var messageContext = new MessageContext(envelopes, interchangeContext);

            // This will read through the grammar and will build an xml

            // Get the grammar from the context
            var messageGrammar = ParseTree.LoadFrom(messageContext.SystemType,
                pt => pt.IsMessage || pt.IsGroup || pt.IsChoice || pt.IsAll || pt.IsLoopOfLoops);
            // Set the position in the grammar
            var lastSegment = messageGrammar.Children.First();

            // Create the xml root of the parsed edi
            var ediXml = ToXml(messageGrammar, interchangeContext);
            // Set the position in the xml
            var lastXElement = ediXml;
            
            // Iterate trough the segment lines
            foreach (var segment in segments)
            {
                try
                {
                    // Find the next segment grammar
                    var currSeg = lastSegment.FindNextSegment(new SegmentFullName(segment, interchangeContext, messageContext.Format));
                    // Build the segment hierarchy
                    // This will move to the required level up for the segment parents: groups, choices, all and loop of loops,
                    // until another group is reached.
                    var segmentTree = GetSegmentTree(currSeg, lastSegment);
                    // Intersect the grammar with the parsed xml.
                    // The new chunk will be attched to this intersection point.
                    lastXElement = lastXElement.AncestorsAndSelf().Last(xe => xe.Name.LocalName == segmentTree.First().Parent.Name);

                    // Attach each bit
                    foreach (var parseTree in segmentTree)
                    {
                        // Parse if a segment, otherwise convert to xml
                        var element = parseTree.IsSegment
                            ? SegmentParser.ParseLine(parseTree, segment, interchangeContext)
                            : ToXml(parseTree, interchangeContext);

                        // Attach to the xml
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
        /// Convert a parse tree to a root xml node
        /// Without the hierarchy, only the name.
        /// </summary>
        /// <param name="parseTree">The parse tree.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>A xml node.</returns>
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
                                s => s.Parent != null && !s.Parent.IsGroup && !s.Parent.IsMessage)
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
