using System.Reflection;

namespace EdiFabric.Framework.Parsers
{
    class ComplexDataElement : ParseNode
    {
        public ComplexDataElement(PropertyInfo propertyInfo)
            : base(propertyInfo)
        {
        }
    }
}
