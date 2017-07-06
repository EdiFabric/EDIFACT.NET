using System.Collections.Generic;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Rules.HIPAA_005010X222A1_837
{
    public partial class Loop_2000A : IValidator
    {
        public List<SegmentErrorContext> Validate(InstanceContext instanceContext, int segmentIndex, int inSegmentIndex,
            int inComponentIndex, int repetitionIndex)
        {
            var result = new List<SegmentErrorContext>();

            if (All_NM1_2 != null)
                result.Add(new SegmentErrorContext("CustomValidationSegment", segmentIndex, SegmentErrorCode.LoopExceedsMaximumUse,
                    "This is custom validation."));

            return result;
        }
    }
}