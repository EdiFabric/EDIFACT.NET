using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiFabric.Core.Model.Edi.ErrorCodes
{
    public enum MessageErrorCode
    {
        MessageTrailerMissing,

        /// <summary>
        /// Missing or invalid transaction set identifier.
        /// </summary>
        InvalidTransactionSetIdentifier,

        /// <summary>
        /// Transaction set control number in header and trailer do not match.
        /// </summary>
        ControlNumberNotMatching,

        /// <summary>
        /// Number of included segments does not match actual count.
        /// </summary>
        SegmentsCountNotMatching,

        /// <summary>
        /// Invalid transaction set control number.
        /// </summary>
        DuplicateMessageControlNumber,

        /// <summary>
        /// Segment has data element errors.
        /// </summary>
        SegmentWithErrors,

        /// <summary>
        /// One or more segments in error.
        /// </summary>
        MessageWithErrors,

        /// <summary>
        /// Invalid group control number.
        /// </summary>
        DuplicateGroupControlNumber,

        /// <summary>
        /// Invalid interchange control number.
        /// </summary>
        DuplicateInterchangeControlNumber
    }
}
