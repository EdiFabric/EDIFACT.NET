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

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Parses EDI messages into .NET objects.
    /// </summary>
    public abstract class EdiReader : IDisposable
    {
        protected readonly StreamReader StreamReader;
        protected readonly string RulesAssemblyName;
        protected readonly string RulesNamespacePrefix;

        /// <summary>
        /// Symbols to discard while reading.
        /// </summary>
        protected char[] Trims
        {
            get
            {
                char[] trims = {'\r', '\n', ' '};
                return Separators != null ? trims.Except(new[] {Separators.Segment}).ToArray() : trims;
            }
        }
            
        protected Separators Separators;

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
         }

        /// <summary>
        /// Reads an EDI item from the stream.
        /// Items can be: control segment, message or error.
        /// </summary>
        /// <returns>If a new message was read.</returns>
        public abstract bool Read(Action<object> collect = null);

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
        /// <param name="header">The interchange header.</param>
        /// <returns>If an interchange header was found.</returns>
        protected abstract bool TryReadControl(string segmentName, out string header);

        protected string ReadSegment()
        {
            var line = "";

            while (StreamReader.Peek() >= 0)
            {
                var symbol = StreamReader.Read(1);
                line = line + symbol;

                if (line.Length > 2)
                {
                    string probed;
                    var last3 = line.Substring(line.Length - 3);
                    if (TryReadControl(last3, out probed))
                    {
                        line = probed;
                    }
                    else
                    {
                        if(!string.IsNullOrEmpty(probed))
                            line = line.Substring(0, line.Length - 3) + probed;
                    }                    
                }

                // Segment terminator may never be reached
                if (line.Count() > 1024)
                {
                    line = "";
                    Separators = null;
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
