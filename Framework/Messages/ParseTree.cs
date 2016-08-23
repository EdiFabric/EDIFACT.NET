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

namespace EdiFabric.Framework.Messages
{
    /// <summary>
    /// This class represents the formal grammar as imported from the definitions class. 
    /// It is a lightweight parent\child relationship structure and is used to define the hierarchy of the EDI as outlined in the standard. 
    /// </summary>
    class ParseTree
    {
        public Type SystemType { get; private set; }
        public string Name { get; private set; }
        public string EdiName { get; private set; }
        public EdiPrefix Prefix { get; private set; }
        public ParseTree Parent { get; private set; }
        public IList<ParseTree> Children { get; private set; }
        public IList<string> FirstChildValues { get; private set; }
        public IList<string> SecondChildValues { get; private set; }
        public bool IsEnvelope { get; private set; }
        
        public bool IsMessage
        {
            get { return Prefix == EdiPrefix.M; }
        }
        public bool IsGroup
        {
            get { return Prefix == EdiPrefix.G; }
        }
        public bool IsAll
        {
            get { return Prefix == EdiPrefix.A; }
        }
        public bool IsLoopOfLoops
        {
            get { return Prefix == EdiPrefix.U; }
        }
        public bool IsSegment
        {
            get { return Prefix == EdiPrefix.S; }
        }
        public bool IsComplex
        {
            get { return Prefix == EdiPrefix.C; }
        }
        public bool IsSimple
        {
            get { return Prefix == EdiPrefix.D; }
        }

        public bool IsTrigger
        {
            get { return Parent != null && Parent.Prefix == EdiPrefix.G && Parent.Children.IndexOf(this) == 0; }
        }
        
        public ParseTree(Type systemType, Func<ParseTree, bool> limit) : this(systemType.Name)
        {
            if (systemType == null) throw new ArgumentNullException("systemType");
            if (limit == null) throw new ArgumentNullException("limit");

            var properties = systemType.GetProperties().Sort();

            SystemType = systemType;
            IsEnvelope = SystemType.FullName.Contains("EdiFabric.Framework.Envelopes");
            FirstChildValues = IsSegment && properties.Count > 0 ? properties[0].GetProperyValues(0) : null;
            SecondChildValues = IsSegment && properties.Count > 1 ? properties[1].GetProperyValues(1) : null;
            
            if (!limit(this)) return;

            foreach (var propertyInfo in properties)
            {
                var parseTree = propertyInfo.Name.StartsWith(EdiPrefix.D.ToString())
                    ? new ParseTree(propertyInfo.Name)
                    : new ParseTree(propertyInfo.GetSystemType(), limit);                    

                parseTree.Parent = this;
                Children.Add(parseTree);
            }
        }

        private ParseTree(string name)
        {
            Name = name;
            EdiName = Name.Split('_')[1];
            Prefix = (EdiPrefix)Enum.Parse(typeof(EdiPrefix), Name.Split('_')[0]);
            Children = new List<ParseTree>();            
        }

    }
}
