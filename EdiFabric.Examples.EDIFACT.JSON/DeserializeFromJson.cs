using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Templates.EdifactD96A;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.JSON
{
    class DeserializeFromJson
    {
        /// <summary>
        /// De-serialize to an EDI object from Json using Json.NET
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrderNs.json");
            var transaction = Newtonsoft.Json.JsonConvert.DeserializeObject<TSORDERS>(ediStream.LoadToString());
        }
    }
}
