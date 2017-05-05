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
        public static MessageErrorContext Validate(this EdiMessage instance)
        {
            var visited = new HashSet<object>();
            var stack = new Stack<TraverseItem>();
            var messageContext = new MessageContext(instance);
            var result = new MessageErrorContext(messageContext.Tag, messageContext.ControlNumber);

            stack.Push(new TraverseItem(instance));

            string lastSegmentName = null;
            var segmentIndex = 0;

            while (stack.Any())
            {
                var current = stack.Pop();

                if (!(current.Instance is string) && current.Instance != null && !visited.Add(current.Instance))
                    continue;

                if (current.Property != null && current.Property.IsType<SegmentAttribute>())
                {
                    segmentIndex++;
                    lastSegmentName = current.Property.GetGenericType().GetCustomAttribute<EdiAttribute>().Id;
                }

                result.AddRange(current.ValidateRequired(lastSegmentName, segmentIndex));
                
                var neighbours = current.GetNeigbours().Where(p => !visited.Contains(p.Instance));
                foreach (var neighbour in neighbours.Reverse())
                {
                    stack.Push(neighbour);
                }
                
                
            }

            return result;
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

        public static bool IsRequired(this PropertyInfo propertyInfo)
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
