using System.Collections.Generic;
using System.Linq;
using EdiFabric.Annotations.Edi;
using EdiFabric.Annotations.Model;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Validators
{
    public static class EdiMessageExtensions
    {
        public static MessageErrorContext Validate(this EdiMessage instance)
        {
            var visited = new HashSet<object>();
            var stack = new Stack<TraverseItem>();
            var messageContext = new MessageContext(instance);
            var result = new MessageErrorContext(messageContext.Tag, messageContext.ControlNumber);

            stack.Push(new TraverseItem(instance));

            var segmentIndex = 0;

            while (stack.Any())
            {
                var current = stack.Pop();

                if (!(current.Instance is string) && current.Instance != null && !visited.Add(current.Instance))
                    continue;

                if (current.IsType<SegmentAttribute>())
                {
                    segmentIndex++;
                }

                result.AddRange(current.ValidateRequired(segmentIndex));
                
                var neighbours = current.GetNeigbours().Where(p => !visited.Contains(p.Instance));
                foreach (var neighbour in neighbours.Reverse())
                {
                    stack.Push(neighbour);
                }               
            }

            return result;
        }
    }
}
