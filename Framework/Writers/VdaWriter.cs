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

using System.IO;
using System.Text;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Model;

namespace EdiFabric.Framework.Writers
{
    /// <summary>
    /// Writes .NET object into VDA documents.
    /// </summary>
    public class VdaWriter : BaseWriter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VdaWriter"/> class.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="postfix">The postfix after each segment line.</param>
        /// <param name="encoding">The encoding. Encoding.UTF8 by default.</param>
        public VdaWriter(Stream stream, string postfix = "", Encoding encoding = null)
            : base(stream, postfix, true, encoding)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VdaWriter"/> class.
        /// </summary>
        /// <param name="path">The path to the file to write to.</param>
        /// <param name="append">Whether to append to the file. The file will be overwritten by default.</param>
        /// <param name="postfix">The postfix after each segment line.</param>
        /// <param name="encoding">The encoding. Encoding.UTF8 by default.</param>
        public VdaWriter(string path, bool append, string postfix = "", Encoding encoding = null)
            : base(path, append, postfix, true, encoding)
        {
        }

        public override void Write(EdiMessage message)
        {
            var transactionSet = new TransactionSet(message.GetStandardType(), message);
            foreach (var segment in transactionSet.Descendants<Segment>())
            {
                Write(segment.Generate(Pad));
            }
        }

        public override void Write(EdiSegment ediSegment)
        {
            var segment = new Segment(ediSegment.GetStandardType(), ediSegment);
            Write(segment.Generate(Pad));
        }

        private string Pad(DataElement dataElement)
        {
            return dataElement.Value.PadRight(dataElement.MaxSize, ' ');
        }
    }
}
