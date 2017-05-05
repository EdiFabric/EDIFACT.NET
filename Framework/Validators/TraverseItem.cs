using System;
using System.Collections;
using System.Collections.Generic;
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
        private readonly PropertyInfo _property;
        private readonly TraverseItem _parent;
        private readonly int _propertyIndex;
        private int _repetitionIndex = 1;

        private bool IsRequired
        {
            get { return _property != null && _property.GetCustomAttribute<RequiredAttribute>() != null; }
        }

        private string GetId()
        {
            if(_property == null)
                throw new NoNullAllowedException("Property");

            var ediAttr = _property.GetGenericType().GetCustomAttribute<EdiAttribute>();
            if (ediAttr == null)
                throw new Exception(string.Format("Property {0} is not annotated with [EdiAttribute].", _property.Name));

            return ediAttr.Id;
        }

        private string GetDeclaringTypeId()
        {
            if (_property == null)
                throw new NoNullAllowedException("Property");

            var ediAttr = _property.DeclaringType.GetCustomAttribute<EdiAttribute>();
            if (ediAttr == null)
                throw new Exception(string.Format("The type declaring Property {0} is not annotated with [EdiAttribute].", _property.Name));

            return ediAttr.Id;
        }

        public bool IsParentInstanceOfType<T>() where T : EdiAttribute
        {
            return _parent.IsInstanceOfType<T>();
        }

        public bool IsInstanceOfType<T>() where T : EdiAttribute
        {
            if (Instance == null)
                return false;

            var list = Instance as IList;

            if (list != null)
                return false;

            return IsPropertyOfType<T>();
        }

        private bool IsPropertyOfType<T>() where T : EdiAttribute
        {
            return _property != null && _property.GetGenericType().GetCustomAttribute<T>() != null;
        }

        public TraverseItem(object instance)
        {
            Instance = instance;
        }

        public TraverseItem(object instance, PropertyInfo property, TraverseItem parent, int propertyIndex,
            int repetitionIndex)
            : this(instance)
        {
            _property = property;
            _parent = parent;
            _propertyIndex = propertyIndex;
            _repetitionIndex = repetitionIndex;
        }

        public IEnumerable<SegmentErrorContext> ValidateRequired(int segmentIndex, int inSegmentIndex, int inCompositeIndex)
        {
            if (Instance == null && IsRequired)
            {
                if (IsPropertyOfType<AllAttribute>())
                {
                    var mandatoryNames =
                        _property.GetGenericType()
                            .GetProperties()
                            .Where(p => p.GetCustomAttribute<RequiredAttribute>() != null)
                            .Select(s => s.GetGenericType().GetCustomAttribute<EdiAttribute>().Id);

                    foreach (var name in mandatoryNames)
                    {
                        yield return new SegmentErrorContext(name, segmentIndex + 1, ValidationResult.RequiredMissing);
                    }
                }

                if (IsPropertyOfType<GroupAttribute>() || IsPropertyOfType<SegmentAttribute>())
                {
                    yield return
                        new SegmentErrorContext(GetId(), segmentIndex + 1, ValidationResult.RequiredMissing);
                }

                if (IsPropertyOfType<CompositeAttribute>())
                {
                    if (_parent.IsPropertyOfType<SegmentAttribute>())
                        throw new Exception(string.Format("Parent of composite {0} must be a segment.", _property.Name));

                    var result = new SegmentErrorContext(_parent.GetId(), segmentIndex + 1);
                    result.Add(GetId(), inSegmentIndex + 1, ValidationResult.RequiredMissing, 0, 0, null);
                    yield return result;
                }

                if (_property.GetGenericType() == typeof (string))
                {
                    var segmentName = _parent.IsPropertyOfType<SegmentAttribute>()
                        ? _parent.GetId()
                        : _parent.GetDeclaringTypeId();

                    var dataElementAttr = _property.GetGenericType().GetCustomAttribute<DataElementAttribute>();
                    var name = dataElementAttr == null ? "" : dataElementAttr.Code;

                    var result = new SegmentErrorContext(segmentName, segmentIndex + 1);
                    result.Add(name, inSegmentIndex + 1, ValidationResult.RequiredMissing, inCompositeIndex, 0, null);
                    yield return result;
                }

             }
        }

        public IEnumerable<TraverseItem> GetNeigbours()
        {
            if (Instance != null && !(Instance is string))
            {
                var list = Instance as IList;
                if (list != null)
                {
                    var repetitionIndex = 0;
                    foreach (var listValue in list)
                    {
                        yield return
                            new TraverseItem(listValue, _property, this, _propertyIndex, repetitionIndex++);
                    }
                }
                else
                {
                    var propertyIndex = 0;
                    foreach (var propertyInfo in Instance.GetType().GetProperties().Sort())
                    {
                        yield return new TraverseItem(propertyInfo.GetValue(Instance), propertyInfo, this, propertyIndex++, 0);
                    }
                }
            }

            if (_parent != null)
                yield return _parent;
        }
    }
}
