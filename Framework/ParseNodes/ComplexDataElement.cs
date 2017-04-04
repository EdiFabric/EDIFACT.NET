using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EdiFabric.Framework.Parsing
{
    class ComplexDataElement : ParseNode
    {
        public ComplexDataElement(PropertyInfo propertyInfo) : base(propertyInfo)
        {
        }
    }
}
