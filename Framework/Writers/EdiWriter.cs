using System.IO;
using System.Text;
using EdiFabric.Attributes;

namespace EdiFabric.Framework.Writers
{
    public abstract class EdiWriter<T, U>    
    {
        private readonly StreamWriter _writer;             
        private readonly string _postFix;
        protected string InterchangeControlNr;
        protected string GroupControlNr;
        protected int MessageCounter;
        protected int GroupCounter;
        protected Separators Separators;
        
        
        protected EdiWriter(Stream stream, string postfix, Encoding encoding)
        {
            _writer = new StreamWriter(stream, encoding);
            _postFix = postfix;
        }

        public abstract void BeginInterchange(T interchangeHeader, Separators separators);

        public abstract void BeginGroup(U groupHeader);
       
        public abstract void AddMessage(IEdiMessage message);
        
        public abstract void EndGroup();

        public abstract void EndInterchange();

        protected void Write(string segment)
        {
            _writer.Write(segment + _postFix);
        }

        protected string SetTrailer(string tag, string controlNumber, int count)
        {
            return tag + Separators.DataElement + count + Separators.DataElement +
                      controlNumber + Separators.Segment;
        }

        protected void Flush()
        {
            _writer.Flush();
        }
    }
}
