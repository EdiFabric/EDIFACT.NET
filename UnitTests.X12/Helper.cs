using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using EdiFabric.Annotations.Model;
using EdiFabric.Framework;
using EdiFabric.Framework.Segments.X12;
using EdiFabric.Framework.Writers;
using EdiFabric.Rules.X12_002040;

namespace EdiFabric.UnitTests.X12
{
    public class Helper
    {
        public static string Generate(List<object> items, Separators separators, string postFix,
            Encoding encoding = null)
        {
            using (var stream = new MemoryStream())
            {
                var writer = new X12Writer(stream, encoding, postFix);
                foreach (var item in items)
                {
                    var message = item as EdiMessage;
                    if (message != null)
                    {
                        writer.WriteMessage(message);
                        continue;
                    }

                    var gs = item as GS;
                    if (gs != null)
                    {
                        writer.WriteGroup(gs);
                        continue;
                    }

                    var ge = item as GE;
                    if (ge != null)
                    {
                        continue;
                    }

                    var ta1 = item as TA1;
                    if (ta1 != null)
                    {
                        writer.WriteSegment(ta1.ToString(separators));
                    }

                    var isa = item as ISA;
                    if (isa != null)
                    {
                        writer.WriteInterchange(isa, separators);
                    }
                }
                writer.Flush();

                return CommonHelper.LoadString(stream);
            }
        }

        public static GS CreateGs()
        {
            return new GS
            {
                // Functional ID Code
                CodeIdentifyingInformationType_1 = "IN",
                // Application Senders Code
                SenderIDCode_2 = "SENDERID",
                // Application Receivers Code
                ReceiverIDCode_3 = "RECEIVERID",
                // Date
                Date_4 = "170509",
                // Time
                Time_5 = "1246",
                // Group Control Number
                // Must be unique to both partners for this interchange
                GroupControlNumber_6 = "111111111",
                // Responsible Agency Code
                TransactionTypeCode_7 = "X",
                // Version/Release/Industry id code
                VersionAndRelease_8 = "002040"
            };
        }

        public static ISA CreateIsa()
        {
            return new ISA
            {
                // Authorization Information Qualifier
                AuthorizationInformationQualifier_1 = "00",
                // Authorization Information
                AuthorizationInformation_2 = "          ",
                // Security Information Qualifier
                SecurityInformationQualifier_3 = "00",
                // Security Information
                SecurityInformation_4 = "          ",
                // Interchange ID Qualifier
                SenderIDQualifier_5 = "01",
                // Interchange Sender
                InterchangeSenderID_6 = "SENDERID",
                // Interchange ID Qualifier
                ReceiverIDQualifier_7 = "02",
                // Interchange Receiver
                InterchangeReceiverID_8 = "RECEIVERID",
                // Date
                InterchangeDate_9 = "170509",
                // Time
                InterchangeTime_10 = "1246",
                // Standard identifier
                InterchangeControlStandardsIdentifier_11 = "U",
                // Interchange Version ID
                // This is the ISA version and not the transaction set version
                InterchangeControlVersionNumber_12 = "00204",
                // Interchange Control Number
                InterchangeControlNumber_13 = "111111111",
                // Acknowledgment Requested (0 or 1)
                AcknowledgementRequested_14 = "1",
                // Test Indicator
                UsageIndicator_15 = "T"
            };
        }

        public static TS810 CreateInvoice()
        {
            var result = new TS810
            {
                ST = new ST {TransactionSetIdentifierCode_01 = "810", TransactionSetControlNumber_02 = "123456789"},
                BIG = new BIG
                {
                    InvoiceDate_01 = "20070129",
                    InvoiceNumber_02 = "0013833070",
                    PurchaseOrderDate_03 = "20070129",
                    PurchaseOrderNumber_04 = "V8748745",
                    TransactionTypeCode_07 = "DI"
                },
                NTE = new List<NTE>(),
                CAD = new CAD(),
                CTT = new CTT { NumberofLineItems_01 = "", HashTotal_02 = ""}
            };

            var nte1 = new NTE {NoteReferenceCode_01 = "GEN", FreeFormMessage_02 = "Text1"};
            result.NTE.Add(nte1);
            var nte2 = new NTE {NoteReferenceCode_01 = "GEN", FreeFormMessage_02 = "Text2"};
            result.NTE.Add(nte2);

            return result;
        }
    }
}
