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

        public static IList<ParseNode> AncestorsAndSelf(this ParseNode node)
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

        public static object ToInstance(this ParseNode parseNode)
        {
            if (parseNode == null) throw new ArgumentNullException("parseNode");

            var root = Activator.CreateInstance(parseNode.Type);
            var instanceLinks = new Dictionary<string, object> {{parseNode.Path, root}};
            var stack = new Stack<ParseNode>(new[] {parseNode});
            var listTypes = new Dictionary<string, IList>();

            while (stack.Any())
            {
                var currentNode = stack.Pop();

                var segment = currentNode as Segment;
                if (segment != null && !segment.IsParsed)
                    continue;

                var path = currentNode.Path;
                object currentInstance;
                if (!instanceLinks.TryGetValue(path, out currentInstance))
                    throw new Exception(string.Format("Instance not set for path: {0}", currentNode.Path));

                foreach (var nodeChild in currentNode.Children)
                {
                    var segment1 = nodeChild as Segment;
                    if (segment1 != null && !segment1.IsParsed)
                        continue;

                    var propertyInfo = currentNode.Type.GetProperty(nodeChild.Name);
                    if (propertyInfo == null)
                        throw new Exception(string.Format("Property {0} was not found in type {1}", nodeChild.Name,
                            currentNode.Type.Name));

                    var de = nodeChild as DataElement;
                    var child = de != null
                        ? de.Value
                        : Activator.CreateInstance(nodeChild.Type);

                    if (propertyInfo.PropertyType.IsGenericType)
                    {
                        var repPath = nodeChild.Parent.Path + nodeChild.Name;
                        IList list;
                        if (!listTypes.TryGetValue(repPath, out list))
                        {
                            list = (IList) Activator.CreateInstance(typeof (List<>).MakeGenericType(nodeChild.Type));
                            propertyInfo.SetValue(currentInstance, list, null);

                            listTypes.Add(repPath, list);
                        }

                        list.Add(child);
                    }
                    else
                    {
                        propertyInfo.SetValue(currentInstance, child, null);
                    }

                    if (de != null) continue;

                    instanceLinks.Add(nodeChild.Path, child);
                    stack.Push(nodeChild);
                }

                instanceLinks.Remove(path);
            }

            return root;
        }

        public static ParseNode ToParseNode(this PropertyInfo propertyInfo, object instance = null)
        {
            var type = propertyInfo.PropertyType;
            if (type.IsGenericType)
                type = type.GenericTypeArguments.First();

            var sAttr = propertyInfo.GetCustomAttribute<SAttribute>();
            if (sAttr != null)
                return new Segment(type, propertyInfo.Name, sAttr.Id, instance);

            var gAttr = propertyInfo.GetCustomAttribute<GAttribute>();
            if (gAttr != null)
                return new Loop(type, propertyInfo.Name, propertyInfo.Name, instance);

            var cAttr = propertyInfo.GetCustomAttribute<CAttribute>();
            if (cAttr != null)
                return new ComplexDataElement(type, propertyInfo.Name, propertyInfo.Name, instance);

            var dAttr = propertyInfo.GetCustomAttribute<DAttribute>();
            if (dAttr != null)
                return new DataElement(type, propertyInfo.Name, propertyInfo.Name, instance);

            var aAttr = propertyInfo.GetCustomAttribute<AAttribute>();
            if (aAttr != null)
                return new AllLoop(type, propertyInfo.Name, propertyInfo.Name, instance);

            throw new Exception(string.Format("Property {0} is not annotated with [EdiAttribute].", propertyInfo.Name));
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
