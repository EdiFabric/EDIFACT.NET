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
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Model
{
    class ComplexDataElement : ParseNode
    {
        public ComplexDataElement(PropertyInfo propertyInfo, CompositeAttribute cAttr, object instance = null)
            : base(propertyInfo.GetGenericType(), propertyInfo.Name, cAttr.Id)
        {
            BuildChildren(instance, true);
        }

        public ComplexDataElement(ParseNode parseNode)
            : base(parseNode.Type, parseNode.Name, parseNode.EdiName)
        {
            parseNode.Parent.InsertChild(parseNode.IndexInParent() + 1, this);
            BuildChildren(null, true);
        }

        public override void Parse(string value, Separators separators, bool allowPartial)
        {
            IsParsed = true;
            var index = 0;
            foreach (var currentToParse in value.GetComponentDataElements(separators))
            {
                if (String.IsNullOrEmpty(currentToParse))
                {
                    index++;
                    continue;
                }

                if (index >= Children.Count)
                {
                    if (allowPartial)
                        continue;

                    throw new ParserElementException("Too many components.", DataElementErrorCode.TooManyComponents, index);
                }

                var currentElement = Children.ElementAt(index);
                if (currentElement.IsParsed)
                {
                    currentElement = currentElement.InsertRepetition();
                    index++;
                }
                currentElement.Parse(currentToParse, separators, allowPartial);
                index++;
            }
        }

        public override ParseNode InsertRepetition()
        {
            return new ComplexDataElement(this);
        }
    }
}
