using System;
using System.Collections.Generic;
using System.Linq;
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

        public Segment(Type type, string name, string ediName, List<string> firstValues, List<string> secondValues, object instance = null)
            : base(type, name, ediName)
        {
            if (instance == null)
            {
                if (firstValues != null)
                    _firstChildValues = firstValues;
                if (secondValues != null)
                    _secondChildValues = secondValues;
                return;
            }

            BuildChildren(instance, true);
        }

        public Segment(Type type)
            : base(type, type.Name, type.Name)
        {
        }

        public Segment(Segment segment)
            : this(segment.Type, segment.Name, segment.EdiName, segment._firstChildValues, segment._secondChildValues)
        {
            segment.Parent.InsertChild(segment.IndexInParent() + 1, this);
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IList<ParseNode> exclusion)
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
