using System;
using System.Collections.Generic;

namespace EdiFabric.Framework.Parsers
{
    class AllLoop : ParseNode
    {
        public AllLoop(Type type, string name, string ediName)
            : base(type, name, ediName)
        {
            BuildChildren();
        }

        public AllLoop(Type type, string name, string ediName, object instance)
            : base(type, name, ediName)
        {
            BuildChildren(instance);
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
