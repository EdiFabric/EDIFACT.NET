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

namespace EdiFabric.Framework.Readers
{
    internal static class EdiReaderExtensions
    {
        internal static T ParseSegment<T>(this string segmentValue, Separators separators)
        {
            var parseNode = ParseNode.BuldTree(typeof(T), false);
            parseNode.ParseSegment(segmentValue, separators);
            return (T)parseNode.ToInstance();
        }

        internal static string Read(this StreamReader reader, int bytes, char[] trims)
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

        internal static SegmentTags ToSegmentTag(this string segment, Separators separators)
        {
            if (string.IsNullOrEmpty(segment) || string.IsNullOrWhiteSpace(segment) || segment.Length < 3)
                return SegmentTags.Regular;

            if (segment.StartsWith(SegmentTags.UNA.ToString(), StringComparison.Ordinal)) return SegmentTags.UNA;

            var segmentTag = segment.Split(new[] {separators.DataElement}, StringSplitOptions.None).FirstOrDefault();

            SegmentTags tag;
            return Enum.TryParse(segmentTag, out tag) ? tag : SegmentTags.Regular;
        }

        internal static string Read(this StreamReader reader, int bytes)
        {
            var result = new char[bytes];
            reader.Read(result, 0, result.Length);
            return string.Concat(result);
        }

        internal static string ReadIsa(this StreamReader reader, char dataElementSeparator)
        {
            var line = "";
            var counter = 0;

            while (reader.Peek() >= 0 && counter < 15 && line.Length < 100)
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
