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
    /// Attribute to mark position.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class PosAttribute : Attribute
    {
        /// <summary>
        /// The position.
        /// </summary>
        public int Pos { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PosAttribute"/> class.
        /// </summary>
        /// <param name="pos">The position.</param>
        public PosAttribute(int pos)
        {
            Pos = pos;
        }
    }
}
