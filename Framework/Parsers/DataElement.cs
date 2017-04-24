using System.Reflection;

namespace EdiFabric.Framework.Parsers
{
    class DataElement : ParseNode
    {
        public DataElement(PropertyInfo propertyInfo, object instance = null)
            : base(propertyInfo.GetGenericType(), propertyInfo.Name, propertyInfo.Name)
        {
            Value = instance as string;
        }

        public DataElement(ParseNode parseNode)
            : base(parseNode.Type, parseNode.Name, parseNode.EdiName)
        {
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
        }

        public override void Parse(string value, Separators separators)
        {
            IsParsed = true;
            Value = value.UnEscapeLine(separators);
        }

        public override ParseNode InsertRepetition()
        {
            return new DataElement(this);
        }

        public override object ToInstance()
        {
            return Value;
        }
    }
}
