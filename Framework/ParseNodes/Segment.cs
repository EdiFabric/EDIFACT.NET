using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EdiFabric.Attributes;

namespace EdiFabric.Framework.Parsing
{
    class Segment : ParseNode
    {
        private List<string> _firstChildValues = new List<string>();
        public IReadOnlyCollection<string> FirstChildValues
        {
            get { return _firstChildValues.AsReadOnly(); }
        }

        private List<string> _secondChildValues = new List<string>();
        public IReadOnlyCollection<string> SecondChildValues
        {
            get { return _secondChildValues.AsReadOnly(); }
        }

        public bool IsTrigger
        {
            get { return Parent is Loop && IndexInParent() == 0; }
        }

        public Segment(Type type, bool lazyLoad = false)
            : base(type)
        {
            Build(lazyLoad);
        }

        public Segment(PropertyInfo propertyInfo, string ediName)
            : base(propertyInfo, ediName)
        {
            Build(true);
            var firstTwo = GetProperties().GetFirstTwoPropertyValues();
            _firstChildValues = firstTwo.Item1;
            _secondChildValues = firstTwo.Item2;
        }

        public Segment(object instance)
            : base(instance.GetType())
        {
            BuildFromInstance(instance);
        }

        private void Build(bool lazyLoadSegment)
        {
            var stack = new Stack<ParseNode>(new[] { this });

            while (stack.Any())
            {
                var currentNode = stack.Pop();

                var properties = currentNode.GetProperties();
                if (lazyLoadSegment)
                {
                    //var firstTwo = properties.GetFirstTwoPropertyValues();
                    //currentNode._firstChildValues = firstTwo.Item1;
                    //currentNode._secondChildValues = firstTwo.Item2;
                    //continue;
                }

                foreach (var property in properties)
                {
                    var childNode = property.ToParseNode();
                    currentNode.AddChild(childNode);

                    if (childNode is DataElement) continue;

                    stack.Push(childNode);
                }
            }
        }

        public override IEnumerable<ParseNode> NeighboursWithExclusion(IList<ParseNode> exclusion)
        {
            return new List<ParseNode> {Parent};
        }
    }
}
