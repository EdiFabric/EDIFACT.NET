using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Templates.EdifactD96A;
using EdiFabric.Examples.EDIFACT.Common;
using System;

namespace EdiFabric.Examples.EDIFACT.ORDRSP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }
            Read();
            Write();
        }

        /// <summary>
        /// Read Order Response
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Eancom\PurchaseOrderResponse.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSORDRSP>();            

            foreach (var transaction in transactions)
            {
                if (transaction.HasErrors)
                {
                    //  partially parsed
                    var errors = transaction.ErrorContext.Flatten();
                }
            }
        }

        /// <summary>
        /// Write Order Response
        /// </summary>
        static void Write()
        {
            var transaction = BuildOrderResponse("ME000001");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        /// <summary>
        /// Build order response.
        /// Original from https://www.gs1.org/sites/default/files/docs/eancom/s4/ordrsp.pdf
        /// </summary>
        static TSORDRSP BuildOrderResponse(string controlNumber)
        {
            var result = new TSORDRSP();

            //  Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "ORDRSP";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "96A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            //  Order response number ORSP12856, accepted with proposals for change
            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "231";
            result.BGM.Documentmessagenumber_02 = "ORSP12856";
            result.BGM.Messagefunctioncoded_03 = "4";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  Message date is 30th of March 2002
            var dtm1 = new DTM();
            dtm1.DATETIMEPERIOD_01 = new C507();
            dtm1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "137";
            dtm1.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020330";
            dtm1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm1);

            //  Repeating RFF Groups
            result.RFFLoop = new List<Loop_RFF_ORDRSP>();

            //  Begin RFF Group
            var rffLoop1 = new Loop_RFF_ORDRSP();

            //  Message is responding to order number 652744
            rffLoop1.RFF = new RFF();
            rffLoop1.RFF.REFERENCE_01 = new C506();
            rffLoop1.RFF.REFERENCE_01.Referencequalifier_01 = "ON";
            rffLoop1.RFF.REFERENCE_01.Referencenumber_02 = "652744";

            //  Repeating DTM
            rffLoop1.DTM = new List<DTM>();

            //  Order date is 25th of March 2002
            var dtmRff1 = new DTM();
            dtmRff1.DATETIMEPERIOD_01 = new C507();
            dtmRff1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "171";
            dtmRff1.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020325";
            dtmRff1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            rffLoop1.DTM.Add(dtmRff1);

            //  End RFF Group
            result.RFFLoop.Add(rffLoop1);

            //  Repeating NAD Groups
            result.NADLoop = new List<Loop_NAD_ORDRSP>();

            //  Begin NAD Group 1
            var nadLoop1 = new Loop_NAD_ORDRSP();

            //  Buyer is identified using GLN 5412345000013
            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.Partyqualifier_01 = "BY";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5412345000013";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating RFF NAD Groups
            nadLoop1.RFFLoop = new List<Loop_RFF_ORDRSP>();

            //  Begin RFF NAD Group
            var rffNadLoop1 = new Loop_RFF_ORDRSP();

            //  Buyer’s VAT number is 452282
            rffNadLoop1.RFF = new RFF();
            rffNadLoop1.RFF.REFERENCE_01 = new C506();
            rffNadLoop1.RFF.REFERENCE_01.Referencequalifier_01 = "VA";
            rffNadLoop1.RFF.REFERENCE_01.Referencenumber_02 = "452282";

            //  End RFF NAD Group
            nadLoop1.RFFLoop.Add(rffNadLoop1);

            //  End NAD Group 1
            result.NADLoop.Add(nadLoop1);

            //  Begin NAD Group 2
            var nadLoop2 = new Loop_NAD_ORDRSP();

            //  Supplier is identified using GLN 4012345500004
            nadLoop2.NAD = new NAD();
            nadLoop2.NAD.Partyqualifier_01 = "SU";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "4012345500004";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating RFF NAD Groups
            nadLoop2.RFFLoop = new List<Loop_RFF_ORDRSP>();

            //  Begin RFF NAD Group
            var rffNadLoop2 = new Loop_RFF_ORDRSP();

            //  Supplier’s VAT number is 87765432
            rffNadLoop2.RFF = new RFF();
            rffNadLoop2.RFF.REFERENCE_01 = new C506();
            rffNadLoop2.RFF.REFERENCE_01.Referencequalifier_01 = "VA";
            rffNadLoop2.RFF.REFERENCE_01.Referencenumber_02 = "87765432";

            //  End RFF NAD Group
            nadLoop2.RFFLoop.Add(rffNadLoop2);

            //  End NAD Group 2
            result.NADLoop.Add(nadLoop2);

            //  Repeating LIN Groups
            result.LINLoop = new List<Loop_LIN_ORDRSP>();

            //  Begin LIN Group 1
            var linLoop1 = new Loop_LIN_ORDRSP();

            //  First product identified by GTIN 3312345501102 is accepted
            linLoop1.LIN = new LIN();
            linLoop1.LIN.Lineitemnumber_01 = "1";
            linLoop1.LIN.Actionrequestnotificationcoded_02 = "5";
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "3312345501102";
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";

            //  End LIN Group 1
            result.LINLoop.Add(linLoop1);

            //  Begin LIN Group 2
            var linLoop2 = new Loop_LIN_ORDRSP();

            //  Second product identified by GTIN 3312345501003 is amended
            linLoop2.LIN = new LIN();
            linLoop2.LIN.Lineitemnumber_01 = "2";
            linLoop2.LIN.Actionrequestnotificationcoded_02 = "3";
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "3312345501003";
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";

            //  Repeating PIA
            linLoop2.PIA = new List<PIA>();

            //  Supplier’s article number ABC1234 is provided as an additional identification
            var piaLin1 = new PIA();
            piaLin1.Productidfunctionqualifier_01 = "1";
            piaLin1.ITEMNUMBERIDENTIFICATION_02 = new C212();
            piaLin1.ITEMNUMBERIDENTIFICATION_02.Itemnumber_01 = "ABC1234";
            piaLin1.ITEMNUMBERIDENTIFICATION_02.Itemnumbertypecoded_02 = "SA";
            linLoop2.PIA.Add(piaLin1);

            //  Repeating IMD
            linLoop2.IMD = new List<IMD>();

            //  Product is a traded unit
            var imdLin1 = new IMD();
            imdLin1.Itemdescriptiontypecoded_01 = "C";
            imdLin1.ITEMDESCRIPTION_03 = new C273();
            imdLin1.ITEMDESCRIPTION_03.Itemdescriptionidentification_01 = "TU";
            imdLin1.ITEMDESCRIPTION_03.Codelistresponsibleagencycoded_03 = "9";
            linLoop2.IMD.Add(imdLin1);

            //  Repeating QTY
            linLoop2.QTY = new List<QTY>();

            //  Ordered quantity is 48
            var qtyLin1 = new QTY();
            qtyLin1.QUANTITYDETAILS_01 = new C186();
            qtyLin1.QUANTITYDETAILS_01.Quantityqualifier_01 = "21";
            qtyLin1.QUANTITYDETAILS_01.Quantity_02 = "48";
            linLoop2.QTY.Add(qtyLin1);

            //  Repeating DTM
            linLoop2.DTM = new List<DTM>();

            //  Date of order is 10th of September 2002
            var dtmLin1 = new DTM();
            dtmLin1.DATETIMEPERIOD_01 = new C507();
            dtmLin1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "2";
            dtmLin1.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020910";
            dtmLin1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            linLoop2.DTM.Add(dtmLin1);

            //  Repeating MOA
            linLoop2.MOA = new List<MOA>();

            //  Value of ordered line is 26400
            var moaLin1 = new MOA();
            moaLin1.MONETARYAMOUNT_01 = new C516();
            moaLin1.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "203";
            moaLin1.MONETARYAMOUNT_01.Monetaryamount_02 = "26400";
            linLoop2.MOA.Add(moaLin1);

            //  Repeating PRI Groups
            linLoop2.PRILoop = new List<Loop_PRI_ORDRSP>();

            //  Begin PRI LIN Group
            var priLin1 = new Loop_PRI_ORDRSP();

            //  Net calculation price is 550
            priLin1.PRI = new PRI();
            priLin1.PRI.PRICEINFORMATION_01 = new C509();
            priLin1.PRI.PRICEINFORMATION_01.Pricequalifier_01 = "AAA";
            priLin1.PRI.PRICEINFORMATION_01.Price_02 = "550";
            priLin1.PRI.PRICEINFORMATION_01.Pricetypecoded_03 = "CT";
            priLin1.PRI.PRICEINFORMATION_01.Pricetypequalifier_04 = "AAA";

            //  End PRI LIN Group
            linLoop2.PRILoop.Add(priLin1);

            //  Repeating PAC Groups
            linLoop2.PACLoop = new List<Loop_PAC_ORDRSP_2>();

            //  Begin PAC LIN Group
            var pacLin1 = new Loop_PAC_ORDRSP_2();

            //  Product is packaged in a case
            pacLin1.PAC = new PAC();
            pacLin1.PAC.Numberofpackages_01 = "4";
            pacLin1.PAC.PACKAGINGDETAILS_02 = new C531();
            pacLin1.PAC.PACKAGINGDETAILS_02.Packaginglevelcoded_01 = "1";
            pacLin1.PAC.PACKAGETYPE_03 = new C202();
            pacLin1.PAC.PACKAGETYPE_03.Typeofpackagesidentification_01 = "CS";

            //  End PAC LIN Group
            linLoop2.PACLoop.Add(pacLin1);

            //  Repeating TAX Groups
            linLoop2.TAXLoop = new List<Loop_TAX_ORDRSP>();

            //  Begin TAX LIN Group
            var taxLin1 = new Loop_TAX_ORDRSP();

            //  Product is subject to standard VAT rate of 17.5 %
            taxLin1.TAX = new TAX();
            taxLin1.TAX.Dutytaxfeefunctionqualifier_01 = "7";
            taxLin1.TAX.DUTYTAXFEETYPE_02 = new C241();
            taxLin1.TAX.DUTYTAXFEETYPE_02.Dutytaxfeetypecoded_01 = "VAT";
            taxLin1.TAX.DUTYTAXFEEDETAIL_05 = new C243();
            taxLin1.TAX.DUTYTAXFEEDETAIL_05.Dutytaxfeerate_04 = "17.5";
            taxLin1.TAX.Dutytaxfeecategorycoded_06 = "S";

            //  Tax amount for product is 4620
            taxLin1.MOA = new MOA();
            taxLin1.MOA.MONETARYAMOUNT_01 = new C516();
            taxLin1.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "124";
            taxLin1.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "4620";

            //  End TAX LIN Group
            linLoop2.TAXLoop.Add(taxLin1);

            //  Repeating TDT Groups
            linLoop2.TDTLoop = new List<Loop_TDT_ORDRSP>();

            //  Begin TDT LIN Group
            var tdtLin1 = new Loop_TDT_ORDRSP();

            //  Main carriage transport for the product is a truck
            tdtLin1.TDT = new TDT();
            tdtLin1.TDT.Transportstagequalifier_01 = "20";
            tdtLin1.TDT.MODEOFTRANSPORT_03 = new C220();
            tdtLin1.TDT.MODEOFTRANSPORT_03.Modeoftransportcoded_01 = "30";
            tdtLin1.TDT.CARRIER_05 = new C040();
            tdtLin1.TDT.CARRIER_05.Carrieridentification_01 = "31";

            //  End TDT LIN Group
            linLoop2.TDTLoop.Add(tdtLin1);

            //  End LIN Group 2
            result.LINLoop.Add(linLoop2);

            //  Begin LIN Group 3
            var linLoop3 = new Loop_LIN_ORDRSP();

            //  Third product identified by GTIN 3312345501096 is not accepted
            linLoop3.LIN = new LIN();
            linLoop3.LIN.Lineitemnumber_01 = "3";
            linLoop3.LIN.Actionrequestnotificationcoded_02 = "7";
            linLoop3.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop3.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "3312345501096";
            linLoop3.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";

            //  End LIN Group 3
            result.LINLoop.Add(linLoop3);

            //  Message detail/summary separator
            result.UNS = new UNS();
            result.UNS.Sectionidentification_01 = "S";

            //  Repeating CNT
            result.CNT = new List<CNT>();

            //  Count of the number of LIN segments in the message
            var cnt = new CNT();
            cnt.CONTROL_01 = new C270();
            cnt.CONTROL_01.Controlqualifier_01 = "2";
            cnt.CONTROL_01.Controlvalue_02 = "3";
            result.CNT.Add(cnt);

            return result;
        }
    }
}

