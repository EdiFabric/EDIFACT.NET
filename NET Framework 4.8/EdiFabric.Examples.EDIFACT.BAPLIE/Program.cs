using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Templates.EdifactD13B;
using EdiFabric.Examples.EDIFACT.Common;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.BAPLIE
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
        /// Read Bayplan
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\Bayplan.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, TypeFactory))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSBAPLIE>();

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
            if (unh.MessageIdentifier_02.MessageReleaseNumber_03 == "13B" &&
                unh.MessageIdentifier_02.MessageType_01 == "BAPLIE")
                return typeof(TSBAPLIE).GetTypeInfo();

            throw new System.Exception(string.Format("Transaction {0} for version {1} is not supported.",
                unh.MessageIdentifier_02.MessageType_01, unh.MessageIdentifier_02.MessageVersionNumber_02 + unh.MessageIdentifier_02.MessageReleaseNumber_03));
        }

        /// <summary>
        /// Write Bayplan
        /// </summary>
        static void Write()
        {
            var transaction = BuildBayplan("M-EX1/1");

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
        /// Build bayplan.
        /// Original from http://www.smdg.org/assets/assets/BAPLIE3.1.1-02.pdf?
        /// </summary>
        static TSBAPLIE BuildBayplan(string controlNumber)
        {
            var result = new TSBAPLIE();

            //  Message header (ref id = M-EX1/1)
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "BAPLIE";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "13B";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";
            result.UNH.MessageIdentifier_02.AssociationAssignedCode_05 = "SMDG31";

            //  Partial BAPLIE(code 659), loaded containers only(LOADONLY), final stage(code 38)
            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentnamecode_01 = "659";
            result.BGM.DOCUMENTMESSAGENAME_01.Codelistresponsibleagencycode_03 = "LOADONLY";
            result.BGM.DOCUMENTMESSAGEIDENTIFICATION_02 = new C106();
            result.BGM.DOCUMENTMESSAGEIDENTIFICATION_02.Documentidentifier_01 = "M-EX1/1";
            result.BGM.Responsetypecode_04 = "38";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  Date/time (UTC) when message has been prepared
            var dtm1 = new DTM();
            dtm1.DATETIMEPERIOD_01 = new C507();
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "137";
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodtext_02 = "201304130959";
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "203";
            result.DTM.Add(dtm1);

            //  Repeating NAD Groups
            result.NADLoop = new List<Loop_NAD_BAPLIE>();

            //  Begin NAD Group
            var nadLoop1 = new Loop_NAD_BAPLIE();

            //  Function of sender (terminal)
            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.Partyfunctioncodequalifier_01 = "WZ";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "HNE";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "TERMINALS";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycode_03 = "306";

            //  End NAD Group
            result.NADLoop.Add(nadLoop1);

            //  Repeating TDT Groups
            result.TDTLoop = new List<Loop_TDT_BAPLIE>();

            //  Begin TDT Group
            var tdtLoop1 = new Loop_TDT_BAPLIE();

            //  Discharge voyage number, vessel operator, vessel identification
            tdtLoop1.TDT = new TDT();
            tdtLoop1.TDT.Transportstagecodequalifier_01 = "20";
            tdtLoop1.TDT.Meansoftransportjourneyidentifier_02 = "123W45";
            tdtLoop1.TDT.CARRIER_05 = new C040();
            tdtLoop1.TDT.CARRIER_05.Carrieridentifier_01 = "HLC";
            tdtLoop1.TDT.CARRIER_05.Codelistidentificationcode_02 = "LINES";
            tdtLoop1.TDT.CARRIER_05.Codelistresponsibleagencycode_03 = "306";
            tdtLoop1.TDT.EXCESSTRANSPORTATIONINFORMATION_07 = new C401();
            tdtLoop1.TDT.EXCESSTRANSPORTATIONINFORMATION_07.Excesstransportationreasoncode_01 = "9354351";
            tdtLoop1.TDT.EXCESSTRANSPORTATIONINFORMATION_07.Excesstransportationresponsibilitycode_02 = "11";
            tdtLoop1.TDT.EXCESSTRANSPORTATIONINFORMATION_07.Customershipmentauthorisationidentifier_03 = "ANINA";

            //  Loading voyage number
            tdtLoop1.RFF = new RFF();
            tdtLoop1.RFF.REFERENCE_01 = new C506();
            tdtLoop1.RFF.REFERENCE_01.Referencecodequalifier_01 = "VON";
            tdtLoop1.RFF.REFERENCE_01.Referenceidentifier_02 = "123E38";

            //  Repeating LOC TDT Groups
            tdtLoop1.LOCLoop = new List<Loop_LOC_BAPLIE_2>();

            //  Begin LOC TDT Group 1
            var locTdtLoop1 = new Loop_LOC_BAPLIE_2();

            //  Place of departure
            locTdtLoop1.LOC = new LOC();
            locTdtLoop1.LOC.Locationfunctioncodequalifier_01 = "5";
            locTdtLoop1.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            locTdtLoop1.LOC.LOCATIONIDENTIFICATION_02.Locationidentifier_01 = "BEANR";

            //  Repeating DTM
            locTdtLoop1.DTM = new List<DTM>();

            //  Actual departure time
            var dtmLoc1 = new DTM();
            dtmLoc1.DATETIMEPERIOD_01 = new C507();
            dtmLoc1.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "136";
            dtmLoc1.DATETIMEPERIOD_01.Dateortimeorperiodtext_02 = "201304301048";
            dtmLoc1.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "203";
            locTdtLoop1.DTM.Add(dtmLoc1);

            //  End LOC TDT Group 1
            tdtLoop1.LOCLoop.Add(locTdtLoop1);

            //  Begin LOC TDT Group 2
            var locTdtLoop2 = new Loop_LOC_BAPLIE_2();

            //  Next port of call
            locTdtLoop2.LOC = new LOC();
            locTdtLoop2.LOC.Locationfunctioncodequalifier_01 = "61";
            locTdtLoop2.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            locTdtLoop2.LOC.LOCATIONIDENTIFICATION_02.Locationidentifier_01 = "FRLEH";

            //  Repeating DTM
            locTdtLoop2.DTM = new List<DTM>();

            //  Estimated arrival time
            var dtmLoc2 = new DTM();
            dtmLoc2.DATETIMEPERIOD_01 = new C507();
            dtmLoc2.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "178";
            dtmLoc2.DATETIMEPERIOD_01.Dateortimeorperiodtext_02 = "201305012100";
            dtmLoc2.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "203";
            locTdtLoop2.DTM.Add(dtmLoc2);

            //  End LOC TDT Group 2
            tdtLoop1.LOCLoop.Add(locTdtLoop2);

            //  End TDT Group
            result.TDTLoop.Add(tdtLoop1);

            //  End of message header
            result.UNS = new UNS();
            result.UNS.Sectionidentification_01 = "D";

            //  Repeating LOC Groups
            result.LOCLoop = new List<Loop_LOC_BAPLIE>();

            //  Begin LOC Group 1
            var locLoop1 = new Loop_LOC_BAPLIE();

            //  Stowage location (used)
            locLoop1.LOC = new LOC();
            locLoop1.LOC.Locationfunctioncodequalifier_01 = "147";
            locLoop1.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            locLoop1.LOC.LOCATIONIDENTIFICATION_02.Locationidentifier_01 = "0200688";
            locLoop1.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "9711";
            locLoop1.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "5";

            //  Repeating EQD Groups
            locLoop1.EQDLoop = new List<Loop_EQD_BAPLIE>();

            //  Begin EQD Group
            var eqdLocLoop1 = new Loop_EQD_BAPLIE();

            //  40' open top container
            eqdLocLoop1.EQD = new EQD();
            eqdLocLoop1.EQD.Equipmenttypecodequalifier_01 = "CN";
            eqdLocLoop1.EQD.EQUIPMENTIDENTIFICATION_02 = new C237();
            eqdLocLoop1.EQD.EQUIPMENTIDENTIFICATION_02.Equipmentidentifier_01 = "SUDU1234569";
            eqdLocLoop1.EQD.EQUIPMENTIDENTIFICATION_02.Codelistidentificationcode_02 = "6346";
            eqdLocLoop1.EQD.EQUIPMENTIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "5";
            eqdLocLoop1.EQD.EQUIPMENTSIZEANDTYPE_03 = new C224();
            eqdLocLoop1.EQD.EQUIPMENTSIZEANDTYPE_03.Equipmentsizeandtypedescriptioncode_01 = "42U0";
            eqdLocLoop1.EQD.EQUIPMENTSIZEANDTYPE_03.Codelistidentificationcode_02 = "6346";
            eqdLocLoop1.EQD.EQUIPMENTSIZEANDTYPE_03.Codelistresponsibleagencycode_03 = "5";
            eqdLocLoop1.EQD.Fulloremptyindicatorcode_06 = "5";

            //  Repeating NAD
            eqdLocLoop1.NAD = new List<NAD>();

            //  Container operator (HSD)
            var nadEqd1 = new NAD();
            nadEqd1.Partyfunctioncodequalifier_01 = "CF";
            nadEqd1.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadEqd1.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "HSD";
            nadEqd1.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "LINES";
            nadEqd1.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycode_03 = "306";
            eqdLocLoop1.NAD.Add(nadEqd1);

            //  Repeating MEA
            eqdLocLoop1.MEA = new List<MEA>();

            //  Gross weight (22.6 t)
            var meaEqd1 = new MEA();
            meaEqd1.Measurementpurposecodequalifier_01 = "AAE";
            meaEqd1.MEASUREMENTDETAILS_02 = new C502();
            meaEqd1.MEASUREMENTDETAILS_02.Measuredattributecode_01 = "AET";
            meaEqd1.VALUERANGE_03 = new C174();
            meaEqd1.VALUERANGE_03.Measurementunitcode_01 = "KGM";
            meaEqd1.VALUERANGE_03.Measure_02 = "22600";
            eqdLocLoop1.MEA.Add(meaEqd1);

            //  Repeating DIM
            eqdLocLoop1.DIM = new List<DIM>();

            //  Overheight (92 cm)
            var dimEqd1 = new DIM();
            dimEqd1.Dimensiontypecodequalifier_01 = "13";
            dimEqd1.DIMENSIONS_02 = new C211();
            dimEqd1.DIMENSIONS_02.Measurementunitcode_01 = "CMT";
            dimEqd1.DIMENSIONS_02.Heightmeasure_04 = "92";
            eqdLocLoop1.DIM.Add(dimEqd1);

            //  End EQD Group
            locLoop1.EQDLoop.Add(eqdLocLoop1);

            //  Control total
            locLoop1.CNT = new CNT();
            locLoop1.CNT.CONTROL_01 = new C270();
            locLoop1.CNT.CONTROL_01.Controlqualifier_01 = "8";
            locLoop1.CNT.CONTROL_01.Controlvalue_02 = "1";

            //  End LOC Group 1
            result.LOCLoop.Add(locLoop1);

            //  Begin LOC Group 2
            var locLoop2 = new Loop_LOC_BAPLIE();

            //  Stowage location (blocked)
            locLoop2.LOC = new LOC();
            locLoop2.LOC.Locationfunctioncodequalifier_01 = "147";
            locLoop2.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            locLoop2.LOC.LOCATIONIDENTIFICATION_02.Locationidentifier_01 = "0200690";
            locLoop2.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "9711";
            locLoop2.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "5";

            //  Repeating FTX
            locLoop2.FTX = new List<FTX>();

            //  Lost slot
            var ftxLoc1 = new FTX();
            ftxLoc1.Textsubjectcodequalifier_01 = "AGW";
            ftxLoc1.TEXTREFERENCE_03 = new C107();
            ftxLoc1.TEXTREFERENCE_03.Freetextdescriptioncode_01 = "LOST";
            ftxLoc1.TEXTREFERENCE_03.Codelistidentificationcode_02 = "STOWLOC";
            ftxLoc1.TEXTREFERENCE_03.Codelistresponsibleagencycode_03 = "306";
            locLoop2.FTX.Add(ftxLoc1);

            //  Equipment causing lost slot
            locLoop2.RFF = new RFF();
            locLoop2.RFF.REFERENCE_01 = new C506();
            locLoop2.RFF.REFERENCE_01.Referencecodequalifier_01 = "EQ";
            locLoop2.RFF.REFERENCE_01.Referenceidentifier_02 = "SUDU123459";

            //  Control total
            locLoop2.CNT = new CNT();
            locLoop2.CNT.CONTROL_01 = new C270();
            locLoop2.CNT.CONTROL_01.Controlqualifier_01 = "8";
            locLoop2.CNT.CONTROL_01.Controlvalue_02 = "0";

            //  End LOC Group 2
            result.LOCLoop.Add(locLoop2);

            return result;
        }
    }
}
