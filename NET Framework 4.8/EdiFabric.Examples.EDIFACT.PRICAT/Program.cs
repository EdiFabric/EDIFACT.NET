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

namespace EdiFabric.Examples.EDIFACT.PRICAT
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
        /// Read Price Catalogue
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Eancom\PriceCatalogue.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSPRICAT>();

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
        /// Write Price Catalogue
        /// </summary>
        static void Write()
        {
            var transaction = BuildPriceCatalogue("ME000001");

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
        /// Build price catalogue.
        /// Original from https://www.gs1.org/sites/default/files/docs/eancom/s4/pricat.pdf
        /// </summary>
        static TSPRICAT BuildPriceCatalogue(string controlNumber)
        {
            var result = new TSPRICAT();

            //  Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "PRICAT";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "96A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            //  Price/sales catalogue number PC32458
            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "9";
            result.BGM.Documentmessagenumber_02 = "PC32458";
            result.BGM.Messagefunctioncoded_03 = "9";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  Message date 1st October 2002
            var dtm1 = new DTM();
            dtm1.DATETIMEPERIOD_01 = new C507();
            dtm1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "137";
            dtm1.DATETIMEPERIOD_01.Datetimeperiod_02 = "20021001";
            dtm1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm1);

            //  Repeating RFF Groups
            result.RFFLoop = new List<Loop_RFF_PRICAT>();

            //  Begin RFF Group
            var rffLoop1 = new Loop_RFF_PRICAT();

            //  Price list is related to contract number 5622ABE
            rffLoop1.RFF = new RFF();
            rffLoop1.RFF.REFERENCE_01 = new C506();
            rffLoop1.RFF.REFERENCE_01.Referencequalifier_01 = "CT";
            rffLoop1.RFF.REFERENCE_01.Referencenumber_02 = "5622ABE";

            //  Repeating DTM
            rffLoop1.DTM = new List<DTM>();

            //  Contract date 10th of August 2002
            var dtmRff1 = new DTM();
            dtmRff1.DATETIMEPERIOD_01 = new C507();
            dtmRff1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "171";
            dtmRff1.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020810";
            dtmRff1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            rffLoop1.DTM.Add(dtmRff1);

            //  End RFF Group
            result.RFFLoop.Add(rffLoop1);

            //  Repeating NAD Groups
            result.NADLoop = new List<Loop_NAD_PRICAT>();

            //  Begin NAD Group 1
            var nadLoop1 = new Loop_NAD_PRICAT();

            //  Buyer is identified by GLN 5412345000020
            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.Partyqualifier_01 = "BY";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5412345000020";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating RFF NAD Groups
            nadLoop1.RFFLoop = new List<Loop_RFF_PRICAT>();

            //  Begin RFF NAD Group
            var rffNadLoop1 = new Loop_RFF_PRICAT();

            //  Buyer’s VAT number VR12345
            rffNadLoop1.RFF = new RFF();
            rffNadLoop1.RFF.REFERENCE_01 = new C506();
            rffNadLoop1.RFF.REFERENCE_01.Referencequalifier_01 = "VA";
            rffNadLoop1.RFF.REFERENCE_01.Referencenumber_02 = "VR12345";

            //  End RFF NAD Group
            nadLoop1.RFFLoop.Add(rffNadLoop1);

            //  End NAD Group 1
            result.NADLoop.Add(nadLoop1);

            //  Begin NAD Group 2
            var nadLoop2 = new Loop_NAD_PRICAT();

            //  Supplier is identified by GLN 4012345500004
            nadLoop2.NAD = new NAD();
            nadLoop2.NAD.Partyqualifier_01 = "SU";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "4012345500004";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  Repeating RFF NAD Groups
            nadLoop2.RFFLoop = new List<Loop_RFF_PRICAT>();

            //  Begin RFF NAD Group
            var rffNadLoop2 = new Loop_RFF_PRICAT();

            //  Supplier’s VAT number is VR95745
            rffNadLoop2.RFF = new RFF();
            rffNadLoop2.RFF.REFERENCE_01 = new C506();
            rffNadLoop2.RFF.REFERENCE_01.Referencequalifier_01 = "VA";
            rffNadLoop2.RFF.REFERENCE_01.Referencenumber_02 = "VR95745";

            //  End RFF NAD Group
            nadLoop2.RFFLoop.Add(rffNadLoop2);

            //  End NAD Group 2
            result.NADLoop.Add(nadLoop2);

            //  Repeating CUX Groups
            result.CUXLoop = new List<Loop_CUX_PRICAT>();

            //  Begin CUX Group
            var cuxLoop = new Loop_CUX_PRICAT();

            //  Price list currency is Euros
            cuxLoop.CUX = new CUX();
            cuxLoop.CUX.CURRENCYDETAILS_01 = new C504();
            cuxLoop.CUX.CURRENCYDETAILS_01.Currencydetailsqualifier_01 = "2";
            cuxLoop.CUX.CURRENCYDETAILS_01.Currencycoded_02 = "EUR";
            cuxLoop.CUX.CURRENCYDETAILS_01.Currencyqualifier_03 = "8";

            //  End CUX Group
            result.CUXLoop.Add(cuxLoop);

            //  Repeating PGI Groups
            result.PGILoop = new List<Loop_PGI_PRICAT>();

            //  Begin PGI Group
            var pgiLoop1 = new Loop_PGI_PRICAT();

            //  Product group containing no price group
            pgiLoop1.PGI = new PGI();
            pgiLoop1.PGI.Productgrouptypecoded_01 = "2";

            //  Repeating LIN PGI Groups
            pgiLoop1.LINLoop = new List<Loop_LIN_PRICAT>();

            //  Begin LIN PGI Group 1
            var linPgiLoop1 = new Loop_LIN_PRICAT();

            //  Line item 1, an addition, is identified by GTIN 5410738377131
            linPgiLoop1.LIN = new LIN();
            linPgiLoop1.LIN.Lineitemnumber_01 = "1";
            linPgiLoop1.LIN.Actionrequestnotificationcoded_02 = "1";
            linPgiLoop1.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linPgiLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "5410738377131";
            linPgiLoop1.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";

            //  Repeating PIA
            linPgiLoop1.PIA = new List<PIA>();

            //  Supplier’s article number CU32555 is provided as an additional identification
            var piaLin1 = new PIA();
            piaLin1.Productidfunctionqualifier_01 = "1";
            piaLin1.ITEMNUMBERIDENTIFICATION_02 = new C212();
            piaLin1.ITEMNUMBERIDENTIFICATION_02.Itemnumber_01 = "CU32555";
            piaLin1.ITEMNUMBERIDENTIFICATION_02.Itemnumbertypecoded_02 = "SA";
            linPgiLoop1.PIA.Add(piaLin1);

            //  Repeating IMD
            linPgiLoop1.IMD = new List<IMD>();

            //  Current line item is a consumer unit
            var imdLin1 = new IMD();
            imdLin1.Itemdescriptiontypecoded_01 = "C";
            imdLin1.ITEMDESCRIPTION_03 = new C273();
            imdLin1.ITEMDESCRIPTION_03.Itemdescriptionidentification_01 = "CU";
            imdLin1.ITEMDESCRIPTION_03.Codelistresponsibleagencycoded_03 = "9";
            linPgiLoop1.IMD.Add(imdLin1);

            //  Product description
            var imdLin2 = new IMD();
            imdLin2.Itemdescriptiontypecoded_01 = "F";
            imdLin2.ITEMDESCRIPTION_03 = new C273();
            imdLin2.ITEMDESCRIPTION_03.Itemdescription_04 = "HEALTHIEST CORN CRISPIES";
            imdLin2.ITEMDESCRIPTION_03.Itemdescription_05 = "BOX";
            linPgiLoop1.IMD.Add(imdLin2);

            //  Repeating MEA
            linPgiLoop1.MEA = new List<MEA>();

            //  The net weight of the consumer unit is 250 grms
            var mea = new MEA();
            mea.Measurementapplicationqualifier_01 = "PD";
            mea.MEASUREMENTDETAILS_02 = new C502();
            mea.MEASUREMENTDETAILS_02.Measurementdimensioncoded_01 = "AAA";
            mea.MEASUREMENTDETAILS_02.Measurementsignificancecoded_02 = "4";
            mea.VALUERANGE_03 = new C174();
            mea.VALUERANGE_03.Measureunitqualifier_01 = "GRM";
            mea.VALUERANGE_03.Measurementvalue_02 = "250";
            linPgiLoop1.MEA.Add(mea);

            //  Repeating HAN
            linPgiLoop1.HAN = new List<HAN>();

            //  The product is foodstuffs
            var hanLin1 = new HAN();
            hanLin1.HANDLINGINSTRUCTIONS_01 = new C524();
            hanLin1.HANDLINGINSTRUCTIONS_01.Handlinginstructionscoded_01 = "EAT";
            hanLin1.HANDLINGINSTRUCTIONS_01.Codelistresponsibleagencycoded_03 = "9";
            linPgiLoop1.HAN.Add(hanLin1);

            //  Repeating TAX LIN Groups
            linPgiLoop1.TAXLoop = new List<Loop_TAX_PRICAT>();

            //  Begin TAX LIN Group
            var taxLin1 = new Loop_TAX_PRICAT();

            //  The product is subject to the standard rate of 21% VAT
            taxLin1.TAX = new TAX();
            taxLin1.TAX.Dutytaxfeefunctionqualifier_01 = "7";
            taxLin1.TAX.DUTYTAXFEETYPE_02 = new C241();
            taxLin1.TAX.DUTYTAXFEETYPE_02.Dutytaxfeetypecoded_01 = "VAT";
            taxLin1.TAX.DUTYTAXFEEDETAIL_05 = new C243();
            taxLin1.TAX.DUTYTAXFEEDETAIL_05.Dutytaxfeerate_04 = "21";
            taxLin1.TAX.Dutytaxfeecategorycoded_06 = "S";

            //  End TAX LIN Group
            linPgiLoop1.TAXLoop.Add(taxLin1);

            //  Repeating PRI LIN Groups
            linPgiLoop1.PRILoop = new List<Loop_PRI_PRICAT_2>();

            //  Begin PRI LIN Group
            var priLinLoop1 = new Loop_PRI_PRICAT_2();

            //  The suggested retail information price, including allowances / charges and taxes, is 40
            priLinLoop1.PRI = new PRI();
            priLinLoop1.PRI.PRICEINFORMATION_01 = new C509();
            priLinLoop1.PRI.PRICEINFORMATION_01.Pricequalifier_01 = "AAE";
            priLinLoop1.PRI.PRICEINFORMATION_01.Price_02 = "40";
            priLinLoop1.PRI.PRICEINFORMATION_01.Pricetypecoded_03 = "CA";
            priLinLoop1.PRI.PRICEINFORMATION_01.Pricetypequalifier_04 = "SRP";

            //  End PRI LIN Group
            linPgiLoop1.PRILoop.Add(priLinLoop1);

            //  Repeating PAC LIN Groups
            linPgiLoop1.PACLoop = new List<Loop_PAC_PRICAT>();

            //  Begin PAC LIN Group
            var pacLin1 = new Loop_PAC_PRICAT();

            //  The consumer unit is packaged in a box
            pacLin1.PAC = new PAC();
            pacLin1.PAC.PACKAGETYPE_03 = new C202();
            pacLin1.PAC.PACKAGETYPE_03.Typeofpackagesidentification_01 = "BX";

            //  Repeating MEA
            pacLin1.MEA = new List<MEA>();

            //  The height of the box is 200 mm
            var meaPac1 = new MEA();
            meaPac1.Measurementapplicationqualifier_01 = "PD";
            meaPac1.MEASUREMENTDETAILS_02 = new C502();
            meaPac1.MEASUREMENTDETAILS_02.Measurementdimensioncoded_01 = "HT";
            meaPac1.VALUERANGE_03 = new C174();
            meaPac1.VALUERANGE_03.Measureunitqualifier_01 = "MMT";
            meaPac1.VALUERANGE_03.Measurementvalue_02 = "200";
            pacLin1.MEA.Add(meaPac1);

            //  The length of the box is 80 mm
            var meaPac2 = new MEA();
            meaPac2.Measurementapplicationqualifier_01 = "PD";
            meaPac2.MEASUREMENTDETAILS_02 = new C502();
            meaPac2.MEASUREMENTDETAILS_02.Measurementdimensioncoded_01 = "LN";
            meaPac2.VALUERANGE_03 = new C174();
            meaPac2.VALUERANGE_03.Measureunitqualifier_01 = "MMT";
            meaPac2.VALUERANGE_03.Measurementvalue_02 = "80";
            pacLin1.MEA.Add(meaPac2);

            //  The width of the box is 30 mm
            var meaPac3 = new MEA();
            meaPac3.Measurementapplicationqualifier_01 = "PD";
            meaPac3.MEASUREMENTDETAILS_02 = new C502();
            meaPac3.MEASUREMENTDETAILS_02.Measurementdimensioncoded_01 = "WD";
            meaPac3.VALUERANGE_03 = new C174();
            meaPac3.VALUERANGE_03.Measureunitqualifier_01 = "MMT";
            meaPac3.VALUERANGE_03.Measurementvalue_02 = "30";
            pacLin1.MEA.Add(meaPac3);

            //  End PAC LIN Group
            linPgiLoop1.PACLoop.Add(pacLin1);            

            //  End LIN PGI Group 1
            pgiLoop1.LINLoop.Add(linPgiLoop1);

            //  Begin LIN PGI Group 2
            var linPgiLoop2 = new Loop_LIN_PRICAT();

            //  Line item 2, an addition, is identified by GTIN 5410738377117
            linPgiLoop2.LIN = new LIN();
            linPgiLoop2.LIN.Lineitemnumber_01 = "2";
            linPgiLoop2.LIN.Actionrequestnotificationcoded_02 = "1";
            linPgiLoop2.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linPgiLoop2.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "5410738377117";
            linPgiLoop2.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";

            //  Repeating PIA
            linPgiLoop2.PIA = new List<PIA>();

            //  Supplier’s article number TU32555 is provided as an additional identification
            var piaLin2 = new PIA();
            piaLin2.Productidfunctionqualifier_01 = "1";
            piaLin2.ITEMNUMBERIDENTIFICATION_02 = new C212();
            piaLin2.ITEMNUMBERIDENTIFICATION_02.Itemnumber_01 = "TU32555";
            piaLin2.ITEMNUMBERIDENTIFICATION_02.Itemnumbertypecoded_02 = "SA";
            linPgiLoop2.PIA.Add(piaLin2);

            //  Repeating IMD
            linPgiLoop2.IMD = new List<IMD>();

            //  Current line item is a trade unit
            var imdLin3 = new IMD();
            imdLin3.Itemdescriptiontypecoded_01 = "C";
            imdLin3.ITEMDESCRIPTION_03 = new C273();
            imdLin3.ITEMDESCRIPTION_03.Itemdescriptionidentification_01 = "TU";
            imdLin3.ITEMDESCRIPTION_03.Codelistresponsibleagencycoded_03 = "9";
            linPgiLoop2.IMD.Add(imdLin3);

            //  Product description
            var imdLin4 = new IMD();
            imdLin4.Itemdescriptiontypecoded_01 = "F";
            imdLin4.ITEMDESCRIPTION_03 = new C273();
            imdLin4.ITEMDESCRIPTION_03.Itemdescription_04 = "CORN CRISPIES";
            imdLin4.ITEMDESCRIPTION_03.Itemdescription_05 = "CASE";
            linPgiLoop2.IMD.Add(imdLin4);            

            //  Repeating HAN
            linPgiLoop2.HAN = new List<HAN>();

            //  The product is foodstuffs
            var hanLin2 = new HAN();
            hanLin2.HANDLINGINSTRUCTIONS_01 = new C524();
            hanLin2.HANDLINGINSTRUCTIONS_01.Handlinginstructionscoded_01 = "EAT";
            hanLin2.HANDLINGINSTRUCTIONS_01.Codelistresponsibleagencycoded_03 = "9";
            linPgiLoop2.HAN.Add(hanLin2);

            //  Repeating ALI
            linPgiLoop2.ALI = new List<ALI>();

            //  Country of origin is Belgium
            var aliLin1 = new ALI();
            aliLin1.Countryoforigincoded_01 = "BE";
            linPgiLoop2.ALI.Add(aliLin1);

            //  Repeating TAX LIN Groups
            linPgiLoop2.TAXLoop = new List<Loop_TAX_PRICAT>();

            //  Begin TAX LIN Group
            var taxLin2 = new Loop_TAX_PRICAT();

            //  Product is subject to the standard VAT rate of 21%
            taxLin2.TAX = new TAX();
            taxLin2.TAX.Dutytaxfeefunctionqualifier_01 = "7";
            taxLin2.TAX.DUTYTAXFEETYPE_02 = new C241();
            taxLin2.TAX.DUTYTAXFEETYPE_02.Dutytaxfeetypecoded_01 = "VAT";
            taxLin2.TAX.DUTYTAXFEEDETAIL_05 = new C243();
            taxLin2.TAX.DUTYTAXFEEDETAIL_05.Dutytaxfeerate_04 = "21";
            taxLin2.TAX.Dutytaxfeecategorycoded_06 = "S";

            //  End TAX LIN Group
            linPgiLoop2.TAXLoop.Add(taxLin2);

            //  Repeating PRI LIN Groups
            linPgiLoop2.PRILoop = new List<Loop_PRI_PRICAT_2>();

            //  Begin PRI LIN Group
            var priLinLoop2 = new Loop_PRI_PRICAT_2();

            //  The calculation gross price for the product is 500
            priLinLoop2.PRI = new PRI();
            priLinLoop2.PRI.PRICEINFORMATION_01 = new C509();
            priLinLoop2.PRI.PRICEINFORMATION_01.Pricequalifier_01 = "AAB";
            priLinLoop2.PRI.PRICEINFORMATION_01.Price_02 = "500";
            priLinLoop2.PRI.PRICEINFORMATION_01.Pricetypecoded_03 = "CA";

            //  Repeating ALC LIN Groups
            linPgiLoop2.ALCLoop = new List<Loop_ALC_PRICAT>();

            //  Begin ALC LIN Group
            var alcLin1 = new Loop_ALC_PRICAT();

            //  An allowance exists for this product
            alcLin1.ALC = new ALC();
            alcLin1.ALC.Allowanceorchargequalifier_01 = "A";
            alcLin1.ALC.Calculationsequenceindicatorcoded_04 = "1";

            //  PCD Group
            alcLin1.PCDLoop = new Loop_PCD_PRICAT();

            //  Allowance of 8%
            alcLin1.PCDLoop.PCD = new PCD();
            alcLin1.PCDLoop.PCD.PERCENTAGEDETAILS_01 = new C501();
            alcLin1.PCDLoop.PCD.PERCENTAGEDETAILS_01.Percentagequalifier_01 = "3";
            alcLin1.PCDLoop.PCD.PERCENTAGEDETAILS_01.Percentage_02 = "8";

            //  Is available on purchase of a minimum quantity of 48
            alcLin1.PCDLoop.RNG = new RNG();
            alcLin1.PCDLoop.RNG.Rangetypequalifier_01 = "1";
            alcLin1.PCDLoop.RNG.RANGE_02 = new C280();
            alcLin1.PCDLoop.RNG.RANGE_02.Measureunitqualifier_01 = "PCE";
            alcLin1.PCDLoop.RNG.RANGE_02.Rangeminimum_02 = "48";

            //  End ALC LIN Group
            linPgiLoop2.ALCLoop.Add(alcLin1);

            //  End PRI LIN Group
            linPgiLoop2.PRILoop.Add(priLinLoop2);

            //  Repeating PAC LIN Groups
            linPgiLoop2.PACLoop = new List<Loop_PAC_PRICAT>();

            //  Begin PAC LIN Group
            var pacLin2 = new Loop_PAC_PRICAT();

            //  The product is packaged in a carton
            pacLin2.PAC = new PAC();
            pacLin2.PAC.PACKAGETYPE_03 = new C202();
            pacLin2.PAC.PACKAGETYPE_03.Typeofpackagesidentification_01 = "CT";            

            //  End PAC LIN Group
            linPgiLoop2.PACLoop.Add(pacLin2);

            //  End LIN PGI Group 2
            pgiLoop1.LINLoop.Add(linPgiLoop2);

            //  Begin LIN PGI Group 3
            var linPgiLoop3 = new Loop_LIN_PRICAT();

            //  Line number 3, identified by GTIN 5410738377131, is a sub-line of line number 2
            linPgiLoop3.LIN = new LIN();
            linPgiLoop3.LIN.Lineitemnumber_01 = "3";
            linPgiLoop3.LIN.Actionrequestnotificationcoded_02 = "1";
            linPgiLoop3.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linPgiLoop3.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "5410738377131";
            linPgiLoop3.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";
            linPgiLoop3.LIN.SUBLINEINFORMATION_04 = new C829();
            linPgiLoop3.LIN.SUBLINEINFORMATION_04.Sublineindicatorcoded_01 = "1";
            linPgiLoop3.LIN.SUBLINEINFORMATION_04.Lineitemnumber_02 = "2";

            //  Repeating QTY
            linPgiLoop3.QTY = new List<QTY>();

            //  Number of consumer units in trade unit is 48
            var qtyLin1 = new QTY();
            qtyLin1.QUANTITYDETAILS_01 = new C186();
            qtyLin1.QUANTITYDETAILS_01.Quantityqualifier_01 = "45E";
            qtyLin1.QUANTITYDETAILS_01.Quantity_02 = "48";
            linPgiLoop3.QTY.Add(qtyLin1);

            //  End LIN PGI Group 3
            pgiLoop1.LINLoop.Add(linPgiLoop3);

            //  Begin LIN PGI Group 4
            var linPgiLoop4 = new Loop_LIN_PRICAT();

            //  Line item 4, an addition, is identified by GTIN 5410738251028
            linPgiLoop4.LIN = new LIN();
            linPgiLoop4.LIN.Lineitemnumber_01 = "4";
            linPgiLoop4.LIN.Actionrequestnotificationcoded_02 = "1";
            linPgiLoop4.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linPgiLoop4.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "5410738251028";
            linPgiLoop4.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";

            //  Repeating PIA
            linPgiLoop4.PIA = new List<PIA>();

            //  Supplier’s article number PN32555 is provided as an  additional identification
            var piaLin3 = new PIA();
            piaLin3.Productidfunctionqualifier_01 = "1";
            piaLin3.ITEMNUMBERIDENTIFICATION_02 = new C212();
            piaLin3.ITEMNUMBERIDENTIFICATION_02.Itemnumber_01 = "PN32555";
            piaLin3.ITEMNUMBERIDENTIFICATION_02.Itemnumbertypecoded_02 = "SA";
            linPgiLoop4.PIA.Add(piaLin3);

            //  Repeating IMD
            linPgiLoop4.IMD = new List<IMD>();

            //  Product is a despatch unit
            var imdLin5 = new IMD();
            imdLin5.Itemdescriptiontypecoded_01 = "C";
            imdLin5.ITEMDESCRIPTION_03 = new C273();
            imdLin5.ITEMDESCRIPTION_03.Itemdescriptionidentification_01 = "DU";
            imdLin5.ITEMDESCRIPTION_03.Codelistqualifier_02 = "9";
            linPgiLoop4.IMD.Add(imdLin5);

            //  Product description
            var imdLin6 = new IMD();
            imdLin6.Itemdescriptiontypecoded_01 = "F";
            imdLin6.ITEMDESCRIPTION_03 = new C273();
            imdLin6.ITEMDESCRIPTION_03.Itemdescription_04 = "CORN CRISPIES";
            imdLin6.ITEMDESCRIPTION_03.Itemdescription_05 = "PALLET";
            linPgiLoop4.IMD.Add(imdLin6);

            //  Repeating HAN
            linPgiLoop4.HAN = new List<HAN>();

            //  The product is foodstuffs
            var hanLin3 = new HAN();
            hanLin3.HANDLINGINSTRUCTIONS_01 = new C524();
            hanLin3.HANDLINGINSTRUCTIONS_01.Handlinginstructionscoded_01 = "EAT";
            hanLin3.HANDLINGINSTRUCTIONS_01.Codelistresponsibleagencycoded_03 = "9";
            linPgiLoop4.HAN.Add(hanLin3);

            //  The product is susceptible to frost damage
            var hanLin4 = new HAN();
            hanLin4.HANDLINGINSTRUCTIONS_01 = new C524();
            hanLin4.HANDLINGINSTRUCTIONS_01.Handlinginstructionscoded_01 = "FTD";
            hanLin4.HANDLINGINSTRUCTIONS_01.Codelistresponsibleagencycoded_03 = "9";
            linPgiLoop4.HAN.Add(hanLin4);

            //  Repeating TAX LIN Groups
            linPgiLoop4.TAXLoop = new List<Loop_TAX_PRICAT>();

            //  Begin TAX LIN Group
            var taxLin3 = new Loop_TAX_PRICAT();

            //  The product is subject to the standard VAT rate of 21%
            taxLin3.TAX = new TAX();
            taxLin3.TAX.Dutytaxfeefunctionqualifier_01 = "7";
            taxLin3.TAX.DUTYTAXFEETYPE_02 = new C241();
            taxLin3.TAX.DUTYTAXFEETYPE_02.Dutytaxfeetypecoded_01 = "VAT";
            taxLin3.TAX.DUTYTAXFEEDETAIL_05 = new C243();
            taxLin3.TAX.DUTYTAXFEEDETAIL_05.Dutytaxfeerate_04 = "21";
            taxLin3.TAX.Dutytaxfeecategorycoded_06 = "S";

            //  End TAX LIN Group
            linPgiLoop4.TAXLoop.Add(taxLin3);

            //  Repeating PRI LIN Groups
            linPgiLoop4.PRILoop = new List<Loop_PRI_PRICAT_2>();

            //  Begin PRI LIN Group
            var priLinLoop3 = new Loop_PRI_PRICAT_2();

            //  The calculation net price for the product is 24000
            priLinLoop3.PRI = new PRI();
            priLinLoop3.PRI.PRICEINFORMATION_01 = new C509();
            priLinLoop3.PRI.PRICEINFORMATION_01.Pricequalifier_01 = "AAA";
            priLinLoop3.PRI.PRICEINFORMATION_01.Price_02 = "24000";
            priLinLoop3.PRI.PRICEINFORMATION_01.Pricetypecoded_03 = "CA";

            //  End PRI LIN Group
            linPgiLoop4.PRILoop.Add(priLinLoop3);

            //  Repeating ALC LIN Groups
            linPgiLoop4.ALCLoop = new List<Loop_ALC_PRICAT>();

            //  Begin ALC LIN Group
            var alcLin2 = new Loop_ALC_PRICAT();

            //  An allowance exists for this product
            alcLin2.ALC = new ALC();
            alcLin2.ALC.Allowanceorchargequalifier_01 = "A";
            alcLin2.ALC.Calculationsequenceindicatorcoded_04 = "1";

            //  PCD Group
            alcLin2.PCDLoop = new Loop_PCD_PRICAT();

            //  Allowance of 10%
            alcLin2.PCDLoop.PCD = new PCD();
            alcLin2.PCDLoop.PCD.PERCENTAGEDETAILS_01 = new C501();
            alcLin2.PCDLoop.PCD.PERCENTAGEDETAILS_01.Percentagequalifier_01 = "1";
            alcLin2.PCDLoop.PCD.PERCENTAGEDETAILS_01.Percentage_02 = "10";

            //  Is available on purchases of a minimum quantity of 50
            alcLin2.PCDLoop.RNG = new RNG();
            alcLin2.PCDLoop.RNG.Rangetypequalifier_01 = "1";
            alcLin2.PCDLoop.RNG.RANGE_02 = new C280();
            alcLin2.PCDLoop.RNG.RANGE_02.Measureunitqualifier_01 = "PCE";
            alcLin2.PCDLoop.RNG.RANGE_02.Rangeminimum_02 = "50";

            //  End ALC LIN Group
            linPgiLoop4.ALCLoop.Add(alcLin2);

            //  Repeating PAC LIN Groups
            linPgiLoop4.PACLoop = new List<Loop_PAC_PRICAT>();

            //  Begin PAC LIN Group
            var pacLin3 = new Loop_PAC_PRICAT();

            //  The product is packaged on an ISO 1 pallet
            pacLin3.PAC = new PAC();
            pacLin3.PAC.PACKAGETYPE_03 = new C202();
            pacLin3.PAC.PACKAGETYPE_03.Typeofpackagesidentification_01 = "201";
            pacLin3.PAC.PACKAGETYPE_03.Codelistresponsibleagencycoded_03 = "9";

            //  End PAC LIN Group
            linPgiLoop4.PACLoop.Add(pacLin3);

            //  End LIN PGI Group 4
            pgiLoop1.LINLoop.Add(linPgiLoop4);

            //  Begin LIN PGI Group 5
            var linPgiLoop5 = new Loop_LIN_PRICAT();

            //  Line number 5, identified by GTIN 5410738377117 , is a sub-line of line number 4
            linPgiLoop5.LIN = new LIN();
            linPgiLoop5.LIN.Lineitemnumber_01 = "5";
            linPgiLoop5.LIN.Actionrequestnotificationcoded_02 = "1";
            linPgiLoop5.LIN.ITEMNUMBERIDENTIFICATION_03 = new C212();
            linPgiLoop5.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01 = "5410738377117";
            linPgiLoop5.LIN.ITEMNUMBERIDENTIFICATION_03.Itemnumbertypecoded_02 = "SRV";
            linPgiLoop5.LIN.SUBLINEINFORMATION_04 = new C829();
            linPgiLoop5.LIN.SUBLINEINFORMATION_04.Sublineindicatorcoded_01 = "1";
            linPgiLoop5.LIN.SUBLINEINFORMATION_04.Lineitemnumber_02 = "4";

            //  Repeating QTY
            linPgiLoop5.QTY = new List<QTY>();

            //  Number of traded units in despatch unit is 24
            var qtyLin2 = new QTY();
            qtyLin2.QUANTITYDETAILS_01 = new C186();
            qtyLin2.QUANTITYDETAILS_01.Quantityqualifier_01 = "45E";
            qtyLin2.QUANTITYDETAILS_01.Quantity_02 = "24";
            linPgiLoop5.QTY.Add(qtyLin2);

            //  End LIN PGI Group 5
            pgiLoop1.LINLoop.Add(linPgiLoop5);

            //  End PGI Group
            result.PGILoop.Add(pgiLoop1);

            return result;
        }
    }
}


