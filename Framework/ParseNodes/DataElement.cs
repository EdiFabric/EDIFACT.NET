using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EdiFabric.Framework.Parsing
{
    class DataElement : ParseNode
    {
        public string Value { get; private set; }
        
        public DataElement(PropertyInfo propertyInfo, string value) : base(propertyInfo)
        {
            Value = value;
        }
    }
}
