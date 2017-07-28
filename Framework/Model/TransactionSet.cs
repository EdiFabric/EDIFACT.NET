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
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Exceptions;
using System.Reflection;

namespace EdiFabric.Framework.Model
{
    class TransactionSet : ParseNode
    {
        public TransactionSet(TypeInfo typeInfo, object instance = null)
            : base(typeInfo, typeInfo.Name, typeInfo.Name)
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

        public MessageErrorContext Analyze(IEnumerable<SegmentContext> segments, MessageContext messageContext,
            Separators separators, int partsIndex, int segmentIndex)
        {
            var errorContext = new MessageErrorContext(messageContext.Name, messageContext.ControlNumber,
                messageContext.Version, partsIndex,
                "Message was parsed with errors.");

            var currSeg = Children.First() as Segment;
            var index = segmentIndex;
            foreach (var segment in segments)
            {
                Segment tempSeg;
                index++;
                if (segment.IsJump)
                {
                    tempSeg =
                        this.Descendants<Segment>()
                            .LastOrDefault(
                                d => d.EdiName == "HL" && d.Children.Count > 1 && d.Children.ElementAt(1).Value == segment.SecondValue);

                    if (tempSeg != null)
                        currSeg = tempSeg;
                }

                tempSeg = currSeg.TraverseDepthFirst().FirstOrDefault(n => n.Match(segment));
                if (tempSeg == null)
                {
                    var errorCode = SegmentErrorCode.SegmentNotInProperSequence;
                    if (this.Descendants<Segment>().All(d => d.EdiName != segment.Name))
                        errorCode = SegmentErrorCode.UnrecognizedSegment;

                    errorContext.Add(new SegmentErrorContext(segment.Name, index,
                        segment.Value, errorCode));

                    if (messageContext.PartialAllowed)
                    {
                        // ReSharper disable once RedundantAssignment
                        tempSeg = currSeg;
                        continue;
                    }

                    return errorContext;
                }
                
                currSeg = tempSeg;

                if (currSeg.IsParsed)
                    currSeg = (Segment) currSeg.InsertRepetition();

                try
                {
                    if (separators == null)
                        currSeg.Parse(segment.Value, messageContext.PartialAllowed);
                    else
                        currSeg.Parse(segment.Value, separators, messageContext.PartialAllowed);
                }
                catch (ParserSegmentException ex)
                {
                    var segmentContext = new SegmentErrorContext(segment.Name, index, segment.Value);
                    segmentContext.Add(ex.ErrorContext);
                    errorContext.Add(segmentContext);

                    if (messageContext.PartialAllowed)
                        continue;

                    return errorContext;
                }
            }

            return errorContext.HasErrors ? errorContext : null;
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
