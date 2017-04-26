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

using EdiFabric.Attributes;

namespace EdiFabric.Framework.Segments.X12
{
    /// <summary>
    /// Interchange acknowledgment.
    /// </summary>
    public class TA1 : IEdiItem
    {
        [D(1)]
        public string InterchangeControlNumber_1 { get; set; }

        [D(2)]
        public string InterchangeDate_2 { get; set; }

        [D(3)]
        public string InterchangeTime_3 { get; set; }

        [D(4)]
        public string InterchangeAcknowledgmentCode_4 { get; set; }

        [D(5)]
        public string InterchangeNoteCode_5 { get; set; }
    }      
}
