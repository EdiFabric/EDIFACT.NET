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

namespace EdiFabric.Framework.Envelopes.X12
{
    /// <summary>
    /// This class represents the X12 interchange.
    /// </summary>
    /// <example>
    /// Parse EDI with classes in the default assembly EdiFabric.Definitions.dll.
    /// <code lang="C#">
    /// var interchange = Interchange.LoadFrom(File.OpenRead(@"c:\test.edi"));
    /// </code>
    /// </example>
    [XmlRoot("INTERCHANGE", Namespace = Namespaces.X12)]
    public class Interchange : AbstractInterchange
    {
        /// <summary>
        /// Interchange header.
        /// </summary>
        [XmlElement("S_ISA", Order = 0)]
        public S_ISA Isa { get; set; }

        /// <summary>
        /// Groups.
        /// </summary>
        [XmlArray("GROUPS", Order = 1)]
        [XmlArrayItem("GROUP", IsNullable = false)]
        public List<Group> Groups { get; set; }

        /// <summary>
        /// Interchange trailer.
        /// </summary>
        [XmlElement("S_IEA", Order = 2)]
        public S_IEA Iea { get; set; }

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
        /// <param name="ediStream">The EDI stream.</param>
        /// <param name="definitionsAssemblyName">The assembly name of the project containing the classes.</param>
        /// <returns>
        /// The interchange instance.
        /// </returns>
        /// <example>
        /// Parse EDI with classes in a custom assembly MyAssembly.MyProject.dll.
        /// <code lang="C#">
        /// var interchange = Interchange.LoadFrom(File.OpenRead(@"c:\test.edi"), "MyAssembly.MyProject");
        /// </code>
        /// </example>
        public static Interchange LoadFrom(Stream ediStream, string definitionsAssemblyName = null)
        {
            if (ediStream == null) throw new ArgumentNullException("ediStream");

            var x12Lexer = new FromEdiLexer(ediStream.ToEdiString(), definitionsAssemblyName);
            x12Lexer.Analyze();

            // X12 headers are positional and the blank spaces need to be preserved
            x12Lexer.Result.Isa.D_745_2 = x12Lexer.Result.Isa.D_745_2.PadRight(10, ' ');
            x12Lexer.Result.Isa.D_747_4 = x12Lexer.Result.Isa.D_747_4.PadRight(10, ' ');

            return x12Lexer.Result;
        }

        /// <summary>
        /// Factory to initialize a new instance of the <see cref="Interchange"/> class.
        /// </summary>
        /// <param name="ediElement">
        /// The EDI XML.
        /// </param>
        /// <returns>
        /// The interchange instance.
        /// </returns>
        /// <example>
        /// Interchange to XML.
        /// <code lang="C#">
        /// var interchange = Interchange.LoadFrom(File.OpenRead(@"c:\test.edi"));
        /// XElement xml = interchange.Serialize();
        /// interchange = Interchange.LoadFrom(xml);
        /// </code>
        /// </example>
        public static Interchange LoadFrom(XElement ediElement)
        {
            if (ediElement == null) throw new ArgumentNullException("ediElement");

            var interchange = ediElement.Deserialize<Interchange>();

            // X12 headers are positional and the blank spaces need to be preserved
            interchange.Isa.D_745_2 = interchange.Isa.D_745_2.PadRight(10, ' ');
            interchange.Isa.D_747_4 = interchange.Isa.D_747_4.PadRight(10, ' ');

            return interchange;
        }

        /// <summary>
        /// Converts the interchange to EDI message.
        /// </summary>
        /// <param name="context">
        /// The interchange context.
        /// This sets the non format default separators.
        /// </param>
        /// <returns>
        /// The EDI message.
        /// </returns>
        /// <example>
        /// Generate EDI with classes in the default assembly EdiFabric.Definitions.dll.
        /// <code lang="C#">
        /// var interchange = new Interchange();
        /// // Construct the object...
        /// List&lt;string&gt; segments = interchange.ToEdi();
        /// </code>
        /// </example>
        public override List<string> ToEdi(InterchangeContext context = null)
        {
            var x12Lexer = new ToEdiLexer(EdiHelper.Serialize(this), context);
            x12Lexer.Analyze();

            return x12Lexer.Result;
        }
    }
}
