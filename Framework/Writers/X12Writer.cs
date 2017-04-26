using System;
using System.IO;
using System.Text;
using EdiFabric.Attributes;
using EdiFabric.Framework.Parsers;
using EdiFabric.Framework.Segments.X12;

namespace EdiFabric.Framework.Writers
{
    public class X12Writer : EdiWriter<ISA, GS>
    {
        public X12Writer(ISA header, Stream stream, Separators separators, string postfix, Encoding encoding)
            : base(header, stream, separators ?? Separators.Edifact, postfix ?? "", encoding ?? Encoding.Default)
        {
            if (header == null) throw new Exception("ISA header is null.");

            header.ComponentElementSeparator_16 = Separators.ComponentDataElement.ToString();
            if (header.InterchangeControlStandardsIdentifier_11 != "U")
                header.InterchangeControlStandardsIdentifier_11 = Separators.RepetitionDataElement.ToString();

            var segment = new Segment(typeof(ISA), header);
            Writer.Write(segment.GenerateSegment(Separators) + PostFix);        
        }
        
        public override void EndGroup()
        {
            var trailer = SetTrailer("GE", CurrentGroupHeader.GroupControlNumber_6, MessageCounter);
            Writer.Write(trailer + PostFix);

            CurrentGroupHeader = null;
        }

        public override void EndInterchange()
        {
            var trailer = SetTrailer("IEA", InterchangeHeader.InterchangeControlNumber_13, GroupCounter);
            Writer.Write(trailer + PostFix);

            Writer.Flush();
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
                Writer.Write(segment.GenerateSegment(Separators) + PostFix);
                segmentCounter++;
            }

            if (transactionSet.EdiName != "TA1")
            {
                segmentCounter++;
                var trailer = SetTrailer(trailerTag, transactionSet.GetControlNumber(), segmentCounter);
                Writer.Write(trailer + PostFix);
            }
        }
    }
}
