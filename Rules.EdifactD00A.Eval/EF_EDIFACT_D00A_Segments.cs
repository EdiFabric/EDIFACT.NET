namespace EdiFabric.Rules.EDIFACT_D00A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Segment("GIR")]
    public class GIR
    {
        
        [Pos(1)]
        public string Settypecodequalifier_01 { get; set; }
        [Pos(2)]
        public C206 IDENTIFICATIONNUMBER_02 { get; set; }
        [Pos(3)]
        public C206 IDENTIFICATIONNUMBER_03 { get; set; }
        [Pos(4)]
        public C206 IDENTIFICATIONNUMBER_04 { get; set; }
        [Pos(5)]
        public C206 IDENTIFICATIONNUMBER_05 { get; set; }
        [Pos(6)]
        public C206 IDENTIFICATIONNUMBER_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("DGS")]
    public class DGS
    {
        
        [Pos(1)]
        public string Dangerousgoodsregulationscode_01 { get; set; }
        [Pos(2)]
        public C205 HAZARDCODE_02 { get; set; }
        [Pos(3)]
        public C234 UNDGINFORMATION_03 { get; set; }
        [Pos(4)]
        public C223 DANGEROUSGOODSSHIPMENTFLASHPOINT_04 { get; set; }
        [Pos(5)]
        public string Packagingdangerlevelcode_05 { get; set; }
        [Pos(6)]
        public string Emergencyprocedureforshipsidentifier_06 { get; set; }
        [Pos(7)]
        public string Hazardmedicalfirstaidguideidentifier_07 { get; set; }
        [Pos(8)]
        public string Transportemergencycardidentifier_08 { get; set; }
        [Pos(9)]
        public C235 HAZARDIDENTIFICATIONPLACARDDETAILS_09 { get; set; }
        [Pos(10)]
        public C236 DANGEROUSGOODSLABEL_10 { get; set; }
        [Pos(11)]
        public string Packinginstructiontypecode_11 { get; set; }
        [Pos(12)]
        public string Hazardousmeansoftransportcategorycode_12 { get; set; }
        [Pos(13)]
        public string Hazardouscargotransportauthorisationcode_13 { get; set; }
    }
    
    [Serializable()]
    [Segment("GIS")]
    public class GIS
    {
        
        [Pos(1)]
        public C529 PROCESSINGINDICATOR_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("LOC")]
    public class LOC
    {
        
        [Pos(1)]
        public string Locationfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public C517 LOCATIONIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public C519 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }
        [Pos(4)]
        public C553 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }
        [Pos(5)]
        public string Relationcode_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("FTX")]
    public class FTX
    {
        
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
        [Pos(3)]
        public C107 TEXTREFERENCE_03 { get; set; }
        [Pos(4)]
        public C108 TEXTLITERAL_04 { get; set; }
        [Pos(5)]
        public string Languagenamecode_05 { get; set; }
        [Pos(6)]
        public string Freetextformatcode_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("IMD")]
    public class IMD
    {
        
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        [Pos(2)]
        public C272 ITEMCHARACTERISTIC_02 { get; set; }
        [Pos(3)]
        public C273 ITEMDESCRIPTION_03 { get; set; }
        [Pos(4)]
        public string Surfaceorlayercode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALI")]
    public class ALI
    {
        
        [Pos(1)]
        public string Countryoforiginnamecode_01 { get; set; }
        [Pos(2)]
        public string Dutyregimetypecode_02 { get; set; }
        [Pos(3)]
        public string Specialconditioncode_03 { get; set; }
        [Pos(4)]
        public string Specialconditioncode_04 { get; set; }
        [Pos(5)]
        public string Specialconditioncode_05 { get; set; }
        [Pos(6)]
        public string Specialconditioncode_06 { get; set; }
        [Pos(7)]
        public string Specialconditioncode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("PAI")]
    public class PAI
    {
        
        [Pos(1)]
        public C534 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTM")]
    public class DTM
    {
        
        [Pos(1)]
        public C507 DATETIMEPERIOD_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("BGM")]
    public class BGM
    {
        
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }
        [Pos(2)]
        public C106 DOCUMENTMESSAGEIDENTIFICATION_02 { get; set; }
        [Pos(3)]
        public string Messagefunctioncode_03 { get; set; }
        [Pos(4)]
        public string Responsetypecode_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("UNH")]
    public class UNH
    {
        
        [Pos(1)]
        public string MessageReferenceNumber_01 { get; set; }
        [Pos(2)]
        public S009 MessageIdentifier_02 { get; set; }
        [Pos(3)]
        public string CommonAccessReference_03 { get; set; }
        [Pos(4)]
        public S010 StatusoftheTransfer_04 { get; set; }
        [Pos(5)]
        public S016 MessageSubsetIdentification_05 { get; set; }
        [Pos(6)]
        public S017 MessageImplementationGuidelineIdentification_06 { get; set; }
        [Pos(7)]
        public S018 ScenarioIdentification_07 { get; set; }
    }
}
