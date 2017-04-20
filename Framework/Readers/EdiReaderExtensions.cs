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
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Parsers;

namespace EdiFabric.Framework.Readers
{
    internal static class EdiReaderExtensions
    {
        internal static T ParseSegment<T>(this string segmentValue, Separators separators)
        {
            var type = typeof (T);
            var parseNode = new Segment(type, type.Name, type.Name);
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
                if (!String.IsNullOrEmpty(symbol))
                    counter += 1;
                result += symbol;
            }

            return result;
        }

        internal static SegmentId ToSegmentTag(this string segment, Separators separators)
        {
            if (String.IsNullOrEmpty(segment) || String.IsNullOrWhiteSpace(segment) || segment.Length < 3)
                return SegmentId.Regular;

            if (segment.StartsWith(SegmentId.UNA.ToString(), StringComparison.Ordinal)) return SegmentId.UNA;

            var segmentTag = segment.Split(new[] {separators.DataElement}, StringSplitOptions.None).FirstOrDefault();

            SegmentId tag;
            return Enum.TryParse(segmentTag, out tag) ? tag : SegmentId.Regular;
        }

        internal static string Read(this StreamReader reader, int bytes)
        {
            var result = new char[bytes];
            reader.Read(result, 0, result.Length);
            return String.Concat(result);
        }

        internal static string[] GetDataElements(this string segment, Separators separators)
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

        internal static string[] GetComponentDataElements(this string dataElement, Separators separators)
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

        internal static IEnumerable<string> SplitWithEscape(this string input, char escapeCharacter, char separator)
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

        internal static object Analyze(this List<SegmentContext> segments, Separators separators,
            MessageContext messageContext)
        {
            if (segments == null) throw new ArgumentNullException("segments");
            if (separators == null) throw new ArgumentNullException("separators");
            if (messageContext == null) throw new ArgumentNullException("messageContext");

            var messageGrammar = new TransactionSet(messageContext.SystemType);
           
            var errorContext = new MessageErrorContext(messageContext.Tag, messageContext.ControlNumber);
            var segmentPosition = messageGrammar.Children.First() as Segment;
            
            foreach (var segment in segments)
            {
                if (segment.IsControl) continue;

                Logger.Log(String.Format("Segment to match: {0}", segment.LogName));
                // Jump back to HL segment if needed
                if (segment.IsJump)
                {
                    try
                    {
                        segmentPosition = messageGrammar.JumpToHl(segment.ParentId);
                    }
                    catch (Exception ex)
                    {
                        errorContext.Add(segment.Name, segments.IndexOf(segment) + 1, ErrorCodes.UnexpectedSegment);
                        throw new ParsingException(ErrorCodes.InvalidInterchangeContent,
                            "Unable to resolve HL.", ex, segment.Value, errorContext);
                    }
                }

                var currSeg = segmentPosition.TraverseDepthFirst().FirstOrDefault(n => n.IsEqual(segment));
                if (currSeg == null)
                {
                    if (messageGrammar.Descendants().All(d => d.EdiName != segment.Name))
                    {
                        errorContext.Add(segment.Name, segments.IndexOf(segment) + 1, ErrorCodes.UnrecognizedSegment);
                        throw new ParsingException(ErrorCodes.InvalidInterchangeContent,
                            "Segment is not supported in rules class.", segment.Value, errorContext);
                    }

                    errorContext.Add(segment.Name, segments.IndexOf(segment) + 1, ErrorCodes.UnexpectedSegment);
                    throw new ParsingException(ErrorCodes.InvalidInterchangeContent,
                        "Segment was not in the correct position according to the rules class.", segment.Value,
                        errorContext);
                }

                if (!string.IsNullOrEmpty(currSeg.Value))
                {
                    if (currSeg.IsTrigger)
                    {
                        var group = new Loop(currSeg.Parent.Type, currSeg.Parent.Name, currSeg.Parent.EdiName);
                        currSeg.Parent.Parent.InsertChild(currSeg.Parent.IndexInParent() + 1, group);
                        currSeg = (Segment)group.Children.First();
                    }
                    else
                    {
                        var newNode = new Segment(currSeg.Type, currSeg.Name, currSeg.EdiName);
                        currSeg.Parent.InsertChild(currSeg.IndexInParent() + 1, newNode);
                        currSeg = newNode;
                    }                    
                }
                
                currSeg.ParseSegment(segment.Value, separators, errorContext);
                segmentPosition = currSeg;
                Logger.Log(String.Format("Matched segment: {0}", segmentPosition.Name));
            }

            return messageGrammar.ToInstance();
        }

