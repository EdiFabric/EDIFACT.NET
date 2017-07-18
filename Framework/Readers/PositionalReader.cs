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
    public class PositionalReader : BaseReader
    {
        internal readonly Func<string, MessageContext> MessageContext;
        private readonly string _postFix;

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionalReader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="messageContext">The delegate to return the message context.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <param name="postFix">The postfix.</param>
        /// <param name="continueOnError">Whether to continue searching for valid data after an error occurs.</param>
        /// <param name="segmentLength">The maximum length of a segment after which the search for segment terminator seizes.</param>
        protected PositionalReader(Stream ediStream, Func<string, MessageContext> messageContext, Encoding encoding,
            int segmentLength, string postFix = null, bool continueOnError = false)
            : base(ediStream, encoding, continueOnError, segmentLength)
        {
            if (messageContext == null) throw new ArgumentNullException("messageContext");
            MessageContext = messageContext;
            _postFix = postFix;
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

                   if (string.IsNullOrEmpty(segment))
                        continue;

                    Item = Process(segment);
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
                Item = Flush(null);

            var readerErrorContext = Item as ReaderErrorContext;
            if (readerErrorContext != null)
            {
                CurrentSegments.Clear();              
            }

            return Item != null;
        }

        /// <summary>
        /// Converts EDI segments into typed objects. 
        /// </summary>
        /// <param name="segment">The segment to be processed.</param>
        protected virtual EdiItem Process(string segment)
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
            var postFix = "";
            while ((!StreamReader.EndOfStream || InternalBuffer.Any()) && line.Length < MaxSegmentLength)
            {
                line = line + Read(1); 
            }

            while (!string.IsNullOrEmpty(_postFix) && !StreamReader.EndOfStream && postFix.Length < _postFix.Length)
            {
                postFix = postFix + Read(1); 
            }

            if (!string.IsNullOrEmpty(_postFix) && postFix != _postFix)
                throw new Exception(string.Format("Postfix {0} is different than the expected {1}", postFix, _postFix));            

            return line;
        }       
    }
}
