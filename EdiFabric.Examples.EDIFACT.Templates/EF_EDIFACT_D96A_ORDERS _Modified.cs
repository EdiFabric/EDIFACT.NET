using System;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;

namespace EdiFabric.Templates.EdifactD96A
{
    /// <summary>
    /// Modified Purchase Order
    /// The changes are:
    /// 1. Modified BGM segment
    /// </summary>
    [Serializable()]
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERSModified : TSORDERS
    {
        /// <summary>
        /// Modified BGM Segment
        /// </summary>
        [Required]
        [Pos(2)]
        public new BGMModified BGM { get; set; }       
    }

    /// <summary>
    /// Modified BGM
    /// The changes are:
    /// 1. Pos 2 - data element is changed from Optional to Mandatory
    /// 2. Pos 4 - data element code set is changed from EDIFACT_ID_4343 to EDIFACT_ID_4343_Modified
    /// 3. An extra data element is added at position 5
    /// </summary>
    [Serializable()]
    [Segment("BGM")]
    public class BGMModified : BGM
    {
        /// <summary>
        /// Modified Document/message number - set to madatory
        /// </summary>
        [Required]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(2)]
        public new string Documentmessagenumber_02 { get; set; }

        /// <summary>
        /// Modified Response type - new data element code set
        /// </summary>
        [DataElement("4343", typeof(EDIFACT_ID_4343_Modified))]
        [Pos(4)]
        public new string Responsetypecoded_04 { get; set; }

        /// <summary>
        /// Extra element
        /// </summary>
        [DataElement("Extra", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string ExtraElement_05 { get; set; }
    }

    /// <summary>
    /// Modified Response type, coded
    /// </summary>
    [Serializable()]
    [EdiCodes(",NEWCODE1,NEWCODE2,")]
    public class EDIFACT_ID_4343_Modified
    {
    }
}
