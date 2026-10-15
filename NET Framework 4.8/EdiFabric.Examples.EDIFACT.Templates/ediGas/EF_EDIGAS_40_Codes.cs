namespace EdiFabric.Templates.Edigas40
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using EdiFabric.Core.Model.Edi.X12;
    
    
    /// <summary>
    // Syntax identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",UNOA,UNOB,UNOC,UNOD,UNOE,UNOF,UNOG,UNOH,UNOI,UNOJ,UNOK,UNOL,UNOQ,UNOW,UNOX,UNOY," +
        "UNOZ,")]
    public class EDIFACT_ID_0001
    {
    }
    
    /// <summary>
    // Syntax version number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_0002
    {
    }
    
    /// <summary>
    // Partner identification code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,14,501,ZS0,")]
    public class EDIFACT_ID_0007
    {
    }
    
    /// <summary>
    // Recipient's reference/password qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,BB,")]
    public class EDIFACT_ID_0025
    {
    }
    
    /// <summary>
    // Processing priority code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,")]
    public class EDIFACT_ID_0029
    {
    }
    
    /// <summary>
    // Acknowledgement request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_0031
    {
    }
    
    /// <summary>
    // Controlling agency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EG,UN,")]
    public class EDIFACT_ID_0051
    {
    }
    
    /// <summary>
    // Message version number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,D,")]
    public class EDIFACT_ID_0052
    {
    }
    
    /// <summary>
    // Message release number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01A,07A,2,3,96A,97A,")]
    public class EDIFACT_ID_0054
    {
    }
    
    /// <summary>
    // Message type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",APERAK,CONTRL,MSCONS,ORDERS,ORDRSP,UTILTS,")]
    public class EDIFACT_ID_0065
    {
    }
    
    /// <summary>
    // First and last transfer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,F,")]
    public class EDIFACT_ID_0073
    {
    }
    
    /// <summary>
    // Section identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,S,")]
    public class EDIFACT_ID_0081
    {
    }
    
    /// <summary>
    // Document name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01G,02G,03G,04G,05G,06G,07G,08G,09G,10G,11G,12G,13G,14G,16G,17G,18G,19G,20G,22G,25G,26G,27G,294,30G,310,320,325,35G,380,381,383,385,388,38G,41G,42G,43G,44G,45G,48G,49G,51G,52G,54G,55G,56G,57G,58G,60G,61G,62G,63G,64G,65G,66G,69G,71G,72G,73G,74G,80G,81G,82,82G,83,83G,84,84G,85G,86G,87G,88G,89G,90G,91G,92G,93G,94G,95G,96G,97G,98G,99G,AAG,ABG,ACG,ADG,AEG,AFG,AGG,AHG,AIG,AJG,AKG,ALG,P01,P02,P03,P04,P05,P06,P07,P08,P09,P10,P11,P12,")]
    public class EDIFACT_ID_1001
    {
    }
    
    /// <summary>
    // Sequence position identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CONNECTION,G-QUALITY,G-QUANTITY,GCV,INITIATOR,OFFTAKE,")]
    public class EDIFACT_ID_1050
    {
    }
    
    /// <summary>
    // Code list identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",25,")]
    public class EDIFACT_ID_1131
    {
    }
    
    /// <summary>
    // Reference code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAG,AAJ,ABO,ACD,ACW,AHI,AHU,ALL,ALY,AOD,AP,ATP,AWQ,BC,BO,CD,CR,CT,DL,EQ,FC,G1A,G" +
        "2A,G2B,G2C,GGV,GKV,GN,GXX,IA,IT,IV,MG,ON,PL,PQ,PR,PY,SB,SE,TE,VA,XA,Z01,Z02,Z03," +
        "Z04,Z05,Z07,Z08,Z09,Z10,Z11,Z14,Z15,Z16,Z17,Z18,ZSC,")]
    public class EDIFACT_ID_1153
    {
    }
    
    /// <summary>
    // Reference identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",G1A,G2A,G2B,G2C,GGV,GKV,GXX,")]
    public class EDIFACT_ID_1154
    {
    }
    
    /// <summary>
    // Sequence identifier source code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Z01,Z02,Z03,Z04,Z05,Z06,Z08,Z09,Z10,Z11,Z12,Z13,Z14,Z15,Z16,Z17,Z18,Z19,Z20,Z21," +
        "Z22,Z23,Z24,Z25,Z26,Z27,Z28,Z29,Z30,Z31,Z32,Z33,Z34,Z35,Z36,ZGF,ZGV,ZPR,ZWN,")]
    public class EDIFACT_ID_1159
    {
    }
    
    /// <summary>
    // Message function code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",04G,1,12,13,15,16,17,2,23,27,29,3,31,34,35,4,42,43,46,47,5,6,64,65,7,9,")]
    public class EDIFACT_ID_1225
    {
    }
    
    /// <summary>
    // CALCULATION SEQUENCE CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_1227
    {
    }
    
    /// <summary>
    // Test indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,5,")]
    public class EDIFACT_ID_0035
    {
    }
    
    /// <summary>
    // ACTION CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,108,109,11,2,23,24,3,4,5,6,63,7,8,9,")]
    public class EDIFACT_ID_1229
    {
    }
    
    /// <summary>
    // Date or time or period function code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",119,12,13,134,137,157,163,164,171,175,194,2,206,209,218,263,273,3,318,322,324,32" +
        "6,35,350,355,356,36,367,368,384,44,61,63,64,69,7,Z01,Z02,Z03,Z04,Z05,Z06,")]
    public class EDIFACT_ID_2005
    {
    }
    
    /// <summary>
    // TERMS TIME RELATION CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_2009
    {
    }
    
    /// <summary>
    // PERIOD TYPE CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",3M,6M,AA,AD,CD,CW,D,DC,DW,F,H,HM,M,MN,P,S,SD,SI,W,WD,WW,Y,ZZZ,")]
    public class EDIFACT_ID_2151
    {
    }
    
    /// <summary>
    // Date or time or period format code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",102,106,110,203,303,401,501,610,718,719,801,802,803,804,805,806,807,")]
    public class EDIFACT_ID_2379
    {
    }
    
    /// <summary>
    // EVENT TIME REFERENCE CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",5,66,")]
    public class EDIFACT_ID_2475
    {
    }
    
    /// <summary>
    // Party function code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AE,AZ,BO,BY,CN,COE,CP,DP,FR,HI,II,IV,MR,MS,PB,PE,RB,SA,SC,SE,SR,SU,TR,UD,ZAA," +
        "ZCA,ZCR,ZES,ZHC,ZHO,ZNO,ZOA,ZOB,ZOC,ZPO,ZRO,ZSH,ZSI,ZSM,ZSO,ZSR,ZSU,ZSV,ZSW,ZSX," +
        "ZSY,ZSZ,ZTR,ZTS,ZTT,ZTU,ZTV,ZTW,")]
    public class EDIFACT_ID_3035
    {
    }
    
    /// <summary>
    // Party identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACC,AEP,AEQ,AGL,AIRPRO,ALIQ,ALT,AMH,APMM,APPT,APX,ATEL,BAR,BAY,BEAR,BEB,BEBSSO,BGIL,BGP,BHPB,BKW,BN,BNPP,BPA,BPGML,BSO,CALOG,CAR,CCP,CDI,CEMAG,CEN,CEPN,CIN,CITI,CNC,CNST,CPNOR,CTN,DACO,DBAG,DELTA,DGA,DGAFLX,DGFLEX,DGS,DNO,DONG,DOW,DYN,EAV,EBL,EBLN,ECC,ECO,ECOD,ECON,EDFG,EDFT,EDISON,EDMIJ,EET,EGG,EGL,EGM,EGS,EGSSIS,EGTVHP,EHA,EHW,EKT,ELP,EMGMDG,EMGMDK,ENECO,ENEL,ENICH,ENID,ENIGP,ENIGPDE,ENIUK,ENLOGS,ENOI,ENVIA,ENVIAM,EOS,ERT,ESSDE,ESSENT,ETG,ETM,EWE,EWEAG,EWS,FGL,FLX,FLXLNG,FLXSSO,FOG,FTS,GASAG,GASSCO,GAZPRM,GAZPUK,GDF,GDFDT,GDFPD,GDFSTO,GDFT,GDFTM,GELWAS,GENT,GEP,GLEN,GMSL,GNCOMF,GSEPN,GSL,GSPL,GU,GUD,GUN,GUT,GUTS,GVS,GXP,HEPG,HNGMN,HUB,HUBCO,IDP,INDEXIS,INO,IUK,JAR,JPMC,JPMV,KOMS,LBLICK,LEHB,LHTSSO,MAI,MCQ,MERC,METHA,MIR,MITS,MOG,MOL,MOS,MPNI,MSGD,NAM,NATG,NBB,NCG,NCGVHP,NGT,NHD,NHDN,NHDNS,NOGAT,NPH,NRG,NRH,NUO,NUONNNO,OGG,ONTRAS,ONTRASBKN,ONTRASTSO,PFALZ,PGEN,PGNG,POWEO,PREGO,PRN,QTL,RAG,RBS,RDN,REA,REL,REM,REN,RTGBKN,RTGBKV,RTGTSO,RUG,RUK,RWE,RWEDEA,RWEG,RWEGSCZ,RWEKA,RWEM,RWEN,RWEUK,SCOT,SEGAL,SEM,SEMK,SEPNO,SETL,SFG,SFGH,SGE,SGS,SGZ,SHEN,SJB,SNA,SNEA,SPE,SPEIA,SPT,STA,STAFIN,STANW,STE,STGN,STGT,STGW,STK,STUK,SVP,SWBIL,SWBV,SWH,SWHOS,SWRO,SYN,TALI,TFEN,TGE,TGH,TGPL,THY,TIGF,TOTALNOGAT,TRAF,TRAN,TRGP,TRI,TXU,UBSA,UBSL,VEM,VIA,VITOL,VNG,VTS,WINNGT,WINNOGAT,WINWGT,WNG,WNTT,WTKG,WVEM,XOM,XOMGLOBAL,ZEBRA,ZMB,")]
    public class EDIFACT_ID_3039
    {
    }
    
    /// <summary>
    // Code list responsible agency code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",16,305,321,5,86,9,91,92,ZGW,ZIU,ZSO,ZZZ,")]
    public class EDIFACT_ID_3055
    {
    }
    
    /// <summary>
    // Carrier identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACC,AEP,AEQ,AGL,AIRPRO,ALIQ,ALT,AMH,APMM,APPT,APX,ATEL,BAR,BAY,BEAR,BEB,BEBSSO,BGIL,BGP,BHPB,BKW,BN,BNPP,BPA,BPGML,BSO,CALOG,CAR,CCP,CDI,CEMAG,CEN,CEPN,CIN,CITI,CNC,CNST,CPNOR,CTN,DACO,DBAG,DELTA,DGA,DGAFLX,DGFLEX,DGS,DNO,DONG,DOW,DYN,EAV,EBL,EBLN,ECC,ECO,ECOD,ECON,EDFG,EDFT,EDISON,EDMIJ,EET,EGG,EGL,EGM,EGS,EGSSIS,EGTVHP,EHA,EHW,EKT,ELP,EMGMDG,EMGMDK,ENECO,ENEL,ENICH,ENID,ENIGP,ENIGPDE,ENIUK,ENLOGS,ENOI,ENVIA,ENVIAM,EOS,ERT,ESSDE,ESSENT,ETG,ETM,EWE,EWEAG,EWS,FGL,FLX,FLXLNG,FLXSSO,FOG,FTS,GASAG,GASSCO,GAZPRM,GAZPUK,GDF,GDFDT,GDFPD,GDFSTO,GDFT,GDFTM,GELWAS,GENT,GEP,GLEN,GMSL,GNCOMF,GSEPN,GSL,GSPL,GU,GUD,GUN,GUT,GUTS,GVS,GXP,HEPG,HNGMN,HUB,HUBCO,IDP,INDEXIS,INO,IUK,JAR,JPMC,JPMV,KOMS,LBLICK,LEHB,LHTSSO,MAI,MCQ,MERC,METHA,MIR,MITS,MOG,MOL,MOS,MPNI,MSGD,NAM,NATG,NBB,NCG,NCGVHP,NGT,NHD,NHDN,NHDNS,NOGAT,NPH,NRG,NRH,NUO,NUONNNO,OGG,ONTRAS,ONTRASBKN,ONTRASTSO,PFALZ,PGEN,PGNG,POWEO,PREGO,PRN,QTL,RAG,RBS,RDN,REA,REL,REM,REN,RTGBKN,RTGBKV,RTGTSO,RUG,RUK,RWE,RWEDEA,RWEG,RWEGSCZ,RWEKA,RWEM,RWEN,RWEUK,SCOT,SEGAL,SEM,SEMK,SEPNO,SETL,SFG,SFGH,SGE,SGS,SGZ,SHEN,SJB,SNA,SNEA,SPE,SPEIA,SPT,STA,STAFIN,STANW,STE,STGN,STGT,STGW,STK,STUK,SVP,SWBIL,SWBV,SWH,SWHOS,SWRO,SYN,TALI,TFEN,TGE,TGH,TGPL,THY,TIGF,TOTALNOGAT,TRAF,TRAN,TRGP,TRI,TXU,UBSA,UBSL,VEM,VIA,VITOL,VNG,VTS,WINNGT,WINNOGAT,WINWGT,WNG,WNTT,WTKG,WVEM,XOM,XOMGLOBAL,ZEBRA,ZMB,")]
    public class EDIFACT_ID_3127
    {
    }
    
    /// <summary>
    // CONTACT FUNCTION CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AE,AP,AR,AZ,CP,IC,MR,MS,PD,SA,SC,TR,")]
    public class EDIFACT_ID_3139
    {
    }
    
    /// <summary>
    // Communication means type code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AE,AH,AI,AJ,AK,AL,AM,AN,CA,EI,EM,EX,FT,FX,IM,MA,PB,PS,SW,TE,TG,TL,TM,TT,TX,XF" +
        ",XG,XH,XI,XJ,")]
    public class EDIFACT_ID_3155
    {
    }
    
    /// <summary>
    // COUNTRY IDENTIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AT,BE,BG,CH,CZ,DE,DK,ES,FI,FR,GB,GI,HU,IE,IS,IT,LT,LU,LV,MA,MT,NL,NO,PL,PT,RO" +
        ",RU,SE,SI,SK,TN,TR,UA,")]
    public class EDIFACT_ID_3207
    {
    }
    
    /// <summary>
    // Location identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",21Z000000000001G,21Z000000000002E,21Z000000000003C,21Z000000000004A,21Z000000000" +
        "0058,21Z0000000000066,21Z0000000000074,21Z0000000000082,21Z0000000000090,21Z0000" +
        "00000010F,21Z000000000011D,21Z000000000012B,21Z0000000000139,21Z0000000000147,21" +
        "Z0000000000155,21Z0000000000163,21Z0000000000171,21Z000000000019Y,21Z00000000002" +
        "0C,21Z000000000021A,21Z0000000000228,21Z0000000000236,21Z0000000000244,21Z000000" +
        "0000252,21Z0000000000260,21Z000000000027Z,21Z000000000028X,21Z000000000029V,21Z0" +
        "000000000309,21Z0000000000317,21Z0000000000325,21Z0000000000333,21Z0000000000341" +
        ",21Z000000000036Y,21Z000000000037W,21Z000000000038U,21Z000000000039S,21Z00000000" +
        "00406,21Z0000000000414,21Z0000000000422,21Z0000000000430,21Z000000000044Z,21Z000" +
        "000000045X,21Z000000000046V,21Z000000000047T,21Z000000000048R,21Z000000000049P,2" +
        "1Z0000000000503,21Z0000000000511,21Z000000000053Y,21Z000000000054W,21Z0000000000" +
        "55U,21Z000000000056S,21Z000000000057Q,21Z000000000058O,21Z000000000059M,21Z00000" +
        "00000600,21Z000000000061Z,21Z000000000062X,21Z000000000063V,21Z000000000064T,21Z" +
        "000000000065R,21Z000000000066P,21Z000000000067N,21Z000000000068L,21Z000000000069" +
        "J,21Z000000000070Y,21Z000000000071W,21Z000000000072U,21Z000000000073S,21Z0000000" +
        "00074Q,21Z000000000075O,21Z000000000076M,21Z000000000077K,21Z000000000078I,21Z00" +
        "0000000079G,21Z000000000080V,21Z000000000081T,21Z000000000082R,21Z000000000083P," +
        "21Z000000000084N,21Z000000000085L,21Z000000000086J,21Z000000000087H,21Z000000000" +
        "088F,21Z000000000089D,21Z000000000090S,21Z000000000091Q,21Z000000000092O,21Z0000" +
        "00000093M,21Z000000000094K,21Z000000000095I,21Z000000000096G,21Z000000000097E,21" +
        "Z000000000098C,21Z000000000099A,21Z000000000100E,21Z000000000101C,21Z00000000010" +
        "2A,21Z0000000001038,21Z0000000001046,21Z0000000001054,21Z0000000001062,21Z000000" +
        "0001070,21Z000000000108Z,21Z000000000109X,21Z000000000110B,21Z0000000001119,21Z0" +
        "000000001127,21Z0000000001135,21Z0000000001143,21Z0000000001151,21Z000000000117Y" +
        ",21Z000000000118W,21Z000000000119U,21Z0000000001208,21Z0000000001216,21Z00000000" +
        "01224,21Z0000000001232,21Z0000000001240,21Z000000000125Z,21Z000000000126X,21Z000" +
        "000000128T,21Z000000000129R,21Z0000000001305,21Z0000000001313,21Z0000000001321,2" +
        "1Z000000000134Y,21Z000000000135W,21Z000000000136U,21Z000000000137S,21Z0000000001" +
        "38Q,21Z000000000139O,21Z0000000001402,21Z0000000001410,21Z000000000142Z,21Z00000" +
        "0000143X,21Z000000000144V,21Z000000000145T,21Z000000000146R,21Z000000000147P,21Z" +
        "000000000148N,21Z000000000149L,21Z000000000151Y,21Z000000000152W,21Z000000000153" +
        "U,21Z000000000154S,21Z000000000155Q,21Z000000000156O,21Z000000000157M,21Z0000000" +
        "00158K,21Z000000000159I,21Z000000000160X,21Z000000000161V,21Z000000000162T,21Z00" +
        "0000000163R,21Z000000000164P,21Z000000000165N,21Z000000000166L,21Z000000000167J," +
        "21Z000000000168H,21Z000000000169F,21Z000000000170U,21Z000000000175K,21Z000000000" +
        "176I,21Z000000000178E,21Z000000000179C,21Z000000000180R,21Z000000000181P,21Z0000" +
        "00000182N,21Z000000000191M,21Z000000000192K,21Z000000000193I,21Z000000000194G,21" +
        "Z000000000195E,21Z000000000196C,21Z000000000197A,21Z0000000001988,21Z00000000019" +
        "96,21Z000000000200A,21Z0000000002018,21Z0000000002026,21Z0000000002034,21Z000000" +
        "000206Z,21Z000000000207X,21Z000000000208V,21Z000000000209T,21Z0000000002107,21Z0" +
        "000000002115,21ZAMTCST------N,21ZBISTST------A,21ZBRNCST------G,21ZBRPCST------V" +
        ",21ZBRSNST-----0Y,21ZCONCST------2,21ZDIMCST------Z,21ZENRCST------I,21ZILNGST--" +
        "----V,21ZPHLCST------D,21ZSAGCST------2,21ZSEACST------K,21ZSHAMST------W,21ZSOL" +
        "CST------1,21ZSPOTST------8,21ZTAMCST------Y,21ZTOMCST------E,")]
    public class EDIFACT_ID_3225
    {
    }
    
    /// <summary>
    // Location function code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",172,231,7,Z01,Z02,Z13,Z17,Z18,Z19,Z20,Z21,Z22,Z23,Z99,")]
    public class EDIFACT_ID_3227
    {
    }
    
    /// <summary>
    // PAYMENT TERMS TYPE CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,20,22,3,45,7,")]
    public class EDIFACT_ID_4279
    {
    }
    
    /// <summary>
    // Change reason description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ZAA,ZAB,ZAC,ZAD,ZAE,ZAF,")]
    public class EDIFACT_ID_4295
    {
    }
    
    /// <summary>
    // RESPONSE TYPE CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AC,AI,NA,")]
    public class EDIFACT_ID_4343
    {
    }
    
    /// <summary>
    // PRODUCT IDENTIFIER CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01G,1,5,")]
    public class EDIFACT_ID_4347
    {
    }
    
    /// <summary>
    // Status description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01G,02G,03G,04G,05G,06G,07G,08G,09G,10G,11G,12G,13G,14G,15G,16G,17G,18G,19G,20G," +
        "21G,22G,23G,24G,25G,26G,27G,28G,29G,30G,31G,32G,33G,34G,35G,36G,37G,38G,39G,40G," +
        "41G,42G,43G,44G,45G,46G,47G,48G,49G,50G,51G,52G,53G,54G,55G,")]
    public class EDIFACT_ID_4405
    {
    }
    
    /// <summary>
    // Payment conditions code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,6,61,62,63,64,69,7,70,71,8," +
        "9,ZZZ,")]
    public class EDIFACT_ID_4439
    {
    }
    
    /// <summary>
    // Free text description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C01,F01,R01,R02,R07,R08,R09,R10,R11,R12,")]
    public class EDIFACT_ID_4441
    {
    }
    
    /// <summary>
    // TEXT SUBJECT CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAI,AAO,ACD,ACL,ACR,ADM,CHG,PUR,QUT,")]
    public class EDIFACT_ID_4451
    {
    }
    
    /// <summary>
    // FREE TEXT FUNCTION CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_4453
    {
    }
    
    /// <summary>
    // Payment means code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,6,60,61,62,63,64,65,66,67,7" +
        ",70,74,75,76,77,78,8,9,91,92,93,94,95,96,97,ZZZ,")]
    public class EDIFACT_ID_4461
    {
    }
    
    /// <summary>
    // SETTLEMENT MEANS CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,5,6,")]
    public class EDIFACT_ID_4471
    {
    }
    
    /// <summary>
    // Monetary amount type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",113,124,125,128,129,131,176,203,204,21,23,236,25,53,66,77,79,8,86,9,")]
    public class EDIFACT_ID_5025
    {
    }
    
    /// <summary>
    // Price code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAA,AAB,AAC,AAD,AAE,AAF,AAG,CAL,INF,INV,")]
    public class EDIFACT_ID_5125
    {
    }
    
    /// <summary>
    // Duty or tax or fee type name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,ADD,BOL,CAP,CAR,COC,CST,CUD,CVD,ENV,EXC," +
        "EXP,FET,FRE,GCN,GST,ILL,IMP,IND,LAC,LCN,LDP,LOC,LST,MCA,MCD,OTH,PDB,PDC,PRF,SCN," +
        "SSS,STT,SUP,SUR,SWT,TAC,TOT,TOX,TTA,VAD,VAT,")]
    public class EDIFACT_ID_5153
    {
    }
    
    /// <summary>
    // Allowance or charge identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59," +
        "6,60,61,62,63,64,65,66,67,68,69,7,70,71,8,9,")]
    public class EDIFACT_ID_5189
    {
    }
    
    /// <summary>
    // Percentage type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,12,15,16,2,7,")]
    public class EDIFACT_ID_5245
    {
    }
    
    /// <summary>
    // Percentage basis identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5249
    {
    }
    
    /// <summary>
    // Duty or tax or fee rate basis code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5273
    {
    }
    
    /// <summary>
    // DUTY OR TAX OR FEE FUNCTION CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,9,")]
    public class EDIFACT_ID_5283
    {
    }
    
    /// <summary>
    // DUTY OR TAX OR FEE CATEGORY CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AA,AB,AC,AD,B,C,E,G,H,O,S,Z,")]
    public class EDIFACT_ID_5305
    {
    }
    
    /// <summary>
    // Price type code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AE,CT,QT,SR,TB,")]
    public class EDIFACT_ID_5375
    {
    }
    
    /// <summary>
    // Price specification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAA,AAG,AAK,AAL,AAM,AAQ,ABG,ABJ,ABL,CON,CP,CUP,INV,MAX,MIN,NTP,")]
    public class EDIFACT_ID_5387
    {
    }
    
    /// <summary>
    // Rate type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5419
    {
    }
    
    /// <summary>
    // ALLOWANCE OR CHARGE CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,")]
    public class EDIFACT_ID_5463
    {
    }
    
    /// <summary>
    // Relation code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Z02,Z03,")]
    public class EDIFACT_ID_5479
    {
    }
    
    /// <summary>
    // QUANTITY TYPE CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,113,129,12G,131,13G,265,47,DN,DN1,TC,Z01,Z02,Z03,Z04,Z06,Z07,Z08,Z09,Z12,Z13,Z16,Z17,Z18,Z19,Z21,Z22,Z23,Z25,Z26,Z27,Z28,Z29,Z30,Z31,Z32,Z33,Z35,Z36,Z37,Z38,Z39,Z40,Z41,Z42,Z43,Z44,Z45,Z46,Z47,Z48,Z49,Z50,Z51,Z52,Z53,Z54,Z55,Z56,Z57,Z58,Z59,Z60,Z61,Z62,Z63,Z64,Z65,Z66,Z67,Z68,Z69,Z70,Z71,Z72,Z74,Z75,Z77,Z78,Z79,Z81,Z82,Z83,Z84,Z85,Z86,Z87,Z89,Z90,Z91,Z92,Z96,Z97,Z98,Z99,ZA2,ZA4,ZA5,ZA6,ZA7,ZA8,ZA9,ZAA,ZAB,ZAC,ZAD,ZAE,ZAF,ZAG,ZAH,ZAI,ZAJ,ZAK,ZAL,ZAM,ZAN,ZAO,ZAP,ZAQ,ZAR,ZAS,ZAT,ZAU,ZAV,ZAW,ZAX,ZAY,ZAZ,ZBA,ZBB,ZBC,ZBD,ZBE,ZBF,ZBG,ZBH,ZBI,ZBJ,ZBK,ZBL,ZBM,ZBN,ZBO,ZBP,ZBQ,ZBR,ZCA,ZCB,ZCC,ZCD,ZCE,ZCF,ZCG,ZCH,ZFL,ZGF,ZGK,ZGL,ZGV,ZLA,ZLB,ZN,ZNV,ZO,ZPA,ZPB,ZPC,ZPD,ZPE,ZPR,ZPS,ZPT,ZPU,ZPV,ZPW,ZPX,ZPY,ZPZ,ZQA,ZQB,ZQD,ZQE,ZQF,ZQG,ZQH,ZQI,ZQJ,ZQK,ZQN,ZS,ZWI,ZWN,")]
    public class EDIFACT_ID_6063
    {
    }
    
    /// <summary>
    // Control total type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_6069
    {
    }
    
    /// <summary>
    // Non-discrete measurement name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,12,18,22,23,37,8,Z01,Z02,Z03,Z04,Z05,Z06,Z07,Z08,Z09,Z10,Z11,Z12,Z13,Z14,Z15," +
        "Z16,Z17,Z18,Z19,Z20,Z21,Z22,Z23,Z24,Z25,Z26,Z27,Z28,Z29,Z30,Z31,Z32,Z33,Z34,Z35," +
        "Z36,Z38,Z39,Z40,Z41,Z42,Z43,Z44,")]
    public class EDIFACT_ID_6155
    {
    }
    
    /// <summary>
    // MEASUREMENT PURPOSE CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01G,02G,03G,04G,05G,AAE,ABN,SV,TR,VO,VT,")]
    public class EDIFACT_ID_6311
    {
    }
    
    /// <summary>
    // Measured attribute code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAP,AAY,ABO,DN,DN1,TC,ZBK,ZBV,ZDG,ZEF,ZEP,ZFL,ZGA,ZGB,ZGC,ZGD,ZGF,ZGG,ZGH,ZGI,ZGK,ZGL,ZGV,ZH,ZIN,ZIP,ZKA,ZKB,ZKC,ZKD,ZKE,ZKF,ZKG,ZKH,ZKI,ZKJ,ZKK,ZKL,ZKM,ZKN,ZKO,ZKP,ZKQ,ZKR,ZKS,ZKT,ZKU,ZKV,ZKW,ZKX,ZKY,ZKZ,ZLA,ZLB,ZLC,ZLD,ZLE,ZLF,ZLG,ZLS,ZMF,ZMR,ZN,ZNV,ZO,ZOP,ZOV,ZPC,ZPO,ZPR,ZQA,ZQB,ZQC,ZQD,ZQE,ZQF,ZQG,ZQH,ZQI,ZQJ,ZQK,ZQL,ZQM,ZQN,ZQZ,ZRC,ZRH,ZS,ZSP,ZST,ZWD,ZWI,ZWN,ZWQ,ZWR,ZWS,ZWT,ZWU,ZWV,")]
    public class EDIFACT_ID_6313
    {
    }
    
    /// <summary>
    // Measure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_6314
    {
    }
    
    /// <summary>
    // Measurement significance code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",02G,03G,04G,05G,06G,07G,08G,09G,10,10G,11,11G,12,13,15,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6321
    {
    }
    
    /// <summary>
    // Currency type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6343
    {
    }
    
    /// <summary>
    // Currency identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ADP,BGN,CHF,CZK,DKK,EUR,GBP,GIP,HRK,HUF,ISK,LTL,LVL,MTL,NOK,PLN,ROL,RUB,SEK,SIT," +
        "SKK,TRL,USD,")]
    public class EDIFACT_ID_6345
    {
    }
    
    /// <summary>
    // Currency usage code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,3,")]
    public class EDIFACT_ID_6347
    {
    }
    
    /// <summary>
    // Measurement unit code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",3,3B,A97,ANN,BAR,CEL,D30,DAY,EA,GC1,GC2,GLI,GP,GV,GV1,GV2,GW1,GW2,GWH,HM1,HM2,HM5,HM6,HM7,HMQ,HUR,JM,JM1,JM2,JM8,JOU,KBA,KC1,KC2,KEL,KGM,KJO,KM9,KMQ,KPA,KW1,KW2,KW3,KWH,KWT,MAW,MBR,MGD,MIN,MOL,MON,MPA,MQ5,MQ6,MQ7,MQH,MQM,MQS,MTQ,MTR,MTS,MW1,MW2,MWH,MWZ,P1,PPV,R9,SEC,TD,TD1,TD2,TQ5,TQ6,TQ7,TQD,TQH,TW3,TW4,VPC,WHR,WTT,Z99,ZZ,")]
    public class EDIFACT_ID_6411
    {
    }
    
    /// <summary>
    // Item description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",12G,13G,14G,15G,16G,17G,18G,21G,22G,23G,24G,25G,26G,27G,28G,29G,30G,31G,32G,33G," +
        "34G,ABS,BLE,BOI,CAB,CIR,CLK,CMP,CNT,COM,COR,DRY,EMG,EXT,FID,FIL,FIP,GSD,HCG,LCG," +
        "LIN,LNK,LVL,MCH,MOD,PMP,PRT,RED,RER,RGN,VAP,VBY,VFL,VIN,VLV,VOT,VRG,VSF,WBM,")]
    public class EDIFACT_ID_7009
    {
    }
    
    /// <summary>
    // Characteristic description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01G,02G,C,G1A,G2A,G2B,G2C,GGV,GKV,GXX,M,N,Y,")]
    public class EDIFACT_ID_7037
    {
    }
    
    /// <summary>
    // CLASS TYPE CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01G,03G,04G,05G,06G,07G,08G,10,11,17,3,8,9,")]
    public class EDIFACT_ID_7059
    {
    }
    
    /// <summary>
    // Description format code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,S,")]
    public class EDIFACT_ID_7077
    {
    }
    
    /// <summary>
    // Item characteristic code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",05G,06G,13,167,180,")]
    public class EDIFACT_ID_7081
    {
    }
    
    /// <summary>
    // Item identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",COEFFICIENT,QUANTITY,")]
    public class EDIFACT_ID_7140
    {
    }
    
    /// <summary>
    // Special service description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AJ,CAC,DI,EAB,FI,HD,QD,")]
    public class EDIFACT_ID_7161
    {
    }
    
    /// <summary>
    // Process type description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Z01,Z02,")]
    public class EDIFACT_ID_7187
    {
    }
    
    /// <summary>
    // Object identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01G,02G,03G,ACCOUNT,")]
    public class EDIFACT_ID_7402
    {
    }
    
    /// <summary>
    // OBJECT TYPE CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_7495
    {
    }
    
    /// <summary>
    // TRANSPORT STAGE CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",40G,41G,42G,")]
    public class EDIFACT_ID_8051
    {
    }
    
    /// <summary>
    // Transport mode name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",70,")]
    public class EDIFACT_ID_8067
    {
    }
    
    /// <summary>
    // Status category code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01G,02G,03G,04G,05G,06G,07G,08G,09G,10G,11G,12G,13G,14G,15G,16G,17G,18G,19G,20G," +
        "")]
    public class EDIFACT_ID_9015
    {
    }
    
    /// <summary>
    // Application error code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01G,02G,03G,04G,11G,12G,13G,14G,15G,16G,17G,18G,19G,20G,21G,22G,23G,25G,40G,41G," +
        "42G,43G,44G,45G,46G,47G,48G,49G,50G,51G,52G,53G,54G,55G,56G,57G,58G,59G,60G,61G," +
        "62G,63G,64G,65G,66G,67G,68G,")]
    public class EDIFACT_ID_9321
    {
    }
    
    /// <summary>
    // Item type identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",SN,Z01,Z02,Z03,Z04,Z05,ZEI,")]
    public class EDIFACT_ID_7143
    {
    }
}
