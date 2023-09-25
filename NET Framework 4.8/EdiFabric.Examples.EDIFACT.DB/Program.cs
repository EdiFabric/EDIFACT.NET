using EdiFabric.Examples.EDIFACT.Common;
using System;

namespace EdiFabric.Examples.EDIFACT.DB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }

            //  Save purchase order to DB. This will automatically create a DB structure for the full D96A version the first time it is executed.
            //  NOTE: edit the connection string in app.config, by default it looks for a local SQL Server instance
            SaveToDb.Run();

            //  Pull the latest purchase order from the DB
            PullFromDb.Run();
        }
    }
}
