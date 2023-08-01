using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.WriteEDI
{
    class Program
    {
        static void Main(string[] args)
        {
             SerialKey.Set(Config.TrialSerialKey);

            //  Write EDI to stream and then to string or file
            WriteEDIToStream.Run();
            WriteEDIToStreamAsync.Run();

            //  Write EDI directly to file
            WriteEDIToFile.Run();

            //  Write EDI with custom delimiters (this includes all delimiters set in ISA)
            WriteEDIWithCustomDelimiters.Run();

            //  Write EDI with postfix (such as new line) after each segment
            WriteEDIWithNewLines.Run();

            //  Write batches
            WriteEDITransactionBatch.Run();
            WriteEDIGroupBatch.Run();
            WriteEDIInterchangeBatch.Run();

            //  Retain trailing data element delimiters for empty data elements
            WriteEDIWithEmptyDataElements.Run();

            //  Write transaction only
            WriteEDITransactionOnly.Run();

            //  Turn auto-trailers off
            WriteEDIWithoutAutoTrailers.Run();

            //  Write with obfuscation
            WriteEDIWithObfuscation.Run();
        }
    }
}
