using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EdiFabric.Framework.Parsing
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
