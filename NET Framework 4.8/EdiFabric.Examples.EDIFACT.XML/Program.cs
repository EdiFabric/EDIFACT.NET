using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.XML
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Serialize to XML
            SerializeToXml.WithXmlSerializer();
            SerializeToXml.WithDataContractSerializer();

            //  Deserialize from XML
            DeserializeFromXml.WithXmlSerializer();
            DeserializeFromXml.WithDataContractSerializer();
        }
    }
}
