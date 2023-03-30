using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.ReadEDI
{
    class ReadEDIFileBatch
    {
        /// <summary>
        /// Reads purchase orders and invoices batched up in the same interchange.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\MixedTransactions.txt");

            //  2.  Read multiple transactions batched up in the same interchange
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
            {
                while (ediReader.Read())
                {
                    //  Process purchase orders if no parsing errors
                    var po = ediReader.Item as TSORDERS;
                    if (po != null && !po.HasErrors)
                        ProcessPurchaseOrder(ediReader.CurrentInterchangeHeader, ediReader.CurrentGroupHeader, po);

                    //  Process invoices if no parsing errors
                    var invoice = ediReader.Item as TSINVOIC;
                    if (invoice != null && !invoice.HasErrors)
                        ProcessInvoice(ediReader.CurrentInterchangeHeader, ediReader.CurrentGroupHeader, invoice);
                }
            }
        }

        private static void ProcessPurchaseOrder(UNB unb, UNG ung, TSORDERS purchaseOrder)
        {
            //  Do something with the purchase order
        }

        private static void ProcessInvoice(UNB unb, UNG ung, TSINVOIC invoice)
        {
            //  Do something with the invoice
        }
    }
}
