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
    /// Functional Group header.
    /// </summary>
    public class GS : IEdiItem
    {
        [D(1)]
        public string CodeIdentifyingInformationType_1 { get; set; }

        [D(2)]
        public string SenderIDCode_2 { get; set; }

        [D(3)]
        public string ReceiverIDCode_3 { get; set; }

        [D(4)]
        public string Date_4 { get; set; }

        [D(5)]
        public string Time_5 { get; set; }

        [D(6)]
        public string GroupControlNumber_6 { get; set; }

        [D(7)]
        public string TransactionTypeCode_7 { get; set; }

        [D(8)]
        public string VersionAndRelease_8 { get; set; }

        public string GetControlNumber()
        {
            throw new System.NotImplementedException();
        }

        public string SetTrailer()
        {
            throw new System.NotImplementedException();
        }
    }
}
