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

using System.Collections.Generic;
using System.Linq;
using EdiFabric.Framework.Messages;
using EdiFabric.Framework.Messages.Segments;

namespace EdiFabric.Framework.Envelopes.Edifact
{
    /// <summary>
    /// This is the EDIFACT lexer for converting EDI into XML.
    /// </summary>
    class FromEdiLexer : InterchangeLexer
    {
        /// <summary>
        /// The interchange that is being built.
        /// </summary>
        public Interchange Result { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FromEdiLexer"/> class.
        /// </summary>
        /// <param name="ediString">
        /// The EDI message.
        /// </param>
        /// <param name="definitionsAssemblyName">The assembly name of the project containing the classes.</param>
        public FromEdiLexer(string ediString, string definitionsAssemblyName)
            : base(ediString, definitionsAssemblyName)
        {
            Result = new Interchange();
        }

        /// <summary>
        /// Parses the interchange header.
        /// </summary>
        /// <param name="segment">
        /// The EDI segment.
        /// </param>
        protected override void CreateInterchangeHeader(string segment)
        {
            Result.Unb = SegmentParser.ParseLine<S_UNB>(segment, InterchangeContext).Deserialize<S_UNB>();
        }

        /// <summary>
        /// Parses the interchange trailer.
        /// </summary>
        /// <param name="segment">
        /// The EDI segment.
        /// </param>
        protected override void CreateInterchangeTrailer(string segment)
        {
            Result.Unz = SegmentParser.ParseLine<S_UNZ>(segment, InterchangeContext).Deserialize<S_UNZ>();
        }

        /// <summary>
        /// Parses the group header.
        /// </summary>
        /// <param name="segment">
        /// The EDI segment.
        /// </param>
        protected override void CreateGroupHeader(string segment)
        {
            Result.Groups.Add(new Group());
            Result.Groups.Last().Messages = new List<Message>();

            Result.Groups.Last().Ung = SegmentParser.ParseLine<S_UNG>(segment, InterchangeContext).Deserialize<S_UNG>();
        }

        /// <summary>
        /// Parses the group trailer.
        /// </summary>
        /// <param name="segment">
        /// The EDI segment.
        /// </param>
        protected override void CreateGroupTrailer(string segment)
        {
            Result.Groups.Last().Une = SegmentParser.ParseLine<S_UNE>(segment, InterchangeContext).Deserialize<S_UNE>();
        }

        /// <summary>
        /// Parses the EDI message.
        /// </summary>
        /// <param name="segments">The message segments.</param>
        /// <param name="headers">The interchange headers.</param>
        protected override void CreateMessage(List<string> segments, List<string> headers)
        {
            if (Result.Groups.Count == 0)
            {
                // Manually create group if none have been created
                // Edifact groups are optional
                Result.Groups.Add(new Group());
                Result.Groups.Last().Messages = new List<Message>();
            }

            Result.Groups.Last().Messages.Add(MessageLexer.Analyze(segments, headers, InterchangeContext));
        }
    }
}
