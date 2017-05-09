using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Annotations.Edi;

namespace EdiFabric.Core
{
    public static class PropertyInfoExtensions
    {
        public static IEnumerable<PropertyInfo> Sort(this PropertyInfo[] propertyInfos)
        {
            return propertyInfos.OrderBy(
                p =>
                    p.GetCustomAttributes(typeof(PosAttribute), false)
                        .Cast<PosAttribute>()
                        .Select(a => a.Pos)
                        .FirstOrDefault());
        }

        public static Type GetGenericType(this PropertyInfo propertyInfo)
        {
            var type = propertyInfo.PropertyType;
            if (type.IsGenericType)
                type = type.GenericTypeArguments.First();

            return type;
        }
    }
}
