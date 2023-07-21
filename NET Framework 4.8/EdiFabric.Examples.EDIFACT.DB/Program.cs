using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.DB
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Save purchase order to DB. This will automatically create a DB structure for the full D96A version the first time it is executed.
            //  NOTE: edit the connection string in app.config, by default it looks for a local SQL Server instance
            SaveToDb.Run();

            //  Pull the latest purchase order from the DB
            PullFromDb.Run();
        }
    }
}
