using System.IO;
using System.Reflection;
using System.Text;

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

            return Assembly.Load(assemblyName).GetManifestResourceStream(qualifiedFileName);
        }

        public static string LoadString(string qualifiedFileName, Encoding encoding = null)
        {
            return LoadString(LoadStream(qualifiedFileName), encoding);
        }

        public static string LoadString(Stream stream, Encoding encoding = null)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, encoding ?? Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
