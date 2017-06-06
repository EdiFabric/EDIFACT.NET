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
using EdiFabric.Core.ErrorCodes;

namespace EdiFabric.Framework.Exceptions
{
    class ParserElementException : Exception
    {
        public DataElementErrorCode ErrorCode { get; private set; }
        public int ComponentPosition { get; private set; }
        
        public ParserElementException(string message, DataElementErrorCode errorCode, int compositePosition)
            : base(message)
        {
            ErrorCode = errorCode;
            ComponentPosition = compositePosition;
        }
    }
}
