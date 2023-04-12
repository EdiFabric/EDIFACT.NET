using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.ReadEDI
{
    class ReadEDIFileStreamingAsync
    {
        /// <summary>
        /// Reads one item at a time from the EDI stream async.
        /// Use for interchanges containing multiple transactions.
        /// The sample file contains two purchase orders - a valid one and an invalid one.
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\PurchaseOrders.txt");

            //  2. Read item by item, that is each call to Read() 
            //  brings back either a control segment (UNB, UNG, UNE or UNZ) or a transaction
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
            {
                while (await ediReader.ReadAsync())
                {
                    //  3. Check if current item is purchase order
                    var po = ediReader.Item as TSORDERS;
                    if (po != null)
                    {
                        ProcessPurchaseOrder(ediReader.CurrentInterchangeHeader, ediReader.CurrentGroupHeader, po);
                    }
                }
            }
        }

        private static void ProcessPurchaseOrder(UNB unb, UNG ung, TSORDERS purchaseOrder)
        {
            //  Do something with the purchase order
        }
    }
}
