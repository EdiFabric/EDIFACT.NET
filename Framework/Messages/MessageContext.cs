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
    /// Context of Edi message
    /// </summary>
    public class MessageContext
    {
        /// <summary>
        /// Edi tag
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Edi version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Edi origin
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Edi format, this is the message format and can be different than the envelope format
        /// </summary>
        public EdiFormats Format { get; set; }

        /// <summary>
        /// The system type
        /// </summary>
        private readonly Type _systemType;
        public Type SystemType
        {
            get { return _systemType; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// Parameterless constructor is needed for serialization\deserialization
        /// </summary>
        private MessageContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="message">
        /// From xml
        /// </param>
        public MessageContext(XElement message)
        {
            var context = ToContext(message);

            Format = context.Item4;
            Version = context.Item2;
            Tag = context.Item1;
            Origin = context.Item3;
            _systemType = ToSystemType(Format, Version, Tag, Origin);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="envelopes">
        /// From interchange headers
        /// </param>
        /// <param name="interchangeContext">
        /// The interchange context
        /// </param>
        public MessageContext(IEnumerable<string> envelopes, InterchangeContext interchangeContext)
        {
            var context = ToContext(envelopes, interchangeContext);

            Format = context.Item4;
            Version = context.Item2;
            Tag = context.Item1;
            Origin = context.Item3;
            _systemType = ToSystemType(Format, Version, Tag, Origin);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        /// <param name="systemType">
        /// From type
        /// </param>
        public MessageContext(Type systemType)
        {
            if (systemType == null) throw new ArgumentNullException("systemType");
            
            var context = ToContext(systemType);

            Format = context.Item4;
            Version = context.Item2;
            Tag = context.Item1;
            Origin = context.Item3;
            _systemType = systemType;
        }

        /// <summary>
        /// Converts system type into message context
        /// </summary>
        /// <param name="systemType">
        /// The system type.
        /// </param>
        /// <returns>
        /// The message context.
        /// </returns>
        private Tuple<string, string, string, EdiFormats> ToContext(Type systemType)
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

            return new Tuple<string, string, string, EdiFormats>(tag, version, origin, format);
        }

        /// <summary>
        /// Converts message context into system type  
        /// </summary>
        /// <param name="format">Message format.</param>
        /// <param name="version">Message version.</param>
        /// <param name="tag">Message tag.</param>
        /// <param name="origin">Message origin.</param>
        /// <returns>
        /// The system type.
        /// </returns>
        private Type ToSystemType(EdiFormats format, string version, string tag, string origin)
        {
            const string definitions = "EdiFabric.Definitions";

            if (string.IsNullOrEmpty(version)) throw new NullReferenceException("version");
            if (string.IsNullOrEmpty(tag)) throw new NullReferenceException("tag");

            var typeFullName = definitions + "." + format + "_" + version + "_" + tag;
            if (!string.IsNullOrEmpty(origin))
                typeFullName = typeFullName + "_" + origin;

            typeFullName = typeFullName + ".M_" + tag;
            typeFullName = typeFullName + ", " + definitions;

            var systemType = Type.GetType(typeFullName);

            if (systemType == null)
                throw new ParserException(string.Format("Can't find type for type name = {0}", typeFullName));

            return systemType;
        }

        /// <summary>
        /// Converts xml edi into message context
        /// </summary>
        /// <param name="message">
        /// The xml edi.
        /// </param>
        /// <returns>
        /// The message context.
        /// </returns>
        private Tuple<string, string, string, EdiFormats> ToContext(XElement message)
        {
            if (message == null) throw new ArgumentNullException("message");

            switch (message.Name.NamespaceName)
            {
                case Namespaces.Edifact:
                    return ToContextEdifact(message);
                case Namespaces.X12:
                    return ToContextX12(message);
            }

            throw new Exception(string.Format("Unsupported message format = {0}", message.Name.NamespaceName));
        }

        /// <summary>
        /// Converts xml edi into message context
        /// </summary>
        /// <param name="message">
        /// The xml edi.
        /// </param>
        /// <returns>
        /// The message context.
        /// </returns>
        private Tuple<string, string, string, EdiFormats> ToContextX12(XElement message)
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
            if (st.Descendants().Where(x => x.Name.LocalName.IndexOf(EdiElements.StTag) != -1).Any()) {
                tag = st.Descendants().Where(x => x.Name.LocalName.IndexOf(EdiElements.StTag) != -1).First();
            } else if (st.Descendants().Where(x => x.Name.LocalName.IndexOf(EdiElements.StTagHipaa) != -1).Any()) {
                tag = st.Descendants().Where(x => x.Name.LocalName.IndexOf(EdiElements.StTagHipaa) != -1).First();
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
            if (version.Value.Count() > 10)
                origin = version.Value.Substring(6, 4);
            var format = HipaaHelper.IsHipaa(versionString + origin) ? EdiFormats.Hipaa : EdiFormats.X12;

            return new Tuple<string, string, string, EdiFormats>(tag.Value, versionString, origin, format);
        }

        /// <summary>
        /// Converts xml edi into message context
        /// </summary>
        /// <param name="message">
        /// The xml edi.
        /// </param>
        /// <returns>
        /// The message context.
        /// </returns>
        private Tuple<string, string, string, EdiFormats> ToContextEdifact(XElement message)
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

            return new Tuple<string, string, string, EdiFormats>(tag.Value, edition.Value + release.Value, null, EdiFormats.Edifact);
        }

        /// <summary>
        /// Converts edi interchange headers into message context.
        /// </summary>
        /// <param name="envelopes">The interchange headers.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>
        /// The message context.
        /// </returns>
        private Tuple<string, string, string, EdiFormats> ToContext(IEnumerable<string> envelopes, InterchangeContext interchangeContext)
        {
            if (envelopes == null) throw new ArgumentNullException("envelopes");
            
            switch (interchangeContext.Format)
            {
                case EdiFormats.Edifact:
                    return ToContextEdifact(envelopes, interchangeContext);
                case EdiFormats.X12:
                    return ToContextX12(envelopes, interchangeContext);
            }

            throw new Exception(string.Format("Unsupported message format = {0}", interchangeContext.Format));
        }

        /// <summary>
        /// Converts edi interchange headers into message context.
        /// </summary>
        /// <param name="envelopes">The interchange headers.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>
        /// The message context.
        /// </returns>
        private Tuple<string, string, string, EdiFormats> ToContextX12(IEnumerable<string> envelopes, InterchangeContext interchangeContext)
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

            return new Tuple<string, string, string, EdiFormats>(tag, version, origin, ToFormat(format));
        }

        /// <summary>
        /// Converts edi interchange headers into message context.
        /// </summary>
        /// <param name="envelopes">The interchange headers.</param>
        /// <param name="interchangeContext">The interchange context.</param>
        /// <returns>
        /// The message context.
        /// </returns>
        private Tuple<string, string, string, EdiFormats> ToContextEdifact(IEnumerable<string> envelopes, InterchangeContext interchangeContext)
        {
            try
            {
                var unh = envelopes.Single(es => es.StartsWith(EdiSegments.Unh));
                var ediCompositeDataElements = EdiHelper.GetEdiCompositeDataElements(unh, interchangeContext);
                var ediDataElements = EdiHelper.GetEdiComponentDataElements(ediCompositeDataElements[1], interchangeContext);

                return new Tuple<string, string, string, EdiFormats>(ediDataElements[0], ediDataElements[1] + ediDataElements[2], null, EdiFormats.Edifact);
             }
            catch (Exception ex)
            {
                throw new ParserException("Can't parse UNH segment.", ex);
            }
        }

        /// <summary>
        /// Converts a string to formtas enum
        /// </summary>
        /// <param name="value">The format string.</param>
        /// <returns>The format enum.</returns>
        public static EdiFormats ToFormat(string value)
        {
            return (EdiFormats)Enum.Parse(typeof(EdiFormats), value);
        }
    }
}
