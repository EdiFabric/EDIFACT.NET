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

namespace EdiFabric.Framework.Parsers
{
    class DataElement : ParseNode
    {
        public DataElement(PropertyInfo propertyInfo, object instance = null)
            : base(propertyInfo.GetGenericType(), propertyInfo.Name, propertyInfo.Name)
        {
            Value = instance as string;
        }

        public DataElement(ParseNode parseNode)
            : base(parseNode.Type, parseNode.Name, parseNode.EdiName)
        {
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
        }

        public override void Parse(string value, Separators separators)
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
    }
}
