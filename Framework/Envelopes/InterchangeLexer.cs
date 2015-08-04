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

namespace EdiFabric.Framework.Envelopes
{
    /// <summary>
    /// This is the abstract lexer for interchanges
    /// </summary>
    abstract class InterchangeLexer
    {
        /// <summary>
        /// The interchange context
        /// </summary>
        protected InterchangeContext InterchangeContext;

        /// <summary>
        /// The edi message
        /// </summary>
        private readonly string _ediString;

        /// <summary>
        /// Initializes a new instance of the <see cref="InterchangeLexer"/> class.
        /// </summary>
        /// <param name="ediString">
        /// The edi message.
        /// </param>
        /// <param name="definitionsAssemblyName">The assembly name of the project containing the classes and xsd.</param>
        protected InterchangeLexer(string ediString, string definitionsAssemblyName)
        {
            _ediString = ediString;
            InterchangeContext = new InterchangeContext(ediString, definitionsAssemblyName);
        }
        
        /// <summary>
        /// Parses interchange header
        /// </summary>
        /// <param name="segment">
        /// The edi segment
        /// </param>
        protected abstract void CreateInterchangeHeader(string segment);

        /// <summary>
        /// Parses interchange trailer
        /// </summary>
        /// <param name="segment">
        /// The edi segment
        /// </param>
        protected abstract void CreateInterchangeTrailer(string segment);

        /// <summary>
        /// Parses group header
        /// </summary>
        /// <param name="segment">
        /// The edi segment
        /// </param>
        protected abstract void CreateGroupHeader(string segment);

        /// <summary>
        /// Parses group trailer
        /// </summary>
        /// <param name="segment">
        /// The edi segment
        /// </param>
        protected abstract void CreateGroupTrailer(string segment);

        /// <summary>
        /// Parses an edi message
        /// </summary>
        /// <param name="segments">The message segments</param>
        /// <param name="headers">The interchange headers</param>
        protected abstract void CreateMessage(List<string> segments, List<string> headers);

        /// <summary>
        /// Lexical analysis of the segments
        /// </summary>
        public void Analyze()
        {
            var message = new List<string>();
            var envelope = new List<string>();

            // Loads all messages in memory
            foreach (var segment in EdiHelper.GetEdiSegments(_ediString, InterchangeContext))
            {
                switch (EdiHelper.GetSegmentName(segment, InterchangeContext))
                {
                    case EdiSegments.Una:
                        break;
                    case EdiSegments.Unb:
                    case EdiSegments.Isa:
                        CreateInterchangeHeader(segment);
                        break;
                    case EdiSegments.Unz:
                    case EdiSegments.Iea:
                        CreateInterchangeTrailer(segment);
                        break;
                    case EdiSegments.Ung:
                        CreateGroupHeader(segment);
                        break;
                    case EdiSegments.Gs:
                        CreateGroupHeader(segment);
                        envelope.Add(segment);
                        break;
                    case EdiSegments.Une:
                    case EdiSegments.Ge:
                        CreateGroupTrailer(segment);
                        envelope.Clear();
                        break;
                    case EdiSegments.Unh:
                    case EdiSegments.St:
                        message.Add(segment);
                        envelope.Add(segment);
                        break;
                    case EdiSegments.Unt:
                    case EdiSegments.Se:
                        message.Add(segment);
                        CreateMessage(message, envelope);
                        // For X12 the ST segment is included in the headers
                        // Once the message is parsed - it's removed
                        envelope.Remove(envelope.Last());
                        message.Clear();
                        break;
                    default:
                        message.Add(segment);
                        break;
                }
            }
        }
     }
}
