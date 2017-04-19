using System.Collections.Generic;
using System.Reflection;

namespace EdiFabric.Framework.Parsers
{
    class AllLoop : ParseNode
    {
        public AllLoop(PropertyInfo propertyInfo)
            : base(propertyInfo)
        {
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
