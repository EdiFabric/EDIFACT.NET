using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
            var errorContext = new MessageErrorContext(messageContext.Tag, messageContext.ControlNumber);

            Validate2(message, messageContext);


            throw new Exception();
        }

        public static void Validate2(object instance, MessageContext messageContext)
        {
            var segmentIndex = 0;
            var nodes = new Stack<object>();
            nodes.Push(instance);
            while (nodes.Any())
            {
                var node = nodes.Pop();

                if (node is string)
                    continue;

                foreach (var propertyInfo in node.GetType().GetProperties().Sort())
                {
                    var value = propertyInfo.GetValue(node);
                    var results = propertyInfo.Validate(value);

                    foreach (var result in results)
                    {
                        //var segmentName = 
                    }

                    if (value == null)
                        continue;

                    var list = value as IList;
                    if (list != null)
                    {
                        foreach (var listValue in list)
                        {
                            if (listValue is string)
                                continue;

                            nodes.Push(listValue);
                        }
                    }
                    else
                    {
                        nodes.Push(value);
                    }
                }
            }
        }

        public static IEnumerable<ValidationResult> Validate(this PropertyInfo propertyInfo, object instance)
        {
           var attributes = propertyInfo.GetCustomAttributes<ValidationAttribute>();

            foreach (var attr in attributes)
            {
                var errorCode = attr.IsValid(instance);
                if (errorCode != ValidationResult.Valid)
                {
                    yield return errorCode;
                }
            }
        }

        
    }
}
