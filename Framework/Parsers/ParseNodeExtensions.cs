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
using EdiFabric.Annotations.Edi;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Validators;

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
            var parents = startNode.Ancestors().Reverse().ToList();
            
            stack.Push(startNode);

            while (stack.Any())
            {
                var current = stack.Pop();

                if (!visited.Add(current))
                    continue;

                if (current is Segment)
                {
                    yield return current as Segment;
                }

                var neighbours = current.NeighboursWithExclusion(parents).Where(p => !visited.Contains(p));

                foreach (var neighbour in neighbours.Reverse())
                {
                    stack.Push(neighbour);
                }
            }
        }

        private static IEnumerable<ParseNode> Ancestors(this ParseNode node)
        {
            var stack = new Stack<ParseNode>();
            if (node == null) 
                yield break;
            
            stack.Push(node);
            while (stack.Count != 0)
            {
                var item = stack.Pop();
                yield return item;
                
                if (item.Parent != null)
                    stack.Push(item.Parent);
            }
        }

        public static IEnumerable<T> Descendants<T>(this ParseNode parseNode) where T : ParseNode
        {
            var nodes = new Stack<ParseNode>(new[] { parseNode });
            while (nodes.Any())
            {
                var node = nodes.Pop();
                var result = node as T;
                if (result != null)
                    yield return result;
                foreach (var n in node.Children.Reverse()) 
                    nodes.Push(n);
            }
        }

        public static ParseNode ToParseNode(this PropertyInfo propertyInfo, object instance = null)
        {
            var type = propertyInfo.GetGenericType();
            if(type == typeof(string))
                return new DataElement(propertyInfo, instance);

            var attr = propertyInfo.GetGenericType().GetCustomAttribute<EdiAttribute>();
            if(attr == null)
                throw new Exception(string.Format("Property {0} is not annotated with [EdiAttribute].", propertyInfo.Name));
            
            if (attr is SegmentAttribute)
                return new Segment(propertyInfo, attr as SegmentAttribute, instance);

            if (attr is CompositeAttribute)
                return new ComplexDataElement(propertyInfo, instance);

            if (attr is GroupAttribute)
                return new Loop(propertyInfo, instance);

            if (attr is AllAttribute)
                return new AllLoop(propertyInfo, instance);

            throw new Exception(string.Format("Property {0} is annotated with unknown [EdiAttribute].", propertyInfo.Name));
        }

        //public static SegmentErrorContext ToSegmentErrorContext(this PropertyInfo propertyInfo, object value, int segmentPosition)
        //{
        //    var attr = propertyInfo.GetCustomAttribute<PositionAttribute>();

        //    if (attr == null)
        //        throw new Exception(string.Format("Property {0} is not annotated with [PositionAttribute].", propertyInfo.Name));

        //    var results = propertyInfo.Validate(value);

        //    if (attr is SAttribute)
        //    {
        //        var sAttr = propertyInfo.GetGenericType().GetCustomAttribute<EdiAttribute>();
        //        var segmentName = sAttr.Id;
        //    }

        //    if (attr is GAttribute)
        //    {
        //        var sAttr = propertyInfo.GetGenericType().GetCustomAttribute<EdiAttribute>();
        //        var segmentName = sAttr.Id;
        //    }

        //    if (attr is CAttribute)
        //    {
        //        var sAttr = propertyInfo.DeclaringType.GetCustomAttribute<EdiAttribute>();
        //        var segmentName = sAttr.Id;
        //    }

        //    if (attr is DAttribute)
        //    {
        //        var sAttr = propertyInfo.DeclaringType.GetCustomAttribute<EdiAttribute>();
        //        if (sAttr == null)
        //        {
        //            sAttr = propertyInfo.DeclaringType.DeclaringType.GetCustomAttribute<EdiAttribute>();
        //        }
        //        var segmentName = sAttr.Id;
        //    }

        //    if (attr is AAttribute && results.Contains(ValidationCodes.RequiredMissing))
        //    {
        //        foreach (var aValue in value.GetType().GetProperties().Sort())
        //        {
                    
        //        }
        //    }


            

        //    foreach (var result in results)
        //    {
        //        //var segmentName = 
        //    }

           
            

           

            

            

            

        //    throw new Exception(string.Format("Property {0} is annotated with unknown [PositionAttribute].", propertyInfo.Name));
        //}

        public static IEnumerable<PropertyInfo> Sort(this PropertyInfo[] propertyInfos)
        {
            return propertyInfos.OrderBy(
                p =>
                    p.GetCustomAttributes(typeof(PosAttribute), false)
                        .Cast<PosAttribute>()
                        .Select(a => a.Pos)
                        .FirstOrDefault());
        }

        public static Type GetGenericType(this PropertyInfo propertyInfo)
        {
            var type = propertyInfo.PropertyType;
            if (type.IsGenericType)
                type = type.GenericTypeArguments.First();

            return type;
        }

        
    }
}
