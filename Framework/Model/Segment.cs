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
using EdiFabric.Core;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Model;

namespace EdiFabric.Framework.Model
{
    class Segment : ParseNode
    {
        private readonly List<string> _firstChildValues = new List<string>();
        public IReadOnlyCollection<string> FirstChildValues
        {
            get { return _firstChildValues.AsReadOnly(); }
        }

        private readonly List<string> _secondChildValues = new List<string>();
        public IReadOnlyCollection<string> SecondChildValues
        {
            get { return _secondChildValues.AsReadOnly(); }
        }

        public bool IsTrigger
        {
            get { return Parent is Loop && IndexInParent() == 0; }
        }

        private Segment(Type type, string name, string ediName, object instance = null)
            : base(type, name, ediName)
        {
            if (instance == null) return;
            BuildChildren(instance, true);
        }

        public Segment(PropertyInfo propertyInfo, SegmentAttribute sAttr, object instance = null)
            : this(propertyInfo.GetGenericType(), propertyInfo.Name, sAttr.Id, instance)
        {
            if (sAttr.First != null)
            {
                var eAttr = (EdiCodesAttribute)sAttr.First.GetCustomAttributes(typeof(EdiCodesAttribute)).SingleOrDefault();
                if (eAttr == null)
                    throw new Exception(string.Format("Type {0} is not annotated with {1}.",
                        sAttr.First.Name, typeof(EdiCodesAttribute).Name));
                _firstChildValues = eAttr.Codes.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (sAttr.Second != null)
                {
                    var eAttrS = (EdiCodesAttribute)sAttr.Second.GetCustomAttributes(typeof(EdiCodesAttribute)).SingleOrDefault();
                    if (eAttrS == null)
                        throw new Exception(string.Format("Type {0} is not annotated with {1}.",
                            sAttr.Second.Name, typeof(EdiCodesAttribute).Name));
                    _secondChildValues = eAttrS.Codes.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
            }
        }

        public Segment(Type type, object instance = null)
            : this(type, type.Name, type.Name, instance)
        {
        }

        public Segment(Segment segment)
            : this(segment.Type, segment.Name, segment.EdiName)
        {
            segment.Parent.InsertChild(segment.IndexInParent() + 1, this);
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IEnumerable<ParseNode> exclusion)
        {
            return new List<ParseNode> {Parent};
        }

        public override void SetParsed()
        {
            IsParsed = true;
            if (Parent != null)
                Parent.SetParsed();
        }

        public override void Parse(string value, Separators separators)
        {
            if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("value");
            if (separators == null) throw new ArgumentNullException("separators");

            if (!Children.Any())
                BuildChildren();

            SetParsed();

            var index = 0;
            foreach (var currentToParse in value.GetDataElements(separators))
            {
                if (String.IsNullOrEmpty(currentToParse))
                {
                    index++;
                    continue;
                }

                if (index >= Children.Count)
                    throw new ParsingException(ErrorCode.DataElementsTooMany, "Too many data elements in segment.",
                           value);

                var currentElement = Children.ElementAt(index);

                var repetitions = currentElement.IsX12RepetitionSeparator()
                    ? new List<string> { currentToParse }
                    : currentToParse.GetRepetitions(separators);

                foreach (var repetition in repetitions)
                {
                    if (String.IsNullOrEmpty(repetition)) continue;
                    if (currentElement.IsParsed)
                    {
                        currentElement = currentElement.InsertRepetition();
                        index++;
                    }
                    currentElement.Parse(repetition, separators);                   
                }
                index++;
            }
        }

        public override ParseNode InsertRepetition()
        {
            if (IsTrigger)
            {
                return (Segment) new Loop(Parent).Children.First();
            }

            return new Segment(this);
        }

        public string GenerateSegment(Separators separators, bool preserveWhitespace)
        {
            if (separators == null) throw new ArgumentNullException("separators");

            var result = new List<string> {EdiName};

            foreach (var element in Children)
            {
                string value;
                if (element is ComplexDataElement)
                {
                    var composite = new List<string>();
                    foreach (var child in element.Children.OfType<DataElement>())
                    {
                        composite.Add(child.Value.EscapeLine(separators));
                        composite.Add(separators.ComponentDataElement.ToString());
                    }
                    value = composite.TrimEndWithEscape(separators.Escape, separators.ComponentDataElement,
                        preserveWhitespace);
                }
                else
                {
                    var de = element as DataElement;
                    if (de == null)
                        throw new Exception(String.Format("Unexpected node {0} under parent {1}", element.Type.FullName,
                            element.Parent.Type.FullName));

                    value = de.Value.EscapeLine(separators);
                }

                var separator = element.IsRepetition()
                    ? separators.RepetitionDataElement
                    : separators.DataElement;

                result.Add(separator.ToString());
                result.Add(value);
            }

            return result.TrimEndWithEscape(separators.Escape, separators.DataElement, preserveWhitespace) +
                   separators.Segment;
        }

        public bool Match(SegmentContext segmentContext)
        {
            // The names must match
            if (EdiName == segmentContext.Name)
            {
                // If no identity match is required, mark this as a match
                if (String.IsNullOrEmpty(segmentContext.FirstValue) || !FirstChildValues.Any())
                    return true;

                // Match the value 
                // This must have been defined in the enum of the first element of the segment.
                if (FirstChildValues.Any() && !String.IsNullOrEmpty(segmentContext.FirstValue) &&
                    FirstChildValues.Contains(segmentContext.FirstValue))
                {
                    if (SecondChildValues.Any() && !String.IsNullOrEmpty(segmentContext.SecondValue))
                    {
                        return SecondChildValues.Contains(segmentContext.SecondValue);
                    }

                    return true;
                }
            }

            return false;
        }        
    }
}
