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
namespace EdiFabric.Annotations.Edi
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class EdiCodesAttribute : Attribute
    {
        public string Codes { get; set; }
        public EdiCodesAttribute(string codes)
        {
            Codes = codes;
        }
    }
}
