namespace EdiFabric.Rules.X12002040810 {
    using System;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class M_810 {
    [XmlElement(Order=0)]
    public S_ST S_ST {get; set;}
    [XmlElement(Order=1)]
    public S_BIG S_BIG {get; set;}
    [XmlElement("S_NTE",Order=2)]
    public List<S_NTE> S_NTE {get; set;}
    [XmlElement(Order=3)]
    public S_CUR S_CUR {get; set;}
    [XmlElement("S_REF",Order=4)]
    public List<S_REF> S_REF {get; set;}
    [XmlElement("S_PER",Order=5)]
    public List<S_PER> S_PER {get; set;}
    [XmlElement("G_N1",Order=6)]
    public List<G_N1> G_N1 {get; set;}
    [XmlElement("S_ITD",Order=7)]
    public List<S_ITD> S_ITD {get; set;}
    [XmlElement("S_DTM",Order=8)]
    public List<S_DTM> S_DTM {get; set;}
    [XmlElement(Order=9)]
    public S_FOB S_FOB {get; set;}
    [XmlElement("S_PID",Order=10)]
    public List<S_PID> S_PID {get; set;}
    [XmlElement("S_MEA",Order=11)]
    public List<S_MEA> S_MEA {get; set;}
    [XmlElement("S_PWK",Order=12)]
    public List<S_PWK> S_PWK {get; set;}
    [XmlElement("S_PKG",Order=13)]
    public List<S_PKG> S_PKG {get; set;}
    [XmlElement(Order=14)]
    public S_L7 S_L7 {get; set;}
    [XmlElement("G_IT1",Order=15)]
    public List<G_IT1> G_IT1 {get; set;}
    [XmlElement(Order=16)]
    public S_TDS S_TDS {get; set;}
    [XmlElement("S_TXI_3",Order=17)]
    public List<S_TXI_3> S_TXI_3 {get; set;}
    [XmlElement(Order=18)]
    public S_CAD_2 S_CAD_2 {get; set;}
    [XmlElement("G_ITA_2",Order=19)]
    public List<G_ITA_2> G_ITA_2 {get; set;}
    [XmlElement("S_ISS",Order=20)]
    public List<S_ISS> S_ISS {get; set;}
    [XmlElement(Order=21)]
    public S_CTT S_CTT {get; set;}
    [XmlElement(Order=22)]
    public S_SE S_SE {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_ST {
    [XmlElement(Order=0)]
    public string D_143_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_329_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_1705_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_BIG {
    [XmlElement(Order=0)]
    public string D_245_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_76_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_323_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_324_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_328_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_327_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_640_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NTE {
    [XmlElement(Order=0)]
    public string D_363_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_3_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CUR {
    [XmlElement(Order=0)]
    public string D_98_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_100_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_280_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_98_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_100_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_669_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_374_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_373_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_337_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_374_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_373_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_337_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_374_13 {get; set;}
    [XmlElement(Order=13)]
    public string D_373_14 {get; set;}
    [XmlElement(Order=14)]
    public string D_337_15 {get; set;}
    [XmlElement(Order=15)]
    public string D_374_16 {get; set;}
    [XmlElement(Order=16)]
    public string D_373_17 {get; set;}
    [XmlElement(Order=17)]
    public string D_337_18 {get; set;}
    [XmlElement(Order=18)]
    public string D_374_19 {get; set;}
    [XmlElement(Order=19)]
    public string D_373_20 {get; set;}
    [XmlElement(Order=20)]
    public string D_337_21 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF {
    [XmlElement(Order=0)]
    public string D_128_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_127_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_352_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER {
    [XmlElement(Order=0)]
    public string D_366_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_93_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_365_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_364_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_N1 {
    [XmlElement(Order=0)]
    public S_N1 S_N1 {get; set;}
    [XmlElement("S_N2",Order=1)]
    public List<S_N2> S_N2 {get; set;}
    [XmlElement("S_N3",Order=2)]
    public List<S_N3> S_N3 {get; set;}
    [XmlElement(Order=3)]
    public S_N4 S_N4 {get; set;}
    [XmlElement("S_REF_2",Order=4)]
    public List<S_REF_2> S_REF_2 {get; set;}
    [XmlElement("S_PER_2",Order=5)]
    public List<S_PER_2> S_PER_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N1 {
    [XmlElement(Order=0)]
    public string D_98_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_93_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_66_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_67_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N2 {
    [XmlElement(Order=0)]
    public string D_93_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_93_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3 {
    [XmlElement(Order=0)]
    public string D_166_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_166_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4 {
    [XmlElement(Order=0)]
    public string D_19_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_156_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_116_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_26_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_309_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_310_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_2 {
    [XmlElement(Order=0)]
    public string D_128_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_127_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_352_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_2 {
    [XmlElement(Order=0)]
    public string D_366_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_93_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_365_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_364_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_ITD {
    [XmlElement(Order=0)]
    public string D_336_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_333_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_338_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_370_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_351_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_446_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_386_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_362_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_388_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_389_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_342_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_352_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_765_13 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTM {
    [XmlElement(Order=0)]
    public string D_374_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_373_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_337_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_623_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_FOB {
    [XmlElement(Order=0)]
    public string D_146_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_309_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_352_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_334_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_335_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_309_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_352_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_54_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_352_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PID {
    [XmlElement(Order=0)]
    public string D_349_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_750_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_348_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_751_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_352_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_752_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_MEA {
    [XmlElement(Order=0)]
    public string D_737_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_738_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_739_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_355_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_740_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_741_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_935_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_936_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_752_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PWK {
    [XmlElement(Order=0)]
    public string D_755_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_756_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_757_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_98_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_66_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_67_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_352_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PKG {
    [XmlElement(Order=0)]
    public string D_349_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_753_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_348_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_754_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_352_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_L7 {
    [XmlElement(Order=0)]
    public string D_213_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_168_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_171_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_172_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_169_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_170_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_59_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_173_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_46_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_37_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_119_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_227_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_294_13 {get; set;}
    [XmlElement(Order=13)]
    public string D_295_14 {get; set;}
    [XmlElement(Order=14)]
    public string D_19_15 {get; set;}
    [XmlElement(Order=15)]
    public string D_156_16 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_IT1 {
    [XmlElement(Order=0)]
    public S_IT1 S_IT1 {get; set;}
    [XmlElement(Order=1)]
    public S_CUR_2 S_CUR_2 {get; set;}
    [XmlElement("S_IT3",Order=2)]
    public List<S_IT3> S_IT3 {get; set;}
    [XmlElement("S_TXI",Order=3)]
    public List<S_TXI> S_TXI {get; set;}
    [XmlElement("S_CTP",Order=4)]
    public List<S_CTP> S_CTP {get; set;}
    [XmlElement("S_PID_2",Order=5)]
    public List<S_PID_2> S_PID_2 {get; set;}
    [XmlElement("S_MEA_2",Order=6)]
    public List<S_MEA_2> S_MEA_2 {get; set;}
    [XmlElement("S_PWK_2",Order=7)]
    public List<S_PWK_2> S_PWK_2 {get; set;}
    [XmlElement("S_PKG_2",Order=8)]
    public List<S_PKG_2> S_PKG_2 {get; set;}
    [XmlElement(Order=9)]
    public S_PO4 S_PO4 {get; set;}
    [XmlElement("S_ITD_2",Order=10)]
    public List<S_ITD_2> S_ITD_2 {get; set;}
    [XmlElement("S_REF_3",Order=11)]
    public List<S_REF_3> S_REF_3 {get; set;}
    [XmlElement("S_PER_3",Order=12)]
    public List<S_PER_3> S_PER_3 {get; set;}
    [XmlElement("S_SDQ",Order=13)]
    public List<S_SDQ> S_SDQ {get; set;}
    [XmlElement("S_DTM_2",Order=14)]
    public List<S_DTM_2> S_DTM_2 {get; set;}
    [XmlElement("S_CAD",Order=15)]
    public List<S_CAD> S_CAD {get; set;}
    [XmlElement("S_L7_2",Order=16)]
    public List<S_L7_2> S_L7_2 {get; set;}
    [XmlElement("G_ITA",Order=17)]
    public List<G_ITA> G_ITA {get; set;}
    [XmlElement("G_SLN",Order=18)]
    public List<G_SLN> G_SLN {get; set;}
    [XmlElement("G_N1_2",Order=19)]
    public List<G_N1_2> G_N1_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_IT1 {
    [XmlElement(Order=0)]
    public string D_350_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_358_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_355_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_212_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_639_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_235_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_234_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_235_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_234_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_235_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_234_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_235_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_234_13 {get; set;}
    [XmlElement(Order=13)]
    public string D_235_14 {get; set;}
    [XmlElement(Order=14)]
    public string D_234_15 {get; set;}
    [XmlElement(Order=15)]
    public string D_235_16 {get; set;}
    [XmlElement(Order=16)]
    public string D_234_17 {get; set;}
    [XmlElement(Order=17)]
    public string D_235_18 {get; set;}
    [XmlElement(Order=18)]
    public string D_234_19 {get; set;}
    [XmlElement(Order=19)]
    public string D_235_20 {get; set;}
    [XmlElement(Order=20)]
    public string D_234_21 {get; set;}
    [XmlElement(Order=21)]
    public string D_235_22 {get; set;}
    [XmlElement(Order=22)]
    public string D_234_23 {get; set;}
    [XmlElement(Order=23)]
    public string D_235_24 {get; set;}
    [XmlElement(Order=24)]
    public string D_234_25 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CUR_2 {
    [XmlElement(Order=0)]
    public string D_98_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_100_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_280_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_98_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_100_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_669_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_374_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_373_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_337_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_374_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_373_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_337_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_374_13 {get; set;}
    [XmlElement(Order=13)]
    public string D_373_14 {get; set;}
    [XmlElement(Order=14)]
    public string D_337_15 {get; set;}
    [XmlElement(Order=15)]
    public string D_374_16 {get; set;}
    [XmlElement(Order=16)]
    public string D_373_17 {get; set;}
    [XmlElement(Order=17)]
    public string D_337_18 {get; set;}
    [XmlElement(Order=18)]
    public string D_374_19 {get; set;}
    [XmlElement(Order=19)]
    public string D_373_20 {get; set;}
    [XmlElement(Order=20)]
    public string D_337_21 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_IT3 {
    [XmlElement(Order=0)]
    public string D_382_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_355_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_368_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_383_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_371_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_TXI {
    [XmlElement(Order=0)]
    public string D_963_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_782_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_954_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_955_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_956_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CTP {
    [XmlElement(Order=0)]
    public string D_687_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_236_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_212_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_380_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_355_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_648_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_649_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PID_2 {
    [XmlElement(Order=0)]
    public string D_349_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_750_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_348_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_751_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_352_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_752_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_MEA_2 {
    [XmlElement(Order=0)]
    public string D_737_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_738_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_739_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_355_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_740_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_741_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_935_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_936_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_752_9 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PWK_2 {
    [XmlElement(Order=0)]
    public string D_755_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_756_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_757_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_98_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_66_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_67_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_352_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PKG_2 {
    [XmlElement(Order=0)]
    public string D_349_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_753_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_348_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_754_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_352_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PO4 {
    [XmlElement(Order=0)]
    public string D_356_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_357_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_355_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_103_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_187_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_384_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_355_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_385_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_355_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_82_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_189_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_65_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_355_13 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_ITD_2 {
    [XmlElement(Order=0)]
    public string D_336_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_333_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_338_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_370_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_351_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_446_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_386_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_362_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_388_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_389_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_342_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_352_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_765_13 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_3 {
    [XmlElement(Order=0)]
    public string D_128_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_127_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_352_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_3 {
    [XmlElement(Order=0)]
    public string D_366_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_93_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_365_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_364_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SDQ {
    [XmlElement(Order=0)]
    public string D_355_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_66_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_67_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_380_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_67_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_380_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_67_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_380_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_67_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_380_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_67_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_380_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_67_13 {get; set;}
    [XmlElement(Order=13)]
    public string D_380_14 {get; set;}
    [XmlElement(Order=14)]
    public string D_67_15 {get; set;}
    [XmlElement(Order=15)]
    public string D_380_16 {get; set;}
    [XmlElement(Order=16)]
    public string D_67_17 {get; set;}
    [XmlElement(Order=17)]
    public string D_380_18 {get; set;}
    [XmlElement(Order=18)]
    public string D_67_19 {get; set;}
    [XmlElement(Order=19)]
    public string D_380_20 {get; set;}
    [XmlElement(Order=20)]
    public string D_67_21 {get; set;}
    [XmlElement(Order=21)]
    public string D_380_22 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTM_2 {
    [XmlElement(Order=0)]
    public string D_374_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_373_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_337_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_623_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CAD {
    [XmlElement(Order=0)]
    public string D_91_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_206_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_207_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_140_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_387_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_368_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_128_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_127_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_L7_2 {
    [XmlElement(Order=0)]
    public string D_213_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_168_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_171_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_172_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_169_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_170_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_59_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_173_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_46_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_37_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_119_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_227_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_294_13 {get; set;}
    [XmlElement(Order=13)]
    public string D_295_14 {get; set;}
    [XmlElement(Order=14)]
    public string D_19_15 {get; set;}
    [XmlElement(Order=15)]
    public string D_156_16 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_ITA {
    [XmlElement(Order=0)]
    public S_ITA S_ITA {get; set;}
    [XmlElement("S_TXI_2",Order=1)]
    public List<S_TXI_2> S_TXI_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_ITA {
    [XmlElement(Order=0)]
    public string D_248_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_559_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_560_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_331_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_341_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_359_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_360_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_378_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_332_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_339_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_355_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_380_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_352_13 {get; set;}
    [XmlElement(Order=13)]
    public string D_150_14 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_TXI_2 {
    [XmlElement(Order=0)]
    public string D_963_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_782_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_954_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_955_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_956_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_SLN {
    [XmlElement(Order=0)]
    public S_SLN S_SLN {get; set;}
    [XmlElement("S_REF_4",Order=1)]
    public List<S_REF_4> S_REF_4 {get; set;}
    [XmlElement("S_PID_3",Order=2)]
    public List<S_PID_3> S_PID_3 {get; set;}
    [XmlElement("S_ITA_2",Order=3)]
    public List<S_ITA_2> S_ITA_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SLN {
    [XmlElement(Order=0)]
    public string D_350_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_350_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_661_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_380_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_355_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_212_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_639_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_662_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_235_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_234_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_235_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_234_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_235_13 {get; set;}
    [XmlElement(Order=13)]
    public string D_234_14 {get; set;}
    [XmlElement(Order=14)]
    public string D_235_15 {get; set;}
    [XmlElement(Order=15)]
    public string D_234_16 {get; set;}
    [XmlElement(Order=16)]
    public string D_235_17 {get; set;}
    [XmlElement(Order=17)]
    public string D_234_18 {get; set;}
    [XmlElement(Order=18)]
    public string D_235_19 {get; set;}
    [XmlElement(Order=19)]
    public string D_234_20 {get; set;}
    [XmlElement(Order=20)]
    public string D_235_21 {get; set;}
    [XmlElement(Order=21)]
    public string D_234_22 {get; set;}
    [XmlElement(Order=22)]
    public string D_235_23 {get; set;}
    [XmlElement(Order=23)]
    public string D_234_24 {get; set;}
    [XmlElement(Order=24)]
    public string D_235_25 {get; set;}
    [XmlElement(Order=25)]
    public string D_234_26 {get; set;}
    [XmlElement(Order=26)]
    public string D_235_27 {get; set;}
    [XmlElement(Order=27)]
    public string D_234_28 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_4 {
    [XmlElement(Order=0)]
    public string D_128_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_127_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_352_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PID_3 {
    [XmlElement(Order=0)]
    public string D_349_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_750_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_348_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_751_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_352_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_752_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_ITA_2 {
    [XmlElement(Order=0)]
    public string D_248_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_559_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_560_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_331_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_341_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_359_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_360_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_378_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_332_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_339_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_355_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_380_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_352_13 {get; set;}
    [XmlElement(Order=13)]
    public string D_150_14 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_N1_2 {
    [XmlElement(Order=0)]
    public S_N1_2 S_N1_2 {get; set;}
    [XmlElement("S_N2_2",Order=1)]
    public List<S_N2_2> S_N2_2 {get; set;}
    [XmlElement("S_N3_2",Order=2)]
    public List<S_N3_2> S_N3_2 {get; set;}
    [XmlElement(Order=3)]
    public S_N4_2 S_N4_2 {get; set;}
    [XmlElement("S_REF_5",Order=4)]
    public List<S_REF_5> S_REF_5 {get; set;}
    [XmlElement("S_PER_4",Order=5)]
    public List<S_PER_4> S_PER_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N1_2 {
    [XmlElement(Order=0)]
    public string D_98_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_93_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_66_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_67_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N2_2 {
    [XmlElement(Order=0)]
    public string D_93_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_93_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_2 {
    [XmlElement(Order=0)]
    public string D_166_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_166_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_2 {
    [XmlElement(Order=0)]
    public string D_19_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_156_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_116_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_26_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_309_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_310_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_5 {
    [XmlElement(Order=0)]
    public string D_128_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_127_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_352_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_4 {
    [XmlElement(Order=0)]
    public string D_366_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_93_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_365_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_364_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_TDS {
    [XmlElement(Order=0)]
    public string D_361_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_390_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_391_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_362_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_TXI_3 {
    [XmlElement(Order=0)]
    public string D_963_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_782_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_954_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_955_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_956_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CAD_2 {
    [XmlElement(Order=0)]
    public string D_91_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_206_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_207_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_140_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_387_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_368_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_128_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_127_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_ITA_2 {
    [XmlElement(Order=0)]
    public S_ITA_3 S_ITA_3 {get; set;}
    [XmlElement("S_TXI_4",Order=1)]
    public List<S_TXI_4> S_TXI_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_ITA_3 {
    [XmlElement(Order=0)]
    public string D_248_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_559_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_560_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_331_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_341_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_359_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_360_7 {get; set;}
    [XmlElement(Order=7)]
    public string D_378_8 {get; set;}
    [XmlElement(Order=8)]
    public string D_332_9 {get; set;}
    [XmlElement(Order=9)]
    public string D_339_10 {get; set;}
    [XmlElement(Order=10)]
    public string D_355_11 {get; set;}
    [XmlElement(Order=11)]
    public string D_380_12 {get; set;}
    [XmlElement(Order=12)]
    public string D_352_13 {get; set;}
    [XmlElement(Order=13)]
    public string D_150_14 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_TXI_4 {
    [XmlElement(Order=0)]
    public string D_963_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_782_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_954_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_955_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_956_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_ISS {
    [XmlElement(Order=0)]
    public string D_382_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_355_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_81_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_355_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_183_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_355_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CTT {
    [XmlElement(Order=0)]
    public string D_354_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_347_2 {get; set;}
    [XmlElement(Order=2)]
    public string D_81_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_355_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_183_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_355_6 {get; set;}
    [XmlElement(Order=6)]
    public string D_352_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SE {
    [XmlElement(Order=0)]
    public string D_96_1 {get; set;}
    [XmlElement(Order=1)]
    public string D_329_2 {get; set;}
    }
}
