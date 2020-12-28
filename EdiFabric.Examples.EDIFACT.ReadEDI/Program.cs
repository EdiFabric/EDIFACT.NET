using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.ReadEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());

            //  Read EDI file to the end
            ReadEDIFileToEnd.Run();
            ReadEDIFileToEndAsync.Run();

            //  Read one item at a time
            ReadEDIFileStreaming.Run();
            ReadEDIFileStreamingAsync.Run();

            //  Read batches of transactions
            ReadEDIFileBatch.Run();

            //  Split transactions to repeating loops
            ReadEDIFileSplitting.Run();
            ReadEDIFileSplitting.RunWithCopy();

            //  Read EDI files with issues
            ReadEDIFileCorrupt.Run();
            ReadEDIFileWithErrors.Run();

            //  Read transaction only
            ReadEDIFileTransactionOnly.Run();

            //  Read using partner-specific template (inherited)
            ReadEDIFileWithInheritedTemplate.Run();

            //  Read using dynamic template resolution
            ReadEDIFileWithTemplateResolution.RunWithAssemblyFactory();
            ReadEDIFileWithTemplateResolution.RunWithTypeFactory();
        }
    }
}
