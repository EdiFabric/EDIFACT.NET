namespace EdiFabric.Rules.EANCOM_D01BEAN3
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Message("EDIFACT", "D01BEAN3", "INVOIC")]
    public class TSINVOIC : EdiMessage
    {
        
        [Pos(1)]
        public TSINVOIC_UNH TSINVOIC_UNH { get; set; }
        [Required]
        [Pos(2)]
        public TSINVOIC_BGM TSINVOIC_BGM { get; set; }
        [Required]
        [ListCount(35)]
        [Pos(3)]
        public List<TSINVOIC_DTM> TSINVOIC_DTM { get; set; }
        [Pos(4)]
        public TSINVOIC_PAI TSINVOIC_PAI { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<TSINVOIC_ALI> TSINVOIC_ALI { get; set; }
        [ListCount(99)]
        [Pos(6)]
        public List<TSINVOIC_FTX> TSINVOIC_FTX { get; set; }
        [ListCount(99999)]
        [Pos(7)]
        public List<TSINVOIC_RFFLoop1> RFFLoop1 { get; set; }
        [ListCount(99)]
        [Pos(8)]
        public List<TSINVOIC_NADLoop1> NADLoop1 { get; set; }
        [ListCount(5)]
        [Pos(9)]
        public List<TSINVOIC_TAXLoop1> TAXLoop1 { get; set; }
        [ListCount(99)]
        [Pos(10)]
        public List<TSINVOIC_CUXLoop1> CUXLoop1 { get; set; }
        [ListCount(10)]
        [Pos(11)]
        public List<TSINVOIC_PATLoop1> PATLoop1 { get; set; }
        [ListCount(10)]
        [Pos(12)]
        public List<TSINVOIC_TDTLoop1> TDTLoop1 { get; set; }
        [ListCount(5)]
        [Pos(13)]
        public List<TSINVOIC_TODLoop1> TODLoop1 { get; set; }
        [ListCount(1000)]
        [Pos(14)]
        public List<TSINVOIC_PACLoop1> PACLoop1 { get; set; }
        [ListCount(9999)]
        [Pos(15)]
        public List<TSINVOIC_ALCLoop1> ALCLoop1 { get; set; }
        [ListCount(9999999)]
        [Pos(16)]
        public List<TSINVOIC_LINLoop1> LINLoop1 { get; set; }
        [Required]
        [Pos(17)]
        public TSINVOIC_UNS TSINVOIC_UNS { get; set; }
        [ListCount(10)]
        [Pos(18)]
        public List<TSINVOIC_CNT> TSINVOIC_CNT { get; set; }
        [Required]
        [ListCount(100)]
        [Pos(19)]
        public List<TSINVOIC_MOALoop4> MOALoop4 { get; set; }
        [ListCount(10)]
        [Pos(20)]
        public List<TSINVOIC_TAXLoop5> TAXLoop5 { get; set; }
        [ListCount(15)]
        [Pos(21)]
        public List<TSINVOIC_ALCLoop3> ALCLoop3 { get; set; }
        [Pos(22)]
        public TSINVOIC_UNT TSINVOIC_UNT { get; set; }
    }
    
    [Serializable()]
    [Group("ALC")]
    public class TSINVOIC_ALCLoop3
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_ALC_3 TSINVOIC_ALC_3 { get; set; }
        [Pos(2)]
        public TSINVOIC_ALI_4 TSINVOIC_ALI_4 { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<TSINVOIC_MOA_12> TSINVOIC_MOA_12 { get; set; }
    }
    
    [Serializable()]
    [Group("TAX")]
    public class TSINVOIC_TAXLoop5
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_TAX_5 TSINVOIC_TAX_5 { get; set; }
        [ListCount(9)]
        [Pos(2)]
        public List<TSINVOIC_MOA_11> TSINVOIC_MOA_11 { get; set; }
    }
    
    [Serializable()]
    [Group("MOA")]
    public class TSINVOIC_MOALoop4
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_MOA_10 TSINVOIC_MOA_10 { get; set; }
        [Pos(2)]
        public TSINVOIC_RFFLoop5 RFFLoop5 { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop5
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_RFF_5 TSINVOIC_RFF_5 { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<TSINVOIC_DTM_11> TSINVOIC_DTM_11 { get; set; }
    }
    
    [Serializable()]
    [Group("LIN")]
    public class TSINVOIC_LINLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_LIN TSINVOIC_LIN { get; set; }
        [ListCount(25)]
        [Pos(2)]
        public List<TSINVOIC_PIA> TSINVOIC_PIA { get; set; }
        [ListCount(99)]
        [Pos(3)]
        public List<TSINVOIC_IMD> TSINVOIC_IMD { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<TSINVOIC_MEA> TSINVOIC_MEA { get; set; }
        [ListCount(5)]
        [Pos(5)]
        public List<TSINVOIC_QTY_2> TSINVOIC_QTY_2 { get; set; }
        [ListCount(5)]
        [Pos(6)]
        public List<TSINVOIC_ALI_2> TSINVOIC_ALI_2 { get; set; }
        [ListCount(35)]
        [Pos(7)]
        public List<TSINVOIC_DTM_6> TSINVOIC_DTM_6 { get; set; }
        [ListCount(1000)]
        [Pos(8)]
        public List<TSINVOIC_GIN> TSINVOIC_GIN { get; set; }
        [Pos(9)]
        public TSINVOIC_QVR TSINVOIC_QVR { get; set; }
        [ListCount(99)]
        [Pos(10)]
        public List<TSINVOIC_FTX_2> TSINVOIC_FTX_2 { get; set; }
        [ListCount(99)]
        [Pos(11)]
        public List<TSINVOIC_MOALoop2> MOALoop2 { get; set; }
        [ListCount(10)]
        [Pos(12)]
        public List<TSINVOIC_PATLoop2> PATLoop2 { get; set; }
        [ListCount(25)]
        [Pos(13)]
        public List<TSINVOIC_PRILoop1> PRILoop1 { get; set; }
        [ListCount(10)]
        [Pos(14)]
        public List<TSINVOIC_RFFLoop3> RFFLoop3 { get; set; }
        [ListCount(10)]
        [Pos(15)]
        public List<TSINVOIC_PACLoop2> PACLoop2 { get; set; }
        [ListCount(9999)]
        [Pos(16)]
        public List<TSINVOIC_LOCLoop2> LOCLoop2 { get; set; }
        [ListCount(99)]
        [Pos(17)]
        public List<TSINVOIC_TAXLoop3> TAXLoop3 { get; set; }
        [ListCount(99)]
        [Pos(18)]
        public List<TSINVOIC_NADLoop2> NADLoop2 { get; set; }
        [ListCount(30)]
        [Pos(19)]
        public List<TSINVOIC_ALCLoop2> ALCLoop2 { get; set; }
        [ListCount(10)]
        [Pos(20)]
        public List<TSINVOIC_TDTLoop2> TDTLoop2 { get; set; }
        [ListCount(5)]
        [Pos(21)]
        public List<TSINVOIC_TODLoop2> TODLoop2 { get; set; }
    }
    
    [Serializable()]
    [Group("TOD")]
    public class TSINVOIC_TODLoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_TOD_2 TSINVOIC_TOD_2 { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<TSINVOIC_LOC_4> TSINVOIC_LOC_4 { get; set; }
    }
    
    [Serializable()]
    [Group("TDT")]
    public class TSINVOIC_TDTLoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_TDT_2 TSINVOIC_TDT_2 { get; set; }
    }
    
    [Serializable()]
    [Group("ALC")]
    public class TSINVOIC_ALCLoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_ALC_2 TSINVOIC_ALC_2 { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<TSINVOIC_ALI_3> TSINVOIC_ALI_3 { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<TSINVOIC_DTM_10> TSINVOIC_DTM_10 { get; set; }
        [Pos(4)]
        public TSINVOIC_QTYLoop2 QTYLoop2 { get; set; }
        [Pos(5)]
        public TSINVOIC_PCDLoop2 PCDLoop2 { get; set; }
        [ListCount(2)]
        [Pos(6)]
        public List<TSINVOIC_MOALoop3> MOALoop3 { get; set; }
        [Pos(7)]
        public TSINVOIC_RTELoop2 RTELoop2 { get; set; }
        [ListCount(5)]
        [Pos(8)]
        public List<TSINVOIC_TAXLoop4> TAXLoop4 { get; set; }
    }
    
    [Serializable()]
    [Group("TAX")]
    public class TSINVOIC_TAXLoop4
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_TAX_4 TSINVOIC_TAX_4 { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<TSINVOIC_MOA_9> TSINVOIC_MOA_9 { get; set; }
    }
    
    [Serializable()]
    [Group("RTE")]
    public class TSINVOIC_RTELoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_RTE_2 TSINVOIC_RTE_2 { get; set; }
    }
    
    [Serializable()]
    [Group("MOA")]
    public class TSINVOIC_MOALoop3
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_MOA_8 TSINVOIC_MOA_8 { get; set; }
    }
    
    [Serializable()]
    [Group("PCD")]
    public class TSINVOIC_PCDLoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_PCD_4 TSINVOIC_PCD_4 { get; set; }
    }
    
    [Serializable()]
    [Group("QTY")]
    public class TSINVOIC_QTYLoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_QTY_4 TSINVOIC_QTY_4 { get; set; }
    }
    
    [Serializable()]
    [Group("NAD")]
    public class TSINVOIC_NADLoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_NAD_2 TSINVOIC_NAD_2 { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<TSINVOIC_RFFLoop4> RFFLoop4 { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop4
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_RFF_4 TSINVOIC_RFF_4 { get; set; }
    }
    
    [Serializable()]
    [Group("TAX")]
    public class TSINVOIC_TAXLoop3
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_TAX_3 TSINVOIC_TAX_3 { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<TSINVOIC_MOA_7> TSINVOIC_MOA_7 { get; set; }
    }
    
    [Serializable()]
    [Group("LOC")]
    public class TSINVOIC_LOCLoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_LOC_3 TSINVOIC_LOC_3 { get; set; }
        [ListCount(100)]
        [Pos(2)]
        public List<TSINVOIC_QTY_3> TSINVOIC_QTY_3 { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<TSINVOIC_DTM_9> TSINVOIC_DTM_9 { get; set; }
    }
    
    [Serializable()]
    [Group("PAC")]
    public class TSINVOIC_PACLoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_PAC_2 TSINVOIC_PAC_2 { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<TSINVOIC_MEA_2> TSINVOIC_MEA_2 { get; set; }
        [ListCount(10)]
        [Pos(3)]
        public List<TSINVOIC_PCILoop1> PCILoop1 { get; set; }
    }
    
    [Serializable()]
    [Group("PCI")]
    public class TSINVOIC_PCILoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_PCI TSINVOIC_PCI { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<TSINVOIC_GIN_2> TSINVOIC_GIN_2 { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop3
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_RFF_3 TSINVOIC_RFF_3 { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<TSINVOIC_DTM_8> TSINVOIC_DTM_8 { get; set; }
    }
    
    [Serializable()]
    [Group("PRI")]
    public class TSINVOIC_PRILoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_PRI TSINVOIC_PRI { get; set; }
        [Pos(2)]
        public TSINVOIC_APR TSINVOIC_APR { get; set; }
    }
    
    [Serializable()]
    [Group("PAT")]
    public class TSINVOIC_PATLoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_PAT_2 TSINVOIC_PAT_2 { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<TSINVOIC_DTM_7> TSINVOIC_DTM_7 { get; set; }
        [ListCount(99)]
        [Pos(3)]
        public List<TSINVOIC_PCD_3> TSINVOIC_PCD_3 { get; set; }
        [Pos(4)]
        public TSINVOIC_MOA_6 TSINVOIC_MOA_6 { get; set; }
    }
    
    [Serializable()]
    [Group("MOA")]
    public class TSINVOIC_MOALoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_MOA_5 TSINVOIC_MOA_5 { get; set; }
    }
    
    [Serializable()]
    [Group("ALC")]
    public class TSINVOIC_ALCLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_ALC TSINVOIC_ALC { get; set; }
        [Pos(2)]
        public TSINVOIC_QTYLoop1 QTYLoop1 { get; set; }
        [Pos(3)]
        public TSINVOIC_PCDLoop1 PCDLoop1 { get; set; }
        [ListCount(2)]
        [Pos(4)]
        public List<TSINVOIC_MOALoop1> MOALoop1 { get; set; }
        [Pos(5)]
        public TSINVOIC_RTELoop1 RTELoop1 { get; set; }
        [ListCount(5)]
        [Pos(6)]
        public List<TSINVOIC_TAXLoop2> TAXLoop2 { get; set; }
    }
    
    [Serializable()]
    [Group("TAX")]
    public class TSINVOIC_TAXLoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_TAX_2 TSINVOIC_TAX_2 { get; set; }
        [Pos(2)]
        public TSINVOIC_MOA_4 TSINVOIC_MOA_4 { get; set; }
    }
    
    [Serializable()]
    [Group("RTE")]
    public class TSINVOIC_RTELoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_RTE TSINVOIC_RTE { get; set; }
    }
    
    [Serializable()]
    [Group("MOA")]
    public class TSINVOIC_MOALoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_MOA_3 TSINVOIC_MOA_3 { get; set; }
    }
    
    [Serializable()]
    [Group("PCD")]
    public class TSINVOIC_PCDLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_PCD_2 TSINVOIC_PCD_2 { get; set; }
    }
    
    [Serializable()]
    [Group("QTY")]
    public class TSINVOIC_QTYLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_QTY TSINVOIC_QTY { get; set; }
    }
    
    [Serializable()]
    [Group("PAC")]
    public class TSINVOIC_PACLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_PAC TSINVOIC_PAC { get; set; }
    }
    
    [Serializable()]
    [Group("TOD")]
    public class TSINVOIC_TODLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_TOD TSINVOIC_TOD { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<TSINVOIC_LOC_2> TSINVOIC_LOC_2 { get; set; }
    }
    
    [Serializable()]
    [Group("TDT")]
    public class TSINVOIC_TDTLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_TDT TSINVOIC_TDT { get; set; }
        [ListCount(10)]
        [Pos(2)]
        public List<TSINVOIC_LOCLoop1> LOCLoop1 { get; set; }
    }
    
    [Serializable()]
    [Group("LOC")]
    public class TSINVOIC_LOCLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_LOC TSINVOIC_LOC { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<TSINVOIC_DTM_5> TSINVOIC_DTM_5 { get; set; }
    }
    
    [Serializable()]
    [Group("PAT")]
    public class TSINVOIC_PATLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_PAT TSINVOIC_PAT { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<TSINVOIC_DTM_4> TSINVOIC_DTM_4 { get; set; }
        [Pos(3)]
        public TSINVOIC_PCD TSINVOIC_PCD { get; set; }
        [Pos(4)]
        public TSINVOIC_MOA_2 TSINVOIC_MOA_2 { get; set; }
        [Pos(5)]
        public TSINVOIC_PAI_2 TSINVOIC_PAI_2 { get; set; }
        [Pos(6)]
        public TSINVOIC_FII_2 TSINVOIC_FII_2 { get; set; }
    }
    
    [Serializable()]
    [Group("CUX")]
    public class TSINVOIC_CUXLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_CUX TSINVOIC_CUX { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<TSINVOIC_DTM_3> TSINVOIC_DTM_3 { get; set; }
    }
    
    [Serializable()]
    [Group("TAX")]
    public class TSINVOIC_TAXLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_TAX TSINVOIC_TAX { get; set; }
        [Pos(2)]
        public TSINVOIC_MOA TSINVOIC_MOA { get; set; }
    }
    
    [Serializable()]
    [Group("NAD")]
    public class TSINVOIC_NADLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_NAD TSINVOIC_NAD { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<TSINVOIC_FII> TSINVOIC_FII { get; set; }
        [ListCount(9999)]
        [Pos(3)]
        public List<TSINVOIC_RFFLoop2> RFFLoop2 { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<TSINVOIC_CTALoop1> CTALoop1 { get; set; }
    }
    
    [Serializable()]
    [Group("CTA")]
    public class TSINVOIC_CTALoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_CTA TSINVOIC_CTA { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<TSINVOIC_COM> TSINVOIC_COM { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop2
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_RFF_2 TSINVOIC_RFF_2 { get; set; }
    }
    
    [Serializable()]
    [Group("RFF")]
    public class TSINVOIC_RFFLoop1
    {
        
        [Required]
        [Pos(1)]
        public TSINVOIC_RFF TSINVOIC_RFF { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<TSINVOIC_DTM_2> TSINVOIC_DTM_2 { get; set; }
    }
}
