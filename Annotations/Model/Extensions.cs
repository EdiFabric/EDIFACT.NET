using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Annotations.Edi;

namespace EdiFabric.Annotations.Model
{
    public static class Extensions
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
