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
using System.Collections.Generic;
using System.Linq;

namespace EdiFabric.Framework.Messages
{
    /// <summary>
    /// This class represents the formal grammar as imported from the definitions class. 
    /// It is a lightweight parent\child relationship structure and is used to define the hierarchy of the EDI as outlined in the standard. 
    /// </summary>
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
        
        public static ParseNode FromType(Type type, bool lazyLoadSegment) 
        {
            if (type == null) throw new ArgumentNullException("type");

            var root = new ParseNode(type);

            var stack = new Stack<ParseNode>();
            stack.Push(root);

            while (stack.Any())
            {
                var currentNode = stack.Pop();

                if (currentNode.Prefix == EdiPrefix.D) continue;
                
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
                    var systemType = propertyInfo.GetSystemType();
                    var name = propertyInfo.Name.StartsWith(EdiPrefix.D.ToString()) ? propertyInfo.Name : systemType.Name;

                    var childParseTree = currentNode.AddChild(systemType, name);                   
                    stack.Push(childParseTree);
                }
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
                throw new ParserException(string.Format("Can't derive node prefix from: {0}", splitName[0]));
            Prefix = prefix;
            EdiName = splitName[1];
            IsEnvelope = Type.FullName.Contains("EdiFabric.Framework.Envelopes");           
        }
    }
}
