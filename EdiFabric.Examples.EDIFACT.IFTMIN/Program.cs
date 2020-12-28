using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Templates.EdifactD96A;
using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.IFTMIN
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());
            Read();
            Write();
        }

        /// <summary>
        /// Read Instruction
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Eancom\Instruction.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSIFTMIN>();

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
        /// Write Instruction
        /// </summary>
        static void Write()
        {
            var transaction = BuildInstruction("ME000001");

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
        /// Build instruction.
        /// Original from https://www.gs1.org/sites/default/files/docs/eancom/s4/iftmin.pdf
        /// </summary>
        static TSIFTMIN BuildInstruction(string controlNumber)
        {
            var result = new TSIFTMIN();

            //  Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "IFTMIN";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "96A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            //  Transport instruction number 
            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "610";
            result.BGM.Documentmessagenumber_02 = "569952";
            result.BGM.Messagefunctioncoded_03 = "9";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  Message date/time 1st March 2002
            var dtm1 = new DTM();
            dtm1.DATETIMEPERIOD_01 = new C507();
            dtm1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "137";
            dtm1.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020301";
            dtm1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm1);

            //  Delivery date/time requested, 8th March 2002 at 11:00
            var dtm2 = new DTM();
            dtm2.DATETIMEPERIOD_01 = new C507();
            dtm2.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "2";
            dtm2.DATETIMEPERIOD_01.Datetimeperiod_02 = "200203081100";
            dtm2.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "203";
            result.DTM.Add(dtm2);
            
            //  Repeating CNT
            result.CNT = new List<CNT>();

            //  Total number of packages 1
            var cnt = new CNT();
            cnt.CONTROL_01 = new C270();
            cnt.CONTROL_01.Controlqualifier_01 = "11";
            cnt.CONTROL_01.Controlvalue_02 = "1";
            result.CNT.Add(cnt);

            //  Repeating RFF Groups
            result.RFFLoop = new List<Loop_RFF_IFTMIN>();

            //  Begin RFF Group
            var rffLoop1 = new Loop_RFF_IFTMIN();

            //  Consignor’s reference number TI1284 
            rffLoop1.RFF = new RFF();
            rffLoop1.RFF.REFERENCE_01 = new C506();
            rffLoop1.RFF.REFERENCE_01.Referencequalifier_01 = "CU";
            rffLoop1.RFF.REFERENCE_01.Referencenumber_02 = "TI1284";

            //  End RFF Group
            result.RFFLoop.Add(rffLoop1);

            //  Repeating TDT Groups
            result.TDTLoop = new List<Loop_TDT_IFTMIN>();

            //  Begin TDT Group
            var tdtLoop1 = new Loop_TDT_IFTMIN();

            //  Details of transport, by truck 
            tdtLoop1.TDT = new TDT();
            tdtLoop1.TDT.Transportstagequalifier_01 = "20";
            tdtLoop1.TDT.MODEOFTRANSPORT_03 = new C220();
            tdtLoop1.TDT.MODEOFTRANSPORT_03.Modeoftransportcoded_01 = "30";
            tdtLoop1.TDT.TRANSPORTMEANS_04 = new C228();
            tdtLoop1.TDT.TRANSPORTMEANS_04.Typeofmeansoftransportidentification_01 = "31";

            //  Repeating DTM
            tdtLoop1.DTM = new List<DTM>();

            //  Estimated departure of truck 5th March 2002 at 11am
            var dtmTdt1 = new DTM();
            dtmTdt1.DATETIMEPERIOD_01 = new C507();
            dtmTdt1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "133";
            dtmTdt1.DATETIMEPERIOD_01.Datetimeperiod_02 = "200203051100";
            dtmTdt1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "203";
            tdtLoop1.DTM.Add(dtmTdt1);

            //  Repeating LOC Groups
            tdtLoop1.LOCLoop = new List<Loop_LOC_IFTMIN_2>();

            //  Begin LOC Group
            var locTdt1 = new Loop_LOC_IFTMIN_2();

            //  Place of truck loading identified with GLN 5412345678908
            locTdt1.LOC = new LOC();
            locTdt1.LOC.Placelocationqualifier_01 = "9";
            locTdt1.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            locTdt1.LOC.LOCATIONIDENTIFICATION_02.Placelocationidentification_01 = "5412345678908";
            locTdt1.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycoded_03 = "9";

            //  End LOC Group
            tdtLoop1.LOCLoop.Add(locTdt1);

            //  End TDT Group
            result.TDTLoop.Add(tdtLoop1);

            //  Repeating NAD Groups
            result.NADLoop = new List<Loop_NAD_IFTMIN>();

            //  Begin NAD Group 1
            var nadLoop1 = new Loop_NAD_IFTMIN();

            //  Consignor identified with GLN 5412345123453
            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.Partyqualifier_01 = "CZ";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5412345123453";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";            

            //  End NAD Group 1
            result.NADLoop.Add(nadLoop1);

            //  Begin NAD Group 2
            var nadLoop2 = new Loop_NAD_IFTMIN();

            //  Carrier identified with GLN 5411234512309
            nadLoop2.NAD = new NAD();
            nadLoop2.NAD.Partyqualifier_01 = "CA";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5411234512309";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  End NAD Group 2
            result.NADLoop.Add(nadLoop2);

            //  Begin NAD Group 3
            var nadLoop3 = new Loop_NAD_IFTMIN();

            //  Consignee identified with GLN 5411234444402
            nadLoop3.NAD = new NAD();
            nadLoop3.NAD.Partyqualifier_01 = "CN";
            nadLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5411234444402";
            nadLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  End NAD Group 3
            result.NADLoop.Add(nadLoop3);

            //  Begin NAD Group 4
            var nadLoop4 = new Loop_NAD_IFTMIN();

            //  Delivery party identified with GLN 5412345145660
            nadLoop4.NAD = new NAD();
            nadLoop4.NAD.Partyqualifier_01 = "DP";
            nadLoop4.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop4.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5412345145660";
            nadLoop4.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  End NAD Group 4
            result.NADLoop.Add(nadLoop4);

            //  Repeating GID Groups
            result.GIDLoop = new List<Loop_GID_IFTMIN>();

            //  Begin GID Group
            var gidLoop1 = new Loop_GID_IFTMIN();

            //  First occurrence of goods in one returnable pallet with 14 packages
            gidLoop1.GID = new GID();
            gidLoop1.GID.Goodsitemnumber_01 = "1";
            gidLoop1.GID.NUMBERANDTYPEOFPACKAGES_02 = new C213();
            gidLoop1.GID.NUMBERANDTYPEOFPACKAGES_02.Numberofpackages_01 = "1";
            gidLoop1.GID.NUMBERANDTYPEOFPACKAGES_02.Typeofpackagesidentification_02 = "09";
            gidLoop1.GID.NUMBERANDTYPEOFPACKAGES_02.Codelistresponsibleagencycoded_04 = "9";
            gidLoop1.GID.NUMBERANDTYPEOFPACKAGES_03 = new C213();
            gidLoop1.GID.NUMBERANDTYPEOFPACKAGES_03.Numberofpackages_01 = "14";
            gidLoop1.GID.NUMBERANDTYPEOFPACKAGES_03.Typeofpackagesidentification_02 = "PK";

            //  The goods are foods stuffs 
            gidLoop1.HAN = new HAN();
            gidLoop1.HAN.HANDLINGINSTRUCTIONS_01 = new C524();
            gidLoop1.HAN.HANDLINGINSTRUCTIONS_01.Handlinginstructionscoded_01 = "EAT";
            gidLoop1.HAN.HANDLINGINSTRUCTIONS_01.Codelistresponsibleagencycoded_03 = "9";

            //  Transport temperature 0 degrees Celsius
            gidLoop1.TMP = new TMP();
            gidLoop1.TMP.Temperaturequalifier_01 = "2";
            gidLoop1.TMP.TEMPERATURESETTING_02 = new C239();
            gidLoop1.TMP.TEMPERATURESETTING_02.Temperaturesetting_01 = "000";
            gidLoop1.TMP.TEMPERATURESETTING_02.Measureunitqualifier_02 = "CEL";

            //  The range of temperature must be between –5 and 5 degrees Celsius
            gidLoop1.RNG = new RNG();
            gidLoop1.RNG.Rangetypequalifier_01 = "5";
            gidLoop1.RNG.RANGE_02 = new C280();
            gidLoop1.RNG.RANGE_02.Measureunitqualifier_01 = "CEL";
            gidLoop1.RNG.RANGE_02.Rangeminimum_02 = "-5";
            gidLoop1.RNG.RANGE_02.Rangemaximum_03 = "5";

            //  Repeating MOA
            gidLoop1.MOA = new List<MOA>();

            //  Declared valued of the carriage 45.000 EUR
            var moaGid1 = new MOA();
            moaGid1.MONETARYAMOUNT_01 = new C516();
            moaGid1.MONETARYAMOUNT_01.Monetaryamounttypequalifier_01 = "44";
            moaGid1.MONETARYAMOUNT_01.Monetaryamount_02 = "45000";
            moaGid1.MONETARYAMOUNT_01.Currencycoded_03 = "EUR";
            gidLoop1.MOA.Add(moaGid1);

            //  Repeating PIA
            gidLoop1.PIA = new List<PIA>();

            //  Product identification of the goods using GTIN 5410738377117
            var piaGid1 = new PIA();
            piaGid1.Productidfunctionqualifier_01 = "5";
            piaGid1.ITEMNUMBERIDENTIFICATION_02 = new C212();
            piaGid1.ITEMNUMBERIDENTIFICATION_02.Itemnumber_01 = "5410738377117";
            piaGid1.ITEMNUMBERIDENTIFICATION_02.Itemnumbertypecoded_02 = "SRV";
            gidLoop1.PIA.Add(piaGid1);

            //  Repeating MEA Groups
            gidLoop1.MEALoop = new List<Loop_MEA_IFTMIN>();

            //  Begin MEA GID Group
            var meaGid1 = new Loop_MEA_IFTMIN();

            //  Gross weight of returnable pallet plus 14 packages on the pallet is 250 Kilograms
            meaGid1.MEA = new MEA();
            meaGid1.MEA.Measurementapplicationqualifier_01 = "AAE";
            meaGid1.MEA.MEASUREMENTDETAILS_02 = new C502();
            meaGid1.MEA.MEASUREMENTDETAILS_02.Measurementdimensioncoded_01 = "X7E";
            meaGid1.MEA.VALUERANGE_03 = new C174();
            meaGid1.MEA.VALUERANGE_03.Measureunitqualifier_01 = "KGM";
            meaGid1.MEA.VALUERANGE_03.Measurementvalue_02 = "250";

            //  End MEA GID Group
            gidLoop1.MEALoop.Add(meaGid1);

            //  Repeating PCI Groups
            gidLoop1.PCILoop = new List<Loop_PCI_IFTMIN>();

            //  Begin PCI GID Group
            var pciGid1 = new Loop_PCI_IFTMIN();

            //  Marked with the EAN.UCC serial shipping container code
            pciGid1.PCI = new PCI();
            pciGid1.PCI.Markinginstructionscoded_01 = "33E";

            //  Repeating GIN
            pciGid1.GIN = new List<GIN>();

            //  Identification of marked serial shipping container code
            var ginPci1 = new GIN();
            ginPci1.Identitynumberqualifier_01 = "BJ";
            ginPci1.IDENTITYNUMBERRANGE_02 = new C208();
            ginPci1.IDENTITYNUMBERRANGE_02.Identitynumber_01 = "354123450000000014";
            pciGid1.GIN.Add(ginPci1);

            //  End PCI GID Group
            gidLoop1.PCILoop.Add(pciGid1);

            //  End GID Group
            result.GIDLoop.Add(gidLoop1);

            return result;
        }
    }
}
