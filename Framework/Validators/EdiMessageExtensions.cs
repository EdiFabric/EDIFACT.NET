using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Annotations.Edi;
using EdiFabric.Annotations.Model;
using EdiFabric.Annotations.Validation;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Parsers;
using ValidationException = EdiFabric.Framework.Exceptions.ValidationException;

namespace EdiFabric.Framework.Validators
{
    public static class EdiMessageExtensions
    {
        public static ValidationException Validate(this EdiMessage message)
        {
            var messageContext = new MessageContext(message);
            var messageErrorContext = new MessageErrorContext(messageContext.Tag, messageContext.ControlNumber);

            var segmentIndex = 0;

            var items = new Stack<ValidationContext>();
            items.Push(new ValidationContext(message, null));

            while (items.Any())
            {
                var item = items.Pop();

                if (item.Instance is string)
                    continue;

                var properyIndex = 0;
                foreach (var propertyInfo in item.Instance.GetType().GetProperties().Sort())
                {
                    var value = propertyInfo.GetValue(item.Instance);
                    var list = value as IList;
                    if (value == null)
                    {
                        if (propertyInfo.IsRequired())
                            propertyInfo.SetRequiredMissing(messageErrorContext, segmentIndex, item.ErrorContext);
                        
                        continue;
                    }

                    properyIndex++;                    


                    SegmentErrorContext segmentErrorContext = null;
                    if (list != null)
                    {
                        var repetitionIdex = 0;
                        foreach (var listValue in list)
                        {
                            repetitionIdex++;

                            if (listValue is string)
                                continue;

                            if (propertyInfo.IsType<SegmentAttribute>())
                                segmentErrorContext = new SegmentErrorContext(propertyInfo.ToSegmentName(), segmentIndex++);                            

                            items.Push(new ValidationContext(listValue, segmentErrorContext ?? item.ErrorContext));
                        }
                    }
                    else
                    {
                        if (propertyInfo.IsType<SegmentAttribute>())
                            segmentErrorContext = new SegmentErrorContext(propertyInfo.ToSegmentName(), segmentIndex++);

                        items.Push(new ValidationContext(value, segmentErrorContext ?? item.ErrorContext));
                    }
                }
            }

            return new ValidationException(messageContext.Tag, messageErrorContext);
        }

        private static void SetRequiredMissing(this PropertyInfo propertyInfo, MessageErrorContext messageErrorContext, int index, SegmentErrorContext errorContext)
        {
            if (propertyInfo.IsType<AllAttribute>())
            {
                var mandatoryNames =
                    propertyInfo.GetGenericType()
                        .GetProperties()
                        .Where(p => p.GetCustomAttribute<RequiredAttribute>() != null)
                        .Select(s => s.GetGenericType().GetCustomAttribute<EdiAttribute>().Id);

                foreach (var name in mandatoryNames)
                {
                    messageErrorContext.Add(name, index + 1, ValidationResult.RequiredMissing);
                }
            }

            if (propertyInfo.IsType<GroupAttribute>() || propertyInfo.IsType<SegmentAttribute>())
            {
                var name = propertyInfo.GetGenericType().GetCustomAttribute<EdiAttribute>().Id;
                messageErrorContext.Add(name, index + 1, ValidationResult.RequiredMissing);
            }

            if (propertyInfo.IsType<CompositeAttribute>())
            {
                var name = propertyInfo.GetGenericType().GetCustomAttribute<EdiAttribute>().Id;
                if (errorContext == null)
                    throw new Exception(string.Format("SegmentErrorContext not set for {0}", propertyInfo.Name));

                messageErrorContext.Add(errorContext.Name, errorContext.Position, name, index, ValidationResult.RequiredMissing, 0, 0, null);
            }

            if (propertyInfo.GetGenericType() == typeof(string))
            {
                var dataElementAttr = propertyInfo.GetGenericType().GetCustomAttribute<DataElementAttribute>();
                if (dataElementAttr == null)
                    return;

                if (errorContext == null)
                    throw new Exception(string.Format("SegmentErrorContext not set for {0}", propertyInfo.Name));

                messageErrorContext.Add(errorContext.Name, errorContext.Position, dataElementAttr.Code, index, ValidationResult.RequiredMissing, 0, 0, null);
            }
        }

        private static void SetUnexpected(this PropertyInfo propertyInfo, MessageErrorContext messageErrorContext, int index)
        {
            if (propertyInfo.IsType<AllAttribute>())
            {
                throw new Exception(string.Format("All {0} can't have repetitions.", propertyInfo.Name));
            }

            if (propertyInfo.IsType<GroupAttribute>() || propertyInfo.IsType<SegmentAttribute>())
            {
                var mandatory = propertyInfo.GetGenericType().GetCustomAttribute<EdiAttribute>().Id;
                messageErrorContext.Add(mandatory, index + 1, ValidationResult.Unexpected);
            }
        }

        private static ValidationResult Validate(this PropertyInfo propertyInfo, object instance)
        {
           var attributes = propertyInfo.GetCustomAttributes<ValidationAttribute>().OrderBy(p => p.Priority);

            if (instance == null)
            {
                var required = attributes.OfType<RequiredAttribute>().SingleOrDefault();
                if (required != null)
                    return required.IsValid(null);
            }
            else
            {
                foreach (var attr in attributes)
                {
                    var errorCode = attr.IsValid(instance);
                    if (errorCode != ValidationResult.Valid)
                    {
                        return errorCode;
                    }
                }
            }

            return ValidationResult.Valid;
        }

        private static bool IsRequired(this PropertyInfo propertyInfo)
        {
            return propertyInfo.GetCustomAttributes<RequiredAttribute>().Any();
        }

        private static string ToSegmentName(this PropertyInfo propertyInfo)
        {
            if (!propertyInfo.IsType<SegmentAttribute>())
                throw new Exception(string.Format("{0} is not a segment.", propertyInfo.Name));

            return propertyInfo.GetGenericType().GetCustomAttribute<EdiAttribute>().Id;
        }
    }
}
