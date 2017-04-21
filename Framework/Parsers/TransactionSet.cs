using System;
using System.Collections.Generic;
using System.Linq;

namespace EdiFabric.Framework.Parsers
{
    class TransactionSet : ParseNode
    {
        public TransactionSet(Type type, object instance = null)
            : base(type, type.Name, type.Name)
        {
            BuildChildren(instance);
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IList<ParseNode> exclusion)
        {
            var result = new List<ParseNode>();
            result.AddRange(this.ChildrenWithExclusion(exclusion));
            if (!result.Any())
                result.AddRange(Children);
            return result;
        }

        
    }
}
