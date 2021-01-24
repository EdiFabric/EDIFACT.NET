using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class WriteEDIWithoutAutoTrailers
    {
        /// <summary>
        /// Write without auto trailers
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                //  Set AutoTrailers to false
                using (var writer = new EdifactWriter(stream, new EdifactWriterSettings { AutoTrailers = false }))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    writer.Write(EF_EDIFACT_D96A_INVOIC_Builder.BuildInvoice("1"));
                    //  trailers need to be manually written   
                }

                using (var writer = new StreamWriter(stream))
                {
                    var unz = new UNZ();
                    unz.InterchangeControlCount_1 = "1";
                    unz.InterchangeControlReference_2 = "000000001";
                    writer.Write(unz.ToEdi(Separators.Edifact));

                    writer.Flush();

                    Debug.Write(stream.LoadToString());
                }
            }
        }
    }
}
