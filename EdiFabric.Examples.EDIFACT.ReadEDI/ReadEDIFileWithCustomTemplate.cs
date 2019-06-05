using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A.PartnerB;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.ReadEDI
{
    class ReadEDIFileWithCustomTemplate
    {
        /// <summary>
        /// Reads EDI file into a custom, partner-specific template. 
        /// Compare the files in EdiFabric.Examples.EDIFACT.Templates.D96A.PartnerB to the standard template in EdiFabric.Examples.EDIFACT.Templates.D96A
        /// for changes.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrderCustom1.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates.D96A.PartnerB"))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var purchaseOrders = ediItems.OfType<TSORDERS>();
        }
    }
}
