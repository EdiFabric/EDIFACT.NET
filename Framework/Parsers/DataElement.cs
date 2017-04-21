using System;

namespace EdiFabric.Framework.Parsers
{
    class DataElement : ParseNode
    {
        public DataElement(Type type, string name, string ediName, object instance = null)
            : base(type, name, ediName)
        {
            Value = instance as string;
        }

        public DataElement(ParseNode parseNode)
            : this(parseNode.Type, parseNode.Name, parseNode.EdiName)
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
    }
}
