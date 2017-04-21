using System;
using System.Collections.Generic;
using System.Linq;

namespace EdiFabric.Framework.Parsers
{
    class Loop : ParseNode
    {
        public Loop(Type type, string name, string ediName, object instance = null)
            : base(type, name, ediName)
        {
            BuildChildren(instance);
        }

        public Loop(ParseNode parseNode)
            : this(parseNode.Type, parseNode.Name, parseNode.EdiName)
        {
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IList<ParseNode> exclusion)
        {
            var result = new List<ParseNode>();
            result.AddRange(this.ChildrenWithExclusion(exclusion));
            result.Add(Children.First());
            result.Add(Parent);
            return result;
        }
    }
}
