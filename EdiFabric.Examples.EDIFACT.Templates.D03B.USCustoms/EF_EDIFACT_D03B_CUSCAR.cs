namespace EdiFabric.Templates.EdifactD03B
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;

    /// <summary>
    /// Customs cargo report message
    /// </summary>
    [Serializable()]
    [Message("EDIFACT", "D03B", "CUSCAR")]
    public class TSCUSCAR : EdiMessage
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
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(4)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// QUANTITY
        /// </summary>
        [Pos(5)]
        public List<QTY> QTY { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [Pos(6)]
        public List<Loop_RFF_CUSCAR> RFFLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [Pos(7)]
        public List<Loop_NAD_CUSCAR> NADLoop { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(8)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// Loop for TRANSPORT INFORMATION
        /// </summary>
        [Pos(9)]
        public List<Loop_TDT_CUSCAR> TDTLoop { get; set; }
        /// <summary>
        /// PROCESSING INFORMATION
        /// </summary>
        [Pos(10)]
        public List<GEI> GEI { get; set; }
        /// <summary>
        /// Loop for EQUIPMENT DETAILS
        /// </summary>
        [Pos(11)]
        public List<Loop_EQD_CUSCAR> EQDLoop { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [Pos(12)]
        public List<CNT> CNT { get; set; }
        /// <summary>
        /// Loop for CONSIGNMENT INFORMATION
        /// </summary>
        [Pos(13)]
        public List<Loop_CNI_CUSCAR> CNILoop { get; set; }
        /// <summary>
        /// Loop for AUTHENTICATION RESULT
        /// </summary>
        [Pos(14)]
        public Loop_AUT_CUSCAR AUTLoop { get; set; }
        /// <summary>
        /// Message Trailer
        /// </summary>
        [Pos(15)]
        public UNT UNT { get; set; }
    }

    /// <summary>
    /// Loop for AUTHENTICATION RESULT
    /// </summary>
    [Serializable()]
    [Group(typeof(AUT))]
    public class Loop_AUT_CUSCAR
    {
        
        /// <summary>
        /// AUTHENTICATION RESULT
        /// </summary>
        [Pos(1)]
        public AUT AUT { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(3)]
        public List<RFF> RFF { get; set; }
    }
    
    /// <summary>
    /// Loop for CONSIGNMENT INFORMATION
    /// </summary>
    [Serializable()]
    [Group(typeof(CNI))]
    public class Loop_CNI_CUSCAR
    {
        
        /// <summary>
        /// CONSIGNMENT INFORMATION
        /// </summary>
        [Pos(1)]
        public CNI CNI { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [Pos(2)]
        public List<CNT> CNT { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// This is specific to the US Customs - https://www.cbp.gov/trade/ace/truck-manifest/edi/message/electronic-truck-manifest
        /// </summary>
        [Pos(3)]
        public List<DOC> DOC { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [Pos(4)]
        public List<Loop_RFF_CUSCAR_2> RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [Group(typeof(CTA))]
    public class Loop_CTA_CUSCAR
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
    /// Loop for EQUIPMENT DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(EQD))]
    public class Loop_EQD_CUSCAR
    {
        
        /// <summary>
        /// EQUIPMENT DETAILS
        /// </summary>
        [Pos(1)]
        public EQD EQD { get; set; }
        /// <summary>
        /// TRANSPORT SERVICE REQUIREMENTS
        /// </summary>
        [Pos(2)]
        public List<TSR> TSR { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [Pos(3)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// DIMENSIONS
        /// </summary>
        [Pos(4)]
        public List<DIM> DIM { get; set; }
        /// <summary>
        /// SEAL NUMBER
        /// </summary>
        [Pos(5)]
        public List<SEL> SEL { get; set; }
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Pos(6)]
        public List<NAD> NAD { get; set; }
        /// <summary>
        /// PROCESSING INFORMATION
        /// </summary>
        [Pos(7)]
        public List<GEI> GEI { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(8)]
        public LOC LOC { get; set; }
        /// <summary>
        /// Loop for TEMPERATURE
        /// </summary>
        [Pos(9)]
        public List<Loop_TMP_CUSCAR> TMPLoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// This is specific to the US Customs - https://www.cbp.gov/trade/ace/truck-manifest/edi/message/electronic-truck-manifest
        /// </summary>
        [Pos(9)]
        public List<Loop_RFF_CUSCAR_4> RFFLoop { get; set; }        
    }
    
    /// <summary>
    /// Loop for PROCESSING INFORMATION
    /// </summary>
    [Serializable()]
    [Group(typeof(GEI))]
    public class Loop_GEI_CUSCAR
    {
        
        /// <summary>
        /// PROCESSING INFORMATION
        /// </summary>
        [Pos(1)]
        public GEI GEI { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [Pos(3)]
        public List<DOC> DOC { get; set; }
        /// <summary>
        /// PACKAGE
        /// </summary>
        [Pos(4)]
        public List<PAC> PAC { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [Pos(5)]
        public List<MEA> MEA { get; set; }
    }
    
    /// <summary>
    /// Loop for GOODS ITEM DETAILS
    /// </summary>
    [Serializable()]
    [Group(typeof(GID))]
    public class Loop_GID_CUSCAR
    {
        
        /// <summary>
        /// GOODS ITEM DETAILS
        /// </summary>
        [Pos(1)]
        public GID GID { get; set; }
        /// <summary>
        /// PACKAGE
        /// </summary>
        [Pos(2)]
        public List<PAC> PAC { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [Pos(3)]
        public List<HAN> HAN { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(4)]
        public List<FTX> FTX { get; set; }
        /// <summary>
        /// MEASUREMENTS
        /// </summary>
        [Pos(5)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [Pos(6)]
        public List<MOA> MOA { get; set; }
        /// <summary>
        /// SPLIT GOODS PLACEMENT
        /// </summary>
        [Pos(7)]
        public List<SGP> SGP { get; set; }
        /// <summary>
        /// DANGEROUS GOODS
        /// </summary>
        [Pos(8)]
        public List<DGS> DGS { get; set; }
        /// <summary>
        /// PACKAGE IDENTIFICATION
        /// </summary>
        [Pos(9)]
        public List<PCI> PCI { get; set; }
        /// <summary>
        /// CUSTOMS STATUS OF GOODS
        /// </summary>
        [Pos(10)]
        public CST CST { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(11)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// TRANSPORT MOVEMENT DETAILS
        /// </summary>
        [Pos(12)]
        public List<TMD> TMD { get; set; }
        /// <summary>
        /// Loop for PROCESSING INFORMATION
        /// </summary>
        [Pos(13)]
        public List<Loop_GEI_CUSCAR> GEILoop { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [Pos(14)]
        public List<Loop_QTY_CUSCAR_2> QTYLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [Group(typeof(NAD))]
    public class Loop_NAD_CUSCAR
    {
        
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Pos(1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(2)]
        public DTM DTM { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [Pos(3)]
        public List<Loop_CTA_CUSCAR> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [Group(typeof(NAD))]
    public class Loop_NAD_CUSCAR_2
    {
        
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [Pos(1)]
        public NAD NAD { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(3)]
        public List<RFF> RFF { get; set; }
        /// <summary>
        /// Loop for CONTACT INFORMATION
        /// </summary>
        [Pos(4)]
        public List<Loop_CTA_CUSCAR> CTALoop { get; set; }
    }
    
    /// <summary>
    /// Loop for QUANTITY
    /// </summary>
    [Serializable()]
    [Group(typeof(QTY))]
    public class Loop_QTY_CUSCAR
    {
        
        /// <summary>
        /// QUANTITY
        /// </summary>
        [Pos(1)]
        public QTY QTY { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(2)]
        public List<FTX> FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for QUANTITY
    /// </summary>
    [Serializable()]
    [Group(typeof(QTY))]
    public class Loop_QTY_CUSCAR_2
    {
        
        /// <summary>
        /// QUANTITY
        /// </summary>
        [Pos(1)]
        public QTY QTY { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [Pos(2)]
        public FTX FTX { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [Group(typeof(RFF))]
    public class Loop_RFF_CUSCAR
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
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [Group(typeof(RFF))]
    public class Loop_RFF_CUSCAR_2
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// CONTROL TOTAL
        /// </summary>
        [Pos(2)]
        public List<CNT> CNT { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [Pos(3)]
        public List<MOA> MOA { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(4)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// PROCESSING INFORMATION
        /// </summary>
        [Pos(5)]
        public List<GEI> GEI { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [Pos(6)]
        public List<CUX> CUX { get; set; }
        /// <summary>
        /// CHARGE PAYMENT INSTRUCTIONS
        /// </summary>
        [Pos(7)]
        public List<CPI> CPI { get; set; }
        /// <summary>
        /// Loop for TRANSPORT INFORMATION
        /// </summary>
        [Pos(8)]
        public List<Loop_TDT_CUSCAR_2> TDTLoop { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [Pos(9)]
        public List<Loop_NAD_CUSCAR_2> NADLoop { get; set; }
        /// <summary>
        /// Loop for QUANTITY
        /// </summary>
        [Pos(10)]
        public List<Loop_QTY_CUSCAR> QTYLoop { get; set; }
        /// <summary>
        /// Loop for GOODS ITEM DETAILS
        /// </summary>
        [Pos(11)]
        public List<Loop_GID_CUSCAR> GIDLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [Group(typeof(RFF))]
    public class Loop_RFF_CUSCAR_3
    {
        
        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// TRANSPORT SERVICE REQUIREMENTS
        /// </summary>
        [Pos(2)]
        public List<TSR> TSR { get; set; }
    }

    /// <summary>
    /// Loop for REFERENCE
    /// </summary>
    [Serializable()]
    [Group(typeof(RFF))]
    public class Loop_RFF_CUSCAR_4
    {

        /// <summary>
        /// REFERENCE
        /// </summary>
        [Pos(1)]
        public RFF RFF { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(2)]
        public List<LOC> LOC { get; set; }
    }

    /// <summary>
    /// Loop for TRANSPORT INFORMATION
    /// </summary>
    [Serializable()]
    [Group(typeof(TDT))]
    public class Loop_TDT_CUSCAR
    {
        
        /// <summary>
        /// TRANSPORT INFORMATION
        /// </summary>
        [Pos(1)]
        public TDT TDT { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(2)]
        public List<LOC> LOC { get; set; }
        /// <summary>
        /// DATE/TIME/PERIOD
        /// </summary>
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for TRANSPORT INFORMATION
    /// </summary>
    [Serializable()]
    [Group(typeof(TDT))]
    public class Loop_TDT_CUSCAR_2
    {
        
        /// <summary>
        /// TRANSPORT INFORMATION
        /// </summary>
        [Pos(1)]
        public TDT TDT { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [Pos(2)]
        public List<LOC> LOC { get; set; }
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
        /// Loop for REFERENCE
        /// </summary>
        [Pos(5)]
        public List<Loop_RFF_CUSCAR_3> RFFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for TEMPERATURE
    /// </summary>
    [Serializable()]
    [Group(typeof(TMP))]
    public class Loop_TMP_CUSCAR
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
    }    
}
