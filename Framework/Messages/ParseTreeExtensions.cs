using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using EdiFabric.Framework.Envelopes;

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

            return node.Children.IndexOf(next);
        }

        public static IEnumerable<ParseTree> GetChildrenWithExclusion(this ParseTree node, IList<ParseTree> exclusion)
        {
            if (exclusion.Contains(node))
            {
                var index = node.GetIndexOfImmediateChild(exclusion);
                return node.Children.Where(c => c.Parent.Children.IndexOf(c) >= index);
            }

            return new List<ParseTree>();
        }

        public static IEnumerable<ParseTree> GetNeighboursWithExclusion(this ParseTree node, IList<ParseTree> exclusion)
        {
            var result = new List<ParseTree>();

            if (node.IsSegment)
            {
                result.Add(node.Parent);
                return result;
            }

            if (node.IsGroup)
            {
                result.AddRange(node.GetChildrenWithExclusion(exclusion));
                result.Add(node.Children.First());
                result.Add(node.Parent);

                return result;
            }

            if (node.IsMessage)
            {
                result.AddRange(node.GetChildrenWithExclusion(exclusion));
                if(!result.Any())
                    result.AddRange(node.Children);

                return result;
            }

            if (node.IsLoopOfLoops)
            {
                result.AddRange(node.GetChildrenWithExclusion(exclusion));
                if (!result.Any())
                    result.AddRange(node.Children);
                result.Add(node.Parent);

                return result;
            }

            result.AddRange(node.Children);
            result.Add(node.Parent);

            return result;
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

                if (current.IsSegment)
                    yield return current;

                var neighbours = current.GetNeighboursWithExclusion(parents).Where(p => !visited.Contains(p));

                foreach (var neighbour in neighbours.Reverse())
                    stack.Push(neighbour);                
            }
        }

        public static IEnumerable<ParseTree> GetParents(this ParseTree node, Func<ParseTree, bool> shouldContinue)
        {
            var stack = new Stack<ParseTree>();
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
            if(result.Last() != node.Parent)
                throw new ParserException("Incorrect parent collection.");
            result.Add(node);

            return result;
        }

        public static IEnumerable<ParseTree> GetSegmentTree(this ParseTree segment, ParseTree lastFoundSegment)
        {
            if(!segment.IsSegment)
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
    }
}
