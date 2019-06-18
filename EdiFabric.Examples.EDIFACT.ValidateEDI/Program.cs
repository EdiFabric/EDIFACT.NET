namespace EdiFabric.Examples.EDIFACT.ValidateEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Validate custom EDI codes
            ValidateCustomEDICodes.Run();

            //  Validate transactions after reading
            ValidateEDITransationsAfterRead.Run();

            //  Validate transactions before writing them out
            ValidateEDITransationsBeforeWrite.Run();

            //  Validate transactions with custom code
            ValidateEDITransationsWithCustomCode.Run();

            //  Validate data element alpha and alphanumeric data types
            ValidateDataElementTypes.Unoa();
            ValidateDataElementTypes.Unob();

            //  Validate control segments, UNB and UNG
            ValidateUNBorUNG.Run();

            //  Validate sample transactions
            ValidateINVOIC.Run();
            ValidateINVOICSyntax3.Run();
            ValidateORDERS.Run();
        }
    }
}
