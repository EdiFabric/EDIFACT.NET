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
using EdiFabric.Attributes;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Framework.Parsers
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

        public Segment(PropertyInfo propertyInfo, SAttribute sAttr, object instance = null)
            : this(propertyInfo.GetGenericType(), propertyInfo.Name, sAttr.Id, instance)
        {
            if (sAttr.First != null)
            {
                var eAttr = (EAttribute)sAttr.First.GetCustomAttributes(typeof(EAttribute)).SingleOrDefault();
                if (eAttr == null)
                    throw new Exception(string.Format("Type {0} is not annotated with [EAttribute].",
                        sAttr.First.Name));
                _firstChildValues = eAttr.Codes.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (sAttr.Second != null)
                {
                    var eAttrS = (EAttribute)sAttr.Second.GetCustomAttributes(typeof(EAttribute)).SingleOrDefault();
                    if (eAttrS == null)
                        throw new Exception(string.Format("Type {0} is not annotated with [EAttribute].",
                            sAttr.Second.Name));
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

        public override void Parse(string value, Separators separators)
        {
            if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("value");
            if (separators == null) throw new ArgumentNullException("separators");

            if (!Children.Any())
                BuildChildren();
            
            IsParsed = true;

            var index = 0;
            foreach (var currentToParse in value.GetDataElements(separators))
            {
                if (String.IsNullOrEmpty(currentToParse))
                {
                    index++;
                    continue;
                }

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
    }
}
