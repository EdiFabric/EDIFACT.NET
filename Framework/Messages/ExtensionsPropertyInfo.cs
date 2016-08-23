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
    static class ExtensionsPropertyInfo
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
            var dictionary = new Dictionary<int, PropertyInfo>();
            
            // Iterate through each property
            foreach (var propertyInfo in propertyInfos)
            {
                int order;

                // Skip property if it is decorated with XmlIgnore
                var ignoreAttribute =
                    Attribute.GetCustomAttributes(propertyInfo, typeof(XmlIgnoreAttribute), true).FirstOrDefault() as XmlIgnoreAttribute;
                if (ignoreAttribute != null) continue;

                // Get all XmlElement attributes
                // Usually there is only one but only for choices there are many
                var elementAttributes =
                    Attribute.GetCustomAttributes(propertyInfo, typeof(XmlElementAttribute), true).OfType<XmlElementAttribute>().ToList();

                // Check if any at all
                // If none is found try to find XmlArray
                if (!elementAttributes.Any())
                {
                    // Gets here only if no XmlElement attribute is found.
                    var arrayAttribute =
                    Attribute.GetCustomAttribute(propertyInfo, typeof(XmlArrayAttribute), true) as XmlArrayAttribute;

                    // If no XmlAttribute is found then no Order had been set and the collection can't be sorted
                    if(arrayAttribute == null)
                        throw new NullReferenceException("arrayAttribute");

                    order = arrayAttribute.Order;
                }
                else
                {
                    // In case multiple XmlElement attributes were found, their Order must be the same
                    // otherwise it becomes ambiguous and throws exception
                    var firstVal = elementAttributes.First().Order;
                    if (elementAttributes.Any(ea => ea.Order != firstVal))
                        throw new Exception("Ambiguous ordering in XmlElementAttribute.");
                    
                    order = firstVal;
                }

                dictionary.Add(order, propertyInfo);
            }

            return dictionary.OrderBy(d => d.Key).Select(v => v.Value).ToList();
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
            if (typeof(IList).IsAssignableFrom(propertyInfo.PropertyType)
                && propertyInfo.PropertyType.IsGenericType)
            {
                return propertyInfo.PropertyType.GetGenericArguments()[0];
            }

            return propertyInfo.PropertyType;
        }

        /// <summary>
        /// Gets the values for an element if that element is defined as enum.
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <param name="index">The index to the property we need.</param>
        /// <returns></returns>
        public static IList<string> GetProperyValues(this PropertyInfo propertyInfo, int index)
        {
            var values = propertyInfo.GetProperyEnumValues().ToList();
            if (!propertyInfo.Name.StartsWith(EdiPrefix.C.ToString()) || values.Any()) return values;
            try
            {
                var complexProperties = propertyInfo.PropertyType.GetProperties().Sort();
                values = complexProperties[index].GetProperyEnumValues().ToList();
            }
            catch
            {
                // ignored
            }
            
            return values;
        }
    }
}
