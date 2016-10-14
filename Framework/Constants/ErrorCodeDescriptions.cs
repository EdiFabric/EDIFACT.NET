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

namespace EdiFabric.Framework.Constants
{
    static class ErrorCodeDescriptions
    {
        public static string ToDescription(this ErrorCodes errorCode)
        {
            switch (errorCode)
            {
                case ErrorCodes.ImproperEndOfFile:
                    return "Missing headers or trailers.";
                case ErrorCodes.InvalidControlStructure:
                    return "Missing UNA, UNB or ISA.";
                case ErrorCodes.InvalidInterchangeContent:
                    return "Missing GS.";
                default:
                    return "Unknown error.";
            }
        }
    }
}
