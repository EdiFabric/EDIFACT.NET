using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Framework.Parsers
{
    class Loop : ParseNode
    {
        public Loop(PropertyInfo propertyInfo)
            : base(propertyInfo)
        {
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
