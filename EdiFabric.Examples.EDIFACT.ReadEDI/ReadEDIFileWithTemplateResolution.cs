using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.ReadEDI
{
    class ReadEDIFileWithTemplateResolution
    {
        /// <summary>
        /// Reads the EDI stream from start to end using assembly factory. Allows you to dynamically specify a separate assembly to be used for parsing.
        /// </summary>
        public static void RunWithAssemblyFactory()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrders.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, AssemblyeFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the purchase orders
            var purchaseOrders = ediItems.OfType<TSORDERS>();
        }

        public static Assembly AssemblyeFactory(MessageContext messageContext)
        {
            if (messageContext.Version == "D96A")
                return Assembly.Load("EdiFabric.Examples.EDIFACT.Templates.D96A");

            throw new System.Exception(string.Format("Version {0} is not supported.", messageContext.Version));
        }

        /// <summary>
        /// Reads the EDI stream from start to end using type factory. Allows you to dynamically specify the exact template to be used for parsing.
        /// </summary>
        public static void RunWithTypeFactory()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrders.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, TypeFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the purchase orders
            var purchaseOrders = ediItems.OfType<TSORDERS>();
        }

        public static TypeInfo TypeFactory(UNB unb, UNG ung, UNH unh)
        {
            if (unh.MessageIdentifier_02.MessageReleaseNumber_03 == "96A" &&
                unh.MessageIdentifier_02.MessageType_01 == "ORDERS")
                return typeof(TSORDERS).GetTypeInfo();

            if (unh.MessageIdentifier_02.MessageReleaseNumber_03 == "96A" &&
                unh.MessageIdentifier_02.MessageType_01 == "INVOIC")
                return typeof(TSINVOIC).GetTypeInfo();

            throw new System.Exception(string.Format("Transaction {0} for version {1} is not supported.",
                unh.MessageIdentifier_02.MessageType_01, unh.MessageIdentifier_02.MessageVersionNumber_02 + unh.MessageIdentifier_02.MessageReleaseNumber_03));
        }        
    }
}
