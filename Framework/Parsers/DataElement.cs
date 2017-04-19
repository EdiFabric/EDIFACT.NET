using System.Reflection;

namespace EdiFabric.Framework.Parsers
{
    class DataElement : ParseNode
    {
        public DataElement(PropertyInfo propertyInfo, string value = null)
            : base(propertyInfo)
        {
            Value = value;
        }

    }
}
