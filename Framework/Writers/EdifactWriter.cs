using System;
using System.IO;
using System.Text;
using EdiFabric.Attributes;
using EdiFabric.Framework.Parsers;
using EdiFabric.Framework.Segments.Edifact;

namespace EdiFabric.Framework.Writers
{
    public class EdifactWriter : EdiWriter<UNB, UNG>
    {
        public EdifactWriter(UNB header, Stream stream, Separators separators, string postfix, Encoding encoding)
            : base(header, stream, separators ?? Separators.Edifact, postfix ?? "", encoding ?? Encoding.Default)
        {
            if (header == null) throw new Exception("UNB header is null.");

            var segment = new Segment(typeof(UNB), header);
            Writer.Write(segment.GenerateSegment(Separators) + PostFix);        
        }
        
        public override void EndGroup()
        {
            var trailer = SetTrailer("UNE", CurrentGroupHeader.GroupReferenceNumber_5, MessageCounter);
            Writer.Write(trailer + PostFix);

            CurrentGroupHeader = null;
        }

        public override void EndInterchange()
        {
            if (GroupCounter == 0)
                GroupCounter = MessageCounter;

            var trailer = SetTrailer("UNZ", InterchangeHeader.InterchangeControlReference_5, GroupCounter);
            Writer.Write(trailer + PostFix);

            Writer.Flush();
        }

        public override void AddMessage(IEdiMessage message)
        {
            MessageCounter++;

            const string trailerTag = "UNT";
            var segmentCounter = 0;
            var transactionSet = new TransactionSet(message.GetType(), "EDIFACT", message);
            transactionSet.RemoveTrailer(trailerTag);
            
            foreach (var segment in transactionSet.Descendants<Segment>())
            {
                Writer.Write(segment.GenerateSegment(Separators) + PostFix);
                segmentCounter++;
            }

            segmentCounter++;
            var trailer = SetTrailer(trailerTag, transactionSet.GetControlNumber(), segmentCounter);
            Writer.Write(trailer + PostFix);
        }
    }
}
