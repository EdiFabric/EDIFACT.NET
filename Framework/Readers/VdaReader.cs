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
using System.IO;
using System.Text;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Model;

namespace EdiFabric.Framework.Readers
{
    public class VdaReader : PositionalReader
    {
        public VdaReader(Stream ediStream, Func<string, MessageContext> messageContext, Encoding encoding = null,
            string postFix = null, bool continueOnError = false)
            : base(ediStream, messageContext, encoding, 128, postFix, continueOnError)
        {
        }

        protected override EdiItem Process(string segment)
        {
            var segmentContext = new SegmentContext(segment, SetSegmentContext);
            var messageContext = MessageContext(segment);
            if (messageContext != null)
            {
                var result = Flush(segment);
                if (result != null)
                    return result;

                CurrentMessageContext = messageContext;
            }

            CurrentSegments.Add(segmentContext);

            return null;
        }

        private Tuple<string, string, string, bool> SetSegmentContext(string segment)
        {
            return new Tuple<string, string, string, bool>(segment.Substring(0, 3), segment.Substring(3, 2), null, false);
        }
    }
}
