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
using EdiFabric.Framework.Segments.X12;

namespace EdiFabric.Framework.Writers
{
    /// <summary>
    /// Writes .NET object into EDI documents.
    /// </summary>
    public sealed class X12Writer : EdiWriter<ISA, GS>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="X12Writer"/> class.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="encoding">The encoding. Encoding.Deafult by default.</param>
        /// <param name="postfix">The postfix after each segment line.</param>
        /// <param name="preserveWhitespace">Whether to preserve whitespace. White-spaces at the end of a segment or component are trimmed by default.</param>
        public X12Writer(Stream stream, Encoding encoding = null, string postfix = "", bool preserveWhitespace = false)
            : base(stream, encoding ?? Encoding.Default, postfix ?? "", preserveWhitespace)
        {
            SetFormatTags();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="X12Writer"/> class.
        /// </summary>
        /// <param name="path">The path to the file to write to.</param>
        /// <param name="append">Whether to append to the file. The file will be overwritten by default.</param>
        /// <param name="encoding">The encoding. Encoding.Deafult by default.</param>
        /// <param name="postfix">The postfix after each segment line.</param>
        /// <param name="preserveWhitespace">Whether to preserve whitespace. White-spaces at the end of a segment or component are trimmed by default.</param>
        public X12Writer(string path, bool append, Encoding encoding = null, string postfix = "", bool preserveWhitespace = false)
            : base(path, append, encoding ?? Encoding.Default, postfix ?? "", preserveWhitespace)
        {
            SetFormatTags();
        }

        public override void WriteInterchange(ISA interchangeHeader, Separators separators = null)
        {
            var sep = separators ?? Separators.X12;
            interchangeHeader.ComponentElementSeparator_16 = sep.ComponentDataElement.ToString();
            if (interchangeHeader.InterchangeControlStandardsIdentifier_11 != "U")
                interchangeHeader.InterchangeControlStandardsIdentifier_11 = sep.RepetitionDataElement.ToString();

            BeginInterchange(interchangeHeader, interchangeHeader.InterchangeControlNumber_13, sep);
        }

        public override void WriteGroup(GS groupHeader)
        {
            BeginGroup(groupHeader, groupHeader.GroupControlNumber_6);
        }

        private void SetFormatTags()
        {
            Format = "X12";
            InterchangeTrailer = "IEA";
            GroupTrailer = "GE";
            MessageTrailer = "SE";
            Ta = "TA1";
        }        
    }
}
