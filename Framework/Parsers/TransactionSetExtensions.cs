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

                currSeg = currSeg.TraverseDepthFirst().FirstOrDefault(n => n.Match(segment));
                if (currSeg == null)
                {
                    if (transactionSet.Descendants().All(d => d.EdiName != segment.Name))
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

                if (currSeg.IsParsed) currSeg = (Segment)currSeg.InsertRepetition();
                currSeg.Parse(segment.Value, separators);
                Logger.Log(String.Format("Matched segment: {0}", currSeg.Name));
            }
        }

        private static Segment JumpToHl(this TransactionSet transactionSet, string parentId)
        {
            ParseNode hlParent;
            if (parentId != null)
            {
                // Parent HL, start right after it
                hlParent =
                    transactionSet.Descendants()
                        .SingleOrDefault(
                            d =>
                                (d.Name == "HL" || d.Name.StartsWith("HL_", StringComparison.Ordinal)) &&
                                d.Children.First().Value == parentId);
                if (hlParent == null)
                    throw new Exception(string.Format("HL with id = {0} was not found.", parentId));

                var nextSegment = transactionSet.Descendants().Reverse().OfType<Segment>().FindNextSegment(pt => pt.Name == hlParent.Name);

                if (nextSegment == null)
                    throw new Exception(string.Format("No segment after HL with id = {0} .", parentId));

                return nextSegment;
            }

            // Root HL, start from it
            return
                transactionSet.Descendants()
                    .Reverse().OfType<Segment>()
                    .First(d => (d.Name == "HL" || d.Name.StartsWith("HL_", StringComparison.Ordinal)));

        }

        private static Segment FindNextSegment(this IEnumerable<Segment> items, Predicate<ParseNode> matchPredicate)
        {
            using (var iter = items.GetEnumerator())
            {
                while (iter.MoveNext())
                {
                    if (matchPredicate(iter.Current))
                    {
                        if (iter.MoveNext())
                            return iter.Current;
                    }
                }
            }

            return null;
        }
    }
}
