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
using System.Xml.Serialization;
using EdiFabric.Framework.Messages.Segments;

namespace EdiFabric.Framework.Messages
{
    /// <summary>
    /// The pasing grammar of edi nodes. 
    /// </summary>
    class ParseTree : IEqualityComparer<ParseTree>
    {
        /// <summary>
        /// Node name
        /// (Message, Group, Segment, Data Element, etc.)
        /// Everything is a ParseTree
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type in the definitions class representing this node
        /// </summary>
        public Type SystemType { get; set; }

        /// <summary>
        /// The parent node or ParseTree
        /// </summary>
        public ParseTree Parent { get; set; }

        /// <summary>
        /// The children collection 
        /// </summary>
        public List<ParseTree> Children { get; set; }

        /// <summary>
        /// The collection of values defined for that node.
        /// This is only populated for segmenst and is the enum of values 
        /// for the first dataelement for that segment.
        /// </summary>
        public List<string> Values { get; set; }

        /// <summary>
        /// One of the edi prefixes
        /// </summary>
        public string Prefix
        {
            get { return Name.Split('_')[0]; }
        }

        /// <summary>
        /// The name without the prefix
        /// </summary>
        public string EdiName
        {
            get { return Name.Split('_')[1]; }
        }

        /// <summary>
        /// If it is message
        /// </summary>
        public bool IsMessage
        {
            get { return Prefix == EdiPrefix.M; }
        }

        /// <summary>
        /// If it is group
        /// </summary>
        public bool IsGroup
        {
            get { return Prefix == EdiPrefix.G; }
        }

        /// <summary>
        /// If it is all
        /// </summary>
        public bool IsAll
        {
            get { return Prefix == EdiPrefix.A; }
        }

        /// <summary>
        /// If it is choice
        /// </summary>
        public bool IsChoice
        {
            get { return Prefix == EdiPrefix.I; }
        }

        /// <summary>
        /// If it is loop of groups
        /// </summary>
        public bool IsLoopOfLoops
        {
            get { return Prefix == EdiPrefix.U; }
        }

        /// <summary>
        /// If it is segment
        /// </summary>
        public bool IsSegment
        {
            get { return Prefix == EdiPrefix.S; }
        }

        /// <summary>
        /// If it is complex element
        /// </summary>
        public bool IsComplex
        {
            get { return Prefix == EdiPrefix.C; }
        }

        /// <summary>
        /// If it is data element
        /// </summary>
        public bool IsSimple
        {
            get { return Prefix == EdiPrefix.D; }
        }

        /// <summary>
        /// If it is trigger, e.g. the first segment in the group
        /// </summary>
        public bool IsTrigger
        {
            get
            {
                if (Parent != null && Parent.Prefix == EdiPrefix.G)
                {
                    return Parent.Children.IndexOf(this) == 0;
                }

                return false;
            }
        }

        /// <summary>
        /// If it is envelope segment
        /// </summary>
        public bool IsEnvelope
        {
            get { return SystemType.FullName.Contains("EdiFabric.Framework.Envelopes"); }
        }

        /// <summary>
        /// Factory from system type.
        /// Builds a parse tree from the class definition.
        /// </summary>
        /// <param name="systemType">The system type</param>
        /// <param name="limit">How deep to build (segments with data elements or segments without data elements)</param>
        /// <returns>The parse tree</returns>
        public static ParseTree LoadFrom(Type systemType, Func<ParseTree, bool> limit)
        {
            if (systemType == null) throw new ArgumentNullException("systemType");
            if (limit == null) throw new ArgumentNullException("limit");

            // Build the parse tree root
            var result = new ParseTree
            {
                Name = systemType.Name,
                Children = new List<ParseTree>(),
                SystemType = systemType,
                Values = new List<string>()
            };

            // Get all properties from the class definition, sorted by Order attribute
            // This is required as .NET can scramble the properties in the class declaration
            // GetProperties method is not supposed to return all properties in the order they are declared in the class file.
            var properties = systemType.GetProperties().Sort();

            // Always populate the enum list for a segment, e.g.
            // This is the first element defined in the segment
            // This is required for Hipaa as the segments are not only identified by name
            // There could be situations where
            // S_BHT+41 is different segment than S_BHT+88, although both are S_BHT
            if (result.IsSegment && properties.Any())
            {
                result.Values.AddRange(properties[0].GetProperyEnumValues());
            }

            // Check if need to go deeper or stop
            if (!limit(result)) return result;

            // Drill down the children
            foreach (var propertyInfo in properties)
            {
                // TODO: refactor to remove the recursion
                ParseTree parseTree;
                if (propertyInfo.IsChoice())
                {
                    parseTree = propertyInfo.GetParseTreeRoot();
                    foreach (var attr in propertyInfo.GetCustomAttributes(typeof(XmlArrayItemAttribute), false))
                    {
                        var attrChild = LoadFrom(((XmlArrayItemAttribute)attr).Type, limit);

                        attrChild.Parent = parseTree;
                        parseTree.Children.Add(attrChild);
                    }
                }
                else
                {
                    parseTree = propertyInfo.Name.StartsWith(EdiPrefix.D)
                        ? new ParseTree { Name = propertyInfo.Name }
                        : LoadFrom(propertyInfo.GetSystemType(), limit);
                }

                parseTree.Parent = result;
                result.Children.Add(parseTree);
            }

            return result;
        }

