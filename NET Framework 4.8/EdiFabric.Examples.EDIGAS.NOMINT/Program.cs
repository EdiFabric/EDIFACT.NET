using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Templates.Edigas40;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIGAS.NOMINT
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
        /// Read Nomination
        /// </summary>
        static void Read()
        {
            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edigas\NOMINT.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edigas"))
                ediItems = ediReader.ReadToEnd().ToList();

            var transactions = ediItems.OfType<TSNOMINT>();

            foreach (var transaction in transactions)
            {
                var xml = transaction.Serialize();
                File.WriteAllText(@"C:\Temp\nomint.xml", xml.Root.ToString());
                if (transaction.HasErrors)
                {
                    //  partially parsed
                    var errors = transaction.ErrorContext.Flatten();
                }
            }
        }

        /// <summary>
        /// Write Nomination
        /// </summary>
        static void Write()
        {
            var transaction = BuildNomination("ME000001");

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
        /// Build Nomination.
        /// Original from https://www.edigas.org/
        /// </summary>
        static TSNOMINT BuildNomination(string controlNumber)
        {
            var result = new TSNOMINT();

            //  Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "NOMINT";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "4";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "0";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "EG";
            result.UNH.MessageIdentifier_02.AssociationAssignedCode_05 = "EGAS40";

            //  BEGINNING OF MESSAGE – To indicate the type and function of a message and to transmit the identifying number.
            //  The following structure for the message number in BGM-1004 is mandatory in the Edig@s messages: 6 character message code + a unique identification
            result.BGM = new BGM();
            result.BGM.C002_01 = new C002();
            result.BGM.C002_01.DocumentNameCode_01 = "01G";
            result.BGM.C002_01.CodeListResponsibleAgencyCode_03 = "321";
            result.BGM.C106_02 = new C106();
            result.BGM.C106_02.DocumentIdentifier_01 = "NOMINT20090101A00001";
            result.BGM.MessageFunctionCode_03 = "9";

            //  Repeating DTM
            result.DTM = new List<DTM>();

            //  Identifies the time definition
            var dtm1 = new DTM();
            dtm1.C507_01 = new C507();
            dtm1.C507_01.DateOrTimeOrPeriodFunctionCodeQualifier_01 = "Z05";
            dtm1.C507_01.DateOrTimeOrPeriodText_02 = "0";
            dtm1.C507_01.DateOrTimeOrPeriodFormatCode_03 = "805";
            result.DTM.Add(dtm1);

            //  Identifies the date and time of the message
            var dtm2 = new DTM();
            dtm2.C507_01 = new C507();
            dtm2.C507_01.DateOrTimeOrPeriodFunctionCodeQualifier_01 = "137";
            dtm2.C507_01.DateOrTimeOrPeriodText_02 = "200309051506";
            dtm2.C507_01.DateOrTimeOrPeriodFormatCode_03 = "203";
            result.DTM.Add(dtm2);

            //  Identifies the (validity) period covered by the message
            var dtm3 = new DTM();
            dtm3.C507_01 = new C507();
            dtm3.C507_01.DateOrTimeOrPeriodFunctionCodeQualifier_01 = "Z01";
            dtm3.C507_01.DateOrTimeOrPeriodText_02 = "200309090400200309160400";
            dtm3.C507_01.DateOrTimeOrPeriodFormatCode_03 = "719";
            result.DTM.Add(dtm3);

            //  Repeating P1 Groups
            result.P1Loop = new List<Loop_1_TSNOMINT>();

            //  Begin P1 Group
            var rffLoop1 = new Loop_1_TSNOMINT();

            //  This identifies the contract (group) relevant for this message
            rffLoop1.RFF = new RFF();
            rffLoop1.RFF.C506_01 = new C506();
            rffLoop1.RFF.C506_01.ReferenceCodeQualifier_01 = "Z11";
            rffLoop1.RFF.C506_01.ReferenceIdentifier_02 = "TRABCRR01";

            //  End P1 Group
            result.P1Loop.Add(rffLoop1);

            //  Repeating P2 Groups
            result.P2Loop = new List<Loop_2_TSNOMINT>();

            //  Begin P2 Group
            var nadLoop1 = new Loop_2_TSNOMINT();

            //  This Identifies the issuer and recipient of the message
            nadLoop1.NAD = new NAD();
            nadLoop1.NAD.PartyFunctionCodeQualifier_01 = "ZSH";
            nadLoop1.NAD.C082_02 = new C082();
            nadLoop1.NAD.C082_02.PartyIdentifier_01 = "GREENSHIPPER";
            nadLoop1.NAD.C082_02.CodeListResponsibleAgencyCode_03 = "321";

            //  End P2 Group
            result.P2Loop.Add(nadLoop1);

            //  Repeating P29 Groups
            result.P29Loop = new List<Loop_29_TSNOMINT>();

            //  Begin P29 Group 1
            var linLoop1 = new Loop_29_TSNOMINT();

            //  Starts each new occurrence of the LIN-Loop
            linLoop1.LIN = new LIN();
            linLoop1.LIN.LINEITEMIDENTIFIER_01 = "ZSH";

            //  Repeating MEA
            linLoop1.MEA = new List<MEA>();

            //  To specify physical measurements, including dimension tolerances, weights and counts. Provides GCV conversion values.
            var mea1 = new MEA();
            mea1.MEASUREMENTPURPOSECODEQUALIFIER_01 = "SV";
            mea1.C502_02 = new C502();
            mea1.C502_02.MeasuredAttributeCode_01 = "ZDG";
            mea1.C174_03 = new C174();
            mea1.C174_03.MeasurementUnitCode_01 = "KW3";
            mea1.C174_03.Measure_02 = "11.82";
            linLoop1.MEA.Add(mea1);

            //  Repeating DTM
            linLoop1.DTM = new List<DTM>();

            //  Identifies the date/time/period for the preceding value
            var dtm4 = new DTM();
            dtm4.C507_01 = new C507();
            dtm4.C507_01.DateOrTimeOrPeriodFunctionCodeQualifier_01 = "7";
            dtm4.C507_01.DateOrTimeOrPeriodText_02 = "200309090400200309160400";
            dtm4.C507_01.DateOrTimeOrPeriodFormatCode_03 = "719";
            linLoop1.DTM.Add(dtm4);

            //  Repeating P38 Groups
            linLoop1.P38Loop = new List<Loop_38_TSNOMINT>();

            //  Begin P38 Group 1
            var locLoop1 = new Loop_38_TSNOMINT();

            //  Identifies the connection point relevant for the values in this LIN-loop
            locLoop1.LOC = new LOC();
            locLoop1.LOC.LocationFunctionCodeQualifier_01 = "Z19";
            locLoop1.LOC.C517_02 = new C517();
            locLoop1.LOC.C517_02.LocationIdentifier_01 = "DEESS";
            locLoop1.LOC.C517_02.CodeListResponsibleAgencyCode_03 = "321";

            //  End P38 Group 1
            linLoop1.P38Loop.Add(locLoop1);

            //  End P29 Group 1
            result.P29Loop.Add(linLoop1);

            //  Begin P29 Group 2
            var linLoop2 = new Loop_29_TSNOMINT();

            //  Starts each new occurrence of the LIN-Loop
            linLoop2.LIN = new LIN();
            linLoop2.LIN.LINEITEMIDENTIFIER_01 = "3";

            //  Repeating P34 Groups
            linLoop2.P34Loop = new List<Loop_34_TSNOMINT>();

            //  Begin P34 Group 1
            var rffLoop2 = new Loop_34_TSNOMINT();

            //  Identifies a contract and/or a category
            rffLoop2.RFF = new RFF();
            rffLoop2.RFF.C506_01 = new C506();
            rffLoop2.RFF.C506_01.ReferenceCodeQualifier_01 = "CT";
            rffLoop2.RFF.C506_01.ReferenceIdentifier_02 = "TRABCRR01NN";

            //  End P34 Group 1
            linLoop2.P34Loop.Add(rffLoop2);

            //  Repeating P38 Groups
            linLoop2.P38Loop = new List<Loop_38_TSNOMINT>();

            //  Begin P38 Group 1
            var locLoop2 = new Loop_38_TSNOMINT();

            //  Identifies the connection point relevant for the quantities in this LIN-loop
            locLoop2.LOC = new LOC();
            locLoop2.LOC.LocationFunctionCodeQualifier_01 = "Z19";
            locLoop2.LOC.C517_02 = new C517();
            locLoop2.LOC.C517_02.LocationIdentifier_01 = "DEESS";
            locLoop2.LOC.C517_02.CodeListResponsibleAgencyCode_03 = "321";

            //  Identifies the date/time/period for the preceding quantity
            locLoop2.DTM = new DTM();
            locLoop2.DTM.C507_01 = new C507();
            locLoop2.DTM.C507_01.DateOrTimeOrPeriodFunctionCodeQualifier_01 = "2";
            locLoop2.DTM.C507_01.DateOrTimeOrPeriodText_02 = "200309150400200309160400";
            locLoop2.DTM.C507_01.DateOrTimeOrPeriodFormatCode_03 = "719";

            //  Repeating P39 Groups
            locLoop2.P39Loop = new List<Loop_39_TSNOMINT>();

            //  Begin P39 Group 1
            var qtyLoop1 = new Loop_39_TSNOMINT();

            //   To specify a pertinent quantity
            qtyLoop1.QTY = new QTY();
            qtyLoop1.QTY.C186_01 = new C186();
            qtyLoop1.QTY.C186_01.QUANTITYTYPECODEQUALIFIER_01 = "Z03";
            qtyLoop1.QTY.C186_01.QUANTITY_02 = "6782";
            qtyLoop1.QTY.C186_01.MeasurementUnitCode_03 = "KW1";

            //  Repeating STS
            qtyLoop1.STS = new List<STS>();

            //  To specify the status of an object or service, including its category and the reason(s) for the status
            var sts1 = new STS();
            sts1.C601_01 = new C601();
            sts1.C601_01.StatusCategoryCode_01 = "08G";
            sts1.C601_01.CodeListResponsibleAgencyCode_03 = "321";
            sts1.C555_02 = new C555();
            sts1.C555_02.StatusDescriptionCode_01 = "30G";
            sts1.C555_02.CodeListResponsibleAgencyCode_03 = "321";
            qtyLoop1.STS.Add(sts1);

            //  End P39 Group 1
            locLoop2.P39Loop.Add(qtyLoop1);

            //  End P38 Group 1
            linLoop2.P38Loop.Add(locLoop2);

            //  Repeating P41 Groups
            linLoop2.P41Loop = new List<Loop_41_TSNOMINT>();

            //  Begin P41 Group 1
            var nadLoop2 = new Loop_41_TSNOMINT();

            //  Identifies a party specifically related to this Lin-loop
            nadLoop2.NAD = new NAD();
            nadLoop2.NAD.PartyFunctionCodeQualifier_01 = "ZSH";
            nadLoop2.NAD.C082_02 = new C082();
            nadLoop2.NAD.C082_02.PartyIdentifier_01 = "SHIPPER02";
            nadLoop2.NAD.C082_02.CodeListResponsibleAgencyCode_03 = "ZSO";

            //  End P41 Group 1
            linLoop2.P41Loop.Add(nadLoop2);

            //  End P29 Group 2
            result.P29Loop.Add(linLoop2);

            //  To separate header, detail and summary sections of a message. Separates the Detail and the Summary sections
            result.UNS = new UNS();
            result.UNS.SectionIdentification_01 = "";

            return result;
        }
    }
}
