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
            var messageGrammar = new ParseTree(messageContext.SystemType, true);
            // Set the position in the grammar
            var lastSegment = messageGrammar.Children.First();

            var newTree = new ParseTree(messageContext.SystemType);

            // Create the XML root of the parsed EDI
            var ediXml = messageGrammar.ToXml(interchangeContext);
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
                            lastSegment = hl.Parent.Children.ElementAt(1);
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
                    var currSeg = lastSegment.TraverseSegmentsDepthFirst().FirstOrDefault(n => n.IsSameSegment(segmentContext));
                    if(currSeg == null)
                        throw new Exception(string.Format("Segment {0} can't be found after segment {1}. Please check the definition class.", segment, lastSegment.EdiName));
                    
                    Logger.Log(string.Format("Segment found: {0}", currSeg.Name));

                    // Build the segment hierarchy
                    // This will move to the required level up for the segment parents: groups, choices, all and loop of loops,
                    // until another group is reached.
                    var segmentTree = currSeg.GetParentsToIntersection(lastSegment);
                    // Intersect the grammar with the parsed XML.
                    // The new chunk will be attached to this intersection point.
                    lastXElement =
                        lastXElement.AncestorsAndSelf().Last(xe => xe.Name.LocalName == segmentTree.First().Parent.Name);
                    newTree = newTree.GetParentsAndSelf().Last(nt => nt.Name == segmentTree.First().Parent.Name);

                    // Attach each bit
                    foreach (var parseTree in segmentTree)
                    {
                        // Parse if a segment, otherwise convert to XML
                        var element = parseTree.Prefix == EdiPrefix.S
                            ? SegmentParser.ParseLine(parseTree, segment, interchangeContext)
                            : parseTree.ToXml(interchangeContext);

                        // Attach to the XML
                        lastXElement.Add(element);
                        // Set the last attached as the attachment point as we iterate from the top parent to the bottom segment
                        lastXElement = element;

                        newTree = newTree.AddChild(parseTree.Type);
                        if (parseTree.Prefix == EdiPrefix.S)
                        {
                            newTree.Parse(segment, interchangeContext);
                        }
                       
                        
                    }

                    //foreach (var parseTree in segmentTree.Reverse())
                    //{
                    //    newTree = newTree.AddChild(parseTree.Type);
                    //    if (parseTree.Prefix == EdiPrefix.S)
                    //    {
                    //        newTree.Parse(segment, interchangeContext);
                    //    }


                    //}

                    // Reset the position in the grammar
                    lastSegment = currSeg;
                }
                catch (Exception ex)
                {
                    throw new ParserException("Failed at line: " + segment, ex);
                }
            }

            var b = newTree.Parent.ToInstance();
            var f = EdiHelper.Serialize(b);

            var msg = new Message(b);
            var de = msg.Validate();

            var df = new Message(ediXml, messageContext);
            var ded = df.Validate();

            return df;
        } 

        
    }
}
