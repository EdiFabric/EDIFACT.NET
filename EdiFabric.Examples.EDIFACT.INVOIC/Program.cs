using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.EdifactD96A;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Core.Model.Edi.Edifact;

namespace EdiFabric.Examples.EDIFACT.INVOIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
            Write();
        }

        /// <summary>
        /// Read Invoices
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\Invoice.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates.D96A.NoValidation"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSINVOIC>();

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
        /// Write Invoices
        /// </summary>
        static void Write()
        {
            var transaction = BuildInvoice("1");

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
        /// Build invoice.
        /// Original from https://www.gs1.org/standards/edi-xml-gs1-eancom/eancom-invoic-s4/syntax-4
        /// </summary>
        public static TSINVOIC BuildInvoice(string controlNumber)
        {
            var result = new TSINVOIC();

            //  Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "INVOIC";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "96A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            //  Commercial invoice number IN432097
            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "380";
            result.BGM.Documentmessagenumber_02 = "IN432097";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  Message date 8th March 2002
            var dtm = new DTM();
            dtm.DATETIMEPERIOD_01 = new C507();
            dtm.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "137";
            dtm.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020308";
            dtm.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm);

            //  Instructions to pay in bank account
            result.PAI = new PAI();
            result.PAI.PAYMENTINSTRUCTIONDETAILS_01 = new C534();
            result.PAI.PAYMENTINSTRUCTIONDETAILS_01.Paymentmeanscoded_03 = "42";

            //  Repeating RFF Groups
            result.RFFLoop = new List<Loop_RFF_INVOIC>();

            //  Begin RFF Group 1
            var rffLoop1 = new Loop_RFF_INVOIC();

            //  Purchase order invoiced number ORD9523
            rffLoop1.RFF = new RFF();
            rffLoop1.RFF.REFERENCE_01 = new C506();
            rffLoop1.RFF.REFERENCE_01.Referencequalifier_01 = "ON";
            rffLoop1.RFF.REFERENCE_01.Referencenumber_02 = "ORD9523";

            //  Repeating DTM
            rffLoop1.DTM = new List<DTM>();

            //  Reference date 12th February 2002
            var dtmRff1 = new DTM();
            dtmRff1.DATETIMEPERIOD_01 = new C507();
            dtmRff1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "171";
            dtmRff1.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020212";
            dtmRff1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            rffLoop1.DTM.Add(dtmRff1);

            //  End RFF Group 1
            result.RFFLoop.Add(rffLoop1);

            //  Begin RFF Group 2
            var rffLoop2 = new Loop_RFF_INVOIC();

            //  Price list reference number PL99523
            rffLoop2.RFF = new RFF();
            rffLoop2.RFF.REFERENCE_01 = new C506();
            rffLoop2.RFF.REFERENCE_01.Referencequalifier_01 = "PL";
            rffLoop2.RFF.REFERENCE_01.Referencenumber_02 = "PL99523";

            //  Repeating DTM
            rffLoop2.DTM = new List<DTM>();

            //  Reference date 1st January 2002 
            var dtmRff2 = new DTM();
            dtmRff2.DATETIMEPERIOD_01 = new C507();
            dtmRff2.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "171";
            dtmRff2.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020101";
            dtmRff2.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            rffLoop2.DTM.Add(dtmRff2);

            //  End RFF Group 2
            result.RFFLoop.Add(rffLoop2);

            //  Begin RFF Group 3
            var rffLoop3 = new Loop_RFF_INVOIC();

            //  Reference delivery note number 53662
            rffLoop3.RFF = new RFF();
            rffLoop3.RFF.REFERENCE_01 = new C506();
            rffLoop3.RFF.REFERENCE_01.Referencequalifier_01 = "DQ";
            rffLoop3.RFF.REFERENCE_01.Referencenumber_02 = "53662";

            //  Repeating DTM
            rffLoop3.DTM = new List<DTM>();

            //  Reference date 15th February 2002
            var dtmRff3 = new DTM();
            dtmRff3.DATETIMEPERIOD_01 = new C507();
            dtmRff3.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "171";
            dtmRff3.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020215";
            dtmRff3.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            rffLoop3.DTM.Add(dtmRff3);

            //  End RFF Group 3
            result.RFFLoop.Add(rffLoop3);

            //  Repeating NAD Groups
            result.NADLoop = new List<Loop_NAD_INVOIC>();

            //  Begin NAD Group 1
            var nadLoop1 = new Loop_NAD_INVOIC();

            //  Buyer identified by GLN 5412345000013
            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.Partyqualifier_01 = "BY";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5412345000013";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating RFF Groups
            nadLoop1.RFFLoop = new List<Loop_RFF_INVOIC>();

            //  Begin RFF Group 1
            var rffNadLoop1 = new Loop_RFF_INVOIC();

            //  VAT reference number of the buyer 4146023 
            rffNadLoop1.RFF = new RFF();
            rffNadLoop1.RFF.REFERENCE_01 = new C506();
            rffNadLoop1.RFF.REFERENCE_01.Referencequalifier_01 = "VA";
            rffNadLoop1.RFF.REFERENCE_01.Referencenumber_02 = "4146023";

            //  End RFF Group 1
            nadLoop1.RFFLoop.Add(rffNadLoop1);

            //  End NAD Group 1
            result.NADLoop.Add(nadLoop1);

            //  Begin NAD Group 2
            var nadLoop2 = new Loop_NAD_INVOIC();

            //  Supplier identified by GLN 4012345500004
            nadLoop2.NAD = new NAD();
            nadLoop2.NAD.Partyqualifier_01 = "SU";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "4012345500004";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating RFF Groups
            nadLoop2.RFFLoop = new List<Loop_RFF_INVOIC>();

            //  Begin RFF Group 1
            var rffNadLoop2 = new Loop_RFF_INVOIC();

            //  VAT reference number of the supplier VR12345
            rffNadLoop2.RFF = new RFF();
            rffNadLoop2.RFF.REFERENCE_01 = new C506();
            rffNadLoop2.RFF.REFERENCE_01.Referencequalifier_01 = "VA";
            rffNadLoop2.RFF.REFERENCE_01.Referencenumber_02 = "VR12345";

            //  End RFF Group 1
            nadLoop2.RFFLoop.Add(rffNadLoop2);

            //  End NAD Group 2
            result.NADLoop.Add(nadLoop2);

            //  Begin NAD Group 3
            var nadLoop3 = new Loop_NAD_INVOIC();

            //  Delivery party identified by GLN 5412345678908
            nadLoop3.NAD = new NAD();
            nadLoop3.NAD.Partyqualifier_01 = "DP";
            nadLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5412345678908";
            nadLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  End NAD Group 3
            result.NADLoop.Add(nadLoop3);

            //  Repeating CUX Groups
            result.CUXLoop = new List<Loop_CUX_INVOIC>();

            //  Begin CUX Group
            var cuxLoop = new Loop_CUX_INVOIC();

            //  Reference currency is Euros 
            cuxLoop.CUX = new CUX();
            cuxLoop.CUX.CURRENCYDETAILS_01 = new C504();
            cuxLoop.CUX.CURRENCYDETAILS_01.Currencydetailsqualifier_01 = "2";
            cuxLoop.CUX.CURRENCYDETAILS_01.Currencycoded_02 = "EUR";
            cuxLoop.CUX.CURRENCYDETAILS_01.Currencyqualifier_03 = "4";

            //  End CUX Group
            result.CUXLoop.Add(cuxLoop);

            //  Repeating PAT Groups
            result.PATLoop = new List<Loop_PAT_INVOIC>();

            //  Begin PAT Group 1
            var patLoop1 = new Loop_PAT_INVOIC();

            //  Payment terms 2 months after date of invoice
            patLoop1.PAT = new PAT();
            patLoop1.PAT.Paymenttermstypequalifier_01 = "1";
            patLoop1.PAT.TERMSTIMEINFORMATION_03 = new C112();
            patLoop1.PAT.TERMSTIMEINFORMATION_03.Paymenttimereferencecoded_01 = "5";
            patLoop1.PAT.TERMSTIMEINFORMATION_03.Timerelationcoded_02 = "3";
            patLoop1.PAT.TERMSTIMEINFORMATION_03.Typeofperiodcoded_03 = "M";
            patLoop1.PAT.TERMSTIMEINFORMATION_03.Numberofperiods_04 = "2";

            //  End PAT Group 1
            result.PATLoop.Add(patLoop1);

            //  Begin PAT Group 2
            var patLoop2 = new Loop_PAT_INVOIC();

            //  Payment discount for payment 10 days after date of invoice
            patLoop2.PAT = new PAT();
            patLoop2.PAT.Paymenttermstypequalifier_01 = "22";
            patLoop2.PAT.TERMSTIMEINFORMATION_03 = new C112();
            patLoop2.PAT.TERMSTIMEINFORMATION_03.Paymenttimereferencecoded_01 = "5";
            patLoop2.PAT.TERMSTIMEINFORMATION_03.Timerelationcoded_02 = "3";
            patLoop2.PAT.TERMSTIMEINFORMATION_03.Typeofperiodcoded_03 = "D";
            patLoop2.PAT.TERMSTIMEINFORMATION_03.Numberofperiods_04 = "10";

            //  Percentage information for the allowances or charges 2.5 %
            patLoop2.PCD = new PCD();
            patLoop2.PCD.PERCENTAGEDETAILS_01 = new C501();
            patLoop2.PCD.PERCENTAGEDETAILS_01.Percentagequalifier_01 = "12";
            patLoop2.PCD.PERCENTAGEDETAILS_01.Percentage_02 = "2.5";
            patLoop2.PCD.PERCENTAGEDETAILS_01.Percentagebasiscoded_03 = "13";

            //  End PAT Group 2
            result.PATLoop.Add(patLoop2);

            //  Repeating ALC Groups
            result.ALCLoop = new List<Loop_ALC_INVOIC>();

            //  Begin ALC Group
            var alcLoop = new Loop_ALC_INVOIC();

            //  Charges to be paid by customer
            alcLoop.ALC = new ALC();
            alcLoop.ALC.Allowanceorchargequalifier_01 = "C";
            alcLoop.ALC.Settlementcoded_03 = "6";
            alcLoop.ALC.SPECIALSERVICESIDENTIFICATION_05 = new C214();
            alcLoop.ALC.SPECIALSERVICESIDENTIFICATION_05.Specialservicescoded_01 = "FC";

            //  Repeating MOA Groups
            alcLoop.MOALoop = new List<Loop_MOA_INVOIC>();

            //  Begin MOA Group
            var moaAlcLoop = new Loop_MOA_INVOIC();

            //  Monetary amount for the charge 120 EUR to be added
            moaAlcLoop.MOA = new MOA();
            moaAlcLoop.MOA.MONETARYAMOUNT_01 = new C516();
            moaAlcLoop.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "23";
            moaAlcLoop.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "120";

            //  End MOA Group
            alcLoop.MOALoop.Add(moaAlcLoop);

            //  Repeating TAX Groups
            alcLoop.TAXLoop = new List<Loop_TAX_INVOIC_2>();

            //  Begin TAX Group
            var taxAlcLoop = new Loop_TAX_INVOIC_2();

            //  Type of tax is value added tax at 19 %
            taxAlcLoop.TAX = new TAX();
            taxAlcLoop.TAX.Dutytaxfeefunctionqualifier_01 = "7";
            taxAlcLoop.TAX.DUTYTAXFEETYPE_02 = new C241();
            taxAlcLoop.TAX.DUTYTAXFEETYPE_02.Dutytaxfeetypecoded_01 = "VAT";
            taxAlcLoop.TAX.DUTYTAXFEEDETAIL_05 = new C243();
            taxAlcLoop.TAX.DUTYTAXFEEDETAIL_05.Dutytaxfeerate_04 = "19";
            taxAlcLoop.TAX.Dutytaxfeecategorycoded_06 = "S";

            //  Tax monetary amount 22.80 EUR
            taxAlcLoop.MOA = new MOA();
            taxAlcLoop.MOA.MONETARYAMOUNT_01 = new C516();
            taxAlcLoop.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "124";
            taxAlcLoop.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "22.80";

            //  End TAX Group
            alcLoop.TAXLoop.Add(taxAlcLoop);

            //  End ALC Group
            result.ALCLoop.Add(alcLoop);

            //  Repeating LIN Groups
            result.LINLoop = new List<Loop_LIN_INVOIC>();

            //  Begin LIN Group 1
            var linLoop1 = new Loop_LIN_INVOIC();

            //  Line item 1 identified by GTIN 4000862141404
            linLoop1.LIN = new LIN();
            linLoop1.LIN.Lineitemnumber_01 = "1";
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "4000862141404";
            linLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRS";

            //  Repeating QTY
            linLoop1.QTY = new List<QTY>();

            //  Invoiced quantity 40
            var qtyLin1 = new QTY();
            qtyLin1.QUANTITYDETAILS_01 = new C186();
            qtyLin1.QUANTITYDETAILS_01.Quantityqualifier_01 = "47";
            qtyLin1.QUANTITYDETAILS_01.Quantity_02 = "40";
            linLoop1.QTY.Add(qtyLin1);

            //  Repeating MOA Groups
            linLoop1.MOALoop = new List<Loop_MOA_INVOIC_2>();

            //  Begin MOA Group
            var moaLinLoop1 = new Loop_MOA_INVOIC_2();

            //  Line item amount 2.160 EUR
            moaLinLoop1.MOA = new MOA();
            moaLinLoop1.MOA.MONETARYAMOUNT_01 = new C516();
            moaLinLoop1.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "203";
            moaLinLoop1.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "2160";

            //  End MOA Group
            linLoop1.MOALoop.Add(moaLinLoop1);

            //  Repeating PRI Groups
            linLoop1.PRILoop = new List<Loop_PRI_INVOIC>();

            //  Begin PRI Group
            var priLinLoop1 = new Loop_PRI_INVOIC();

            //  Gross calculation price of 60 which does not include any allowance or charges, from the catalogue.
            priLinLoop1.PRI = new PRI();
            priLinLoop1.PRI.PRICEINFORMATION_01 = new C509();
            priLinLoop1.PRI.PRICEINFORMATION_01.Pricequalifier_01 = "AAB";
            priLinLoop1.PRI.PRICEINFORMATION_01.Price_02 = "60";
            priLinLoop1.PRI.PRICEINFORMATION_01.Pricetypecoded_03 = "CA";

            //  End PRI Group
            linLoop1.PRILoop.Add(priLinLoop1);

            //  Repeating TAX Groups
            linLoop1.TAXLoop = new List<Loop_TAX_INVOIC>();

            //  Begin TAX Group
            var taxLinLoop1 = new Loop_TAX_INVOIC();

            //  Type of tax for the line item is value added tax 21%
            taxLinLoop1.TAX = new TAX();
            taxLinLoop1.TAX.Dutytaxfeefunctionqualifier_01 = "7";
            taxLinLoop1.TAX.DUTYTAXFEETYPE_02 = new C241();
            taxLinLoop1.TAX.DUTYTAXFEETYPE_02.Dutytaxfeetypecoded_01 = "VAT";
            taxLinLoop1.TAX.DUTYTAXFEEDETAIL_05 = new C243();
            taxLinLoop1.TAX.DUTYTAXFEEDETAIL_05.Dutytaxfeerate_04 = "21";
            taxLinLoop1.TAX.Dutytaxfeecategorycoded_06 = "S";

            //  Tax monetary amount 453.60 EUR 
            taxLinLoop1.MOA = new MOA();
            taxLinLoop1.MOA.MONETARYAMOUNT_01 = new C516();
            taxLinLoop1.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "124";
            taxLinLoop1.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "453.60";

            //  End TAX Group
            linLoop1.TAXLoop.Add(taxLinLoop1);

            //  Repeating ALC Groups
            linLoop1.ALCLoop = new List<Loop_ALC_INVOIC_2>();

            //  Begin ALC Group
            var alcLinLoop1 = new Loop_ALC_INVOIC_2();

            //  Allowances
            alcLinLoop1.ALC = new ALC();
            alcLinLoop1.ALC.Allowanceorchargequalifier_01 = "A";

            //  PCD Group
            alcLinLoop1.PCDLoop = new Loop_PCD_INVOIC();

            //  Percentage information for the allowances 10 %
            alcLinLoop1.PCDLoop.PCD = new PCD();
            alcLinLoop1.PCDLoop.PCD.PERCENTAGEDETAILS_01 = new C501();
            alcLinLoop1.PCDLoop.PCD.PERCENTAGEDETAILS_01.Percentagequalifier_01 = "1";
            alcLinLoop1.PCDLoop.PCD.PERCENTAGEDETAILS_01.Percentage_02 = "10";

            //  End ALC Group
            linLoop1.ALCLoop.Add(alcLinLoop1);

            //  End LIN Group 1
            result.LINLoop.Add(linLoop1);

            //  Begin LIN Group 2
            var linLoop2 = new Loop_LIN_INVOIC();

            //  Line item 2 identified by GTIN 5412345111115
            linLoop2.LIN = new LIN();
            linLoop2.LIN.Lineitemnumber_01 = "2";
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "5412345111115";
            linLoop2.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRS";

            //  Repeating QTY
            linLoop2.QTY = new List<QTY>();

            //  Delivered quantity 5
            var qtyLin2 = new QTY();
            qtyLin2.QUANTITYDETAILS_01 = new C186();
            qtyLin2.QUANTITYDETAILS_01.Quantityqualifier_01 = "46";
            qtyLin2.QUANTITYDETAILS_01.Quantity_02 = "5";
            linLoop2.QTY.Add(qtyLin2);

            //  Invoiced quantity 12.65 Kg.
            var qtyLin3 = new QTY();
            qtyLin3.QUANTITYDETAILS_01 = new C186();
            qtyLin3.QUANTITYDETAILS_01.Quantityqualifier_01 = "47";
            qtyLin3.QUANTITYDETAILS_01.Quantity_02 = "12.65";
            qtyLin3.QUANTITYDETAILS_01.Measureunitqualifier_03 = "KGM";
            linLoop2.QTY.Add(qtyLin3);

            //  Repeating MOA Groups
            linLoop2.MOALoop = new List<Loop_MOA_INVOIC_2>();

            //  Begin MOA Group
            var moaLinLoop2 = new Loop_MOA_INVOIC_2();

            //  Line item amount 2.530 EUR
            moaLinLoop2.MOA = new MOA();
            moaLinLoop2.MOA.MONETARYAMOUNT_01 = new C516();
            moaLinLoop2.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "203";
            moaLinLoop2.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "2530";

            //  End MOA Group
            linLoop2.MOALoop.Add(moaLinLoop2);

            //  Repeating PRI Groups
            linLoop2.PRILoop = new List<Loop_PRI_INVOIC>();

            //  Begin PRI Group
            var priLinLoop2 = new Loop_PRI_INVOIC();

            //  Net price of 200 per Kg from the catalogue, this price includes allowances and charges
            priLinLoop2.PRI = new PRI();
            priLinLoop2.PRI.PRICEINFORMATION_01 = new C509();
            priLinLoop2.PRI.PRICEINFORMATION_01.Pricequalifier_01 = "AAA";
            priLinLoop2.PRI.PRICEINFORMATION_01.Price_02 = "200";
            priLinLoop2.PRI.PRICEINFORMATION_01.Pricetypecoded_03 = "CA";
            priLinLoop2.PRI.PRICEINFORMATION_01.Unitpricebasis_05 = "1";
            priLinLoop2.PRI.PRICEINFORMATION_01.Measureunitqualifier_06 = "KGM";

            //  End PRI Group
            linLoop2.PRILoop.Add(priLinLoop2);

            //  Repeating TAX Groups
            linLoop2.TAXLoop = new List<Loop_TAX_INVOIC>();

            //  Begin TAX Group
            var taxLinLoop2 = new Loop_TAX_INVOIC();

            //  Type of tax for the line item is value added tax 19 %
            taxLinLoop2.TAX = new TAX();
            taxLinLoop2.TAX.Dutytaxfeefunctionqualifier_01 = "7";
            taxLinLoop2.TAX.DUTYTAXFEETYPE_02 = new C241();
            taxLinLoop2.TAX.DUTYTAXFEETYPE_02.Dutytaxfeetypecoded_01 = "VAT";
            taxLinLoop2.TAX.DUTYTAXFEEDETAIL_05 = new C243();
            taxLinLoop2.TAX.DUTYTAXFEEDETAIL_05.Dutytaxfeerate_04 = "19";
            taxLinLoop2.TAX.Dutytaxfeecategorycoded_06 = "S";

            //  Tax monetary amount 480.70 EUR
            taxLinLoop2.MOA = new MOA();
            taxLinLoop2.MOA.MONETARYAMOUNT_01 = new C516();
            taxLinLoop2.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "124";
            taxLinLoop2.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "480.70";

            //  End TAX Group
            linLoop2.TAXLoop.Add(taxLinLoop2);

            //  End LIN Group 2
            result.LINLoop.Add(linLoop2);

            //  To separate the detail section from the summary section
            result.UNS = new UNS();
            result.UNS.Sectionidentification_01 = "S";

            //  Repeating CNT
            result.CNT = new List<CNT>();

            //  Total number of line items 2
            var cnt = new CNT();
            cnt.CONTROL_01 = new C270();
            cnt.CONTROL_01.Controlqualifier_01 = "2";
            cnt.CONTROL_01.Controlvalue_02 = "2";
            result.CNT.Add(cnt);

            //  Repeating MOA Groups
            result.MOALoop = new List<Loop_MOA_INVOIC_3>();

            //  Begin MOA Group 1
            var moaLoop1 = new Loop_MOA_INVOIC_3();

            //  Message total monetary amount 5.767,10 EUR
            moaLoop1.MOA = new MOA();
            moaLoop1.MOA.MONETARYAMOUNT_01 = new C516();
            moaLoop1.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "86";
            moaLoop1.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "5767.10";

            //  End MOA Group 1
            result.MOALoop.Add(moaLoop1);

            //  Begin MOA Group 2
            var moaLoop2 = new Loop_MOA_INVOIC_3();

            //  Message total line items amount 4.690 EUR
            moaLoop2.MOA = new MOA();
            moaLoop2.MOA.MONETARYAMOUNT_01 = new C516();
            moaLoop2.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "79";
            moaLoop2.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "4690";

            //  End MOA Group 2
            result.MOALoop.Add(moaLoop2);

            //  Begin MOA Group 3
            var moaLoop3 = new Loop_MOA_INVOIC_3();

            //  Total amount subject to payment discount 5.767.10 EUR
            moaLoop3.MOA = new MOA();
            moaLoop3.MOA.MONETARYAMOUNT_01 = new C516();
            moaLoop3.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "129";
            moaLoop3.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "5767.10";

            //  End MOA Group 3
            result.MOALoop.Add(moaLoop3);

            //  Begin MOA Group 4
            var moaLoop4 = new Loop_MOA_INVOIC_3();

            //  Message total taxable amount 4.810 EUR
            moaLoop4.MOA = new MOA();
            moaLoop4.MOA.MONETARYAMOUNT_01 = new C516();
            moaLoop4.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "125";
            moaLoop4.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "4810";

            //  End MOA Group 4
            result.MOALoop.Add(moaLoop4);

            //  Begin MOA Group 5
            var moaLoop5 = new Loop_MOA_INVOIC_3();

            //  Message total tax amount 957,10 EUR
            moaLoop5.MOA = new MOA();
            moaLoop5.MOA.MONETARYAMOUNT_01 = new C516();
            moaLoop5.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "176";
            moaLoop5.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "957.10";

            //  End MOA Group 5
            result.MOALoop.Add(moaLoop5);

            //  Begin MOA Group 6
            var moaLoop6 = new Loop_MOA_INVOIC_3();

            //  Total charges/allowances 120 EUR
            moaLoop6.MOA = new MOA();
            moaLoop6.MOA.MONETARYAMOUNT_01 = new C516();
            moaLoop6.MOA.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "131";
            moaLoop6.MOA.MONETARYAMOUNT_01.Monetaryamount_02 = "120";

            //  End MOA Group 6
            result.MOALoop.Add(moaLoop6);

            //  Repeating TAX Groups
            result.TAXLoop2 = new List<Loop_TAX_INVOIC_3>();

            //  Begin TAX Group 1
            var taxLoop1 = new Loop_TAX_INVOIC_3();

            //  Type of tax for the total message is value added tax 19 %
            taxLoop1.TAX = new TAX();
            taxLoop1.TAX.Dutytaxfeefunctionqualifier_01 = "7";
            taxLoop1.TAX.DUTYTAXFEETYPE_02 = new C241();
            taxLoop1.TAX.DUTYTAXFEETYPE_02.Dutytaxfeetypecoded_01 = "VAT";
            taxLoop1.TAX.DUTYTAXFEEDETAIL_05 = new C243();
            taxLoop1.TAX.DUTYTAXFEEDETAIL_05.Dutytaxfeerate_04 = "19";
            taxLoop1.TAX.Dutytaxfeecategorycoded_06 = "S";

            //  Repeating MOA
            taxLoop1.MOA = new List<MOA>();

            //  Tax monetary amount 503.50 EUR
            var moaTax1 = new MOA();
            moaTax1.MONETARYAMOUNT_01 = new C516();
            moaTax1.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "124";
            moaTax1.MONETARYAMOUNT_01.Monetaryamount_02 = "503.50";
            taxLoop1.MOA.Add(moaTax1);

            //  End TAX Group 1
            result.TAXLoop2.Add(taxLoop1);

            //  Begin TAX Group 2
            var taxLoop2 = new Loop_TAX_INVOIC_3();

            //  Type of tax for the total message is value added tax 21 %
            taxLoop2.TAX = new TAX();
            taxLoop2.TAX.Dutytaxfeefunctionqualifier_01 = "7";
            taxLoop2.TAX.DUTYTAXFEETYPE_02 = new C241();
            taxLoop2.TAX.DUTYTAXFEETYPE_02.Dutytaxfeetypecoded_01 = "VAT";
            taxLoop2.TAX.DUTYTAXFEEDETAIL_05 = new C243();
            taxLoop2.TAX.DUTYTAXFEEDETAIL_05.Dutytaxfeerate_04 = "21";
            taxLoop2.TAX.Dutytaxfeecategorycoded_06 = "S";

            //  Repeating MOA
            taxLoop2.MOA = new List<MOA>();

            //  Tax monetary amount 453.60 EUR
            var moaTax2 = new MOA();
            moaTax2.MONETARYAMOUNT_01 = new C516();
            moaTax2.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "124";
            moaTax2.MONETARYAMOUNT_01.Monetaryamount_02 = "453.60";
            taxLoop2.MOA.Add(moaTax2);

            //  End TAX Group 2
            result.TAXLoop2.Add(taxLoop2);

            result.ALCLoop2 = new List<Loop_ALC_INVOIC_3>();

            //  Begin ALC Group
            var alcLoop2 = new Loop_ALC_INVOIC_3();

            //  Freight charge 
            alcLoop2.ALC = new ALC();
            alcLoop2.ALC.Allowanceorchargequalifier_01 = "C";
            alcLoop2.ALC.SPECIALSERVICESIDENTIFICATION_05 = new C214();
            alcLoop2.ALC.SPECIALSERVICESIDENTIFICATION_05.Specialservicescoded_01 = "FC";

            //  Repeating MOA 
            alcLoop2.MOA = new List<MOA>();

            //  Total charges 120 EUR
            var moaAlc = new MOA();
            moaAlc.MONETARYAMOUNT_01 = new C516();
            moaAlc.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "131";
            moaAlc.MONETARYAMOUNT_01.Monetaryamount_02 = "120";
            alcLoop2.MOA.Add(moaAlc);

            //  End ALC Group
            result.ALCLoop2.Add(alcLoop2);

            return result;
        }
    }
}
