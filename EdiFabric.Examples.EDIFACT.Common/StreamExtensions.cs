using System.IO;
using System.Text;

namespace EdiFabric.Examples.EDIFACT.Common
{
    public static class StreamExtensions
    {
        public static string LoadToString(this Stream stream)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
