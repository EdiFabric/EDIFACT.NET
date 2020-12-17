using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Examples.EDIFACT.Templates.D96A;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class WriteEDIToStreamAsync
    {
        /// <summary>
        /// Generate and write EDI document to a stream async.
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the invoice
            var invoice = EF_EDIFACT_D96A_INVOIC_Builder.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream, new EdifactWriterSettings { SerialNumber = TrialLicense.SerialNumber }))
                {
                    //  2.  Begin with UNB segment
                    await writer.WriteAsync(SegmentBuilders.BuildUnb("1"));
                    //  3.  Then write the invoice(s)
                    await writer.WriteAsync(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
