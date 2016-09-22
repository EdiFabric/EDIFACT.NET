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

using System.IO;
using System.Text;
using EdiFabric.Framework.Headers;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// Parses EDI messages into .NET object.
    /// </summary>
    public class X12Reader : EdiReader<S_ISA, S_GS>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="X12Reader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssemblyName">The full assembly name of the assembly containing the EDI classes. The default is Edifabric.Rules.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <param name="rulesNamespacePrefix">The namespace prefix for the EDI classes. The default is Edifabric.Rules.</param>
        protected X12Reader(Stream ediStream, string rulesAssemblyName, Encoding encoding, string rulesNamespacePrefix)
            : base(ediStream, rulesAssemblyName, encoding, rulesNamespacePrefix)
        {
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="X12Reader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssemblyName">The full assembly name of the assembly containing the EDI classes. The default is Edifabric.Rules.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <param name="rulesNamespacePrefix">The namespace prefix for the EDI classes. The default is Edifabric.Rules.</param>
        /// <returns>A new instance of the <see cref="X12Reader"/> class.</returns>
        public static X12Reader Create(Stream ediStream, string rulesAssemblyName = null, Encoding encoding = null, string rulesNamespacePrefix = null)
        {
            return new X12Reader(ediStream, rulesAssemblyName, encoding, rulesNamespacePrefix);
        }

        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="X12Reader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream to read from.</param>
        /// <param name="rulesAssemblyName">The full assembly name of the assembly containing the EDI classes. The default is Edifabric.Rules.</param>
        /// <param name="encoding">The encoding. The default is Encoding.Default.</param>
        /// <param name="rulesNamespacePrefix">The namespace prefix for the EDI classes. The default is Edifabric.Rules.</param>
        /// <returns>A new instance of the <see cref="X12Reader"/> class.</returns>
        public static X12Reader Create(Stream ediStream, Encoding encoding = null, string rulesAssemblyName = null, string rulesNamespacePrefix = null)
        {
            return new X12Reader(ediStream, rulesAssemblyName, encoding, rulesNamespacePrefix);
        } 
    }
}
