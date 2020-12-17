using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EdiFabric.Examples.EDIFACT.CSV
{
    class ExportToCsv
    {
        /// <summary>
        /// Export an EDI object to CSV
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrderCSV.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact", new EdifactReaderSettings { SerialNumber = TrialLicense.SerialNumber }))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TSORDERS>();
            foreach (var transaction in transactions)
            {
                var csv = Export(transaction);
                Debug.WriteLine(csv);
            }
        }

        private static string Export(TSORDERS po)
        {
            var result = new StringBuilder();
            result.AppendLine("LINE_NUMBER,UPC_NUMBER,QUANTITY,PRICE,UOM,PO_NUMBER,PO_DATE,CUSTOMER_NAME,CUSTOMER_NUMBER,ADDRESS,CITY,STATE,POSTAL_CODE");

            var orderNr = po.BGM.Documentmessagenumber_02;
            var orderDate = "";
            var dtm = po.DTM.Where(d => d.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 == "137").FirstOrDefault();
            if (dtm != null)
                orderDate = dtm.DATETIMEPERIOD_01.Datetimeperiod_02;

            var customer = "";
            var customerNr = "";
            var address = "";
            var city = "";
            var state = "";
            var postCode = "";
            var nadLoop = po.NADLoop.Where(nl => nl.NAD.Partyqualifier_01 == "BY").FirstOrDefault();
            if (nadLoop != null)
            {
                customer = nadLoop.NAD.PARTYNAME_04.Partyname_01;
                customerNr = nadLoop.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01;
                address = nadLoop.NAD.STREET_05.Streetandnumberpobox_01;
                city = nadLoop.NAD.Cityname_06;
                state = nadLoop.NAD.Countrysubentityidentification_07;
                postCode = nadLoop.NAD.Postcodeidentification_08;
            }

            foreach (var linLoop in po.LINLoop)
            {
                //  Add line number
                var line = linLoop.LIN.Lineitemnumber_01 + ",";
                //  Add item number
                line += linLoop.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 + ",";

                string quantity = "";
                string uom = "";
                var qty = linLoop.QTY.Where(q => q.QUANTITYDETAILS_01.Quantityqualifier_01 == "21").FirstOrDefault();
                if (qty != null)
                {
                    quantity = qty.QUANTITYDETAILS_01.Quantity_02;
                    uom = qty.QUANTITYDETAILS_01.Measureunitqualifier_03;
                }

                //  Add quantity
                line += quantity + ",";

                string price = "";
                var priLoop = linLoop.PRILoop.Where(pl => pl.PRI.PRICEINFORMATION_01.Pricequalifier_01 == "AAA").FirstOrDefault();
                if (priLoop != null)
                    price = priLoop.PRI.PRICEINFORMATION_01.Price_02;
                //  Add price
                line += price + ",";
                //  Add uom
                line += uom + ",";
                //  Add po number
                line += orderNr + ",";
                //  Add po date
                line += orderDate + ",";
                //  Add customer name
                line += customer + ",";
                //  Add customer number
                line += customerNr + ",";
                //  Add address line 1
                line += address + ",";
                //  Add city
                line += city + ",";
                //  Add state
                line += state + ",";
                //  Add postal code
                line += postCode + ",";

                result.AppendLine(line.TrimEnd(new[] { ',' }));
            }

            return result.ToString();
        }
    }
}
