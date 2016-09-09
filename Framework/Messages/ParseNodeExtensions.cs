using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using EdiFabric.Framework.Envelopes;
using EdiFabric.Framework.Messages.Segments;

namespace EdiFabric.Framework.Messages
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
                case EdiPrefix.S:
                    result.Add(node.Parent);
                    return result;
                case EdiPrefix.G:
                    result.AddRange(node.ChildrenWithExclusion(exclusion));
                    result.Add(node.Children.First());
                    result.Add(node.Parent);
                    return result;
                case EdiPrefix.M:
                    result.AddRange(node.ChildrenWithExclusion(exclusion));
                    if(!result.Any())
                        result.AddRange(node.Children);
                    return result;
                case EdiPrefix.U:
                    result.AddRange(node.ChildrenWithExclusion(exclusion));
                    if (!result.Any())
                        result.AddRange(node.Children);
                    result.Add(node.Parent);
                    return result;
                case EdiPrefix.A:
                    result.AddRange(node.Children);
                result.Add(node.Parent);
                return result;
                default:
                    throw new Exception(string.Format("Unsupported node prefix: {0}", node.Prefix));
            }
        }

        public static IEnumerable<ParseNode> TraverseSegmentsDepthFirst(this ParseNode startNode)
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

                if (current.Prefix == EdiPrefix.S)
                    yield return current;

                var neighbours = current.NeighboursWithExclusion(parents).Where(p => !visited.Contains(p));

                foreach (var neighbour in neighbours.Reverse())
                    stack.Push(neighbour);                
            }
        }

        public static IEnumerable<ParseNode> Ancestors(this ParseNode node)
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

        public static IEnumerable<ParseNode> AncestorsToIntersection(this ParseNode segment, ParseNode lastFoundSegment)
        {
            if (segment.Prefix != EdiPrefix.S)
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

        /// <summary>
        /// Convert a parse tree to a root XML node.
        /// Without the hierarchy, only the name.
        /// </summary>
        /// <param name="parseNode">The parse tree.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>A XML node.</returns>
        public static XElement ToXml(this ParseNode parseNode, InterchangeContext interchangeContext)
        {
            XNamespace ns = interchangeContext.TargetNamespace;
            return new XElement(ns + parseNode.Name);
        }

        public static bool IsSameSegment(this ParseNode parseNode, SegmentContext segmentContext)
        {
            if(parseNode.Prefix != EdiPrefix.S) throw new ParserException(string.Format("Can't compare non segments: {0}", parseNode.Name));

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

        public static void Parse(this ParseNode parseNode, string line, InterchangeContext interchangeContext)
        {
            if (parseNode.Prefix != EdiPrefix.S)
                throw new Exception(string.Format("Only segments are supported: {0}", parseNode.Name));
            if (string.IsNullOrEmpty(line)) throw new ArgumentNullException("line");

            var dataElementsGrammar = ParseNode.BuldTree(parseNode.Type, false).Children.ToArray();
            var dataElements = EdiHelper.GetEdiCompositeDataElements(line, interchangeContext);
            for (var deIndex = 0; deIndex < dataElements.Length; deIndex++)
            {
                var currentDataElement = dataElements[deIndex];
                if (string.IsNullOrEmpty(currentDataElement)) continue;
                var currentDataElementGrammar = dataElementsGrammar[deIndex];
                var repetitions = EdiHelper.GetRepetitions(currentDataElement, interchangeContext);
                foreach (var repetition in repetitions)
                {
                    var childParseNode = parseNode.AddChild(currentDataElementGrammar.Type,
                        currentDataElementGrammar.Name,
                        currentDataElementGrammar.Prefix == EdiPrefix.D ? repetition : null);

                    if (currentDataElementGrammar.Prefix != EdiPrefix.C) continue;

                    var componentDataElementsGrammar = currentDataElementGrammar.Children.ToArray();
                    var componentDataElements = EdiHelper.GetEdiComponentDataElements(repetition, interchangeContext);
                    for (var cdeIndex = 0; cdeIndex < componentDataElements.Length; cdeIndex++)
                    {
                        var currentComponentDataElement = componentDataElements[cdeIndex];
                        if (string.IsNullOrEmpty(currentComponentDataElement)) continue;
                        var currentComponentDataElementGrammar = componentDataElementsGrammar[cdeIndex];

                        childParseNode.AddChild(currentComponentDataElementGrammar.Type,
                            currentComponentDataElementGrammar.Name,
                            currentComponentDataElement);
                    }
                }
            }
        }

        public static object ToInstance(this ParseNode parseNode)
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
                    if (nodeChild.Prefix == EdiPrefix.D)
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

        public static List<string> GenerateEdi(this ParseNode parseNode)
        {
            if (parseNode.Prefix != EdiPrefix.S)
                throw new Exception(string.Format("Only segments are supported: {0}", parseNode.Name));

            throw new NotImplementedException();
        }
    }
}
