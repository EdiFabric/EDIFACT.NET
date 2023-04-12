using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;

namespace EdiFabric.Examples.EDIFACT.ModifyTemplates
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());

            // Parse ORDERS
            ParsePO(Config.TestFilesPath + @"\EDIFACT\PurchaseOrder.txt");

            //  Parse modified ORDERS 
            ParseModifiedPO(Config.TestFilesPath + @"\EDIFACT\PurchaseOrderModified.txt");
        }

        public static void ParsePO(string ediFile)
        {
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + ediFile);

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, TypeFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TSORDERS>();
        }

        public static void ParseModifiedPO(string ediFile)
        {
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + ediFile);

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, ModifiedTypeFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            var modifiedPurchaseOrders = ediItems.OfType<TSORDERSModified>();
        }

        public static TypeInfo TypeFactory(UNB unb, UNG ung, UNH unh)
        {
            if (unh.MessageIdentifier_02.MessageReleaseNumber_03 == "96A" &&
               unh.MessageIdentifier_02.MessageType_01 == "ORDERS")
                return typeof(TSORDERS).GetTypeInfo();

            throw new Exception(string.Format("Transaction {0} for version {1} is not supported.",
                unh.MessageIdentifier_02.MessageType_01, unh.MessageIdentifier_02.MessageVersionNumber_02 + unh.MessageIdentifier_02.MessageReleaseNumber_03));
        }

        public static TypeInfo ModifiedTypeFactory(UNB unb, UNG ung, UNH unh)
        {
            if (unh.MessageIdentifier_02.MessageReleaseNumber_03 == "96A" &&
               unh.MessageIdentifier_02.MessageType_01 == "ORDERS")
                return typeof(TSORDERSModified).GetTypeInfo();

            throw new Exception(string.Format("Transaction {0} for version {1} is not supported.",
                unh.MessageIdentifier_02.MessageType_01, unh.MessageIdentifier_02.MessageVersionNumber_02 + unh.MessageIdentifier_02.MessageReleaseNumber_03));
        }
    }
}
