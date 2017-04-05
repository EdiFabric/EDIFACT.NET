using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Framework.Parsing
{
    class ParseNode 
    {
        public PropertyInfo PropertyInfo { get; private set; }
        public string Name { get; private set; }
        public string EdiName { get; private set; }
        public ParseNode Parent { get; private set; }
        public Type Type { get; private set; }
        public string Value { get; set; }

        public string Path
        {
            get
            {
                return this.AncestorsAndSelf()
                    .Aggregate("", (current, node) => current + node.Name + node.IndexInParent());
            }
        }

        public int IndexOfChild(ParseNode child)
        {
            return _children.IndexOf(child);
        }

        public int IndexInParent()
        {
            return Parent != null ? Parent.IndexOfChild(this) : -1;
        }

        private readonly List<ParseNode> _children = new List<ParseNode>();
        public IReadOnlyCollection<ParseNode> Children
        {
            get { return _children.AsReadOnly(); }
        }

        protected ParseNode(PropertyInfo propertyInfo, string ediName = null)
        {
            var systemType = propertyInfo.PropertyType;
            if (systemType.IsGenericType)
                 systemType = systemType.GenericTypeArguments.First();

            Type = systemType;
            Name = propertyInfo.Name;
            EdiName = ediName ?? Name;
            PropertyInfo = propertyInfo;
         }

        protected ParseNode(Type type)
        {
            Type = type;
            Name = type.Name;
            EdiName = type.Name;
            PropertyInfo = null;
        }
        
        public void AddChild(ParseNode node)
        {
            node.Parent = this;
            _children.Add(node);
        }
       
        public IEnumerable<PropertyInfo> GetProperties()
        {
            return Type.GetProperties().Sort();
        }

        public virtual IEnumerable<ParseNode> NeighboursWithExclusion(IList<ParseNode> exclusion)
        {
            throw new NotImplementedException(Type.FullName);
        }

        protected void BuildFromInstance(object instance)
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

                if (currentNode is DataElement || currentInstance == null) continue;

                var properties = currentNode.GetProperties();
                foreach (var propertyInfo in properties)
                {
                    var node = propertyInfo.ToParseNode();
                    if (propertyInfo.PropertyType.IsGenericType)
                    {
                        var currentList = propertyInfo.GetValue(currentInstance) as IList;
                        if (currentList == null && !(node is DataElement) && !(node is ComplexDataElement)) continue;

                        if (currentList == null || currentList.Count == 0)
                        {
                            currentNode.AddChild(propertyInfo.ToParseNode());
                        }
                        else
                        {
                            foreach (var currentValue in currentList)
                            {
                                if (currentValue == null) continue;

                                var childParseTree = propertyInfo.ToParseNode(currentValue);
                                currentNode.AddChild(childParseTree);
                                
                                stack.Push(childParseTree);
                                instanceLinks.Add(childParseTree.Path, currentValue);
                            }
                        }
                    }
                    else
                    {
                        var currentValue = propertyInfo.GetValue(currentInstance);
                        if (currentValue == null && !(node is DataElement) && !(node is ComplexDataElement))
                            continue;

                        var childParseTree = propertyInfo.ToParseNode(currentValue);
                        currentNode.AddChild(childParseTree);
                        if (currentValue == null) continue;

                        stack.Push(childParseTree);
                        instanceLinks.Add(childParseTree.Path, currentValue);
                    }

                }

                instanceLinks.Remove(path);
            }
        }
    }
}
