namespace EdiFabric.Rules.EDIFACT_D00A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
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
