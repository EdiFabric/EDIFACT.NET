using System;
using System.Collections.Generic;
using System.Linq;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Parsers
{
    static class TransactionSetExtensions
    {
        public static object ParseTransactionSet(this List<SegmentContext> segments, Separators separators,
            MessageContext messageContext)
        {
            var message = new TransactionSet(messageContext.SystemType);
            message.Parse(segments, separators, messageContext);
            return message.ToInstance();
        }

        private static void Parse(this TransactionSet transactionSet, IList<SegmentContext> segments, Separators separators, MessageContext messageContext)
        {
            var errorContext = new MessageErrorContext(messageContext.Tag, messageContext.ControlNumber);
            var currSeg = transactionSet.Children.First() as Segment;

            foreach (var segment in segments)
            {
                if (segment.IsControl) continue;

                Logger.Log(String.Format("Segment to match: {0}", segment.LogName));
                // Jump back to HL segment if needed
                if (segment.IsJump)
                {
                    try
                    {
                        currSeg = transactionSet.JumpToHl(segment.ParentId);
                    }
                    catch (Exception ex)
                    {
                        errorContext.Add(segment.Name, segments.IndexOf(segment) + 1, ErrorCodes.UnexpectedSegment);
                        throw new ParsingException(ErrorCodes.InvalidInterchangeContent,
                            "Unable to resolve HL.", ex, segment.Value, errorContext);
                    }
                }

                var availableSegments = currSeg.TraverseDepthFirst().ToList();
                var match = availableSegments.FirstOrDefault(n => n.Match(segment));
                if (match == null)
                {
                    if (transactionSet.Descendants<Segment>().All(d => d.EdiName != segment.Name))
                    {
                        errorContext.Add(segment.Name, segments.IndexOf(segment) + 1, ErrorCodes.UnrecognizedSegment);
                        throw new ParsingException(ErrorCodes.InvalidInterchangeContent,
                            "Segment is not supported in rules class.", segment.Value, errorContext);
                    }

                    errorContext.Add(segment.Name, segments.IndexOf(segment) + 1, ErrorCodes.UnexpectedSegment);
                    throw new ParsingException(ErrorCodes.InvalidInterchangeContent,
                        "Segment was not in the correct position according to the rules class.", segment.Value,
                        errorContext);
                }

                if(currSeg != null && currSeg.Parent is AllLoop)
                    currSeg = availableSegments.First(s => s.Token == match.Token);
                else
                    currSeg = availableSegments.Last(s => s.Token == match.Token);

                if (currSeg.IsParsed) currSeg = (Segment)currSeg.InsertRepetition();
                currSeg.Parse(segment.Value, separators);
                Logger.Log(String.Format("Matched segment: {0}", currSeg.Name));
            }
        }

        private static Segment JumpToHl(this TransactionSet transactionSet, string parentId)
        {
            Segment result;
            var descendants = transactionSet.Descendants<Segment>();
            // Root HL, start from it
            if (parentId == null)
            {
                result = descendants.Last(d => d.EdiName == "HL" && d.Children.ElementAt(1).Value == null);
                if (result == null)
                    throw new Exception("No HL segment at parent level was found.");
                return result;
            }

            // Parent HL, start from it
            result = descendants.SingleOrDefault(
                d =>
                    d.EdiName == "HL" &&
                    d.Children.First().Value == parentId);

            if (result == null)
                throw new Exception(string.Format("No HL segment with id = {0} was found.", parentId));

            return result;    
        }
    }
}
