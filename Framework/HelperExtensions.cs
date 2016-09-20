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
            var parseNode = ParseNode.BuldTree(typeof (T), false);
            parseNode.ParseSegment(segmentContext.Value, separators);
            return (T) parseNode.ToInstance();
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

        internal static string ReadIsa(this StreamReader reader, string dataElementSeparator)
        {
            var line = "";
            var counter = 0;

            while (reader.Peek() >= 0 && counter < 16)
            {
                var symbol = (char)reader.Read();
                line = line + symbol;

                if (dataElementSeparator[0] == symbol)
                {
                    counter = counter + 1;
                }
            }
            
            return line + reader.Read(2);
        }

        internal static Tuple<string, Separators> ReadHeader(this StreamReader reader, string segmentName)
        {
            string dataElement;
            string componentDataElement;
            string repetitionDataElement;
            string segment;
            string escape;
            string header = null;
            Separators separators = null;

            switch (segmentName.ToSegmentTag(null))
            {
                case SegmentTags.ISA:
                    try
                    {
                        dataElement = reader.Read(1);
                        var isa = reader.ReadIsa(dataElement);
                        var isaElements = isa.Split(dataElement.ToCharArray());
                        componentDataElement = string.Concat(isaElements[16].First());
                        repetitionDataElement = isaElements[11] != "U"
                            ? isaElements[11]
                            : Separators.DefaultSeparatorsX12().RepetitionDataElement;
                        var last = isaElements[16].ToCharArray();
                        segment = last.Length > 1 && !char.IsWhiteSpace(last[1])
                            ? string.Concat(last[1])
                            : Environment.NewLine;

                        separators = Separators.SeparatorsX12(segment, componentDataElement, dataElement,
                            repetitionDataElement);
                        header = segmentName + dataElement + isa;
                    }
                    catch (Exception ex)
                    {
                        throw new ParserException("Unable to extract X12 interchange delimiters", ex);
                    }
                    break;
                case SegmentTags.UNB:
                    var defaultSeparators = Separators.DefaultSeparatorsEdifact();
                    componentDataElement = defaultSeparators.ComponentDataElement;
                    dataElement = defaultSeparators.DataElement;
                    escape = defaultSeparators.Escape;
                    repetitionDataElement = defaultSeparators.RepetitionDataElement;
                    segment = defaultSeparators.Segment;

                    separators = Separators.SeparatorsEdifact(segment, componentDataElement, dataElement,
                            repetitionDataElement, escape);
                    header = segmentName + reader.ReadSegment(separators);
                    break;
                case SegmentTags.UNA:
                    try
                    {
                        var una = reader.Read(6);
                        var unaChars = una.ToArray();
                        componentDataElement = string.Concat(unaChars[0]);
                        dataElement = string.Concat(unaChars[1]);
                        escape = string.Concat(unaChars[3]);
                        repetitionDataElement = Separators.DefaultSeparatorsEdifact().RepetitionDataElement;
                        segment = string.Concat(unaChars[5]);

                        separators = Separators.SeparatorsEdifact(segment, componentDataElement, dataElement,
                            repetitionDataElement, escape);
                        header = segmentName + una;
                    }
                    catch (Exception ex)
                    {
                        throw new ParserException("Unable to extract UNA interchange delimiters", ex);
                    }
                    break;
            }

            return new Tuple<string, Separators>(header, separators);
        }

        internal static string EscapeLine(this string line, Separators separators)
        {
            if (string.IsNullOrEmpty(line))
                return string.Empty;

            return line.ToCharArray()
                .Aggregate("", (current, l) => l.IsSeparator(separators) ? current + separators.Escape + l : current + l);
        }

        internal static string UnEscapeLine(this string line, Separators separators)
        {
            if (string.IsNullOrEmpty(line))
                return string.Empty;

            var result = string.Empty;
            var temp = line.Split(new[] {separators.Escape + separators.Escape}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var str in temp)
            {
                result = result + str.Replace(separators.Escape, string.Empty) + separators.Escape;
            }

            if (!line.EndsWith(separators.Escape + separators.Escape))
                result = result.TrimEnd(separators.Escape.ToCharArray());

            return result;
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

            return message.Split(separators.Escape.ToCharArray()[0],
                separators.Segment).ToArray();
        }

        internal static string[] GetDataElements(this string segment, Separators separators)
        {
            if (string.IsNullOrEmpty(segment)) throw new ArgumentNullException("segment");
            if (separators == null) throw new ArgumentNullException("separators");

            return segment.Split(separators.Escape.ToCharArray()[0],
                separators.DataElement).Skip(1).ToArray();
        }

        internal static string[] GetComponentDataElements(this string dataElement, Separators separators)
        {
            if (separators == null) throw new ArgumentNullException("separators");
            if (string.IsNullOrEmpty(dataElement)) throw new ArgumentNullException("dataElement");

            return dataElement.Split(separators.Escape.ToCharArray()[0],
                separators.ComponentDataElement).ToArray();
        }

        internal static string[] GetRepetitions(this string value, Separators separators)
        {
            if (separators == null) throw new ArgumentNullException("separators");
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("value");

            return value.Split(separators.Escape.ToCharArray()[0],
                separators.RepetitionDataElement).ToArray();
        }

        internal static Stream ToSeekStream(this Stream stream)
        {
            if (stream.CanSeek) return stream;

            var ms = new MemoryStream();
            stream.CopyTo(ms);
            ms.Position = 0;
            return ms;
        }

        internal static string Read(this StreamReader reader, int bytes, char[] trims)
        {
            string result = null;
            var counter = 0;
            while (counter < bytes)
            {
                var symbol = reader.Read(1).Trim(trims);
                if (!string.IsNullOrEmpty(symbol))
                    counter += 1;
                result += symbol;
            }

            return result;
        }

        internal static string Read(this StreamReader reader, int bytes)
        {
            var result = new char[bytes];
            reader.Read(result, 0, result.Length);
            return string.Concat(result);
        }

        public static IEnumerable<string> Split(this string input, char escapeCharacter, string separator)
        {
            var startOfSegment = 0;
            var index = 0;
            while (index < input.Length)
            {
                index = input.IndexOf(separator, index, StringComparison.Ordinal);
                if (index > 0 && input[index - 1] == escapeCharacter)
                {
                    if (index > 1)
                    {
                        if (input[index - 2] != escapeCharacter)
                        {
                            index += separator.Length;
                            continue;
                        }
                    }
                    else
                    {
                        index += separator.Length;
                        continue;
                    }                    
                }
                if (index == -1)
                {
                    break;
                }
                yield return input.Substring(startOfSegment, index - startOfSegment);
                index += separator.Length;
                startOfSegment = index;
            }
            yield return input.Substring(startOfSegment);
        }

        public static string TrimEnd(this string input, string escapeCharacter, string separator)
        {
            var result = input.TrimEnd(separator.ToCharArray());
            if (result.EndsWith(escapeCharacter))
                result = result + separator;

            return result;
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
