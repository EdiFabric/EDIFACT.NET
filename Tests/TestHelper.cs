using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
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

        public static XDocument Serialize(object instance)
        {
            if (instance == null)
                throw new ArgumentNullException("instance");

            var type = instance.GetType();

            var nameSpace = type.Namespace;
            if (type.FullName.Contains("X12"))
                nameSpace = "www.edifabric.com/x12";
            if (type.FullName.Contains("Edifact"))
                nameSpace = "www.edifabric.com/edifact";

            var serializer = new XmlSerializer(type, nameSpace);
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, instance);
                ms.Position = 0;
                return XDocument.Load(ms, LoadOptions.PreserveWhitespace);
            }
        }

        public static T Deserialize<T>(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (var reader = new StreamReader(stream))
            {
                return (T) serializer.Deserialize(reader);
            }
        }

        public static IEnumerable<object> ParseX12(string sample, Encoding encoding = null,
            string rulesAssembly = null, string rulesNameSpacePrefix = null)
        {
            using (
                var ediReader = X12Reader.Create(Load(sample),
                    new ReaderSettings(rulesAssembly ?? "EdiFabric.Rules", rulesNameSpacePrefix ?? "EdiFabric.Rules",
                        encoding ?? Encoding.Default)))
            {
                return ediReader.ReadToEnd().ToList();
            }
        }

        public static IEnumerable<object> ParseEdifact(string sample, Encoding encoding = null,
            string rulesAssembly = null, string rulesNameSpacePrefix = null)
        {
            using (
                var ediReader = EdifactReader.Create(Load(sample),
                    new ReaderSettings(rulesAssembly ?? "EdiFabric.Rules", rulesNameSpacePrefix ?? "EdiFabric.Rules",
                        encoding ?? Encoding.Default)))
            {
                return ediReader.ReadToEnd().ToList();
            }
        }

        public static EdifactInterchange GenerateEdifact<T>(string sample)
        {
            var items = ParseEdifact(sample).ToList();

            var ung = items.OfType<S_UNG>().SingleOrDefault();
            var group = new EdifactGroup<T>(ung);
            group.AddItem(items.OfType<T>().Single());
            var interchange = new EdifactInterchange(items.OfType<S_UNB>().Single());
            interchange.AddItem(group);

            return interchange;
        }

        public static X12Interchange GenerateX12<T>(string sample, string rulesNameSpacePrefix = null)
        {
            var items = ParseX12(sample, null, null, rulesNameSpacePrefix).ToList();

            var group = new X12Group<T>(items.OfType<S_GS>().Single());
            group.AddItem(items.OfType<T>().Single());
            var interchange = new X12Interchange(items.OfType<S_ISA>().Single());
            interchange.AddItem(group);

            return interchange;
        }
    }
}
