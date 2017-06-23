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
using EdiFabric.Core.Model.Edi.Edifact;

namespace EdiFabric.Framework.Writers
{
    /// <summary>
    /// Writes .NET object into EDI documents.
    /// </summary>
    public sealed class EdifactWriter : EdiWriter<UNB, UNG>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdifactWriter"/> class.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The encoding. Encoding.Deafult by default.</param>
        /// <param name="postfix">The postfix after each segment line.</param>
        /// <param name="preserveWhitespace">Whether to preserve whitespace. White-spaces at the end of a segment or component are trimmed by default.</param>
        
        public EdifactWriter(Stream stream, Encoding encoding = null, string postfix = "", bool preserveWhitespace = false)
            : base(stream, postfix ?? "", preserveWhitespace, encoding ?? Encoding.UTF8)
        {
            SetFormatTags();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdifactWriter"/> class.
        /// </summary>
        /// <param name="path">The path to the file to write to.</param>
        /// <param name="append">Whether to append to the file. The file will be overwritten by default.</param>
        /// <param name="encoding">The encoding. Encoding.Deafult by default.</param>
        /// <param name="postfix">The postfix after each segment line.</param>
        /// <param name="preserveWhitespace">Whether to preserve whitespace. White-spaces at the end of a segment or component are trimmed by default.</param>
        public EdifactWriter(string path, bool append, Encoding encoding = null, string postfix = "", bool preserveWhitespace = false)
            : base(path, append, postfix ?? "", preserveWhitespace, encoding ?? Encoding.UTF8)
        {
            SetFormatTags();
        }

        public override void Write(UNB interchangeHeader, Separators separators = null)
        {
            var sep = separators ?? Separators.Edifact;
            if (sep.IsDifferent(Separators.Edifact))
                Write(sep.ToUna());

            BeginInterchange(interchangeHeader, interchangeHeader.InterchangeControlReference_5, sep);
        }

        public override void Write(UNG groupHeader)
        {
            BeginGroup(groupHeader, groupHeader.GroupReferenceNumber_5);
        }

        private void SetFormatTags()
        {
            Format = "EDIFACT";
            InterchangeTrailer = "UNZ";
            GroupTrailer = "UNE";
            MessageTrailer = "UNT";
            Ta = "";
        }       
    }
}
