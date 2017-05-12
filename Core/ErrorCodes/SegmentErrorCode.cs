using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiFabric.Core.Model.Edi.ErrorCodes
{
    public enum SegmentErrorCode
    {
        SegmentWithErrors,
        SegmentNotInProperSequence,
        UnrecognizedSegment,
        LoopExceedsMaximumUse,
        SegmentExceedsMaximumUse,
        LoopBelowMinimumUse,
        SegmentBelowMinimumUse,
        RequiredSegmentMissing
    }
}
