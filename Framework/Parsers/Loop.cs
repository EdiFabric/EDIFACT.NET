using System;
using System.Collections.Generic;
using System.Linq;

namespace EdiFabric.Framework.Parsers
{
    class Loop : ParseNode
    {
        public Loop(Type type, string name, string ediName)
            : base(type, name, ediName)
        {
            BuildChildren();
        }

        public Loop(Type type, string name, string ediName, object instance)
            : base(type, name, ediName)
        {
            BuildChildren(instance);
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
