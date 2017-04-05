using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EdiFabric.Framework.Parsing;

namespace EdiFabric.Framework.Parsing
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
                    var childNode = NewNode(propertyInfo);
                    currentNode.AddChild(childNode);

                    if (childNode is Segment) continue;

                    stack.Push(childNode);
                }
            }
        }

        public TransactionSet(object instance)
            : base(instance.GetType())
        {
            var instanceLinks = new Dictionary<string, object> { { Path, instance } };
            var stack = new Stack<ParseNode>(new[] { this });

            while (stack.Any())
            {
                var currentNode = stack.Pop();

                var path = currentNode.Path;
                object currentInstance;
                if (!instanceLinks.TryGetValue(path, out currentInstance))
                    throw new Exception(string.Format("Instance not set for path: {0}", currentNode.Path));

                if (currentInstance is DataElement) continue;

                var properties = currentNode.GetProperties();
                foreach (var propertyInfo in properties)
                {
                    var node = NewNode(propertyInfo);
                    if (node is DataElement || node is ComplexDataElement)
                    {

                        if (propertyInfo.PropertyType.IsGenericType)
                        {
                            var currentList = propertyInfo.GetValue(currentInstance) as IList;
                            if (currentList == null) continue;

                            if (currentList == null || currentList.Count == 0)
                            {
                                currentNode.AddChild(NewNode(propertyInfo));
                            }
                            else
                            {
                                foreach (var currentValue in currentList)
                                {
                                    if (currentValue == null) continue;

                                    var childParseTree = new DataElement(propertyInfo, (string) currentValue);
                                    currentNode.AddChild(childParseTree);
                                    stack.Push(childParseTree);
                                    instanceLinks.Add(childParseTree.Path, currentValue);
                                }
                            }
                        }
                        else
                        {
                            var currentValue = propertyInfo.GetValue(currentInstance);
                            if (currentValue == null)
                                continue;

                            var childParseTree = new DataElement(propertyInfo, (string) currentValue);
                            currentNode.AddChild(childParseTree);
                            if (currentValue == null) continue;

                            stack.Push(childParseTree);
                            instanceLinks.Add(childParseTree.Path, currentValue);
                        }
                }
            }

                instanceLinks.Remove(path);
            }
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
