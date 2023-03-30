using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.EDIFACT.Common;
using System.Diagnostics;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.ValidateEDI
{
    class ValidateEDITransationsBeforeWrite
    {
        /// <summary>
        /// Validate EDI transactions before writing them out, skipping the trailer validation because trailers hadn't been set just yet
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var purchaseOrder = SegmentBuilders.BuildPurchaseOrder("1");

            //  Validate using EDI codes map
            MessageErrorContext errorContext;
            if (!purchaseOrder.IsValid(out errorContext, new ValidationSettings { SkipTrailerValidation = true }))
            {
                //  Report it back to the sender, log, etc.
                var errors = errorContext.Flatten();
            }
            else
            {
                //  purchaseOrder is valid, handle it downstream
            }
        }
    }
}
