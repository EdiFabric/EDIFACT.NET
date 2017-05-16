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

namespace EdiFabric.Core.Annotations.Edi
{
    /// <summary>
    /// Base class for all EDI attributes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class EdiAttribute : Attribute
    {
        /// <summary>
        /// The EDI identifier.
        /// </summary>
        public string Id { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdiAttribute"/> class.
        /// </summary>
        /// <param name="id"></param>
        public EdiAttribute(string id)
        {
            Id = id;
        }
    }
}
