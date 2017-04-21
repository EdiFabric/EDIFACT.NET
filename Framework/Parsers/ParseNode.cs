using System;
using System.Collections;
using System.Collections.Generic;
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
        public bool IsParsed { get; set; }
        
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
            IsParsed = false;
        }

        public void BuildChildren(object instance = null, bool allowNulls = false)
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

        public virtual void Parse(string value, Separators separators)
        {
            throw new NotImplementedException(Type.FullName);
        }

        public virtual ParseNode InsertRepetition()
        {
            throw new NotImplementedException(Type.FullName);
        }

        public virtual object ToInstance()
        {
            var result = Activator.CreateInstance(Type);

            var listTypes = new Dictionary<string, IList>();
            foreach (var nodeChild in Children)
            {
                if (!nodeChild.IsParsed) continue;

                var propertyInfo = Type.GetProperty(nodeChild.Name);
                if (propertyInfo == null)
                    throw new Exception(string.Format("Property {0} was not found in type {1}", nodeChild.Name,
                        Type.Name));

                if (propertyInfo.PropertyType.IsGenericType)
                {
                    IList list;
                    if (!listTypes.TryGetValue(propertyInfo.MetadataToken.ToString(), out list))
                    {
                        list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(nodeChild.Type));
                        propertyInfo.SetValue(result, list, null);

                        listTypes.Clear();
                        listTypes.Add(propertyInfo.MetadataToken.ToString(), list);
                    }

                    list.Add(nodeChild.ToInstance());
                }
                else
                {
                    propertyInfo.SetValue(result, nodeChild.ToInstance(), null);
                }                
            }

            return result;
        }
    }
}
