namespace EdiFabric.Templates.EdifactD03B
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;

    /// <summary>
    /// Passenger list message
    /// </summary>
    [Serializable()]
    [Message("EDIFACT", "D03B", "PAXLST")]
    public class TSPAXLST : EdiMessage
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
        /// REFERENCE
        /// </summary>
        [Pos(3)]
        public RFF RFF { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(4)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [Pos(5)]
        public List<Loop_NAD_PAXLST> NADLoop { get; set; }
        /// <summary>
        /// Loop for TRANSPORT INFORMATION
        /// </summary>
        [Pos(6)]
        public List<Loop_TDT_PAXLST> TDTLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [Pos(7)]
        public List<Loop_NAD_PAXLST_2> NADLoop2 { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [Pos(8)]
        public CNT CNT { get; set; }
        /// <summary>
        /// AUTHENTICATION RESULT
        /// </summary>
        [Pos(9)]
        public AUT AUT { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [Pos(10)]
        public UNT UNT { get; set; }
    }

    /// <summary>
    /// Loop for DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(DOC))]
    public class Loop_DOC_PAXLST
    {
        
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [Pos(1)]
        public DOC DOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// PROCESSING INFORMATION
        /// </summary>
        [Pos(3)]
        public List<GEI> GEI { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(4)]
        public List<RFF> RFF { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(5)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// CHARGE PAYMENT INSTRUCTIONS
        /// </summary>
        [Pos(6)]
        public CPI CPI { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [Pos(7)]
        public List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for GOODS ITEM DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(GID))]
    public class Loop_GID_PAXLST
    {
        
        /// <summary>
        /// GOODS ITEM DETAILS
        /// </summary>
        [Pos(1)]
        public GID GID { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(2)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [Pos(3)]
        public List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for PLACE/LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [Group(typeof(LOC))]
    public class Loop_LOC_PAXLST
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
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [Group(typeof(NAD))]
    public class Loop_NAD_PAXLST
    {
        
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Pos(1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// CONTACT INFORMATION
        /// </summary>
        [Pos(2)]
        public CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [Pos(3)]
        public List<COM> COM { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [Group(typeof(NAD))]
    public class Loop_NAD_PAXLST_2
    {
        
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Pos(1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// ATTRIBUTE
        /// </summary>
        [Pos(2)]
        public List<ATT> ATT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [Pos(4)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// PROCESSING INFORMATION
        /// </summary>
        [Pos(5)]
        public List<GEI> GEI { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(6)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(7)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [Pos(8)]
        public COM COM { get; set; }
        /// <summary>
        /// EMPLOYMENT DETAILS
        /// </summary>
        [Pos(9)]
        public List<EMP> EMP { get; set; }
        /// <summary>
        /// NATIONALITY
        /// </summary>
        [Pos(10)]
        public List<NAT> NAT { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(11)]
        public RFF RFF { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [Pos(12)]
        public List<Loop_DOC_PAXLST> DOCLoop { get; set; }
        /// <summary>
        /// Loop for GOODS ITEM DETAILS
        /// </summary>
        [Pos(13)]
        public List<Loop_GID_PAXLST> GIDLoop { get; set; }
        /// <summary>
        /// Loop for TRANSPORT INFORMATION
        /// </summary>
        [Pos(14)]
        public Loop_TDT_PAXLST_2 TDTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for TRANSPORT INFORMATION
    /// </summary>
    [Serializable()]
    [Group(typeof(TDT))]
    public class Loop_TDT_PAXLST
    {
        
        /// <summary>
        /// TRANSPORT INFORMATION
        /// </summary>
        [Pos(1)]
        public TDT TDT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(2)]
        public DTM DTM { get; set; }
        /// <summary>
        /// Loop for PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(3)]
        public List<Loop_LOC_PAXLST> LOCLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for TRANSPORT INFORMATION
    /// </summary>
    [Serializable()]
    [Group(typeof(TDT))]
    public class Loop_TDT_PAXLST_2
    {
        
        /// <summary>
        /// TRANSPORT INFORMATION
        /// </summary>
        [Pos(1)]
        public TDT TDT { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(2)]
        public FTX FTX { get; set; }
    }
}
