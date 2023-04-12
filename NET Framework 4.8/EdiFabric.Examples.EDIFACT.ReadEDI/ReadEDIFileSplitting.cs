using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
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

namespace EdiFabric.Examples.EDIFACT.ReadEDI
{
    class ReadEDIFileSplitting
    {
        /// <summary>
        /// Split a message into parts (blocks of segments) and read each part individually.
        /// Use to process large transactions with repeating groups.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\PurchaseOrderMultiLine.txt");

            //  The split is driven by setting which class to split by in the template.
            //  Set the class to inherit from EdiItem and the parser will automatically split by it.
            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, (UNB unb, UNG ung, UNH unh) => typeof(TSORDERSWithSplitter).GetTypeInfo(), new EdifactReaderSettings { Split = true }))
                ediItems = ediReader.ReadToEnd().ToList();

            //  Find all LIN loops, they are all separate ediItems\EdiMessages
            var linLoop = ediItems.OfType<TSORDERSWithSplitter>().Where(m => m.LINLoop != null).SelectMany(m => m.LINLoop);
            Debug.WriteLine(string.Format("LIN parts {0}", linLoop.Count()));
        }

        /// <summary>
        /// Copy a message and remove unwanted parts.
        /// </summary>
        public static void RunWithCopy()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\PurchaseOrderMultiLine.txt");

            //  The split is driven by setting which class to split by in the template.
            //  Set the class to inherit from EdiItem and the parser will automatically split by it.
            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
                ediItems = ediReader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TSORDERS>();
            var splitPurchaseOrders = new List<TSORDERS>();

            foreach (var po in purchaseOrders)
            {
                foreach (var linLoop in po.LINLoop)
                {
                    var splitPO = po.Copy() as TSORDERS;
                    splitPO.LINLoop.RemoveAll(l => splitPO.LINLoop.IndexOf(l) != po.LINLoop.IndexOf(linLoop));
                    splitPurchaseOrders.Add(splitPO);
                }
            }

            foreach (var po in purchaseOrders)
                Debug.WriteLine(string.Format("Original: PO - LIN parts {0}", po.LINLoop.Count()));

            foreach (var po in splitPurchaseOrders)
                Debug.WriteLine(string.Format("Split: PO - LIN parts {0}", po.LINLoop.Count()));
        }
    }

    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERSWithSplitter : TSORDERS
    {
        [Splitter]
        [DataMember]
        [ListCount(200000)]
        [Pos(21)]
        public new List<Loop_LIN_ORDERS> LINLoop { get; set; }
    }
}
