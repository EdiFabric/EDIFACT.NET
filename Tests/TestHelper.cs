using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Framework.Controls;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Tests
{
    internal class TestHelper
    {
        public static Stream Load(string qualifiedFileName)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(qualifiedFileName);
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

        public static IEnumerable<object> Parse(string sample, Encoding encoding = null,
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

            var ung = items.OfType<S_UNG>().SingleOrDefault();
            var group = new EdifactGroup<T>(ung ?? null);
            group.AddItem(items.OfType<T>().Single());
            var interchange = new EdifactInterchange(items.OfType<S_UNB>().Single());
            interchange.AddItem(group);

            return interchange;
        }

        public static X12Interchange GenerateX12<T>(string sample, string rulesNameSpacePrefix = null)
        {
            var items = Parse(sample, null, null, rulesNameSpacePrefix).ToList();

            var group = new X12Group<T>(items.OfType<S_GS>().Single());
            group.AddItem(items.OfType<T>().Single());
            var interchange = new X12Interchange(items.OfType<S_ISA>().Single());
            interchange.AddItem(group);

            return interchange;
        }
    }
}
