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
using System.Reflection;

namespace EdiFabric.Framework.Messages
{
    /// <summary>
    /// This class represents the formal grammar as imported from the definitions class. 
    /// It is a lightweight parent\child relationship structure and is used to define the hierarchy of the EDI as outlined in the standard. 
    /// </summary>
    class ParseTree 
    {
        public Type Type { get; private set; }
        public string Name { get; private set; }
        public string EdiName { get; private set; }
        public EdiPrefix Prefix { get; private set; }
        public ParseTree Parent { get; private set; }

        private readonly List<ParseTree> _children;
        public IReadOnlyCollection<ParseTree> Children
        {
            get { return _children.AsReadOnly(); }
        }
        
        private List<string> _firstChildValues;
        public IReadOnlyCollection<string> FirstChildValues
        {
            get { return _firstChildValues.AsReadOnly(); }
        }

        private List<string> _secondChildValues;
        public IReadOnlyCollection<string> SecondChildValues
        {
            get { return _secondChildValues.AsReadOnly(); }
        }

        public bool IsEnvelope { get; private set; }
        public bool IsTrigger
        {
            get { return Parent != null && Parent.Prefix == EdiPrefix.G && Parent.IndexOfChild(this) == 0; }
        }

        public int IndexOfChild(ParseTree child)
        {
            return _children.IndexOf(child);
        }
        
        public ParseTree(Type type, bool lazyLoadSegment) : this(type)
        {
            if (type == null) throw new ArgumentNullException("type");

            var stack = new Stack<ParseTree>();
            stack.Push(this);

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
                    var childParseTree = new ParseTree(propertyInfo, currentNode);
                    currentNode._children.Add(childParseTree);
                    
                    stack.Push(childParseTree);
                }
            }
        }

        private ParseTree(PropertyInfo propertyInfo, ParseTree parent)
            : this(
                propertyInfo.GetSystemType(),
                propertyInfo.Name.StartsWith(EdiPrefix.D.ToString()) ? propertyInfo.Name : null)
        {
            Parent = parent;
        }

        private ParseTree(Type type, string name = null)
        {
            if (type == null) throw new ArgumentNullException("type");

            Type = type;
            IsEnvelope = Type.FullName.Contains("EdiFabric.Framework.Envelopes");
            Name = string.IsNullOrEmpty(name) ? Type.Name : name;
            var splitName = Name.Split('_');
            if(splitName.Length < 2) throw new ParserException(string.Format("Invalid node name: {0}", Name));
            EdiName = splitName[1];
            Prefix = (EdiPrefix) Enum.Parse(typeof (EdiPrefix), splitName[0]);
            _children = new List<ParseTree>();
        }
    }
}
