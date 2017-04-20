using System;
using System.Collections.Generic;

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

        public Segment(Type type, string name, string ediName, object instance = null)
            : base(type, name, ediName)
        {
            if (instance == null)
            {
                var firstTwo = GetProperties().GetFirstTwoPropertyValues();
                _firstChildValues = firstTwo.Item1;
                _secondChildValues = firstTwo.Item2;
                return;
            }

            BuildChildren(instance, true);
        }

        public Segment(Type type, object instance = null)
            : base(type, type.Name, type.Name)
        {
            BuildChildren(instance, true);
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IList<ParseNode> exclusion)
        {
            return new List<ParseNode> {Parent};
        }       
    }
}
