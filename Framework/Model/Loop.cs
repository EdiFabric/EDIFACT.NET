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
using EdiFabric.Core.Annotations.Edi;

namespace EdiFabric.Framework.Model
{
    class Loop : ParseNode
    {
        public Loop(PropertyInfo propertyInfo, GroupAttribute gAttr, object instance = null)
            : base(propertyInfo.GetGenericType(), propertyInfo.Name, gAttr.Id)
        {
            BuildChildren(instance);
        }

        public Loop(ParseNode parseNode)
            : base(parseNode.TypeInfo, parseNode.Name, parseNode.EdiName)
        {
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
            BuildChildren();
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IEnumerable<ParseNode> exclusion)
        {
            var result = new List<ParseNode>();
            result.AddRange(this.ChildrenWithExclusion(exclusion.ToList()));
            result.Add(Children.First());
            result.Add(Parent);
            return result;
        }
    }
}
