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
using System.Xml.Serialization;

namespace EdiFabric.Examples.EDIFACT.ReadEDI
{
    class ReadEDIFileWithInheritedTemplate
    {
        /// <summary>
        /// Reads EDI file into a custom, partner-specific template. 
        /// Compare the files in EdiFabric.Examples.EDIFACT.Templates.D96A.PartnerC to the standard template in EdiFabric.Examples.EDIFACT.Templates.D96A
        /// and the base template in EdiFabric.Examples.EDIFACT.Templates.D96A.PartnerB for changes.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrderCustom2.txt");

            //  2.  Read all the contents
            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, mc => Assembly.GetEntryAssembly(), new EdifactReaderSettings { SerialNumber = TrialLicense.SerialNumber }))
                ediItems = ediReader.ReadToEnd().ToList();

            //  3.  Pull the required transactions
            var purchaseOrders = ediItems.OfType<TSORDERSPartnerC>();
        }
    }

    /// <summary>
    /// Purchase order message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERSPartnerC : TSORDERS
    {
        /// <summary>
        /// PAYMENT INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public new PAI PAI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(35)]
        [Pos(4)]
        public new List<DTM> DTM { get; set; }
    }

    /// <summary>
    /// PAYMENT INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAIPartnerC : PAI
    {
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public new C534PartnerC PAYMENTINSTRUCTIONDETAILS_01 { get; set; }

        //  Add extra field with numeric type
        [DataElement("4439", typeof(EDIFACT_N))]
        [Pos(2)]
        public string ExtraField_02 { get; set; }
    }

    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534PartnerC : C534
    {
        //  Change the validation attribute and data element type at position 3
        [StringLength(1, 5)]
        [DataElement("4444", typeof(EDIFACT_AN))]
        [Pos(3)]
        public new string Paymentmeanscoded_03 { get; set; }
    }
}
