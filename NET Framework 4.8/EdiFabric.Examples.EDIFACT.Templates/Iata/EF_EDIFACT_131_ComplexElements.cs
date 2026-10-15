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
    [Composite("Our own tariff class")]
    public class CTAR
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string RateTariffClass_06 { get; set; }
    }

    [Serializable()]
    [Composite("C337")]
    public class C337
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [ListCount(2)]
        [StringLength(1, 3)]
        [DataElement("7293", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual List<string> SectorSubjectIdentificationQualifier_01 
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
    [Composite("C300")]
    public class C300
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 9)]
        [DataElement("9900", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string TravelAgentIdentificationDetails_01 { get; set; }

        [StringLength(1, 9)]
        [DataElement("9902", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string InhouseIdentification_02 { get; set; }

        [StringLength(1, 9)]
        [DataElement("9902", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string InhouseIdentification2_03 { get; set; }

        [StringLength(1, 9)]
        [DataElement("9902", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string InhouseIdentification3_04 { get; set; }
    }

    [Serializable()]
    [Composite("C328")]
    public class C328
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PlaceLocationIdentification_01 { get; set; }

        [StringLength(1, 17)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PlaceLocationName_02 { get; set; }
    }

    [Serializable()]
    [Composite("C031")]
    public class C031
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 1)]
        [DataElement("9858", typeof(EDIFACT_A))]
        [Pos(1)]
        public virtual string UpdateActionCode_01 { get; set; }

        [ListCount(9)]
        [StringLength(1, 3)]
        [DataElement("1229", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual List<string> ActionRequestNotification_02 
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
    [Composite("C032")]
    public class C032
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("3299", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string AddressPurposeCode_01 { get; set; }

        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string StreetAndNumber_02 { get; set; }

        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string City_03 { get; set; }

        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string CountrySubEntityIdentification_04 { get; set; }

        [StringLength(1, 35)]
        [DataElement("3228", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string CountrySubEntityName_05 { get; set; }

        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string Country_06 { get; set; }

        [StringLength(1, 17)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string PostCodeIdentification_07 { get; set; }

        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string FreeText_08 { get; set; }

        [StringLength(1, 17)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string PlaceLocation_09 { get; set; }
    }

    [Serializable()]
    [Composite("C314")]
    public class C314
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 8)]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TypeOfMeansOfTransport_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("9924", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string NumberOfStops_02 { get; set; }

        [StringLength(1, 6)]
        [DataElement("9926", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string LegDuration_03 { get; set; }

        [StringLength(1, 8)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string Percentage_04 { get; set; }

        [StringLength(1, 7)]
        [DataElement("9928", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string DaysOfOperation_05 { get; set; }

        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string DateTimePeriod_06 { get; set; }

        [StringLength(1, 1)]
        [DataElement("9950", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string ComplexingFlightIndicator_07 { get; set; }

        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string PlaceLocationIdentification_08 { get; set; }

        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string PlaceLocationIdentification2_09 { get; set; }

        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string PlaceLocationIdentification3_10 { get; set; }
    }

    [Serializable()]
    [Composite("C348")]
    public class C348
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 6)]
        [DataElement("9870", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string GateDescription_01 { get; set; }

        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string RelatedPlaceLocationOneID_02 { get; set; }

        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string RelatedPlaceLocationTwoID_03 { get; set; }
    }

    [Serializable()]
    [Composite("C317")]
    public class C317
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string MeasurementValue_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string MeasureUnitQualifier_02 { get; set; }

        [StringLength(1, 4)]
        [DataElement("9918", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string FirstTime_03 { get; set; }
    }

    [Serializable()]
    [Composite("C318")]
    public class C318
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 4)]
        [DataElement("9918", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string FirstTime_01 { get; set; }

        [StringLength(1, 4)]
        [DataElement("9922", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string SecondTime_02 { get; set; }

        [StringLength(1, 10)]
        [DataElement("9952", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string CheckInDetails_03 { get; set; }
    }

    [Serializable()]
    [Composite("C320")]
    public class C320
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("9932", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string FacilityType_01 { get; set; }

        [StringLength(1, 70)]
        [DataElement("9934", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string FacilityDescription_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("9970", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ProductDetailsQualifier_03 { get; set; }

        [ListCount(17)]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual List<string> CharacteristicIdentification_04 
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
    [Composite("C688")]
    public class C688
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("2005", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DateTimePeriodQualifier_01 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string FirstDate_02 { get; set; }

        [StringLength(1, 4)]
        [DataElement("9918", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string FirstTime_03 { get; set; }

        [StringLength(1, 3)]
        [DataElement("2005", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DateTimePeriodQualifier2_04 { get; set; }

        [StringLength(1, 4)]
        [DataElement("9918", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string FirstTime2_05 { get; set; }

        [StringLength(1, 3)]
        [DataElement("8335", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string MovementType_06 { get; set; }

        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string PlaceLocationIdentification_07 { get; set; }
    }

    [Serializable()]
    [Composite("C674")]
    public class C674
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string Currency_01 { get; set; }

        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string MonetaryAmount_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ProcessingIndicator_03 { get; set; }
    }

    [Serializable()]
    [Composite("C675")]
    public class C675
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string Quantity_01 { get; set; }

        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string MeasurementValue_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5463", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string AllowanceOrChargeQualifier_03 { get; set; }

        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string MeasureUnitQualifier_04 { get; set; }

        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string ProcessingIndicator_05 { get; set; }
    }

    [Serializable()]
    [Composite("C358")]
    public class C358
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string CompanyIdentification_01 { get; set; }

        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ItemNumber_02 { get; set; }

        [StringLength(1, 15)]
        [DataElement("7240", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string TotalNumberOfItems_03 { get; set; }

        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PlaceLocationIdentification_04 { get; set; }

        [StringLength(1, 15)]
        [DataElement("9996", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string CompanyIdentificationNumber_05 { get; set; }

        [StringLength(1, 2)]
        [DataElement("9988", typeof(EDIFACT_N))]
        [Pos(6)]
        public virtual string DataIndicator_06 { get; set; }

        [StringLength(1, 3)]
        [DataElement("7081", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string ItemCharacteristic_07 { get; set; }

        [StringLength(1, 4)]
        [DataElement("9962", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string SpecialRequirementType_08 { get; set; }

        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(9)]
        public virtual string MeasurementValue_09 { get; set; }

        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string MeasureUnitQualifier_10 { get; set; }

        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string FreeText_11 { get; set; }
    }

    [Serializable()]
    [Composite("C523")]
    public class C523
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 15)]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string NumberOfUnits_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("6353", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string NumberOfUnitsQualifier_02 { get; set; }
    }

    [Serializable()]
    [Composite("C901")]
    public class C901
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("9321", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ApplicationError_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }

    [Serializable()]
    [Composite("C662")]
    public class C662
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("6353", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string NumberOfUnitsQualifier_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string Percentage_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string Country_03 { get; set; }

        [StringLength(1, 3)]
        [DataElement("9878", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FareClassificationType_04 { get; set; }
    }

    [Serializable()]
    [Composite("C644")]
    public class C644
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [ListCount(5)]
        [StringLength(1, 35)]
        [DataElement("5388", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PricingGroup_01 { get; set; }
    }

    [Serializable()]
    [Composite("C641")]
    public class C641
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 10)]
        [DataElement("9888", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string FormOfPaymentIdentification_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DataIndicator_02 { get; set; }

        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string MonetaryAmount_03 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string CompanyIdentification_04 { get; set; }

        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string ReferenceNumber_05 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_N))]
        [Pos(6)]
        public virtual string FirstDate_06 { get; set; }

        [StringLength(1, 17)]
        [DataElement("9889", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string ApprovalIdentification_07 { get; set; }

        [StringLength(1, 3)]
        [DataElement("9890", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string Source_08 { get; set; }

        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(9)]
        public virtual string MonetaryAmount2_09 { get; set; }

        [StringLength(1, 3)]
        [DataElement("9891", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string Verification_10 { get; set; }

        [StringLength(1, 70)]
        [DataElement("3194 ", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string AccountHolderNumber_11 { get; set; }

        [StringLength(1, 3)]
        [DataElement("2475 ", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string PaymentTimeReference_12 { get; set; }

        [StringLength(1, 70)]
        [DataElement("4440 ", typeof(EDIFACT_AN))]
        [Pos(13)]
        public virtual string FreeText_13 { get; set; }

        [StringLength(1, 3)]
        [DataElement("7453 ", typeof(EDIFACT_AN))]
        [Pos(14)]
        public virtual string MembershipStatus_14 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9892", typeof(EDIFACT_AN))]
        [Pos(15)]
        public virtual string TransactionInformation_15 { get; set; }
    }

    [Serializable()]
    [Composite("C326")]
    public class C326
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("9906 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string CompanyIdentification_01 { get; set; }

        [Required]
        [StringLength(1, 25)]
        [DataElement("9948", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string FrequentTravellerIdentification_02 { get; set; }

        [StringLength(1, 10)]
        [DataElement("9944 ", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string TravellerReferenceNumber_03 { get; set; }

        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string Status_04 { get; set; }

        [StringLength(1, 35)]
        [DataElement("7456", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string MembershipLevel_05 { get; set; }

        [StringLength(1, 12)]
        [DataElement("7164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string HierarchicalIDNumber_06 { get; set; }

        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string ItemDescription_07 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string CompanyIdentification2_08 { get; set; }

        [StringLength(1, 4)]
        [DataElement("9949 ", typeof(EDIFACT_N))]
        [Pos(9)]
        public virtual string PassengerPriorityValue_09 { get; set; }
    }

    [Serializable()]
    [Composite("C346")]
    public class C346
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 3)]
        [DataElement("4451", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TextSubjectQualifier_01 { get; set; }

        [Required]
        [StringLength(1, 4)]
        [DataElement("9980", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string InformationType_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("4405 ", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string Status_03 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string CompanyIdentification_04 { get; set; }

        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string Language_05 { get; set; }
    }

    [Serializable()]
    [Composite("C663")]
    public class C663
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 3)]
        [DataElement("5025", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string MonetaryAmountTypeQualifier_01 { get; set; }

        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string AllowanceOrChargeNumber_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string Currency_03 { get; set; }

        [ListCount(2)]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual List<string> PlaceLocationIdentification_04 
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
    [Composite("C302")]
    public class C302
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("4025", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string BusinessFunction_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("1225", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string MessageFunction_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }

        [ListCount(20)]
        [StringLength(1, 3)]
        [DataElement("1225", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual List<string> MessageFunction2_04 
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
    [Composite("C336")]
    public class C336
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string CompanyIdentification_01 { get; set; }

        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PlaceLocationIdentification_02 { get; set; }

        [StringLength(1, 17)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string PlaceLocationName_03 { get; set; }
    }

    [Serializable()]
    [Composite("C354")]
    public class C354
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string Country_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string Currency_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string Language_03 { get; set; }
    }

    [Serializable()]
    [Composite("C664")]
    public class C664
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PriceTypeQualifier_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PriceTypeQualifier2_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string PriceTypeQualifier3_03 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PriceTypeQualifier4_04 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PriceTypeQualifier5_05 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string PriceTypeQualifier6_06 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string PriceTypeQualifier7_07 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string PriceTypeQualifier8_08 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string PriceTypeQualifier9_09 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string PriceTypeQualifier10_10 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string PriceTypeQualifier11_11 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string PriceTypeQualifier12_12 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(13)]
        public virtual string PriceTypeQualifier13_13 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(14)]
        public virtual string PriceTypeQualifier14_14 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(15)]
        public virtual string PriceTypeQualifier15_15 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(16)]
        public virtual string PriceTypeQualifier16_16 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(17)]
        public virtual string PriceTypeQualifier17_17 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(18)]
        public virtual string PriceTypeQualifier18_18 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(19)]
        public virtual string PriceTypeQualifier19_19 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_AN))]
        [Pos(20)]
        public virtual string PriceTypeQualifier20_20 { get; set; }
    }

    [Serializable()]
    [Composite("C310")]
    public class C310
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string FirstDate_01 { get; set; }

        [StringLength(1, 4)]
        [DataElement("9918", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string FirstTime_02 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9920", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string SecondDate_03 { get; set; }

        [StringLength(1, 4)]
        [DataElement("9922", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string SecondTime_04 { get; set; }

        [StringLength(1, 1)]
        [DataElement("9954", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string DateVariation_05 { get; set; }
    }

    [Serializable()]
    [Composite("C306")]
    public class C306
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string CompanyIdentification_01 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string CompanyIdentification2_02 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string CompanyIdentification3_03 { get; set; }
    }

    [Serializable()]
    [Composite("C665")]
    public class C665
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("9996", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string CompanyIdentificationNumber_01 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string CompanyIdentificationNumber2_02 { get; set; }
    }

    [Serializable()]
    [Composite("C666")]
    public class C666
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PlaceLocationIdentification_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string Country_02 { get; set; }
    }

    [Serializable()]
    [Composite("C330")]
    public class C330
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string CompanyIdentification_01 { get; set; }

        [StringLength(1, 20)]
        [DataElement("9956", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ReservationControlNumber_02 { get; set; }

        [StringLength(1, 1)]
        [DataElement("9958", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ReservationControlType_03 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FirstDate_04 { get; set; }

        [StringLength(1, 9)]
        [DataElement("9994", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string Time_05 { get; set; }
    }

    [Serializable()]
    [Composite("C653")]
    public class C653
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("1153", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ReferenceQualifier_01 { get; set; }

        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ReferenceNumber_02 { get; set; }
    }

    [Serializable()]
    [Composite("C678")]
    public class C678
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string Quantity_01 { get; set; }

        [StringLength(1, 15)]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string NumberOfUnits_02 { get; set; }

        [StringLength(1, 15)]
        [DataElement("7240", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string TotalNumberOfItems_03 { get; set; }
    }

    [Serializable()]
    [Composite("C679")]
    public class C679
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [ListCount(99)]
        [StringLength(1, 4)]
        [DataElement("9809", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual List<string> SpecificSeat_01 
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
    [Composite("C680")]
    public class C680
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [ListCount(99)]
        [StringLength(1, 2)]
        [DataElement("9825", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual List<string> SeatCharacteristics_01 
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
    [Composite("C681")]
    public class C681
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 3)]
        [DataElement("9830", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string SeatRowNumber_01 { get; set; }

        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string RangeMaximum_02 { get; set; }

        [ListCount(20)]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual List<string> SeatColumn_03 
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
    [Composite("C682")]
    public class C682
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [ListCount(2)]
        [StringLength(1, 5)]
        [DataElement("9751", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual List<string> SecurityIdentification_01 
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
    [Composite("C683")]
    public class C683
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 3)]
        [DataElement("7081", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ItemCharacteristic_01 { get; set; }

        [StringLength(1, 4)]
        [DataElement("9809", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string SpecificSeat_02 { get; set; }
    }

    [Serializable()]
    [Composite("C334")]
    public class C334
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [Required]
        [StringLength(1, 4)]
        [DataElement("9962 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string SpecialRequirementType_01 { get; set; }

        [Required]
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string Status_02 { get; set; }

        [StringLength(1, 15)]
        [DataElement("6060 ", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string Quantity_03 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string CompanyIdentification_04 { get; set; }

        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string ProcessingIndicator_05 { get; set; }

        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string ProcessingIndicator2_06 { get; set; }

        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string ItemDescription_07 { get; set; }

        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string PlaceLocationIdentification_08 { get; set; }

        [StringLength(1, 25)]
        [DataElement("3225 ", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string PlaceLocationIdentification2_09 { get; set; }

        [ListCount(99)]
        [StringLength(1, 70)]
        [DataElement("4440 ", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual List<string> FreeText_10 
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
    [Composite("C332")]
    public class C332
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 4)]
        [DataElement("9960 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string SpecialRequirementData_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string MeasureUnitQualifier_02 { get; set; }

        [StringLength(1, 10)]
        [DataElement("9944 ", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string TravellerReferenceNumber_03 { get; set; }

        [ListCount(5)]
        [StringLength(1, 2)]
        [DataElement("9825", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual List<string> SeatCharacteristic_04 
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
    [Composite("C686")]
    public class C686
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("7365 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ProcessingIndicator_01 { get; set; }

        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string IdentifyNumber_02 { get; set; }
    }

    [Serializable()]
    [Composite("C322")]
    public class C322
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 70)]
        [DataElement("9936 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TravellerSurname_01 { get; set; }

        [Required]
        [StringLength(1, 3)]
        [DataElement("6353", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string NumberOfUnitsQualifier_02 { get; set; }

        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string Quantity_03 { get; set; }

        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string Status_04 { get; set; }
    }

    [Serializable()]
    [Composite("C324")]
    public class C324
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 70)]
        [DataElement("9942 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TravellerGivenName_01 { get; set; }

        [Required]
        [StringLength(1, 3)]
        [DataElement("6353", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string NumberOfUnitsQualifier_02 { get; set; }

        [StringLength(1, 10)]
        [DataElement("9944", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string TravellerReferenceNumber_03 { get; set; }

        [StringLength(1, 1)]
        [DataElement("9946", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string TravellerAccompaniedByInfantIndicator_04 { get; set; }

        [StringLength(1, 70)]
        [DataElement("9754", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string OtherNames1_05 { get; set; }

        [StringLength(1, 70)]
        [DataElement("9754", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string OtherNames2_06 { get; set; }
    }

    [Serializable()]
    [Composite("C667")]
    public class C667
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 35)]
        [DataElement("1004 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DocumentMessageNumber_01 { get; set; }

        [Required]
        [StringLength(1, 3)]
        [DataElement("1001", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DocumentMessageName_02 { get; set; }

        [StringLength(1, 15)]
        [DataElement("7240", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string TotalNumberOfItems_03 { get; set; }

        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DataIndicator_04 { get; set; }

        [StringLength(1, 3)]
        [DataElement("1229", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string ActionRequestNotification_05 { get; set; }

        [StringLength(1, 35)]
        [DataElement("1004 ", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string DocumentMessageNumber2_06 { get; set; }
    }

    [Serializable()]
    [Composite("C308")]
    public class C308
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 35)]
        [DataElement("9908 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ProductionIdentification_01 { get; set; }

        [Required]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string CharacteristicIdentification_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("9914", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ProductIdentificationCharacteristic_03 { get; set; }

        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string ItemDescriptionIdentification_04 { get; set; }
    }

    [Serializable()]
    [Composite("C670")]
    public class C670
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("7405 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string IdentityNumberQualifier_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("1153", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ReferenceQualifier_02 { get; set; }
    }

    [Serializable()]
    [Composite("C671")]
    public class C671
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 35)]
        [DataElement("1154 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ReferenceNumber_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("1153", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ReferenceQualifier_02 { get; set; }

        [StringLength(1, 4)]
        [DataElement("9809", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string SpecificSeat_03 { get; set; }

        [StringLength(1, 10)]
        [DataElement("9944", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string TravellerReferenceNumber_04 { get; set; }
    }

    [Serializable()]
    [Composite("C309")]
    public class C309
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [ListCount(9)]
        [StringLength(1, 6)]
        [DataElement("1050 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual List<string> SequenceNumber_01 
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
    [Composite("C311")]
    public class C311
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 3)]
        [DataElement("5479 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string Relation_01 { get; set; }

        [StringLength(1, 10)]
        [DataElement("9995", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string GroupNumber_02 { get; set; }

        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string LineItemNumber_03 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5479 ", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string Relation2_04 { get; set; }

        [StringLength(1, 35)]
        [DataElement("9906 ", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string CompanyIdentification_05 { get; set; }
    }

    [Serializable()]
    [Composite("C668")]
    public class C668
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        [StringLength(1, 17)]
        [DataElement("5278 ", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DutyTaxFeeRate_01 { get; set; }

        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string Country_02 { get; set; }

        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string Currency_03 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5153 ", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DutyTaxFeeType_04 { get; set; }

        [StringLength(1, 17)]
        [DataElement("5278 ", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string DutyTaxFeeRate2_05 { get; set; }

        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string Currency2_06 { get; set; }

        [StringLength(1, 3)]
        [DataElement("5153 ", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string DutyTaxFeeType2_07 { get; set; }

        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string MonetaryAmount_08 { get; set; }

        [ListCount(2)]
        [StringLength(1, 3)]
        [DataElement("5007", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual List<string> MonetaryFunction_09 
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
    // DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Document/message name
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(1)]
        public virtual string DocumentmessageName_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Document/message name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DocumentmessageName_04 { get; set; }
    }
    
    /// <summary>
    // REQUESTOR IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C012")]
    public class C012
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Requestor identification
        /// </summary>
        [DataMember]
        [StringLength(1, 34)]
        [DataElement("3806", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string RequestorIdentification_01 { get; set; }
        /// <summary>
        // Identification code set designator
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9879", typeof(EDIFACT_ID_9879))]
        [Pos(2)]
        public virtual string IdentificationCodeSetDesignator_02 { get; set; }
        /// <summary>
        // Office identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("9880", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string OfficeIdentification_03 { get; set; }
        /// <summary>
        // Requestor authority code
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9881", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string RequestorAuthorityCode_04 { get; set; }
    }
    
    /// <summary>
    // OUTBOUND CARRIER DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C013")]
    public class C013
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public virtual string CarrierIdentification_01 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(2)]
        public virtual string CarrierIdentification_02 { get; set; }
    }
    
    /// <summary>
    // OUTBOUND FLIGHT NUMBER DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C014")]
    public class C014
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Flight number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("3802", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string FlightNumber_01 { get; set; }
        /// <summary>
        // Operational suffix to the carrier code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9801", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string OperationalSuffixToTheCarrierCode_02 { get; set; }
    }
    
    /// <summary>
    // INBOUND CARRIER DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C015")]
    public class C015
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public virtual string CarrierIdentification_01 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(2)]
        public virtual string CarrierIdentification_02 { get; set; }
    }
    
    /// <summary>
    // INBOUND FLIGHT NUMBER DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C016")]
    public class C016
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Flight number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("3802", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string FlightNumber_01 { get; set; }
        /// <summary>
        // Operational suffix to the carrier code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9801", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string OperationalSuffixToTheCarrierCode_02 { get; set; }
    }
    
    /// <summary>
    // PASSENGER TYPE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C017")]
    public class C017
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Passenger type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9819", typeof(EDIFACT_ID_9819))]
        [Pos(1)]
        public virtual string PassengerType_01 { get; set; }
        /// <summary>
        // Passenger with infant indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9884", typeof(EDIFACT_ID_9884))]
        [Pos(2)]
        public virtual string PassengerWithInfantIndicator_02 { get; set; }
    }
    
    /// <summary>
    // INFANT NAME DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C018")]
    public class C018
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Surname
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("3808", typeof(EDIFACT_A))]
        [Pos(1)]
        public virtual string Surname_01 { get; set; }
        /// <summary>
        // Given name
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("3809", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string GivenName_02 { get; set; }
    }
    
    /// <summary>
    // PASSENGER PARTY REFERENCE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C020")]
    public class C020
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Alpha party reference
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("9826", typeof(EDIFACT_A))]
        [Pos(1)]
        public virtual string AlphaPartyReference_01 { get; set; }
        /// <summary>
        // Numeric party reference
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9827", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string NumericPartyReference_02 { get; set; }
    }
    
    /// <summary>
    // SURNAME CONNECTOR DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C021")]
    public class C021
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Surname/family name connector
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("9828", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string SurnamefamilyNameConnector_01 { get; set; }
        /// <summary>
        // Passenger number within a surname/family name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("9829", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string PassengerNumberWithinASurnamefamilyName_02 { get; set; }
    }
    
    /// <summary>
    // PNR ON BOOKING SYSTEM DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C022")]
    public class C022
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public virtual string CarrierIdentification_01 { get; set; }
        /// <summary>
        // Passenger name record locator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 9)]
        [DataElement("9823", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PassengerNameRecordLocator_02 { get; set; }
    }
    
    /// <summary>
    // CLASS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C023")]
    public class C023
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Reservation booking designator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9800", typeof(EDIFACT_ID_9800))]
        [Pos(1)]
        public virtual string ReservationBookingDesignator_01 { get; set; }
        /// <summary>
        // Cabin class of service
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9873", typeof(EDIFACT_ID_9873))]
        [Pos(2)]
        public virtual string CabinClassOfService_02 { get; set; }
    }
    
    /// <summary>
    // GENERIC SEAT REQUEST DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C024")]
    public class C024
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // No smoking indicator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9807", typeof(EDIFACT_ID_9807))]
        [Pos(1)]
        public virtual string NoSmokingIndicator_01 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(2)]
        public virtual string SeatCharacteristic_02 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(3)]
        public virtual string SeatCharacteristic_03 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(4)]
        public virtual string SeatCharacteristic_04 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(5)]
        public virtual string SeatCharacteristic_05 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(6)]
        public virtual string SeatCharacteristic_06 { get; set; }
    }
    
    /// <summary>
    // SEAT RANGE REQUEST DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C025")]
    public class C025
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Seat row number
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9830", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string SeatRowNumber_01 { get; set; }
        /// <summary>
        // Rows - number of rows
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6804", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string RowsNumberOfRows_02 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string SeatColumn_03 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string SeatColumn_04 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string SeatColumn_05 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string SeatColumn_06 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string SeatColumn_07 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string SeatColumn_08 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string SeatColumn_09 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string SeatColumn_10 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string SeatColumn_11 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string SeatColumn_12 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(13)]
        public virtual string SeatColumn_13 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(14)]
        public virtual string SeatColumn_14 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(15)]
        public virtual string SeatColumn_15 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(16)]
        public virtual string SeatColumn_16 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(17)]
        public virtual string SeatColumn_17 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(18)]
        public virtual string SeatColumn_18 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(19)]
        public virtual string SeatColumn_19 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(20)]
        public virtual string SeatColumn_20 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(21)]
        public virtual string SeatColumn_21 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(22)]
        public virtual string SeatColumn_22 { get; set; }
    }
    
    /// <summary>
    // SEAT ADJUSTMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C026")]
    public class C026
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Seat count adjustment
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9832", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string SeatCountAdjustment_01 { get; set; }
        /// <summary>
        // Reason for seat adjustment
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("9833", typeof(EDIFACT_ID_9833))]
        [Pos(2)]
        public virtual string ReasonForSeatAdjustment_02 { get; set; }
        /// <summary>
        // Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6803", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string Weight_03 { get; set; }
    }
    
    /// <summary>
    // CHECKED BAGGAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C027")]
    public class C027
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Number of pieces
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("6806", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string NumberOfPieces_01 { get; set; }
        /// <summary>
        // Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6803", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string Weight_02 { get; set; }
    }
    
    /// <summary>
    // HAND BAGGAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C028")]
    public class C028
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Number of pieces
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6806", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string NumberOfPieces_01 { get; set; }
        /// <summary>
        // Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6803", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string Weight_02 { get; set; }
    }
    
    /// <summary>
    // BAG TAG DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C029")]
    public class C029
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public virtual string CarrierIdentification_01 { get; set; }
        /// <summary>
        // Tag serial number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 16)]
        [DataElement("9835", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string TagSerialNumber_02 { get; set; }
        /// <summary>
        // Number of consecutive tag serial number
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9836", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string NumberOfConsecutiveTagSerialNumber_03 { get; set; }
        /// <summary>
        // Place of destination
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("3259", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PlaceOfDestination_04 { get; set; }
        /// <summary>
        // Airline code number
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3810", typeof(EDIFACT_ID_3810))]
        [Pos(5)]
        public virtual string AirlineCodeNumber_05 { get; set; }
        /// <summary>
        // Online/interline indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9885", typeof(EDIFACT_ID_9885))]
        [Pos(6)]
        public virtual string OnlineinterlineIndicator_06 { get; set; }
    }
    
    /// <summary>
    // SSR DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C030")]
    public class C030
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Special service request (SSR) code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("9837", typeof(EDIFACT_A))]
        [Pos(1)]
        public virtual string SpecialServiceRequest_01 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(2)]
        public virtual string CarrierIdentification_02 { get; set; }
        /// <summary>
        // Frequent flyer identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("9839", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FrequentFlyerIdentificationCode_03 { get; set; }
        /// <summary>
        // Age
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("9886", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string Age_04 { get; set; }
        /// <summary>
        // Number of pieces
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6806", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string NumberOfPieces_05 { get; set; }
        /// <summary>
        // Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6803", typeof(EDIFACT_N))]
        [Pos(6)]
        public virtual string Weight_06 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string FreeText_07 { get; set; }
        /// <summary>
        // Number of units qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6353", typeof(EDIFACT_ID_6353))]
        [Pos(8)]
        public virtual string NumberOfUnitsQualifier_08 { get; set; }
        /// <summary>
        // Document/message name
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(9)]
        public virtual string DocumentmessageName_09 { get; set; }
    }
    
    
    /// <summary>
    // UPDATE SEAT ADJUSTMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C034")]
    public class C034
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Update action code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9858", typeof(EDIFACT_ID_9858))]
        [Pos(1)]
        public virtual string UpdateActionCode_01 { get; set; }
        /// <summary>
        // Seat count adjustment
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9832", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string SeatCountAdjustment_02 { get; set; }
        /// <summary>
        // Reason for seat adjustment
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("9833", typeof(EDIFACT_ID_9833))]
        [Pos(3)]
        public virtual string ReasonForSeatAdjustment_03 { get; set; }
        /// <summary>
        // Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6803", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string Weight_04 { get; set; }
    }
    
    /// <summary>
    // UPDATE CHECKED BAGGAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C035")]
    public class C035
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Update action code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9858", typeof(EDIFACT_ID_9858))]
        [Pos(1)]
        public virtual string UpdateActionCode_01 { get; set; }
        /// <summary>
        // Number of pieces
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6806", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string NumberOfPieces_02 { get; set; }
        /// <summary>
        // Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6803", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string Weight_03 { get; set; }
    }
    
    /// <summary>
    // UPDATE HAND BAGGAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C036")]
    public class C036
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Update action code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9858", typeof(EDIFACT_ID_9858))]
        [Pos(1)]
        public virtual string UpdateActionCode_01 { get; set; }
        /// <summary>
        // Number of pieces
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6806", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string NumberOfPieces_02 { get; set; }
        /// <summary>
        // Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6803", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string Weight_03 { get; set; }
    }
    
    /// <summary>
    // UPDATE BAG TAG DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C037")]
    public class C037
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Update action code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9858", typeof(EDIFACT_ID_9858))]
        [Pos(1)]
        public virtual string UpdateActionCode_01 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(2)]
        public virtual string CarrierIdentification_02 { get; set; }
        /// <summary>
        // Tag serial number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 16)]
        [DataElement("9835", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string TagSerialNumber_03 { get; set; }
        /// <summary>
        // Number of consecutive tag serial number
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9836", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string NumberOfConsecutiveTagSerialNumber_04 { get; set; }
        /// <summary>
        // Place of destination
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("3259", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PlaceOfDestination_05 { get; set; }
        /// <summary>
        // Airline code number
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3810", typeof(EDIFACT_ID_3810))]
        [Pos(6)]
        public virtual string AirlineCodeNumber_06 { get; set; }
        /// <summary>
        // Online/interline indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9885", typeof(EDIFACT_ID_9885))]
        [Pos(7)]
        public virtual string OnlineinterlineIndicator_07 { get; set; }
    }
    
    /// <summary>
    // UPDATE SSR DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C038")]
    public class C038
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Update action code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9858", typeof(EDIFACT_ID_9858))]
        [Pos(1)]
        public virtual string UpdateActionCode_01 { get; set; }
        /// <summary>
        // Special service request (SSR) code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("9837", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string SpecialServiceRequest_02 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(3)]
        public virtual string CarrierIdentification_03 { get; set; }
        /// <summary>
        // Frequent flyer identification code
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("9839", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FrequentFlyerIdentificationCode_04 { get; set; }
        /// <summary>
        // Age
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("9886", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string Age_05 { get; set; }
        /// <summary>
        // Number of pieces
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6806", typeof(EDIFACT_N))]
        [Pos(6)]
        public virtual string NumberOfPieces_06 { get; set; }
        /// <summary>
        // Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6803", typeof(EDIFACT_N))]
        [Pos(7)]
        public virtual string Weight_07 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string FreeText_08 { get; set; }
        /// <summary>
        // Number of units qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6353", typeof(EDIFACT_ID_6353))]
        [Pos(9)]
        public virtual string NumberOfUnitsQualifier_09 { get; set; }
        /// <summary>
        // Document/message name
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(10)]
        public virtual string DocumentmessageName_10 { get; set; }
    }
    
    /// <summary>
    // UPDATE OSI DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C039")]
    public class C039
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Update action code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9858", typeof(EDIFACT_ID_9858))]
        [Pos(1)]
        public virtual string UpdateActionCode_01 { get; set; }
        /// <summary>
        // Other service information (OSI)
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 250)]
        [DataElement("9838", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string OtherServiceInformation_02 { get; set; }
    }
    
    /// <summary>
    // CARRIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public virtual string CarrierIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Carrier name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3128", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string CarrierName_04 { get; set; }
    }
    
    /// <summary>
    // COMPLEXING FLIGHT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C041")]
    public class C041
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Flight number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("3802", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string FlightNumber_01 { get; set; }
        /// <summary>
        // Place of departure
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 5)]
        [DataElement("3215", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PlaceOfDeparture_02 { get; set; }
        /// <summary>
        // Place of destination
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 5)]
        [DataElement("3259", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string PlaceOfDestination_03 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(4)]
        public virtual string CarrierIdentification_04 { get; set; }
        /// <summary>
        // Operational suffix to the carrier code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9801", typeof(EDIFACT_A))]
        [Pos(5)]
        public virtual string OperationalSuffixToTheCarrierCode_05 { get; set; }
    }
    
    /// <summary>
    // FLIGHT SERVICE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C042")]
    public class C042
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(1)]
        public virtual string FlightServiceCode_01 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(2)]
        public virtual string FlightServiceCode_02 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(3)]
        public virtual string FlightServiceCode_03 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(4)]
        public virtual string FlightServiceCode_04 { get; set; }
        [DataMember]
        [DataElement("~3293", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C04205 { get; set; }
        [DataMember]
        [DataElement("~1131", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C04206 { get; set; }
        [DataMember]
        [DataElement("~3055", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string C04207 { get; set; }
        [DataMember]
        [DataElement("~3292", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string C04208 { get; set; }
    }
    
    /// <summary>
    // FLIGHT SERVICE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C042")]
    public class C042_1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(1)]
        public virtual string FlightServiceCode_01 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(2)]
        public virtual string FlightServiceCode_02 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(3)]
        public virtual string FlightServiceCode_03 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(4)]
        public virtual string FlightServiceCode_04 { get; set; }
        [DataMember]
        [DataElement("~3293", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C04205 { get; set; }
        [DataMember]
        [DataElement("~1131", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C04206 { get; set; }
        [DataMember]
        [DataElement("~3055", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string C04207 { get; set; }
        [DataMember]
        [DataElement("~3292", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string C04208 { get; set; }
    }
    
    /// <summary>
    // FLIGHT SERVICE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C042")]
    public class C042_2
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(1)]
        public virtual string FlightServiceCode_01 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(2)]
        public virtual string FlightServiceCode_02 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(3)]
        public virtual string FlightServiceCode_03 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(4)]
        public virtual string FlightServiceCode_04 { get; set; }
        [DataMember]
        [DataElement("~3293", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C04205 { get; set; }
        [DataMember]
        [DataElement("~1131", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C04206 { get; set; }
        [DataMember]
        [DataElement("~3055", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string C04207 { get; set; }
        [DataMember]
        [DataElement("~3292", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string C04208 { get; set; }
    }
    
    /// <summary>
    // FLIGHT SERVICE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C042")]
    public class C042_3
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(1)]
        public virtual string FlightServiceCode_01 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(2)]
        public virtual string FlightServiceCode_02 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(3)]
        public virtual string FlightServiceCode_03 { get; set; }
        /// <summary>
        // Flight service code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9871", typeof(EDIFACT_ID_9871))]
        [Pos(4)]
        public virtual string FlightServiceCode_04 { get; set; }
        [DataMember]
        [DataElement("~3293", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C04205 { get; set; }
        [DataMember]
        [DataElement("~1131", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C04206 { get; set; }
        [DataMember]
        [DataElement("~3055", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string C04207 { get; set; }
        [DataMember]
        [DataElement("~3292", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string C04208 { get; set; }
    }
    
    /// <summary>
    // SEAT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C043")]
    public class C043
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Specific seat
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9809", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string SpecificSeat_01 { get; set; }
        /// <summary>
        // Freeseating reference identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9861", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string FreeseatingReferenceIdentifier_02 { get; set; }
    }
    
    /// <summary>
    // SEAT DEFINITION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C044")]
    public class C044
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // No smoking indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9807", typeof(EDIFACT_ID_9807))]
        [Pos(1)]
        public virtual string NoSmokingIndicator_01 { get; set; }
        /// <summary>
        // Cabin class designator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9854", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string CabinClassDesignator_02 { get; set; }
        /// <summary>
        // Cabin class of service
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9873", typeof(EDIFACT_ID_9873))]
        [Pos(3)]
        public virtual string CabinClassOfService_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FreeText_04 { get; set; }
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
        // Equipment code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7800", typeof(EDIFACT_ID_7800))]
        [Pos(7)]
        public virtual string EquipmentCode_07 { get; set; }
        /// <summary>
        // Seat request fulfilled indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9862", typeof(EDIFACT_ID_9862))]
        [Pos(8)]
        public virtual string SeatRequestFulfilledIndicator_08 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(9)]
        public virtual string SeatCharacteristic_09 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(10)]
        public virtual string SeatCharacteristic_10 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(11)]
        public virtual string SeatCharacteristic_11 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(12)]
        public virtual string SeatCharacteristic_12 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(13)]
        public virtual string SeatCharacteristic_13 { get; set; }
    }
    
    /// <summary>
    // BOARDING SECURITY CODE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C045")]
    public class C045
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Passenger boarding security identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 5)]
        [DataElement("9874", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PassengerBoardingSecurityIdentifier_01 { get; set; }
        /// <summary>
        // Passenger boarding security identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("9874", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PassengerBoardingSecurityIdentifier_02 { get; set; }
    }
    
    /// <summary>
    // PASSENGER SELECTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C046")]
    public class C046
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
        // Given name
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("3809", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string GivenName_02 { get; set; }
        /// <summary>
        // Reservation booking designator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9800", typeof(EDIFACT_ID_9800))]
        [Pos(3)]
        public virtual string ReservationBookingDesignator_03 { get; set; }
        /// <summary>
        // Number of passenger in surname/family
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9824", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string NumberOfPassengerInSurnamefamily_04 { get; set; }
    }
    
    /// <summary>
    // RANGE OF ROWS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C047")]
    public class C047
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
        // Rows - number of rows
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6804", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string RowsNumberOfRows_02 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string SeatColumn_03 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string SeatColumn_04 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string SeatColumn_05 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string SeatColumn_06 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string SeatColumn_07 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string SeatColumn_08 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string SeatColumn_09 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string SeatColumn_10 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string SeatColumn_11 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string SeatColumn_12 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(13)]
        public virtual string SeatColumn_13 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(14)]
        public virtual string SeatColumn_14 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(15)]
        public virtual string SeatColumn_15 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(16)]
        public virtual string SeatColumn_16 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(17)]
        public virtual string SeatColumn_17 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(18)]
        public virtual string SeatColumn_18 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(19)]
        public virtual string SeatColumn_19 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(20)]
        public virtual string SeatColumn_20 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(21)]
        public virtual string SeatColumn_21 { get; set; }
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(22)]
        public virtual string SeatColumn_22 { get; set; }
    }
    
    /// <summary>
    // CONFIGURATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C048")]
    public class C048
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Cabin class designator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9854", typeof(EDIFACT_A))]
        [Pos(1)]
        public virtual string CabinClassDesignator_01 { get; set; }
        /// <summary>
        // Seats - number of seats
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6800", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string SeatsNumberOfSeats_02 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(3)]
        public virtual string CharacteristicIdentification_03 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(4)]
        public virtual string CharacteristicIdentification_04 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(5)]
        public virtual string CharacteristicIdentification_05 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(6)]
        public virtual string CharacteristicIdentification_06 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(7)]
        public virtual string CharacteristicIdentification_07 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(8)]
        public virtual string CharacteristicIdentification_08 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(9)]
        public virtual string CharacteristicIdentification_09 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(10)]
        public virtual string CharacteristicIdentification_10 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(11)]
        public virtual string CharacteristicIdentification_11 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(12)]
        public virtual string CharacteristicIdentification_12 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(13)]
        public virtual string CharacteristicIdentification_13 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(14)]
        public virtual string CharacteristicIdentification_14 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(15)]
        public virtual string CharacteristicIdentification_15 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(16)]
        public virtual string CharacteristicIdentification_16 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(17)]
        public virtual string CharacteristicIdentification_17 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(18)]
        public virtual string CharacteristicIdentification_18 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(19)]
        public virtual string CharacteristicIdentification_19 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(20)]
        public virtual string CharacteristicIdentification_20 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(21)]
        public virtual string CharacteristicIdentification_21 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(22)]
        public virtual string CharacteristicIdentification_22 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(23)]
        public virtual string CharacteristicIdentification_23 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(24)]
        public virtual string CharacteristicIdentification_24 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(25)]
        public virtual string CharacteristicIdentification_25 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(26)]
        public virtual string CharacteristicIdentification_26 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(27)]
        public virtual string CharacteristicIdentification_27 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(28)]
        public virtual string CharacteristicIdentification_28 { get; set; }
    }
    
    /// <summary>
    // ROW CHARACTERISTICS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C049")]
    public class C049
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Row characteristic
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9864", typeof(EDIFACT_ID_9864))]
        [Pos(1)]
        public virtual string RowCharacteristic_01 { get; set; }
        /// <summary>
        // Row characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9864", typeof(EDIFACT_ID_9864))]
        [Pos(2)]
        public virtual string RowCharacteristic_02 { get; set; }
        /// <summary>
        // Row characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9864", typeof(EDIFACT_ID_9864))]
        [Pos(3)]
        public virtual string RowCharacteristic_03 { get; set; }
        /// <summary>
        // Row characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9864", typeof(EDIFACT_ID_9864))]
        [Pos(4)]
        public virtual string RowCharacteristic_04 { get; set; }
        /// <summary>
        // Row characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9864", typeof(EDIFACT_ID_9864))]
        [Pos(5)]
        public virtual string RowCharacteristic_05 { get; set; }
        /// <summary>
        // Row characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9864", typeof(EDIFACT_ID_9864))]
        [Pos(6)]
        public virtual string RowCharacteristic_06 { get; set; }
        /// <summary>
        // Row characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9864", typeof(EDIFACT_ID_9864))]
        [Pos(7)]
        public virtual string RowCharacteristic_07 { get; set; }
        /// <summary>
        // Row characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9864", typeof(EDIFACT_ID_9864))]
        [Pos(8)]
        public virtual string RowCharacteristic_08 { get; set; }
        /// <summary>
        // Row characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9864", typeof(EDIFACT_ID_9864))]
        [Pos(9)]
        public virtual string RowCharacteristic_09 { get; set; }
    }
    
    /// <summary>
    // SEAT OCCUPATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C051")]
    public class C051
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string SeatColumn_01 { get; set; }
        /// <summary>
        // Seat occupation
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9865", typeof(EDIFACT_ID_9865))]
        [Pos(2)]
        public virtual string SeatOccupation_02 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(3)]
        public virtual string SeatCharacteristic_03 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(4)]
        public virtual string SeatCharacteristic_04 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(5)]
        public virtual string SeatCharacteristic_05 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(6)]
        public virtual string SeatCharacteristic_06 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(7)]
        public virtual string SeatCharacteristic_07 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(8)]
        public virtual string SeatCharacteristic_08 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(9)]
        public virtual string SeatCharacteristic_09 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(10)]
        public virtual string SeatCharacteristic_10 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(11)]
        public virtual string SeatCharacteristic_11 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(12)]
        public virtual string SeatCharacteristic_12 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(13)]
        public virtual string SeatCharacteristic_13 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(14)]
        public virtual string SeatCharacteristic_14 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(15)]
        public virtual string SeatCharacteristic_15 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(16)]
        public virtual string SeatCharacteristic_16 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(17)]
        public virtual string SeatCharacteristic_17 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(18)]
        public virtual string SeatCharacteristic_18 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(19)]
        public virtual string SeatCharacteristic_19 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(20)]
        public virtual string SeatCharacteristic_20 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(21)]
        public virtual string SeatCharacteristic_21 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(22)]
        public virtual string SeatCharacteristic_22 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(23)]
        public virtual string SeatCharacteristic_23 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(24)]
        public virtual string SeatCharacteristic_24 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(25)]
        public virtual string SeatCharacteristic_25 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(26)]
        public virtual string SeatCharacteristic_26 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(27)]
        public virtual string SeatCharacteristic_27 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(28)]
        public virtual string SeatCharacteristic_28 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(29)]
        public virtual string SeatCharacteristic_29 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(30)]
        public virtual string SeatCharacteristic_30 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(31)]
        public virtual string SeatCharacteristic_31 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(32)]
        public virtual string SeatCharacteristic_32 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(33)]
        public virtual string SeatCharacteristic_33 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(34)]
        public virtual string SeatCharacteristic_34 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(35)]
        public virtual string SeatCharacteristic_35 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(36)]
        public virtual string SeatCharacteristic_36 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(37)]
        public virtual string SeatCharacteristic_37 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(38)]
        public virtual string SeatCharacteristic_38 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(39)]
        public virtual string SeatCharacteristic_39 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(40)]
        public virtual string SeatCharacteristic_40 { get; set; }
    }
    
    /// <summary>
    // CABIN CLASS SEAT ROW RANGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C052")]
    public class C052
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
        // Seat row number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9830", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string SeatRowNumber_02 { get; set; }
    }
    
    /// <summary>
    // SMOKING AREA SEAT ROW RANGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C053")]
    public class C053
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
        // Seat row number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9830", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string SeatRowNumber_02 { get; set; }
    }
    
    /// <summary>
    // CABIN WIDTH AND COLUMN DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C054")]
    public class C054
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Seat column
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9831", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string SeatColumn_01 { get; set; }
        /// <summary>
        // Column description
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("9882", typeof(EDIFACT_ID_9882))]
        [Pos(2)]
        public virtual string ColumnDescription_02 { get; set; }
        /// <summary>
        // Column description
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("9882", typeof(EDIFACT_ID_9882))]
        [Pos(3)]
        public virtual string ColumnDescription_03 { get; set; }
    }
    
    /// <summary>
    // WARNING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C055")]
    public class C055
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Processing level
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9876", typeof(EDIFACT_ID_9876))]
        [Pos(1)]
        public virtual string ProcessingLevel_01 { get; set; }
        /// <summary>
        // Error/warning message number
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9845", typeof(EDIFACT_ID_9845))]
        [Pos(2)]
        public virtual string ErrorwarningMessageNumber_02 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FreeText_03 { get; set; }
    }
    
    /// <summary>
    // ERROR INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C056")]
    public class C056
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Processing level
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9876", typeof(EDIFACT_ID_9876))]
        [Pos(1)]
        public virtual string ProcessingLevel_01 { get; set; }
        /// <summary>
        // Error/warning message number
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9845", typeof(EDIFACT_ID_9845))]
        [Pos(2)]
        public virtual string ErrorwarningMessageNumber_02 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FreeText_03 { get; set; }
    }
    
    /// <summary>
    // BAG TAG SELECTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C057")]
    public class C057
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public virtual string CarrierIdentification_01 { get; set; }
        /// <summary>
        // Tag serial number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 16)]
        [DataElement("9835", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string TagSerialNumber_02 { get; set; }
    }
    
    /// <summary>
    // OVERWING SEAT ROW RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C058")]
    public class C058
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
        // Seat row number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9830", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string SeatRowNumber_02 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string C05803 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string C05804 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C05805 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C05806 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string C05807 { get; set; }
    }
    
    /// <summary>
    // OVERWING SEAT ROW RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C058")]
    public class C058_1
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
        // Seat row number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9830", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string SeatRowNumber_02 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string C05803 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string C05804 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C05805 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C05806 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string C05807 { get; set; }
    }
    
    /// <summary>
    // OVERWING SEAT ROW RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C058")]
    public class C058_2
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
        // Seat row number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9830", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string SeatRowNumber_02 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string C05803 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string C05804 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C05805 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C05806 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string C05807 { get; set; }
    }
    
    /// <summary>
    // OVERWING SEAT ROW RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C058")]
    public class C058_3
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
        // Seat row number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9830", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string SeatRowNumber_02 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string C05803 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string C05804 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C05805 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C05806 { get; set; }
        [DataMember]
        [DataElement("~3124", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string C05807 { get; set; }
    }
    
    /// <summary>
    // PLACE OF ORIGIN OF A REQUEST
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C059")]
    public class C059
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public virtual string CarrierIdentification_01 { get; set; }
        /// <summary>
        // Place of origin of business
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("3800", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string PlaceOfOriginOfBusiness_02 { get; set; }
        /// <summary>
        // Country where request originated
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("3805", typeof(EDIFACT_A))]
        [Pos(3)]
        public virtual string CountryWhereRequestOriginated_03 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string C05904 { get; set; }
        [DataMember]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C05905 { get; set; }
        [DataMember]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C05906 { get; set; }
    }
    
    /// <summary>
    // PLACE OF ORIGIN OF A REQUEST
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C059")]
    public class C059_1
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public virtual string CarrierIdentification_01 { get; set; }
        /// <summary>
        // Place of origin of business
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("3800", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string PlaceOfOriginOfBusiness_02 { get; set; }
        /// <summary>
        // Country where request originated
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("3805", typeof(EDIFACT_A))]
        [Pos(3)]
        public virtual string CountryWhereRequestOriginated_03 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string C05904 { get; set; }
        [DataMember]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C05905 { get; set; }
        [DataMember]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C05906 { get; set; }
    }
    
    /// <summary>
    // PLACE OF ORIGIN OF A REQUEST
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C059")]
    public class C059_2
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public virtual string CarrierIdentification_01 { get; set; }
        /// <summary>
        // Place of origin of business
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("3800", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string PlaceOfOriginOfBusiness_02 { get; set; }
        /// <summary>
        // Country where request originated
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("3805", typeof(EDIFACT_A))]
        [Pos(3)]
        public virtual string CountryWhereRequestOriginated_03 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string C05904 { get; set; }
        [DataMember]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C05905 { get; set; }
        [DataMember]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C05906 { get; set; }
    }
    
    /// <summary>
    // PLACE OF ORIGIN OF A REQUEST
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C059")]
    public class C059_3
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public virtual string CarrierIdentification_01 { get; set; }
        /// <summary>
        // Place of origin of business
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("3800", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string PlaceOfOriginOfBusiness_02 { get; set; }
        /// <summary>
        // Country where request originated
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("3805", typeof(EDIFACT_A))]
        [Pos(3)]
        public virtual string CountryWhereRequestOriginated_03 { get; set; }
        [DataMember]
        [Required]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string C05904 { get; set; }
        [DataMember]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string C05905 { get; set; }
        [DataMember]
        [DataElement("~3042", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string C05906 { get; set; }
    }
    
    /// <summary>
    // PASSENGER API DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C060")]
    public class C060
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Number of units qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6353", typeof(EDIFACT_ID_6353))]
        [Pos(1)]
        public virtual string NumberOfUnitsQualifier_01 { get; set; }
        /// <summary>
        // Surname
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("3808", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string Surname_02 { get; set; }
        /// <summary>
        // Given name
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("3809", typeof(EDIFACT_A))]
        [Pos(3)]
        public virtual string GivenName_03 { get; set; }
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FirstDate_04 { get; set; }
        /// <summary>
        // Processing status code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9869", typeof(EDIFACT_ID_9869))]
        [Pos(5)]
        public virtual string ProcessingStatusCode_05 { get; set; }
        /// <summary>
        // Other names
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("9754", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string OtherNames_06 { get; set; }
        /// <summary>
        // Country
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(7)]
        public virtual string Country_07 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string FreeText_08 { get; set; }
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string PlacelocationIdentification_09 { get; set; }
    }
    
    /// <summary>
    // COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C076")]
    public class C076
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Communication number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 25)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string CommunicationNumber_01 { get; set; }
        /// <summary>
        // Communication channel qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("3155", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string CommunicationChannelQualifier_02 { get; set; }
    }
    
    /// <summary>
    // ACCOUNT HOLDER IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C078")]
    public class C078
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Account holder number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string AccountHolderNumber_01 { get; set; }
        /// <summary>
        // Account holder name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string AccountHolderName_02 { get; set; }
        /// <summary>
        // Account holder name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string AccountHolderName_03 { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(4)]
        public virtual string Currency_04 { get; set; }
    }
    
    /// <summary>
    // PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C080")]
    public class C080
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PartyName_01 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PartyName_02 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string PartyName_03 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PartyName_04 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PartyName_05 { get; set; }
        /// <summary>
        // Party name format
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3045", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string PartyNameFormat_06 { get; set; }
    }
    
    /// <summary>
    // PARTY IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C082")]
    public class C082
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Party id identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PartyIdIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }
    
    /// <summary>
    // INSTITUTION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C088")]
    public class C088
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Institution name identification
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("3433", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string InstitutionNameIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Institution branch number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string InstitutionBranchNumber_04 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public virtual string CodeListQualifier_05 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public virtual string CodeListResponsibleAgency_06 { get; set; }
        /// <summary>
        // Institution name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3432", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string InstitutionName_07 { get; set; }
        /// <summary>
        // Institution branch place
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3436", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string InstitutionBranchPlace_08 { get; set; }
    }
    
    /// <summary>
    // TEXT REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C107")]
    public class C107
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("4441", typeof(EDIFACT_ID_4441))]
        [Pos(1)]
        public virtual string FreeText_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }
    
    /// <summary>
    // TEXT LITERAL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C108")]
    public class C108
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string FreeText_01 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string FreeText_02 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FreeText_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FreeText_04 { get; set; }
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
    // PAYMENT TERMS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C110")]
    public class C110
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Terms of payment identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("4277", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TermsOfPaymentIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Terms of payment
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string TermsOfPayment_04 { get; set; }
        /// <summary>
        // Terms of payment
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string TermsOfPayment_05 { get; set; }
    }
    
    /// <summary>
    // TERMS/TIME INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C112")]
    public class C112
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Payment time reference
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("2475", typeof(EDIFACT_ID_2475))]
        [Pos(1)]
        public virtual string PaymentTimeReference_01 { get; set; }
        /// <summary>
        // Time relation
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2009", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string TimeRelation_02 { get; set; }
        /// <summary>
        // Type of period
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2151", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string TypeOfPeriod_03 { get; set; }
        /// <summary>
        // Number of periods
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string NumberOfPeriods_04 { get; set; }
    }
    
    /// <summary>
    // VALUE/RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C174")]
    public class C174
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Measure unit qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public virtual string MeasureUnitQualifier_01 { get; set; }
        /// <summary>
        // Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string MeasurementValue_02 { get; set; }
        /// <summary>
        // Range minimum
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string RangeMinimum_03 { get; set; }
        /// <summary>
        // Range maximum
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string RangeMaximum_04 { get; set; }
    }
    
    /// <summary>
    // QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Quantity qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public virtual string QuantityQualifier_01 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string Quantity_02 { get; set; }
        /// <summary>
        // Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public virtual string MeasureUnitQualifier_03 { get; set; }
    }
    
    /// <summary>
    // HAZARD CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C205")]
    public class C205
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Hazard code identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 7)]
        [DataElement("8351", typeof(EDIFACT_ID_8351))]
        [Pos(1)]
        public virtual string HazardCodeIdentification_01 { get; set; }
        /// <summary>
        // Hazard substance/item/page number
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("8078", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string HazardSubstanceitempageNumber_02 { get; set; }
        /// <summary>
        // Hazard code version number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("8092", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string HazardCodeVersionNumber_03 { get; set; }
    }
    
    /// <summary>
    // IDENTIFICATION NUMBER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C206")]
    public class C206
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string IdentityNumber_01 { get; set; }
        /// <summary>
        // Identity number qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public virtual string IdentityNumberQualifier_02 { get; set; }
    }
    
    /// <summary>
    // DIMENSIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C211")]
    public class C211
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public virtual string MeasureUnitQualifier_01 { get; set; }
        /// <summary>
        // Length dimension
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6168", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string LengthDimension_02 { get; set; }
        /// <summary>
        // Width dimension
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6140", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string WidthDimension_03 { get; set; }
        /// <summary>
        // Height dimension
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6008", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string HeightDimension_04 { get; set; }
    }
    
    /// <summary>
    // ITEM NUMBER IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C212")]
    public class C212
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
        // Item number type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public virtual string ItemNumberType_02 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public virtual string CodeListQualifier_03 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public virtual string CodeListResponsibleAgency_04 { get; set; }
    }
    
    /// <summary>
    // SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C214")]
    public class C214
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Special service
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public virtual string SpecialService_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Special service
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string SpecialService_04 { get; set; }
        /// <summary>
        // Special service
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string SpecialService_05 { get; set; }
    }
    
    /// <summary>
    // MODE OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C220")]
    public class C220
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Mode of transport
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("8067", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ModeOfTransport_01 { get; set; }
        /// <summary>
        // Mode of transport
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ModeOfTransport_02 { get; set; }
    }
    
    /// <summary>
    // TRANSPORT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C222")]
    public class C222
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Id. of means of transport identification
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("8213", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string IdOfMeansOfTransportIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Id of the means of transport
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string IdOfTheMeansOfTransport_04 { get; set; }
        /// <summary>
        // Nationality of means of transport
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string NationalityOfMeansOfTransport_05 { get; set; }
    }
    
    /// <summary>
    // EQUIPMENT SIZE AND TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C224")]
    public class C224
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Equipment size and type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8155", typeof(EDIFACT_ID_8155))]
        [Pos(1)]
        public virtual string EquipmentSizeAndTypeIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Equipment size and type
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("8154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string EquipmentSizeAndType_04 { get; set; }
    }
    
    /// <summary>
    // TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C228")]
    public class C228
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Type of means of transport identification
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TypeOfMeansOfTransportIdentification_01 { get; set; }
        /// <summary>
        // Type of means of transport
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string TypeOfMeansOfTransport_02 { get; set; }
    }
    
    /// <summary>
    // HAZARD IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C235")]
    public class C235
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Hazard identification number
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8158", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string HazardIdentificationNumber_01 { get; set; }
        /// <summary>
        // Substance identification number
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("8186", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string SubstanceIdentificationNumber_02 { get; set; }
    }
    
    /// <summary>
    // EQUIPMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C237")]
    public class C237
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Equipment identification number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8260", typeof(EDIFACT_ID_8260))]
        [Pos(1)]
        public virtual string EquipmentIdentificationNumber_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }
    
    /// <summary>
    // DUTY/TAX/FEE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C241")]
    public class C241
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Duty/Tax fee type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public virtual string DutyTaxFeeType_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Duty/tax/fee type
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DutytaxfeeType_04 { get; set; }
    }
    
    /// <summary>
    // DUTY/TAX/FEE DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C243")]
    public class C243
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Duty/tax/fee rate identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DutytaxfeeRateIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Duty/tax/fee rate
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DutytaxfeeRate_04 { get; set; }
        /// <summary>
        // Duty/tax/fee rate basis identification
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("5273", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string DutytaxfeeRateBasisIdentification_05 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public virtual string CodeListQualifier_06 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public virtual string CodeListResponsibleAgency_07 { get; set; }
    }
    
    /// <summary>
    // CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Control qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("6069", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ControlQualifier_01 { get; set; }
        /// <summary>
        // Control value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string ControlValue_02 { get; set; }
        /// <summary>
        // Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public virtual string MeasureUnitQualifier_03 { get; set; }
    }
    
    /// <summary>
    // ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C273")]
    public class C273
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(1)]
        public virtual string ItemDescriptionIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string ItemDescription_04 { get; set; }
        /// <summary>
        // Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string ItemDescription_05 { get; set; }
        /// <summary>
        // Language
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(6)]
        public virtual string Language_06 { get; set; }
    }
    
    /// <summary>
    // RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C280")]
    public class C280
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(1)]
        public virtual string MeasureUnitQualifier_01 { get; set; }
        /// <summary>
        // Range minimum
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string RangeMinimum_02 { get; set; }
        /// <summary>
        // Range maximum
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string RangeMaximum_03 { get; set; }
    }
    
    /// <summary>
    // PRODUCT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C304")]
    public class C304
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(1)]
        public virtual string CharacteristicIdentification_01 { get; set; }
        /// <summary>
        // Article availability
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7011", typeof(EDIFACT_ID_7011))]
        [Pos(2)]
        public virtual string ArticleAvailability_02 { get; set; }
        /// <summary>
        // Special service
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(3)]
        public virtual string SpecialService_03 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(4)]
        public virtual string ItemDescriptionIdentification_04 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(5)]
        public virtual string ItemDescriptionIdentification_05 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(6)]
        public virtual string ItemDescriptionIdentification_06 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(7)]
        public virtual string ItemDescriptionIdentification_07 { get; set; }
    }
    
    /// <summary>
    // CONNECTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C312")]
    public class C312
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PlacelocationIdentification_01 { get; set; }
        /// <summary>
        // Company identification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_ID_9906))]
        [Pos(2)]
        public virtual string CompanyIdentification_02 { get; set; }
        /// <summary>
        // First time
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9918", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string FirstTime_03 { get; set; }
        /// <summary>
        // Second time
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9922", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string SecondTime_04 { get; set; }
        /// <summary>
        // Processing indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_ID_7365))]
        [Pos(5)]
        public virtual string ProcessingIndicator_05 { get; set; }
    }
    
    
    /// <summary>
    // PRODUCT LOCATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C316")]
    public class C316
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PlacelocationIdentification_01 { get; set; }
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PlacelocationIdentification_02 { get; set; }
        /// <summary>
        // Place/location qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(3)]
        public virtual string PlacelocationQualifier_03 { get; set; }
    }
    
    /// <summary>
    // TRAVELLER RELATED TEXT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C323")]
    public class C323
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Traveler reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("9944", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TravelerReferenceNumber_01 { get; set; }
        /// <summary>
        // Text subject qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(2)]
        public virtual string TextSubjectQualifier_02 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FreeText_03 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FreeText_04 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string FreeText_05 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string FreeText_06 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string FreeText_07 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string FreeText_08 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string FreeText_09 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string FreeText_10 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string FreeText_11 { get; set; }
    }
    
    /// <summary>
    // TRAFFIC RESTRICTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C338")]
    public class C338
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Traffic restriction
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9930", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TrafficRestriction_01 { get; set; }
        /// <summary>
        // Traffic restriction type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9968", typeof(EDIFACT_ID_9968))]
        [Pos(2)]
        public virtual string TrafficRestrictionType_02 { get; set; }
        /// <summary>
        // Traffic restriction qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9966", typeof(EDIFACT_ID_9966))]
        [Pos(3)]
        public virtual string TrafficRestrictionQualifier_03 { get; set; }
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
    // CABIN FACILITIES DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C340")]
    public class C340
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Cabin facilities characteristic
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9978", typeof(EDIFACT_ID_9978))]
        [Pos(1)]
        public virtual string CabinFacilitiesCharacteristic_01 { get; set; }
        /// <summary>
        // Place/location qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(2)]
        public virtual string PlacelocationQualifier_02 { get; set; }
    }
    
    /// <summary>
    // CABIN CLASS DESIGNATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C342")]
    public class C342
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Cabin class designator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9854", typeof(EDIFACT_A))]
        [Pos(1)]
        public virtual string CabinClassDesignator_01 { get; set; }
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(2)]
        public virtual string CharacteristicIdentification_02 { get; set; }
        /// <summary>
        // Cabin class of service
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9873", typeof(EDIFACT_ID_9873))]
        [Pos(3)]
        public virtual string CabinClassOfService_03 { get; set; }
        /// <summary>
        // Cabin compartment designator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9992", typeof(EDIFACT_A))]
        [Pos(4)]
        public virtual string CabinCompartmentDesignator_04 { get; set; }
    }
    
    /// <summary>
    // GENERIC DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C344")]
    public class C344
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Cabin class designator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9854", typeof(EDIFACT_A))]
        [Pos(1)]
        public virtual string CabinClassDesignator_01 { get; set; }
        /// <summary>
        // No smoking indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9807", typeof(EDIFACT_ID_9807))]
        [Pos(2)]
        public virtual string NoSmokingIndicator_02 { get; set; }
        /// <summary>
        // Cabin class of service
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9873", typeof(EDIFACT_ID_9873))]
        [Pos(3)]
        public virtual string CabinClassOfService_03 { get; set; }
        /// <summary>
        // Cabin compartment designator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9992", typeof(EDIFACT_A))]
        [Pos(4)]
        public virtual string CabinCompartmentDesignator_04 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(5)]
        public virtual string SeatCharacteristic_05 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(6)]
        public virtual string SeatCharacteristic_06 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(7)]
        public virtual string SeatCharacteristic_07 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(8)]
        public virtual string SeatCharacteristic_08 { get; set; }
        /// <summary>
        // Seat characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9825", typeof(EDIFACT_ID_9825))]
        [Pos(9)]
        public virtual string SeatCharacteristic_09 { get; set; }
    }
    
    /// <summary>
    // DOCUMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C350")]
    public class C350
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Document/message number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DocumentmessageNumber_01 { get; set; }
        /// <summary>
        // Status
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public virtual string Status_02 { get; set; }
        /// <summary>
        // Date/Time/Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string DateTimePeriod_03 { get; set; }
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
    // QUANTITY INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C351")]
    public class C351
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Number of units
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string NumberOfUnits_01 { get; set; }
        /// <summary>
        // Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string MeasurementValue_02 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string Quantity_03 { get; set; }
        /// <summary>
        // Quantity qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(4)]
        public virtual string QuantityQualifier_04 { get; set; }
    }
    
    /// <summary>
    // CARGO DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C352")]
    public class C352
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Nature of cargo
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7085", typeof(EDIFACT_ID_7085))]
        [Pos(1)]
        public virtual string NatureOfCargo_01 { get; set; }
        /// <summary>
        // Handling instructions
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4079", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string HandlingInstructions_02 { get; set; }
        /// <summary>
        // Status
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public virtual string Status_03 { get; set; }
    }
    
    /// <summary>
    // LOAD DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C353")]
    public class C353
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Measurement dimension
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public virtual string MeasurementDimension_01 { get; set; }
        /// <summary>
        // Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(2)]
        public virtual string MeasureUnitQualifier_02 { get; set; }
        /// <summary>
        // Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string MeasurementValue_03 { get; set; }
        /// <summary>
        // Measurement significance
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(4)]
        public virtual string MeasurementSignificance_04 { get; set; }
        /// <summary>
        // Full/empty indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8169", typeof(EDIFACT_ID_8169))]
        [Pos(5)]
        public virtual string FullemptyIndicator_05 { get; set; }
    }
    
    /// <summary>
    // PROCESSING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C355")]
    public class C355
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Processing indicator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_ID_7365))]
        [Pos(1)]
        public virtual string ProcessingIndicator_01 { get; set; }
        /// <summary>
        // Status
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public virtual string Status_02 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual List<string> FreeText_03 
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
    // BAGGAGE STATUS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C356")]
    public class C356
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Cabin class designator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9854", typeof(EDIFACT_A))]
        [Pos(1)]
        public virtual string CabinClassDesignator_01 { get; set; }
        /// <summary>
        // Equipment identification number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8260", typeof(EDIFACT_ID_8260))]
        [Pos(2)]
        public virtual string EquipmentIdentificationNumber_02 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(3)]
        public virtual string StatusIndicator_03 { get; set; }
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
    // EQUIPMENT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C359")]
    public class C359
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Mode of transport
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("8067", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ModeOfTransport_01 { get; set; }
        /// <summary>
        // Type of means of transport identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 8)]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string TypeOfMeansOfTransportIdentification_02 { get; set; }
        /// <summary>
        // Article availability
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7011", typeof(EDIFACT_ID_7011))]
        [Pos(3)]
        public virtual string ArticleAvailability_03 { get; set; }
        /// <summary>
        // Type of call at port
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9984", typeof(EDIFACT_ID_9984))]
        [Pos(4)]
        public virtual string TypeOfCallAtPort_04 { get; set; }
    }
    
    /// <summary>
    // EQUIPMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C360")]
    public class C360
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Type of means of transport identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 8)]
        [DataElement("8179", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TypeOfMeansOfTransportIdentification_01 { get; set; }
        /// <summary>
        // Product identification characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9914", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ProductIdentificationCharacteristic_02 { get; set; }
        /// <summary>
        // Id of the means of transport
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string IdOfTheMeansOfTransport_03 { get; set; }
        /// <summary>
        // Equipment identification number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8260", typeof(EDIFACT_ID_8260))]
        [Pos(4)]
        public virtual string EquipmentIdentificationNumber_04 { get; set; }
    }
    
    /// <summary>
    // ADDITIONAL EQUIPMENT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C361")]
    public class C361
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Aircraft cabin version identification
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("9866", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string AircraftCabinVersionIdentification_01 { get; set; }
        /// <summary>
        // Aircraft cabin version identification
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("9866", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string AircraftCabinVersionIdentification_02 { get; set; }
        /// <summary>
        // Company identification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_ID_9906))]
        [Pos(3)]
        public virtual string CompanyIdentification_03 { get; set; }
        /// <summary>
        // Equipment identification number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8260", typeof(EDIFACT_ID_8260))]
        [Pos(4)]
        public virtual string EquipmentIdentificationNumber_04 { get; set; }
        /// <summary>
        // Cabin facilities characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9978", typeof(EDIFACT_ID_9978))]
        [Pos(5)]
        public virtual string CabinFacilitiesCharacteristic_05 { get; set; }
        /// <summary>
        // Cabin facilities characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9978", typeof(EDIFACT_ID_9978))]
        [Pos(6)]
        public virtual string CabinFacilitiesCharacteristic_06 { get; set; }
    }
    
    /// <summary>
    // TIME INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C362")]
    public class C362
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // First time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("9918", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string FirstTime_01 { get; set; }
        /// <summary>
        // Second time
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9922", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string SecondTime_02 { get; set; }
        /// <summary>
        // UTC/local time variation
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("9986", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string UTClocalTimeVariation_03 { get; set; }
        /// <summary>
        // Date variation
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9954", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string DateVariation_04 { get; set; }
    }
    
    /// <summary>
    // TERMINAL INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C366")]
    public class C366
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Related place/location one identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string RelatedPlacelocationOneIdentification_01 { get; set; }
        /// <summary>
        // Related place/location one identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string RelatedPlacelocationOneIdentification_02 { get; set; }
    }
    
    /// <summary>
    // ON-TIME PERFORMANCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C368")]
    public class C368
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Date/Time/Period
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DateTimePeriod_01 { get; set; }
        /// <summary>
        // Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string Percentage_02 { get; set; }
        /// <summary>
        // Percentage qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(3)]
        public virtual string PercentageQualifier_03 { get; set; }
    }
    
    /// <summary>
    // REASON INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C369")]
    public class C369
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Status reason
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(1)]
        public virtual string StatusReason_01 { get; set; }
        /// <summary>
        // Status reason
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(2)]
        public virtual string StatusReason_02 { get; set; }
        /// <summary>
        // Status reason
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(3)]
        public virtual string StatusReason_03 { get; set; }
        /// <summary>
        // Status reason
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(4)]
        public virtual string StatusReason_04 { get; set; }
        /// <summary>
        // Status reason
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(5)]
        public virtual string StatusReason_05 { get; set; }
        /// <summary>
        // Status reason
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(6)]
        public virtual string StatusReason_06 { get; set; }
        /// <summary>
        // Status reason
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(7)]
        public virtual string StatusReason_07 { get; set; }
        /// <summary>
        // Status reason
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(8)]
        public virtual string StatusReason_08 { get; set; }
        /// <summary>
        // Status reason
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9013", typeof(EDIFACT_ID_9013))]
        [Pos(9)]
        public virtual string StatusReason_09 { get; set; }
    }
    
    /// <summary>
    // PORT OF CALL DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C370")]
    public class C370
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Type of call at port
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9984", typeof(EDIFACT_ID_9984))]
        [Pos(1)]
        public virtual string TypeOfCallAtPort_01 { get; set; }
        /// <summary>
        // Restricted payload
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("9982", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string RestrictedPayload_02 { get; set; }
        /// <summary>
        // Government action
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9417", typeof(EDIFACT_ID_9417))]
        [Pos(3)]
        public virtual string GovernmentAction_03 { get; set; }
    }
    
    /// <summary>
    // COMPANY ROLE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C374")]
    public class C374
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
        // Company identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("9906", typeof(EDIFACT_ID_9906))]
        [Pos(2)]
        public virtual string CompanyIdentification_02 { get; set; }
        /// <summary>
        // Product identification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9908", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ProductIdentification_03 { get; set; }
        /// <summary>
        // Product identification characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9914", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string ProductIdentificationCharacteristic_04 { get; set; }
    }
    
    /// <summary>
    // EXCESS TRANSPORTATION INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C401")]
    public class C401
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Excess transportation reason
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("8457", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ExcessTransportationReason_01 { get; set; }
        /// <summary>
        // Excess transportation responsibility
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("8459", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ExcessTransportationResponsibility_02 { get; set; }
        /// <summary>
        // Customer authorization number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string CustomerAuthorizationNumber_03 { get; set; }
    }
    
    /// <summary>
    // MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Measurement dimension
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public virtual string MeasurementDimension_01 { get; set; }
        /// <summary>
        // Measurement significance
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public virtual string MeasurementSignificance_02 { get; set; }
        /// <summary>
        // Measurement attribute
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6155", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string MeasurementAttribute_03 { get; set; }
    }
    
    /// <summary>
    // DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C503")]
    public class C503
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Document/message number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DocumentmessageNumber_01 { get; set; }
        /// <summary>
        // Document/message status
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1373", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DocumentmessageStatus_02 { get; set; }
        /// <summary>
        // Document/message source
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string DocumentmessageSource_03 { get; set; }
        /// <summary>
        // Language
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_ID_3453))]
        [Pos(4)]
        public virtual string Language_04 { get; set; }
    }
    
    /// <summary>
    // CURRENCY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C504")]
    public class C504
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Currency details qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("6347", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string CurrencyDetailsQualifier_01 { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(2)]
        public virtual string Currency_02 { get; set; }
        /// <summary>
        // Currency qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6343", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string CurrencyQualifier_03 { get; set; }
        /// <summary>
        // Currency rate base
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string CurrencyRateBase_04 { get; set; }
    }
    
    /// <summary>
    // REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Reference qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public virtual string ReferenceQualifier_01 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ReferenceNumber_02 { get; set; }
        /// <summary>
        // Line number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string LineNumber_03 { get; set; }
        /// <summary>
        // Reference version number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string ReferenceVersionNumber_04 { get; set; }
    }
    
    /// <summary>
    // DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Date/Time/Period qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public virtual string DateTimePeriodQualifier_01 { get; set; }
        /// <summary>
        // Date/Time/Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DateTimePeriod_02 { get; set; }
        /// <summary>
        // Date/time/period format qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2379", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string DatetimeperiodFormatQualifier_03 { get; set; }
    }
    
    /// <summary>
    // PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Price qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("5125", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PriceQualifier_01 { get; set; }
        /// <summary>
        // Price
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string Price_02 { get; set; }
        /// <summary>
        // Price type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5375", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string PriceType_03 { get; set; }
        /// <summary>
        // Price type qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public virtual string PriceTypeQualifier_04 { get; set; }
        /// <summary>
        // Unit price basis
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string UnitPriceBasis_05 { get; set; }
        /// <summary>
        // Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(6)]
        public virtual string MeasureUnitQualifier_06 { get; set; }
    }
    
    /// <summary>
    // MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Monetary amount type qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public virtual string MonetaryAmountTypeQualifier_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public virtual string Currency_03 { get; set; }
        /// <summary>
        // Currency qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6343", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string CurrencyQualifier_04 { get; set; }
        /// <summary>
        // Status
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public virtual string Status_05 { get; set; }
    }
    
    /// <summary>
    // LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C517")]
    public class C517
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
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Place/location
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string Placelocation_04 { get; set; }
    }
    
    /// <summary>
    // RELATED LOCATION ONE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C519")]
    public class C519
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Related place/location one identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string RelatedPlacelocationOneIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Related place/location one
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string RelatedPlacelocationOne_04 { get; set; }
    }
    
    /// <summary>
    // DUTY/TAX/FEE ACCOUNT DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C533")]
    public class C533
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Duty/tax/fee account identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DutytaxfeeAccountIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }
    
    /// <summary>
    // PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Payment conditions
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public virtual string PaymentConditions_01 { get; set; }
        /// <summary>
        // Payment guarantee
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4431", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PaymentGuarantee_02 { get; set; }
        /// <summary>
        // Payment means
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4461", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string PaymentMeans_03 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public virtual string CodeListQualifier_04 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public virtual string CodeListResponsibleAgency_05 { get; set; }
        /// <summary>
        // Payment channel
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4435", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string PaymentChannel_06 { get; set; }
    }
    
    /// <summary>
    // REQUIREMENT/CONDITION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C550")]
    public class C550
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Requirement/condition identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("7295", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string RequirementconditionIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Requirement or condition
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string RequirementOrCondition_04 { get; set; }
    }
    
    /// <summary>
    // ALLOWANCE/CHARGE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C552")]
    public class C552
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Allowance or charge number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string AllowanceOrChargeNumber_01 { get; set; }
        /// <summary>
        // Charge/allowance description
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5189", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ChargeallowanceDescription_02 { get; set; }
    }
    
    /// <summary>
    // RELATED LOCATION TWO IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C553")]
    public class C553
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Related place/location two identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string RelatedPlacelocationTwoIdentification_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Related place/location two
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string RelatedPlacelocationTwo_04 { get; set; }
    }
    
    /// <summary>
    // COUPON INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C640")]
    public class C640
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(1)]
        public virtual string SequenceNumber_01 { get; set; }
        /// <summary>
        // Status
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(2)]
        public virtual string Status_02 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string MonetaryAmount_03 { get; set; }
        /// <summary>
        // Sequence number source
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1159", typeof(EDIFACT_ID_1159))]
        [Pos(4)]
        public virtual string SequenceNumberSource_04 { get; set; }
        /// <summary>
        // Control identification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9887", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string ControlIdentification_05 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(6)]
        public virtual string StatusIndicator_06 { get; set; }
        /// <summary>
        // Status
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(7)]
        public virtual string Status_07 { get; set; }
        /// <summary>
        // Sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(8)]
        public virtual string SequenceNumber_08 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string ReferenceNumber_09 { get; set; }
        /// <summary>
        // Action request / notification
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(10)]
        public virtual string ActionRequestNotification_10 { get; set; }
    }
    
    /// <summary>
    // INTERNAL IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C642")]
    public class C642
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // In-house identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 9)]
        [DataElement("9902", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string InhouseIdentification_01 { get; set; }
        /// <summary>
        // Identification type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9893", typeof(EDIFACT_ID_9893))]
        [Pos(2)]
        public virtual string IdentificationType_02 { get; set; }
        /// <summary>
        // Travel agent identification details
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("9900", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string TravelAgentIdentificationDetails_03 { get; set; }
    }
    
    /// <summary>
    // RATE/TARIFF CLASS INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C643")]
    public class C643
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string RateTariffClass_01 { get; set; }
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(2)]
        public virtual string DataIndicator_02 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string RateTariffClass_03 { get; set; }
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(4)]
        public virtual string DataIndicator_04 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string RateTariffClass_05 { get; set; }
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(6)]
        public virtual string DataIndicator_06 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string RateTariffClass_07 { get; set; }
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(8)]
        public virtual string DataIndicator_08 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string RateTariffClass_09 { get; set; }
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(10)]
        public virtual string DataIndicator_10 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string RateTariffClass_11 { get; set; }
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(12)]
        public virtual string DataIndicator_12 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(13)]
        public virtual string RateTariffClass_13 { get; set; }
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(14)]
        public virtual string DataIndicator_14 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(15)]
        public virtual string RateTariffClass_15 { get; set; }
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(16)]
        public virtual string DataIndicator_16 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(17)]
        public virtual string RateTariffClass_17 { get; set; }
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(18)]
        public virtual string DataIndicator_18 { get; set; }
    }
    
    /// <summary>
    // FARE QUALIFIER INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C645")]
    public class C645
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Fare qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9910", typeof(EDIFACT_ID_9910))]
        [Pos(1)]
        public virtual string FareQualifier_01 { get; set; }
        /// <summary>
        // Fare qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9910", typeof(EDIFACT_ID_9910))]
        [Pos(2)]
        public virtual string FareQualifier_02 { get; set; }
        /// <summary>
        // Fare qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9910", typeof(EDIFACT_ID_9910))]
        [Pos(3)]
        public virtual string FareQualifier_03 { get; set; }
    }
    
    /// <summary>
    // ADDITIONAL FARE QUALIFIER DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C646")]
    public class C646
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string RateTariffClass_01 { get; set; }
        /// <summary>
        // Commodity/rate identification
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("7357", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string CommodityrateIdentification_02 { get; set; }
        /// <summary>
        // Pricing Group
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5388", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string PricingGroup_03 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string RateTariffClass_04 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string RateTariffClass_05 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string RateTariffClass_06 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string RateTariffClass_07 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string RateTariffClass_08 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string RateTariffClass_09 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string RateTariffClass_10 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string RateTariffClass_11 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string RateTariffClass_12 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(13)]
        public virtual string RateTariffClass_13 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(14)]
        public virtual string RateTariffClass_14 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(15)]
        public virtual string RateTariffClass_15 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(16)]
        public virtual string RateTariffClass_16 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(17)]
        public virtual string RateTariffClass_17 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(18)]
        public virtual string RateTariffClass_18 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(19)]
        public virtual string RateTariffClass_19 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(20)]
        public virtual string RateTariffClass_20 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(21)]
        public virtual string RateTariffClass_21 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(22)]
        public virtual string RateTariffClass_22 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(23)]
        public virtual string RateTariffClass_23 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(24)]
        public virtual string RateTariffClass_24 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(25)]
        public virtual string RateTariffClass_25 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(26)]
        public virtual string RateTariffClass_26 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(27)]
        public virtual string RateTariffClass_27 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(28)]
        public virtual string RateTariffClass_28 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(29)]
        public virtual string RateTariffClass_29 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(30)]
        public virtual string RateTariffClass_30 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(31)]
        public virtual string RateTariffClass_31 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(32)]
        public virtual string RateTariffClass_32 { get; set; }
    }
    
    /// <summary>
    // FARE CATEGORY CODES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C647")]
    public class C647
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Rate type identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 20)]
        [DataElement("5263", typeof(EDIFACT_ID_5263))]
        [Pos(1)]
        public virtual string RateTypeIdentification_01 { get; set; }
        /// <summary>
        // Rate type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("5263", typeof(EDIFACT_ID_5263))]
        [Pos(2)]
        public virtual string RateTypeIdentification_02 { get; set; }
        /// <summary>
        // Rate type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("5263", typeof(EDIFACT_ID_5263))]
        [Pos(3)]
        public virtual string RateTypeIdentification_03 { get; set; }
        /// <summary>
        // Rate type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("5263", typeof(EDIFACT_ID_5263))]
        [Pos(4)]
        public virtual string RateTypeIdentification_04 { get; set; }
        /// <summary>
        // Rate type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("5263", typeof(EDIFACT_ID_5263))]
        [Pos(5)]
        public virtual string RateTypeIdentification_05 { get; set; }
        /// <summary>
        // Rate type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("5263", typeof(EDIFACT_ID_5263))]
        [Pos(6)]
        public virtual string RateTypeIdentification_06 { get; set; }
        /// <summary>
        // Rate type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("5263", typeof(EDIFACT_ID_5263))]
        [Pos(7)]
        public virtual string RateTypeIdentification_07 { get; set; }
        /// <summary>
        // Rate type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("5263", typeof(EDIFACT_ID_5263))]
        [Pos(8)]
        public virtual string RateTypeIdentification_08 { get; set; }
        /// <summary>
        // Rate type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("5263", typeof(EDIFACT_ID_5263))]
        [Pos(9)]
        public virtual string RateTypeIdentification_09 { get; set; }
    }
    
    /// <summary>
    // DISCOUNT/PENALTY INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C648")]
    public class C648
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Fare qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9910", typeof(EDIFACT_ID_9910))]
        [Pos(1)]
        public virtual string FareQualifier_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string Percentage_03 { get; set; }
    }
    
    /// <summary>
    // DISCOUNT/PENALTY MONETARY INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C649")]
    public class C649
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Monetary function
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5007", typeof(EDIFACT_ID_5007))]
        [Pos(1)]
        public virtual string MonetaryFunction_01 { get; set; }
        /// <summary>
        // Monetary amount type qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(2)]
        public virtual string MonetaryAmountTypeQualifier_02 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string MonetaryAmount_03 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string RateTariffClass_04 { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(5)]
        public virtual string Currency_05 { get; set; }
    }
    
    /// <summary>
    // PRODUCT/ACCOUNT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C650")]
    public class C650
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Item number type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(1)]
        public virtual string ItemNumberType_01 { get; set; }
        /// <summary>
        // Frequent traveler identification code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 25)]
        [DataElement("9948", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string FrequentTravelerIdentificationCode_02 { get; set; }
        /// <summary>
        // Rate/tariff class identification
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("5243", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string RatetariffClassIdentification_03 { get; set; }
        /// <summary>
        // Sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(4)]
        public virtual string SequenceNumber_04 { get; set; }
        /// <summary>
        // Reference version number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string ReferenceVersionNumber_05 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string RateTariffClass_06 { get; set; }
        /// <summary>
        // Approval identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("9889", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string ApprovalIdentification_07 { get; set; }
    }
    
    /// <summary>
    // VALID DATE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C651")]
    public class C651
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string FirstDate_01 { get; set; }
        /// <summary>
        // Second date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9920", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string SecondDate_02 { get; set; }
    }
    
    /// <summary>
    // ACCOUNT HOLDER INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C652")]
    public class C652
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Traveler surname
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("9936", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TravelerSurname_01 { get; set; }
        /// <summary>
        // Traveler given name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("9942", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string TravelerGivenName_02 { get; set; }
        /// <summary>
        // Institution name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3432", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string InstitutionName_03 { get; set; }
    }
    
    /// <summary>
    // INSTRUCTION INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C654")]
    public class C654
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Instruction
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4401", typeof(EDIFACT_ID_4401))]
        [Pos(1)]
        public virtual string Instruction_01 { get; set; }
        /// <summary>
        // Instruction qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4403", typeof(EDIFACT_ID_4403))]
        [Pos(2)]
        public virtual string InstructionQualifier_02 { get; set; }
    }
    
    /// <summary>
    // MESSAGE/APPLICATION/PRODUCT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C655")]
    public class C655
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Message function
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(1)]
        public virtual string MessageFunction_01 { get; set; }
        /// <summary>
        // Application identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("9755", typeof(EDIFACT_ID_9755))]
        [Pos(2)]
        public virtual string ApplicationIdentification_02 { get; set; }
        /// <summary>
        // Application identification qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9756", typeof(EDIFACT_ID_9756))]
        [Pos(3)]
        public virtual string ApplicationIdentificationQualifier_03 { get; set; }
        /// <summary>
        // Country
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(4)]
        public virtual string Country_04 { get; set; }
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string FirstDate_05 { get; set; }
        /// <summary>
        // Second date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9920", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string SecondDate_06 { get; set; }
        /// <summary>
        // Number of units
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(7)]
        public virtual string NumberOfUnits_07 { get; set; }
    }
    
    /// <summary>
    // STATUS DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C656")]
    public class C656
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(1)]
        public virtual string StatusIndicator_01 { get; set; }
        /// <summary>
        // Action request / notification
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public virtual string ActionRequestNotification_02 { get; set; }
        /// <summary>
        // Status type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9015", typeof(EDIFACT_ID_9015))]
        [Pos(3)]
        public virtual string StatusType_03 { get; set; }
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
    // QUANTITY AND ACTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C657")]
    public class C657
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string Quantity_01 { get; set; }
        /// <summary>
        // Option
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9750", typeof(EDIFACT_ID_9750))]
        [Pos(2)]
        public virtual string Option_02 { get; set; }
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
    // DATA TYPE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C658")]
    public class C658
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Data type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9989", typeof(EDIFACT_ID_9989))]
        [Pos(1)]
        public virtual string DataType_01 { get; set; }
        /// <summary>
        // Status event
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9011", typeof(EDIFACT_ID_9011))]
        [Pos(2)]
        public virtual string StatusEvent_02 { get; set; }
    }
    
    /// <summary>
    // DATA INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C659")]
    public class C659
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(1)]
        public virtual string DataIndicator_01 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string Quantity_02 { get; set; }
        /// <summary>
        // Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(3)]
        public virtual string MeasureUnitQualifier_03 { get; set; }
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
    // SELECTION DETAILS INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C660")]
    public class C660
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Option
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9750", typeof(EDIFACT_ID_9750))]
        [Pos(1)]
        public virtual string Option_01 { get; set; }
        /// <summary>
        // Associated option information
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9749", typeof(EDIFACT_ID_9749))]
        [Pos(2)]
        public virtual string AssociatedOptionInformation_02 { get; set; }
    }
    
    /// <summary>
    // CONVERSION RATE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C661")]
    public class C661
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Conversion type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9875", typeof(EDIFACT_ID_9875))]
        [Pos(1)]
        public virtual string ConversionType_01 { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(2)]
        public virtual string Currency_02 { get; set; }
        /// <summary>
        // Rate type qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5419", typeof(EDIFACT_ID_5419))]
        [Pos(3)]
        public virtual string RateTypeQualifier_03 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string MonetaryAmount_04 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string MonetaryAmount_05 { get; set; }
        /// <summary>
        // Duty/Tax fee type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(6)]
        public virtual string DutyTaxFeeType_06 { get; set; }
        /// <summary>
        // Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(7)]
        public virtual string MeasurementValue_07 { get; set; }
        /// <summary>
        // Measurement significance
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(8)]
        public virtual string MeasurementSignificance_08 { get; set; }
    }
    
    /// <summary>
    // MULTIPLE IDENTIFICATION NUMBERS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C669")]
    public class C669
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string IdentityNumber_01 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string IdentityNumber_02 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string IdentityNumber_03 { get; set; }
    }
    
    /// <summary>
    // PROCESSING INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C672")]
    public class C672
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Message function
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(1)]
        public virtual string MessageFunction_01 { get; set; }
        /// <summary>
        // Reference qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(2)]
        public virtual string ReferenceQualifier_02 { get; set; }
        /// <summary>
        // Sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(3)]
        public virtual string SequenceNumber_03 { get; set; }
    }
    
    /// <summary>
    // REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C673")]
    public class C673
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sequence number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1050", typeof(EDIFACT_ID_1050))]
        [Pos(1)]
        public virtual string SequenceNumber_01 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ReferenceNumber_02 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ReferenceNumber_03 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string ReferenceNumber_04 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string ReferenceNumber_05 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string ReferenceNumber_06 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string ReferenceNumber_07 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string ReferenceNumber_08 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string ReferenceNumber_09 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string ReferenceNumber_10 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string ReferenceNumber_11 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string ReferenceNumber_12 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(13)]
        public virtual string ReferenceNumber_13 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(14)]
        public virtual string ReferenceNumber_14 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(15)]
        public virtual string ReferenceNumber_15 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(16)]
        public virtual string ReferenceNumber_16 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(17)]
        public virtual string ReferenceNumber_17 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(18)]
        public virtual string ReferenceNumber_18 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(19)]
        public virtual string ReferenceNumber_19 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(20)]
        public virtual string ReferenceNumber_20 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(21)]
        public virtual string ReferenceNumber_21 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(22)]
        public virtual string ReferenceNumber_22 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(23)]
        public virtual string ReferenceNumber_23 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(24)]
        public virtual string ReferenceNumber_24 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(25)]
        public virtual string ReferenceNumber_25 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(26)]
        public virtual string ReferenceNumber_26 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(27)]
        public virtual string ReferenceNumber_27 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(28)]
        public virtual string ReferenceNumber_28 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(29)]
        public virtual string ReferenceNumber_29 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(30)]
        public virtual string ReferenceNumber_30 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(31)]
        public virtual string ReferenceNumber_31 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(32)]
        public virtual string ReferenceNumber_32 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(33)]
        public virtual string ReferenceNumber_33 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(34)]
        public virtual string ReferenceNumber_34 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(35)]
        public virtual string ReferenceNumber_35 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(36)]
        public virtual string ReferenceNumber_36 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(37)]
        public virtual string ReferenceNumber_37 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(38)]
        public virtual string ReferenceNumber_38 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(39)]
        public virtual string ReferenceNumber_39 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(40)]
        public virtual string ReferenceNumber_40 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(41)]
        public virtual string ReferenceNumber_41 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(42)]
        public virtual string ReferenceNumber_42 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(43)]
        public virtual string ReferenceNumber_43 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(44)]
        public virtual string ReferenceNumber_44 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(45)]
        public virtual string ReferenceNumber_45 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(46)]
        public virtual string ReferenceNumber_46 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(47)]
        public virtual string ReferenceNumber_47 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(48)]
        public virtual string ReferenceNumber_48 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(49)]
        public virtual string ReferenceNumber_49 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(50)]
        public virtual string ReferenceNumber_50 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(51)]
        public virtual string ReferenceNumber_51 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(52)]
        public virtual string ReferenceNumber_52 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(53)]
        public virtual string ReferenceNumber_53 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(54)]
        public virtual string ReferenceNumber_54 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(55)]
        public virtual string ReferenceNumber_55 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(56)]
        public virtual string ReferenceNumber_56 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(57)]
        public virtual string ReferenceNumber_57 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(58)]
        public virtual string ReferenceNumber_58 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(59)]
        public virtual string ReferenceNumber_59 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(60)]
        public virtual string ReferenceNumber_60 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(61)]
        public virtual string ReferenceNumber_61 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(62)]
        public virtual string ReferenceNumber_62 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(63)]
        public virtual string ReferenceNumber_63 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(64)]
        public virtual string ReferenceNumber_64 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(65)]
        public virtual string ReferenceNumber_65 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(66)]
        public virtual string ReferenceNumber_66 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(67)]
        public virtual string ReferenceNumber_67 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(68)]
        public virtual string ReferenceNumber_68 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(69)]
        public virtual string ReferenceNumber_69 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(70)]
        public virtual string ReferenceNumber_70 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(71)]
        public virtual string ReferenceNumber_71 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(72)]
        public virtual string ReferenceNumber_72 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(73)]
        public virtual string ReferenceNumber_73 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(74)]
        public virtual string ReferenceNumber_74 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(75)]
        public virtual string ReferenceNumber_75 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(76)]
        public virtual string ReferenceNumber_76 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(77)]
        public virtual string ReferenceNumber_77 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(78)]
        public virtual string ReferenceNumber_78 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(79)]
        public virtual string ReferenceNumber_79 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(80)]
        public virtual string ReferenceNumber_80 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(81)]
        public virtual string ReferenceNumber_81 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(82)]
        public virtual string ReferenceNumber_82 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(83)]
        public virtual string ReferenceNumber_83 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(84)]
        public virtual string ReferenceNumber_84 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(85)]
        public virtual string ReferenceNumber_85 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(86)]
        public virtual string ReferenceNumber_86 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(87)]
        public virtual string ReferenceNumber_87 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(88)]
        public virtual string ReferenceNumber_88 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(89)]
        public virtual string ReferenceNumber_89 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(90)]
        public virtual string ReferenceNumber_90 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(91)]
        public virtual string ReferenceNumber_91 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(92)]
        public virtual string ReferenceNumber_92 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(93)]
        public virtual string ReferenceNumber_93 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(94)]
        public virtual string ReferenceNumber_94 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(95)]
        public virtual string ReferenceNumber_95 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(96)]
        public virtual string ReferenceNumber_96 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(97)]
        public virtual string ReferenceNumber_97 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(98)]
        public virtual string ReferenceNumber_98 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(99)]
        public virtual string ReferenceNumber_99 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(100)]
        public virtual string ReferenceNumber_100 { get; set; }
    }
    
    /// <summary>
    // MESSAGE CONDITIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C676")]
    public class C676
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Communication channel identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(1)]
        public virtual string CommunicationChannelIdentifier_01 { get; set; }
        /// <summary>
        // Number of units
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string NumberOfUnits_02 { get; set; }
        /// <summary>
        // Processing indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_ID_7365))]
        [Pos(3)]
        public virtual string ProcessingIndicator_03 { get; set; }
        /// <summary>
        // Processing indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_ID_7365))]
        [Pos(4)]
        public virtual string ProcessingIndicator_04 { get; set; }
        /// <summary>
        // Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_ID_6411))]
        [Pos(5)]
        public virtual string MeasureUnitQualifier_05 { get; set; }
        /// <summary>
        // Total number of items
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7240", typeof(EDIFACT_N))]
        [Pos(6)]
        public virtual string TotalNumberOfItems_06 { get; set; }
        /// <summary>
        // Relation
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(7)]
        public virtual string Relation_07 { get; set; }
        /// <summary>
        // Relation
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(8)]
        public virtual string Relation_08 { get; set; }
        /// <summary>
        // Relation
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(9)]
        public virtual string Relation_09 { get; set; }
        /// <summary>
        // Relation
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(10)]
        public virtual string Relation_10 { get; set; }
        /// <summary>
        // Relation
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(11)]
        public virtual string Relation_11 { get; set; }
        /// <summary>
        // Relation
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(12)]
        public virtual string Relation_12 { get; set; }
        /// <summary>
        // Relation
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(13)]
        public virtual string Relation_13 { get; set; }
        /// <summary>
        // Relation
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(14)]
        public virtual string Relation_14 { get; set; }
        /// <summary>
        // Relation
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_ID_5479))]
        [Pos(15)]
        public virtual string Relation_15 { get; set; }
    }
    
    /// <summary>
    // MESSAGE EQUIPMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C677")]
    public class C677
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Equipment qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("8053", typeof(EDIFACT_ID_8053))]
        [Pos(1)]
        public virtual string EquipmentQualifier_01 { get; set; }
        /// <summary>
        // Equipment status
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8249", typeof(EDIFACT_ID_8249))]
        [Pos(2)]
        public virtual string EquipmentStatus_02 { get; set; }
        /// <summary>
        // Equipment size and type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("8155", typeof(EDIFACT_ID_8155))]
        [Pos(3)]
        public virtual string EquipmentSizeAndTypeIdentification_03 { get; set; }
    }
    
    /// <summary>
    // SPECIFIC TRAVELLER DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C684")]
    public class C684
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Traveler reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("9944", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string TravelerReferenceNumber_01 { get; set; }
        /// <summary>
        // Measurement value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string MeasurementValue_02 { get; set; }
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FirstDate_03 { get; set; }
        /// <summary>
        // Traveler surname
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("9936", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string TravelerSurname_04 { get; set; }
        /// <summary>
        // Traveler given name
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("9942", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string TravelerGivenName_05 { get; set; }
    }
    
    /// <summary>
    // CLASS INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C687")]
    public class C687
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Characteristic identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_ID_7037))]
        [Pos(1)]
        public virtual string CharacteristicIdentification_01 { get; set; }
        /// <summary>
        // Cabin class of service
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9873", typeof(EDIFACT_ID_9873))]
        [Pos(2)]
        public virtual string CabinClassOfService_02 { get; set; }
    }
    
    /// <summary>
    // TRAVELLER INDICATORS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C689")]
    public class C689
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(1)]
        public virtual string StatusIndicator_01 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(2)]
        public virtual string StatusIndicator_02 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(3)]
        public virtual string StatusIndicator_03 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(4)]
        public virtual string StatusIndicator_04 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(5)]
        public virtual string StatusIndicator_05 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(6)]
        public virtual string StatusIndicator_06 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(7)]
        public virtual string StatusIndicator_07 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(8)]
        public virtual string StatusIndicator_08 { get; set; }
        /// <summary>
        // Status indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1245", typeof(EDIFACT_ID_1245))]
        [Pos(9)]
        public virtual string StatusIndicator_09 { get; set; }
    }
    
    /// <summary>
    // PAX ID DETAILS IN QUERYING SYSTEM
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C690")]
    public class C690
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Unique passenger reference
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("9821", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string UniquePassengerReference_01 { get; set; }
        /// <summary>
        // Unique passenger reference
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("9821", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string UniquePassengerReference_02 { get; set; }
    }
    
    /// <summary>
    // PAX ID DETAILS IN THIRD PARTY SYSTEM
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C691")]
    public class C691
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Unique passenger reference
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("9821", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string UniquePassengerReference_01 { get; set; }
        /// <summary>
        // Unique passenger reference
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("9821", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string UniquePassengerReference_02 { get; set; }
    }
    
    /// <summary>
    // PAX ID DETAILS IN RESPONDING SYSTEM
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C692")]
    public class C692
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Unique passenger reference
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("9821", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string UniquePassengerReference_01 { get; set; }
        /// <summary>
        // Unique passenger reference
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("9821", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string UniquePassengerReference_02 { get; set; }
    }
    
    /// <summary>
    // BAGTAG STUB INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C693")]
    public class C693
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(1)]
        public virtual string CarrierIdentification_01 { get; set; }
        /// <summary>
        // Flight number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("3802", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string FlightNumber_02 { get; set; }
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
        // Reservation booking designator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9800", typeof(EDIFACT_ID_9800))]
        [Pos(5)]
        public virtual string ReservationBookingDesignator_05 { get; set; }
        /// <summary>
        // Operational suffix to the carrier code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9801", typeof(EDIFACT_A))]
        [Pos(6)]
        public virtual string OperationalSuffixToTheCarrierCode_06 { get; set; }
    }
    
    /// <summary>
    // BAG POOL REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C694")]
    public class C694
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Update action code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9858", typeof(EDIFACT_ID_9858))]
        [Pos(1)]
        public virtual string UpdateActionCode_01 { get; set; }
        /// <summary>
        // Processing indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_ID_7365))]
        [Pos(2)]
        public virtual string ProcessingIndicator_02 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string IdentityNumber_03 { get; set; }
    }
    
    /// <summary>
    // UPDATE BAGTAG STUB INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C695")]
    public class C695
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Update action code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("9858", typeof(EDIFACT_ID_9858))]
        [Pos(1)]
        public virtual string UpdateActionCode_01 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(2)]
        public virtual string CarrierIdentification_02 { get; set; }
        /// <summary>
        // Flight number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("3802", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string FlightNumber_03 { get; set; }
        /// <summary>
        // Departure date and time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("2281", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string DepartureDateAndTime_04 { get; set; }
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
        // Reservation booking designator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9800", typeof(EDIFACT_ID_9800))]
        [Pos(6)]
        public virtual string ReservationBookingDesignator_06 { get; set; }
        /// <summary>
        // Operational suffix to the carrier code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9801", typeof(EDIFACT_A))]
        [Pos(7)]
        public virtual string OperationalSuffixToTheCarrierCode_07 { get; set; }
    }
    
    /// <summary>
    // HOST DEFINITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C696")]
    public class C696
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Host qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9803", typeof(EDIFACT_ID_9803))]
        [Pos(1)]
        public virtual string HostQualifier_01 { get; set; }
        /// <summary>
        // Host definition numeric
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9804", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string HostDefinitionNumeric_02 { get; set; }
        /// <summary>
        // Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_ID_3127))]
        [Pos(3)]
        public virtual string CarrierIdentification_03 { get; set; }
    }
    
    /// <summary>
    // DOCUMENT ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C700")]
    public class C700
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Processing indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7365", typeof(EDIFACT_ID_7365))]
        [Pos(1)]
        public virtual string ProcessingIndicator_01 { get; set; }
        /// <summary>
        // Document/message number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DocumentmessageNumber_02 { get; set; }
        /// <summary>
        // Country
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_ID_3207))]
        [Pos(3)]
        public virtual string Country_03 { get; set; }
        /// <summary>
        // Confirmation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9813", typeof(EDIFACT_ID_9813))]
        [Pos(4)]
        public virtual string ConfirmationIndicator_04 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string FreeText_05 { get; set; }
        /// <summary>
        // Date/Time/Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string DateTimePeriod_06 { get; set; }
        /// <summary>
        // Number of units qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6353", typeof(EDIFACT_ID_6353))]
        [Pos(7)]
        public virtual string NumberOfUnitsQualifier_07 { get; set; }
        /// <summary>
        // Source
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9890", typeof(EDIFACT_ID_9890))]
        [Pos(8)]
        public virtual string Source_08 { get; set; }
        /// <summary>
        // Country sub-entity name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3228", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string CountrySubentityName_09 { get; set; }
        /// <summary>
        // City name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string CityName_10 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string PartyName_11 { get; set; }
        /// <summary>
        // Date/Time/Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string DateTimePeriod_12 { get; set; }
        /// <summary>
        // Surname
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("3808", typeof(EDIFACT_A))]
        [Pos(13)]
        public virtual string Surname_13 { get; set; }
        /// <summary>
        // Given name
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("3809", typeof(EDIFACT_A))]
        [Pos(14)]
        public virtual string GivenName_14 { get; set; }
        /// <summary>
        // Other names
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("9754", typeof(EDIFACT_AN))]
        [Pos(15)]
        public virtual string OtherNames_15 { get; set; }
        /// <summary>
        // Confirmation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9813", typeof(EDIFACT_ID_9813))]
        [Pos(16)]
        public virtual string ConfirmationIndicator_16 { get; set; }
        /// <summary>
        // Confirmation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9813", typeof(EDIFACT_ID_9813))]
        [Pos(17)]
        public virtual string ConfirmationIndicator_17 { get; set; }
        /// <summary>
        // Confirmation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9813", typeof(EDIFACT_ID_9813))]
        [Pos(18)]
        public virtual string ConfirmationIndicator_18 { get; set; }
        /// <summary>
        // Confirmation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9813", typeof(EDIFACT_ID_9813))]
        [Pos(19)]
        public virtual string ConfirmationIndicator_19 { get; set; }
        /// <summary>
        // Confirmation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9813", typeof(EDIFACT_ID_9813))]
        [Pos(20)]
        public virtual string ConfirmationIndicator_20 { get; set; }
        /// <summary>
        // Confirmation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9813", typeof(EDIFACT_ID_9813))]
        [Pos(21)]
        public virtual string ConfirmationIndicator_21 { get; set; }
        /// <summary>
        // Confirmation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9813", typeof(EDIFACT_ID_9813))]
        [Pos(22)]
        public virtual string ConfirmationIndicator_22 { get; set; }
        /// <summary>
        // Confirmation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9813", typeof(EDIFACT_ID_9813))]
        [Pos(23)]
        public virtual string ConfirmationIndicator_23 { get; set; }
        /// <summary>
        // Confirmation indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("9813", typeof(EDIFACT_ID_9813))]
        [Pos(24)]
        public virtual string ConfirmationIndicator_24 { get; set; }
        /// <summary>
        // Place/location
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(25)]
        public virtual string Placelocation_25 { get; set; }
    }
    
    /// <summary>
    // PASSENGER CONTACT DATA
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C701")]
    public class C701
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Surname
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("3808", typeof(EDIFACT_A))]
        [Pos(1)]
        public virtual string Surname_01 { get; set; }
        /// <summary>
        // Given name
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("3809", typeof(EDIFACT_A))]
        [Pos(2)]
        public virtual string GivenName_02 { get; set; }
        /// <summary>
        // Communication number
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string CommunicationNumber_03 { get; set; }
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
    // SUB-LINE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C829")]
    public class C829
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Sub-line indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5495", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string SublineIndicator_01 { get; set; }
        /// <summary>
        // Line item number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string LineItemNumber_02 { get; set; }
    }
    
    /// <summary>
    // ATTRIBUTE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C955")]
    public class C955
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Attribute type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9021", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string AttributeType_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }
    
    /// <summary>
    // ATTRIBUTE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C956")]
    public class C956
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Attribute
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9019", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string Attribute_01 { get; set; }
        /// <summary>
        // Code list qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Code list responsible agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
        /// <summary>
        // Attribute
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9018", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string Attribute_04 { get; set; }
    }
    
    /// <summary>
    // COMMISSION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C957")]
    public class C957
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Payment conditions
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public virtual string PaymentConditions_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public virtual string Currency_03 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PartyName_04 { get; set; }
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
    // SERVICE DATE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C959")]
    public class C959
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Special service
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public virtual string SpecialService_01 { get; set; }
        /// <summary>
        // First time
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9918", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string FirstTime_02 { get; set; }
        /// <summary>
        // Second time
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9922", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string SecondTime_03 { get; set; }
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FirstDate_04 { get; set; }
        /// <summary>
        // Place/location
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string Placelocation_05 { get; set; }
    }
    
    /// <summary>
    // CONSUMER REFERENCE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C967")]
    public class C967
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Reference qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public virtual string ReferenceQualifier_01 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ReferenceNumber_02 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string PartyName_03 { get; set; }
        /// <summary>
        // Traveler reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("9944", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string TravelerReferenceNumber_04 { get; set; }
    }
    
    /// <summary>
    // PAYMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C977")]
    public class C977
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Form of payment identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("5903", typeof(EDIFACT_ID_5903))]
        [Pos(1)]
        public virtual string FormOfPaymentIdentification_01 { get; set; }
        /// <summary>
        // Payment type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("5905", typeof(EDIFACT_ID_5905))]
        [Pos(2)]
        public virtual string PaymentTypeIdentification_02 { get; set; }
        /// <summary>
        // Service to be paid
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5909", typeof(EDIFACT_ID_5909))]
        [Pos(3)]
        public virtual string ServiceToBePaid_03 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string MonetaryAmount_04 { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(5)]
        public virtual string Currency_05 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string ReferenceNumber_06 { get; set; }
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string FirstDate_07 { get; set; }
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string PlacelocationIdentification_08 { get; set; }
    }
    
    /// <summary>
    // CREDIT CARD INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C978")]
    public class C978
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PartyName_01 { get; set; }
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ReferenceNumber_02 { get; set; }
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FirstDate_03 { get; set; }
        /// <summary>
        // Bank identification
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("3901", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string BankIdentification_04 { get; set; }
        /// <summary>
        // Traveler reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("9944", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string TravelerReferenceNumber_05 { get; set; }
    }
    
    /// <summary>
    // FARE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C980")]
    public class C980
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(1)]
        public virtual string DataIndicator_01 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string Quantity_02 { get; set; }
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FirstDate_03 { get; set; }
        /// <summary>
        // Pricing Group
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5388", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PricingGroup_04 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string RateTariffClass_05 { get; set; }
    }
    
    /// <summary>
    // CORPORATE FARE IDENTIFIERS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C981")]
    public class C981
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Fare qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9910", typeof(EDIFACT_ID_9910))]
        [Pos(1)]
        public virtual string FareQualifier_01 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string IdentityNumber_02 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string IdentityNumber_03 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string IdentityNumber_04 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string IdentityNumber_05 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string IdentityNumber_06 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string IdentityNumber_07 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string IdentityNumber_08 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string IdentityNumber_09 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string IdentityNumber_10 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string IdentityNumber_11 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string IdentityNumber_12 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(13)]
        public virtual string IdentityNumber_13 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(14)]
        public virtual string IdentityNumber_14 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(15)]
        public virtual string IdentityNumber_15 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(16)]
        public virtual string IdentityNumber_16 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(17)]
        public virtual string IdentityNumber_17 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(18)]
        public virtual string IdentityNumber_18 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(19)]
        public virtual string IdentityNumber_19 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(20)]
        public virtual string IdentityNumber_20 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(21)]
        public virtual string IdentityNumber_21 { get; set; }
    }
    
    /// <summary>
    // TARIFF INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C982")]
    public class C982
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Rate type identification
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("5907", typeof(EDIFACT_ID_5907))]
        [Pos(1)]
        public virtual string RateTypeIdentification_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(3)]
        public virtual string Currency_03 { get; set; }
        /// <summary>
        // Rate plan
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5911", typeof(EDIFACT_ID_5911))]
        [Pos(4)]
        public virtual string RatePlan_04 { get; set; }
        /// <summary>
        // Monetary amount type qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(5)]
        public virtual string MonetaryAmountTypeQualifier_05 { get; set; }
        /// <summary>
        // Number of periods
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(6)]
        public virtual string NumberOfPeriods_06 { get; set; }
        /// <summary>
        // Price change indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5377", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string PriceChangeIndicator_07 { get; set; }
        /// <summary>
        // Total monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 20)]
        [DataElement("5906", typeof(EDIFACT_N))]
        [Pos(8)]
        public virtual string TotalMonetaryAmount_08 { get; set; }
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string FirstDate_09 { get; set; }
        /// <summary>
        // Second date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9920", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string SecondDate_10 { get; set; }
    }
    
    /// <summary>
    // RATE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C983")]
    public class C983
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
        // Range minimum
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string RangeMinimum_02 { get; set; }
        /// <summary>
        // Range maximum
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string RangeMaximum_03 { get; set; }
    }
    
    /// <summary>
    // ASSOCIATED CHARGES INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C984")]
    public class C984
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Charge unit
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("5901", typeof(EDIFACT_ID_5901))]
        [Pos(1)]
        public virtual string ChargeUnit_01 { get; set; }
        /// <summary>
        // Monetary amount
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string MonetaryAmount_02 { get; set; }
        /// <summary>
        // Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ItemDescription_03 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string Quantity_04 { get; set; }
        /// <summary>
        // Charge period type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2901", typeof(EDIFACT_ID_2901))]
        [Pos(5)]
        public virtual string ChargePeriodType_05 { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_ID_6345))]
        [Pos(6)]
        public virtual string Currency_06 { get; set; }
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string PlacelocationIdentification_07 { get; set; }
        /// <summary>
        // Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string FreeText_08 { get; set; }
    }
    
    /// <summary>
    // QUEUE INFORMATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C986")]
    public class C986
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(1)]
        public virtual string ItemDescriptionIdentification_01 { get; set; }
        /// <summary>
        // Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ItemDescription_02 { get; set; }
        /// <summary>
        // Relationship
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9143", typeof(EDIFACT_ID_9143))]
        [Pos(3)]
        public virtual string Relationship_03 { get; set; }
        /// <summary>
        // Total number of items
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7240", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string TotalNumberOfItems_04 { get; set; }
        /// <summary>
        // Maximum number of occurrences
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("6176", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string MaximumNumberOfOccurrences_05 { get; set; }
        /// <summary>
        // Status
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(6)]
        public virtual string Status_06 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(7)]
        public virtual string ItemDescriptionIdentification_07 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(8)]
        public virtual string ItemDescriptionIdentification_08 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(9)]
        public virtual string ItemDescriptionIdentification_09 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(10)]
        public virtual string ItemDescriptionIdentification_10 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(11)]
        public virtual string ItemDescriptionIdentification_11 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(12)]
        public virtual string ItemDescriptionIdentification_12 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(13)]
        public virtual string ItemDescriptionIdentification_13 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(14)]
        public virtual string ItemDescriptionIdentification_14 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(15)]
        public virtual string ItemDescriptionIdentification_15 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(16)]
        public virtual string ItemDescriptionIdentification_16 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(17)]
        public virtual string ItemDescriptionIdentification_17 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(18)]
        public virtual string ItemDescriptionIdentification_18 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(19)]
        public virtual string ItemDescriptionIdentification_19 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(20)]
        public virtual string ItemDescriptionIdentification_20 { get; set; }
        /// <summary>
        // Item description identification
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(EDIFACT_ID_7009))]
        [Pos(21)]
        public virtual string ItemDescriptionIdentification_21 { get; set; }
    }
    
    /// <summary>
    // SUB QUEUE INFORMATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C988")]
    public class C988
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Identification type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9893", typeof(EDIFACT_ID_9893))]
        [Pos(1)]
        public virtual string IdentificationType_01 { get; set; }
        /// <summary>
        // Item number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ItemNumber_02 { get; set; }
        /// <summary>
        // Total number of items
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7240", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string TotalNumberOfItems_03 { get; set; }
        /// <summary>
        // Maximum number of occurrences
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("6176", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string MaximumNumberOfOccurrences_04 { get; set; }
        /// <summary>
        // Status
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public virtual string Status_05 { get; set; }
        /// <summary>
        // Item description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string ItemDescription_06 { get; set; }
    }
    
    /// <summary>
    // VEHICLE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C991")]
    public class C991
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Equipment size and type
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("8154", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string EquipmentSizeAndType_01 { get; set; }
        /// <summary>
        // Identity number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string IdentityNumber_02 { get; set; }
    }
    
    /// <summary>
    // POSITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C992")]
    public class C992
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Related place/location one identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string RelatedPlacelocationOneIdentification_01 { get; set; }
        /// <summary>
        // Related place/location one identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string RelatedPlacelocationOneIdentification_02 { get; set; }
    }
    
    /// <summary>
    // TOUR DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C993")]
    public class C993
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Product identification
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9908", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ProductIdentification_01 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PartyName_02 { get; set; }
        /// <summary>
        // Length dimension
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6168", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string LengthDimension_03 { get; set; }
        /// <summary>
        // Number of stops
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9924", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string NumberOfStops_04 { get; set; }
        /// <summary>
        // Days of operation
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("9928", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string DaysOfOperation_05 { get; set; }
        /// <summary>
        // Number of units
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(6)]
        public virtual string NumberOfUnits_06 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(7)]
        public virtual string Quantity_07 { get; set; }
    }
    
    /// <summary>
    // STOPOVER INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C994")]
    public class C994
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Place/location identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PlacelocationIdentification_01 { get; set; }
        /// <summary>
        // Number of units
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6350", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string NumberOfUnits_02 { get; set; }
    }
    
    /// <summary>
    // ACCOMMODATION ALLOCATION INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C997")]
    public class C997
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Reference number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ReferenceNumber_01 { get; set; }
        /// <summary>
        // Relationship
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9143", typeof(EDIFACT_ID_9143))]
        [Pos(2)]
        public virtual string Relationship_02 { get; set; }
        /// <summary>
        // Accommodation type
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("7904", typeof(EDIFACT_ID_7904))]
        [Pos(3)]
        public virtual string AccommodationType_03 { get; set; }
        /// <summary>
        // Characteristic
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7907", typeof(EDIFACT_ID_7907))]
        [Pos(4)]
        public virtual string Characteristic_04 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(5)]
        public virtual string SpecialRequirementData_05 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(6)]
        public virtual string SpecialRequirementData_06 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(7)]
        public virtual string SpecialRequirementData_07 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(8)]
        public virtual string SpecialRequirementData_08 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(9)]
        public virtual string SpecialRequirementData_09 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(10)]
        public virtual string SpecialRequirementData_10 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(11)]
        public virtual string SpecialRequirementData_11 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(12)]
        public virtual string SpecialRequirementData_12 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(13)]
        public virtual string SpecialRequirementData_13 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(14)]
        public virtual string SpecialRequirementData_14 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(15)]
        public virtual string SpecialRequirementData_15 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(16)]
        public virtual string SpecialRequirementData_16 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(17)]
        public virtual string SpecialRequirementData_17 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(18)]
        public virtual string SpecialRequirementData_18 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(19)]
        public virtual string SpecialRequirementData_19 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(20)]
        public virtual string SpecialRequirementData_20 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(21)]
        public virtual string SpecialRequirementData_21 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(22)]
        public virtual string SpecialRequirementData_22 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(23)]
        public virtual string SpecialRequirementData_23 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(24)]
        public virtual string SpecialRequirementData_24 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(25)]
        public virtual string SpecialRequirementData_25 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(26)]
        public virtual string SpecialRequirementData_26 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(27)]
        public virtual string SpecialRequirementData_27 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(28)]
        public virtual string SpecialRequirementData_28 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(29)]
        public virtual string SpecialRequirementData_29 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(30)]
        public virtual string SpecialRequirementData_30 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(31)]
        public virtual string SpecialRequirementData_31 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(32)]
        public virtual string SpecialRequirementData_32 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(33)]
        public virtual string SpecialRequirementData_33 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(34)]
        public virtual string SpecialRequirementData_34 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(35)]
        public virtual string SpecialRequirementData_35 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(36)]
        public virtual string SpecialRequirementData_36 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(37)]
        public virtual string SpecialRequirementData_37 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(38)]
        public virtual string SpecialRequirementData_38 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(39)]
        public virtual string SpecialRequirementData_39 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(40)]
        public virtual string SpecialRequirementData_40 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(41)]
        public virtual string SpecialRequirementData_41 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(42)]
        public virtual string SpecialRequirementData_42 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(43)]
        public virtual string SpecialRequirementData_43 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(44)]
        public virtual string SpecialRequirementData_44 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(45)]
        public virtual string SpecialRequirementData_45 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(46)]
        public virtual string SpecialRequirementData_46 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(47)]
        public virtual string SpecialRequirementData_47 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(48)]
        public virtual string SpecialRequirementData_48 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(49)]
        public virtual string SpecialRequirementData_49 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(50)]
        public virtual string SpecialRequirementData_50 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(51)]
        public virtual string SpecialRequirementData_51 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(52)]
        public virtual string SpecialRequirementData_52 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(53)]
        public virtual string SpecialRequirementData_53 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(54)]
        public virtual string SpecialRequirementData_54 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(55)]
        public virtual string SpecialRequirementData_55 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(56)]
        public virtual string SpecialRequirementData_56 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(57)]
        public virtual string SpecialRequirementData_57 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(58)]
        public virtual string SpecialRequirementData_58 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(59)]
        public virtual string SpecialRequirementData_59 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(60)]
        public virtual string SpecialRequirementData_60 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(61)]
        public virtual string SpecialRequirementData_61 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(62)]
        public virtual string SpecialRequirementData_62 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(63)]
        public virtual string SpecialRequirementData_63 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(64)]
        public virtual string SpecialRequirementData_64 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(65)]
        public virtual string SpecialRequirementData_65 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(66)]
        public virtual string SpecialRequirementData_66 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(67)]
        public virtual string SpecialRequirementData_67 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(68)]
        public virtual string SpecialRequirementData_68 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(69)]
        public virtual string SpecialRequirementData_69 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(70)]
        public virtual string SpecialRequirementData_70 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(71)]
        public virtual string SpecialRequirementData_71 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(72)]
        public virtual string SpecialRequirementData_72 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(73)]
        public virtual string SpecialRequirementData_73 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(74)]
        public virtual string SpecialRequirementData_74 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(75)]
        public virtual string SpecialRequirementData_75 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(76)]
        public virtual string SpecialRequirementData_76 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(77)]
        public virtual string SpecialRequirementData_77 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(78)]
        public virtual string SpecialRequirementData_78 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(79)]
        public virtual string SpecialRequirementData_79 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(80)]
        public virtual string SpecialRequirementData_80 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(81)]
        public virtual string SpecialRequirementData_81 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(82)]
        public virtual string SpecialRequirementData_82 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(83)]
        public virtual string SpecialRequirementData_83 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(84)]
        public virtual string SpecialRequirementData_84 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(85)]
        public virtual string SpecialRequirementData_85 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(86)]
        public virtual string SpecialRequirementData_86 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(87)]
        public virtual string SpecialRequirementData_87 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(88)]
        public virtual string SpecialRequirementData_88 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(89)]
        public virtual string SpecialRequirementData_89 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(90)]
        public virtual string SpecialRequirementData_90 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(91)]
        public virtual string SpecialRequirementData_91 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(92)]
        public virtual string SpecialRequirementData_92 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(93)]
        public virtual string SpecialRequirementData_93 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(94)]
        public virtual string SpecialRequirementData_94 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(95)]
        public virtual string SpecialRequirementData_95 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(96)]
        public virtual string SpecialRequirementData_96 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(97)]
        public virtual string SpecialRequirementData_97 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(98)]
        public virtual string SpecialRequirementData_98 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(99)]
        public virtual string SpecialRequirementData_99 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(100)]
        public virtual string SpecialRequirementData_100 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(101)]
        public virtual string SpecialRequirementData_101 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(102)]
        public virtual string SpecialRequirementData_102 { get; set; }
        /// <summary>
        // Special requirement data
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("9960", typeof(EDIFACT_ID_9960))]
        [Pos(103)]
        public virtual string SpecialRequirementData_103 { get; set; }
    }
    
    /// <summary>
    // DISCOUNT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C998")]
    public class C998
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Adjustment reason
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("4465", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string AdjustmentReason_01 { get; set; }
        /// <summary>
        // Percentage
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string Percentage_02 { get; set; }
        /// <summary>
        // Party name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string PartyName_03 { get; set; }
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
    // FARE COMPONENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("CXXX")]
    public class CXXX
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        
        /// <summary>
        // Data indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9988", typeof(EDIFACT_ID_9988))]
        [Pos(1)]
        public virtual string DataIndicator_01 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string Quantity_02 { get; set; }
        /// <summary>
        // First date
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("9916", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FirstDate_03 { get; set; }
        /// <summary>
        // Pricing Group
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5388", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PricingGroup_04 { get; set; }
        /// <summary>
        // Rate/Tariff class
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string RateTariffClass_05 { get; set; }
    }
}
