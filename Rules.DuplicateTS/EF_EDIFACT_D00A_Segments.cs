namespace EdiFabric.Rules.EDIFACT_D00A
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using EdiFabric.Attributes;
    
    
    public class UNT
    {
        
        [D(1, "0074")]
        public string NumberofSegmentsinaMessage_01 { get; set; }
        [D(2, "0062")]
        public string MessageReferenceNumber_02 { get; set; }
    }
    
    public class FTX
    {
        
        [D(1, "4451")]
        public string Textsubjectcodequalifier_01 { get; set; }
        [D(2, "4453")]
        public string Freetextfunctioncode_02 { get; set; }
        [C(3)]
        public C107 TEXTREFERENCE_03 { get; set; }
        [C(4)]
        public C108 TEXTLITERAL_04 { get; set; }
        [D(5, "3453")]
        public string Languagenamecode_05 { get; set; }
        [D(6, "4447")]
        public string Freetextformatcode_06 { get; set; }
    }
    
    public class MOA
    {
        
        [C(1)]
        public C516 MONETARYAMOUNT_01 { get; set; }
    }
    
    public class ALI
    {
        
        [D(1, "3239")]
        public string Countryoforiginnamecode_01 { get; set; }
        [D(2, "9213")]
        public string Dutyregimetypecode_02 { get; set; }
        [D(3, "4183")]
        public string Specialconditioncode_03 { get; set; }
        [D(4, "4183")]
        public string Specialconditioncode_04 { get; set; }
        [D(5, "4183")]
        public string Specialconditioncode_05 { get; set; }
        [D(6, "4183")]
        public string Specialconditioncode_06 { get; set; }
        [D(7, "4183")]
        public string Specialconditioncode_07 { get; set; }
    }
    
    public class ALC
    {
        
        [D(1, "5463")]
        public string Allowanceorchargecodequalifier_01 { get; set; }
        [C(2)]
        public C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        [D(3, "4471")]
        public string Settlementmeanscode_03 { get; set; }
        [D(4, "1227")]
        public string Calculationsequencecode_04 { get; set; }
        [C(5)]
        public C214 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    public class TAX
    {
        
        [D(1, "5283")]
        public string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        [C(2)]
        public C241 DUTYTAXFEETYPE_02 { get; set; }
        [C(3)]
        public C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        [D(4, "5286")]
        public string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        [C(5)]
        public C243 DUTYTAXFEEDETAIL_05 { get; set; }
        [D(6, "5305")]
        public string Dutyortaxorfeecategorycode_06 { get; set; }
        [D(7, "3446")]
        public string Partytaxidentifier_07 { get; set; }
        [D(8, "1227")]
        public string Calculationsequencecode_08 { get; set; }
    }
    
    public class DTM
    {
        
        [C(1)]
        public C507 DATETIMEPERIOD_01 { get; set; }
    }
    
    public class RFF
    {
        
        [C(1)]
        public C506 REFERENCE_01 { get; set; }
    }
    
    public class CNT
    {
        
        [C(1)]
        public C270 CONTROL_01 { get; set; }
    }
    
    public class UNS
    {
        
        [D(1, "0081")]
        public string Sectionidentification_01 { get; set; }
    }
    
    public class QTY
    {
        
        [C(1)]
        public C186 QUANTITYDETAILS_01 { get; set; }
    }
    
    public class MEA
    {
        
        [D(1, "6311")]
        public string Measurementattributecode_01 { get; set; }
        [C(2)]
        public C502 MEASUREMENTDETAILS_02 { get; set; }
        [C(3)]
        public C174 VALUERANGE_03 { get; set; }
        [D(4, "7383")]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    public class LOC
    {
        
        [D(1, "3227")]
        public string Locationfunctioncodequalifier_01 { get; set; }
        [C(2)]
        public C517 LOCATIONIDENTIFICATION_02 { get; set; }
        [C(3)]
        public C519 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        [C(4)]
        public C553 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        [D(5, "5479")]
        public string Relationcode_05 { get; set; }
    }
    
    public class GIR
    {
        
        [D(1, "7297")]
        public string Settypecodequalifier_01 { get; set; }
        [C(2)]
        public C206 IDENTIFICATIONNUMBER_02 { get; set; }
        [C(3)]
        public C206 IDENTIFICATIONNUMBER_03 { get; set; }
        [C(4)]
        public C206 IDENTIFICATIONNUMBER_04 { get; set; }
        [C(5)]
        public C206 IDENTIFICATIONNUMBER_05 { get; set; }
        [C(6)]
        public C206 IDENTIFICATIONNUMBER_06 { get; set; }
    }
    
    public class GIS
    {
        
        [C(1)]
        public C529 PROCESSINGINDICATOR_01 { get; set; }
    }
    
    public class RCS
    {
        
        [D(1, "7293")]
        public string Sectorareaidentificationcodequalifier_01 { get; set; }
        [C(2)]
        public C550 REQUIREMENTCONDITIONIDENTIFICATION_02 { get; set; }
        [D(3, "1229")]
        public string Actionrequestnotificationdescriptioncode_03 { get; set; }
        [D(4, "3207")]
        public string Countrynamecode_04 { get; set; }
    }
    
    public class TOD
    {
        
        [D(1, "4055")]
        public string Deliveryortransporttermsfunctioncode_01 { get; set; }
        [D(2, "4215")]
        public string Transportchargespaymentmethodcode_02 { get; set; }
        [C(3)]
        public C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    public class TDT
    {
        
        [D(1, "8051")]
        public string Transportstagecodequalifier_01 { get; set; }
        [D(2, "8028")]
        public string Meansoftransportjourneyidentifier_02 { get; set; }
        [C(3)]
        public C220 MODEOFTRANSPORT_03 { get; set; }
        [C(4)]
        public C228 TRANSPORTMEANS_04 { get; set; }
        [C(5)]
        public C040 CARRIER_05 { get; set; }
        [D(6, "8101")]
        public string Transitdirectionindicatorcode_06 { get; set; }
        [C(7)]
        public C401 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        [C(8)]
        public C222 TRANSPORTIDENTIFICATION_08 { get; set; }
        [D(9, "8281")]
        public string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    public class RNG
    {
        
        [D(1, "6167")]
        public string Rangetypecodequalifier_01 { get; set; }
        [C(2)]
        public C280 RANGE_02 { get; set; }
    }
    
    public class RTE
    {
        
        [C(1)]
        public C128 RATEDETAILS_01 { get; set; }
        [D(2, "4405")]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    public class CUX
    {
        
        [C(1)]
        public C504 CURRENCYDETAILS_01 { get; set; }
        [C(2)]
        public C504 CURRENCYDETAILS_02 { get; set; }
        [D(3, "5402")]
        public string Currencyexchangerate_03 { get; set; }
        [D(4, "6341")]
        public string Exchangeratecurrencymarketidentifier_04 { get; set; }
    }
    
    public class PCD
    {
        
        [C(1)]
        public C501 PERCENTAGEDETAILS_01 { get; set; }
        [D(2, "4405")]
        public string Statusdescriptioncode_02 { get; set; }
    }
    
    public class COM
    {
        
        [C(1)]
        public List<C076> COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    public class CTA
    {
        
        [D(1, "3139")]
        public string Contactfunctioncode_01 { get; set; }
        [C(2)]
        public C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    public class DOC
    {
        
        [C(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        [C(2)]
        public C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        [D(3, "3153")]
        public string Communicationmediumtypecode_03 { get; set; }
        [D(4, "1220")]
        public string Documentcopiesrequiredquantity_04 { get; set; }
        [D(5, "1218")]
        public string Documentoriginalsrequiredquantity_05 { get; set; }
    }
    
    public class FII
    {
        
        [D(1, "3035")]
        public string Partyfunctioncodequalifier_01 { get; set; }
        [C(2)]
        public C078 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        [C(3)]
        public C088 INSTITUTIONIDENTIFICATION_03 { get; set; }
        [D(4, "3207")]
        public string Countrynamecode_04 { get; set; }
    }
    
    public class NAD
    {
        
        [D(1, "3035")]
        public string Partyfunctioncodequalifier_01 { get; set; }
        [C(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        [C(3)]
        public C058 NAMEANDADDRESS_03 { get; set; }
        [C(4)]
        public C080 PARTYNAME_04 { get; set; }
        [C(5)]
        public C059 STREET_05 { get; set; }
        [D(6, "3164")]
        public string Cityname_06 { get; set; }
        [C(7)]
        public C819 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        [D(8, "3251")]
        public string Postalidentificationcode_08 { get; set; }
        [D(9, "3207")]
        public string Countrynamecode_09 { get; set; }
    }
    
    public class GIN
    {
        
        [D(1, "7405")]
        public string Objectidentificationcodequalifier_01 { get; set; }
        [C(2)]
        public C208 IDENTITYNUMBERRANGE_02 { get; set; }
        [C(3)]
        public C208 IDENTITYNUMBERRANGE_03 { get; set; }
        [C(4)]
        public C208 IDENTITYNUMBERRANGE_04 { get; set; }
        [C(5)]
        public C208 IDENTITYNUMBERRANGE_05 { get; set; }
        [C(6)]
        public C208 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    public class PCI
    {
        
        [D(1, "4233")]
        public string Markinginstructionscode_01 { get; set; }
        [C(2)]
        public C210 MARKSLABELS_02 { get; set; }
        [D(3, "8275")]
        public string Containerorpackagecontentsindicatorcode_03 { get; set; }
        [C(4)]
        public C827 TYPEOFMARKING_04 { get; set; }
    }
    
    public class EQD
    {
        
        [D(1, "8053")]
        public string Equipmenttypecodequalifier_01 { get; set; }
        [C(2)]
        public C237 EQUIPMENTIDENTIFICATION_02 { get; set; }
        [C(3)]
        public C224 EQUIPMENTSIZEANDTYPE_03 { get; set; }
        [D(4, "8077")]
        public string Equipmentsuppliercode_04 { get; set; }
        [D(5, "8249")]
        public string Equipmentstatuscode_05 { get; set; }
        [D(6, "8169")]
        public string Fulloremptyindicatorcode_06 { get; set; }
    }
    
    public class PAC
    {
        
        [D(1, "7224")]
        public string Packagequantity_01 { get; set; }
        [C(2)]
        public C531 PACKAGINGDETAILS_02 { get; set; }
        [C(3)]
        public C202 PACKAGETYPE_03 { get; set; }
        [C(4)]
        public C402 PACKAGETYPEIDENTIFICATION_04 { get; set; }
        [C(5)]
        public C532 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    public class APR
    {
        
        [D(1, "4043")]
        public string Tradeclasscode_01 { get; set; }
        [C(2)]
        public C138 PRICEMULTIPLIERINFORMATION_02 { get; set; }
        [C(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    public class PRI
    {
        
        [C(1)]
        public C509 PRICEINFORMATION_01 { get; set; }
        [D(2, "5213")]
        public string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    public class PAT
    {
        
        [D(1, "4279")]
        public string Paymenttermstypecodequalifier_01 { get; set; }
        [C(2)]
        public C110 PAYMENTTERMS_02 { get; set; }
        [C(3)]
        public C112 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    public class DGS
    {
        
        [D(1, "8273")]
        public string Dangerousgoodsregulationscode_01 { get; set; }
        [C(2)]
        public C205 HAZARDCODE_02 { get; set; }
        [C(3)]
        public C234 UNDGINFORMATION_03 { get; set; }
        [C(4)]
        public C223 DANGEROUSGOODSSHIPMENTFLASHPOINT_04 { get; set; }
        [D(5, "8339")]
        public string Packagingdangerlevelcode_05 { get; set; }
        [D(6, "8364")]
        public string Emergencyprocedureforshipsidentifier_06 { get; set; }
        [D(7, "8410")]
        public string Hazardmedicalfirstaidguideidentifier_07 { get; set; }
        [D(8, "8126")]
        public string Transportemergencycardidentifier_08 { get; set; }
        [C(9)]
        public C235 HAZARDIDENTIFICATIONPLACARDDETAILS_09 { get; set; }
        [C(10)]
        public C236 DANGEROUSGOODSLABEL_10 { get; set; }
        [D(11, "8255")]
        public string Packinginstructiontypecode_11 { get; set; }
        [D(12, "8325")]
        public string Hazardousmeansoftransportcategorycode_12 { get; set; }
        [D(13, "8211")]
        public string Hazardouscargotransportauthorisationcode_13 { get; set; }
    }
    
    public class QVR
    {
        
        [C(1)]
        public C279 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        [D(2, "4221")]
        public string Discrepancynatureidentificationcode_02 { get; set; }
        [C(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    public class IMD
    {
        
        [D(1, "7077")]
        public string Descriptionformatcode_01 { get; set; }
        [C(2)]
        public C272 ITEMCHARACTERISTIC_02 { get; set; }
        [C(3)]
        public C273 ITEMDESCRIPTION_03 { get; set; }
        [D(4, "7383")]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    public class PIA
    {
        
        [D(1, "4347")]
        public string Productidentifiercodequalifier_01 { get; set; }
        [C(2)]
        public C212 ITEMNUMBERIDENTIFICATION_02 { get; set; }
        [C(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        [C(4)]
        public C212 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        [C(5)]
        public C212 ITEMNUMBERIDENTIFICATION_05 { get; set; }
        [C(6)]
        public C212 ITEMNUMBERIDENTIFICATION_06 { get; set; }
    }
    
    public class LIN
    {
        
        [D(1, "1082")]
        public string Lineitemidentifier_01 { get; set; }
        [D(2, "1229")]
        public string Actionrequestnotificationdescriptioncode_02 { get; set; }
        [C(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        [C(4)]
        public C829 SUBLINEINFORMATION_04 { get; set; }
        [D(5, "1222")]
        public string Configurationlevelnumber_05 { get; set; }
        [D(6, "7083")]
        public string Configurationoperationcode_06 { get; set; }
    }
    
    public class INP
    {
        
        [C(1)]
        public C849 PARTIESTOINSTRUCTION_01 { get; set; }
        [C(2)]
        public C522 INSTRUCTION_02 { get; set; }
        [C(3)]
        public C850 STATUSOFINSTRUCTION_03 { get; set; }
        [D(4, "1229")]
        public string Actionrequestnotificationdescriptioncode_04 { get; set; }
    }
    
    public class AJT
    {
        
        [D(1, "4465")]
        public string Adjustmentreasondescriptioncode_01 { get; set; }
        [D(2, "1082")]
        public string Lineitemidentifier_02 { get; set; }
    }
    
    public class SEL
    {
        
        [D(1, "9308")]
        public string Sealidentifier_01 { get; set; }
        [C(2)]
        public C215 SEALISSUER_02 { get; set; }
        [D(3, "4517")]
        public string Sealconditioncode_03 { get; set; }
        [C(4)]
        public C208 IDENTITYNUMBERRANGE_04 { get; set; }
    }
    
    public class TSR
    {
        
        [C(1)]
        public C536 CONTRACTANDCARRIAGECONDITION_01 { get; set; }
        [C(2)]
        public C233 SERVICE_02 { get; set; }
        [C(3)]
        public C537 TRANSPORTPRIORITY_03 { get; set; }
        [C(4)]
        public C703 NATUREOFCARGO_04 { get; set; }
    }
    
    public class PAI
    {
        
        [C(1)]
        public C534 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    public class BGM
    {
        
        [C(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        [C(2)]
        public C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        [D(3, "1225")]
        public string Messagefunctioncode_03 { get; set; }
        [D(4, "4343")]
        public string Responsetypecode_04 { get; set; }
    }
    
    public class UNH
    {
        
        [D(1, "0062")]
        public string MessageReferenceNumber_01 { get; set; }
        [C(2)]
        public S009 MessageIdentifier_02 { get; set; }
        [D(3, "0068")]
        public string CommonAccessReference_03 { get; set; }
        [C(4)]
        public S010 StatusoftheTransfer_04 { get; set; }
        [C(5)]
        public S016 MessageSubsetIdentification_05 { get; set; }
        [C(6)]
        public S017 MessageImplementationGuidelineIdentification_06 { get; set; }
        [C(7)]
        public S018 ScenarioIdentification_07 { get; set; }
    }
}
