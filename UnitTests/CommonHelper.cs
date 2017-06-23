using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.UnitTests
{
    public class CommonHelper
    {
        public static Stream LoadStream(string qualifiedFileName, bool noType = true)
        {
            var parts = qualifiedFileName.Split('.');
            var assemblyName = parts[0] + "." + parts[1];
            if (noType)
                assemblyName = assemblyName + "." + parts[2];

            return Assembly.Load(new AssemblyName(assemblyName)).GetManifestResourceStream(qualifiedFileName);
        }

        public static string LoadString(string qualifiedFileName, Encoding encoding = null, bool noType = true)
        {
            return LoadString(LoadStream(qualifiedFileName, noType), encoding);
        }

        public static string LoadString(Stream stream, Encoding encoding = null)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, encoding ?? Encoding.GetEncoding(0)))
            {
                return reader.ReadToEnd();
            }
        }

        public static XDocument Serialize(EdiMessage instance, Encoding encoding = null)
        {
            if (instance == null)
                throw new ArgumentNullException("instance");

            var serializer = new XmlSerializer(instance.GetType());
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, instance);
                ms.Position = 0;
                var str = LoadString(ms, encoding);
                return XDocument.Parse(str);
            }
        }
    }
}
