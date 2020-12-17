using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.ValidateEDI
{
    class ValidateEDITransationsAsync
    {
        /// <summary>
        /// Validate EDI transactions async
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\EDIFACT\MixedTransactions.txt");

            List<IEdiItem> ediItems;
            using (var reader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates.D96A", new EdifactReaderSettings { SerialNumber = TrialLicense.SerialNumber }))
                ediItems = reader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TSORDERSFull>();

            foreach (var purchaseOrder in purchaseOrders)
            {
                //  Validate
                Tuple<bool, MessageErrorContext> result = await purchaseOrder.IsValidAsync(new ValidationSettings { SerialNumber = TrialLicense.SerialNumber });
                if (!result.Item1)
                {
                    //  Report it back to the sender, log, etc.
                    var errors = result.Item2.Flatten();
                }
                else
                {
                    //  purchaseOrder is valid, handle it downstream
                }
            }
        }
    }
}
