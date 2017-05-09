using System.Collections.Generic;
using System.IO;
using System.Text;
using EdiFabric.Core.Model;
using EdiFabric.Core.Model.X12;
using EdiFabric.Framework.Writers;

namespace EdiFabric.UnitTests.Hipaa
{
    public class Helper
    {
        public static string Generate(List<object> items, Separators separators, string postFix,
            Encoding encoding = null)
        {
            using (var stream = new MemoryStream())
            {
                var writer = new X12Writer(stream, encoding, postFix);
                foreach (var item in items)
                {
                    var message = item as EdiMessage;
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

                return CommonHelper.LoadString(stream);
            }
        }
    }
}
