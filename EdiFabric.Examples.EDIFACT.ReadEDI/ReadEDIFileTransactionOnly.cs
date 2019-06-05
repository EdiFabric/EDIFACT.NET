using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.ReadEDI
{
    class ReadEDIFileTransactionOnly
    {
        /// <summary>
        /// Reads file without envelopes - no UNB, UNG, UNE or UNZ
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\MixedTransactionsNoEnvelopes.txt");

            //  Set the NoEnvelope flag to true
            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates.D96A", new EdifactReaderSettings() { NoEnvelope = true }))
                ediItems = ediReader.ReadToEnd().ToList();

            var items = ediItems.OfType<EdiMessage>();
            foreach (var item in items)
            {
            }
        }
    }
}
