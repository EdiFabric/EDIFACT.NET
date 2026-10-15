namespace EdiFabric.Templates.Iata131
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    
    
    /// <summary>
    // Syntax identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IATA,IATB,IATC,IATD,IATE,IATF,IATG,IATH,IATI,IATJ,IATK,IATL,IATQ,IATW,IATX,IATY," +
        "IATZ,UNOA,UNOB,UNOC,UNOD,UNOE,UNOF,UNOG,UNOH,UNOI,UNOJ,UNOK,UNOL,UNOQ,UNOW,UNOX," +
        "UNOY,UNOZ,")]
    public class EDIFACT_ID_0001
    {
    }
    
    /// <summary>
    // Syntax version number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_0002
    {
    }
    
    /// <summary>
    // Partner identification code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,103,12,128,129,14,144,145,146,147,148,18,22,30,31,33,34,4,5,500,501,502,51,52," +
        "53,54,55,57,58,59,61,63,65,8,80,82,84,85,86,87,89,9,90,91,92,Z01,ZZZ,")]
    public class EDIFACT_ID_0007
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
    // Controlling agency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IA,UN,")]
    public class EDIFACT_ID_0051
    {
    }
    
    /// <summary>
    // Message type version number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,1,10,11,12,13,14,15,16,17,18,2,3,4,88,89,90,92,93,94," +
        "95,96,97,98,99,D,S,")]
    public class EDIFACT_ID_0052
    {
    }
    
    /// <summary>
    // Message type release number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,00A,00B,01A,01B,01C,02A,02B,03A,03B,04A,04B,05A,05B,06A,06B,07A,07B,08A,08B,09" +
        "A,09B,1,10A,10B,11A,11B,12A,12B,13A,13B,14A,14B,15A,15B,16A,16B,17A,17B,18A,18B," +
        "2,3,902,911,912,921,932,93A,94A,94B,95A,95B,96A,96B,97A,97B,98A,98B,99A,99B,")]
    public class EDIFACT_ID_0054
    {
    }
    
    /// <summary>
    // Message type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ACKRES,CONTRL,GOVREQ,PNRGOV,")]
    public class EDIFACT_ID_0065
    {
    }
    
    /// <summary>
    // Action
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",4,7,8,")]
    public class EDIFACT_ID_0083
    {
    }
    
    /// <summary>
    // Syntax error
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",11,12,13,14,15,18,2,23,24,26,28,29,37,39,40,41,42,43,")]
    public class EDIFACT_ID_0085
    {
    }
    
    /// <summary>
    // Character encoding
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,ZZZ,")]
    public class EDIFACT_ID_0133
    {
    }
    
    /// <summary>
    // Document/message name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,703,E,INF,J,M,O,S,T,XXX,Y,")]
    public class EDIFACT_ID_1001
    {
    }
    
    /// <summary>
    // Sequence number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A,AA,AR,AT,B,BM,BN,BO,BP,BR,BS,C,CB,CF,CR,CS,CU,D,DA,DC,DP,DS,E,EN,ER,ET,F,FF,FM,FR,FU,GR,H,HE,HT,I,IA,J,JA,K,L,LX,M,MC,MP,MX,N,O,OC,OE,OM,P,PT,Q,RA,RB,RN,RO,RP,RR,S,SA,SL,SM,SP,SR,ST,T,TA,TD,TE,TF,TN,TR,TS,TT,U,V,VL,W,X,Y,Z,")]
    public class EDIFACT_ID_1050
    {
    }
    
    /// <summary>
    // Code list qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,EC,WEC,WZZ,ZZZ,")]
    public class EDIFACT_ID_1131
    {
    }
    
    /// <summary>
    // Reference qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,700,701,702,703,704,705,706,707,A,B,F,H,P,S,T,XX,")]
    public class EDIFACT_ID_1153
    {
    }
    
    /// <summary>
    // Sequence number source
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,P,")]
    public class EDIFACT_ID_1159
    {
    }
    
    /// <summary>
    // Message function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,119,12,121,122,13,130,131,132,133,134,135,137,139,14,140,141,142,143,144,145,146,15,150,151,152,153,154,155,156,157,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,19,190,191,192,193,194,195,196,197,198,2,20,200,205,206,207,21,210,211,212,213,214,215,216,217,22,220,221,222,223,23,24,25,26,27,3,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,700,701,702,703,704,705,706,707,708,709,71,710,711,712,713,714,715,716,717,718,719,72,720,721,722,723,724,725,726,727,728,729,73,730,731,732,733,734,735,736,737,738,739,74,740,741,742,743,744,745,746,747,748,749,75,750,751,752,753,754,755,756,757,758,759,76,760,761,762,763,764,765,766,767,768,769,77,770,771,772,773,774,775,776,777,778,779,78,780,781,782,783,784,785,786,787,788,789,79,790,791,792,793,794,795,796,797,798,799,8,80,800,801,802,803,804,805,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,97,98,99,A,A4,B,C,D,E,F,F18,FC,FM,FS,G,H,I,J,K,L,M,N,O,P,RC,RN,RQ,RS,RZ,SA,SCR,SIR,SMA,TLQ,U,")]
    public class EDIFACT_ID_1225
    {
    }
    
    /// <summary>
    // Action request / notification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,700,701,702,703,A,AO,B,BH,C,CH,CS,D,DC,DS,E,ES,F,FS,G,H,HH,I,IC,IM,J" +
        ",K,KK,L,LS,M,MS,N,NA,NE,NS,O,OO,P,PP,Q,QA,QD,QS,R,RS,S,SR,SS,T,TO,TS,U,UU,V,W,WW" +
        ",X,XX,Y,YY,Z,ZZ,")]
    public class EDIFACT_ID_1229
    {
    }
    
    /// <summary>
    // Status indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",0,1,2,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,716,717,718,719,720,721,722,723,724,725,726,729,730,731,732,733,734,735,736,737,738,739,740,741,742,743,744,745,746,747,748,749,750,751,752,753,754,755,756,757,759,760,761,762,763,764,765,766,767,768,769,770,771,772,773,774,775,7CG,7DO,7GE,7IN,7NS,7WG,A,AW,AW2,AW3,AW5,B,C,F,FF,FL,FS,I,L,LX,MM,N,NOP,NS,OL,OP,P1,P2,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PM,PN,R,S,SA,SB,SC,SCH,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,T,V,VG,VIP,X,Y,")]
    public class EDIFACT_ID_1245
    {
    }
    
    /// <summary>
    // Date/Time/Period qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,716,A,AA,ACL,ACT,AD,AI,ALL,ALT,B,CAL,COL,COT,DV,DX,E,EA,EAL,EAT,EB,ED,EET,ENL,ENT,EO,ESL,EST,EX,FLT,FR,GRT,HEL,HET,HIL,HIT,HNL,HNT,L,LA,LAL,LAT,LT,LX,MNG,NIL,NIT,OB,PLN,RC,REL,RET,RR,RT,SCA,SCD,SCL,SCT,STL,STT,T,TAR,U,ZT,")]
    public class EDIFACT_ID_2005
    {
    }
    
    /// <summary>
    // Payment time reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",...,1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,3" +
        "3,34,35,36,4,5,6,7,8,9,E,")]
    public class EDIFACT_ID_2475
    {
    }
    
    /// <summary>
    // Charge period type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_2901
    {
    }
    
    /// <summary>
    // Party qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,BAG,CAT,FLT,FRT,FUE,H,M,MAI,PAX,PLT,ROU,TEC,WAR,")]
    public class EDIFACT_ID_3035
    {
    }
    
    /// <summary>
    // Code list responsible agency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",13,2,3,5,6,ZZZ,")]
    public class EDIFACT_ID_3055
    {
    }
    
    /// <summary>
    // Carrier identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAH,AAL,AAR,AAW,ABR,ACA,ACI,ADR,AEA,AEE,AEW,AFG,AFL,AFR,AGN,AHY,AIC,AIZ,AJM,ALK,AMC,AML,AMU,AMX,ANA,ANG,ANS,ANZ,ARG,ASA,ATC,AUA,AUI,AUT,AVA,AVN,AWE,AZA,AZW,BAG,BAW,BBC,BCS,BCY,BEE,BER,BKP,BLF,BMA,BOT,BPA,BRA,BRU,BRZ,BWA,BWG,CAL,CAW,CCA,CDG,CES,CHH,CIM,CLH,CLX,CMI,CMP,COA,CPA,CPN,CRL,CSA,CSN,CTN,CUB,CXA,CYP,DAH,DAL,DAT,DHK,DHX,DLH,DNM,DTA,EIN,ELG,ELL,ELY,ETD,ETH,EVA,EWG,FCN,FDX,FEA,FIN,FJI,GBL,GEC,GFA,GIA,HCY,HDA,HEJ,HLF,IAC,IAW,IBB,IBE,ICE,ICL,IRA,IRC,IRM,ISR,ISS,IYE,JAI,JAL,JAT,JAZ,JKK,KAC,KAL,KHA,KLM,KOR,KQA,KRP,LAA,LAM,LAN,LAP,LBC,LCO,LDA,LGL,LIL,LLB,LOT,LPE,LRC,LTU,LXR,MAH,MAK,MAS,MAU,MAZ,MDG,MEA,MGL,MGX,MLD,MPX,MRS,MSR,MXA,NCA,NMB,NTW,NWA,OAL,OAS,PAL,PAO,PGA,PIA,PLK,PNW,PUA,QFA,QTR,RAM,RBA,REU,RJA,ROT,RSN,SAA,SAS,SAT,SBI,SER,SEY,SIA,SKX,SLA,SLK,SLM,SOL,SUD,SVA,SWR,SYR,TAI,TAP,TAR,TAY,THA,THT,THY,TMA,TNA,TSO,TUA,UAE,UAL,UPS,USA,UYC,VGN,VIR,VLE,VLK,VRG,VSP,VTA,WIF,WNT,")]
    public class EDIFACT_ID_3127
    {
    }
    
    /// <summary>
    // Communication channel identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class EDIFACT_ID_3153
    {
    }
    
    /// <summary>
    // Country
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AD,AE,AF,AG,AI,AL,AM,AN,AO,AQ,AR,AS,AT,AU,AW,AX,AZ,BA,BB,BD,BE,BF,BG,BH,BI,BJ,BM,BN,BO,BR,BS,BT,BV,BW,BY,BZ,CA,CC,CD,CF,CG,CH,CI,CK,CL,CM,CN,CO,CR,CS,CU,CV,CX,CY,CZ,DE,DJ,DK,DM,DO,DZ,EC,EE,EG,EH,ER,ES,ET,FI,FJ,FK,FM,FO,FR,GA,GB,GD,GE,GF,GG,GH,GI,GL,GM,GN,GP,GQ,GR,GS,GT,GU,GW,GY,HK,HM,HN,HR,HT,HU,ID,IE,IL,IM,IN,IO,IQ,IR,IS,IT,JE,JM,JO,JP,KE,KG,KH,KI,KM,KN,KP,KR,KW,KY,KZ,LA,LB,LC,LI,LK,LR,LS,LT,LU,LV,LY,MA,MC,MD,MG,MH,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,NA,NC,NE,NF,NG,NI,NL,NO,NP,NR,NU,NZ,OM,PA,PE,PF,PG,PH,PK,PL,PM,PN,PR,PS,PT,PW,PY,QA,RE,RO,RU,RW,SA,SB,SC,SD,SE,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SR,ST,SV,SY,SZ,TC,TD,TF,TG,TH,TJ,TK,TL,TM,TN,TO,TR,TT,TV,TW,TZ,UA,UG,UM,US,UY,UZ,VA,VC,VE,VG,VI,VN,VU,WF,WS,YE,YT,ZA,ZM,ZW,")]
    public class EDIFACT_ID_3207
    {
    }    
    
    /// <summary>
    // Place/location qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,703,704,705,706,707,708,C,L,LC,R,RC,")]
    public class EDIFACT_ID_3227
    {
    }
    
    /// <summary>
    // Address purpose code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,700,701,702,703,704,")]
    public class EDIFACT_ID_3299
    {
    }
    
    /// <summary>
    // Language
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AE,AF,AK,AM,AN,AR,AS,AV,AY,AZ,BA,BE,BG,BH,BI,BM,BN,BO,BR,BS,CA,CE,CH,CO,CR,CS,CU,CV,CY,DA,DE,DV,DZ,EE,EL,EN,EO,ES,ET,EU,FA,FF,FI,FJ,FO,FR,FY,GA,GD,GL,GN,GU,GV,HA,HE,HI,HO,HR,HT,HU,HY,HZ,IA,ID,IE,IG,II,IK,IO,IS,IT,IU,JA,JV,KA,KG,KI,KJ,KK,KL,KM,KN,KO,KR,KS,KU,KV,KW,KY,LA,LB,LG,LI,LN,LO,LT,LU,LV,MG,MH,MI,MK,ML,MN,MO,MR,MS,MT,MY,NA,NB,ND,NE,NG,NL,NN,NO,NR,NV,NY,OC,OJ,OM,OR,OS,PA,PI,PL,PS,PT,QU,RM,RN,RO,RU,RW,SA,SC,SD,SE,SG,SH,SI,SK,SL,SM,SN,SO,SQ,SR,SS,ST,SU,SV,SW,TA,TE,TG,TH,TI,TK,TL,TN,TO,TR,TS,TT,TW,TY,UG,UK,UR,UZ,VE,VI,VO,WA,WO,XH,YI,YO,ZA,ZH,ZU,")]
    public class EDIFACT_ID_3453
    {
    }
    
    /// <summary>
    // Airline code number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",001,004,005,006,012,014,016,020,021,023,024,027,032,037,042,043,044,045,047,048,050,051,053,055,057,058,061,063,064,065,068,070,071,072,073,074,075,076,077,078,079,080,081,082,083,086,096,098,104,105,106,108,112,114,115,117,118,120,124,125,126,131,132,133,134,135,136,139,141,142,143,145,146,147,148,149,152,154,155,157,160,161,162,165,167,168,169,170,171,172,176,180,182,183,185,186,191,192,193,195,197,199,200,201,202,205,208,214,217,218,220,229,230,231,232,235,236,238,239,240,244,251,255,257,258,260,263,265,266,267,276,277,281,286,289,297,324,327,343,367,390,391,400,401,406,407,409,412,421,459,462,465,469,472,474,479,489,490,509,512,515,532,537,542,544,546,555,566,567,572,589,596,603,604,607,610,615,617,618,625,628,629,635,636,639,643,647,656,657,669,670,672,675,680,681,683,685,689,690,692,694,695,700,701,705,706,708,724,731,737,745,748,749,752,756,759,760,771,774,778,780,781,784,786,789,798,815,818,829,831,867,870,874,876,879,880,906,910,923,932,933,944,957,960,988,994,995,996,997,999,")]
    public class EDIFACT_ID_3810
    {
    }
    
    /// <summary>
    // Business function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,5,6,7,8,9,G,R,S,")]
    public class EDIFACT_ID_4025
    {
    }
    
    /// <summary>
    // Special condition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,716,717,718,719," +
        "720,721,A,B,C,D,E,F,FL,G,H,I,RB,RE,RO,SR,Z,")]
    public class EDIFACT_ID_4183
    {
    }
    
    /// <summary>
    // Response type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,3,4,5,6,7,700,701,702,703,704,705," +
        "706,707,708,709,70C,70D,710,8,9,A,B,C,D,E,F,")]
    public class EDIFACT_ID_4343
    {
    }
    
    /// <summary>
    // Instruction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,N,Y,")]
    public class EDIFACT_ID_4401
    {
    }
    
    /// <summary>
    // Instruction qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,I,N,X,")]
    public class EDIFACT_ID_4403
    {
    }
    
    /// <summary>
    // Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,703,704,705,706,707,708,709,710,A,AC,AL,ALL,AVA,B,BD,C,CK,CLO,D,DB,D" +
        "N,E,F,G,I,IF,INU,IO,K,LIM,NAV,NC,NS,OF,OK,OLD,OPE,P,PAV,PE,PR,PRF,PRP,R,RD,REP,R" +
        "EV,RF,RQ,S,SA,SB,SRV,T,UNS,V,WL,X,")]
    public class EDIFACT_ID_4405
    {
    }
    
    /// <summary>
    // Payment conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,")]
    public class EDIFACT_ID_4439
    {
    }
    
    /// <summary>
    // Free text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_4441
    {
    }
    
    /// <summary>
    // Text subject qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,3,4,CHG,PRD,SAF,SIM,SPH,STN,TRA,ZZZ,")]
    public class EDIFACT_ID_4451
    {
    }
    
    /// <summary>
    // Monetary function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,700,701,702,703,704,705,706,")]
    public class EDIFACT_ID_5007
    {
    }
    
    /// <summary>
    // Monetary amount type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,4,5,6,7,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,716,717,718,719,720,721,722,723,724,725,726,727,728,729,730,731,732,733,734,735,8,9,A,AA,AB,AC,AD,AE,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
    public class EDIFACT_ID_5025
    {
    }
    
    /// <summary>
    // Duty/Tax fee type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5153
    {
    }
    
    /// <summary>
    // Charge category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,716,717,718,719," +
        "720,721,722,723,724,725,726,727,728,729,730,731,732,733,734,735,736,737,738,739," +
        "740,741,742,743,744,745,")]
    public class EDIFACT_ID_5237
    {
    }
    
    /// <summary>
    // Percentage qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,O,T,U,")]
    public class EDIFACT_ID_5245
    {
    }
    
    /// <summary>
    // Rate type identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,716,717,718,719," +
        "720,721,722,723,724,725,726,")]
    public class EDIFACT_ID_5263
    {
    }
    
    /// <summary>
    // Duty/tax/fee category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,700,701,702,703,704,705,706,707,708,709,710,711,D,E,I,N,Q,T,")]
    public class EDIFACT_ID_5305
    {
    }
    
    /// <summary>
    // Price type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,71" +
        "6,717,718,719,720,721,722,723,724,725,726,727,728,729,730,731,732,D,DF,G,HF,I,II" +
        ",IO,LF,N,NE,NF,NR,OI,OO,PA,R,RD,RI,RN,S,SC,T,TA,TF,TN,TW,VF,X,")]
    public class EDIFACT_ID_5387
    {
    }
    
    /// <summary>
    // Rate type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,BBR,BSR,ROE,USR,")]
    public class EDIFACT_ID_5419
    {
    }
    
    /// <summary>
    // Allowance or charge qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,C,N,S,V,W,")]
    public class EDIFACT_ID_5463
    {
    }
    
    /// <summary>
    // Relation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,F,I,L,M,")]
    public class EDIFACT_ID_5479
    {
    }
    
    /// <summary>
    // Charge unit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59," +
        "6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84" +
        ",85,86,87,9,")]
    public class EDIFACT_ID_5901
    {
    }
    
    /// <summary>
    // Form of payment identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5903
    {
    }
    
    /// <summary>
    // Payment type identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5905
    {
    }
    
    /// <summary>
    // Rate type identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5907
    {
    }
    
    /// <summary>
    // Service to be paid
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_5909
    {
    }
    
    /// <summary>
    // Rate plan
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,4,5,6,7,8,9,DY,MY,WD,WY,")]
    public class EDIFACT_ID_5911
    {
    }
    
    /// <summary>
    // Quantity qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1ST,2ND,3RD,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,716," +
        "717,AC,ACO,B,C,CAR,H,IG,KG,L,LAN,LB,LT,MTO,N,OZ,PAX,PT,R,RTO,SA,T,UG,Y,")]
    public class EDIFACT_ID_6063
    {
    }
    
    /// <summary>
    // Dimension qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_6145
    {
    }
    
    /// <summary>
    // Range type qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,")]
    public class EDIFACT_ID_6167
    {
    }
    
    /// <summary>
    // Measurement application qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,")]
    public class EDIFACT_ID_6311
    {
    }
    
    /// <summary>
    // Measurement dimension
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",NCD,PLD,PMD,PWG,SCD,")]
    public class EDIFACT_ID_6313
    {
    }
    
    /// <summary>
    // Measurement significance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,A,P,")]
    public class EDIFACT_ID_6321
    {
    }
    
    /// <summary>
    // Currency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",004,008,012,020,024,031,032,036,040,044,048,050,051,052,056,060,064,068,072,084," +
        "090,096,100,104,108,116,124,132,136,144,152,156,170,174,180,188,191,192,196,200," +
        "203,208,214,218,222,230,232,233,238,242,246,250,262,270,276,278,288,292,300,320," +
        "324,328,332,340,344,348,352,356,360,364,368,372,376,380,388,392,398,400,404,408," +
        "410,414,417,418,422,426,428,430,434,440,442,446,450,454,458,462,470,478,480,484," +
        "496,498,504,508,512,516,524,528,532,533,548,554,558,566,578,586,590,598,600,604," +
        "608,616,620,624,626,634,642,643,646,654,678,682,690,694,702,703,704,705,706,710," +
        "716,720,724,736,740,748,752,756,760,762,764,776,777,780,784,788,792,795,800,804," +
        "807,810,818,826,834,840,858,860,862,882,886,891,894,901,937,938,939,940,941,943," +
        "944,946,947,948,949,950,951,952,953,954,955,956,957,958,959,960,961,962,963,964," +
        "968,969,970,971,972,973,974,975,976,977,978,979,980,981,982,983,984,985,986,990," +
        "991,992,993,995,996,997,998,999,ADP,AED,AFA,AFN,ALL,AMD,ANG,AOA,AON,AOR,ARS,ATS," +
        "AUD,AWG,AZM,AZN,BAM,BBD,BDT,BEC,BEF,BEL,BGL,BGN,BHD,BIF,BMD,BND,BOB,BOV,BRL,BSD," +
        "BTN,BWP,BYR,BZD,CAD,CDF,CHE,CHF,CHW,CLF,CLP,CNY,COP,COU,CRC,CSD,CSK,CUP,CVE,CYP," +
        "CZK,DDM,DEM,DJF,DKK,DOP,DZD,ECS,ECV,EEK,EGP,ERN,ESA,ESB,ESP,ETB,EUR,FIM,FJD,FKP," +
        "FRF,GBP,GEL,GHC,GHP,GIP,GMD,GNF,GRD,GTQ,GWP,GYD,HKD,HNL,HRK,HTG,HUF,IDR,IEP,ILS," +
        "INR,IQD,IRR,ISK,ITL,JMD,JOD,JPY,KES,KGS,KHR,KMF,KPW,KRW,KWD,KYD,KZT,LAK,LBP,LKR," +
        "LRD,LSL,LTL,LUF,LVL,LYD,MAD,MDL,MGA,MGF,MKD,MMK,MNT,MOP,MRO,MTL,MUR,MVR,MWK,MXN," +
        "MXV,MYR,MZM,MZN,NAD,NGN,NIO,NLG,NOK,NPR,NZD,OMR,PAB,PEN,PGK,PHP,PKR,PLN,PLZ,PTE," +
        "PYG,QAR,ROL,RON,RSD,RUB,RUR,RWF,SAR,SBD,SCR,SDD,SDG,SEK,SGD,SHP,SIT,SKK,SLL,SOS," +
        "SRD,SRG,STD,SVC,SYP,SZL,THB,TJR,TJS,TMM,TND,TOP,TPE,TRL,TRY,TTD,TWD,TZS,UAH,UAK," +
        "UGX,USD,USN,USS,UYI,UYU,UZS,VEB,VEF,VND,VUV,WST,XAF,XAG,XAU,XBA,XBB,XBC,XBD,XCD," +
        "XDR,XEU,XFO,XFU,XOF,XPD,XPF,XPT,XTS,XXX,YDD,YER,ZAL,ZAR,ZMK,ZRN,ZWD,")]
    public class EDIFACT_ID_6345
    {
    }
    
    /// <summary>
    // Number of units qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,7,700,701,702,703,704,705,706,707,708,709,70A,70B,70C,70D,70E,70F,70G,70H,70I,70J,70K,70L,70M,70N,70O,70P,70Q,70R,70S,70T,70U,70V,70W,70X,70Y,70Z,710,711,712,713,714,715,716,717,718,719,71A,71B,71C,71D,71E,71F,71G,71H,71I,71J,71K,71L,71M,71N,71O,71P,71Q,71R,71S,71T,71U,71V,71W,71X,71Y,71Z,720,721,722,723,724,725,726,727,728,729,72A,72B,72C,72D,72E,72F,730,731,732,733,734,735,736,737,738,739,740,741,742,743,744,745,746,747,748,749,750,751,752,753,754,755,756,757,758,759,760,761,762,763,764,765,766,767,768,769,770,771,772,773,774,775,776,777,778,779,780,781,782,783,784,785,786,787,788,789,790,791,792,793,794,795,796,797,798,799,8,800,801,802,803,804,805,806,807,808,809,810,811,812,813,814,815,816,817,818,819,820,821,822,823,824,825,826,827,828,829,830,831,832,833,834,835,836,837,838,839,840,841,842,843,844,845,846,847,848,849,850,851,852,853,854,855,856,857,9,A,BS,C,CP,DPI,F,G,I,IF,IM,IN,IZ,L,M,ML,MX,N,NC,NL,PX,S,SP,SS,T,TA,TC,TCA,TD,TF,TS,TU,TUA,UM,")]
    public class EDIFACT_ID_6353
    {
    }
    
    /// <summary>
    // Measure unit qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,703,704,A,B,BUS,C,DPL,ECO,FIR,FR,G,GLI,GLL,K,L,LR,LTR,M,MIN,ONZ,OZA," +
        "OZI,P,S,")]
    public class EDIFACT_ID_6411
    {
    }
    
    /// <summary>
    // Weight unit code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",K,L,")]
    public class EDIFACT_ID_6801
    {
    }
    
    /// <summary>
    // Item description identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,700,701,702,D,N,")]
    public class EDIFACT_ID_7009
    {
    }
    
    /// <summary>
    // Article availability
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117," +
        "118,119,12,120,121,122,123,124,125,126,127,128,129,13,130,131,132,133,134,135,13" +
        "6,137,138,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154," +
        "155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,17" +
        "3,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,19,190,191," +
        "192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21," +
        "210,211,212,213,214,215,216,217,218,219,22,220,221,222,223,224,225,226,227,228,2" +
        "29,23,230,231,232,233,234,235,236,237,238,239,24,240,241,242,243,244,245,246,247" +
        ",248,249,25,250,251,252,253,254,255,256,257,258,259,26,260,261,262,263,264,265,2" +
        "66,267,268,269,27,270,271,272,273,274,275,276,277,278,279,28,280,281,282,283,284" +
        ",285,286,287,288,289,29,290,291,292,293,294,295,296,297,298,299,3,30,300,301,302" +
        ",303,304,305,306,307,308,309,31,310,311,312,313,314,315,316,317,318,319,32,320,3" +
        "21,322,323,324,325,326,327,328,329,33,330,331,332,333,334,335,336,337,338,339,34" +
        ",340,341,342,343,344,345,346,347,348,349,35,350,351,352,353,354,355,356,357,358," +
        "359,36,360,361,362,363,364,365,366,367,368,369,37,370,371,372,373,374,375,376,37" +
        "7,378,379,38,380,381,382,383,384,385,386,387,388,389,39,390,391,392,393,394,395," +
        "396,397,398,399,4,40,400,401,402,403,404,405,406,407,408,409,41,410,411,412,413," +
        "414,415,416,417,418,419,42,420,421,422,423,424,425,426,427,428,429,43,430,431,43" +
        "2,433,434,435,436,437,438,439,44,440,441,442,443,444,445,446,447,448,449,45,450," +
        "451,452,453,454,455,456,457,458,459,46,460,461,462,463,464,465,466,467,468,469,4" +
        "7,470,471,472,473,474,475,476,477,478,479,48,480,481,482,483,484,485,486,487,488" +
        ",489,49,490,491,492,493,494,495,496,497,498,499,5,50,500,501,502,503,504,505,506" +
        ",507,508,509,51,510,511,512,513,514,515,516,517,518,519,52,520,521,522,523,524,5" +
        "25,526,527,528,529,53,530,531,532,533,534,535,536,537,538,539,54,540,541,542,543" +
        ",544,545,546,547,548,549,55,550,551,552,553,554,555,556,557,558,559,56,560,561,5" +
        "62,563,564,565,566,567,568,569,57,570,571,572,573,574,575,576,577,578,579,58,580" +
        ",581,582,583,584,585,586,587,588,589,59,590,591,592,593,594,595,596,597,598,599," +
        "6,60,600,601,602,603,604,605,606,607,608,609,61,610,611,612,613,614,615,616,617," +
        "618,619,62,620,621,622,623,624,625,626,627,628,629,63,630,631,632,633,634,635,63" +
        "6,637,638,639,64,640,641,642,643,644,645,646,647,648,649,65,650,651,652,653,654," +
        "655,656,657,658,659,66,660,661,662,663,664,665,666,667,668,669,67,670,671,672,67" +
        "3,674,675,676,677,678,679,68,680,681,682,683,684,685,686,687,688,689,69,690,691," +
        "692,693,694,695,696,697,698,699,7,70,700,701,702,703,704,705,706,707,708,709,70A" +
        ",70B,70C,71,710,711,712,713,714,715,716,717,718,719,72,720,721,722,723,724,725,7" +
        "26,727,728,729,73,730,731,732,733,734,735,736,737,738,739,74,740,741,742,743,744" +
        ",745,746,747,748,749,75,750,751,752,753,754,755,756,757,758,759,76,760,761,762,7" +
        "63,764,765,766,767,768,769,77,770,771,772,773,774,775,776,777,778,779,78,780,781" +
        ",782,783,784,785,786,787,788,789,79,790,791,792,793,794,795,796,797,798,799,8,80" +
        ",800,801,802,803,804,805,806,807,808,809,81,810,811,812,813,814,815,816,817,818," +
        "819,82,820,821,822,823,824,825,826,827,828,829,83,830,831,832,833,834,835,836,83" +
        "7,838,839,84,840,841,842,843,844,845,846,847,848,849,85,850,851,852,853,854,855," +
        "856,857,858,859,86,860,861,862,863,864,865,866,867,868,869,87,870,871,872,873,87" +
        "4,875,876,877,878,879,88,880,881,882,883,884,885,886,887,888,889,89,890,891,892," +
        "893,894,895,896,897,898,899,9,90,900,901,902,903,904,905,906,907,908,909,91,910," +
        "911,912,913,914,915,916,917,918,919,92,920,921,922,923,924,925,926,927,928,929,9" +
        "3,930,931,932,933,934,935,936,937,938,939,94,940,941,942,943,944,945,946,947,948" +
        ",949,95,950,951,952,953,954,955,956,957,958,959,96,960,961,962,963,964,965,966,9" +
        "67,968,969,97,970,971,972,973,974,975,976,977,978,979,98,980,981,982,983,984,985" +
        ",986,987,988,989,99,990,991,992,993,994,995,996,997,998,999,A,C,L,R,")]
    public class EDIFACT_ID_7011
    {
    }
    
    /// <summary>
    // Characteristic identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,700,")]
    public class EDIFACT_ID_7037
    {
    }
    
    /// <summary>
    // Item characteristic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AT,B,C,COM,CT,E,L,LT,M,MT,NCM,STP,U,")]
    public class EDIFACT_ID_7081
    {
    }
    
    /// <summary>
    // Nature of cargo
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,E,M,O,T,")]
    public class EDIFACT_ID_7085
    {
    }
    
    /// <summary>
    // Item number type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,703,704,705,A,C,D,P,")]
    public class EDIFACT_ID_7143
    {
    }
    
    /// <summary>
    // Special service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,BR,C,D,E,F,G,K,L,M,P,R,S,V,")]
    public class EDIFACT_ID_7161
    {
    }
    
    /// <summary>
    // Hierarchical ID number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,700,701,702,703,704,705,706,707,708,709,710,711,712,")]
    public class EDIFACT_ID_7164
    {
    }
    
    /// <summary>
    // Rule part identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,")]
    public class EDIFACT_ID_7175
    {
    }
    
    /// <summary>
    // Sector/subject identification qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,700,701,702,703,")]
    public class EDIFACT_ID_7293
    {
    }
    
    /// <summary>
    // Processing indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,700,701,702,703,704,705,706,707,708,709,710,711,712,7SR,7TR,ACK,AEA,AF,AI,AT" +
        ",B,BS,C,CD,CM1,CN,CP2,CR,CY,DP,EC,EI,EW,F,FA,FE,FN,FT,FY,GC,HP,J,MH,MI,MP,MPP,N," +
        "NB,NP,NS,P,PA,PC,PI,PP,PS,PT,R,RD,SA,SS,T,TF,TP,VI,Y,YP,")]
    public class EDIFACT_ID_7365
    {
    }
    
    /// <summary>
    // Surface/layer indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Q6,Q7,")]
    public class EDIFACT_ID_7383
    {
    }
    
    /// <summary>
    // Identity number qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,I,N,O,P,Q,R,T,")]
    public class EDIFACT_ID_7405
    {
    }
    
    /// <summary>
    // Equipment code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",100,141,142,143,146,14F,14X,14Y,14Z,1L8,310,312,313,318,319,31F,31X,31Y,320,321,32S,330,332,333,340,342,343,345,346,380,38F,703,707,70F,70M,717,721,722,727,72A,72B,72C,72F,72M,72S,72X,72Y,731,732,733,734,735,736,737,738,739,73A,73F,73G,73H,73M,73S,73W,73X,73Y,740,741,742,743,744,747,74C,74D,74E,74F,74J,74L,74M,74R,74T,74U,74V,74X,74Y,752,753,757,75F,75M,762,763,764,767,76F,76X,76Y,772,773,777,7QM,A26,A28,A30,A32,A40,A4F,AB3,AB4,AB6,ABB,ABF,ABX,ABY,ACD,ACP,ACT,ALM,AMT,AN4,AN6,AN7,ANF,APH,AR1,AR7,AR8,ARJ,ARS,ARX,AT3,AT4,AT5,AT7,ATP,ATR,AX1,AX8,B11,B12,B13,B14,B15,B72,BE1,BE2,BE9,BEC,BEH,BEP,BES,BET,BH2,BNI,BNT,BUS,CCJ,CCX,CD2,CL4,CN1,CN2,CNA,CNC,CNJ,CNT,CR1,CR2,CR7,CR9,CRJ,CRV,CS2,CS5,CV4,CV5,CV6,CVF,CVR,CVV,CVX,CVY,CWC,D10,D11,D1C,D1F,D1M,D1X,D1Y,D28,D38,D3F,D6F,D85,D86,D87,D8A,D8B,D8F,D8L,D8M,D8Q,D8S,D8T,D8X,D8Y,D91,D92,D93,D94,D95,D9C,D9F,D9S,D9X,DAM,DC3,DC6,DC8,DC9,DCS,DF2,DF3,DFL,DH1,DH2,DH3,DH4,DH7,DH8,DHB,DHC,DHD,DHH,DHL,DHO,DHP,DHR,DHS,DHT,E70,E90,EM2,EMB,EMJ,EOV,ER3,ER4,ERD,ERJ,F21,F22,F23,F24,F27,F28,F50,F70,FA7,FK7,FRJ,GRG,GRJ,GRM,GRS,H25,HEC,HOV,HPH,HS7,HSF,I14,I93,I9F,I9M,I9X,I9Y,IAT,ICE,IL6,IL7,IL8,IL9,ILW,J31,J32,J41,JST,JU5,L10,L11,L15,L1F,L49,L4T,LCH,LMO,LOE,LOF,LOH,LOM,LRJ,M11,M1F,M1M,M80,M81,M82,M83,M87,M88,M90,M95,MBH,MD9,MIH,MTL,MU2,ND2,NDC,NDE,NDH,PA1,PA2,PAG,PAT,PL2,PL6,PN6,RFS,S20,S58,S61,S76,SF3,SH3,SH6,SHB,SHS,SSC,SWM,T20,TAT,TCM,TEE,TGV,THS,THT,TIC,TRN,TSL,TU3,TU5,VCV,VGF,WWP,YK2,YK4,YN2,YN7,YS1,")]
    public class EDIFACT_ID_7800
    {
    }
    
    /// <summary>
    // Accommodation type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,11,12,13,14,15,16,9,")]
    public class EDIFACT_ID_7904
    {
    }
    
    /// <summary>
    // Characteristic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7907
    {
    }
    
    /// <summary>
    // Transport stage qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,D,F,L,O,P,R,S,")]
    public class EDIFACT_ID_8051
    {
    }
    
    /// <summary>
    // Equipment qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,A,B,U,")]
    public class EDIFACT_ID_8053
    {
    }
    
    /// <summary>
    // Equipment size and type identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,")]
    public class EDIFACT_ID_8155
    {
    }
    
    /// <summary>
    // Full/empty indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class EDIFACT_ID_8169
    {
    }
    
    /// <summary>
    // Equipment status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class EDIFACT_ID_8249
    {
    }
    
    /// <summary>
    // Equipment identification number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PAG,")]
    public class EDIFACT_ID_8260
    {
    }
    
    /// <summary>
    // Movement type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",7AP,7AT,7CA,7CT,7EH,7FE,7PA,7PE,7PN,7PO,7RW,7SA,7SP,7TB,7TS,7US,7WH,WX,")]
    public class EDIFACT_ID_8335
    {
    }
    
    /// <summary>
    // Packing group
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_8339
    {
    }
    
    /// <summary>
    // Hazard code identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,II,III,")]
    public class EDIFACT_ID_8351
    {
    }
    
    /// <summary>
    // Status event
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,716,717,71" +
        "8,719,720,721,722,723,724,725,ACT,ALL,BKD,CHK,EST,EXP,MAX,MIN,PRG,SCH,ZZZ,")]
    public class EDIFACT_ID_9011
    {
    }
    
    /// <summary>
    // Status reason
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,GA,HA,NA,NB,PA,R10,R15,R30,R5,R60,TA,UA,WA,")]
    public class EDIFACT_ID_9013
    {
    }
    
    /// <summary>
    // Status type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,")]
    public class EDIFACT_ID_9015
    {
    }
    
    /// <summary>
    // Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,700,")]
    public class EDIFACT_ID_9143
    {
    }
    
    /// <summary>
    // Application error
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117," +
        "118,119,12,120,121,122,123,124,125,126,127,128,129,13,130,131,132,133,134,135,13" +
        "6,137,138,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154," +
        "155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,17" +
        "3,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,19,190,191," +
        "192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21," +
        "210,211,212,213,214,215,216,217,218,219,22,220,221,222,223,224,225,226,227,228,2" +
        "29,23,230,231,232,233,234,235,236,237,238,239,24,240,241,242,243,244,245,247,248" +
        ",249,25,250,251,252,253,254,255,256,257,258,259,26,260,261,262,263,264,265,266,2" +
        "67,268,269,27,270,271,272,273,274,275,276,277,278,279,28,280,281,282,283,284,285" +
        ",286,287,288,289,29,290,291,292,293,294,295,3,30,301,302,303,304,305,306,307,308" +
        ",309,31,310,311,312,313,314,315,316,317,318,319,32,320,321,322,323,324,325,326,3" +
        "27,328,329,33,330,331,332,333,334,335,336,337,338,339,34,340,341,342,343,344,345" +
        ",346,347,348,349,35,350,351,352,353,354,356,357,36,360,361,362,363,364,365,366,3" +
        "67,368,369,37,370,371,372,373,374,375,376,377,378,379,38,380,381,382,383,384,385" +
        ",386,387,388,389,39,390,391,392,393,394,395,396,397,398,399,4,40,400,401,403,404" +
        ",405,406,407,408,409,41,410,411,412,413,414,415,416,417,418,419,42,420,421,422,4" +
        "23,424,425,426,427,428,429,43,430,431,432,433,434,435,436,437,438,439,44,440,441" +
        ",442,443,444,445,446,447,448,449,45,450,451,452,453,454,455,456,457,458,459,46,4" +
        "60,461,462,463,464,465,466,467,468,469,47,470,471,472,473,48,49,5,50,51,52,53,54" +
        ",55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,700,701,702,703,704,705,706" +
        ",707,708,709,70A,70B,70C,70D,70E,70F,70G,70H,70I,70J,70K,70L,70M,70N,70O,70P,70Q" +
        ",70R,70S,70T,70U,70V,70W,70X,70Y,70Z,71,710,711,712,713,714,715,716,717,718,719," +
        "71A,71B,71C,71D,71E,71F,71G,71H,71I,71J,71K,71L,71M,71N,71O,71P,71Q,71R,71S,71T," +
        "71U,71V,71W,71X,71Y,71Z,72,720,721,722,723,724,725,726,727,728,729,72A,72B,72C,7" +
        "2D,72E,72F,72G,72H,72I,72J,72K,72L,72M,72N,72O,72P,72Q,72R,72S,72T,72U,72V,72W,7" +
        "2X,72Y,72Z,73,730,731,732,733,734,735,736,737,738,739,73A,73B,73C,73D,73E,73F,73" +
        "G,73H,73I,73J,73K,73L,73M,73N,73O,73P,73Q,73R,73S,73T,73U,73V,73W,73X,73Y,73Z,74" +
        ",740,741,742,743,744,745,746,747,748,749,74A,74B,74C,74D,74E,74F,74G,74H,74I,74J" +
        ",74K,74L,74M,74N,74O,74P,74Q,74R,74S,74T,74U,74V,74W,74X,74Y,74Z,75,750,751,752," +
        "753,754,755,756,757,758,759,75A,75B,75C,75D,75E,75F,75G,75H,75I,75J,75K,75L,75M," +
        "75N,75O,75P,75Q,75R,75S,75T,75U,75V,75W,75X,75Y,75Z,76,760,761,762,763,764,765,7" +
        "66,767,768,769,76A,76B,76C,76D,76E,76F,76G,76H,76I,76J,77,770,771,772,773,774,77" +
        "5,776,777,778,779,78,780,781,782,783,784,785,786,787,788,789,790,791,792,793,794" +
        ",795,796,797,798,799,79A,79B,79C,79D,79E,79F,79G,79H,79I,79J,79K,79L,79M,79N,79O" +
        ",79P,79Q,79R,79S,79T,79U,8,800,9,900,901,902,903,911,912,913,914,915,916,917,")]
    public class EDIFACT_ID_9321
    {
    }
    
    /// <summary>
    // Government action
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_9417
    {
    }
    
    /// <summary>
    // Associated option information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,700,701,702,703,704,705,706,707,708,709,710,711,712,8,9,")]
    public class EDIFACT_ID_9749
    {
    }
    
    /// <summary>
    // Option
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",0,1,12C,1ST,2,2ND,3,3RD,4,5,6,7,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,716,717,718,719,720,721,722,723,724,725,726,727,728,729,730,731,732,733,734,735,736,737,738,739,740,741,742,743,744,745,746,747,748,749,750,751,752,753,754,755,756,757,758,759,760,761,762,763,764,765,766,767,768,769,770,771,772,773,774,775,AA,AB,ABA,ABD,AC,AD,ADC,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,ATC,AU,AV,AW,AX,AY,AZ,BA,BAG,BB,BC,BCL,BD,BE,BEN,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BST,BT,BU,BUS,BV,BW,BX,BY,BZ,CA,CB,CC,CD,CE,CF,CG,CGT,CH,CHC,CHK,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CRD,CTO,DCL,DEL,DIC,DIS,DIV,DOP,EAR,ENG,FBG,FCL,FCT,FIN,FIR,FND,FST,GCL,GFR,GRD,GTG,GTO,HEN,HST,JET,LAN,LBG,MND,MST,MZC,MZO,NAA,NAB,NAC,NAD,NAE,NAF,NAG,NAH,NAI,NAJ,NAK,NAL,NAM,NAN,NAO,NAP,NAQ,NAR,NAS,NAT,NAU,NAV,NAW,NAX,NAY,NAZ,NBA,NBB,NBC,NBD,NBE,NBF,NBG,NBH,NBI,NBJ,NBK,NBL,NBM,NBN,NBO,NBP,NBQ,NBR,NBS,NBT,NBU,NBV,NBW,NBX,NBY,NBZ,NCA,NCB,NCC,NCD,NCE,NCF,NCG,NCH,NCI,NCJ,NCK,NCL,NCM,NCN,NCO,NCP,NCQ,OFB,OFS,ONB,ONS,P1,P10,P2,P3,P4,P5,P6,P7,PBK,RDT,RFA,RST,SAT,SCT,SPE,SRT,STK,TDN,TDP,TEN,THM,TKO,UNS,WAB,")]
    public class EDIFACT_ID_9750
    {
    }
    
    /// <summary>
    // Application identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_9755
    {
    }
    
    /// <summary>
    // Application identification qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_9756
    {
    }
    
    /// <summary>
    // Reservation booking designator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,K,L,M,P,Q,R,S,T,U,V,W,Y,")]
    public class EDIFACT_ID_9800
    {
    }
    
    /// <summary>
    // Host qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,A,H,")]
    public class EDIFACT_ID_9803
    {
    }
    
    /// <summary>
    // No smoking indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,P,S,U,X,")]
    public class EDIFACT_ID_9807
    {
    }
    
    /// <summary>
    // Confirmation indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class EDIFACT_ID_9813
    {
    }
    
    /// <summary>
    // Availability of a boarding pass printer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class EDIFACT_ID_9817
    {
    }
    
    /// <summary>
    // Passenger type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,F,M,")]
    public class EDIFACT_ID_9819
    {
    }
    
    /// <summary>
    // Reservation status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",OK,RQ,SA,WL,")]
    public class EDIFACT_ID_9822
    {
    }
    
    /// <summary>
    // Seat characteristic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1M,1W,2,20,21,22,23,24,25,26,27,28,3,3A,3B,4,5,6,6A,6B,7,700,701,702,7A,7B,8,9,A,AA,AB,AC,AG,AJ,AL,AM,AR,AS,AT,AU,AV,AW,B,BA,BK,C,CC,CH,CL,CS,D,DE,E,EA,EC,EK,EX,F,FC,G,GF,GN,GR,H,I,IA,IE,J,K,KA,KN,L,LA,LG,LH,LS,M,MA,N,O,OW,PC,Q,RS,S,SO,ST,T,TA,U,UP,V,W,WA,X,Z,")]
    public class EDIFACT_ID_9825
    {
    }
    
    /// <summary>
    // Reason for seat adjustment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,M,U,")]
    public class EDIFACT_ID_9833
    {
    }
    
    /// <summary>
    // Pooled checked bag indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class EDIFACT_ID_9834
    {
    }
    
    /// <summary>
    // Error/warning message number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,104,11,12,13,14,15,16,17,18,185,186,187,188,189,19,190,191,192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21,210,211,212,213,214,215,217,218,22,223,224,225,226,227,228,229,23,230,231,232,233,234,235,236,237,238,239,24,240,244,245,246,247,248,249,25,250,251,252,253,254,255,256,257,258,259,26,260,261,262,263,264,265,266,267,268,269,27,270,271,272,273,274,275,276,277,278,279,28,280,281,282,283,284,285,286,287,288,289,29,290,291,292,293,294,295,296,297,298,299,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,700,701,702,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,")]
    public class EDIFACT_ID_9845
    {
    }
    
    /// <summary>
    // Issue/reissue boarding pass indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class EDIFACT_ID_9850
    {
    }
    
    /// <summary>
    // Outbound flight continuation indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,T,")]
    public class EDIFACT_ID_9856
    {
    }
    
    /// <summary>
    // Inbound type of service indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,F,P,R,T,")]
    public class EDIFACT_ID_9857
    {
    }
    
    /// <summary>
    // Update action code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,R,")]
    public class EDIFACT_ID_9858
    {
    }
    
    /// <summary>
    // Reason for cancel
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_9859
    {
    }
    
    /// <summary>
    // Type of cancel
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,F,O,R,")]
    public class EDIFACT_ID_9860
    {
    }
    
    /// <summary>
    // Seat request fulfilled indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class EDIFACT_ID_9862
    {
    }
    
    /// <summary>
    // Cabin class location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",L,M,U,")]
    public class EDIFACT_ID_9863
    {
    }
    
    /// <summary>
    // Row characteristic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,11,12,13,14,15,16,17,18,19,20,21,23,24,25,26,27,A,B,C,CC,D,E,EC,EL,ER,I,K,L,M" +
        ",MV,N,S,U,X,XC,Z,")]
    public class EDIFACT_ID_9864
    {
    }
    
    /// <summary>
    // Seat occupation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,D,E,F,G,H,I,M,N,O,P,Q,R,S,T,U,V,X,Y,Z,")]
    public class EDIFACT_ID_9865
    {
    }
    
    /// <summary>
    // Complexing passenger indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class EDIFACT_ID_9867
    {
    }
    
    /// <summary>
    // Response type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,F,I,P,S,U,X,")]
    public class EDIFACT_ID_9868
    {
    }
    
    /// <summary>
    // Processing status code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,X,")]
    public class EDIFACT_ID_9869
    {
    }
    
    /// <summary>
    // Flight service code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,F,G,H,M,N,Q,U,")]
    public class EDIFACT_ID_9871
    {
    }
    
    /// <summary>
    // Cabin class of service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_9873
    {
    }
    
    /// <summary>
    // Conversion type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,703,704,705,706,707,B,C,D,E,F,G,H,M,N,P,Q,R,S,T,")]
    public class EDIFACT_ID_9875
    {
    }
    
    /// <summary>
    // Processing level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,")]
    public class EDIFACT_ID_9876
    {
    }
    
    /// <summary>
    // Fare type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,2,3,4,5,6,7,700,8,9,")]
    public class EDIFACT_ID_9877
    {
    }
    
    /// <summary>
    // Identification code set designator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ATA1,IAT1,")]
    public class EDIFACT_ID_9879
    {
    }
    
    /// <summary>
    // Column description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",9,A,CH,W,")]
    public class EDIFACT_ID_9882
    {
    }
    
    /// <summary>
    // Seat occupation default indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,N,O,R,")]
    public class EDIFACT_ID_9883
    {
    }
    
    /// <summary>
    // Passenger with infant indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class EDIFACT_ID_9884
    {
    }
    
    /// <summary>
    // Online/interline indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,")]
    public class EDIFACT_ID_9885
    {
    }
    
    /// <summary>
    // Form of payment identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AGT,CA,CC,CK,DP,GR,MS,NR,PT,SGR,UN,")]
    public class EDIFACT_ID_9888
    {
    }
    
    /// <summary>
    // Source
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,F,M,S,")]
    public class EDIFACT_ID_9890
    {
    }
    
    /// <summary>
    // Identification type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,703,704,705,706,B,")]
    public class EDIFACT_ID_9893
    {
    }
    
    /// <summary>
    // Company identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",700,701,702,703,7YY,AAH,AAL,AAR,AAW,ABR,ACA,ACI,ADR,AEA,AEE,AEW,AFG,AFL,AFR,AGN,AHY,AIC,AIZ,AJM,ALK,AMC,AML,AMU,AMX,ANA,ANG,ANS,ANZ,ARG,ASA,ATC,AUA,AUI,AUT,AVA,AVN,AWE,AZA,AZW,BAG,BAW,BBC,BCS,BCY,BEE,BER,BKP,BLF,BMA,BOT,BPA,BRA,BRU,BRZ,BWA,BWG,CAL,CAW,CCA,CDG,CES,CHH,CIM,CLH,CLX,CMI,CMP,COA,CPA,CPN,CRL,CSA,CSN,CTN,CUB,CXA,CYP,DAH,DAL,DAT,DHK,DHX,DLH,DNM,DTA,EIN,ELG,ELL,ELY,ETD,ETH,EVA,EWG,FCN,FDX,FEA,FIN,FJI,GBL,GEC,GFA,GIA,HCY,HDA,HEJ,HLF,IAC,IAW,IBB,IBE,ICE,ICL,IRA,IRC,IRM,ISR,ISS,IYE,JAI,JAL,JAT,JAZ,JKK,KAC,KAL,KHA,KLM,KOR,KQA,KRP,LAA,LAM,LAN,LAP,LBC,LCO,LDA,LGL,LIL,LLB,LOT,LPE,LRC,LTU,LXR,MAH,MAK,MAS,MAU,MAZ,MDG,MEA,MGL,MGX,MLD,MPX,MRS,MSR,MXA,NCA,NMB,NTW,NWA,OAL,OAS,PAL,PAO,PGA,PIA,PLK,PNW,PUA,QFA,QTR,RAM,RBA,REU,RJA,ROT,RSN,SAA,SAS,SAT,SBI,SER,SEY,SIA,SKX,SLA,SLK,SLM,SOL,SUD,SVA,SWR,SYR,TAI,TAP,TAR,TAY,THA,THT,THY,TMA,TNA,TSO,TUA,UAE,UAL,UPS,USA,UYC,VGN,VIR,VLE,VLK,VRG,VSP,VTA,WIF,WNT,")]
    public class EDIFACT_ID_9906
    {
    }
    
    /// <summary>
    // Fare qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,700,701,702,703,704,705,706,707,708,709,70A,70B,70C,70D,70E,70F,70G,70H,70I,70J,70K,70L,70M,710,711,712,713,714,715,716,717,718,719,720,721,722,723,724,725,726,727,728,729,730,731,732,733,734,735,736,737,738,739,740,741,742,743,744,745,746,747,748,749,750,751,752,753,754,755,756,757,758,759,760,761,762,763,764,765,766,767,768,769,770,771,772,773,774,775,776,777,778,779,780,781,782,783,784,785,786,787,788,789,790,791,792,793,794,795,796,797,798,799,")]
    public class EDIFACT_ID_9910
    {
    }
    
    /// <summary>
    // Facility type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,2,3,4,5,6,7,700,701,8,9,ABU,AIR,BAG,BEL,BUS,CAT,CHK" +
        ",CLN,COU,CRW,CUB,FIR,FUE,GAN,GTE,ICE,JET,LIT,LND,LOU,LUG,PAR,PIE,POW,PUB,SAT,SHU" +
        ",STD,STF,TAN,TER,TOW,TWB,WAS,WAT,")]
    public class EDIFACT_ID_9932
    {
    }
    
    /// <summary>
    // Traveler accompanied by infant
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_9946
    {
    }
    
    /// <summary>
    // Complexing flight indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_9950
    {
    }
    
    /// <summary>
    // Reservation control type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,D,Q,R,")]
    public class EDIFACT_ID_9958
    {
    }
    
    /// <summary>
    // Special requirement data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",356,357,358,359,360,361,362,363,364,365,366,367,368,369,370,371,372,373,374,375," +
        "376,377,378,379,380,381,382,383,384,385,386,387,388,389,390,391,392,393,394,395," +
        "396,397,398,399,400,401,402,403,404,405,406,407,408,409,410,411,412,413,414,415," +
        "416,417,")]
    public class EDIFACT_ID_9960
    {
    }
    
    /// <summary>
    // Special requirement type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,700,701,")]
    public class EDIFACT_ID_9962
    {
    }
    
    /// <summary>
    // Traffic restriction qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_9966
    {
    }
    
    /// <summary>
    // Traffic restriction type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_9968
    {
    }
    
    /// <summary>
    // Product details qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,BAS,CLB,CTA,DOM,ECO,EQP,FST,INT,OB,OC,PAR,PER,SB,SC,SCH,SHU,TRB," +
        "")]
    public class EDIFACT_ID_9970
    {
    }
    
    /// <summary>
    // Originator type code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,N,P,R,S,T,V,W,X,Y,")]
    public class EDIFACT_ID_9972
    {
    }
    
    /// <summary>
    // Row location qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,M,R,")]
    public class EDIFACT_ID_9976
    {
    }
    
    /// <summary>
    // Cabin facilities characteristic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,AR,BA,BK,CL,D,E,G,LA,LG,MV,SO,ST,TA,")]
    public class EDIFACT_ID_9978
    {
    }
    
    /// <summary>
    // Information type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,101,102,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,45,46,47,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,716,717,718,719,720,721,722,723,724,725,726,727,728,729,730,731,732,733,734,735,7EX,7FC,7NU,7NV,7RV,8,9,AHS,BD,BI,DHS,FAA,ISR,OD,OI,TXT,")]
    public class EDIFACT_ID_9980
    {
    }
    
    /// <summary>
    // Type of call at port
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class EDIFACT_ID_9984
    {
    }
    
    /// <summary>
    // Data indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,3,4,5,6,7,8,9,AFT,BEF,DOM," +
        "ECA,EMP,INT,LOC,NOT,SCH,STP,TCT,TIM,TOT,TRA,TRS,TWT,VAL,")]
    public class EDIFACT_ID_9988
    {
    }
    
    /// <summary>
    // Data type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,ADT,ARE,BAG,CHD,CRO," +
        "CRW,CUS,DEL,DHD,FEM,FRT,INF,MAI,MAL,NOI,NOT,NRV,PAX,REV,TME,TOF,")]
    public class EDIFACT_ID_9989
    {
    }
    
    /// <summary>
    // Material type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ADM,AT1,AT2,BDP,CVP,GEN,HVP,INV,ITI,TAT,")]
    public class EDIFACT_ID_9997
    {
    }
    
    /// <summary>
    // Baggage claim type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",OTH,REG,SIZ,SKI,")]
    public class EDIFACT_ID_BAG
    {
    }
    
    /// <summary>
    // Balance output
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_BAL
    {
    }
    
    /// <summary>
    // Special cargo codes
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_CAR
    {
    }
    
    /// <summary>
    // Check-in type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BAG,DSK,GRP,KIK,ODD,")]
    public class EDIFACT_ID_CHK
    {
    }
    
    /// <summary>
    // Items for Dry Operating Weight/Index
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_DOW
    {
    }
    
    /// <summary>
    // Special emphasis codes
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CH,FF,IN,MT,NC,OL,PC,PO,RD,SC,ST,TM,UN,VP,")]
    public class EDIFACT_ID_EMP
    {
    }
    
    /// <summary>
    // Variation for weights
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_VAR
    {
    }
}
