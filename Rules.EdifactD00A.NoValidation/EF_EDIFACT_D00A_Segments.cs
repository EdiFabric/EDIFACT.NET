namespace EdiFabric.Rules.EDIFACT_D00A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Segment("UNT")]
    public class UNT
    {
        
        [Pos(1)]
        public string NumberofSegmentsinaMessage_01 { get; set; }
        [Pos(2)]
        public string MessageReferenceNumber_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("FTX")]
    public class FTX
    {
        
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
        [Pos(3)]
        public C107 TEXTREFERENCE_03 { get; set; }
        [Pos(4)]
        public C108 TEXTLITERAL_04 { get; set; }
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class MOA
    {
        
        [Pos(1)]
        public C516 MONETARYAMOUNT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALI")]
    public class ALI
    {
        
        [Pos(1)]
        public string Countryoforiginnamecode_01 { get; set; }
        [Pos(2)]
        public string Dutyregimetypecode_02 { get; set; }
        [Pos(3)]
        public string Specialconditioncode_03 { get; set; }
        [Pos(4)]
        public string Specialconditioncode_04 { get; set; }
        [Pos(5)]
        public string Specialconditioncode_05 { get; set; }
        [Pos(6)]
        public string Specialconditioncode_06 { get; set; }
        [Pos(7)]
        public string Specialconditioncode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALC")]
    public class ALC
    {
        
        [Pos(1)]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        [Pos(2)]
        public C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        [Pos(3)]
        public string Settlementmeanscode_03 { get; set; }
        [Pos(4)]
        public string Calculationsequencecode_04 { get; set; }
        [Pos(5)]
        public C214 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("TAX")]
    public class TAX
    {
        
        [Pos(1)]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public C241 DUTYTAXFEETYPE_02 { get; set; }
        [Pos(3)]
        public C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        [Pos(4)]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        [Pos(5)]
        public C243 DUTYTAXFEEDETAIL_05 { get; set; }
        [Pos(6)]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        [Pos(7)]
        public string Partytaxidentifier_07 { get; set; }
        [Pos(8)]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class DTM
    {
        
        [Pos(1)]
        public C507 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("RFF")]
    public class RFF
    {
        
        [Pos(1)]
        public C506 REFERENCE_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("CNT")]
    public class CNT
    {
        
        [Pos(1)]
        public C270 CONTROL_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("UNS")]
    public class UNS
    {
        
        [Pos(1)]
        public string Sectionidentification_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("QTY")]
    public class QTY
    {
        
        [Pos(1)]
        public C186 QUANTITYDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("MEA")]
    public class MEA
    {
        
        [Pos(1)]
        public string Measurementattributecode_01 { get; set; }
        [Pos(2)]
        public C502 MEASUREMENTDETAILS_02 { get; set; }
        [Pos(3)]
        public C174 VALUERANGE_03 { get; set; }
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("LOC")]
    public class LOC
    {
        
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public C517 LOCATIONIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public C519 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public C553 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("GIR")]
    public class GIR
    {
        
        [Pos(1)]
        public string Settypecodequalifier_01 { get; set; }
        [Pos(2)]
        public C206 IDENTIFICATIONNUMBER_02 { get; set; }
        [Pos(3)]
        public C206 IDENTIFICATIONNUMBER_03 { get; set; }
        [Pos(4)]
        public C206 IDENTIFICATIONNUMBER_04 { get; set; }
        [Pos(5)]
        public C206 IDENTIFICATIONNUMBER_05 { get; set; }
        [Pos(6)]
        public C206 IDENTIFICATIONNUMBER_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("GIS")]
    public class GIS
    {
        
        [Pos(1)]
        public C529 PROCESSINGINDICATOR_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("RCS")]
    public class RCS
    {
        
        [Pos(1)]
        public string Sectorareaidentificationcodequalifier_01 { get; set; }
        [Pos(2)]
        public C550 REQUIREMENTCONDITIONIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public string Actionrequestnotificationdescriptioncode_03 { get; set; }
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("TOD")]
    public class TOD
    {
        
        [Pos(1)]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        [Pos(2)]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        [Pos(3)]
        public C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("TDT")]
    public class TDT
    {
        
        [Pos(1)]
        public string Transportstagecodequalifier_01 { get; set; }
        [Pos(2)]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        [Pos(3)]
        public C220 MODEOFTRANSPORT_03 { get; set; }
        [Pos(4)]
        public C228 TRANSPORTMEANS_04 { get; set; }
        [Pos(5)]
        public C040 CARRIER_05 { get; set; }
        [Pos(6)]
        public string Transitdirectionindicatorcode_06 { get; set; }
        [Pos(7)]
        public C401 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        [Pos(8)]
        public C222 TRANSPORTIDENTIFICATION_08 { get; set; }
        [Pos(9)]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("RNG")]
    public class RNG
    {
        
        [Pos(1)]
        public string Rangetypecodequalifier_01 { get; set; }
        [Pos(2)]
        public C280 RANGE_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("RTE")]
    public class RTE
    {
        
        [Pos(1)]
        public C128 RATEDETAILS_01 { get; set; }
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("CUX")]
    public class CUX
    {
        
        [Pos(1)]
        public C504 CURRENCYDETAILS_01 { get; set; }
        [Pos(2)]
        public C504 CURRENCYDETAILS_02 { get; set; }
        [Pos(3)]
        public string Currencyexchangerate_03 { get; set; }
        [Pos(4)]
        public string Exchangeratecurrencymarketidentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PCD")]
    public class PCD
    {
        
        [Pos(1)]
        public C501 PERCENTAGEDETAILS_01 { get; set; }
        [Pos(2)]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("COM")]
    public class COM
    {
        
        [Pos(1)]
        public List<C076> COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("CTA")]
    public class CTA
    {
        
        [Pos(1)]
        public string Contactfunctioncode_01 { get; set; }
        [Pos(2)]
        public C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("DOC")]
    public class DOC
    {
        
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        [Pos(2)]
        public C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        [Pos(3)]
        public string Communicationmediumtypecode_03 { get; set; }
        [Pos(4)]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        [Pos(5)]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("FII")]
    public class FII
    {
        
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NAD")]
    public class NAD
    {
        
        [Pos(1)]
        public string Partyfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        [Pos(3)]
        public C058 NAMEANDADDRESS_03 { get; set; }
        [Pos(4)]
        public C080 PARTYNAME_04 { get; set; }
        [Pos(5)]
        public C059 STREET_05 { get; set; }
        [Pos(6)]
        public string Cityname_06 { get; set; }
        [Pos(7)]
        public C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        [Pos(8)]
        public string Postalidentificationcode_08 { get; set; }
        [Pos(9)]
        public string Countrynamecode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("GIN")]
    public class GIN
    {
        
        [Pos(1)]
        public string Objectidentificationcodequalifier_01 { get; set; }
        [Pos(2)]
        public C208 IDENTITYNUMBERRANGE_02 { get; set; }
        [Pos(3)]
        public C208 IDENTITYNUMBERRANGE_03 { get; set; }
        [Pos(4)]
        public C208 IDENTITYNUMBERRANGE_04 { get; set; }
        [Pos(5)]
        public C208 IDENTITYNUMBERRANGE_05 { get; set; }
        [Pos(6)]
        public C208 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PCI")]
    public class PCI
    {
        
        [Pos(1)]
        public string Markinginstructionscode_01 { get; set; }
        [Pos(2)]
        public C210 MARKSLABELS_02 { get; set; }
        [Pos(3)]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        [Pos(4)]
        public C827 TYPEOFMARKING_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("EQD")]
    public class EQD
    {
        
        [Pos(1)]
        public string Equipmenttypecodequalifier_01 { get; set; }
        [Pos(2)]
        public C237 EQUIPMENTIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public C224 EQUIPMENTSIZEANDTYPE_03 { get; set; }
        [Pos(4)]
        public string Equipmentsuppliercode_04 { get; set; }
        [Pos(5)]
        public string Equipmentstatuscode_05 { get; set; }
        [Pos(6)]
        public string Fulloremptyindicatorcode_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAC")]
    public class PAC
    {
        
        [Pos(1)]
        public string Packagequantity_01 { get; set; }
        [Pos(2)]
        public C531 PACKAGINGDETAILS_02 { get; set; }
        [Pos(3)]
        public C202 PACKAGETYPE_03 { get; set; }
        [Pos(4)]
        public C402 PACKAGETYPEIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public C532 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("APR")]
    public class APR
    {
        
        [Pos(1)]
        public string Tradeclasscode_01 { get; set; }
        [Pos(2)]
        public C138 PRICEMULTIPLIERINFORMATION_02 { get; set; }
        [Pos(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRI")]
    public class PRI
    {
        
        [Pos(1)]
        public C509 PRICEINFORMATION_01 { get; set; }
        [Pos(2)]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAT")]
    public class PAT
    {
        
        [Pos(1)]
        public string Paymenttermstypecodequalifier_01 { get; set; }
        [Pos(2)]
        public C110 PAYMENTTERMS_02 { get; set; }
        [Pos(3)]
        public C112 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DGS")]
    public class DGS
    {
        
        [Pos(1)]
        public string Dangerousgoodsregulationscode_01 { get; set; }
        [Pos(2)]
        public C205 HAZARDCODE_02 { get; set; }
        [Pos(3)]
        public C234 UNDGINFORMATION_03 { get; set; }
        [Pos(4)]
        public C223 DANGEROUSGOODSSHIPMENTFLASHPOINT_04 { get; set; }
        [Pos(5)]
        public string Packagingdangerlevelcode_05 { get; set; }
        [Pos(6)]
        public string Emergencyprocedureforshipsidentifier_06 { get; set; }
        [Pos(7)]
        public string Hazardmedicalfirstaidguideidentifier_07 { get; set; }
        [Pos(8)]
        public string Transportemergencycardidentifier_08 { get; set; }
        [Pos(9)]
        public C235 HAZARDIDENTIFICATIONPLACARDDETAILS_09 { get; set; }
        [Pos(10)]
        public C236 DANGEROUSGOODSLABEL_10 { get; set; }
        [Pos(11)]
        public string Packinginstructiontypecode_11 { get; set; }
        [Pos(12)]
        public string Hazardousmeansoftransportcategorycode_12 { get; set; }
        [Pos(13)]
        public string Hazardouscargotransportauthorisationcode_13 { get; set; }
    }
    
    [Serializable()]
    [Segment("QVR")]
    public class QVR
    {
        
        [Pos(1)]
        public C279 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        [Pos(2)]
        public string Discrepancynatureidentificationcode_02 { get; set; }
        [Pos(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("IMD")]
    public class IMD
    {
        
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        [Pos(2)]
        public C272 ITEMCHARACTERISTIC_02 { get; set; }
        [Pos(3)]
        public C273 ITEMDESCRIPTION_03 { get; set; }
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PIA")]
    public class PIA
    {
        
        [Pos(1)]
        public string Productidentifiercodequalifier_01 { get; set; }
        [Pos(2)]
        public C212 ITEMNUMBERIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public C212 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public C212 ITEMNUMBERIDENTIFICATION_05 { get; set; }
        [Pos(6)]
        public C212 ITEMNUMBERIDENTIFICATION_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("LIN")]
    public class LIN
    {
        
        [Pos(1)]
        public string Lineitemidentifier_01 { get; set; }
        [Pos(2)]
        public string Actionrequestnotificationdescriptioncode_02 { get; set; }
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public C829 SUBLINEINFORMATION_04 { get; set; }
        [Pos(5)]
        public string Configurationlevelnumber_05 { get; set; }
        [Pos(6)]
        public string Configurationoperationcode_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("INP")]
    public class INP
    {
        
        [Pos(1)]
        public C849 PARTIESTOINSTRUCTION_01 { get; set; }
        [Pos(2)]
        public C522 INSTRUCTION_02 { get; set; }
        [Pos(3)]
        public C850 STATUSOFINSTRUCTION_03 { get; set; }
        [Pos(4)]
        public string Actionrequestnotificationdescriptioncode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("AJT")]
    public class AJT
    {
        
        [Pos(1)]
        public string Adjustmentreasondescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Lineitemidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("SEL")]
    public class SEL
    {
        
        [Pos(1)]
        public string Sealidentifier_01 { get; set; }
        [Pos(2)]
        public C215 SEALISSUER_02 { get; set; }
        [Pos(3)]
        public string Sealconditioncode_03 { get; set; }
        [Pos(4)]
        public C208 IDENTITYNUMBERRANGE_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("TSR")]
    public class TSR
    {
        
        [Pos(1)]
        public C536 CONTRACTANDCARRIAGECONDITION_01 { get; set; }
        [Pos(2)]
        public C233 SERVICE_02 { get; set; }
        [Pos(3)]
        public C537 TRANSPORTPRIORITY_03 { get; set; }
        [Pos(4)]
        public C703 NATUREOFCARGO_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAI")]
    public class PAI
    {
        
        [Pos(1)]
        public C534 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("BGM")]
    public class BGM
    {
        
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        [Pos(2)]
        public C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("UNH")]
    public class UNH
    {
        
        [Pos(1)]
        public string MessageReferenceNumber_01 { get; set; }
        [Pos(2)]
        public S009 MessageIdentifier_02 { get; set; }
        [Pos(3)]
        public string CommonAccessReference_03 { get; set; }
        [Pos(4)]
        public S010 StatusoftheTransfer_04 { get; set; }
        [Pos(5)]
        public S016 MessageSubsetIdentification_05 { get; set; }
        [Pos(6)]
        public S017 MessageImplementationGuidelineIdentification_06 { get; set; }
        [Pos(7)]
        public S018 ScenarioIdentification_07 { get; set; }
    }
}
