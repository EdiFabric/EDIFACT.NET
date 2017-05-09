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
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class PosAttribute : Attribute
    {
        public int Pos { get; set; }
        public PosAttribute(int pos)
        {
            Pos = pos;
        }
    }
}
