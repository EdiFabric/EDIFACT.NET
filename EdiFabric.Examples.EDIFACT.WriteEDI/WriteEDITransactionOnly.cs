using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class WriteEDITransactionOnly
    {
        /// <summary>
        /// Write to stream without envelopes - no UNB, UNG, UNE or UNZ.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                //  Set the separators 
                using (var writer = new EdifactWriter(stream, new EdifactWriterSettings() { Separators = Separators.Edifact }))
                {
                    writer.Write(EF_EDIFACT_D96A_INVOIC_Builder.BuildInvoice("1"));
                    writer.Write(EF_EDIFACT_D96A_INVOIC_Builder.BuildInvoice("2"));
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
