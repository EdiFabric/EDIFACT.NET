using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using EdiFabric.Framework.Constants;
using EdiFabric.Framework.Controls;
using EdiFabric.Framework.Items;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Tests
{
    internal class TestHelper
    {
        public const string XsdAssemblyName = "EdiFabric.Xsd";

        public static XElement Serialize<T>(T instance, string nameSpace)
        {
            var serializer = new XmlSerializer(instance.GetType(), nameSpace);
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, instance);
                ms.Position = 0;
                return XElement.Load(ms, LoadOptions.PreserveWhitespace);
            }
        }

        public static Stream Load(string qualifiedFileName)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(qualifiedFileName);
        }

        public static Stream LoadXsd(string xsd)
        {
            return
                Assembly.Load(new AssemblyName(XsdAssemblyName))
                    .GetManifestResourceStream(string.Format("{0}.{1}", XsdAssemblyName, xsd));
        }

        public static string AsString(string qualifiedFileName, bool withLfCr = true)
        {
            using (var reader = new StreamReader(Load(qualifiedFileName), Encoding.Default))
            {
                if (withLfCr)
                    return reader.ReadToEnd().Replace("\r\n", "\n").Replace("\n", "\r\n");

                return reader.ReadToEnd();
            }
        }

        public static string AsString(IEnumerable<string> list, string postFix)
        {
            return list.Aggregate("", (current, item) => current + item + postFix);
        }

        public static IEnumerable<EdiItem> Parse(string sample, Encoding encoding = null,
            string rulesAssemblyName = null, string rulesNameSpacePrefix = null)
        {
            using (var ediReader = EdiReader.Create(Load(sample), encoding, rulesAssemblyName, rulesNameSpacePrefix))
            {
                return ediReader.ReadToNextMessage().ToList();
            }
        }

        public static IEnumerable<EdiItem> ParseMultiple(string sample, Encoding encoding = null,
            string rulesAssemblyName = null, string rulesNameSpacePrefix = null)
        {
            using (var ediReader = EdiReader.Create(Load(sample), encoding, rulesAssemblyName, rulesNameSpacePrefix))
            {
                return ediReader.ReadToEnd().ToList();
            }
        }
        
        public static EdifactInterchange GenerateEdifact<T>(string sample)
        {
            var items = Parse(sample).ToList();

            var ung = items.OfType<EdiControl<S_UNG>>().SingleOrDefault();
            var group = new EdifactGroup<T>(ung != null ? ung.Parse() : null);
            group.AddItem(items.OfType<EdiMessage>().Select(i => i.Value).OfType<T>().Single());
            var interchange = new EdifactInterchange(items.OfType<EdiControl<S_UNB>>().Single().Parse());
            interchange.AddItem(group);

            return interchange;
        }

        public static X12Interchange GenerateX12<T>(string sample, string rulesNameSpacePrefix = null)
        {
            var items = Parse(sample, null, null, rulesNameSpacePrefix).ToList();

            var group = new X12Group<T>(items.OfType<EdiControl<S_GS>>().Single().Parse());
            group.AddItem(items.OfType<EdiMessage>().Select(i => i.Value).OfType<T>().Single());
            var interchange = new X12Interchange(items.OfType<EdiControl<S_ISA>>().Single().Parse());
            interchange.AddItem(group);

            return interchange;
        }
    }
}
