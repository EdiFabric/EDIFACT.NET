using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Templates.EdifactD96A;
using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.DESADV
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Despatch Advice
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Eancom\DespatchAdvice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates.D96A.NoValidation"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSDESADV>();

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
        /// Write Despatch Advice
        /// </summary>
        static void Write()
        {
            var transaction = BuildDespatchAdvice("1");
           
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
        /// Build despatch advice.
        /// Original from https://www.gs1.org/sites/default/files/docs/eancom/s3/desadv.pdf
        /// </summary>
        static TSDESADV BuildDespatchAdvice(string controlNumber)
        {
            var result = new TSDESADV();

            //  Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "DESADV";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "96A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            //  Despatch advice number DES587441
            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "351";
            result.BGM.Documentmessagenumber_02 = "DES587441";
            result.BGM.Messagefunctioncoded_03 = "9";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  Message date 1st April 2002 
            var dtm1 = new DTM();
            dtm1.DATETIMEPERIOD_01 = new C507();
            dtm1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "137";
            dtm1.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020401";
            dtm1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm1);

            //  Despatch date 3rd April 2002
            var dtm2 = new DTM();
            dtm2.DATETIMEPERIOD_01 = new C507();
            dtm2.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "11";
            dtm2.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020403";
            dtm2.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm2);

            //  Due date to arrive on or after the 3rd of April
            var dtm3 = new DTM();
            dtm3.DATETIMEPERIOD_01 = new C507();
            dtm3.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "358";
            dtm3.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020403";
            dtm3.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm3);

            //  Repeating RFF Groups
            result.RFFLoop = new List<Loop_RFF_DESADV>();

            //  Begin RFF Group
            var rffLoop1 = new Loop_RFF_DESADV();

            //  Consignment is related to order number 12332
            rffLoop1.RFF = new RFF();
            rffLoop1.RFF.REFERENCE_01 = new C506();
            rffLoop1.RFF.REFERENCE_01.Referencequalifier_01 = "ON";
            rffLoop1.RFF.REFERENCE_01.Referencenumber_02 = "12332";

            //  Date of order 25th of March 2002 
            rffLoop1.DTM = new DTM();
            rffLoop1.DTM.DATETIMEPERIOD_01 = new C507();
            rffLoop1.DTM.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "171";
            rffLoop1.DTM.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020325";
            rffLoop1.DTM.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";

            //  End RFF Group
            result.RFFLoop.Add(rffLoop1);

            //  Repeating NAD Groups
            result.NADLoop = new List<Loop_NAD_DESADV>();

            //  Begin NAD Group 1
            var nadLoop1 = new Loop_NAD_DESADV();

            //  Supplier identified by GLN 5411234512309
            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.Partyqualifier_01 = "SU";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5411234512309";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating RFF Groups
            nadLoop1.RFFLoop = new List<Loop_RFF_DESADV>();

            //  Begin RFF Group 1
            var rffNadLoop1 = new Loop_RFF_DESADV();

            //  Supplier's VAT number 6558774 
            rffNadLoop1.RFF = new RFF();
            rffNadLoop1.RFF.REFERENCE_01 = new C506();
            rffNadLoop1.RFF.REFERENCE_01.Referencequalifier_01 = "VA";
            rffNadLoop1.RFF.REFERENCE_01.Referencenumber_02 = "6558774";

            //  End RFF Group 1
            nadLoop1.RFFLoop.Add(rffNadLoop1);

            //  End NAD Group 1
            result.NADLoop.Add(nadLoop1);

            //  Begin NAD Group 2
            var nadLoop2 = new Loop_NAD_DESADV();

            //  Buyer identified by GLN 5412345000013
            nadLoop2.NAD = new NAD();
            nadLoop2.NAD.Partyqualifier_01 = "BY";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5412345000013";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating RFF Groups
            nadLoop2.RFFLoop = new List<Loop_RFF_DESADV>();

            //  Begin RFF Group 1
            var rffNadLoop2 = new Loop_RFF_DESADV();

            //  Buyer's VAT number 7002474
            rffNadLoop2.RFF = new RFF();
            rffNadLoop2.RFF.REFERENCE_01 = new C506();
            rffNadLoop2.RFF.REFERENCE_01.Referencequalifier_01 = "VA";
            rffNadLoop2.RFF.REFERENCE_01.Referencenumber_02 = "7002474";

            //  End RFF Group 1
            nadLoop2.RFFLoop.Add(rffNadLoop2);

            //  End NAD Group 2
            result.NADLoop.Add(nadLoop2);

            //  Begin NAD Group 3
            var nadLoop3 = new Loop_NAD_DESADV();

            //  Delivery party identified by GLN 5412345123453
            nadLoop3.NAD = new NAD();
            nadLoop3.NAD.Partyqualifier_01 = "DP";
            nadLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5412345123453";
            nadLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating RFF Groups
            nadLoop3.RFFLoop = new List<Loop_RFF_DESADV>();

            //  Begin RFF Group 1
            var rffNadLoop3 = new Loop_RFF_DESADV();

            //  Delivery party's VAT number 800800
            rffNadLoop3.RFF = new RFF();
            rffNadLoop3.RFF.REFERENCE_01 = new C506();
            rffNadLoop3.RFF.REFERENCE_01.Referencequalifier_01 = "VA";
            rffNadLoop3.RFF.REFERENCE_01.Referencenumber_02 = "800800";

            //  End RFF Group 1
            nadLoop3.RFFLoop.Add(rffNadLoop3);

            //  End NAD Group 3
            result.NADLoop.Add(nadLoop3);

            //  Begin NAD Group 4
            var nadLoop4 = new Loop_NAD_DESADV();

            //  Shipper identified by GLN 5412345000105
            nadLoop4.NAD = new NAD();
            nadLoop4.NAD.Partyqualifier_01 = "SH";
            nadLoop4.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop4.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5412345000105";
            nadLoop4.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  End NAD Group 4
            result.NADLoop.Add(nadLoop4);

            //  Repeating CPS Groups
            result.CPSLoop = new List<Loop_CPS_DESADV>();

            //  Begin CPS Group 1
            var cpsLoop1 = new Loop_CPS_DESADV();

            //  First level description of consignment packing
            cpsLoop1.CPS = new CPS();
            cpsLoop1.CPS.Hierarchicalidnumber_01 = "1";

            //  Repeating PAC Groups
            cpsLoop1.PACLoop = new List<Loop_PAC_DESADV>();

            //  Begin PAC Group 1
            var pacLoop1 = new Loop_PAC_DESADV();

            //  Two ISO 1 pallets 
            pacLoop1.PAC = new PAC();
            pacLoop1.PAC.Numberofpackages_01 = "2";
            pacLoop1.PAC.PACKAGETYPE_03 = new C202();
            pacLoop1.PAC.PACKAGETYPE_03.Typeofpackagesidentification_01 = "201";
            pacLoop1.PAC.PACKAGETYPE_03.Codelistresponsibleagencycoded_03 = "9";

            //  End PAC Group 1
            cpsLoop1.PACLoop.Add(pacLoop1);

            //  End CPS Group 1
            result.CPSLoop.Add(cpsLoop1);

            //  Begin CPS Group 2
            var cpsLoop2 = new Loop_CPS_DESADV();

            //  Second level description of the first pallet
            cpsLoop2.CPS = new CPS();
            cpsLoop2.CPS.Hierarchicalidnumber_01 = "2";
            cpsLoop2.CPS.Hierarchicalparentid_02 = "1";

            //  Repeating PAC Groups
            cpsLoop2.PACLoop = new List<Loop_PAC_DESADV>();

            //  Begin PAC Group 1
            var pacLoop2 = new Loop_PAC_DESADV();

            //  One ISO 1 pallet 
            pacLoop2.PAC = new PAC();
            pacLoop2.PAC.Numberofpackages_01 = "1";
            pacLoop2.PAC.PACKAGETYPE_03 = new C202();
            pacLoop2.PAC.PACKAGETYPE_03.Typeofpackagesidentification_01 = "201";
            pacLoop2.PAC.PACKAGETYPE_03.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating MEA
            pacLoop2.MEA = new List<MEA>();

            //  Pallet weight 263.2 Kilos including goods packages
            var mea1 = new MEA();
            mea1.Measurementapplicationqualifier_01 = "PD";
            mea1.MEASUREMENTDETAILS_02 = new C502();
            mea1.MEASUREMENTDETAILS_02.Measurementdimensioncoded_01 = "AAB";
            mea1.VALUERANGE_03 = new C174();
            mea1.VALUERANGE_03.Measureunitqualifier_01 = "KGM";
            mea1.VALUERANGE_03.Measurementvalue_02 = "263.2";
            pacLoop2.MEA.Add(mea1);

            //  Pallet width 800 millimeters
            var mea2 = new MEA();
            mea2.Measurementapplicationqualifier_01 = "PD";
            mea2.MEASUREMENTDETAILS_02 = new C502();
            mea2.MEASUREMENTDETAILS_02.Measurementdimensioncoded_01 = "WD";
            mea2.VALUERANGE_03 = new C174();
            mea2.VALUERANGE_03.Measureunitqualifier_01 = "MMT";
            mea2.VALUERANGE_03.Measurementvalue_02 = "800";
            pacLoop2.MEA.Add(mea2);

            //  Pallet length 1200 millimeters
            var mea3 = new MEA();
            mea3.Measurementapplicationqualifier_01 = "PD";
            mea3.MEASUREMENTDETAILS_02 = new C502();
            mea3.MEASUREMENTDETAILS_02.Measurementdimensioncoded_01 = "LN";
            mea3.VALUERANGE_03 = new C174();
            mea3.VALUERANGE_03.Measureunitqualifier_01 = "MMT";
            mea3.VALUERANGE_03.Measurementvalue_02 = "1200";
            pacLoop2.MEA.Add(mea3);

            //  Repeating PCI Groups
            pacLoop2.PCILoop = new List<Loop_PCI_DESADV>();

            //  Begin PCI Group
            var pciLoop1 = new Loop_PCI_DESADV();

            //  Pallet marked with SSCC
            pciLoop1.PCI = new PCI();
            pciLoop1.PCI.Markinginstructionscoded_01 = "33E";

            //  Repeating GIN Groups
            pciLoop1.GINLoop = new List<Loop_GIN_DESADV>();

            //  Begin GIN Group
            var ginLoop1 = new Loop_GIN_DESADV();

            //  Serial Shipping Container Code 354107380000001051
            ginLoop1.GIN = new GIN();
            ginLoop1.GIN.Identitynumberqualifier_01 = "BJ";
            ginLoop1.GIN.IDENTITYNUMBERRANGE_02 = new C208();
            ginLoop1.GIN.IDENTITYNUMBERRANGE_02.Identitynumber_01 = "354107380000001051";

            //  End GIN Group 
            pciLoop1.GINLoop.Add(ginLoop1);

            //  End PCI Group 
            pacLoop2.PCILoop.Add(pciLoop1);

            //  End PAC Group 1
            cpsLoop2.PACLoop.Add(pacLoop2);

            //  Begin PAC Group 2
            var pacLoop3 = new Loop_PAC_DESADV();

            //  Twenty cartons
            pacLoop3.PAC = new PAC();
            pacLoop3.PAC.Numberofpackages_01 = "20";
            pacLoop3.PAC.PACKAGETYPE_03 = new C202();
            pacLoop3.PAC.PACKAGETYPE_03.Typeofpackagesidentification_01 = "CT";

            //  End PAC Group 2
            cpsLoop2.PACLoop.Add(pacLoop3);

            //  Repeating LIN Groups
            cpsLoop2.LINLoop = new List<Loop_LIN_DESADV>();

            //  Begin LIN Group
            var linLoop1 = new Loop_LIN_DESADV();

            //  Product contained in this package is identified by GTIN 5410738000152
            linLoop1.LIN = new LIN();
            linLoop1.LIN.Lineitemnumber_01 = "1";
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "5410738000152";
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";

            linLoop1.QTY = new List<QTY>();

            //  Despatch quantity 20
            var qty1 = new QTY();
            qty1.QUANTITYDETAILS_01 = new C186();
            qty1.QUANTITYDETAILS_01.Quantityqualifier_01 = "12";
            qty1.QUANTITYDETAILS_01.Quantity_02 = "20";
            linLoop1.QTY.Add(qty1);

            //  End LIN Group
            cpsLoop2.LINLoop.Add(linLoop1);

            //  End CPS Group 2
            result.CPSLoop.Add(cpsLoop2);

            //  Begin CPS Group 3
            var cpsLoop3 = new Loop_CPS_DESADV();

            //  Second level description of the second pallet 
            cpsLoop3.CPS = new CPS();
            cpsLoop3.CPS.Hierarchicalidnumber_01 = "3";
            cpsLoop3.CPS.Hierarchicalparentid_02 = "1";

            //  Repeating PAC Groups
            cpsLoop3.PACLoop = new List<Loop_PAC_DESADV>();

            //  Begin PAC Group 1
            var pacLoop4 = new Loop_PAC_DESADV();

            //  One ISO 1 pallet 
            pacLoop4.PAC = new PAC();
            pacLoop4.PAC.Numberofpackages_01 = "1";
            pacLoop4.PAC.PACKAGETYPE_03 = new C202();
            pacLoop4.PAC.PACKAGETYPE_03.Typeofpackagesidentification_01 = "201";
            pacLoop4.PAC.PACKAGETYPE_03.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating MEA
            pacLoop4.MEA = new List<MEA>();

            //  Pallet weight 305.1 Kilos 
            var mea4 = new MEA();
            mea4.Measurementapplicationqualifier_01 = "PD";
            mea4.MEASUREMENTDETAILS_02 = new C502();
            mea4.MEASUREMENTDETAILS_02.Measurementdimensioncoded_01 = "AAB";
            mea4.VALUERANGE_03 = new C174();
            mea4.VALUERANGE_03.Measureunitqualifier_01 = "KGM";
            mea4.VALUERANGE_03.Measurementvalue_02 = "305.1";
            pacLoop4.MEA.Add(mea4);           

            //  Repeating PCI Groups
            pacLoop4.PCILoop = new List<Loop_PCI_DESADV>();

            //  Begin PCI Group
            var pciLoop2 = new Loop_PCI_DESADV();

            //  Pallet marked with SSCC
            pciLoop2.PCI = new PCI();
            pciLoop2.PCI.Markinginstructionscoded_01 = "33E";

            //  Repeating GIN Groups
            pciLoop2.GINLoop = new List<Loop_GIN_DESADV>();

            //  Begin GIN Group
            var ginLoop2 = new Loop_GIN_DESADV();

            //  Serial Shipping Container Code 354107380000001068
            ginLoop2.GIN = new GIN();
            ginLoop2.GIN.Identitynumberqualifier_01 = "BJ";
            ginLoop2.GIN.IDENTITYNUMBERRANGE_02 = new C208();
            ginLoop2.GIN.IDENTITYNUMBERRANGE_02.Identitynumber_01 = "354107380000001068";

            //  End GIN Group 
            pciLoop2.GINLoop.Add(ginLoop2);

            //  End PCI Group 
            pacLoop4.PCILoop.Add(pciLoop2);

            //  End PAC Group 1
            cpsLoop3.PACLoop.Add(pacLoop4);

            //  Begin PAC Group 2
            var pacLoop5 = new Loop_PAC_DESADV();

            //  Twenty cartons
            pacLoop5.PAC = new PAC();
            pacLoop5.PAC.Numberofpackages_01 = "20";
            pacLoop5.PAC.PACKAGETYPE_03 = new C202();
            pacLoop5.PAC.PACKAGETYPE_03.Typeofpackagesidentification_01 = "CT";

            //  End PAC Group 2
            cpsLoop3.PACLoop.Add(pacLoop5);

            //  Repeating LIN Groups
            cpsLoop3.LINLoop = new List<Loop_LIN_DESADV>();

            //  Begin LIN Group 1
            var linLoop2 = new Loop_LIN_DESADV();

            //  First product contained in this package is identified by GTIN 5410738000169
            linLoop2.LIN = new LIN();
            linLoop2.LIN.Lineitemnumber_01 = "2";
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "5410738000169";
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";

            linLoop2.QTY = new List<QTY>();

            // Despatch quantity 5
            var qty2 = new QTY();
            qty2.QUANTITYDETAILS_01 = new C186();
            qty2.QUANTITYDETAILS_01.Quantityqualifier_01 = "12";
            qty2.QUANTITYDETAILS_01.Quantity_02 = "5";
            linLoop2.QTY.Add(qty2);

            //  End LIN Group 1
            cpsLoop3.LINLoop.Add(linLoop2);

            //  Begin LIN Group 2
            var linLoop3 = new Loop_LIN_DESADV();

            //  Second product contained in this package is identified by GTIN 5410738000176
            linLoop3.LIN = new LIN();
            linLoop3.LIN.Lineitemnumber_01 = "3";
            linLoop3.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop3.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "5410738000176";
            linLoop3.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";

            linLoop3.QTY = new List<QTY>();

            // Despatch quantity 3
            var qty3 = new QTY();
            qty3.QUANTITYDETAILS_01 = new C186();
            qty3.QUANTITYDETAILS_01.Quantityqualifier_01 = "12";
            qty3.QUANTITYDETAILS_01.Quantity_02 = "3";
            linLoop3.QTY.Add(qty3);

            //  End LIN Group 2
            cpsLoop3.LINLoop.Add(linLoop3);

            //  Begin LIN Group 3
            var linLoop4 = new Loop_LIN_DESADV();

            //  Third product contained in this package is identified by GTIN 5410738000183
            linLoop4.LIN = new LIN();
            linLoop4.LIN.Lineitemnumber_01 = "4";
            linLoop4.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop4.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "5410738000183";
            linLoop4.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";

            linLoop4.QTY = new List<QTY>();

            // Despatch quantity 12
            var qty4 = new QTY();
            qty4.QUANTITYDETAILS_01 = new C186();
            qty4.QUANTITYDETAILS_01.Quantityqualifier_01 = "12";
            qty4.QUANTITYDETAILS_01.Quantity_02 = "12";
            linLoop4.QTY.Add(qty4);

            //  End LIN Group 3
            cpsLoop3.LINLoop.Add(linLoop4);

            //  End CPS Group 3
            result.CPSLoop.Add(cpsLoop3);

            //  Repeating CNT
            result.CNT = new List<CNT>();

            //  Total number of LIN segments in the message = 4
            var cnt = new CNT();
            cnt.CONTROL_01 = new C270();
            cnt.CONTROL_01.Controlqualifier_01 = "2";
            cnt.CONTROL_01.Controlvalue_02 = "4";
            result.CNT.Add(cnt);

            return result;
        }
    }
}
