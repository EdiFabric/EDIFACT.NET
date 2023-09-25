using EdiFabric.Examples.EDIFACT.Common;
using System;

namespace EdiFabric.Examples.EDIFACT.AcknowledgeEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }

            //  Generate CONTRL for valid group
            GenerateValidCONTRL.Run();

            //  Generate CONTRL for invalid group
            GenerateInvalidCONTRL.Run();

            //  Generate CONTRL for duplicates
            GenerateCONTRLForDuplicateTransaction.Run();
            GenerateCONTRLForDuplicateGroup.Run();
            GenerateCONTRLForDuplicateInterchange.Run();

            //  Generate CONTRL with explicit control numbers
            GenerateCONTRLWithCustomControlNumbers.Run();

            //  Read CONTRL message
            ReadCONTRL.Run();
        }
    }
}
