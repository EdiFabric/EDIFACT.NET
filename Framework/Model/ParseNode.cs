//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace EdiFabric.Framework.Model
{
    class ParseNode 
    {
        public TypeInfo TypeInfo { get; private set; }
        public string Name { get; private set; }
        public string EdiName { get; private set; }
        public ParseNode Parent { get; private set; }
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

        protected ParseNode(TypeInfo typeInfo, string name, string ediName)
        {
            TypeInfo = typeInfo;
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

                if (property.GetStandardType().IsGenericType)
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

        public void RemoveChild(ParseNode node)
        {
            _children.Remove(node);
        }
       
        public IEnumerable<PropertyInfo> GetProperties()
        {
            return TypeInfo.GetProperties(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance).Sort();
        }

        public virtual IEnumerable<ParseNode> NeighboursWithExclusion(IEnumerable<ParseNode> exclusion)
        {
            throw new NotImplementedException(TypeInfo.FullName);
        }

        public virtual void Parse(string value, Separators separators, bool allowPartial)
        {
            throw new NotImplementedException(TypeInfo.FullName);
        }

        public virtual ParseNode InsertRepetition()
        {
            throw new NotImplementedException(TypeInfo.FullName);
        }

        public virtual void SetParsed()
        {
            IsParsed = true;
            if (Parent != null && !Parent.IsParsed)
                Parent.SetParsed();
        }

        public virtual object ToInstance()
        {
            var result = Activator.CreateInstance(TypeInfo.AsType());

            var listTypes = new Dictionary<string, IList>();
            foreach (var nodeChild in Children)
            {
                if (!nodeChild.IsParsed) continue;

                var propertyInfo = TypeInfo.GetProperty(nodeChild.Name);
                if (propertyInfo == null)
                    throw new Exception(string.Format("Property {0} was not found in type {1}", nodeChild.Name,
                        TypeInfo.Name));

                if (propertyInfo.GetStandardType().IsGenericType)
                {
                    IList list;
                    if (!listTypes.TryGetValue(propertyInfo.MetadataToken.ToString(), out list))
                    {
                        list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(nodeChild.TypeInfo.AsType()));
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
