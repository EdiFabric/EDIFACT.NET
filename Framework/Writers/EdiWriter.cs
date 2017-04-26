using System;
using System.IO;
using System.Text;
using EdiFabric.Attributes;

namespace EdiFabric.Framework.Writers
{
    public abstract class EdiWriter<T, U> : IDisposable  
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
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (postfix == null)
                throw new ArgumentNullException("postfix");
            if (encoding == null)
                throw new ArgumentNullException("encoding");

            _writer = new StreamWriter(stream, encoding);
            _postFix = postfix;
        }

        public virtual void BeginInterchange(T interchangeHeader, Separators separators = null)
        {
            MessageCounter = 0;
            GroupCounter = 0;
            GroupControlNr = null;
            InterchangeControlNr = null;
        }

        public virtual void BeginGroup(U groupHeader)
        {
            MessageCounter = 0;
            GroupControlNr = null;
            GroupCounter++;            
        }

        public virtual void AddMessage(IEdiMessage message)
        {
            MessageCounter++;
        }

        public virtual void EndGroup()
        {
            MessageCounter = 0;
            GroupControlNr = null;
        }

        public virtual void EndInterchange()
        {
            MessageCounter = 0;
            GroupCounter = 0;
            GroupControlNr = null;
            InterchangeControlNr = null;
            Flush();
        }

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

        public void Dispose()
        {
            if (_writer != null)
                _writer.Dispose();
        }
    }
}
