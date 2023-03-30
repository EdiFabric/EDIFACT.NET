﻿using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class WriteEDIToStream
    {
        /// <summary>
        /// Generate and write EDI document to a stream.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the invoice
            var invoice = SegmentBuilders.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream))
                {
                    //  2.  Begin with UNB segment
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    //  3.  Then write the invoice(s)
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
