using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using EdiFabric.Annotations.Edi;
using EdiFabric.Annotations.Validation;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Parsers;

namespace EdiFabric.Framework.Validators
{
    public class TraverseItem
    {
        public object Instance { get; set; }
        public PropertyInfo Property { get; set; }
        private readonly TraverseItem _parent;
        private int _propertyIndex = 1;
        private readonly int _instanceIndex = 1;
        private int _repetitionIndex = 1;

        public bool IsRequired
        {
            get { return Property != null && Property.GetCustomAttributes<RequiredAttribute>().Any(); }
        }

        public string GetId()
        {
            if(Property == null)
                throw new NoNullAllowedException("Property");

            var ediAttr = Property.GetGenericType().GetCustomAttribute<EdiAttribute>();
            if (ediAttr == null)
                throw new Exception(string.Format("Property {0} is not annotated with [EdiAttribute].", Property.Name));

            return ediAttr.Id;
        }

        public string GetDeclaringTypeId()
        {
            if (Property == null)
                throw new NoNullAllowedException("Property");

            var ediAttr = Property.DeclaringType.GetCustomAttribute<EdiAttribute>();
            if (ediAttr == null)
                throw new Exception(string.Format("The type declaring Property {0} is not annotated with [EdiAttribute].", Property.Name));

            return ediAttr.Id;
        }

        public bool IsType<T>() where T : EdiAttribute
        {
            return Property != null && Property.PropertyType.GetCustomAttribute<T>() != null;
        }

        public bool IsGenericType<T>() where T : EdiAttribute
        {
            return Property != null && Property.GetGenericType().GetCustomAttribute<T>() != null;
        }

        public TraverseItem(object instance)
        {
            Instance = instance;
        }

        public TraverseItem(object instance, PropertyInfo property, TraverseItem parent, int propertyIndex,
            int instanceIndex, int repetitionIndex)
            : this(instance)
        {
            Property = property;
            _parent = parent;
            _propertyIndex = propertyIndex;
            _instanceIndex = instanceIndex;
            _repetitionIndex = repetitionIndex;
        }

        public IEnumerable<SegmentErrorContext> ValidateRequired(int segmentIndex)
        {
            if (Instance == null && IsRequired)
            {
                if (IsGenericType<AllAttribute>())
                {
                    var mandatoryNames =
                        Property.GetGenericType()
                            .GetProperties()
                            .Where(p => p.GetCustomAttribute<RequiredAttribute>() != null)
                            .Select(s => s.GetGenericType().GetCustomAttribute<EdiAttribute>().Id);

                    foreach (var name in mandatoryNames)
                    {
                        yield return new SegmentErrorContext(name, segmentIndex + 1, ValidationResult.RequiredMissing);
                    }
                }

                if (IsGenericType<GroupAttribute>() || IsType<SegmentAttribute>())
                {
                    yield return
                        new SegmentErrorContext(GetId(), segmentIndex + 1, ValidationResult.RequiredMissing);
                }

                if (IsGenericType<CompositeAttribute>())
                {
                    if (_parent.IsGenericType<SegmentAttribute>())
                        throw new Exception(string.Format("Parent of composite {0} must be a segment.", Property.Name));

                    var result = new SegmentErrorContext(_parent.GetId(), segmentIndex + 1);
                    result.Add(GetId(), _instanceIndex + 1, ValidationResult.RequiredMissing, 0, 0, null);
                    yield return result;
                }

                if (Property.GetGenericType() == typeof (string))
                {
                    var segmentName = _parent.IsGenericType<SegmentAttribute>()
                        ? _parent.GetId()
                        : _parent.GetDeclaringTypeId();

                    var dataElementAttr = Property.GetGenericType().GetCustomAttribute<DataElementAttribute>();
                    var name = dataElementAttr == null ? "" : dataElementAttr.Code;

                    var result = new SegmentErrorContext(segmentName, segmentIndex + 1);
                    result.Add(name, _instanceIndex + 1, ValidationResult.RequiredMissing, 0, 0, null);
                    yield return result;
                }

             }
        }

        public IEnumerable<TraverseItem> GetNeigbours()
        {
            if (Instance is string)
            {
            }
            else if (Instance == null)
            {
            }
            else
            {
                var propertyIndex = 0;
                var instanceIndex = 0;

                var list = Instance as IList;
                if (list != null)
                {
                    var repetitionIndex = 0;
                    foreach (var listValue in list)
                    {
                        repetitionIndex++;

                        if (listValue != null) 
                            instanceIndex++;

                        yield return
                            new TraverseItem(listValue, Property, this, propertyIndex, instanceIndex,
                                repetitionIndex);
                    }
                }
                else
                {
                    foreach (var propertyInfo in Instance.GetType().GetProperties().Sort())
                    {
                        propertyIndex++;

                        var value = propertyInfo.GetValue(Instance);

                        if (value != null) 
                            instanceIndex++;

                        yield return new TraverseItem(value, propertyInfo, this, propertyIndex, instanceIndex, 0);

                    }
                }
            }

            if (_parent != null)
                yield return _parent;
        }
    }
}
