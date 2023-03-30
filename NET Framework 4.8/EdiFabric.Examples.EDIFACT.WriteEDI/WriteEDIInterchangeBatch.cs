using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class WriteEDIInterchangeBatch
    {
        /// <summary>
        /// Batch multiple interchanges in the same EDI stream.
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
                    //  1.  Write the first interchange
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    writer.Write(SegmentBuilders.BuildInvoice("1"));

                    //  2.  Write the second interchange
                    //  No need to close the previous interchange with a IEA
                    writer.Write(SegmentBuilders.BuildUnb("2"));
                    writer.Write(SegmentBuilders.BuildInvoice("1"));
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
