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
using System.Linq;
using System.Xml.Linq;
using EdiFabric.Framework.Envelopes;

namespace EdiFabric.Framework.Messages
{
    /// <summary>
    /// This class represents the context of the EDI message. Every message is identified by its context.
    /// </summary>
    /// <example>
    /// Extract message.
    /// <code lang="C#">
    /// var interchange = Interchange.LoadFrom(File.OpenRead(@"c:\test.edi"));
    /// var message = interchange.Groups[0].Messages[0];
    /// if (message.Context.Tag == "INVOIC" &amp;&amp; message.Context.Version == "D96A")
    /// {
    ///     var typedMessage = message.DeserializeItem&lt;EdiFabric.Definitions.Edifact_D96A_INVOIC.M_INVOIC&gt;();
    /// }
    /// </code>
    /// </example>
    public class MessageContext
    {
        /// <summary>
        /// EDI tag.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// EDI version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// EDI origin.
        /// Used for sub formats such as HIPAA.
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// EDI format, this is the message format and can be different than the envelope format.
        /// The envelope can be X12 whereas the message can be HIPAA.
        /// </summary>
        public EdiFormats Format { get; set; }

        /// <summary>
        /// The system type which represents a valid .NET type.
        /// </summary>
        private readonly Type _systemType;
        /// <summary>
        /// The read only system type.
        /// </summary>
        public Type SystemType
        {
            get { return _systemType; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// Parameterless constructor is needed for serialization\deserialization
        /// </summary>
        // ReSharper disable once UnusedMember.Local
        private MessageContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="message">
        /// From XML.
        /// </param>
        /// <param name="interchangeContext">
        /// The interchange context.
        /// </param>
        public MessageContext(XElement message, InterchangeContext interchangeContext)
        {
            ToContext(message);
            _systemType = ToSystemType(Format, Version, Tag, Origin, interchangeContext.DefinitionsAssemblyName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="envelopes">
        /// From interchange headers.
        /// </param>
        /// <param name="interchangeContext">
        /// The interchange context.
        /// </param>
        public MessageContext(IEnumerable<string> envelopes, InterchangeContext interchangeContext)
        {
            ToContext(envelopes, interchangeContext);
            _systemType = ToSystemType(Format, Version, Tag, Origin, interchangeContext.DefinitionsAssemblyName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="systemType">
        /// From type.
        /// </param>
        public MessageContext(Type systemType)
        {
            if (systemType == null) throw new ArgumentNullException("systemType");
            
            ToContext(systemType);
            _systemType = systemType;
        }

        /// <summary>
        /// Converts a system type into message context.
        /// </summary>
        /// <param name="systemType">
        /// The system type.
        /// </param>
        private void ToContext(Type systemType)
        {
            var splittedDots = systemType.FullName.Split('.');
            if (splittedDots.Length < 3)
                throw new Exception(string.Format("Can't create message context from type {0}", systemType.FullName));
            var splittedUnders = splittedDots[2].Split('_');
            if (splittedUnders.Length < 3)
                throw new Exception(string.Format("Can't create message context from type {0}", systemType.FullName));

            var format = ToFormat(splittedUnders[0]);
            var version = splittedUnders[1];
            var tag = splittedUnders[2];
            string origin = null;

            if (splittedUnders.Length > 3)
                origin = splittedUnders[3];

            Tag = tag;
            Version = version;
            Origin = origin;
            Format = format;
        }

        /// <summary>
        /// Converts a message context into system type.  
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="version">Message version.</param>
        /// <param name="tag">Message tag.</param>
        /// <param name="origin">Message origin.</param>
        /// <param name="definitionsAssemblyName">The assembly name of the project containing the classes and XSD.</param>
        /// <returns>
        /// The system type.
        /// </returns>
        private Type ToSystemType(EdiFormats format, string version, string tag, string origin, string definitionsAssemblyName)
        {
            if (string.IsNullOrEmpty(version)) throw new NullReferenceException("version");
            if (string.IsNullOrEmpty(tag)) throw new NullReferenceException("tag");

            var typeFullName = "EdiFabric.Definitions" + "." + format + "_" + version + "_" + tag;
            if (!string.IsNullOrEmpty(origin))
                typeFullName = typeFullName + "_" + origin;

            typeFullName = typeFullName + ".M_" + tag;
            typeFullName = typeFullName + ", " + definitionsAssemblyName;

            var systemType = Type.GetType(typeFullName);

            if (systemType == null)
                throw new ParserException(string.Format("Can't find type for type name = {0} .Please ensure that the correct class was added to the definitions project and that you pointed to the definitions project in your .config file.", typeFullName));

            return systemType;
        }

        /// <summary>
        /// Converts XML EDI into message context.
        /// </summary>
        /// <param name="message">
        /// The XML EDI.
        /// </param>
        private void ToContext(XElement message)
        {
            if (message == null) throw new ArgumentNullException("message");

            switch (message.Name.NamespaceName)
            {
                case Namespaces.Edifact:
                    ToContextEdifact(message);
                    break;
                case Namespaces.X12:
                    ToContextX12(message);
                    break;
                default:
                    throw new Exception(string.Format("Unsupported message format = {0}", message.Name.NamespaceName));
            }
        }

        /// <summary>
        /// Converts XML EDI into message context.
        /// </summary>
        /// <param name="message">
        /// The XML EDI.
        /// </param>
        private void ToContextX12(XElement message)
        {
            XNamespace ns = message.Name.NamespaceName;
            var st = message.Element(ns + "S_" + EdiSegments.St);

            if (st == null)
            {
                throw new ParserException("Can't find ST segment.");
            }

            if (message.Parent == null || message.Parent.Parent == null || message.Parent.Parent.Parent == null ||
                message.Parent.Parent.Parent.Parent == null)
            {
                throw new ParserException("Can't find GROUP segment.");
            }

            var gs = message.Parent.Parent.Parent.Parent.Element(ns + "S_" + EdiSegments.Gs);

            if (gs == null)
            {
                throw new ParserException("Can't find GS segment.");
            }

            XElement tag = null;
            if (st.Descendants().Any(x => x.Name.LocalName.IndexOf(EdiElements.StTag, StringComparison.Ordinal) != -1)) {
                tag = st.Descendants().First(x => x.Name.LocalName.IndexOf(EdiElements.StTag, StringComparison.Ordinal) != -1);
            } else if (st.Descendants().Any(x => x.Name.LocalName.IndexOf(EdiElements.StTagHipaa, StringComparison.Ordinal) != -1)) {
                tag = st.Descendants().First(x => x.Name.LocalName.IndexOf(EdiElements.StTagHipaa, StringComparison.Ordinal) != -1);
            }

            if (tag == null)
            {
                throw new ParserException("Can't find " + EdiElements.StTag);
            }

            var version = gs.Element(ns + EdiElements.GsVersion);

            if (version == null)
            {
                throw new ParserException("Can't find " + EdiElements.GsVersion);
            }

            if (version.Value.Length < 6)
            {
                throw new ParserException("Version length should be at least 6.");
            }

            var versionString = version.Value.Substring(0, 6);
            string origin = null;
            if (version.Value.Count() >= 10)
                origin = version.Value.Substring(6, 4);
            var format = HipaaHelper.IsHipaa(versionString + origin) ? EdiFormats.Hipaa : EdiFormats.X12;

            Tag = tag.Value;
            Version = versionString;
            Origin = origin;
            Format = format;
        }

        /// <summary>
        /// Converts XML EDI into message context.
        /// </summary>
        /// <param name="message">
        /// The XML EDI.
        /// </param>
        private void ToContextEdifact(XElement message)
        {
            XNamespace ns = message.Name.NamespaceName;
            var unh = message.Element(ns + "S_" + EdiSegments.Unh);

            if (unh == null)
            {
                throw new ParserException("Can't find UNH segment.");
            }

            var unhContext = unh.Element(ns + EdiElements.UnhContext);

            if (unhContext == null)
            {
                throw new ParserException("Can't find " + EdiElements.UnhContext);
            }

            var tag = unhContext.Element(ns + EdiElements.UnhTag);

            if (tag == null)
            {
                throw new ParserException("Can't find " + EdiElements.UnhTag);
            }

            var edition = unhContext.Element(ns + EdiElements.UnhEdition);

            if (edition == null)
            {
                throw new ParserException("Can't find " + EdiElements.UnhEdition);
            }

            var release = unhContext.Element(ns + EdiElements.UnhRelease);

            if (release == null)
            {
                throw new ParserException("Can't find " + EdiElements.UnhRelease);
            }

            Tag = tag.Value;
            Version = edition.Value + release.Value;
            Origin = null;
            Format = EdiFormats.Edifact;
        }

        /// <summary>
        /// Converts EDI interchange headers into message context.
        /// </summary>
        /// <param name="envelopes">The interchange headers.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        private void ToContext(IEnumerable<string> envelopes, InterchangeContext interchangeContext)
        {
            if (envelopes == null) throw new ArgumentNullException("envelopes");
            
            switch (interchangeContext.Format)
            {
                case EdiFormats.Edifact:
                    ToContextEdifact(envelopes, interchangeContext);
                    break;
                case EdiFormats.X12:
                    ToContextX12(envelopes, interchangeContext);
                    break;
                default:
                    throw new Exception(string.Format("Unsupported message format = {0}", interchangeContext.Format));
            }
        }

        /// <summary>
        /// Converts EDI interchange headers into message context.
        /// </summary>
        /// <param name="envelopes">The interchange headers.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        private void ToContextX12(IEnumerable<string> envelopes, InterchangeContext interchangeContext)
        {
            var enumerable = envelopes as List<string> ?? envelopes.ToList();
            string version;
            string origin;
            string format;
            string tag;

            try
            {
                var gs = enumerable.Single(es => es.StartsWith(EdiSegments.Gs));
                var ediCompositeDataElementsGs = EdiHelper.GetEdiCompositeDataElements(gs, interchangeContext);

                version = ediCompositeDataElementsGs[7].Substring(0, 6);
                origin = ediCompositeDataElementsGs[7].Count() >= 10
                    ? ediCompositeDataElementsGs[7].Substring(6, 4)
                    : null;
                format = HipaaHelper.IsHipaa(version + origin) ? EdiFormats.Hipaa.ToString() : EdiFormats.X12.ToString();

                if (!HipaaHelper.IsHipaa(version + origin))
                {
                    origin = null;
                }
            }
            catch(Exception ex)
            {
                throw new ParserException("Can't parse GS segment.", ex);
            }

            try
            {
                var st = enumerable.Single(es => es.StartsWith(EdiSegments.St));
                var ediCompositeDataElementsSt = EdiHelper.GetEdiCompositeDataElements(st, interchangeContext);
                tag = ediCompositeDataElementsSt[0];
            }
            catch (Exception ex)
            {
                throw new ParserException("Can't parse ST segment.", ex);
            }

            Tag = tag;
            Version = version;
            Origin = origin;
            Format = ToFormat(format);
        }

        /// <summary>
        /// Converts EDI interchange headers into message context.
        /// </summary>
        /// <param name="envelopes">The interchange headers.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        private void ToContextEdifact(IEnumerable<string> envelopes, InterchangeContext interchangeContext)
        {
            try
            {
                var unh = envelopes.Single(es => es.StartsWith(EdiSegments.Unh));
                var ediCompositeDataElements = EdiHelper.GetEdiCompositeDataElements(unh, interchangeContext);
                var ediDataElements = EdiHelper.GetEdiComponentDataElements(ediCompositeDataElements[1],
                    interchangeContext);

                Tag = ediDataElements[0];
                Version = ediDataElements[1] + ediDataElements[2];
                Origin = null;
                Format = EdiFormats.Edifact;
            }
            catch (Exception ex)
            {
                throw new ParserException("Can't parse UNH segment.", ex);
            }
        }

        /// <summary>
        /// Converts a string to enum
        /// </summary>
        /// <param name="value">The format string.</param>
        /// <returns>The format enum.</returns>
        private static EdiFormats ToFormat(string value)
        {
            return (EdiFormats)Enum.Parse(typeof(EdiFormats), value);
        }
    }
}
