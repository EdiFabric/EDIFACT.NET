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
                case ErrorCodes.InvalidControlStructure:
                    return "Missing or invalid control segments.";
                case ErrorCodes.InvalidInterchangeContent:
                    return "Missing or invalid segments.";
                case ErrorCodes.ImproperEndOfFile:
                    return "Missing trailers.";
                case ErrorCodes.SegmentTerminatorNotFound:
                    return "Segment terminator was not found.";
                case ErrorCodes.BlankSegment:
                    return "Segment is blank.";
                case ErrorCodes.RulesAssemblyNameNotSet:
                    return "Rules assembly name is blank. It must be set in the .config or passed explicitly.";
                case ErrorCodes.TypeNotFound:
                    return "Type was not found in rules assembly.";
                case ErrorCodes.GsInvalid:
                    return "GS is too short.";
                case ErrorCodes.GsNotFound:
                    return "Failed to find GS.";
                case ErrorCodes.StNotFound:
                    return "Failed to find ST.";
                case ErrorCodes.UnhInvalid:
                    return "UNH is too short.";
                case ErrorCodes.UnhNotFound:
                    return "Failed to find UNH.";
                case ErrorCodes.SegmentNotFound:
                    return "Segment was not found.";
                case ErrorCodes.DataElementsNumberMismatch:
                    return "Number of data elements is different in the class.";
                default:
                    return "Unknown error.";
            }
        }
    }
}
