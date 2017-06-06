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
using System.Text;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Model;

namespace EdiFabric.Framework.Writers
{
    /// <summary>
    /// Writes .NET object into EDI documents.
    /// </summary>
    /// <typeparam name="T">The interchange header.</typeparam>
    /// <typeparam name="U">The group header.</typeparam>
    // ReSharper disable once InconsistentNaming
    public abstract class EdiWriter<T, U> : IDisposable  
    {
        private readonly StreamWriter _writer;             
        private readonly string _postFix;
        private string _interchangeControlNr;
        private string _groupControlNr;
        private int _messageCounter;
        private int _groupCounter;        
        private Separators _separators;
        private readonly bool _preserveWhitespace;

        protected string Format;
        protected string InterchangeTrailer;
        protected string GroupTrailer;
        protected string MessageTrailer;
        protected string Ta;

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiWriter{T, U}"/> class.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="postfix">The postfix after each segment line.</param>
        /// <param name="preserveWhitespace">Whether to preserve whitespace. White-spaces at the end of a segment or component are trimmed by default.</param>
        /// <param name="encoding">The encoding. Encoding.Deafult by default.</param>
        protected EdiWriter(Stream stream, string postfix, bool preserveWhitespace, Encoding encoding)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (encoding == null)
                throw new ArgumentNullException("encoding");
            if (postfix == null)
                throw new ArgumentNullException("postfix");

            _writer = new StreamWriter(stream, encoding);
            _postFix = postfix;
            _preserveWhitespace = preserveWhitespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiWriter{T, U}"/> class.
        /// </summary>
        /// <param name="path">The path to the file to write to.</param>
        /// <param name="append">Whether to append to the file. The file will be overwritten by default.</param>
        /// <param name="postfix">The postfix after each segment line.</param>
        /// <param name="preserveWhitespace">Whether to preserve whitespace. White-spaces at the end of a segment or component are trimmed by default.</param>
        /// <param name="encoding">The encoding. Encoding.Deafult by default.</param>
        protected EdiWriter(string path, bool append, string postfix, bool preserveWhitespace, Encoding encoding)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("path");
            if (encoding == null)
                throw new ArgumentNullException("encoding");
            if (postfix == null)
                throw new ArgumentNullException("postfix");             

            _writer = new StreamWriter(path, append, encoding);
            _postFix = postfix;
            _preserveWhitespace = preserveWhitespace;
        }

        /// <summary>
        /// Writes an interchange header to the destination to start a new interchange.
        /// Closes the previous interchange and group if any.
        /// </summary>
        /// <param name="interchangeHeader">The interchange header.</param>
        /// <param name="separators">The separators.
        /// Allows to write multiple interchanges to the destination, each with its own separators.
        /// </param>
        public abstract void Write(T interchangeHeader, Separators separators = null);

        /// <summary>
        /// Writes an interchange header to the destination to start a new interchange.
        /// Closes the last started interchange and group if any.
        /// </summary>
        /// <param name="interchangeHeader">The interchange header.</param>
        /// <param name="controlNumber">The interchange header control number.</param>
        /// <param name="separators">The separators.
        /// Allows to write multiple interchanges to the destination, each with its own separators.
        /// </param>
        protected void BeginInterchange(T interchangeHeader, string controlNumber, Separators separators)
        {
            if (separators == null)
                throw new ArgumentNullException("separators");

            _separators = separators;

            EndGroup();
            EndInterchange();

            _interchangeControlNr = controlNumber;

            var segment = new Segment(typeof(T), interchangeHeader);
            Write(segment.GenerateSegment(_separators, _preserveWhitespace));
        }

        private void EndInterchange()
        {
            if (_interchangeControlNr != null)
            {
                var trailer = BuildTrailer(InterchangeTrailer, _interchangeControlNr,
                    _groupCounter > 0 ? _groupCounter : _messageCounter);
                Write(trailer);
            }

            _messageCounter = 0;
            _groupCounter = 0;
            _groupControlNr = null;
            _interchangeControlNr = null;
        }

        /// <summary>
        /// Writes a group header to the destination to start a new group.
        /// Closes the last started group if any.
        /// </summary>
        /// <param name="groupHeader">The group header.</param>
        public abstract void Write(U groupHeader);

        /// <summary>
        /// Writes a group header to the destination to start a new group.
        /// Closes the last started group if any.
        /// </summary>
        /// <param name="groupHeader">The group header.</param>
        /// <param name="controlNumber">The group header control number.</param>
        protected void BeginGroup(U groupHeader, string controlNumber)
        {
            if (_separators == null)
                throw new Exception("No interchange was started.");

            EndGroup();

            _messageCounter = 0;
            _groupControlNr = null;
            _groupCounter++;

            _groupControlNr = controlNumber;

            var segment = new Segment(typeof(U), groupHeader);
            Write(segment.GenerateSegment(_separators, _preserveWhitespace));
        }

        private void EndGroup()
        {
            if (_groupControlNr != null)
            {
                var trailer = BuildTrailer(GroupTrailer, _groupControlNr, _messageCounter);
                Write(trailer);

                _messageCounter = 0;
            }
            
            _groupControlNr = null;
        }

        /// <summary>
        /// Writes a message to the destination.
        /// </summary>
        /// <param name="message">The message to write.</param>
        public void Write(EdiMessage message)
        {
            if (_separators == null)
                throw new Exception("No interchange was started.");

            _messageCounter++;

            var segmentCounter = 0;
            var transactionSet = new TransactionSet(message.GetType(), message);
            transactionSet.RemoveTrailer(MessageTrailer);

            foreach (var segment in transactionSet.Descendants<Segment>())
            {
                Write(segment.GenerateSegment(_separators, _preserveWhitespace));
                segmentCounter++;
            }

            if (message.Name == "TA1")
                return;

            segmentCounter++;
            var trailer = BuildTrailer(MessageTrailer, message.ControlNumber, segmentCounter);
            Write(trailer);
        }
        
        /// <summary>
        /// Write the string representation of a segment to the destination.
        /// </summary>
        /// <param name="segment">The segment.</param>
        public void Write(string segment)
        {
            _writer.Write(segment + _postFix);
        }
        
        /// <summary>
        /// Flushes the writer. 
        /// Closes the last started interchange and group if any.
        /// Flushes the underlying StreamWriter to clear the buffer.
        /// </summary>
        public void Flush()
        {
            if (_separators != null)
            {
                EndGroup();
                EndInterchange();
            }

            _writer.Flush();
        }

        public void Dispose()
        {
            if (_writer != null)
                _writer.Dispose();
        }

        private string BuildTrailer(string tag, string controlNumber, int count)
        {
            return tag + _separators.DataElement + count + _separators.DataElement +
                      controlNumber + _separators.Segment;
        }
    }
}
