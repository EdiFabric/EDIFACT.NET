using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
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
    class ValidateEDITransationsWithCustomCode
    {
        /// <summary>
        /// Apply custom validation for cross segment or data element scenarios
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrderInvalid.txt");

            //  The custom validation logic is applied in the template by implementing IEdiValidator.
            //  See EF_X12_004010_850_CustomValidation.cs
            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates.D96A"))
                ediItems = ediReader.ReadToEnd().ToList();

            //  Get the purchase order
            var po = ediItems.OfType<TSORDERS>().Single();

            //  Check that the custom validation was triggered
            MessageErrorContext errorContext;
            if (!po.IsValid(out errorContext))
            {
                var customValidation = errorContext.Errors.FirstOrDefault(e => e.Value == "DTM segment is missing.");
                Debug.WriteLine(customValidation.Value);
            }
        }
    }
}
