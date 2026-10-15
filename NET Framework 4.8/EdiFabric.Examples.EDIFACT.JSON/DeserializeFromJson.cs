using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Templates.EdifactD96A;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text.Json;

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

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\PurchaseOrderNs.json");
            var transaction = JsonSerializer.Deserialize<TSORDERS>(ediStream.LoadToString());
        }
    }
}
