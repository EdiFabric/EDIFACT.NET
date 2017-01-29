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
using System.Reflection;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Parsing;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Parses EDI messages into .NET objects.
    /// </summary>
    public abstract class EdiReader : IDisposable
    {
        internal SegmentContext CurrentGroupHeader;
        internal Queue<char> Buffer { get; private set; } 
        internal List<SegmentContext> CurrentMessage { get; private set; }
        internal StreamReader StreamReader { get; private set; }
        internal Separators Separators { get; private set; }
        internal Func<MessageContext, Assembly> RulesAssembly { get; private set; }
        internal Func<MessageContext, string> RulesNamespacePrefix { get; private set; }
        internal char[] Trims
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
            
            StreamReader = new StreamReader(ediStream, settings.Encoding, true);
            CurrentMessage = new List<SegmentContext>();
            Buffer = new Queue<char>();
            RulesAssembly = settings.RulesAssembly;
            RulesNamespacePrefix = settings.RulesNamespacePrefix;
        }

        /// <summary>
        /// Reads an EDI item from the stream.
        /// Items can be: control segment, message or error.
        /// </summary>
        /// <returns>If a new message was read.</returns>
        public bool Read()
        {
            Item = null;

            try
            {
                while ((!StreamReader.EndOfStream || Buffer.Any()) && Item == null)
                {
                    ProcessSegment(ReadSegment());
                    
                    if (Separators != null) continue;
                    
                    Item = new ParsingException(ErrorCodes.InvalidControlStructure, "No valid interchange header was found.");
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

            if (StreamReader.EndOfStream && CurrentMessage.Any())
            {
                Item = new ParsingException(ErrorCodes.ImproperEndOfFile, "Unprocessed segments before the end of file.");
                CurrentMessage.Clear();
            }

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
        internal abstract bool TryReadControl(string segmentName, out string probed, out Separators separators);

        /// <summary>
        /// Parses control segments and messages. 
        /// </summary>
        /// <param name="segment">The current segment.</param>
        internal abstract void ProcessSegment(string segment);

        /// <summary>
        /// Extracts the message context.
        /// </summary>
        /// <returns>The ediFabric type for this transaction set.</returns>
        internal abstract MessageContext BuildContext();
        
        /// <summary>
        /// Reads a segment from the stream.
        /// </summary>
        /// <returns>
        /// The segment found.
        /// </returns>
        internal string ReadSegment()
        {
            var line = "";

            while (!StreamReader.EndOfStream || Buffer.Any())
            {
                var symbol = Buffer.Any()
                    ? Buffer.Dequeue().ToString()
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
                                Buffer.Enqueue(c);
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
        /// Tries to parse what had been collected before a new message starts.
        /// </summary>
        /// <param name="segmentContext">The current segment.</param>
        /// <param name="tag">The start new message tag.</param>
        /// <returns>If flushed.</returns>
        internal bool Flush(SegmentContext segmentContext, SegmentTags tag)
        {
            if ((segmentContext.IsControl || segmentContext.Tag == tag) && CurrentMessage.Any())
            {
                foreach (var c in segmentContext.Value)
                    Buffer.Enqueue(c);
                Buffer.Enqueue(Separators.Segment);

                try
                {
                    if (CurrentGroupHeader != null)
                        CurrentMessage.Add(CurrentGroupHeader);
                    Item = CurrentMessage.Analyze(Separators, BuildContext());
                }
                finally
                {
                    CurrentMessage.Clear();
                }

                return true;
            }

            return false;
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
