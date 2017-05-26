namespace EdiFabric.Rules.EDIFACT_D00A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Segment("DGS")]
    public class DGS
    {
        
        [Pos(1)]
        public string Dangerousgoodsregulationscode_01 { get; set; }
        [Pos(2)]
        public C205 HAZARDCODE_02 { get; set; }
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
    }
    
    [Serializable()]
    [Segment("FTX")]
    public class FTX
    {
        
        [Pos(1)]
        public string Textsubjectcodequalifier_01 { get; set; }
        [Pos(2)]
        public string Freetextfunctioncode_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("IMD")]
    public class IMD
    {
        
        [Pos(1)]
        public string Descriptionformatcode_01 { get; set; }
        [Pos(2)]
        public C272 ITEMCHARACTERISTIC_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("ALI")]
    public class ALI
    {
        
        [Pos(1)]
        public string Countryoforiginnamecode_01 { get; set; }
        [Pos(2)]
        public string Dutyregimetypecode_02 { get; set; }
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
    }
    
    [Serializable()]
    [Segment("UNH")]
    public class UNH
    {
        
        [Pos(1)]
        public string MessageReferenceNumber_01 { get; set; }
        [Pos(2)]
        public S009 MessageIdentifier_02 { get; set; }
    }
}
