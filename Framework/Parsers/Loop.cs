using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Framework.Parsers
{
    class Loop : ParseNode
    {
        public Loop(PropertyInfo propertyInfo, object instance = null)
            : base(propertyInfo.GetGenericType(), propertyInfo.Name, propertyInfo.Name)
        {
            IsParsed = true;
            BuildChildren(instance);
        }

        public Loop(ParseNode parseNode)
            : base(parseNode.Type, parseNode.Name, parseNode.EdiName)
        {
            IsParsed = true;
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
            BuildChildren();
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IEnumerable<ParseNode> exclusion)
        {
            var result = new List<ParseNode>();
            result.AddRange(this.ChildrenWithExclusion(exclusion.ToList()));
            result.Add(Children.First());
            result.Add(Parent);
            return result;
        }
    }
}
