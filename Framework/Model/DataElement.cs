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

using System.Reflection;
using EdiFabric.Core.Annotations.Validation;

namespace EdiFabric.Framework.Model
{
    class DataElement : ParseNode
    {
        public DataElement(PropertyInfo propertyInfo, object instance = null)
            : base(propertyInfo.GetGenericType(), propertyInfo.Name, GetEdiName(propertyInfo))
        {
            Value = instance as string;
        }

        public DataElement(ParseNode parseNode)
            : base(parseNode.TypeInfo, parseNode.Name, parseNode.EdiName)
        {
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
        }

        public override void Parse(string value, Separators separators, bool allowPartial)
        {
            IsParsed = true;
            Value = value.UnEscapeLine(separators);
        }

        public override ParseNode InsertRepetition()
        {
            return new DataElement(this);
        }

        public override object ToInstance()
        {
            return Value;
        }

        private static string GetEdiName(PropertyInfo propertyInfo)
        {
            var attr = propertyInfo.GetCustomAttribute<DataElementAttribute>();
            if (attr != null && !string.IsNullOrEmpty(attr.Code))
                return attr.Code;

            return propertyInfo.Name;
        }
    }
}
