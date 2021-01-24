using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Writers;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class WriteEDIWithNewLines
    {
        /// <summary>
        /// Write with segment postfix.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var invoice = EF_EDIFACT_D96A_INVOIC_Builder.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream, new EdifactWriterSettings() { Postfix = Environment.NewLine }))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
