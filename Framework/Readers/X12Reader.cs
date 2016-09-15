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
        /// <param name="ediStream">The EDI stream.</param>
        /// <param name="definitionsAssemblyName">The full assembly name of the assembly with the definition classes.</param>
        /// <param name="encoding">The encoding.</param>
        protected X12Reader(Stream ediStream, string definitionsAssemblyName, Encoding encoding)
            : base(ediStream, definitionsAssemblyName, encoding)
        {
        }
        
        /// <summary>
        /// Factory method to initialize a new instance of the <see cref="X12Reader"/> class.
        /// </summary>
        /// <param name="ediStream">The EDI stream.</param>
        /// <param name="definitionsAssemblyName">The full assembly name of the assembly with the definition classes.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns></returns>
        public static X12Reader Create(Stream ediStream, string definitionsAssemblyName, Encoding encoding = null)
        {
            return new X12Reader(ediStream, definitionsAssemblyName, encoding);
        }       
    }
}
