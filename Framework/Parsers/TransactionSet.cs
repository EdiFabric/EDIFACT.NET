using System.Collections.Generic;
using System.Linq;

namespace EdiFabric.Framework.Parsers
{
    class TransactionSet : ParseNode
    {
        public TransactionSet(MessageContext messageContext, bool lazyLoad)
            : base(messageContext.SystemType)
        {
            if (lazyLoad) return;

            var stack = new Stack<ParseNode>(new[] { this });

            while (stack.Any())
            {
                var currentNode = stack.Pop();

                foreach (var propertyInfo in currentNode.GetProperties())
                {
                    var c = propertyInfo.Name;

                    var childNode = propertyInfo.ToParseNode();
                    currentNode.AddChild(childNode);

                    if (childNode is Segment) continue;

                    stack.Push(childNode);
                }
            }
        }

        public TransactionSet(object instance)
            : base(instance.GetType())
        {
            BuildFromInstance(instance);
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
