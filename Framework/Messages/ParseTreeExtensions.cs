using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using EdiFabric.Framework.Envelopes;
using EdiFabric.Framework.Messages.Segments;

namespace EdiFabric.Framework.Messages
{
    static class ParseTreeExtensions
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

        /// <summary>
        /// Compare a parse tree to identity.
        /// </summary>
        /// <param name="parseNode">The parse tree.</param>
        /// <param name="segmentContext">The identity.</param>
        /// <returns>If equal</returns>
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

        /// <summary>
        /// Gets all the descendants up to the root including the current.
        /// </summary>
        /// <param name="parseNode">The parse tree.</param>
        /// <returns>
        /// The list of descendants.
        /// </returns>
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

        public static void Parse(this ParseNode result, string line, InterchangeContext interchangeContext)
        {
            if (result.Prefix != EdiPrefix.S) throw new Exception("Not a segment.");

            ParseNode grammar = ParseNode.BuldTree(result.Type, false);

            // Gets the composite data elements from the segment string
            var dataElements = EdiHelper.GetEdiCompositeDataElements(line, interchangeContext).ToList();

            // Index the composite data elements from the class definition
            var indexedGrammar = grammar.Children.Select((g, p) => new { Grammar = g, Position = p }).ToList();
            // Index the composite data elements from the EDI string
            var indexedValues = dataElements.Select((v, p) => new { Value = v, Position = p }).ToList();

            // This will try to parse the EDI string into the class definition
            // Load a parse tree against each value
            // If there are more values in the EDI string than in the class definition - they will be ignored
            // If there are less values in the EDI string than in the class definition - it will throw an exception
            var indexedList = from ig in indexedGrammar
                              from iv in indexedValues
                              where ig.Position == iv.Position
                              select new { ig.Grammar, iv.Value, ig.Position };

            foreach (var dataElement in indexedList)
            {
                // Skip the blank elements
                // This massively reduces the generated XML
                if (string.IsNullOrEmpty(dataElement.Value))
                {
                    // Don't skip for header segments as they are positional
                    if (!grammar.IsEnvelope)
                        continue;
                }

                // If the current element is out of the range of elements defined in the definition class, then it's a repetition
                // The repetitions are always for the last defined element
                var elementGrammar = dataElement.Position >= grammar.Children.Count
                    ? grammar.Children.Last()
                    : grammar.Children.ElementAt(dataElement.Position);

                // Handle the repetitions
                var elementRepetitions = grammar.IsEnvelope
                    ? new[] { dataElement.Value }
                    : EdiHelper.GetRepetitions(dataElement.Value, interchangeContext);

                // Parse each repetition
                foreach (var elementRepetition in elementRepetitions)
                {
                    result.ParseElement(elementGrammar, elementRepetition, interchangeContext);
                }
            }
        }

        private static void ParseElement(this ParseNode segment, ParseNode parseNode, string value, InterchangeContext interchangeContext)
        {
            if (value == null) throw new ArgumentNullException("value");
            if (parseNode.Prefix != EdiPrefix.C && parseNode.Prefix != EdiPrefix.D) throw new Exception("Not a data element.");

            if (parseNode.Prefix == EdiPrefix.C)
            {
                var result = segment.AddChild(parseNode.Type, parseNode.Type.Name);

                if (value == string.Empty)
                {
                    // Only deal with blank values for envelope headers
                    if (parseNode.IsEnvelope)
                    {
                        foreach (var dataElement in parseNode.Children)
                        {
                            result.AddChild(dataElement.Type, dataElement.Name, String.Empty);                            
                        }
                    }
                }
                else
                {
                    // Get the simple data elements
                    var componentDataElements =
                        EdiHelper.GetEdiComponentDataElements(value, interchangeContext).ToList();

                    // Index the composite data elements from the class definition
                    var indexedGrammar =
                        parseNode.Children.Select((g, p) => new { Grammar = g, Position = p }).ToList();
                    // Index the composite data elements from the EDI string
                    var indexedValues = componentDataElements.Select((v, p) => new { Value = v, Position = p }).ToList();

                    // This will try to parse the EDI string into the class definition
                    // Load a parse tree against each value
                    // If there are more values in the EDI string than in the class definition - they will be ignored
                    // If there are less values in the EDI string than in the class definition - it will throw an exception
                    var indexedList = from ig in indexedGrammar
                                      from iv in indexedValues
                                      where ig.Position == iv.Position
                                      select new { ig.Position, iv.Value };

                    // Index the list so we can position each element
                    //var indexed = componentDataElements.Select((a, i) => new {Item = a, Position = i}).ToList();

                    foreach (var dataElement in indexedList)
                    {
                        // Skip blank data elements otherwise this will produce blank XML nodes
                        if (string.IsNullOrEmpty(dataElement.Value))
                        {
                            if (!parseNode.IsEnvelope)
                                continue;
                        }

                        // Handle the repetitions
                        // If the children the EDI string are more than the class definition,
                        // Then the extra ones are considered repetitions of the last child in the class definition
                        var objectToParse = dataElement.Position >= parseNode.Children.Count
                                                ? parseNode.Children.Last()
                                                : parseNode.Children.ElementAt(dataElement.Position);

                        result.AddChild(objectToParse.Type, objectToParse.Name, dataElement.Value); 
                    }
                }
            }
            else
            {
                // Prevent faulty XML
                segment.AddChild(parseNode.Type, parseNode.Name, value);
                //result = new ParseTree(parseTree.Type, parseTree.Name, value); 
                //result.SetValue(SecurityElement.Escape(value) ?? string.Empty);
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
    }
}
