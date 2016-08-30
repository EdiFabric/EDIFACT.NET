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
        public Type SystemType { get; private set; }
        public PropertyInfo SystemProperty { get; private set; }
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
        public IReadOnlyCollection<string> FirstChildValues {
            get { return _firstChildValues.AsReadOnly(); }
        }
        private List<string> _secondChildValues;
        public IReadOnlyCollection<string> SecondChildValues
        {
            get { return _secondChildValues.AsReadOnly(); }
        }

        public bool IsEnvelope { get; private set; }
        public bool IsTrigger { get; private set; }

        public int IndexOfChild(ParseTree child)
        {
            return _children.IndexOf(child);
        }
        
        public ParseTree(Type systemType, bool lazyLoadSegment) : this(systemType)
        {
            if (systemType == null) throw new ArgumentNullException("systemType");

            var stack = new Stack<ParseTree>();
            stack.Push(this);

            while (stack.Any())
            {
                var currentNode = stack.Pop();

                if (currentNode.Prefix == EdiPrefix.D) continue;
                
                var properties = currentNode.SystemType.GetProperties().Sort();

                if (currentNode.Prefix == EdiPrefix.S)
                {
                    currentNode._firstChildValues = properties.Count > 0
                        ? properties[0].GetProperyValues()
                        : null;
                    currentNode._secondChildValues = properties.Count > 1
                        ? properties[1].GetProperyValues()
                        : null;
                    currentNode.IsTrigger = currentNode.Parent != null && currentNode.Parent.Prefix == EdiPrefix.G &&
                                            currentNode.Parent.IndexOfChild(currentNode) == 0;

                    if (lazyLoadSegment) continue;
                }

                foreach (var propertyInfo in properties)
                {
                    var childParseTree = new ParseTree(propertyInfo) {Parent = currentNode};
                    currentNode._children.Add(childParseTree);
                    
                    stack.Push(childParseTree);
                }
            }
        }

        //public void AddChild(ParseTree newChild)
        //{
        //    var previous = _children.Last(c => c.Name == newChild.Name);
        //    var index = IndexOfChild(previous);
        //    _children.Insert(index + 1, newChild);
        //}

        private ParseTree(PropertyInfo propertyInfo)
            : this(
                propertyInfo.GetSystemType(),
                propertyInfo.Name.StartsWith(EdiPrefix.D.ToString()) ? propertyInfo.Name : null,
                propertyInfo
            )
        {
        }

        private ParseTree(Type systemType, string name = null, PropertyInfo propertyInfo = null)
        {
            if (systemType == null) throw new ArgumentNullException("systemType");

            SystemProperty = propertyInfo;
            SystemType = systemType;
            IsEnvelope = SystemType.FullName.Contains("EdiFabric.Framework.Envelopes");
            Name = string.IsNullOrEmpty(name) ? SystemType.Name : name;
            var splitName = Name.Split('_');
            if(splitName.Length < 2) throw new ParserException(string.Format("Invalid node name: {0}", Name));
            EdiName = splitName[1];
            Prefix = (EdiPrefix) Enum.Parse(typeof (EdiPrefix), splitName[0]);
            _children = new List<ParseTree>();
        }
    }
}
