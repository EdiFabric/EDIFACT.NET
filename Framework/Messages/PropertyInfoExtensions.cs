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

namespace EdiFabric.Framework.Messages
{
    /// <summary>
    /// Global extensions for .NET PropertyInfo class.
    /// These are used in conjunction with Parse Tree class and the EDI definitions.
    /// </summary>
    static class PropertyInfoExtensions
    {
        /// <summary>
        /// Sorts a collection of properties by the Order attribute.
        /// Order is only set in XmlElement or XmlArray attributes.
        /// </summary>
        /// <param name="propertyInfos">
        /// The collection of property infos.
        /// </param>
        /// <returns>
        /// The sorted collection of property infos.
        /// </returns>
        public static List<PropertyInfo> Sort(this PropertyInfo[] propertyInfos)
        {
            var dictionary = new SortedDictionary<int, PropertyInfo>();

            // Iterate through each property
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

        /// <summary>
        /// Extracts the enum values from a property.
        /// </summary>
        /// <param name="propertyInfo">The property.</param>
        /// <returns>The list of enum values.</returns>
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

        /// <summary>
        /// Gets the type name from a property info.
        /// </summary>
        /// <param name="propertyInfo">The property info.</param>
        /// <returns>The type.</returns>
        public static Type GetSystemType(this PropertyInfo propertyInfo)
        {
            if (propertyInfo.IsList())
            {
                return propertyInfo.PropertyType.GetGenericArguments()[0];
            }

            return propertyInfo.PropertyType;
        }
        
        /// <summary>
        /// Gets the values for an element if that element is defined as enum.
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <returns></returns>
        public static List<string> GetProperyValues(this PropertyInfo propertyInfo)
        {
            if (propertyInfo.IsList())
                return new List<string>();

            if (!propertyInfo.Name.StartsWith(EdiPrefix.C.ToString())) 
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
