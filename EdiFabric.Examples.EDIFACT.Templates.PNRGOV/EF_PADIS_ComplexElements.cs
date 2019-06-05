namespace EdiFabric.Templates.Padis
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;

    [Serializable()]
    [Composite("C337")]
    public class C337
    {
        [Pos(1)]
        public List<string> SectorSubjectIdentificationQualifier_01 { get; set; }
    }

    [Serializable()]
    [Composite("C300")]
    public class C300
    {
        [Pos(1)]
        public string TravelAgentIdentificationDetails_01 { get; set; }

        [Pos(2)]
        public string InhouseIdentification_02 { get; set; }

        [Pos(3)]
        public string InhouseIdentification2_03 { get; set; }

        [Pos(4)]
        public string InhouseIdentification3_04 { get; set; }
    }

    [Serializable()]
    [Composite("C328")]
    public class C328
    {
        [Pos(1)]
        public string PlaceLocationIdentification_01 { get; set; }

        [Pos(2)]
        public string PlaceLocationName_02 { get; set; }
    }

    [Serializable()]
    [Composite("C031")]
    public class C031
    {
        [Pos(1)]
        public string UpdateActionCode_01 { get; set; }

        [Pos(2)]
        public List<string> ActionRequestNotification_02 { get; set; }
    }

    [Serializable()]
    [Composite("C032")]
    public class C032
    {
        [Pos(1)]
        public string AddressPurposeCode_01 { get; set; }

        [Pos(2)]
        public string StreetAndNumber_02 { get; set; }

        [Pos(3)]
        public string City_03 { get; set; }

        [Pos(4)]
        public string CountrySubEntityIdentification_04 { get; set; }

        [Pos(5)]
        public string CountrySubEntityName_05 { get; set; }

        [Pos(6)]
        public string Country_06 { get; set; }

        [Pos(7)]
        public string PostCodeIdentification_07 { get; set; }

        [Pos(8)]
        public string FreeText_08 { get; set; }

        [Pos(9)]
        public string PlaceLocation_09 { get; set; }
    }

    [Serializable()]
    [Composite("C314")]
    public class C314
    {
        [Pos(1)]
        public string TypeOfMeansOfTransport_01 { get; set; }

        [Pos(2)]
        public string NumberOfStops_02 { get; set; }

        [Pos(3)]
        public string LegDuration_03 { get; set; }

        [Pos(4)]
        public string Percentage_04 { get; set; }

        [Pos(5)]
        public string DaysOfOperation_05 { get; set; }

        [Pos(6)]
        public string DateTimePeriod_06 { get; set; }

        [Pos(7)]
        public string ComplexingFlightIndicator_07 { get; set; }

        [Pos(8)]
        public string PlaceLocationIdentification_08 { get; set; }

        [Pos(9)]
        public string PlaceLocationIdentification2_09 { get; set; }

        [Pos(10)]
        public string PlaceLocationIdentification3_10 { get; set; }
    }

    [Serializable()]
    [Composite("C348")]
    public class C348
    {
        [Pos(1)]
        public string GateDescription_01 { get; set; }

        [Pos(2)]
        public string RelatedPlaceLocationOneID_02 { get; set; }

        [Pos(3)]
        public string RelatedPlaceLocationTwoID_03 { get; set; }
    }

    [Serializable()]
    [Composite("C317")]
    public class C317
    {
        [Pos(1)]
        public string MeasurementValue_01 { get; set; }

        [Pos(2)]
        public string MeasureUnitQualifier_02 { get; set; }

        [Pos(3)]
        public string FirstTime_03 { get; set; }
    }

    [Serializable()]
    [Composite("C318")]
    public class C318
    {
        [Pos(1)]
        public string FirstTime_01 { get; set; }

        [Pos(2)]
        public string SecondTime_02 { get; set; }

        [Pos(3)]
        public string CheckInDetails_03 { get; set; }
    }

    [Serializable()]
    [Composite("C320")]
    public class C320
    {
        [Pos(1)]
        public string FacilityType_01 { get; set; }

        [Pos(2)]
        public string FacilityDescription_02 { get; set; }

        [Pos(3)]
        public string ProductDetailsQualifier_03 { get; set; }

        [Pos(4)]
        public List<string> CharacteristicIdentification_04 { get; set; }
    }

    [Serializable()]
    [Composite("C688")]
    public class C688
    {
        [Pos(1)]
        public string DateTimePeriodQualifier_01 { get; set; }

        [Pos(2)]
        public string FirstDate_02 { get; set; }

        [Pos(3)]
        public string FirstTime_03 { get; set; }

        [Pos(4)]
        public string DateTimePeriodQualifier2_04 { get; set; }

        [Pos(5)]
        public string FirstTime2_05 { get; set; }

        [Pos(6)]
        public string MovementType_06 { get; set; }

        [Pos(7)]
        public string PlaceLocationIdentification_07 { get; set; }
    }

    [Serializable()]
    [Composite("C674")]
    public class C674
    {
        [Pos(1)]
        public string Currency_01 { get; set; }

        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }

        [Pos(3)]
        public string ProcessingIndicator_03 { get; set; }
    }

    [Serializable()]
    [Composite("C675")]
    public class C675
    {
        [Pos(1)]
        public string Quantity_01 { get; set; }

        [Pos(2)]
        public string MeasurementValue_02 { get; set; }

        [Pos(3)]
        public string AllowanceOrChargeQualifier_03 { get; set; }

        [Pos(4)]
        public string MeasureUnitQualifier_04 { get; set; }

        [Pos(5)]
        public string ProcessingIndicator_05 { get; set; }
    }

    [Serializable()]
    [Composite("C358")]
    public class C358
    {
        [Pos(1)]
        public string CompanyIdentification_01 { get; set; }

        [Pos(2)]
        public string ItemNumber_02 { get; set; }

        [Pos(3)]
        public string TotalNumberOfItems_03 { get; set; }

        [Pos(4)]
        public string PlaceLocationIdentification_04 { get; set; }

        [Pos(5)]
        public string CompanyIdentificationNumber_05 { get; set; }

        [Pos(6)]
        public string DataIndicator_06 { get; set; }



        [Pos(7)]
        public string ItemCharacteristic_07 { get; set; }



        [Pos(8)]
        public string SpecialRequirementType_08 { get; set; }



        [Pos(9)]
        public string MeasurementValue_09 { get; set; }



        [Pos(10)]
        public string MeasureUnitQualifier_10 { get; set; }



        [Pos(11)]
        public string FreeText_11 { get; set; }
    }

    [Serializable()]
    [Composite("C523")]
    public class C523
    {


        [Pos(1)]
        public string NumberOfUnits_01 { get; set; }



        [Pos(2)]
        public string NumberOfUnitsQualifier_02 { get; set; }
    }

    [Serializable()]
    [Composite("C901")]
    public class C901
    {


        [Pos(1)]
        public string ApplicationError_01 { get; set; }



        [Pos(2)]
        public string CodeListQualifier_02 { get; set; }



        [Pos(3)]
        public string CodeListResponsibleAgency_03 { get; set; }
    }

    [Serializable()]
    [Composite("C662")]
    public class C662
    {


        [Pos(1)]
        public string NumberOfUnitsQualifier_01 { get; set; }



        [Pos(2)]
        public string Percentage_02 { get; set; }



        [Pos(3)]
        public string Country_03 { get; set; }



        [Pos(4)]
        public string FareClassificationType_04 { get; set; }
    }

    [Serializable()]
    [Composite("C644")]
    public class C644
    {



        [Pos(1)]
        public string PricingGroup_01 { get; set; }
    }

    [Serializable()]
    [Composite("C641")]
    public class C641
    {



        [Pos(1)]
        public string FormOfPaymentIdentification_01 { get; set; }



        [Pos(2)]
        public string DataIndicator_02 { get; set; }



        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }



        [Pos(4)]
        public string CompanyIdentification_04 { get; set; }



        [Pos(5)]
        public string ReferenceNumber_05 { get; set; }



        [Pos(6)]
        public string FirstDate_06 { get; set; }



        [Pos(7)]
        public string ApprovalIdentification_07 { get; set; }



        [Pos(8)]
        public string Source_08 { get; set; }



        [Pos(9)]
        public string MonetaryAmount2_09 { get; set; }



        [Pos(10)]
        public string Verification_10 { get; set; }



        [Pos(11)]
        public string AccountHolderNumber_11 { get; set; }



        [Pos(12)]
        public string PaymentTimeReference_12 { get; set; }



        [Pos(13)]
        public string FreeText_13 { get; set; }



        [Pos(14)]
        public string MembershipStatus_14 { get; set; }



        [Pos(15)]
        public string TransactionInformation_15 { get; set; }
    }

    [Serializable()]
    [Composite("C326")]
    public class C326
    {



        [Pos(1)]
        public string CompanyIdentification_01 { get; set; }




        [Pos(2)]
        public string FrequentTravellerIdentification_02 { get; set; }



        [Pos(3)]
        public string TravellerReferenceNumber_03 { get; set; }



        [Pos(4)]
        public string Status_04 { get; set; }



        [Pos(5)]
        public string MembershipLevel_05 { get; set; }



        [Pos(6)]
        public string HierarchicalIDNumber_06 { get; set; }



        [Pos(7)]
        public string ItemDescription_07 { get; set; }



        [Pos(8)]
        public string CompanyIdentification2_08 { get; set; }



        [Pos(9)]
        public string PassengerPriorityValue_09 { get; set; }
    }

    [Serializable()]
    [Composite("C346")]
    public class C346
    {



        [Pos(1)]
        public string TextSubjectQualifier_01 { get; set; }




        [Pos(2)]
        public string InformationType_02 { get; set; }



        [Pos(3)]
        public string Status_03 { get; set; }



        [Pos(4)]
        public string CompanyIdentification_04 { get; set; }



        [Pos(5)]
        public string Language_05 { get; set; }
    }

    [Serializable()]
    [Composite("C663")]
    public class C663
    {



        [Pos(1)]
        public string MonetaryAmountTypeQualifier_01 { get; set; }



        [Pos(2)]
        public string AllowanceOrChargeNumber_02 { get; set; }



        [Pos(3)]
        public string Currency_03 { get; set; }




        [Pos(4)]
        public List<string> PlaceLocationIdentification_04 { get; set; }
    }

    [Serializable()]
    [Composite("C302")]
    public class C302
    {


        [Pos(1)]
        public string BusinessFunction_01 { get; set; }



        [Pos(2)]
        public string MessageFunction_02 { get; set; }



        [Pos(3)]
        public string CodeListResponsibleAgency_03 { get; set; }




        [Pos(4)]
        public List<string> MessageFunction2_04 { get; set; }
    }

    [Serializable()]
    [Composite("C336")]
    public class C336
    {



        [Pos(1)]
        public string CompanyIdentification_01 { get; set; }



        [Pos(2)]
        public string PlaceLocationIdentification_02 { get; set; }



        [Pos(3)]
        public string PlaceLocationName_03 { get; set; }
    }

    [Serializable()]
    [Composite("C354")]
    public class C354
    {


        [Pos(1)]
        public string Country_01 { get; set; }



        [Pos(2)]
        public string Currency_02 { get; set; }



        [Pos(3)]
        public string Language_03 { get; set; }
    }

    [Serializable()]
    [Composite("C664")]
    public class C664
    {


        [Pos(1)]
        public string PriceTypeQualifier_01 { get; set; }



        [Pos(2)]
        public string PriceTypeQualifier2_02 { get; set; }



        [Pos(3)]
        public string PriceTypeQualifier3_03 { get; set; }



        [Pos(4)]
        public string PriceTypeQualifier4_04 { get; set; }



        [Pos(5)]
        public string PriceTypeQualifier5_05 { get; set; }



        [Pos(6)]
        public string PriceTypeQualifier6_06 { get; set; }



        [Pos(7)]
        public string PriceTypeQualifier7_07 { get; set; }



        [Pos(8)]
        public string PriceTypeQualifier8_08 { get; set; }



        [Pos(9)]
        public string PriceTypeQualifier9_09 { get; set; }



        [Pos(10)]
        public string PriceTypeQualifier10_10 { get; set; }



        [Pos(11)]
        public string PriceTypeQualifier11_11 { get; set; }



        [Pos(12)]
        public string PriceTypeQualifier12_12 { get; set; }



        [Pos(13)]
        public string PriceTypeQualifier13_13 { get; set; }



        [Pos(14)]
        public string PriceTypeQualifier14_14 { get; set; }



        [Pos(15)]
        public string PriceTypeQualifier15_15 { get; set; }



        [Pos(16)]
        public string PriceTypeQualifier16_16 { get; set; }



        [Pos(17)]
        public string PriceTypeQualifier17_17 { get; set; }



        [Pos(18)]
        public string PriceTypeQualifier18_18 { get; set; }



        [Pos(19)]
        public string PriceTypeQualifier19_19 { get; set; }



        [Pos(20)]
        public string PriceTypeQualifier20_20 { get; set; }
    }

    [Serializable()]
    [Composite("C310")]
    public class C310
    {


        [Pos(1)]
        public string FirstDate_01 { get; set; }



        [Pos(2)]
        public string FirstTime_02 { get; set; }



        [Pos(3)]
        public string SecondDate_03 { get; set; }



        [Pos(4)]
        public string SecondTime_04 { get; set; }



        [Pos(5)]
        public string DateVariation_05 { get; set; }
    }

    [Serializable()]
    [Composite("C306")]
    public class C306
    {



        [Pos(1)]
        public string CompanyIdentification_01 { get; set; }



        [Pos(2)]
        public string CompanyIdentification2_02 { get; set; }



        [Pos(3)]
        public string CompanyIdentification3_03 { get; set; }
    }

    [Serializable()]
    [Composite("C665")]
    public class C665
    {



        [Pos(1)]
        public string CompanyIdentificationNumber_01 { get; set; }



        [Pos(2)]
        public string CompanyIdentificationNumber2_02 { get; set; }
    }

    [Serializable()]
    [Composite("C666")]
    public class C666
    {


        [Pos(1)]
        public string PlaceLocationIdentification_01 { get; set; }



        [Pos(2)]
        public string Country_02 { get; set; }
    }

    [Serializable()]
    [Composite("C330")]
    public class C330
    {



        [Pos(1)]
        public string CompanyIdentification_01 { get; set; }



        [Pos(2)]
        public string ReservationControlNumber_02 { get; set; }



        [Pos(3)]
        public string ReservationControlType_03 { get; set; }



        [Pos(4)]
        public string FirstDate_04 { get; set; }



        [Pos(5)]
        public string Time_05 { get; set; }
    }

    [Serializable()]
    [Composite("C653")]
    public class C653
    {


        [Pos(1)]
        public string ReferenceQualifier_01 { get; set; }



        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
    }

    [Serializable()]
    [Composite("C678")]
    public class C678
    {



        [Pos(1)]
        public string Quantity_01 { get; set; }



        [Pos(2)]
        public string NumberOfUnits_02 { get; set; }



        [Pos(3)]
        public string TotalNumberOfItems_03 { get; set; }
    }

    [Serializable()]
    [Composite("C679")]
    public class C679
    {




        [Pos(1)]
        public List<string> SpecificSeat_01 { get; set; }
    }

    [Serializable()]
    [Composite("C680")]
    public class C680
    {




        [Pos(1)]
        public List<string> SeatCharacteristics_01 { get; set; }
    }

    [Serializable()]
    [Composite("C681")]
    public class C681
    {



        [Pos(1)]
        public string SeatRowNumber_01 { get; set; }



        [Pos(2)]
        public string RangeMaximum_02 { get; set; }




        [Pos(3)]
        public List<string> SeatColumn_03 { get; set; }
    }

    [Serializable()]
    [Composite("C682")]
    public class C682
    {




        [Pos(1)]
        public List<string> SecurityIdentification_01 { get; set; }
    }


    [Serializable()]
    [Composite("C683")]
    public class C683
    {



        [Pos(1)]
        public string ItemCharacteristic_01 { get; set; }



        [Pos(2)]
        public string SpecificSeat_02 { get; set; }
    }

    [Serializable()]
    [Composite("C334")]
    public class C334
    {



        [Pos(1)]
        public string SpecialRequirementType_01 { get; set; }




        [Pos(2)]
        public string Status_02 { get; set; }



        [Pos(3)]
        public string Quantity_03 { get; set; }



        [Pos(4)]
        public string CompanyIdentification_04 { get; set; }



        [Pos(5)]
        public string ProcessingIndicator_05 { get; set; }



        [Pos(6)]
        public string ProcessingIndicator2_06 { get; set; }



        [Pos(7)]
        public string ItemDescription_07 { get; set; }



        [Pos(8)]
        public string PlaceLocationIdentification_08 { get; set; }



        [Pos(9)]
        public string PlaceLocationIdentification2_09 { get; set; }




        [Pos(10)]
        public List<string> FreeText_10 { get; set; }
    }

    [Serializable()]
    [Composite("C332")]
    public class C332
    {


        [Pos(1)]
        public string SpecialRequirementData_01 { get; set; }



        [Pos(2)]
        public string MeasureUnitQualifier_02 { get; set; }



        [Pos(3)]
        public string TravellerReferenceNumber_03 { get; set; }




        [Pos(4)]
        public List<string> SeatCharacteristic_04 { get; set; }
    }


    [Serializable()]
    [Composite("C686")]
    public class C686
    {


        [Pos(1)]
        public string ProcessingIndicator_01 { get; set; }




        [Pos(2)]
        public string IdentifyNumber_02 { get; set; }
    }

    [Serializable()]
    [Composite("C322")]
    public class C322
    {


        [Pos(1)]
        public string TravellerSurname_01 { get; set; }




        [Pos(2)]
        public string NumberOfUnitsQualifier_02 { get; set; }



        [Pos(3)]
        public string Quantity_03 { get; set; }



        [Pos(4)]
        public string Status_04 { get; set; }
    }

    [Serializable()]
    [Composite("C324")]
    public class C324
    {


        [Pos(1)]
        public string TravellerGivenName_01 { get; set; }




        [Pos(2)]
        public string NumberOfUnitsQualifier_02 { get; set; }



        [Pos(3)]
        public string TravellerReferenceNumber_03 { get; set; }



        [Pos(4)]
        public string TravellerAccompaniedByInfantIndicator_04 { get; set; }



        [Pos(5)]
        public string OtherNames1_05 { get; set; }



        [Pos(6)]
        public string OtherNames2_06 { get; set; }
    }

    [Serializable()]
    [Composite("C667")]
    public class C667
    {


        [Pos(1)]
        public string DocumentMessageNumber_01 { get; set; }




        [Pos(2)]
        public string DocumentMessageName_02 { get; set; }



        [Pos(3)]
        public string TotalNumberOfItems_03 { get; set; }



        [Pos(4)]
        public string DataIndicator_04 { get; set; }



        [Pos(5)]
        public string ActionRequestNotification_05 { get; set; }



        [Pos(6)]
        public string DocumentMessageNumber2_06 { get; set; }
    }

    [Serializable()]
    [Composite("C308")]
    public class C308
    {


        [Pos(1)]
        public string ProductionIdentification_01 { get; set; }




        [Pos(2)]
        public string CharacteristicIdentification_02 { get; set; }



        [Pos(3)]
        public string ProductIdentificationCharacteristic_03 { get; set; }



        [Pos(4)]
        public string ItemDescriptionIdentification_04 { get; set; }
    }

    [Serializable()]
    [Composite("C670")]
    public class C670
    {


        [Pos(1)]
        public string IdentityNumberQualifier_01 { get; set; }



        [Pos(2)]
        public string ReferenceQualifier_02 { get; set; }
    }

    [Serializable()]
    [Composite("C671")]
    public class C671
    {


        [Pos(1)]
        public string ReferenceNumber_01 { get; set; }



        [Pos(2)]
        public string ReferenceQualifier_02 { get; set; }



        [Pos(3)]
        public string SpecificSeat_03 { get; set; }



        [Pos(4)]
        public string TravellerReferenceNumber_04 { get; set; }
    }

    [Serializable()]
    [Composite("C309")]
    public class C309
    {



        [Pos(1)]
        public List<string> SequenceNumber_01 { get; set; }
    }

    [Serializable()]
    [Composite("C311")]
    public class C311
    {


        [Pos(1)]
        public string Relation_01 { get; set; }



        [Pos(2)]
        public string GroupNumber_02 { get; set; }



        [Pos(3)]
        public string LineItemNumber_03 { get; set; }



        [Pos(4)]
        public string Relation2_04 { get; set; }



        [Pos(5)]
        public string CompanyIdentification_05 { get; set; }
    }

    [Serializable()]
    [Composite("C668")]
    public class C668
    {


        [Pos(1)]
        public string DutyTaxFeeRate_01 { get; set; }



        [Pos(2)]
        public string Country_02 { get; set; }



        [Pos(3)]
        public string Currency_03 { get; set; }



        [Pos(4)]
        public string DutyTaxFeeType_04 { get; set; }



        [Pos(5)]
        public string DutyTaxFeeRate2_05 { get; set; }



        [Pos(6)]
        public string Currency2_06 { get; set; }



        [Pos(7)]
        public string DutyTaxFeeType2_07 { get; set; }



        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }




        [Pos(9)]
        public List<string> MonetaryFunction_09 { get; set; }
    }
}
