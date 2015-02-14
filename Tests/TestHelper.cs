using System.IO;
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
    }
}
