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
using System.Reflection;
using System.Text;
using EdiFabric.Framework.Parsing;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// The additional settings for the reader.
    /// </summary>
    public class ReaderSettings
    {
        /// <summary>
        /// The encoding. The default is Encoding.Default.
        /// </summary>
        public Encoding Encoding { get; private set; } 
        /// <summary>
        /// The factory to return the assembly containing the EDI classes. The default is EdiFabric.Rules.
        /// </summary>
        public Func<MessageContext, Assembly> RulesAssembly { get; private set; } 
        /// <summary>
        /// The factory to return the namespace prefix for the EDI classes. The default is EdiFabric.Rules.
        /// </summary>
        public Func<MessageContext, string> RulesNamespacePrefix { get; private set; }

        private const string DefaultRulesNamespacePrefix = "EdiFabric.Rules";

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderSettings"/> class.
        /// </summary>
        public ReaderSettings(string rulesAssemblyName)
            : this(
                key => Assembly.Load(rulesAssemblyName), Encoding.Default,
                key => DefaultRulesNamespacePrefix)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderSettings"/> class.
        /// </summary>
        public ReaderSettings(string rulesAssemblyName, Encoding encoding)
            : this(
                key => Assembly.Load(rulesAssemblyName), encoding,
                key => DefaultRulesNamespacePrefix)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderSettings"/> class.
        /// </summary>
        public ReaderSettings(string rulesAssemblyName, string rulesNamespacePrefix)
            : this(
                key => Assembly.Load(rulesAssemblyName), Encoding.Default,
                key => rulesNamespacePrefix)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderSettings"/> class.
        /// </summary>
        public ReaderSettings(string rulesAssemblyName, string rulesNamespacePrefix, Encoding encoding)
            : this(
                key => Assembly.Load(rulesAssemblyName), encoding,
                key => rulesNamespacePrefix)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderSettings"/> class.
        /// </summary>
        /// <param name="rulesAssembly"></param>
        /// <param name="encoding"></param>
        /// <param name="rulesNamespacePrefix"></param>
        public ReaderSettings(Func<MessageContext, Assembly> rulesAssembly,
            Encoding encoding, Func<MessageContext, string> rulesNamespacePrefix)
        {
            if (rulesAssembly == null) throw new ArgumentNullException("rulesAssembly");
            if (encoding == null) throw new ArgumentNullException("encoding");
            if (rulesNamespacePrefix == null) throw new ArgumentNullException("rulesNamespacePrefix");

            Encoding = encoding;
            RulesAssembly = rulesAssembly;
            RulesNamespacePrefix = rulesNamespacePrefix;
        }
    }
}
