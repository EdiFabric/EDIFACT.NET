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
    class GenerateCONTRLForDuplicateGroup
    {
        /// <summary>
        /// Detect duplicate groups.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");            

            var edi = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\DuplicateGroup.txt");

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
                    if (!a.ErrorContext.HasErrors)
                    {
                        if (a.InDuplicateGroup)
                        {
                            Debug.WriteLine(string.Format("Interchange with control number {0}", a.InterchangeHeader.InterchangeControlReference_5));
                            Debug.WriteLine(string.Format("Group with control number {0}", a.GroupHeader.GroupReferenceNumber_5));
                            Debug.WriteLine("Message {0} with control number {1}", a.Message.Name, a.Message.ErrorContext.ControlNumber);
                            Debug.WriteLine("Is in duplicate group: {0}", a.InDuplicateGroup);
                            // reject message
                        }
                    }
                },
                // Turn on UCM for valid messages
                GenerateForValidMessages = true,
                GroupDuplicates = true
            };

            using (var ackMan = new Plugins.Acknowledgments.Edifact.AckMan(settings))
            {
                using (var ediReader = new EdifactReader(edi, "EdiFabric.Templates.Edifact"))
                {
                    while (ediReader.Read())
                        ackMan.Publish(ediReader.Item);
                }
            }
        }
    }
}
