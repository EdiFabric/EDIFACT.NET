using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Attributes;

namespace EdiFabric.Framework.Parsers
{
    static class SegmentExtensions
    {
        public static string GenerateSegment(this Segment segment, Separators separators)
        {
            if (separators == null) throw new ArgumentNullException("separators");

            var result = segment.EdiName;

            foreach (var element in segment.Children)
            {
                string value = string.Empty;
                if (element is ComplexDataElement)
                {
                    if (element.Children.Any())
                    {
                        var dataElements = element.Children.OfType<DataElement>().ToList();
                        value = dataElements.ElementAt(0).Value != null
                            ? EscapeLine(dataElements.ElementAt(0).Value, separators)
                            : string.Empty;
                        value = dataElements.Skip(1)
                            .Aggregate(value,
                                (current, subElement) =>
                                    current + separators.ComponentDataElement + EscapeLine(subElement.Value, separators));
                        value = TrimEndWithEscape(value, separators.Escape, separators.ComponentDataElement);
                    }
                }
                else
                {
                    var de = element as DataElement;
                    if (de == null) throw new Exception(string.Format("Unexpected node {0} under parent {1}", element.Type.FullName, element.Parent.Type.FullName));
                    value = EscapeLine(de.Value, separators);
                }

                var separator = element.IsRepetition()
                    ? separators.RepetitionDataElement
                    : separators.DataElement;

                result = result + separator + value;
            }

            return TrimEndWithEscape(result, separators.Escape, separators.DataElement) + separators.Segment;
        }

        private static string EscapeLine(string line, Separators separators)
        {
            if (string.IsNullOrEmpty(line))
                return string.Empty;

            if (!separators.Escape.HasValue)
                return line;

            return line.ToCharArray()
                .Aggregate("", (current, l) => IsSeparator(l, separators) ? current + separators.Escape + l : current + l);
        }

        private static string TrimEndWithEscape(string input, char? escapeCharacter, char separator)
        {
            var result = input.TrimEnd(separator);
            if (escapeCharacter.HasValue && result.EndsWith(escapeCharacter.ToString(), StringComparison.Ordinal))
                result = result + separator;

            return result;
        }

        private static bool IsSeparator(char value, Separators separators)
        {
            return separators.ComponentDataElement == value ||
                   separators.DataElement == value ||
                   separators.Escape == value ||
                   separators.RepetitionDataElement == value ||
                   separators.Segment == value;
        }

        private static bool IsRepetition(this ParseNode parseNode)
        {
            var index = parseNode.IndexInParent();
            if (index <= 0) return false;
            var previous = parseNode.Parent.Children.ElementAt(index - 1);
            return parseNode.Name == previous.Name;
        }

        public static Tuple<List<string>, List<string>> GetFirstTwoPropertyValues(this IEnumerable<PropertyInfo> propertyInfos)
        {
            var firstTwo = propertyInfos.Take(2).ToList();
            var element1 = firstTwo.Count > 0 ? firstTwo[0].GetDataElement().GetCodes() : new List<string>();
            var element2 = firstTwo.Count > 1 ? firstTwo[1].GetDataElement().GetCodes() : new List<string>();

            return new Tuple<List<string>, List<string>>(element1, element2);
        }

        private static PropertyInfo GetDataElement(this PropertyInfo item)
        {
            var cAttr = item.GetCustomAttribute<CAttribute>();
            if (cAttr != null)
            {
                return item.PropertyType.IsGenericType
                         ? item.PropertyType.GenericTypeArguments.First().GetProperties().Sort().First()
                         : item.PropertyType.GetProperties().Sort().First();
            }

            return item;
        }

        private static List<string> GetCodes(this PropertyInfo item)
        {
            var deAttr = item.GetCustomAttribute<DAttribute>();
            if (deAttr == null)
                throw new Exception("No DAttribute");

            if (deAttr.DataType != null)
            {
                var codes = deAttr.DataType.GetField("Codes");
                if (codes != null)
                {
                    return (List<String>)codes.GetValue(Activator.CreateInstance(deAttr.DataType));
                }
            }

            return new List<string>();
        }     
    }
}
