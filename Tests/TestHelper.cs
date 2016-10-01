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

namespace EdiFabric.Tests
{
    internal class TestHelper
    {
        //public const string RulesAssemblyName = "EdiFabric.Rules";
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

        public static EdiMessage<S_UNB, S_UNG> ParseEdifact(string sample, Encoding encoding = null,
            string rulesAssemblyName = null, string rulesNameSpacePrefix = null)
        {
            using (var ediReader = EdifactReader.Create(Load(sample), rulesAssemblyName, encoding, rulesNameSpacePrefix)
                )
            {
                return ediReader.ReadMessage() ? ediReader.Message : null;
            }
        }

        public static EdiMessage<S_ISA, S_GS> ParseX12(string sample, Encoding encoding = null,
            string rulesAssemblyName = null, string rulesNameSpacePrefix = null)
        {
            using (var ediReader = X12Reader.Create(Load(sample), rulesAssemblyName, encoding, rulesNameSpacePrefix))
            {
                return ediReader.ReadMessage() ? ediReader.Message : null;
            }
        }

        public static List<EdiMessage<S_UNB, S_UNG>> ParseEdifactMultiple(string sample, Encoding encoding = null,
            string rulesAssemblyName = null, string rulesNameSpacePrefix = null)
        {
            using (var ediReader = EdifactReader.Create(Load(sample), rulesAssemblyName, encoding, rulesNameSpacePrefix)
                )
            {
                return ediReader.ReadAllMessages().ToList();
            }
        }

        public static List<EdiMessage<S_ISA, S_GS>> ParseX12Multiple(string sample, Encoding encoding = null,
            string rulesAssemblyName = null, string rulesNameSpacePrefix = null)
        {
            using (var ediReader = X12Reader.Create(Load(sample), rulesAssemblyName, encoding, rulesNameSpacePrefix)
                )
            {
                return ediReader.ReadAllMessages().ToList();
            }
        }

        public static EdifactInterchange GenerateEdifact<T>(string sample)
        {
            var message = ParseEdifact(sample);
            var group = new EdifactGroup<T>(message.GroupHeader);
            group.AddItem((T)message.Value);
            var interchange = new EdifactInterchange(message.InterchangeHeader);
            interchange.AddItem(group);

            return interchange;
        }

        public static X12Interchange GenerateX12<T>(string sample, string rulesNameSpacePrefix = null)
        {
            var message = ParseX12(sample, null, null, rulesNameSpacePrefix);
            var group = new X12Group<T>(message.GroupHeader);
            group.AddItem((T)message.Value);
            var interchange = new X12Interchange(message.InterchangeHeader);
            interchange.AddItem(group);

            return interchange;
        }
    }
}
