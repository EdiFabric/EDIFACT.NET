using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using System.Collections.Generic;
using System.Reflection;

namespace EdiFabric.Templates.EdifactD96A
{
    public partial class Loop_LIN_ORDERS : IEdiValidator
        {
            public SegmentErrorContext ValidateEdi(ValidationContext validationContext)
            {
                var position = validationContext.SegmentIndex + 1;
                if (PIA != null)
                    position += PIA.Count;
                if (IMD != null)
                    position += IMD.Count;
                if (MEA != null)
                    position += MEA.Count;
                if (QTY != null)
                    position += QTY.Count;
                if (PCD != null)
                    position += PCD.Count;
                if (ALI != null)
                    position += ALI.Count;

                if (QTY != null && DTM == null)
                    return new SegmentErrorContext("DTM", position + 1, GetType().GetTypeInfo(), SegmentErrorCode.RequiredSegmentMissing,
                        "DTM segment is missing.");

                return null;
            }
        }    
}
