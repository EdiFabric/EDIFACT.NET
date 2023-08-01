using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Templates.EdifactD96A;
using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.IFTSTA
{
    class Program
    {
        static void Main(string[] args)
        {
             SerialKey.Set(Config.TrialSerialKey);
            Read();
            Write();
        }

        /// <summary>
        /// Read Transport Status
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Eancom\TransportStatus.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSIFTSTA>();

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
        /// Write Transport Status
        /// </summary>
        static void Write()
        {
            var transaction = BuildTransportStatus("ME000021");

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
        /// Build transport status.
        /// Original from https://www.gs1.org/sites/default/files/docs/eancom/s4/iftsta.pdf
        /// </summary>
        static TSIFTSTA BuildTransportStatus(string controlNumber)
        {
            var result = new TSIFTSTA();

            //  Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "IFTSTA";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "96A";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            //  Transport status number 95-455
            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentmessagenamecoded_01 = "44";
            result.BGM.Documentmessagenumber_02 = "95-455";
            result.BGM.Messagefunctioncoded_03 = "9";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  Message date/time 4th February 2002
            var dtm1 = new DTM();
            dtm1.DATETIMEPERIOD_01 = new C507();
            dtm1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "137";
            dtm1.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020204";
            dtm1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            result.DTM.Add(dtm1);

            //  Repeating NAD Groups
            result.NADLoop = new List<Loop_NAD_IFTSTA>();

            //  Begin NAD Group 1
            var nadLoop1 = new Loop_NAD_IFTSTA();

            //  Freight forwarder identified with GLN 5422331123459
            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.Partyqualifier_01 = "FW";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5422331123459";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  End NAD Group 1
            result.NADLoop.Add(nadLoop1);

            //  Begin NAD Group 2
            var nadLoop2 = new Loop_NAD_IFTSTA();

            //  Consignor identified with GLN 5412345123453
            nadLoop2.NAD = new NAD();
            nadLoop2.NAD.Partyqualifier_01 = "CZ";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5412345123453";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";

            //  End NAD Group 2
            result.NADLoop.Add(nadLoop2);

            //  Repeating CNI Groups
            result.CNILoop = new List<Loop_CNI_IFTSTA>();

            //  Begin CNI Group 1
            var cniLoop1 = new Loop_CNI_IFTSTA();

            //  First consignment number 4215A
            cniLoop1.CNI = new CNI();
            cniLoop1.CNI.Consolidationitemnumber_01 = "1";
            cniLoop1.CNI.DOCUMENTMESSAGEDETAILS_02 = new C503();
            cniLoop1.CNI.DOCUMENTMESSAGEDETAILS_02.Documentmessagenumber_01 = "4215A";

            //  Repeating STS Groups
            cniLoop1.STSLoop = new List<Loop_STS_IFTSTA>();

            //  Begin STS Group
            var stsCni1 = new Loop_STS_IFTSTA();

            //  Status of the consignment: ‘delivered’
            stsCni1.STS = new STS();
            stsCni1.STS.STATUSTYPE_01 = new C601();
            stsCni1.STS.STATUSTYPE_01.Statustypecoded_01 = "1";
            stsCni1.STS.STATUSEVENT_02 = new C555();
            stsCni1.STS.STATUSEVENT_02.Statuseventcoded_01 = "21";

            //  Repeating RFF
            stsCni1.RFF = new List<RFF>();

            //  Reference is a delivery note number ‘5/2334'
            var rffSts1 = new RFF();
            rffSts1.REFERENCE_01 = new C506();
            rffSts1.REFERENCE_01.Referencequalifier_01 = "DQ";
            rffSts1.REFERENCE_01.Referencenumber_02 = "5/2334";
            stsCni1.RFF.Add(rffSts1);

            //  Repeating DTM
            stsCni1.DTM = new List<DTM>();

            //  Date/time of the status change 1st February 2002 at 14:50
            var dtmSts1 = new DTM();
            dtmSts1.DATETIMEPERIOD_01 = new C507();
            dtmSts1.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "334";
            dtmSts1.DATETIMEPERIOD_01.Datetimeperiod_02 = "200202011450";
            dtmSts1.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "203";
            stsCni1.DTM.Add(dtmSts1);

            //  Repeating NAD
            stsCni1.NAD = new List<NAD>();

            //  Delivery party identified with GLN 5411111123451
            var nadSts1 = new NAD();
            nadSts1.Partyqualifier_01 = "DP";
            nadSts1.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadSts1.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01 = "5411111123451";
            nadSts1.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycoded_03 = "9";
            stsCni1.NAD.Add(nadSts1);

            //  End STS Group
            cniLoop1.STSLoop.Add(stsCni1);

            //  End CNI Group 1 
            result.CNILoop.Add(cniLoop1);

            //  Begin CNI Group 2
            var cniLoop2 = new Loop_CNI_IFTSTA();

            //  Second consignment number 5122C
            cniLoop2.CNI = new CNI();
            cniLoop2.CNI.Consolidationitemnumber_01 = "2";
            cniLoop2.CNI.DOCUMENTMESSAGEDETAILS_02 = new C503();
            cniLoop2.CNI.DOCUMENTMESSAGEDETAILS_02.Documentmessagenumber_01 = "5122C";

            //  Repeating STS Groups
            cniLoop2.STSLoop = new List<Loop_STS_IFTSTA>();

            //  Begin STS Group
            var stsCni2 = new Loop_STS_IFTSTA();

            //  Status of the consignment: ‘Goods on their way’
            stsCni2.STS = new STS();
            stsCni2.STS.STATUSTYPE_01 = new C601();
            stsCni2.STS.STATUSTYPE_01.Statustypecoded_01 = "1";
            stsCni2.STS.STATUSEVENT_02 = new C555();
            stsCni2.STS.STATUSEVENT_02.Statuseventcoded_01 = "31";

            //  Repeating DTM
            stsCni2.DTM = new List<DTM>();

            //  Date/time of the next status 7th February 2002 
            var dtmSts2 = new DTM();
            dtmSts2.DATETIMEPERIOD_01 = new C507();
            dtmSts2.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "40E";
            dtmSts2.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020207";
            dtmSts2.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            stsCni2.DTM.Add(dtmSts2);

            //  End STS Group
            cniLoop2.STSLoop.Add(stsCni2);

            //  End CNI Group 2 
            result.CNILoop.Add(cniLoop2);

            //  Begin CNI Group 3
            var cniLoop3 = new Loop_CNI_IFTSTA();

            //  Third consignment number 5145E
            cniLoop3.CNI = new CNI();
            cniLoop3.CNI.Consolidationitemnumber_01 = "3";
            cniLoop3.CNI.DOCUMENTMESSAGEDETAILS_02 = new C503();
            cniLoop3.CNI.DOCUMENTMESSAGEDETAILS_02.Documentmessagenumber_01 = "5145E";

            //  Repeating STS Groups
            cniLoop3.STSLoop = new List<Loop_STS_IFTSTA>();

            //  Begin STS Group
            var stsCni3 = new Loop_STS_IFTSTA();

            //  The consignment was customs refused and no recipient contact information
            stsCni3.STS = new STS();
            stsCni3.STS.STATUSTYPE_01 = new C601();
            stsCni3.STS.STATUSTYPE_01.Statustypecoded_01 = "1";
            stsCni3.STS.STATUSEVENT_02 = new C555();
            stsCni3.STS.STATUSEVENT_02.Statuseventcoded_01 = "17";
            stsCni3.STS.STATUSREASON_03 = new C556();
            stsCni3.STS.STATUSREASON_03.Statusreasoncoded_01 = "39";

            //  Repeating DTM
            stsCni3.DTM = new List<DTM>();

            //  The refusal took place 15th January 2002
            var dtmSts3 = new DTM();
            dtmSts3.DATETIMEPERIOD_01 = new C507();
            dtmSts3.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "334";
            dtmSts3.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020115";
            dtmSts3.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            stsCni3.DTM.Add(dtmSts3);

            //  Identify customs in Heathrow airport as the location of the status
            stsCni3.LOC = new LOC();
            stsCni3.LOC.Placelocationqualifier_01 = "16E";
            stsCni3.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            stsCni3.LOC.LOCATIONIDENTIFICATION_02.Placelocation_04 = "H.MCUSTOMS AND EXCISE LONDON HEATHROW AIRPORT";

            //  End STS Group
            cniLoop3.STSLoop.Add(stsCni3);

            //  End CNI Group 3
            result.CNILoop.Add(cniLoop3);

            //  Begin CNI Group 4
            var cniLoop4 = new Loop_CNI_IFTSTA();

            //  Fourth consignment number 7655S
            cniLoop4.CNI = new CNI();
            cniLoop4.CNI.Consolidationitemnumber_01 = "4";
            cniLoop4.CNI.DOCUMENTMESSAGEDETAILS_02 = new C503();
            cniLoop4.CNI.DOCUMENTMESSAGEDETAILS_02.Documentmessagenumber_01 = "7655S";

            //  Repeating STS Groups
            cniLoop4.STSLoop = new List<Loop_STS_IFTSTA>();

            //  Begin STS Group 1
            var stsCni4 = new Loop_STS_IFTSTA();

            //  The following goods item are lost 
            stsCni4.STS = new STS();
            stsCni4.STS.STATUSTYPE_01 = new C601();
            stsCni4.STS.STATUSTYPE_01.Statustypecoded_01 = "1";
            stsCni4.STS.STATUSEVENT_02 = new C555();
            stsCni4.STS.STATUSEVENT_02.Statuseventcoded_01 = "49";
           
            //  Repeating DTM
            stsCni4.DTM = new List<DTM>();

            //  Date/time reported lost 28th January 2002
            var dtmSts4 = new DTM();
            dtmSts4.DATETIMEPERIOD_01 = new C507();
            dtmSts4.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "334";
            dtmSts4.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020148";
            dtmSts4.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            stsCni4.DTM.Add(dtmSts4);

            //  Repeating GID Groups
            stsCni4.GIDLoop = new List<Loop_GID_IFTSTA>();

            //  Begin GID STS Group
            var gidSts1 = new Loop_GID_IFTSTA();

            //  One carton box, first goods item
            gidSts1.GID = new GID();
            gidSts1.GID.Goodsitemnumber_01 = "1";
            gidSts1.GID.NUMBERANDTYPEOFPACKAGES_02 = new C213();
            gidSts1.GID.NUMBERANDTYPEOFPACKAGES_02.Numberofpackages_01 = "1";
            gidSts1.GID.NUMBERANDTYPEOFPACKAGES_02.Typeofpackagesidentification_02 = "CT";

            //  Repeating PCI GID Groups
            gidSts1.PCILoop = new List<Loop_PCI_IFTSTA>();

            //  Begin PCI GID Group
            var pciGid1 = new Loop_PCI_IFTSTA();

            //  EAN.UCC SSCC 
            pciGid1.PCI = new PCI();
            pciGid1.PCI.Markinginstructionscoded_01 = "33E";

            //  Repeating GIN
            pciGid1.GIN = new List<GIN>();

            //  354107380000001068
            var ginPci1 = new GIN();
            ginPci1.Identitynumberqualifier_01 = "BJ";
            ginPci1.IDENTITYNUMBERRANGE_02 = new C208();
            ginPci1.IDENTITYNUMBERRANGE_02.Identitynumber_01 = "354107380000001068";
            pciGid1.GIN.Add(ginPci1);

            //  End PCI GID Group
            gidSts1.PCILoop.Add(pciGid1);

            //  End GID STS Group
            stsCni4.GIDLoop.Add(gidSts1);

            //  End STS Group 1
            cniLoop4.STSLoop.Add(stsCni4);

            //  Begin STS Group 2
            var stsCni5 = new Loop_STS_IFTSTA();

            //  The following goods items have been delivered
            stsCni5.STS = new STS();
            stsCni5.STS.STATUSTYPE_01 = new C601();
            stsCni5.STS.STATUSTYPE_01.Statustypecoded_01 = "1";
            stsCni5.STS.STATUSEVENT_02 = new C555();
            stsCni5.STS.STATUSEVENT_02.Statuseventcoded_01 = "21";

            //  Repeating DTM
            stsCni5.DTM = new List<DTM>();

            //  Delivered 28th January 2002
            var dtmSts5 = new DTM();
            dtmSts5.DATETIMEPERIOD_01 = new C507();
            dtmSts5.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "334";
            dtmSts5.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020148";
            dtmSts5.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            stsCni5.DTM.Add(dtmSts5);

            //  Repeating GID Groups
            stsCni5.GIDLoop = new List<Loop_GID_IFTSTA>();

            //  Begin GID STS Group
            var gidSts2 = new Loop_GID_IFTSTA();

            //  One cardboard box, second goods item
            gidSts2.GID = new GID();
            gidSts2.GID.Goodsitemnumber_01 = "2";
            gidSts2.GID.NUMBERANDTYPEOFPACKAGES_02 = new C213();
            gidSts2.GID.NUMBERANDTYPEOFPACKAGES_02.Numberofpackages_01 = "1";
            gidSts2.GID.NUMBERANDTYPEOFPACKAGES_02.Typeofpackagesidentification_02 = "CT";

            //  Repeating PCI GID Groups
            gidSts2.PCILoop = new List<Loop_PCI_IFTSTA>();

            //  Begin PCI GID Group
            var pciGid2 = new Loop_PCI_IFTSTA();

            //  Box marked with EAN.UCC SSCC
            pciGid2.PCI = new PCI();
            pciGid2.PCI.Markinginstructionscoded_01 = "33E";

            //  Repeating GIN
            pciGid2.GIN = new List<GIN>();

            //  EAN.UCC SSCC 354107380000001051
            var ginPci2 = new GIN();
            ginPci2.Identitynumberqualifier_01 = "BJ";
            ginPci2.IDENTITYNUMBERRANGE_02 = new C208();
            ginPci2.IDENTITYNUMBERRANGE_02.Identitynumber_01 = "354107380000001051";
            pciGid2.GIN.Add(ginPci2);

            //  End PCI GID Group
            gidSts2.PCILoop.Add(pciGid2);

            //  End GID STS Group
            stsCni5.GIDLoop.Add(gidSts2);

            //  End STS Group 2
            cniLoop4.STSLoop.Add(stsCni5);

            //  Begin STS Group 3
            var stsCni6 = new Loop_STS_IFTSTA();

            //  Consignment delivered
            stsCni6.STS = new STS();
            stsCni6.STS.STATUSTYPE_01 = new C601();
            stsCni6.STS.STATUSTYPE_01.Statustypecoded_01 = "1";
            stsCni6.STS.STATUSEVENT_02 = new C555();
            stsCni6.STS.STATUSEVENT_02.Statuseventcoded_01 = "21";

            //  Repeating DTM
            stsCni6.DTM = new List<DTM>();

            //  Delivered 28th January 2002
            var dtmSts6 = new DTM();
            dtmSts6.DATETIMEPERIOD_01 = new C507();
            dtmSts6.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 = "334";
            dtmSts6.DATETIMEPERIOD_01.Datetimeperiod_02 = "20020148";
            dtmSts6.DATETIMEPERIOD_01.Datetimeperiodformatqualifier_03 = "102";
            stsCni6.DTM.Add(dtmSts6);

            //  Repeating GID Groups
            stsCni6.GIDLoop = new List<Loop_GID_IFTSTA>();

            //  Begin GID STS Group
            var gidSts3 = new Loop_GID_IFTSTA();

            //  One returnable pallet, third goods item
            gidSts3.GID = new GID();
            gidSts3.GID.Goodsitemnumber_01 = "3";
            gidSts3.GID.NUMBERANDTYPEOFPACKAGES_02 = new C213();
            gidSts3.GID.NUMBERANDTYPEOFPACKAGES_02.Numberofpackages_01 = "1";
            gidSts3.GID.NUMBERANDTYPEOFPACKAGES_02.Typeofpackagesidentification_02 = "09";
            gidSts3.GID.NUMBERANDTYPEOFPACKAGES_02.Codelistresponsibleagencycoded_04 = "9";

            //  Repeating PCI GID Groups
            gidSts3.PCILoop = new List<Loop_PCI_IFTSTA>();

            //  Begin PCI GID Group
            var pciGid3 = new Loop_PCI_IFTSTA();

            //  Pallet marked with EAN.UCC SSCC
            pciGid3.PCI = new PCI();
            pciGid3.PCI.Markinginstructionscoded_01 = "33E";

            //  Repeating GIN
            pciGid3.GIN = new List<GIN>();

            //  EAN.UCC SSCC 354123451234567892
            var ginPci3 = new GIN();
            ginPci3.Identitynumberqualifier_01 = "BJ";
            ginPci3.IDENTITYNUMBERRANGE_02 = new C208();
            ginPci3.IDENTITYNUMBERRANGE_02.Identitynumber_01 = "354123451234567892";
            pciGid3.GIN.Add(ginPci3);

            //  End PCI GID Group
            gidSts3.PCILoop.Add(pciGid3);

            //  End GID STS Group
            stsCni6.GIDLoop.Add(gidSts3);

            //  End STS Group 3
            cniLoop4.STSLoop.Add(stsCni6);

            //  End CNI Group 4
            result.CNILoop.Add(cniLoop4);

            return result;
        }
    }
}

