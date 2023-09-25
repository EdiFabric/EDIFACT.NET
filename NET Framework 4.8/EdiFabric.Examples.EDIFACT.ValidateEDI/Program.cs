using EdiFabric.Examples.EDIFACT.Common;
using System;

namespace EdiFabric.Examples.EDIFACT.ValidateEDI
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

            //  Validate custom EDI codes
            ValidateCustomEDICodes.Run();
            ValidateCustomEDICodes.Run2();

            //  Validate transactions after reading
            ValidateEDITransationsAfterRead.Run();

            //  Validate transactions before writing them out
            ValidateEDITransationsBeforeWrite.Run();

            //  Validate transactions with custom code
            ValidateEDITransationsWithCustomCode.Run1();

            //  Validate date with custom code
            ValidateEDITransationsWithCustomCode.Run2();

            //  Validate data element alpha and alphanumeric data types
            ValidateDataElementTypes.Unoa();
            ValidateDataElementTypes.Unob();

            //  Validate control segments, UNB and UNG
            ValidateUNBorUNG.Run();

            //  Validate sample transactions
            ValidateINVOIC.Run();
            ValidateORDERS.Run();

            //  Validate async
            ValidateEDITransationsAsync.Run();
        }
    }
}
