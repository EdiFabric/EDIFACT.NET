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
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Parsers
{
    class TransactionSet : ParseNode
    {
        public string Format;
        public TransactionSet(Type type, string format, object instance = null)
            : base(type, type.Name, type.Name)
        {
            BuildChildren(instance);
            Format = format;
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
            var index = 1;
            foreach (var segment in segments)
            {
                if (segment.IsJump)
                {
                    currSeg =
                        this.Descendants<Segment>()
                            .LastOrDefault(
                                d => d.EdiName == "HL" && d.Children.ElementAt(1).Value == segment.SecondValue);

                    if (currSeg == null)
                        throw ToException(messageContext, segment, "Unable to resolve HL.", index,
                            ErrorCodes.InvalidInterchangeContent);
                }

                currSeg = currSeg.TraverseDepthFirst().FirstOrDefault(n => n.Match(segment));

                if (currSeg == null)
                {
                    var message = "Segment was not in the correct position according to the rules class.";
                    ErrorCodes errorCode = ErrorCodes.UnexpectedSegment;
                    if (this.Descendants<Segment>().All(d => d.EdiName != segment.Name))
                    {
                        message = "Segment is not supported in rules class.";
                        errorCode = ErrorCodes.UnrecognizedSegment;
                    }

                    throw ToException(messageContext, segment, message, index, errorCode);
                }

                if (currSeg.IsParsed)
                    currSeg = (Segment)currSeg.InsertRepetition();

                currSeg.Parse(segment.Value, separators);
                index++;
            }
        }

        private static ParsingException ToException(MessageContext messageContext, SegmentContext segmentContext,
            string message, int index, ErrorCodes errorCode)
        {
            var errorContext = new MessageErrorContext(messageContext.Tag, messageContext.ControlNumber);
            errorContext.Add(new SegmentErrorContext(segmentContext.Name, index, errorCode));

            return new ParsingException(ErrorCodes.InvalidInterchangeContent, message, segmentContext.Value,
                errorContext);
        }

        public string GetControlNumber()
        {
            var first = Children.FirstOrDefault();
            if(first == null)
                throw new Exception("Transaction set has no children.");

            if(Format == "X12")
                return first.Children.ElementAt(1).Value;

            if (Format == "EDIFACT")
                return first.Children.ElementAt(0).Value;

            throw new NotImplementedException(Format);
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
