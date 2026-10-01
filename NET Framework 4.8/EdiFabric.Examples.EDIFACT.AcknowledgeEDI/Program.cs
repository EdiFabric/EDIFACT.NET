using EdiFabric.Examples.EDIFACT.Common;
using System;

namespace EdiFabric.Examples.EDIFACT.AcknowledgeEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            License.SetSerial(Config.TrialSerialKey);

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
