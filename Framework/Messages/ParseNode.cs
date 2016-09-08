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

namespace EdiFabric.Framework.Messages
{
    class ParseNode 
    {
        public Type Type { get; private set; }
        public string Name { get; private set; }
        public string EdiName { get; private set; }
        public EdiPrefix Prefix { get; private set; }
        public ParseNode Parent { get; private set; }
        public string Value { get; private set; }
        public bool IsEnvelope { get; private set; }

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
            get { return Parent != null && Parent.Prefix == EdiPrefix.G && IndexInParent() == 0; }
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

            var systemType = propertyInfo.GetSystemType();
            var name = propertyInfo.Name.StartsWith(EdiPrefix.D.ToString())
                ? propertyInfo.Name
                : systemType.Name;
            var val = value as string;

            if (value != null && value.GetType().IsEnum)
            {
                val = value.ToString();
                if (val.StartsWith("Item"))
                {
                    val = val.Substring(4);
                }
            }
            
            return AddChild(systemType, name, val);
        }
        
        public static ParseNode BuldTree(Type type, bool lazyLoadSegment) 
        {
            if (type == null) throw new ArgumentNullException("type");
            if (type.Name.StartsWith(EdiPrefix.D.ToString()))
                throw new ParserException(string.Format("DataElement is not supported: {0}", type.Name));

            var root = new ParseNode(type);

            var stack = new Stack<ParseNode>();
            stack.Push(root);

            while (stack.Any())
            {
                var currentNode = stack.Pop();

                var properties = currentNode.Type.GetProperties().Sort();
                if (currentNode.Prefix == EdiPrefix.S)
                {
                    if (properties.Count > 0)
                        currentNode._firstChildValues = properties[0].GetProperyValues();
                    if (properties.Count > 1)
                        currentNode._secondChildValues = properties[1].GetProperyValues();

                    if (lazyLoadSegment) continue;
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
            if (type.Name.StartsWith(EdiPrefix.D.ToString()))
                throw new ParserException(string.Format("DataElement is not supported: {0}", type.Name));

            var root = new ParseNode(type);
            var instanceLinks = new Dictionary<string, object> {{root.Path, instance}};

            var stack = new Stack<ParseNode>();
            stack.Push(root);

            while (stack.Any())
            {
                var currentNode = stack.Pop();

                var path = currentNode.Path;
                object currentInstance;
                if (!instanceLinks.TryGetValue(path, out currentInstance))
                    throw new Exception(string.Format("Instance not set for path: {0}", currentNode.Path));

                var properties = currentNode.Type.GetProperties().Sort();
                foreach (var propertyInfo in properties)
                {
                    if (propertyInfo.IsList())
                    {
                        var currentList = propertyInfo.GetValue(currentInstance) as IList;
                        if (currentList == null) continue;

                        foreach (var currentValue in currentList)
                        {
                            if (currentValue == null) continue;

                            var currentProperty = propertyInfo.PropertyType.GetProperty("Item");
                            var childParseTree = currentNode.AddChild(currentProperty, currentValue);
                            stack.Push(childParseTree);

                            instanceLinks.Add(childParseTree.Path, currentValue);
                        }
                    }
                    else
                    {
                        var currentValue = propertyInfo.GetValue(currentInstance);
                        if (currentValue == null) continue;

                        var childParseTree = currentNode.AddChild(propertyInfo, currentValue);
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
                throw new ParserException(string.Format("Invalid node name: {0}", Name));
            EdiPrefix prefix;
            if (!Enum.TryParse(splitName[0], out prefix))
                throw new ParserException(string.Format("Cannot derive node prefix from: {0}", splitName[0]));
            Prefix = prefix;
            EdiName = splitName[1];
            IsEnvelope = Type.FullName.Contains("EdiFabric.Framework.Envelopes");           
        }
    }
}
