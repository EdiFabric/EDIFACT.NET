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
    
    
    public interface I_ADR<T1, T2, T3, T4>
        where T1 : I_C817
        where T2 : I_C090
        where T3 : I_C819
        where T4 : I_C517
    {
        
        T1 ADDRESSUSAGE_01 { get; set; }
        T2 ADDRESSDETAILS_02 { get; set; }
        string Cityname_03 { get; set; }
        string Postcodeidentification_04 { get; set; }
        string Countrycoded_05 { get; set; }
        T3 COUNTRYSUBENTITYDETAILS_06 { get; set; }
        T4 LOCATIONIDENTIFICATION_07 { get; set; }
    }
    
    public interface I_AGR<T1>
        where T1 : I_C543
    {
        
        T1 AGREEMENTTYPEIDENTIFICATION_01 { get; set; }
        string Servicelayercoded_02 { get; set; }
    }
    
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
    
    public interface I_ARD<T1>
        where T1 : I_C549
    {
        
        T1 MONETARYFUNCTION_01 { get; set; }
    }
    
    public interface I_ARR<T1, T2>
        where T1 : I_C778
        where T2 : I_C770
    {
        
        T1 POSITIONIDENTIFICATION_01 { get; set; }
        T2 ARRAYCELLDETAILS_02 { get; set; }
    }
    
    public interface I_ASI<T1, T2>
        where T1 : I_C779
        where T2 : I_C082
    {
        
        T1 ARRAYSTRUCTUREIDENTIFICATION_01 { get; set; }
        T2 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        string Statuscoded_03 { get; set; }
        string Maintenanceoperationcoded_04 { get; set; }
    }
    
    public interface I_ATT<T1, T2>
        where T1 : I_C955
        where T2 : I_C956
    {
        
        string Attributefunctionqualifier_01 { get; set; }
        T1 ATTRIBUTETYPE_02 { get; set; }
        T2 ATTRIBUTEDETAILS_03 { get; set; }
    }
    
    public interface I_AUT
    {
        
        string Validationresult_01 { get; set; }
        string Validationkeyidentification_02 { get; set; }
    }
    
    public interface I_BGM<T1>
        where T1 : I_C002
    {
        
        T1 DOCUMENTMESSAGENAME_01 { get; set; }
        string Documentmessagenumber_02 { get; set; }
        string Messagefunctioncoded_03 { get; set; }
        string Responsetypecoded_04 { get; set; }
    }
    
    public interface I_BII<T1>
        where T1 : I_C045
    {
        
        string Indexingstructurequalifier_01 { get; set; }
        T1 BILLLEVELIDENTIFICATION_02 { get; set; }
        string Itemnumber_03 { get; set; }
    }
    
    public interface I_BUS<T1, T2>
        where T1 : I_C521
        where T2 : I_C551
    {
        
        T1 BUSINESSFUNCTION_01 { get; set; }
        string Geographicenvironmentcoded_02 { get; set; }
        string Typeoffinancialtransactioncoded_03 { get; set; }
        T2 BANKOPERATION_04 { get; set; }
        string Intracompanypaymentcoded_05 { get; set; }
    }
    
    public interface I_CAV<T1>
        where T1 : I_C889
    {
        
        T1 CHARACTERISTICVALUE_01 { get; set; }
    }
    
    public interface I_CCD
    {
        
        string Creditcoverrequestcoded_01 { get; set; }
        string Creditcoverresponsecoded_02 { get; set; }
        string Creditcoverreasoncoded_03 { get; set; }
    }
    
    public interface I_CCI<T1, T2>
        where T1 : I_C502
        where T2 : I_C240
    {
        
        string Propertyclasscoded_01 { get; set; }
        T1 MEASUREMENTDETAILS_02 { get; set; }
        T2 PRODUCTCHARACTERISTIC_03 { get; set; }
    }
    
    public interface I_CDI<T1>
        where T1 : I_C564
    {
        
        string Physicalorlogicalstatequalifier_01 { get; set; }
        T1 PHYSICALORLOGICALSTATEINFORMATION_02 { get; set; }
    }
    
    public interface I_CDS<T1>
        where T1 : I_C702
    {
        
        T1 CODESETIDENTIFICATION_01 { get; set; }
        string Classdesignatorcoded_02 { get; set; }
        string Maintenanceoperationcoded_03 { get; set; }
    }
    
    public interface I_CDV
    {
        
        string Codevalue_01 { get; set; }
        string Codename_02 { get; set; }
        string Maintenanceoperationcoded_03 { get; set; }
    }
    
    public interface I_CED<T1>
        where T1 : I_C079
    {
        
        string Computerenvironmentdetailsqualifier_01 { get; set; }
        T1 COMPUTERENVIRONMENTIDENTIFICATION_02 { get; set; }
    }
    
    public interface I_CMP
    {
        
        string Compositedataelementtag_01 { get; set; }
        string Classdesignatorcoded_02 { get; set; }
        string Maintenanceoperationcoded_03 { get; set; }
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
    
    public interface I_COD<T1, T2>
        where T1 : I_C823
        where T2 : I_C824
    {
        
        T1 TYPEOFUNITCOMPONENT_01 { get; set; }
        T2 COMPONENTMATERIAL_02 { get; set; }
    }
    
    public interface I_COM<T1>
        where T1 : I_C076
    {
        
        T1 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    public interface I_COT<T1, T2, T3, T4>
        where T1 : I_C953
        where T2 : I_C522
        where T3 : I_C203
        where T4 : I_C960
    {
        
        string Contributionqualifier_01 { get; set; }
        T1 CONTRIBUTIONTYPE_02 { get; set; }
        T2 INSTRUCTION_03 { get; set; }
        T3 RATETARIFFCLASS_04 { get; set; }
        T4 REASONFORCHANGE_05 { get; set; }
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
    
    public interface I_CST<T1, T2, T3, T4, T5>
        where T1 : I_C246
        where T2 : I_C246
        where T3 : I_C246
        where T4 : I_C246
        where T5 : I_C246
    {
        
        string Goodsitemnumber_01 { get; set; }
        T1 CUSTOMSIDENTITYCODES_02 { get; set; }
        T2 CUSTOMSIDENTITYCODES_03 { get; set; }
        T3 CUSTOMSIDENTITYCODES_04 { get; set; }
        T4 CUSTOMSIDENTITYCODES_05 { get; set; }
        T5 CUSTOMSIDENTITYCODES_06 { get; set; }
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
    
    public interface I_DAM<T1, T2, T3, T4>
        where T1 : I_C821
        where T2 : I_C822
        where T3 : I_C825
        where T4 : I_C826
    {
        
        string Damagedetailsqualifier_01 { get; set; }
        T1 TYPEOFDAMAGE_02 { get; set; }
        T2 DAMAGEAREA_03 { get; set; }
        T3 DAMAGESEVERITY_04 { get; set; }
        T4 ACTION_05 { get; set; }
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
    
    public interface I_DII
    {
        
        string Version_01 { get; set; }
        string Release_02 { get; set; }
        string Directorystatus_03 { get; set; }
        string Controlagency_04 { get; set; }
        string Languagecoded_05 { get; set; }
        string Maintenanceoperationcoded_06 { get; set; }
    }
    
    public interface I_DIM<T1>
        where T1 : I_C211
    {
        
        string Dimensionqualifier_01 { get; set; }
        T1 DIMENSIONS_02 { get; set; }
    }
    
    public interface I_DLI
    {
        
        string Documentlineindicatorcoded_01 { get; set; }
        string Lineitemnumber_02 { get; set; }
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
    
    public interface I_DMS
    {
        
        string Documentmessagenumber_01 { get; set; }
        string Documentmessagenamecoded_02 { get; set; }
        string Totalnumberofitems_03 { get; set; }
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
    
    public interface I_DSI<T1, T2, T3>
        where T1 : I_C782
        where T2 : I_C082
        where T3 : I_C286
    {
        
        T1 DATASETIDENTIFICATION_01 { get; set; }
        T2 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        string Statuscoded_03 { get; set; }
        T3 SEQUENCEINFORMATION_04 { get; set; }
        string Revisionnumber_05 { get; set; }
    }
    
    public interface I_DTM<T1>
        where T1 : I_C507
    {
        
        T1 DATETIMEPERIOD_01 { get; set; }
    }
    
    public interface I_EFI<T1, T2>
        where T1 : I_C077
        where T2 : I_C099
    {
        
        T1 FILEIDENTIFICATION_01 { get; set; }
        T2 FILEDETAILS_02 { get; set; }
        string Sequencenumber_03 { get; set; }
    }
    
    public interface I_ELM
    {
        
        string Simpledataelementtag_01 { get; set; }
        string Simpledataelementcharacterrepresentationcoded_02 { get; set; }
        string Simpledataelementlengthtypecoded_03 { get; set; }
        string Simpledataelementmaximumlength_04 { get; set; }
        string Simpledataelementminimumlength_05 { get; set; }
        string Codesetindicatorcoded_06 { get; set; }
        string Classdesignatorcoded_07 { get; set; }
        string Maintenanceoperationcoded_08 { get; set; }
    }
    
    public interface I_ELU
    {
        
        string Dataelementtag_01 { get; set; }
        string Requirementdesignatorcoded_02 { get; set; }
        string Sequencenumber_03 { get; set; }
        string Maintenanceoperationcoded_04 { get; set; }
    }
    
    public interface I_EMP<T1, T2, T3>
        where T1 : I_C948
        where T2 : I_C951
        where T3 : I_C950
    {
        
        string Employmentqualifier_01 { get; set; }
        T1 EMPLOYMENTCATEGORY_02 { get; set; }
        T2 OCCUPATION_03 { get; set; }
        T3 QUALIFICATIONCLASSIFICATION_04 { get; set; }
        string Jobtitle_05 { get; set; }
        string Qualificationareacoded_06 { get; set; }
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
    
    public interface I_ERC<T1>
        where T1 : I_C901
    {
        
        T1 APPLICATIONERRORDETAIL_01 { get; set; }
    }
    
    public interface I_ERP<T1>
        where T1 : I_C701
    {
        
        T1 ERRORPOINTDETAILS_01 { get; set; }
    }
    
    public interface I_FCA<T1>
        where T1 : I_C878
    {
        
        string Settlementcoded_01 { get; set; }
        T1 CHARGEALLOWANCEACCOUNT_02 { get; set; }
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
    
    public interface I_FNS<T1, T2>
        where T1 : I_C783
        where T2 : I_C082
    {
        
        T1 FOOTNOTESETIDENTIFICATION_01 { get; set; }
        T2 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        string Statuscoded_03 { get; set; }
        string Maintenanceoperationcoded_04 { get; set; }
    }
    
    public interface I_FNT<T1, T2>
        where T1 : I_C784
        where T2 : I_C082
    {
        
        T1 FOOTNOTEIDENTIFICATION_01 { get; set; }
        T2 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        string Statuscoded_03 { get; set; }
        string Maintenanceoperationcoded_04 { get; set; }
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
    
    public interface I_GIS<T1>
        where T1 : I_C529
    {
        
        T1 PROCESSINGINDICATOR_01 { get; set; }
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
    
    public interface I_GRU
    {
        
        string Groupidentification_01 { get; set; }
        string Requirementdesignatorcoded_02 { get; set; }
        string Maximumnumberofoccurrences_03 { get; set; }
        string Maintenanceoperationcoded_04 { get; set; }
        string Sequencenumber_05 { get; set; }
    }
    
    public interface I_HAN<T1, T2>
        where T1 : I_C524
        where T2 : I_C218
    {
        
        T1 HANDLINGINSTRUCTIONS_01 { get; set; }
        T2 HAZARDOUSMATERIAL_02 { get; set; }
    }
    
    public interface I_ICD<T1, T2>
        where T1 : I_C330
        where T2 : I_C331
    {
        
        T1 INSURANCECOVERTYPE_01 { get; set; }
        T2 INSURANCECOVERDETAILS_02 { get; set; }
    }
    
    public interface I_IDE<T1, T2, T3, T4>
        where T1 : I_C206
        where T2 : I_C082
        where T3 : I_C778
        where T4 : I_C240
    {
        
        string Identificationqualifier_01 { get; set; }
        T1 IDENTIFICATIONNUMBER_02 { get; set; }
        T2 PARTYIDENTIFICATIONDETAILS_03 { get; set; }
        string Statuscoded_04 { get; set; }
        string Configurationlevel_05 { get; set; }
        T3 POSITIONIDENTIFICATION_06 { get; set; }
        T4 PRODUCTCHARACTERISTIC_07 { get; set; }
    }
    
    public interface I_IHC<T1>
        where T1 : I_C818
    {
        
        string Personcharacteristicqualifier_01 { get; set; }
        T1 PERSONINHERITEDCHARACTERISTICDETAILS_02 { get; set; }
    }
    
    public interface I_IMD<T1>
        where T1 : I_C273
    {
        
        string Itemdescriptiontypecoded_01 { get; set; }
        string Itemcharacteristiccoded_02 { get; set; }
        T1 ITEMDESCRIPTION_03 { get; set; }
        string Surfacelayerindicatorcoded_04 { get; set; }
    }
    
    public interface I_IND<T1, T2>
        where T1 : I_C545
        where T2 : I_C546
    {
        
        T1 INDEXIDENTIFICATION_01 { get; set; }
        T2 INDEXVALUE_02 { get; set; }
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
    
    public interface I_INV<T1>
        where T1 : I_C522
    {
        
        string Inventorymovementdirectioncoded_01 { get; set; }
        string Typeofinventoryaffectedcoded_02 { get; set; }
        string Reasonforinventorymovementcoded_03 { get; set; }
        string Inventorybalancemethodcoded_04 { get; set; }
        T1 INSTRUCTION_05 { get; set; }
    }
    
    public interface I_IRQ<T1>
        where T1 : I_C333
    {
        
        T1 INFORMATIONREQUEST_01 { get; set; }
    }
    
    public interface I_LAN<T1>
        where T1 : I_C508
    {
        
        string Languagequalifier_01 { get; set; }
        T1 LANGUAGEDETAILS_02 { get; set; }
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
    
    public interface I_MEM<T1, T2, T3, T4, T5>
        where T1 : I_C942
        where T2 : I_C944
        where T3 : I_C945
        where T4 : I_C203
        where T5 : I_C960
    {
        
        string Membershipqualifier_01 { get; set; }
        T1 MEMBERSHIPCATEGORY_02 { get; set; }
        T2 MEMBERSHIPSTATUS_03 { get; set; }
        T3 MEMBERSHIPLEVEL_04 { get; set; }
        T4 RATETARIFFCLASS_05 { get; set; }
        T5 REASONFORCHANGE_06 { get; set; }
    }
    
    public interface I_MKS<T1>
        where T1 : I_C332
    {
        
        string Sectorsubjectidentificationqualifier_01 { get; set; }
        T1 SALESCHANNELIDENTIFICATION_02 { get; set; }
        string Actionrequestnotificationcoded_03 { get; set; }
    }
    
    public interface I_MOA<T1>
        where T1 : I_C516
    {
        
        T1 MONETARYAMOUNT_01 { get; set; }
    }
    
    public interface I_MSG<T1>
        where T1 : I_C709
    {
        
        T1 MESSAGEIDENTIFIER_01 { get; set; }
        string Classdesignatorcoded_02 { get; set; }
        string Maintenanceoperationcoded_03 { get; set; }
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
    
    public interface I_NAT<T1>
        where T1 : I_C042
    {
        
        string Nationalityqualifier_01 { get; set; }
        T1 NATIONALITYDETAILS_02 { get; set; }
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
    
    public interface I_PDI<T1, T2>
        where T1 : I_C085
        where T2 : I_C101
    {
        
        string Sexcoded_01 { get; set; }
        T1 MARITALSTATUSDETAILS_02 { get; set; }
        T2 RELIGIONDETAILS_03 { get; set; }
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
    
    public interface I_PNA<T1, T2, T3, T4, T5, T6, T7>
        where T1 : I_C206
        where T2 : I_C082
        where T3 : I_C816
        where T4 : I_C816
        where T5 : I_C816
        where T6 : I_C816
        where T7 : I_C816
    {
        
        string Partyqualifier_01 { get; set; }
        T1 IDENTIFICATIONNUMBER_02 { get; set; }
        T2 PARTYIDENTIFICATIONDETAILS_03 { get; set; }
        string Nametypecoded_04 { get; set; }
        string Namestatuscoded_05 { get; set; }
        T3 NAMECOMPONENTDETAILS_06 { get; set; }
        T4 NAMECOMPONENTDETAILS_07 { get; set; }
        T5 NAMECOMPONENTDETAILS_08 { get; set; }
        T6 NAMECOMPONENTDETAILS_09 { get; set; }
        T7 NAMECOMPONENTDETAILS_10 { get; set; }
    }
    
    public interface I_PRC<T1>
        where T1 : I_C242
    {
        
        T1 PROCESSTYPEANDDESCRIPTION_01 { get; set; }
    }
    
    public interface I_PRI<T1>
        where T1 : I_C509
    {
        
        T1 PRICEINFORMATION_01 { get; set; }
        string Sublinepricechangecoded_02 { get; set; }
    }
    
    public interface I_PSD<T1, T2, T3, T4>
        where T1 : I_C526
        where T2 : I_C514
        where T3 : I_C514
        where T4 : I_C514
    {
        
        string Sampleprocessstatuscoded_01 { get; set; }
        string Sampleselectionmethodcoded_02 { get; set; }
        T1 FREQUENCYDETAILS_03 { get; set; }
        string Sampledescriptioncoded_04 { get; set; }
        string Sampledirectioncoded_05 { get; set; }
        T2 SAMPLELOCATIONDETAILS_06 { get; set; }
        T3 SAMPLELOCATIONDETAILS_07 { get; set; }
        T4 SAMPLELOCATIONDETAILS_08 { get; set; }
    }
    
    public interface I_PTY<T1>
        where T1 : I_C585
    {
        
        string Priorityqualifier_01 { get; set; }
        T1 PRIORITYDETAILS_02 { get; set; }
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
    
    public interface I_REL<T1>
        where T1 : I_C941
    {
        
        string Relationshipqualifier_01 { get; set; }
        T1 RELATIONSHIP_02 { get; set; }
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
    
    public interface I_SAL<T1>
        where T1 : I_C049
    {
        
        T1 REMUNERATIONTYPEIDENTIFICATION_01 { get; set; }
    }
    
    public interface I_SCC<T1>
        where T1 : I_C329
    {
        
        string Deliveryplanstatusindicatorcoded_01 { get; set; }
        string Deliveryrequirementscoded_02 { get; set; }
        T1 PATTERNDESCRIPTION_03 { get; set; }
    }
    
    public interface I_SCD<T1, T2, T3, T4>
        where T1 : I_C786
        where T2 : I_C082
        where T3 : I_C778
        where T4 : I_C240
    {
        
        string Componentfunctionqualifier_01 { get; set; }
        T1 STRUCTURECOMPONENTIDENTIFICATION_02 { get; set; }
        T2 PARTYIDENTIFICATIONDETAILS_03 { get; set; }
        string Statuscoded_04 { get; set; }
        string Configurationlevel_05 { get; set; }
        T3 POSITIONIDENTIFICATION_06 { get; set; }
        T4 PRODUCTCHARACTERISTIC_07 { get; set; }
    }
    
    public interface I_SEG
    {
        
        string Segmenttag_01 { get; set; }
        string Classdesignatorcoded_02 { get; set; }
        string Maintenanceoperationcoded_03 { get; set; }
    }
    
    public interface I_SEL<T1>
        where T1 : I_C215
    {
        
        string Sealnumber_01 { get; set; }
        T1 SEALISSUER_02 { get; set; }
        string Sealconditioncoded_03 { get; set; }
    }
    
    public interface I_SEQ<T1>
        where T1 : I_C286
    {
        
        string Statusindicatorcoded_01 { get; set; }
        T1 SEQUENCEINFORMATION_02 { get; set; }
    }
    
    public interface I_SFI<T1, T2>
        where T1 : I_C814
        where T2 : I_C815
    {
        
        string Hierarchicalidnumber_01 { get; set; }
        T1 SAFETYSECTION_02 { get; set; }
        T2 ADDITIONALSAFETYINFORMATION_03 { get; set; }
        string Maintenanceoperationcoded_04 { get; set; }
    }
    
    public interface I_SGP<T1>
        where T1 : I_C237
    {
        
        T1 EQUIPMENTIDENTIFICATION_01 { get; set; }
        string Numberofpackages_02 { get; set; }
    }
    
    public interface I_SGU
    {
        
        string Segmenttag_01 { get; set; }
        string Requirementdesignatorcoded_02 { get; set; }
        string Maximumnumberofoccurrences_03 { get; set; }
        string Levelnumber_04 { get; set; }
        string Sequencenumber_05 { get; set; }
        string Messagesectioncoded_06 { get; set; }
        string Maintenanceoperationcoded_07 { get; set; }
    }
    
    public interface I_SPS<T1, T2, T3, T4, T5, T6>
        where T1 : I_C526
        where T2 : I_C512
        where T3 : I_C512
        where T4 : I_C512
        where T5 : I_C512
        where T6 : I_C512
    {
        
        T1 FREQUENCYDETAILS_01 { get; set; }
        string Confidencelimit_02 { get; set; }
        T2 SIZEDETAILS_03 { get; set; }
        T3 SIZEDETAILS_04 { get; set; }
        T4 SIZEDETAILS_05 { get; set; }
        T5 SIZEDETAILS_06 { get; set; }
        T6 SIZEDETAILS_07 { get; set; }
    }
    
    public interface I_STA<T1>
        where T1 : I_C527
    {
        
        string Statistictypecoded_01 { get; set; }
        T1 STATISTICALDETAILS_02 { get; set; }
    }
    
    public interface I_STC<T1, T2>
        where T1 : I_C785
        where T2 : I_C082
    {
        
        T1 STATISTICALCONCEPTIDENTIFICATION_01 { get; set; }
        T2 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        string Statuscoded_03 { get; set; }
        string Maintenanceoperationcoded_04 { get; set; }
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
    
    public interface I_TEM<T1, T2>
        where T1 : I_C244
        where T2 : I_C515
    {
        
        T1 TESTMETHOD_01 { get; set; }
        string Testrouteofadministeringcoded_02 { get; set; }
        string Testmediacoded_03 { get; set; }
        string Measurementapplicationqualifier_04 { get; set; }
        string Testrevisionnumber_05 { get; set; }
        T2 TESTREASON_06 { get; set; }
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
    
    public interface I_VLI<T1, T2, T3>
        where T1 : I_C780
        where T2 : I_C082
        where T3 : I_C240
    {
        
        T1 VALUELISTIDENTIFICATION_01 { get; set; }
        T2 PARTYIDENTIFICATIONDETAILS_02 { get; set; }
        string Statuscoded_03 { get; set; }
        string Valuelistname_04 { get; set; }
        string Classdesignatorcoded_05 { get; set; }
        string Valuelisttypecoded_06 { get; set; }
        T3 PRODUCTCHARACTERISTIC_07 { get; set; }
        string Maintenanceoperationcoded_08 { get; set; }
    }
}
