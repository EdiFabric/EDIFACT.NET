using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Templates.EdifactD03B;
using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.PAXLST
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
        /// Read Passenger List
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PassengerList.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSPAXLST>();

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
        /// Write Passenger List
        /// </summary>
        static void Write()
        {
            var transaction = BuildPassengerList("PAXLST16");

            using (var stream = new MemoryStream())
            {
                using (var writer = new EdifactWriter(stream))
                {
                    writer.Write(SegmentBuilders.BuildUnb("1"));
                    writer.Write(SegmentBuilders.BuildUng("16", "PAXLST"));
                    writer.Write(transaction);
                }

                var ediString = stream.LoadToString();
            }
        }

        /// <summary>
        /// Build passenger list.
        /// Original from https://www.cbp.gov/sites/default/files/documents/paxlst_012_36_3.txt
        /// </summary>
        static TSPAXLST BuildPassengerList(string controlNumber)
        {
            var result = new TSPAXLST();

            //  Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "PAXLST";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "03B";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentnamecode_01 = "10";
            result.BGM.DOCUMENTMESSAGEIDENTIFICATION_02 = new C106();
            result.BGM.DOCUMENTMESSAGEIDENTIFICATION_02.Documentidentifier_01 = "LOCKKH04103101";
            result.BGM.Messagefunctioncode_03 = "4";            

            result.RFF = new RFF();
            result.RFF.REFERENCE_01 = new C506();
            result.RFF.REFERENCE_01.Referencecodequalifier_01 = "RFA";
            result.RFF.REFERENCE_01.Referenceidentifier_02 = "03";

            //  Repeating TDT Groups
            result.TDTLoop = new List<Loop_TDT_PAXLST>();

            //  Begin TDT Group 
            var tdtLoop1 = new Loop_TDT_PAXLST();

            tdtLoop1.TDT = new TDT();
            tdtLoop1.TDT.Transportstagecodequalifier_01 = "11";
            tdtLoop1.TDT.CARRIER_05 = new C040();
            tdtLoop1.TDT.CARRIER_05.Carrieridentifier_01 = "LOCK";
            tdtLoop1.TDT.CARRIER_05.Codelistidentificationcode_02 = "172";

            tdtLoop1.DTM = new DTM();
            tdtLoop1.DTM.DATETIMEPERIOD_01 = new C507();
            tdtLoop1.DTM.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "132";
            tdtLoop1.DTM.DATETIMEPERIOD_01.Dateortimeorperiodtext_02 = "20041230";
            tdtLoop1.DTM.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "102";

            //  End TDT Group 
            result.TDTLoop.Add(tdtLoop1);

            //  Repeating RFF Groups
            result.NADLoop2 = new List<Loop_NAD_PAXLST_2>();

            //  Begin NAD Group 1
            var nadLoop1 = new Loop_NAD_PAXLST_2();

            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.Partyfunctioncodequalifier_01 = "VW";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "0000041153";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "109";
            nadLoop1.NAD.PARTYNAME_04 = new C080();
            nadLoop1.NAD.PARTYNAME_04.Partyname_01 = "AOMAD";
            nadLoop1.NAD.PARTYNAME_04.Partyname_02 = "CHRIS";
            nadLoop1.NAD.PARTYNAME_04.Partynameformatcode_06 = "1";
            nadLoop1.NAD.STREET_05 = new C059();
            nadLoop1.NAD.STREET_05.Streetandnumberorpostofficeboxidentifier_01 = "11107 SUNSET HILLS ROAD";
            nadLoop1.NAD.Cityname_06 = "RESTON";
            nadLoop1.NAD.COUNTRYSUBENTITYDETAILS_07 = new C819();
            nadLoop1.NAD.COUNTRYSUBENTITYDETAILS_07.Countrysubentitynamecode_01 = "VA";
            nadLoop1.NAD.COUNTRYSUBENTITYDETAILS_07.Codelistidentificationcode_02 = "163";
            nadLoop1.NAD.COUNTRYSUBENTITYDETAILS_07.Codelistresponsibleagencycode_03 = "5";
            nadLoop1.NAD.Postalidentificationcode_08 = "20190";

            //  Repeating ATT
            nadLoop1.ATT = new List<ATT>();

            var attNad1 = new ATT();
            attNad1.Attributefunctioncodequalifier_01 = "2";
            attNad1.ATTRIBUTEDETAIL_03 = new List<C956>();
            var c9561 = new C956();
            c9561.Attributedescriptioncode_01 = "M";
            attNad1.ATTRIBUTEDETAIL_03.Add(c9561);
            var c9562 = new C956();
            c9562.Attributedescriptioncode_01 = "M";
            attNad1.ATTRIBUTEDETAIL_03.Add(c9562);
            var c9563 = new C956();
            c9563.Attributedescriptioncode_01 = "M";
            attNad1.ATTRIBUTEDETAIL_03.Add(c9563);
            var c9564 = new C956();
            c9564.Attributedescriptioncode_01 = "M";
            attNad1.ATTRIBUTEDETAIL_03.Add(c9564);
            var c9565 = new C956();
            c9565.Attributedescriptioncode_01 = "M";
            attNad1.ATTRIBUTEDETAIL_03.Add(c9565);
            nadLoop1.ATT.Add(attNad1);

            //  Repeating DTM
            nadLoop1.DTM = new List<DTM>();

            var dtmNad1 = new DTM();
            dtmNad1.DATETIMEPERIOD_01 = new C507();
            dtmNad1.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "329";
            dtmNad1.DATETIMEPERIOD_01.Dateortimeorperiodtext_02 = "19350919";
            dtmNad1.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "102";
            nadLoop1.DTM.Add(dtmNad1);

            //  Repeating EMP
            nadLoop1.EMP = new List<EMP>();

            var empNad1 = new EMP();
            empNad1.Employmentdetailscodequalifier_01 = "4";
            empNad1.QUALIFICATIONCLASSIFICATION_04 = new C950();
            empNad1.QUALIFICATIONCLASSIFICATION_04.Qualificationclassificationdescriptioncode_01 = "1";
            empNad1.Qualificationapplicationareacode_06 = "8";
            nadLoop1.EMP.Add(empNad1);

            //  Repeating NAT
            nadLoop1.NAT = new List<NAT>();

            var natNad1 = new NAT();
            natNad1.Nationalitycodequalifier_01 = "2";
            natNad1.NATIONALITYDETAILS_02 = new C042();
            natNad1.NATIONALITYDETAILS_02.Nationalitynamecode_01 = "US";
            natNad1.NATIONALITYDETAILS_02.Codelistresponsibleagencycode_03 = "5";
            nadLoop1.NAT.Add(natNad1);

            //  Repeating DOC NAD Groups
            nadLoop1.DOCLoop = new List<Loop_DOC_PAXLST>();

            //  Begin DOC NAD Group 1
            var docNad1 = new Loop_DOC_PAXLST();

            docNad1.DOC = new DOC();
            docNad1.DOC.DOCUMENTMESSAGENAME_01 = new C002();
            docNad1.DOC.DOCUMENTMESSAGENAME_01.Documentnamecode_01 = "5K";
            docNad1.DOC.DOCUMENTMESSAGEDETAILS_02 = new C503();
            docNad1.DOC.DOCUMENTMESSAGEDETAILS_02.Documentidentifier_01 = "P100971204141";

            docNad1.LOC = new List<LOC>();

            var locDoc1 = new LOC();
            locDoc1.Locationfunctioncodequalifier_01 = "91";
            locDoc1.LOCATIONIDENTIFICATION_02 = new C517();
            locDoc1.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "VA";
            locDoc1.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "163";
            docNad1.LOC.Add(locDoc1);

            var locDoc2 = new LOC();
            locDoc2.Locationfunctioncodequalifier_01 = "91";
            locDoc2.LOCATIONIDENTIFICATION_02 = new C517();
            locDoc2.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "US";
            locDoc2.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "162";
            docNad1.LOC.Add(locDoc2);

            //  End DOC NAD Group 1
            nadLoop1.DOCLoop.Add(docNad1);

            //  Begin DOC NAD Group 2
            var docNad2 = new Loop_DOC_PAXLST();

            docNad2.DOC = new DOC();
            docNad2.DOC.DOCUMENTMESSAGENAME_01 = new C002();
            docNad2.DOC.DOCUMENTMESSAGENAME_01.Documentnamecode_01 = "39";
            docNad2.DOC.DOCUMENTMESSAGEDETAILS_02 = new C503();
            docNad2.DOC.DOCUMENTMESSAGEDETAILS_02.Documentidentifier_01 = "15504141";

            docNad2.LOC = new List<LOC>();

            var locDoc3 = new LOC();
            locDoc3.Locationfunctioncodequalifier_01 = "91";
            locDoc3.LOCATIONIDENTIFICATION_02 = new C517();
            locDoc3.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "US";
            locDoc3.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "162";
            docNad2.LOC.Add(locDoc3);            

            //  End DOC NAD Group 2
            nadLoop1.DOCLoop.Add(docNad2);

            //  End NAD Group 1
            result.NADLoop2.Add(nadLoop1);

            return result;
        }
    }
}
