using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Examples.EDIFACT.Templates.D96A;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class WriteEDIGroupBatch
    {
        /// <summary>
        /// Batch multiple transactions under multiple functional groups in the same EDI stream.
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

                    //  1.  Write the first group      
                    writer.Write(SegmentBuilders.BuildUng("1", "INVOIC"));
                    writer.Write(EF_EDIFACT_D96A_INVOIC_Builder.BuildInvoice("1"));

                    //  2.  Write the second group
                    //  No need to close the previous group with a UNE
                    writer.Write(SegmentBuilders.BuildUng("2", "ORDERS"));
                    writer.Write(EF_EDIFACT_D96A_ORDERS_Builder.BuildPurchaseOrder("1"));
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
