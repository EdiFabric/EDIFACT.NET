using System;
using System.IO;
using System.Text;
using EdiFabric.Attributes;
using EdiFabric.Framework.Parsers;
using EdiFabric.Framework.Segments.Edifact;

namespace EdiFabric.Framework.Writers
{
    public sealed class EdifactWriter : EdiWriter<UNB, UNG>
    {
        public EdifactWriter(Stream stream)
            : base(stream, "", Encoding.Default)
        {
        }

        public EdifactWriter(Stream stream, string postfix)
            : base(stream, postfix, Encoding.Default)
        {
        }

        public EdifactWriter(Stream stream, Encoding encoding)
            : base(stream, "", encoding)
        {
        }

        public EdifactWriter(Stream stream, string postfix, Encoding encoding)
            : base(stream, postfix, encoding)
        {
        }

        public override void BeginInterchange(UNB interchangeHeader, Separators separators = null)
        {
            base.BeginInterchange(interchangeHeader, separators);

            Separators = separators ?? Separators.Edifact;            
            InterchangeControlNr = interchangeHeader.InterchangeControlReference_5;
            
            var segment = new Segment(typeof(UNB), interchangeHeader);
            Write(segment.GenerateSegment(Separators));    
        }

        public override void BeginGroup(UNG groupHeader)
        {
            base.BeginGroup(groupHeader);

            GroupControlNr = groupHeader.GroupReferenceNumber_5;

            var segment = new Segment(typeof(UNG), groupHeader);
            Write(segment.GenerateSegment(Separators));
        }
        
        public override void EndGroup()
        {
            var trailer = SetTrailer("UNE", GroupControlNr, MessageCounter);
            Write(trailer);

            base.EndGroup();
        }

        public override void EndInterchange()
        {
            if (GroupCounter == 0)
                GroupCounter = MessageCounter;

            var trailer = SetTrailer("UNZ", InterchangeControlNr, GroupCounter);
            Write(trailer);

            base.EndInterchange();
        }

        public override void AddMessage(IEdiMessage message)
        {
            base.AddMessage(message);

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
