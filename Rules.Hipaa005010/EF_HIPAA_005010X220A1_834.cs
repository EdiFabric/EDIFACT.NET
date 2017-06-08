namespace EdiFabric.Rules.HIPAA_005010X220A1_834
{
    using System;
    using System.Collections.Generic;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Annotations.Validation;
    
    
    [Serializable()]
    [Message("X12", "005010X220A1", "834")]
    public class TS834 : EdiMessage
    {
        
        [Pos(1)]
        public ST ST { get; set; }
        [Required]
        [Pos(2)]
        public BGN_BeginningSegment BGN_BeginningSegment { get; set; }
        [Pos(3)]
        public REF_TransactionSetPolicyNumber REF_TransactionSetPolicyNumber { get; set; }
        [Pos(4)]
        public List<DTP_FileEffectiveDate> DTP_FileEffectiveDate { get; set; }
        [ListCount(3)]
        [Pos(5)]
        public List<QTY_TransactionSetControlTotals> QTY_TransactionSetControlTotals { get; set; }
        [Required]
        [Pos(6)]
        public All_N1 All_N1 { get; set; }
        [Required]
        [Pos(7)]
        public List<Loop_2000> Loop_2000 { get; set; }
        [Pos(8)]
        public SE SE { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",834,")]
    public class X12_ID_143
    {
    }
    
    [Serializable()]
    public class X12_AN
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,15,22,")]
    public class X12_ID_353
    {
    }
    
    [Serializable()]
    [EdiCodes(",38,")]
    public class X12_ID_128
    {
    }
    
    [Serializable()]
    [EdiCodes(",007,090,091,303,382,388,")]
    public class X12_ID_374
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250
    {
    }
    
    [Serializable()]
    [EdiCodes(",DT,ET,TO,")]
    public class X12_ID_673
    {
    }
    
    [Serializable()]
    public class X12_R
    {
    }
    
    [Serializable()]
    public class X12_N0
    {
    }
    
    [Serializable()]
    [Segment("SE")]
    public class SE
    {
        
        [Required]
        [StringLength(1, 10)]
        [DataElement("96", typeof(X12_N0))]
        [Pos(1)]
        public string TransactionSegmentCount_01 { get; set; }
        [Required]
        [StringLength(4, 9)]
        [DataElement("329", typeof(X12_AN))]
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
    }
    
    [Serializable()]
    [Group("INS")]
    public class Loop_2000
    {
        
        [Required]
        [Pos(1)]
        public INS_MemberLevelDetail INS_MemberLevelDetail { get; set; }
        [Required]
        [Pos(2)]
        public All_REF All_REF { get; set; }
        [ListCount(24)]
        [Pos(3)]
        public List<DTP_MemberLevelDates> DTP_MemberLevelDates { get; set; }
        [Required]
        [Pos(4)]
        public All_NM1 All_NM1 { get; set; }
        [Pos(5)]
        public List<Loop_2200> Loop_2200 { get; set; }
        [ListCount(99)]
        [Pos(6)]
        public List<Loop_2300> Loop_2300 { get; set; }
        [Pos(7)]
        public Loop_LS Loop_LS { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,23,24,25,26,31,38,53,60,D2" +
        ",G8,G9,")]
    public class X12_ID_1069
    {
    }
    
    [Serializable()]
    [EdiCodes(",050,286,296,297,300,301,303,336,337,338,339,340,341,350,351,356,357,383,385,386," +
        "393,394,473,474,")]
    public class X12_ID_374_2
    {
    }
    
    [Serializable()]
    [Group("LS")]
    public class Loop_LS
    {
        
        [Required]
        [Pos(1)]
        public LS_AdditionalReportingCategories LS_AdditionalReportingCategories { get; set; }
        [Pos(2)]
        public List<Loop_2700> Loop_2700 { get; set; }
        [Required]
        [Pos(3)]
        public LE_AdditionalReportingCategoriesTermination LE_AdditionalReportingCategoriesTermination { get; set; }
    }
    
    [Serializable()]
    [Segment("LE")]
    public class LE_AdditionalReportingCategoriesTermination
    {
        
        [Required]
        [StringLength(1, 4)]
        [DataElement("447", typeof(X12_AN))]
        [Pos(1)]
        public string LoopIdentifierCode_01 { get; set; }
    }
    
    [Serializable()]
    [Group("LX")]
    public class Loop_2700
    {
        
        [Required]
        [Pos(1)]
        public LX_MemberReportingCategories LX_MemberReportingCategories { get; set; }
        [Pos(2)]
        public Loop_2750 Loop_2750 { get; set; }
    }
    
    [Serializable()]
    [Group("N1")]
    public class Loop_2750
    {
        
        [Required]
        [Pos(1)]
        public N1_ReportingCategory N1_ReportingCategory { get; set; }
        [Pos(2)]
        public REF_ReportingCategoryReference REF_ReportingCategoryReference { get; set; }
        [Pos(3)]
        public DTP_ReportingCategoryDate DTP_ReportingCategoryDate { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",75,")]
    public class X12_ID_98_16
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,17,18,19,26,3L,6M,9V,9X,GE,LU,PID,XX1,XX2,YY,ZZ,")]
    public class X12_ID_128_9
    {
    }
    
    [Serializable()]
    [EdiCodes(",007,")]
    public class X12_ID_374_6
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,RD8,")]
    public class X12_ID_1250_2
    {
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_6), typeof(X12_ID_1250_2))]
    public class DTP_ReportingCategoryDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_6))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_2))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string MemberReportingCategoryEffectiveDates_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_9))]
    public class REF_ReportingCategoryReference
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_9))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberReportingCategoryReferenceID_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_8 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_8")]
    public class C040_ReferenceIdentifier_8
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",00,01,01A,01B,01C,01D,01E,01G,01H,02,03,04,05,06,07,08,09,0A,0B,0D,0E,0F,0G,0H,0" +
        "I,0J,0K,0L,0M,0N,0P,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J," +
        "1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,28,29,2A" +
        ",2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,30,3" +
        "1,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R," +
        "3S,3T,3U,3V,3W,3X,3Y,3Z,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I" +
        ",4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55,56,57,58,5" +
        "9,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z," +
        "60,61,63,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R" +
        ",6S,6T,6U,6V,6X,6Y,6Z,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7" +
        "J,7K,7L,7M,7N,7O,7P,7Q,7R,7S,7T,7U,7W,7X,7Y,7Z,80,81,82,83,84,85,86,87,88,89,8A," +
        "8B,8C,8D,8E,8F,8G,8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8U,8V,8W,8X,8Y,8Z,90,91,92" +
        ",93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9M,9N,9P,9Q,9R,9S,9T,9" +
        "U,9V,9W,9X,9Y,9Z,A0,A1,A2,A3,A4,A5,A7,A8,A9,AA,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,A" +
        "AI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,AB,ABA,AB" +
        "B,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,AB" +
        "V,ABW,ABX,ABY,ABZ,AC,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO" +
        ",ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,AD,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH," +
        "ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADU,ADV,ADW,ADX,ADY,ADZ,AE,AEA,A" +
        "EB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEJ,AEK,AEL,AEM,AEN,AEO,AEP,AEQ,AER,AES,AET,AEU,A" +
        "EV,AEX,AEY,AEZ,AF,AFA,AFB,AFC,AFD,AFE,AFF,AFG,AFH,AFI,AFJ,AFK,AFL,AFM,AFN,AFO,AF" +
        "P,AFQ,AFR,AFS,AFT,AFU,AFV,AFW,AFX,AFY,AFZ,AG,AGA,AGB,AGC,AGD,AGH,AGI,AGJ,AGK,AGL" +
        ",AGM,AGN,AGO,AGP,AGQ,AH,AHC,AI,AJ,AK,AL,ALC,ALG,ALH,ALI,ALJ,ALR,ALS,ALT,AM,AN,AO" +
        ",AP,APC,API,AQ,AR,AS,ASL,ASP,AST,AT,ATC,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B" +
        "8,B9,BA,BAA,BAB,BAC,BAD,BAE,BAF,BAG,BAH,BAI,BAJ,BAK,BB,BC,BCI,BCN,BCP,BD,BDG,BDN" +
        ",BE,BEN,BF,BG,BH,BI,BJ,BK,BKT,BL,BLT,BM,BMM,BN,BO,BOI,BP,BQ,BR,BS,BT,BU,BV,BW,BX" +
        ",BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CAA,CAB,CAC,CAD,CAE,CAF,CAG,CAH,CAI,CAJ," +
        "CAK,CAL,CAM,CAT,CB,CBG,CC,CD,CDN,CDT,CE,CF,CFR,CG,CH,CHR,CI,CID,CIR,CIT,CJ,CK,CL" +
        ",CLI,CM,CMN,CMP,CMT,CN,CNA,CNO,CNS,CO,COL,COT,CP,CPA,CPD,CPR,CPT,CQ,CR,CRN,CRS,C" +
        "S,CSC,CSG,CST,CT,CTS,CU,CUB,CV,CVS,CW,CX,CY,CYC,CZ,D0,D1,D2,D3,D4,D5,D6,D7,D8,D9" +
        ",DA,DAI,DAN,DB,DC,DD,DE,DF,DG,DH,DHH,DI,DIS,DJ,DK,DL,DM,DN,DNR,DNS,DO,DOA,DOC,DO" +
        "E,DOI,DOJ,DOL,DON,DOS,DOT,DP,DQ,DR,DRN,DS,DSC,DSI,DST,DT,DTS,DU,DUN,DV,DW,DX,DY," +
        "DZ,E00,E01,E02,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ECA,ECB,ECC,ECD,ECE,ECF,ECJ,E" +
        "D,EDA,EE,EF,EG,EH,EI,EII,EJ,EK,EL,EM,EMM,EN,END,EO,EP,EPA,EPB,EPC,EQ,ER,ES,ESN,E" +
        "T,EU,EV,EVI,EW,EX,EXP,EY,EZ,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FAN,FB,FC,FCN,FD,FE,FE" +
        "N,FF,FG,FH,FHC,FHO,FI,FJ,FK,FL,FLZ,FM,FMG,FMP,FN,FND,FO,FP,FQ,FR,FRN,FS,FSC,FSN," +
        "FT,FTN,FTP,FTZ,FU,FV,FW,FWC,FX,FY,FZ,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,G" +
        "F,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GWS,GX,GY,GZ,H1,H2,H3,H5,H6" +
        ",H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,HH,HHT,HI,HJ,HK,HL,HM,HMB,HN,HO,HP,HPI,HQ,HR,HS,H" +
        "T,HU,HUD,HV,HW,HX,HY,HZ,I1,I2,I3,I4,I5,I7,I9,IA,IB,IC,ICD,ID,IE,IF,IFC,IFT,IG,IH" +
        ",II,IID,IJ,IK,IL,IM,IMP,IMS,IN,IND,IO,IP,IQ,IR,IRN,IRP,IS,ISC,ISN,ISS,IT,ITI,IU," +
        "IV,IW,IX,IZ,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JCS,JD,JE,JF,JH,JI,JK,JL,JM,J" +
        "N,JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K0,K1,K2,K3,K4,K5,K6,K7,K8,K9,KA,KAS,KB,KC" +
        ",KCS,KD,KE,KG,KH,KI,KII,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KRL,KRP,KS,KSR,KT,KU,KV,KW,KX" +
        ",KY,KZ,L0,L1,L2,L3,L4,L5,L6,L7,L8,L9,LA,LAA,LAN,LB,LC,LD,LE,LEN,LF,LG,LH,LI,LIC," +
        "LJ,LK,LL,LM,LMI,LN,LO,LOI,LOS,LP,LPK,LQ,LR,LS,LSD,LT,LU,LV,LVO,LW,LX,LY,LZ,M0,M1" +
        ",M2,M3,M5,M6,M7,M8,M9,MA,MB,MBS,MBX,MC,MCC,MCI,MCN,MD,MDN,ME,MF,MG,MH,MI,MII,MIN" +
        ",MJ,MK,ML,MM,MN,MO,MP,MPN,MQ,MR,MRC,MRN,MS,MSL,MT,MU,MUI,MV,MW,MX,MY,MZ,MZO,N0,N" +
        "1,N2,N3,N4,N5,N6,N7,N8,N9,NA,NAS,NB,NC,ND,NDA,NDB,NE,NF,NFC,NFD,NFM,NFN,NFS,NG,N" +
        "H,NI,NJ,NK,NL,NM,NMT,NN,NO,NP,NQ,NR,NS,NT,NTP,NU,NW,NX,NY,NZ,O1,O2,O5,O7,O8,O9,O" +
        "A,OB,OC,OD,OE,OF,OFF,OG,OH,OI,OIC,OJ,OK,OL,OM,ON,OOS,OP,OPE,OPF,OQ,OR,OS,OT,OU,O" +
        "V,OW,OX,OZ,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PAC,PAN,PAP,PB,PC,PCC,PCN,PD,PDI,PDL,PD" +
        "R,PE,PF,PG,PGC,PGD,PGN,PGS,PH,PHC,PHY,PI,PID,PIN,PJ,PJC,PK,PKG,PKU,PL,PLA,PLN,PM" +
        ",PMN,PN,PNN,PO,POL,POS,PP,PPJ,PPK,PPL,PPM,PPN,PQ,PR,PRS,PRT,PS,PSI,PSL,PSM,PSN,P" +
        "T,PTC,PU,PUA,PV,PVC,PW,PWC,PWS,PX,PXC,PY,PYA,PYR,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q" +
        "A,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV,QW,QX,QY,QZ,R0," +
        "R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RAA,RAN,RB,RC,RD,RE,REC,RF,RG,RGI,RH,RI,RIG,RJ,RK," +
        "RL,RLI,RM,RN,RO,RP,RPP,RPS,RPT,RQ,RR,RRC,RRS,RS,RSN,RSS,RT,RU,RV,RW,RWK,RX,RY,RZ" +
        ",S0,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SAL,SB,SBN,SC,SCA,SCN,SD,SDT,SE,SEK,SES,SF,SG," +
        "SH,SHL,SI,SII,SJ,SK,SL,SM,SMC,SMT,SN,SNH,SNP,SNV,SO,SP,SPL,SPN,SQ,SR,SS,SST,ST,S" +
        "TB,STR,STS,SU,SUB,SUC,SUO,SV,SW,SX,SY,SZ,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,TB,TC," +
        "TD,TDT,TE,TF,TFC,TG,TH,TI,TIP,TJ,TK,TL,TM,TN,TO,TOC,TP,TPN,TQ,TR,TS,TSN,TT,TU,TV" +
        ",TW,TX,TY,TZ,U0,U1,U2,U3,U4,U5,U6,U8,U9,UA,UB,UC,UCB,UCM,UD,UE,UF,UG,UH,UI,UIC,U" +
        "J,UK,UL,UM,UN,UO,UP,UQ,UR,URL,URP,URQ,US,UT,UU,UV,UW,UX,UY,UZ,V0,V1,V2,V3,V4,V5," +
        "V6,V7,V8,V9,VA,VAO,VB,VC,VD,VE,VF,VG,VGS,VH,VI,VJ,VK,VL,VM,VN,VO,VP,VQ,VR,VS,VT," +
        "VU,VV,VW,VX,VY,VZ,W1,W2,W3,W4,W5,W6,W7,W8,W9,WA,WB,WC,WCS,WD,WDR,WE,WF,WG,WH,WI," +
        "WJ,WK,WL,WM,WN,WO,WP,WQ,WR,WS,WT,WU,WV,WW,WX,WY,WZ,X0,X1,X2,X3,X4,X5,X6,X7,X8,X9" +
        ",XA,XB,XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS,XT,XU,XV,XW,XX,XX1,XX2" +
        ",XX3,XX4,XX5,XX6,XX7,XX8,XY,XZ,Y0,Y1,Y2,Y3,Y4,Y5,Y6,Y8,Y9,YA,YB,YC,YD,YE,YF,YH,Y" +
        "I,YJ,YK,YL,YM,YN,YO,YP,YQ,YR,YS,YT,YV,YW,YX,YY,YZ,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA," +
        "ZB,ZC,ZD,ZE,ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZTS,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_128_2
    {
    }
    
    [Serializable()]
    [Segment("N1", typeof(X12_ID_98_16))]
    public class N1_ReportingCategory
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_16))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string MemberReportingCategoryName_02 { get; set; }
        [DataElement("66", typeof(X12_ID_66_3))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(@",0,1,10,11,12,13,15,16,17,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,50,51,53,54,55,56,57,58,59,6,61,62,63,64,7,71,72,73,74,75,76,77,78,81,82,83,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,A7,AA,AB,AC,AD,AE,AF,AI,AL,AP,BC,BD,BE,BG,BN,BP,BS,C,C1,C2,C5,CA,CB,CC,CD,CE,CF,CI,CL,CM,CN,CP,CR,CS,CT,D,DG,DL,DN,DO,DP,DR,DS,E,EC,EH,EI,EL,EP,EQ,ER,ES,ET,F,FA,FB,FC,FD,FE,FI,FJ,FL,FN,G,GA,GC,HC,HN,HS,I,ID,II,IP,J,K,L,LC,LD,LE,LI,LN,M,M3,M4,M5,M6,MA,MB,MC,MD,MI,MK,ML,MN,MO,MP,MR,N,NA,ND,NI,NO,NR,OC,OP,PA,PB,PC,PI,PP,PR,RA,RB,RC,RD,RE,RI,RP,RT,S,SA,SB,SD,SF,SI,SJ,SK,SL,SP,ST,SV,SW,TA,TC,TL,TS,TZ,UC,UI,UL,UP,UR,US,UT,WR,WS,X1,XV,XX,XY,ZC,ZN,ZY,ZZ,")]
    public class X12_ID_66_3
    {
    }
    
    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,CP,OP,PI,")]
    public class X12_ID_706
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,001,002,003,004,005,006,007,008,01,02,03,04,05,06,07,08,09,0A,0B,0D,0E,0F,0G," +
        "0H,0I,0J,0P,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K,1L,1M" +
        ",1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2" +
        "D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,30,31,32,33," +
        "34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U" +
        ",3V,3W,3X,3Y,3Z,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4" +
        "L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55,56,57,58,59,5A,5B," +
        "5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,60,61,62" +
        ",63,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6" +
        "T,6U,6V,6W,6X,6Y,6Z,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E,7F,7G,7H,7I,7J," +
        "7K,7L,7M,7N,7O,7P,7Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,80,81,82,83,84,85,86,87,88,89,8A" +
        ",8B,8C,8D,8E,8F,8G,8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8T,8U,8V,8W,8X,8Y,90,91,9" +
        "2,93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9N,9O,9P,9Q,9R,9S,9T," +
        "9U,9V,9W,9X,9Y,9Z,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AA1,AA2,AA3,AA4,AA5,AA6,AA7,AA8," +
        "AA9,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAS,AAT," +
        "AAU,AAV,AAW,AB,AB1,AB2,AB3,AB4,AB5,AB6,AB7,AB8,AB9,ABB,ABC,ABD,ABE,ABF,ABG,ABH,A" +
        "BI,ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,AC,AC1,AC2,AC3,AC" +
        "B,ACC,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,AC" +
        "W,ACX,ACY,ACZ,AD,ADA,ADB,ADC,ADD,ADE,ADF,ADH,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR" +
        ",ADS,ADT,ADU,ADV,ADW,ADX,ADY,ADZ,AE,AEA,AEB,AEC,AED,AEE,AEF,AEG,AEI,AEJ,AEK,AEL," +
        "AF,AG,AH,AHM,AI,AJ,AK,AL,ALA,ALO,AM,AN,AO,AP,APR,AQ,AR,AS,AT,ATA,AU,AUO,AV,AW,AX" +
        ",AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BAL,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BKR,BL,BL" +
        "D,BLT,BM,BN,BO,BOW,BP,BQ,BR,BRN,BS,BT,BU,BUS,BV,BW,BX,BY,BZ,C0,C1,C2,C3,C4,C4A,C" +
        "5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CHA,CI,CJ,CK,CL,CLT,CM,CMW,CN,CNP,CNR,CNS," +
        "CO,COD,COL,COM,COR,CP,CQ,CR,CRW,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,D5,D6,D7,D8," +
        "D9,DA,DAM,DB,DC,DCC,DD,DE,DF,DG,DH,DI,DIR,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV" +
        ",DW,DX,DY,DZ,E0,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EAA,EAB,EAD,EAE,EAF,EAG,EAH,EAI,EA" +
        "J,EAK,EAL,EAM,EAN,EAO,EAP,EAQ,EAR,EAS,EAT,EAU,EAV,EAW,EAX,EAY,EAZ,EB,EBA,EBB,EBC" +
        ",EBD,EBE,EBF,EBG,EBH,EBI,EBJ,EBK,EBL,EBM,EBN,EBO,EBP,EBQ,EBR,EBS,EC,ED,EE,EF,EG," +
        "EH,EI,EJ,EK,EL,EM,EN,ENR,EO,EP,EQ,ER,ET,EU,EV,EW,EX,EXS,EY,EZ,F1,F2,F3,F4,F5,F6," +
        "F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FGT,FH,FI,FJ,FL,FM,FN,FO,FP,FQ,FR,FRL,FS,FSI,FSR,F" +
        "T,FU,FV,FW,FX,FY,FZ,G0,G1,G2,G3,G5,G6,G7,G8,G9,GA,GB,GBA,GBO,GBP,GC,GD,GE,GF,GG," +
        "GH,GI,GIR,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H1,H2,H3,H5,H6,H7,H" +
        "9,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HMI,HN,HO,HOM,HON,HP,HQ,HR,HS,HT,HU,HV," +
        "HW,HX,HY,HZ,I1,I3,I4,I9,IA,IAA,IAC,IAD,IAE,IAF,IAG,IAH,IAI,IAK,IAL,IAM,IAN,IAO,I" +
        "AP,IAQ,IAR,IAS,IAT,IAU,IAV,IAW,IAY,IAZ,IB,IC,ICP,ID,IE,IF,IG,II,IJ,IK,IL,IM,IMM," +
        "IN,INT,INV,IO,IP,IQ,IR,IS,IT,IU,IV,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JD,JE,JF," +
        "JG,JH,JI,JJ,JK,JL,JM,JN,JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K1,K2,K3,K4,K5,K6,K7" +
        ",K8,K9,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,K" +
        "Y,KZ,L1,L2,L3,L5,L8,L9,LA,LB,LC,LCN,LD,LE,LF,LG,LGS,LH,LI,LJ,LK,LL,LM,LN,LO,LP,L" +
        "Q,LR,LS,LT,LU,LV,LW,LY,LYM,LYN,LYO,LYP,LZ,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD" +
        ",ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MSC,MT,MTR,MU,MV,MW,MX,MY,MZ,N1,N2" +
        ",N3,N4,N5,N6,N7,N8,N9,NB,NC,NCT,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NN,NP,NPC,NQ,NR,NS" +
        ",NT,NU,NV,NW,NX,NY,NZ,O1,O2,O3,O4,O5,O6,O7,O8,OA,OB,OC,OD,OE,OF,OG,OH,OI,OL,OM,O" +
        "N,OO,OP,OR,ORI,OS,OSH,OT,OU,OUC,OV,OW,OX,OY,OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA," +
        "PB,PC,PD,PE,PF,PG,PH,PI,PIC,PJ,PK,PL,PLC,PLR,PM,PMC,PMF,PMG,PN,PO,PP,PPC,PPS,PQ," +
        "PR,PRE,PRO,PRP,PS,PT,PU,PUR,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,QA,QB,QC,Q" +
        "D,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV,QW,QX,QY,QZ,R0,R1,R2,R3," +
        "R4,R5,R6,R7,R8,R9,RA,RB,RC,RCR,RD,REC,RF,RG,RGA,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR" +
        ",RR2,RR3,RS,RT,RU,RV,RW,RX,RY,RZ,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SE" +
        "P,SF,SG,SH,SI,SIC,SIP,SJ,SK,SL,SM,SN,SNP,SO,SP,SQ,SR,SS,ST,STC,SU,SUS,SV,SW,SX,S" +
        "Y,SZ,T1,T2,T3,T4,T6,T8,T9,TA,TB,TC,TD,TE,TEC,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TOW,T" +
        "P,TPM,TQ,TR,TS,TSD,TSE,TSR,TT,TTP,TU,TV,TW,TX,TY,TZ,U1,U2,U3,U4,U5,U6,U7,U8,U9,U" +
        "A,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UU,UW,UX,UY,UZ,V1,V2," +
        "V3,V4,V5,V6,V8,V9,VA,VB,VC,VD,VE,VER,VF,VG,VH,VI,VIC,VJ,VK,VL,VM,VN,VO,VP,VQ,VR," +
        "VS,VT,VU,VV,VW,VX,VY,W1,W2,W3,W4,W8,W9,WA,WB,WC,WD,WE,WF,WG,WH,WI,WJ,WL,WN,WO,WP" +
        ",WR,WS,WT,WU,WV,WW,WX,WY,WZ,X1,X2,X3,X4,X5,X6,X7,X8,XA,XC,XD,XE,XF,XG,XH,XI,XJ,X" +
        "K,XL,XM,XN,XO,XP,XQ,XR,XS,XT,XU,XV,XW,XX,XY,XZ,Y2,YA,YB,YC,YD,YE,YF,YG,YH,YI,YJ," +
        "YK,YL,YM,YN,YO,YP,YQ,YR,YS,YT,YU,YV,YW,YX,YY,YZ,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB" +
        ",ZC,ZD,ZE,ZF,ZG,ZH,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_98_2
    {
    }
    
    [Serializable()]
    [Segment("LX")]
    public class LX_MemberReportingCategories
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("LS")]
    public class LS_AdditionalReportingCategories
    {
        
        [Required]
        [StringLength(1, 4)]
        [DataElement("447", typeof(X12_AN))]
        [Pos(1)]
        public string LoopIdentifierCode_01 { get; set; }
    }
    
    [Serializable()]
    [Group("HD")]
    public class Loop_2300
    {
        
        [Required]
        [Pos(1)]
        public HD_HealthCoverage HD_HealthCoverage { get; set; }
        [Required]
        [ListCount(6)]
        [Pos(2)]
        public List<DTP_HealthCoverageDates> DTP_HealthCoverageDates { get; set; }
        [ListCount(9)]
        [Pos(3)]
        public List<AMT_HealthCoveragePolicy> AMT_HealthCoveragePolicy { get; set; }
        [Pos(4)]
        public All_REF_2 All_REF_2 { get; set; }
        [ListCount(3)]
        [Pos(5)]
        public List<IDC_IdentificationCard> IDC_IdentificationCard { get; set; }
        [ListCount(30)]
        [Pos(6)]
        public List<Loop_2310> Loop_2310 { get; set; }
        [ListCount(5)]
        [Pos(7)]
        public List<Loop_2320> Loop_2320 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",001,002,021,024,025,026,030,032,")]
    public class X12_ID_875_2
    {
    }
    
    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,EC,XB,XI,XL,XM,XN,XT,ZZ,")]
    public class X12_ID_1203_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",300,303,343,348,349,543,695,")]
    public class X12_ID_374_4
    {
    }
    
    [Serializable()]
    [EdiCodes(",B9,C1,D2,EBA,FK,P3,R,")]
    public class X12_ID_522
    {
    }
    
    [Serializable()]
    [EdiCodes(",D,H,P,")]
    public class X12_ID_1215
    {
    }
    
    [Serializable()]
    [Group("COB")]
    public class Loop_2320
    {
        
        [Required]
        [Pos(1)]
        public COB_CoordinationofBenefits COB_CoordinationofBenefits { get; set; }
        [ListCount(4)]
        [Pos(2)]
        public List<REF_AdditionalCoordinationofBenefitsIdentifiers> REF_AdditionalCoordinationofBenefitsIdentifiers { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<DTP_CoordinationofBenefitsEligibilityDates> DTP_CoordinationofBenefitsEligibilityDates { get; set; }
        [ListCount(3)]
        [Pos(4)]
        public List<Loop_2330> Loop_2330 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",P,S,T,U,")]
    public class X12_ID_1138
    {
    }
    
    [Serializable()]
    [EdiCodes(",60,6P,SY,ZZ,")]
    public class X12_ID_128_8
    {
    }
    
    [Serializable()]
    [EdiCodes(",344,345,")]
    public class X12_ID_374_5
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330
    {
        
        [Required]
        [Pos(1)]
        public NM1_CoordinationofBenefitsRelatedEntity NM1_CoordinationofBenefitsRelatedEntity { get; set; }
        [Pos(2)]
        public N3_CoordinationofBenefitsRelatedEntityAddress N3_CoordinationofBenefitsRelatedEntityAddress { get; set; }
        [Pos(3)]
        public N4_CoordinationofBenefitsOtherInsuranceCompanyCity_State_ZIPCode N4_CoordinationofBenefitsOtherInsuranceCompanyCity_State_ZIPCode { get; set; }
        [Pos(4)]
        public PER_AdministrativeCommunicationsContact PER_AdministrativeCommunicationsContact { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",36,GW,IN,")]
    public class X12_ID_98_15
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_3
    {
    }
    
    [Serializable()]
    public class X12_ID
    {
    }
    
    [Serializable()]
    [EdiCodes(",CN,")]
    public class X12_ID_366_7
    {
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_7))]
    public class PER_AdministrativeCommunicationsContact
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366_7))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365_5))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365_6))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_6))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",TE,")]
    public class X12_ID_365_5
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AP,AS,AU,BN,BT,CA,CP,DN,EA,ED,EM,EX,FT,FU,FX,HF,HP,IT,MN,NP,OF,OT" +
        ",PA,PC,PP,PS,SP,TE,TL,TM,TN,TX,UR,VM,WC,WF,WP,")]
    public class X12_ID_365_6
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_CoordinationofBenefitsOtherInsuranceCompanyCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string CoordinationofBenefitsOtherInsuranceCompanyCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string CoordinationofBenefitsOtherInsuranceCompanyStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string CoordinationofBenefitsOtherInsuranceCompanyPostalZoneorZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [DataElement("309", typeof(X12_ID_309_2))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_ID))]
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(@",10,11,12,13,14,18,19,20,21,22,27,28,29,30,31,32,33,34,35,36,38,39,40,41,42,43,44,45,46,47,48,49,50,52,53,54,55,57,58,59,60,93,94,A,A1,AA,AC,AP,AR,B,B1,BE,BL,BS,C,C2,CA,CB,CC,CD,CE,CG,CI,CL,CM,CO,CR,CS,CY,D,DC,DE,DL,DO,DP,DR,DT,E,EA,EB,EL,F,FA,FE,FF,FI,FR,FS,FT,FV,G,GL,H,I,IA,IB,IM,IP,IS,IT,J,K,KE,KL,KP,L,LO,M,MI,MO,MS,MZ,NS,O,OA,OF,OL,OP,OR,OV,P,PA,PB,PC,PD,PE,PF,PG,PH,PL,PM,PO,PP,PQ,PR,PS,PT,PU,PV,PZ,Q,RA,RC,RE,RG,RJ,RL,RS,RT,SA,SB,SC,SD,SE,SG,SH,SL,SN,SP,SS,ST,SW,TA,TC,TI,TL,TM,TN,TP,TR,TX,UN,UR,UT,VA,VI,VS,W,WF,WH,WI,X1,ZN,ZZ,")]
    public class X12_ID_309_2
    {
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_CoordinationofBenefitsRelatedEntityAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AddressInformation_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AddressInformation_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_15), typeof(X12_ID_1065_3))]
    public class NM1_CoordinationofBenefitsRelatedEntity
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_15))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string CoordinationofBenefitsInsurerName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string NameFirst_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string NameMiddle_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string NameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_8))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string CoordinationofBenefitsInsurerIdentificationCode_09 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",FI,NI,XV,")]
    public class X12_ID_66_8
    {
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_5), typeof(X12_ID_1250))]
    public class DTP_CoordinationofBenefitsEligibilityDates
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_5))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string CoordinationofBenefitsDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_8))]
    public class REF_AdditionalCoordinationofBenefitsIdentifiers
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_8))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_7 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_7")]
    public class C040_ReferenceIdentifier_7
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("COB", typeof(X12_ID_1138))]
    public class COB_CoordinationofBenefits
    {
        
        [Required]
        [DataElement("1138", typeof(X12_ID_1138))]
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        [Required]
        [DataElement("1143", typeof(X12_ID_1143))]
        [Pos(3)]
        public string CoordinationofBenefitsCode_03 { get; set; }
        [ListCount(9)]
        [DataElement("1365", typeof(X12_ID_1365))]
        [Pos(4)]
        public List<string> ServiceTypeCode_04 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",1,5,6,")]
    public class X12_ID_1143
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,35,48,50,54,89,90,A4,AG,AL,BB,")]
    public class X12_ID_1365
    {
    }
    
    [Serializable()]
    [Group("LX")]
    public class Loop_2310
    {
        
        [Required]
        [Pos(1)]
        public LX_ProviderInformation LX_ProviderInformation { get; set; }
        [Required]
        [Pos(2)]
        public NM1_ProviderName NM1_ProviderName { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<N3_ProviderAddress> N3_ProviderAddress { get; set; }
        [Pos(4)]
        public N4_ProviderCity_State_ZIPCode N4_ProviderCity_State_ZIPCode { get; set; }
        [ListCount(2)]
        [Pos(5)]
        public List<PER_ProviderCommunicationsNumbers> PER_ProviderCommunicationsNumbers { get; set; }
        [Pos(6)]
        public PLA_ProviderChangeReason PLA_ProviderChangeReason { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",1X,3D,80,FA,OD,P3,QA,QN,Y2,")]
    public class X12_ID_98_13
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",IC,")]
    public class X12_ID_366_6
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_306_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",1P,")]
    public class X12_ID_98_14
    {
    }
    
    [Serializable()]
    [Segment("PLA", typeof(X12_ID_306_3), typeof(X12_ID_98_14))]
    public class PLA_ProviderChangeReason
    {
        
        [Required]
        [DataElement("306", typeof(X12_ID_306_3))]
        [Pos(1)]
        public string ActionCode_01 { get; set; }
        [Required]
        [DataElement("98", typeof(X12_ID_98_14))]
        [Pos(2)]
        public string EntityIdentifierCode_02 { get; set; }
        [Required]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string ProviderEffectiveDate_03 { get; set; }
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(4)]
        public string Time_04 { get; set; }
        [Required]
        [DataElement("1203", typeof(X12_ID_1203_3))]
        [Pos(5)]
        public string MaintenanceReasonCode_05 { get; set; }
    }
    
    [Serializable()]
    public class X12_DT
    {
    }
    
    [Serializable()]
    public class X12_TM
    {
    }
    
    [Serializable()]
    [EdiCodes(",14,22,46,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,")]
    public class X12_ID_1203_3
    {
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_6))]
    public class PER_ProviderCommunicationsNumbers
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366_6))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AP,BN,CP,EM,EX,FX,HP,TE,WP,")]
    public class X12_ID_365
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_ProviderCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string ProviderCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string ProviderStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string ProviderPostalZoneorZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [DataElement("309", typeof(X12_ID_309_3))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_ID))]
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",60,CY,RJ,")]
    public class X12_ID_309_3
    {
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_ProviderAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string ProviderAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string ProviderAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065_2))]
    public class NM1_ProviderName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_13))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderLastorOrganizationName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string ProviderNamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_7))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ProviderIdentifier_09 { get; set; }
        [Required]
        [DataElement("706", typeof(X12_ID_706_2))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",34,FI,SV,XX,")]
    public class X12_ID_66_7
    {
    }
    
    [Serializable()]
    [EdiCodes(",25,26,72,")]
    public class X12_ID_706_2
    {
    }
    
    [Serializable()]
    [Segment("LX")]
    public class LX_ProviderInformation
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
    }
    
    [Serializable()]
    [Segment("IDC")]
    public class IDC_IdentificationCard
    {
        
        [Required]
        [StringLength(1, 50)]
        [DataElement("1204", typeof(X12_AN))]
        [Pos(1)]
        public string PlanCoverageDescription_01 { get; set; }
        [Required]
        [DataElement("1215", typeof(X12_ID_1215))]
        [Pos(2)]
        public string IdentificationCardTypeCode_02 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string IdentificationCardCount_03 { get; set; }
        [DataElement("306", typeof(X12_ID_306_2))]
        [Pos(4)]
        public string ActionCode_04 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",1,2,RX,")]
    public class X12_ID_306_2
    {
    }
    
    [Serializable()]
    [All()]
    public class All_REF_2
    {
        
        [ListCount(14)]
        [Pos(1)]
        public List<REF_HealthCoveragePolicyNumber> REF_HealthCoveragePolicyNumber { get; set; }
        [Pos(2)]
        public REF_PriorCoverageMonths REF_PriorCoverageMonths { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",17,1L,9V,CE,E8,M7,PID,RB,X9,XM,XX1,XX2,ZX,ZZ,")]
    public class X12_ID_128_6
    {
    }
    
    [Serializable()]
    [EdiCodes(",QQ,")]
    public class X12_ID_128_7
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_7))]
    public class REF_PriorCoverageMonths
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_7))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PriorCoverageMonthCount_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_6 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_6")]
    public class C040_ReferenceIdentifier_6
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_6))]
    public class REF_HealthCoveragePolicyNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_6))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_5 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_5")]
    public class C040_ReferenceIdentifier_5
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522))]
    public class AMT_HealthCoveragePolicy
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string ContractAmount_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",C,D,")]
    public class X12_ID_478
    {
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_4), typeof(X12_ID_1250_2))]
    public class DTP_HealthCoverageDates
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_4))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_2))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string CoveragePeriod_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("HD", typeof(X12_ID_875_2), typeof(X12_ID_1203_2))]
    public class HD_HealthCoverage
    {
        
        [Required]
        [DataElement("875", typeof(X12_ID_875_2))]
        [Pos(1)]
        public string MaintenanceTypeCode_01 { get; set; }
        [DataElement("1203", typeof(X12_ID_1203_2))]
        [Pos(2)]
        public string MaintenanceReasonCode_02 { get; set; }
        [Required]
        [DataElement("1205", typeof(X12_ID_1205))]
        [Pos(3)]
        public string InsuranceLineCode_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("1204", typeof(X12_AN))]
        [Pos(4)]
        public string PlanCoverageDescription_04 { get; set; }
        [DataElement("1207", typeof(X12_ID_1207))]
        [Pos(5)]
        public string CoverageLevelCode_05 { get; set; }
        [StringLength(1, 9)]
        [DataElement("609", typeof(X12_N0))]
        [Pos(6)]
        public string Count_06 { get; set; }
        [StringLength(1, 9)]
        [DataElement("609", typeof(X12_N0))]
        [Pos(7)]
        public string Count_07 { get; set; }
        [DataElement("1209", typeof(X12_ID_1209))]
        [Pos(8)]
        public string UnderwritingDecisionCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string LateEnrollmentIndicator_09 { get; set; }
        [DataElement("1211", typeof(X12_ID_1211))]
        [Pos(10)]
        public string DrugHouseCode_10 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(11)]
        public string YesNoConditionorResponseCode_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AG,AH,AJ,AK,DCP,DEN,EPO,FAC,HE,HLT,HMO,LTC,LTD,MM,MOD,PDG,POS,PPO,PRA,STD,UR,VIS" +
        ",")]
    public class X12_ID_1205
    {
    }
    
    [Serializable()]
    [EdiCodes(",CHD,DEP,E1D,E2D,E3D,E5D,E6D,E7D,E8D,E9D,ECH,EMP,ESP,FAM,IND,SPC,SPO,TWO,")]
    public class X12_ID_1207
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,I,N,S,")]
    public class X12_ID_1209
    {
    }
    
    [Serializable()]
    [EdiCodes(",AM,BAX,FLR,HCS,NP,PCS,THR,ZZ,")]
    public class X12_ID_1211
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,U,W,Y,")]
    public class X12_ID_1073_2
    {
    }
    
    [Serializable()]
    [Group("DSB")]
    public class Loop_2200
    {
        
        [Required]
        [Pos(1)]
        public DSB_DisabilityInformation DSB_DisabilityInformation { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<DTP_DisabilityEligibilityDates> DTP_DisabilityEligibilityDates { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1146
    {
    }
    
    [Serializable()]
    [EdiCodes(",360,361,")]
    public class X12_ID_374_3
    {
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_3), typeof(X12_ID_1250))]
    public class DTP_DisabilityEligibilityDates
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_3))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string DisabilityEligibilityDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DSB", typeof(X12_ID_1146))]
    public class DSB_DisabilityInformation
    {
        
        [Required]
        [DataElement("1146", typeof(X12_ID_1146))]
        [Pos(1)]
        public string DisabilityTypeCode_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        [StringLength(4, 6)]
        [DataElement("1149", typeof(X12_ID))]
        [Pos(3)]
        public string OccupationCode_03 { get; set; }
        [DataElement("1154", typeof(X12_ID_1154))]
        [Pos(4)]
        public string WorkIntensityCode_04 { get; set; }
        [DataElement("1161", typeof(X12_ID_1161))]
        [Pos(5)]
        public string ProductOptionCode_05 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(6)]
        public string MonetaryAmount_06 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(7)]
        public string ProductorServiceIDQualifier_07 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1137", typeof(X12_AN))]
        [Pos(8)]
        public string DiagnosisCode_08 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",H,L,M,R,")]
    public class X12_ID_1154
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,2,28,29,3,30,31,4,5,6,7,8,9,A,B,BA,C,D,GA,N,NC,O,PD,S,")]
    public class X12_ID_1161
    {
    }
    
    [Serializable()]
    [EdiCodes(",DX,ZZ,")]
    public class X12_ID_235
    {
    }
    
    [Serializable()]
    [All()]
    public class All_NM1
    {
        
        [Required]
        [Pos(1)]
        public Loop_2100A Loop_2100A { get; set; }
        [Pos(2)]
        public Loop_2100B Loop_2100B { get; set; }
        [Pos(3)]
        public Loop_2100C Loop_2100C { get; set; }
        [ListCount(3)]
        [Pos(4)]
        public List<Loop_2100D> Loop_2100D { get; set; }
        [ListCount(3)]
        [Pos(5)]
        public List<Loop_2100E> Loop_2100E { get; set; }
        [Pos(6)]
        public Loop_2100F Loop_2100F { get; set; }
        [ListCount(13)]
        [Pos(7)]
        public List<Loop_2100G> Loop_2100G { get; set; }
        [Pos(8)]
        public Loop_2100H Loop_2100H { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2100H
    {
        
        [Required]
        [Pos(1)]
        public NM1_DropOffLocation NM1_DropOffLocation { get; set; }
        [Pos(2)]
        public N3_DropOffLocationStreetAddress N3_DropOffLocationStreetAddress { get; set; }
        [Pos(3)]
        public N4_DropOffLocationCity_State_ZIPCode N4_DropOffLocationCity_State_ZIPCode { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",45,")]
    public class X12_ID_98_12
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1065
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_DropOffLocationCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string DropOffLocationCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string DropOffLocationStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string DropOffLocationPostalZoneorZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [DataElement("309", typeof(X12_ID_309_2))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_ID))]
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_DropOffLocationStreetAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string DropOffLocationAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string DropOffLocationAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_12), typeof(X12_ID_1065))]
    public class NM1_DropOffLocation
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_12))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string NameLastorOrganizationName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string NameFirst_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string NameMiddle_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string NameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_3))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string IdentificationCode_09 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2100G
    {
        
        [Required]
        [Pos(1)]
        public NM1_ResponsiblePerson NM1_ResponsiblePerson { get; set; }
        [Pos(2)]
        public PER_ResponsiblePersonCommunicationsNumbers PER_ResponsiblePersonCommunicationsNumbers { get; set; }
        [Pos(3)]
        public N3_ResponsiblePersonStreetAddress N3_ResponsiblePersonStreetAddress { get; set; }
        [Pos(4)]
        public N4_ResponsiblePersonCity_State_ZIPCode N4_ResponsiblePersonCity_State_ZIPCode { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",6Y,9K,E1,EI,EXS,GB,GD,J6,LR,QD,S1,TZ,X4,")]
    public class X12_ID_98_11
    {
    }
    
    [Serializable()]
    [EdiCodes(",RP,")]
    public class X12_ID_366_5
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_ResponsiblePersonCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string ResponsiblePersonCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string ResponsiblePersonStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string ResponsiblePersonPostalZoneorZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [DataElement("309", typeof(X12_ID_309_2))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_ID))]
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_ResponsiblePersonStreetAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string ResponsiblePartyAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string ResponsiblePartyAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_5))]
    public class PER_ResponsiblePersonCommunicationsNumbers
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366_5))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065))]
    public class NM1_ResponsiblePerson
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_11))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ResponsiblePartyLastorOrganizationName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ResponsiblePartyFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ResponsiblePartyMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string ResponsiblePartyNamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ResponsiblePartySuffixName_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_4))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ResponsiblePartyIdentifier_09 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",34,ZZ,")]
    public class X12_ID_66_4
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2100F
    {
        
        [Required]
        [Pos(1)]
        public NM1_CustodialParent NM1_CustodialParent { get; set; }
        [Pos(2)]
        public PER_CustodialParentCommunicationsNumbers PER_CustodialParentCommunicationsNumbers { get; set; }
        [Pos(3)]
        public N3_CustodialParentStreetAddress N3_CustodialParentStreetAddress { get; set; }
        [Pos(4)]
        public N4_CustodialParentCity_State_ZIPCode N4_CustodialParentCity_State_ZIPCode { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",S3,")]
    public class X12_ID_98_10
    {
    }
    
    [Serializable()]
    [EdiCodes(",PQ,")]
    public class X12_ID_366_4
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_CustodialParentCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string CustodialParentCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string CustodialParentStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string CustodialParentPostalZoneorZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [DataElement("309", typeof(X12_ID_309_2))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_ID))]
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_CustodialParentStreetAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string CustodialParentAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string CustodialParentAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_4))]
    public class PER_CustodialParentCommunicationsNumbers
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366_4))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_4))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AP,BN,CP,EM,EX,HP,TE,WP,")]
    public class X12_ID_365_4
    {
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_10), typeof(X12_ID_1065))]
    public class NM1_CustodialParent
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_10))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string CustodialParentLastName_03 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string CustodialParentFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string CustodialParentMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string CustodialParentNamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string CustodialParentNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_4))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string CustodialParentIdentifier_09 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2100E
    {
        
        [Required]
        [Pos(1)]
        public NM1_MemberSchool NM1_MemberSchool { get; set; }
        [Pos(2)]
        public PER_MemberSchoolCommmunicationsNumbers PER_MemberSchoolCommmunicationsNumbers { get; set; }
        [Pos(3)]
        public N3_MemberSchoolStreetAddress N3_MemberSchoolStreetAddress { get; set; }
        [Pos(4)]
        public N4_MemberSchoolCity_State_ZIPCode N4_MemberSchoolCity_State_ZIPCode { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",M8,")]
    public class X12_ID_98_9
    {
    }
    
    [Serializable()]
    [EdiCodes(",SK,")]
    public class X12_ID_366_3
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_MemberSchoolCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string MemberSchoolCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string MemberSchoolStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string MemberSchoolPostalZoneorZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [DataElement("309", typeof(X12_ID_309_2))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_ID))]
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_MemberSchoolStreetAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string SchoolAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string SchoolAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_3))]
    public class PER_MemberSchoolCommmunicationsNumbers
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366_3))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string MemberSchoolCommunicationsContactName_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365_3))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365_3))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_3))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",EM,EX,FX,TE,")]
    public class X12_ID_365_3
    {
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
    public class NM1_MemberSchool
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string SchoolName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string NameFirst_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string NameMiddle_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string NameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_3))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string IdentificationCode_09 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2100D
    {
        
        [Required]
        [Pos(1)]
        public NM1_MemberEmployer NM1_MemberEmployer { get; set; }
        [Pos(2)]
        public PER_MemberEmployerCommunicationsNumbers PER_MemberEmployerCommunicationsNumbers { get; set; }
        [Pos(3)]
        public N3_MemberEmployerStreetAddress N3_MemberEmployerStreetAddress { get; set; }
        [Pos(4)]
        public N4_MemberEmployerCity_State_ZIPCode N4_MemberEmployerCity_State_ZIPCode { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",36,")]
    public class X12_ID_98_8
    {
    }
    
    [Serializable()]
    [EdiCodes(",EP,")]
    public class X12_ID_366_2
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_MemberEmployerCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string MemberEmployerCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string MemberEmployerStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string MemberEmployerPostalZoneorZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [DataElement("309", typeof(X12_ID_309_2))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_ID))]
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_MemberEmployerStreetAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string MemberEmployerAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string MemberEmployerAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_2))]
    public class PER_MemberEmployerCommunicationsNumbers
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366_2))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string MemberEmployerCommunicationsContactName_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365_2))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365_2))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_2))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AP,BN,CP,EM,EX,FX,TE,")]
    public class X12_ID_365_2
    {
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_8), typeof(X12_ID_1065_2))]
    public class NM1_MemberEmployer
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_8))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string MemberEmployerName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string MemberEmployerFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string MemberEmployerMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string MemberEmployerNamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string MemberEmployerNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_6))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string MemberEmployerIdentifier_09 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,")]
    public class X12_ID_66_6
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2100C
    {
        
        [Required]
        [Pos(1)]
        public NM1_MemberMailingAddress NM1_MemberMailingAddress { get; set; }
        [Required]
        [Pos(2)]
        public N3_MemberMailStreetAddress N3_MemberMailStreetAddress { get; set; }
        [Required]
        [Pos(3)]
        public N4_MemberMailCity_State_ZIPCode N4_MemberMailCity_State_ZIPCode { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",31,")]
    public class X12_ID_98_7
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_MemberMailCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string MemberMailCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string MemberMailStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string MemberMailPostalZoneorZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [DataElement("309", typeof(X12_ID_309_2))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_ID))]
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_MemberMailStreetAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string MemberAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string MemberAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_7), typeof(X12_ID_1065))]
    public class NM1_MemberMailingAddress
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_7))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string NameLastorOrganizationName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string NameFirst_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string NameMiddle_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string NameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_3))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string IdentificationCode_09 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2100B
    {
        
        [Required]
        [Pos(1)]
        public NM1_IncorrectMemberName NM1_IncorrectMemberName { get; set; }
        [Pos(2)]
        public DMG_IncorrectMemberDemographics DMG_IncorrectMemberDemographics { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",70,")]
    public class X12_ID_98_6
    {
    }
    
    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250))]
    public class DMG_IncorrectMemberDemographics
    {
        
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(2)]
        public string PriorIncorrectInsuredBirthDate_02 { get; set; }
        [DataElement("1068", typeof(X12_ID_1068))]
        [Pos(3)]
        public string PriorIncorrectInsuredGenderCode_03 { get; set; }
        [DataElement("1067", typeof(X12_ID_1067))]
        [Pos(4)]
        public string MaritalStatusCode_04 { get; set; }
        [ListCount(10)]
        [Pos(5)]
        public List<C056_CompositeRaceorEthnicityInformation_2> CompositeRaceorEthnicityInformation_05 { get; set; }
        [DataElement("1066", typeof(X12_ID_1066))]
        [Pos(6)]
        public string CitizenshipStatusCode_06 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        [DataElement("659", typeof(X12_ID_659))]
        [Pos(8)]
        public string BasisofVerificationCode_08 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(9)]
        public string Quantity_09 { get; set; }
        [DataElement("1270", typeof(X12_ID_1270_2))]
        [Pos(10)]
        public string CodeListQualifierCode_10 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(11)]
        public string RaceorEthnicityCollectionCode_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",F,M,U,")]
    public class X12_ID_1068
    {
    }
    
    [Serializable()]
    [EdiCodes(",B,D,I,M,R,S,U,W,X,")]
    public class X12_ID_1067
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_1066
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,")]
    public class X12_ID_659
    {
    }
    
    [Serializable()]
    [EdiCodes(",REC,")]
    public class X12_ID_1270_2
    {
    }
    
    [Serializable()]
    [Composite("C056_CompositeRaceorEthnicityInformation_2")]
    public class C056_CompositeRaceorEthnicityInformation_2
    {
        
        [DataElement("1109", typeof(X12_ID_1109))]
        [Pos(1)]
        public string RaceorEthnicityCode_01 { get; set; }
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(2)]
        public string CodeListQualifierCode_02 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(3)]
        public string RaceorEthnicityCode_03 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",7,8,A,B,C,D,E,F,G,H,I,J,N,O,P,Z,")]
    public class X12_ID_1109
    {
    }
    
    [Serializable()]
    [EdiCodes(",RET,")]
    public class X12_ID_1270
    {
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_6), typeof(X12_ID_1065))]
    public class NM1_IncorrectMemberName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_6))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string PriorIncorrectMemberLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string PriorIncorrectMemberFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string PriorIncorrectMemberMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string PriorIncorrectMemberNamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string PriorIncorrectMemberNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_4))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string PriorIncorrectInsuredIdentifier_09 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2100A
    {
        
        [Required]
        [Pos(1)]
        public NM1_MemberName NM1_MemberName { get; set; }
        [Pos(2)]
        public PER_MemberCommunicationsNumbers PER_MemberCommunicationsNumbers { get; set; }
        [Pos(3)]
        public N3_MemberResidenceStreetAddress N3_MemberResidenceStreetAddress { get; set; }
        [Pos(4)]
        public N4_MemberCity_State_ZIPCode N4_MemberCity_State_ZIPCode { get; set; }
        [Pos(5)]
        public DMG_MemberDemographics DMG_MemberDemographics { get; set; }
        [Pos(6)]
        public List<EC_EmploymentClass> EC_EmploymentClass { get; set; }
        [Pos(7)]
        public ICM_MemberIncome ICM_MemberIncome { get; set; }
        [ListCount(7)]
        [Pos(8)]
        public List<AMT_MemberPolicyAmounts> AMT_MemberPolicyAmounts { get; set; }
        [Pos(9)]
        public HLH_MemberHealthInformation HLH_MemberHealthInformation { get; set; }
        [Pos(10)]
        public List<LUI_MemberLanguage> LUI_MemberLanguage { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",74,IL,")]
    public class X12_ID_98_5
    {
    }
    
    [Serializable()]
    [EdiCodes(",IP,")]
    public class X12_ID_366
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,17,18,19,20,21,22,23,")]
    public class X12_ID_1176
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,6,7,8,9,B,C,H,Q,S,U,")]
    public class X12_ID_594
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,S,T,U,X,")]
    public class X12_ID_1212
    {
    }
    
    [Serializable()]
    [EdiCodes(",LD,LE,")]
    public class X12_ID_66_5
    {
    }
    
    [Serializable()]
    [Segment("LUI", typeof(X12_ID_66_5))]
    public class LUI_MemberLanguage
    {
        
        [DataElement("66", typeof(X12_ID_66_5))]
        [Pos(1)]
        public string IdentificationCodeQualifier_01 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(2)]
        public string LanguageCode_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string LanguageDescription_03 { get; set; }
        [DataElement("1303", typeof(X12_ID_1303))]
        [Pos(4)]
        public string LanguageUseIndicator_04 { get; set; }
        [DataElement("1476", typeof(X12_ID_1476))]
        [Pos(5)]
        public string LanguageProficiencyIndicator_05 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",5,6,7,8,")]
    public class X12_ID_1303
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,A,B,C,D,E,")]
    public class X12_ID_1476
    {
    }
    
    [Serializable()]
    [Segment("HLH", typeof(X12_ID_1212))]
    public class HLH_MemberHealthInformation
    {
        
        [Required]
        [DataElement("1212", typeof(X12_ID_1212))]
        [Pos(1)]
        public string HealthRelatedCode_01 { get; set; }
        [StringLength(1, 8)]
        [DataElement("65", typeof(X12_R))]
        [Pos(2)]
        public string MemberHeight_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(3)]
        public string MemberWeight_03 { get; set; }
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(4)]
        public string Weight_04 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        public string Description_05 { get; set; }
        [DataElement("1213", typeof(X12_ID_1213))]
        [Pos(6)]
        public string CurrentHealthConditionCode_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,E,F,G,P,")]
    public class X12_ID_1213
    {
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522))]
    public class AMT_MemberPolicyAmounts
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string ContractAmount_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("ICM", typeof(X12_ID_594))]
    public class ICM_MemberIncome
    {
        
        [Required]
        [DataElement("594", typeof(X12_ID_594))]
        [Pos(1)]
        public string FrequencyCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string WageAmount_02 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string WorkHoursCount_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(4)]
        public string LocationIdentificationCode_04 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1214", typeof(X12_AN))]
        [Pos(5)]
        public string SalaryGradeCode_05 { get; set; }
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_ID))]
        [Pos(6)]
        public string CurrencyCode_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("EC", typeof(X12_ID_1176), typeof(X12_ID_1176))]
    public class EC_EmploymentClass
    {
        
        [Required]
        [DataElement("1176", typeof(X12_ID_1176))]
        [Pos(1)]
        public string EmploymentClassCode_01 { get; set; }
        [DataElement("1176", typeof(X12_ID_1176))]
        [Pos(2)]
        public string EmploymentClassCode_02 { get; set; }
        [DataElement("1176", typeof(X12_ID_1176))]
        [Pos(3)]
        public string EmploymentClassCode_03 { get; set; }
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(4)]
        public string PercentageasDecimal_04 { get; set; }
        [DataElement("1201", typeof(X12_ID_1201))]
        [Pos(5)]
        public string InformationStatusCode_05 { get; set; }
        [StringLength(4, 6)]
        [DataElement("1149", typeof(X12_ID))]
        [Pos(6)]
        public string OccupationCode_06 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,L,O,P,S,T,")]
    public class X12_ID_1201
    {
    }
    
    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250))]
    public class DMG_MemberDemographics
    {
        
        [Required]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(2)]
        public string MemberBirthDate_02 { get; set; }
        [Required]
        [DataElement("1068", typeof(X12_ID_1068))]
        [Pos(3)]
        public string GenderCode_03 { get; set; }
        [DataElement("1067", typeof(X12_ID_1067))]
        [Pos(4)]
        public string MaritalStatusCode_04 { get; set; }
        [ListCount(10)]
        [Pos(5)]
        public List<C056_CompositeRaceorEthnicityInformation> CompositeRaceorEthnicityInformation_05 { get; set; }
        [DataElement("1066", typeof(X12_ID_1066))]
        [Pos(6)]
        public string CitizenshipStatusCode_06 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        [DataElement("659", typeof(X12_ID_659))]
        [Pos(8)]
        public string BasisofVerificationCode_08 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(9)]
        public string Quantity_09 { get; set; }
        [DataElement("1270", typeof(X12_ID_1270_2))]
        [Pos(10)]
        public string CodeListQualifierCode_10 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(11)]
        public string RaceorEthnicityCollectionCode_11 { get; set; }
    }
    
    [Serializable()]
    [Composite("C056_CompositeRaceorEthnicityInformation")]
    public class C056_CompositeRaceorEthnicityInformation
    {
        
        [DataElement("1109", typeof(X12_ID_1109))]
        [Pos(1)]
        public string RaceorEthnicityCode_01 { get; set; }
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(2)]
        public string CodeListQualifierCode_02 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(3)]
        public string RaceorEthnicityCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_MemberCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string MemberCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string MemberStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string MemberPostalZoneorZipCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
        [StringLength(1, 3)]
        [DataElement("1715", typeof(X12_ID))]
        [Pos(7)]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",60,CY,")]
    public class X12_ID_309
    {
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_MemberResidenceStreetAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string MemberAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string MemberAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_MemberCommunicationsNumbers
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("443", typeof(X12_AN))]
        [Pos(9)]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_5), typeof(X12_ID_1065))]
    public class NM1_MemberName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_5))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string MemberLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string MemberFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string MemberMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string MemberNamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string MemberNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_4))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string MemberIdentifier_09 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(10)]
        public string EntityRelationshipCode_10 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(11)]
        public string EntityIdentifierCode_11 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(12)]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_2), typeof(X12_ID_1250))]
    public class DTP_MemberLevelDates
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_2))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string StatusInformationEffectiveDate_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF
    {
        
        [Required]
        [Pos(1)]
        public REF_SubscriberIdentifier REF_SubscriberIdentifier { get; set; }
        [Pos(2)]
        public REF_MemberPolicyNumber REF_MemberPolicyNumber { get; set; }
        [ListCount(13)]
        [Pos(3)]
        public List<REF_MemberSupplementalIdentifier> REF_MemberSupplementalIdentifier { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",0F,")]
    public class X12_ID_128_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",1L,")]
    public class X12_ID_128_4
    {
    }
    
    [Serializable()]
    [EdiCodes(",17,23,3H,4A,6O,ABB,D3,DX,F6,P5,Q4,QQ,ZZ,")]
    public class X12_ID_128_5
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_5))]
    public class REF_MemberSupplementalIdentifier
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_5))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberSupplementalIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_4 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_4")]
    public class C040_ReferenceIdentifier_4
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_4))]
    public class REF_MemberPolicyNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_4))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MemberGrouporPolicyNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_3 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_3")]
    public class C040_ReferenceIdentifier_3
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_3))]
    public class REF_SubscriberIdentifier
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string SubscriberIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_2 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_2")]
    public class C040_ReferenceIdentifier_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("INS", typeof(X12_ID_1073), typeof(X12_ID_1069))]
    public class INS_MemberLevelDetail
    {
        
        [Required]
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(1)]
        public string MemberIndicator_01 { get; set; }
        [Required]
        [DataElement("1069", typeof(X12_ID_1069))]
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        [Required]
        [DataElement("875", typeof(X12_ID_875))]
        [Pos(3)]
        public string MaintenanceTypeCode_03 { get; set; }
        [DataElement("1203", typeof(X12_ID_1203))]
        [Pos(4)]
        public string MaintenanceReasonCode_04 { get; set; }
        [Required]
        [DataElement("1216", typeof(X12_ID_1216_2))]
        [Pos(5)]
        public string BenefitStatusCode_05 { get; set; }
        [Pos(6)]
        public C052_MedicareStatusCode MedicareStatusCode_06 { get; set; }
        [DataElement("1219", typeof(X12_ID_1219))]
        [Pos(7)]
        public string ConsolidatedOmnibusBudgetReconciliationActCOBRAQualifyingEventCode_07 { get; set; }
        [DataElement("584", typeof(X12_ID_584))]
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        [DataElement("1220", typeof(X12_ID_1220))]
        [Pos(9)]
        public string StudentStatusCode_09 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(10)]
        public string HandicapIndicator_10 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(11)]
        public string DateTimePeriodFormatQualifier_11 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(12)]
        public string MemberIndividualDeathDate_12 { get; set; }
        [DataElement("1165", typeof(X12_ID_1165))]
        [Pos(13)]
        public string ConfidentialityCode_13 { get; set; }
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(14)]
        public string CityName_14 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(15)]
        public string StateorProvinceCode_15 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(16)]
        public string CountryCode_16 { get; set; }
        [StringLength(1, 9)]
        [DataElement("1470", typeof(X12_N0))]
        [Pos(17)]
        public string BirthSequenceNumber_17 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",001,021,024,025,030,")]
    public class X12_ID_875
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,14,15,16,17,18,20,21,22,25,26,27,28,29,31,32,33" +
        ",37,38,39,40,41,43,59,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,EC,XN,XT,")]
    public class X12_ID_1203
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,C,S,T,")]
    public class X12_ID_1216_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,ZZ,")]
    public class X12_ID_1219
    {
    }
    
    [Serializable()]
    [EdiCodes(",AC,AO,AU,FT,L1,PT,RT,TE,")]
    public class X12_ID_584
    {
    }
    
    [Serializable()]
    [EdiCodes(",F,N,P,")]
    public class X12_ID_1220
    {
    }
    
    [Serializable()]
    [EdiCodes(",R,U,")]
    public class X12_ID_1165
    {
    }
    
    [Serializable()]
    [Composite("C052_MedicareStatusCode")]
    public class C052_MedicareStatusCode
    {
        
        [Required]
        [DataElement("1218", typeof(X12_ID_1218))]
        [Pos(1)]
        public string MedicarePlanCode_01 { get; set; }
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(2)]
        public string MedicareEligibilityReasonCode_02 { get; set; }
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(3)]
        public string EligibilityReasonCode_03 { get; set; }
        [DataElement("1701", typeof(X12_ID_1701))]
        [Pos(4)]
        public string EligibilityReasonCode_04 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1218
    {
    }
    
    [Serializable()]
    [EdiCodes(",0,1,2,")]
    public class X12_ID_1701
    {
    }
    
    [Serializable()]
    [All()]
    public class All_N1
    {
        
        [Required]
        [Pos(1)]
        public Loop_1000A Loop_1000A { get; set; }
        [Required]
        [Pos(2)]
        public Loop_1000B Loop_1000B { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<Loop_1000C> Loop_1000C { get; set; }
    }
    
    [Serializable()]
    [Group("N1")]
    public class Loop_1000C
    {
        
        [Required]
        [Pos(1)]
        public N1_TPA_BrokerName N1_TPA_BrokerName { get; set; }
        [Pos(2)]
        public Loop_1100C Loop_1100C { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",BO,TV,")]
    public class X12_ID_98_4
    {
    }
    
    [Serializable()]
    [Group("ACT")]
    public class Loop_1100C
    {
        
        [Required]
        [Pos(1)]
        public ACT_TPA_BrokerAccountInformation ACT_TPA_BrokerAccountInformation { get; set; }
    }
    
    [Serializable()]
    [Segment("ACT")]
    public class ACT_TPA_BrokerAccountInformation
    {
        
        [Required]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(1)]
        public string TPAorBrokerAccountNumber_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        [DataElement("66", typeof(X12_ID_66_3))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
        [DataElement("569", typeof(X12_ID_569))]
        [Pos(5)]
        public string AccountNumberQualifier_05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(6)]
        public string TPAorBrokerAccountNumber_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [DataElement("107", typeof(X12_ID_107))]
        [Pos(8)]
        public string PaymentMethodTypeCode_08 { get; set; }
        [DataElement("1216", typeof(X12_ID_1216))]
        [Pos(9)]
        public string BenefitStatusCode_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",01,03,05,06,07,08,1,10,11,12,13,14,2,3,4,5,6,7,8,9,AG,ALC,ANN,AP,BA,CB,CC,CDM,CD" +
        "S,CM,CRU,DA,DC,EC,EPC,GL,LN,LTD,MUT,PRI,RD,REL,RS,SG,SKA,Z,ZB1,ZB2,")]
    public class X12_ID_569
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,8,A,AA,AB,AC,AD,AE,AF,AG,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y" +
        ",")]
    public class X12_ID_107
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,C,I,S,T,V,")]
    public class X12_ID_1216
    {
    }
    
    [Serializable()]
    [Segment("N1", typeof(X12_ID_98_4))]
    public class N1_TPA_BrokerName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_4))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string TPAorBrokerName_02 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string TPAorBrokerIdentificationCode_04 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",94,FI,XV,")]
    public class X12_ID_66_2
    {
    }
    
    [Serializable()]
    [Group("N1")]
    public class Loop_1000B
    {
        
        [Required]
        [Pos(1)]
        public N1_Payer N1_Payer { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",IN,")]
    public class X12_ID_98_3
    {
    }
    
    [Serializable()]
    [Segment("N1", typeof(X12_ID_98_3))]
    public class N1_Payer
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_3))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string InsurerName_02 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string InsurerIdentificationCode_04 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    [Serializable()]
    [Group("N1")]
    public class Loop_1000A
    {
        
        [Required]
        [Pos(1)]
        public N1_SponsorName N1_SponsorName { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",P5,")]
    public class X12_ID_98
    {
    }
    
    [Serializable()]
    [Segment("N1", typeof(X12_ID_98))]
    public class N1_SponsorName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string PlanSponsorName_02 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string SponsorIdentifier_04 { get; set; }
        [DataElement("706", typeof(X12_ID_706))]
        [Pos(5)]
        public string EntityRelationshipCode_05 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(6)]
        public string EntityIdentifierCode_06 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,94,FI,")]
    public class X12_ID_66
    {
    }
    
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673))]
    public class QTY_TransactionSetControlTotals
    {
        
        [Required]
        [DataElement("673", typeof(X12_ID_673))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string RecordTotals_02 { get; set; }
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure")]
    public class C001_CompositeUnitofMeasure
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        public string Exponent_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        public string Multiplier_03 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        public string Exponent_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        public string Multiplier_06 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        public string Exponent_08 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        public string Multiplier_09 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        public string Exponent_11 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        public string Multiplier_12 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        public string Exponent_14 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        public string Multiplier_15 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H" +
        ",1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1T,1X,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2" +
        "F,2G,2H,2I,2J,2K,2L,2M,2N,2P,2Q,2R,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38," +
        "39,3B,3C,3E,3F,3G,3H,3I,40,41,43,44,45,46,47,48,4A,4B,4C,4D,4E,4F,4G,4I,4J,4K,4L" +
        ",4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,50,51,52,53,54,56,57,58,59,5A,5B,5C,5D,5E,5" +
        "F,5G,5H,5I,5J,5K,5P,5Q,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,76,77,78,79," +
        "80,81,82,83,84,85,86,87,89,8C,8D,8P,8R,8S,8U,90,91,92,93,94,95,96,97,98,99,A8,AA" +
        ",AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B0,B" +
        "1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR," +
        "BS,BT,BU,BV,BW,BX,BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI" +
        ",CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D5,D8,D9,DA,DB,DC,D" +
        "D,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DW,DX,DY,DZ,E1,E3,E4,E5,E7," +
        "E8,E9,EA,EB,EC,ED,EE,EF,EG,EH,EJ,EM,EP,EQ,EV,EX,EY,EZ,F1,F2,F3,F4,F5,F6,F9,FA,FB" +
        ",FD,FE,FF,FG,FH,FJ,FK,FL,FM,FO,FP,FR,FS,FT,FZ,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,G" +
        "D,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H1,H2,H3,H4," +
        "H5,H6,H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HV" +
        ",HW,HY,HZ,IA,IB,IC,IE,IF,IG,IH,II,IK,IL,IM,IN,IP,IS,IT,IU,IV,IW,J1,J2,J3,J4,J5,J" +
        "6,J7,J8,J9,JA,JB,JC,JE,JG,JK,JL,JM,JN,JO,JP,JR,JS,JT,JU,JV,JX,K1,K2,K3,K4,K5,K6," +
        "K7,K9,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KO,KP,KQ,KR,KT,KU,KV,KW,KX,L1,L2,LA" +
        ",LB,LC,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LT,LX,LY,M0,M1,M2,M3,M4,M5,M" +
        "6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW," +
        "MX,MY,MZ,N1,N2,N3,N4,N6,N7,N9,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NN,NQ,NR,NS" +
        ",NT,NU,NV,NW,NX,NY,OA,OC,ON,OP,OT,OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,P" +
        "E,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5," +
        "Q6,Q7,QA,QB,QC,QD,QE,QH,QK,QR,QS,QT,QU,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE" +
        ",RG,RH,RK,RL,RM,RN,RO,RP,RS,RT,RU,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,S" +
        "G,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SV,SW,SX,SY,SZ,T0,T1,T2,T3,T4,T5,T6,T7," +
        "T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV,TW,TX,TY" +
        ",TZ,U1,U2,U3,U5,UA,UB,UC,UD,UE,UF,UH,UL,UM,UN,UP,UQ,UR,US,UT,UU,UV,UW,UX,UY,UZ,V" +
        "1,V2,VA,VC,VI,VP,VR,VS,W2,WA,WB,WD,WE,WG,WH,WI,WK,WM,WP,WR,WW,X1,X2,X3,X4,X5,X6," +
        "X7,X8,X9,XP,Y1,Y2,Y3,Y4,YD,YL,YR,YT,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF" +
        ",ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_355
    {
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374), typeof(X12_ID_1250))]
    public class DTP_FileEffectiveDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(3)]
        public string DateTimePeriod_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128))]
    public class REF_TransactionSetPolicyNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MasterPolicyNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier")]
    public class C040_ReferenceIdentifier
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("BGN", typeof(X12_ID_353))]
    public class BGN_BeginningSegment
    {
        
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string TransactionSetReferenceNumber_02 { get; set; }
        [Required]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string TransactionSetCreationDate_03 { get; set; }
        [Required]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(4)]
        public string TransactionSetCreationTime_04 { get; set; }
        [DataElement("623", typeof(X12_ID_623))]
        [Pos(5)]
        public string TimeZoneCode_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string OriginalTransactionSetReferenceNumber_06 { get; set; }
        [DataElement("640", typeof(X12_ID_640))]
        [Pos(7)]
        public string TransactionTypeCode_07 { get; set; }
        [Required]
        [DataElement("306", typeof(X12_ID_306))]
        [Pos(8)]
        public string ActionCode_08 { get; set; }
        [DataElement("786", typeof(X12_ID_786))]
        [Pos(9)]
        public string SecurityLevelCode_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,AD,AS,AT" +
        ",CD,CS,CT,ED,ES,ET,GM,HD,HS,HT,LT,MD,MS,MT,ND,NS,NT,PD,PS,PT,TD,TS,TT,UT,")]
    public class X12_ID_623
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,20,21,22,23,24,25" +
        ",26,27,28,30,31,33,34,35,36,37,38,39,3M,40,41,42,43,44,45,46,47,48,49,50,51,52,5" +
        "4,55,56,57,58,60,62,63,64,65,66,67,68,69,6A,6C,6N,6R,6S,70,71,72,73,74,75,76,77," +
        "78,79,80,81,82,83,85,87,88,89,91,94,95,97,98,99,A0,A1,A3,A4,A5,A6,A7,AA,AB,AC,AD" +
        ",AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AP,AQ,AR,AS,AT,AV,AW,AZ,BA,BB,BD,BF,BG,BH,BJ,BK,B" +
        "L,BM,BN,BO,BP,BR,BS,BT,BU,BV,BW,BX,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD," +
        "CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D4,DA,DB,DC,DD" +
        ",DE,DF,DG,DH,DI,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,E1,EA,EB,EC,ED,EF,EI,EM,EP,ER,E" +
        "X,F1,F4,F5,F6,F7,F8,FA,FB,FC,FD,FE,FF,FG,FI,FL,FM,FN,FP,FR,FS,FT,G1,G2,G3,GA,GI," +
        "GR,GS,GT,GU,GV,GW,GX,GY,HA,HB,HC,HD,HE,HF,HG,HP,HX,I1,IA,IB,IC,ID,IE,IF,II,IM,IN" +
        ",IO,IR,IU,IW,IX,IZ,JM,JO,JR,JS,JU,JX,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KS,K" +
        "T,LC,LD,LE,LF,LN,LO,LP,LR,LV,M1,MA,MB,MC,MD,ME,MF,MI,ML,MM,MP,MR,MS,MU,N1,N2,N3," +
        "N4,N5,N6,N7,N8,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NO,NP,NQ,NR,NS,NT,NU,OC,OF" +
        ",OP,OR,P1,PA,PB,PC,PD,PE,PF,PG,PH,PI,PL,PM,PO,PP,PR,PS,PT,PU,PV,PW,PX,PZ,Q1,Q2,Q" +
        "A,QB,QC,QD,QE,QF,QG,QH,QJ,QK,QL,QP,QR,R1,R2,R3,R4,R5,R6,R7,R8,RA,RB,RC,RD,RE,RF," +
        "RG,RH,RI,RJ,RK,RM,RP,RQ,RS,RT,RU,RZ,S1,S2,S3,S4,SA,SB,SC,SD,SE,SF,SG,SH,SL,SM,SO" +
        ",SP,SQ,SR,SS,ST,SU,SV,T1,T2,T3,T4,T5,T6,T7,T8,T9,TD,TF,TG,TH,TI,TJ,TK,TL,TP,TR,T" +
        "S,TT,TX,U1,U2,U4,U5,U9,UA,UC,UD,UF,UI,UM,UO,UP,UR,UT,V1,V2,V3,V4,VH,VJ,VL,VM,VN," +
        "VO,VP,VQ,VR,W1,W4,W5,WA,WC,WD,WH,WO,WS,WT,X1,XA,XB,XC,XD,XX,XY,XZ,YI,YR,Z1,Z2,Z3" +
        ",Z4,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,Z" +
        "Z,")]
    public class X12_ID_640
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,4,RX,")]
    public class X12_ID_306
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,06,09,11,20,21,90,92,93,94,99,ZZ,")]
    public class X12_ID_786
    {
    }
    
    [Serializable()]
    [Segment("ST", typeof(X12_ID_143))]
    public class ST
    {
        
        [Required]
        [DataElement("143", typeof(X12_ID_143))]
        [Pos(1)]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [Required]
        [StringLength(4, 9)]
        [DataElement("329", typeof(X12_AN))]
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
        [Required]
        [DataElement("1705", typeof(X12_ID_1705))]
        [Pos(3)]
        public string ImplementationConventionReference_03 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",005010X220A1,")]
    public class X12_ID_1705
    {
    }
}
