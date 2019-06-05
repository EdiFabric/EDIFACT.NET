namespace EdiFabric.Templates.EdifactD96A.PartnerC
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using System.Xml.Serialization;
    using EdiFabric.Templates.EdifactD96A.PartnerB;

    /// <summary>
    /// Purchase order message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERSPartnerC : TSORDERS
    {        
        /// <summary>
        /// PAYMENT INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public new PAI PAI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(35)]
        [Pos(4)]
        public new List<DTM> DTM { get; set; }
    }

    /// <summary>
    /// PAYMENT INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAIPartnerC : PAI
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public new C534PartnerC PAYMENTINSTRUCTIONDETAILS_01 { get; set; }

        //  Add extra field
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(2)]
        public string ExtraField_02 { get; set; }
    }

    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534PartnerC : C534
    {
        //  Change the validation attribute and data element type at position 3
        [StringLength(1, 5)]
        [DataElement("4444", typeof(EDIFACT_AN))]
        [Pos(3)]
        public new string Paymentmeanscoded_03 { get; set; }       
    }
}
