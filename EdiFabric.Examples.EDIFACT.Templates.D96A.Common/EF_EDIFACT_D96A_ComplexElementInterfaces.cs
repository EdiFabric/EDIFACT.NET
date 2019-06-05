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
    
    public interface I_C078
    {
        
        string Accountholdernumber_01 { get; set; }
        string Accountholdername_02 { get; set; }
        string Accountholdername_03 { get; set; }
        string Currencycoded_04 { get; set; }
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
    
    public interface I_C100
    {
        
        string Termsofdeliveryortransportcoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Termsofdeliveryortransport_04 { get; set; }
        string Termsofdeliveryortransport_05 { get; set; }
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
    
    public interface I_C509
    {
        
        string Pricequalifier_01 { get; set; }
        string Price_02 { get; set; }
        string Pricetypecoded_03 { get; set; }
        string Pricetypequalifier_04 { get; set; }
        string Unitpricebasis_05 { get; set; }
        string Measureunitqualifier_06 { get; set; }
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
    
    public interface I_C528
    {
        
        string Commodityrateidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
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
    
    public interface I_C550
    {
        
        string Requirementconditionidentification_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Requirementorcondition_04 { get; set; }
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
    
    public interface I_C601
    {
        
        string Statustypecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    public interface I_C703
    {
        
        string Natureofcargocoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
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
    
    public interface I_C889
    {
        
        string Characteristicvaluecoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Characteristicvalue_04 { get; set; }
        string Characteristicvalue_05 { get; set; }
    }
    
    public interface I_C960
    {
        
        string Changereasoncoded_01 { get; set; }
        string Codelistqualifier_02 { get; set; }
        string Codelistresponsibleagencycoded_03 { get; set; }
        string Changereason_04 { get; set; }
    }
}
