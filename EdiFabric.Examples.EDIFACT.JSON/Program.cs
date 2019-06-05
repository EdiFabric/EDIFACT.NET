namespace EdiFabric.Examples.EDIFACT.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
