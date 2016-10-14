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
using System.IO;
using System.Linq;
using EdiFabric.Framework.Constants;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Readers
{
    internal static class EdiReaderExtensions
    {
        internal static string ReadSegment(this StreamReader reader, Separators separators)
        {
            try
            {
                var line = "";

                while (reader.Peek() >= 0)
                {
                    var symbol = (char)reader.Read();
                    line = line + symbol;

                    if (line.EndsWith(separators.Segment.ToString()))
                    {
                        if (separators.Escape.HasValue &&
                            line.EndsWith(string.Concat(separators.Escape.Value, separators.Segment)))
                        {
                            continue;
                        }

                        int index = line.LastIndexOf(separators.Segment.ToString(), StringComparison.Ordinal);
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
            catch (Exception ex)
            {
                throw new ParsingException(ErrorCodes.InvalidInterchangeContent, ex);
            }
            
        }

        internal static T ParseSegment<T>(this SegmentContext segmentContext, Separators separators)
        {
            return segmentContext.Value.ParseSegment<T>(separators);
        }

        internal static T ParseSegment<T>(this string segmentValue, Separators separators)
        {
            var parseNode = ParseNode.BuldTree(typeof(T), false);
            parseNode.ParseSegment(segmentValue, separators);
            return (T)parseNode.ToInstance();
        }

        internal static Tuple<string, Separators> ReadControl(this StreamReader reader, string segmentName)
        {
            string header = null;
            Separators separators = null;

            try
            {
                char dataElement;
                char componentDataElement;
                char repetitionDataElement;
                char segment;
                char? escape;
                switch (segmentName.ToSegmentTag())
                {
                    case SegmentTags.ISA:
                        dataElement = reader.Read(1)[0];
                        var isa = reader.ReadIsa(dataElement);
                        var isaElements = isa.Split(dataElement);
                        if (isaElements[15].Count() != 2)
                            throw new ParsingException(ErrorCodes.SegmentTerminatorNotFound);
                        componentDataElement = isaElements[15].First();
                        repetitionDataElement = isaElements[10].First() != 'U'
                            ? isaElements[10].First()
                            : Separators.DefaultSeparatorsX12().RepetitionDataElement;
                        segment = isaElements[15].Last();
                        separators = Separators.SeparatorsX12(segment, componentDataElement, dataElement,
                            repetitionDataElement);
                        header = segmentName + dataElement + isa;
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
                        var una = reader.Read(6);
                        var unaChars = una.ToArray();
                        componentDataElement = unaChars[0];
                        dataElement = unaChars[1];
                        escape = unaChars[3];
                        repetitionDataElement = Separators.DefaultSeparatorsEdifact().RepetitionDataElement;
                        segment = unaChars[5];

                        separators = Separators.SeparatorsEdifact(segment, componentDataElement, dataElement,
                            repetitionDataElement, escape);
                        header = segmentName + una;
                        break;
                }

                return new Tuple<string, Separators>(header, separators);

            }
            catch (Exception ex)
            {
                if (ex is ParsingException)
                    throw;

                throw new ParsingException(ErrorCodes.InvalidControlStructure, ex);
            }
        }

        internal static string Read(this StreamReader reader, int bytes, char[] trims)
        {
            try
            {
                string result = null;
                var counter = 0;
                while (counter < bytes && !reader.EndOfStream)
                {
                    var symbol = reader.Read(1).Trim(trims);
                    if (!string.IsNullOrEmpty(symbol))
                        counter += 1;
                    result += symbol;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new ParsingException(ErrorCodes.InvalidInterchangeContent, ex);
            }           
        }

        internal static SegmentTags ToSegmentTag(this string segment, Separators separators = null)
        {
            if (string.IsNullOrEmpty(segment) || string.IsNullOrWhiteSpace(segment) || segment.Length < 3)
                return SegmentTags.Regular;

            if (segment.StartsWith(SegmentTags.UNA.ToString())) return SegmentTags.UNA;

            var segmentTag = separators != null
                ? segment.Split(new[] {separators.DataElement}, StringSplitOptions.None).FirstOrDefault()
                : segment.ToUpper().TrimStart().Substring(0, 3);

            SegmentTags tag;
            return Enum.TryParse(segmentTag, out tag) ? tag : SegmentTags.Regular;
        }

        private static string Read(this StreamReader reader, int bytes)
        {
            var result = new char[bytes];
            reader.Read(result, 0, result.Length);
            return string.Concat(result);
        }

        private static string ReadIsa(this StreamReader reader, char dataElementSeparator)
        {
            var line = "";
            var counter = 0;

            while (reader.Peek() >= 0 && counter < 15)
            {
                var symbol = (char) reader.Read();
                line = line + symbol;

                if (dataElementSeparator == symbol)
                {
                    counter = counter + 1;
                }
            }

            return line + reader.Read(2);
        }
    }
}
