using System.IO;
using System.Text;
using EdiFabric.Attributes;
using EdiFabric.Framework.Parsers;

namespace EdiFabric.Framework.Writers
{
    public abstract class EdiWriter<T, U>    
    {
        protected Separators Separators;
        protected StreamWriter Writer;
        protected int MessageCounter;
        protected int GroupCounter;
        protected U CurrentGroupHeader;
        protected T InterchangeHeader;
        protected string PostFix;
        
        protected EdiWriter(T header, Stream stream, Separators separators, string postfix, Encoding encoding)
        {
            InterchangeHeader = header;
            Writer = new StreamWriter(stream, encoding);
            Separators = separators;
            PostFix = postfix;
        }

        public virtual void BeginGroup(U group)
        {
            MessageCounter = 0;
            GroupCounter++;
            CurrentGroupHeader = group;

            var segment = new Segment(group.GetType(), group);
            Writer.Write(segment.GenerateSegment(Separators) + PostFix);
        }

        public abstract void AddMessage(IEdiMessage message);
        
        public abstract void EndGroup();

        public abstract void EndInterchange();

        protected virtual string SetTrailer(string tag, string controlNumber, int count)
        {
            return tag + Separators.DataElement + count + Separators.DataElement +
                      controlNumber + Separators.Segment;
        }

    }
}
