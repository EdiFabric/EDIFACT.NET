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
                    currSeg =
                        transactionSet.Descendants<Segment>()
                            .LastOrDefault(d => d.EdiName == "HL" && d.Children.ElementAt(1).Value == segment.SecondValue);

                    if (currSeg == null)
                    {
                        errorContext.Add(segment.Name, segments.IndexOf(segment) + 1, ErrorCodes.UnexpectedSegment);
                        throw new ParsingException(ErrorCodes.InvalidInterchangeContent,
                            "Unable to resolve HL.", segment.Value, errorContext);
                    }
                }

                currSeg = currSeg.TraverseDepthFirst().FirstOrDefault(n => n.Match(segment));
                if (currSeg == null)
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

                if (currSeg.IsParsed) currSeg = (Segment)currSeg.InsertRepetition();
                currSeg.Parse(segment.Value, separators);
                Logger.Log(String.Format("Matched segment: {0}", currSeg.Name));
            }
        }

        public static Tuple<string, string> PullTrailerValues(this TransactionSet transactionSet)
        {
            var msgHeader = transactionSet.Children.First();
            DataElement controlNumber = null;
            var trailerTag = "";
            if (msgHeader != null && msgHeader.EdiName == "UNH")
            {
                controlNumber = msgHeader.Children.ElementAt(0) as DataElement;
                trailerTag = "UNT";
            }

            if (msgHeader != null && msgHeader.EdiName == "ST")
            {
                controlNumber = msgHeader.Children.ElementAt(1) as DataElement;
                trailerTag = "SE";
            }

            if (msgHeader == null || controlNumber == null)
                throw new Exception("Invalid control structure. UNH or ST was not found.");

            if (String.IsNullOrEmpty(controlNumber.Value))
                throw new Exception("Invalid control number.");

            if (String.IsNullOrEmpty(trailerTag))
                throw new Exception("Invalid trailer tag.");

            return new Tuple<string, string>(controlNumber.Value, trailerTag);
        }  
    }
}
