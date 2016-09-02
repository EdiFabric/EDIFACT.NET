using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using EdiFabric.Framework.Envelopes;
using EdiFabric.Framework.Messages.Segments;

namespace EdiFabric.Framework.Messages
{
    static class ParseTreeExtensions
    {
        public static int GetIndexOfImmediateChild(this ParseTree node, IList<ParseTree> parents)
        {
            var index = parents.IndexOf(node);
            if(index == -1)
                throw new ParserException("Child is not part of the parents list.");
            if(index + 1 == parents.Count)
                throw new ParserException("Child is in the last position in the parents list.");
            var next = parents[index + 1];

            return node.IndexOfChild(next);
        }

        public static IEnumerable<ParseTree> GetChildrenWithExclusion(this ParseTree node, IList<ParseTree> exclusion)
        {
            if (exclusion.Contains(node))
            {
                var index = node.GetIndexOfImmediateChild(exclusion);
                return node.Children.Where(c => c.Parent.IndexOfChild(c) >= index);
            }

            return new List<ParseTree>();
        }

        public static IEnumerable<ParseTree> GetNeighboursWithExclusion(this ParseTree node, IList<ParseTree> exclusion)
        {
            var result = new List<ParseTree>();

            switch (node.Prefix)
            {
                case EdiPrefix.S:
                    result.Add(node.Parent);
                    return result;
                case EdiPrefix.G:
                    result.AddRange(node.GetChildrenWithExclusion(exclusion));
                    result.Add(node.Children.First());
                    result.Add(node.Parent);
                    return result;
                case EdiPrefix.M:
                    result.AddRange(node.GetChildrenWithExclusion(exclusion));
                    if(!result.Any())
                        result.AddRange(node.Children);
                    return result;
                case EdiPrefix.U:
                    result.AddRange(node.GetChildrenWithExclusion(exclusion));
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

        public static IEnumerable<ParseTree> TraverseSegmentsDepthFirst(this ParseTree startNode)
        {
            var visited = new HashSet<ParseTree>();
            var stack = new Stack<ParseTree>();
            var parents = startNode.GetParentsAndSelf();
            
            stack.Push(startNode);

            while (stack.Any())
            {
                var current = stack.Pop();

                if (!visited.Add(current))
                    continue;

                if (current.Prefix == EdiPrefix.S)
                    yield return current;

                var neighbours = current.GetNeighboursWithExclusion(parents).Where(p => !visited.Contains(p));

                foreach (var neighbour in neighbours.Reverse())
                    stack.Push(neighbour);                
            }
        }

        public static IEnumerable<ParseTree> GetParents(this ParseTree node, Func<ParseTree, bool> shouldContinue)
        {
            var stack = new Stack<ParseTree>();
            if (node.Parent == null) yield break;
            stack.Push(node.Parent);
            while (stack.Count != 0)
            {
                var item = stack.Pop();
                yield return item;
                if (shouldContinue(item))
                    stack.Push(item.Parent);
            }
        }

        public static IList<ParseTree> GetParentsAndSelf(this ParseTree node)
        {
            var result = node.GetParents(p => p.Parent != null).Reverse().ToList();
 
            result.Add(node);

            return result;
        }

        public static IEnumerable<ParseTree> GetParentsToIntersection(this ParseTree segment, ParseTree lastFoundSegment)
        {
            if (segment.Prefix != EdiPrefix.S)
                throw new ParserException("Not a segment " + segment.Name);

            var lastParents = lastFoundSegment.GetParents(s => s.Parent != null);
            var parents = segment.GetParents(s => s.Parent != null).ToList();
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
        /// <param name="parseTree">The parse tree.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>A XML node.</returns>
        public static XElement ToXml(this ParseTree parseTree, InterchangeContext interchangeContext)
        {
            XNamespace ns = interchangeContext.TargetNamespace;
            return new XElement(ns + parseTree.Name);
        }

        /// <summary>
        /// Compare a parse tree to identity.
        /// </summary>
        /// <param name="parseTree">The parse tree.</param>
        /// <param name="segmentContext">The identity.</param>
        /// <returns>If equal</returns>
        public static bool IsSameSegment(this ParseTree parseTree, SegmentContext segmentContext)
        {
            if(parseTree.Prefix != EdiPrefix.S) throw new ParserException(string.Format("Can't compare non segments: {0}", parseTree.Name));

            // The names must match
            if (parseTree.EdiName == segmentContext.Name)
            {
                // If no identity match is required, mark this as a match
                if (string.IsNullOrEmpty(segmentContext.FirstValue) || !parseTree.FirstChildValues.Any())
                    return true;

                // Match the value 
                // This must have been defined in the enum of the first element of the segment.
                if (parseTree.FirstChildValues.Any() && !string.IsNullOrEmpty(segmentContext.FirstValue) &&
                    parseTree.FirstChildValues.Contains(segmentContext.FirstValue))
                {
                    if (parseTree.SecondChildValues.Any() && !string.IsNullOrEmpty(segmentContext.SecondValue))
                    {
                        return parseTree.SecondChildValues.Contains(segmentContext.SecondValue);
                    }

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets all the descendants up to the root including the current.
        /// </summary>
        /// <param name="parseTree">The parse tree.</param>
        /// <returns>
        /// The list of descendants.
        /// </returns>
        public static IEnumerable<ParseTree> Descendants(this ParseTree parseTree)
        {
            var nodes = new Stack<ParseTree>(new[] { parseTree });
            while (nodes.Any())
            {
                var node = nodes.Pop();
                yield return node;
                foreach (var n in node.Children) nodes.Push(n);
            }
        }

        public static void Parse(this ParseTree result, string line, InterchangeContext interchangeContext)
        {
            if (result.Prefix != EdiPrefix.S) throw new Exception("Not a segment.");

            ParseTree grammar = new ParseTree(result.Type, false);

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

        /// <summary>
        /// Parses a data element
        /// </summary>
        /// <param name="parseTree">The data element grammar.</param>
        /// <param name="value">The data element line.</param>
        /// <param name="interchangeContext"></param>
        /// <returns>The parsed XML.</returns>
        private static void ParseElement(this ParseTree segment, ParseTree parseTree, string value, InterchangeContext interchangeContext)
        {
            if (value == null) throw new ArgumentNullException("value");
            if (parseTree.Prefix != EdiPrefix.C && parseTree.Prefix != EdiPrefix.D) throw new Exception("Not a data element.");

            if (parseTree.Prefix == EdiPrefix.C)
            {
                var result = segment.AddChild(parseTree.Type);

                if (value == string.Empty)
                {
                    // Only deal with blank values for envelope headers
                    if (parseTree.IsEnvelope)
                    {
                        foreach (var dataElement in parseTree.Children)
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
                        parseTree.Children.Select((g, p) => new { Grammar = g, Position = p }).ToList();
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
                            if (!parseTree.IsEnvelope)
                                continue;
                        }

                        // Handle the repetitions
                        // If the children the EDI string are more than the class definition,
                        // Then the extra ones are considered repetitions of the last child in the class definition
                        var objectToParse = dataElement.Position >= parseTree.Children.Count
                                                ? parseTree.Children.Last()
                                                : parseTree.Children.ElementAt(dataElement.Position);

                        result.AddChild(objectToParse.Type, objectToParse.Name, dataElement.Value); 
                    }
                }
            }
            else
            {
                // Prevent faulty XML
                segment.AddChild(parseTree.Type, parseTree.Name, value);
                //result = new ParseTree(parseTree.Type, parseTree.Name, value); 
                //result.SetValue(SecurityElement.Escape(value) ?? string.Empty);
            }
        }

        public static object ToInstance(this ParseTree parseTree)
        {
            var result = Activator.CreateInstance(parseTree.Type);
            var nodes =
                new Stack<Tuple<ParseTree, object>>(new[] { Tuple.Create(parseTree, result) });

            var listTypes = new Dictionary<string, IList>();
            
            while (nodes.Any())
            {
                var node = nodes.Pop();

                foreach (var n in node.Item1.Children)
                {                    
                    var prop = node.Item1.Type.GetProperty(n.Name);
                    if (n.Prefix == EdiPrefix.D)
                    {
                        if (prop.PropertyType.IsEnum)
                        {
                            var val = n.Value;
                            if (n.Value.Length > 0 && char.IsDigit(n.Value[0]))
                            {
                                val = string.Format("Item{0}", n.Value);

                                var propS = node.Item1.Type.GetProperty(n.Name + "Specified");
                            }
                            prop.SetValue(node.Item2, Enum.Parse(prop.PropertyType, val), null);

                            
                        }
                        else
                        {
                            prop.SetValue(node.Item2, n.Value, null);
                        }
                        
                    }
                    else
                    {
                        if (typeof(IList).IsAssignableFrom(prop.PropertyType) && prop.PropertyType.IsGenericType)
                        {
                            IList list;
                            var id = n.Id;
                            if (listTypes.ContainsKey(id))
                            {
                                list = listTypes[id];
                            }
                            else
                            {
                                list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(n.Type));
                                prop.SetValue(node.Item2, list, null);
                                
                                listTypes.Add(id, list);
                            }
                            
                            object obj = Activator.CreateInstance(n.Type);
                            list.Add(obj);

                            nodes.Push(new Tuple<ParseTree, object>(n, obj));
                        }
                        else
                        {
                            var child = Activator.CreateInstance(prop.PropertyType);
                            prop.SetValue(node.Item2, child, null);
                            nodes.Push(new Tuple<ParseTree, object>(n, child));
                        }
                        
                    }                    
                }
            }

            return result;
        }
    }
}
