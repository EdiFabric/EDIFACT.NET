using System;
using System.IO;
using System.Reflection;
using EdiFabric.Framework.Parsing;

namespace EdiFabric.Framework.Validation
{
    public class ValidatorSettings
    {
        public Func<MessageContext, Stream> XsdStream { get; private set; }
        public int SerializerCacheMax { get; private set; }
        public int XsdCacheMax { get; private set; }

        public ValidatorSettings(Func<MessageContext, Stream> xsdStream, int serializerCacheMax = 20, int xsdCacheMax = 20)
        {
            if (xsdStream == null) throw new ArgumentNullException("xsdStream");

            XsdStream = xsdStream;
            SerializerCacheMax = serializerCacheMax;
            XsdCacheMax = xsdCacheMax;
        }

        public ValidatorSettings(string xsdAssemblyName, int serializerCacheMax = 20, int xsdCacheMax = 20)
        {
            if (string.IsNullOrEmpty(xsdAssemblyName)) throw new ArgumentNullException("xsdAssemblyName");

            XsdStream = key => Assembly.Load(xsdAssemblyName)
                .GetManifestResourceStream(string.Format("{0}.{1}", xsdAssemblyName, key.XsdName));
            SerializerCacheMax = serializerCacheMax;
            XsdCacheMax = xsdCacheMax;
        }
    }
}
