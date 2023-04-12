using System;
using System.IO;

namespace EdiFabric.Examples.EDIFACT.Common
{
    public class SerialKey
    {
        private static string _serialKey = null;
        static SerialKey()
        {
            // To get a free serial key go to https://sowl.co/oApEt

            if (!File.Exists(Config.SerialKeyPath))
                throw new Exception("Set the path to the serial.key file in project EdiFabric.Examples.EDIFACT.Common, file Config.cs!");

            _serialKey = File.ReadAllText(Config.SerialKeyPath).Trim(new[] { ' ', '\r', '\n' });
        }

        public static string Get()
        {
            return _serialKey;
        }
    }
}
