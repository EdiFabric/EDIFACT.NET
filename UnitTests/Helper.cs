using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Framework;
using EdiFabric.Framework.Controls.Edifact;
using EdiFabric.Framework.Controls.X12;

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
            var stream = LoadStream(qualifiedFileName);
            using (var reader = new StreamReader(stream, encoding ?? Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }

        public static string GenerateEdifact<T>(List<object> items, Separators separators, string postFix)
        {
            var interchange = new EdifactInterchange(items.OfType<UNB>().Single());
            EdifactGroup<T> currentGroup = null;
            foreach (var item in items)
            {
                if (item is UNG)
                {
                    currentGroup = new EdifactGroup<T>(item as UNG);
                    interchange.AddItem(currentGroup);
                    continue;
                }

                if (item is UNB) continue;
                if (item is UNE) continue;
                if (item is UNZ) continue;

                if (currentGroup == null)
                {
                    currentGroup = new EdifactGroup<T>(null);
                    interchange.AddItem(currentGroup);
                }
                currentGroup.AddItem((T) item);
            }

            return interchange.GenerateEdi(separators).Aggregate("", (current, item) => current + item + postFix);
        }

        public static string GenerateX12<T>(List<object> items, Separators separators, string postFix)
        {
            var interchange = new X12Interchange(items.OfType<ISA>().Single());
            X12Group<T> currentGroup = null;
            foreach (var item in items)
            {
                if (item is GS)
                {
                    currentGroup = new X12Group<T>(item as GS);
                    interchange.AddItem(currentGroup);
                    continue;
                }

                if (item is ISA) continue;
                if (item is IEA) continue;
                if (item is GE) continue;

                if (currentGroup != null)
                    currentGroup.AddItem((T)item);
            }

            var segments = interchange.GenerateEdi(separators).ToList();
            var ta1 = items.OfType<TA1>().SingleOrDefault();
            if (ta1 != null)
            {
               segments.Insert(1, Ta1ToString(ta1, separators)); 
            }

            return segments.Aggregate("", (current, item) => current + item + postFix);
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
