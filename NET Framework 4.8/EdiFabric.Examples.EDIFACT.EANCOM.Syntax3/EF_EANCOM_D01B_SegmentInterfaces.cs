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
    
    
    public interface I_AJT
    {
        
        string Adjustmentreasondescriptioncode_01 { get; set; }
        string Lineitemidentifier_02 { get; set; }
    }
    
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
    
    public interface I_AUT
    {
        
        string Validationresultvalue_01 { get; set; }
        string Validationkeyidentifier_02 { get; set; }
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
    
    public interface I_BUS<T1, T2>
        where T1 : I_C521
        where T2 : I_C551
    {
        
        T1 BUSINESSFUNCTION_01 { get; set; }
        string Geographicareacode_02 { get; set; }
        string Financialtransactiontypecode_03 { get; set; }
        T2 BANKOPERATION_04 { get; set; }
        string Intracompanypaymentindicatorcode_05 { get; set; }
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
        
        string Classtypecode_01 { get; set; }
        T1 MEASUREMENTDETAILS_02 { get; set; }
        T2 PRODUCTCHARACTERISTIC_03 { get; set; }
        string Characteristicrelevancecode_04 { get; set; }
    }
    
    public interface I_CDI<T1>
        where T1 : I_C564
    {
        
        string Physicalorlogicalstatetypecodequalifier_01 { get; set; }
        T1 PHYSICALORLOGICALSTATEINFORMATION_02 { get; set; }
    }
    
    public interface I_CED<T1>
        where T1 : I_C079
    {
        
        string Computerenvironmentdetailscodequalifier_01 { get; set; }
        T1 COMPUTERENVIRONMENTIDENTIFICATION_02 { get; set; }
        string Filegenerationcommandname_03 { get; set; }
    }
    
    public interface I_CNI<T1>
        where T1 : I_C503
    {
        
        string Consolidationitemnumber_01 { get; set; }
        T1 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        string Consignmentloadsequenceidentifier_03 { get; set; }
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
    
    public interface I_CPS
    {
        
        string Hierarchicalstructurelevelidentifier_01 { get; set; }
        string Hierarchicalstructureparentidentifier_02 { get; set; }
        string Packaginglevelcode_03 { get; set; }
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
    
    public interface I_DGS<T1, T2, T3, T4, T5>
        where T1 : I_C205
        where T2 : I_C234
        where T3 : I_C223
        where T4 : I_C235
        where T5 : I_C236
    {
        
        string Dangerousgoodsregulationscode_01 { get; set; }
        T1 HAZARDCODE_02 { get; set; }
        T2 UNDGINFORMATION_03 { get; set; }
        T3 DANGEROUSGOODSSHIPMENTFLASHPOINT_04 { get; set; }
        string Packagingdangerlevelcode_05 { get; set; }
        string Emergencyprocedureforshipsidentifier_06 { get; set; }
        string Hazardmedicalfirstaidguideidentifier_07 { get; set; }
        string Transportemergencycardidentifier_08 { get; set; }
        T4 HAZARDIDENTIFICATIONPLACARDDETAILS_09 { get; set; }
        T5 DANGEROUSGOODSLABEL_10 { get; set; }
        string Packinginstructiontypecode_11 { get; set; }
        string Hazardousmeansoftransportcategorycode_12 { get; set; }
        string Hazardouscargotransportauthorisationcode_13 { get; set; }
    }
    
    public interface I_DIM<T1>
        where T1 : I_C211
    {
        
        string Dimensiontypecodequalifier_01 { get; set; }
        T1 DIMENSIONS_02 { get; set; }
    }
    
    public interface I_DLI
    {
        
        string Documentlineactioncode_01 { get; set; }
        string Lineitemidentifier_02 { get; set; }
    }
    
    public interface I_DLM<T1, T2>
        where T1 : I_C522
        where T2 : I_C214
    {
        
        string Backorderarrangementtypecode_01 { get; set; }
        T1 INSTRUCTION_02 { get; set; }
        T2 SPECIALSERVICESIDENTIFICATION_03 { get; set; }
        string Substitutionconditioncode_04 { get; set; }
    }
    
    public interface I_DOC<T1, T2>
        where T1 : I_C002
        where T2 : I_C503
    {
        
        T1 DOCUMENTMESSAGENAME_01 { get; set; }
        T2 DOCUMENTMESSAGEDETAILS_02 { get; set; }
        string Communicationmediumtypecode_03 { get; set; }
        string Documentcopiesrequiredquantity_04 { get; set; }
        string Documentoriginalsrequiredquantity_05 { get; set; }
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
        string Sequencepositionidentifier_03 { get; set; }
        string Filecompressiontechniquename_04 { get; set; }
    }
    
    public interface I_EQD<T1, T2>
        where T1 : I_C237
        where T2 : I_C224
    {
        
        string Equipmenttypecodequalifier_01 { get; set; }
        T1 EQUIPMENTIDENTIFICATION_02 { get; set; }
        T2 EQUIPMENTSIZEANDTYPE_03 { get; set; }
        string Equipmentsuppliercode_04 { get; set; }
        string Equipmentstatuscode_05 { get; set; }
        string Fulloremptyindicatorcode_06 { get; set; }
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
    
    public interface I_FCA<T1>
        where T1 : I_C878
    {
        
        string Settlementmeanscode_01 { get; set; }
        T1 CHARGEALLOWANCEACCOUNT_02 { get; set; }
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
    
    public interface I_GDS<T1>
        where T1 : I_C703
    {
        
        T1 NATUREOFCARGO_01 { get; set; }
    }
    
    public interface I_GID<T1, T2, T3, T4, T5>
        where T1 : I_C213
        where T2 : I_C213
        where T3 : I_C213
        where T4 : I_C213
        where T5 : I_C213
    {
        
        string Goodsitemnumber_01 { get; set; }
        T1 NUMBERANDTYPEOFPACKAGES_02 { get; set; }
        T2 NUMBERANDTYPEOFPACKAGES_03 { get; set; }
        T3 NUMBERANDTYPEOFPACKAGES_04 { get; set; }
        T4 NUMBERANDTYPEOFPACKAGES_05 { get; set; }
        T5 NUMBERANDTYPEOFPACKAGES_06 { get; set; }
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
        
        string Transportmovementcode_01 { get; set; }
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
    
    public interface I_HYN<T1>
        where T1 : I_C212
    {
        
        string Hierarchyobjectcodequalifier_01 { get; set; }
        string Hierarchicalstructurerelationshipcode_02 { get; set; }
        string Actionrequestnotificationdescriptioncode_03 { get; set; }
        T1 ITEMNUMBERIDENTIFICATION_04 { get; set; }
        string Hierarchicalstructureparentidentifier_05 { get; set; }
    }
    
    public interface I_IDE<T1, T2, T3, T4>
        where T1 : I_C206
        where T2 : I_C082
        where T3 : I_C778
        where T4 : I_C240
    {
        
        string Objecttypecodequalifier_01 { get; set; }
        T1 IDENTIFICATIONNUMBER_02 { get; set; }
        T2 PARTYIDENTIFICATIONDETAILS_03 { get; set; }
        string Statusdescriptioncode_04 { get; set; }
        string Configurationlevelnumber_05 { get; set; }
        T3 POSITIONIDENTIFICATION_06 { get; set; }
        T4 PRODUCTCHARACTERISTIC_07 { get; set; }
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
    
    public interface I_INP<T1, T2, T3>
        where T1 : I_C849
        where T2 : I_C522
        where T3 : I_C850
    {
        
        T1 PARTIESTOINSTRUCTION_01 { get; set; }
        T2 INSTRUCTION_02 { get; set; }
        T3 STATUSOFINSTRUCTION_03 { get; set; }
        string Actionrequestnotificationdescriptioncode_04 { get; set; }
    }
    
    public interface I_INV<T1>
        where T1 : I_C522
    {
        
        string Inventorymovementdirectioncode_01 { get; set; }
        string Inventorytypecode_02 { get; set; }
        string Inventorymovementreasoncode_03 { get; set; }
        string Inventorybalancemethodcode_04 { get; set; }
        T1 INSTRUCTION_05 { get; set; }
    }
    
    public interface I_IRQ<T1>
        where T1 : I_C333
    {
        
        T1 INFORMATIONREQUEST_01 { get; set; }
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
    
    public interface I_PGI<T1>
        where T1 : I_C288
    {
        
        string Productgrouptypecode_01 { get; set; }
        T1 PRODUCTGROUP_02 { get; set; }
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
    
    public interface I_PRC<T1, T2>
        where T1 : I_C242
        where T2 : I_C830
    {
        
        T1 PROCESSTYPEANDDESCRIPTION_01 { get; set; }
        T2 PROCESSIDENTIFICATIONDETAILS_02 { get; set; }
    }
    
    public interface I_PRI<T1>
        where T1 : I_C509
    {
        
        T1 PRICEINFORMATION_01 { get; set; }
        string Sublineitempricechangeoperationcode_02 { get; set; }
    }
    
    public interface I_PYT<T1>
        where T1 : I_C019
    {
        
        string Paymenttermstypecodequalifier_01 { get; set; }
        T1 PAYMENTTERMS_02 { get; set; }
        string Timereferencecode_03 { get; set; }
        string Termstimerelationcode_04 { get; set; }
        string Periodtypecode_05 { get; set; }
        string Periodcountquantity_06 { get; set; }
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
    
    public interface I_RCS<T1>
        where T1 : I_C550
    {
        
        string Sectorareaidentificationcodequalifier_01 { get; set; }
        T1 REQUIREMENTCONDITIONIDENTIFICATION_02 { get; set; }
        string Actionrequestnotificationdescriptioncode_03 { get; set; }
        string Countrynamecode_04 { get; set; }
    }
    
    public interface I_RFF<T1>
        where T1 : I_C506
    {
        
        T1 REFERENCE_01 { get; set; }
    }
    
    public interface I_RNG<T1>
        where T1 : I_C280
    {
        
        string Rangetypecodequalifier_01 { get; set; }
        T1 RANGE_02 { get; set; }
    }
    
    public interface I_RTE<T1>
        where T1 : I_C128
    {
        
        T1 RATEDETAILS_01 { get; set; }
        string Statusdescriptioncode_02 { get; set; }
    }
    
    public interface I_SCC<T1>
        where T1 : I_C329
    {
        
        string Deliveryplancommitmentlevelcode_01 { get; set; }
        string Deliveryinstructioncode_02 { get; set; }
        T1 PATTERNDESCRIPTION_03 { get; set; }
    }
    
    public interface I_SEL<T1, T2>
        where T1 : I_C215
        where T2 : I_C208
    {
        
        string Sealidentifier_01 { get; set; }
        T1 SEALISSUER_02 { get; set; }
        string Sealconditioncode_03 { get; set; }
        T2 IDENTITYNUMBERRANGE_04 { get; set; }
    }
    
    public interface I_SEQ<T1>
        where T1 : I_C286
    {
        
        string Actionrequestnotificationdescriptioncode_01 { get; set; }
        T1 SEQUENCEINFORMATION_02 { get; set; }
    }
    
    public interface I_SGP<T1>
        where T1 : I_C237
    {
        
        T1 EQUIPMENTIDENTIFICATION_01 { get; set; }
        string Packagequantity_02 { get; set; }
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
        
        T1 STATUSCATEGORY_01 { get; set; }
        T2 STATUS_02 { get; set; }
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
    
    public interface I_TMP<T1>
        where T1 : I_C239
    {
        
        string Temperaturetypecodequalifier_01 { get; set; }
        T1 TEMPERATURESETTING_02 { get; set; }
    }
    
    public interface I_TOD<T1>
        where T1 : I_C100
    {
        
        string Deliveryortransporttermsfunctioncode_01 { get; set; }
        string Transportchargespaymentmethodcode_02 { get; set; }
        T1 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    public interface I_TRU
    {
        
        string Objectidentifier_01 { get; set; }
        string Versionidentifier_02 { get; set; }
        string Releaseidentifier_03 { get; set; }
        string Rulepartidentifier_04 { get; set; }
        string Codelistresponsibleagencycode_05 { get; set; }
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
    
    public interface I_UGH
    {
        
        string Anticollisionsegmentgroupidentification_01 { get; set; }
    }
    
    public interface I_UGT
    {
        
        string Anticollisionsegmentgroupidentification_01 { get; set; }
    }
    
    public interface I_UNS
    {
        
        string Sectionidentification_01 { get; set; }
    }
}
