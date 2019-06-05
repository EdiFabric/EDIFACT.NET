using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.EdifactD96A;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.ORDERS
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Purchase Orders 
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrder.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates.D96A.NoValidation"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSORDERS>();

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
        /// Write Purchase Orders
        /// </summary>
        static void Write()
        {
            var transaction = BuildPurchaseOrder("1");

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
        /// Build purchase order.
        /// Original from https://www.gs1.org/standards/edi-xml-gs1-eancom/eancom-orders-s4/syntax-4
        /// </summary>
        public static TSORDERS BuildPurchaseOrder(string controlNumber)
        {
            var result = new TSORDERS();

            //  Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "ORDERS";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "96A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            //  Order number 128576
            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "220";
            result.BGM.Documentmessagenumber_02 = "128576";
            result.BGM.Messagefunctioncoded_03 = "9";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  Message date 30th of August 2002
            var dtm = new DTM();
            dtm.DATETIMEPERIOD_01 = new C507();
            dtm.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "137";
            dtm.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020830";
            dtm.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm);

            //  Instruction to pay in Bank Account
            result.PAI = new PAI();
            result.PAI.PAYMENTINSTRUCTIONDETAILS_01 = new C534();
            result.PAI.PAYMENTINSTRUCTIONDETAILS_01.Paymentmeanscoded_03 = "42";

            //  Repeating FTX
            result.FTX = new List<FTX>();

            //  Free text mutually defined
            var ftx = new FTX();
            ftx.Textsubjectqualifier_01 = "ZZZ";
            ftx.Textfunctioncoded_02 = "1";
            ftx.TEXTREFERENCE_03 = new C107();
            ftx.TEXTREFERENCE_03.Freetextcoded_01 = "001";
            ftx.TEXTREFERENCE_03.Codelistresponsibleagencycoded_03 = "91";
            result.FTX.Add(ftx);

            //  Repeating RFF Groups
            result.RFFLoop = new List<Loop_RFF_ORDERS>();

            //  Begin RFF Group 
            var rffLoop = new Loop_RFF_ORDERS();

            //  Order is based on contract number 652744
            rffLoop.RFF = new RFF();
            rffLoop.RFF.REFERENCE_01 = new C506();
            rffLoop.RFF.REFERENCE_01.Referencequalifier_01 = "CT";
            rffLoop.RFF.REFERENCE_01.Referencenumber_02 = "652744";

            //  Repeating DTM
            rffLoop.DTM = new List<DTM>();

            //  Date of contract 25th of August 2002            
            var rffDtm1 = new DTM();
            rffDtm1.DATETIMEPERIOD_01 = new C507();
            rffDtm1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "171";
            rffDtm1.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020825";
            rffDtm1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            rffLoop.DTM.Add(rffDtm1);

            //  End RFF Group             
            result.RFFLoop.Add(rffLoop);

            //  Repeating NAD Groups
            result.NADLoop = new List<Loop_NAD_ORDERS>();

            //  Begin NAD Group 1 
            var nadLoop1 = new Loop_NAD_ORDERS();

            //  Buyer is identified by GLN 5412345000013            
            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.Partyqualifier_01 = "BY";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5412345000013";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating RFF Groups
            nadLoop1.RFFLoop = new List<Loop_RFF_ORDERS>();

            //  Begin RFF Group
            var rffLoopNad = new Loop_RFF_ORDERS();

            //  Buyer’s VAT number is 87765432
            rffLoopNad.RFF = new RFF();
            rffLoopNad.RFF.REFERENCE_01 = new C506();
            rffLoopNad.RFF.REFERENCE_01.Referencequalifier_01 = "VA";
            rffLoopNad.RFF.REFERENCE_01.Referencenumber_02 = "87765432";

            //  End RFF Group
            nadLoop1.RFFLoop.Add(rffLoopNad);

            //  Repeating CTA Groups
            nadLoop1.CTALoop = new List<Loop_CTA_ORDERS>();

            //  Begin CTA Group
            var ctaLoop = new Loop_CTA_ORDERS();

            //  Order contact is PForget
            ctaLoop.CTA = new CTA();
            ctaLoop.CTA.Contactfunctioncoded_01 = "OC";
            ctaLoop.CTA.DEPARTMENTOREMPLOYEEDETAILS_02 = new C056();
            ctaLoop.CTA.DEPARTMENTOREMPLOYEEDETAILS_02.Departmentoremployee_02 = "P FORGET";

            //  Repeating COM
            ctaLoop.COM = new List<COM>();

            //  Telephone number of order contact            
            var com = new COM();
            com.COMMUNICATIONCONTACT_01 = new C076();
            com.COMMUNICATIONCONTACT_01.Communicationnumber_01 = "0044715632478";
            com.COMMUNICATIONCONTACT_01.Communicationchannelqualifier_02 = "TE";
            ctaLoop.COM.Add(com);

            //  End CTA Group
            nadLoop1.CTALoop.Add(ctaLoop);

            //  End NAD Group 1
            result.NADLoop.Add(nadLoop1);

            //  Begin NAD Group 2 
            var nadLoop2 = new Loop_NAD_ORDERS();

            //  Supplier is identified by GLN 4012345500004
            nadLoop2.NAD = new NAD();
            nadLoop2.NAD.Partyqualifier_01 = "SU";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "4012345500004";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating RFF Groups
            nadLoop2.RFFLoop = new List<Loop_RFF_ORDERS>();

            //  Begin RFF Group  
            var rffLoopNad2 = new Loop_RFF_ORDERS();

            //  Supplier’s VAT number is 56225432
            rffLoopNad2.RFF = new RFF();
            rffLoopNad2.RFF.REFERENCE_01 = new C506();
            rffLoopNad2.RFF.REFERENCE_01.Referencequalifier_01 = "VA";
            rffLoopNad2.RFF.REFERENCE_01.Referencenumber_02 = "56225432";

            //  End RFF Group
            nadLoop2.RFFLoop.Add(rffLoopNad2);

            //  End NAD Group 2
            result.NADLoop.Add(nadLoop2);

            //  Repeating CUX Groups
            result.CUXLoop = new List<Loop_CUX_ORDERS>();

            //  Begin CUX Group  
            var cuxLoop = new Loop_CUX_ORDERS();

            //  Ordering currency is Pounds Sterling with the invoicing currency identified as Euros 
            //  The exchange rate between them is 1 Pound Sterling equals 1.67 Euros
            cuxLoop.CUX = new CUX();
            cuxLoop.CUX.CURRENCYDETAILS_01 = new C504();
            cuxLoop.CUX.CURRENCYDETAILS_01.Currencydetailsqualifier_01 = "2";
            cuxLoop.CUX.CURRENCYDETAILS_01.Currencycoded_02 = "GBP";
            cuxLoop.CUX.CURRENCYDETAILS_01.Currencyqualifier_03 = "9";
            cuxLoop.CUX.CURRENCYDETAILS_02 = new C504();
            cuxLoop.CUX.CURRENCYDETAILS_02.Currencydetailsqualifier_01 = "3";
            cuxLoop.CUX.CURRENCYDETAILS_02.Currencycoded_02 = "EUR";
            cuxLoop.CUX.CURRENCYDETAILS_02.Currencyqualifier_03 = "4";
            cuxLoop.CUX.Rateofexchange_03 = "1.67";

            //  Repeating DTM
            cuxLoop.DTM = new List<DTM>();

            //  Period on which rate of exchange date is based is the
            //  1st of August 2002 - 31st of August 2002
            var dtmCux = new DTM();
            dtmCux.DATETIMEPERIOD_01 = new C507();
            dtmCux.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "134";
            dtmCux.DATETIMEPERIOD_01.Datetimeperiod_02 = "2002080120020831";
            dtmCux.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "718";
            cuxLoop.DTM.Add(dtmCux);

            //  End CUX Group
            result.CUXLoop.Add(cuxLoop);

            //  Repeating TDT Groups
            result.TDTLoop = new List<Loop_TDT_ORDERS>();

            //  Begin TDT Group
            var tdtLoop = new Loop_TDT_ORDERS();

            //  Order requests that the main carriage transport used to deliver the goods is a truck
            tdtLoop.TDT = new TDT();
            tdtLoop.TDT.Transportstagequalifier_01 = "20";
            tdtLoop.TDT.MODEOFTRANSPORT_03 = new C220();
            tdtLoop.TDT.MODEOFTRANSPORT_03.Modeoftransportcoded_01 = "30";
            tdtLoop.TDT.TRANSPORTMEANS_04 = new C228();
            tdtLoop.TDT.TRANSPORTMEANS_04.Typeofmeansoftransportidentification_01 = "31";

            //  End TDT Group
            result.TDTLoop.Add(tdtLoop);

            //  Repeating TOD Groups
            result.TODLoop = new List<Loop_TOD_ORDERS>();

            //  Begin TOD Group
            var todLoop = new Loop_TOD_ORDERS();

            //  Terms of delivery are to be Cost, Insurance and Freight
            todLoop.TOD = new TOD();
            todLoop.TOD.Termsofdeliveryortransportfunctioncoded_01 = "3";
            todLoop.TOD.TERMSOFDELIVERYORTRANSPORT_03 = new C100();
            todLoop.TOD.TERMSOFDELIVERYORTRANSPORT_03.Termsofdeliveryortransportcoded_01 = "CIF";
            todLoop.TOD.TERMSOFDELIVERYORTRANSPORT_03.Codelistqualifier_02 = "23";
            todLoop.TOD.TERMSOFDELIVERYORTRANSPORT_03.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating LOC Group
            todLoop.LOC = new List<LOC>();

            //  The named port is Brussels
            var loc = new LOC();
            loc.Placelocationqualifier_01 = "1";
            loc.LOCATIONIDENTIFICATION_02 = new C517();
            loc.LOCATIONIDENTIFICATION_02.Placelocationidentification_01 = "BE-BRU";
            todLoop.LOC.Add(loc);

            //  End TOD Group
            result.TODLoop.Add(todLoop);

            //  Repeating LIN Groups
            result.LINLoop = new List<Loop_LIN_ORDERS>();

            //  Begin LIN Group 1
            var linLoop1 = new Loop_LIN_ORDERS();

            //  First product order is identified by GTIN 4000862141404
            linLoop1.LIN = new LIN();
            linLoop1.LIN.Lineitemnumber_01 = "1";
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "4000862141404";
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRS";

            //  Repeating PIA
            linLoop1.PIA = new List<PIA>();

            //  In addition the buyer’s part number ABC1234 is provided
            var pia = new PIA();
            pia.Productidfunctionqualifier_01 = "1";
            pia.ITEMNUMBERIDENTIFICATION_02 = new C212();
            pia.ITEMNUMBERIDENTIFICATION_02.Itemnumber_01 = "ABC1234";
            pia.ITEMNUMBERIDENTIFICATION_02.Itemnumbertypecoded_02 = "IN";
            linLoop1.PIA.Add(pia);

            //  Repeating IMD
            linLoop1.IMD = new List<IMD>();

            //  The ordered item is a traded unit
            var imd = new IMD();
            imd.Itemdescriptiontypecoded_01 = "C";
            imd.ITEMDESCRIPTION_03 = new C273();
            imd.ITEMDESCRIPTION_03.Itemdescriptionidentification_01 = "TU";
            imd.ITEMDESCRIPTION_03.Codelistresponsibleagencycoded_03 = "9";
            linLoop1.IMD.Add(imd);

            //  Repeating QTY
            linLoop1.QTY = new List<QTY>();

            //  Ordered quantity is 48 units
            var qty = new QTY();
            qty.QUANTITYDETAILS_01 = new C186();
            qty.QUANTITYDETAILS_01.Quantityqualifier_01 = "21";
            qty.QUANTITYDETAILS_01.Quantity_02 = "48";
            linLoop1.QTY.Add(qty);

            //  Repeating MOA
            linLoop1.MOA = new List<MOA>();

            //  Value of order line is 699.84 Pounds Sterling
            var moa = new MOA();
            moa.MONETARYAMOUNT_01 = new C516();
            moa.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "203";
            moa.MONETARYAMOUNT_01.Monetaryamount_02 = "699.84";
            linLoop1.MOA.Add(moa);

            //  Repeating PRI Groups
            linLoop1.PRILoop = new List<Loop_PRI_ORDERS>();

            //  Begin PRI Group
            var priLoop = new Loop_PRI_ORDERS();

            //  Fixed net calculation price is 14.58 Pounds Sterling
            priLoop.PRI = new PRI();
            priLoop.PRI.PRICEINFORMATION_01 = new C509();
            priLoop.PRI.PRICEINFORMATION_01.Pricequalifier_01 = "AAA";
            priLoop.PRI.PRICEINFORMATION_01.Price_02 = "14.58";
            priLoop.PRI.PRICEINFORMATION_01.Pricetypecoded_03 = "CT";
            priLoop.PRI.PRICEINFORMATION_01.Pricetypequalifier_04 = "AAE";
            priLoop.PRI.PRICEINFORMATION_01.Unitpricebasis_05 = "1";
            priLoop.PRI.PRICEINFORMATION_01.Measureunitqualifier_06 = "KGM";

            //  End PRI Group
            linLoop1.PRILoop.Add(priLoop);

            //  Repeating RFF Groups
            linLoop1.RFFLoop = new List<Loop_RFF_ORDERS>();

            //  Begin RFF Group 
            var rffLoopLin = new Loop_RFF_ORDERS();

            //  Price is taken from the price list AUG93RNG04
            rffLoopLin.RFF = new RFF();
            rffLoopLin.RFF.REFERENCE_01 = new C506();
            rffLoopLin.RFF.REFERENCE_01.Referencequalifier_01 = "PL";
            rffLoopLin.RFF.REFERENCE_01.Referencenumber_02 = "AUG93RNG04";

            //  Repeating DTM
            rffLoopLin.DTM = new List<DTM>();

            //  Price list date 1st of August 2002           
            var dtmRff = new DTM();
            dtmRff.DATETIMEPERIOD_01 = new C507();
            dtmRff.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "171";
            dtmRff.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020801";
            dtmRff.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            rffLoopLin.DTM.Add(dtmRff);

            //  End RFF Group             
            linLoop1.RFFLoop.Add(rffLoopLin);

            //  Repeating PAC Groups
            linLoop1.PACLoop = new List<Loop_PAC_ORDERS_2>();

            //  Begin PAC Group
            var pacLoop = new Loop_PAC_ORDERS_2();

            //  Two packages (cases) barcoded with ITF14
            pacLoop.PAC = new PAC();
            pacLoop.PAC.Numberofpackages_01 = "2";
            pacLoop.PAC.PACKAGINGDETAILS_02 = new C531();
            pacLoop.PAC.PACKAGINGDETAILS_02.Packagingrelatedinformationcoded_02 = "51";
            pacLoop.PAC.PACKAGETYPE_03 = new C202();
            pacLoop.PAC.PACKAGETYPE_03.Typeofpackagesidentification_01 = "CS";

            //  Repeating PCI Groups
            pacLoop.PCILoop = new List<Loop_PCI_ORDERS>();

            //  Begin PCI Group
            var pciLoop = new Loop_PCI_ORDERS();

            //  The expiry date of the product is to be marked on it's packaging
            pciLoop.PCI = new PCI();
            pciLoop.PCI.Markinginstructionscoded_01 = "14";

            //  End PCI Group
            pacLoop.PCILoop.Add(pciLoop);

            //  End PAC Group
            linLoop1.PACLoop.Add(pacLoop);

            //  Repeating LOC Groups
            linLoop1.LOCLoop = new List<Loop_LOC_ORDERS_2>();

            //  Begin LOC Group 1
            var locLoop1 = new Loop_LOC_ORDERS_2();

            //  The second place to which the product is to be delivered is identified by GLN 3312345502000
            locLoop1.LOC = new LOC();
            locLoop1.LOC.Placelocationqualifier_01 = "7";
            locLoop1.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            locLoop1.LOC.LOCATIONIDENTIFICATION_02.Placelocationidentification_01 = "3312345502000";
            locLoop1.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycoded_03 = "9";

            //  The quantity to be delivered at this location is 24
            locLoop1.QTY = new QTY();
            locLoop1.QTY.QUANTITYDETAILS_01 = new C186();
            locLoop1.QTY.QUANTITYDETAILS_01.Quantityqualifier_01 = "11";
            locLoop1.QTY.QUANTITYDETAILS_01.Quantity_02 = "24";

            //  Repeating DTM
            locLoop1.DTM = new List<DTM>();

            //  The quantity should be delivered on the 15th of September 2002
            var dtmLoc = new DTM();
            dtmLoc.DATETIMEPERIOD_01 = new C507();
            dtmLoc.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "2";
            dtmLoc.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020915";
            dtmLoc.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            locLoop1.DTM.Add(dtmLoc);

            //  End LOC Group 1
            linLoop1.LOCLoop.Add(locLoop1);

            //  Begin LOC Group 2
            var locLoop2 = new Loop_LOC_ORDERS_2();

            //  The first place to which the product is to be delivered is identified by GLN 3312345501003
            locLoop2.LOC = new LOC();
            locLoop2.LOC.Placelocationqualifier_01 = "7";
            locLoop2.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            locLoop2.LOC.LOCATIONIDENTIFICATION_02.Placelocationidentification_01 = "3312345501003";
            locLoop2.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycoded_03 = "9";

            //  The quantity to be delivered at this location is 24
            locLoop2.QTY = new QTY();
            locLoop2.QTY.QUANTITYDETAILS_01 = new C186();
            locLoop2.QTY.QUANTITYDETAILS_01.Quantityqualifier_01 = "11";
            locLoop2.QTY.QUANTITYDETAILS_01.Quantity_02 = "24";

            //  Repeating DTM
            locLoop2.DTM = new List<DTM>();

            //  The quantity should be delivered on the 13th of September 2002
            var dtmLoc2 = new DTM();
            dtmLoc2.DATETIMEPERIOD_01 = new C507();
            dtmLoc2.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "2";
            dtmLoc2.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020913";
            dtmLoc2.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            locLoop2.DTM.Add(dtmLoc2);

            //  End LOC Group 2
            linLoop1.LOCLoop.Add(locLoop2);

            //  Repeating TAX Groups
            linLoop1.TAXLoop = new List<Loop_TAX_ORDERS>();

            //  Begin TAX Group
            var taxLoop = new Loop_TAX_ORDERS();

            //  The product is subject to the standard VAT rate of 17.5%
            taxLoop.TAX = new TAX();
            taxLoop.TAX.Dutytaxfeefunctionqualifier_01 = "7";
            taxLoop.TAX.DUTYTAXFEETYPE_02 = new C241();
            taxLoop.TAX.DUTYTAXFEETYPE_02.Dutytaxfeetypecoded_01 = "VAT";
            taxLoop.TAX.DUTYTAXFEEDETAIL_05 = new C243();
            taxLoop.TAX.DUTYTAXFEEDETAIL_05.Dutytaxfeerate_04 = "17.5";
            taxLoop.TAX.Dutytaxfeecategorycoded_06 = "S";

            //  End TAX Group
            linLoop1.TAXLoop.Add(taxLoop);

            //  End LIN Group 1
            result.LINLoop.Add(linLoop1);

            //  Message detail/summary separator
            result.UNS = new UNS();
            result.UNS.Sectionidentification_01 = "S";

            //  Repeating CNT
            result.CNT = new List<CNT>();

            //  Count of the number of LIN segments in the message
            var cnt = new CNT();
            cnt.CONTROL_01 = new C270();
            cnt.CONTROL_01.Controlqualifier_01 = "2";
            cnt.CONTROL_01.Controlvalue_02 = "1";
            result.CNT.Add(cnt);

            return result;
        }
    }
}
