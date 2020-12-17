using System;
using System.IO;

namespace EdiFabric.Examples.EDIFACT.Common
{
    public class TrialLicense
    {
        public static string SerialNumber {get; set;}
        static TrialLicense()
        {
            var serialKeyPath = @"../../../../edifabric-trial/serial.key";

            if (!File.Exists(serialKeyPath))
                throw new Exception("Set the path to the serial.key file in project EdiFabric.Examples.EDIFACT.Common, file License.cs!");

            SerialNumber = File.ReadAllText(serialKeyPath).Trim(new[] {' ', '\r', '\n' });
        }
    }
}
