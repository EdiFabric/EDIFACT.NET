using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
