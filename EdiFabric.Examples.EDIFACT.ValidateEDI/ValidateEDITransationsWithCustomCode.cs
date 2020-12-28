using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.EDIFACT.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace EdiFabric.Examples.EDIFACT.ValidateEDI
{
    class ValidateEDITransationsWithCustomCode
    {
        /// <summary>
        /// Apply custom validation for cross segment or data element scenarios
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrderInvalid.txt");

            List<IEdiItem> ediItems;
            //  Load the new template with the custom validation
            using (var ediReader = new EdifactReader(ediStream, (UNB unb, UNG ung, UNH unh) => typeof(TSORDERSCustomValidation).GetTypeInfo()))
                ediItems = ediReader.ReadToEnd().ToList();

            //  Get the purchase order
            var po = ediItems.OfType<TSORDERSCustomValidation>().Single();

            //  Check that the custom validation was triggered
            MessageErrorContext errorContext;
            if (!po.IsValid(out errorContext))
            {
                var customValidation = errorContext.Errors.FirstOrDefault(e => e.Message == "DTM segment is missing.");
                Debug.WriteLine(customValidation.Message);
            }
        }
    }

    /// <summary>
    /// New validation attribute to apply to LIN loops
    /// Validates that if QTY segment exists, then DTM segment must also exists, otherwise throws an exception
    /// Preserves the position of the missing segment within the loop, to allow the correct index to be applied in the acknowledgment
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class LinLoopValidationAttribute : ValidationAttribute
    {
        public LinLoopValidationAttribute() : base(10)
        {
        }

        public override SegmentErrorContext ValidateEdi(ValidationContext validationContext)
        {
            var position = validationContext.SegmentIndex + 1;

            var linLoops = validationContext.InstanceContext.Instance as IList<Loop_LIN_ORDERS>;
            if (linLoops != null)
            {
                foreach (var linLoop in linLoops)
                {
                    //  Count all existing segments before the one that is validated to apply the correct index
                    if (linLoop.PIA != null)
                        position += linLoop.PIA.Count;
                    if (linLoop.IMD != null)
                        position += linLoop.IMD.Count;
                    if (linLoop.MEA != null)
                        position += linLoop.MEA.Count;
                    if (linLoop.QTY != null)
                        position += linLoop.QTY.Count;
                    if (linLoop.PCD != null)
                        position += linLoop.PCD.Count;
                    if (linLoop.ALI != null)
                        position += linLoop.ALI.Count;

                    //  Check if QTY exists and DTM also exist
                    if (linLoop.QTY != null && linLoop.DTM == null)
                        return new SegmentErrorContext("DTM", position + 1, GetType().GetTypeInfo(), SegmentErrorCode.RequiredSegmentMissing,
                            "DTM segment is missing.");
                }
            }

            return null;
        }
    }

    /// <summary>
    /// New purchase order message to apply validation to
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERSCustomValidation : TSORDERS
    {
        /// <summary>
        /// New loop for LINE ITEM
        /// The new validation attribute is applied to this loop
        /// </summary>
        [LinLoopValidation]
        [DataMember]
        [ListCount(200000)]
        [Pos(21)]
        public new List<Loop_LIN_ORDERS> LINLoop { get; set; }
    }
}

