using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Examples.EDIFACT.Templates.D96A;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class WriteEDIWithCustomDelimiters
    {
        /// <summary>
        /// Write with custom separators, by default it uses the standard separators.
        /// UNA segment is automatically applied if any of the custom separators is different than the default.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var invoice = EF_EDIFACT_D96A_INVOIC_Builder.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream, new EdifactWriterSettings { SerialNumber = TrialLicense.SerialNumber }))
                {
                    //  Set a custom segment separator
                    var separators = new Separators('|', Separators.Edifact.ComponentDataElement,
                        Separators.Edifact.DataElement, Separators.Edifact.RepetitionDataElement, Separators.Edifact.Escape);

                    //  Write the UNB with the custom separator set
                    writer.Write(SegmentBuilders.BuildUnb("1"), separators);
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
