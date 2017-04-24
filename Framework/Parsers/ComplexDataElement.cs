using System;
using System.Linq;
using System.Reflection;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Framework.Parsers
{
    class ComplexDataElement : ParseNode
    {
        public ComplexDataElement(PropertyInfo propertyInfo, object instance = null)
            : base(propertyInfo.GetGenericType(), propertyInfo.Name, propertyInfo.Name)
        {
            BuildChildren(instance, true);
        }

        public ComplexDataElement(ParseNode parseNode)
            : base(parseNode.Type, parseNode.Name, parseNode.EdiName)
        {
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
            BuildChildren(null, true);
        }

        public override void Parse(string value, Separators separators)
        {
            IsParsed = true;
            var index = 0;
            foreach (var currentToParse in value.GetComponentDataElements(separators))
            {
                if (String.IsNullOrEmpty(currentToParse))
                {
                    index++;
                    continue;
                }

                var currentElement = Children.ElementAt(index);
                if (currentElement.IsParsed)
                {
                    currentElement = currentElement.InsertRepetition();
                    index++;
                }
                currentElement.Parse(currentToParse, separators);
                index++;
            }
        }

        public override ParseNode InsertRepetition()
        {
            return new ComplexDataElement(this);
        }
    }
}
