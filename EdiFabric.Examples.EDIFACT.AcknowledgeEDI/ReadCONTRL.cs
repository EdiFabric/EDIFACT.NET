using EdiFabric.Core.Model.Ack;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.Edifact.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.AcknowledgeEDI
{
    class ReadCONTRL
    {
        /// <summary>
        /// Generate CONTRL for a valid message.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\CONTRL.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric"))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the CONTRL messages
            var controls = ediItems.OfType<TSCONTRL>();
        }
    }
}
