namespace EdiFabric.Rules.EDIFACT_D00A
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Composite("C205")]
    public class C205
    {
        
        [Pos(1)]
        public string Hazardidentificationcode_01 { get; set; }
        [Pos(2)]
        public string Additionalhazardclassificationidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C529")]
    public class C529
    {
        
        [Pos(1)]
        public string Processingindicatordescriptioncode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C517")]
    public class C517
    {
        
        [Pos(1)]
        public string Locationnamecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C272")]
    public class C272
    {
        
        [Pos(1)]
        public string Itemcharacteristiccode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C534")]
    public class C534
    {
        
        [Pos(1)]
        public string Paymentconditionscode_01 { get; set; }
        [Pos(2)]
        public string Paymentguaranteemeanscode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C507")]
    public class C507
    {
        
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C106")]
    public class C106
    {
        
        [Pos(1)]
        public string Documentidentifier_01 { get; set; }
        [Pos(2)]
        public string Versionidentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("C002")]
    public class C002
    {
        
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
    }
    
    [Serializable()]
    [Composite("S009")]
    public class S009
    {
        
        [Pos(1)]
        public string MessageTypeIdentifier_01 { get; set; }
        [Pos(2)]
        public string MessageTypeVersionNumber_02 { get; set; }
    }
}
