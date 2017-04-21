using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Attributes;
using EdiFabric.Framework.Readers;

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
                string value = String.Empty;
                if (element is ComplexDataElement)
                {
                    if (element.Children.Any())
                    {
                        var dataElements = element.Children.OfType<DataElement>().ToList();
                        value = dataElements.ElementAt(0).Value != null
                            ? EscapeLine(dataElements.ElementAt(0).Value, separators)
                            : String.Empty;
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
                    if (de == null) throw new Exception(String.Format("Unexpected node {0} under parent {1}", element.Type.FullName, element.Parent.Type.FullName));
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
            if (String.IsNullOrEmpty(line))
                return String.Empty;

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
                    return (List<string>)codes.GetValue(Activator.CreateInstance(deAttr.DataType));
                }
            }

            return new List<string>();
        }

        public static T ParseSegment<T>(this string segmentValue, Separators separators)
        {
            var parseNode = new Segment(typeof(T));
            parseNode.Parse(segmentValue, separators);
            return (T)parseNode.ToInstance();
        }

        public static string UnEscapeLine(this string line, Separators separators)
        {
            if (String.IsNullOrEmpty(line))
                return String.Empty;

            var result = String.Empty;
            var temp = separators.Escape.HasValue
                ? line.SplitWithEscape(separators.Escape.Value, separators.Escape.Value)
                : new List<string> { line };
            foreach (var str in temp)
            {
                result = result + str;
            }

            if (separators.Escape.HasValue && !line.EndsWith(String.Concat(separators.Escape.Value, separators.Escape.Value), StringComparison.Ordinal))
                result = result.TrimEnd(separators.Escape.Value);

            return result;
        }

        public static List<string> GetRepetitions(this string value, Separators separators)
        {
            if (separators == null) throw new ArgumentNullException("separators");
            if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("value");

            if (!separators.RepetitionDataElement.HasValue)
                return new List<string> { value };

            if (!separators.Escape.HasValue)
            {
                return value.Split(separators.RepetitionDataElement.Value).ToList();
            }

            return value.SplitWithEscape(separators.Escape.Value,
                separators.RepetitionDataElement.Value).ToList();
        }

        public static bool IsX12RepetitionSeparator(this ParseNode parseNode)
        {
            return parseNode.Parent != null && parseNode.Parent.Name == "ISA" &&
                   parseNode.Name == "InterchangeControlStandardsIdentifier_11";
        }

        public static SegmentId ToSegmentTag(this string segment, Separators separators)
        {
            if (String.IsNullOrEmpty(segment) || String.IsNullOrWhiteSpace(segment) || segment.Length < 3)
                return SegmentId.Regular;

            if (segment.StartsWith(SegmentId.UNA.ToString(), StringComparison.Ordinal)) return SegmentId.UNA;

            var segmentTag = segment.Split(new[] { separators.DataElement }, StringSplitOptions.None).FirstOrDefault();

            SegmentId tag;
            return Enum.TryParse(segmentTag, out tag) ? tag : SegmentId.Regular;
        }

        public static bool Match(this Segment parseNode, SegmentContext segmentContext)
        {
            // The names must match
            if (parseNode.EdiName == segmentContext.Name)
            {
                // If no identity match is required, mark this as a match
                if (String.IsNullOrEmpty(segmentContext.FirstValue) || !parseNode.FirstChildValues.Any())
                    return true;

                // Match the value 
                // This must have been defined in the enum of the first element of the segment.
                if (parseNode.FirstChildValues.Any() && !String.IsNullOrEmpty(segmentContext.FirstValue) &&
                    parseNode.FirstChildValues.Contains(segmentContext.FirstValue))
                {
                    if (parseNode.SecondChildValues.Any() && !String.IsNullOrEmpty(segmentContext.SecondValue))
                    {
                        return parseNode.SecondChildValues.Contains(segmentContext.SecondValue);
                    }

                    return true;
                }
            }

            return false;
        }

        public static Tuple<string, string> PullTrailerValues(this IEnumerable<Segment> segments)
        {
            var msgHeader =
                segments.SingleOrDefault(
                    s =>
                        s.Name == "UNH" || s.Name.StartsWith("UNH_", StringComparison.Ordinal) ||
                        s.Name == "ST" || s.Name.StartsWith("ST_", StringComparison.Ordinal));

            DataElement controlNumber = null;
            var trailerTag = "";
            if (msgHeader != null && msgHeader.Name == "UNH")
            {
                controlNumber = msgHeader.Children.ElementAt(0) as DataElement;
                trailerTag = "UNT";
            }

            if (msgHeader != null && msgHeader.Name == "ST")
            {
                controlNumber = msgHeader.Children.ElementAt(1) as DataElement;
                trailerTag = "SE";
            }

            if (msgHeader == null || controlNumber == null)
                throw new Exception("Invalid control structure. UNH or ST was not found.");

            if (String.IsNullOrEmpty(controlNumber.Value))
                throw new Exception("Invalid control number.");

            if (String.IsNullOrEmpty(trailerTag))
                throw new Exception("Invalid trailer tag.");

            return new Tuple<string, string>(controlNumber.Value, trailerTag);
        }
    }
}
