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
using EdiFabric.Attributes;

namespace EdiFabric.Framework.Parsers
{
    static class ParseNodeExtensions
    {
        private static int IndexOfImmediateChild(this ParseNode node, IList<ParseNode> parents)
        {
            var index = parents.IndexOf(node);
            if(index == -1)
                throw new Exception("Child is not part of the parents list.");
            if(index + 1 == parents.Count)
                throw new Exception("Child is in the last position in the parents list.");
            var next = parents[index + 1];

            return node.IndexOfChild(next);
        }

        public static IEnumerable<ParseNode> ChildrenWithExclusion(this ParseNode node, IList<ParseNode> exclusion)
        {
            if (exclusion.Contains(node))
            {
                var index = node.IndexOfImmediateChild(exclusion);
                return node.Children.Where(c => c.IndexInParent() >= index);
            }

            return new List<ParseNode>();
        }

        public static IEnumerable<Segment> TraverseDepthFirst(this Segment startNode)
        {
            var visited = new HashSet<ParseNode>();
            var stack = new Stack<ParseNode>();
            var parents = startNode.AncestorsAndSelf();
            
            stack.Push(startNode);

            while (stack.Any())
            {
                var current = stack.Pop();

                if (!visited.Add(current))
                    continue;

                if (current is Segment)
                    yield return current as Segment;

                var neighbours = current.NeighboursWithExclusion(parents).Where(p => !visited.Contains(p));

                foreach (var neighbour in neighbours.Reverse())
                    stack.Push(neighbour);                
            }
        }

        private static IEnumerable<ParseNode> Ancestors(this ParseNode node)
        {
            var stack = new Stack<ParseNode>();
            if (node.Parent == null) 
                yield break;
            
            stack.Push(node.Parent);
            while (stack.Count != 0)
            {
                var item = stack.Pop();
                yield return item;
                
                if (item.Parent != null)
                    stack.Push(item.Parent);
            }
        }

        private static IList<ParseNode> AncestorsAndSelf(this ParseNode node)
        {
            var result = node.Ancestors().Reverse().ToList(); 
            result.Add(node);

            return result;
        }

        public static IEnumerable<ParseNode> Descendants(this ParseNode parseNode)
        {
            var nodes = new Stack<ParseNode>(new[] { parseNode });
            while (nodes.Any())
            {
                var node = nodes.Pop();
                yield return node;
                foreach (var n in node.Children) 
                    nodes.Push(n);
            }
        }

        public static ParseNode ToParseNode(this PropertyInfo propertyInfo, object instance = null)
        {
            var type = propertyInfo.PropertyType;
            if (type.IsGenericType)
                type = type.GenericTypeArguments.First();

            var attr = propertyInfo.GetCustomAttribute<EdiAttribute>();
            if(attr == null)
                throw new Exception(string.Format("Property {0} is not annotated with [EdiAttribute].", propertyInfo.Name));

            if (attr is DAttribute)
                return new DataElement(type, propertyInfo.Name, propertyInfo.Name, instance);

            if (attr is SAttribute)
            {
                List<string> first = null;
                List<string> second = null;
                var sAttr = attr as SAttribute;
                if (sAttr.First != null)
                {
                    var eAttr = (EAttribute) sAttr.First.GetCustomAttributes(typeof (EAttribute)).SingleOrDefault();
                    if (eAttr == null)
                        throw new Exception(string.Format("Type {0} is not annotated with an [EAttribute].",
                            sAttr.First.Name));
                    first = eAttr.Codes.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (sAttr.Second != null)
                    {
                        var eAttrS = (EAttribute) sAttr.Second.GetCustomAttributes(typeof (EAttribute)).SingleOrDefault();
                        if (eAttrS == null)
                            throw new Exception(string.Format("Type {0} is not annotated with an [EAttribute].",
                                sAttr.Second.Name));
                        second = eAttrS.Codes.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    }
                }
                return new Segment(type, propertyInfo.Name, sAttr.Id, first, second, instance);
            }

            if (attr is CAttribute)
                return new ComplexDataElement(type, propertyInfo.Name, propertyInfo.Name, instance);

            if (attr is GAttribute)
                return new Loop(type, propertyInfo.Name, propertyInfo.Name, instance);

            var aAttr = propertyInfo.GetCustomAttribute<AAttribute>();
            if (aAttr != null)
                return new AllLoop(type, propertyInfo.Name, propertyInfo.Name, instance);

            throw new Exception(string.Format("Property {0} is annotated with an unknown [EdiAttribute].", propertyInfo.Name));
        }

        public static IEnumerable<PropertyInfo> Sort(this PropertyInfo[] propertyInfos)
        {
            return propertyInfos.OrderBy(
                p =>
                    p.GetCustomAttributes(typeof(EdiAttribute), false)
                        .Cast<EdiAttribute>()
                        .Select(a => a.Pos)
                        .FirstOrDefault());
        }      
    }
}
