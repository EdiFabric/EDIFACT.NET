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
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework
{
    static class ParseNodeExtensions
    {
        private static int IndexOfImmediateChild(this ParseNode node, IList<ParseNode> parents)
        {
            var index = parents.IndexOf(node);
            if(index == -1)
                throw new ParserException("Child is not part of the parents list.");
            if(index + 1 == parents.Count)
                throw new ParserException("Child is in the last position in the parents list.");
            var next = parents[index + 1];

            return node.IndexOfChild(next);
        }

        private static IEnumerable<ParseNode> ChildrenWithExclusion(this ParseNode node, IList<ParseNode> exclusion)
        {
            if (exclusion.Contains(node))
            {
                var index = node.IndexOfImmediateChild(exclusion);
                return node.Children.Where(c => c.Parent.IndexOfChild(c) >= index);
            }

            return new List<ParseNode>();
        }

        private static IEnumerable<ParseNode> NeighboursWithExclusion(this ParseNode node, IList<ParseNode> exclusion)
        {
            var result = new List<ParseNode>();

            switch (node.Prefix)
            {
                case Prefixes.S:
                    result.Add(node.Parent);
                    return result;
                case Prefixes.G:
                    result.AddRange(node.ChildrenWithExclusion(exclusion));
                    result.Add(node.Children.First());
                    result.Add(node.Parent);
                    return result;
                case Prefixes.M:
                    result.AddRange(node.ChildrenWithExclusion(exclusion));
                    if(!result.Any())
                        result.AddRange(node.Children);
                    return result;
                case Prefixes.U:
                    result.AddRange(node.ChildrenWithExclusion(exclusion));
                    if (!result.Any())
                        result.AddRange(node.Children);
                    result.Add(node.Parent);
                    return result;
                case Prefixes.A:
                    result.AddRange(node.Children);
                result.Add(node.Parent);
                return result;
                default:
                    throw new Exception(string.Format("Unsupported node prefix: {0}", node.Prefix));
            }
        }

        internal static IEnumerable<ParseNode> TraverseSegmentsDepthFirst(this ParseNode startNode)
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

                if (current.Prefix == Prefixes.S)
                    yield return current;

                var neighbours = current.NeighboursWithExclusion(parents).Where(p => !visited.Contains(p));

                foreach (var neighbour in neighbours.Reverse())
                    stack.Push(neighbour);                
            }
        }

        internal static IEnumerable<ParseNode> Ancestors(this ParseNode node)
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

        internal static IList<ParseNode> AncestorsAndSelf(this ParseNode node)
        {
            var result = node.Ancestors().Reverse().ToList(); 
            result.Add(node);

            return result;
        }

        internal static IEnumerable<ParseNode> AncestorsToIntersection(this ParseNode segment, ParseNode lastFoundSegment)
        {
            if (segment.Prefix != Prefixes.S)
                throw new ParserException("Not a segment " + segment.Name);

            var lastParents = lastFoundSegment.Ancestors();
            var parents = segment.Ancestors().ToList();
            var intersect = parents.Select(n => n.Name).Intersect(lastParents.Select(n => n.Name)).ToList();
            var result = parents.TakeWhile(parent => parent.Name != intersect.First()).Reverse().ToList();

            if (!result.Any() && segment.IsTrigger)
                result.Add(segment.Parent);
            
            result.Add(segment);
                   
            return result;
        }

        internal static bool IsEqual(this ParseNode parseNode, SegmentContext segmentContext)
        {
            if(parseNode.Prefix != Prefixes.S) throw new ParserException(string.Format("Can't compare non segments: {0}", parseNode.Name));

            // The names must match
            if (parseNode.EdiName == segmentContext.Name)
            {
                // If no identity match is required, mark this as a match
                if (string.IsNullOrEmpty(segmentContext.FirstValue) || !parseNode.FirstChildValues.Any())
                    return true;

                // Match the value 
                // This must have been defined in the enum of the first element of the segment.
                if (parseNode.FirstChildValues.Any() && !string.IsNullOrEmpty(segmentContext.FirstValue) &&
                    parseNode.FirstChildValues.Contains(segmentContext.FirstValue))
                {
                    if (parseNode.SecondChildValues.Any() && !string.IsNullOrEmpty(segmentContext.SecondValue))
                    {
                        return parseNode.SecondChildValues.Contains(segmentContext.SecondValue);
                    }

                    return true;
                }
            }

            return false;
        }

        internal static IEnumerable<ParseNode> Descendants(this ParseNode parseNode)
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

        internal static void ParseSegment(this ParseNode parseNode, string line, Separators separators)
        {
            if (parseNode.Prefix != Prefixes.S)
                throw new Exception(string.Format("Only segments are supported: {0}", parseNode.Name));
            if (string.IsNullOrEmpty(line)) throw new ArgumentNullException("line");

            var dataElementsGrammar = ParseNode.BuldTree(parseNode.Type, false).Children;
            var dataElements = line.GetDataElements(separators);
            for (var deIndex = 0; deIndex < dataElements.Length; deIndex++)
            {
                var currentDataElement = dataElements[deIndex];
                if (string.IsNullOrEmpty(currentDataElement)) continue;
                var currentDataElementGrammar = dataElementsGrammar.ElementAt(deIndex);
                var repetitions = currentDataElement.GetRepetitions(separators);
                foreach (var repetition in repetitions)
                {
                    var childParseNode = parseNode.AddChild(currentDataElementGrammar.Type,
                        currentDataElementGrammar.Name,
                        currentDataElementGrammar.Prefix == Prefixes.D ? repetition : null);

                    if (currentDataElementGrammar.Prefix != Prefixes.C) continue;

                    var componentDataElementsGrammar = currentDataElementGrammar.Children;
                    var componentDataElements = repetition.GetComponentDataElements(separators);
                    for (var cdeIndex = 0; cdeIndex < componentDataElements.Length; cdeIndex++)
                    {
                        var currentComponentDataElement = componentDataElements[cdeIndex];
                        if (string.IsNullOrEmpty(currentComponentDataElement)) continue;
                        var currentComponentDataElementGrammar = componentDataElementsGrammar.ElementAt(cdeIndex);

                        childParseNode.AddChild(currentComponentDataElementGrammar.Type,
                            currentComponentDataElementGrammar.Name,
                            currentComponentDataElement);
                    }
                }
            }
        }

        internal static object ToInstance(this ParseNode parseNode)
        {
            var root = Activator.CreateInstance(parseNode.Type);
            var instanceLinks = new Dictionary<string, object> { { parseNode.Path, root } };
            var stack = new Stack<ParseNode>(new[] { parseNode });            
            var listTypes = new Dictionary<string, IList>();
            
            while (stack.Any())
            {
                var currentNode = stack.Pop();

                var path = currentNode.Path;
                object currentInstance;
                if (!instanceLinks.TryGetValue(path, out currentInstance))
                    throw new Exception(string.Format("Instance not set for path: {0}", currentNode.Path));

                foreach (var nodeChild in currentNode.Children) 
                {                    
                    var propertyInfo = currentNode.Type.GetProperty(nodeChild.Name);
                    if (nodeChild.Prefix == Prefixes.D)
                    {
                        propertyInfo.SetValue(currentInstance, propertyInfo.GetPropertyValue(nodeChild.Value), null);                                              
                    }
                    else
                    {
                        object child;
                        if (propertyInfo.IsList())
                        {
                            var repPath = nodeChild.Parent.Path + nodeChild.Name;
                            IList list;
                            if (!listTypes.TryGetValue(repPath, out list))
                            {
                                list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(nodeChild.Type));
                                propertyInfo.SetValue(currentInstance, list, null);

                                listTypes.Add(repPath, list);
                            }

                            child = Activator.CreateInstance(nodeChild.Type);
                            list.Add(child);
                        }
                        else
                        {
                            child = Activator.CreateInstance(nodeChild.Type);
                            propertyInfo.SetValue(currentInstance, child, null);
                        }

                        instanceLinks.Add(nodeChild.Path, child);
                        stack.Push(nodeChild);                        
                    }                    
                }

                instanceLinks.Remove(path);
            }

            return root;
        }

        internal static string GenerateSegment(this ParseNode parseNode, Separators separators)
        {
            if (parseNode.Prefix != Prefixes.S)
                throw new Exception(string.Format("Only segments are supported: {0}", parseNode.Name));

            var result = parseNode.EdiName;

            foreach (var element in parseNode.Children)
            {
                string value;
                if (element.Prefix == Prefixes.C)
                {
                    value = element.Children.ElementAt(0).Value ?? string.Empty;
                    value = element.Children.Skip(1)
                        .Aggregate(value,
                            (current, subElement) =>
                                current + separators.ComponentDataElement + subElement.Value.EscapeLine(separators));                               
                }
                else
                {
                    value = element.Value != null ? element.Value.EscapeLine(separators) : string.Empty;
                }

                var separator = element.IsRepetition()
                    ? separators.RepetitionDataElement
                    : separators.DataElement;

                result = result + separator + value;              
            }

            result = result + separators.Segment;

            return result;
        }

        internal static bool IsRepetition(this ParseNode parseNode)
        {
            var index = parseNode.IndexInParent();
            if (index <= 0) return false;
            var previous = parseNode.Parent.Children.ElementAt(index - 1);
            return parseNode.Name == previous.Name;
        }

        internal static ParseNode JumpToHl(this ParseNode parseNode, ParseNode builtNode, string parentId)
        {
            ParseNode hlParent;
            if (parentId != null)
            {
                // Parent HL, start right after it
                hlParent =
                    builtNode.Descendants()
                        .Single(
                            d =>
                                d.Name.StartsWith("S_HL") &&
                                d.Children.First().Value == parentId);
                var hl = parseNode.Root().Descendants().Single(pt => pt.Name == hlParent.Name);
                return hl.Parent.Children.ElementAt(1);
            }
            
            // Root HL, start from it
            hlParent = builtNode.Descendants().First(d => d.Name.StartsWith("S_HL"));
            return parseNode.Root().Descendants().Single(pt => pt.Name == hlParent.Name);
        }

        internal static ParseNode Root(this ParseNode parseNode)
        {
            return parseNode.Ancestors().Last(); 
        }
    }
}
