using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.EDIFACT.ValidateEDI
{
    class ValidateINVOIC
    {
        /// <summary>
        /// Validate INVOIC
        /// </summary>
        public static void Run()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\Invoice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates.D96A"))
                ediItems = ediReader.ReadToEnd().ToList();

            var invoices = ediItems.OfType<TSINVOIC>();

            foreach (var invoice in invoices)
            {
                //  Validate
                MessageErrorContext errorContext;
                if (!invoice.IsValid(out errorContext))
                {
                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  invoice is valid, handle it downstream
                }
            }
        }
    }
}
