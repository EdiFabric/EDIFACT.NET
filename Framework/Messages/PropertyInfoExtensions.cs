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
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework.Messages
{
    static class PropertyInfoExtensions
    {
        public static List<PropertyInfo> Sort(this PropertyInfo[] propertyInfos)
        {
            var dictionary = new SortedDictionary<int, PropertyInfo>();

            foreach (var propertyInfo in propertyInfos)
            {
                var attributes = Attribute.GetCustomAttributes(propertyInfo);
                if (attributes.OfType<XmlIgnoreAttribute>().Any())
                    continue;

                var elementAttribute = attributes.OfType<XmlElementAttribute>().FirstOrDefault();
                if (elementAttribute != null)
                {
                    dictionary.Add(elementAttribute.Order, propertyInfo);
                }
            }               

            return dictionary.Select(v => v.Value).ToList();
        }

        public static IEnumerable<string> GetProperyEnumValues(this PropertyInfo propertyInfo)
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

        public static Type GetSystemType(this PropertyInfo propertyInfo)
        {
            if (propertyInfo.IsList())
            {
                return propertyInfo.PropertyType.GetGenericArguments()[0];
            }

            return propertyInfo.PropertyType;
        }
        
        public static List<string> GetProperyValues(this PropertyInfo propertyInfo)
        {
            if (propertyInfo.IsList())
                return new List<string>();

            if (!propertyInfo.Name.StartsWith(Prefixes.C.ToString())) 
                return propertyInfo.GetProperyEnumValues().ToList();
            
            var complexProperties = propertyInfo.PropertyType.GetProperties().Sort();
            return complexProperties[0].GetProperyEnumValues().ToList();
        }

        public static bool IsList(this PropertyInfo propertyInfo)
        {
            return typeof (IList).IsAssignableFrom(propertyInfo.PropertyType)
                   && propertyInfo.PropertyType.IsGenericType;
        }

        public static object GetPropertyValue(this PropertyInfo propertyInfo, string value)
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
