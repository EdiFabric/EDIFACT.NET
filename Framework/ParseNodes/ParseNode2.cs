using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Attributes;

namespace EdiFabric.Framework.Parsing
{
    class ParseNode 
    {
        public PropertyInfo PropertyInfo { get; private set; }
        public string Name { get; private set; }
        public string EdiName { get; private set; }
        public ParseNode Parent { get; private set; }
        public Type Type { get; private set; }

        public string Path
        {
            get
            {
                return this.AncestorsAndSelf()
                    .Aggregate("", (current, node) => current + node.Name + node.IndexInParent());
            }
        }

        public int IndexOfChild(ParseNode child)
        {
            return _children.IndexOf(child);
        }

        public int IndexInParent()
        {
            return Parent != null ? Parent.IndexOfChild(this) : -1;
        }

        private readonly List<ParseNode> _children = new List<ParseNode>();
        public IReadOnlyCollection<ParseNode> Children
        {
            get { return _children.AsReadOnly(); }
        }

        protected ParseNode(PropertyInfo propertyInfo, string ediName = null)
        {
            var systemType = propertyInfo.PropertyType;
            if (systemType.IsGenericType)
                 systemType = systemType.GenericTypeArguments.First();

            Type = systemType;
            Name = propertyInfo.Name;
            EdiName = ediName ?? Name;
            PropertyInfo = propertyInfo;
        }

        protected ParseNode(Type type)
        {
            Type = type;
            Name = type.Name;
            EdiName = type.Name;
            PropertyInfo = null;
        }
        
        public void AddChild(ParseNode node)
        {
            node.Parent = this;
            _children.Add(node);
        }

        public IEnumerable<PropertyInfo> GetProperties()
        {
            return Type.GetProperties().Sort();
        }

        public static ParseNode NewNode(PropertyInfo propertyInfo)
        {
            var sAttr = propertyInfo.GetCustomAttribute<SAttribute>();
            if (sAttr != null)
                return new Segment(propertyInfo, sAttr.Id, false);
            
            var gAttr = propertyInfo.GetCustomAttribute<GAttribute>();
            if (gAttr != null)
                return new Loop(propertyInfo);

            var cAttr = propertyInfo.GetCustomAttribute<CAttribute>();
            if (cAttr != null)
                return new ComplexDataElement(propertyInfo);

            var dAttr = propertyInfo.GetCustomAttribute<DAttribute>();
            if (dAttr != null)
                return new DataElement(propertyInfo, null);

            throw new Exception(string.Format("Property {0} is not annotated with [EdiAttribute].", propertyInfo.Name));
        }

        public virtual IEnumerable<ParseNode> NeighboursWithExclusion(IList<ParseNode> exclusion)
        {
            throw new Exception(string.Format("Unsupported for: {0}", Type.FullName));
        }
    }
}
