using System;
using System.Configuration;
using System.IO;

namespace EdiFabric.Framework
{
    /// <summary>
    /// Simple logger for dumping the traversal of the parse tree to a file.
    /// This is intended only for debugging purposes and should be switched off otherwise.
    /// </summary>
    internal static class Logger
    {
        /// <summary>
        /// The static logger.
        /// </summary>
        private static readonly string LogFile;

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
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

        /// <summary>
        /// Thread unsafe logging.
        /// </summary>
        /// <param name="text">
        /// The text to be logged.
        /// </param>
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
