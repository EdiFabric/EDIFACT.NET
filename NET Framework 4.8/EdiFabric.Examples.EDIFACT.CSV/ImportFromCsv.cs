using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Templates.EdifactD96A;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.CSV
{
    class ImportFromCsv
    {
        /// <summary>
        /// Import to an EDI object from CSV
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\PurchaseOrder.csv");
            var csv = ediStream.LoadToString();
            var lines = csv.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var transaction = Import(lines);
        }

        private static TSORDERS Import(string[] lines)
        {
            var result = new TSORDERS();

            if (lines.Length < 2)
                throw new Exception("Insufficient number of lines");

            //  line[0] is the header
            var firstLine = lines[1];

            //  UNH
            result.UNH = new Core.Model.Edi.Edifact.UNH();
            result.UNH.MessageReferenceNumber_01 = "000000101";
            result.UNH.MessageIdentifier_02 = new Core.Model.Edi.Edifact.S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "ORDERS";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "96A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            var firstLineItems = firstLine.Split(new[] { ',' });
            if (firstLineItems.Count() < 13)
                throw new Exception("Insufficient number of columns");

            //  BGM
            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "220";
            result.BGM.Documentmessagenumber_02 = firstLineItems[5];
            result.BGM.Messagefunctioncoded_03 = "9";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  DTM
            var dtm = new DTM();
            dtm.DATETIMEPERIOD_01 = new C507();
            dtm.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "137";
            dtm.DATETIMEPERIOD_01.Datetimeperiod_02 = firstLineItems[6];
            dtm.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm);

            //  Repeating NAD Loops
            result.NADLoop = new List<Loop_NAD_ORDERS>();

            //  Begin NAD Loop
            var nadLoop = new Loop_NAD_ORDERS();

            //  NAD
            nadLoop.NAD = new NAD();
            nadLoop.NAD.Partyqualifier_01 = "BY";
            nadLoop.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = firstLineItems[8];
            nadLoop.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";
            nadLoop.NAD.PARTYNAME_04 = new C080();
            nadLoop.NAD.PARTYNAME_04.Partyname_01 = firstLineItems[7];
            nadLoop.NAD.STREET_05 = new C059();
            nadLoop.NAD.STREET_05.Streetandnumberpobox_01 = firstLineItems[9];
            nadLoop.NAD.Cityname_06 = firstLineItems[10];
            nadLoop.NAD.Countrysubentityidentification_07 = firstLineItems[11];
            nadLoop.NAD.Postcodeidentification_08 = firstLineItems[12];

            //  End NAD Loop
            result.NADLoop.Add(nadLoop);

            //  Repeating PO1 Loops
            result.LINLoop = new List<Loop_LIN_ORDERS>();

            foreach (var line in lines.Skip(1))
            {
                var lineItems = line.Split(new[] { ',' });
                if (lineItems.Count() < 13)
                    throw new Exception("Insufficient number of columns");

                //  Begin LIN Loop
                var linLoop = new Loop_LIN_ORDERS();

                //  LIN
                linLoop.LIN = new LIN();
                linLoop.LIN.Lineitemnumber_01 = lineItems[0];
                linLoop.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
                linLoop.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = lineItems[1];
                linLoop.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRS";

                //  Repeating QTY
                linLoop.QTY = new List<QTY>();

                //  QTY
                var qty = new QTY();
                qty.QUANTITYDETAILS_01 = new C186();
                qty.QUANTITYDETAILS_01.Quantityqualifier_01 = "21";
                qty.QUANTITYDETAILS_01.Quantity_02 = lineItems[2];
                qty.QUANTITYDETAILS_01.Measureunitqualifier_03 = lineItems[4];
                linLoop.QTY.Add(qty);

                //  Repeating PRI Loops
                linLoop.PRILoop = new List<Loop_PRI_ORDERS>();

                //  Begin PRI Loop
                var priLoop = new Loop_PRI_ORDERS();

                //  PRI
                priLoop.PRI = new PRI();
                priLoop.PRI.PRICEINFORMATION_01 = new C509();
                priLoop.PRI.PRICEINFORMATION_01.Pricequalifier_01 = "AAA";
                priLoop.PRI.PRICEINFORMATION_01.Price_02 = lineItems[3];

                //  End PRI Loop
                linLoop.PRILoop.Add(priLoop);

                //  End LIN Loop
                result.LINLoop.Add(linLoop);
            }

            result.UNS = new UNS();
            result.UNS.Sectionidentification_01 = "S";

            return result;
        }
    }
}
