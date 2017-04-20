using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Framework.Parsers
{
    class ParseNode 
    {
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

        protected ParseNode(Type type, string name, string ediName)
        {
            Type = type;
            Name = name;
            EdiName = ediName;
        }

        public void BuildChildren()
        {
            foreach (var property in GetProperties())
            {
                AddChild(property.ToParseNode());
            }
        }

        public void BuildChildren(object instance, bool allowNulls = false)
        {
            foreach (var property in GetProperties())
            {
                if (instance == null)
                {
                    AddChild(property.ToParseNode());
                    continue;
                }

                if (property.PropertyType.IsGenericType)
                {
                    var currentList = property.GetValue(instance) as IList;
                    if (currentList == null) continue;

                    foreach (var currentValue in currentList)
                    {
                        if (!allowNulls && currentValue == null) continue;

                        var childParseTree = property.ToParseNode(currentValue);
                        AddChild(childParseTree);
                    }
                }
                else
                {
                    var currentValue = property.GetValue(instance);
                    if (!allowNulls && currentValue == null) continue;

                    AddChild(property.ToParseNode(currentValue));
                }
            }
        }
        
        public void AddChild(ParseNode node)
        {
            node.Parent = this;
            _children.Add(node);
        }

        public void InsertChild(int position, ParseNode node)
        {
            node.Parent = this;
            _children.Insert(position, node);
        }
       
        public IEnumerable<PropertyInfo> GetProperties()
        {
            return Type.GetProperties().Sort();
        }

        public virtual IEnumerable<ParseNode> NeighboursWithExclusion(IList<ParseNode> exclusion)
        {
            throw new NotImplementedException(Type.FullName);
        }
    }
}
