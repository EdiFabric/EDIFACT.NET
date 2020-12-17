using EdiFabric.Core.Model.Ack;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.Edifact.Model;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.AcknowledgeEDI
{
    class GenerateCONTRLWithCustomControlNumbers
    {
        /// <summary>
        /// Auto increment custom control numbers.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrder.txt");
            int unbControlNumber = 28;
            int ungControlNumber = 35;
            Debug.WriteLine("Start interchange control number: {0}", unbControlNumber);
            Debug.WriteLine("Start group control number: {0}", ungControlNumber);

            var settings = new AckSettings
            {
                AckHandler = (s, a) =>
                {
                    var contrl = a.Message as TSCONTRL;

                    if (contrl != null && a.AckType == AckType.Technical)
                    {
                        // a.Message is technical acknowledgment 
                    }

                    if (contrl != null && a.AckType == AckType.Functional)
                    {
                        var ack = AckBuilders.BuildAck(a.InterchangeHeader, a.GroupHeader, contrl, ++unbControlNumber, ++ungControlNumber);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (!a.ErrorContext.HasErrors)
                    {
                        // do something with the message a.Message
                        Debug.WriteLine("Message {0} with control number {1} is valid.", a.ErrorContext.Name, a.ErrorContext.ControlNumber);
                    }
                },
                ValidationSettings = new ValidationSettings { SerialNumber = TrialLicense.SerialNumber }
            };

            using (var ackMan = new Plugins.Acknowledgments.Edifact.AckMan(settings))
            {
                using (var ediReader = new EdifactReader(edi, "EdiFabric.Examples.EDIFACT.Templates.D96A", new EdifactReaderSettings { SerialNumber = TrialLicense.SerialNumber }))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }

            Debug.WriteLine("Last interchange control number: {0}", unbControlNumber);
            Debug.WriteLine("Last group control number: {0}", ungControlNumber);
        }
    }
}
