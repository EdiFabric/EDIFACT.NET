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
using EdiFabric.Core.Model.Edi.ErrorCodes;
using EdiFabric.Core.Model.Edi.Exceptions;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Model
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
        
        public void Analyze(IEnumerable<SegmentContext> segments, Separators separators)
        {
            var currSeg = Children.First() as Segment;
            var index = 0;
            foreach (var segment in segments)
            {
                index++;
                if (segment.IsJump)
                {
                    currSeg =
                        this.Descendants<Segment>()
                            .LastOrDefault(
                                d => d.EdiName == "HL" && d.Children.ElementAt(1).Value == segment.SecondValue);

                    if (currSeg == null)
                        throw new SegmentException("HL not found.",
                            new ErrorContextSegment(segment.Name, index,
                                segment.Value, SegmentErrorCode.SegmentNotInProperSequence));
                }

                currSeg = currSeg.TraverseDepthFirst().FirstOrDefault(n => n.Match(segment));

                if (currSeg == null)
                {
                    var message = "Segment was not in the correct position according to the rules class.";
                    var errorCode = SegmentErrorCode.SegmentNotInProperSequence;
                    if (this.Descendants<Segment>().All(d => d.EdiName != segment.Name))
                    {
                        message = "Segment is not supported in rules class.";
                        errorCode = SegmentErrorCode.UnrecognizedSegment;
                    }

                    throw new SegmentException(message,
                            new ErrorContextSegment(segment.Name, index,
                                segment.Value, errorCode));
                }

                if (currSeg.IsParsed)
                    currSeg = (Segment)currSeg.InsertRepetition();

                try
                {
                    currSeg.Parse(segment.Value, separators);  
                }
                catch (ParsingException ex)
                {
                    var segmentContext = new ErrorContextSegment(segment.Name, index, segment.Value);
                    segmentContext.Add(ex.Name, ex.Position, ex.ErrorCode, ex.ComponentPosition, ex.RepetitionPosition,
                        ex.Value);

                    throw new SegmentException(ex.Message, segmentContext);
                }
                             
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
