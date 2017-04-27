using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using EdiFabric.Attributes;
using EdiFabric.Framework;
using EdiFabric.Framework.Segments.Edifact;
using EdiFabric.Framework.Segments.X12;
using EdiFabric.Framework.Writers;

namespace EdiFabric.UnitTests
{
    public class Helper
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

        public static string GenerateEdifact(List<object> items, Separators separators, string postFix,
            Encoding encoding = null, string una = null)
        {
            using (var stream = new MemoryStream())
            {
                var writer = new EdifactWriter(stream, encoding, postFix);
                if (!string.IsNullOrEmpty(una))
                    writer.WriteSegment(una);
                foreach (var item in items)
                {
                    var message = item as IEdiMessage;
                    if (message != null)
                    {
                        writer.WriteMessage(message);
                        continue;
                    }

                    var gs = item as UNG;
                    if (gs != null)
                    {
                        writer.WriteGroup(gs);
                        continue;
                    }

                    var ge = item as UNE;
                    if (ge != null)
                    {
                        continue;
                    }

                    var unb = item as UNB;
                    if (unb != null)
                    {
                        writer.WriteInterchange(unb, separators);
                    }
                }
                writer.Flush();

                return LoadString(stream);
            }
        }

        public static string GenerateX12(List<object> items, Separators separators, string postFix,
            Encoding encoding = null)
        {
            using (var stream = new MemoryStream())
            {
                var writer = new X12Writer(stream, encoding, postFix);
                foreach (var item in items)
                {
                    var message = item as IEdiMessage;
                    if (message != null)
                    {
                        writer.WriteMessage(message);
                        continue;
                    }

                    var gs = item as GS;
                    if (gs != null)
                    {
                        writer.WriteGroup(gs);
                        continue;
                    }

                    var ge = item as GE;
                    if (ge != null)
                    {
                        continue;
                    }

                    var ta1 = item as TA1;
                    if (ta1 != null)
                    {
                        writer.WriteSegment(ta1.ToString(separators));
                    }

                    var isa = item as ISA;
                    if (isa != null)
                    {
                        writer.WriteInterchange(isa, separators);
                    }
                }
                writer.Flush();

                return LoadString(stream);
            }
        }
    } 
}
