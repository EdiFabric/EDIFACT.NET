using EdiFabric.Examples.EDIFACT.Common;
using System;

namespace EdiFabric.Examples.EDIFACT.CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            License.SetSerial(Config.TrialSerialKey);

            //  Export to custom CSV
            ExportToCsv.Run();

            //  Import from custom CSV
            ImportFromCsv.Run();
        }
    }
}
