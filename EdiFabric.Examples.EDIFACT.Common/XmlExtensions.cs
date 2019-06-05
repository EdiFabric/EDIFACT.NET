using EdiFabric.Core.Model.Edi;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EdiFabric.Examples.EDIFACT.Common
{
    public static class XmlExtensions
    {
        public static XDocument Serialize(this EdiMessage instance)
        {
            if (instance == null)
                throw new ArgumentNullException("instance");

            var serializer = new XmlSerializer(instance.GetType());
            using (var ms = new MemoryStream())
            {
                serializer.Serialize(ms, instance);
                ms.Position = 0;
                return XDocument.Load(ms, LoadOptions.PreserveWhitespace);
            }
        }

        public static T Deserialize<T>(this XElement xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(xml.CreateReader());
        }

        public static XDocument SerializeDataContract(this EdiMessage instance)
        {
            if (instance == null)
                throw new ArgumentNullException("instance");

            var serializer = new DataContractSerializer(instance.GetType());
            using (var ms = new MemoryStream())
            {
                serializer.WriteObject(ms, instance);
                ms.Position = 0;
                return XDocument.Load(ms, LoadOptions.PreserveWhitespace);
            }
        }

        public static T DeserializeDataContract<T>(this XElement xml)
        {
            var serializer = new DataContractSerializer(typeof(T));
            return (T)serializer.ReadObject(xml.CreateReader());
        }
    }
}
