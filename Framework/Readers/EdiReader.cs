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
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Parses EDI messages into .NET objects.
    /// </summary>
    public abstract class EdiReader : IDisposable
    {
        private readonly Queue<char> _buffer; 
        /// <summary>
        /// The list of segments that are currently being collected.
        /// </summary>
        protected List<SegmentContext> CurrentMessage { get; private set; }
        /// <summary>
        /// The EDI stream reader.
        /// </summary>
        protected StreamReader StreamReader { get; private set; }
        /// <summary>
        /// The name of the assembly containing the rules classes.
        /// </summary>
        protected string RulesAssemblyName { get; private set; }
        /// <summary>
        /// The prefix of each of the rules classes.
        /// </summary>
        protected string RulesNamespacePrefix { get; private set; }
        /// <summary>
        /// The separators.
        /// </summary>
        protected Separators Separators { get; private set; }
        /// <summary>
        /// Symbols to skip over when reading from the stream.
        /// </summary>
        protected char[] Trims
        {
            get
            {
                char[] trims = { '\r', '\n', ' ' };
                return Separators != null ? trims.Except(new[] { Separators.Segment }).ToArray() : trims;
            }
        }

        /// <summary>
        /// The currently read item.
        /// </summary>
        public object Item { get; protected set; }
        
        /// <summary>
        /// End of stream reached.
        /// </summary>
        public bool EndOfStream
        {
            get { return StreamReader.EndOfStream; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="settings">The additional settings.</param>
        protected EdiReader(Stream ediStream, ReaderSettings settings)
        {
            if (ediStream == null) throw new ArgumentNullException("ediStream");
            if (settings == null) throw new ArgumentNullException("settings");
            
            StreamReader = new StreamReader(ediStream, settings.Encoding ?? Encoding.Default, true);
            RulesAssemblyName = settings.RulesAssemblyName;
            RulesNamespacePrefix = settings.RulesNamespacePrefix;
            CurrentMessage = new List<SegmentContext>();
            _buffer = new Queue<char>();           
         }

        /// <summary>
        /// Reads an EDI item from the stream.
        /// Items can be: control segment, message or error.
        /// </summary>
        /// <returns>If a new message was read.</returns>
        public bool Read(Action<object> collect = null)
        {
            Item = null;

            try
            {
                while (StreamReader.Peek() >= 0 && Item == null)
                {
                    ProcessSegment(ReadSegment());
                    
                    if (Separators != null) continue;
                    
                    Item = new ParsingException(ErrorCodes.NoInterchangeFound);
                    CurrentMessage.Clear();
                }               
            }
            catch (ParsingException ex)
            {
                Item = ex;
            }
            catch (Exception ex)
            {
                Item = new ParsingException(ErrorCodes.Unknown, ex.Message, ex);
            }

            if (StreamReader.EndOfStream && CurrentMessage.Any(s => !s.IsControl))
            {
                Item = new ParsingException(ErrorCodes.ImproperEndOfFile);
                CurrentMessage.Clear();
            }

            if (collect != null && Item != null) collect(Item);

            return Item != null;
        }

        /// <summary>
        /// Reads the stream to the end.
        /// </summary>
        /// <returns>All items that were found in the stream.</returns>
        public IEnumerable<object> ReadToEnd()
        {
            while (Read())
            {
                yield return Item;
            }
        }

        /// <summary>
        /// Probes for interchange header.
        /// Sets the separators if header was found.
        /// </summary>
        /// <param name="segmentName">The probed segment name.</param>
        /// <param name="probed">The probed text.</param>
        /// <param name="separators">The new separators.</param>
        /// <returns>If an interchange header was found.</returns>
        protected abstract bool TryReadControl(string segmentName, out string probed, out Separators separators);

        /// <summary>
        /// Parses control segments and messages. 
        /// </summary>
        /// <param name="segment">The current segment.</param>
        protected abstract void ProcessSegment(string segment);
        
        /// <summary>
        /// Reads a segment from the stream.
        /// </summary>
        /// <returns>
        /// The segment found.
        /// </returns>
        protected string ReadSegment()
        {
            var line = "";
            
            while (StreamReader.Peek() >= 0)
            {
                var symbol = _buffer.Any()
                    ? _buffer.Dequeue().ToString()
                    : StreamReader.Read(1);

                line = line + symbol;

                if (line.Length > 2)
                {
                    var last3 = line.Substring(line.Length - 3);
                    Separators separators;
                    string probed;
                    if (TryReadControl(last3, out probed, out separators))
                    {
                        Separators = separators;
                        line = probed;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(probed))
                            foreach (var c in probed.Skip(3))
                                _buffer.Enqueue(c);
                    }
                }

                // Segment terminator may never be reached
                if (line.Count() > 10000)
                {
                    line = "";
                    continue;
                }

                if (Separators == null)
                    continue;

                if (line.EndsWith(Separators.Segment.ToString(), StringComparison.Ordinal))
                {
                    if (Separators.Escape.HasValue &&
                        line.EndsWith(string.Concat(Separators.Escape.Value, Separators.Segment),
                            StringComparison.Ordinal))
                    {
                        continue;
                    }

                    int index = line.LastIndexOf(Separators.Segment.ToString(), StringComparison.Ordinal);
                    if (index > 0)
                    {
                        line = line.Remove(index);
                    }

                    if (!string.IsNullOrEmpty(line))
                        break;
                }
            }

            return line.Trim(Trims);
        }

        /// <summary>
        /// Disposes the reader.
        /// </summary>
        public void Dispose()
        {
            if (StreamReader != null)
                StreamReader.Dispose();
        }
    }
}
