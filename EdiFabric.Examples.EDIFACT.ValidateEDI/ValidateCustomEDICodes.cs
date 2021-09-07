using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.ErrorCodes;
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
using System.Runtime.Serialization;

namespace EdiFabric.Examples.EDIFACT.ValidateEDI
{
    class ValidateCustomEDICodes
    {
        /// <summary>
        /// Validate with custom EDI codes, different than the standard EDI codes
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Set EDI codes map where the original code type will be substituted with the partner-specific code type
            Dictionary<Type, Type> codeSetMap = new Dictionary<Type, Type>();
            codeSetMap.Add(typeof(EDIFACT_ID_1225), typeof(EDIFACT_ID_1225_PartnerA));

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\EDIFACT\MixedTransactions.txt");

            List<IEdiItem> ediItems;
            using (var reader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
                ediItems = reader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TSORDERS>();

            foreach (var purchaseOrder in purchaseOrders)
            {
                //  Validate using EDI codes map
                MessageErrorContext errorContext;
                if (!purchaseOrder.IsValid(out errorContext, new ValidationSettings { DataElementTypeMap = codeSetMap }))
                {
                    //  Invalid code value
                    var customCodeError = errorContext.Errors.SingleOrDefault(e => e.Errors.Any(de => de.Code == DataElementErrorCode.InvalidCodeValue));
                    
                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  purchaseOrder is valid, handle it downstream
                }
            }
        }

        /// <summary>
        /// Validate with custom EDI codes, different than the standard EDI codes. Load the code dynamically at runtime.
        /// </summary>
        public static void Run2()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Set EDI codes map where the original code type will be substituted with the partner-specific code type
            var codeSetMap = new Dictionary<string, List<string>>();
            codeSetMap.Add("EDIFACT_ID_1001", new List<string> { "A", "B", "C", "D", "E" });

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\EDIFACT\MixedTransactions.txt");

            //  Ensure that the codeset map is set on the reader
            List<IEdiItem> ediItems;
            using (var reader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact", new EdifactReaderSettings { DataElementCodesMap = codeSetMap }))
                ediItems = reader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TSORDERS>();

            foreach (var purchaseOrder in purchaseOrders)
            {
                //  Validate using EDI codes map
                MessageErrorContext errorContext;
                if (!purchaseOrder.IsValid(out errorContext, new ValidationSettings { DataElementCodesMap = codeSetMap }))
                {
                    //  Invalid code value
                    var customCodeError = errorContext.Errors.SingleOrDefault(e => e.Errors.Any(de => de.Code == DataElementErrorCode.InvalidCodeValue));

                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  purchaseOrder is valid, handle it downstream
                }
            }
        }
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",LL,PP,")]
    public class EDIFACT_ID_1225_PartnerA
    {
    }
}
