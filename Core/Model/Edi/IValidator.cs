using System.Collections.Generic;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Core.Model.Edi
{
    /// <summary>
    /// Edi item validation interface.
    /// </summary>
    public interface IValidator
    {
        /// <summary>
        /// Detects if an item is valid.
        /// </summary>
        /// <param name="instanceContext">The instance context.</param>
        /// <param name="segmentIndex">The segment position.</param>
        /// <param name="inSegmentIndex">The position within the segment.</param>
        /// <param name="inCompositeIndex">The position within the component if any.</param>
        /// <param name="repetitionIndex">The repetition position.</param>
        /// <returns>A list of segment errors if invalid, otherwise nothing.</returns>
        List<SegmentErrorContext> Validate(InstanceContext instanceContext, int segmentIndex, int inSegmentIndex,
            int inCompositeIndex, int repetitionIndex);
    }
}
