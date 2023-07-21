using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Export to custom CSV
            ExportToCsv.Run();

            //  Import from custom CSV
            ImportFromCsv.Run();
        }
    }
}
