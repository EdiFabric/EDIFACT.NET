using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using EdiFabric.Framework;
using EdiFabric.Framework.Headers;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.EdifactD00AINVOIC;

namespace EdiFabric.Tests
{
    class TestHelper
    {
        public const string RulesAssemblyName = "EdiFabric.Rules";
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

        public static string AsString(string qualifiedFileName)
        {
            using (var reader = new StreamReader(Load(qualifiedFileName), Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }

        public static string AsString(IEnumerable<string> list, string postFix)
        {
            return list.Aggregate("", (current, item) => current + item + postFix);
        }

        public static EdiMessage<S_UNB, S_UNG> ParseEdifact(string sample, Encoding encoding = null)
        {
            using (var ediReader = EdifactReader.Create(Load(sample), RulesAssemblyName, encoding ?? Encoding.Default))
            {
                return ediReader.ReadMessage() ? ediReader.Message : null;
            }
        }

        public static List<EdiMessage<S_UNB, S_UNG>> ParseEdifactMultiple(string sample, Encoding encoding = null)
        {
            using (var ediReader = EdifactReader.Create(Load(sample), RulesAssemblyName, encoding ?? Encoding.Default))
            {
                return ediReader.ReadAllMessages().ToList();
            }
        }

        public static EdifactInterchange GenerateEdifact(string sample)
        {
            var message = ParseEdifact(sample);
            var group = new EdifactGroup<M_INVOIC>(message.GroupHeader);
            group.AddItem(message.Value as M_INVOIC);
            var interchange = new EdifactInterchange(message.InterchangeHeader);
            interchange.AddItem(group);

            return interchange;
        }
    }
}
