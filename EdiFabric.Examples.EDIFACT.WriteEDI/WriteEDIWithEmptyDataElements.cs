using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class WriteEDIWithEmptyDataElements
    {
        /// <summary>
        /// Write transactions with whitespace.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var invoice = EF_EDIFACT_D96A_INVOIC_Builder.BuildInvoice("1");

            //  Initialize a blank property
            invoice.BGM.Responsetypecoded_04 = "";

            using (var stream = new MemoryStream())
            {
                //  Set PreserveWhitespace flag to true
                using (var writer = new EdifactWriter(stream, new EdifactWriterSettings() { PreserveWhitespace = true }))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
