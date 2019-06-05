namespace EdiFabric.Templates.EdifactD13B
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;

    /// <summary>
    /// Bayplan/stowage plan occupied and empty locations message
    /// </summary>
    [Serializable()]
    [Message("EDIFACT", "D13B", "BAPLIE")]
    public class TSBAPLIE : EdiMessage
    {

        /// <summary>
        /// Message Header
        /// </summary>
        [Pos(1)]
        public UNH UNH { get; set; }
        /// <summary>
        /// BEGINNING OF MESSAGE
        /// </summary>
        [Pos(2)]
        public BGM BGM { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [Pos(4)]
        public List<Loop_RFF_BAPLIE> RFFLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [Pos(5)]
        public List<Loop_NAD_BAPLIE> NADLoop { get; set; }
        /// <summary>
        /// Loop for TRANSPORT INFORMATION
        /// </summary>
        [Pos(6)]
        public List<Loop_TDT_BAPLIE> TDTLoop { get; set; }
        /// <summary>
        /// SECTION CONTROL
        /// </summary>
        [Pos(7)]
        public UNS UNS { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(8)]
        public List<Loop_LOC_BAPLIE> LOCLoop { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [Pos(9)]
        public UNT UNT { get; set; }
    }

    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [Group(typeof(CTA))]
    public class Loop_CTA_BAPLIE
    {
        
        /// <summary>
        /// CONTACT INFORMATION
        /// </summary>
        [Pos(1)]
        public CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [Pos(2)]
        public List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for DANGEROUS GOODS
    /// </summary>
    [Serializable()]
    [Group(typeof(DGS))]
    public class Loop_DGS_BAPLIE
    {
        
        /// <summary>
        /// DANGEROUS GOODS
        /// </summary>
        [Pos(1)]
        public DGS DGS { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(2)]
        public FTX FTX { get; set; }
    }

    /// <summary>
    /// Loop for DANGEROUS GOODS
    /// </summary>
    [Serializable()]
    [Group(typeof(DGS))]
    public class Loop_DGS_BAPLIE_2
    {

        /// <summary>
        /// DANGEROUS GOODS
        /// </summary>
        [Pos(1)]
        public DGS DGS { get; set; }
        /// <summary>
        /// ATTRIBUTE
        /// </summary>
        [Pos(2)]
        public List<ATT> ATT { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [Pos(3)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(4)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [Pos(5)]
        public List<Loop_CTA_BAPLIE> LoopCTA { get; set; }
    }

    /// <summary>
    /// Loop for EQUIPMENT DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(EQD))]
    public class Loop_EQD_BAPLIE
    {
        
        /// <summary>
        /// EQUIPMENT DETAILS
        /// </summary>
        [Pos(1)]
        public EQD EQD { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Pos(2)]
        public List<NAD> NAD { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [Pos(3)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [Pos(4)]
        public List<HAN> HAN { get; set; }
        /// <summary>
        /// DIMENSIONS
        /// </summary>
        [Pos(5)]
        public List<DIM> DIM { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(6)]
        public List<RFF> RFF { get; set; }
        /// <summary>
        ///  NATURE OF CARGO
        /// </summary>
        [Pos(7)]
        public List<GDS> GDS { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(8)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(9)]
        public List<Loop_LOC_BAPLIE_3> LOCLoop { get; set; }
        /// <summary>
        /// Loop for TEMPERATURE
        /// </summary>
        [Pos(10)]
        public List<Loop_TMP_BAPLIE> TMPLoop { get; set; }
        /// <summary>
        /// Loop for ATTACHED EQUIPMENT
        /// </summary>
        [Pos(11)]
        public List<Loop_EQA_BAPLIE> EQALoop { get; set; }
        
       
        
    }
    
    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Group(typeof(LOC))]
    public class Loop_LOC_BAPLIE
    {
        
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(1)]
        public LOC LOC { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(2)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(3)]
        public RFF RFF { get; set; }        
        /// <summary>
        /// Loop for EQUIPMENT DETAILS
        /// </summary>
        [Pos(4)]
        public List<Loop_EQD_BAPLIE> EQDLoop { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [Pos(5)]
        public CNT CNT { get; set; }
    }

    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Group(typeof(LOC))]
    public class Loop_LOC_BAPLIE_2
    {
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(1)]
        public LOC LOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }

    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Group(typeof(LOC))]
    public class Loop_LOC_BAPLIE_3
    {
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(1)]
        public LOC LOC { get; set; }
        /// <summary>
        /// TRANSPORT SERVICE REQUIREMENTS
        /// </summary>
        [Pos(2)]
        public TSR TSR { get; set; }
        /// <summary>
        /// TRANSPORT INFORMATION
        /// </summary>
        [Pos(3)]
        public TDT TDT { get; set; }
    }

    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [Group(typeof(NAD))]
    public class Loop_NAD_BAPLIE
    {
        
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Pos(1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [Pos(2)]
        public List<Loop_CTA_BAPLIE> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [Group(typeof(RFF))]
    public class Loop_RFF_BAPLIE
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for TRANSPORT INFORMATION
    /// </summary>
    [Serializable()]
    [Group(typeof(TDT))]
    public class Loop_TDT_BAPLIE
    {
        
        /// <summary>
        /// TRANSPORT INFORMATION
        /// </summary>
        [Pos(1)]
        public TDT TDT { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(2)]
        public RFF RFF { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(3)]
        public FTX FTX { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(4)]
        public List<Loop_LOC_BAPLIE_2> LOCLoop { get; set; }       
        
    }

    /// <summary>
    /// Loop for TEMPERATURE
    /// </summary>
    [Serializable()]
    [Group(typeof(TMP))]
    public class Loop_TMP_BAPLIE
    {

        /// <summary>
        /// TEMPERATURE
        /// </summary>
        [Pos(1)]
        public TMP TMP { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [Pos(2)]
        public RNG RNG { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(3)]
        public DTM DTM { get; set; }       
    }

    /// <summary>
    /// Loop for ATTACHED EQUIPMENT
    /// </summary>
    [Serializable()]
    [Group(typeof(EQA))]
    public class Loop_EQA_BAPLIE
    {

        /// <summary>
        /// ATTACHED EQUIPMENT
        /// </summary>
        [Pos(1)]
        public EQA EQA { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Pos(2)]
        public NAD NAD { get; set; }
    }
}
