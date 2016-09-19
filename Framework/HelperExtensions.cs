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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Framework.Constants;

namespace EdiFabric.Framework
{
    internal static class HelperExtensions
    {
        internal static T ParseSegment<T>(this SegmentContext segmentContext, Separators separators)
        {
            var parseNode = ParseNode.BuldTree(typeof(T), false);
            parseNode.ParseSegment(segmentContext.Value, separators);
            return (T)parseNode.ToInstance();
        }

        internal static string ReadSegment(this TextReader reader, Separators separators)
        {
            var line = "";

            while (reader.Peek() >= 0)
            {
                var symbol = (char) reader.Read();
                line = line + symbol;

                if (line.EndsWith(separators.Segment))
                {
                    if (separators.Escape.Length != 0 &&
                        line.EndsWith(string.Concat(separators.Escape, separators.Segment)))
                    {
                        continue;
                    }

                    if (separators.Segment != Environment.NewLine)
                        line = line.Trim('\r', '\n');

                    int index = line.LastIndexOf(separators.Segment, StringComparison.Ordinal);
                    if (index > 0)
                    {
                        line = line.Remove(index);
                    }

                    if (!string.IsNullOrEmpty(line))
                        break;
                }
            }

            return line.Trim('\r', '\n');
        }

        internal static string EscapeLine(this string line, Separators separators)
        {
            if (string.IsNullOrEmpty(line))
                return string.Empty;

            return line.ToCharArray()
                .Aggregate("", (current, l) => l.IsSeparator(separators) ? current + separators.Escape + l : current + l);
        }

        internal static SegmentTags ToSegmentTag(this string segment, Separators separators)
        {
            if (segment.StartsWith(SegmentTags.UNA.ToString())) return SegmentTags.UNA;

            var segmentTag = separators != null
                ? segment.Split(separators.DataElement.ToCharArray(), StringSplitOptions.None).FirstOrDefault()
                : segment.ToUpper().TrimStart().Substring(0, 3);

            SegmentTags tag;
            return Enum.TryParse(segmentTag, out tag) ? tag : SegmentTags.Regular;
        }

        internal static string[] GetSegments(this string message, Separators separators)
        {
            if (message == null) throw new ArgumentNullException("message");
            if (separators == null) throw new ArgumentNullException("separators");

            if (separators.Segment != Environment.NewLine)
                message = message.Trim('\r', '\n');

            return message.SplitWithEscape(separators.Escape,
                separators.Segment,
                StringSplitOptions.RemoveEmptyEntries);
        }

        internal static string[] GetDataElements(this string segment, Separators separators)
        {
            if (string.IsNullOrEmpty(segment)) throw new ArgumentNullException("segment");
            if (separators == null) throw new ArgumentNullException("separators");

            return segment.SplitWithEscape(separators.Escape,
                separators.DataElement, StringSplitOptions.None).Skip(1).ToArray();
        }

        internal static string[] GetComponentDataElements(this string dataElement, Separators separators)
        {
            if (separators == null) throw new ArgumentNullException("separators");
            if (string.IsNullOrEmpty(dataElement)) throw new ArgumentNullException("dataElement");

            return dataElement.SplitWithEscape(separators.Escape,
                separators.ComponentDataElement, StringSplitOptions.None, true);
        }

        internal static string[] GetRepetitions(this string value, Separators separators)
        {
            if (separators == null) throw new ArgumentNullException("separators");
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("value");

            return value.SplitWithEscape(separators.Escape,
                separators.RepetitionDataElement, StringSplitOptions.None);
        }

        internal static Stream ToSeekStream(this Stream stream)
        {
            if (stream.CanSeek) return stream;

            var ms = new MemoryStream();
            stream.CopyTo(ms);
            ms.Position = 0;
            return ms;
        }

        private static string[] SplitWithEscape(this string contents, string escapeCharacter, string splitSeparator,
            StringSplitOptions splitOption, bool escapeTheEscape = false)
        {
            if (string.IsNullOrEmpty(escapeCharacter))
                return contents.Split(splitSeparator.ToCharArray(), splitOption);

            var result = new List<string>();
            var line = "";
            var previousSymbol = char.MinValue;

            // Iterate through all chars in the string
            // This builds a line until the split separator is reached
            // Only if the split separator is not escaped, e.g. not preceded by the escape character
            foreach (char symbol in contents)
            {
                // If the current char is the split separator
                if (symbol == splitSeparator[0])
                {
                    // Check if the separator is escaped
                    if (previousSymbol != escapeCharacter[0])
                    {
                        // If it not escaped, add the currently built line
                        // and start the next line
                        // check for escaping the escape character
                        if (line.EndsWith(escapeCharacter + escapeCharacter))
                            line = line.Remove(line.Length - 1);

                        result.Add(line);
                        line = "";
                        previousSymbol = char.MinValue;

                        continue;
                    }

                    // Keep building the line until a separator is reached
                    line = line.TrimEnd(escapeCharacter.ToCharArray());
                }

                // check for escaping the escape character
                if (escapeTheEscape && line.EndsWith(escapeCharacter + escapeCharacter))
                    line = line.Remove(line.Length - 1);

                line = line + symbol;

                // Keep track of the previous character in case it's an escape character
                if (previousSymbol == symbol && previousSymbol == escapeCharacter[0])
                    previousSymbol = char.MinValue;
                else
                    previousSymbol = symbol;
            }

            result.Add(line.Trim());

            // Handle blank lines
            if (splitOption == StringSplitOptions.RemoveEmptyEntries)
            {
                result.RemoveAll(string.IsNullOrEmpty);
            }

            return result.ToArray();
        }

        private static bool IsSeparator(this char value, Separators separators)
        {
            return separators.ComponentDataElement.Contains(value) ||
                   separators.DataElement.Contains(value) ||
                   separators.Escape.Contains(value) ||
                   separators.RepetitionDataElement.Contains(value) ||
                   separators.Segment.Contains(value);
        }
    }
}
