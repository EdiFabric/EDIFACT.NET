using EdiFabric.Examples.EDIFACT.Common;
using System;

namespace EdiFabric.Examples.EDIFACT.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            License.SetSerial(Config.TrialSerialKey);

            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
