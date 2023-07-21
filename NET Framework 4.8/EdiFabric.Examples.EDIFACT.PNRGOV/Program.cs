using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Templates.Padis;
using System.Reflection;
using EdiFabric.Framework;

namespace EdiFabric.Examples.EDIFACT.PNRGOV
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();
            Read();
            Write();
        }

        /// <summary>
        /// Read Passenger Data
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\PassengerData.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, TypeFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSPNRGOV>();

            foreach (var transaction in transactions)
            {
                if (transaction.HasErrors)
                {
                    //  partially parsed
                    var errors = transaction.ErrorContext.Flatten();
                }
            }
        }

        public static TypeInfo TypeFactory(UNB unb, UNG ung, UNH unh)
        {
            if (unh.MessageIdentifier_02.MessageType_01 == "PNRGOV")
                return typeof(TSPNRGOV).GetTypeInfo();

            throw new System.Exception(string.Format("Transaction {0} for version {1} is not supported.",
                unh.MessageIdentifier_02.MessageType_01, unh.MessageIdentifier_02.MessageVersionNumber_02 + unh.MessageIdentifier_02.MessageReleaseNumber_03));
        }

        /// <summary>
        /// Write Passenger Data
        /// </summary>
        static void Write()
        {
            var transaction = BuildPassengerData("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream))
                {
                    writer.Write(SegmentBuilders.BuildUnb("13052210400995"));
                    writer.Write(SegmentBuilders.BuildUng("13052210400995", "PNRGOV"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        public static TypeInfo TemplateFactory(UNB unb, UNG ung, UNH unh)
        {
            if (unh.MessageIdentifier_02.MessageType_01 == "PNRGOV")
                return typeof(TSPNRGOV).GetTypeInfo();

            throw new System.Exception(string.Format("Transaction {0} for version {1} is not supported.",
                unh.MessageIdentifier_02.MessageType_01, unh.MessageIdentifier_02.MessageVersionNumber_02 + unh.MessageIdentifier_02.MessageReleaseNumber_03));
        }

        /// <summary>
        /// Build passenger data.
        /// Original from https://www.iata.org/iata/passenger-data-toolkit/assets/doc_library/04-pnr/PNRGOV%20EDIFACT%20Implementation%20Guide%2013_1.pdf
        /// </summary>
        static TSPNRGOV BuildPassengerData(string controlNumber)
        {
            var result = new TSPNRGOV();

            //  Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "PNRGOV";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "11";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "1";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "IA";
            result.UNH.CommonAccessReference_03 = "AM498/230513/1142";

            //  Code to specify the message function
            result.MSG = new MSG();
            result.MSG.MESSAGEFUNCTIONBUSINESSDETAILS_01 = new C302();
            result.MSG.MESSAGEFUNCTIONBUSINESSDETAILS_01.MessageFunction_02 = "22";

            //  The originator of the request is AM
            result.ORG = new ORG();
            result.ORG.SYSTEMDETAILS_01 = new C336();
            result.ORG.SYSTEMDETAILS_01.CompanyIdentification_01 = "AM";

            //  PNR data for AM498/23MAY13 MTY LAS
            result.TVL = new TVL();
            result.TVL.PRODUCTDATETIME_01 = new C310();
            result.TVL.PRODUCTDATETIME_01.FirstDate_01 = "230513";
            result.TVL.PRODUCTDATETIME_01.FirstTime_02 = "1039";
            result.TVL.PRODUCTDATETIME_01.SecondDate_03 = "230513";
            result.TVL.PRODUCTDATETIME_01.SecondTime_04 = "1142";
            result.TVL.LOCATION_02 = new C328();
            result.TVL.LOCATION_02.PlaceLocationIdentification_01 = "MTY";
            result.TVL.LOCATION2_03 = new C328();
            result.TVL.LOCATION2_03.PlaceLocationIdentification_01 = "LAS";
            result.TVL.COMPANYIDENTIFICATION_04 = new C306();
            result.TVL.COMPANYIDENTIFICATION_04.CompanyIdentification_01 = "AM";
            result.TVL.PRODUCTIDENTIFICATIONDETAILS_05 = new C308();
            result.TVL.PRODUCTIDENTIFICATIONDETAILS_05.ProductionIdentification_01 = "498";

            //  Total numbers of PNRs
            result.EQN = new EQN();
            result.EQN.NUMBEROFUNITDETAILS_01 = new List<C523>();
            var c523 = new C523();
            c523.NumberOfUnits_01 = "1";
            result.EQN.NUMBEROFUNITDETAILS_01.Add(c523);

            //  Repeating SRC Groups
            result.GR1_SRCLoop = new List<GR1_SRCLoop>();

            //  Begin SRC Group
            var srcLoop = new GR1_SRCLoop();

            //  Situational blank SRC
            srcLoop.SRC = new SRC();

            //  Passenger record reference
            srcLoop.RCI = new RCI();
            srcLoop.RCI.RESERVATIONCONTROLINFORMATION_01 = new List<C330>();
            var c330 = new C330();
            c330.CompanyIdentification_01 = "AM";
            c330.ReservationControlNumber_02 = "XXXYET";
            c330.FirstDate_04 = "300413";
            c330.Time_05 = "115500";
            srcLoop.RCI.RESERVATIONCONTROLINFORMATION_01.Add(c330);

            //  Repeating SSR
            srcLoop.SSR = new List<SSR>();

            //  Special requirements /general information-applies to all flights and all passengers
            var ssrSrc1 = new SSR();
            ssrSrc1.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrSrc1.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "OTHS";
            ssrSrc1.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = " ADV TKT NUMBER BY 03MAY13 1800CO OR WILL CANCEL";
            srcLoop.SSR.Add(ssrSrc1);

            //  Special requirements 2
            var ssrSrc2 = new SSR();
            ssrSrc2.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrSrc2.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "OTHS";
            ssrSrc2.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = " IF THE FARE RULE TL DIFFERS FROM THE AUTOMATIC";
            srcLoop.SSR.Add(ssrSrc2);

            //  //  Special requirements 3
            var ssrSrc3 = new SSR();
            ssrSrc3.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrSrc3.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "OTHS";
            ssrSrc3.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = " TL THE MOST RESTRICTIVE TL WILL APPLY";
            srcLoop.SSR.Add(ssrSrc3);

            //  Ticket issue / last PNR transaction date/Time
            srcLoop.DAT = new DAT();
            srcLoop.DAT.DATEANDTIMEDETAILS_01 = new List<C688>();
            var c688 = new C688();
            c688.DateTimePeriodQualifier_01 = "700";
            c688.FirstDate_02 = "180513";
            c688.FirstTime_03 = "1502";
            srcLoop.DAT.DATEANDTIMEDETAILS_01.Add(c688);

            //  Booked by AM, BOG agent
            srcLoop.ORG = new ORG();
            srcLoop.ORG.SYSTEMDETAILS_01 = new C336();
            srcLoop.ORG.SYSTEMDETAILS_01.CompanyIdentification_01 = "AM";
            srcLoop.ORG.SYSTEMDETAILS_01.PlaceLocationIdentification_02 = "BOG";

            //  Repeating TIF Groups
            srcLoop.GR2_TIFLoop = new List<GR2_TIFLoop>();

            //  Begin TIF Group 1
            var tifLoop1 = new GR2_TIFLoop();

            //  Adult passenger’s name & surname
            tifLoop1.TIF = new TIF();
            tifLoop1.TIF.TRAVELLERSURNAMEINFORMATION_01 = new C322();
            tifLoop1.TIF.TRAVELLERSURNAMEINFORMATION_01.TravellerSurname_01 = "TESTSURNAMEONE";
            tifLoop1.TIF.TRAVELLERDETAILS_02 = new List<C324>();
            var c324 = new C324();
            c324.TravellerGivenName_01 = "TESTNAMEONE MRS";
            c324.NumberOfUnitsQualifier_02 = "A";
            c324.TravellerReferenceNumber_03 = "1.1";
            c324.TravellerAccompaniedByInfantIndicator_04 = "1";
            tifLoop1.TIF.TRAVELLERDETAILS_02.Add(c324);

            //  Repeating SSR
            tifLoop1.SSR = new List<SSR>();

            //  Infant information: surname/name/DOB
            var ssrTif1 = new SSR();
            ssrTif1.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTif1.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "INFT";
            ssrTif1.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "NN";
            ssrTif1.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTif1.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTif1.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "TESTSURNAMETWO/TESTNAMETWO/10AUG11";
            ssrTif1.SPECIALREQUIREMENTDATADETAILS_02 = new List<C332>();
            var c3321 = new C332();
            c3321.TravellerReferenceNumber_03 = "1.1";
            ssrTif1.SPECIALREQUIREMENTDATADETAILS_02.Add(c3321);
            tifLoop1.SSR.Add(ssrTif1);

            //  Infant information: surname/name/DOB
            var ssrTif2 = new SSR();
            ssrTif2.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTif2.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "INFT";
            ssrTif2.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "NN";
            ssrTif2.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTif2.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTif2.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "TESTSURNAMETWO/TESTNAMETWO/10AUG11";
            ssrTif2.SPECIALREQUIREMENTDATADETAILS_02 = new List<C332>();
            var c3322 = new C332();
            c3322.TravellerReferenceNumber_03 = "1.1";
            ssrTif2.SPECIALREQUIREMENTDATADETAILS_02.Add(c3322);
            tifLoop1.SSR.Add(ssrTif2);

            //  Ticketing details for adult MEX CUN
            var ssrTif3 = new SSR();
            ssrTif3.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTif3.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "TKNE";
            ssrTif3.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "HK";
            ssrTif3.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTif3.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTif3.SPECIALREQUIREMENTTYPEDETAILS_01.ItemDescription_07 = "MEX";
            ssrTif3.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification_08 = "CUN";
            ssrTif3.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "1392178947000C2";
            ssrTif3.SPECIALREQUIREMENTDATADETAILS_02 = new List<C332>();
            var c3323 = new C332();
            c3323.TravellerReferenceNumber_03 = "1.1";
            ssrTif3.SPECIALREQUIREMENTDATADETAILS_02.Add(c3323);
            tifLoop1.SSR.Add(ssrTif3);

            //  Ticketing details for adult CUN BOG
            var ssrTif4 = new SSR();
            ssrTif4.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTif4.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "TKNE";
            ssrTif4.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "HK";
            ssrTif4.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTif4.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTif4.SPECIALREQUIREMENTTYPEDETAILS_01.ItemDescription_07 = "CUN";
            ssrTif4.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification_08 = "BOG";
            ssrTif4.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "1392178947000C3";
            ssrTif4.SPECIALREQUIREMENTDATADETAILS_02 = new List<C332>();
            var c3324 = new C332();
            c3324.TravellerReferenceNumber_03 = "1.1";
            ssrTif4.SPECIALREQUIREMENTDATADETAILS_02.Add(c3324);
            tifLoop1.SSR.Add(ssrTif4);

            //  Ticketing details for infant MEX CUN
            var ssrTif5 = new SSR();
            ssrTif5.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTif5.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "TKNE";
            ssrTif5.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "HK";
            ssrTif5.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTif5.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTif5.SPECIALREQUIREMENTTYPEDETAILS_01.ItemDescription_07 = "MEX";
            ssrTif5.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification_08 = "CUN";
            ssrTif5.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "INF1392178947000C2";
            ssrTif5.SPECIALREQUIREMENTDATADETAILS_02 = new List<C332>();
            var c3325 = new C332();
            c3325.TravellerReferenceNumber_03 = "1.1";
            ssrTif5.SPECIALREQUIREMENTDATADETAILS_02.Add(c3325);
            tifLoop1.SSR.Add(ssrTif5);

            //  Ticketing details for infant CUN BOG
            var ssrTif6 = new SSR();
            ssrTif6.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTif6.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "TKNE";
            ssrTif6.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "HK";
            ssrTif6.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTif6.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTif6.SPECIALREQUIREMENTTYPEDETAILS_01.ItemDescription_07 = "CUN";
            ssrTif6.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification_08 = "BOG";
            ssrTif6.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "INF1392178947000C3";
            ssrTif6.SPECIALREQUIREMENTDATADETAILS_02 = new List<C332>();
            var c3326 = new C332();
            c3326.TravellerReferenceNumber_03 = "1.1";
            ssrTif6.SPECIALREQUIREMENTDATADETAILS_02.Add(c3326);
            tifLoop1.SSR.Add(ssrTif6);

            //  Passport information for adult 
            var ssrTif7 = new SSR();
            ssrTif7.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTif7.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "DOCS";
            ssrTif7.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "HK";
            ssrTif7.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTif7.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTif7.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "/P/CO/52263000/CO/30MAY76/F/31OCT15/TESTSURNAMEONE/TESTNAMEONE MRS";
            ssrTif7.SPECIALREQUIREMENTDATADETAILS_02 = new List<C332>();
            var c3327 = new C332();
            c3327.TravellerReferenceNumber_03 = "1.1";
            ssrTif7.SPECIALREQUIREMENTDATADETAILS_02.Add(c3327);
            tifLoop1.SSR.Add(ssrTif7);

            //  Passport information for infant
            var ssrTif8 = new SSR();
            ssrTif8.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTif8.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "DOCS";
            ssrTif8.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "HK";
            ssrTif8.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTif8.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTif8.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "/P/COL/AO234000/COL/10AUG11/FI/21DEC22/TESTSURNAMETWO/TESTNAMETWO";
            ssrTif8.SPECIALREQUIREMENTDATADETAILS_02 = new List<C332>();
            var c3328 = new C332();
            c3328.TravellerReferenceNumber_03 = "1.1";
            ssrTif8.SPECIALREQUIREMENTDATADETAILS_02.Add(c3328);
            tifLoop1.SSR.Add(ssrTif8);

            //  End TIF Group 1
            srcLoop.GR2_TIFLoop.Add(tifLoop1);

            //  Begin TIF Group 2
            var tifLoop2 = new GR2_TIFLoop();

            //  Infant passenger’s name & surname
            tifLoop2.TIF = new TIF();
            tifLoop2.TIF.TRAVELLERSURNAMEINFORMATION_01 = new C322();
            tifLoop2.TIF.TRAVELLERSURNAMEINFORMATION_01.TravellerSurname_01 = "TESTSURNAMETWO";
            tifLoop2.TIF.TRAVELLERDETAILS_02 = new List<C324>();
            var c3242 = new C324();
            c3242.TravellerGivenName_01 = "TESTNAMETWO";
            c3242.NumberOfUnitsQualifier_02 = "IN";
            c3242.TravellerReferenceNumber_03 = "2.1";
            tifLoop2.TIF.TRAVELLERDETAILS_02.Add(c3242);

            //  Repeating IFT
            tifLoop2.IFT = new List<IFT>();

            //  OSI free text information
            var iftTif1 = new IFT();
            iftTif1.FREETEXTQUALIFICATION_01 = new C346();
            iftTif1.FREETEXTQUALIFICATION_01.TextSubjectQualifier_01 = "4";
            iftTif1.FREETEXTQUALIFICATION_01.InformationType_02 = "28";
            iftTif1.FreeText_02 = new List<string>();
            iftTif1.FreeText_02.Add("AM INF");
            tifLoop2.IFT.Add(iftTif1);

            //  End TIF Group 2
            srcLoop.GR2_TIFLoop.Add(tifLoop2);

            //  Repeating TVL SRC Groups
            srcLoop.GR5_TVLLoop = new List<GR5_TVLLoop>();

            //  Begin TVL SRC Group 1
            var tvlSrc1 = new GR5_TVLLoop();

            //  PNR data for AM709/15MAY13 BOG MEX
            tvlSrc1.TVL = new TVL();
            tvlSrc1.TVL.PRODUCTDATETIME_01 = new C310();
            tvlSrc1.TVL.PRODUCTDATETIME_01.FirstDate_01 = "150513";
            tvlSrc1.TVL.PRODUCTDATETIME_01.FirstTime_02 = "0105";
            tvlSrc1.TVL.PRODUCTDATETIME_01.SecondDate_03 = "150513";
            tvlSrc1.TVL.PRODUCTDATETIME_01.SecondTime_04 = "0557";
            tvlSrc1.TVL.LOCATION_02 = new C328();
            tvlSrc1.TVL.LOCATION_02.PlaceLocationIdentification_01 = "BOG";
            tvlSrc1.TVL.LOCATION2_03 = new C328();
            tvlSrc1.TVL.LOCATION2_03.PlaceLocationIdentification_01 = "MEX";
            tvlSrc1.TVL.COMPANYIDENTIFICATION_04 = new C306();
            tvlSrc1.TVL.COMPANYIDENTIFICATION_04.CompanyIdentification_01 = "AM";
            tvlSrc1.TVL.PRODUCTIDENTIFICATIONDETAILS_05 = new C308();
            tvlSrc1.TVL.PRODUCTIDENTIFICATIONDETAILS_05.ProductionIdentification_01 = "709";
            tvlSrc1.TVL.PRODUCTIDENTIFICATIONDETAILS_05.CharacteristicIdentification_02 = "R";

            //  Flight booking status for 1 adult passenger
            tvlSrc1.RPI = new RPI();
            tvlSrc1.RPI.Quantity_01 = "1";
            tvlSrc1.RPI.Status_02 = new List<string>();
            tvlSrc1.RPI.Status_02.Add("YG");

            //  Equipment Type- Boeing 737
            tvlSrc1.APD = new APD();
            tvlSrc1.APD.ADDITIONALPRODUCTDETAILS_01 = new C314();
            tvlSrc1.APD.ADDITIONALPRODUCTDETAILS_01.TypeOfMeansOfTransport_01 = "737";

            //  AM passenger record reference
            tvlSrc1.RCI = new RCI();
            tvlSrc1.RCI.RESERVATIONCONTROLINFORMATION_01 = new List<C330>();
            var c3302 = new C330();
            c3302.CompanyIdentification_01 = "AM";
            c3302.ReservationControlNumber_02 = "XXXYET";
            c3302.FirstDate_04 = "300413";
            c3302.Time_05 = "115500";
            tvlSrc1.RCI.RESERVATIONCONTROLINFORMATION_01.Add(c3302);

            //  End TVL SRC Group 1
            srcLoop.GR5_TVLLoop.Add(tvlSrc1);

            //  Begin TVL SRC Group 2
            var tvlSrc2 = new GR5_TVLLoop();

            //  PNR data for AM445/19MAY13 MEX CUN
            tvlSrc2.TVL = new TVL();
            tvlSrc2.TVL.PRODUCTDATETIME_01 = new C310();
            tvlSrc2.TVL.PRODUCTDATETIME_01.FirstDate_01 = "190513";
            tvlSrc2.TVL.PRODUCTDATETIME_01.FirstTime_02 = "1500";
            tvlSrc2.TVL.PRODUCTDATETIME_01.SecondDate_03 = "190513";
            tvlSrc2.TVL.PRODUCTDATETIME_01.SecondTime_04 = "1710";
            tvlSrc2.TVL.LOCATION_02 = new C328();
            tvlSrc2.TVL.LOCATION_02.PlaceLocationIdentification_01 = "MEX";
            tvlSrc2.TVL.LOCATION2_03 = new C328();
            tvlSrc2.TVL.LOCATION2_03.PlaceLocationIdentification_01 = "CUN";
            tvlSrc2.TVL.COMPANYIDENTIFICATION_04 = new C306();
            tvlSrc2.TVL.COMPANYIDENTIFICATION_04.CompanyIdentification_01 = "AM";
            tvlSrc2.TVL.PRODUCTIDENTIFICATIONDETAILS_05 = new C308();
            tvlSrc2.TVL.PRODUCTIDENTIFICATIONDETAILS_05.ProductionIdentification_01 = "445";
            tvlSrc2.TVL.PRODUCTIDENTIFICATIONDETAILS_05.CharacteristicIdentification_02 = "S";

            //  Flight booking status for 1 adult passenger
            tvlSrc2.RPI = new RPI();
            tvlSrc2.RPI.Quantity_01 = "1";
            tvlSrc2.RPI.Status_02 = new List<string>();
            tvlSrc2.RPI.Status_02.Add("HK");

            //  Equipment Type
            tvlSrc2.APD = new APD();
            tvlSrc2.APD.ADDITIONALPRODUCTDETAILS_01 = new C314();
            tvlSrc2.APD.ADDITIONALPRODUCTDETAILS_01.TypeOfMeansOfTransport_01 = "738";

            //  Repeating SSR
            tvlSrc2.SSR = new List<SSR>();

            //  Infant information: surname/name/DOB 
            var ssrTvl1 = new SSR();
            ssrTvl1.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTvl1.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "INFT";
            ssrTvl1.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "NN";
            ssrTvl1.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTvl1.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTvl1.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "TESTSURNAMETWO/TESTNAMETWO/10AUG11";
            tvlSrc2.SSR.Add(ssrTvl1);

            //  Ticketing details for adult MEX CUN 
            var ssrTvl2 = new SSR();
            ssrTvl2.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTvl2.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "TKNE";
            ssrTvl2.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "HK";
            ssrTvl2.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTvl2.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTvl2.SPECIALREQUIREMENTTYPEDETAILS_01.ItemDescription_07 = "MEX";
            ssrTvl2.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification_08 = "CUN";
            ssrTvl2.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "1392178947000C2";
            tvlSrc2.SSR.Add(ssrTvl2);

            //  Ticketing details for infant MEX CUN 
            var ssrTvl3 = new SSR();
            ssrTvl3.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTvl3.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "TKNE";
            ssrTvl3.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "HK";
            ssrTvl3.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTvl3.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTvl3.SPECIALREQUIREMENTTYPEDETAILS_01.ItemDescription_07 = "MEX";
            ssrTvl3.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification_08 = "CUN";
            ssrTvl3.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "INF1392178947000C2";
            tvlSrc2.SSR.Add(ssrTvl3);

            //  AM passenger record reference
            tvlSrc2.RCI = new RCI();
            tvlSrc2.RCI.RESERVATIONCONTROLINFORMATION_01 = new List<C330>();
            var c3303 = new C330();
            c3303.CompanyIdentification_01 = "AM";
            c3303.ReservationControlNumber_02 = "XXXYET";
            c3303.FirstDate_04 = "300413";
            c3303.Time_05 = "115500";
            tvlSrc2.RCI.RESERVATIONCONTROLINFORMATION_01.Add(c3303);

            //  End TVL SRC Group 2
            srcLoop.GR5_TVLLoop.Add(tvlSrc2);

            //  Begin TVL SRC Group 3
            var tvlSrc3 = new GR5_TVLLoop();

            //  PNR data for AM718/23MAY13 CUN BOG
            tvlSrc3.TVL = new TVL();
            tvlSrc3.TVL.PRODUCTDATETIME_01 = new C310();
            tvlSrc3.TVL.PRODUCTDATETIME_01.FirstDate_01 = "230513";
            tvlSrc3.TVL.PRODUCTDATETIME_01.FirstTime_02 = "0135";
            tvlSrc3.TVL.PRODUCTDATETIME_01.SecondDate_03 = "230513";
            tvlSrc3.TVL.PRODUCTDATETIME_01.SecondTime_04 = "0500";
            tvlSrc3.TVL.LOCATION_02 = new C328();
            tvlSrc3.TVL.LOCATION_02.PlaceLocationIdentification_01 = "CUN";
            tvlSrc3.TVL.LOCATION2_03 = new C328();
            tvlSrc3.TVL.LOCATION2_03.PlaceLocationIdentification_01 = "BOG";
            tvlSrc3.TVL.COMPANYIDENTIFICATION_04 = new C306();
            tvlSrc3.TVL.COMPANYIDENTIFICATION_04.CompanyIdentification_01 = "AM";
            tvlSrc3.TVL.PRODUCTIDENTIFICATIONDETAILS_05 = new C308();
            tvlSrc3.TVL.PRODUCTIDENTIFICATIONDETAILS_05.ProductionIdentification_01 = "718";
            tvlSrc3.TVL.PRODUCTIDENTIFICATIONDETAILS_05.CharacteristicIdentification_02 = "Q";

            //  Flight booking status for 1 passenger
            tvlSrc3.RPI = new RPI();
            tvlSrc3.RPI.Quantity_01 = "1";
            tvlSrc3.RPI.Status_02 = new List<string>();
            tvlSrc3.RPI.Status_02.Add("HK");

            //  Equipment Type
            tvlSrc3.APD = new APD();
            tvlSrc3.APD.ADDITIONALPRODUCTDETAILS_01 = new C314();
            tvlSrc3.APD.ADDITIONALPRODUCTDETAILS_01.TypeOfMeansOfTransport_01 = "737";

            //  Repeating SSR
            tvlSrc3.SSR = new List<SSR>();

            //  Infant information: surname/name/DOB
            var ssrTvl4 = new SSR();
            ssrTvl4.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTvl4.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "INFT";
            ssrTvl4.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "NN";
            ssrTvl4.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTvl4.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTvl4.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "TESTSURNAMETWO/TESTNAMETWO/10AUG11";
            tvlSrc3.SSR.Add(ssrTvl4);

            //  Ticketing details for adult CUN BOG
            var ssrTvl5 = new SSR();
            ssrTvl5.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTvl5.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "TKNE";
            ssrTvl5.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "HK";
            ssrTvl5.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTvl5.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTvl5.SPECIALREQUIREMENTTYPEDETAILS_01.ItemDescription_07 = "CUN";
            ssrTvl5.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification_08 = "BOG";
            ssrTvl5.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "1392178947000C3";
            tvlSrc3.SSR.Add(ssrTvl5);

            //  Ticketing details for infant CUN BOG
            var ssrTvl6 = new SSR();
            ssrTvl6.SPECIALREQUIREMENTTYPEDETAILS_01 = new C334();
            ssrTvl6.SPECIALREQUIREMENTTYPEDETAILS_01.SpecialRequirementType_01 = "TKNE";
            ssrTvl6.SPECIALREQUIREMENTTYPEDETAILS_01.Status_02 = "HK";
            ssrTvl6.SPECIALREQUIREMENTTYPEDETAILS_01.Quantity_03 = "1";
            ssrTvl6.SPECIALREQUIREMENTTYPEDETAILS_01.CompanyIdentification_04 = "AM";
            ssrTvl6.SPECIALREQUIREMENTTYPEDETAILS_01.ItemDescription_07 = "CUN";
            ssrTvl6.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification_08 = "BOG";
            ssrTvl6.SPECIALREQUIREMENTTYPEDETAILS_01.PlaceLocationIdentification2_09 = "INF1392178947000C3";
            tvlSrc3.SSR.Add(ssrTvl6);

            //  AM passenger record reference
            tvlSrc3.RCI = new RCI();
            tvlSrc3.RCI.RESERVATIONCONTROLINFORMATION_01 = new List<C330>();
            var c3304 = new C330();
            c3304.CompanyIdentification_01 = "AM";
            c3304.ReservationControlNumber_02 = "XXXYET";
            c3304.FirstDate_04 = "300413";
            c3304.Time_05 = "115500";
            tvlSrc3.RCI.RESERVATIONCONTROLINFORMATION_01.Add(c3304);

            //  End TVL SRC Group 3
            srcLoop.GR5_TVLLoop.Add(tvlSrc3);

            //  End SRC Group
            result.GR1_SRCLoop.Add(srcLoop);

            return result;
        }
    }
}

