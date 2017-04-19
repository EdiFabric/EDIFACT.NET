using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using EdiFabric.Framework;
using EdiFabric.Framework.Controls;
using EdiFabric.Framework.Controls.Edifact;
using EdiFabric.Framework.Controls.X12;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Tests
{
    internal class TestHelper
    {
        public static Stream LoadStream(string qualifiedFileName)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(qualifiedFileName);
        }

        public static string LoadString(string qualifiedFileName, Encoding encoding = null)
        {
            var stream = LoadStream(qualifiedFileName);
            using (var reader = new StreamReader(stream, encoding ?? Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }

        public static string AsString(string qualifiedFileName, bool withLfCr = true)
        {
            using (var reader = new StreamReader(LoadStream(qualifiedFileName), Encoding.Default))
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
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StreamReader(stream))
            {
                return (T) serializer.Deserialize(reader);
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

            return AsString(interchange.GenerateEdi(separators), postFix);
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

            return AsString(segments, postFix);
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
