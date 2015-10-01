using System;
using System.Configuration;
using System.IO;

namespace EdiFabric.Framework
{
    static class Logger
    {
        private static readonly string LogFile;
        static Logger()
        {
            try
            {
                LogFile = ConfigurationManager.AppSettings["EdiFabric.LogFile"];
                if (!String.IsNullOrWhiteSpace(LogFile))
                    File.Delete(LogFile);
            }
            catch
            {
                // ignored
            }
        }

        public static void Log(string text)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(LogFile))
                    File.AppendAllText(LogFile, text + Environment.NewLine);
            }
            catch
            {
                // ignored
            }
        }
    }
}
