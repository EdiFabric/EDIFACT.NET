using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace EdiFabric.Examples.EDIFACT.MapEDI
{
    class EDIToCustomObjectWithXslt
    {
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Edifact\PurchaseOrderCSV.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Templates.Edifact"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TSORDERS>();
            foreach (var transaction in transactions)
            {
                //  Serialize each transaction
                var xml = transaction.Serialize();

                //  Transform each XML
                XDocument outputXml = new XDocument();
                using (XmlWriter writer = outputXml.CreateWriter())
                {
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load(XmlReader.Create(File.OpenRead(Directory.GetCurrentDirectory() + Config.TestMapPath + @"TemplateORDERSToPurchaseOrderMap.xslt")));
                    xslt.Transform(xml.CreateReader(), writer);
                }

                //  Deserialize into the destination type
                PurchaseOrder customTransaction = outputXml.Root.Deserialize<PurchaseOrder>();
            }
        }
    }
}
