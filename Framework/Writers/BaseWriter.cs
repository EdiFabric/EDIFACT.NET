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

namespace EdiFabric.Framework.Writers
{
    /// <summary>
    /// Writes .NET object into files or streams.
    /// </summary>
    public abstract class BaseWriter : IDisposable  
    {
        protected readonly StreamWriter Writer;
        protected readonly string PostFix;
        protected readonly bool PreserveWhitespace;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWriter"/> class.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="postfix">The postfix after each segment line.</param>
        /// <param name="preserveWhitespace">Whether to preserve whitespace. White-spaces at the end of a segment or component are trimmed by default.</param>
        /// <param name="encoding">The encoding. Encoding.UTF8 by default.</param>
        protected BaseWriter(Stream stream, string postfix, bool preserveWhitespace, Encoding encoding)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");            

            Writer = new StreamWriter(stream, encoding ?? Encoding.UTF8);
            PostFix = postfix ?? "";
            PreserveWhitespace = preserveWhitespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWriter"/> class.
        /// </summary>
        /// <param name="path">The path to the file to write to.</param>
        /// <param name="append">Whether to append to the file. The file will be overwritten by default.</param>
        /// <param name="postfix">The postfix after each segment line.</param>
        /// <param name="preserveWhitespace">Whether to preserve whitespace. White-spaces at the end of a segment or component are trimmed by default.</param>
        /// <param name="encoding">The encoding. Encoding.UTF8 by default.</param>
        protected BaseWriter(string path, bool append, string postfix, bool preserveWhitespace, Encoding encoding)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("path");
            
            var fileStream = File.Open(path, append ? FileMode.Append : FileMode.Create, FileAccess.Write);
            Writer = new StreamWriter(fileStream, encoding ?? Encoding.UTF8);
            PostFix = postfix ?? "";
            PreserveWhitespace = preserveWhitespace;
        }

        /// <summary>
        /// Writes a message to the destination.
        /// </summary>
        /// <param name="message">The message to write.</param>
        public abstract void Write(EdiMessage message);

        /// <summary>
        /// Write a segment to the destination.
        /// </summary>
        /// <param name="ediSegment">The segment.</param>
        public abstract void Write(EdiSegment ediSegment);

        /// <summary>
        /// Write the string representation of a segment to the destination.
        /// </summary>
        /// <param name="segment">The segment.</param>
        protected void Write(string segment)
        {
            Writer.Write(segment + PostFix);
        }
        
        public void Dispose()
        {
            if (Writer != null)
                Writer.Dispose();
        }

        /// <summary>
        /// Flushes the writer. 
        /// Closes the last started interchange and group if any.
        /// Flushes the underlying StreamWriter to clear the buffer.
        /// </summary>
        public virtual void Flush()
        {
            Writer.Flush();
        }   
    }
}
