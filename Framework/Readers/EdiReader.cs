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
using System.Reflection;
using System.Text;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Reads EDI documents into .NET objects.
    /// </summary>
    public class EdiReader : BaseReader
    {
        internal readonly Func<MessageContext, Assembly> RulesAssembly;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EdiReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssembly">The delegate to return the assembly containing the EDI classes.</param>
        /// <param name="encoding">The encoding. The default is Encoding.UTF8.</param>
        /// <param name="continueOnError">Whether to continue searching for valid data after an error occurs.</param>
        /// <param name="maxSegmentLength">The maximum length of a segment after which the search for segment terminator seizes.</param>
        protected EdiReader(Stream ediStream, Func<MessageContext, Assembly> rulesAssembly, Encoding encoding,
            bool continueOnError, int maxSegmentLength)
            : base(ediStream, encoding, continueOnError, maxSegmentLength)
        {
            if (rulesAssembly == null) throw new ArgumentNullException("rulesAssembly");
            RulesAssembly = rulesAssembly;            
        }

        /// <summary>
        /// Reads an EDI item from the stream.
        /// </summary>
        /// <returns>Indication if an item was read.</returns>
        public override bool Read()
        {
            if (Item is ReaderErrorContext && !ContinueOnError)
                return false;

            Item = null;

            try
            {
                while ((!StreamReader.EndOfStream || InternalBuffer.Any()) && Item == null)
                {
                    var segment = ReadSegment();

                    if (Separators == null)
                        throw new ReaderException("No valid separator set was found.", ReaderErrorCode.InvalidControlStructure);

                    if (string.IsNullOrEmpty(segment))
                        continue;

                    Item = Split(segment) ?? Process(segment);
                }
            }
            catch (ReaderException ex)
            {
                Item = new ReaderErrorContext(ex, ex.ErrorCode);
            }
            catch (ParserMessageException ex)
            {
                Item = new ReaderErrorContext(ex, ReaderErrorCode.InvalidSpecOrAssembly, ex.MessageErrorContext);
            }
            catch (Exception ex)
            {
                Item = new ReaderErrorContext(ex, ReaderErrorCode.Unknown);
            }

            if (StreamReader.EndOfStream && CurrentSegments.Any())
                Item = new ReaderErrorContext(new Exception("Improper end of file."), ReaderErrorCode.ImproperEndOfFile);

            var readerErrorContext = Item as ReaderErrorContext;
            if (readerErrorContext != null)
            {
                CurrentSegments.Clear();
                if(readerErrorContext.MessageErrorContext == null)
                    Separators = null;
            }

            return Item != null;
        }

        /// <summary>
        /// Probes for interchange header.
        /// Sets the separators if header was found.
        /// </summary>
        /// <param name="segmentName">The probed segment name.</param>
        /// <param name="probed">The probed text.</param>
        /// <param name="separators">The new separators.</param>
        /// <returns>Indicates if an interchange header was found.</returns>
        protected virtual bool TryReadHeader(string segmentName, out string probed, out Separators separators)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts EDI segments into typed objects. 
        /// </summary>
        /// <param name="segment">The segment to be processed.</param>
        protected override EdiItem Process(string segment)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reads from the stream until a non-escaped segment terminator was reached.
        /// Breaks if no segment terminator was encountered after 5000 symbols were read. 
        /// This is to avoid loading large and corrupt files. 
        /// </summary>
        /// <returns>
        /// An EDI segment.
        /// </returns>
        protected override string ReadSegment()
        {
            var line = "";
            while (!StreamReader.EndOfStream || InternalBuffer.Any())
            {
                line = line + Read(1);
                if (line.Length > 2)
                {
                    var last3 = line.Substring(line.Length - 3);
                    Separators separators;
                    string probed;
                    if (TryReadHeader(last3, out probed, out separators))
                    {
                        Separators = separators;
                        Trims = Trims.Except(new[] {Separators.Segment}).ToArray();
                        line = probed;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(probed))
                            Buffer(probed.Skip(3));                            
                    }
                }

                // Segment terminator may never be reached
                if (line.Length > MaxSegmentLength)
                {
                    //  Reset and continue or break
                    if (ContinueOnError)
                        line = "";
                    else
                        throw new ReaderException(
                            string.Format("No segment was found before the buffer reached the allowed maximum of {0}.", MaxSegmentLength),
                            ReaderErrorCode.InvalidInterchangeContent);
                }

                if (Separators == null)
                    continue;

                if (!line.EndsWith(Separators.Segment.ToString(), StringComparison.Ordinal)) 
                    continue;

                if (Separators.Escape.HasValue &&
                    line.EndsWith(string.Concat(Separators.Escape.Value, Separators.Segment),
                        StringComparison.Ordinal))
                    continue;

                var index = line.LastIndexOf(Separators.Segment.ToString(), StringComparison.Ordinal);
                if (index > 0)
                    line = line.Remove(index);

                if (!string.IsNullOrEmpty(line))
                    break;
            }

            return line.Trim(Trims);
        }       
    }
}
