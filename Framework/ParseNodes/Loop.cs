using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EdiFabric.Framework.Parsing
{
    class Loop : ParseNode
    {
        public Loop(PropertyInfo propertyInfo) : base(propertyInfo)
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
