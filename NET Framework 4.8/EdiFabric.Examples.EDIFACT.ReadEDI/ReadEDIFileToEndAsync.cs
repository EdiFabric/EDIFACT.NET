using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.ReadEDI
{
    class ReadEDIFileToEndAsync
    {
        /// <summary>
        /// Reads the EDI stream from start to end async.
        /// This method loads the file into memory. Do not use for large files. 
        /// The sample file contains two purchase orders - a valid one and an invalid one.
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\PurchaseOrders.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
            {
                var items = await ediReader.ReadToEndAsync();
                ediItems = items.ToList();
            }

            //  3.  Pull the purchase orders
            var purchaseOrders = ediItems.OfType<TSORDERS>();
        }
    }
}
