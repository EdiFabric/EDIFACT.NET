using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EdiFabric.Tests
{
    class TestHelper
    {
        public static XElement Serialize<T>(T instance, string nameSpace)
        {
            // Fix: using instance.GetType() instead of typeof(T)
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
    }
}
