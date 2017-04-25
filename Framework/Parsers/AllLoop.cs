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

using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Framework.Parsers
{
    class AllLoop : ParseNode
    {
        public AllLoop(PropertyInfo propertyInfo, object instance = null)
            : base(propertyInfo.GetGenericType(), propertyInfo.Name, propertyInfo.Name)
        {
            IsParsed = true;
            BuildChildren(instance);
        }

        public AllLoop(ParseNode parseNode)
            : base(parseNode.Type, parseNode.Name, parseNode.EdiName)
        {
            IsParsed = true;
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
            BuildChildren();
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IEnumerable<ParseNode> exclusion)
        {
            var result = new List<ParseNode>();
            
            if (Children.Any())
            {
                var grouped = Children.GroupBy(s => s.Name);               
                result.AddRange(grouped.Select(g => g.Last()));
            }

            result.Add(Parent);
            return result;
        }
    }
}
