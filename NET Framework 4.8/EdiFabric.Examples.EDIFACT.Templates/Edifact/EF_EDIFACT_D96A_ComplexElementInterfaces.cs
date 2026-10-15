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
    
    
    public interface I_C002
    {
        
        string Documentmessagenamecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Documentmessagename_04 { get; set; }
    }
    
    public interface I_C040
    {
        
        string Carrieridentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Carriername_04 { get; set; }
    }
    
    public interface I_C042
    {
        
        string Nationalitycoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Nationality_04 { get; set; }
    }
    
    public interface I_C045
    {
        
        string Leveloneid_01 { get; set; }
        string Leveltwoid_02 { get; set; }
        string Levelthreeid_03 { get; set; }
        string Levelfourid_04 { get; set; }
        string Levelfiveid_05 { get; set; }
        string Levelsixid_06 { get; set; }
    }
    
    public interface I_C049
    {
        
        string Remunerationtypecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Remunerationtype_04 { get; set; }
        string Remunerationtype_05 { get; set; }
    }
    
    public interface I_C056
    {
        
        string Departmentoremployeeidentification_01 { get; set; }
        string Departmentoremployee_02 { get; set; }
    }
    
    public interface I_C058
    {
        
        string Nameandaddressline_01 { get; set; }
        string Nameandaddressline_02 { get; set; }
        string Nameandaddressline_03 { get; set; }
        string Nameandaddressline_04 { get; set; }
        string Nameandaddressline_05 { get; set; }
    }
    
    public interface I_C059
    {
        
        string Streetandnumberpobox_01 { get; set; }
        string Streetandnumberpobox_02 { get; set; }
        string Streetandnumberpobox_03 { get; set; }
        string Streetandnumberpobox_04 { get; set; }
    }
    
    public interface I_C076
    {
        
        string Communicationnumber_01 { get; set; }
        string Communicationchannelqualifier_02 { get; set; }
    }
    
    public interface I_C077
    {
        
        string Filename_01 { get; set; }
        string Itemdescription_02 { get; set; }
    }
    
    public interface I_C078
    {
        
        string Accountholdernumber_01 { get; set; }
        string Accountholdername_02 { get; set; }
        string Accountholdername_03 { get; set; }
        string Currencycoded_04 { get; set; }
    }
    
    public interface I_C079
    {
        
        string Computerenvironmentcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Computerenvironment_04 { get; set; }
        string Version_05 { get; set; }
        string Release_06 { get; set; }
        string Identitynumber_07 { get; set; }
    }
    
    public interface I_C080
    {
        
        string Partyname_01 { get; set; }
        string Partyname_02 { get; set; }
        string Partyname_03 { get; set; }
        string Partyname_04 { get; set; }
        string Partyname_05 { get; set; }
        string Partynameformatcoded_06 { get; set; }
    }
    
    public interface I_C082
    {
        
        string Partyididentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C085
    {
        
        string Maritalstatuscoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Maritalstatus_04 { get; set; }
    }
    
    public interface I_C088
    {
        
        string Institutionnameidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Institutionbranchnumber_04 { get; set; }
        string Codelistqualifier_05 { get; set; }
        string Codelistresponsibleagencycoded_06 { get; set; }
        string Institutionname_07 { get; set; }
        string Institutionbranchplace_08 { get; set; }
    }
    
    public interface I_C090
    {
        
        string Addressformatcoded_01 { get; set; }
        string Addresscomponent_02 { get; set; }
        string Addresscomponent_03 { get; set; }
        string Addresscomponent_04 { get; set; }
        string Addresscomponent_05 { get; set; }
        string Addresscomponent_06 { get; set; }
    }
    
    public interface I_C099
    {
        
        string Fileformat_01 { get; set; }
        string Version_02 { get; set; }
        string Dataformatcoded_03 { get; set; }
        string Dataformat_04 { get; set; }
    }
    
    public interface I_C100
    {
        
        string Termsofdeliveryortransportcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Termsofdeliveryortransport_04 { get; set; }
        string Termsofdeliveryortransport_05 { get; set; }
    }
    
    public interface I_C101
    {
        
        string Religioncoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Religion_04 { get; set; }
    }
    
    public interface I_C107
    {
        
        string Freetextcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C108
    {
        
        string Freetext_01 { get; set; }
        string Freetext_02 { get; set; }
        string Freetext_03 { get; set; }
        string Freetext_04 { get; set; }
        string Freetext_05 { get; set; }
    }
    
    public interface I_C110
    {
        
        string Termsofpaymentidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Termsofpayment_04 { get; set; }
        string Termsofpayment_05 { get; set; }
    }
    
    public interface I_C112
    {
        
        string Paymenttimereferencecoded_01 { get; set; }
        string Timerelationcoded_02 { get; set; }
        string Typeofperiodcoded_03 { get; set; }
        string Numberofperiods_04 { get; set; }
    }
    
    public interface I_C128
    {
        
        string Ratetypequalifier_01 { get; set; }
        string Rateperunit_02 { get; set; }
        string Unitpricebasis_03 { get; set; }
        string Measureunitqualifier_04 { get; set; }
    }
    
    public interface I_C138
    {
        
        string Pricemultiplier_01 { get; set; }
        string Pricemultiplierqualifier_02 { get; set; }
    }
    
    public interface I_C174
    {
        
        string Measureunitqualifier_01 { get; set; }
        string Measurementvalue_02 { get; set; }
        string Rangeminimum_03 { get; set; }
        string Rangemaximum_04 { get; set; }
        string Significantdigits_05 { get; set; }
    }
    
    public interface I_C186
    {
        
        string Quantityqualifier_01 { get; set; }
        string Quantity_02 { get; set; }
        string Measureunitqualifier_03 { get; set; }
    }
    
    public interface I_C200
    {
        
        string Freightandchargesidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Freightandcharges_04 { get; set; }
        string Prepaidcollectindicatorcoded_05 { get; set; }
        string Itemnumber_06 { get; set; }
    }
    
    public interface I_C202
    {
        
        string Typeofpackagesidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Typeofpackages_04 { get; set; }
    }
    
    public interface I_C203
    {
        
        string Ratetariffclassidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Ratetariffclass_04 { get; set; }
        string Supplementaryratetariffbasisidentification_05 { get; set; }
        string Codelistqualifier_06 { get; set; }
        string Codelistresponsibleagencycoded_07 { get; set; }
        string Supplementaryratetariffbasisidentification_08 { get; set; }
        string Codelistqualifier_09 { get; set; }
        string Codelistresponsibleagencycoded_10 { get; set; }
    }
    
    public interface I_C205
    {
        
        string Hazardcodeidentification_01 { get; set; }
        string Hazardsubstanceitempagenumber_02 { get; set; }
        string Hazardcodeversionnumber_03 { get; set; }
    }
    
    public interface I_C206
    {
        
        string Identitynumber_01 { get; set; }
        string Identitynumberqualifier_02 { get; set; }
        string Statuscoded_03 { get; set; }
    }
    
    public interface I_C208
    {
        
        string Identitynumber_01 { get; set; }
        string Identitynumber_02 { get; set; }
    }
    
    public interface I_C210
    {
        
        string Shippingmarks_01 { get; set; }
        string Shippingmarks_02 { get; set; }
        string Shippingmarks_03 { get; set; }
        string Shippingmarks_04 { get; set; }
        string Shippingmarks_05 { get; set; }
        string Shippingmarks_06 { get; set; }
        string Shippingmarks_07 { get; set; }
        string Shippingmarks_08 { get; set; }
        string Shippingmarks_09 { get; set; }
        string Shippingmarks_10 { get; set; }
    }
    
    public interface I_C211
    {
        
        string Measureunitqualifier_01 { get; set; }
        string Lengthdimension_02 { get; set; }
        string Widthdimension_03 { get; set; }
        string Heightdimension_04 { get; set; }
    }
    
    public interface I_C212
    {
        
        string Itemnumber_01 { get; set; }
        string Itemnumbertypecoded_02 { get; set; }
        string Codelistqualifier_03 { get; set; }
        string Codelistresponsibleagencycoded_04 { get; set; }
    }
    
    public interface I_C213
    {
        
        string Numberofpackages_01 { get; set; }
        string Typeofpackagesidentification_02 { get; set; }
        string Codelistqualifier_03 { get; set; }
        string Codelistresponsibleagencycoded_04 { get; set; }
        string Typeofpackages_05 { get; set; }
    }
    
    public interface I_C214
    {
        
        string Specialservicescoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Specialservice_04 { get; set; }
        string Specialservice_05 { get; set; }
    }
    
    public interface I_C215
    {
        
        string Sealingpartycoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Sealingparty_04 { get; set; }
    }
    
    public interface I_C218
    {
        
        string Hazardousmaterialclasscodeidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C219
    {
        
        string Movementtypecoded_01 { get; set; }
        string Movementtype_02 { get; set; }
    }
    
    public interface I_C220
    {
        
        string Modeoftransportcoded_01 { get; set; }
        string Modeoftransport_02 { get; set; }
    }
    
    public interface I_C222
    {
        
        string Idofmeansoftransportidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Idofthemeansoftransport_04 { get; set; }
        string Nationalityofmeansoftransportcoded_05 { get; set; }
    }
    
    public interface I_C223
    {
        
        string Shipmentflashpoint_01 { get; set; }
        string Measureunitqualifier_02 { get; set; }
    }
    
    public interface I_C224
    {
        
        string Equipmentsizeandtypeidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Equipmentsizeandtype_04 { get; set; }
    }
    
    public interface I_C228
    {
        
        string Typeofmeansoftransportidentification_01 { get; set; }
        string Typeofmeansoftransport_02 { get; set; }
    }
    
    public interface I_C229
    {
        
        string Chargecategorycoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C231
    {
        
        string Transportchargesmethodofpaymentcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C232
    {
        
        string Governmentagencycoded_01 { get; set; }
        string Governmentinvolvementcoded_02 { get; set; }
        string Governmentactioncoded_03 { get; set; }
        string Governmentprocedurecoded_04 { get; set; }
    }
    
    public interface I_C233
    {
        
        string Servicerequirementcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Servicerequirementcoded_04 { get; set; }
        string Codelistqualifier_05 { get; set; }
        string Codelistresponsibleagencycoded_06 { get; set; }
    }
    
    public interface I_C234
    {
        
        string UNDGnumber_01 { get; set; }
        string Dangerousgoodsflashpoint_02 { get; set; }
    }
    
    public interface I_C235
    {
        
        string Hazardidentificationnumberupperpart_01 { get; set; }
        string Substanceidentificationnumberlowerpart_02 { get; set; }
    }
    
    public interface I_C236
    {
        
        string Dangerousgoodslabelmarking_01 { get; set; }
        string Dangerousgoodslabelmarking_02 { get; set; }
        string Dangerousgoodslabelmarking_03 { get; set; }
    }
    
    public interface I_C237
    {
        
        string Equipmentidentificationnumber_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Countrycoded_04 { get; set; }
    }
    
    public interface I_C239
    {
        
        string Temperaturesetting_01 { get; set; }
        string Measureunitqualifier_02 { get; set; }
    }
    
    public interface I_C240
    {
        
        string Characteristicidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Characteristic_04 { get; set; }
        string Characteristic_05 { get; set; }
    }
    
    public interface I_C241
    {
        
        string Dutytaxfeetypecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Dutytaxfeetype_04 { get; set; }
    }
    
    public interface I_C242
    {
        
        string Processtypeidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Processtype_04 { get; set; }
        string Processtype_05 { get; set; }
    }
    
    public interface I_C243
    {
        
        string Dutytaxfeerateidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Dutytaxfeerate_04 { get; set; }
        string Dutytaxfeeratebasisidentification_05 { get; set; }
        string Codelistqualifier_06 { get; set; }
        string Codelistresponsibleagencycoded_07 { get; set; }
    }
    
    public interface I_C244
    {
        
        string Testmethodidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Testdescription_04 { get; set; }
    }
    
    public interface I_C246
    {
        
        string Customscodeidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C270
    {
        
        string Controlqualifier_01 { get; set; }
        string Controlvalue_02 { get; set; }
        string Measureunitqualifier_03 { get; set; }
    }
    
    public interface I_C273
    {
        
        string Itemdescriptionidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Itemdescription_04 { get; set; }
        string Itemdescription_05 { get; set; }
        string Languagecoded_06 { get; set; }
    }
    
    public interface I_C279
    {
        
        string Quantitydifference_01 { get; set; }
        string Quantityqualifier_02 { get; set; }
    }
    
    public interface I_C280
    {
        
        string Measureunitqualifier_01 { get; set; }
        string Rangeminimum_02 { get; set; }
        string Rangemaximum_03 { get; set; }
    }
    
    public interface I_C286
    {
        
        string Sequencenumber_01 { get; set; }
        string Sequencenumbersourcecoded_02 { get; set; }
        string Codelistqualifier_03 { get; set; }
        string Codelistresponsibleagencycoded_04 { get; set; }
    }
    
    public interface I_C288
    {
        
        string Productgroupcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Productgroup_04 { get; set; }
    }
    
    public interface I_C329
    {
        
        string Frequencycoded_01 { get; set; }
        string Despatchpatterncoded_02 { get; set; }
        string Despatchpatterntimingcoded_03 { get; set; }
    }
    
    public interface I_C330
    {
        
        string Insurancecovertypecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C331
    {
        
        string Insurancecoveridentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Insurancecover_04 { get; set; }
        string Insurancecover_05 { get; set; }
    }
    
    public interface I_C332
    {
        
        string Saleschannelidentifier_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C333
    {
        
        string Requestedinformationcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Requestedinformation_04 { get; set; }
    }
    
    public interface I_C401
    {
        
        string Excesstransportationreasoncoded_01 { get; set; }
        string Excesstransportationresponsibilitycoded_02 { get; set; }
        string Customerauthorizationnumber_03 { get; set; }
    }
    
    public interface I_C402
    {
        
        string Itemdescriptiontypecoded_01 { get; set; }
        string Typeofpackages_02 { get; set; }
        string Itemnumbertypecoded_03 { get; set; }
        string Typeofpackages_04 { get; set; }
        string Itemnumbertypecoded_05 { get; set; }
    }
    
    public interface I_C501
    {
        
        string Percentagequalifier_01 { get; set; }
        string Percentage_02 { get; set; }
        string Percentagebasiscoded_03 { get; set; }
        string Codelistqualifier_04 { get; set; }
        string Codelistresponsibleagencycoded_05 { get; set; }
    }
    
    public interface I_C502
    {
        
        string Measurementdimensioncoded_01 { get; set; }
        string Measurementsignificancecoded_02 { get; set; }
        string Measurementattributecoded_03 { get; set; }
        string Measurementattribute_04 { get; set; }
    }
    
    public interface I_C503
    {
        
        string Documentmessagenumber_01 { get; set; }
        string Documentmessagestatuscoded_02 { get; set; }
        string Documentmessagesource_03 { get; set; }
        string Languagecoded_04 { get; set; }
    }
    
    public interface I_C504
    {
        
        string Currencydetailsqualifier_01 { get; set; }
        string Currencycoded_02 { get; set; }
        string Currencyqualifier_03 { get; set; }
        string Currencyratebase_04 { get; set; }
    }
    
    public interface I_C506
    {
        
        string Referencequalifier_01 { get; set; }
        string Referencenumber_02 { get; set; }
        string Linenumber_03 { get; set; }
        string Referenceversionnumber_04 { get; set; }
    }
    
    public interface I_C507
    {
        
        string Datetimeperiodqualifier_01 { get; set; }
        string Datetimeperiod_02 { get; set; }
        string Datetimeperiodformatqualifier_03 { get; set; }
    }
    
    public interface I_C508
    {
        
        string Languagecoded_01 { get; set; }
        string Language_02 { get; set; }
    }
    
    public interface I_C509
    {
        
        string Pricequalifier_01 { get; set; }
        string Price_02 { get; set; }
        string Pricetypecoded_03 { get; set; }
        string Pricetypequalifier_04 { get; set; }
        string Unitpricebasis_05 { get; set; }
        string Measureunitqualifier_06 { get; set; }
    }
    
    public interface I_C512
    {
        
        string Sizequalifier_01 { get; set; }
        string Size_02 { get; set; }
    }
    
    public interface I_C514
    {
        
        string Samplelocationcoded_01 { get; set; }
        string Samplelocation_02 { get; set; }
    }
    
    public interface I_C515
    {
        
        string Testreasonidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Testreason_04 { get; set; }
    }
    
    public interface I_C516
    {
        
        string Monetaryamounttypequalifier_01 { get; set; }
        string Monetaryamount_02 { get; set; }
        string Currencycoded_03 { get; set; }
        string Currencyqualifier_04 { get; set; }
        string Statuscoded_05 { get; set; }
    }
    
    public interface I_C517
    {
        
        string Placelocationidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Placelocation_04 { get; set; }
    }
    
    public interface I_C519
    {
        
        string Relatedplacelocationoneidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Relatedplacelocationone_04 { get; set; }
    }
    
    public interface I_C521
    {
        
        string Businessfunctionqualifier_01 { get; set; }
        string Businessfunctioncoded_02 { get; set; }
        string Codelistqualifier_03 { get; set; }
        string Codelistresponsibleagencycoded_04 { get; set; }
        string Businessdescription_05 { get; set; }
    }
    
    public interface I_C522
    {
        
        string Instructionqualifier_01 { get; set; }
        string Instructioncoded_02 { get; set; }
        string Codelistqualifier_03 { get; set; }
        string Codelistresponsibleagencycoded_04 { get; set; }
        string Instruction_05 { get; set; }
    }
    
    public interface I_C523
    {
        
        string Numberofunits_01 { get; set; }
        string Numberofunitsqualifier_02 { get; set; }
    }
    
    public interface I_C524
    {
        
        string Handlinginstructionscoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Handlinginstructions_04 { get; set; }
    }
    
    public interface I_C526
    {
        
        string Frequencyqualifier_01 { get; set; }
        string Frequencyvalue_02 { get; set; }
        string Measureunitqualifier_03 { get; set; }
    }
    
    public interface I_C527
    {
        
        string Measurementvalue_01 { get; set; }
        string Measureunitqualifier_02 { get; set; }
        string Measurementdimensioncoded_03 { get; set; }
        string Measurementsignificancecoded_04 { get; set; }
    }
    
    public interface I_C528
    {
        
        string Commodityrateidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C529
    {
        
        string Processingindicatorcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Processtypeidentification_04 { get; set; }
    }
    
    public interface I_C531
    {
        
        string Packaginglevelcoded_01 { get; set; }
        string Packagingrelatedinformationcoded_02 { get; set; }
        string Packagingtermsandconditionscoded_03 { get; set; }
    }
    
    public interface I_C532
    {
        
        string Returnablepackagefreightpaymentresponsibilitycoded_01 { get; set; }
        string Returnablepackageloadcontentscoded_02 { get; set; }
    }
    
    public interface I_C533
    {
        
        string Dutytaxfeeaccountidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C534
    {
        
        string Paymentconditionscoded_01 { get; set; }
        string Paymentguaranteecoded_02 { get; set; }
        string Paymentmeanscoded_03 { get; set; }
        string Codelistqualifier_04 { get; set; }
        string Codelistresponsibleagencycoded_05 { get; set; }
        string Paymentchannelcoded_06 { get; set; }
    }
    
    public interface I_C536
    {
        
        string Contractandcarriageconditioncoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C537
    {
        
        string Transportprioritycoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C543
    {
        
        string Agreementtypequalifier_01 { get; set; }
        string Agreementtypecoded_02 { get; set; }
        string Codelistqualifier_03 { get; set; }
        string Codelistresponsibleagencycoded_04 { get; set; }
        string Agreementtypedescription_05 { get; set; }
    }
    
    public interface I_C545
    {
        
        string Indexqualifier_01 { get; set; }
        string Indextypecoded_02 { get; set; }
        string Codelistqualifier_03 { get; set; }
        string Codelistresponsibleagencycoded_04 { get; set; }
    }
    
    public interface I_C546
    {
        
        string Indexvalue_01 { get; set; }
        string Indexvaluerepresentationcoded_02 { get; set; }
    }
    
    public interface I_C549
    {
        
        string Monetaryfunctioncoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C550
    {
        
        string Requirementconditionidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Requirementorcondition_04 { get; set; }
    }
    
    public interface I_C551
    {
        
        string Bankoperationcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C552
    {
        
        string Allowanceorchargenumber_01 { get; set; }
        string Chargeallowancedescriptioncoded_02 { get; set; }
    }
    
    public interface I_C553
    {
        
        string Relatedplacelocationtwoidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Relatedplacelocationtwo_04 { get; set; }
    }
    
    public interface I_C554
    {
        
        string Ratetariffclassidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C555
    {
        
        string Statuseventcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Statusevent_04 { get; set; }
    }
    
    public interface I_C556
    {
        
        string Statusreasoncoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Statusreason_04 { get; set; }
    }
    
    public interface I_C564
    {
        
        string Physicalorlogicalstatecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Physicalorlogicalstatedescription_04 { get; set; }
    }
    
    public interface I_C585
    {
        
        string Prioritycoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Priority_04 { get; set; }
    }
    
    public interface I_C601
    {
        
        string Statustypecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C701
    {
        
        string Messagesectioncoded_01 { get; set; }
        string Messageitemnumber_02 { get; set; }
        string Messagesubitemnumber_03 { get; set; }
    }
    
    public interface I_C702
    {
        
        string Simpledataelementtag_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C703
    {
        
        string Natureofcargocoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C709
    {
        
        string Messagetypeidentifier_01 { get; set; }
        string Version_02 { get; set; }
        string Release_03 { get; set; }
        string Controlagency_04 { get; set; }
        string Associationassignedidentification_05 { get; set; }
        string Revisionnumber_06 { get; set; }
    }
    
    public interface I_C770
    {
        
        string Arraycellinformation_01 { get; set; }
    }
    
    public interface I_C778
    {
        
        string Hierarchicalidnumber_01 { get; set; }
        string Sequencenumber_02 { get; set; }
    }
    
    public interface I_C779
    {
        
        string Arraystructureidentifier_01 { get; set; }
        string Identitynumberqualifier_02 { get; set; }
    }
    
    public interface I_C780
    {
        
        string Valuelistidentifier_01 { get; set; }
        string Identitynumberqualifier_02 { get; set; }
    }
    
    public interface I_C782
    {
        
        string Datasetidentifier_01 { get; set; }
        string Identitynumberqualifier_02 { get; set; }
    }
    
    public interface I_C783
    {
        
        string Footnotesetidentifier_01 { get; set; }
        string Identitynumberqualifier_02 { get; set; }
    }
    
    public interface I_C784
    {
        
        string Footnoteidentifier_01 { get; set; }
        string Identitynumberqualifier_02 { get; set; }
    }
    
    public interface I_C785
    {
        
        string Statisticalconceptidentifier_01 { get; set; }
        string Identitynumberqualifier_02 { get; set; }
    }
    
    public interface I_C786
    {
        
        string Structurecomponentidentifier_01 { get; set; }
        string Identitynumberqualifier_02 { get; set; }
    }
    
    public interface I_C814
    {
        
        string Safetysection_01 { get; set; }
        string Safetysectionname_02 { get; set; }
    }
    
    public interface I_C815
    {
        
        string Additionalsafetyinformationcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Additionalsafetyinformation_04 { get; set; }
    }
    
    public interface I_C816
    {
        
        string Namecomponentqualifier_01 { get; set; }
        string Namecomponent_02 { get; set; }
        string Namecomponentstatuscoded_03 { get; set; }
        string Namecomponentoriginalrepresentationcoded_04 { get; set; }
    }
    
    public interface I_C817
    {
        
        string Addresspurposecoded_01 { get; set; }
        string Addresstypecoded_02 { get; set; }
        string Addressstatuscoded_03 { get; set; }
    }
    
    public interface I_C818
    {
        
        string Personinheritedcharacteristicidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Personinheritedcharacteristic_04 { get; set; }
    }
    
    public interface I_C819
    {
        
        string Countrysubentityidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Countrysubentity_04 { get; set; }
    }
    
    public interface I_C821
    {
        
        string Typeofdamagecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Typeofdamage_04 { get; set; }
    }
    
    public interface I_C822
    {
        
        string Damageareaidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Damagearea_04 { get; set; }
    }
    
    public interface I_C823
    {
        
        string Typeofunitcomponentcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Typeofunitcomponent_04 { get; set; }
    }
    
    public interface I_C824
    {
        
        string Componentmaterialcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Componentmaterial_04 { get; set; }
    }
    
    public interface I_C825
    {
        
        string Damageseveritycoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Damageseverity_04 { get; set; }
    }
    
    public interface I_C826
    {
        
        string Actionrequestnotificationcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Actionrequestnotification_04 { get; set; }
    }
    
    public interface I_C827
    {
        
        string Typeofmarkingcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C829
    {
        
        string Sublineindicatorcoded_01 { get; set; }
        string Lineitemnumber_02 { get; set; }
    }
    
    public interface I_C849
    {
        
        string Partyenactinginstructionidentification_01 { get; set; }
        string Recipientoftheinstructionidentification_02 { get; set; }
    }
    
    public interface I_C850
    {
        
        string Statuscoded_01 { get; set; }
        string Partyname_02 { get; set; }
    }
    
    public interface I_C878
    {
        
        string Institutionbranchnumber_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Accountholdernumber_04 { get; set; }
        string Currencycoded_05 { get; set; }
    }
    
    public interface I_C889
    {
        
        string Characteristicvaluecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Characteristicvalue_04 { get; set; }
        string Characteristicvalue_05 { get; set; }
    }
    
    public interface I_C901
    {
        
        string Applicationerroridentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C941
    {
        
        string Relationshipcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Relationship_04 { get; set; }
    }
    
    public interface I_C942
    {
        
        string Membershipcategoryidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Membershipcategory_04 { get; set; }
    }
    
    public interface I_C944
    {
        
        string Membershipstatuscoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Membershipstatus_04 { get; set; }
    }
    
    public interface I_C945
    {
        
        string Membershiplevelqualifier_01 { get; set; }
        string Membershiplevelidentification_02 { get; set; }
        string Codelistqualifier_03 { get; set; }
        string Codelistresponsibleagencycoded_04 { get; set; }
        string Membershiplevel_05 { get; set; }
    }
    
    public interface I_C948
    {
        
        string Employmentcategorycoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Employmentcategory_04 { get; set; }
    }
    
    public interface I_C950
    {
        
        string Qualificationclassificationcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Qualificationclassification_04 { get; set; }
        string Qualificationclassification_05 { get; set; }
    }
    
    public interface I_C951
    {
        
        string Occupationcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Occupation_04 { get; set; }
        string Occupation_05 { get; set; }
    }
    
    public interface I_C953
    {
        
        string Contributiontypecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Contributiontype_04 { get; set; }
    }
    
    public interface I_C955
    {
        
        string Attributetypecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C956
    {
        
        string Attributecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Attribute_04 { get; set; }
    }
    
    public interface I_C960
    {
        
        string Changereasoncoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Changereason_04 { get; set; }
    }
}