        internal static void ParseSegment(this Segment parseNode, string line, Separators separators, MessageErrorContext errorContext = null)
        {
            if (parseNode == null) throw new ArgumentNullException("parseNode");
            if (String.IsNullOrEmpty(line)) throw new ArgumentNullException("line");
            if (separators == null) throw new ArgumentNullException("separators");
            parseNode.Value = line;

            var dataElementsGrammar = new Segment(parseNode.Type).Children;
            var dataElementsToParse = line.GetDataElements(separators);
            for (var deIndex = 0; deIndex < dataElementsToParse.Length; deIndex++)
            {
                if (dataElementsGrammar.Count <= deIndex)
                {
                    if (errorContext != null)
                        errorContext.Add(parseNode.EdiName, parseNode.IndexInParent() + 1, ErrorCodes.DataElementsTooMany);
                    throw new ParsingException(ErrorCodes.InvalidInterchangeContent, "Too many data elements in segment.", line, errorContext);
                }

                var currentToParse = dataElementsToParse[deIndex];
                if (String.IsNullOrEmpty(currentToParse)) continue;

                var currentDataElementGrammar = dataElementsGrammar.ElementAt(deIndex);

                var repetitions = currentDataElementGrammar.IsX12RepetitionSeparator()
                    ? new[] { currentToParse }
                    : currentToParse.GetRepetitions(separators);

                foreach (var repetition in repetitions)
                {
                    if (String.IsNullOrEmpty(repetition)) continue;

                    ParseNode childParseNode;
                    if (currentDataElementGrammar is DataElement)
                    {
                        childParseNode = new DataElement(currentDataElementGrammar.Type, currentDataElementGrammar.Name, currentDataElementGrammar.EdiName, repetition.UnEscapeLine(separators));
                        parseNode.AddChild(childParseNode);
                        continue;
                    }

                    childParseNode = new ComplexDataElement(currentDataElementGrammar.Type, currentDataElementGrammar.Name, currentDataElementGrammar.EdiName);
                    parseNode.AddChild(childParseNode);

                    var componentDataElementsGrammar = currentDataElementGrammar.Children;
                    var componentDataElements = repetition.GetComponentDataElements(separators);
                    for (var cdeIndex = 0; cdeIndex < componentDataElements.Length; cdeIndex++)
                    {
                        var currentComponentDataElement = componentDataElements[cdeIndex];
                        if (String.IsNullOrEmpty(currentComponentDataElement)) continue;

                        var currentComponentDataElementGrammar = componentDataElementsGrammar.ElementAt(cdeIndex);
                        if (componentDataElementsGrammar.Count <= cdeIndex)
                        {
                            if (errorContext != null)
                                errorContext.Add(parseNode.EdiName, parseNode.IndexInParent() + 1,
                                    currentComponentDataElementGrammar.Name,
                                    currentDataElementGrammar.IndexInParent() + 1,
                                    ErrorCodes.ComponentDataElementsTooMany,
                                    currentComponentDataElementGrammar.IndexInParent() + 1,
                                    repetitions.ToList().IndexOf(repetition) + 1, currentComponentDataElement);

                            throw new ParsingException(ErrorCodes.InvalidInterchangeContent,
                                "Too many component data elements.", line, errorContext);
                        }

                        var dataElementNode = new DataElement(currentComponentDataElementGrammar.Type,
                            currentComponentDataElementGrammar.Name, currentComponentDataElementGrammar.EdiName,
                            currentComponentDataElement.UnEscapeLine(separators));
                        childParseNode.AddChild(dataElementNode);
                    }
                }
            }
        }

        private static string UnEscapeLine(this string line, Separators separators)
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

        private static string[] GetRepetitions(this string value, Separators separators)
        {
            if (separators == null) throw new ArgumentNullException("separators");
            if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("value");

            if (!separators.RepetitionDataElement.HasValue)
                return new[] { value };

            if (!separators.Escape.HasValue)
            {
                return value.Split(separators.RepetitionDataElement.Value);
            }

            return value.SplitWithEscape(separators.Escape.Value,
                separators.RepetitionDataElement.Value).ToArray();
        }

        private static bool IsX12RepetitionSeparator(this ParseNode parseNode)
        {
            return parseNode.Parent != null && parseNode.Parent.Name == "S_ISA" &&
                   parseNode.Name == "D_726_11";
        }        
    }
}
