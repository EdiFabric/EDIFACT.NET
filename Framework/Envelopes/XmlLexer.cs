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
using System.Xml.Linq;
using EdiFabric.Framework.Messages;
using EdiFabric.Framework.Messages.Segments;

namespace EdiFabric.Framework.Envelopes
{
    /// <summary>
    /// This is the abstract lexer for Xml edi
    /// </summary>
    abstract class XmlLexer
    {
        /// <summary>
        /// The Xml edi
        /// </summary>
        private readonly XElement _xmlEdi;

        /// <summary>
        /// The interchange context
        /// </summary>
        protected InterchangeContext InterchangeContext;

        /// <summary>
        /// The edi being built
        /// </summary>
        public List<string> Result;

        /// <summary>
        /// Initializes a new instance of the <see cref="XmlLexer"/> class.
        /// </summary>
        /// <param name="xmlEdi">
        /// Edi as Xml
        /// </param>
        protected XmlLexer(XElement xmlEdi)
        {
            _xmlEdi = xmlEdi;
            Result = new List<string>();
        }

        /// <summary>
        /// Creates interchange settings
        /// </summary>
        /// <param name="xmlEdi">
        /// Edi segment
        /// </param>
        protected abstract void CreateInterchangeSettings(XElement xmlEdi);

        /// <summary>
        /// Parses interchange header 
        /// </summary>
        /// <param name="xmlEdi">
        /// Edi segment
        /// </param>
        protected abstract void CreateInterchangeHeader(XElement xmlEdi);

        /// <summary>
        /// Parses group header
        /// </summary>
        /// <param name="group">
        /// Edi segment
        /// </param>
        protected abstract void CreateGroupHeader(XElement group);

        /// <summary>
        /// Parses an edi message
        /// </summary>
        /// <param name="typedMessage">
        /// The Xml edi.
        /// </param>
        protected void CreateSegments(XElement typedMessage)
        {
            // Clear all empty nodes
            typedMessage.Descendants().Where(d => string.IsNullOrEmpty(d.Value)).Remove();
            typedMessage.Descendants().Where(d => string.IsNullOrWhiteSpace(d.Value)).Remove();

            var messageContext = new MessageContext(typedMessage);
            // Get all segments, which are not parents of other segments
            foreach (var segment in typedMessage.Descendants().Where(d => d.Name.LocalName.StartsWith("S_")
                && !d.Elements().Any(e => e.Name.LocalName.StartsWith("S_"))))
            {
                Result.Add(SegmentParser.ParseXml(messageContext.SystemType, segment, InterchangeContext));
            }
        }

        /// <summary>
        /// Parses group trailer
        /// </summary>
        /// <param name="group">
        /// Edi segment
        /// </param>
        protected abstract void CreateGroupTrailer(XElement group);

        /// <summary>
        /// Parses interchange trailer
        /// </summary>
        /// <param name="xmlEdi">
        /// Edi segment
        /// </param>
        protected abstract void CreateInterchangeTrailer(XElement xmlEdi);
        
        /// <summary>
        /// Lexical analysis of the xml
        /// </summary>
        public void Analyze()
        {
            XNamespace ns = _xmlEdi.Name.NamespaceName;

            CreateInterchangeSettings(_xmlEdi);
            CreateInterchangeHeader(_xmlEdi);

            var groups = _xmlEdi.Element(ns + EdiSegments.Groups);
            if (groups == null)
            {
                throw new ParserException("Can't find GROUPS element.");
            }

            if (!groups.Elements().Any())
            {
                throw new ParserException("Can't find GROUP element.");
            }

            foreach (var group in groups.Elements())
            {
                CreateGroupHeader(group);

                var messages = group.Element(ns + EdiSegments.Messages);

                if (messages == null)
                {
                    throw new ParserException("Can't find MESSAGES element.");
                }

                if (!messages.Elements().Any())
                {
                    throw new ParserException("Can't find MESSAGE element.");
                }

                foreach (var message in messages.Elements())
                {
                    var item = message.Elements().FirstOrDefault();

                    if (item == null)
                    {
                        throw new ParserException("Can't find item.");
                    }

                    var typedMessage = item.Elements().FirstOrDefault();

                    if (typedMessage == null)
                    {
                        throw new ParserException("Can't find message.");
                    }

                    if (!typedMessage.Elements().Any())
                    {
                        throw new ParserException("Can't find segments.");
                    }

                    CreateSegments(typedMessage);
                }

                CreateGroupTrailer(group);
            }

            CreateInterchangeTrailer(_xmlEdi);
        }

        /// <summary>
        /// Finds a node in xml by name
        /// </summary>
        /// <param name="source">The source xml</param>
        /// <param name="segment">The name of the node to search for</param>
        /// <returns>The found node</returns>
        protected XElement FindSegment(XElement source, string segment)
        {
            XNamespace ns = source.Name.NamespaceName;
            var result = source.Element(ns + "S_" + segment);

            if (result == null)
            {
                throw new ParserException(string.Format("Can't find {0} segment.", segment));
            }

            return result;
        }  
    }
}
