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
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Attributes;

namespace EdiFabric.Framework.Parsers
{
    static class PropertyInfoExtensions
    {
        internal static ParseNode ToParseNode(this PropertyInfo propertyInfo, object value = null)
        {
            var sAttr = propertyInfo.GetCustomAttribute<SAttribute>();
            if (sAttr != null)
                return new Segment(propertyInfo, sAttr.Id);

            var gAttr = propertyInfo.GetCustomAttribute<GAttribute>();
            if (gAttr != null)
                return new Loop(propertyInfo);

            var cAttr = propertyInfo.GetCustomAttribute<CAttribute>();
            if (cAttr != null)
                return new ComplexDataElement(propertyInfo);

            var dAttr = propertyInfo.GetCustomAttribute<DAttribute>();
            if (dAttr != null)
                return new DataElement(propertyInfo, value as string);

            var aAttr = propertyInfo.GetCustomAttribute<AAttribute>();
            if (aAttr != null)
                return new AllLoop(propertyInfo);

            throw new Exception(string.Format("Property {0} is not annotated with [EdiAttribute].", propertyInfo.Name));
        }

        internal static IEnumerable<PropertyInfo> Sort(this PropertyInfo[] propertyInfos)
        {
            return propertyInfos.OrderBy(
                p =>
                    p.GetCustomAttributes(typeof(EdiAttribute), false)
                        .Cast<EdiAttribute>()
                        .Select(a => a.Pos)
                        .FirstOrDefault());           
        }

        internal static Tuple<List<string>, List<string>> GetFirstTwoPropertyValues(this IEnumerable<PropertyInfo> propertyInfos)
        {
            var firstTwo = propertyInfos.Take(2).ToList();
            var element1 = firstTwo.Count > 0 ? firstTwo[0].GetDataElement().GetCodes() : new List<string>();
            var element2 = firstTwo.Count > 1 ? firstTwo[1].GetDataElement().GetCodes() : new List<string>();
            
            return new Tuple<List<string>, List<string>>(element1, element2);
        }

        static PropertyInfo GetDataElement(this PropertyInfo item)
        {
            var cAttr = item.GetCustomAttribute<CAttribute>();
            if (cAttr != null)
            {
                return item.PropertyType.IsGenericType
                         ? item.PropertyType.GenericTypeArguments.First().GetProperties().Sort().First()
                         : item.PropertyType.GetProperties().Sort().First();
            }

            return item;
        }

        static List<string> GetCodes(this PropertyInfo item)
        {
            var deAttr = item.GetCustomAttribute<DAttribute>();
            if(deAttr == null)
                throw new Exception("No DAttribute");

            if (deAttr.DataType != null)
            {
                var codes = deAttr.DataType.GetField("Codes");
                if (codes != null)
                {
                    return (List<String>)codes.GetValue(Activator.CreateInstance(deAttr.DataType));
                }
            }

            return new List<string>();
        }        
    }
}
