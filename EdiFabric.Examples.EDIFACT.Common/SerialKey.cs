using System;
using System.IO;

namespace EdiFabric.Examples.EDIFACT.Common
{
    public class SerialKey
    {
        private static string _serialKey = null;
        static SerialKey()
        {
            var serialKeyPath = @"../../../../edifabric-trial/serial.key";

            if (!File.Exists(serialKeyPath))
                throw new Exception("Set the path to the serial.key file in project EdiFabric.Examples.EDIFACT.Common, file License.cs!");

            _serialKey = File.ReadAllText(serialKeyPath).Trim(new[] {' ', '\r', '\n' });
        }

        public static string Get()
        {
            return _serialKey;
        }
    }
}
