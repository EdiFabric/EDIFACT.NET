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
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Core.Model.Edi
{
    /// <summary>
    /// The instance context used for validation
    /// </summary>
    public sealed class InstanceContext
    {
        private int _repetitionIndex;

        /// <summary>
        /// The instance.
        /// </summary>
        public object Instance { get; private set; }

        /// <summary>
        /// The property info for the instance.
        /// </summary>
        public PropertyInfo Property { get; private set; }

        /// <summary>
        /// The parent.
        /// </summary>
        public InstanceContext Parent { get; private set; }

        /// <summary>
        /// Gets the Edi Id from the property attributes.
        /// </summary>
        /// <returns>
        /// Identifier of the Edi item or throws an exception if property is not annotated with EdiAttribute.
        /// </returns>
        internal string GetId()
        {
            if (Property == null)
                return null;

            var ediAttr = Property.GetGenericType().GetCustomAttribute<EdiAttribute>();
            if (ediAttr == null)
                throw new Exception(string.Format("Property {0} is not annotated with {1}.", Property.Name,
                    typeof (EdiAttribute).Name));

            return ediAttr.Id;
        }

        /// <summary>
        /// Gets the declaring type of the property.
        /// </summary>
        /// <returns>
        /// The declaring type of the property or null if the property is null.
        /// </returns>
        internal string GetDeclaringTypeId()
        {
            if (Property == null || Property.DeclaringType == null)
                return null;

            var decalringType = Property.GetStandardDeclaringType();
            var ediAttr = decalringType.GetCustomAttribute<EdiAttribute>();
            if (ediAttr == null)
                throw new Exception(string.Format("The type {0} declaring property {1} is not annotated with {2}.",
                    decalringType.Name, Property.Name, typeof(EdiAttribute).Name));

            return ediAttr.Id;
        }

        /// <summary>
        /// Detects if the property contains an attribute inheriting from EdiAttribute.
        /// Only checks properties if the instance is not null and not a list.
        /// </summary>
        /// <typeparam name="T">The type of the property to look for.</typeparam>
        /// <returns>True if the property was found and False otherwise. Returns null if the instance is either null or list.</returns>
        internal bool IsInstanceOfType<T>() where T : EdiAttribute
        {
            if (Instance == null)
                return false;

            var list = Instance as IList;

            if (list != null)
                return false;

            return IsPropertyOfType<T>();
        }

        /// <summary>
        /// Detects if the property contains an attribute inheriting from EdiAttribute.
        /// </summary>
        /// <typeparam name="T">The type of the property to look for.</typeparam>
        /// <returns>True if the property was found and False otherwise.</returns>
        internal bool IsPropertyOfType<T>() where T : EdiAttribute
        {
            return Property != null && Property.GetGenericType().GetCustomAttribute<T>() != null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceContext"/> class.
        /// </summary>
        /// <param name="instance">An instance.</param>
        public InstanceContext(object instance)
        {
            Instance = instance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceContext"/> class.
        /// </summary>
        /// <param name="instance">An instance.</param>
        /// <param name="property">The property info for the instance.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="repetitionIndex">The repetition index.</param>
        internal InstanceContext(object instance, PropertyInfo property, InstanceContext parent, int repetitionIndex)
            : this(instance)
        {
            Property = property;
            Parent = parent;
            _repetitionIndex = repetitionIndex;
        }

        internal List<SegmentErrorContext> Validate(int segmentIndex, int inSegmentIndex, int inComponentIndex)
        {
            var result = new List<SegmentErrorContext>();

            if (Property == null) return result;

            var validationAttributes = Property.GetCustomAttributes<ValidationAttribute>().OrderBy(a => a.Priority);
            foreach (var validationAttribute in validationAttributes)
            {
                result.AddRange(validationAttribute.Validate(this, segmentIndex, inSegmentIndex, inComponentIndex,
                    _repetitionIndex));
            }

            if (Instance == null)
                return result;

            var customValidator = Instance as IValidator;
            if (customValidator == null)
                return result;

            result.AddRange(customValidator.Validate(this, segmentIndex, inSegmentIndex, inComponentIndex,
                    _repetitionIndex));

            return result;
        }

        internal IEnumerable<InstanceContext> GetNeigbours()
        {
            if (Instance != null && !(Instance is string))
            {
                var list = Instance as IList;
                if (list != null)
                {
                    _repetitionIndex = 0;
                    foreach (var listValue in list)
                    {
                        yield return
                            new InstanceContext(listValue, Property, this, _repetitionIndex++);
                    }
                }
                else
                {
                    foreach (
                        var propertyInfo in
                            Instance.GetStandardType()
                                .GetProperties(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance)
                                .Sort())
                    {
                        yield return new InstanceContext(propertyInfo.GetValue(Instance), propertyInfo, this, 0);
                    }
                }
            }

            if (Parent != null)
                yield return Parent;
        }

        internal void SetIndexes(ref int segmentIndex, ref int inSegmentIndex, ref int inComponentIndex)
        {
            if (IsInstanceOfType<SegmentAttribute>())
            {
                segmentIndex++;
                inSegmentIndex = 0;
                inComponentIndex = 0;
            }

            if (Parent != null && Parent.IsInstanceOfType<SegmentAttribute>())
            {
                inSegmentIndex++;
                inComponentIndex = 0;
            }

            if (Parent != null && Parent.IsInstanceOfType<CompositeAttribute>())
            {
                inComponentIndex++;
            }
        }
    }
}
