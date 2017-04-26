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

        public static string GenerateEdifact(List<object> items, Separators separators, string postFix, Encoding encoding = null, bool una = false)
        {
            string result;
            using (var stream = new MemoryStream())
            {
                var writer = new EdifactWriter(stream, postFix, encoding);
                if(una)
                    writer.AddUna(separators);
                foreach (var item in items)
                {
                    var message = item as IEdiMessage;
                    if (message != null)
                    {
                        writer.AddMessage(message);
                        continue;
                    }
                    
                    var gs = item as UNG;
                    if (gs != null)
                    {
                        writer.BeginGroup(gs);
                        continue;
                    }

                    var ge = item as UNE;
                    if (ge != null)
                    {
                        writer.EndGroup();
                        continue;
                    }

                    var unb = item as UNB;
                    if (unb != null)
                    {
                        writer.BeginInterchange(unb, separators);
                        continue;
                    }

                    var iea = item as UNZ;
                    if (iea != null)
                    {
                        writer.EndInterchange();
                    }
                }

                result = LoadString(stream);

            }

            return result;
        }

        public static string GenerateX12(List<object> items, Separators separators, string postFix, Encoding encoding = null)
        {
            string result;
            using (var stream = new MemoryStream())
            {
                var writer = new X12Writer(stream, postFix, encoding);
                foreach (var item in items)
                {
                    var message = item as IEdiMessage;
                    if (message != null)
                    {
                        writer.AddMessage(message);
                        continue;
                    }

                    var gs = item as GS;
                    if (gs != null)
                    {
                        writer.BeginGroup(gs);
                        continue;
                    }

                    var ge = item as GE;
                    if (ge != null)
                    {
                        writer.EndGroup();
                        continue;
                    }

                    var ta1 = item as TA1;
                    if (ta1 != null)
                    {
                        writer.AddTa1(ta1);
                    }

                    var isa = item as ISA;
                    if (isa != null)
                    {
                        writer.BeginInterchange(isa, separators);
                        continue;
                    }

                    var iea = item as IEA;
                    if (iea != null)
                    {
                        writer.EndInterchange();
                    }
                }

                result = LoadString(stream);
                
            }

            return result;
        }

        private static string Ta1ToString(TA1 ta1, Separators separators)
        {
            var result = "TA1" + separators.DataElement + ta1.InterchangeControlNumber_1;
            if (!string.IsNullOrEmpty(ta1.InterchangeDate_2))
            {
                result = result + separators.DataElement + ta1.InterchangeDate_2;
            }
            if (!string.IsNullOrEmpty(ta1.InterchangeTime_3))
            {
                result = result + separators.DataElement + ta1.InterchangeTime_3;
            }
            if (!string.IsNullOrEmpty(ta1.InterchangeAcknowledgmentCode_4))
            {
                result = result + separators.DataElement + ta1.InterchangeAcknowledgmentCode_4;
            }
            if (!string.IsNullOrEmpty(ta1.InterchangeNoteCode_5))
            {
                result = result + separators.DataElement + ta1.InterchangeNoteCode_5;
            }

            return result + separators.Segment;
        }
    } 
}
