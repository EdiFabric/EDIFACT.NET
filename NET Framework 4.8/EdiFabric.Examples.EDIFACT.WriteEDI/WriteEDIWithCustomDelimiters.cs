﻿using EdiFabric.Examples.EDIFACT.Common;
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

            var invoice = SegmentBuilders.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream))
                {
                    //  Set a custom segment separator
                    var separators = Separators.Edifact;
                    separators.Segment = '|';

                    //  Write the UNB with the custom separator set
                    writer.Write(SegmentBuilders.BuildUnb("1"), separators);
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
