namespace EdiFabric.Rules.EANCOM_D01BEAN3
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    public class EDIFACT_N
    {
    }
    
    [Serializable()]
    public class EDIFACT_AN
    {
    }
    
    [Serializable()]
    [EdiCodes(",124,125,")]
    public class EDIFACT_ID_5025
    {
    }
    
    [Serializable()]
    [EdiCodes(@",ADP,AED,AFA,ALL,AMD,ANG,AOA,AOK,ARA,ARS,ATS,AUD,AWG,AZM,BAM,BBD,BDT,BEC,BEF,BEL,BGL,BGN,BHD,BIF,BMD,BND,BOB,BOV,BRC,BRL,BSD,BTN,BUK,BWP,BYB,BYR,BZD,CAD,CDF,CHF,CLF,CLP,CNY,COP,CRC,CUP,CVE,CYP,CZK,DEM,DJF,DKK,DOP,DZD,ECS,ECV,EEK,EGP,ERN,ESP,ETB,EUR,FIM,FJD,FKP,FRF,GBP,GEL,GHC,GIP,GMD,GNF,GRD,GTQ,GWP,GYD,HKD,HNL,HRD,HRK,HTG,HUF,IDR,IEP,ILS,INR,IQD,IRR,ISK,ITL,JMD,JOD,JPY,KES,KGS,KHR,KMF,KPW,KRW,KWD,KYD,KZT,LAK,LBP,LKR,LRD,LSL,LTL,LUC,LUF,LUL,LVL,LYD,MAD,MDL,MGF,MKD,MNT,MOP,MRO,MTL,MUR,MVR,MWK,MXN,MXV,MYR,MZM,NAD,NGN,NIC,NIO,NLG,NOK,NPR,NZD,OMR,PAB,PEI,PEN,PGK,PHP,PKR,PLN,PTE,PYG,QAR,ROL,RUB,RWF,SAR,SBD,SCR,SDD,SEK,SGD,SHP,SIT,SKK,SLL,SOS,SRG,STD,SVC,SYP,SZL,THB,TJR,TMM,TND,TOP,TPE,TRL,TTD,TWD,TZS,UAH,UGX,USD,USN,USS,UYU,UZS,VEB,VND,VUV,WST,XAF,XAG,XAU,XBA,XBB,XBC,XBD,XCD,XDR,XEU,XFO,XFU,XOF,XPD,XPF,XTS,XXX,YDD,YER,YUM,YUN,ZAR,ZMK,ZWD,")]
    public class EDIFACT_ID_6345
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,10E,11,12,13,14,15,17,3,4,5,8,9,")]
    public class EDIFACT_ID_6343
    {
    }
    
    [Serializable()]
    [EdiCodes(@",1,10,100,101,102,103,11,110,12,13,14,15,16,17,18,19,1E,20,20E,21,21E,22,22B,22E,23,23E,24,24E,25,26,26E,27,27E,28,28E,29,29E,2E,3,30,30E,31,314,315,316,317,319,31E,32,324,326,327,328,329,32E,33,330,34,34E,35,355,356,357,35E,36,36E,37,37B,37E,38,38E,39,39E,4,40,45,46,47,48,49,49E,4E,5,50,50E,57E,58,58E,59,59E,5E,6,60,60E,62E,63,64,64B,64E,65,65E,66,67,68,69E,6E,7,70,70E,71,71B,71E,72,72B,72E,73,73E,74,74B,74E,75E,76E,77,77B,77E,78,78E,79,79E,7E,8,80,80E,81,81E,82,82E,83,83E,84,84E,85,85E,86,86E,87E,88,89,8E,9,90,91,92,93,94,95,96,97,98,99,9E,CSA,CSC,CSD,CSE,X33,X34,X35,X37,X38,X39,X40,X41,")]
    public class EDIFACT_ID_4405
    {
    }
    
    [Serializable()]
    [EdiCodes(@",AD,AE,AF,AG,AI,AL,AM,AN,AO,AQ,AR,AS,AT,AU,AW,AZ,BA,BB,BD,BE,BF,BG,BH,BI,BJ,BM,BN,BO,BR,BS,BT,BV,BW,BY,BZ,CA,CC,CD,CF,CG,CH,CI,CK,CL,CM,CN,CO,CR,CU,CV,CX,CY,CZ,DE,DJ,DK,DM,DO,DZ,EC,EE,EG,EH,ER,ES,ET,EU,FI,FJ,FK,FM,FO,FR,GA,GB,GD,GE,GF,GH,GI,GL,GM,GN,GP,GQ,GR,GS,GT,GU,GW,GY,HK,HM,HN,HR,HT,HU,ID,IE,IL,IN,IO,IQ,IR,IS,IT,JM,JO,JP,KE,KG,KH,KI,KM,KN,KP,KR,KW,KY,KZ,LA,LB,LC,LI,LK,LR,LS,LT,LU,LV,LY,MA,MC,MD,MG,MH,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,NA,NC,NE,NF,NG,NI,NL,NO,NP,NR,NU,NZ,OM,PA,PE,PF,PG,PH,PK,PL,PM,PN,PR,PS,PT,PW,PY,QA,RE,RO,RU,RW,SA,SB,SC,SD,SE,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SR,ST,SV,SY,SZ,TC,TD,TF,TG,TH,TJ,TK,TM,TN,TO,TP,TR,TT,TV,TW,TZ,UA,UG,UM,US,UY,UZ,VA,VC,VE,VG,VI,VN,VU,WF,WS,YE,YT,YU,ZA,ZM,ZW,")]
    public class EDIFACT_ID_3239
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,8,9,")]
    public class EDIFACT_ID_9213
    {
    }
    
    [Serializable()]
    [EdiCodes(",116,140,141,15,6,76E,79E,")]
    public class EDIFACT_ID_4183
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,C,")]
    public class EDIFACT_ID_5463
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,5,6,")]
    public class EDIFACT_ID_4471
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_1227
    {
    }
    
    [Serializable()]
    [EdiCodes(",AEK,AJ,CAC,EAB,FC,FI,HD,QD,")]
    public class EDIFACT_ID_7161
    {
    }
    
    [Serializable()]
    [EdiCodes(",106,132,154,157,166,174,1E,23,25,2E,ADR,BR,CA,CO,FL,HMT,SRN,ST,SZ,ZZZ,")]
    public class EDIFACT_ID_1131
    {
    }
    
    [Serializable()]
    [EdiCodes(",10,112,113,116,131,136,17,182,2,200,245,246,260,28,281,286,3,5,6,60,65,68,7,8,83" +
        ",84,86,87,88,89,9,90,91,92,CEN,PMS,RAL,TGA,X4,X5,X6,X7,ZZZ,")]
    public class EDIFACT_ID_3055
    {
    }
    
    [Serializable()]
    [EdiCodes(",64E,69,")]
    public class EDIFACT_ID_5189
    {
    }
    
    [Serializable()]
    [EdiCodes(",5,7,")]
    public class EDIFACT_ID_5283
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,E,S,")]
    public class EDIFACT_ID_5305
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5273
    {
    }
    
    [Serializable()]
    [EdiCodes(",GST,VAT,")]
    public class EDIFACT_ID_5153
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,11,137,200,263,325,35,36,44E,454,50,")]
    public class EDIFACT_ID_2005
    {
    }
    
    [Serializable()]
    [EdiCodes(",102,203,718,")]
    public class EDIFACT_ID_2379
    {
    }
    
    [Serializable()]
    [EdiCodes(",AAB,AAJ,AAK,AFO,AIZ,ALL,AMT,APQ,CD,CR,DL,DQ,IV,ON,PL,RF,VN,")]
    public class EDIFACT_ID_1153
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,11,15,2,26,7,")]
    public class EDIFACT_ID_6069
    {
    }
    
    [Serializable()]
    [EdiCodes(",KGM,LTR,")]
    public class EDIFACT_ID_6411
    {
    }
    
    [Serializable()]
    public class EDIFACT_A
    {
    }
    
    [Serializable()]
    [EdiCodes(",8,9,")]
    public class EDIFACT_ID_3227
    {
    }
    
    [Serializable()]
    [EdiCodes(",3,6,")]
    public class EDIFACT_ID_4055
    {
    }
    
    [Serializable()]
    [EdiCodes(",DF,PC,")]
    public class EDIFACT_ID_4215
    {
    }
    
    [Serializable()]
    [EdiCodes(",01E,02E,03E,04E,CFR,CIF,CIP,CPT,DAF,DDP,DDU,DEQ,DES,EXW,FAS,FCA,FOA,FOB,FOR,RDN," +
        "RPD,SD,")]
    public class EDIFACT_ID_4053
    {
    }
    
    [Serializable()]
    [EdiCodes(",20,")]
    public class EDIFACT_ID_8051
    {
    }
    
    [Serializable()]
    [EdiCodes(",BS,SB,")]
    public class EDIFACT_ID_8101
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_8281
    {
    }
    
    [Serializable()]
    [EdiCodes(@",AD,AE,AF,AG,AI,AL,AM,AN,AO,AQ,AR,AS,AT,AU,AW,AZ,BA,BB,BD,BE,BF,BG,BH,BI,BJ,BM,BN,BO,BR,BS,BT,BV,BW,BY,BZ,CA,CC,CD,CF,CG,CH,CI,CK,CL,CM,CN,CO,CR,CU,CV,CX,CY,CZ,DE,DJ,DK,DM,DO,DZ,EC,EE,EG,EH,ER,ES,ET,FI,FJ,FK,FM,FO,FR,GA,GB,GD,GE,GF,GH,GI,GL,GM,GN,GP,GQ,GR,GS,GT,GU,GW,GY,HK,HM,HN,HR,HT,HU,ID,IE,IL,IN,IO,IQ,IR,IS,IT,JM,JO,JP,KE,KG,KH,KI,KM,KN,KP,KR,KW,KY,KZ,LA,LB,LC,LI,LK,LR,LS,LT,LU,LV,LY,MA,MC,MD,MG,MH,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,NA,NC,NE,NF,NG,NI,NL,NO,NP,NR,NU,NZ,OM,PA,PE,PF,PG,PH,PK,PL,PM,PN,PR,PS,PT,PW,PY,QA,RE,RO,RU,RW,SA,SB,SC,SD,SE,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SR,ST,SV,SY,SZ,TC,TD,TF,TG,TH,TJ,TK,TM,TN,TO,TP,TR,TT,TV,TW,TZ,UA,UG,UM,US,UY,UZ,VA,VC,VE,VG,VI,VN,VU,WF,WS,YE,YT,YU,ZA,ZM,ZW,")]
    public class EDIFACT_ID_8453
    {
    }
    
    [Serializable()]
    [EdiCodes(",23,25,31,")]
    public class EDIFACT_ID_8179
    {
    }
    
    [Serializable()]
    [EdiCodes(",10,20,30,40,")]
    public class EDIFACT_ID_8067
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_5419
    {
    }
    
    [Serializable()]
    [EdiCodes(",12,15,16,7,")]
    public class EDIFACT_ID_5245
    {
    }
    
    [Serializable()]
    [EdiCodes(",13,")]
    public class EDIFACT_ID_5249
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_6063
    {
    }
    
    [Serializable()]
    [EdiCodes(",BO,BS,BY,CN,CS,DP,II,IV,LC,LD,PE,RE,SE,SN,SR,ST,SU,")]
    public class EDIFACT_ID_3035
    {
    }
    
    [Serializable()]
    [EdiCodes(@",AD,AE,AF,AG,AI,AL,AM,AN,AO,AQ,AR,AS,AT,AU,AW,AZ,BA,BB,BD,BE,BF,BG,BH,BI,BJ,BM,BN,BO,BR,BS,BT,BV,BW,BY,BZ,CA,CC,CD,CF,CG,CH,CI,CK,CL,CM,CN,CO,CR,CU,CV,CX,CY,CZ,DE,DJ,DK,DM,DO,DZ,EC,EE,EG,EH,ER,ES,ET,FI,FJ,FK,FM,FO,FR,GA,GB,GD,GE,GF,GH,GI,GL,GM,GN,GP,GQ,GR,GS,GT,GU,GW,GY,HK,HM,HN,HR,HT,HU,ID,IE,IL,IN,IO,IQ,IR,IS,IT,JM,JO,JP,KE,KG,KH,KI,KM,KN,KP,KR,KW,KY,KZ,LA,LB,LC,LI,LK,LR,LS,LT,LU,LV,LY,MA,MC,MD,MG,MH,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,NA,NC,NE,NF,NG,NI,NL,NO,NP,NR,NU,NZ,OM,PA,PE,PF,PG,PH,PK,PL,PM,PN,PR,PS,PT,PW,PY,QA,RE,RO,RU,RW,SA,SB,SC,SD,SE,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SR,ST,SV,SY,SZ,TC,TD,TF,TG,TH,TJ,TK,TM,TN,TO,TP,TR,TT,TV,TW,TZ,UA,UG,UM,US,UY,UZ,VA,VC,VE,VG,VI,VN,VU,WF,WS,YE,YT,YU,ZA,ZM,ZW,")]
    public class EDIFACT_ID_3207
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_3045
    {
    }
    
    [Serializable()]
    [EdiCodes(",BN,")]
    public class EDIFACT_ID_7405
    {
    }
    
    [Serializable()]
    [EdiCodes(",33E,")]
    public class EDIFACT_ID_4233
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_8275
    {
    }
    
    [Serializable()]
    [EdiCodes(",PD,SO,TL,")]
    public class EDIFACT_ID_6311
    {
    }
    
    [Serializable()]
    [EdiCodes(",AAA,HT,LN,WD,")]
    public class EDIFACT_ID_6313
    {
    }
    
    [Serializable()]
    [EdiCodes(",3,4,")]
    public class EDIFACT_ID_6321
    {
    }
    
    [Serializable()]
    [EdiCodes(",42,43,44,45,")]
    public class EDIFACT_ID_6155
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,3,")]
    public class EDIFACT_ID_8395
    {
    }
    
    [Serializable()]
    [EdiCodes(",3,")]
    public class EDIFACT_ID_8393
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,S,")]
    public class EDIFACT_ID_7077
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AC,ACU,ADU,AQ,AT,ATC,BAN,BP,BU,BZ,CG,DW,EN,GB,GD,GLN,GN,GU,HS,IB,IN,IS,IT,LI," +
        "MF,MN,NB,PGC,PV,RVM,SA,SN,SPP,SRS,SRT,SRU,SRV,ST,UP,")]
    public class EDIFACT_ID_7143
    {
    }
    
    [Serializable()]
    [EdiCodes(",AE,CR,CX,")]
    public class EDIFACT_ID_7065
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,1E,2,3,")]
    public class EDIFACT_ID_7075
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,31,32,33,4,5,50,51,52,53,54,LAB,NBR,")]
    public class EDIFACT_ID_7233
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_7073
    {
    }
    
    [Serializable()]
    [EdiCodes(",MF,")]
    public class EDIFACT_ID_4043
    {
    }
    
    [Serializable()]
    [EdiCodes(",AJT,")]
    public class EDIFACT_ID_4295
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,")]
    public class EDIFACT_ID_5393
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,I,S,")]
    public class EDIFACT_ID_5213
    {
    }
    
    [Serializable()]
    [EdiCodes(",AAA,AAB,AAE,AAF,")]
    public class EDIFACT_ID_5125
    {
    }
    
    [Serializable()]
    [EdiCodes(",CA,CT,")]
    public class EDIFACT_ID_5375
    {
    }
    
    [Serializable()]
    [EdiCodes(",DPR,PPR,PRP,RTP,SRP,")]
    public class EDIFACT_ID_5387
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10E,20,22,3,7,")]
    public class EDIFACT_ID_4279
    {
    }
    
    [Serializable()]
    [EdiCodes(",5,")]
    public class EDIFACT_ID_2475
    {
    }
    
    [Serializable()]
    [EdiCodes(",3,")]
    public class EDIFACT_ID_2009
    {
    }
    
    [Serializable()]
    [EdiCodes(",D,M,WD,Y,")]
    public class EDIFACT_ID_2151
    {
    }
    
    [Serializable()]
    [EdiCodes(",ZZZ,")]
    public class EDIFACT_ID_4277
    {
    }
    
    [Serializable()]
    [EdiCodes(",PUR,ZZZ,")]
    public class EDIFACT_ID_4451
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_4453
    {
    }
    
    [Serializable()]
    [EdiCodes(@",AA,AB,AF,AM,AR,AS,AY,AZ,BA,BE,BG,BH,BI,BN,BO,BR,CA,CO,CS,CY,DA,DE,DZ,EL,EN,EO,ES,ET,EU,FA,FI,FJ,FO,FR,FY,GA,GD,GL,GN,GU,HA,HE,HI,HR,HU,HY,IA,ID,IE,IK,IS,IT,IU,JA,JW,KA,KK,KL,KM,KN,KO,KS,KU,KY,LA,LN,LO,LT,LV,MG,MI,MK,ML,MN,MO,MR,MS,MT,NA,NE,NL,NO,OC,OM,OR,PA,PL,PS,PT,QU,RM,RN,RO,RU,RW,SA,SD,SG,SH,SI,SK,SL,SM,SN,SO,SQ,SR,SS,ST,SU,SV,SW,TA,TE,TG,TH,TI,TK,TL,TN,TO,TR,TS,TT,TW,UG,UK,UR,UZ,VI,VO,WO,YI,YO,ZA,ZH,ZU,")]
    public class EDIFACT_ID_3453
    {
    }
    
    [Serializable()]
    [EdiCodes(",1E,2E,3E,4E,")]
    public class EDIFACT_ID_4441
    {
    }
    
    [Serializable()]
    [EdiCodes(",BP,CP,OW,TW,")]
    public class EDIFACT_ID_4221
    {
    }
    
    [Serializable()]
    [EdiCodes(",CU,DU,RC,SER,TU,VQ,")]
    public class EDIFACT_ID_7009
    {
    }
    
    [Serializable()]
    [EdiCodes(@",120,126,13,132,169,196,197,2,27,3,31,35,38,4,44,45,46,47,6,61,72,75,76,77,78,79,80,81,82,83,84,85,86,98,ANM,AVI,BPD,BRN,BVP,DSC,ECO,EDS,GDC,HAN,HAZ,IDC,IRC,ISC,ISY,KEY,MNF,NAV,RLI,SDS,SGR,STE,TDS,TPE,U02,U07,U08,U09,UP2,UP4,UP5,UP6,UP7,UP8,UP9,UQ1,UQ2,UQ3,UQ5,WVL,")]
    public class EDIFACT_ID_7081
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,4,5,")]
    public class EDIFACT_ID_4347
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,11E,12E,13E,14E,2,23,24,3,38,4,5,55,6,7,96,XB6,YF2,")]
    public class EDIFACT_ID_1229
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,D,I,")]
    public class EDIFACT_ID_7083
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_5495
    {
    }
    
    [Serializable()]
    [EdiCodes(",BK,PO,")]
    public class EDIFACT_ID_3433
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,OA,")]
    public class EDIFACT_ID_4439
    {
    }
    
    [Serializable()]
    [EdiCodes(",20,")]
    public class EDIFACT_ID_4431
    {
    }
    
    [Serializable()]
    [EdiCodes(",10E,13E,42,60,70,")]
    public class EDIFACT_ID_4461
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_4435
    {
    }
    
    [Serializable()]
    [EdiCodes(",AMS,FRA,IMF,LNF,LNS,NYC,PHI,ZUR,")]
    public class EDIFACT_ID_6341
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,")]
    public class EDIFACT_ID_6347
    {
    }
    
    [Serializable()]
    [EdiCodes(",EM,FX,TE,TL,XF,")]
    public class EDIFACT_ID_3155
    {
    }
    
    [Serializable()]
    [EdiCodes(",AD,AP,AR,GR,PD,")]
    public class EDIFACT_ID_3139
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,31,43,5,7,9,")]
    public class EDIFACT_ID_1225
    {
    }
    
    [Serializable()]
    [EdiCodes(",AB,NA,")]
    public class EDIFACT_ID_4343
    {
    }
    
    [Serializable()]
    [EdiCodes(",130,261,262,308,325,380,381,382,383,384,385,386,388,389,390,393,82,83,84,")]
    public class EDIFACT_ID_1001
    {
    }
}
