namespace EdiFabric.Examples.EDIFACT.Common
{
    public class Config
    {
        public static string TrialSerialKey = "c417cb9dd9d54297a55c032a74c87996";
#if NET
        public static string TestFilesPath = @"\..\..\..\..\..\Files";
        public static string TestMapPath = @"\..\..\..\..\..\NET Framework 4.8\EdiFabric.Examples.EDIFACT.MapEDI\";
#else
        public static string TestFilesPath = @"\..\..\..\..\Files";
        public static string TestMapPath = @"\..\..\";
#endif

    }
}

