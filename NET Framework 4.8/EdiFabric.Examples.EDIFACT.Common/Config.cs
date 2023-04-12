namespace EdiFabric.Examples.EDIFACT.Common
{
    public class Config
    {
#if NET
        public static string TestFilesPath = @"\..\..\..\..\..\Files";
        public static string TestMapPath = @"\..\..\..\..\..\NET Framework 4.8\EdiFabric.Examples.EDIFACT.MapEDI\";
        public static string SerialKeyPath = @"../../../../../../edifabric/serial.key";
#else
        public static string TestFilesPath = @"\..\..\..\..\Files";
        public static string TestMapPath = @"\..\..\";
        public static string SerialKeyPath = @"../../../../../edifabric/serial.key";
#endif

    }
}

