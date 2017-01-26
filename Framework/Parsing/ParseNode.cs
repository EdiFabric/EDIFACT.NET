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
using System.Linq;
using System.Reflection;

namespace EdiFabric.Framework.Parsing
{
    class ParseNode 
    {
        public Type Type { get; private set; }
        public string Name { get; private set; }
        public string EdiName { get; private set; }
        public Prefixes Prefix { get; private set; }
        public ParseNode Parent { get; private set; }
        public string Value { get; private set; }
        
        private readonly List<ParseNode> _children = new List<ParseNode>();
        public IReadOnlyCollection<ParseNode> Children
        {
            get { return _children.AsReadOnly(); }
        }

        private List<string> _firstChildValues = new List<string>();
        public IReadOnlyCollection<string> FirstChildValues
        {
            get { return _firstChildValues.AsReadOnly(); }
        }

        private List<string> _secondChildValues = new List<string>();
        public IReadOnlyCollection<string> SecondChildValues
        {
            get { return _secondChildValues.AsReadOnly(); }
        }
        
        public bool IsTrigger
        {
            get { return Parent != null && Parent.Prefix == Prefixes.G && IndexInParent() == 0; }
        }

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

        public ParseNode AddChild(Type type, string name, string value = null)
        {
            if (type == null) throw new ArgumentNullException("type");
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            var node = new ParseNode(type, name, this, value);
            _children.Add(node);
            return node;
        }

        public ParseNode AddChild(PropertyInfo propertyInfo, object value = null)
        {
            if (propertyInfo == null) throw new ArgumentNullException("propertyInfo");

            var systemType = propertyInfo.PropertyType;
            if (systemType.IsGenericType)
                systemType = systemType.GenericTypeArguments.First();
            
            return AddChild(systemType, propertyInfo.Name, propertyInfo.GetPropertyValue(value));
        }
        
        public static ParseNode BuldTree(Type type, bool lazyLoadSegment) 
        {
            if (type == null) throw new ArgumentNullException("type");
            if (type.Name.StartsWith(Prefixes.D.ToString(), StringComparison.Ordinal))
                throw new Exception(string.Format("DataElement is not supported: {0}", type.Name));

            var root = new ParseNode(type);
            var stack = new Stack<ParseNode>(new[] { root }); 
            
            while (stack.Any())
            {
                var currentNode = stack.Pop();

                if (currentNode.Prefix == Prefixes.D) continue;

                var properties = currentNode.Type.GetProperties().Sort();
                if (currentNode.Prefix == Prefixes.S && lazyLoadSegment)
                {
                    var firstTwo = properties.GetFirstTwoPropertyValues();
                    currentNode._firstChildValues = firstTwo.Item1;
                    currentNode._secondChildValues = firstTwo.Item2;

                    continue;
                }

                foreach (var propertyInfo in properties)
                {
                    var childParseTree = currentNode.AddChild(propertyInfo);                   
                    stack.Push(childParseTree);
                }
            }

            return root;
        }

        public static ParseNode BuldTree(object instance)
        {
            if (instance == null) throw new ArgumentNullException("instance");

            var type = instance.GetType();
            if (type.Name.StartsWith(Prefixes.D.ToString(), StringComparison.Ordinal))
                throw new Exception(string.Format("DataElement is not supported: {0}", type.Name));

            var root = new ParseNode(type);
            var instanceLinks = new Dictionary<string, object> {{root.Path, instance}};
            var stack = new Stack<ParseNode>(new[] { root }); 
           
            while (stack.Any())
            {
                var currentNode = stack.Pop();

                var path = currentNode.Path;
                object currentInstance;
                if (!instanceLinks.TryGetValue(path, out currentInstance))
                    throw new Exception(string.Format("Instance not set for path: {0}", currentNode.Path));

                if (currentInstance == null || currentNode.Prefix == Prefixes.D) continue;

                var properties = currentNode.Type.GetProperties().Sort();
                foreach (var propertyInfo in properties)
                {
                    if (propertyInfo.PropertyType.IsGenericType)
                    {
                        var currentList = propertyInfo.GetValue(currentInstance) as IList;
                        if (currentList == null && !propertyInfo.Name.StartsWith(Prefixes.D.ToString(), StringComparison.Ordinal) &&
                            !propertyInfo.Name.StartsWith(Prefixes.C.ToString(), StringComparison.Ordinal)) continue;

                        if (currentList == null || currentList.Count == 0)
                        {
                            currentNode.AddChild(propertyInfo);
                        }
                        else
                        {
                            foreach (var currentValue in currentList)
                            {
                                if (currentValue == null) continue;

                                var childParseTree = currentNode.AddChild(propertyInfo, currentValue);
                                stack.Push(childParseTree);
                                instanceLinks.Add(childParseTree.Path, currentValue);
                            }
                        }                       
                    }
                    else
                    {
                        var currentValue = propertyInfo.GetValue(currentInstance);
                        if (currentValue == null && !propertyInfo.Name.StartsWith(Prefixes.D.ToString(), StringComparison.Ordinal) &&
                            !propertyInfo.Name.StartsWith(Prefixes.C.ToString(), StringComparison.Ordinal)) continue;

                        var childParseTree = currentNode.AddChild(propertyInfo, currentValue);
                        if (currentValue == null) continue;
                        
                        stack.Push(childParseTree);
                        instanceLinks.Add(childParseTree.Path, currentValue);
                    }
                }

                instanceLinks.Remove(path);
            }

            return root;
        }

        public ParseNode(Type type, ParseNode parent = null, string value = null) : this(type, type.Name, parent, value)
        {
        }

        private ParseNode(Type type, string name, ParseNode parent = null, string value = null)
        {
            if (type == null) throw new ArgumentNullException("type");
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            Type = type;            
            Name = name;
            Parent = parent;
            Value = value;
            var splitName = Name.Split('_');
            if (splitName.Length < 2) 
                throw new Exception(string.Format("Invalid node name: {0}", Name));
            Prefixes prefix;
            if (!Enum.TryParse(splitName[0], out prefix))
                throw new Exception(string.Format("Cannot derive node prefix from: {0}", splitName[0]));
            Prefix = prefix;
            EdiName = splitName[1];           
        }
    }
}
