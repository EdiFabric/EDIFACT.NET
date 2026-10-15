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
    
    
    public interface I_C002
    {
        
        string Documentnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Documentname_04 { get; set; }
    }
    
    public interface I_C019
    {
        
        string Paymenttermsdescriptionidentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Paymenttermsdescription_04 { get; set; }
    }
    
    public interface I_C040
    {
        
        string Carrieridentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Carriername_04 { get; set; }
    }
    
    public interface I_C056
    {
        
        string Departmentoremployeenamecode_01 { get; set; }
        string Departmentoremployeename_02 { get; set; }
    }
    
    public interface I_C058
    {
        
        string Nameandaddressdescription_01 { get; set; }
        string Nameandaddressdescription_02 { get; set; }
        string Nameandaddressdescription_03 { get; set; }
        string Nameandaddressdescription_04 { get; set; }
        string Nameandaddressdescription_05 { get; set; }
    }
    
    public interface I_C059
    {
        
        string Streetandnumberorpostofficeboxidentifier_01 { get; set; }
        string Streetandnumberorpostofficeboxidentifier_02 { get; set; }
        string Streetandnumberorpostofficeboxidentifier_03 { get; set; }
        string Streetandnumberorpostofficeboxidentifier_04 { get; set; }
    }
    
    public interface I_C076
    {
        
        string Communicationaddressidentifier_01 { get; set; }
        string Communicationaddresscodequalifier_02 { get; set; }
    }
    
    public interface I_C077
    {
        
        string Filename_01 { get; set; }
        string Itemdescription_02 { get; set; }
    }
    
    public interface I_C078
    {
        
        string Accountholderidentifier_01 { get; set; }
        string Accountholdername_02 { get; set; }
        string Accountholdername_03 { get; set; }
        string Currencyidentificationcode_04 { get; set; }
    }
    
    public interface I_C079
    {
        
        string Computerenvironmentnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Computerenvironmentname_04 { get; set; }
        string Versionidentifier_05 { get; set; }
        string Releaseidentifier_06 { get; set; }
        string Objectidentifier_07 { get; set; }
    }
    
    public interface I_C080
    {
        
        string Partyname_01 { get; set; }
        string Partyname_02 { get; set; }
        string Partyname_03 { get; set; }
        string Partyname_04 { get; set; }
        string Partyname_05 { get; set; }
        string Partynameformatcode_06 { get; set; }
    }
    
    public interface I_C082
    {
        
        string Partyidentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface I_C088
    {
        
        string Institutionnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Institutionbranchidentifier_04 { get; set; }
        string Codelistidentificationcode_05 { get; set; }
        string Codelistresponsibleagencycode_06 { get; set; }
        string Institutionname_07 { get; set; }
        string Institutionbranchlocationname_08 { get; set; }
    }
    
    public interface I_C099
    {
        
        string Fileformatname_01 { get; set; }
        string Versionidentifier_02 { get; set; }
        string Dataformatdescriptioncode_03 { get; set; }
        string Dataformatdescription_04 { get; set; }
    }
    
    public interface I_C100
    {
        
        string Deliveryortransporttermsdescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Deliveryortransporttermsdescription_04 { get; set; }
        string Deliveryortransporttermsdescription_05 { get; set; }
    }
    
    public interface I_C106
    {
        
        string Documentidentifier_01 { get; set; }
        string Versionidentifier_02 { get; set; }
        string Revisionidentifier_03 { get; set; }
    }
    
    public interface I_C107
    {
        
        string Freetextvaluecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface I_C108
    {
        
        string Freetextvalue_01 { get; set; }
        string Freetextvalue_02 { get; set; }
        string Freetextvalue_03 { get; set; }
        string Freetextvalue_04 { get; set; }
        string Freetextvalue_05 { get; set; }
    }
    
    public interface I_C110
    {
        
        string Paymenttermsdescriptionidentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Paymenttermsdescription_04 { get; set; }
        string Paymenttermsdescription_05 { get; set; }
    }
    
    public interface I_C112
    {
        
        string Timereferencecode_01 { get; set; }
        string Termstimerelationcode_02 { get; set; }
        string Periodtypecode_03 { get; set; }
        string Periodcountquantity_04 { get; set; }
    }
    
    public interface I_C128
    {
        
        string Ratetypecodequalifier_01 { get; set; }
        string Unitpricebasisrate_02 { get; set; }
        string Unitpricebasisvalue_03 { get; set; }
        string Measurementunitcode_04 { get; set; }
    }
    
    public interface I_C138
    {
        
        string Pricemultiplierrate_01 { get; set; }
        string Pricemultipliertypecodequalifier_02 { get; set; }
    }
    
    public interface I_C174
    {
        
        string Measurementunitcode_01 { get; set; }
        string Measurementvalue_02 { get; set; }
        string Rangeminimumvalue_03 { get; set; }
        string Rangemaximumvalue_04 { get; set; }
        string Significantdigitsquantity_05 { get; set; }
    }
    
    public interface I_C186
    {
        
        string Quantitytypecodequalifier_01 { get; set; }
        string Quantity_02 { get; set; }
        string Measurementunitcode_03 { get; set; }
    }
    
    public interface I_C202
    {
        
        string Packagetypedescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Typeofpackages_04 { get; set; }
    }
    
    public interface I_C205
    {
        
        string Hazardidentificationcode_01 { get; set; }
        string Additionalhazardclassificationidentifier_02 { get; set; }
        string Hazardcodeversionidentifier_03 { get; set; }
    }
    
    public interface I_C206
    {
        
        string Objectidentifier_01 { get; set; }
        string Objectidentificationcodequalifier_02 { get; set; }
        string Statusdescriptioncode_03 { get; set; }
    }
    
    public interface I_C208
    {
        
        string Objectidentifier_01 { get; set; }
        string Objectidentifier_02 { get; set; }
    }
    
    public interface I_C210
    {
        
        string Shippingmarksdescription_01 { get; set; }
        string Shippingmarksdescription_02 { get; set; }
        string Shippingmarksdescription_03 { get; set; }
        string Shippingmarksdescription_04 { get; set; }
        string Shippingmarksdescription_05 { get; set; }
        string Shippingmarksdescription_06 { get; set; }
        string Shippingmarksdescription_07 { get; set; }
        string Shippingmarksdescription_08 { get; set; }
        string Shippingmarksdescription_09 { get; set; }
        string Shippingmarksdescription_10 { get; set; }
    }
    
    public interface I_C211
    {
        
        string Measurementunitcode_01 { get; set; }
        string Lengthdimensionvalue_02 { get; set; }
        string Widthdimensionvalue_03 { get; set; }
        string Heightdimensionvalue_04 { get; set; }
    }
    
    public interface I_C212
    {
        
        string Itemidentifier_01 { get; set; }
        string Itemtypeidentificationcode_02 { get; set; }
        string Codelistidentificationcode_03 { get; set; }
        string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    public interface I_C213
    {
        
        string Packagequantity_01 { get; set; }
        string Packagetypedescriptioncode_02 { get; set; }
        string Codelistidentificationcode_03 { get; set; }
        string Codelistresponsibleagencycode_04 { get; set; }
        string Typeofpackages_05 { get; set; }
        string Packagingrelateddescriptioncode_06 { get; set; }
    }
    
    public interface I_C214
    {
        
        string Specialservicedescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Specialservicedescription_04 { get; set; }
        string Specialservicedescription_05 { get; set; }
    }
    
    public interface I_C215
    {
        
        string Sealingpartynamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Sealingpartyname_04 { get; set; }
    }
    
    public interface I_C218
    {
        
        string Hazardousmaterialcategorynamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Hazardousmaterialcategoryname_04 { get; set; }
    }
    
    public interface I_C220
    {
        
        string Transportmodenamecode_01 { get; set; }
        string Transportmodename_02 { get; set; }
    }
    
    public interface I_C222
    {
        
        string Transportmeansidentificationnameidentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Transportmeansidentificationname_04 { get; set; }
        string Transportmeansnationalitycode_05 { get; set; }
    }
    
    public interface I_C223
    {
        
        string Shipmentflashpointvalue_01 { get; set; }
        string Measurementunitcode_02 { get; set; }
    }
    
    public interface I_C224
    {
        
        string Equipmentsizeandtypedescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Equipmentsizeandtypedescription_04 { get; set; }
    }
    
    public interface I_C228
    {
        
        string Transportmeansdescriptioncode_01 { get; set; }
        string Transportmeansdescription_02 { get; set; }
    }
    
    public interface I_C232
    {
        
        string Governmentagencyidentificationcode_01 { get; set; }
        string Governmentinvolvementcode_02 { get; set; }
        string Governmentactioncode_03 { get; set; }
        string Governmentprocedurecode_04 { get; set; }
    }
    
    public interface I_C233
    {
        
        string Servicerequirementcode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Servicerequirementcode_04 { get; set; }
        string Codelistidentificationcode_05 { get; set; }
        string Codelistresponsibleagencycode_06 { get; set; }
    }
    
    public interface I_C234
    {
        
        string UnitedNationsDangerousGoodsUNDGidentifier_01 { get; set; }
        string Dangerousgoodsflashpointvalue_02 { get; set; }
    }
    
    public interface I_C235
    {
        
        string Orangehazardplacardupperpartidentifier_01 { get; set; }
        string Orangehazardplacardlowerpartidentifier_02 { get; set; }
    }
    
    public interface I_C236
    {
        
        string Dangerousgoodsmarkingidentifier_01 { get; set; }
        string Dangerousgoodsmarkingidentifier_02 { get; set; }
        string Dangerousgoodsmarkingidentifier_03 { get; set; }
    }
    
    public interface I_C237
    {
        
        string Equipmentidentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Countrynamecode_04 { get; set; }
    }
    
    public interface I_C239
    {
        
        string Temperaturevalue_01 { get; set; }
        string Measurementunitcode_02 { get; set; }
    }
    
    public interface I_C240
    {
        
        string Characteristicdescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Characteristicdescription_04 { get; set; }
        string Characteristicdescription_05 { get; set; }
    }
    
    public interface I_C241
    {
        
        string Dutyortaxorfeetypenamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    public interface I_C242
    {
        
        string Processtypedescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Processtypedescription_04 { get; set; }
        string Processtypedescription_05 { get; set; }
    }
    
    public interface I_C243
    {
        
        string Dutyortaxorfeeratecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Dutyortaxorfeerate_04 { get; set; }
        string Dutyortaxorfeeratebasiscode_05 { get; set; }
        string Codelistidentificationcode_06 { get; set; }
        string Codelistresponsibleagencycode_07 { get; set; }
    }
    
    public interface I_C270
    {
        
        string Controltotaltypecodequalifier_01 { get; set; }
        string Controltotalvalue_02 { get; set; }
        string Measurementunitcode_03 { get; set; }
    }
    
    public interface I_C272
    {
        
        string Itemcharacteristiccode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface I_C273
    {
        
        string Itemdescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Itemdescription_04 { get; set; }
        string Itemdescription_05 { get; set; }
        string Languagenamecode_06 { get; set; }
    }
    
    public interface I_C279
    {
        
        string Quantityvariancevalue_01 { get; set; }
        string Quantitytypecodequalifier_02 { get; set; }
    }
    
    public interface I_C280
    {
        
        string Measurementunitcode_01 { get; set; }
        string Rangeminimumvalue_02 { get; set; }
        string Rangemaximumvalue_03 { get; set; }
    }
    
    public interface I_C286
    {
        
        string Sequencepositionidentifier_01 { get; set; }
        string Sequenceidentifiersourcecode_02 { get; set; }
        string Codelistidentificationcode_03 { get; set; }
        string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    public interface I_C288
    {
        
        string Productgroupnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Productgroupname_04 { get; set; }
    }
    
    public interface I_C329
    {
        
        string Frequencycode_01 { get; set; }
        string Despatchpatterncode_02 { get; set; }
        string Despatchpatterntimingcode_03 { get; set; }
    }
    
    public interface I_C333
    {
        
        string Requestedinformationdescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Requestedinformationdescription_04 { get; set; }
    }
    
    public interface I_C401
    {
        
        string Excesstransportationreasoncode_01 { get; set; }
        string Excesstransportationresponsibilitycode_02 { get; set; }
        string Customershipmentauthorisationidentifier_03 { get; set; }
    }
    
    public interface I_C402
    {
        
        string Descriptionformatcode_01 { get; set; }
        string Typeofpackages_02 { get; set; }
        string Itemtypeidentificationcode_03 { get; set; }
        string Typeofpackages_04 { get; set; }
        string Itemtypeidentificationcode_05 { get; set; }
    }
    
    public interface I_C501
    {
        
        string Percentagetypecodequalifier_01 { get; set; }
        string Percentage_02 { get; set; }
        string Percentagebasisidentificationcode_03 { get; set; }
        string Codelistidentificationcode_04 { get; set; }
        string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    public interface I_C502
    {
        
        string Measuredattributecode_01 { get; set; }
        string Measurementsignificancecode_02 { get; set; }
        string Nondiscretemeasurementnamecode_03 { get; set; }
        string Nondiscretemeasurementname_04 { get; set; }
    }
    
    public interface I_C503
    {
        
        string Documentidentifier_01 { get; set; }
        string Documentstatuscode_02 { get; set; }
        string Documentsourcedescription_03 { get; set; }
        string Languagenamecode_04 { get; set; }
        string Versionidentifier_05 { get; set; }
        string Revisionidentifier_06 { get; set; }
    }
    
    public interface I_C504
    {
        
        string Currencyusagecodequalifier_01 { get; set; }
        string Currencyidentificationcode_02 { get; set; }
        string Currencytypecodequalifier_03 { get; set; }
        string Currencyratevalue_04 { get; set; }
    }
    
    public interface I_C506
    {
        
        string Referencecodequalifier_01 { get; set; }
        string Referenceidentifier_02 { get; set; }
        string Documentlineidentifier_03 { get; set; }
        string Referenceversionidentifier_04 { get; set; }
        string Revisionidentifier_05 { get; set; }
    }
    
    public interface I_C507
    {
        
        string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        string Dateortimeorperiodvalue_02 { get; set; }
        string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    public interface I_C509
    {
        
        string Pricecodequalifier_01 { get; set; }
        string Priceamount_02 { get; set; }
        string Pricetypecode_03 { get; set; }
        string Pricespecificationcode_04 { get; set; }
        string Unitpricebasisvalue_05 { get; set; }
        string Measurementunitcode_06 { get; set; }
    }
    
    public interface I_C516
    {
        
        string Monetaryamounttypecodequalifier_01 { get; set; }
        string Monetaryamount_02 { get; set; }
        string Currencyidentificationcode_03 { get; set; }
        string Currencytypecodequalifier_04 { get; set; }
        string Statusdescriptioncode_05 { get; set; }
    }
    
    public interface I_C517
    {
        
        string Locationnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Locationname_04 { get; set; }
    }
    
    public interface I_C519
    {
        
        string Firstrelatedlocationnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Firstrelatedlocationname_04 { get; set; }
    }
    
    public interface I_C521
    {
        
        string Businessfunctiontypecodequalifier_01 { get; set; }
        string Businessfunctioncode_02 { get; set; }
        string Codelistidentificationcode_03 { get; set; }
        string Codelistresponsibleagencycode_04 { get; set; }
        string Businessdescription_05 { get; set; }
    }
    
    public interface I_C522
    {
        
        string Instructiontypecodequalifier_01 { get; set; }
        string Instructiondescriptioncode_02 { get; set; }
        string Codelistidentificationcode_03 { get; set; }
        string Codelistresponsibleagencycode_04 { get; set; }
        string Instructiondescription_05 { get; set; }
    }
    
    public interface I_C523
    {
        
        string Unitsquantity_01 { get; set; }
        string Unittypecodequalifier_02 { get; set; }
    }
    
    public interface I_C524
    {
        
        string Handlinginstructiondescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Handlinginstructiondescription_04 { get; set; }
    }
    
    public interface I_C529
    {
        
        string Processingindicatordescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Processtypedescriptioncode_04 { get; set; }
    }
    
    public interface I_C531
    {
        
        string Packaginglevelcode_01 { get; set; }
        string Packagingrelateddescriptioncode_02 { get; set; }
        string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    public interface I_C532
    {
        
        string Returnablepackagefreightpaymentresponsibilitycode_01 { get; set; }
        string Returnablepackageloadcontentscode_02 { get; set; }
    }
    
    public interface I_C533
    {
        
        string Dutyortaxorfeeaccountcode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface I_C534
    {
        
        string Paymentconditionscode_01 { get; set; }
        string Paymentguaranteemeanscode_02 { get; set; }
        string Paymentmeanscode_03 { get; set; }
        string Codelistidentificationcode_04 { get; set; }
        string Codelistresponsibleagencycode_05 { get; set; }
        string Paymentchannelcode_06 { get; set; }
    }
    
    public interface I_C536
    {
        
        string Contractandcarriageconditioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface I_C537
    {
        
        string Transportserviceprioritycode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface I_C550
    {
        
        string Requirementorconditiondescriptionidentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Requirementorconditiondescription_04 { get; set; }
    }
    
    public interface I_C551
    {
        
        string Bankoperationcode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface I_C552
    {
        
        string Allowanceorchargeidentifier_01 { get; set; }
        string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    public interface I_C553
    {
        
        string Secondrelatedlocationnamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Secondrelatedlocationname_04 { get; set; }
    }
    
    public interface I_C555
    {
        
        string Statusdescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Statusdescription_04 { get; set; }
    }
    
    public interface I_C556
    {
        
        string Statusreasondescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Statusreasondescription_04 { get; set; }
    }
    
    public interface I_C564
    {
        
        string Physicalorlogicalstatedescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Physicalorlogicalstatedescription_04 { get; set; }
    }
    
    public interface I_C601
    {
        
        string Statuscategorycode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface I_C703
    {
        
        string Cargotypeclassificationcode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface I_C778
    {
        
        string Hierarchicalstructurelevelidentifier_01 { get; set; }
        string Sequencepositionidentifier_02 { get; set; }
    }
    
    public interface I_C819
    {
        
        string Countrysubentitynamecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Countrysubentityname_04 { get; set; }
    }
    
    public interface I_C827
    {
        
        string Markingtypecode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface I_C829
    {
        
        string Sublineindicatorcode_01 { get; set; }
        string Lineitemidentifier_02 { get; set; }
    }
    
    public interface I_C830
    {
        
        string Processdescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Processdescription_04 { get; set; }
    }
    
    public interface I_C849
    {
        
        string Enactingpartyidentifier_01 { get; set; }
        string Instructionreceivingpartyidentifier_02 { get; set; }
    }
    
    public interface I_C850
    {
        
        string Statusdescriptioncode_01 { get; set; }
        string Partyname_02 { get; set; }
    }
    
    public interface I_C878
    {
        
        string Institutionbranchidentifier_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Accountholderidentifier_04 { get; set; }
        string Currencyidentificationcode_05 { get; set; }
    }
    
    public interface I_C889
    {
        
        string Characteristicvaluedescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Characteristicvaluedescription_04 { get; set; }
        string Characteristicvaluedescription_05 { get; set; }
    }
    
    public interface I_C901
    {
        
        string Applicationerrorcode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public interface I_C960
    {
        
        string Changereasondescriptioncode_01 { get; set; }
        string Codelistidentificationcode_02 { get; set; }
        string Codelistresponsibleagencycode_03 { get; set; }
        string Changereasondescription_04 { get; set; }
    }
}
