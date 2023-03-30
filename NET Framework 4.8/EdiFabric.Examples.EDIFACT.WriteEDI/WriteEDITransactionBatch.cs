﻿using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class WriteEDITransactionBatch
    {
        /// <summary>
        /// Batch multiple transactions in the same functional group\EDI stream.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));

                    //  1.  Write the first invoice
                    writer.Write(SegmentBuilders.BuildInvoice("1"));

                    //  2.  Write the second invoice
                    writer.Write(SegmentBuilders.BuildInvoice("2"));

                    //  3.  Write any subsequent invoices...
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
