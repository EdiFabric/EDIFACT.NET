using EdiFabric.Examples.EDIFACT.Common;
using System;

namespace EdiFabric.Examples.EDIFACT.XML
{
    class Program
    {
        static void Main(string[] args)
        {
            License.SetSerial(Config.TrialSerialKey);

            //  Serialize to XML
            SerializeToXml.WithXmlSerializer();
            SerializeToXml.WithDataContractSerializer();

            //  Deserialize from XML
            DeserializeFromXml.WithXmlSerializer();
            DeserializeFromXml.WithDataContractSerializer();
        }
    }
}
