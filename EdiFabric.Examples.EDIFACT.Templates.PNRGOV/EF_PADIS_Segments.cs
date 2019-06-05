namespace EdiFabric.Templates.Padis
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    [Serializable()]
    [Segment("ABI")]
    public class ABI
    {
        
        [Pos(1)]
        public C337 SOURCETYPE_01 { get; set; }
        [Pos(2)]
        public C300 ORIGINATORDETAILS_02 { get; set; }
        [Pos(3)]
        public C328 LOCATION_03 { get; set; }
        
        
        [Pos(4)]
        public string Country_04 { get; set; }
        
        
        [Pos(5)]
        public string CompanyIdentification_05 { get; set; }
    }

    [Serializable()]
    [Segment("ADD")]
    public class ADD
    {
        [Pos(1)]
        public C031 ACTIONDETAILS_01 { get; set; }
        
        
        [Pos(2)]
        public List<C032> ADDRESSDETAILS_02 { get; set; }       
    }

    [Serializable()]
    [Segment("APD")]
    public class APD
    {
        [Pos(1)]
        public C314 ADDITIONALPRODUCTDETAILS_01 { get; set; }
        [Pos(2)]
        public C348 STATIONINFORMATION1_02 { get; set; }
        [Pos(3)]
        public C348 STATIONINFORMATION2_03 { get; set; }
        [Pos(4)]
        public C317 MILEAGETIMEDETAILS_04 { get; set; }
        [Pos(5)]
        public C318 TRAVELLERTIMEDETAILS_05 { get; set; }
        
        [Pos(6)]
        public List<C320> PRODUCTFACILITIES_06 { get; set; }
    }

    [Serializable()]
    [Segment("DAT")]
    public class DAT
    {
        
        [Pos(1)]
        public List<C688> DATEANDTIMEDETAILS_01 { get; set; }
    }

    [Serializable()]
    [Segment("EBD")]
    public class EBD
    {
        [Pos(1)]
        public C674 EXCESSBAGGAGEDETAILS_01 { get; set; }
        
        [Pos(2)]
        public List<C675> BAGGAGEDETAILS_02 { get; set; }
        
        [Pos(3)]
        public List<C358> BAGTAGDETAILS_03 { get; set; }        
    }

    [Serializable()]
    [Segment("EQN")]
    public class EQN
    {
        
        [Pos(1)]
        public List<C523> NUMBEROFUNITDETAILS_01 { get; set; }
    }

    [Serializable()]
    [Segment("ERC")]
    public class ERC
    {
        [Pos(1)]
        public C901 APPLICATIONERRORDETAIL_01 { get; set; }
    }

    [Serializable()]
    [Segment("FAR")]
    public class FAR
    {
        
        
        [Pos(1)]
        public string NumberOfUnitsQualifier_01 { get; set; }
        
        
        [Pos(2)]
        public string Quantity_02 { get; set; }
        [Pos(3)]
        public C662 FAREDETAILS_03 { get; set; }
        
        
        [Pos(4)]
        public string IdentityNumber_04 { get; set; }
        [Pos(5)]
        public C644 FARETYPEGROUPINGINFORMATION_05 { get; set; }
    }

    [Serializable()]
    [Segment("FOP")]
    public class FOP
    {
        
        
        [Pos(1)]
        public List<C641> FORMOFPAYMENTDETAILS_01 { get; set; }
    }

    [Serializable()]
    [Segment("FTI")]
    public class FTI
    {
        
        
        [Pos(1)]
        public List<C326> FREQUENTTRAVELLERIDENTIFICATION_01 { get; set; }
    }

    [Serializable()]
    [Segment("IFT")]
    public class IFT
    {
        [Pos(1)]
        public C346 FREETEXTQUALIFICATION_01 { get; set; }
        
        
        
        [Pos(2)]
        public List<string> FreeText_02 { get; set; }
    }

    [Serializable()]
    [Segment("LTS")]
    public class LTS
    {
        
        
        [Pos(1)]
        public string TextStringDetails_01 { get; set; }
    }

    [Serializable()]
    [Segment("MON")]
    public class MON
    {
        
        
        [Pos(1)]
        public List<C663> MONETARYINFORMATION_01 { get; set; }
    }

    [Serializable()]
    [Segment("MSG")]
    public class MSG
    {
        
        [Pos(1)]
        public C302 MESSAGEFUNCTIONBUSINESSDETAILS_01 { get; set; }
        
        
        [Pos(2)]
        public string ResponseType_02 { get; set; }
    }

    [Serializable()]
    [Segment("ORG")]
    public class ORG
    {
        
        [Pos(1)]
        public C336 SYSTEMDETAILS_01 { get; set; }
        [Pos(2)]
        public C300 ORIGINATORIDENTIFICATIONDETAILS_02 { get; set; }
        [Pos(3)]
        public C328 LOCATION_03 { get; set; }
        [Pos(4)]
        public C336 SYSTEMDETAILS2_04 { get; set; }
        
        
        [Pos(5)]
        public string OriginatorTypeCode_05 { get; set; }
        [Pos(6)]
        public C354 ORIGINATORDETAILS_06 { get; set; }
        
        
        [Pos(7)]
        public string OriginatorAuthorityRequestCode_07 { get; set; }
        
        
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        
        
        [Pos(9)]
        public string PartyIdIdentification_09 { get; set; }
    }

    [Serializable()]
    [Segment("PTK")]
    public class PTK
    {
        [Pos(1)]
        public C664 PRICINGTICKETINGINFORMATION_01 { get; set; }
        
        
        [Pos(2)]
        public string PriceTariffType_02 { get; set; }
        [Pos(3)]
        public C310 PRODUCTDATETIME_03 { get; set; }
        [Pos(4)]
        public C306 COMPANYIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public C665 COMPANYIDENTIFICATIONNUMBERS_05 { get; set; }
        
        [Pos(6)]
        public List<C666> LOCATIONDETAILS_06 { get; set; }
        
        
        [Pos(7)]
        public string IdentityNumber_07 { get; set; }
        
        
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
    }

    [Serializable()]
    [Segment("RCI")]
    public class RCI
    {
        
        
        [Pos(1)]
        public List<C330> RESERVATIONCONTROLINFORMATION_01 { get; set; }
    }

    [Serializable()]
    [Segment("REF")]
    public class REF
    {
        
        [Pos(1)]
        public List<C653> REFERENCINGDETAILS_01 { get; set; }
    }

    [Serializable()]
    [Segment("RPI")]
    public class RPI
    {
        
        
        [Pos(1)]
        public string Quantity_01 { get; set; }
        
        
        
        [Pos(2)]
        public List<string> Status_02 { get; set; }
    }

    [Serializable()]
    [Segment("SAC")]
    public class SAC
    {
        
        
        [Pos(1)]
        public string StatusIndicator_01 { get; set; }
        
        
        [Pos(2)]
        public string PlaceLocationIdentification_02 { get; set; }
        
        
        [Pos(3)]
        public string Status_03 { get; set; }
    }

    [Serializable()]
    [Segment("SRC")]
    public class SRC
    {
        
        [Pos(1)]
        public List<C678> SEGMENTREPETITIONCONTROLDETAILS_01 { get; set; }
    }

    [Serializable()]
    [Segment("SSD")]
    public class SSD
    {
        [Pos(1)]
        public C679 SPECIFICSEATDETAILS_01 { get; set; }
        
        
        [Pos(2)]
        public string NoSmokingIndicator_02 { get; set; }
        [Pos(3)]
        public C680 SEATCHARACTERISTICDETAILS_03 { get; set; }
        [Pos(4)]
        public C681 SEATRANGEDETAILS_04 { get; set; }
        
        
        [Pos(5)]
        public string CabinClassDesignator_05 { get; set; }
        
        
        [Pos(6)]
        public string CabinClassOfService_06 { get; set; }
        
        
        [Pos(7)]
        public string PlaceLocationIdentification_07 { get; set; }
        
        
        [Pos(8)]
        public string PlaceLocationIdentification2_08 { get; set; }
        
        
        [Pos(9)]
        public string ProcessingIndicator_09 { get; set; }
        
        [Pos(10)]
        public List<C683> SPECIFICSEATPURPOSE_10 { get; set; }
    }

    [Serializable()]
    [Segment("SSR")]
    public class SSR
    {
        
        [Pos(1)]
        public C334 SPECIALREQUIREMENTTYPEDETAILS_01 { get; set; }

        
        [Pos(2)]
        public List<C332> SPECIALREQUIREMENTDATADETAILS_02 { get; set; }
    }

    [Serializable()]
    [Segment("TBD")]
    public class TBD
    {
        
        
        [Pos(1)]
        public string Status_01 { get; set; }
        
        [Pos(2)]
        public List<C675> BAGGAGEDETAILS_02 { get; set; }
        [Pos(3)]
        public C686 BAGGAGEREFERENCEDETAILS_03 { get; set; }
        
        [Pos(4)]
        public List<C358> BAGTAGDETAILS_04 { get; set; }
    }

    [Serializable()]
    [Segment("TIF")]
    public class TIF
    {
        [Pos(1)]
        public C322 TRAVELLERSURNAMEINFORMATION_01 { get; set; }
        
        [Pos(2)]
        public List<C324> TRAVELLERDETAILS_02 { get; set; }
    }

    [Serializable()]
    [Segment("TKT")]
    public class TKT
    {
        
        [Pos(1)]
        public C667 TICKETNUMBERDETAILS_01 { get; set; }
        
        
        [Pos(2)]
        public string Status_02 { get; set; }       
    }

    [Serializable()]
    [Segment("TRA")]
    public class TRA
    {
        
        [Pos(1)]
        public C306 COMPANYIDENTIFICATION_01 { get; set; }
        [Pos(2)]
        public C308 PRODUCTIDENTIFICATIONDETAILS_02 { get; set; }
    }

    [Serializable()]
    [Segment("TRI")]
    public class TRI
    {
        [Pos(1)]
        public C670 REFERENCEQUALIFICATION_01 { get; set; }
        
        [Pos(2)]
        public List<C671> TRAVELLERIDENTIFICATION_02 { get; set; }
    }


    [Serializable()]
    [Segment("TVL")]
    public class TVL
    {
        [Pos(1)]
        public C310 PRODUCTDATETIME_01 { get; set; }
        [Pos(2)]
        public C328 LOCATION_02 { get; set; }
        [Pos(3)]
        public C328 LOCATION2_03 { get; set; }
        [Pos(4)]
        public C306 COMPANYIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public C308 PRODUCTIDENTIFICATIONDETAILS_05 { get; set; }
        [Pos(6)]
        public C309 PRODUCTTYPEDETAILS_06 { get; set; }
        
        
        [Pos(7)]
        public string LineItemNumber_07 { get; set; }
        
        
        [Pos(8)]
        public string ProcessingIndicator_08 { get; set; }
        
        [Pos(9)]
        public List<C311> MARRIAGECONTROLDETAILS_09 { get; set; }
    }

    [Serializable()]
    [Segment("TXD")]
    public class TXD
    {
        
        
        [Pos(1)]
        public string DutyTaxFeeCategory_01 { get; set; }
        
        [Pos(2)]
        public List<C668> TAXDETAILS_02 { get; set; }        
    }
}
