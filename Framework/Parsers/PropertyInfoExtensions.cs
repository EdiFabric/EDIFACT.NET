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
        public static ParseNode ToParseNode(this PropertyInfo propertyInfo, object instance = null)
        {
            var type = propertyInfo.PropertyType;
            if (type.IsGenericType)
                type = type.GenericTypeArguments.First();

            var sAttr = propertyInfo.GetCustomAttribute<SAttribute>();
            if (sAttr != null)
                return new Segment(type, propertyInfo.Name, sAttr.Id, instance);

            var gAttr = propertyInfo.GetCustomAttribute<GAttribute>();
            if (gAttr != null)
                return new Loop(type, propertyInfo.Name, propertyInfo.Name, instance);

            var cAttr = propertyInfo.GetCustomAttribute<CAttribute>();
            if (cAttr != null)
                return new ComplexDataElement(type, propertyInfo.Name, propertyInfo.Name, instance);

            var dAttr = propertyInfo.GetCustomAttribute<DAttribute>();
            if (dAttr != null)
                return new DataElement(type, propertyInfo.Name, propertyInfo.Name, instance);

            var aAttr = propertyInfo.GetCustomAttribute<AAttribute>();
            if (aAttr != null)
                return new AllLoop(type, propertyInfo.Name, propertyInfo.Name, instance);

            throw new Exception(string.Format("Property {0} is not annotated with [EdiAttribute].", propertyInfo.Name));
        }

        public static IEnumerable<PropertyInfo> Sort(this PropertyInfo[] propertyInfos)
        {
            return propertyInfos.OrderBy(
                p =>
                    p.GetCustomAttributes(typeof(EdiAttribute), false)
                        .Cast<EdiAttribute>()
                        .Select(a => a.Pos)
                        .FirstOrDefault());           
        }           
    }
}
