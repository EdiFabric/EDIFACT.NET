namespace EdiFabric.Rules.EDIFACT_D00A
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using EdiFabric.Attributes;
    
    
    public class C108
    {
        
        [D(1, "4440")]
        public string Freetextvalue_01 { get; set; }
        [D(2, "4440")]
        public string Freetextvalue_02 { get; set; }
        [D(3, "4440")]
        public string Freetextvalue_03 { get; set; }
        [D(4, "4440")]
        public string Freetextvalue_04 { get; set; }
        [D(5, "4440")]
        public string Freetextvalue_05 { get; set; }
    }
    
    public class C107
    {
        
        [D(1, "4441")]
        public string Freetextvaluecode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public class C516
    {
        
        [D(1, "5025")]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [D(2, "5004")]
        public string Monetaryamount_02 { get; set; }
        [D(3, "6345")]
        public string Currencyidentificationcode_03 { get; set; }
        [D(4, "6343")]
        public string Currencytypecodequalifier_04 { get; set; }
        [D(5, "4405")]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    public class C214
    {
        
        [D(1, "7161")]
        public string Specialservicedescriptioncode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "7160")]
        public string Specialservicedescription_04 { get; set; }
        [D(5, "7160")]
        public string Specialservicedescription_05 { get; set; }
    }
    
    public class C552
    {
        
        [D(1, "1230")]
        public string Allowanceorchargeidentifier_01 { get; set; }
        [D(2, "5189")]
        public string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    public class C243
    {
        
        [D(1, "5279")]
        public string Dutyortaxorfeeratedescriptioncode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "5278")]
        public string Dutyortaxorfeeratedescription_04 { get; set; }
        [D(5, "5273")]
        public string Dutyortaxorfeeratebasiscode_05 { get; set; }
        [D(6, "1131")]
        public string Codelistidentificationcode_06 { get; set; }
        [D(7, "3055")]
        public string Codelistresponsibleagencycode_07 { get; set; }
    }
    
    public class C533
    {
        
        [D(1, "5289")]
        public string Dutyortaxorfeeaccountcode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public class C241
    {
        
        [D(1, "5153")]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "5152")]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    public class C507
    {
        
        [D(1, "2005")]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [D(2, "2380")]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [D(3, "2379")]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    public class C506
    {
        
        [D(1, "1153")]
        public string Referencefunctioncodequalifier_01 { get; set; }
        [D(2, "1154")]
        public string Referenceidentifier_02 { get; set; }
        [D(3, "1156")]
        public string Documentlineidentifier_03 { get; set; }
        [D(4, "4000")]
        public string Referenceversionidentifier_04 { get; set; }
        [D(5, "1060")]
        public string Revisionidentifier_05 { get; set; }
    }
    
    public class C270
    {
        
        [D(1, "6069")]
        public string Controltotaltypecodequalifier_01 { get; set; }
        [D(2, "6066")]
        public string Controltotalvalue_02 { get; set; }
        [D(3, "6411")]
        public string Measurementunitcode_03 { get; set; }
    }
    
    public class C186
    {
        
        [D(1, "6063")]
        public string Quantitytypecodequalifier_01 { get; set; }
        [D(2, "6060")]
        public string Quantity_02 { get; set; }
        [D(3, "6411")]
        public string Measurementunitcode_03 { get; set; }
    }
    
    public class C174
    {
        
        [D(1, "6411")]
        public string Measurementunitcode_01 { get; set; }
        [D(2, "6314")]
        public string Measurementvalue_02 { get; set; }
        [D(3, "6162")]
        public string Rangeminimumvalue_03 { get; set; }
        [D(4, "6152")]
        public string Rangemaximumvalue_04 { get; set; }
        [D(5, "6432")]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    public class C502
    {
        
        [D(1, "6313")]
        public string Measuredattributecode_01 { get; set; }
        [D(2, "6321")]
        public string Measurementsignificancecode_02 { get; set; }
        [D(3, "6155")]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        [D(4, "6154")]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    public class C553
    {
        
        [D(1, "3233")]
        public string Secondrelatedlocationnamecode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "3232")]
        public string Secondrelatedlocationname_04 { get; set; }
    }
    
    public class C519
    {
        
        [D(1, "3223")]
        public string Firstrelatedlocationnamecode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "3222")]
        public string Firstrelatedlocationname_04 { get; set; }
    }
    
    public class C517
    {
        
        [D(1, "3225")]
        public string Locationnamecode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "3224")]
        public string Locationname_04 { get; set; }
    }
    
    public class C206
    {
        
        [D(1, "7402")]
        public string Objectidentifier_01 { get; set; }
        [D(2, "7405")]
        public string Objectidentificationcodequalifier_02 { get; set; }
        [D(3, "4405")]
        public string Statusdescriptioncode_03 { get; set; }
    }
    
    public class C529
    {
        
        [D(1, "7365")]
        public string Processingindicatordescriptioncode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "7187")]
        public string Processtypedescriptioncode_04 { get; set; }
    }
    
    public class C550
    {
        
        [D(1, "7295")]
        public string Requirementorconditiondescriptionidentifier_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "7294")]
        public string Requirementorconditiondescription_04 { get; set; }
    }
    
    public class C100
    {
        
        [D(1, "4053")]
        public string Deliveryortransporttermsdescriptioncode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "4052")]
        public string Deliveryortransporttermsdescription_04 { get; set; }
        [D(5, "4052")]
        public string Deliveryortransporttermsdescription_05 { get; set; }
    }
    
    public class C222
    {
        
        [D(1, "8213")]
        public string Transportmeansidentificationnameidentifier_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "8212")]
        public string Transportmeansidentificationname_04 { get; set; }
        [D(5, "8453")]
        public string Transportmeansnationalitycode_05 { get; set; }
    }
    
    public class C401
    {
        
        [D(1, "8457")]
        public string Excesstransportationreasoncode_01 { get; set; }
        [D(2, "8459")]
        public string Excesstransportationresponsibilitycode_02 { get; set; }
        [D(3, "7130")]
        public string Customershipmentauthorisationidentifier_03 { get; set; }
    }
    
    public class C040
    {
        
        [D(1, "3127")]
        public string Carrieridentifier_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "3128")]
        public string Carriername_04 { get; set; }
    }
    
    public class C228
    {
        
        [D(1, "8179")]
        public string Transportmeansdescriptioncode_01 { get; set; }
        [D(2, "8178")]
        public string Transportmeansdescription_02 { get; set; }
    }
    
    public class C220
    {
        
        [D(1, "8067")]
        public string Transportmodenamecode_01 { get; set; }
        [D(2, "8066")]
        public string Transportmodename_02 { get; set; }
    }
    
    public class C280
    {
        
        [D(1, "6411")]
        public string Measurementunitcode_01 { get; set; }
        [D(2, "6162")]
        public string Rangeminimumvalue_02 { get; set; }
        [D(3, "6152")]
        public string Rangemaximumvalue_03 { get; set; }
    }
    
    public class C128
    {
        
        [D(1, "5419")]
        public string Ratetypecodequalifier_01 { get; set; }
        [D(2, "5420")]
        public string Unitpricebasisrate_02 { get; set; }
        [D(3, "5284")]
        public string Unitpricebasisvalue_03 { get; set; }
        [D(4, "6411")]
        public string Measurementunitcode_04 { get; set; }
    }
    
    public class C504
    {
        
        [D(1, "6347")]
        public string Currencyusagecodequalifier_01 { get; set; }
        [D(2, "6345")]
        public string Currencyidentificationcode_02 { get; set; }
        [D(3, "6343")]
        public string Currencytypecodequalifier_03 { get; set; }
        [D(4, "6348")]
        public string Currencyratevalue_04 { get; set; }
    }
    
    public class C501
    {
        
        [D(1, "5245")]
        public string Percentagetypecodequalifier_01 { get; set; }
        [D(2, "5482")]
        public string Percentage_02 { get; set; }
        [D(3, "5249")]
        public string Percentagebasisidentificationcode_03 { get; set; }
        [D(4, "1131")]
        public string Codelistidentificationcode_04 { get; set; }
        [D(5, "3055")]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    public class C076
    {
        
        [D(1, "3148")]
        public string Communicationnumber_01 { get; set; }
        [D(2, "3155")]
        public string Communicationnumbercodequalifier_02 { get; set; }
    }
    
    public class C056
    {
        
        [D(1, "3413")]
        public string Departmentoremployeenamecode_01 { get; set; }
        [D(2, "3412")]
        public string Departmentoremployeename_02 { get; set; }
    }
    
    public class C503
    {
        
        [D(1, "1004")]
        public string Documentidentifier_01 { get; set; }
        [D(2, "1373")]
        public string Documentstatuscode_02 { get; set; }
        [D(3, "1366")]
        public string Documentsourcedescription_03 { get; set; }
        [D(4, "3453")]
        public string Languagenamecode_04 { get; set; }
        [D(5, "1056")]
        public string Versionidentifier_05 { get; set; }
        [D(6, "1060")]
        public string Revisionidentifier_06 { get; set; }
    }
    
    public class C002
    {
        
        [D(1, "1001")]
        public string Documentnamecode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "1000")]
        public string Documentname_04 { get; set; }
    }
    
    public class C088
    {
        
        [D(1, "3433")]
        public string Institutionnamecode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "3434")]
        public string Institutionbranchidentifier_04 { get; set; }
        [D(5, "1131")]
        public string Codelistidentificationcode_05 { get; set; }
        [D(6, "3055")]
        public string Codelistresponsibleagencycode_06 { get; set; }
        [D(7, "3432")]
        public string Institutionname_07 { get; set; }
        [D(8, "3436")]
        public string Institutionbranchlocationname_08 { get; set; }
    }
    
    public class C078
    {
        
        [D(1, "3194")]
        public string Accountholderidentifier_01 { get; set; }
        [D(2, "3192")]
        public string Accountholdername_02 { get; set; }
        [D(3, "3192")]
        public string Accountholdername_03 { get; set; }
        [D(4, "6345")]
        public string Currencyidentificationcode_04 { get; set; }
    }
    
    public class C819
    {
        
        [D(1, "3229")]
        public string Countrysubentitynamecode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "3228")]
        public string Countrysubentityname_04 { get; set; }
    }
    
    public class C059
    {
        
        [D(1, "3042")]
        public string Streetandnumberorpostofficeboxidentifier_01 { get; set; }
        [D(2, "3042")]
        public string Streetandnumberorpostofficeboxidentifier_02 { get; set; }
        [D(3, "3042")]
        public string Streetandnumberorpostofficeboxidentifier_03 { get; set; }
        [D(4, "3042")]
        public string Streetandnumberorpostofficeboxidentifier_04 { get; set; }
    }
    
    public class C080
    {
        
        [D(1, "3036")]
        public string Partyname_01 { get; set; }
        [D(2, "3036")]
        public string Partyname_02 { get; set; }
        [D(3, "3036")]
        public string Partyname_03 { get; set; }
        [D(4, "3036")]
        public string Partyname_04 { get; set; }
        [D(5, "3036")]
        public string Partyname_05 { get; set; }
        [D(6, "3045")]
        public string Partynameformatcode_06 { get; set; }
    }
    
    public class C058
    {
        
        [D(1, "3124")]
        public string Nameandaddressdescription_01 { get; set; }
        [D(2, "3124")]
        public string Nameandaddressdescription_02 { get; set; }
        [D(3, "3124")]
        public string Nameandaddressdescription_03 { get; set; }
        [D(4, "3124")]
        public string Nameandaddressdescription_04 { get; set; }
        [D(5, "3124")]
        public string Nameandaddressdescription_05 { get; set; }
    }
    
    public class C082
    {
        
        [D(1, "3039")]
        public string Partyidentifier_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public class C208
    {
        
        [D(1, "7402")]
        public string Objectidentifier_01 { get; set; }
        [D(2, "7402")]
        public string Objectidentifier_02 { get; set; }
    }
    
    public class C827
    {
        
        [D(1, "7511")]
        public string Markingtypecode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public class C210
    {
        
        [D(1, "7102")]
        public string Shippingmarksdescription_01 { get; set; }
        [D(2, "7102")]
        public string Shippingmarksdescription_02 { get; set; }
        [D(3, "7102")]
        public string Shippingmarksdescription_03 { get; set; }
        [D(4, "7102")]
        public string Shippingmarksdescription_04 { get; set; }
        [D(5, "7102")]
        public string Shippingmarksdescription_05 { get; set; }
        [D(6, "7102")]
        public string Shippingmarksdescription_06 { get; set; }
        [D(7, "7102")]
        public string Shippingmarksdescription_07 { get; set; }
        [D(8, "7102")]
        public string Shippingmarksdescription_08 { get; set; }
        [D(9, "7102")]
        public string Shippingmarksdescription_09 { get; set; }
        [D(10, "7102")]
        public string Shippingmarksdescription_10 { get; set; }
    }
    
    public class C224
    {
        
        [D(1, "8155")]
        public string Equipmentsizeandtypedescriptioncode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "8154")]
        public string Equipmentsizeandtypedescription_04 { get; set; }
    }
    
    public class C237
    {
        
        [D(1, "8260")]
        public string Equipmentidentifier_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "3207")]
        public string Countrynamecode_04 { get; set; }
    }
    
    public class C532
    {
        
        [D(1, "8395")]
        public string Returnablepackagefreightpaymentresponsibilitycode_01 { get; set; }
        [D(2, "8393")]
        public string Returnablepackageloadcontentscode_02 { get; set; }
    }
    
    public class C402
    {
        
        [D(1, "7077")]
        public string Descriptionformatcode_01 { get; set; }
        [D(2, "7064")]
        public string Typeofpackages_02 { get; set; }
        [D(3, "7143")]
        public string Itemtypeidentificationcode_03 { get; set; }
        [D(4, "7064")]
        public string Typeofpackages_04 { get; set; }
        [D(5, "7143")]
        public string Itemtypeidentificationcode_05 { get; set; }
    }
    
    public class C202
    {
        
        [D(1, "7065")]
        public string Packagetypedescriptioncode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "7064")]
        public string Typeofpackages_04 { get; set; }
    }
    
    public class C531
    {
        
        [D(1, "7075")]
        public string Packaginglevelcode_01 { get; set; }
        [D(2, "7233")]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        [D(3, "7073")]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    public class C960
    {
        
        [D(1, "4295")]
        public string Changereasondescriptioncode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "4294")]
        public string Changereasondescription_04 { get; set; }
    }
    
    public class C138
    {
        
        [D(1, "5394")]
        public string Pricemultiplierrate_01 { get; set; }
        [D(2, "5393")]
        public string Pricemultipliertypecodequalifier_02 { get; set; }
    }
    
    public class C509
    {
        
        [D(1, "5125")]
        public string Pricecodequalifier_01 { get; set; }
        [D(2, "5118")]
        public string Priceamount_02 { get; set; }
        [D(3, "5375")]
        public string Pricetypecode_03 { get; set; }
        [D(4, "5387")]
        public string Pricespecificationcode_04 { get; set; }
        [D(5, "5284")]
        public string Unitpricebasisvalue_05 { get; set; }
        [D(6, "6411")]
        public string Measurementunitcode_06 { get; set; }
    }
    
    public class C112
    {
        
        [D(1, "2475")]
        public string Timereferencecode_01 { get; set; }
        [D(2, "2009")]
        public string Termstimerelationcode_02 { get; set; }
        [D(3, "2151")]
        public string Periodtypecode_03 { get; set; }
        [D(4, "2152")]
        public string Periodcountquantity_04 { get; set; }
    }
    
    public class C110
    {
        
        [D(1, "4277")]
        public string Paymenttermsdescriptionidentifier_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "4276")]
        public string Paymenttermsdescription_04 { get; set; }
        [D(5, "4276")]
        public string Paymenttermsdescription_05 { get; set; }
    }
    
    public class C236
    {
        
        [D(1, "8246")]
        public string Dangerousgoodsmarkingidentifier_01 { get; set; }
        [D(2, "8246")]
        public string Dangerousgoodsmarkingidentifier_02 { get; set; }
        [D(3, "8246")]
        public string Dangerousgoodsmarkingidentifier_03 { get; set; }
    }
    
    public class C235
    {
        
        [D(1, "8158")]
        public string Orangehazardplacardupperpartidentifier_01 { get; set; }
        [D(2, "8186")]
        public string Orangehazardplacardlowerpartidentifier_02 { get; set; }
    }
    
    public class C223
    {
        
        [D(1, "7106")]
        public string Shipmentflashpointvalue_01 { get; set; }
        [D(2, "6411")]
        public string Measurementunitcode_02 { get; set; }
    }
    
    public class C234
    {
        
        [D(1, "7124")]
        public string UnitedNationsDangerousGoodsidentificationcode_01 { get; set; }
        [D(2, "7088")]
        public string Dangerousgoodsflashpointvalue_02 { get; set; }
    }
    
    public class C205
    {
        
        [D(1, "8351")]
        public string Hazardidentificationcode_01 { get; set; }
        [D(2, "8078")]
        public string Additionalhazardclassificationidentifier_02 { get; set; }
        [D(3, "8092")]
        public string Hazardcodeversionidentifier_03 { get; set; }
    }
    
    public class C279
    {
        
        [D(1, "6064")]
        public string Quantityvariancevalue_01 { get; set; }
        [D(2, "6063")]
        public string Quantitytypecodequalifier_02 { get; set; }
    }
    
    public class C273
    {
        
        [D(1, "7009")]
        public string Itemdescriptioncode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "7008")]
        public string Itemdescription_04 { get; set; }
        [D(5, "7008")]
        public string Itemdescription_05 { get; set; }
        [D(6, "3453")]
        public string Languagenamecode_06 { get; set; }
    }
    
    public class C272
    {
        
        [D(1, "7081")]
        public string Itemcharacteristiccode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public class C212
    {
        
        [D(1, "7140")]
        public string Itemidentifier_01 { get; set; }
        [D(2, "7143")]
        public string Itemtypeidentificationcode_02 { get; set; }
        [D(3, "1131")]
        public string Codelistidentificationcode_03 { get; set; }
        [D(4, "3055")]
        public string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    public class C829
    {
        
        [D(1, "5495")]
        public string Sublineindicatorcode_01 { get; set; }
        [D(2, "1082")]
        public string Lineitemidentifier_02 { get; set; }
    }
    
    public class C850
    {
        
        [D(1, "4405")]
        public string Statusdescriptioncode_01 { get; set; }
        [D(2, "3036")]
        public string Partyname_02 { get; set; }
    }
    
    public class C522
    {
        
        [D(1, "4403")]
        public string Instructiontypecodequalifier_01 { get; set; }
        [D(2, "4401")]
        public string Instructiondescriptioncode_02 { get; set; }
        [D(3, "1131")]
        public string Codelistidentificationcode_03 { get; set; }
        [D(4, "3055")]
        public string Codelistresponsibleagencycode_04 { get; set; }
        [D(5, "4400")]
        public string Instructiondescription_05 { get; set; }
    }
    
    public class C849
    {
        
        [D(1, "3301")]
        public string Enactingpartyidentifier_01 { get; set; }
        [D(2, "3285")]
        public string Instructionreceivingpartyidentifier_02 { get; set; }
    }
    
    public class C215
    {
        
        [D(1, "9303")]
        public string Sealingpartynamecode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "9302")]
        public string Sealingpartyname_04 { get; set; }
    }
    
    public class C703
    {
        
        [D(1, "7085")]
        public string Cargotypeclassificationcode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public class C537
    {
        
        [D(1, "4219")]
        public string Transportserviceprioritycode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public class C233
    {
        
        [D(1, "7273")]
        public string Servicerequirementcode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [D(4, "7273")]
        public string Servicerequirementcode_04 { get; set; }
        [D(5, "1131")]
        public string Codelistidentificationcode_05 { get; set; }
        [D(6, "3055")]
        public string Codelistresponsibleagencycode_06 { get; set; }
    }
    
    public class C536
    {
        
        [D(1, "4065")]
        public string Contractandcarriageconditioncode_01 { get; set; }
        [D(2, "1131")]
        public string Codelistidentificationcode_02 { get; set; }
        [D(3, "3055")]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    public class C534
    {
        
        [D(1, "4439")]
        public string Paymentconditionscode_01 { get; set; }
        [D(2, "4431")]
        public string Paymentguaranteemeanscode_02 { get; set; }
        [D(3, "4461")]
        public string Paymentmeanscode_03 { get; set; }
        [D(4, "1131")]
        public string Codelistidentificationcode_04 { get; set; }
        [D(5, "3055")]
        public string Codelistresponsibleagencycode_05 { get; set; }
        [D(6, "4435")]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    public class C106
    {
        
        [D(1, "1004")]
        public string Documentidentifier_01 { get; set; }
        [D(2, "1056")]
        public string Versionidentifier_02 { get; set; }
        [D(3, "1060")]
        public string Revisionidentifier_03 { get; set; }
    }
    
    public class S018
    {
        
        [D(1, "0127")]
        public string ScenarioIdentification_01 { get; set; }
        [D(2, "0128")]
        public string ScenarioVersionNumber_02 { get; set; }
        [D(3, "0130")]
        public string ScenarioReleaseNumber_03 { get; set; }
        [D(4, "0051")]
        public string ControllingAgencyCoded_04 { get; set; }
    }
    
    public class S017
    {
        
        [D(1, "0121")]
        public string MessageImplementationGuidelineIdentification_01 { get; set; }
        [D(2, "0122")]
        public string MessageImplementationGuidelineVersionNumber_02 { get; set; }
        [D(3, "0124")]
        public string MessageImplementationGuidelineReleaseNumber_03 { get; set; }
        [D(4, "0051")]
        public string ControllingAgencyCoded_04 { get; set; }
    }
    
    public class S016
    {
        
        [D(1, "0115")]
        public string MessageSubsetIdentification_01 { get; set; }
        [D(2, "0116")]
        public string MessageSubsetVersionNumber_02 { get; set; }
        [D(3, "0118")]
        public string MessageSubsetReleaseNumber_03 { get; set; }
        [D(4, "0051")]
        public string ControllingAgencyCoded_04 { get; set; }
    }
    
    public class S010
    {
        
        [D(1, "0070")]
        public string SequenceMessageTransferNumber_01 { get; set; }
        [D(2, "0073")]
        public string FirstLastSequenceMessageTransferIndication_02 { get; set; }
    }
    
    public class S009
    {
        
        [D(1, "0065")]
        public string MessageTypeIdentifier_01 { get; set; }
        [D(2, "0052")]
        public string MessageTypeVersionNumber_02 { get; set; }
        [D(3, "0054")]
        public string MessageTypeReleaseNumber_03 { get; set; }
        [D(4, "0051")]
        public string ControllingAgency_04 { get; set; }
        [D(5, "0057")]
        public string AssociationAssignedCode_05 { get; set; }
        [D(6, "0110")]
        public string CodeListDirectoryVersionNumber_06 { get; set; }
        [D(7, "0113")]
        public string MessageTypeSubfunctionIdentification_07 { get; set; }
    }
}
