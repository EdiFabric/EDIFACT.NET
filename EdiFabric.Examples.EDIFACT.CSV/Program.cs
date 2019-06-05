namespace EdiFabric.Examples.EDIFACT.CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Export to custom CSV
            ExportToCsv.Run();

            //  Import from custom CSV
            ImportFromCsv.Run();
        }
    }
}
