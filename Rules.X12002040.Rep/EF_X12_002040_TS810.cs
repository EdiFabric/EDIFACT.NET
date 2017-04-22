namespace EdiFabric.Rules.X12_002040.Rep
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using EdiFabric.Attributes;
    
    
    [M("X12", "002040", "810")]
    public class TS810
    {
        
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [S("ST", 1)]
        public ST ST { get; set; }
        /// <summary>
        /// Beginning Segment for Invoice
        /// </summary>
        [S("BIG", 2)]
        public BIG BIG { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [S("NTE", 3)]
        public List<NTE> NTE { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [S("CUR", 4)]
        public CUR CUR { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [S("REF", 5)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [S("PER", 6)]
        public List<PER> PER { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [G(7)]
        public List<TS810_N1Loop1> N1Loop1 { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [S("ITD", 8)]
        public List<ITD> ITD { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [S("DTM", 9)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [S("FOB", 10)]
        public FOB FOB { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [S("PID", 11)]
        public List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [S("MEA", 12)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [S("PWK", 13)]
        public List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [S("PKG", 14)]
        public List<PKG> PKG { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [S("L7", 15)]
        public L7 L7 { get; set; }
        /// <summary>
        /// Loop for Baseline Item Data (Invoice)
        /// </summary>
        [G(16)]
        public List<TS810_IT1Loop1> IT1Loop1 { get; set; }
        /// <summary>
        /// Total Monetary Value Summary
        /// </summary>
        [S("TDS", 17)]
        public TDS TDS { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [S("TXI", 18)]
        public List<TXI> TXI { get; set; }
        /// <summary>
        /// Carrier Detail
        /// </summary>
        [S("CAD", 19)]
        public CAD CAD { get; set; }
        /// <summary>
        /// Loop for Allowance, Charge or Service
        /// </summary>
        [G(20)]
        public List<TS810_ITALoop2> ITALoop2 { get; set; }
        /// <summary>
        /// Invoice Shipment Summary
        /// </summary>
        [S("ISS", 21)]
        public List<ISS> ISS { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [S("CTT", 22)]
        public CTT CTT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [S("SE", 23)]
        public SE SE { get; set; }
    }
    
    public class TS810_ITALoop2
    {
        
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [S("ITA", 1)]
        public ITA ITA { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [S("TXI", 2)]
        public List<TXI> TXI { get; set; }
    }
    
    public class TS810_IT1Loop1
    {
        
        /// <summary>
        /// Baseline Item Data (Invoice)
        /// </summary>
        [S("IT1", 1)]
        public IT1 IT1 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [S("CUR", 2)]
        public CUR CUR { get; set; }
        /// <summary>
        /// Additional Item Data
        /// </summary>
        [S("IT3", 3)]
        public List<IT3> IT3 { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [S("TXI", 4)]
        public List<TXI> TXI { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [S("CTP", 5)]
        public List<CTP> CTP { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [S("PID", 6)]
        public List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [S("MEA", 7)]
        public List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [S("PWK", 8)]
        public List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [S("PKG", 9)]
        public List<PKG> PKG { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [S("PO4", 10)]
        public PO4 PO4 { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [S("ITD", 11)]
        public List<ITD> ITD { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [S("REF", 12)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [S("PER", 13)]
        public List<PER> PER { get; set; }
        /// <summary>
        /// Destination Quantity
        /// </summary>
        [S("SDQ", 14)]
        public List<SDQ> SDQ { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [S("DTM", 15)]
        public List<DTM> DTM { get; set; }
        /// <summary>
        /// Carrier Detail
        /// </summary>
        [S("CAD", 16)]
        public List<CAD> CAD { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [S("L7", 17)]
        public List<L7> L7 { get; set; }
        /// <summary>
        /// Loop for Allowance, Charge or Service
        /// </summary>
        [G(18)]
        public List<TS810_ITALoop1> ITALoop1 { get; set; }
        /// <summary>
        /// Loop for Subline Item Detail
        /// </summary>
        [G(19)]
        public List<TS810_SLNLoop1> SLNLoop1 { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [G(20)]
        public List<TS810_N1Loop2> N1Loop2 { get; set; }
    }
    
    public class TS810_N1Loop2
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [S("N1", 1)]
        public N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [S("N2", 2)]
        public List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [S("N3", 3)]
        public List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [S("N4", 4)]
        public N4 N4 { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [S("REF", 5)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [S("PER", 6)]
        public List<PER> PER { get; set; }
    }
    
    public class TS810_SLNLoop1
    {
        
        /// <summary>
        /// Subline Item Detail
        /// </summary>
        [S("SLN", 1)]
        public SLN SLN { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [S("REF", 2)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [S("PID", 3)]
        public List<PID> PID { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [S("ITA", 4)]
        public List<ITA> ITA { get; set; }
    }
    
    public class TS810_ITALoop1
    {
        
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [S("ITA", 1)]
        public ITA ITA { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [S("TXI", 2)]
        public List<TXI> TXI { get; set; }
    }
    
    public class TS810_N1Loop1
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [S("N1", 1)]
        public N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [S("N2", 2)]
        public List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [S("N3", 3)]
        public List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [S("N4", 4)]
        public N4 N4 { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [S("REF", 5)]
        public List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [S("PER", 6)]
        public List<PER> PER { get; set; }
    }
}
