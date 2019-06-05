namespace EdiFabric.Templates.EancomD01B
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System.Xml.Serialization;
    
    
    public interface I_ALC<T1, T2>
        where T1 : I_C552
        where T2 : I_C214
    {
        
        string Allowanceorchargecodequalifier_01 { get; set; }
        T1 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        string Settlementmeanscode_03 { get; set; }
        string Calculationsequencecode_04 { get; set; }
        T2 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    public interface I_ALI
    {
        
        string Countryoforiginnamecode_01 { get; set; }
        string Dutyregimetypecode_02 { get; set; }
        string Specialconditioncode_03 { get; set; }
        string Specialconditioncode_04 { get; set; }
        string Specialconditioncode_05 { get; set; }
        string Specialconditioncode_06 { get; set; }
        string Specialconditioncode_07 { get; set; }
    }
    
    public interface I_APR<T1, T2>
        where T1 : I_C138
        where T2 : I_C960
    {
        
        string Tradeclasscode_01 { get; set; }
        T1 PRICEMULTIPLIERINFORMATION_02 { get; set; }
        T2 REASONFORCHANGE_03 { get; set; }
    }
    
    public interface I_BGM<T1, T2>
        where T1 : I_C002
        where T2 : I_C106
    {
        
        T1 DOCUMENTMESSAGENAME_01 { get; set; }
        T2 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        string Messagefunctioncode_03 { get; set; }
        string Responsetypecode_04 { get; set; }
    }
    
    public interface I_CNT<T1>
        where T1 : I_C270
    {
        
        T1 CONTROL_01 { get; set; }
    }
    
    public interface I_COM<T1>
        where T1 : I_C076
    {
        
        T1 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    public interface I_CTA<T1>
        where T1 : I_C056
    {
        
        string Contactfunctioncode_01 { get; set; }
        T1 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    public interface I_CUX<T1, T2>
        where T1 : I_C504
        where T2 : I_C504
    {
        
        T1 CURRENCYDETAILS_01 { get; set; }
        T2 CURRENCYDETAILS_02 { get; set; }
        string Currencyexchangerate_03 { get; set; }
        string Exchangeratecurrencymarketidentifier_04 { get; set; }
    }
    
    public interface I_DTM<T1>
        where T1 : I_C507
    {
        
        T1 DATETIMEPERIOD_01 { get; set; }
    }
    
    public interface I_FII<T1, T2>
        where T1 : I_C078
        where T2 : I_C088
    {
        
        string Partyfunctioncodequalifier_01 { get; set; }
        T1 ACCOUNTHOLDERIDENTIFICATION_02 { get; set; }
        T2 INSTITUTIONIDENTIFICATION_03 { get; set; }
        string Countrynamecode_04 { get; set; }
    }
    
    public interface I_FTX<T1, T2>
        where T1 : I_C107
        where T2 : I_C108
    {
        
        string Textsubjectcodequalifier_01 { get; set; }
        string Freetextfunctioncode_02 { get; set; }
        T1 TEXTREFERENCE_03 { get; set; }
        T2 TEXTLITERAL_04 { get; set; }
        string Languagenamecode_05 { get; set; }
        string Freetextformatcode_06 { get; set; }
    }
    
    public interface I_GIN<T1, T2, T3, T4, T5>
        where T1 : I_C208
        where T2 : I_C208
        where T3 : I_C208
        where T4 : I_C208
        where T5 : I_C208
    {
        
        string Objectidentificationcodequalifier_01 { get; set; }
        T1 IDENTITYNUMBERRANGE_02 { get; set; }
        T2 IDENTITYNUMBERRANGE_03 { get; set; }
        T3 IDENTITYNUMBERRANGE_04 { get; set; }
        T4 IDENTITYNUMBERRANGE_05 { get; set; }
        T5 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    public interface I_IMD<T1, T2>
        where T1 : I_C272
        where T2 : I_C273
    {
        
        string Descriptionformatcode_01 { get; set; }
        T1 ITEMCHARACTERISTIC_02 { get; set; }
        T2 ITEMDESCRIPTION_03 { get; set; }
        string Surfaceorlayercode_04 { get; set; }
    }
    
    public interface I_LIN<T1, T2>
        where T1 : I_C212
        where T2 : I_C829
    {
        
        string Lineitemidentifier_01 { get; set; }
        string Actionrequestnotificationdescriptioncode_02 { get; set; }
        T1 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        T2 SUBLINEINFORMATION_04 { get; set; }
        string Configurationlevelnumber_05 { get; set; }
        string Configurationoperationcode_06 { get; set; }
    }
    
    public interface I_LOC<T1, T2, T3>
        where T1 : I_C517
        where T2 : I_C519
        where T3 : I_C553
    {
        
        string Locationfunctioncodequalifier_01 { get; set; }
        T1 LOCATIONIDENTIFICATION_02 { get; set; }
        T2 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        T3 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        string Relationcode_05 { get; set; }
    }
    
    public interface I_MEA<T1, T2>
        where T1 : I_C502
        where T2 : I_C174
    {
        
        string Measurementpurposecodequalifier_01 { get; set; }
        T1 MEASUREMENTDETAILS_02 { get; set; }
        T2 VALUERANGE_03 { get; set; }
        string Surfaceorlayercode_04 { get; set; }
    }
    
    public interface I_MOA<T1>
        where T1 : I_C516
    {
        
        T1 MONETARYAMOUNT_01 { get; set; }
    }
    
    public interface I_NAD<T1, T2, T3, T4, T5>
        where T1 : I_C082
        where T2 : I_C058
        where T3 : I_C080
        where T4 : I_C059
        where T5 : I_C819
    {
        
        string Partyfunctioncodequalifier_01 { get; set; }
        T1 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        T2 NAMEANDADDRESS_03 { get; set; }
        T3 PARTYNAME_04 { get; set; }
        T4 STREET_05 { get; set; }
        string Cityname_06 { get; set; }
        T5 COUNTRYSUBENTITYDETAILS_07 { get; set; }
        string Postalidentificationcode_08 { get; set; }
        string Countrynamecode_09 { get; set; }
    }
    
    public interface I_PAC<T1, T2, T3, T4>
        where T1 : I_C531
        where T2 : I_C202
        where T3 : I_C402
        where T4 : I_C532
    {
        
        string Packagequantity_01 { get; set; }
        T1 PACKAGINGDETAILS_02 { get; set; }
        T2 PACKAGETYPE_03 { get; set; }
        T3 PACKAGETYPEIDENTIFICATION_04 { get; set; }
        T4 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    public interface I_PAI<T1>
        where T1 : I_C534
    {
        
        T1 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    public interface I_PAT<T1, T2>
        where T1 : I_C110
        where T2 : I_C112
    {
        
        string Paymenttermstypecodequalifier_01 { get; set; }
        T1 PAYMENTTERMS_02 { get; set; }
        T2 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    public interface I_PCD<T1>
        where T1 : I_C501
    {
        
        T1 PERCENTAGEDETAILS_01 { get; set; }
        string Statusdescriptioncode_02 { get; set; }
    }
    
    public interface I_PCI<T1, T2>
        where T1 : I_C210
        where T2 : I_C827
    {
        
        string Markinginstructionscode_01 { get; set; }
        T1 MARKSLABELS_02 { get; set; }
        string Containerorpackagecontentsindicatorcode_03 { get; set; }
        T2 TYPEOFMARKING_04 { get; set; }
    }
    
    public interface I_PIA<T1, T2, T3, T4, T5>
        where T1 : I_C212
        where T2 : I_C212
        where T3 : I_C212
        where T4 : I_C212
        where T5 : I_C212
    {
        
        string Productidentifiercodequalifier_01 { get; set; }
        T1 ITEMNUMBERIDENTIFICATION_02 { get; set; }
        T2 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        T3 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        T4 ITEMNUMBERIDENTIFICATION_05 { get; set; }
        T5 ITEMNUMBERIDENTIFICATION_06 { get; set; }
    }
    
    public interface I_PRI<T1>
        where T1 : I_C509
    {
        
        T1 PRICEINFORMATION_01 { get; set; }
        string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    public interface I_QTY<T1>
        where T1 : I_C186
    {
        
        T1 QUANTITYDETAILS_01 { get; set; }
    }
    
    public interface I_QVR<T1, T2>
        where T1 : I_C279
        where T2 : I_C960
    {
        
        T1 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }
        string Discrepancynatureidentificationcode_02 { get; set; }
        T2 REASONFORCHANGE_03 { get; set; }
    }
    
    public interface I_RFF<T1>
        where T1 : I_C506
    {
        
        T1 REFERENCE_01 { get; set; }
    }
    
    public interface I_RTE<T1>
        where T1 : I_C128
    {
        
        T1 RATEDETAILS_01 { get; set; }
        string Statusdescriptioncode_02 { get; set; }
    }
    
    public interface I_TAX<T1, T2, T3>
        where T1 : I_C241
        where T2 : I_C533
        where T3 : I_C243
    {
        
        string Dutyortaxorfeefunctioncodequalifier_01 { get; set; }
        T1 DUTYTAXFEETYPE_02 { get; set; }
        T2 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        string Dutyortaxorfeeassessmentbasisvalue_04 { get; set; }
        T3 DUTYTAXFEEDETAIL_05 { get; set; }
        string Dutyortaxorfeecategorycode_06 { get; set; }
        string Partytaxidentifier_07 { get; set; }
        string Calculationsequencecode_08 { get; set; }
    }
    
    public interface I_TDT<T1, T2, T3, T4, T5>
        where T1 : I_C220
        where T2 : I_C228
        where T3 : I_C040
        where T4 : I_C401
        where T5 : I_C222
    {
        
        string Transportstagecodequalifier_01 { get; set; }
        string Meansoftransportjourneyidentifier_02 { get; set; }
        T1 MODEOFTRANSPORT_03 { get; set; }
        T2 TRANSPORTMEANS_04 { get; set; }
        T3 CARRIER_05 { get; set; }
        string Transitdirectionindicatorcode_06 { get; set; }
        T4 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        T5 TRANSPORTIDENTIFICATION_08 { get; set; }
        string Transportmeansownershipindicatorcode_09 { get; set; }
    }
    
    public interface I_TOD<T1>
        where T1 : I_C100
    {
        
        string Deliveryortransporttermsfunctioncode_01 { get; set; }
        string Transportchargespaymentmethodcode_02 { get; set; }
        T1 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    public interface I_UNS
    {
        
        string Sectionidentification_01 { get; set; }
    }
}
