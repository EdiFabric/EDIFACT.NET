using System;

namespace EdiFabric.Framework.Parsers
{
    class ComplexDataElement : ParseNode
    {
        public ComplexDataElement(Type type, string name, string ediName)
            : base(type, name, ediName)
        {
            BuildChildren();
        }

        public ComplexDataElement(Type type, string name, string ediName, object instance)
            : base(type, name, ediName)
        {
            BuildChildren(instance, true);
        }
    }
}
