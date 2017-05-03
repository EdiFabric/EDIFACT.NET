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
using EdiFabric.Annotations.Model;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Parsers;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Reads EDI documents into .NET objects.
    /// </summary>
    public abstract class EdiReader : IDisposable
    {
        private Queue<char> Buffer { get; set; }
        private StreamReader StreamReader { get; set; }
        private char[] Trims { get; set; }
        
        /// <summary>
        /// The current list of segments.
        /// </summary>
        protected List<SegmentContext> CurrentMessage { get; private set; }
        
        /// <summary>
        /// EDI separators.
        /// </summary>
        public Separators Separators { get; private set; }

        /// <summary>
        /// The last item that was read.
        /// </summary>
        public IEdiItem Item { get; protected set; }
        
        /// <summary>
        /// Indicates whether the current stream position is at the end of the stream.
        /// </summary>
        public bool EndOfStream
        {
            get { return StreamReader.EndOfStream; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        protected EdiReader(Stream ediStream, Encoding encoding)
        {
            if (ediStream == null) throw new ArgumentNullException("ediStream");
            
            StreamReader = new StreamReader(ediStream, encoding ?? Encoding.Default, true);
            CurrentMessage = new List<SegmentContext>();
            Buffer = new Queue<char>();
            Trims = new[] { '\r', '\n', ' ' };        
        }

        /// <summary>
        /// Reads an EDI item from the stream.
        /// An EDI item is an IEdiControl or a message or a ParsingException.
        /// </summary>
        /// <returns>Indication if an item was read.</returns>
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
                Item = new ParsingException(ex);
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
        /// <returns>Indicates if an interchange header was found.</returns>
        protected abstract bool TryReadControl(string segmentName, out string probed, out Separators separators);

        /// <summary>
        /// Converts EDI segments into typed objects. 
        /// </summary>
        /// <param name="segment">The segment to be processed.</param>
        protected abstract void ProcessSegment(string segment);

        /// <summary>
        /// Extracts the format, the version and the tag of the EDI document.
        /// </summary>
        /// <returns>The message context.</returns>
        protected abstract MessageContext BuildContext();
        
        /// <summary>
        /// Reads from the stream until a non-escaped segment terminator was reached.
        /// Breaks if no segment terminator was encountered after 10000 symbols were read. 
        /// This is to avoid loading large and corrupt files. 
        /// </summary>
        /// <returns>
        /// An EDI segment.
        /// </returns>
        private string ReadSegment()
        {
            var line = "";

            while (!StreamReader.EndOfStream || Buffer.Any())
            {
                var symbol = Buffer.Any()
                    ? Buffer.Dequeue().ToString()
                    : Read(1);

                line = line + symbol;

                if (line.Length > 2)
                {
                    var last3 = line.Substring(line.Length - 3);
                    Separators separators;
                    string probed;
                    if (TryReadControl(last3, out probed, out separators))
                    {
                        Separators = separators;
                        Trims = Trims.Except(new[] { Separators.Segment }).ToArray();
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
        /// Clears the internal cache before trying to process a new message.
        /// It tries to process what's in the cache in case it's a valid message, before clearing the cache.
        /// This is for situations where no message trailer was included in the file, however all other segments were present.
        /// </summary>
        /// <param name="segment">The last read segment.</param>
        protected void Flush(string segment)
        {
            foreach (var c in segment)
                Buffer.Enqueue(c);
            Buffer.Enqueue(Separators.Segment);

            try
            {
                Item = CurrentMessage.ParseTransactionSet(Separators, BuildContext());
            }
            finally
            {
                CurrentMessage.Clear();
            }
        }

        /// <summary>
        /// Reads number of bytes from the stream.
        /// Skips over any known trim symbol.
        /// </summary>
        /// <param name="bytes">The number of bytes.</param>
        /// <returns>The string read from the stream.</returns>
        protected string ReadWithTrims(int bytes)
        {
            string result = null;
            var counter = 0;
            while (counter < bytes && !StreamReader.EndOfStream)
            {
                var symbol = Read(1).Trim(Trims);
                if (!String.IsNullOrEmpty(symbol))
                    counter += 1;
                result += symbol;
            }

            return result;
        }

        /// <summary>
        /// Reads number of bytes from the stream.
        /// </summary>
        /// <param name="bytes">The number of bytes.</param>
        /// <returns>The string read from the stream.</returns>
        protected string Read(int bytes)
        {
            var result = new char[bytes];
            StreamReader.Read(result, 0, result.Length);
            return String.Concat(result);
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
