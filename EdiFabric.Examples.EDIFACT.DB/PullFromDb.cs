using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.EdifactD96A;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.DB
{
    class PullFromDb
    {
        /// <summary>
        /// Pull the last purchase order from DB
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var db = new EDIFACTContext())
            {
                var po = db.TSORDERS.OrderByDescending(o => o.Id).FirstOrDefault();

                using (var stream = new MemoryStream())
                {
                    using (var writer = new EdifactWriter(stream))
                    {
                        writer.Write(SegmentBuilders.BuildUnb("1"));
                        writer.Write(po);
                    }

                    Debug.Write(stream.LoadToString());
                }
            }
        }
    }
}
