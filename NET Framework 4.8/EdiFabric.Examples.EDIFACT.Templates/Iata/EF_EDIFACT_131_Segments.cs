namespace EdiFabric.Templates.Iata131
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;

    [Serializable()]
    [Segment("ABI")]
    public class ABI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [Pos(1)]
        public virtual C337 SOURCETYPE_01 { get; set; }
        [Pos(2)]
        public virtual C300 ORIGINATORDETAILS_02 { get; set; }
        [Pos(3)]
        public virtual C328 LOCATION_03 { get; set; }
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string Country_04 { get; set; }
        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string CompanyIdentification_05 { get; set; }
    }

    [Serializable()]
    [Segment("ADD")]
    public class ADD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Pos(1)]
        public virtual C031 ACTIONDETAILS_01 { get; set; }
        [Required]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<C032> ADDRESSDETAILS_02 { get; set; }
    }

    [Serializable()]
    [Segment("APD")]
    public class APD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Pos(1)]
        public virtual C314 ADDITIONALPRODUCTDETAILS_01 { get; set; }
        [Pos(2)]
        public virtual C348 STATIONINFORMATION1_02 { get; set; }
        [Pos(3)]
        public virtual C348 STATIONINFORMATION2_03 { get; set; }
        [Pos(4)]
        public virtual C317 MILEAGETIMEDETAILS_04 { get; set; }
        [Pos(5)]
        public virtual C318 TRAVELLERTIMEDETAILS_05 { get; set; }
        [ListCount(10)]
        [Pos(6)]
        public virtual List<C320> PRODUCTFACILITIES_06 { get; set; }
    }

    [Serializable()]
    [Segment("DAT")]
    public class DAT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [ListCount(99)]
        [Pos(1)]
        public virtual List<C688> DATEANDTIMEDETAILS_01 { get; set; }
    }

    [Serializable()]
    [Segment("EBD")]
    public class EBD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Pos(1)]
        public virtual C674 EXCESSBAGGAGEDETAILS_01 { get; set; }
        [ListCount(3)]
        [Pos(2)]
        public virtual List<C675> BAGGAGEDETAILS_02 { get; set; }
        [ListCount(99)]
        [Pos(3)]
        public virtual List<C358> BAGTAGDETAILS_03 { get; set; }
    }

    [Serializable()]
    [Segment("EQN")]
    public class EQN
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [ListCount(9)]
        [Pos(1)]
        public virtual List<C523> NUMBEROFUNITDETAILS_01 { get; set; }
    }

    [Serializable()]
    [Segment("ERC")]
    public class ERC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Pos(1)]
        public virtual C901 APPLICATIONERRORDETAIL_01 { get; set; }
    }

    [Serializable()]
    [Segment("FAR")]
    public class FAR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("6353", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string NumberOfUnitsQualifier_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string Quantity_02 { get; set; }
        [Pos(3)]
        public virtual C662 FAREDETAILS_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string IdentityNumber_04 { get; set; }
        [Pos(5)]
        public virtual C644 FARETYPEGROUPINGINFORMATION_05 { get; set; }

        [ListCount(9)]
        [Pos(6)]
        public virtual List<CTAR> RateTariffClass_06 { get; set; }
    }

    [Serializable()]
    [Segment("FOP")]
    public class FOP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [ListCount(99)]
        [Pos(1)]
        public virtual List<C641> FORMOFPAYMENTDETAILS_01 { get; set; }
    }

    [Serializable()]
    [Segment("FTI")]
    public class FTI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [ListCount(9)]
        [Pos(1)]
        public virtual List<C326> FREQUENTTRAVELLERIDENTIFICATION_01 { get; set; }
    }

    [Serializable()]
    [Segment("IFT")]
    public class IFT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Pos(1)]
        public virtual C346 FREETEXTQUALIFICATION_01 { get; set; }
        [ListCount(99)]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual List<string> FreeText_02 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }

    [Serializable()]
    [Segment("LTS")]
    public class LTS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 9999)]
        [DataElement("9990", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TextStringDetails_01 { get; set; }
    }

    [Serializable()]
    [Segment("MON")]
    public class MON
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [ListCount(20)]
        [Pos(1)]
        public virtual List<C663> MONETARYINFORMATION_01 { get; set; }
    }

    [Serializable()]
    [Segment("MSG")]
    public class MSG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [Pos(1)]
        public virtual C302 MESSAGEFUNCTIONBUSINESSDETAILS_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("4343 ", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ResponseType_02 { get; set; }
    }

    [Serializable()]
    [Segment("ORG")]
    public class ORG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [Pos(1)]
        public virtual C336 SYSTEMDETAILS_01 { get; set; }
        [Pos(2)]
        public virtual C300 ORIGINATORIDENTIFICATIONDETAILS_02 { get; set; }
        [Pos(3)]
        public virtual C328 LOCATION_03 { get; set; }
        [Pos(4)]
        public virtual C336 SYSTEMDETAILS2_04 { get; set; }
        [StringLength(1, 1)]
        [DataElement("9972", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string OriginatorTypeCode_05 { get; set; }
        [Pos(6)]
        public virtual C354 ORIGINATORDETAILS_06 { get; set; }
        [StringLength(1, 9)]
        [DataElement("9904", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string OriginatorAuthorityRequestCode_07 { get; set; }
        [StringLength(1, 25)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string CommunicationNumber_08 { get; set; }
        [StringLength(1, 17)]
        [DataElement("3039", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string PartyIdIdentification_09 { get; set; }
    }

    [Serializable()]
    [Segment("PTK")]
    public class PTK
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Pos(1)]
        public virtual C664 PRICINGTICKETINGINFORMATION_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("5379", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PriceTariffType_02 { get; set; }
        [Pos(3)]
        public virtual C310 PRODUCTDATETIME_03 { get; set; }
        [Pos(4)]
        public virtual C306 COMPANYIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public virtual C665 COMPANYIDENTIFICATIONNUMBERS_05 { get; set; }
        [ListCount(2)]
        [Pos(6)]
        public virtual List<C666> LOCATIONDETAILS_06 { get; set; }
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string IdentityNumber_07 { get; set; }
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(8)]
        public virtual string MonetaryAmount_08 { get; set; }
    }

    [Serializable()]
    [Segment("RCI")]
    public class RCI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [ListCount(9)]
        [Pos(1)]
        public virtual List<C330> RESERVATIONCONTROLINFORMATION_01 { get; set; }
    }

    [Serializable()]
    [Segment("REF")]
    public class REF
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [ListCount(99)]
        [Pos(1)]
        public virtual List<C653> REFERENCINGDETAILS_01 { get; set; }
    }

    [Serializable()]
    [Segment("RPI")]
    public class RPI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string Quantity_01 { get; set; }
        [ListCount(10)]
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual List<string> Status_02 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }

    [Serializable()]
    [Segment("SAC")]
    public class SAC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string StatusIndicator_01 { get; set; }
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PlaceLocationIdentification_02 { get; set; }
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string Status_03 { get; set; }
    }

    [Serializable()]
    [Segment("SRC")]
    public class SRC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [ListCount(9)]
        [Pos(1)]
        public virtual List<C678> SEGMENTREPETITIONCONTROLDETAILS_01 { get; set; }
    }

    [Serializable()]
    [Segment("SSD")]
    public class SSD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Pos(1)]
        public virtual C679 SPECIFICSEATDETAILS_01 { get; set; }
        [StringLength(1, 1)]
        [DataElement("9807", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string NoSmokingIndicator_02 { get; set; }
        [Pos(3)]
        public virtual C680 SEATCHARACTERISTICDETAILS_03 { get; set; }
        [Pos(4)]
        public virtual C681 SEATRANGEDETAILS_04 { get; set; }
        [StringLength(1, 1)]
        [DataElement("9854", typeof(EDIFACT_A))]
        [Pos(5)]
        public virtual string CabinClassDesignator_05 { get; set; }
        [StringLength(1, 1)]
        [DataElement("9873", typeof(EDIFACT_N))]
        [Pos(6)]
        public virtual string CabinClassOfService_06 { get; set; }
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string PlaceLocationIdentification_07 { get; set; }
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string PlaceLocationIdentification2_08 { get; set; }
        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string ProcessingIndicator_09 { get; set; }
        [ListCount(99)]
        [Pos(10)]
        public virtual List<C683> SPECIFICSEATPURPOSE_10 { get; set; }
    }

    [Serializable()]
    [Segment("SSR")]
    public class SSR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [Pos(1)]
        public virtual C334 SPECIALREQUIREMENTTYPEDETAILS_01 { get; set; }

        [ListCount(999)]
        [Pos(2)]
        public virtual List<C332> SPECIALREQUIREMENTDATADETAILS_02 { get; set; }
    }

    [Serializable()]
    [Segment("TBD")]
    public class TBD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string Status_01 { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public virtual List<C675> BAGGAGEDETAILS_02 { get; set; }
        [Pos(3)]
        public virtual C686 BAGGAGEREFERENCEDETAILS_03 { get; set; }
        [ListCount(99)]
        [Pos(4)]
        public virtual List<C358> BAGTAGDETAILS_04 { get; set; }
    }

    [Serializable()]
    [Segment("TIF")]
    public class TIF
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Pos(1)]
        public virtual C322 TRAVELLERSURNAMEINFORMATION_01 { get; set; }
        [ListCount(99)]
        [Pos(2)]
        public virtual List<C324> TRAVELLERDETAILS_02 { get; set; }
    }

    [Serializable()]
    [Segment("TKT")]
    public class TKT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [Pos(1)]
        public virtual C667 TICKETNUMBERDETAILS_01 { get; set; }
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string Status_02 { get; set; }
    }

    [Serializable()]
    [Segment("TRA")]
    public class TRA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [Pos(1)]
        public virtual C306 COMPANYIDENTIFICATION_01 { get; set; }
        [Pos(2)]
        public virtual C308 PRODUCTIDENTIFICATIONDETAILS_02 { get; set; }
    }

    [Serializable()]
    [Segment("TRI")]
    public class TRI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Pos(1)]
        public virtual C670 REFERENCEQUALIFICATION_01 { get; set; }
        [ListCount(999)]
        [Pos(2)]
        public virtual List<C671> TRAVELLERIDENTIFICATION_02 { get; set; }
    }


    [Serializable()]
    [Segment("TVL")]
    public class TVL
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Pos(1)]
        public virtual C310 PRODUCTDATETIME_01 { get; set; }
        [Pos(2)]
        public virtual C328 LOCATION_02 { get; set; }
        [Pos(3)]
        public virtual C328 LOCATION2_03 { get; set; }
        [Pos(4)]
        public virtual C306 COMPANYIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public virtual C308 PRODUCTIDENTIFICATIONDETAILS_05 { get; set; }
        [Pos(6)]
        public virtual C309 PRODUCTTYPEDETAILS_06 { get; set; }
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(7)]
        public virtual string LineItemNumber_07 { get; set; }
        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string ProcessingIndicator_08 { get; set; }
        [ListCount(99)]
        [Pos(9)]
        public virtual List<C311> MARRIAGECONTROLDETAILS_09 { get; set; }
    }

    [Serializable()]
    [Segment("TXD")]
    public class TXD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("5305", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DutyTaxFeeCategory_01 { get; set; }
        [ListCount(99)]
        [Pos(2)]
        public virtual List<C668> TAXDETAILS_02 { get; set; }
    }


    /// <summary>
    // Accommodation Allocation Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAI")]
    public class AAI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // ACCOMMODATION ALLOCATION INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C997 C997_01 { get; set; }
        /// <summary>
        // ACCOMMODATION ALLOCATION INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(19)]
        [Pos(2)]
        public virtual List<C997> C997_02 { get; set; }
    }
    
    /// <summary>
    // Action Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ACT")]
    public class ACT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Action request / notification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(1)]
        public virtual string ActionRequestNotification_01 { get; set; }
        /// <summary>
        // COMPANY IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C306 C306_02 { get; set; }
        /// <summary>
        // PRODUCT IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C308 C308_03 { get; set; }
        /// <summary>
        // COMPANY IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C306 C306_04 { get; set; }
        /// <summary>
        // PRODUCT IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C308 C308_05 { get; set; }
        /// <summary>
        // REASON INFORMATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C369 C369_06 { get; set; }
    }
    
    /// <summary>
    // Action Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ADT")]
    public class ADT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // PROCESSING INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C672 C672_01 { get; set; }
        /// <summary>
        // REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<C673> C673_02 { get; set; }
    }
    
    /// <summary>
    // Allowance or Charge
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALC")]
    public class ALC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Allowance or charge qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public virtual string AllowanceOrChargeQualifier_01 { get; set; }
        /// <summary>
        // ALLOWANCE/CHARGE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C552 C552_02 { get; set; }
        /// <summary>
        // Settlement
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4471", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string Settlement_03 { get; set; }
        /// <summary>
        // Calculation sequence indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1227", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string CalculationSequenceIndicator_04 { get; set; }
        /// <summary>
        // SPECIAL SERVICES IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C214 C214_05 { get; set; }
    }
    
    /// <summary>
    // Service Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ASD")]
    public class ASD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // SERVICE DATE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C959 C959_01 { get; set; }
        /// <summary>
        // SERVICE DATE
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(2)]
        public virtual List<C959> C959_02 { get; set; }
    }
    
    /// <summary>
    // Additional Services Group
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ASG")]
    public class ASG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Item characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7081", typeof(EDIFACT_ID_7081))]
        [Pos(1)]
        public virtual string ItemCharacteristic_01 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(2)]
        public virtual string ItemDescriptionIdentification_02 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public virtual string CodeListQualifier_03 { get; set; }
        /// <summary>
        // Item description type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7077", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string ItemDescriptionType_04 { get; set; }
    }
    
    /// <summary>
    // Tour Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ATI")]
    public class ATI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // TOUR DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C993 C993_01 { get; set; }
        /// <summary>
        // STOPOVER INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<C994> C994_02 { get; set; }
    }
    
    /// <summary>
    // Attribute
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ATT")]
    public class ATT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Attribute function qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9017", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string AttributeFunctionQualifier_01 { get; set; }
        /// <summary>
        // ATTRIBUTE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C955 C955_02 { get; set; }
        /// <summary>
        // ATTRIBUTE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C956 C956_03 { get; set; }
    }
    
    /// <summary>
    // Baggage Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BAG")]
    public class BAG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // BAGGAGE STATUS DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C356 C356_01 { get; set; }
        /// <summary>
        // BAGTAG DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<C358> C358_02 { get; set; }
    }
    
    /// <summary>
    // Beginning of Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGM")]
    public class BGM
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C002 C002_01 { get; set; }
        /// <summary>
        // Document/message number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DocumentmessageNumber_02 { get; set; }
        /// <summary>
        // Message function
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public virtual string MessageFunction_03 { get; set; }
        /// <summary>
        // Response type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public virtual string ResponseType_04 { get; set; }
    }
    
    /// <summary>
    // Boarding Pass Supplemental Information Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BPS")]
    public class BPS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Local boarding time
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("2804", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string LocalBoardingTime_01 { get; set; }
        /// <summary>
        // STATION INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C348 C348_02 { get; set; }
        /// <summary>
        // STATION INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C348 C348_03 { get; set; }
        /// <summary>
        // Aircraft position
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("9853", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string AircraftPosition_04 { get; set; }
        /// <summary>
        // Bar code data
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("9855", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string BarCodeData_05 { get; set; }
        /// <summary>
        // Discounted/non-revenue passenger priority information
        /// </summary>
        [DataMember]
        [StringLength(1, 21)]
        [DataElement("9851", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string DiscountednonrevenuePassengerPriorityInformation_06 { get; set; }
        /// <summary>
        // FLIGHT SERVICE DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C042 C042_07 { get; set; }
        /// <summary>
        // Flight delay reason
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("9872", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string FlightDelayReason_08 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string FreeText_09 { get; set; }
    }
    
    /// <summary>
    // Bagtag Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BTI")]
    public class BTI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // BAG TAG DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C029 C029_01 { get; set; }
        /// <summary>
        // BAGTAG STUB INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<C693> C693_02 { get; set; }
    }
    
    /// <summary>
    // Commercial Agreements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CAR")]
    public class CAR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // COMPANY ROLE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C374 C374_01 { get; set; }
        /// <summary>
        // COMPANY ROLE IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(98)]
        [Pos(2)]
        public virtual List<C374> C374_02 { get; set; }
    }
    
    /// <summary>
    // Cabin Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CBD")]
    public class CBD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CABIN CLASS DESIGNATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C342 C342_01 { get; set; }
        /// <summary>
        // CABIN CLASS SEAT ROW RANGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C052 C052_02 { get; set; }
        /// <summary>
        // Cabin class location
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9863", typeof(EDIFACT_ID_9863))]
        [Pos(3)]
        public virtual string CabinClassLocation_03 { get; set; }
        /// <summary>
        // SMOKING AREA SEAT ROW RANGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C053 C053_04 { get; set; }
        /// <summary>
        // Seat occupation default indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9883", typeof(EDIFACT_ID_9883))]
        [Pos(5)]
        public virtual string SeatOccupationDefaultIndicator_05 { get; set; }
        /// <summary>
        // OVERWING SEAT ROW RANGE
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C058 C058_06 { get; set; }
        /// <summary>
        // CABIN WIDTH AND COLUMN DETAILS
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(7)]
        public virtual List<C054> C054_07 { get; set; }
    }
    
    /// <summary>
    // Cabin Facilities
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CBF")]
    public class CBF
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Row location qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9976", typeof(EDIFACT_ID_9976))]
        [Pos(1)]
        public virtual string RowLocationQualifier_01 { get; set; }
        /// <summary>
        // CABIN FACILITIES DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C340 C340_02 { get; set; }
        /// <summary>
        // CABIN FACILITIES DETAILS
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(3)]
        public virtual List<C340> C340_03 { get; set; }
    }
    
    /// <summary>
    // Corporate Fare Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CFI")]
    public class CFI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(1)]
        public virtual List<C981> C981_01 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C981 C981_02 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C981 C981_03 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C981 C981_04 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C981 C981_05 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C981 C981_06 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C981 C981_07 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C981 C981_08 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C981 C981_09 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C981 C981_10 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C981 C981_11 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual C981 C981_12 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual C981 C981_13 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual C981 C981_14 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual C981 C981_15 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual C981 C981_16 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual C981 C981_17 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual C981 C981_18 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual C981 C981_19 { get; set; }
        /// <summary>
        // CORPORATE FARE IDENTIFIERS
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual C981 C981_20 { get; set; }
    }
    
    /// <summary>
    // Cascading Host Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CHD")]
    public class CHD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // PLACE OF ORIGIN OF A REQUEST
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C059 C059_01 { get; set; }
        /// <summary>
        // OUTBOUND CARRIER DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C013 C013_02 { get; set; }
        /// <summary>
        // OUTBOUND FLIGHT NUMBER DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C014 C014_03 { get; set; }
        /// <summary>
        // Departure date and time
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("2281", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string DepartureDateAndTime_04 { get; set; }
        /// <summary>
        // Place of departure
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("3215", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PlaceOfDeparture_05 { get; set; }
        /// <summary>
        // Place of destination
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("3259", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string PlaceOfDestination_06 { get; set; }
        /// <summary>
        // Outbound flight continuation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9856", typeof(EDIFACT_ID_9856))]
        [Pos(7)]
        public virtual string OutboundFlightContinuationIndicator_07 { get; set; }
        /// <summary>
        // Maximum number of hosts allowed
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9802", typeof(EDIFACT_N))]
        [Pos(8)]
        public virtual string MaximumNumberOfHostsAllowed_08 { get; set; }
        /// <summary>
        // HOST DEFINITION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(9)]
        public virtual List<C696> C696_09 { get; set; }
    }
    
    /// <summary>
    // Clear/terminate Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CLT")]
    public class CLT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Action request / notification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(1)]
        public virtual string ActionRequestNotification_01 { get; set; }
        /// <summary>
        // Message function
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(2)]
        public virtual string MessageFunction_02 { get; set; }
        /// <summary>
        // Message function
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public virtual string MessageFunction_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FreeText_04 { get; set; }
    }
    
    /// <summary>
    // Commission Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CMN")]
    public class CMN
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // COMMISSION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C957 C957_01 { get; set; }
        /// <summary>
        // COMMISSION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(2)]
        public virtual List<C957> C957_02 { get; set; }
    }
    
    /// <summary>
    // Control Total
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNT")]
    public class CNT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CONTROL
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C270 C270_01 { get; set; }
    }
    
    /// <summary>
    // Connection Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CNX")]
    public class CNX
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CONNECTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C312 C312_01 { get; set; }
        /// <summary>
        // CONNECTION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C312 C312_02 { get; set; }
    }
    
    /// <summary>
    // Communications Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COM")]
    public class COM
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C076 C076_01 { get; set; }
    }
    
    /// <summary>
    // Coupon Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CPN")]
    public class CPN
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // COUPON INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(1)]
        public virtual List<C640> C640_01 { get; set; }
    }
    
    /// <summary>
    // Consignment Packing Sequence
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CPS")]
    public class CPS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Hierarchical ID number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 12)]
        [DataElement("7164", typeof(EDIFACT_ID_7164))]
        [Pos(1)]
        public virtual string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        // Hierarchical parent ID
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("7166", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string HierarchicalParentID_02 { get; set; }
        /// <summary>
        // Packaging level
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7075", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string PackagingLevel_03 { get; set; }
    }
    
    /// <summary>
    // Cancel Request Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRD")]
    public class CRD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Reason for cancel
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("9859", typeof(EDIFACT_ID_9859))]
        [Pos(1)]
        public virtual string ReasonForCancel_01 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string FreeText_02 { get; set; }
        /// <summary>
        // Type of cancel
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9860", typeof(EDIFACT_ID_9860))]
        [Pos(3)]
        public virtual string TypeOfCancel_03 { get; set; }
    }
    
    /// <summary>
    // Consumer Reference Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CRI")]
    public class CRI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CONSUMER REFERENCE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C967 C967_01 { get; set; }
        /// <summary>
        // CONSUMER REFERENCE IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(19)]
        [Pos(2)]
        public virtual List<C967> C967_02 { get; set; }
    }
    
    /// <summary>
    // Contact Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTA")]
    public class CTA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Contact function
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3139", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ContactFunction_01 { get; set; }
        /// <summary>
        // ERROR INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C056 C056_02 { get; set; }
    }
    
    /// <summary>
    // Currencies
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUX")]
    public class CUX
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C504 C504_01 { get; set; }
        /// <summary>
        // CURRENCY DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C504 C504_02 { get; set; }
        /// <summary>
        // Rate of exchange
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string RateOfExchange_03 { get; set; }
        /// <summary>
        // Currency market exchange
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6341", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string CurrencyMarketExchange_04 { get; set; }
    }
    
    /// <summary>
    // Conversion Rate
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CVR")]
    public class CVR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CONVERSION RATE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C661 C661_01 { get; set; }
        /// <summary>
        // CONVERSION RATE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(19)]
        [Pos(2)]
        public virtual List<C661> C661_02 { get; set; }
    }
    
    /// <summary>
    // Device Control Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DCD")]
    public class DCD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Company identification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_ID_9906))]
        [Pos(1)]
        public virtual string CompanyIdentification_01 { get; set; }
        /// <summary>
        // IDENTIFICATION NUMBER
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C206 C206_02 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(3)]
        public virtual string StatusIndicator_03 { get; set; }
        /// <summary>
        // Sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(4)]
        public virtual string SequenceNumber_04 { get; set; }
        /// <summary>
        // Material type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9997", typeof(EDIFACT_ID_9997))]
        [Pos(5)]
        public virtual string MaterialType_05 { get; set; }
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(6)]
        public virtual string DataIndicator_06 { get; set; }
    }
    
    /// <summary>
    // Document Information Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DID")]
    public class DID
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // DOCUMENT DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C350 C350_01 { get; set; }
        /// <summary>
        // PROCESSING DETAILS
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<C355> C355_02 { get; set; }
    }
    
    /// <summary>
    // Dimensions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DIM")]
    public class DIM
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Dimension qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("6145", typeof(EDIFACT_ID_6145))]
        [Pos(1)]
        public virtual string DimensionQualifier_01 { get; set; }
        /// <summary>
        // DIMENSIONS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C211 C211_02 { get; set; }
    }
    
    /// <summary>
    // Discount Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DIS")]
    public class DIS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // DISCOUNT INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C998 C998_01 { get; set; }
        /// <summary>
        // DISCOUNT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(19)]
        [Pos(2)]
        public virtual List<C998> C998_02 { get; set; }
    }
    
    /// <summary>
    // Default Message Characteristics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMC")]
    public class DMC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Confirmation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9813", typeof(EDIFACT_ID_9813))]
        [Pos(1)]
        public virtual string ConfirmationIndicator_01 { get; set; }
        /// <summary>
        // Weight unit code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("6801", typeof(EDIFACT_ID_6801))]
        [Pos(2)]
        public virtual string WeightUnitCode_02 { get; set; }
        /// <summary>
        // Maximum number of flights to be handled
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9815", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string MaximumNumberOfFlightsToBeHandled_03 { get; set; }
        /// <summary>
        // Number of units
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string NumberOfUnits_04 { get; set; }
    }
    
    /// <summary>
    // Document/Message Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DOC")]
    public class DOC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // DOCUMENT/MESSAGE NAME
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C002 C002_01 { get; set; }
        /// <summary>
        // DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C503 C503_02 { get; set; }
        /// <summary>
        // Communication channel identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public virtual string CommunicationChannelIdentifier_03 { get; set; }
        /// <summary>
        // Number of copies of document required
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string NumberOfCopiesOfDocumentRequired_04 { get; set; }
        /// <summary>
        // Number of originals of document required
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string NumberOfOriginalsOfDocumentRequired_05 { get; set; }
    }
    
    /// <summary>
    // Discount And Penalty Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DPI")]
    public class DPI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sector/subject identification qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7293", typeof(EDIFACT_ID_7293))]
        [Pos(1)]
        public virtual string SectorsubjectIdentificationQualifier_01 { get; set; }
        /// <summary>
        // DISCOUNT/PENALTY MONETARY INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<C649> C649_02 { get; set; }
    }
    
    /// <summary>
    // Date/Time Period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507 C507_01 { get; set; }
    }
    
    /// <summary>
    // Device Characteristics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DVC")]
    public class DVC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Availability of a boarding pass printer
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9817", typeof(EDIFACT_ID_9817))]
        [Pos(1)]
        public virtual string AvailabilityOfABoardingPassPrinter_01 { get; set; }
        /// <summary>
        // Limit for bag tag printing
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9818", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string LimitForBagTagPrinting_02 { get; set; }
    }
    
    /// <summary>
    // Device Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DVI")]
    public class DVI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string IdentityNumber_01 { get; set; }
        /// <summary>
        // Handling instructions
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4079", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string HandlingInstructions_02 { get; set; }
        /// <summary>
        // Cabin class designator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9854", typeof(EDIFACT_A))]
        [Pos(3)]
        public virtual string CabinClassDesignator_03 { get; set; }
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PlacelocationIdentification_04 { get; set; }
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PlacelocationIdentification_05 { get; set; }
    }
    
    /// <summary>
    // Equipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQD")]
    public class EQD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CONFIGURATION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(1)]
        public virtual List<C048> C048_01 { get; set; }
        /// <summary>
        // Equipment code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7800", typeof(EDIFACT_ID_7800))]
        [Pos(2)]
        public virtual string EquipmentCode_02 { get; set; }
        /// <summary>
        // Aircraft cabin version identification
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("9866", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string AircraftCabinVersionIdentification_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FreeText_04 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(5)]
        public virtual string CarrierIdentification_05 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string FreeText_06 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~8053", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string EQD07 { get; set; }
        [DataMember]
        [DataElement("~C237", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string EQD08 { get; set; }
        [DataMember]
        [DataElement("~C224", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string EQD09 { get; set; }
        [DataMember]
        [DataElement("~8077", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string EQD10 { get; set; }
        [DataMember]
        [DataElement("~8249", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string EQD11 { get; set; }
        [DataMember]
        [DataElement("~8169", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string EQD12 { get; set; }
    }
    
    /// <summary>
    // Equipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQD")]
    public class EQD_1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CONFIGURATION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(1)]
        public virtual List<C048> C048_01 { get; set; }
        /// <summary>
        // Equipment code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7800", typeof(EDIFACT_ID_7800))]
        [Pos(2)]
        public virtual string EquipmentCode_02 { get; set; }
        /// <summary>
        // Aircraft cabin version identification
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("9866", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string AircraftCabinVersionIdentification_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FreeText_04 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(5)]
        public virtual string CarrierIdentification_05 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string FreeText_06 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~8053", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string EQD07 { get; set; }
        [DataMember]
        [DataElement("~C237", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string EQD08 { get; set; }
        [DataMember]
        [DataElement("~C224", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string EQD09 { get; set; }
        [DataMember]
        [DataElement("~8077", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string EQD10 { get; set; }
        [DataMember]
        [DataElement("~8249", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string EQD11 { get; set; }
        [DataMember]
        [DataElement("~8169", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string EQD12 { get; set; }
    }
    
    /// <summary>
    // Equipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQD")]
    public class EQD_2
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CONFIGURATION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(1)]
        public virtual List<C048> C048_01 { get; set; }
        /// <summary>
        // Equipment code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7800", typeof(EDIFACT_ID_7800))]
        [Pos(2)]
        public virtual string EquipmentCode_02 { get; set; }
        /// <summary>
        // Aircraft cabin version identification
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("9866", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string AircraftCabinVersionIdentification_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FreeText_04 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(5)]
        public virtual string CarrierIdentification_05 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string FreeText_06 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~8053", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string EQD07 { get; set; }
        [DataMember]
        [DataElement("~C237", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string EQD08 { get; set; }
        [DataMember]
        [DataElement("~C224", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string EQD09 { get; set; }
        [DataMember]
        [DataElement("~8077", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string EQD10 { get; set; }
        [DataMember]
        [DataElement("~8249", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string EQD11 { get; set; }
        [DataMember]
        [DataElement("~8169", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string EQD12 { get; set; }
    }
    
    /// <summary>
    // Equipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQD")]
    public class EQD_3
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CONFIGURATION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(1)]
        public virtual List<C048> C048_01 { get; set; }
        /// <summary>
        // Equipment code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7800", typeof(EDIFACT_ID_7800))]
        [Pos(2)]
        public virtual string EquipmentCode_02 { get; set; }
        /// <summary>
        // Aircraft cabin version identification
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("9866", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string AircraftCabinVersionIdentification_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FreeText_04 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(5)]
        public virtual string CarrierIdentification_05 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string FreeText_06 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~8053", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string EQD07 { get; set; }
        [DataMember]
        [DataElement("~C237", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string EQD08 { get; set; }
        [DataMember]
        [DataElement("~C224", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string EQD09 { get; set; }
        [DataMember]
        [DataElement("~8077", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string EQD10 { get; set; }
        [DataMember]
        [DataElement("~8249", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string EQD11 { get; set; }
        [DataMember]
        [DataElement("~8169", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string EQD12 { get; set; }
    }
    
    /// <summary>
    // Equipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQI")]
    public class EQI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CONFIGURATION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(1)]
        public virtual List<C048> C048_01 { get; set; }
        /// <summary>
        // Type of means of transport identification
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string TypeOfMeansOfTransportIdentification_02 { get; set; }
        /// <summary>
        // ADDITIONAL EQUIPMENT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C361 C361_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FreeText_04 { get; set; }
    }
    
    /// <summary>
    // Equipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQP")]
    public class EQP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C220 C220_01 { get; set; }
        /// <summary>
        // EQUIPMENT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C360 C360_02 { get; set; }
        /// <summary>
        // COMPANY IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C306 C306_03 { get; set; }
    }
    
    /// <summary>
    // Equipment/service Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EQS")]
    public class EQS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // EQUIPMENT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C359 C359_01 { get; set; }
        /// <summary>
        // EQUIPMENT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C359 C359_02 { get; set; }
        /// <summary>
        // NUMBER OF UNIT DETAILS
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<C523> C523_03 { get; set; }
    }
    
    /// <summary>
    // Error Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ERD")]
    public class ERD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // ERROR INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C056 C056_01 { get; set; }
        /// <summary>
        // ERROR INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<C056> C056_02 { get; set; }
    }
    
    /// <summary>
    // Fare Calculation Code Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FCC")]
    public class FCC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Charge category
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5237", typeof(EDIFACT_ID_5237))]
        [Pos(1)]
        public virtual string ChargeCategory_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string PlacelocationIdentification_03 { get; set; }
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PlacelocationIdentification_04 { get; set; }
        /// <summary>
        // Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string Percentage_05 { get; set; }
    }
    
    /// <summary>
    // Fare Component Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FCI")]
    public class FCI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // FARE DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C980 C980_01 { get; set; }
        /// <summary>
        // Document/message number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DocumentmessageNumber_02 { get; set; }
    }
    
    /// <summary>
    // Flight Details Query
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FDQ")]
    public class FDQ
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // OUTBOUND CARRIER DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C013 C013_01 { get; set; }
        /// <summary>
        // OUTBOUND FLIGHT NUMBER DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C014 C014_02 { get; set; }
        /// <summary>
        // Departure date and time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("2281", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string DepartureDateAndTime_03 { get; set; }
        /// <summary>
        // Place of departure
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 5)]
        [DataElement("3215", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PlaceOfDeparture_04 { get; set; }
        /// <summary>
        // Place of destination
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 5)]
        [DataElement("3259", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PlaceOfDestination_05 { get; set; }
        /// <summary>
        // Outbound flight continuation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9856", typeof(EDIFACT_ID_9856))]
        [Pos(6)]
        public virtual string OutboundFlightContinuationIndicator_06 { get; set; }
        /// <summary>
        // INBOUND CARRIER DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C015 C015_07 { get; set; }
        /// <summary>
        // INBOUND FLIGHT NUMBER DETAILS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C016 C016_08 { get; set; }
        /// <summary>
        // Departure date and time
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("2281", typeof(EDIFACT_N))]
        [Pos(9)]
        public virtual string DepartureDateAndTime_09 { get; set; }
        /// <summary>
        // Arrival date and time
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("2107", typeof(EDIFACT_N))]
        [Pos(10)]
        public virtual string ArrivalDateAndTime_10 { get; set; }
        /// <summary>
        // Place of departure
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("3215", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string PlaceOfDeparture_11 { get; set; }
        /// <summary>
        // Place of destination
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("3259", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string PlaceOfDestination_12 { get; set; }
        /// <summary>
        // Terminal of arrival
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("3803", typeof(EDIFACT_AN))]
        [Pos(13)]
        public virtual string TerminalOfArrival_13 { get; set; }
        /// <summary>
        // Inbound type of service indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9857", typeof(EDIFACT_ID_9857))]
        [Pos(14)]
        public virtual string InboundTypeOfServiceIndicator_14 { get; set; }
        /// <summary>
        // PRODUCT DATE/TIME
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(15)]
        public virtual List<C310> C310_15 { get; set; }
    }
    
    /// <summary>
    // Flight Details Response
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FDR")]
    public class FDR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // OUTBOUND CARRIER DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C013 C013_01 { get; set; }
        /// <summary>
        // OUTBOUND FLIGHT NUMBER DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C014 C014_02 { get; set; }
        /// <summary>
        // Departure date and time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("2281", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string DepartureDateAndTime_03 { get; set; }
        /// <summary>
        // Place of departure
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 5)]
        [DataElement("3215", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PlaceOfDeparture_04 { get; set; }
        /// <summary>
        // Place of destination
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 5)]
        [DataElement("3259", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PlaceOfDestination_05 { get; set; }
        /// <summary>
        // Arrival date and time
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("2107", typeof(EDIFACT_N))]
        [Pos(6)]
        public virtual string ArrivalDateAndTime_06 { get; set; }
        /// <summary>
        // Outbound flight continuation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9856", typeof(EDIFACT_ID_9856))]
        [Pos(7)]
        public virtual string OutboundFlightContinuationIndicator_07 { get; set; }
        /// <summary>
        // Inbound type of service indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9857", typeof(EDIFACT_ID_9857))]
        [Pos(8)]
        public virtual string InboundTypeOfServiceIndicator_08 { get; set; }
        /// <summary>
        // COMPLEXING FLIGHT DETAILS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C041 C041_09 { get; set; }
        /// <summary>
        // PRODUCT DATE/TIME
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(10)]
        public virtual List<C310> C310_10 { get; set; }
    }
    
    /// <summary>
    // Financial Institution Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FII")]
    public class FII
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Party qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public virtual string PartyQualifier_01 { get; set; }
        /// <summary>
        // ACCOUNT HOLDER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C078 C078_02 { get; set; }
        /// <summary>
        // INSTITUTION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C088 C088_03 { get; set; }
        /// <summary>
        // Country
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public virtual string Country_04 { get; set; }
    }
    
    /// <summary>
    // Fare Qualifier Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FQU")]
    public class FQU
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Movement type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8335", typeof(EDIFACT_ID_8335))]
        [Pos(1)]
        public virtual string MovementType_01 { get; set; }
        /// <summary>
        // FARE CATEGORY CODES
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C647 C647_02 { get; set; }
        /// <summary>
        // FARE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C662 C662_03 { get; set; }
        /// <summary>
        // ADDITIONAL FARE QUALIFIER DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C646 C646_04 { get; set; }
        /// <summary>
        // DISCOUNT/PENALTY INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<C648> C648_05 { get; set; }
    }
    
    /// <summary>
    // Fare Route Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FRI")]
    public class FRI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Days of operation
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("9928", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DaysOfOperation_01 { get; set; }
        /// <summary>
        // FARE QUALIFIER INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C645 C645_02 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string IdentityNumber_03 { get; set; }
        /// <summary>
        // VALID DATE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C651 C651_04 { get; set; }
    }
    
    /// <summary>
    // Fare Rules Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FRU")]
    public class FRU
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Rate/tariff class identification
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5243", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string RatetariffClassIdentification_01 { get; set; }
        /// <summary>
        // COMPANY IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C306 C306_02 { get; set; }
        /// <summary>
        // Rule part identification
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [StringLength(1, 7)]
        [DataElement("7175", typeof(EDIFACT_ID_7175))]
        [Pos(3)]
        public virtual List<string> RulePartIdentification_03 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Flight Segment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FSD")]
    public class FSD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Local boarding time
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("2804", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string LocalBoardingTime_01 { get; set; }
        /// <summary>
        // Terminal of departure
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("3801", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string TerminalOfDeparture_02 { get; set; }
        /// <summary>
        // Gate description
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("9870", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string GateDescription_03 { get; set; }
        /// <summary>
        // Aircraft position
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("9853", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string AircraftPosition_04 { get; set; }
        /// <summary>
        // FLIGHT SERVICE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C042 C042_05 { get; set; }
        /// <summary>
        // Flight delay reason
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("9872", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string FlightDelayReason_06 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string FreeText_07 { get; set; }
        /// <summary>
        // Processing status code
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [StringLength(1, 1)]
        [DataElement("9869", typeof(EDIFACT_ID_9869))]
        [Pos(8)]
        public virtual List<string> ProcessingStatusCode_08 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Frequent Traveller Verification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTV")]
    public class FTV
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Action request / notification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(1)]
        public virtual string ActionRequestNotification_01 { get; set; }
        /// <summary>
        // Membership level
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7456", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string MembershipLevel_02 { get; set; }
        /// <summary>
        // COMPANY IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C306 C306_03 { get; set; }
        /// <summary>
        // PRODUCT/ACCOUNT DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual C650 C650_04 { get; set; }
        /// <summary>
        // PRODUCT/ACCOUNT DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C650 C650_05 { get; set; }
        /// <summary>
        // VALID DATE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C651 C651_06 { get; set; }
        /// <summary>
        // ACCOUNT HOLDER INFORMATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C652 C652_07 { get; set; }
    }
    
    /// <summary>
    // Free Text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FTX")]
    public class FTX
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Text subject qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public virtual string TextSubjectQualifier_01 { get; set; }
        /// <summary>
        // Text function
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4453", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string TextFunction_02 { get; set; }
        /// <summary>
        // TEXT REFERENCE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C107 C107_03 { get; set; }
        /// <summary>
        // TEXT LITERAL
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C108 C108_04 { get; set; }
        /// <summary>
        // Language
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(5)]
        public virtual string Language_05 { get; set; }
    }
    
    /// <summary>
    // Header Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HDR")]
    public class HDR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Status
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(1)]
        public virtual string Status_01 { get; set; }
        /// <summary>
        // DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C507 C507_02 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ReferenceNumber_03 { get; set; }
        /// <summary>
        // Date/Time/Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DateTimePeriod_04 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string FreeText_05 { get; set; }
        /// <summary>
        // Product identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [StringLength(1, 35)]
        [DataElement("9908", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual List<string> ProductIdentification_06 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Identification Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IDD")]
    public class IDD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // MULTIPLE IDENTIFICATION NUMBERS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C669 C669_01 { get; set; }
        /// <summary>
        // DATE AND TIME DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C688 C688_02 { get; set; }
        /// <summary>
        // DATE AND TIME DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C688 C688_03 { get; set; }
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PlacelocationIdentification_04 { get; set; }
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PlacelocationIdentification_05 { get; set; }
    }
    
    /// <summary>
    // Item Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IMD")]
    public class IMD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Item description type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7077", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ItemDescriptionType_01 { get; set; }
        /// <summary>
        // Item characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7081", typeof(EDIFACT_ID_7081))]
        [Pos(2)]
        public virtual string ItemCharacteristic_02 { get; set; }
        /// <summary>
        // ITEM DESCRIPTION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C273 C273_03 { get; set; }
        /// <summary>
        // Surface/layer indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public virtual string SurfacelayerIndicator_04 { get; set; }
    }
    
    /// <summary>
    // Item Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ITM")]
    public class ITM
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C212 C212_01 { get; set; }
        /// <summary>
        // ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(98)]
        [Pos(2)]
        public virtual List<C212> C212_02 { get; set; }
    }
    
    /// <summary>
    // Load Details Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LDI")]
    public class LDI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CARGO DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C352 C352_01 { get; set; }
        /// <summary>
        // LOAD DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C353 C353_02 { get; set; }
    }
    
    /// <summary>
    // Line Item
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LIN")]
    public class LIN
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Line item number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string LineItemNumber_01 { get; set; }
        /// <summary>
        // Action request / notification
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public virtual string ActionRequestNotification_02 { get; set; }
        /// <summary>
        // ITEM NUMBER IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C212 C212_03 { get; set; }
        /// <summary>
        // SUB-LINE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C829 C829_04 { get; set; }
        /// <summary>
        // Configuration level
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string ConfigurationLevel_05 { get; set; }
        /// <summary>
        // Configuration
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7083", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string Configuration_06 { get; set; }
    }
    
    /// <summary>
    // Place/Location Definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOC")]
    public class LOC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Place/location qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public virtual string PlacelocationQualifier_01 { get; set; }
        /// <summary>
        // LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C517 C517_02 { get; set; }
        /// <summary>
        // RELATED LOCATION ONE IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C519 C519_03 { get; set; }
        /// <summary>
        // RELATED LOCATION TWO IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C553 C553_04 { get; set; }
        /// <summary>
        // Relation
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(5)]
        public virtual string Relation_05 { get; set; }
    }
    
    /// <summary>
    // Location/originator Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LOR")]
    public class LOR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // PLACE OF ORIGIN OF A REQUEST
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C059 C059_01 { get; set; }
        /// <summary>
        // REQUESTOR IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C012 C012_02 { get; set; }
    }
    
    /// <summary>
    // Message/application/product Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MAP")]
    public class MAP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // INSTRUCTION INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C654 C654_01 { get; set; }
        /// <summary>
        // Company identification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_ID_9906))]
        [Pos(2)]
        public virtual string CompanyIdentification_02 { get; set; }
        /// <summary>
        // MESSAGE/APPLICATION/PRODUCT INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<C655> C655_03 { get; set; }
    }
    
    /// <summary>
    // Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Measurement application qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public virtual string MeasurementApplicationQualifier_01 { get; set; }
        /// <summary>
        // MEASUREMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C502 C502_02 { get; set; }
        /// <summary>
        // VALUE/RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C174 C174_03 { get; set; }
        /// <summary>
        // Surface/layer indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public virtual string SurfacelayerIndicator_04 { get; set; }
    }
    
    /// <summary>
    // Monetary Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MOA")]
    public class MOA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C516 C516_01 { get; set; }
    }
    
    /// <summary>
    // Message Processing Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MPD")]
    public class MPD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // MESSAGE CONDITIONS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C676 C676_01 { get; set; }
        /// <summary>
        // MESSAGE EQUIPMENT DETAILS
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<C677> C677_02 { get; set; }
    }
    
    /// <summary>
    // Name And Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAD")]
    public class NAD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Party qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public virtual string PartyQualifier_01 { get; set; }
        /// <summary>
        // PARTY IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C082 C082_02 { get; set; }
        /// <summary>
        // OVERWING SEAT ROW RANGE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C058_3 C058_03 { get; set; }
        /// <summary>
        // PARTY NAME
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C080 C080_04 { get; set; }
        /// <summary>
        // PLACE OF ORIGIN OF A REQUEST
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C059_3 C059_05 { get; set; }
        /// <summary>
        // City name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string CityName_06 { get; set; }
        /// <summary>
        // Country sub-entity identification
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string CountrySubentityIdentification_07 { get; set; }
        /// <summary>
        // Postcode identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string PostcodeIdentification_08 { get; set; }
        /// <summary>
        // Country
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(9)]
        public virtual string Country_09 { get; set; }
    }
    
    /// <summary>
    // Nationality
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NAT")]
    public class NAT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Nationality code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("3493", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string NationalityCodeQualifier_01 { get; set; }
        /// <summary>
        // FLIGHT SERVICE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C042_3 C042_02 { get; set; }
    }
    
    /// <summary>
    // Origin And Destination Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ODI")]
    public class ODI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual List<string> PlacelocationIdentification_01 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // Port Of Call Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OPS")]
    public class OPS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // ON-TIME PERFORMANCE
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C368 C368_01 { get; set; }
        /// <summary>
        // PORT OF CALL DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C370 C370_02 { get; set; }
        /// <summary>
        // COMPANY IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C306 C306_03 { get; set; }
        /// <summary>
        // PRODUCT IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C308 C308_04 { get; set; }
    }
    
    /// <summary>
    // Payment Instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAI")]
    public class PAI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // PAYMENT INSTRUCTION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C534 C534_01 { get; set; }
    }
    
    /// <summary>
    // Passenger Api Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAP")]
    public class PAP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // PASSENGER API DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C060 C060_01 { get; set; }
        /// <summary>
        // PASSENGER CONTACT DATA
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C701 C701_02 { get; set; }
        /// <summary>
        // DOCUMENT ID
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<C700> C700_03 { get; set; }
    }
    
    /// <summary>
    // Payment Terms Basis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAT")]
    public class PAT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Payment terms type qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("4279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PaymentTermsTypeQualifier_01 { get; set; }
        /// <summary>
        // PAYMENT TERMS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C110 C110_02 { get; set; }
        /// <summary>
        // TERMS/TIME INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C112 C112_03 { get; set; }
    }
    
    /// <summary>
    // Advanced Passenger Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAX")]
    public class PAX
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // PASSENGER API DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C060 C060_01 { get; set; }
        /// <summary>
        // DOCUMENT ID
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<C700> C700_02 { get; set; }
    }
    
    /// <summary>
    // Passenger Baggage Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PBD")]
    public class PBD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CHECKED BAGGAGE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C027 C027_01 { get; set; }
        /// <summary>
        // HAND BAGGAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C028 C028_02 { get; set; }
        /// <summary>
        // BAGGAGE REFERENCE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C686 C686_03 { get; set; }
        /// <summary>
        // BAG TAG DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<C029> C029_04 { get; set; }
    }
    
    /// <summary>
    // Passenger Connecting Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCD")]
    public class PCD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // OUTBOUND CARRIER DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C013 C013_01 { get; set; }
        /// <summary>
        // OUTBOUND FLIGHT NUMBER DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C014 C014_02 { get; set; }
        /// <summary>
        // Departure date and time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("2281", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string DepartureDateAndTime_03 { get; set; }
        /// <summary>
        // Place of destination
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 5)]
        [DataElement("3259", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PlaceOfDestination_04 { get; set; }
        /// <summary>
        // Place of departure
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("3215", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PlaceOfDeparture_05 { get; set; }
        /// <summary>
        // Reservation booking designator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9800", typeof(EDIFACT_ID_9800))]
        [Pos(6)]
        public virtual string ReservationBookingDesignator_06 { get; set; }
        /// <summary>
        // Reservation status
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("9822", typeof(EDIFACT_ID_9822))]
        [Pos(7)]
        public virtual string ReservationStatus_07 { get; set; }
        /// <summary>
        // Arrival date and time
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("2107", typeof(EDIFACT_N))]
        [Pos(8)]
        public virtual string ArrivalDateAndTime_08 { get; set; }
    }
    
    /// <summary>
    // Product Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PDI")]
    public class PDI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Product details qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9970", typeof(EDIFACT_ID_9970))]
        [Pos(1)]
        public virtual string ProductDetailsQualifier_01 { get; set; }
        /// <summary>
        // PRODUCT DETAILS
        /// </summary>
        [DataMember]
        [ListCount(26)]
        [Pos(2)]
        public virtual List<C304> C304_02 { get; set; }
    }
    
    /// <summary>
    // Date/time/period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER")]
    public class PER
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // DATE/TIME/PERIOD
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C507 C507_01 { get; set; }
        /// <summary>
        // Frequency value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 9)]
        [DataElement("6072", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string FrequencyValue_02 { get; set; }
        /// <summary>
        // Frequency qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6071", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FrequencyQualifier_03 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(4)]
        public virtual string StatusIndicator_04 { get; set; }
    }
    
    /// <summary>
    // Passenger Flight Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PFD")]
    public class PFD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // SEAT DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C043 C043_01 { get; set; }
        /// <summary>
        // SEAT DEFINITION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C044 C044_02 { get; set; }
        /// <summary>
        // BOARDING SECURITY CODE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C045 C045_03 { get; set; }
        /// <summary>
        // Issue/reissue boarding pass indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9850", typeof(EDIFACT_ID_9850))]
        [Pos(4)]
        public virtual string IssuereissueBoardingPassIndicator_04 { get; set; }
        /// <summary>
        // Bar code data
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("9855", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string BarCodeData_05 { get; set; }
        /// <summary>
        // Discounted/non-revenue passenger priority information
        /// </summary>
        [DataMember]
        [StringLength(1, 21)]
        [DataElement("9851", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string DiscountednonrevenuePassengerPriorityInformation_06 { get; set; }
        /// <summary>
        // SEAT DETAILS
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(7)]
        public virtual List<C043> C043_07 { get; set; }
        /// <summary>
        // SEAT DEFINITION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(8)]
        public virtual List<C044> C044_08 { get; set; }
    }
    
    /// <summary>
    // Payment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PMT")]
    public class PMT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // PAYMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C977 C977_01 { get; set; }
        /// <summary>
        // CREDIT CARD INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<C978> C978_02 { get; set; }
    }
    
    /// <summary>
    // Point of Commencement Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("POC")]
    public class POC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PlacelocationIdentification_01 { get; set; }
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string FirstDate_02 { get; set; }
        /// <summary>
        // First time
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9918", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string FirstTime_03 { get; set; }
    }
    
    /// <summary>
    // Passenger Personal Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PPD")]
    public class PPD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Surname
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 64)]
        [DataElement("3808", typeof(EDIFACT_A))]
        [Pos(1)]
        public virtual string Surname_01 { get; set; }
        /// <summary>
        // PASSENGER TYPE DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual C017 C017_02 { get; set; }
        /// <summary>
        // PAX ID DETAILS IN RESPONDING SYSTEM
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C692 C692_03 { get; set; }
        /// <summary>
        // Given name
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("3809", typeof(EDIFACT_A))]
        [Pos(4)]
        public virtual string GivenName_04 { get; set; }
        /// <summary>
        // INFANT NAME DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C018 C018_05 { get; set; }
        /// <summary>
        // PAX ID DETAILS IN QUERYING SYSTEM
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C690 C690_06 { get; set; }
        /// <summary>
        // SURNAME CONNECTOR DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C021 C021_07 { get; set; }
        /// <summary>
        // Complexing passenger indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9867", typeof(EDIFACT_ID_9867))]
        [Pos(8)]
        public virtual string ComplexingPassengerIndicator_08 { get; set; }
        /// <summary>
        // Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6803", typeof(EDIFACT_N))]
        [Pos(9)]
        public virtual string Weight_09 { get; set; }
        /// <summary>
        // PAX ID DETAILS IN THIRD PARTY SYSTEM
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual C691 C691_10 { get; set; }
    }
    
    /// <summary>
    // Passenger Reservation Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRD")]
    public class PRD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CLASS DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C023 C023_01 { get; set; }
        /// <summary>
        // Reservation status
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("9822", typeof(EDIFACT_ID_9822))]
        [Pos(2)]
        public virtual string ReservationStatus_02 { get; set; }
        /// <summary>
        // PASSENGER PARTY REFERENCE DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C020 C020_03 { get; set; }
        /// <summary>
        // Passenger name record locator
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("9823", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PassengerNameRecordLocator_04 { get; set; }
        /// <summary>
        // Passenger name record locator
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("9823", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PassengerNameRecordLocator_05 { get; set; }
        /// <summary>
        // PNR ON BOOKING SYSTEM DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C022 C022_06 { get; set; }
        /// <summary>
        // Ticket number
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("9811", typeof(EDIFACT_N))]
        [Pos(7)]
        public virtual string TicketNumber_07 { get; set; }
    }
    
    /// <summary>
    // Price Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRI")]
    public class PRI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // PRICE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C509 C509_01 { get; set; }
        /// <summary>
        // Sub-line price change
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5213", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string SublinePriceChange_02 { get; set; }
    }
    
    /// <summary>
    // Terminal/time Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRT")]
    public class PRT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C517 C517_01 { get; set; }
        /// <summary>
        // TIME INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C362 C362_02 { get; set; }
        /// <summary>
        // TIME INFORMATION
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C362 C362_03 { get; set; }
        /// <summary>
        // TERMINAL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<C366> C366_04 { get; set; }
    }
    
    /// <summary>
    // Passenger Seat Request Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PSD")]
    public class PSD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // GENERIC SEAT REQUEST DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C024 C024_01 { get; set; }
        /// <summary>
        // Specific seat
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9809", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string SpecificSeat_02 { get; set; }
        /// <summary>
        // SEAT RANGE REQUEST DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C025 C025_03 { get; set; }
        /// <summary>
        // SEAT ADJUSTMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C026 C026_04 { get; set; }
    }
    
    /// <summary>
    // Passenger Service Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PSI")]
    public class PSI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Other service information (OSI)
        /// </summary>
        [DataMember]
        [StringLength(1, 250)]
        [DataElement("9838", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string OtherServiceInformation_01 { get; set; }
        /// <summary>
        // SSR DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<C030> C030_02 { get; set; }
    }
    
    /// <summary>
    // Pricing/Ticketing Subsequent
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PTS")]
    public class PTS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Item number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ItemNumber_01 { get; set; }
        /// <summary>
        // RATE/TARIFF CLASS INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C643 C643_02 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string MonetaryAmount_03 { get; set; }
        /// <summary>
        // Price type qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public virtual string PriceTypeQualifier_04 { get; set; }
        /// <summary>
        // Special condition
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public virtual string SpecialCondition_05 { get; set; }
        /// <summary>
        // Special condition
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public virtual string SpecialCondition_06 { get; set; }
        /// <summary>
        // Special condition
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public virtual string SpecialCondition_07 { get; set; }
        /// <summary>
        // Duty/tax/fee category
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [StringLength(1, 3)]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(8)]
        public virtual List<string> DutytaxfeeCategory_08 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // RATE/TARIFF CLASS INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(9)]
        public virtual List<C643> C643_09 { get; set; }
    }
    
    /// <summary>
    // Quantity and Action Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QAD")]
    public class QAD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Action request / notification
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(1)]
        public virtual string ActionRequestNotification_01 { get; set; }
        /// <summary>
        // QUANTITY AND ACTION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C657 C657_02 { get; set; }
        /// <summary>
        // QUANTITY AND ACTION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(98)]
        [Pos(3)]
        public virtual List<C657> C657_03 { get; set; }
    }
    
    /// <summary>
    // Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C186 C186_01 { get; set; }
        /// <summary>
        // QUANTITY DETAILS
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(2)]
        public virtual List<C186> C186_02 { get; set; }
    }
    
    /// <summary>
    // Queue Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QUE")]
    public class QUE
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // QUEUE INFORMATION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(1)]
        public virtual List<C986> C986_01 { get; set; }
    }
    
    /// <summary>
    // Response Analysis Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RAD")]
    public class RAD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Response type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9868", typeof(EDIFACT_ID_9868))]
        [Pos(1)]
        public virtual string ResponseType_01 { get; set; }
        /// <summary>
        // Processing status code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9869", typeof(EDIFACT_ID_9869))]
        [Pos(2)]
        public virtual string ProcessingStatusCode_02 { get; set; }
    }
    
    /// <summary>
    // Requirements and Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RCS")]
    public class RCS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sector/subject identification qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7293", typeof(EDIFACT_ID_7293))]
        [Pos(1)]
        public virtual string SectorsubjectIdentificationQualifier_01 { get; set; }
        /// <summary>
        // REQUIREMENT/CONDITION IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C550 C550_02 { get; set; }
        /// <summary>
        // Action request / notification
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public virtual string ActionRequestNotification_03 { get; set; }
    }
    
    /// <summary>
    // Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RFF")]
    public class RFF
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // REFERENCE
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C506 C506_01 { get; set; }
    }
    
    /// <summary>
    // Range Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RNG")]
    public class RNG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Range type qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6167", typeof(EDIFACT_ID_6167))]
        [Pos(1)]
        public virtual string RangeTypeQualifier_01 { get; set; }
        /// <summary>
        // RANGE
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<C280> C280_02 { get; set; }
    }
    
    /// <summary>
    // Row Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ROD")]
    public class ROD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Seat row number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9830", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string SeatRowNumber_01 { get; set; }
        /// <summary>
        // ROW CHARACTERISTICS DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C049 C049_02 { get; set; }
        /// <summary>
        // SEAT OCCUPATION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(3)]
        public virtual List<C051> C051_03 { get; set; }
    }
    
    /// <summary>
    // Routing Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RTG")]
    public class RTG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // PRODUCT LOCATION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(1)]
        public virtual List<C316> C316_01 { get; set; }
    }
    
    /// <summary>
    // Selection Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SDT")]
    public class SDT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // SELECTION DETAILS INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C660 C660_01 { get; set; }
        /// <summary>
        // SELECTION DETAILS INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(98)]
        [Pos(2)]
        public virtual List<C660> C660_02 { get; set; }
    }
    
    /// <summary>
    // Additional Service Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SER")]
    public class SER
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // PRODUCT FACILITIES
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(1)]
        public virtual List<C320> C320_01 { get; set; }
    }
    
    /// <summary>
    // Special Load Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SLD")]
    public class SLD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Handling instructions
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4079", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string HandlingInstructions_01 { get; set; }
        /// <summary>
        // QUANTITY INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C351 C351_02 { get; set; }
        /// <summary>
        // Document/message number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string DocumentmessageNumber_03 { get; set; }
        /// <summary>
        // UNDG number
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("7124", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string UNDGNumber_04 { get; set; }
        /// <summary>
        // Business description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4022", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string BusinessDescription_05 { get; set; }
        /// <summary>
        // Packing group
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8339", typeof(EDIFACT_ID_8339))]
        [Pos(6)]
        public virtual string PackingGroup_06 { get; set; }
        /// <summary>
        // HAZARD IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C235 C235_07 { get; set; }
        /// <summary>
        // HAZARD CODE
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C205 C205_08 { get; set; }
    }
    
    /// <summary>
    // Select Personal Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SPD")]
    public class SPD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // PASSENGER SELECTION DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C046 C046_01 { get; set; }
        /// <summary>
        // SEAT DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C043 C043_02 { get; set; }
        /// <summary>
        // PAX ID DETAILS IN RESPONDING SYSTEM
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C692 C692_03 { get; set; }
        /// <summary>
        // PAX ID DETAILS IN QUERYING SYSTEM
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C690 C690_04 { get; set; }
        /// <summary>
        // BOARDING SECURITY CODE DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C045 C045_05 { get; set; }
        /// <summary>
        // Passenger name record locator
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("9823", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string PassengerNameRecordLocator_06 { get; set; }
        /// <summary>
        // Passenger name record locator
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("9823", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string PassengerNameRecordLocator_07 { get; set; }
        /// <summary>
        // PNR ON BOOKING SYSTEM DETAILS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C022 C022_08 { get; set; }
        /// <summary>
        // BAG TAG SELECTION DETAILS
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C057 C057_09 { get; set; }
        /// <summary>
        // Ticket number
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("9811", typeof(EDIFACT_N))]
        [Pos(10)]
        public virtual string TicketNumber_10 { get; set; }
        /// <summary>
        // PAX ID DETAILS IN THIRD PARTY SYSTEM
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual C691 C691_11 { get; set; }
    }
    
    /// <summary>
    // Specific Data Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SPI")]
    public class SPI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // DATA TYPE INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C658 C658_01 { get; set; }
        /// <summary>
        // DATA INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<C659> C659_02 { get; set; }
    }
    
    /// <summary>
    // Sub Queue Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SQU")]
    public class SQU
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // SUB QUEUE INFORMATION DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(1)]
        public virtual List<C988> C988_01 { get; set; }
        /// <summary>
        // SUB QUEUE INFORMATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C988 C988_02 { get; set; }
        /// <summary>
        // SUB QUEUE INFORMATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C988 C988_03 { get; set; }
        /// <summary>
        // SUB QUEUE INFORMATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C988 C988_04 { get; set; }
        /// <summary>
        // SUB QUEUE INFORMATION DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C988 C988_05 { get; set; }
    }
    
    /// <summary>
    // Seat Request Parameters
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SRP")]
    public class SRP
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // GENERIC DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C344 C344_01 { get; set; }
        /// <summary>
        // RANGE OF ROWS DETAILS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C047 C047_02 { get; set; }
        /// <summary>
        // Processing indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_ID_7365))]
        [Pos(3)]
        public virtual string ProcessingIndicator_03 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string ReferenceNumber_04 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string FreeText_05 { get; set; }
    }
    
    /// <summary>
    // Specific Traveller Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STD")]
    public class STD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // SPECIFIC TRAVELLER DETAILS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(1)]
        public virtual List<C684> C684_01 { get; set; }
    }
    
    /// <summary>
    // Status Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STX")]
    public class STX
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // STATUS DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual C656 C656_01 { get; set; }
        /// <summary>
        // STATUS DETAILS
        /// </summary>
        [DataMember]
        [ListCount(98)]
        [Pos(2)]
        public virtual List<C656> C656_02 { get; set; }
    }
    
    /// <summary>
    // Ticketing Agent Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAI")]
    public class TAI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Company identification number
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("9996", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string CompanyIdentificationNumber_01 { get; set; }
        /// <summary>
        // INTERNAL IDENTIFICATION DETAILS
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<C642> C642_02 { get; set; }
    }
    
    /// <summary>
    // Duty/Tax/Fee Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Duty/tax/fee function qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("5283", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DutytaxfeeFunctionQualifier_01 { get; set; }
        /// <summary>
        // DUTY/TAX/FEE TYPE
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C241 C241_02 { get; set; }
        /// <summary>
        // DUTY/TAX/FEE ACCOUNT DETAIL
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C533 C533_03 { get; set; }
        /// <summary>
        // Duty/tax/fee assessment basis
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DutytaxfeeAssessmentBasis_04 { get; set; }
        /// <summary>
        // DUTY/TAX/FEE DETAIL
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C243 C243_05 { get; set; }
        /// <summary>
        // Duty/tax/fee category
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public virtual string DutytaxfeeCategory_06 { get; set; }
        /// <summary>
        // Party tax identification number
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string PartyTaxIdentificationNumber_07 { get; set; }
    }
    
    /// <summary>
    // Traveller Booking Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TBI")]
    public class TBI
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // CLASS INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C687 C687_01 { get; set; }
        /// <summary>
        // RESERVATION CONTROL INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<C330> C330_02 { get; set; }
        /// <summary>
        // Alpha reference identification
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9752", typeof(EDIFACT_A))]
        [Pos(3)]
        public virtual string AlphaReferenceIdentification_03 { get; set; }
        /// <summary>
        // Numeric reference identification
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9753", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string NumericReferenceIdentification_04 { get; set; }
    }
    
    /// <summary>
    // Details of Transport
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDT")]
    public class TDT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Transport stage qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public virtual string TransportStageQualifier_01 { get; set; }
        /// <summary>
        // Conveyance reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ConveyanceReferenceNumber_02 { get; set; }
        /// <summary>
        // MODE OF TRANSPORT
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C220 C220_03 { get; set; }
        /// <summary>
        // TRANSPORT MEANS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C228 C228_04 { get; set; }
        /// <summary>
        // CARRIER
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C040 C040_05 { get; set; }
        /// <summary>
        // Transit direction
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8101", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string TransitDirection_06 { get; set; }
        /// <summary>
        // EXCESS TRANSPORTATION INFORMATION
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual C401 C401_07 { get; set; }
        /// <summary>
        // TRANSPORT IDENTIFICATION
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual C222 C222_08 { get; set; }
        /// <summary>
        // Transport ownership
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8281", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string TransportOwnership_09 { get; set; }
    }
    
    /// <summary>
    // Tariff Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TFF")]
    public class TFF
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // TARIFF INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual C982 C982_01 { get; set; }
        /// <summary>
        // RATE INFORMATION
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual C983 C983_02 { get; set; }
        /// <summary>
        // ASSOCIATED CHARGES INFORMATION
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<C984> C984_03 { get; set; }
    }
    
    /// <summary>
    // TRAVEL ITINERARY INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TII")]
    public class TII
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Item number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ItemNumber_01 { get; set; }
        /// <summary>
        // Numeric reference identification
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9753", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string NumericReferenceIdentification_02 { get; set; }
        /// <summary>
        // PRODUCT DATE/TIME
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C310 C310_03 { get; set; }
        /// <summary>
        // Movement type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8335", typeof(EDIFACT_ID_8335))]
        [Pos(4)]
        public virtual string MovementType_04 { get; set; }
        /// <summary>
        // Cabin compartment designator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9992", typeof(EDIFACT_A))]
        [Pos(5)]
        public virtual string CabinCompartmentDesignator_05 { get; set; }
        /// <summary>
        // PRODUCT TYPE DETAILS
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual C309 C309_06 { get; set; }
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual List<string> PlacelocationIdentification_07 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }
    
    /// <summary>
    // TRAVELLER PRIORITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TPD")]
    public class TPD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Company identification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_ID_9906))]
        [Pos(1)]
        public virtual string CompanyIdentification_01 { get; set; }
        /// <summary>
        // Rate/tariff class identification
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5243", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string RatetariffClassIdentification_02 { get; set; }
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FirstDate_03 { get; set; }
        /// <summary>
        // Traveler reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("9944", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string TravelerReferenceNumber_04 { get; set; }
        /// <summary>
        // TRAVELLER INDICATORS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C689 C689_05 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(6)]
        public virtual string CharacteristicIdentification_06 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string FreeText_07 { get; set; }
    }
}
