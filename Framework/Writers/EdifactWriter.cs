using System.IO;
using System.Text;
using EdiFabric.Attributes;
using EdiFabric.Framework.Parsers;
using EdiFabric.Framework.Segments.Edifact;

namespace EdiFabric.Framework.Writers
{
    public class EdifactWriter : EdiWriter<UNB, UNG>
    {
        public EdifactWriter(Stream stream, string postfix, Encoding encoding)
            : base(stream, postfix ?? "", encoding ?? Encoding.Default)
        {
        }

        public override void BeginInterchange(UNB interchangeHeader, Separators separators)
        {
            Separators = separators ?? Separators.Edifact;
            InterchangeControlNr = interchangeHeader.InterchangeControlReference_5;
            var segment = new Segment(typeof(UNB), interchangeHeader);
            Write(segment.GenerateSegment(Separators));    
        }

        public override void BeginGroup(UNG groupHeader)
        {
            MessageCounter = 0;
            GroupCounter++;
            GroupControlNr = groupHeader.GroupReferenceNumber_5;

            var segment = new Segment(typeof(UNG), groupHeader);
            Write(segment.GenerateSegment(Separators));
        }
        
        public override void EndGroup()
        {
            var trailer = SetTrailer("UNE", GroupControlNr, MessageCounter);
            Write(trailer);

            GroupControlNr = null;
        }

        public override void EndInterchange()
        {
            if (GroupCounter == 0)
                GroupCounter = MessageCounter;

            var trailer = SetTrailer("UNZ", InterchangeControlNr, GroupCounter);
            Write(trailer);

            InterchangeControlNr = null;
            Flush();
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
                Write(segment.GenerateSegment(Separators));
                segmentCounter++;
            }

            segmentCounter++;
            var trailer = SetTrailer(trailerTag, transactionSet.GetControlNumber(), segmentCounter);
            Write(trailer);
        }

        public void AddUna(Separators separators)
        {
            Write(separators.ToUna());
        }
    }
}
