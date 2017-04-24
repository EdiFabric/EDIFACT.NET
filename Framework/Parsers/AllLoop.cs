using System.Collections.Generic;
using System.Reflection;

namespace EdiFabric.Framework.Parsers
{
    class AllLoop : ParseNode
    {
        public AllLoop(PropertyInfo propertyInfo, object instance = null)
            : base(propertyInfo.GetGenericType(), propertyInfo.Name, propertyInfo.Name)
        {
            IsParsed = true;
            BuildChildren(instance);
        }

        public AllLoop(ParseNode parseNode)
            : base(parseNode.Type, parseNode.Name, parseNode.EdiName)
        {
            IsParsed = true;
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
            BuildChildren();
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IEnumerable<ParseNode> exclusion)
        {
            var result = new List<ParseNode>();
            result.AddRange(Children);
            result.Add(Parent);
            return result;
        }
    }
}
