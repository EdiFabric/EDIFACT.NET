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

using System.Collections.Generic;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Core.Model.Edi
{
    /// <summary>
    /// EDI segment with validation.
    /// </summary>
    public class EdiSegment : EdiItem
    {
        /// <summary>
        ///  Validates an item according to its validation attributes.
        /// </summary>
        /// <returns>A list of segment error contexts. The list is empty if the item is valid.</returns>
        public virtual List<SegmentErrorContext> Validate()
        {
            int segmentsNum;
            return this.Validate(out segmentsNum);
        }
    }
}
