using System.IO;
using System.Text;
using EdiFabric.Attributes;
using EdiFabric.Framework.Parsers;
using EdiFabric.Framework.Segments.X12;

namespace EdiFabric.Framework.Writers
{
    public class X12Writer : EdiWriter<ISA, GS>
    {
        public X12Writer(Stream stream, string postfix, Encoding encoding)
            : base(stream, postfix ?? "", encoding ?? Encoding.Default)
        {
        }

        public override void BeginInterchange(ISA interchangeHeader, Separators separators)
        {
            Separators = separators ?? Separators.X12;
            interchangeHeader.ComponentElementSeparator_16 = Separators.ComponentDataElement.ToString();
            if (interchangeHeader.InterchangeControlStandardsIdentifier_11 != "U")
                interchangeHeader.InterchangeControlStandardsIdentifier_11 = Separators.RepetitionDataElement.ToString();

            InterchangeControlNr = interchangeHeader.InterchangeControlNumber_13;

            var segment = new Segment(typeof(ISA), interchangeHeader);
            Write(segment.GenerateSegment(Separators));
        }

        public override void BeginGroup(GS groupHeader)
        {
            MessageCounter = 0;
            GroupCounter++;
            GroupControlNr = groupHeader.GroupControlNumber_6;

            var segment = new Segment(typeof(GS), groupHeader);
            Write(segment.GenerateSegment(Separators));
        }
        
        public override void EndGroup()
        {
            var trailer = SetTrailer("GE", GroupControlNr, MessageCounter);
            Write(trailer);

            GroupControlNr = null;
        }

        public override void EndInterchange()
        {
            var trailer = SetTrailer("IEA", InterchangeControlNr, GroupCounter);
            Write(trailer);

            InterchangeControlNr = null;
            Flush();
        }

        public override void AddMessage(IEdiMessage message)
        {
            MessageCounter++;

            const string trailerTag = "SE";
            var segmentCounter = 0;
            var transactionSet = new TransactionSet(message.GetType(), "X12", message);
            transactionSet.RemoveTrailer(trailerTag);
            
            foreach (var segment in transactionSet.Descendants<Segment>())
            {
                Write(segment.GenerateSegment(Separators));
                segmentCounter++;
            }

            if (transactionSet.EdiName != "TA1")
            {
                segmentCounter++;
                var trailer = SetTrailer(trailerTag, transactionSet.GetControlNumber(), segmentCounter);
                Write(trailer);
            }
        }

        public void AddTa1(TA1 ta1)
        {
            var segment = new Segment(typeof(TA1), ta1);
            Write(segment.GenerateSegment(Separators));
        }
    }
}
