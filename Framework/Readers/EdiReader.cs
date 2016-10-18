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
using System.Text;
using EdiFabric.Framework.Constants;
using EdiFabric.Framework.Controls;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Items;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Parses EDI messages into .NET objects.
    /// </summary>
    public class EdiReader : IDisposable
    {
        private readonly StreamReader _streamReader;
        private readonly string _rulesAssemblyName;
        private readonly string _rulesNamespacePrefix;
        private char[] _trims = { '\r', '\n', ' ' };
        private Separators _separators;
        private SegmentContext _lastGroupHeader;
        private int _interchangeMarker;
        private int _groupMarker;
        private int _messageMarker;

        /// <summary>
        /// The currently read item.
        /// </summary>
        public EdiItem Item { get; private set; }

        /// <summary>
        /// End of stream reached.
        /// </summary>
        public bool EndOfStream
        {
            get { return _streamReader.EndOfStream; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <param name="rulesAssemblyName">The full assembly name of the assembly containing the EDI classes. The default is Edifabric.Rules.</param>       
        /// <param name="rulesNamespacePrefix">The namespace prefix for the EDI classes. The default is Edifabric.Rules.</param>
        private EdiReader(Stream ediStream, Encoding encoding, string rulesAssemblyName, string rulesNamespacePrefix)
        {
            if (ediStream == null) throw new ArgumentNullException("ediStream");

            _streamReader = new StreamReader(ediStream, encoding ?? Encoding.Default, true);
            _rulesAssemblyName = rulesAssemblyName;
            _rulesNamespacePrefix = rulesNamespacePrefix;
            _interchangeMarker = 0;
            _groupMarker = 0;
            _messageMarker = 0;
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="EdiReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <param name="rulesAssemblyName">The full assembly name of the assembly containing the EDI classes. The default is Edifabric.Rules.</param>        
        /// <param name="rulesNamespacePrefix">The namespace prefix for the EDI classes. The default is Edifabric.Rules.</param>
        /// <returns>A new instance of the <see cref="EdiReader"/> class.</returns>
        public static EdiReader Create(Stream ediStream, Encoding encoding = null, string rulesAssemblyName = null, string rulesNamespacePrefix = null)
        {
            return new EdiReader(ediStream, encoding, rulesAssemblyName, rulesNamespacePrefix);
        }

        /// <summary>
        /// Reads an EDI item from the stream.
        /// Items can be: control segment, message or error.
        /// </summary>
        /// <returns>If a new message was read.</returns>
        public bool Read()
        {
            var currentMessage = new List<SegmentContext>();
            var result = false;

            try
            {
                while (_streamReader.Peek() >= 0 && !result && !IsBreakingError())
                {
                    var currentSegment = ReadSegment();
                    if (string.IsNullOrEmpty(currentSegment)) break;

                    var segmentContext = new SegmentContext(currentSegment, _separators);
                    switch (segmentContext.Tag)
                    {
                        // X12
                        case SegmentTags.ISA:
                            _interchangeMarker++;
                            Item = new EdiControl<S_ISA>(segmentContext.Value, _separators);
                            result = true;
                            break;
                        case SegmentTags.GS:
                            _groupMarker++;
                            _lastGroupHeader = segmentContext;
                            Item = new EdiControl<S_GS>(segmentContext.Value, _separators);
                            result = true;
                            break;
                        case SegmentTags.ST:
                            _messageMarker++;
                            currentMessage.Add(segmentContext);
                            break;
                        case SegmentTags.SE:
                            _messageMarker--;
                            currentMessage.Add(segmentContext);
                            currentMessage.Add(_lastGroupHeader);
                            Item = ParseX12(currentMessage);
                            result = true;
                            currentMessage.Clear();
                            break;
                        case SegmentTags.GE:
                            _groupMarker--;
                            _lastGroupHeader = null;
                            Item = new EdiControl<S_GE>(segmentContext.Value, _separators);
                            result = true;
                            break;
                        case SegmentTags.IEA:
                            _interchangeMarker--;
                            _separators = null;
                            Item = new EdiControl<S_IEA>(segmentContext.Value, _separators);
                            result = true;
                            break;
                        // EDIFACT
                        case SegmentTags.UNA:
                            if (_interchangeMarker != 0)
                                throw ControlException();
                            break;
                        case SegmentTags.UNB:
                            _interchangeMarker++;
                            Item = new EdiControl<S_UNB>(segmentContext.Value, _separators);
                            result = true;
                            break;
                        case SegmentTags.UNG:
                            _groupMarker++;
                            Item = new EdiControl<S_UNG>(segmentContext.Value, _separators);
                            result = true;
                            break;
                        case SegmentTags.UNH:
                            _messageMarker++;
                            currentMessage.Add(segmentContext);
                            break;
                        case SegmentTags.UNT:
                            _messageMarker--;
                            currentMessage.Add(segmentContext);
                            Item = ParseEdifact(currentMessage);
                            result = true;
                            currentMessage.Clear();
                            break;
                        case SegmentTags.UNE:
                            _groupMarker--;
                            Item = new EdiControl<S_UNE>(segmentContext.Value, _separators);
                            result = true;
                            break;
                        case SegmentTags.UNZ:
                            _interchangeMarker--;
                            _separators = null;
                            Item = new EdiControl<S_UNZ>(segmentContext.Value, _separators);
                            result = true;
                            break;
                        default:
                            currentMessage.Add(segmentContext);
                            break;
                    }

                    ValidateControlStructure();
                }
            }
            catch (ParsingException ex)
            {
                Item = new EdiError(ex);
                result = true;
                currentMessage.Clear();
            }
            catch (Exception ex)
            {
                Item = new EdiError(new ParsingException(ErrorCodes.Unknown, ex.Message, ex));
                result = true;
                currentMessage.Clear();
            }

            return result;
        }

        /// <summary>
        /// Reads the stream to the end.
        /// </summary>
        /// <returns>All the messages that were found in the stream.</returns>
        public IEnumerable<EdiItem> ReadToEnd()
        {
            while (Read())
            {
                yield return Item;
            }
        }

        /// <summary>
        /// Reads the stream until the end of a message.
        /// Breaks on message exception or invalid interchange content.
        /// </summary>
        /// <returns>
        /// A collection of EDI items.
        /// </returns>
        public bool ReadNextMessage()
        {
            while (Read())
            {
                if (Item is EdiMessage ||
                    (Item is EdiError && ((EdiError) Item).Value is MessageParsingException))
                    return true;
            }

            return false;
        }

        private string ReadSegment()
        {
            var first3 = _streamReader.Read(3, _trims);

            if (string.IsNullOrEmpty(first3)) return null;
            var header = _streamReader.ReadControl(first3);
            if (header.Item2 != null && _separators == null)
            {
                _separators = header.Item2;
                _trims = _trims.Except(new[] {_separators.Segment}).ToArray();
            }

            if (_separators == null)
                throw new ParsingException(ErrorCodes.InvalidControlStructure);

            return header.Item1 ?? first3 + _streamReader.ReadSegment(_separators);
        }

        private EdiItem ParseX12(List<SegmentContext> currentMessage)
        {
            try
            {
                var type = currentMessage.ToX12Type(_separators, _rulesAssemblyName, _rulesNamespacePrefix);
                var messageInstance = currentMessage.Analyze(_separators, type, _rulesAssemblyName);

                return new EdiMessage(messageInstance, _separators);
            }
            catch (Exception ex)
            {
                var exception = ex as ParsingException;
                if (exception != null)
                    throw new MessageParsingException(exception.ErrorCode, ex);

                throw new MessageParsingException(ErrorCodes.InvalidInterchangeContent, ex);
            }           
        }

        private EdiItem ParseEdifact(List<SegmentContext> currentMessage)
        {
            try
            {
                var type = currentMessage.ToEdifactType(_separators, _rulesAssemblyName, _rulesNamespacePrefix);
                var messageInstance = currentMessage.Analyze(_separators, type, _rulesAssemblyName);

                return new EdiMessage(messageInstance, _separators);
            }
            catch (Exception ex)
            {
                var exception = ex as ParsingException;
                if (exception != null)
                    throw new MessageParsingException(exception.ErrorCode, ex);

                throw new MessageParsingException(ErrorCodes.InvalidInterchangeContent, ex);
            }
        }

        private bool IsBreakingError()
        {
            var ediError = Item as EdiError;
            if (ediError == null) return false;
            var error = (ParsingException) ediError.Value;

            return error.ErrorCode == ErrorCodes.InvalidControlStructure ||
                   error.ErrorCode == ErrorCodes.InvalidInterchangeContent ||
                   error.ErrorCode == ErrorCodes.ImproperEndOfFile ||
                   error.ErrorCode == ErrorCodes.SegmentTerminatorNotFound;
        }

        private void ValidateControlStructure()
        {
            if (_interchangeMarker < 0 || _interchangeMarker > 1)
                throw ControlException();
            if (_groupMarker < 0 || _groupMarker > 1 || (_groupMarker == 1 && _interchangeMarker == 0))
                throw ControlException();
            if (_messageMarker < 0 || _messageMarker > 1 || (_messageMarker == 1 && _interchangeMarker == 0))
                throw ControlException();
        }

        private ParsingException ControlException()
        {
            return _streamReader.EndOfStream
                ? new ParsingException(ErrorCodes.ImproperEndOfFile)
                : new ParsingException(ErrorCodes.InvalidControlStructure);
        }

        /// <summary>
        /// Disposes the reader.
        /// </summary>
        public void Dispose()
        {
            if (_streamReader != null)
                _streamReader.Dispose();
        }
    }
}
