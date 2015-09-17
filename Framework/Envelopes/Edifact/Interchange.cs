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
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EdiFabric.Framework.Envelopes.Edifact
{
    /// <summary>
    /// Edifact interchange
    /// </summary>
    [XmlRoot("INTERCHANGE", Namespace = Namespaces.Edifact)]
    public class Interchange
    {
        /// <summary>
        /// Interchange header
        /// </summary>
        [XmlElement("S_UNB", Order = 0)]
        public S_UNB Unb { get; set; }

        /// <summary>
        /// Groups
        /// </summary>
        [XmlArray("GROUPS", Order = 1)]
        [XmlArrayItem("GROUP", IsNullable = false)]
        public List<Group> Groups { get; set; }

        /// <summary>
        /// Interchange trailer
        /// </summary>
        [XmlElement("S_UNZ", Order = 2)]
        public S_UNZ Unz { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Interchange"/> class.
        /// </summary>
        public Interchange()
        {
            Groups = new List<Group>();
        }

        /// <summary>
        /// Factory to initialize a new instance of the <see cref="Interchange"/> class.
        /// </summary>
        /// <param name="ediStream">The edi stream.</param>
        /// <returns>
        /// The interchange instance.
        /// </returns>
        public static Interchange LoadFrom(Stream ediStream)
        {
            if (ediStream == null) throw new ArgumentNullException("ediStream");

            var edifactLexer = new FromEdiLexer(ediStream.ToEdiString());
            edifactLexer.Analyze();

            return edifactLexer.Result;
        }

        /// <summary>
        /// Factory to initialize a new instance of the <see cref="Interchange"/> class.
        /// </summary>
        /// <param name="ediStream">The edi stream.</param>
        /// <param name="encoding">The encoding of the edi stream.</param>
        /// <returns>
        /// The interchange instance.
        /// </returns>
        public static Interchange LoadFrom(Stream ediStream, System.Text.Encoding encoding)
        {
            if (ediStream == null) throw new ArgumentNullException("ediStream");

            var edifactLexer = new FromEdiLexer(ediStream.ToEdiString(encoding));
            edifactLexer.Analyze();

            return edifactLexer.Result;
        }

        /// <summary>
        /// Factory to initialize a new instance of the <see cref="Interchange"/> class.
        /// </summary>
        /// <param name="ediElement">
        /// The edi xml.
        /// </param>
        /// <returns>
        /// The interchange instance.
        /// </returns>
        public static Interchange LoadFrom(XElement ediElement)
        {
            if (ediElement == null) throw new ArgumentNullException("ediElement");

            return ediElement.Deserialize<Interchange>();
        }

        /// <summary>
        /// Converts the interchange to edi message.
        /// </summary>
        /// <param name="context">
        /// The interchange context.
        /// This sets the non format default separators.
        /// </param>
        /// <returns>
        /// The edi message.
        /// </returns>
        public List<string> ToEdi(InterchangeContext context = null)
        {
            var edifactLexer = new ToEdiLexer(EdiHelper.Serialize(this), context);
            edifactLexer.Analyze();

            return edifactLexer.Result;
        }

        /// <summary>
        /// Serialize the interchange into xml
        /// </summary>
        /// <returns>
        /// The serialized xml.
        /// </returns>
        public XElement Serialize()
        {
            return EdiHelper.Serialize(this);
        }
    }
}
