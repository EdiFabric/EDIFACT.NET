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

namespace EdiFabric.Framework.Parsers
{
    class TransactionSet : ParseNode
    {
        public TransactionSet(Type type, object instance = null)
            : base(type, type.Name, type.Name)
        {
            BuildChildren(instance);
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IEnumerable<ParseNode> exclusion)
        {
            var result = new List<ParseNode>();
            result.AddRange(this.ChildrenWithExclusion(exclusion.ToList()));
            if (!result.Any())
                result.AddRange(Children);
            return result;
        }
        
        public void Analyze(IEnumerable<SegmentContext> segments, Separators separators, MessageContext messageContext)
        {
            var currSeg = Children.First() as Segment;
            foreach (var segment in segments)
            {
                if (segment.IsJump)
                {
                    currSeg =
                        this.Descendants<Segment>()
                            .LastOrDefault(
                                d => d.EdiName == "HL" && d.Children.ElementAt(1).Value == segment.SecondValue);

                    if (currSeg == null)
                        throw new ParsingException(ErrorCode.InvalidInterchangeContent, "Unable to resolve HL.",
                            segment.Value, messageContext.Tag, messageContext.ControlNumber);
                }

                currSeg = currSeg.TraverseDepthFirst().FirstOrDefault(n => n.Match(segment));

                if (currSeg == null)
                {
                    var message = "Segment was not in the correct position according to the rules class.";
                    ErrorCode errorCode = ErrorCode.UnexpectedSegment;
                    if (this.Descendants<Segment>().All(d => d.EdiName != segment.Name))
                    {
                        message = "Segment is not supported in rules class.";
                        errorCode = ErrorCode.UnrecognizedSegment;
                    }

                    throw new ParsingException(errorCode, message, segment.Value, messageContext.Tag,
                        messageContext.ControlNumber);
                }

                if (currSeg.IsParsed)
                    currSeg = (Segment)currSeg.InsertRepetition();

                currSeg.Parse(segment.Value, separators);
            }
        }    

        public void RemoveTrailer(string trailerTag)
        {
            var last = Children.LastOrDefault();
            if (last == null)
                throw new Exception("Transaction set has no children.");

            if (last.EdiName == trailerTag)
                RemoveChild(last);
        }
    }
}
