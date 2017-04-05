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
        public DataElement(PropertyInfo propertyInfo, string value = null)
            : base(propertyInfo)
        {
            Value = value;
        }

    }
}
