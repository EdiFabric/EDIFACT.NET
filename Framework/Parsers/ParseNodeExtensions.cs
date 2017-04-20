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
        
        internal static IEnumerable<Segment> TraverseDepthFirst(this Segment startNode)
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
        
        internal static bool IsEqual(this Segment parseNode, SegmentContext segmentContext)
        {
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

        //internal static IEnumerable<ParseNode> AncestorsToIntersection(this Segment segment, ParseNode lastFoundSegment)
        //{
        //    var lastParents = lastFoundSegment.Ancestors();
        //    var parents = segment.Ancestors().ToList();
        //    var intersect = parents.Select(n => n.Name).Intersect(lastParents.Select(n => n.Name)).ToList();
        //    var result = parents.TakeWhile(parent => parent.Name != intersect.First()).Reverse().ToList();

        //    if (!result.Any() && segment.IsTrigger)
        //        result.Add(segment.Parent);

        //    result.Add(segment);

        //    return result;
        //}
        
        internal static object ToInstance(this ParseNode parseNode)
        {
            if (parseNode == null) throw new ArgumentNullException("parseNode");

            var root = Activator.CreateInstance(parseNode.Type);
            var instanceLinks = new Dictionary<string, object> {{parseNode.Path, root}};
            var stack = new Stack<ParseNode>(new[] {parseNode});
            var listTypes = new Dictionary<string, IList>();

            while (stack.Any())
            {
                var currentNode = stack.Pop();

                if (currentNode is Segment && string.IsNullOrEmpty(currentNode.Value))
                    continue;

                var path = currentNode.Path;
                object currentInstance;
                if (!instanceLinks.TryGetValue(path, out currentInstance))
                    throw new Exception(string.Format("Instance not set for path: {0}", currentNode.Path));

                foreach (var nodeChild in currentNode.Children)
                {
                    if (nodeChild is Segment && string.IsNullOrEmpty(nodeChild.Value))
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

        

        internal static Segment JumpToHl(this TransactionSet grammarRoot, string parentId)
        {
            ParseNode hlParent;
            if (parentId != null)
            {
                // Parent HL, start right after it
                hlParent =
                    grammarRoot.Descendants()
                        .SingleOrDefault(
                            d =>
                                (d.Name == "HL" || d.Name.StartsWith("HL_", StringComparison.Ordinal)) &&
                                d.Children.First().Value == parentId);
                if (hlParent == null)
                    throw new Exception(string.Format("HL with id = {0} was not found.", parentId));

                var nextSegment = grammarRoot.Descendants().Reverse().OfType<Segment>().FindNextSegment(pt => pt.Name == hlParent.Name);

                if (nextSegment == null)
                    throw new Exception(string.Format("No segment after HL with id = {0} .", parentId));

                return nextSegment;
            }

            // Root HL, start from it
            return
                grammarRoot.Descendants()
                    .Reverse().OfType<Segment>()
                    .First(d => (d.Name == "HL" || d.Name.StartsWith("HL_", StringComparison.Ordinal)));

        }

        private static Segment FindNextSegment(this IEnumerable<Segment> items, Predicate<ParseNode> matchPredicate)
        {
            using (var iter = items.GetEnumerator())
            {
                while (iter.MoveNext())
                {
                    if (matchPredicate(iter.Current))
                    {
                        if (iter.MoveNext())
                            return iter.Current;
                    }                   
                }
            }

            return null;
        }

        internal static Tuple<string, string> PullTrailerValues(this IEnumerable<ParseNode> segments)
        {
            var msgHeader =
                segments.SingleOrDefault(
                    s =>
                        s.Name == "UNH" || s.Name.StartsWith("UNH_", StringComparison.Ordinal) ||
                        s.Name == "ST" || s.Name.StartsWith("ST_", StringComparison.Ordinal));

            DataElement controlNumber = null;
            var trailerTag = "";
            if (msgHeader != null && msgHeader.Name == "UNH")
            {
                controlNumber = msgHeader.Children.ElementAt(0) as DataElement;
                trailerTag = "UNT";
            }

            if (msgHeader != null && msgHeader.Name == "ST")
            {
                controlNumber = msgHeader.Children.ElementAt(1) as DataElement;
                trailerTag = "SE";
            }

            if (msgHeader == null || controlNumber == null)
                throw new Exception("Invalid control structure. UNH or ST was not found.");

            if (String.IsNullOrEmpty(controlNumber.Value))
                throw new Exception("Invalid control number.");

            if (String.IsNullOrEmpty(trailerTag))
                throw new Exception("Invalid trailer tag.");

            return new Tuple<string, string>(controlNumber.Value, trailerTag);
        }       
    }
}
