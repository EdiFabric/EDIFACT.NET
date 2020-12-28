using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Templates.EdifactD03B;
using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.CUSCAR
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
        /// Read Cargo Report
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\CargoReport.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSCUSCAR>();

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
        /// Write Cargo Report
        /// </summary>
        static void Write()
        {
            var transaction = BuildCargoReport("CUSCAR54");
           
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
        /// Build cargo report.
        /// Original from https://www.cbp.gov/sites/default/files/documents/cuscar_012_30_3.txt
        /// </summary>
        static TSCUSCAR BuildCargoReport(string controlNumber)
        {
            var result = new TSCUSCAR();

            //  Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "CUSCAR";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "03B";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentnamecode_01 = "85";
            result.BGM.DOCUMENTMESSAGENAME_01.Documentname_04 = "STANDARD";
            result.BGM.DOCUMENTMESSAGEIDENTIFICATION_02 = new C106();
            result.BGM.DOCUMENTMESSAGEIDENTIFICATION_02.Documentidentifier_01 = "LOCKKH04112206";
            result.BGM.Messagefunctioncode_03 = "22";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            var dtm1 = new DTM();
            dtm1.DATETIMEPERIOD_01 = new C507();
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "132";
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodtext_02 = "200412301200";
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "203";
            result.DTM.Add(dtm1);

            //  Repeating LOC
            result.LOC = new List<LOC>();

            var loc1 = new LOC();
            loc1.Locationfunctioncodequalifier_01 = "60";
            loc1.LOCATIONIDENTIFICATION_02 = new C517();
            loc1.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "0901";
            loc1.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "77";
            result.LOC.Add(loc1);

            //  Repeating RFF Groups
            result.RFFLoop = new List<Loop_RFF_CUSCAR>();

            //  Begin RFF Group
            var rffLoop1 = new Loop_RFF_CUSCAR();

            rffLoop1.RFF = new RFF();
            rffLoop1.RFF.REFERENCE_01 = new C506();
            rffLoop1.RFF.REFERENCE_01.Referencecodequalifier_01 = "ABO";
            rffLoop1.RFF.REFERENCE_01.Referenceidentifier_02 = "ABO04100000";

            //  End RFF Group
            result.RFFLoop.Add(rffLoop1);

            //  Repeating RFF Groups
            result.NADLoop = new List<Loop_NAD_CUSCAR>();

            //  Begin NAD Group 1
            var nadLoop1 = new Loop_NAD_CUSCAR();

            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.Partyfunctioncodequalifier_01 = "CA";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "LOCK";
            nadLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "172";
            nadLoop1.NAD.STREET_05 = new C059();
            nadLoop1.NAD.STREET_05.Streetandnumberorpostofficeboxidentifier_01 = "11107 SUNSET HILLS ROAD";
            nadLoop1.NAD.STREET_05.Streetandnumberorpostofficeboxidentifier_02 = "77705 ARLINGTON ROAD";
            nadLoop1.NAD.Cityname_06 = "RESTON";
            nadLoop1.NAD.COUNTRYSUBENTITYDETAILS_07 = new C819();
            nadLoop1.NAD.COUNTRYSUBENTITYDETAILS_07.Countrysubentitynamecode_01 = "VA";
            nadLoop1.NAD.COUNTRYSUBENTITYDETAILS_07.Codelistidentificationcode_02 = "163";
            nadLoop1.NAD.Postalidentificationcode_08 = "20190";

            //  End NAD Group 1
            result.NADLoop.Add(nadLoop1);

            //  Begin NAD Group 2
            var nadLoop2 = new Loop_NAD_CUSCAR();

            nadLoop2.NAD = new NAD();
            nadLoop2.NAD.Partyfunctioncodequalifier_01 = "VW";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "0000041047";
            nadLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "109";
            nadLoop2.NAD.PARTYNAME_04 = new C080();
            nadLoop2.NAD.PARTYNAME_04.Partyname_01 = "AADLER";
            nadLoop2.NAD.PARTYNAME_04.Partyname_02 = "KEN";

            //  End NAD Group 2
            result.NADLoop.Add(nadLoop2);

            //  Repeating FTX
            result.FTX = new List<FTX>();

            var ftx1 = new FTX();
            ftx1.Textsubjectcodequalifier_01 = "INS";
            ftx1.TEXTREFERENCE_03 = new C107();
            ftx1.TEXTREFERENCE_03.Freetextdescriptioncode_01 = "INSURANCE INFOR";
            ftx1.TEXTLITERAL_04 = new C108();
            ftx1.TEXTLITERAL_04.Freetext_01 = "NAMESTATE FARM INSURANCE COMPANY";
            ftx1.TEXTLITERAL_04.Freetext_02 = "PLCYQO123456789";
            ftx1.TEXTLITERAL_04.Freetext_03 = "AMNT100000";
            ftx1.TEXTLITERAL_04.Freetext_04 = "YEAR2004";
            result.FTX.Add(ftx1);

            //  Repeating TDT Groups
            result.TDTLoop = new List<Loop_TDT_CUSCAR>();

            //  Begin TDT Group 
            var tdtLoop1 = new Loop_TDT_CUSCAR();

            tdtLoop1.TDT = new TDT();
            tdtLoop1.TDT.Transportstagecodequalifier_01 = "11";
            tdtLoop1.TDT.MODEOFTRANSPORT_03 = new C220();
            tdtLoop1.TDT.MODEOFTRANSPORT_03.Transportmodenamecode_01 = "03";
            tdtLoop1.TDT.TRANSPORTMEANS_04 = new C001();
            tdtLoop1.TDT.TRANSPORTMEANS_04.Transportmeansdescription_04 = "BT";
            tdtLoop1.TDT.Transitdirectionindicatorcode_06 = "I";
            tdtLoop1.TDT.TRANSPORTIDENTIFICATION_08 = new C222();
            tdtLoop1.TDT.TRANSPORTIDENTIFICATION_08.Codelistidentificationcode_02 = "109";
            tdtLoop1.TDT.TRANSPORTIDENTIFICATION_08.Transportmeansidentificationname_04 = "10000324";

            //  End TDT Group 
            result.TDTLoop.Add(tdtLoop1);

            //  Repeating EQD Groups
            result.EQDLoop = new List<Loop_EQD_CUSCAR>();

            //  Begin EQD Group 
            var eqdLoop1 = new Loop_EQD_CUSCAR();

            eqdLoop1.EQD = new EQD();
            eqdLoop1.EQD.Equipmenttypecodequalifier_01 = "BI";
            eqdLoop1.EQD.EQUIPMENTIDENTIFICATION_02 = new C237();
            eqdLoop1.EQD.EQUIPMENTIDENTIFICATION_02.Equipmentidentifier_01 = "10000325";
            eqdLoop1.EQD.EQUIPMENTIDENTIFICATION_02.Codelistidentificationcode_02 = "109";

            //  Repeating SEL
            eqdLoop1.SEL = new List<SEL>();

            var selEqd = new SEL();
            selEqd.Transportunitsealidentifier_01 = "SEALEQUNO001";
            eqdLoop1.SEL.Add(selEqd);

            //  Repeating EQD RFF Groups
            eqdLoop1.RFFLoop = new List<Loop_RFF_CUSCAR_4>();

            //  Begin RFF Group
            var rffEqdLoop1 = new Loop_RFF_CUSCAR_4();

            rffEqdLoop1.RFF = new RFF();
            rffEqdLoop1.RFF.REFERENCE_01 = new C506();
            rffEqdLoop1.RFF.REFERENCE_01.Referencecodequalifier_01 = "ABZ";
            rffEqdLoop1.RFF.REFERENCE_01.Referenceidentifier_02 = "EQU123";

            //  Repeating LOC
            rffEqdLoop1.LOC = new List<LOC>();

            var locRff1 = new LOC();
            locRff1.Locationfunctioncodequalifier_01 = "89";
            locRff1.LOCATIONIDENTIFICATION_02 = new C517();
            locRff1.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "VA";
            locRff1.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "163";
            rffEqdLoop1.LOC.Add(locRff1);

            //  End RFF Group
            eqdLoop1.RFFLoop.Add(rffEqdLoop1);

            //  End EQD Group 
            result.EQDLoop.Add(eqdLoop1);

            //  Repeating CNI Groups
            result.CNILoop = new List<Loop_CNI_CUSCAR>();

            //  Begin CNI Group
            var cniLoop1 = new Loop_CNI_CUSCAR();

            cniLoop1.CNI = new CNI();
            cniLoop1.CNI.Consolidationitemnumber_01 = "3741";
            cniLoop1.CNI.DOCUMENTMESSAGEDETAILS_02 = new C503();
            cniLoop1.CNI.DOCUMENTMESSAGEDETAILS_02.Documentstatuscode_02 = "23";

            //  Repeating DOC
            cniLoop1.DOC = new List<DOC>();

            var docCni1 = new DOC();
            docCni1.DOCUMENTMESSAGENAME_01 = new C002();
            docCni1.DOCUMENTMESSAGENAME_01.Documentnamecode_01 = "714";
            docCni1.DOCUMENTMESSAGENAME_01.Documentname_04 = "61";
            docCni1.DOCUMENTMESSAGEDETAILS_02 = new C503();
            docCni1.DOCUMENTMESSAGEDETAILS_02.Documentidentifier_01 = "KH041122106";
            docCni1.DOCUMENTMESSAGEDETAILS_02.Documentsourcedescription_03 = "LOCK";
            cniLoop1.DOC.Add(docCni1);

            //  Repeating RFF CNI Groups
            cniLoop1.RFFLoop = new List<Loop_RFF_CUSCAR_2>();

            //  Begin RFF CNI Group
            var rffCniLoop1 = new Loop_RFF_CUSCAR_2();

            rffCniLoop1.RFF = new RFF();
            rffCniLoop1.RFF.REFERENCE_01 = new C506();
            rffCniLoop1.RFF.REFERENCE_01.Referencecodequalifier_01 = "AAM";
            rffCniLoop1.RFF.REFERENCE_01.Referenceidentifier_02 = "LOCKKH041122106";

            //  Repeating CNT
            rffCniLoop1.CNT = new List<CNT>();

            var cntRff1 = new CNT();
            cntRff1.CONTROL_01 = new C270();
            cntRff1.CONTROL_01.Controltotaltypecodequalifier_01 = "58";
            cntRff1.CONTROL_01.Controltotalquantity_02 = "158";
            rffCniLoop1.CNT.Add(cntRff1);

            //  Repeating LOC
            rffCniLoop1.LOC = new List<LOC>();

            var locRff2 = new LOC();
            locRff2.Locationfunctioncodequalifier_01 = "9";
            locRff2.LOCATIONIDENTIFICATION_02 = new C517();
            locRff2.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "U0107";
            locRff2.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "78";
            rffCniLoop1.LOC.Add(locRff2);

            //  Repeating GEI
            rffCniLoop1.GEI = new List<GEI>();

            var geiRff1 = new GEI();
            geiRff1.Processinginformationcodequalifier_01 = "7";
            geiRff1.PROCESSINGINDICATOR_02 = new C012();
            geiRff1.PROCESSINGINDICATOR_02.Processingindicatordescriptioncode_01 = "135";
            rffCniLoop1.GEI.Add(geiRff1);

            //  Repeating TDT RFF Groups
            rffCniLoop1.TDTLoop = new List<Loop_TDT_CUSCAR_2>();

            //  Begin TDT RFF Group 
            var tdtRffLoop1 = new Loop_TDT_CUSCAR_2();

            tdtRffLoop1.TDT = new TDT();
            tdtRffLoop1.TDT.Transportstagecodequalifier_01 = "11";

            //  Repeating DTM
            tdtRffLoop1.DTM = new List<DTM>();

            var dtmRff1 = new DTM();
            dtmRff1.DATETIMEPERIOD_01 = new C507();
            dtmRff1.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "133";
            dtmRff1.DATETIMEPERIOD_01.Dateortimeorperiodtext_02 = "20041230";
            dtmRff1.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "102";
            tdtRffLoop1.DTM.Add(dtmRff1);

            //  Repeating RFF TDT Groups
            tdtRffLoop1.RFFLoop = new List<Loop_RFF_CUSCAR_3>();

            //  Begin RFF TDT Group 
            var rffTdtLoop1 = new Loop_RFF_CUSCAR_3();

            rffTdtLoop1.RFF = new RFF();
            rffTdtLoop1.RFF.REFERENCE_01 = new C506();
            rffTdtLoop1.RFF.REFERENCE_01.Referencecodequalifier_01 = "AWM";

            //  Repeating TSR
            rffTdtLoop1.TSR = new List<TSR>();

            var tsrRff1 = new TSR();
            tsrRff1.CONTRACTANDCARRIAGECONDITION_01 = new C536();
            tsrRff1.CONTRACTANDCARRIAGECONDITION_01.Contractandcarriageconditioncode_01 = "9";
            rffTdtLoop1.TSR.Add(tsrRff1);

            //  End RFF TDTGroup 
            tdtRffLoop1.RFFLoop.Add(rffTdtLoop1);

            //  End TDT RFF Group 
            rffCniLoop1.TDTLoop.Add(tdtRffLoop1);

            //  Repeating NAD RFF Groups
            rffCniLoop1.NADLoop = new List<Loop_NAD_CUSCAR_2>();

            //  Begin NAD RFF Group 1
            var nadRffLoop1 = new Loop_NAD_CUSCAR_2();

            nadRffLoop1.NAD = new NAD();
            nadRffLoop1.NAD.Partyfunctioncodequalifier_01 = "CN";
            nadRffLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadRffLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "65424";
            nadRffLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "109";
            nadRffLoop1.NAD.NAMEANDADDRESS_03 = new C058();
            nadRffLoop1.NAD.NAMEANDADDRESS_03.Nameandaddressdescription_01 = "1234 MAIN STREET";
            nadRffLoop1.NAD.PARTYNAME_04 = new C080();
            nadRffLoop1.NAD.PARTYNAME_04.Partyname_01 = "KATHY SMITH";
            nadRffLoop1.NAD.Cityname_06 = "BELTSVILLE";
            nadRffLoop1.NAD.COUNTRYSUBENTITYDETAILS_07 = new C819();
            nadRffLoop1.NAD.COUNTRYSUBENTITYDETAILS_07.Countrysubentitynamecode_01 = "MD";
            nadRffLoop1.NAD.COUNTRYSUBENTITYDETAILS_07.Codelistidentificationcode_02 = "163";
            nadRffLoop1.NAD.Postalidentificationcode_08 = "20708";
            nadRffLoop1.NAD.Countrynamecode_09 = "US";

            //  Repeating CTA NAD Groups
            nadRffLoop1.CTALoop = new List<Loop_CTA_CUSCAR>();

            //  Begin CTA NAD Group
            var ctaNadLoop1 = new Loop_CTA_CUSCAR();

            ctaNadLoop1.CTA = new CTA();
            ctaNadLoop1.CTA.Contactfunctioncode_01 = "IC";

            //  Repeating COM
            ctaNadLoop1.COM = new List<COM>();

            var comCta1 = new COM();
            //  Repeating C076
            comCta1.COMMUNICATIONCONTACT_01 = new List<C076>();
            var c076Com1 = new C076();
            c076Com1.Communicationaddressidentifier_01 = "8005551212";
            c076Com1.Communicationaddresscodequalifier_02 = "TE";
            comCta1.COMMUNICATIONCONTACT_01.Add(c076Com1);
            ctaNadLoop1.COM.Add(comCta1);

            //  End CTA NAD Group
            nadRffLoop1.CTALoop.Add(ctaNadLoop1);

            //  End NAD RFF Group 1
            rffCniLoop1.NADLoop.Add(nadRffLoop1);

            //  Begin NAD RFF Group 2
            var nadRffLoop2 = new Loop_NAD_CUSCAR_2();

            nadRffLoop2.NAD = new NAD();
            nadRffLoop2.NAD.Partyfunctioncodequalifier_01 = "IM";
            nadRffLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadRffLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "00010";
            nadRffLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "109";
            nadRffLoop2.NAD.NAMEANDADDRESS_03 = new C058();
            nadRffLoop2.NAD.NAMEANDADDRESS_03.Nameandaddressdescription_01 = "1234 MAIN STREET";
            nadRffLoop2.NAD.PARTYNAME_04 = new C080();
            nadRffLoop2.NAD.PARTYNAME_04.Partyname_01 = "KATHY SMITH";
            nadRffLoop2.NAD.Cityname_06 = "BELTSVILLE";
            nadRffLoop2.NAD.COUNTRYSUBENTITYDETAILS_07 = new C819();
            nadRffLoop2.NAD.COUNTRYSUBENTITYDETAILS_07.Countrysubentitynamecode_01 = "MD";
            nadRffLoop2.NAD.COUNTRYSUBENTITYDETAILS_07.Codelistidentificationcode_02 = "163";
            nadRffLoop2.NAD.Postalidentificationcode_08 = "20708";
            nadRffLoop2.NAD.Countrynamecode_09 = "US";

            //  Repeating CTA NAD Groups
            nadRffLoop2.CTALoop = new List<Loop_CTA_CUSCAR>();

            //  Begin CTA NAD Group
            var ctaNadLoop2 = new Loop_CTA_CUSCAR();

            ctaNadLoop2.CTA = new CTA();
            ctaNadLoop2.CTA.Contactfunctioncode_01 = "IC";

            //  Repeating COM
            ctaNadLoop2.COM = new List<COM>();

            var comCta2 = new COM();
            //  Repeating C076
            comCta2.COMMUNICATIONCONTACT_01 = new List<C076>();
            var c076Com2 = new C076();
            c076Com2.Communicationaddressidentifier_01 = "8005551212";
            c076Com2.Communicationaddresscodequalifier_02 = "TE";
            comCta2.COMMUNICATIONCONTACT_01.Add(c076Com2);
            ctaNadLoop2.COM.Add(comCta2);

            //  End CTA NAD Group
            nadRffLoop2.CTALoop.Add(ctaNadLoop2);

            //  End NAD RFF Group 2
            rffCniLoop1.NADLoop.Add(nadRffLoop2);

            //  Begin NAD RFF Group 3
            var nadRffLoop3 = new Loop_NAD_CUSCAR_2();

            nadRffLoop3.NAD = new NAD();
            nadRffLoop3.NAD.Partyfunctioncodequalifier_01 = "OS";
            nadRffLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nadRffLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "27190";
            nadRffLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "109";
            nadRffLoop3.NAD.NAMEANDADDRESS_03 = new C058();
            nadRffLoop3.NAD.NAMEANDADDRESS_03.Nameandaddressdescription_01 = "1234 MAIN STREET";
            nadRffLoop3.NAD.PARTYNAME_04 = new C080();
            nadRffLoop3.NAD.PARTYNAME_04.Partyname_01 = "KATHY SMITH";
            nadRffLoop3.NAD.Cityname_06 = "BELTSVILLE";
            nadRffLoop3.NAD.COUNTRYSUBENTITYDETAILS_07 = new C819();
            nadRffLoop3.NAD.COUNTRYSUBENTITYDETAILS_07.Countrysubentitynamecode_01 = "MD";
            nadRffLoop3.NAD.COUNTRYSUBENTITYDETAILS_07.Codelistidentificationcode_02 = "163";
            nadRffLoop3.NAD.Postalidentificationcode_08 = "20708";
            nadRffLoop3.NAD.Countrynamecode_09 = "US";

            //  Repeating CTA NAD Groups
            nadRffLoop3.CTALoop = new List<Loop_CTA_CUSCAR>();

            //  Begin CTA NAD Group
            var ctaNadLoop3 = new Loop_CTA_CUSCAR();

            ctaNadLoop3.CTA = new CTA();
            ctaNadLoop3.CTA.Contactfunctioncode_01 = "IC";

            //  Repeating COM
            ctaNadLoop3.COM = new List<COM>();

            var comCta3 = new COM();
            //  Repeating C076
            comCta3.COMMUNICATIONCONTACT_01 = new List<C076>();
            var c076Com3 = new C076();
            c076Com3.Communicationaddressidentifier_01 = "8005551212";
            c076Com3.Communicationaddresscodequalifier_02 = "TE";
            comCta3.COMMUNICATIONCONTACT_01.Add(c076Com2);
            ctaNadLoop3.COM.Add(comCta3);

            //  End CTA NAD Group
            nadRffLoop3.CTALoop.Add(ctaNadLoop3);

            //  End NAD RFF Group 3
            rffCniLoop1.NADLoop.Add(nadRffLoop3);

            //  Repeating GID RFF Groups
            rffCniLoop1.GIDLoop = new List<Loop_GID_CUSCAR>();

            //  Begin GID RFF Group
            var gidRffLoop1 = new Loop_GID_CUSCAR();

            gidRffLoop1.GID = new GID();
            gidRffLoop1.GID.Goodsitemnumber_01 = "1";

            //  Repeating PAC
            gidRffLoop1.PAC = new List<PAC>();

            var pacGid1 = new PAC();
            pacGid1.Packagequantity_01 = "158";
            pacGid1.PACKAGETYPE_03 = new C202();
            pacGid1.PACKAGETYPE_03.Packagetypedescriptioncode_01 = "COL";
            gidRffLoop1.PAC.Add(pacGid1);

            //  Repeating FTX
            gidRffLoop1.FTX = new List<FTX>();

            var ftxGid1 = new FTX();
            ftxGid1.Textsubjectcodequalifier_01 = "AAA";
            ftxGid1.TEXTLITERAL_04 = new C108();
            ftxGid1.TEXTLITERAL_04.Freetext_01 = "IRON COIL";
            ftxGid1.TEXTLITERAL_04.Freetext_02 = "SHEET METAL";
            gidRffLoop1.FTX.Add(ftxGid1);

            //  Repeating MEA
            gidRffLoop1.MEA = new List<MEA>();

            var meaGid1 = new MEA();
            meaGid1.Measurementpurposecodequalifier_01 = "AAI";
            meaGid1.VALUERANGE_03 = new C174();
            meaGid1.VALUERANGE_03.Measurementunitcode_01 = "K";
            meaGid1.VALUERANGE_03.Measure_02 = "750";
            gidRffLoop1.MEA.Add(meaGid1);

            //  Repeating SGP
            gidRffLoop1.SGP = new List<SGP>();

            var sgpGid1 = new SGP();
            sgpGid1.EQUIPMENTIDENTIFICATION_01 = new C237();
            sgpGid1.EQUIPMENTIDENTIFICATION_01.Equipmentidentifier_01 = "10000325";
            sgpGid1.EQUIPMENTIDENTIFICATION_01.Codelistidentificationcode_02 = "109";
            gidRffLoop1.SGP.Add(sgpGid1);

            //  End GID RFF Group
            rffCniLoop1.GIDLoop.Add(gidRffLoop1);

            //  End RFF CNI Group 
            cniLoop1.RFFLoop.Add(rffCniLoop1);

            //  End CNI Group 
            result.CNILoop.Add(cniLoop1);

            return result;
        }
    }
}
