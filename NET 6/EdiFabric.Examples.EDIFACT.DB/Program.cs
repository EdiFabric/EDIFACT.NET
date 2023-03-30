using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.EdifactD96A;
using System.Text;

namespace EdiFabric.Examples.EFCore.Edifact.TSORDERS
{
    class Program
    {
        //  IMPORTANT!!!
        //  Before you run this you need to create a database
        //  Set this project to be the Startup Project and then open the Package Manager Console from Tools->NuGet Package Manager-> Package Manager Console
        //  In Package Manager Console select the Default Project to be this one
        //  Create the database with migrations in two steps:
        //  1. PM> Add-Migration InitialCreate
        //  2. PM> Update-Database
        //  The connection string is in EF_EDIFACT_D96A_DbContext.cs, and is set to the local instance of SQL Server
        static void Main(string[] args)
        {
            SerialKey.Set(GetSerial());

            var path = Directory.GetCurrentDirectory() + @"\..\..\..\PurchaseOrder.txt";
            Stream ediStream = File.OpenRead(path);

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
                ediItems = ediReader.ReadToEnd().ToList();

            var tran = ediItems.OfType<Templates.EdifactD96A.TSORDERS>().Single();

            SaveORDERS(tran);
            var edi = PullORDERS(ediItems);

            Console.ReadKey();
        }

        public static void SaveORDERS(Templates.EdifactD96A.TSORDERS tran)
        {
            using (var db = new EDIFACTContext())
            {
                tran.ClearCache();
                db.TSORDERS.Add(tran);
                db.SaveChanges();
            }
        }

        public static string PullORDERS(List<IEdiItem> ediItems)
        {
            using (var db = new EDIFACTContext())
            {
                var tran = db.TSORDERS.FirstOrDefault();
                var sep = Separators.Edifact;
                sep.ComponentDataElement = ':';

                if (tran != null)
                {
                    using (var stream = new MemoryStream())
                    {
                        using (var writer = new EdifactWriter(stream, new EdifactWriterSettings { Postfix = Environment.NewLine, Separators = sep }))
                        {
                            writer.Write(ediItems.OfType<UNB>().Single());
                            var ung = ediItems.OfType<UNG>().SingleOrDefault();
                            if(ung != null)
                                writer.Write(ung);
                            writer.Write(tran);
                        }

                        return LoadString(stream);
                    }
                }
            }

            return null;
        }

        public static string LoadString(Stream stream, Encoding encoding = null)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, encoding ?? Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        public static string GetSerial()
        {
            var serialKeyPath = @"../../../../../edifabric-trial/serial.key";

            if (!File.Exists(serialKeyPath))
                throw new Exception("Set the correct path to the serial.key file!");

            return File.ReadAllText(serialKeyPath).Trim(new[] { ' ', '\r', '\n' });
        }
    }
}
