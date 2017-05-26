namespace EdiFabric.Rules.EDIFACT_D00A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Composite("C108")]
    public class C108
    {
        
        [Pos(1)]
        public string Freetextvalue_01 { get; set; }
        [Pos(2)]
        public string Freetextvalue_02 { get; set; }
        [Pos(3)]
        public string Freetextvalue_03 { get; set; }
        [Pos(4)]
        public string Freetextvalue_04 { get; set; }
        [Pos(5)]
        public string Freetextvalue_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C107")]
    public class C107
    {
        
        [Pos(1)]
        public string Freetextvaluecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C516")]
    public class C516
    {
        
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        [Pos(4)]
        public string Currencytypecodequalifier_04 { get; set; }
        [Pos(5)]
        public string Statusdescriptioncode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C214")]
    public class C214
    {
        
        [Pos(1)]
        public string Specialservicedescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Specialservicedescription_04 { get; set; }
        [Pos(5)]
        public string Specialservicedescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C552")]
    public class C552
    {
        
        [Pos(1)]
        public string Allowanceorchargeidentifier_01 { get; set; }
        [Pos(2)]
        public string Allowanceorchargeidentificationcode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C243")]
    public class C243
    {
        
        [Pos(1)]
        public string Dutyortaxorfeeratedescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Dutyortaxorfeeratedescription_04 { get; set; }
        [Pos(5)]
        public string Dutyortaxorfeeratebasiscode_05 { get; set; }
        [Pos(6)]
        public string Codelistidentificationcode_06 { get; set; }
        [Pos(7)]
        public string Codelistresponsibleagencycode_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("C533")]
    public class C533
    {
        
        [Pos(1)]
        public string Dutyortaxorfeeaccountcode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C241")]
    public class C241
    {
        
        [Pos(1)]
        public string Dutyortaxorfeetypenamecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Dutyortaxorfeetypename_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C507")]
    public class C507
    {
        
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C506")]
    public class C506
    {
        
        [Pos(1)]
        public string Referencefunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        [Pos(3)]
        public string Documentlineidentifier_03 { get; set; }
        [Pos(4)]
        public string Referenceversionidentifier_04 { get; set; }
        [Pos(5)]
        public string Revisionidentifier_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C270")]
    public class C270
    {
        
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        [Pos(2)]
        public string Controltotalvalue_02 { get; set; }
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C186")]
    public class C186
    {
        
        [Pos(1)]
        public string Quantitytypecodequalifier_01 { get; set; }
        [Pos(2)]
        public string Quantity_02 { get; set; }
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C174")]
    public class C174
    {
        
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        [Pos(3)]
        public string Rangeminimumvalue_03 { get; set; }
        [Pos(4)]
        public string Rangemaximumvalue_04 { get; set; }
        [Pos(5)]
        public string Significantdigitsquantity_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C502")]
    public class C502
    {
        
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        [Pos(2)]
        public string Measurementsignificancecode_02 { get; set; }
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C553")]
    public class C553
    {
        
        [Pos(1)]
        public string Secondrelatedlocationnamecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Secondrelatedlocationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C519")]
    public class C519
    {
        
        [Pos(1)]
        public string Firstrelatedlocationnamecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Firstrelatedlocationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C517")]
    public class C517
    {
        
        [Pos(1)]
        public string Locationnamecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Locationname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C206")]
    public class C206
    {
        
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [Pos(2)]
        public string Objectidentificationcodequalifier_02 { get; set; }
        [Pos(3)]
        public string Statusdescriptioncode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C529")]
    public class C529
    {
        
        [Pos(1)]
        public string Processingindicatordescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Processtypedescriptioncode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C550")]
    public class C550
    {
        
        [Pos(1)]
        public string Requirementorconditiondescriptionidentifier_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Requirementorconditiondescription_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C100")]
    public class C100
    {
        
        [Pos(1)]
        public string Deliveryortransporttermsdescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Deliveryortransporttermsdescription_04 { get; set; }
        [Pos(5)]
        public string Deliveryortransporttermsdescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C222")]
    public class C222
    {
        
        [Pos(1)]
        public string Transportmeansidentificationnameidentifier_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Transportmeansidentificationname_04 { get; set; }
        [Pos(5)]
        public string Transportmeansnationalitycode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C401")]
    public class C401
    {
        
        [Pos(1)]
        public string Excesstransportationreasoncode_01 { get; set; }
        [Pos(2)]
        public string Excesstransportationresponsibilitycode_02 { get; set; }
        [Pos(3)]
        public string Customershipmentauthorisationidentifier_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040")]
    public class C040
    {
        
        [Pos(1)]
        public string Carrieridentifier_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Carriername_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C228")]
    public class C228
    {
        
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C220")]
    public class C220
    {
        
        [Pos(1)]
        public string Transportmodenamecode_01 { get; set; }
        [Pos(2)]
        public string Transportmodename_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C280")]
    public class C280
    {
        
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        [Pos(2)]
        public string Rangeminimumvalue_02 { get; set; }
        [Pos(3)]
        public string Rangemaximumvalue_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C128")]
    public class C128
    {
        
        [Pos(1)]
        public string Ratetypecodequalifier_01 { get; set; }
        [Pos(2)]
        public string Unitpricebasisrate_02 { get; set; }
        [Pos(3)]
        public string Unitpricebasisvalue_03 { get; set; }
        [Pos(4)]
        public string Measurementunitcode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C504")]
    public class C504
    {
        
        [Pos(1)]
        public string Currencyusagecodequalifier_01 { get; set; }
        [Pos(2)]
        public string Currencyidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Currencytypecodequalifier_03 { get; set; }
        [Pos(4)]
        public string Currencyratevalue_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C501")]
    public class C501
    {
        
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        [Pos(2)]
        public string Percentage_02 { get; set; }
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C076")]
    public class C076
    {
        
        [Pos(1)]
        public string Communicationnumber_01 { get; set; }
        [Pos(2)]
        public string Communicationnumbercodequalifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C056")]
    public class C056
    {
        
        [Pos(1)]
        public string Departmentoremployeenamecode_01 { get; set; }
        [Pos(2)]
        public string Departmentoremployeename_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C503")]
    public class C503
    {
        
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        [Pos(2)]
        public string Documentstatuscode_02 { get; set; }
        [Pos(3)]
        public string Documentsourcedescription_03 { get; set; }
        [Pos(4)]
        public string Languagenamecode_04 { get; set; }
        [Pos(5)]
        public string Versionidentifier_05 { get; set; }
        [Pos(6)]
        public string Revisionidentifier_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C002")]
    public class C002
    {
        
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C088")]
    public class C088
    {
        
        [Pos(1)]
        public string Institutionnamecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Institutionbranchidentifier_04 { get; set; }
        [Pos(5)]
        public string Codelistidentificationcode_05 { get; set; }
        [Pos(6)]
        public string Codelistresponsibleagencycode_06 { get; set; }
        [Pos(7)]
        public string Institutionname_07 { get; set; }
        [Pos(8)]
        public string Institutionbranchlocationname_08 { get; set; }
    }
    
    [Serializable()]
    [Composite("C078")]
    public class C078
    {
        
        [Pos(1)]
        public string Accountholderidentifier_01 { get; set; }
        [Pos(2)]
        public string Accountholdername_02 { get; set; }
        [Pos(3)]
        public string Accountholdername_03 { get; set; }
        [Pos(4)]
        public string Currencyidentificationcode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C819")]
    public class C819
    {
        
        [Pos(1)]
        public string Countrysubentitynamecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Countrysubentityname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C059")]
    public class C059
    {
        
        [Pos(1)]
        public string Streetandnumberorpostofficeboxidentifier_01 { get; set; }
        [Pos(2)]
        public string Streetandnumberorpostofficeboxidentifier_02 { get; set; }
        [Pos(3)]
        public string Streetandnumberorpostofficeboxidentifier_03 { get; set; }
        [Pos(4)]
        public string Streetandnumberorpostofficeboxidentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C080")]
    public class C080
    {
        
        [Pos(1)]
        public string Partyname_01 { get; set; }
        [Pos(2)]
        public string Partyname_02 { get; set; }
        [Pos(3)]
        public string Partyname_03 { get; set; }
        [Pos(4)]
        public string Partyname_04 { get; set; }
        [Pos(5)]
        public string Partyname_05 { get; set; }
        [Pos(6)]
        public string Partynameformatcode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C058")]
    public class C058
    {
        
        [Pos(1)]
        public string Nameandaddressdescription_01 { get; set; }
        [Pos(2)]
        public string Nameandaddressdescription_02 { get; set; }
        [Pos(3)]
        public string Nameandaddressdescription_03 { get; set; }
        [Pos(4)]
        public string Nameandaddressdescription_04 { get; set; }
        [Pos(5)]
        public string Nameandaddressdescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C082")]
    public class C082
    {
        
        [Pos(1)]
        public string Partyidentifier_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C208")]
    public class C208
    {
        
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C827")]
    public class C827
    {
        
        [Pos(1)]
        public string Markingtypecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C210")]
    public class C210
    {
        
        [Pos(1)]
        public string Shippingmarksdescription_01 { get; set; }
        [Pos(2)]
        public string Shippingmarksdescription_02 { get; set; }
        [Pos(3)]
        public string Shippingmarksdescription_03 { get; set; }
        [Pos(4)]
        public string Shippingmarksdescription_04 { get; set; }
        [Pos(5)]
        public string Shippingmarksdescription_05 { get; set; }
        [Pos(6)]
        public string Shippingmarksdescription_06 { get; set; }
        [Pos(7)]
        public string Shippingmarksdescription_07 { get; set; }
        [Pos(8)]
        public string Shippingmarksdescription_08 { get; set; }
        [Pos(9)]
        public string Shippingmarksdescription_09 { get; set; }
        [Pos(10)]
        public string Shippingmarksdescription_10 { get; set; }
    }
    
    [Serializable()]
    [Composite("C224")]
    public class C224
    {
        
        [Pos(1)]
        public string Equipmentsizeandtypedescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Equipmentsizeandtypedescription_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C237")]
    public class C237
    {
        
        [Pos(1)]
        public string Equipmentidentifier_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C532")]
    public class C532
    {
        
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycode_01 { get; set; }
        [Pos(2)]
        public string Returnablepackageloadcontentscode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C402")]
    public class C402
    {
        
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        [Pos(2)]
        public string Typeofpackages_02 { get; set; }
        [Pos(3)]
        public string Itemtypeidentificationcode_03 { get; set; }
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
        [Pos(5)]
        public string Itemtypeidentificationcode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C202")]
    public class C202
    {
        
        [Pos(1)]
        public string Packagetypedescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C531")]
    public class C531
    {
        
        [Pos(1)]
        public string Packaginglevelcode_01 { get; set; }
        [Pos(2)]
        public string Packagingrelateddescriptioncode_02 { get; set; }
        [Pos(3)]
        public string Packagingtermsandconditionscode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C960")]
    public class C960
    {
        
        [Pos(1)]
        public string Changereasondescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Changereasondescription_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C138")]
    public class C138
    {
        
        [Pos(1)]
        public string Pricemultiplierrate_01 { get; set; }
        [Pos(2)]
        public string Pricemultipliertypecodequalifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C509")]
    public class C509
    {
        
        [Pos(1)]
        public string Pricecodequalifier_01 { get; set; }
        [Pos(2)]
        public string Priceamount_02 { get; set; }
        [Pos(3)]
        public string Pricetypecode_03 { get; set; }
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        [Pos(5)]
        public string Unitpricebasisvalue_05 { get; set; }
        [Pos(6)]
        public string Measurementunitcode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C112")]
    public class C112
    {
        
        [Pos(1)]
        public string Timereferencecode_01 { get; set; }
        [Pos(2)]
        public string Termstimerelationcode_02 { get; set; }
        [Pos(3)]
        public string Periodtypecode_03 { get; set; }
        [Pos(4)]
        public string Periodcountquantity_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C110")]
    public class C110
    {
        
        [Pos(1)]
        public string Paymenttermsdescriptionidentifier_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Paymenttermsdescription_04 { get; set; }
        [Pos(5)]
        public string Paymenttermsdescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C236")]
    public class C236
    {
        
        [Pos(1)]
        public string Dangerousgoodsmarkingidentifier_01 { get; set; }
        [Pos(2)]
        public string Dangerousgoodsmarkingidentifier_02 { get; set; }
        [Pos(3)]
        public string Dangerousgoodsmarkingidentifier_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C235")]
    public class C235
    {
        
        [Pos(1)]
        public string Orangehazardplacardupperpartidentifier_01 { get; set; }
        [Pos(2)]
        public string Orangehazardplacardlowerpartidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C223")]
    public class C223
    {
        
        [Pos(1)]
        public string Shipmentflashpointvalue_01 { get; set; }
        [Pos(2)]
        public string Measurementunitcode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C234")]
    public class C234
    {
        
        [Pos(1)]
        public string UnitedNationsDangerousGoodsidentificationcode_01 { get; set; }
        [Pos(2)]
        public string Dangerousgoodsflashpointvalue_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C205")]
    public class C205
    {
        
        [Pos(1)]
        public string Hazardidentificationcode_01 { get; set; }
        [Pos(2)]
        public string Additionalhazardclassificationidentifier_02 { get; set; }
        [Pos(3)]
        public string Hazardcodeversionidentifier_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C279")]
    public class C279
    {
        
        [Pos(1)]
        public string Quantityvariancevalue_01 { get; set; }
        [Pos(2)]
        public string Quantitytypecodequalifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C273")]
    public class C273
    {
        
        [Pos(1)]
        public string Itemdescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        [Pos(6)]
        public string Languagenamecode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C272")]
    public class C272
    {
        
        [Pos(1)]
        public string Itemcharacteristiccode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C212")]
    public class C212
    {
        
        [Pos(1)]
        public string Itemidentifier_01 { get; set; }
        [Pos(2)]
        public string Itemtypeidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C829")]
    public class C829
    {
        
        [Pos(1)]
        public string Sublineindicatorcode_01 { get; set; }
        [Pos(2)]
        public string Lineitemidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C850")]
    public class C850
    {
        
        [Pos(1)]
        public string Statusdescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Partyname_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C522")]
    public class C522
    {
        
        [Pos(1)]
        public string Instructiontypecodequalifier_01 { get; set; }
        [Pos(2)]
        public string Instructiondescriptioncode_02 { get; set; }
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
        [Pos(5)]
        public string Instructiondescription_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C849")]
    public class C849
    {
        
        [Pos(1)]
        public string Enactingpartyidentifier_01 { get; set; }
        [Pos(2)]
        public string Instructionreceivingpartyidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C215")]
    public class C215
    {
        
        [Pos(1)]
        public string Sealingpartynamecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Sealingpartyname_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C703")]
    public class C703
    {
        
        [Pos(1)]
        public string Cargotypeclassificationcode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C537")]
    public class C537
    {
        
        [Pos(1)]
        public string Transportserviceprioritycode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C233")]
    public class C233
    {
        
        [Pos(1)]
        public string Servicerequirementcode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        [Pos(4)]
        public string Servicerequirementcode_04 { get; set; }
        [Pos(5)]
        public string Codelistidentificationcode_05 { get; set; }
        [Pos(6)]
        public string Codelistresponsibleagencycode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C536")]
    public class C536
    {
        
        [Pos(1)]
        public string Contractandcarriageconditioncode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C534")]
    public class C534
    {
        
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
        [Pos(3)]
        public string Paymentmeanscode_03 { get; set; }
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
        [Pos(6)]
        public string Paymentchannelcode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C106")]
    public class C106
    {
        
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        [Pos(2)]
        public string Versionidentifier_02 { get; set; }
        [Pos(3)]
        public string Revisionidentifier_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("S018")]
    public class S018
    {
        
        [Pos(1)]
        public string ScenarioIdentification_01 { get; set; }
        [Pos(2)]
        public string ScenarioVersionNumber_02 { get; set; }
        [Pos(3)]
        public string ScenarioReleaseNumber_03 { get; set; }
        [Pos(4)]
        public string ControllingAgencyCoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("S017")]
    public class S017
    {
        
        [Pos(1)]
        public string MessageImplementationGuidelineIdentification_01 { get; set; }
        [Pos(2)]
        public string MessageImplementationGuidelineVersionNumber_02 { get; set; }
        [Pos(3)]
        public string MessageImplementationGuidelineReleaseNumber_03 { get; set; }
        [Pos(4)]
        public string ControllingAgencyCoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("S016")]
    public class S016
    {
        
        [Pos(1)]
        public string MessageSubsetIdentification_01 { get; set; }
        [Pos(2)]
        public string MessageSubsetVersionNumber_02 { get; set; }
        [Pos(3)]
        public string MessageSubsetReleaseNumber_03 { get; set; }
        [Pos(4)]
        public string ControllingAgencyCoded_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("S010")]
    public class S010
    {
        
        [Pos(1)]
        public string SequenceMessageTransferNumber_01 { get; set; }
        [Pos(2)]
        public string FirstLastSequenceMessageTransferIndication_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("S009")]
    public class S009
    {
        
        [Pos(1)]
        public string MessageTypeIdentifier_01 { get; set; }
        [Pos(2)]
        public string MessageTypeVersionNumber_02 { get; set; }
        [Pos(3)]
        public string MessageTypeReleaseNumber_03 { get; set; }
        [Pos(4)]
        public string ControllingAgency_04 { get; set; }
        [Pos(5)]
        public string AssociationAssignedCode_05 { get; set; }
        [Pos(6)]
        public string CodeListDirectoryVersionNumber_06 { get; set; }
        [Pos(7)]
        public string MessageTypeSubfunctionIdentification_07 { get; set; }
    }
}
