using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class WriteEDIToFile
    {
        /// <summary>
        /// Generate and write EDI document to a file.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the invoice
            var invoice = EF_EDIFACT_D96A_INVOIC_Builder.BuildInvoice("1");

            //  2.  Write directly to a file
            //  Change the patch to a file on your machine
            using (var writer = new EdifactWriter(@"C:\Test\Output.txt", false))
            {
                writer.Write(SegmentBuilders.BuildUnb("1"));
                writer.Write(invoice);
            }

            Debug.WriteLine("Written to file.");
        }
    }
}
