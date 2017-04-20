using System;

namespace EdiFabric.Framework.Parsers
{
    class DataElement : ParseNode
    {
        public DataElement(Type type, string name, string ediName)
            : base(type, name, ediName)
        {
        }

        public DataElement(Type type, string name, string ediName, object instance)
            : base(type, name, ediName)
        {
            Value = instance as string;
        }
    }
}
