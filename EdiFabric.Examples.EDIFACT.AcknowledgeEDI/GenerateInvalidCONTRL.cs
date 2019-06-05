using EdiFabric.Core.Model.Ack;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Plugins.Acknowledgments.Edifact.Model;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.AcknowledgeEDI
{
    class GenerateInvalidCONTRL
    {
        /// <summary>
        /// Generate CONTRL for an invalid message.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrderInvalid.txt");

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
                        var ack = AckBuilders.BuildAck(a.InterchangeHeader, a.GroupHeader, contrl);
                        Debug.Write(ack);
                    }
                },
                MessageHandler = (s, a) =>
                {
                    if (a.ErrorContext.HasErrors)
                    {
                        // do something with the message a.Message
                        Debug.WriteLine("Message {0} with control number {1} is invalid.", a.ErrorContext.Name, a.ErrorContext.ControlNumber);
                    }
                },
                // Turn on UCM for valid messages
                GenerateForValidMessages = true
            };

            using (var ackMan = new Plugins.Acknowledgments.Edifact.AckMan(settings))
            {
                using (var ediReader = new EdifactReader(edi, "EdiFabric.Examples.EDIFACT.Templates.D96A"))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }
    }
}
