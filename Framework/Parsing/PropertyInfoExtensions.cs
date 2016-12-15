//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace EdiFabric.Framework.Parsing
{
    static class PropertyInfoExtensions
    {
        internal static IEnumerable<PropertyInfo> Sort(this PropertyInfo[] propertyInfos)
        {
            return propertyInfos.OrderBy(
                p =>
                    p.GetCustomAttributes(typeof(XmlElementAttribute), false)
                        .Cast<XmlElementAttribute>()
                        .Select(a => a.Order)
                        .FirstOrDefault());           
        }

        internal static IEnumerable<string> GetPropertyEnumValues(this PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType.IsEnum)
            {
                var fields = propertyInfo.PropertyType.GetFields(BindingFlags.Public | BindingFlags.Static);
                foreach (var field in fields)
                {
                    var attr =
                        (XmlEnumAttribute)field.GetCustomAttributes(typeof(XmlEnumAttribute), false).FirstOrDefault();
                    if (attr != null)
                    {
                        yield return attr.Name;
                        continue;
                    }

                    yield return field.Name;
                }
            }
        }

        internal static Tuple<List<string>, List<string>> GetFirstTwoPropertyValues(this IEnumerable<PropertyInfo> propertyInfos)
        {
            List<string> element0 = null;
            List<string> element1 = null;
            
            int i = 0;            
            var firstTwo = propertyInfos.Take(2);
            foreach (var item in firstTwo)
            {
                var currItem = item;
                if (item.Name.StartsWith(Prefixes.C.ToString(), StringComparison.Ordinal))
                    currItem = item.PropertyType.GetProperties().Sort().First();
                if (!currItem.PropertyType.IsEnum)
                {
                    i++;
                    continue;
                }
                if (i == 0)
                {
                    element0 = currItem.GetPropertyEnumValues().ToList();
                }
                if (i == 1)
                {
                    element1 = currItem.GetPropertyEnumValues().ToList();
                }
                i++;
            }

            return new Tuple<List<string>, List<string>>(element0 ?? new List<string>(), element1 ?? new List<string>());
        }
        
        internal static object GetPropertyValue(this PropertyInfo propertyInfo, string value)
        {
            if (!propertyInfo.PropertyType.IsEnum) return value;
            if (value.Length > 0 && char.IsDigit(value[0]))
            {
                return Enum.Parse(propertyInfo.PropertyType, string.Format("Item{0}", value));
            }

            return Enum.Parse(propertyInfo.PropertyType, value);
        }
    }
}
