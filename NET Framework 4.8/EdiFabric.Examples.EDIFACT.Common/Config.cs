namespace EdiFabric.Examples.EDIFACT.Common
{
    public class Config
    {
        public static string TrialSerialKey = "bd96a836feca45cb91c86ee65d281f52";
#if NET
        public static string TestFilesPath = @"\..\..\..\..\..\Files";
        public static string TestMapPath = @"\..\..\..\..\..\NET Framework 4.8\EdiFabric.Examples.EDIFACT.MapEDI\";
#else
        public static string TestFilesPath = @"\..\..\..\..\Files";
        public static string TestMapPath = @"\..\..\";
#endif

    }
}

