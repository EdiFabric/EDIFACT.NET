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

namespace EdiFabric.Framework.Envelopes.Edifact
{
    /// <summary>
    /// This is the edifact lexer for Xml edi
    /// </summary>
    class ToEdiLexer : XmlLexer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlLexer"/> class.
        /// </summary>
        /// <param name="xmlEdi">
        /// Edi as Xml
        /// </param>
        /// <param name="context">
        /// The interchange context
        /// </param>
        public ToEdiLexer(XElement xmlEdi, InterchangeContext context)
            : base(xmlEdi)
        {
            InterchangeContext = new InterchangeContext(EdiFormats.Edifact);
            // Merge the custom context to the default
            InterchangeContext.Merge(context);

            // Make sure no same separator is used more than once
            if (!InterchangeContext.IsValid(EdiFormats.Edifact))
                throw new ParserException("Invalid interchange context.");
        }

        /// <summary>
        /// Creates interchange settings
        /// </summary>
        /// <param name="xmlEdi">
        /// Edi segment
        /// </param>
        protected override void CreateInterchangeSettings(XElement xmlEdi)
        {
            if (InterchangeContext.IsDefault) return;
            
            // If the interchange settings are not default then add UNA segment
            Result.Add(EdiSegments.Una + InterchangeContext.ComponentDataElementSeparator
                      + InterchangeContext.DataElementSeparator + "."
                      + InterchangeContext.ReleaseIndicator + " "
                      + InterchangeContext.SegmentTerminator);
        }

        /// <summary>
        /// Parses interchange header 
        /// </summary>
        /// <param name="xmlEdi">
        /// Edi segment
        /// </param>
        protected override void CreateInterchangeHeader(XElement xmlEdi)
        {
            Result.Add(SegmentParser.ParseXml<S_UNB>(FindSegment(xmlEdi, EdiSegments.Unb), InterchangeContext));
        }

        /// <summary>
        /// Parses group header
        /// </summary>
        /// <param name="group">
        /// Edi segment
        /// </param>
        protected override void CreateGroupHeader(XElement group)
        {
            try
            {
                Result.Add(SegmentParser.ParseXml<S_UNG>(FindSegment(group, EdiSegments.Ung), InterchangeContext));
            }
            catch (ParserException)
            {
                // skip exception as edifact groups are optional
            }
        }

        /// <summary>
        /// Parses group trailer
        /// </summary>
        /// <param name="group">
        /// Edi segment
        /// </param>
        protected override void CreateGroupTrailer(XElement group)
        {
            try
            {
                Result.Add(SegmentParser.ParseXml<S_UNE>(FindSegment(group, EdiSegments.Une), InterchangeContext));
            }
            catch (ParserException)
            {
                // skip exception as edifact groups are optional
            }
        }

        /// <summary>
        /// Parses interchange trailer
        /// </summary>
        /// <param name="xmlEdi">
        /// Edi segment
        /// </param>
        protected override void CreateInterchangeTrailer(XElement xmlEdi)
        {
            Result.Add(SegmentParser.ParseXml<S_UNZ>(FindSegment(xmlEdi, EdiSegments.Unz), InterchangeContext));
        }
    }
}
