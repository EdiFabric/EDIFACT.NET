﻿using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Examples.EDIFACT.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Translator Demo 

            //  Supported versions/transactions are:
            //  EDIFACT D96A, all classes that begin with TS in namespace EdiFabric.Templates.EdifactD96A
            //  Custom CUSCAR and PAXLST version EDIFACT D03B for US Customs, the classes are TSCUSCAR and TSPAXLST in namespace EdiFabric.Templates.EdifactD03B
            //  Custom BAPLIE version EDIFACT D13B for SMDG, the class is TSBAPLIE in namespace EdiFabric.Templates.EdifactD13B
            //  INVOIC EANCOM D01B Syntax 3, the class is TSINVOIC in namespace EdiFabric.Templates.EancomD01B

            //  If you need a different EDIFACT/EANCOM version or transaction, please contact us at https://support.edifabric.com/hc/en-us/requests/new, EdiFabric supports all versions and transaction for EDIFACT/EANCOM.

            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch(Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }
            //  Uncomment and then comment out the line above if you wish to use distributed cache for tokens
            //  TokenFileCache.Set();

            //  Change the path to point to your own file to test with
            var path = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\PurchaseOrders.txt");

            List<IEdiItem> ediItems;
            using (var reader = new EdifactReader(path, "EdiFabric.Templates.Edifact", new EdifactReaderSettings { ContinueOnError = true }))
                ediItems = reader.ReadToEnd().ToList();  
            
            foreach(var message in ediItems.OfType<EdiMessage>())
            {
                if(!message.HasErrors)
                {
                    //  Message was successfully parsed

                    MessageErrorContext mec;
                    if(message.IsValid(out mec))
                    {
                        //  Message was successfully validated
                    }
                    else
                    {
                        //  Message failed validation with the following validation issues:
                        var validationIssues = mec.Flatten();
                    }
                }
                else
                {
                    //  Message was partially parsed with errors
                }
            }
            
        }   //  Add a breakpoint here, run in debug mode and inspect ediItems
    }
}
