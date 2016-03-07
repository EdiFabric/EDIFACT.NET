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

using System.Xml.Linq;
using EdiFabric.Framework.Messages.Segments;

namespace EdiFabric.Framework.Envelopes.X12
{
    /// <summary>
    /// This is the X12 lexer for converting XML into EDI.
    /// </summary>
    class ToEdiLexer : XmlLexer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToEdiLexer"/> class.
        /// </summary>
        /// <param name="xmlEdi">
        /// EDI as XML.
        /// </param>
        /// <param name="context">
        /// The interchange context.
        /// </param>
        public ToEdiLexer(XElement xmlEdi, InterchangeContext context)
            : base(xmlEdi)
        {
            InterchangeContext = new InterchangeContext(EdiFormats.X12);
            // Merge the custom context to the default
            InterchangeContext.Merge(context);

            // Make sure no same separator is used more than once
            if (!InterchangeContext.IsValid(EdiFormats.X12))
                throw new ParserException("Invalid interchange context.");
        }

        protected override void CreateInterchangeSettings(XElement xmlEdi)
        {
            // X12 has no alternative to UNA because it always set the separators in the content
        }

        /// <summary>
        /// Parses the interchange header. 
        /// </summary>
        /// <param name="xmlEdi">
        /// EDI segment.
        /// </param>
        protected override void CreateInterchangeHeader(XElement xmlEdi)
        {
            Result.Add(SegmentParser.ParseXml<S_ISA>(FindSegment(xmlEdi, EdiSegments.Isa), InterchangeContext));
        }

        /// <summary>
        /// Parses the group header.
        /// </summary>
        /// <param name="group">
        /// EDI segment.
        /// </param>
        protected override void CreateGroupHeader(XElement group)
        {
            Result.Add(SegmentParser.ParseXml<S_GS>(FindSegment(group, EdiSegments.Gs), InterchangeContext));
        }

        /// <summary>
        /// Parses the group trailer.
        /// </summary>
        /// <param name="group">
        /// EDI segment.
        /// </param>
        protected override void CreateGroupTrailer(XElement group)
        {
            Result.Add(SegmentParser.ParseXml<S_GE>(FindSegment(group, EdiSegments.Ge), InterchangeContext));
        }

        /// <summary>
        /// Parses the interchange trailer.
        /// </summary>
        /// <param name="xmlEdi">
        /// EDI segment.
        /// </param>
        protected override void CreateInterchangeTrailer(XElement xmlEdi)
        {
            Result.Add(SegmentParser.ParseXml<S_IEA>(FindSegment(xmlEdi, EdiSegments.Iea), InterchangeContext));
        }
    }
}
