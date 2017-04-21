using System;
using System.Collections.Generic;

namespace EdiFabric.Framework.Parsers
{
    class AllLoop : ParseNode
    {
        public AllLoop(Type type, string name, string ediName, object instance = null)
            : base(type, name, ediName)
        {
            BuildChildren(instance);
        }

        public AllLoop(ParseNode parseNode)
            : this(parseNode.Type, parseNode.Name, parseNode.EdiName)
        {
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IList<ParseNode> exclusion)
        {
            var result = new List<ParseNode>();
            result.AddRange(Children);
            result.Add(Parent);
            return result;
        }
    }
}
