using System;
using System.Collections.Generic;
using System.Linq;

namespace EdiFabric.Framework
{
    static class StringExtensions
    {
        public static string[] GetDataElements(this string segment, Separators separators)
        {
            if (String.IsNullOrEmpty(segment)) throw new ArgumentNullException("segment");
            if (separators == null) throw new ArgumentNullException("separators");

            if (!separators.Escape.HasValue)
            {
                return segment.Split(separators.DataElement).Skip(1).ToArray();
            }

            return segment.SplitWithEscape(separators.Escape.Value,
                separators.DataElement).Skip(1).ToArray();
        }

        public static string[] GetComponentDataElements(this string dataElement, Separators separators)
        {
            if (separators == null) throw new ArgumentNullException("separators");
            if (String.IsNullOrEmpty(dataElement)) throw new ArgumentNullException("dataElement");

            if (!separators.Escape.HasValue)
            {
                return dataElement.Split(separators.ComponentDataElement);
            }

            return dataElement.SplitWithEscape(separators.Escape.Value,
                separators.ComponentDataElement).ToArray();
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

        public static IEnumerable<string> SplitWithEscape(this string input, char escapeCharacter, char separator)
        {
            var startOfSegment = 0;
            var index = 0;
            while (index < input.Length)
            {
                index = input.IndexOf(separator.ToString(), index, StringComparison.Ordinal);
                if (index > 0 && input[index - 1] == escapeCharacter)
                {
                    if (index > 1)
                    {
                        if (input[index - 2] != escapeCharacter)
                        {
                            index += 1;
                            continue;
                        }
                    }
                    else
                    {
                        index += 1;
                        continue;
                    }
                }
                if (index == -1)
                {
                    break;
                }
                yield return input.Substring(startOfSegment, index - startOfSegment);
                index += 1;
                startOfSegment = index;
            }
            yield return input.Substring(startOfSegment);
        }

        public static string TrimEndWithEscape(this List<string> input, char? escapeCharacter, char separator,
            bool preserveWhitespace)
        {
            input.Reverse();
            var temp = preserveWhitespace
                ? input.SkipWhile(i => i == null || i == separator.ToString()).ToList()
                : input.SkipWhile(i => string.IsNullOrEmpty(i) || i == separator.ToString()).ToList();
            temp.Reverse();

            var result = temp.Aggregate<string, string>(null, (current, s) => current + s);

            if (result == null)
                return null;

            if (escapeCharacter.HasValue && result.EndsWith(escapeCharacter.ToString(), StringComparison.Ordinal))
                result = result + separator;

            return result;
        }

        public static string EscapeLine(this string line, Separators separators)
        {
            if (line == null)
                return null;

            if (!separators.Escape.HasValue)
                return line;

            return line.ToCharArray()
                .Aggregate("", (current, l) => IsSeparator(l, separators) ? current + separators.Escape + l : current + l);
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

        private static bool IsSeparator(this char value, Separators separators)
        {
            return separators.ComponentDataElement == value ||
                   separators.DataElement == value ||
                   separators.Escape == value ||
                   separators.RepetitionDataElement == value ||
                   separators.Segment == value;
        }       
    }
}
