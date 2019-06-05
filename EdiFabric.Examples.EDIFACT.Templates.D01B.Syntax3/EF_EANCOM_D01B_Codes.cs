namespace EdiFabric.Templates.EancomD01B
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System.Xml.Serialization;
    
    
    [Serializable()]
    [DataContract()]
    public class EDIFACT_A
    {
    }
    
    [Serializable()]
    [DataContract()]
    public class EDIFACT_AN
    {
    }
    
    /// <summary>
    /// Document name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",82,83,84,130,261,262,308,325,380,381,382,383,384,385,386,388,389,390,393,")]
    public class EDIFACT_ID_1001
    {
    }
    
    /// <summary>
    /// Code list identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",23,25,106,132,154,157,166,174,1E,2E,ADR,BR,CA,CO,FL,HMT,SRN,ST,SZ,ZZZ,")]
    public class EDIFACT_ID_1131
    {
    }
    
    /// <summary>
    /// Reference code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,AAB,AAJ,AAK,ADE,AFO,AIZ,ALL,ALO,ALV,AMT,AP,APQ,CD,CR,CT,DL,DQ,EX,FC,GN,IA,IP,IT" +
        ",IV,ON,PL,PQ,PY,RF,SZ,TRB,VA,VN,XA,XB9,YC1,")]
    public class EDIFACT_ID_1153
    {
    }
    
    /// <summary>
    /// Message function code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,5,7,9,31,43,")]
    public class EDIFACT_ID_1225
    {
    }
    
    /// <summary>
    /// Calculation sequence code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_1227
    {
    }
    
    /// <summary>
    /// Action request/notification description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,10,11,23,24,38,55,96,11E,12E,13E,14E,XB6,YF2,")]
    public class EDIFACT_ID_1229
    {
    }
    
    /// <summary>
    /// Date or time or period function code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,7,11,12,13,35,36,50,100,132,133,134,137,140,171,186,200,209,263,325,326,454,53" +
        "1,44E,")]
    public class EDIFACT_ID_2005
    {
    }
    
    /// <summary>
    /// Terms time relation code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",3,")]
    public class EDIFACT_ID_2009
    {
    }
    
    /// <summary>
    /// Period type code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,D,M,WD,Y,")]
    public class EDIFACT_ID_2151
    {
    }
    
    /// <summary>
    /// Date or time or period format code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,101,102,107,108,109,201,203,204,401,501,502,602,609,610,615,616,713,717,718,71" +
        "9,720,801,802,803,804,805,806,810,21E,")]
    public class EDIFACT_ID_2379
    {
    }
    
    /// <summary>
    /// Time reference code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",5,52,")]
    public class EDIFACT_ID_2475
    {
    }
    
    /// <summary>
    /// Party function code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,BO,BS,BY,CN,CS,DP,II,IV,LC,LD,PB,PE,RB,RE,SE,SN,SR,ST,SU,")]
    public class EDIFACT_ID_3035
    {
    }
    
    /// <summary>
    /// Party name format code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_3045
    {
    }
    
    /// <summary>
    /// Code list responsible agency code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,3,5,6,7,8,9,10,17,28,60,65,68,83,84,86,87,88,89,90,91,92,112,113,116,131,136,1" +
        "82,200,245,246,260,281,286,CEN,PMS,RAL,TGA,X4,X5,X6,X7,ZZZ,")]
    public class EDIFACT_ID_3055
    {
    }
    
    /// <summary>
    /// Contact function code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,AD,AP,AR,GR,PD,")]
    public class EDIFACT_ID_3139
    {
    }
    
    /// <summary>
    /// Communication address code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,EM,FX,TE,TL,XF,")]
    public class EDIFACT_ID_3155
    {
    }
    
    /// <summary>
    /// Country name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",,AD,AE,AF,AG,AI,AL,AM,AN,AO,AQ,AR,AS,AT,AU,AW,AZ,BA,BB,BD,BE,BF,BG,BH,BI,BJ,BM,BN,BO,BR,BS,BT,BV,BW,BY,BZ,CA,CC,CD,CF,CG,CH,CI,CK,CL,CM,CN,CO,CR,CU,CV,CX,CY,CZ,DE,DJ,DK,DM,DO,DZ,EC,EE,EG,EH,ER,ES,ET,FI,FJ,FK,FM,FO,FR,GA,GB,GD,GE,GF,GH,GI,GL,GM,GN,GP,GQ,GR,GS,GT,GU,GW,GY,HK,HM,HN,HR,HT,HU,ID,IE,IL,IN,IO,IQ,IR,IS,IT,JM,JO,JP,KE,KG,KH,KI,KM,KN,KP,KR,KW,KY,KZ,LA,LB,LC,LI,LK,LR,LS,LT,LU,LV,LY,MA,MC,MD,MG,MH,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,NA,NC,NE,NF,NG,NI,NL,NO,NP,NR,NU,NZ,OM,PA,PE,PF,PG,PH,PK,PL,PM,PN,PR,PS,PT,PW,PY,QA,RE,RO,RU,RW,SA,SB,SC,SD,SE,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SR,ST,SV,SY,SZ,TC,TD,TF,TG,TH,TJ,TK,TM,TN,TO,TP,TR,TT,TV,TW,TZ,UA,UG,UM,US,UY,UZ,VA,VC,VE,VG,VI,VN,VU,WF,WS,YE,YT,YU,ZA,ZM,ZW,")]
    public class EDIFACT_ID_3207
    {
    }
    
    /// <summary>
    /// Location function code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,5,7,8,9,")]
    public class EDIFACT_ID_3227
    {
    }
    
    /// <summary>
    /// Country of origin name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",,AD,AE,AF,AG,AI,AL,AM,AN,AO,AQ,AR,AS,AT,AU,AW,AZ,BA,BB,BD,BE,BF,BG,BH,BI,BJ,BM,BN,BO,BR,BS,BT,BV,BW,BY,BZ,CA,CC,CD,CF,CG,CH,CI,CK,CL,CM,CN,CO,CR,CU,CV,CX,CY,CZ,DE,DJ,DK,DM,DO,DZ,EC,EE,EG,EH,ER,ES,ET,EU,FI,FJ,FK,FM,FO,FR,GA,GB,GD,GE,GF,GH,GI,GL,GM,GN,GP,GQ,GR,GS,GT,GU,GW,GY,HK,HM,HN,HR,HT,HU,ID,IE,IL,IN,IO,IQ,IR,IS,IT,JM,JO,JP,KE,KG,KH,KI,KM,KN,KP,KR,KW,KY,KZ,LA,LB,LC,LI,LK,LR,LS,LT,LU,LV,LY,MA,MC,MD,MG,MH,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,NA,NC,NE,NF,NG,NI,NL,NO,NP,NR,NU,NZ,OM,PA,PE,PF,PG,PH,PK,PL,PM,PN,PR,PS,PT,PW,PY,QA,RE,RO,RU,RW,SA,SB,SC,SD,SE,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SR,ST,SV,SY,SZ,TC,TD,TF,TG,TH,TJ,TK,TM,TN,TO,TP,TR,TT,TV,TW,TZ,UA,UG,UM,US,UY,UZ,VA,VC,VE,VG,VI,VN,VU,WF,WS,YE,YT,YU,ZA,ZM,ZW,")]
    public class EDIFACT_ID_3239
    {
    }
    
    /// <summary>
    /// Institution name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,BK,PO,")]
    public class EDIFACT_ID_3433
    {
    }
    
    /// <summary>
    /// Language name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",,AA,AB,AF,AM,AR,AS,AY,AZ,BA,BE,BG,BH,BI,BN,BO,BR,CA,CO,CS,CY,DA,DE,DZ,EL,EN,EO,ES,ET,EU,FA,FI,FJ,FO,FR,FY,GA,GD,GL,GN,GU,HA,HE,HI,HR,HU,HY,IA,ID,IE,IK,IS,IT,IU,JA,JW,KA,KK,KL,KM,KN,KO,KS,KU,KY,LA,LN,LO,LT,LV,MG,MI,MK,ML,MN,MO,MR,MS,MT,NA,NE,NL,NO,OC,OM,OR,PA,PL,PS,PT,QU,RM,RN,RO,RU,RW,SA,SD,SG,SH,SI,SK,SL,SM,SN,SO,SQ,SR,SS,ST,SU,SV,SW,TA,TE,TG,TH,TI,TK,TL,TN,TO,TR,TS,TT,TW,UG,UK,UR,UZ,VI,VO,WO,YI,YO,ZA,ZH,ZU,")]
    public class EDIFACT_ID_3453
    {
    }
    
    /// <summary>
    /// Trade class code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,MF,")]
    public class EDIFACT_ID_4043
    {
    }
    
    /// <summary>
    /// Delivery or transport terms description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,01E,02E,03E,04E,CFR,CIF,CIP,CPT,DAF,DDP,DDU,DEQ,DES,EXW,FAS,FCA,FOA,FOB,FOR,RDN" +
        ",RPD,SD,")]
    public class EDIFACT_ID_4053
    {
    }
    
    /// <summary>
    /// Delivery or transport terms function code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",3,6,")]
    public class EDIFACT_ID_4055
    {
    }
    
    /// <summary>
    /// Special condition code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,9,10,11,12,15,18,96,97,98,99,109,116,119,123,124,125,126,127,128,129,130,133,134,135,136,137,140,141,142,143,144,147,148,150,151,152,153,154,155,157,158,159,164,165,166,167,168,169,170,171,172,173,53E,55E,59E,61E,69E,70E,73E,74E,75E,76E,77E,79E,88E,90E,91E,93E,94E,95E,96E,ACD,ACN,ACP,X1,X13,X14,X15,X16,X18,X19,X2,X20,X44,X5,X8,")]
    public class EDIFACT_ID_4183
    {
    }
    
    /// <summary>
    /// Transport charges payment method code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,DF,PC,")]
    public class EDIFACT_ID_4215
    {
    }
    
    /// <summary>
    /// Discrepancy nature identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,BP,CP,OW,TW,")]
    public class EDIFACT_ID_4221
    {
    }
    
    /// <summary>
    /// Marking instructions code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,33E,")]
    public class EDIFACT_ID_4233
    {
    }
    
    /// <summary>
    /// Payment terms description identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,ZZZ,")]
    public class EDIFACT_ID_4277
    {
    }
    
    /// <summary>
    /// Payment terms type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,3,7,20,22,10E,ZZZ,")]
    public class EDIFACT_ID_4279
    {
    }
    
    /// <summary>
    /// Change reason description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,AJT,X29,")]
    public class EDIFACT_ID_4295
    {
    }
    
    /// <summary>
    /// Response type code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,AB,NA,")]
    public class EDIFACT_ID_4343
    {
    }
    
    /// <summary>
    /// Product identifier code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,4,5,")]
    public class EDIFACT_ID_4347
    {
    }
    
    /// <summary>
    /// Status description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,45,46,47,48,49,50,58,59,60,63,64,65,66,67,68,70,71,72,73,74,77,78,79,80,81,82,83,84,85,86,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,110,314,315,316,317,319,324,326,327,328,329,330,355,356,357,1E,20E,21E,22B,22E,23E,24E,26E,27E,28E,29E,2E,30E,31E,32E,34E,35E,36E,37B,37E,38E,39E,49E,4E,50E,57E,58E,59E,5E,60E,62E,64B,64E,65E,69E,6E,70E,71B,71E,72B,72E,73E,74B,74E,75E,76E,77B,77E,78E,79E,7E,80E,81E,82E,83E,84E,85E,86E,87E,8E,9E,CSA,CSC,CSD,CSE,X33,X34,X35,X37,X38,X39,X40,X41,")]
    public class EDIFACT_ID_4405
    {
    }
    
    /// <summary>
    /// Payment guarantee means code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,11,12,13,14,20,21,23,41,44,45,")]
    public class EDIFACT_ID_4431
    {
    }
    
    /// <summary>
    /// Payment channel code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,10,11,14,62,")]
    public class EDIFACT_ID_4435
    {
    }
    
    /// <summary>
    /// Payment conditions code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,OA,")]
    public class EDIFACT_ID_4439
    {
    }
    
    /// <summary>
    /// Free text value code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,1E,2E,3E,4E,")]
    public class EDIFACT_ID_4441
    {
    }
    
    /// <summary>
    /// Text subject code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,CHG,PUR,ZZZ,")]
    public class EDIFACT_ID_4451
    {
    }
    
    /// <summary>
    /// Free text function code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_4453
    {
    }
    
    /// <summary>
    /// Payment means code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",42,60,70,10E,13E,")]
    public class EDIFACT_ID_4461
    {
    }
    
    /// <summary>
    /// Settlement means code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,13,14,15,")]
    public class EDIFACT_ID_4471
    {
    }
    
    /// <summary>
    /// Monetary amount type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",8,9,21,23,25,52,53,77,79,86,113,124,125,129,131,165,176,201,203,204,227,236,286," +
        "369,396,400,402,496,505,38E,X33,X38,X41,X42,")]
    public class EDIFACT_ID_5025
    {
    }
    
    /// <summary>
    /// Price code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,AAA,AAB,AAE,AAF,")]
    public class EDIFACT_ID_5125
    {
    }
    
    /// <summary>
    /// Duty or tax or fee type name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,GST,VAT,")]
    public class EDIFACT_ID_5153
    {
    }
    
    /// <summary>
    /// Allowance or charge identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",69,64E,")]
    public class EDIFACT_ID_5189
    {
    }
    
    /// <summary>
    /// Sub-line item price change operation code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,A,I,S,")]
    public class EDIFACT_ID_5213
    {
    }
    
    /// <summary>
    /// Percentage type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,7,12,15,16,")]
    public class EDIFACT_ID_5245
    {
    }
    
    /// <summary>
    /// Percentage basis identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,13,")]
    public class EDIFACT_ID_5249
    {
    }
    
    /// <summary>
    /// Duty or tax or fee rate basis code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_5273
    {
    }
    
    /// <summary>
    /// Duty or tax or fee function code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",5,7,")]
    public class EDIFACT_ID_5283
    {
    }
    
    /// <summary>
    /// Duty or tax or fee category code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,A,E,S,")]
    public class EDIFACT_ID_5305
    {
    }
    
    /// <summary>
    /// Price type code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,CA,CT,")]
    public class EDIFACT_ID_5375
    {
    }
    
    /// <summary>
    /// Price specification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,DPR,PPR,PRP,RTP,SRP,")]
    public class EDIFACT_ID_5387
    {
    }
    
    /// <summary>
    /// Price multiplier type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,A,")]
    public class EDIFACT_ID_5393
    {
    }
    
    /// <summary>
    /// Rate type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_5419
    {
    }
    
    /// <summary>
    /// Allowance or charge code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,A,C,")]
    public class EDIFACT_ID_5463
    {
    }
    
    /// <summary>
    /// Sub-line indicator code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,")]
    public class EDIFACT_ID_5495
    {
    }
    
    /// <summary>
    /// Quantity type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,12,21,46,47,59,61,119,121,124,131,192,194,39E,45E,")]
    public class EDIFACT_ID_6063
    {
    }
    
    /// <summary>
    /// Control total type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,7,11,15,26,")]
    public class EDIFACT_ID_6069
    {
    }
    
    /// <summary>
    /// Non-discrete measurement name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",42,43,44,45,")]
    public class EDIFACT_ID_6155
    {
    }
    
    /// <summary>
    /// Measurement purpose code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,PD,SO,TL,")]
    public class EDIFACT_ID_6311
    {
    }
    
    /// <summary>
    /// Measured attribute code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,AAA,HT,LN,WD,")]
    public class EDIFACT_ID_6313
    {
    }
    
    /// <summary>
    /// Measurement significance code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",3,4,")]
    public class EDIFACT_ID_6321
    {
    }
    
    /// <summary>
    /// Exchange rate currency market identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,AMS,FRA,IMF,LNF,LNS,NYC,PHI,ZUR,")]
    public class EDIFACT_ID_6341
    {
    }
    
    /// <summary>
    /// Currency type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,3,4,5,8,9,10,11,12,13,14,15,17,10E,")]
    public class EDIFACT_ID_6343
    {
    }
    
    /// <summary>
    /// Currency identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",,ADP,AED,AFA,ALL,AMD,ANG,AOA,AOK,ARA,ARS,ATS,AUD,AWG,AZM,BAM,BBD,BDT,BEC,BEF,BEL,BGL,BGN,BHD,BIF,BMD,BND,BOB,BOV,BRC,BRL,BSD,BTN,BUK,BWP,BYB,BYR,BZD,CAD,CDF,CHF,CLF,CLP,CNY,COP,CRC,CUP,CVE,CYP,CZK,DEM,DJF,DKK,DOP,DZD,ECS,ECV,EEK,EGP,ERN,ESP,ETB,EUR,FIM,FJD,FKP,FRF,GBP,GEL,GHC,GIP,GMD,GNF,GRD,GTQ,GWP,GYD,HKD,HNL,HRD,HRK,HTG,HUF,IDR,IEP,ILS,INR,IQD,IRR,ISK,ITL,JMD,JOD,JPY,KES,KGS,KHR,KMF,KPW,KRW,KWD,KYD,KZT,LAK,LBP,LKR,LRD,LSL,LTL,LUC,LUF,LUL,LVL,LYD,MAD,MDL,MGF,MKD,MNT,MOP,MRO,MTL,MUR,MVR,MWK,MXN,MXV,MYR,MZM,NAD,NGN,NIC,NIO,NLG,NOK,NPR,NZD,OMR,PAB,PEI,PEN,PGK,PHP,PKR,PLN,PTE,PYG,QAR,ROL,RUB,RWF,SAR,SBD,SCR,SDD,SEK,SGD,SHP,SIT,SKK,SLL,SOS,SRG,STD,SVC,SYP,SZL,THB,TJR,TMM,TND,TOP,TPE,TRL,TTD,TWD,TZS,UAH,UGX,USD,USN,USS,UYU,UZS,VEB,VND,VUV,WST,XAF,XAG,XAU,XBA,XBB,XBC,XBD,XCD,XDR,XEU,XFO,XFU,XOF,XPD,XPF,XTS,XXX,YDD,YER,YUM,YUN,ZAR,ZMK,ZWD,")]
    public class EDIFACT_ID_6345
    {
    }
    
    /// <summary>
    /// Currency usage code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,3,")]
    public class EDIFACT_ID_6347
    {
    }
    
    /// <summary>
    /// Measurement unit code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,25,28,59,2N,2X,4K,4L,4O,4P,A25,A86,ACR,AD,AMH,AMP,AMT,ANN,APX,ASM,ASU,BAR,BTU,C0,C60,CDL,CEL,CLT,CMK,CMQ,CMT,D21,DAY,DD,DMQ,DMT,DOS,DZN,EA,EV,FAH,FOT,FTQ,GL,GLI,GM,GRM,GRO,GV,GWH,HLT,HTZ,HUR,INH,JOU,KAH,KB,KBA,KEL,KGM,KHZ,KJO,KL,KMH,KMQ,KPA,KTM,KVA,KVT,KWH,KWT,L2,LIH,LNE,LTR,LUX,MAL,MAW,MC,MCU,MGM,MHZ,MIN,MLT,MMK,MMQ,MMT,MON,MPA,MTA,MTK,MTQ,MTR,MWH,NAR,NEW,NRL,ONZ,OZA,OZI,P1,PA,PAL,PCE,PF,PND,PR,PTI,PTN,QAN,QTI,RPM,RTO,SEC,SML,ST,TNE,UI,VI,VLT,WHR,WRD,WTT,YRD,ZE,ZP,")]
    public class EDIFACT_ID_6411
    {
    }
    
    /// <summary>
    /// Item description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,CU,DU,RC,SER,TU,VQ,")]
    public class EDIFACT_ID_7009
    {
    }
    
    /// <summary>
    /// Package type description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,AE,CR,CX,")]
    public class EDIFACT_ID_7065
    {
    }
    
    /// <summary>
    /// Packaging terms and conditions code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_7073
    {
    }
    
    /// <summary>
    /// Packaging level code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,1E,")]
    public class EDIFACT_ID_7075
    {
    }
    
    /// <summary>
    /// Description format code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,A,B,C,D,E,F,S,")]
    public class EDIFACT_ID_7077
    {
    }
    
    /// <summary>
    /// Item characteristic code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",2,3,4,6,13,27,31,35,38,44,45,46,47,61,72,75,76,77,78,79,80,81,82,83,84,85,86,98,120,126,132,169,196,197,ANM,AVI,BPD,BRN,BVP,DSC,ECO,EDS,GDC,HAN,HAZ,IDC,IRC,ISC,ISY,KEY,MNF,NAV,RLI,SDS,SGR,STE,TDS,TPE,U02,U07,U08,U09,UP2,UP4,UP5,UP6,UP7,UP8,UP9,UQ1,UQ2,UQ3,UQ5,WVL,")]
    public class EDIFACT_ID_7081
    {
    }
    
    /// <summary>
    /// Configuration operation code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,A,D,I,")]
    public class EDIFACT_ID_7083
    {
    }
    
    /// <summary>
    /// Item type identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,AA,AC,ACU,ADU,AQ,AT,ATC,BAN,BP,BU,BZ,CG,DW,EN,GB,GD,GLN,GN,GU,HS,IB,IN,IS,IT,LI" +
        ",MF,MN,NB,PGC,PV,RVM,SA,SN,SPP,SRS,SRT,SRU,SRV,ST,UP,")]
    public class EDIFACT_ID_7143
    {
    }
    
    /// <summary>
    /// Special service description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",0,1,2,AA,AAB,AAJ,AAM,AAT,AAX,AAY,ABA,ABH,ABL,ABZ,ACQ,ACY,ACZ,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADZ,AEK,AEM,AEN,AEO,AEP,AEQ,AES,AEV,AEX,AEY,AEZ,AG,AJ,ASS,CA,CAC,CAG,CAI,CAL,CAM,CAN,CAP,CAQ,CAR,CAS,CAT,CP,DAE,DBD,DDA,DI,DTC,EAA,EAB,FA,FC,FG,FI,GRB,HD,IN,INT,IS,LA,MAC,MB,MC,NAA,PAD,PAE,PAR,PC,PI,PL,PN,QAA,QD,RAA,RAD,RAE,RCH,SER,SH,SOR,TAE,TD,TX,TZ,VAB,WHE,X21,X22,X23,X29,X30,X31,X32,X33,XAA,")]
    public class EDIFACT_ID_7161
    {
    }
    
    /// <summary>
    /// Packaging related description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,31,32,33,50,51,52,53,54,LAB,NBR,")]
    public class EDIFACT_ID_7233
    {
    }
    
    /// <summary>
    /// Object identification code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,BJ,BN,")]
    public class EDIFACT_ID_7405
    {
    }
    
    /// <summary>
    /// Transport stage code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",20,")]
    public class EDIFACT_ID_8051
    {
    }
    
    /// <summary>
    /// Transport mode name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,20,30,40,")]
    public class EDIFACT_ID_8067
    {
    }
    
    /// <summary>
    /// Transit direction indicator code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",,BS,SB,")]
    public class EDIFACT_ID_8101
    {
    }
    
    /// <summary>
    /// Transport means description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",23,25,31,")]
    public class EDIFACT_ID_8179
    {
    }
    
    /// <summary>
    /// Container or package contents indicator code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_8275
    {
    }
    
    /// <summary>
    /// Transport means ownership indicator code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_8281
    {
    }
    
    /// <summary>
    /// Returnable package load contents code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",3,")]
    public class EDIFACT_ID_8393
    {
    }
    
    /// <summary>
    /// Returnable package freight payment responsibility code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,3,")]
    public class EDIFACT_ID_8395
    {
    }
    
    /// <summary>
    /// Transport means nationality code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",,AD,AE,AF,AG,AI,AL,AM,AN,AO,AQ,AR,AS,AT,AU,AW,AZ,BA,BB,BD,BE,BF,BG,BH,BI,BJ,BM,BN,BO,BR,BS,BT,BV,BW,BY,BZ,CA,CC,CD,CF,CG,CH,CI,CK,CL,CM,CN,CO,CR,CU,CV,CX,CY,CZ,DE,DJ,DK,DM,DO,DZ,EC,EE,EG,EH,ER,ES,ET,FI,FJ,FK,FM,FO,FR,GA,GB,GD,GE,GF,GH,GI,GL,GM,GN,GP,GQ,GR,GS,GT,GU,GW,GY,HK,HM,HN,HR,HT,HU,ID,IE,IL,IN,IO,IQ,IR,IS,IT,JM,JO,JP,KE,KG,KH,KI,KM,KN,KP,KR,KW,KY,KZ,LA,LB,LC,LI,LK,LR,LS,LT,LU,LV,LY,MA,MC,MD,MG,MH,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,NA,NC,NE,NF,NG,NI,NL,NO,NP,NR,NU,NZ,OM,PA,PE,PF,PG,PH,PK,PL,PM,PN,PR,PS,PT,PW,PY,QA,RE,RO,RU,RW,SA,SB,SC,SD,SE,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SR,ST,SV,SY,SZ,TC,TD,TF,TG,TH,TJ,TK,TM,TN,TO,TP,TR,TT,TV,TW,TZ,UA,UG,UM,US,UY,UZ,VA,VC,VE,VG,VI,VN,VU,WF,WS,YE,YT,YU,ZA,ZM,ZW,")]
    public class EDIFACT_ID_8453
    {
    }
    
    /// <summary>
    /// Duty regime type code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,8,9,")]
    public class EDIFACT_ID_9213
    {
    }
    
    [Serializable()]
    [DataContract()]
    public class EDIFACT_N
    {
    }
}
