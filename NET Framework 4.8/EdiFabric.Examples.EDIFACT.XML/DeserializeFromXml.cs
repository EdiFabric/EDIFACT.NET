using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Templates.EdifactD96A;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace EdiFabric.Examples.EDIFACT.XML
{
    class DeserializeFromXml
    {
        /// <summary>
        /// De-serialize to an EDI object from XML using XmlSerializer
        /// </summary>
        public static void WithXmlSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\PurchaseOrder.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.Deserialize<TSORDERS>();
        }

        /// <summary>
        /// De-serialize to an EDI object from XML using DataContractSerializer
        /// </summary>
        public static void WithDataContractSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\PurchaseOrder2.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.DeserializeDataContract<TSORDERS>();
        }
    }
}
