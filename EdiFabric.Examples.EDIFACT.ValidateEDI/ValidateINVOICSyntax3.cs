using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EancomD01B;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.ValidateEDI
{
    class ValidateINVOICSyntax3
    {
        /// <summary>
        /// Validate INVOIC
        /// </summary>
        public static void Run()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Eancom\Invoice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates.D01B.Syntax3"))
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
