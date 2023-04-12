using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.DB
{
    class SaveToDb
    {
        /// <summary>
        /// Save to DB with code first - this will create a new database the first time
        /// Edit the connection string in app.config, by default it looks for a local SQL Server instance
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\EDIFACT\PurchaseOrder.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
                ediItems = ediReader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TSORDERS>();

            using (var db = new EDIFACTContext())
            {
                foreach (var purchaseOrder in purchaseOrders)
                {
                    purchaseOrder.ClearCache();
                    db.TSORDERS.Add(purchaseOrder);
                }
                db.SaveChanges();
            }
        }
    }
}
