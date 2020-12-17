namespace EdiFabric.Templates.EdifactD96A
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System.Xml.Serialization;
    
    
    public interface I_AJT
    {
        
        string Adjustmentreasoncoded_01 { get; set; }
        string Lineitemnumber_02 { get; set; }
    }
    
    public interface I_ALC<T1, T2>
        where T1 : I_C552
        where T2 : I_C214
    {
        
        string Allowanceorchargequalifier_01 { get; set; }
        T1 ALLOWANCECHARGEINFORMATION_02 { get; set; }
        string Settlementcoded_03 { get; set; }
        string Calculationsequenceindicatorcoded_04 { get; set; }
        T2 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    public interface I_ALI
    {
        
        string Countryoforigincoded_01 { get; set; }
        string Typeofdutyregimecoded_02 { get; set; }
        string Specialconditionscoded_03 { get; set; }
        string Specialconditionscoded_04 { get; set; }
        string Specialconditionscoded_05 { get; set; }
        string Specialconditionscoded_06 { get; set; }
        string Specialconditionscoded_07 { get; set; }
    }
    
    public interface I_APR<T1, T2>
        where T1 : I_C138
        where T2 : I_C960
    {
        
        string Classoftradecoded_01 { get; set; }
        T1 PRICEMULTIPLIERINFORMATION_02 { get; set; }
        T2 REASONFORCHANGE_03 { get; set; }
    }
    
    public interface I_BGM<T1>
        where T1 : I_C002
    {
        
        T1 DOCUMENTMESSAGENAME_01 { get; set; }
        string Documentmessagenumber_02 { get; set; }
        string Messagefunctioncoded_03 { get; set; }
        string Responsetypecoded_04 { get; set; }
    }
    
    public interface I_CAV<T1>
        where T1 : I_C889
    {
        
        T1 CHARACTERISTICVALUE_01 { get; set; }
    }
    
    public interface I_CCI<T1, T2>
        where T1 : I_C502
        where T2 : I_C240
    {
        
        string Propertyclasscoded_01 { get; set; }
        T1 MEASUREMENTDETAILS_02 { get; set; }
        T2 PRODUCTCHARACTERISTIC_03 { get; set; }
    }
    
    public interface I_CNI<T1>
        where T1 : I_C503
    {
        
        string Consolidationitemnumber_01 { get; set; }
        T1 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        string Consignmentloadsequencenumber_03 { get; set; }
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
    
    public interface I_CPI<T1, T2>
        where T1 : I_C229
        where T2 : I_C231
    {
        
        T1 CHARGECATEGORY_01 { get; set; }
        T2 METHODOFPAYMENT_02 { get; set; }
        string Prepaidcollectindicatorcoded_03 { get; set; }
    }
    
    public interface I_CPS
    {
        
        string Hierarchicalidnumber_01 { get; set; }
        string Hierarchicalparentid_02 { get; set; }
        string Packaginglevelcoded_03 { get; set; }
    }
    
    public interface I_CTA<T1>
        where T1 : I_C056
    {
        
        string Contactfunctioncoded_01 { get; set; }
        T1 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    public interface I_CUX<T1, T2>
        where T1 : I_C504
        where T2 : I_C504
    {
        
        T1 CURRENCYDETAILS_01 { get; set; }
        T2 CURRENCYDETAILS_02 { get; set; }
        string Rateofexchange_03 { get; set; }
        string Currencymarketexchangecoded_04 { get; set; }
    }
    
    public interface I_DGS<T1, T2, T3, T4, T5>
        where T1 : I_C205
        where T2 : I_C234
        where T3 : I_C223
        where T4 : I_C235
        where T5 : I_C236
    {
        
        string Dangerousgoodsregulationscoded_01 { get; set; }
        T1 HAZARDCODE_02 { get; set; }
        T2 UNDGINFORMATION_03 { get; set; }
        T3 DANGEROUSGOODSSHIPMENTFLASHPOINT_04 { get; set; }
        string Packinggroupcoded_05 { get; set; }
        string EMSnumber_06 { get; set; }
        string MFAG_07 { get; set; }
        string Tremcardnumber_08 { get; set; }
        T4 HAZARDIDENTIFICATION_09 { get; set; }
        T5 DANGEROUSGOODSLABEL_10 { get; set; }
        string Packinginstructioncoded_11 { get; set; }
        string Categoryofmeansoftransportcoded_12 { get; set; }
        string Permissionfortransportcoded_13 { get; set; }
    }
    
    public interface I_DIM<T1>
        where T1 : I_C211
    {
        
        string Dimensionqualifier_01 { get; set; }
        T1 DIMENSIONS_02 { get; set; }
    }
    
    public interface I_DLM<T1, T2>
        where T1 : I_C522
        where T2 : I_C214
    {
        
        string Backordercoded_01 { get; set; }
        T1 INSTRUCTION_02 { get; set; }
        T2 SPECIALSERVICESIDENTIFICATION_03 { get; set; }
        string Productservicesubstitutioncoded_04 { get; set; }
    }
    
    public interface I_DOC<T1, T2>
        where T1 : I_C002
        where T2 : I_C503
    {
        
        T1 DOCUMENTMESSAGENAME_01 { get; set; }
        T2 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        string Communicationchannelidentifiercoded_03 { get; set; }
        string Numberofcopiesofdocumentrequired_04 { get; set; }
        string Numberoforiginalsofdocumentrequired_05 { get; set; }
    }
    
    public interface I_DTM<T1>
        where T1 : I_C507
    {
        
        T1 DATETIMEPERIOD_01 { get; set; }
    }
    
    public interface I_EQA<T1>
        where T1 : I_C237
    {
        
        string Equipmentqualifier_01 { get; set; }
        T1 EQUIPMENTIDENTIFICATION_02 { get; set; }
    }
    
    public interface I_EQD<T1, T2>
        where T1 : I_C237
        where T2 : I_C224
    {
        
        string Equipmentqualifier_01 { get; set; }
        T1 EQUIPMENTIDENTIFICATION_02 { get; set; }
        T2 EQUIPMENTSIZEANDTYPE_03 { get; set; }
        string Equipmentsuppliercoded_04 { get; set; }
        string Equipmentstatuscoded_05 { get; set; }
        string Fullemptyindicatorcoded_06 { get; set; }
    }
    
    public interface I_EQN<T1>
        where T1 : I_C523
    {
        
        T1 NUMBEROFUNITDETAILS_01 { get; set; }
    }
    
    public interface I_FII<T1, T2>
        where T1 : I_C078
        where T2 : I_C088
    {
        
        string Partyqualifier_01 { get; set; }
        T1 ACCOUNTIDENTIFICATION_02 { get; set; }
        T2 INSTITUTIONIDENTIFICATION_03 { get; set; }
        string Countrycoded_04 { get; set; }
    }
    
    public interface I_FTX<T1, T2>
        where T1 : I_C107
        where T2 : I_C108
    {
        
        string Textsubjectqualifier_01 { get; set; }
        string Textfunctioncoded_02 { get; set; }
        T1 TEXTREFERENCE_03 { get; set; }
        T2 TEXTLITERAL_04 { get; set; }
        string Languagecoded_05 { get; set; }
    }
    
    public interface I_GDS<T1>
        where T1 : I_C703
    {
        
        T1 NATUREOFCARGO_01 { get; set; }
    }
    
    public interface I_GID<T1, T2, T3>
        where T1 : I_C213
        where T2 : I_C213
        where T3 : I_C213
    {
        
        string Goodsitemnumber_01 { get; set; }
        T1 NUMBERANDTYPEOFPACKAGES_02 { get; set; }
        T2 NUMBERANDTYPEOFPACKAGES_03 { get; set; }
        T3 NUMBERANDTYPEOFPACKAGES_04 { get; set; }
    }
    
    public interface I_GIN<T1, T2, T3, T4, T5>
        where T1 : I_C208
        where T2 : I_C208
        where T3 : I_C208
        where T4 : I_C208
        where T5 : I_C208
    {
        
        string Identitynumberqualifier_01 { get; set; }
        T1 IDENTITYNUMBERRANGE_02 { get; set; }
        T2 IDENTITYNUMBERRANGE_03 { get; set; }
        T3 IDENTITYNUMBERRANGE_04 { get; set; }
        T4 IDENTITYNUMBERRANGE_05 { get; set; }
        T5 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    public interface I_GIR<T1, T2, T3, T4, T5>
        where T1 : I_C206
        where T2 : I_C206
        where T3 : I_C206
        where T4 : I_C206
        where T5 : I_C206
    {
        
        string Setidentificationqualifier_01 { get; set; }
        T1 IDENTIFICATIONNUMBER_02 { get; set; }
        T2 IDENTIFICATIONNUMBER_03 { get; set; }
        T3 IDENTIFICATIONNUMBER_04 { get; set; }
        T4 IDENTIFICATIONNUMBER_05 { get; set; }
        T5 IDENTIFICATIONNUMBER_06 { get; set; }
    }
    
    public interface I_GOR<T1, T2, T3, T4>
        where T1 : I_C232
        where T2 : I_C232
        where T3 : I_C232
        where T4 : I_C232
    {
        
        string Transportmovementcoded_01 { get; set; }
        T1 GOVERNMENTACTION_02 { get; set; }
        T2 GOVERNMENTACTION_03 { get; set; }
        T3 GOVERNMENTACTION_04 { get; set; }
        T4 GOVERNMENTACTION_05 { get; set; }
    }
    
    public interface I_HAN<T1, T2>
        where T1 : I_C524
        where T2 : I_C218
    {
        
        T1 HANDLINGINSTRUCTIONS_01 { get; set; }
        T2 HAZARDOUSMATERIAL_02 { get; set; }
    }
    
    public interface I_IMD<T1>
        where T1 : I_C273
    {
        
        string Itemdescriptiontypecoded_01 { get; set; }
        string Itemcharacteristiccoded_02 { get; set; }
        T1 ITEMDESCRIPTION_03 { get; set; }
        string Surfacelayerindicatorcoded_04 { get; set; }
    }
    
    public interface I_INP<T1, T2, T3>
        where T1 : I_C849
        where T2 : I_C522
        where T3 : I_C850
    {
        
        T1 PARTIESTOINSTRUCTION_01 { get; set; }
        T2 INSTRUCTION_02 { get; set; }
        T3 STATUSOFINSTRUCTION_03 { get; set; }
        string Actionrequestnotificationcoded_04 { get; set; }
    }
    
    public interface I_LIN<T1, T2>
        where T1 : I_C212
        where T2 : I_C829
    {
        
        string Lineitemnumber_01 { get; set; }
        string Actionrequestnotificationcoded_02 { get; set; }
        T1 ITEMNUMBERIDENTIFICATION_03 { get; set; }
        T2 SUBLINEINFORMATION_04 { get; set; }
        string Configurationlevel_05 { get; set; }
        string Configurationcoded_06 { get; set; }
    }
    
    public interface I_LOC<T1, T2, T3>
        where T1 : I_C517
        where T2 : I_C519
        where T3 : I_C553
    {
        
        string Placelocationqualifier_01 { get; set; }
        T1 LOCATIONIDENTIFICATION_02 { get; set; }
        T2 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        T3 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        string Relationcoded_05 { get; set; }
    }
    
    public interface I_MEA<T1, T2>
        where T1 : I_C502
        where T2 : I_C174
    {
        
        string Measurementapplicationqualifier_01 { get; set; }
        T1 MEASUREMENTDETAILS_02 { get; set; }
        T2 VALUERANGE_03 { get; set; }
        string Surfacelayerindicatorcoded_04 { get; set; }
    }
    
    public interface I_MOA<T1>
        where T1 : I_C516
    {
        
        T1 MONETARYAMOUNT_01 { get; set; }
    }
    
    public interface I_NAD<T1, T2, T3, T4>
        where T1 : I_C082
        where T2 : I_C058
        where T3 : I_C080
        where T4 : I_C059
    {
        
        string Partyqualifier_01 { get; set; }
        T1 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        T2 NAMEANDADDRESS_03 { get; set; }
        T3 PARTYNAME_04 { get; set; }
        T4 STREET_05 { get; set; }
        string Cityname_06 { get; set; }
        string Countrysubentityidentification_07 { get; set; }
        string Postcodeidentification_08 { get; set; }
        string Countrycoded_09 { get; set; }
    }
    
    public interface I_PAC<T1, T2, T3, T4>
        where T1 : I_C531
        where T2 : I_C202
        where T3 : I_C402
        where T4 : I_C532
    {
        
        string Numberofpackages_01 { get; set; }
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
        
        string Paymenttermstypequalifier_01 { get; set; }
        T1 PAYMENTTERMS_02 { get; set; }
        T2 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    public interface I_PCD<T1>
        where T1 : I_C501
    {
        
        T1 PERCENTAGEDETAILS_01 { get; set; }
    }
    
    public interface I_PCI<T1, T2>
        where T1 : I_C210
        where T2 : I_C827
    {
        
        string Markinginstructionscoded_01 { get; set; }
        T1 MARKSLABELS_02 { get; set; }
        string Containerpackagestatuscoded_03 { get; set; }
        T2 TYPEOFMARKING_04 { get; set; }
    }
    
    public interface I_PGI<T1>
        where T1 : I_C288
    {
        
        string Productgrouptypecoded_01 { get; set; }
        T1 PRODUCTGROUP_02 { get; set; }
    }
    
    public interface I_PIA<T1, T2, T3, T4, T5>
        where T1 : I_C212
        where T2 : I_C212
        where T3 : I_C212
        where T4 : I_C212
        where T5 : I_C212
    {
        
        string Productidfunctionqualifier_01 { get; set; }
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
        string Sublinepricechangecoded_02 { get; set; }
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
        string Discrepancycoded_02 { get; set; }
        T2 REASONFORCHANGE_03 { get; set; }
    }
    
    public interface I_RCS<T1>
        where T1 : I_C550
    {
        
        string Sectorsubjectidentificationqualifier_01 { get; set; }
        T1 REQUIREMENTCONDITIONIDENTIFICATION_02 { get; set; }
        string Actionrequestnotificationcoded_03 { get; set; }
    }
    
    public interface I_RFF<T1>
        where T1 : I_C506
    {
        
        T1 REFERENCE_01 { get; set; }
    }
    
    public interface I_RNG<T1>
        where T1 : I_C280
    {
        
        string Rangetypequalifier_01 { get; set; }
        T1 RANGE_02 { get; set; }
    }
    
    public interface I_RTE<T1>
        where T1 : I_C128
    {
        
        T1 RATEDETAILS_01 { get; set; }
    }
    
    public interface I_SCC<T1>
        where T1 : I_C329
    {
        
        string Deliveryplanstatusindicatorcoded_01 { get; set; }
        string Deliveryrequirementscoded_02 { get; set; }
        T1 PATTERNDESCRIPTION_03 { get; set; }
    }
    
    public interface I_SEL<T1>
        where T1 : I_C215
    {
        
        string Sealnumber_01 { get; set; }
        T1 SEALISSUER_02 { get; set; }
        string Sealconditioncoded_03 { get; set; }
    }
    
    public interface I_SGP<T1>
        where T1 : I_C237
    {
        
        T1 EQUIPMENTIDENTIFICATION_01 { get; set; }
        string Numberofpackages_02 { get; set; }
    }
    
    public interface I_STG
    {
        
        string Stagesqualifier_01 { get; set; }
        string Numberofstages_02 { get; set; }
        string Actualstagecount_03 { get; set; }
    }
    
    public interface I_STS<T1, T2, T3, T4, T5, T6, T7>
        where T1 : I_C601
        where T2 : I_C555
        where T3 : I_C556
        where T4 : I_C556
        where T5 : I_C556
        where T6 : I_C556
        where T7 : I_C556
    {
        
        T1 STATUSTYPE_01 { get; set; }
        T2 STATUSEVENT_02 { get; set; }
        T3 STATUSREASON_03 { get; set; }
        T4 STATUSREASON_04 { get; set; }
        T5 STATUSREASON_05 { get; set; }
        T6 STATUSREASON_06 { get; set; }
        T7 STATUSREASON_07 { get; set; }
    }
    
    public interface I_TAX<T1, T2, T3>
        where T1 : I_C241
        where T2 : I_C533
        where T3 : I_C243
    {
        
        string Dutytaxfeefunctionqualifier_01 { get; set; }
        T1 DUTYTAXFEETYPE_02 { get; set; }
        T2 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }
        string Dutytaxfeeassessmentbasis_04 { get; set; }
        T3 DUTYTAXFEEDETAIL_05 { get; set; }
        string Dutytaxfeecategorycoded_06 { get; set; }
        string Partytaxidentificationnumber_07 { get; set; }
    }
    
    public interface I_TCC<T1, T2, T3, T4>
        where T1 : I_C200
        where T2 : I_C203
        where T3 : I_C528
        where T4 : I_C554
    {
        
        T1 CHARGE_01 { get; set; }
        T2 RATETARIFFCLASS_02 { get; set; }
        T3 COMMODITYRATEDETAIL_03 { get; set; }
        T4 RATETARIFFCLASSDETAIL_04 { get; set; }
    }
    
    public interface I_TDT<T1, T2, T3, T4, T5>
        where T1 : I_C220
        where T2 : I_C228
        where T3 : I_C040
        where T4 : I_C401
        where T5 : I_C222
    {
        
        string Transportstagequalifier_01 { get; set; }
        string Conveyancereferencenumber_02 { get; set; }
        T1 MODEOFTRANSPORT_03 { get; set; }
        T2 TRANSPORTMEANS_04 { get; set; }
        T3 CARRIER_05 { get; set; }
        string Transitdirectioncoded_06 { get; set; }
        T4 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }
        T5 TRANSPORTIDENTIFICATION_08 { get; set; }
        string Transportownershipcoded_09 { get; set; }
    }
    
    public interface I_TMD<T1>
        where T1 : I_C219
    {
        
        T1 MOVEMENTTYPE_01 { get; set; }
        string Equipmentplan_02 { get; set; }
        string Haulagearrangementscoded_03 { get; set; }
    }
    
    public interface I_TMP<T1>
        where T1 : I_C239
    {
        
        string Temperaturequalifier_01 { get; set; }
        T1 TEMPERATURESETTING_02 { get; set; }
    }
    
    public interface I_TOD<T1>
        where T1 : I_C100
    {
        
        string Termsofdeliveryortransportfunctioncoded_01 { get; set; }
        string Transportchargesmethodofpaymentcoded_02 { get; set; }
        T1 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    public interface I_TPL<T1>
        where T1 : I_C222
    {
        
        T1 TRANSPORTIDENTIFICATION_01 { get; set; }
    }
    
    public interface I_TSR<T1, T2, T3, T4>
        where T1 : I_C536
        where T2 : I_C233
        where T3 : I_C537
        where T4 : I_C703
    {
        
        T1 CONTRACTANDCARRIAGECONDITION_01 { get; set; }
        T2 SERVICE_02 { get; set; }
        T3 TRANSPORTPRIORITY_03 { get; set; }
        T4 NATUREOFCARGO_04 { get; set; }
    }
    
    public interface I_UNS
    {
        
        string Sectionidentification_01 { get; set; }
    }
}