        /// <summary>
        /// Custom equal
        /// </summary>
        /// <param name="x">
        /// Parse tree source
        /// </param>
        /// <param name="y">
        /// Parse tree target
        /// </param>
        /// <returns>
        /// If source is equal to target
        /// </returns>
        public bool Equals(ParseTree x, ParseTree y)
        {
            return x.EdiName == y.EdiName;
        }

        /// <summary>
        /// Generates hash code
        /// </summary>
        /// <param name="obj">
        /// The parse tree
        /// </param>
        /// <returns>
        /// The hash code
        /// </returns>
        public int GetHashCode(ParseTree obj)
        {
            return obj.EdiName.GetHashCode();
        }

        /// <summary>
        /// Gets the parents of a parse tree until a condition.
        /// The condition is usually the type of parent, e.g. Group or Message
        /// </summary>
        /// <param name="shouldContinue">
        /// The condition to traverse up the hierarchy until.
        /// </param>
        /// <returns>
        /// A collection of parse trees sorted by parentship.
        /// </returns>
        public IEnumerable<ParseTree> GetParents(Func<ParseTree, bool> shouldContinue)
        {
            var stack = new Stack<ParseTree>();
            // Always return at least the immediate parent
            stack.Push(Parent);
            while (stack.Count != 0)
            {
                var item = stack.Pop();
                yield return item;
                if (shouldContinue(item))
                    stack.Push(item.Parent);
            }
        }

        /// <summary>
        /// Gets the index to start searching from
        /// </summary>
        /// <returns>The index</returns>
        public int GetIndex()
        {
            // If the parent is choice, all or loop of group always start from the beginning
            if (Parent.IsChoice || Parent.IsAll || Parent.IsLoopOfLoops)
                return 0;

            // If the parse tree is choice, all or loop of group 
            // and the parent is a group, always start from the next parse tree, e.g.
            // ther can be no repetitions of the same parse tree
            if (IsChoice || IsAll || IsLoopOfLoops)
                return Parent.Children.IndexOf(this) + 1;

            // If it is a segment, start from the same segment as it might be a repetition of the segment
            return Parent.Children.IndexOf(this);
        }

        /// <summary>
        /// Compare a parse tree to identity
        /// </summary>
        /// <param name="segmentContext">The identity</param>
        /// <returns>If equal</returns>
        public bool IsEqual(SegmentContext segmentContext)
        {
            // The names must match
            if (EdiName == segmentContext.Name)
            {
                // If no identity match is required, mark this as a match
                if (string.IsNullOrEmpty(segmentContext.Value))
                    return true;

                // Match the value 
                // This must have been defined in the enum of the first element of the segment.
                return !Values.Any() || Values.Contains(segmentContext.Value);
            }

            return false;
        }

        /// <summary>
        /// Finds the next segment by full name
        /// </summary>
        /// <param name="segmentContext">The segment full name (name + value).</param>
        /// <returns>
        /// The found segment.
        /// </returns>
        public ParseTree FindNextSegment(SegmentContext segmentContext)
        {
            // Look on the same level first
            foreach (var child in Parent.Children.Skip(GetIndex()))
            {
                if (child.IsSegment && child.IsEqual(segmentContext))
                    return child;

                if (child.IsGroup && child.Children.First().IsEqual(segmentContext))
                    return child.Children.First();

                // Search a level down
                if (child.IsAll || child.IsChoice || child.IsLoopOfLoops)
                    return child.Children.First().FindNextSegment(segmentContext);
            }

            // Search a level up
            return Parent.FindNextSegment(segmentContext);
        }

        public IEnumerable<ParseTree> Descendants()
        {
            var nodes = new Stack<ParseTree>(new[] { this });
            while (nodes.Any())
            {
                var node = nodes.Pop();
                yield return node;
                foreach (var n in node.Children) nodes.Push(n);
            }
        }
    }
}
