using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Annotations.Edi;

namespace EdiFabric.Framework
{
    /// <summary>
    /// PropertyInfo extensions
    /// </summary>
    static class PropertyInfoExtensions
    {
        /// <summary>
        /// Sorts the properties if they are marked with position attribute.
        /// </summary>
        /// <param name="propertyInfos">The properties to sort.</param>
        /// <returns>The sorted properties.</returns>
        public static IEnumerable<PropertyInfo> Sort(this PropertyInfo[] propertyInfos)
        {
            return propertyInfos.OrderBy(
                p =>
                    p.GetCustomAttributes(typeof(PosAttribute), false)
                        .Cast<PosAttribute>()
                        .Select(a => a.Pos)
                        .FirstOrDefault());
        }

        /// <summary>
        /// Gets the type of the generic property.
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>
        public static Type GetGenericType(this PropertyInfo propertyInfo)
        {
            var type = propertyInfo.PropertyType;
            if (type.IsGenericType)
                type = type.GenericTypeArguments.First();

            return type;
        }
    }
}
