namespace EdiFabric.Rules.EdifactD00AINVOIC {
    using System;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class M_INVOIC {
    [XmlElement(Order=0)]
    public S_UNH S_UNH {get; set;}
    [XmlElement(Order=1)]
    public S_BGM S_BGM {get; set;}
    [XmlElement("S_DTM",Order=2)]
    public List<S_DTM> S_DTM {get; set;}
    [XmlElement(Order=3)]
    public S_PAI S_PAI {get; set;}
    [XmlElement("S_ALI",Order=4)]
    public List<S_ALI> S_ALI {get; set;}
    [XmlElement(Order=5)]
    public S_IMD S_IMD {get; set;}
    [XmlElement("S_FTX",Order=6)]
    public List<S_FTX> S_FTX {get; set;}
    [XmlElement("S_LOC",Order=7)]
    public List<S_LOC> S_LOC {get; set;}
    [XmlElement("S_GIS",Order=8)]
    public List<S_GIS> S_GIS {get; set;}
    [XmlElement(Order=9)]
    public S_DGS S_DGS {get; set;}
    [XmlElement("S_GIR",Order=10)]
    public List<S_GIR> S_GIR {get; set;}
    [XmlElement("G_RFF",Order=11)]
    public List<G_RFF> G_RFF {get; set;}
    [XmlElement("G_NAD",Order=12)]
    public List<G_NAD> G_NAD {get; set;}
    [XmlElement("G_TAX",Order=13)]
    public List<G_TAX> G_TAX {get; set;}
    [XmlElement("G_CUX",Order=14)]
    public List<G_CUX> G_CUX {get; set;}
    [XmlElement("G_PAT",Order=15)]
    public List<G_PAT> G_PAT {get; set;}
    [XmlElement("G_TDT",Order=16)]
    public List<G_TDT> G_TDT {get; set;}
    [XmlElement("G_TOD",Order=17)]
    public List<G_TOD> G_TOD {get; set;}
    [XmlElement("G_EQD",Order=18)]
    public List<G_EQD> G_EQD {get; set;}
    [XmlElement("G_PAC",Order=19)]
    public List<G_PAC> G_PAC {get; set;}
    [XmlElement("G_ALC",Order=20)]
    public List<G_ALC> G_ALC {get; set;}
    [XmlElement("G_RCS",Order=21)]
    public List<G_RCS> G_RCS {get; set;}
    [XmlElement(Order=22)]
    public G_AJT G_AJT {get; set;}
    [XmlElement(Order=23)]
    public G_INP G_INP {get; set;}
    [XmlElement("G_LIN",Order=24)]
    public List<G_LIN> G_LIN {get; set;}
    [XmlElement(Order=25)]
    public S_UNS S_UNS {get; set;}
    [XmlElement("S_CNT",Order=26)]
    public List<S_CNT> S_CNT {get; set;}
    [XmlElement("G_MOA_4",Order=27)]
    public List<G_MOA_4> G_MOA_4 {get; set;}
    [XmlElement("G_TAX_5",Order=28)]
    public List<G_TAX_5> G_TAX_5 {get; set;}
    [XmlElement("G_ALC_3",Order=29)]
    public List<G_ALC_3> G_ALC_3 {get; set;}
    [XmlElement(Order=30)]
    public S_UNT S_UNT {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_UNH {
    [XmlElement(Order=0)]
    public string D_0062_1 {get; set;}
    [XmlElement(Order=1)]
    public C_S009 C_S009 {get; set;}
    [XmlElement(Order=2)]
    public string D_0068_3 {get; set;}
    [XmlElement(Order=3)]
    public C_S010 C_S010 {get; set;}
    [XmlElement(Order=4)]
    public C_S016 C_S016 {get; set;}
    [XmlElement(Order=5)]
    public C_S017 C_S017 {get; set;}
    [XmlElement(Order=6)]
    public C_S018 C_S018 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_S009 {
    [XmlElement(Order=0)]
    public string D_0065_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_0052_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_0054_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_0051_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_0057_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_0110_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_0113_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_S010 {
    [XmlElement(Order=0)]
    public string D_0070_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_0073_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_S016 {
    [XmlElement(Order=0)]
    public string D_0115_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_0116_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_0118_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_0051_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_S017 {
    [XmlElement(Order=0)]
    public string D_0121_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_0122_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_0124_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_0051_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_S018 {
    [XmlElement(Order=0)]
    public string D_0127_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_0128_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_0130_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_0051_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_BGM {
    [XmlElement(Order=0)]
    public C_C002 C_C002 {get; set;}
    [XmlElement(Order=1)]
    public C_C106 C_C106 {get; set;}
    [XmlElement(Order=2)]
    public string D_1225_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4343_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C002 {
    [XmlElement(Order=0)]
    public string D_1001_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1000_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C106 {
    [XmlElement(Order=0)]
    public string D_1004_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1056_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1060_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM {
    [XmlElement(Order=0)]
    public C_C507 C_C507 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PAI {
    [XmlElement(Order=0)]
    public C_C534 C_C534 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C534 {
    [XmlElement(Order=0)]
    public string D_4439_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4431_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4461_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1131_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3055_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4435_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_ALI {
    [XmlElement(Order=0)]
    public string D_3239_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_9213_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4183_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4183_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4183_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4183_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_4183_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_IMD {
    [XmlElement(Order=0)]
    public string D_7077_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C272 C_C272 {get; set;}
    [XmlElement(Order=2)]
    public C_C273 C_C273 {get; set;}
    [XmlElement(Order=3)]
    public string D_7383_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C272 {
    [XmlElement(Order=0)]
    public string D_7081_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C273 {
    [XmlElement(Order=0)]
    public string D_7009_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7008_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_7008_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_3453_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FTX {
    [XmlElement(Order=0)]
    public string D_4451_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4453_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C107 C_C107 {get; set;}
    [XmlElement(Order=3)]
    public C_C108 C_C108 {get; set;}
    [XmlElement(Order=4)]
    public string D_3453_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4447_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C107 {
    [XmlElement(Order=0)]
    public string D_4441_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C108 {
    [XmlElement(Order=0)]
    public string D_4440_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4440_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4440_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4440_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4440_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517 C_C517 {get; set;}
    [XmlElement(Order=2)]
    public C_C519 C_C519 {get; set;}
    [XmlElement(Order=3)]
    public C_C553 C_C553 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_GIS {
    [XmlElement(Order=0)]
    public C_C529 C_C529 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C529 {
    [XmlElement(Order=0)]
    public string D_7365_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7187_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DGS {
    [XmlElement(Order=0)]
    public string D_8273_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C205 C_C205 {get; set;}
    [XmlElement(Order=2)]
    public C_C234 C_C234 {get; set;}
    [XmlElement(Order=3)]
    public C_C223 C_C223 {get; set;}
    [XmlElement(Order=4)]
    public string D_8339_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_8364_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_8410_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_8126_8 {get; set;}
    [XmlElement(Order=8)]
    public C_C235 C_C235 {get; set;}
    [XmlElement(Order=9)]
    public C_C236 C_C236 {get; set;}
    [XmlElement(Order=10)]
    public string D_8255_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_8325_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_8211_13 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C205 {
    [XmlElement(Order=0)]
    public string D_8351_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8078_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_8092_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C234 {
    [XmlElement(Order=0)]
    public string D_7124_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7088_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C223 {
    [XmlElement(Order=0)]
    public string D_7106_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6411_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C235 {
    [XmlElement(Order=0)]
    public string D_8158_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8186_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C236 {
    [XmlElement(Order=0)]
    public string D_8246_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8246_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_8246_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_GIR {
    [XmlElement(Order=0)]
    public string D_7297_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C206 C_C206 {get; set;}
    [XmlElement(Order=2)]
    public C_C206_2 C_C206_2 {get; set;}
    [XmlElement(Order=3)]
    public C_C206_3 C_C206_3 {get; set;}
    [XmlElement(Order=4)]
    public C_C206_4 C_C206_4 {get; set;}
    [XmlElement(Order=5)]
    public C_C206_5 C_C206_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_2 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_3 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_4 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_5 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_RFF {
    [XmlElement(Order=0)]
    public S_RFF S_RFF {get; set;}
    [XmlElement("S_DTM_2",Order=1)]
    public List<S_DTM_2> S_DTM_2 {get; set;}
    [XmlElement("S_GIR_2",Order=2)]
    public List<S_GIR_2> S_GIR_2 {get; set;}
    [XmlElement("S_LOC_2",Order=3)]
    public List<S_LOC_2> S_LOC_2 {get; set;}
    [XmlElement("S_MEA",Order=4)]
    public List<S_MEA> S_MEA {get; set;}
    [XmlElement("S_QTY",Order=5)]
    public List<S_QTY> S_QTY {get; set;}
    [XmlElement("S_FTX_2",Order=6)]
    public List<S_FTX_2> S_FTX_2 {get; set;}
    [XmlElement("S_MOA",Order=7)]
    public List<S_MOA> S_MOA {get; set;}
    [XmlElement("S_RTE",Order=8)]
    public List<S_RTE> S_RTE {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF {
    [XmlElement(Order=0)]
    public C_C506 C_C506 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_2 {
    [XmlElement(Order=0)]
    public C_C507_2 C_C507_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_2 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_GIR_2 {
    [XmlElement(Order=0)]
    public string D_7297_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C206_6 C_C206_6 {get; set;}
    [XmlElement(Order=2)]
    public C_C206_7 C_C206_7 {get; set;}
    [XmlElement(Order=3)]
    public C_C206_8 C_C206_8 {get; set;}
    [XmlElement(Order=4)]
    public C_C206_9 C_C206_9 {get; set;}
    [XmlElement(Order=5)]
    public C_C206_10 C_C206_10 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_6 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_7 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_8 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_9 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_10 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC_2 {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517_2 C_C517_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C519_2 C_C519_2 {get; set;}
    [XmlElement(Order=3)]
    public C_C553_2 C_C553_2 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517_2 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519_2 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553_2 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MEA {
    [XmlElement(Order=0)]
    public string D_6311_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C502 C_C502 {get; set;}
    [XmlElement(Order=2)]
    public C_C174 C_C174 {get; set;}
    [XmlElement(Order=3)]
    public string D_7383_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C502 {
    [XmlElement(Order=0)]
    public string D_6313_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6321_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6155_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6154_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C174 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6314_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6162_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6152_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_6432_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_QTY {
    [XmlElement(Order=0)]
    public C_C186 C_C186 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C186 {
    [XmlElement(Order=0)]
    public string D_6063_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6060_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6411_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FTX_2 {
    [XmlElement(Order=0)]
    public string D_4451_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4453_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C107_2 C_C107_2 {get; set;}
    [XmlElement(Order=3)]
    public C_C108_2 C_C108_2 {get; set;}
    [XmlElement(Order=4)]
    public string D_3453_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4447_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C107_2 {
    [XmlElement(Order=0)]
    public string D_4441_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C108_2 {
    [XmlElement(Order=0)]
    public string D_4440_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4440_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4440_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4440_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4440_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA {
    [XmlElement(Order=0)]
    public C_C516 C_C516 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RTE {
    [XmlElement(Order=0)]
    public C_C128 C_C128 {get; set;}
    [XmlElement(Order=1)]
    public string D_4405_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C128 {
    [XmlElement(Order=0)]
    public string D_5419_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5420_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_5284_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6411_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_NAD {
    [XmlElement(Order=0)]
    public S_NAD S_NAD {get; set;}
    [XmlElement("S_LOC_3",Order=1)]
    public List<S_LOC_3> S_LOC_3 {get; set;}
    [XmlElement("S_FII",Order=2)]
    public List<S_FII> S_FII {get; set;}
    [XmlElement("S_MOA_2",Order=3)]
    public List<S_MOA_2> S_MOA_2 {get; set;}
    [XmlElement("G_RFF_2",Order=4)]
    public List<G_RFF_2> G_RFF_2 {get; set;}
    [XmlElement("G_DOC",Order=5)]
    public List<G_DOC> G_DOC {get; set;}
    [XmlElement("G_CTA",Order=6)]
    public List<G_CTA> G_CTA {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_NAD {
    [XmlElement(Order=0)]
    public string D_3035_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C082 C_C082 {get; set;}
    [XmlElement(Order=2)]
    public C_C058 C_C058 {get; set;}
    [XmlElement(Order=3)]
    public C_C080 C_C080 {get; set;}
    [XmlElement(Order=4)]
    public C_C059 C_C059 {get; set;}
    [XmlElement(Order=5)]
    public string D_3164_6 {get; set;}
    [XmlElement(Order=6)]
    public C_C819 C_C819 {get; set;}
    [XmlElement(Order=7)]
    public string D_3251_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_3207_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C082 {
    [XmlElement(Order=0)]
    public string D_3039_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C058 {
    [XmlElement(Order=0)]
    public string D_3124_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3124_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3124_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3124_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3124_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C080 {
    [XmlElement(Order=0)]
    public string D_3036_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3036_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3036_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3036_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3036_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_3045_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C059 {
    [XmlElement(Order=0)]
    public string D_3042_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3042_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3042_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3042_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C819 {
    [XmlElement(Order=0)]
    public string D_3229_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3228_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC_3 {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517_3 C_C517_3 {get; set;}
    [XmlElement(Order=2)]
    public C_C519_3 C_C519_3 {get; set;}
    [XmlElement(Order=3)]
    public C_C553_3 C_C553_3 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517_3 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519_3 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553_3 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FII {
    [XmlElement(Order=0)]
    public string D_3035_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C078 C_C078 {get; set;}
    [XmlElement(Order=2)]
    public C_C088 C_C088 {get; set;}
    [XmlElement(Order=3)]
    public string D_3207_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C078 {
    [XmlElement(Order=0)]
    public string D_3194_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3192_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3192_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6345_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C088 {
    [XmlElement(Order=0)]
    public string D_3433_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3434_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1131_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_3055_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3432_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_3436_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_2 {
    [XmlElement(Order=0)]
    public C_C516_2 C_C516_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_2 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_RFF_2 {
    [XmlElement(Order=0)]
    public S_RFF_2 S_RFF_2 {get; set;}
    [XmlElement("S_DTM_3",Order=1)]
    public List<S_DTM_3> S_DTM_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF_2 {
    [XmlElement(Order=0)]
    public C_C506_2 C_C506_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506_2 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_3 {
    [XmlElement(Order=0)]
    public C_C507_3 C_C507_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_3 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_DOC {
    [XmlElement(Order=0)]
    public S_DOC S_DOC {get; set;}
    [XmlElement("S_DTM_4",Order=1)]
    public List<S_DTM_4> S_DTM_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DOC {
    [XmlElement(Order=0)]
    public C_C002_2 C_C002_2 {get; set;}
    [XmlElement(Order=1)]
    public C_C503 C_C503 {get; set;}
    [XmlElement(Order=2)]
    public string D_3153_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1220_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1218_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C002_2 {
    [XmlElement(Order=0)]
    public string D_1001_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1000_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C503 {
    [XmlElement(Order=0)]
    public string D_1004_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1373_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1366_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3453_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1056_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_1060_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_4 {
    [XmlElement(Order=0)]
    public C_C507_4 C_C507_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_4 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_CTA {
    [XmlElement(Order=0)]
    public S_CTA S_CTA {get; set;}
    [XmlElement(Order=1)]
    public List<S_COM> S_COM {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_CTA {
    [XmlElement(Order=0)]
    public string D_3139_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C056 C_C056 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C056 {
    [XmlElement(Order=0)]
    public string D_3413_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3412_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C076 {
    [XmlElement(Order=0)]
    public string D_3148_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3155_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_TAX {
    [XmlElement(Order=0)]
    public S_TAX S_TAX {get; set;}
    [XmlElement(Order=1)]
    public S_MOA_3 S_MOA_3 {get; set;}
    [XmlElement("S_LOC_4",Order=2)]
    public List<S_LOC_4> S_LOC_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_TAX {
    [XmlElement(Order=0)]
    public string D_5283_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C241 C_C241 {get; set;}
    [XmlElement(Order=2)]
    public C_C533 C_C533 {get; set;}
    [XmlElement(Order=3)]
    public string D_5286_4 {get; set;}
    [XmlElement(Order=4)]
    public C_C243 C_C243 {get; set;}
    [XmlElement(Order=5)]
    public string D_5305_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3446_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_1227_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C241 {
    [XmlElement(Order=0)]
    public string D_5153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5152_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C533 {
    [XmlElement(Order=0)]
    public string D_5289_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C243 {
    [XmlElement(Order=0)]
    public string D_5279_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5278_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_5273_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_1131_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3055_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_3 {
    [XmlElement(Order=0)]
    public C_C516_3 C_C516_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_3 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC_4 {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517_4 C_C517_4 {get; set;}
    [XmlElement(Order=2)]
    public C_C519_4 C_C519_4 {get; set;}
    [XmlElement(Order=3)]
    public C_C553_4 C_C553_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517_4 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519_4 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553_4 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_CUX {
    [XmlElement(Order=0)]
    public S_CUX S_CUX {get; set;}
    [XmlElement("S_DTM_5",Order=1)]
    public List<S_DTM_5> S_DTM_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_CUX {
    [XmlElement(Order=0)]
    public C_C504 C_C504 {get; set;}
    [XmlElement(Order=1)]
    public C_C504_2 C_C504_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_5402_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6341_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C504 {
    [XmlElement(Order=0)]
    public string D_6347_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6345_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6343_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6348_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C504_2 {
    [XmlElement(Order=0)]
    public string D_6347_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6345_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6343_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6348_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_5 {
    [XmlElement(Order=0)]
    public C_C507_5 C_C507_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_5 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_PAT {
    [XmlElement(Order=0)]
    public S_PAT S_PAT {get; set;}
    [XmlElement("S_DTM_6",Order=1)]
    public List<S_DTM_6> S_DTM_6 {get; set;}
    [XmlElement(Order=2)]
    public S_PCD S_PCD {get; set;}
    [XmlElement(Order=3)]
    public S_MOA_4 S_MOA_4 {get; set;}
    [XmlElement(Order=4)]
    public S_PAI_2 S_PAI_2 {get; set;}
    [XmlElement(Order=5)]
    public S_FII_2 S_FII_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PAT {
    [XmlElement(Order=0)]
    public string D_4279_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C110 C_C110 {get; set;}
    [XmlElement(Order=2)]
    public C_C112 C_C112 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C110 {
    [XmlElement(Order=0)]
    public string D_4277_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4276_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4276_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C112 {
    [XmlElement(Order=0)]
    public string D_2475_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2009_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2151_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_2152_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_6 {
    [XmlElement(Order=0)]
    public C_C507_6 C_C507_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_6 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PCD {
    [XmlElement(Order=0)]
    public C_C501 C_C501 {get; set;}
    [XmlElement(Order=1)]
    public string D_4405_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C501 {
    [XmlElement(Order=0)]
    public string D_5245_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5482_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_5249_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1131_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3055_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_4 {
    [XmlElement(Order=0)]
    public C_C516_4 C_C516_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_4 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PAI_2 {
    [XmlElement(Order=0)]
    public C_C534_2 C_C534_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C534_2 {
    [XmlElement(Order=0)]
    public string D_4439_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4431_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4461_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1131_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3055_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4435_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FII_2 {
    [XmlElement(Order=0)]
    public string D_3035_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C078_2 C_C078_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C088_2 C_C088_2 {get; set;}
    [XmlElement(Order=3)]
    public string D_3207_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C078_2 {
    [XmlElement(Order=0)]
    public string D_3194_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3192_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3192_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6345_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C088_2 {
    [XmlElement(Order=0)]
    public string D_3433_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3434_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1131_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_3055_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3432_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_3436_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_TDT {
    [XmlElement(Order=0)]
    public S_TDT S_TDT {get; set;}
    [XmlElement(Order=1)]
    public S_TSR S_TSR {get; set;}
    [XmlElement("G_LOC",Order=2)]
    public List<G_LOC> G_LOC {get; set;}
    [XmlElement("G_RFF_3",Order=3)]
    public List<G_RFF_3> G_RFF_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_TDT {
    [XmlElement(Order=0)]
    public string D_8051_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8028_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C220 C_C220 {get; set;}
    [XmlElement(Order=3)]
    public C_C228 C_C228 {get; set;}
    [XmlElement(Order=4)]
    public C_C040 C_C040 {get; set;}
    [XmlElement(Order=5)]
    public string D_8101_6 {get; set;}
    [XmlElement(Order=6)]
    public C_C401 C_C401 {get; set;}
    [XmlElement(Order=7)]
    public C_C222 C_C222 {get; set;}
    [XmlElement(Order=8)]
    public string D_8281_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C220 {
    [XmlElement(Order=0)]
    public string D_8067_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8066_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C228 {
    [XmlElement(Order=0)]
    public string D_8179_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8178_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C040 {
    [XmlElement(Order=0)]
    public string D_3127_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3128_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C401 {
    [XmlElement(Order=0)]
    public string D_8457_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8459_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_7130_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C222 {
    [XmlElement(Order=0)]
    public string D_8213_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_8212_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_8453_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_TSR {
    [XmlElement(Order=0)]
    public C_C536 C_C536 {get; set;}
    [XmlElement(Order=1)]
    public C_C233 C_C233 {get; set;}
    [XmlElement(Order=2)]
    public C_C537 C_C537 {get; set;}
    [XmlElement(Order=3)]
    public C_C703 C_C703 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C536 {
    [XmlElement(Order=0)]
    public string D_4065_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C233 {
    [XmlElement(Order=0)]
    public string D_7273_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7273_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1131_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_3055_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C537 {
    [XmlElement(Order=0)]
    public string D_4219_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C703 {
    [XmlElement(Order=0)]
    public string D_7085_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_LOC {
    [XmlElement(Order=0)]
    public S_LOC_5 S_LOC_5 {get; set;}
    [XmlElement("S_DTM_7",Order=1)]
    public List<S_DTM_7> S_DTM_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC_5 {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517_5 C_C517_5 {get; set;}
    [XmlElement(Order=2)]
    public C_C519_5 C_C519_5 {get; set;}
    [XmlElement(Order=3)]
    public C_C553_5 C_C553_5 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517_5 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519_5 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553_5 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_7 {
    [XmlElement(Order=0)]
    public C_C507_7 C_C507_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_7 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_RFF_3 {
    [XmlElement(Order=0)]
    public S_RFF_3 S_RFF_3 {get; set;}
    [XmlElement("S_DTM_8",Order=1)]
    public List<S_DTM_8> S_DTM_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF_3 {
    [XmlElement(Order=0)]
    public C_C506_3 C_C506_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506_3 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_8 {
    [XmlElement(Order=0)]
    public C_C507_8 C_C507_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_8 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_TOD {
    [XmlElement(Order=0)]
    public S_TOD S_TOD {get; set;}
    [XmlElement("S_LOC_6",Order=1)]
    public List<S_LOC_6> S_LOC_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_TOD {
    [XmlElement(Order=0)]
    public string D_4055_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4215_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C100 C_C100 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C100 {
    [XmlElement(Order=0)]
    public string D_4053_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4052_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4052_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC_6 {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517_6 C_C517_6 {get; set;}
    [XmlElement(Order=2)]
    public C_C519_6 C_C519_6 {get; set;}
    [XmlElement(Order=3)]
    public C_C553_6 C_C553_6 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517_6 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519_6 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553_6 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_EQD {
    [XmlElement(Order=0)]
    public S_EQD S_EQD {get; set;}
    [XmlElement("S_SEL",Order=1)]
    public List<S_SEL> S_SEL {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_EQD {
    [XmlElement(Order=0)]
    public string D_8053_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C237 C_C237 {get; set;}
    [XmlElement(Order=2)]
    public C_C224 C_C224 {get; set;}
    [XmlElement(Order=3)]
    public string D_8077_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_8249_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_8169_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C237 {
    [XmlElement(Order=0)]
    public string D_8260_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3207_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C224 {
    [XmlElement(Order=0)]
    public string D_8155_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_8154_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_SEL {
    [XmlElement(Order=0)]
    public string D_9308_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C215 C_C215 {get; set;}
    [XmlElement(Order=2)]
    public string D_4517_3 {get; set;}
    [XmlElement(Order=3)]
    public C_C208 C_C208 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C215 {
    [XmlElement(Order=0)]
    public string D_9303_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_9302_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_PAC {
    [XmlElement(Order=0)]
    public S_PAC S_PAC {get; set;}
    [XmlElement("S_MEA_2",Order=1)]
    public List<S_MEA_2> S_MEA_2 {get; set;}
    [XmlElement(Order=2)]
    public S_EQD_2 S_EQD_2 {get; set;}
    [XmlElement("G_PCI",Order=3)]
    public List<G_PCI> G_PCI {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PAC {
    [XmlElement(Order=0)]
    public string D_7224_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C531 C_C531 {get; set;}
    [XmlElement(Order=2)]
    public C_C202 C_C202 {get; set;}
    [XmlElement(Order=3)]
    public C_C402 C_C402 {get; set;}
    [XmlElement(Order=4)]
    public C_C532 C_C532 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C531 {
    [XmlElement(Order=0)]
    public string D_7075_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7233_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_7073_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C202 {
    [XmlElement(Order=0)]
    public string D_7065_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7064_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C402 {
    [XmlElement(Order=0)]
    public string D_7077_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7064_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_7143_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7064_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_7143_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C532 {
    [XmlElement(Order=0)]
    public string D_8395_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8393_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MEA_2 {
    [XmlElement(Order=0)]
    public string D_6311_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C502_2 C_C502_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C174_2 C_C174_2 {get; set;}
    [XmlElement(Order=3)]
    public string D_7383_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C502_2 {
    [XmlElement(Order=0)]
    public string D_6313_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6321_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6155_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6154_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C174_2 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6314_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6162_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6152_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_6432_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_EQD_2 {
    [XmlElement(Order=0)]
    public string D_8053_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C237_2 C_C237_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C224_2 C_C224_2 {get; set;}
    [XmlElement(Order=3)]
    public string D_8077_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_8249_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_8169_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C237_2 {
    [XmlElement(Order=0)]
    public string D_8260_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3207_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C224_2 {
    [XmlElement(Order=0)]
    public string D_8155_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_8154_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_PCI {
    [XmlElement(Order=0)]
    public S_PCI S_PCI {get; set;}
    [XmlElement(Order=1)]
    public S_RFF_4 S_RFF_4 {get; set;}
    [XmlElement("S_DTM_9",Order=2)]
    public List<S_DTM_9> S_DTM_9 {get; set;}
    [XmlElement("S_GIN",Order=3)]
    public List<S_GIN> S_GIN {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PCI {
    [XmlElement(Order=0)]
    public string D_4233_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C210 C_C210 {get; set;}
    [XmlElement(Order=2)]
    public string D_8275_3 {get; set;}
    [XmlElement(Order=3)]
    public C_C827 C_C827 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C210 {
    [XmlElement(Order=0)]
    public string D_7102_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7102_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_7102_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7102_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_7102_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_7102_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_7102_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_7102_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_7102_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_7102_10 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C827 {
    [XmlElement(Order=0)]
    public string D_7511_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF_4 {
    [XmlElement(Order=0)]
    public C_C506_4 C_C506_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506_4 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_9 {
    [XmlElement(Order=0)]
    public C_C507_9 C_C507_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_9 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_GIN {
    [XmlElement(Order=0)]
    public string D_7405_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C208_2 C_C208_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C208_3 C_C208_3 {get; set;}
    [XmlElement(Order=3)]
    public C_C208_4 C_C208_4 {get; set;}
    [XmlElement(Order=4)]
    public C_C208_5 C_C208_5 {get; set;}
    [XmlElement(Order=5)]
    public C_C208_6 C_C208_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_2 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_3 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_4 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_5 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_6 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_ALC {
    [XmlElement(Order=0)]
    public S_ALC S_ALC {get; set;}
    [XmlElement("S_ALI_2",Order=1)]
    public List<S_ALI_2> S_ALI_2 {get; set;}
    [XmlElement(Order=2)]
    public S_FTX_3 S_FTX_3 {get; set;}
    [XmlElement("G_RFF_4",Order=3)]
    public List<G_RFF_4> G_RFF_4 {get; set;}
    [XmlElement(Order=4)]
    public G_QTY G_QTY {get; set;}
    [XmlElement(Order=5)]
    public G_PCD G_PCD {get; set;}
    [XmlElement("G_MOA",Order=6)]
    public List<G_MOA> G_MOA {get; set;}
    [XmlElement(Order=7)]
    public G_RTE G_RTE {get; set;}
    [XmlElement("G_TAX_2",Order=8)]
    public List<G_TAX_2> G_TAX_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_ALC {
    [XmlElement(Order=0)]
    public string D_5463_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C552 C_C552 {get; set;}
    [XmlElement(Order=2)]
    public string D_4471_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1227_4 {get; set;}
    [XmlElement(Order=4)]
    public C_C214 C_C214 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C552 {
    [XmlElement(Order=0)]
    public string D_1230_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5189_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C214 {
    [XmlElement(Order=0)]
    public string D_7161_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7160_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_7160_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_ALI_2 {
    [XmlElement(Order=0)]
    public string D_3239_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_9213_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4183_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4183_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4183_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4183_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_4183_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FTX_3 {
    [XmlElement(Order=0)]
    public string D_4451_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4453_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C107_3 C_C107_3 {get; set;}
    [XmlElement(Order=3)]
    public C_C108_3 C_C108_3 {get; set;}
    [XmlElement(Order=4)]
    public string D_3453_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4447_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C107_3 {
    [XmlElement(Order=0)]
    public string D_4441_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C108_3 {
    [XmlElement(Order=0)]
    public string D_4440_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4440_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4440_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4440_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4440_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_RFF_4 {
    [XmlElement(Order=0)]
    public S_RFF_5 S_RFF_5 {get; set;}
    [XmlElement("S_DTM_10",Order=1)]
    public List<S_DTM_10> S_DTM_10 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF_5 {
    [XmlElement(Order=0)]
    public C_C506_5 C_C506_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506_5 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_10 {
    [XmlElement(Order=0)]
    public C_C507_10 C_C507_10 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_10 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_QTY {
    [XmlElement(Order=0)]
    public S_QTY_2 S_QTY_2 {get; set;}
    [XmlElement(Order=1)]
    public S_RNG S_RNG {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_QTY_2 {
    [XmlElement(Order=0)]
    public C_C186_2 C_C186_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C186_2 {
    [XmlElement(Order=0)]
    public string D_6063_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6060_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6411_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RNG {
    [XmlElement(Order=0)]
    public string D_6167_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C280 C_C280 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C280 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6162_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6152_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_PCD {
    [XmlElement(Order=0)]
    public S_PCD_2 S_PCD_2 {get; set;}
    [XmlElement(Order=1)]
    public S_RNG_2 S_RNG_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PCD_2 {
    [XmlElement(Order=0)]
    public C_C501_2 C_C501_2 {get; set;}
    [XmlElement(Order=1)]
    public string D_4405_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C501_2 {
    [XmlElement(Order=0)]
    public string D_5245_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5482_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_5249_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1131_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3055_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RNG_2 {
    [XmlElement(Order=0)]
    public string D_6167_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C280_2 C_C280_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C280_2 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6162_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6152_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_MOA {
    [XmlElement(Order=0)]
    public S_MOA_5 S_MOA_5 {get; set;}
    [XmlElement(Order=1)]
    public S_RNG_3 S_RNG_3 {get; set;}
    [XmlElement(Order=2)]
    public S_CUX_2 S_CUX_2 {get; set;}
    [XmlElement(Order=3)]
    public S_DTM_11 S_DTM_11 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_5 {
    [XmlElement(Order=0)]
    public C_C516_5 C_C516_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_5 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RNG_3 {
    [XmlElement(Order=0)]
    public string D_6167_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C280_3 C_C280_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C280_3 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6162_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6152_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_CUX_2 {
    [XmlElement(Order=0)]
    public C_C504_3 C_C504_3 {get; set;}
    [XmlElement(Order=1)]
    public C_C504_4 C_C504_4 {get; set;}
    [XmlElement(Order=2)]
    public string D_5402_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6341_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C504_3 {
    [XmlElement(Order=0)]
    public string D_6347_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6345_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6343_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6348_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C504_4 {
    [XmlElement(Order=0)]
    public string D_6347_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6345_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6343_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6348_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_11 {
    [XmlElement(Order=0)]
    public C_C507_11 C_C507_11 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_11 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_RTE {
    [XmlElement(Order=0)]
    public S_RTE_2 S_RTE_2 {get; set;}
    [XmlElement(Order=1)]
    public S_RNG_4 S_RNG_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RTE_2 {
    [XmlElement(Order=0)]
    public C_C128_2 C_C128_2 {get; set;}
    [XmlElement(Order=1)]
    public string D_4405_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C128_2 {
    [XmlElement(Order=0)]
    public string D_5419_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5420_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_5284_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6411_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RNG_4 {
    [XmlElement(Order=0)]
    public string D_6167_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C280_4 C_C280_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C280_4 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6162_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6152_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_TAX_2 {
    [XmlElement(Order=0)]
    public S_TAX_2 S_TAX_2 {get; set;}
    [XmlElement(Order=1)]
    public S_MOA_6 S_MOA_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_TAX_2 {
    [XmlElement(Order=0)]
    public string D_5283_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C241_2 C_C241_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C533_2 C_C533_2 {get; set;}
    [XmlElement(Order=3)]
    public string D_5286_4 {get; set;}
    [XmlElement(Order=4)]
    public C_C243_2 C_C243_2 {get; set;}
    [XmlElement(Order=5)]
    public string D_5305_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3446_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_1227_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C241_2 {
    [XmlElement(Order=0)]
    public string D_5153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5152_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C533_2 {
    [XmlElement(Order=0)]
    public string D_5289_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C243_2 {
    [XmlElement(Order=0)]
    public string D_5279_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5278_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_5273_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_1131_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3055_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_6 {
    [XmlElement(Order=0)]
    public C_C516_6 C_C516_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_6 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_RCS {
    [XmlElement(Order=0)]
    public S_RCS S_RCS {get; set;}
    [XmlElement("S_RFF_6",Order=1)]
    public List<S_RFF_6> S_RFF_6 {get; set;}
    [XmlElement("S_DTM_12",Order=2)]
    public List<S_DTM_12> S_DTM_12 {get; set;}
    [XmlElement("S_FTX_4",Order=3)]
    public List<S_FTX_4> S_FTX_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RCS {
    [XmlElement(Order=0)]
    public string D_7293_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C550 C_C550 {get; set;}
    [XmlElement(Order=2)]
    public string D_1229_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3207_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C550 {
    [XmlElement(Order=0)]
    public string D_7295_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7294_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF_6 {
    [XmlElement(Order=0)]
    public C_C506_6 C_C506_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506_6 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_12 {
    [XmlElement(Order=0)]
    public C_C507_12 C_C507_12 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_12 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FTX_4 {
    [XmlElement(Order=0)]
    public string D_4451_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4453_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C107_4 C_C107_4 {get; set;}
    [XmlElement(Order=3)]
    public C_C108_4 C_C108_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3453_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4447_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C107_4 {
    [XmlElement(Order=0)]
    public string D_4441_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C108_4 {
    [XmlElement(Order=0)]
    public string D_4440_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4440_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4440_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4440_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4440_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_AJT {
    [XmlElement(Order=0)]
    public S_AJT S_AJT {get; set;}
    [XmlElement("S_FTX_5",Order=1)]
    public List<S_FTX_5> S_FTX_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_AJT {
    [XmlElement(Order=0)]
    public string D_4465_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1082_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FTX_5 {
    [XmlElement(Order=0)]
    public string D_4451_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4453_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C107_5 C_C107_5 {get; set;}
    [XmlElement(Order=3)]
    public C_C108_5 C_C108_5 {get; set;}
    [XmlElement(Order=4)]
    public string D_3453_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4447_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C107_5 {
    [XmlElement(Order=0)]
    public string D_4441_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C108_5 {
    [XmlElement(Order=0)]
    public string D_4440_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4440_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4440_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4440_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4440_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_INP {
    [XmlElement(Order=0)]
    public S_INP S_INP {get; set;}
    [XmlElement("S_FTX_6",Order=1)]
    public List<S_FTX_6> S_FTX_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_INP {
    [XmlElement(Order=0)]
    public C_C849 C_C849 {get; set;}
    [XmlElement(Order=1)]
    public C_C522 C_C522 {get; set;}
    [XmlElement(Order=2)]
    public C_C850 C_C850 {get; set;}
    [XmlElement(Order=3)]
    public string D_1229_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C849 {
    [XmlElement(Order=0)]
    public string D_3301_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3285_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C522 {
    [XmlElement(Order=0)]
    public string D_4403_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4401_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1131_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3055_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4400_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C850 {
    [XmlElement(Order=0)]
    public string D_4405_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3036_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FTX_6 {
    [XmlElement(Order=0)]
    public string D_4451_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4453_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C107_6 C_C107_6 {get; set;}
    [XmlElement(Order=3)]
    public C_C108_6 C_C108_6 {get; set;}
    [XmlElement(Order=4)]
    public string D_3453_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4447_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C107_6 {
    [XmlElement(Order=0)]
    public string D_4441_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C108_6 {
    [XmlElement(Order=0)]
    public string D_4440_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4440_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4440_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4440_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4440_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_LIN {
    [XmlElement(Order=0)]
    public S_LIN S_LIN {get; set;}
    [XmlElement("S_PIA",Order=1)]
    public List<S_PIA> S_PIA {get; set;}
    [XmlElement("S_IMD_2",Order=2)]
    public List<S_IMD_2> S_IMD_2 {get; set;}
    [XmlElement("S_MEA_3",Order=3)]
    public List<S_MEA_3> S_MEA_3 {get; set;}
    [XmlElement("S_QTY_3",Order=4)]
    public List<S_QTY_3> S_QTY_3 {get; set;}
    [XmlElement(Order=5)]
    public S_PCD_3 S_PCD_3 {get; set;}
    [XmlElement("S_ALI_3",Order=6)]
    public List<S_ALI_3> S_ALI_3 {get; set;}
    [XmlElement("S_DTM_13",Order=7)]
    public List<S_DTM_13> S_DTM_13 {get; set;}
    [XmlElement("S_GIN_2",Order=8)]
    public List<S_GIN_2> S_GIN_2 {get; set;}
    [XmlElement("S_GIR_3",Order=9)]
    public List<S_GIR_3> S_GIR_3 {get; set;}
    [XmlElement(Order=10)]
    public S_QVR S_QVR {get; set;}
    [XmlElement(Order=11)]
    public S_EQD_3 S_EQD_3 {get; set;}
    [XmlElement("S_FTX_7",Order=12)]
    public List<S_FTX_7> S_FTX_7 {get; set;}
    [XmlElement(Order=13)]
    public S_DGS_2 S_DGS_2 {get; set;}
    [XmlElement("G_MOA_2",Order=14)]
    public List<G_MOA_2> G_MOA_2 {get; set;}
    [XmlElement("G_PAT_2",Order=15)]
    public List<G_PAT_2> G_PAT_2 {get; set;}
    [XmlElement("G_PRI",Order=16)]
    public List<G_PRI> G_PRI {get; set;}
    [XmlElement("G_RFF_5",Order=17)]
    public List<G_RFF_5> G_RFF_5 {get; set;}
    [XmlElement("G_PAC_2",Order=18)]
    public List<G_PAC_2> G_PAC_2 {get; set;}
    [XmlElement("G_LOC_2",Order=19)]
    public List<G_LOC_2> G_LOC_2 {get; set;}
    [XmlElement("G_TAX_3",Order=20)]
    public List<G_TAX_3> G_TAX_3 {get; set;}
    [XmlElement("G_NAD_2",Order=21)]
    public List<G_NAD_2> G_NAD_2 {get; set;}
    [XmlElement("G_ALC_2",Order=22)]
    public List<G_ALC_2> G_ALC_2 {get; set;}
    [XmlElement("G_TDT_2",Order=23)]
    public List<G_TDT_2> G_TDT_2 {get; set;}
    [XmlElement("G_TOD_2",Order=24)]
    public List<G_TOD_2> G_TOD_2 {get; set;}
    [XmlElement("G_RCS_2",Order=25)]
    public List<G_RCS_2> G_RCS_2 {get; set;}
    [XmlElement("G_GIS",Order=26)]
    public List<G_GIS> G_GIS {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LIN {
    [XmlElement(Order=0)]
    public string D_1082_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1229_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C212 C_C212 {get; set;}
    [XmlElement(Order=3)]
    public C_C829 C_C829 {get; set;}
    [XmlElement(Order=4)]
    public string D_1222_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_7083_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C212 {
    [XmlElement(Order=0)]
    public string D_7140_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7143_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1131_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3055_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C829 {
    [XmlElement(Order=0)]
    public string D_5495_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1082_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PIA {
    [XmlElement(Order=0)]
    public string D_4347_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C212_2 C_C212_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C212_3 C_C212_3 {get; set;}
    [XmlElement(Order=3)]
    public C_C212_4 C_C212_4 {get; set;}
    [XmlElement(Order=4)]
    public C_C212_5 C_C212_5 {get; set;}
    [XmlElement(Order=5)]
    public C_C212_6 C_C212_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C212_2 {
    [XmlElement(Order=0)]
    public string D_7140_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7143_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1131_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3055_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C212_3 {
    [XmlElement(Order=0)]
    public string D_7140_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7143_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1131_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3055_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C212_4 {
    [XmlElement(Order=0)]
    public string D_7140_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7143_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1131_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3055_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C212_5 {
    [XmlElement(Order=0)]
    public string D_7140_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7143_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1131_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3055_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C212_6 {
    [XmlElement(Order=0)]
    public string D_7140_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7143_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1131_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3055_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_IMD_2 {
    [XmlElement(Order=0)]
    public string D_7077_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C272_2 C_C272_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C273_2 C_C273_2 {get; set;}
    [XmlElement(Order=3)]
    public string D_7383_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C272_2 {
    [XmlElement(Order=0)]
    public string D_7081_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C273_2 {
    [XmlElement(Order=0)]
    public string D_7009_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7008_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_7008_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_3453_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MEA_3 {
    [XmlElement(Order=0)]
    public string D_6311_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C502_3 C_C502_3 {get; set;}
    [XmlElement(Order=2)]
    public C_C174_3 C_C174_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7383_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C502_3 {
    [XmlElement(Order=0)]
    public string D_6313_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6321_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6155_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6154_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C174_3 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6314_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6162_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6152_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_6432_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_QTY_3 {
    [XmlElement(Order=0)]
    public C_C186_3 C_C186_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C186_3 {
    [XmlElement(Order=0)]
    public string D_6063_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6060_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6411_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PCD_3 {
    [XmlElement(Order=0)]
    public C_C501_3 C_C501_3 {get; set;}
    [XmlElement(Order=1)]
    public string D_4405_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C501_3 {
    [XmlElement(Order=0)]
    public string D_5245_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5482_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_5249_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1131_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3055_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_ALI_3 {
    [XmlElement(Order=0)]
    public string D_3239_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_9213_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4183_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4183_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4183_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4183_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_4183_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_13 {
    [XmlElement(Order=0)]
    public C_C507_13 C_C507_13 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_13 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_GIN_2 {
    [XmlElement(Order=0)]
    public string D_7405_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C208_7 C_C208_7 {get; set;}
    [XmlElement(Order=2)]
    public C_C208_8 C_C208_8 {get; set;}
    [XmlElement(Order=3)]
    public C_C208_9 C_C208_9 {get; set;}
    [XmlElement(Order=4)]
    public C_C208_10 C_C208_10 {get; set;}
    [XmlElement(Order=5)]
    public C_C208_11 C_C208_11 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_7 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_8 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_9 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_10 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_11 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_GIR_3 {
    [XmlElement(Order=0)]
    public string D_7297_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C206_11 C_C206_11 {get; set;}
    [XmlElement(Order=2)]
    public C_C206_12 C_C206_12 {get; set;}
    [XmlElement(Order=3)]
    public C_C206_13 C_C206_13 {get; set;}
    [XmlElement(Order=4)]
    public C_C206_14 C_C206_14 {get; set;}
    [XmlElement(Order=5)]
    public C_C206_15 C_C206_15 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_11 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_12 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_13 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_14 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_15 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_QVR {
    [XmlElement(Order=0)]
    public C_C279 C_C279 {get; set;}
    [XmlElement(Order=1)]
    public string D_4221_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C960 C_C960 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C279 {
    [XmlElement(Order=0)]
    public string D_6064_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6063_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C960 {
    [XmlElement(Order=0)]
    public string D_4295_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4294_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_EQD_3 {
    [XmlElement(Order=0)]
    public string D_8053_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C237_3 C_C237_3 {get; set;}
    [XmlElement(Order=2)]
    public C_C224_3 C_C224_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_8077_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_8249_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_8169_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C237_3 {
    [XmlElement(Order=0)]
    public string D_8260_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3207_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C224_3 {
    [XmlElement(Order=0)]
    public string D_8155_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_8154_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FTX_7 {
    [XmlElement(Order=0)]
    public string D_4451_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4453_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C107_7 C_C107_7 {get; set;}
    [XmlElement(Order=3)]
    public C_C108_7 C_C108_7 {get; set;}
    [XmlElement(Order=4)]
    public string D_3453_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4447_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C107_7 {
    [XmlElement(Order=0)]
    public string D_4441_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C108_7 {
    [XmlElement(Order=0)]
    public string D_4440_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4440_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4440_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4440_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4440_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DGS_2 {
    [XmlElement(Order=0)]
    public string D_8273_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C205_2 C_C205_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C234_2 C_C234_2 {get; set;}
    [XmlElement(Order=3)]
    public C_C223_2 C_C223_2 {get; set;}
    [XmlElement(Order=4)]
    public string D_8339_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_8364_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_8410_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_8126_8 {get; set;}
    [XmlElement(Order=8)]
    public C_C235_2 C_C235_2 {get; set;}
    [XmlElement(Order=9)]
    public C_C236_2 C_C236_2 {get; set;}
    [XmlElement(Order=10)]
    public string D_8255_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_8325_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_8211_13 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C205_2 {
    [XmlElement(Order=0)]
    public string D_8351_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8078_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_8092_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C234_2 {
    [XmlElement(Order=0)]
    public string D_7124_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7088_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C223_2 {
    [XmlElement(Order=0)]
    public string D_7106_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6411_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C235_2 {
    [XmlElement(Order=0)]
    public string D_8158_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8186_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C236_2 {
    [XmlElement(Order=0)]
    public string D_8246_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8246_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_8246_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_MOA_2 {
    [XmlElement(Order=0)]
    public S_MOA_7 S_MOA_7 {get; set;}
    [XmlElement(Order=1)]
    public S_CUX_3 S_CUX_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_7 {
    [XmlElement(Order=0)]
    public C_C516_7 C_C516_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_7 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_CUX_3 {
    [XmlElement(Order=0)]
    public C_C504_5 C_C504_5 {get; set;}
    [XmlElement(Order=1)]
    public C_C504_6 C_C504_6 {get; set;}
    [XmlElement(Order=2)]
    public string D_5402_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6341_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C504_5 {
    [XmlElement(Order=0)]
    public string D_6347_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6345_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6343_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6348_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C504_6 {
    [XmlElement(Order=0)]
    public string D_6347_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6345_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6343_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6348_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_PAT_2 {
    [XmlElement(Order=0)]
    public S_PAT_2 S_PAT_2 {get; set;}
    [XmlElement("S_DTM_14",Order=1)]
    public List<S_DTM_14> S_DTM_14 {get; set;}
    [XmlElement("S_PCD_4",Order=2)]
    public List<S_PCD_4> S_PCD_4 {get; set;}
    [XmlElement(Order=3)]
    public S_MOA_8 S_MOA_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PAT_2 {
    [XmlElement(Order=0)]
    public string D_4279_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C110_2 C_C110_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C112_2 C_C112_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C110_2 {
    [XmlElement(Order=0)]
    public string D_4277_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4276_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4276_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C112_2 {
    [XmlElement(Order=0)]
    public string D_2475_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2009_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2151_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_2152_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_14 {
    [XmlElement(Order=0)]
    public C_C507_14 C_C507_14 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_14 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PCD_4 {
    [XmlElement(Order=0)]
    public C_C501_4 C_C501_4 {get; set;}
    [XmlElement(Order=1)]
    public string D_4405_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C501_4 {
    [XmlElement(Order=0)]
    public string D_5245_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5482_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_5249_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1131_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3055_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_8 {
    [XmlElement(Order=0)]
    public C_C516_8 C_C516_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_8 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_PRI {
    [XmlElement(Order=0)]
    public S_PRI S_PRI {get; set;}
    [XmlElement(Order=1)]
    public S_CUX_4 S_CUX_4 {get; set;}
    [XmlElement(Order=2)]
    public S_APR S_APR {get; set;}
    [XmlElement(Order=3)]
    public S_RNG_5 S_RNG_5 {get; set;}
    [XmlElement("S_DTM_15",Order=4)]
    public List<S_DTM_15> S_DTM_15 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PRI {
    [XmlElement(Order=0)]
    public C_C509 C_C509 {get; set;}
    [XmlElement(Order=1)]
    public string D_5213_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C509 {
    [XmlElement(Order=0)]
    public string D_5125_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5118_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_5375_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5387_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_5284_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_6411_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_CUX_4 {
    [XmlElement(Order=0)]
    public C_C504_7 C_C504_7 {get; set;}
    [XmlElement(Order=1)]
    public C_C504_8 C_C504_8 {get; set;}
    [XmlElement(Order=2)]
    public string D_5402_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6341_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C504_7 {
    [XmlElement(Order=0)]
    public string D_6347_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6345_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6343_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6348_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C504_8 {
    [XmlElement(Order=0)]
    public string D_6347_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6345_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6343_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6348_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_APR {
    [XmlElement(Order=0)]
    public string D_4043_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C138 C_C138 {get; set;}
    [XmlElement(Order=2)]
    public C_C960_2 C_C960_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C138 {
    [XmlElement(Order=0)]
    public string D_5394_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5393_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C960_2 {
    [XmlElement(Order=0)]
    public string D_4295_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4294_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RNG_5 {
    [XmlElement(Order=0)]
    public string D_6167_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C280_5 C_C280_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C280_5 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6162_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6152_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_15 {
    [XmlElement(Order=0)]
    public C_C507_15 C_C507_15 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_15 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_RFF_5 {
    [XmlElement(Order=0)]
    public S_RFF_7 S_RFF_7 {get; set;}
    [XmlElement("S_DTM_16",Order=1)]
    public List<S_DTM_16> S_DTM_16 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF_7 {
    [XmlElement(Order=0)]
    public C_C506_7 C_C506_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506_7 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_16 {
    [XmlElement(Order=0)]
    public C_C507_16 C_C507_16 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_16 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_PAC_2 {
    [XmlElement(Order=0)]
    public S_PAC_2 S_PAC_2 {get; set;}
    [XmlElement("S_MEA_4",Order=1)]
    public List<S_MEA_4> S_MEA_4 {get; set;}
    [XmlElement(Order=2)]
    public S_EQD_4 S_EQD_4 {get; set;}
    [XmlElement("G_PCI_2",Order=3)]
    public List<G_PCI_2> G_PCI_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PAC_2 {
    [XmlElement(Order=0)]
    public string D_7224_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C531_2 C_C531_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C202_2 C_C202_2 {get; set;}
    [XmlElement(Order=3)]
    public C_C402_2 C_C402_2 {get; set;}
    [XmlElement(Order=4)]
    public C_C532_2 C_C532_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C531_2 {
    [XmlElement(Order=0)]
    public string D_7075_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7233_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_7073_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C202_2 {
    [XmlElement(Order=0)]
    public string D_7065_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7064_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C402_2 {
    [XmlElement(Order=0)]
    public string D_7077_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7064_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_7143_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7064_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_7143_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C532_2 {
    [XmlElement(Order=0)]
    public string D_8395_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8393_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MEA_4 {
    [XmlElement(Order=0)]
    public string D_6311_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C502_4 C_C502_4 {get; set;}
    [XmlElement(Order=2)]
    public C_C174_4 C_C174_4 {get; set;}
    [XmlElement(Order=3)]
    public string D_7383_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C502_4 {
    [XmlElement(Order=0)]
    public string D_6313_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6321_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6155_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6154_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C174_4 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6314_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6162_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6152_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_6432_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_EQD_4 {
    [XmlElement(Order=0)]
    public string D_8053_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C237_4 C_C237_4 {get; set;}
    [XmlElement(Order=2)]
    public C_C224_4 C_C224_4 {get; set;}
    [XmlElement(Order=3)]
    public string D_8077_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_8249_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_8169_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C237_4 {
    [XmlElement(Order=0)]
    public string D_8260_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3207_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C224_4 {
    [XmlElement(Order=0)]
    public string D_8155_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_8154_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_PCI_2 {
    [XmlElement(Order=0)]
    public S_PCI_2 S_PCI_2 {get; set;}
    [XmlElement(Order=1)]
    public S_RFF_8 S_RFF_8 {get; set;}
    [XmlElement("S_DTM_17",Order=2)]
    public List<S_DTM_17> S_DTM_17 {get; set;}
    [XmlElement("S_GIN_3",Order=3)]
    public List<S_GIN_3> S_GIN_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PCI_2 {
    [XmlElement(Order=0)]
    public string D_4233_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C210_2 C_C210_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_8275_3 {get; set;}
    [XmlElement(Order=3)]
    public C_C827_2 C_C827_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C210_2 {
    [XmlElement(Order=0)]
    public string D_7102_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7102_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_7102_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7102_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_7102_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_7102_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_7102_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_7102_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_7102_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_7102_10 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C827_2 {
    [XmlElement(Order=0)]
    public string D_7511_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF_8 {
    [XmlElement(Order=0)]
    public C_C506_8 C_C506_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506_8 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_17 {
    [XmlElement(Order=0)]
    public C_C507_17 C_C507_17 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_17 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_GIN_3 {
    [XmlElement(Order=0)]
    public string D_7405_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C208_12 C_C208_12 {get; set;}
    [XmlElement(Order=2)]
    public C_C208_13 C_C208_13 {get; set;}
    [XmlElement(Order=3)]
    public C_C208_14 C_C208_14 {get; set;}
    [XmlElement(Order=4)]
    public C_C208_15 C_C208_15 {get; set;}
    [XmlElement(Order=5)]
    public C_C208_16 C_C208_16 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_12 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_13 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_14 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_15 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C208_16 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7402_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_LOC_2 {
    [XmlElement(Order=0)]
    public S_LOC_7 S_LOC_7 {get; set;}
    [XmlElement("S_QTY_4",Order=1)]
    public List<S_QTY_4> S_QTY_4 {get; set;}
    [XmlElement("S_DTM_18",Order=2)]
    public List<S_DTM_18> S_DTM_18 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC_7 {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517_7 C_C517_7 {get; set;}
    [XmlElement(Order=2)]
    public C_C519_7 C_C519_7 {get; set;}
    [XmlElement(Order=3)]
    public C_C553_7 C_C553_7 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517_7 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519_7 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553_7 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_QTY_4 {
    [XmlElement(Order=0)]
    public C_C186_4 C_C186_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C186_4 {
    [XmlElement(Order=0)]
    public string D_6063_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6060_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6411_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_18 {
    [XmlElement(Order=0)]
    public C_C507_18 C_C507_18 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_18 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_TAX_3 {
    [XmlElement(Order=0)]
    public S_TAX_3 S_TAX_3 {get; set;}
    [XmlElement("S_MOA_9",Order=1)]
    public List<S_MOA_9> S_MOA_9 {get; set;}
    [XmlElement("S_LOC_8",Order=2)]
    public List<S_LOC_8> S_LOC_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_TAX_3 {
    [XmlElement(Order=0)]
    public string D_5283_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C241_3 C_C241_3 {get; set;}
    [XmlElement(Order=2)]
    public C_C533_3 C_C533_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5286_4 {get; set;}
    [XmlElement(Order=4)]
    public C_C243_3 C_C243_3 {get; set;}
    [XmlElement(Order=5)]
    public string D_5305_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3446_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_1227_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C241_3 {
    [XmlElement(Order=0)]
    public string D_5153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5152_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C533_3 {
    [XmlElement(Order=0)]
    public string D_5289_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C243_3 {
    [XmlElement(Order=0)]
    public string D_5279_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5278_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_5273_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_1131_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3055_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_9 {
    [XmlElement(Order=0)]
    public C_C516_9 C_C516_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_9 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC_8 {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517_8 C_C517_8 {get; set;}
    [XmlElement(Order=2)]
    public C_C519_8 C_C519_8 {get; set;}
    [XmlElement(Order=3)]
    public C_C553_8 C_C553_8 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517_8 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519_8 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553_8 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_NAD_2 {
    [XmlElement(Order=0)]
    public S_NAD_2 S_NAD_2 {get; set;}
    [XmlElement("S_LOC_9",Order=1)]
    public List<S_LOC_9> S_LOC_9 {get; set;}
    [XmlElement("S_FII_3",Order=2)]
    public List<S_FII_3> S_FII_3 {get; set;}
    [XmlElement("G_RFF_6",Order=3)]
    public List<G_RFF_6> G_RFF_6 {get; set;}
    [XmlElement("G_DOC_2",Order=4)]
    public List<G_DOC_2> G_DOC_2 {get; set;}
    [XmlElement("G_CTA_2",Order=5)]
    public List<G_CTA_2> G_CTA_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_NAD_2 {
    [XmlElement(Order=0)]
    public string D_3035_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C082_2 C_C082_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C058_2 C_C058_2 {get; set;}
    [XmlElement(Order=3)]
    public C_C080_2 C_C080_2 {get; set;}
    [XmlElement(Order=4)]
    public C_C059_2 C_C059_2 {get; set;}
    [XmlElement(Order=5)]
    public string D_3164_6 {get; set;}
    [XmlElement(Order=6)]
    public C_C819_2 C_C819_2 {get; set;}
    [XmlElement(Order=7)]
    public string D_3251_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_3207_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C082_2 {
    [XmlElement(Order=0)]
    public string D_3039_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C058_2 {
    [XmlElement(Order=0)]
    public string D_3124_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3124_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3124_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3124_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3124_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C080_2 {
    [XmlElement(Order=0)]
    public string D_3036_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3036_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3036_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3036_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3036_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_3045_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C059_2 {
    [XmlElement(Order=0)]
    public string D_3042_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3042_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3042_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3042_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C819_2 {
    [XmlElement(Order=0)]
    public string D_3229_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3228_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC_9 {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517_9 C_C517_9 {get; set;}
    [XmlElement(Order=2)]
    public C_C519_9 C_C519_9 {get; set;}
    [XmlElement(Order=3)]
    public C_C553_9 C_C553_9 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517_9 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519_9 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553_9 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FII_3 {
    [XmlElement(Order=0)]
    public string D_3035_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C078_3 C_C078_3 {get; set;}
    [XmlElement(Order=2)]
    public C_C088_3 C_C088_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3207_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C078_3 {
    [XmlElement(Order=0)]
    public string D_3194_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3192_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3192_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6345_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C088_3 {
    [XmlElement(Order=0)]
    public string D_3433_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3434_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1131_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_3055_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3432_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_3436_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_RFF_6 {
    [XmlElement(Order=0)]
    public S_RFF_9 S_RFF_9 {get; set;}
    [XmlElement("S_DTM_19",Order=1)]
    public List<S_DTM_19> S_DTM_19 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF_9 {
    [XmlElement(Order=0)]
    public C_C506_9 C_C506_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506_9 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_19 {
    [XmlElement(Order=0)]
    public C_C507_19 C_C507_19 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_19 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_DOC_2 {
    [XmlElement(Order=0)]
    public S_DOC_2 S_DOC_2 {get; set;}
    [XmlElement("S_DTM_20",Order=1)]
    public List<S_DTM_20> S_DTM_20 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DOC_2 {
    [XmlElement(Order=0)]
    public C_C002_3 C_C002_3 {get; set;}
    [XmlElement(Order=1)]
    public C_C503_2 C_C503_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3153_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1220_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1218_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C002_3 {
    [XmlElement(Order=0)]
    public string D_1001_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1000_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C503_2 {
    [XmlElement(Order=0)]
    public string D_1004_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1373_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1366_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3453_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1056_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_1060_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_20 {
    [XmlElement(Order=0)]
    public C_C507_20 C_C507_20 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_20 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_CTA_2 {
    [XmlElement(Order=0)]
    public S_CTA_2 S_CTA_2 {get; set;}
    [XmlElement(Order=1)]
    public List<S_COM_2> S_COM_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_CTA_2 {
    [XmlElement(Order=0)]
    public string D_3139_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C056_2 C_C056_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C056_2 {
    [XmlElement(Order=0)]
    public string D_3413_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3412_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C076_2 {
    [XmlElement(Order=0)]
    public string D_3148_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3155_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_ALC_2 {
    [XmlElement(Order=0)]
    public S_ALC_2 S_ALC_2 {get; set;}
    [XmlElement("S_ALI_4",Order=1)]
    public List<S_ALI_4> S_ALI_4 {get; set;}
    [XmlElement("S_DTM_21",Order=2)]
    public List<S_DTM_21> S_DTM_21 {get; set;}
    [XmlElement(Order=3)]
    public S_FTX_8 S_FTX_8 {get; set;}
    [XmlElement(Order=4)]
    public G_QTY_2 G_QTY_2 {get; set;}
    [XmlElement(Order=5)]
    public G_PCD_2 G_PCD_2 {get; set;}
    [XmlElement("G_MOA_3",Order=6)]
    public List<G_MOA_3> G_MOA_3 {get; set;}
    [XmlElement(Order=7)]
    public G_RTE_2 G_RTE_2 {get; set;}
    [XmlElement("G_TAX_4",Order=8)]
    public List<G_TAX_4> G_TAX_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_ALC_2 {
    [XmlElement(Order=0)]
    public string D_5463_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C552_2 C_C552_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4471_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1227_4 {get; set;}
    [XmlElement(Order=4)]
    public C_C214_2 C_C214_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C552_2 {
    [XmlElement(Order=0)]
    public string D_1230_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5189_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C214_2 {
    [XmlElement(Order=0)]
    public string D_7161_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7160_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_7160_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_ALI_4 {
    [XmlElement(Order=0)]
    public string D_3239_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_9213_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4183_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4183_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4183_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4183_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_4183_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_21 {
    [XmlElement(Order=0)]
    public C_C507_21 C_C507_21 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_21 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FTX_8 {
    [XmlElement(Order=0)]
    public string D_4451_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4453_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C107_8 C_C107_8 {get; set;}
    [XmlElement(Order=3)]
    public C_C108_8 C_C108_8 {get; set;}
    [XmlElement(Order=4)]
    public string D_3453_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4447_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C107_8 {
    [XmlElement(Order=0)]
    public string D_4441_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C108_8 {
    [XmlElement(Order=0)]
    public string D_4440_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4440_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4440_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4440_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4440_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_QTY_2 {
    [XmlElement(Order=0)]
    public S_QTY_5 S_QTY_5 {get; set;}
    [XmlElement(Order=1)]
    public S_RNG_6 S_RNG_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_QTY_5 {
    [XmlElement(Order=0)]
    public C_C186_5 C_C186_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C186_5 {
    [XmlElement(Order=0)]
    public string D_6063_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6060_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6411_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RNG_6 {
    [XmlElement(Order=0)]
    public string D_6167_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C280_6 C_C280_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C280_6 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6162_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6152_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_PCD_2 {
    [XmlElement(Order=0)]
    public S_PCD_5 S_PCD_5 {get; set;}
    [XmlElement(Order=1)]
    public S_RNG_7 S_RNG_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_PCD_5 {
    [XmlElement(Order=0)]
    public C_C501_5 C_C501_5 {get; set;}
    [XmlElement(Order=1)]
    public string D_4405_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C501_5 {
    [XmlElement(Order=0)]
    public string D_5245_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5482_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_5249_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1131_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_3055_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RNG_7 {
    [XmlElement(Order=0)]
    public string D_6167_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C280_7 C_C280_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C280_7 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6162_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6152_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_MOA_3 {
    [XmlElement(Order=0)]
    public S_MOA_10 S_MOA_10 {get; set;}
    [XmlElement(Order=1)]
    public S_RNG_8 S_RNG_8 {get; set;}
    [XmlElement(Order=2)]
    public S_CUX_5 S_CUX_5 {get; set;}
    [XmlElement(Order=3)]
    public S_DTM_22 S_DTM_22 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_10 {
    [XmlElement(Order=0)]
    public C_C516_10 C_C516_10 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_10 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RNG_8 {
    [XmlElement(Order=0)]
    public string D_6167_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C280_8 C_C280_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C280_8 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6162_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6152_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_CUX_5 {
    [XmlElement(Order=0)]
    public C_C504_9 C_C504_9 {get; set;}
    [XmlElement(Order=1)]
    public C_C504_10 C_C504_10 {get; set;}
    [XmlElement(Order=2)]
    public string D_5402_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6341_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C504_9 {
    [XmlElement(Order=0)]
    public string D_6347_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6345_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6343_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6348_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C504_10 {
    [XmlElement(Order=0)]
    public string D_6347_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6345_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6343_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6348_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_22 {
    [XmlElement(Order=0)]
    public C_C507_22 C_C507_22 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_22 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_RTE_2 {
    [XmlElement(Order=0)]
    public S_RTE_3 S_RTE_3 {get; set;}
    [XmlElement(Order=1)]
    public S_RNG_9 S_RNG_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RTE_3 {
    [XmlElement(Order=0)]
    public C_C128_3 C_C128_3 {get; set;}
    [XmlElement(Order=1)]
    public string D_4405_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C128_3 {
    [XmlElement(Order=0)]
    public string D_5419_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5420_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_5284_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6411_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RNG_9 {
    [XmlElement(Order=0)]
    public string D_6167_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C280_9 C_C280_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C280_9 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6162_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6152_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_TAX_4 {
    [XmlElement(Order=0)]
    public S_TAX_4 S_TAX_4 {get; set;}
    [XmlElement("S_MOA_11",Order=1)]
    public List<S_MOA_11> S_MOA_11 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_TAX_4 {
    [XmlElement(Order=0)]
    public string D_5283_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C241_4 C_C241_4 {get; set;}
    [XmlElement(Order=2)]
    public C_C533_4 C_C533_4 {get; set;}
    [XmlElement(Order=3)]
    public string D_5286_4 {get; set;}
    [XmlElement(Order=4)]
    public C_C243_4 C_C243_4 {get; set;}
    [XmlElement(Order=5)]
    public string D_5305_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3446_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_1227_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C241_4 {
    [XmlElement(Order=0)]
    public string D_5153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5152_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C533_4 {
    [XmlElement(Order=0)]
    public string D_5289_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C243_4 {
    [XmlElement(Order=0)]
    public string D_5279_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5278_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_5273_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_1131_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3055_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_11 {
    [XmlElement(Order=0)]
    public C_C516_11 C_C516_11 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_11 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_TDT_2 {
    [XmlElement(Order=0)]
    public S_TDT_2 S_TDT_2 {get; set;}
    [XmlElement("G_LOC_3",Order=1)]
    public List<G_LOC_3> G_LOC_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_TDT_2 {
    [XmlElement(Order=0)]
    public string D_8051_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8028_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C220_2 C_C220_2 {get; set;}
    [XmlElement(Order=3)]
    public C_C228_2 C_C228_2 {get; set;}
    [XmlElement(Order=4)]
    public C_C040_2 C_C040_2 {get; set;}
    [XmlElement(Order=5)]
    public string D_8101_6 {get; set;}
    [XmlElement(Order=6)]
    public C_C401_2 C_C401_2 {get; set;}
    [XmlElement(Order=7)]
    public C_C222_2 C_C222_2 {get; set;}
    [XmlElement(Order=8)]
    public string D_8281_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C220_2 {
    [XmlElement(Order=0)]
    public string D_8067_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8066_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C228_2 {
    [XmlElement(Order=0)]
    public string D_8179_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8178_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C040_2 {
    [XmlElement(Order=0)]
    public string D_3127_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3128_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C401_2 {
    [XmlElement(Order=0)]
    public string D_8457_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_8459_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_7130_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C222_2 {
    [XmlElement(Order=0)]
    public string D_8213_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_8212_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_8453_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_LOC_3 {
    [XmlElement(Order=0)]
    public S_LOC_10 S_LOC_10 {get; set;}
    [XmlElement("S_DTM_23",Order=1)]
    public List<S_DTM_23> S_DTM_23 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC_10 {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517_10 C_C517_10 {get; set;}
    [XmlElement(Order=2)]
    public C_C519_10 C_C519_10 {get; set;}
    [XmlElement(Order=3)]
    public C_C553_10 C_C553_10 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517_10 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519_10 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553_10 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_23 {
    [XmlElement(Order=0)]
    public C_C507_23 C_C507_23 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_23 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_TOD_2 {
    [XmlElement(Order=0)]
    public S_TOD_2 S_TOD_2 {get; set;}
    [XmlElement("S_LOC_11",Order=1)]
    public List<S_LOC_11> S_LOC_11 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_TOD_2 {
    [XmlElement(Order=0)]
    public string D_4055_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4215_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C100_2 C_C100_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C100_2 {
    [XmlElement(Order=0)]
    public string D_4053_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4052_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4052_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC_11 {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517_11 C_C517_11 {get; set;}
    [XmlElement(Order=2)]
    public C_C519_11 C_C519_11 {get; set;}
    [XmlElement(Order=3)]
    public C_C553_11 C_C553_11 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517_11 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519_11 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553_11 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_RCS_2 {
    [XmlElement(Order=0)]
    public S_RCS_2 S_RCS_2 {get; set;}
    [XmlElement("S_RFF_10",Order=1)]
    public List<S_RFF_10> S_RFF_10 {get; set;}
    [XmlElement("S_DTM_24",Order=2)]
    public List<S_DTM_24> S_DTM_24 {get; set;}
    [XmlElement("S_FTX_9",Order=3)]
    public List<S_FTX_9> S_FTX_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RCS_2 {
    [XmlElement(Order=0)]
    public string D_7293_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C550_2 C_C550_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1229_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3207_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C550_2 {
    [XmlElement(Order=0)]
    public string D_7295_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7294_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF_10 {
    [XmlElement(Order=0)]
    public C_C506_10 C_C506_10 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506_10 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_24 {
    [XmlElement(Order=0)]
    public C_C507_24 C_C507_24 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_24 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FTX_9 {
    [XmlElement(Order=0)]
    public string D_4451_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4453_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C107_9 C_C107_9 {get; set;}
    [XmlElement(Order=3)]
    public C_C108_9 C_C108_9 {get; set;}
    [XmlElement(Order=4)]
    public string D_3453_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4447_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C107_9 {
    [XmlElement(Order=0)]
    public string D_4441_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C108_9 {
    [XmlElement(Order=0)]
    public string D_4440_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4440_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4440_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4440_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4440_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_GIS {
    [XmlElement(Order=0)]
    public S_GIS_2 S_GIS_2 {get; set;}
    [XmlElement(Order=1)]
    public S_RFF_11 S_RFF_11 {get; set;}
    [XmlElement("S_DTM_25",Order=2)]
    public List<S_DTM_25> S_DTM_25 {get; set;}
    [XmlElement("S_GIR_4",Order=3)]
    public List<S_GIR_4> S_GIR_4 {get; set;}
    [XmlElement("S_LOC_12",Order=4)]
    public List<S_LOC_12> S_LOC_12 {get; set;}
    [XmlElement("S_MEA_5",Order=5)]
    public List<S_MEA_5> S_MEA_5 {get; set;}
    [XmlElement("S_QTY_6",Order=6)]
    public List<S_QTY_6> S_QTY_6 {get; set;}
    [XmlElement("S_FTX_10",Order=7)]
    public List<S_FTX_10> S_FTX_10 {get; set;}
    [XmlElement("S_MOA_12",Order=8)]
    public List<S_MOA_12> S_MOA_12 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_GIS_2 {
    [XmlElement(Order=0)]
    public C_C529_2 C_C529_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C529_2 {
    [XmlElement(Order=0)]
    public string D_7365_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7187_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF_11 {
    [XmlElement(Order=0)]
    public C_C506_11 C_C506_11 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506_11 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_25 {
    [XmlElement(Order=0)]
    public C_C507_25 C_C507_25 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_25 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_GIR_4 {
    [XmlElement(Order=0)]
    public string D_7297_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C206_16 C_C206_16 {get; set;}
    [XmlElement(Order=2)]
    public C_C206_17 C_C206_17 {get; set;}
    [XmlElement(Order=3)]
    public C_C206_18 C_C206_18 {get; set;}
    [XmlElement(Order=4)]
    public C_C206_19 C_C206_19 {get; set;}
    [XmlElement(Order=5)]
    public C_C206_20 C_C206_20 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_16 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_17 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_18 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_19 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C206_20 {
    [XmlElement(Order=0)]
    public string D_7402_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_7405_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4405_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_LOC_12 {
    [XmlElement(Order=0)]
    public string D_3227_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C517_12 C_C517_12 {get; set;}
    [XmlElement(Order=2)]
    public C_C519_12 C_C519_12 {get; set;}
    [XmlElement(Order=3)]
    public C_C553_12 C_C553_12 {get; set;}
    [XmlElement(Order=4)]
    public string D_5479_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C517_12 {
    [XmlElement(Order=0)]
    public string D_3225_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3224_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C519_12 {
    [XmlElement(Order=0)]
    public string D_3223_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3222_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C553_12 {
    [XmlElement(Order=0)]
    public string D_3233_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_3232_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MEA_5 {
    [XmlElement(Order=0)]
    public string D_6311_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C502_5 C_C502_5 {get; set;}
    [XmlElement(Order=2)]
    public C_C174_5 C_C174_5 {get; set;}
    [XmlElement(Order=3)]
    public string D_7383_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C502_5 {
    [XmlElement(Order=0)]
    public string D_6313_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6321_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6155_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6154_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C174_5 {
    [XmlElement(Order=0)]
    public string D_6411_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6314_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6162_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6152_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_6432_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_QTY_6 {
    [XmlElement(Order=0)]
    public C_C186_6 C_C186_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C186_6 {
    [XmlElement(Order=0)]
    public string D_6063_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6060_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6411_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FTX_10 {
    [XmlElement(Order=0)]
    public string D_4451_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4453_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C107_10 C_C107_10 {get; set;}
    [XmlElement(Order=3)]
    public C_C108_10 C_C108_10 {get; set;}
    [XmlElement(Order=4)]
    public string D_3453_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4447_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C107_10 {
    [XmlElement(Order=0)]
    public string D_4441_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C108_10 {
    [XmlElement(Order=0)]
    public string D_4440_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4440_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4440_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4440_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4440_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_12 {
    [XmlElement(Order=0)]
    public C_C516_12 C_C516_12 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_12 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_UNS {
    [XmlElement(Order=0)]
    public string D_0081_1 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_CNT {
    [XmlElement(Order=0)]
    public C_C270 C_C270 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C270 {
    [XmlElement(Order=0)]
    public string D_6069_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_6066_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6411_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_MOA_4 {
    [XmlElement(Order=0)]
    public S_MOA_13 S_MOA_13 {get; set;}
    [XmlElement(Order=1)]
    public G_RFF_7 G_RFF_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_13 {
    [XmlElement(Order=0)]
    public C_C516_13 C_C516_13 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_13 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_RFF_7 {
    [XmlElement(Order=0)]
    public S_RFF_12 S_RFF_12 {get; set;}
    [XmlElement("S_DTM_26",Order=1)]
    public List<S_DTM_26> S_DTM_26 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_RFF_12 {
    [XmlElement(Order=0)]
    public C_C506_12 C_C506_12 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C506_12 {
    [XmlElement(Order=0)]
    public string D_1153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1154_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1156_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4000_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_1060_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_DTM_26 {
    [XmlElement(Order=0)]
    public C_C507_26 C_C507_26 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C507_26 {
    [XmlElement(Order=0)]
    public string D_2005_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_2380_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_2379_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_TAX_5 {
    [XmlElement(Order=0)]
    public S_TAX_5 S_TAX_5 {get; set;}
    [XmlElement("S_MOA_14",Order=1)]
    public List<S_MOA_14> S_MOA_14 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_TAX_5 {
    [XmlElement(Order=0)]
    public string D_5283_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C241_5 C_C241_5 {get; set;}
    [XmlElement(Order=2)]
    public C_C533_5 C_C533_5 {get; set;}
    [XmlElement(Order=3)]
    public string D_5286_4 {get; set;}
    [XmlElement(Order=4)]
    public C_C243_5 C_C243_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_5305_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3446_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_1227_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C241_5 {
    [XmlElement(Order=0)]
    public string D_5153_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5152_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C533_5 {
    [XmlElement(Order=0)]
    public string D_5289_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C243_5 {
    [XmlElement(Order=0)]
    public string D_5279_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_5278_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_5273_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_1131_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_3055_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_14 {
    [XmlElement(Order=0)]
    public C_C516_14 C_C516_14 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_14 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class G_ALC_3 {
    [XmlElement(Order=0)]
    public S_ALC_3 S_ALC_3 {get; set;}
    [XmlElement(Order=1)]
    public S_ALI_5 S_ALI_5 {get; set;}
    [XmlElement("S_MOA_15",Order=2)]
    public List<S_MOA_15> S_MOA_15 {get; set;}
    [XmlElement(Order=3)]
    public S_FTX_11 S_FTX_11 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_ALC_3 {
    [XmlElement(Order=0)]
    public string D_5463_1 {get; set;}
    [XmlElement(Order=1)]
    public C_C552_3 C_C552_3 {get; set;}
    [XmlElement(Order=2)]
    public string D_4471_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_1227_4 {get; set;}
    [XmlElement(Order=4)]
    public C_C214_3 C_C214_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C552_3 {
    [XmlElement(Order=0)]
    public string D_1230_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5189_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C214_3 {
    [XmlElement(Order=0)]
    public string D_7161_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_7160_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_7160_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_ALI_5 {
    [XmlElement(Order=0)]
    public string D_3239_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_9213_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4183_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4183_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4183_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4183_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_4183_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_MOA_15 {
    [XmlElement(Order=0)]
    public C_C516_15 C_C516_15 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C516_15 {
    [XmlElement(Order=0)]
    public string D_5025_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_5004_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_6345_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_6343_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4405_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_FTX_11 {
    [XmlElement(Order=0)]
    public string D_4451_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4453_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C107_11 C_C107_11 {get; set;}
    [XmlElement(Order=3)]
    public C_C108_11 C_C108_11 {get; set;}
    [XmlElement(Order=4)]
    public string D_3453_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_4447_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C107_11 {
    [XmlElement(Order=0)]
    public string D_4441_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_1131_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_3055_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class C_C108_11 {
    [XmlElement(Order=0)]
    public string D_4440_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_4440_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_4440_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_4440_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_4440_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_UNT {
    [XmlElement(Order=0)]
    public string D_0074_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_0062_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_COM {
    [XmlElement("C_C076",Order=0)]
    public List<C_C076> C_C076 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/edifact")]
    [XmlRoot(Namespace="www.edifabric.com/edifact", IsNullable=false)]
    public class S_COM_2 {
    [XmlElement("C_C076_2",Order=0)]
    public List<C_C076_2> C_C076_2 {get; set;}
    }
}
