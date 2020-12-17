using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.ValidateEDI
{
    class ValidateUNBorUNG
    {
        /// <summary>
        /// Validate the typed control segments
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\Invoice.txt");

            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates.D96A", new EdifactReaderSettings { SerialNumber = TrialLicense.SerialNumber }))
            {
                while (ediReader.Read())
                {
                    var unb = ediReader.Item as UNB;
                    if (unb != null)
                    {
                        //  Validate 
                        var unbErrors = unb.Validate();
                        //  Pull the sender id from UNB
                        var senderId = unb.INTERCHANGESENDER_2.InterchangeSenderIdentification_1;
                        Debug.WriteLine("Sender ID:");
                        Debug.WriteLine(senderId);
                    }

                    var ung = ediReader.Item as UNG;
                    if (ung != null)
                    {
                        //  Validate 
                        var ungErrors = ung.Validate();
                        //  Pull the sender id from UNG
                        var senderId = ung.APPLICATIONSENDERIDENTIFICATION_2.ApplicationSenderIdentification_1;
                        Debug.WriteLine("Sender ID:");
                        Debug.WriteLine(senderId);
                    }
                }
            }
        }
    }
}
