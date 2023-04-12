using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.ReadEDI
{
    class ReadEDIFileWithCustomUNBorUNG
    {
        /// <summary>
        /// Read with custom UNB or UNG.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\MixedTransactions.txt");

            //  Use the base EdifactReaderBase instead of EdifactReader
            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReaderBase<UNBCustom, UNGCustom>(ediStream, "EdiFabric.Templates.Edifact"))
                ediItems = ediReader.ReadToEnd().ToList();

            var unb = ediItems.OfType<UNBCustom>();
            var ung = ediItems.OfType<UNGCustom>();
        }
    }

    public class UNBCustom : UNB
    {
    }

    public class UNGCustom : UNG
    {
    }
}
