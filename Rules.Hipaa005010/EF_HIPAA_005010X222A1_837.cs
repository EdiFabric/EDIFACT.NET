namespace EdiFabric.Rules.HIPAA_005010X222A1_837
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using EdiFabric.Attributes;
    
    
    [M("X12", "005010X222A1", "837")]
    public class TS837
    {
        
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [S("ST", 1)]
        public ST ST { get; set; }
        [S("BHT", 2)]
        public BHT_BeginningofHierarchicalTransaction BHT_BeginningofHierarchicalTransaction { get; set; }
        [A(3)]
        public All_NM1 All_NM1 { get; set; }
        [G(4)]
        public List<Loop_2000A> Loop_2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [S("SE", 5)]
        public SE SE { get; set; }
    }
    
    public class SE
    {
        
        [D(1, typeof(X12_N0), "96")]
        public string TransactionSegmentCount_01 { get; set; }
        [D(2, typeof(X12_AN), "329")]
        public string TransactionSetControlNumber_02 { get; set; }
    }
    
    public class X12_N0
    {
    }
    
    public class X12_AN
    {
    }
    
    public class Loop_2000A
    {
        
        [S("HL", 1)]
        public HL_BillingProviderHierarchicalLevel HL_BillingProviderHierarchicalLevel { get; set; }
        [S("PRV", 2)]
        public PRV_BillingProviderSpecialtyInformation PRV_BillingProviderSpecialtyInformation { get; set; }
        [S("CUR", 3)]
        public CUR_ForeignCurrencyInformation CUR_ForeignCurrencyInformation { get; set; }
        [A(4)]
        public All_NM1_2 All_NM1_2 { get; set; }
        [G(5)]
        public List<Loop_2000B> Loop_2000B { get; set; }
    }
    
    public class Loop_2000B
    {
        
        [S("HL", 1)]
        public HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel { get; set; }
        [S("SBR", 2)]
        public SBR_SubscriberInformation SBR_SubscriberInformation { get; set; }
        [S("PAT", 3)]
        public PAT_PatientInformation PAT_PatientInformation { get; set; }
        [A(4)]
        public All_NM1_3 All_NM1_3 { get; set; }
        [G(5)]
        public List<Loop_2300> Loop_2300 { get; set; }
        [G(6)]
        public List<Loop_2000C> Loop_2000C { get; set; }
    }
    
    public class Loop_2000C
    {
        
        [S("HL", 1)]
        public HL_PatientHierarchicalLevel HL_PatientHierarchicalLevel { get; set; }
        [S("PAT", 2)]
        public PAT_PatientInformation_2 PAT_PatientInformation_2 { get; set; }
        [G(3)]
        public Loop_2010CA Loop_2010CA { get; set; }
        [G(4)]
        public List<Loop_2300_2> Loop_2300_2 { get; set; }
    }
    
    public class Loop_2300_2
    {
        
        [S("CLM", 1)]
        public CLM_ClaimInformation_2 CLM_ClaimInformation_2 { get; set; }
        [A(2)]
        public All_DTP_3 All_DTP_3 { get; set; }
        [S("PWK", 3)]
        public List<PWK_ClaimSupplementalInformation_2> PWK_ClaimSupplementalInformation_2 { get; set; }
        [S("CN1", 4)]
        public CN1_ContractInformation_3 CN1_ContractInformation_3 { get; set; }
        [S("AMT", 5)]
        public AMT_PatientAmountPaid_2 AMT_PatientAmountPaid_2 { get; set; }
        [A(6)]
        public All_REF_9 All_REF_9 { get; set; }
        [S("K3", 7)]
        public List<K3_FileInformation_3> K3_FileInformation_3 { get; set; }
        [S("NTE", 8)]
        public NTE_ClaimNote_2 NTE_ClaimNote_2 { get; set; }
        [S("CR1", 9)]
        public CR1_AmbulanceTransportInformation_3 CR1_AmbulanceTransportInformation_3 { get; set; }
        [S("CR2", 10)]
        public CR2_SpinalManipulationServiceInformation_2 CR2_SpinalManipulationServiceInformation_2 { get; set; }
        [A(11)]
        public All_CRC_3 All_CRC_3 { get; set; }
        [A(12)]
        public All_HI_2 All_HI_2 { get; set; }
        [S("HCP", 13)]
        public HCP_ClaimPricing_RepricingInformation_2 HCP_ClaimPricing_RepricingInformation_2 { get; set; }
        [A(14)]
        public All_NM1_7 All_NM1_7 { get; set; }
        [G(15)]
        public List<Loop_2320_2> Loop_2320_2 { get; set; }
        [G(16)]
        public List<Loop_2400_2> Loop_2400_2 { get; set; }
    }
    
    public class Loop_2400_2
    {
        
        [S("LX", 1)]
        public LX_ServiceLineNumber_2 LX_ServiceLineNumber_2 { get; set; }
        [S("SV1", 2)]
        public SV1_ProfessionalService_2 SV1_ProfessionalService_2 { get; set; }
        [S("SV5", 3)]
        public SV5_DurableMedicalEquipmentService_2 SV5_DurableMedicalEquipmentService_2 { get; set; }
        [A(4)]
        public All_PWK_2 All_PWK_2 { get; set; }
        [S("CR1", 5)]
        public CR1_AmbulanceTransportInformation_4 CR1_AmbulanceTransportInformation_4 { get; set; }
        [S("CR3", 6)]
        public CR3_DurableMedicalEquipmentCertification_2 CR3_DurableMedicalEquipmentCertification_2 { get; set; }
        [A(7)]
        public All_CRC_4 All_CRC_4 { get; set; }
        [A(8)]
        public All_DTP_4 All_DTP_4 { get; set; }
        [A(9)]
        public All_QTY_2 All_QTY_2 { get; set; }
        [S("MEA", 10)]
        public List<MEA_TestResult_2> MEA_TestResult_2 { get; set; }
        [S("CN1", 11)]
        public CN1_ContractInformation_4 CN1_ContractInformation_4 { get; set; }
        [A(12)]
        public All_REF_11 All_REF_11 { get; set; }
        [A(13)]
        public All_AMT_4 All_AMT_4 { get; set; }
        [S("K3", 14)]
        public List<K3_FileInformation_4> K3_FileInformation_4 { get; set; }
        [A(15)]
        public All_NTE_2 All_NTE_2 { get; set; }
        [S("PS1", 16)]
        public PS1_PurchasedServiceInformation_2 PS1_PurchasedServiceInformation_2 { get; set; }
        [S("HCP", 17)]
        public HCP_LinePricing_RepricingInformation_2 HCP_LinePricing_RepricingInformation_2 { get; set; }
        [G(18)]
        public Loop_2410_2 Loop_2410_2 { get; set; }
        [A(19)]
        public All_NM1_9 All_NM1_9 { get; set; }
        [G(20)]
        public List<Loop_2430_2> Loop_2430_2 { get; set; }
        [G(21)]
        public List<Loop_2440_2> Loop_2440_2 { get; set; }
    }
    
    public class Loop_2440_2
    {
        
        [S("LQ", 1)]
        public LQ_FormIdentificationCode_2 LQ_FormIdentificationCode_2 { get; set; }
        [S("FRM", 2)]
        public List<FRM_SupportingDocumentation_2> FRM_SupportingDocumentation_2 { get; set; }
    }
    
    public class FRM_SupportingDocumentation_2
    {
        
        [D(1, typeof(X12_AN), "350")]
        public string QuestionNumberLetter_01 { get; set; }
        [D(2, typeof(X12_ID_1073_4), "1073")]
        public string QuestionResponse_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string QuestionResponse_03 { get; set; }
        [D(4, typeof(X12_DT), "373")]
        public string QuestionResponse_04 { get; set; }
        [D(5, typeof(X12_R), "332")]
        public string QuestionResponse_05 { get; set; }
    }
    
    public class X12_ID_1073_4
    {
        
        public List<string> Codes = new List<string> {"N","W","Y"};
    }
    
    public class X12_DT
    {
    }
    
    public class X12_R
    {
    }
    
    public class LQ_FormIdentificationCode_2
    {
        
        [D(1, typeof(X12_ID_1270_7), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string FormIdentifier_02 { get; set; }
    }
    
    public class X12_ID_1270_7
    {
        
        public List<string> Codes = new List<string> {"AS","UT"};
    }
    
    public class Loop_2430_2
    {
        
        [S("SVD", 1)]
        public SVD_LineAdjudicationInformation_2 SVD_LineAdjudicationInformation_2 { get; set; }
        [S("CAS", 2)]
        public List<CAS_LineAdjustment_2> CAS_LineAdjustment_2 { get; set; }
        [S("DTP", 3)]
        public DTP_LineCheckorRemittanceDate_2 DTP_LineCheckorRemittanceDate_2 { get; set; }
        [S("AMT", 4)]
        public AMT_RemainingPatientLiability_4 AMT_RemainingPatientLiability_4 { get; set; }
    }
    
    public class AMT_RemainingPatientLiability_4
    {
        
        [D(1, typeof(X12_ID_522_4), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string RemainingPatientLiability_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class X12_ID_522_4
    {
        
        public List<string> Codes = new List<string> {"EAF"};
    }
    
    public class X12_ID_478
    {
        
        public List<string> Codes = new List<string> {"C","D"};
    }
    
    public class DTP_LineCheckorRemittanceDate_2
    {
        
        [D(1, typeof(X12_ID_374_18), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    public class X12_ID_374_18
    {
        
        public List<string> Codes = new List<string> {"573"};
    }
    
    public class X12_ID_1250
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class CAS_LineAdjustment_2
    {
        
        [D(1, typeof(X12_ID_1033), "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3, typeof(X12_R), "782")]
        public string AdjustmentAmount_03 { get; set; }
        [D(4, typeof(X12_R), "380")]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6, typeof(X12_R), "782")]
        public string AdjustmentAmount_06 { get; set; }
        [D(7, typeof(X12_R), "380")]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9, typeof(X12_R), "782")]
        public string AdjustmentAmount_09 { get; set; }
        [D(10, typeof(X12_R), "380")]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12, typeof(X12_R), "782")]
        public string AdjustmentAmount_12 { get; set; }
        [D(13, typeof(X12_R), "380")]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15, typeof(X12_R), "782")]
        public string AdjustmentAmount_15 { get; set; }
        [D(16, typeof(X12_R), "380")]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18, typeof(X12_R), "782")]
        public string AdjustmentAmount_18 { get; set; }
        [D(19, typeof(X12_R), "380")]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class X12_ID_1033
    {
        
        public List<string> Codes = new List<string> {"CO","CR","OA","PI","PR"};
    }
    
    public class X12_ID
    {
    }
    
    public class SVD_LineAdjudicationInformation_2
    {
        
        [D(1, typeof(X12_AN), "67")]
        public string OtherPayerPrimaryIdentifier_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string ServiceLinePaidAmount_02 { get; set; }
        [C(3)]
        public C003_CompositeMedicalProcedureIdentifier_6 CompositeMedicalProcedureIdentifier_03 { get; set; }
        [D(4, typeof(X12_AN), "234")]
        public string ProductServiceID_04 { get; set; }
        [D(5, typeof(X12_R), "380")]
        public string PaidServiceUnitCount_05 { get; set; }
        [D(6, typeof(X12_N0), "554")]
        public string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    public class C003_CompositeMedicalProcedureIdentifier_6
    {
        
        [D(1, typeof(X12_ID_235_2), "235")]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, typeof(X12_AN), "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, typeof(X12_AN), "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, typeof(X12_AN), "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string ProcedureCodeDescription_07 { get; set; }
        [D(8, typeof(X12_AN), "234")]
        public string ProductServiceID_08 { get; set; }
    }
    
    public class X12_ID_235_2
    {
        
        public List<string> Codes = new List<string> {"ER","HC","IV","WK"};
    }
    
    public class All_NM1_9
    {
        
        [G(1)]
        public Loop_2420A_2 Loop_2420A_2 { get; set; }
        [G(2)]
        public Loop_2420B_2 Loop_2420B_2 { get; set; }
        [G(3)]
        public Loop_2420C_2 Loop_2420C_2 { get; set; }
        [G(4)]
        public Loop_2420D_2 Loop_2420D_2 { get; set; }
        [G(5)]
        public Loop_2420E_2 Loop_2420E_2 { get; set; }
        [G(6)]
        public List<Loop_2420F_2> Loop_2420F_2 { get; set; }
        [G(7)]
        public Loop_2420G_2 Loop_2420G_2 { get; set; }
        [G(8)]
        public Loop_2420H_2 Loop_2420H_2 { get; set; }
    }
    
    public class Loop_2420H_2
    {
        
        [S("NM1", 1)]
        public NM1_AmbulanceDrop_offLocation_4 NM1_AmbulanceDrop_offLocation_4 { get; set; }
        [S("N3", 2)]
        public N3_AmbulanceDrop_offLocationAddress_4 N3_AmbulanceDrop_offLocationAddress_4 { get; set; }
        [S("N4", 3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode_4 N4_AmbulanceDrop_offLocationCity_State_ZipCode_4 { get; set; }
    }
    
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode_4
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class X12_ID_309
    {
        
        public List<string> Codes = new List<string> {"10","11","12","13","14","18","19","20","21","22","27","28","29","30","31","32","33","34","35","36","38","39","40","41","42","43","44","45","46","47","48","49","50","52","53","54","55","57","58","59","60","93","94","A","A1","AA","AC","AP","AR","B","B1","BE","BL","BS","C","C2","CA","CB","CC","CD","CE","CG","CI","CL","CM","CO","CR","CS","CY","D","DC","DE","DL","DO","DP","DR","DT","E","EA","EB","EL","F","FA","FE","FF","FI","FR","FS","FT","FV","G","GL","H","I","IA","IB","IM","IP","IS","IT","J","K","KE","KL","KP","L","LO","M","MI","MO","MS","MZ","NS","O","OA","OF","OL","OP","OR","OV","P","PA","PB","PC","PD","PE","PF","PG","PH","PL","PM","PO","PP","PQ","PR","PS","PT","PU","PV","PZ","Q","RA","RC","RE","RG","RJ","RL","RS","RT","SA","SB","SC","SD","SE","SG","SH","SL","SN","SP","SS","ST","SW","TA","TC","TI","TL","TM","TN","TP","TR","TX","UN","UR","UT","VA","VI","VS","W","WF","WH","WI","X1","ZN","ZZ"};
    }
    
    public class N3_AmbulanceDrop_offLocationAddress_4
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulanceDrop_offLocation_4
    {
        
        [D(1, typeof(X12_ID_98_14), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string AmbulanceDropoffLocation_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_14
    {
        
        public List<string> Codes = new List<string> {"45"};
    }
    
    public class X12_ID_1065_2
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_3
    {
        
        public List<string> Codes = new List<string> {"0","1","10","11","12","13","15","16","17","19","2","20","21","22","23","24","25","26","27","28","29","3","30","31","32","33","34","35","36","37","38","39","4","40","41","42","43","44","45","46","47","48","49","50","51","53","54","55","56","57","58","59","6","61","62","63","64","7","71","72","73","74","75","76","77","78","81","82","83","9","90","91","92","93","94","95","96","97","98","99","A","A1","A2","A3","A4","A5","A6","A7","AA","AB","AC","AD","AE","AF","AI","AL","AP","BC","BD","BE","BG","BN","BP","BS","C","C1","C2","C5","CA","CB","CC","CD","CE","CF","CI","CL","CM","CN","CP","CR","CS","CT","D","DG","DL","DN","DO","DP","DR","DS","E","EC","EH","EI","EL","EP","EQ","ER","ES","ET","F","FA","FB","FC","FD","FE","FI","FJ","FL","FN","G","GA","GC","HC","HN","HS","I","ID","II","IP","J","K","L","LC","LD","LE","LI","LN","M","M3","M4","M5","M6","MA","MB","MC","MD","MI","MK","ML","MN","MO","MP","MR","N","NA","ND","NI","NO","NR","OC","OP","PA","PB","PC","PI","PP","PR","RA","RB","RC","RD","RE","RI","RP","RT","S","SA","SB","SD","SF","SI","SJ","SK","SL","SP","ST","SV","SW","TA","TC","TL","TS","TZ","UC","UI","UL","UP","UR","US","UT","WR","WS","X1","XV","XX","XY","ZC","ZN","ZY","ZZ"};
    }
    
    public class X12_ID_706
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97","98","99","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","CP","OP","PI"};
    }
    
    public class X12_ID_98_2
    {
        
        public List<string> Codes = new List<string> {"00","001","002","003","004","005","006","007","008","01","02","03","04","05","06","07","08","09","0A","0B","0D","0E","0F","0G","0H","0I","0J","0P","10","11","12","13","14","15","16","17","18","19","1A","1B","1C","1D","1E","1F","1G","1H","1I","1J","1K","1L","1M","1N","1O","1P","1Q","1R","1S","1T","1U","1V","1W","1X","1Y","1Z","20","21","22","23","24","25","26","27","28","29","2A","2B","2C","2D","2E","2F","2G","2H","2I","2J","2K","2L","2M","2N","2O","2P","2Q","2R","2S","2T","2U","2V","2W","2X","2Y","2Z","30","31","32","33","34","35","36","37","38","39","3A","3B","3C","3D","3E","3F","3G","3H","3I","3J","3K","3L","3M","3N","3O","3P","3Q","3R","3S","3T","3U","3V","3W","3X","3Y","3Z","40","41","42","43","44","45","46","47","48","49","4A","4B","4C","4D","4E","4F","4G","4H","4I","4J","4K","4L","4M","4N","4O","4P","4Q","4R","4S","4T","4U","4V","4W","4X","4Y","4Z","50","51","52","53","54","55","56","57","58","59","5A","5B","5C","5D","5E","5F","5G","5H","5I","5J","5K","5L","5M","5N","5O","5P","5Q","5R","5S","5T","5U","5V","5W","5X","5Y","5Z","60","61","62","63","64","65","66","67","68","69","6A","6B","6C","6D","6E","6F","6G","6H","6I","6J","6K","6L","6M","6N","6O","6P","6Q","6R","6S","6T","6U","6V","6W","6X","6Y","6Z","70","71","72","73","74","75","76","77","78","79","7A","7B","7C","7D","7E","7F","7G","7H","7I","7J","7K","7L","7M","7N","7O","7P","7Q","7R","7S","7T","7U","7V","7W","7X","7Y","7Z","80","81","82","83","84","85","86","87","88","89","8A","8B","8C","8D","8E","8F","8G","8H","8I","8J","8K","8L","8M","8N","8O","8P","8Q","8R","8S","8T","8U","8V","8W","8X","8Y","90","91","92","93","94","95","96","97","98","99","9A","9B","9C","9D","9E","9F","9G","9H","9I","9J","9K","9L","9N","9O","9P","9Q","9R","9S","9T","9U","9V","9W","9X","9Y","9Z","A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","AA1","AA2","AA3","AA4","AA5","AA6","AA7","AA8","AA9","AAA","AAB","AAC","AAD","AAE","AAF","AAG","AAH","AAI","AAJ","AAK","AAL","AAM","AAN","AAO","AAP","AAQ","AAS","AAT","AAU","AAV","AAW","AB","AB1","AB2","AB3","AB4","AB5","AB6","AB7","AB8","AB9","ABB","ABC","ABD","ABE","ABF","ABG","ABH","ABI","ABJ","ABK","ABL","ABM","ABN","ABO","ABP","ABQ","ABR","ABS","ABT","ABU","ABV","ABW","ABX","AC","AC1","AC2","AC3","ACB","ACC","ACE","ACF","ACG","ACH","ACI","ACJ","ACK","ACL","ACM","ACN","ACO","ACP","ACQ","ACR","ACS","ACT","ACU","ACV","ACW","ACX","ACY","ACZ","AD","ADA","ADB","ADC","ADD","ADE","ADF","ADH","ADJ","ADK","ADL","ADM","ADN","ADO","ADP","ADQ","ADR","ADS","ADT","ADU","ADV","ADW","ADX","ADY","ADZ","AE","AEA","AEB","AEC","AED","AEE","AEF","AEG","AEI","AEJ","AEK","AEL","AF","AG","AH","AHM","AI","AJ","AK","AL","ALA","ALO","AM","AN","AO","AP","APR","AQ","AR","AS","AT","ATA","AU","AUO","AV","AW","AX","AY","AZ","B1","B2","B3","B4","B5","B6","B7","B8","B9","BA","BAL","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BKR","BL","BLD","BLT","BM","BN","BO","BOW","BP","BQ","BR","BRN","BS","BT","BU","BUS","BV","BW","BX","BY","BZ","C0","C1","C2","C3","C4","C4A","C5","C6","C7","C8","C9","CA","CB","CC","CD","CE","CF","CG","CH","CHA","CI","CJ","CK","CL","CLT","CM","CMW","CN","CNP","CNR","CNS","CO","COD","COL","COM","COR","CP","CQ","CR","CRW","CS","CT","CU","CV","CW","CX","CY","CZ","D1","D2","D3","D4","D5","D6","D7","D8","D9","DA","DAM","DB","DC","DCC","DD","DE","DF","DG","DH","DI","DIR","DJ","DK","DL","DM","DN","DO","DP","DQ","DR","DS","DT","DU","DV","DW","DX","DY","DZ","E0","E1","E2","E3","E4","E5","E6","E7","E8","E9","EA","EAA","EAB","EAD","EAE","EAF","EAG","EAH","EAI","EAJ","EAK","EAL","EAM","EAN","EAO","EAP","EAQ","EAR","EAS","EAT","EAU","EAV","EAW","EAX","EAY","EAZ","EB","EBA","EBB","EBC","EBD","EBE","EBF","EBG","EBH","EBI","EBJ","EBK","EBL","EBM","EBN","EBO","EBP","EBQ","EBR","EBS","EC","ED","EE","EF","EG","EH","EI","EJ","EK","EL","EM","EN","ENR","EO","EP","EQ","ER","ET","EU","EV","EW","EX","EXS","EY","EZ","F1","F2","F3","F4","F5","F6","F7","F8","F9","FA","FB","FC","FD","FE","FF","FG","FGT","FH","FI","FJ","FL","FM","FN","FO","FP","FQ","FR","FRL","FS","FSI","FSR","FT","FU","FV","FW","FX","FY","FZ","G0","G1","G2","G3","G5","G6","G7","G8","G9","GA","GB","GBA","GBO","GBP","GC","GD","GE","GF","GG","GH","GI","GIR","GJ","GK","GL","GM","GN","GO","GP","GQ","GR","GS","GT","GU","GV","GW","GX","GY","GZ","H1","H2","H3","H5","H6","H7","H9","HA","HB","HC","HD","HE","HF","HG","HH","HI","HJ","HK","HL","HM","HMI","HN","HO","HOM","HON","HP","HQ","HR","HS","HT","HU","HV","HW","HX","HY","HZ","I1","I3","I4","I9","IA","IAA","IAC","IAD","IAE","IAF","IAG","IAH","IAI","IAK","IAL","IAM","IAN","IAO","IAP","IAQ","IAR","IAS","IAT","IAU","IAV","IAW","IAY","IAZ","IB","IC","ICP","ID","IE","IF","IG","II","IJ","IK","IL","IM","IMM","IN","INT","INV","IO","IP","IQ","IR","IS","IT","IU","IV","J1","J2","J3","J4","J5","J6","J7","J8","J9","JA","JB","JC","JD","JE","JF","JG","JH","JI","JJ","JK","JL","JM","JN","JO","JP","JQ","JR","JS","JT","JU","JV","JW","JX","JY","JZ","K1","K2","K3","K4","K5","K6","K7","K8","K9","KA","KB","KC","KD","KE","KF","KG","KH","KI","KJ","KK","KL","KM","KN","KO","KP","KQ","KR","KS","KT","KU","KV","KW","KX","KY","KZ","L1","L2","L3","L5","L8","L9","LA","LB","LC","LCN","LD","LE","LF","LG","LGS","LH","LI","LJ","LK","LL","LM","LN","LO","LP","LQ","LR","LS","LT","LU","LV","LW","LY","LYM","LYN","LYO","LYP","LZ","M1","M2","M3","M4","M5","M6","M7","M8","M9","MA","MB","MC","MD","ME","MF","MG","MH","MI","MJ","MK","ML","MM","MN","MO","MP","MQ","MR","MS","MSC","MT","MTR","MU","MV","MW","MX","MY","MZ","N1","N2","N3","N4","N5","N6","N7","N8","N9","NB","NC","NCT","ND","NE","NF","NG","NH","NI","NJ","NK","NL","NM","NN","NP","NPC","NQ","NR","NS","NT","NU","NV","NW","NX","NY","NZ","O1","O2","O3","O4","O5","O6","O7","O8","OA","OB","OC","OD","OE","OF","OG","OH","OI","OL","OM","ON","OO","OP","OR","ORI","OS","OSH","OT","OU","OUC","OV","OW","OX","OY","OZ","P0","P1","P2","P3","P4","P5","P6","P7","P8","P9","PA","PB","PC","PD","PE","PF","PG","PH","PI","PIC","PJ","PK","PL","PLC","PLR","PM","PMC","PMF","PMG","PN","PO","PP","PPC","PPS","PQ","PR","PRE","PRO","PRP","PS","PT","PU","PUR","PV","PW","PX","PY","PZ","Q1","Q2","Q3","Q4","Q5","Q6","Q7","Q8","Q9","QA","QB","QC","QD","QE","QF","QG","QH","QI","QJ","QK","QL","QM","QN","QO","QP","QQ","QR","QS","QT","QU","QV","QW","QX","QY","QZ","R0","R1","R2","R3","R4","R5","R6","R7","R8","R9","RA","RB","RC","RCR","RD","REC","RF","RG","RGA","RH","RI","RJ","RK","RL","RM","RN","RO","RP","RQ","RR","RR2","RR3","RS","RT","RU","RV","RW","RX","RY","RZ","S0","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SEP","SF","SG","SH","SI","SIC","SIP","SJ","SK","SL","SM","SN","SNP","SO","SP","SQ","SR","SS","ST","STC","SU","SUS","SV","SW","SX","SY","SZ","T1","T2","T3","T4","T6","T8","T9","TA","TB","TC","TD","TE","TEC","TF","TG","TH","TI","TJ","TK","TL","TM","TN","TO","TOW","TP","TPM","TQ","TR","TS","TSD","TSE","TSR","TT","TTP","TU","TV","TW","TX","TY","TZ","U1","U2","U3","U4","U5","U6","U7","U8","U9","UA","UB","UC","UD","UE","UF","UG","UH","UI","UJ","UK","UL","UM","UN","UO","UP","UQ","UR","US","UT","UU","UW","UX","UY","UZ","V1","V2","V3","V4","V5","V6","V8","V9","VA","VB","VC","VD","VE","VER","VF","VG","VH","VI","VIC","VJ","VK","VL","VM","VN","VO","VP","VQ","VR","VS","VT","VU","VV","VW","VX","VY","W1","W2","W3","W4","W8","W9","WA","WB","WC","WD","WE","WF","WG","WH","WI","WJ","WL","WN","WO","WP","WR","WS","WT","WU","WV","WW","WX","WY","WZ","X1","X2","X3","X4","X5","X6","X7","X8","XA","XC","XD","XE","XF","XG","XH","XI","XJ","XK","XL","XM","XN","XO","XP","XQ","XR","XS","XT","XU","XV","XW","XX","XY","XZ","Y2","YA","YB","YC","YD","YE","YF","YG","YH","YI","YJ","YK","YL","YM","YN","YO","YP","YQ","YR","YS","YT","YU","YV","YW","YX","YY","YZ","Z1","Z2","Z3","Z4","Z5","Z6","Z7","Z8","Z9","ZA","ZB","ZC","ZD","ZE","ZF","ZG","ZH","ZJ","ZK","ZL","ZM","ZN","ZO","ZP","ZQ","ZR","ZS","ZT","ZU","ZV","ZW","ZX","ZY","ZZ"};
    }
    
    public class Loop_2420G_2
    {
        
        [S("NM1", 1)]
        public NM1_AmbulancePick_upLocation_4 NM1_AmbulancePick_upLocation_4 { get; set; }
        [S("N3", 2)]
        public N3_AmbulancePick_upLocationAddress_4 N3_AmbulancePick_upLocationAddress_4 { get; set; }
        [S("N4", 3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode_4 N4_AmbulancePick_upLocationCity_State_ZipCode_4 { get; set; }
    }
    
    public class N4_AmbulancePick_upLocationCity_State_ZipCode_4
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string AmbulancePickupCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulancePick_upLocationAddress_4
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulancePick_upLocation_4
    {
        
        [D(1, typeof(X12_ID_98_13), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_13
    {
        
        public List<string> Codes = new List<string> {"PW"};
    }
    
    public class Loop_2420F_2
    {
        
        [S("NM1", 1)]
        public NM1_ReferringProviderName_4 NM1_ReferringProviderName_4 { get; set; }
        [S("REF", 2)]
        public List<REF_ReferringProviderSecondaryIdentification_4> REF_ReferringProviderSecondaryIdentification_4 { get; set; }
    }
    
    public class REF_ReferringProviderSecondaryIdentification_4
    {
        
        [D(1, typeof(X12_ID_128_25), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_100 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_25
    {
        
        public List<string> Codes = new List<string> {"0B","1G","G2"};
    }
    
    public class C040_ReferenceIdentifier_100
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class X12_ID_128_31
    {
        
        public List<string> Codes = new List<string> {"2U"};
    }
    
    public class X12_ID_128_3
    {
        
        public List<string> Codes = new List<string> {"00","01","01A","01B","01C","01D","01E","01G","01H","02","03","04","05","06","07","08","09","0A","0B","0D","0E","0F","0G","0H","0I","0J","0K","0L","0M","0N","0P","10","11","12","13","14","15","16","17","18","19","1A","1B","1C","1D","1E","1F","1G","1H","1I","1J","1K","1L","1M","1N","1O","1P","1Q","1R","1S","1T","1U","1V","1W","1X","1Y","1Z","20","21","22","23","24","25","26","27","28","29","2A","2B","2C","2D","2E","2F","2G","2H","2I","2J","2K","2L","2M","2N","2O","2P","2Q","2R","2S","2T","2U","2V","2W","2X","2Y","2Z","30","31","32","33","34","35","36","37","38","39","3A","3B","3C","3D","3E","3F","3G","3H","3I","3J","3K","3L","3M","3N","3O","3P","3Q","3R","3S","3T","3U","3V","3W","3X","3Y","3Z","40","41","42","43","44","45","46","47","48","49","4A","4B","4C","4D","4E","4F","4G","4H","4I","4J","4K","4L","4M","4N","4O","4P","4Q","4R","4S","4T","4U","4V","4W","4X","4Y","4Z","50","51","52","53","54","55","56","57","58","59","5A","5B","5C","5D","5E","5F","5G","5H","5I","5J","5K","5L","5M","5N","5O","5P","5Q","5R","5S","5T","5U","5V","5W","5X","5Y","5Z","60","61","63","64","65","66","67","68","69","6A","6B","6C","6D","6E","6F","6G","6H","6I","6J","6K","6L","6M","6N","6O","6P","6Q","6R","6S","6T","6U","6V","6X","6Y","6Z","70","71","72","73","74","75","76","77","78","79","7A","7B","7C","7D","7E","7F","7G","7H","7I","7J","7K","7L","7M","7N","7O","7P","7Q","7R","7S","7T","7U","7W","7X","7Y","7Z","80","81","82","83","84","85","86","87","88","89","8A","8B","8C","8D","8E","8F","8G","8H","8I","8J","8K","8L","8M","8N","8O","8P","8Q","8R","8S","8U","8V","8W","8X","8Y","8Z","90","91","92","93","94","95","96","97","98","99","9A","9B","9C","9D","9E","9F","9G","9H","9I","9J","9K","9L","9M","9N","9P","9Q","9R","9S","9T","9U","9V","9W","9X","9Y","9Z","A0","A1","A2","A3","A4","A5","A7","A8","A9","AA","AAA","AAB","AAC","AAD","AAE","AAF","AAG","AAH","AAI","AAJ","AAK","AAL","AAM","AAN","AAO","AAP","AAQ","AAR","AAS","AAT","AAU","AAV","AAW","AAX","AAY","AAZ","AB","ABA","ABB","ABC","ABD","ABE","ABF","ABG","ABH","ABI","ABJ","ABK","ABL","ABM","ABN","ABO","ABP","ABQ","ABR","ABS","ABT","ABU","ABV","ABW","ABX","ABY","ABZ","AC","ACA","ACB","ACC","ACD","ACE","ACF","ACG","ACH","ACI","ACJ","ACK","ACL","ACM","ACN","ACO","ACP","ACQ","ACR","ACS","ACT","ACU","ACV","ACW","ACX","ACY","ACZ","AD","ADA","ADB","ADC","ADD","ADE","ADF","ADG","ADH","ADI","ADJ","ADK","ADL","ADM","ADN","ADO","ADP","ADQ","ADR","ADS","ADT","ADU","ADV","ADW","ADX","ADY","ADZ","AE","AEA","AEB","AEC","AED","AEE","AEF","AEG","AEH","AEI","AEJ","AEK","AEL","AEM","AEN","AEO","AEP","AEQ","AER","AES","AET","AEU","AEV","AEX","AEY","AEZ","AF","AFA","AFB","AFC","AFD","AFE","AFF","AFG","AFH","AFI","AFJ","AFK","AFL","AFM","AFN","AFO","AFP","AFQ","AFR","AFS","AFT","AFU","AFV","AFW","AFX","AFY","AFZ","AG","AGA","AGB","AGC","AGD","AGH","AGI","AGJ","AGK","AGL","AGM","AGN","AGO","AGP","AGQ","AH","AHC","AI","AJ","AK","AL","ALC","ALG","ALH","ALI","ALJ","ALR","ALS","ALT","AM","AN","AO","AP","APC","API","AQ","AR","AS","ASL","ASP","AST","AT","ATC","AU","AV","AW","AX","AY","AZ","B1","B2","B3","B4","B5","B6","B7","B8","B9","BA","BAA","BAB","BAC","BAD","BAE","BAF","BAG","BAH","BAI","BAJ","BAK","BB","BC","BCI","BCN","BCP","BD","BDG","BDN","BE","BEN","BF","BG","BH","BI","BJ","BK","BKT","BL","BLT","BM","BMM","BN","BO","BOI","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ","C0","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CAA","CAB","CAC","CAD","CAE","CAF","CAG","CAH","CAI","CAJ","CAK","CAL","CAM","CAT","CB","CBG","CC","CD","CDN","CDT","CE","CF","CFR","CG","CH","CHR","CI","CID","CIR","CIT","CJ","CK","CL","CLI","CM","CMN","CMP","CMT","CN","CNA","CNO","CNS","CO","COL","COT","CP","CPA","CPD","CPR","CPT","CQ","CR","CRN","CRS","CS","CSC","CSG","CST","CT","CTS","CU","CUB","CV","CVS","CW","CX","CY","CYC","CZ","D0","D1","D2","D3","D4","D5","D6","D7","D8","D9","DA","DAI","DAN","DB","DC","DD","DE","DF","DG","DH","DHH","DI","DIS","DJ","DK","DL","DM","DN","DNR","DNS","DO","DOA","DOC","DOE","DOI","DOJ","DOL","DON","DOS","DOT","DP","DQ","DR","DRN","DS","DSC","DSI","DST","DT","DTS","DU","DUN","DV","DW","DX","DY","DZ","E00","E01","E02","E1","E2","E3","E4","E5","E6","E7","E8","E9","EA","EB","EC","ECA","ECB","ECC","ECD","ECE","ECF","ECJ","ED","EDA","EE","EF","EG","EH","EI","EII","EJ","EK","EL","EM","EMM","EN","END","EO","EP","EPA","EPB","EPC","EQ","ER","ES","ESN","ET","EU","EV","EVI","EW","EX","EXP","EY","EZ","F1","F2","F3","F4","F5","F6","F7","F8","F9","FA","FAN","FB","FC","FCN","FD","FE","FEN","FF","FG","FH","FHC","FHO","FI","FJ","FK","FL","FLZ","FM","FMG","FMP","FN","FND","FO","FP","FQ","FR","FRN","FS","FSC","FSN","FT","FTN","FTP","FTZ","FU","FV","FW","FWC","FX","FY","FZ","G1","G2","G3","G4","G5","G6","G7","G8","G9","GA","GB","GC","GD","GE","GF","GG","GH","GI","GJ","GK","GL","GM","GN","GO","GP","GQ","GR","GS","GT","GU","GV","GW","GWS","GX","GY","GZ","H1","H2","H3","H5","H6","H7","H8","H9","HA","HB","HC","HD","HE","HF","HG","HH","HHT","HI","HJ","HK","HL","HM","HMB","HN","HO","HP","HPI","HQ","HR","HS","HT","HU","HUD","HV","HW","HX","HY","HZ","I1","I2","I3","I4","I5","I7","I9","IA","IB","IC","ICD","ID","IE","IF","IFC","IFT","IG","IH","II","IID","IJ","IK","IL","IM","IMP","IMS","IN","IND","IO","IP","IQ","IR","IRN","IRP","IS","ISC","ISN","ISS","IT","ITI","IU","IV","IW","IX","IZ","J0","J1","J2","J3","J4","J5","J6","J7","J8","J9","JA","JB","JC","JCS","JD","JE","JF","JH","JI","JK","JL","JM","JN","JO","JP","JQ","JR","JS","JT","JU","JV","JW","JX","JY","JZ","K0","K1","K2","K3","K4","K5","K6","K7","K8","K9","KA","KAS","KB","KC","KCS","KD","KE","KG","KH","KI","KII","KJ","KK","KL","KM","KN","KO","KP","KQ","KR","KRL","KRP","KS","KSR","KT","KU","KV","KW","KX","KY","KZ","L0","L1","L2","L3","L4","L5","L6","L7","L8","L9","LA","LAA","LAN","LB","LC","LD","LE","LEN","LF","LG","LH","LI","LIC","LJ","LK","LL","LM","LMI","LN","LO","LOI","LOS","LP","LPK","LQ","LR","LS","LSD","LT","LU","LV","LVO","LW","LX","LY","LZ","M0","M1","M2","M3","M5","M6","M7","M8","M9","MA","MB","MBS","MBX","MC","MCC","MCI","MCN","MD","MDN","ME","MF","MG","MH","MI","MII","MIN","MJ","MK","ML","MM","MN","MO","MP","MPN","MQ","MR","MRC","MRN","MS","MSL","MT","MU","MUI","MV","MW","MX","MY","MZ","MZO","N0","N1","N2","N3","N4","N5","N6","N7","N8","N9","NA","NAS","NB","NC","ND","NDA","NDB","NE","NF","NFC","NFD","NFM","NFN","NFS","NG","NH","NI","NJ","NK","NL","NM","NMT","NN","NO","NP","NQ","NR","NS","NT","NTP","NU","NW","NX","NY","NZ","O1","O2","O5","O7","O8","O9","OA","OB","OC","OD","OE","OF","OFF","OG","OH","OI","OIC","OJ","OK","OL","OM","ON","OOS","OP","OPE","OPF","OQ","OR","OS","OT","OU","OV","OW","OX","OZ","P1","P2","P3","P4","P5","P6","P7","P8","P9","PA","PAC","PAN","PAP","PB","PC","PCC","PCN","PD","PDI","PDL","PDR","PE","PF","PG","PGC","PGD","PGN","PGS","PH","PHC","PHY","PI","PID","PIN","PJ","PJC","PK","PKG","PKU","PL","PLA","PLN","PM","PMN","PN","PNN","PO","POL","POS","PP","PPJ","PPK","PPL","PPM","PPN","PQ","PR","PRS","PRT","PS","PSI","PSL","PSM","PSN","PT","PTC","PU","PUA","PV","PVC","PW","PWC","PWS","PX","PXC","PY","PYA","PYR","PZ","Q1","Q2","Q3","Q4","Q5","Q6","Q7","Q8","Q9","QA","QB","QC","QD","QE","QF","QG","QH","QI","QJ","QK","QL","QM","QN","QO","QP","QQ","QR","QS","QT","QU","QV","QW","QX","QY","QZ","R0","R1","R2","R3","R4","R5","R6","R7","R8","R9","RA","RAA","RAN","RB","RC","RD","RE","REC","RF","RG","RGI","RH","RI","RIG","RJ","RK","RL","RLI","RM","RN","RO","RP","RPP","RPS","RPT","RQ","RR","RRC","RRS","RS","RSN","RSS","RT","RU","RV","RW","RWK","RX","RY","RZ","S0","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SAL","SB","SBN","SC","SCA","SCN","SD","SDT","SE","SEK","SES","SF","SG","SH","SHL","SI","SII","SJ","SK","SL","SM","SMC","SMT","SN","SNH","SNP","SNV","SO","SP","SPL","SPN","SQ","SR","SS","SST","ST","STB","STR","STS","SU","SUB","SUC","SUO","SV","SW","SX","SY","SZ","T0","T1","T2","T3","T4","T5","T6","T7","T8","T9","TA","TB","TC","TD","TDT","TE","TF","TFC","TG","TH","TI","TIP","TJ","TK","TL","TM","TN","TO","TOC","TP","TPN","TQ","TR","TS","TSN","TT","TU","TV","TW","TX","TY","TZ","U0","U1","U2","U3","U4","U5","U6","U8","U9","UA","UB","UC","UCB","UCM","UD","UE","UF","UG","UH","UI","UIC","UJ","UK","UL","UM","UN","UO","UP","UQ","UR","URL","URP","URQ","US","UT","UU","UV","UW","UX","UY","UZ","V0","V1","V2","V3","V4","V5","V6","V7","V8","V9","VA","VAO","VB","VC","VD","VE","VF","VG","VGS","VH","VI","VJ","VK","VL","VM","VN","VO","VP","VQ","VR","VS","VT","VU","VV","VW","VX","VY","VZ","W1","W2","W3","W4","W5","W6","W7","W8","W9","WA","WB","WC","WCS","WD","WDR","WE","WF","WG","WH","WI","WJ","WK","WL","WM","WN","WO","WP","WQ","WR","WS","WT","WU","WV","WW","WX","WY","WZ","X0","X1","X2","X3","X4","X5","X6","X7","X8","X9","XA","XB","XC","XD","XE","XF","XG","XH","XI","XJ","XK","XL","XM","XN","XO","XP","XQ","XR","XS","XT","XU","XV","XW","XX","XX1","XX2","XX3","XX4","XX5","XX6","XX7","XX8","XY","XZ","Y0","Y1","Y2","Y3","Y4","Y5","Y6","Y8","Y9","YA","YB","YC","YD","YE","YF","YH","YI","YJ","YK","YL","YM","YN","YO","YP","YQ","YR","YS","YT","YV","YW","YX","YY","YZ","Z1","Z2","Z3","Z4","Z5","Z6","Z7","Z8","Z9","ZA","ZB","ZC","ZD","ZE","ZG","ZH","ZI","ZJ","ZK","ZL","ZM","ZN","ZO","ZP","ZQ","ZR","ZS","ZT","ZTS","ZU","ZV","ZW","ZX","ZY","ZZ"};
    }
    
    public class NM1_ReferringProviderName_4
    {
        
        [D(1, typeof(X12_ID_98_9), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_9
    {
        
        public List<string> Codes = new List<string> {"DN","P3"};
    }
    
    public class X12_ID_1065_3
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_2
    {
        
        public List<string> Codes = new List<string> {"XX"};
    }
    
    public class Loop_2420E_2
    {
        
        [S("NM1", 1)]
        public NM1_OrderingProviderName_2 NM1_OrderingProviderName_2 { get; set; }
        [S("N3", 2)]
        public N3_OrderingProviderAddress_2 N3_OrderingProviderAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_OrderingProviderCity_State_ZIPCode_2 N4_OrderingProviderCity_State_ZIPCode_2 { get; set; }
        [S("REF", 4)]
        public List<REF_OrderingProviderSecondaryIdentification_2> REF_OrderingProviderSecondaryIdentification_2 { get; set; }
        [S("PER", 5)]
        public PER_OrderingProviderContactInformation_2 PER_OrderingProviderContactInformation_2 { get; set; }
    }
    
    public class PER_OrderingProviderContactInformation_2
    {
        
        [D(1, typeof(X12_ID_366), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN), "93")]
        public string OrderingProviderContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_2), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_2), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN), "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN), "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class X12_ID_366
    {
        
        public List<string> Codes = new List<string> {"IC"};
    }
    
    public class X12_ID_365
    {
        
        public List<string> Codes = new List<string> {"EM","FX","TE"};
    }
    
    public class X12_ID_365_2
    {
        
        public List<string> Codes = new List<string> {"EM","EX","FX","TE"};
    }
    
    public class REF_OrderingProviderSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_25), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OrderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_99 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_99
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_OrderingProviderCity_State_ZIPCode_2
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string OrderingProviderCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string OrderingProviderStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string OrderingProviderPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OrderingProviderAddress_2
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string OrderingProviderAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string OrderingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_OrderingProviderName_2
    {
        
        [D(1, typeof(X12_ID_98_16), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string OrderingProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string OrderingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string OrderingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string OrderingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string OrderingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_16
    {
        
        public List<string> Codes = new List<string> {"DK"};
    }
    
    public class Loop_2420D_2
    {
        
        [S("NM1", 1)]
        public NM1_SupervisingProviderName_4 NM1_SupervisingProviderName_4 { get; set; }
        [S("REF", 2)]
        public List<REF_SupervisingProviderSecondaryIdentification_4> REF_SupervisingProviderSecondaryIdentification_4 { get; set; }
    }
    
    public class REF_SupervisingProviderSecondaryIdentification_4
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_98 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_26
    {
        
        public List<string> Codes = new List<string> {"0B","1G","G2","LU"};
    }
    
    public class C040_ReferenceIdentifier_98
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_SupervisingProviderName_4
    {
        
        [D(1, typeof(X12_ID_98_12), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_12
    {
        
        public List<string> Codes = new List<string> {"DQ"};
    }
    
    public class Loop_2420C_2
    {
        
        [S("NM1", 1)]
        public NM1_ServiceFacilityLocation_2 NM1_ServiceFacilityLocation_2 { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress_4 N3_ServiceFacilityLocationAddress_4 { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode_4 N4_ServiceFacilityLocationCity_State_ZIPCode_4 { get; set; }
        [S("REF", 4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_4> REF_ServiceFacilityLocationSecondaryIdentification_4 { get; set; }
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification_4
    {
        
        [D(1, typeof(X12_ID_128_10), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_97 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_10
    {
        
        public List<string> Codes = new List<string> {"G2","LU"};
    }
    
    public class C040_ReferenceIdentifier_97
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_ServiceFacilityLocationCity_State_ZIPCode_4
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress_4
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocation_2
    {
        
        [D(1, typeof(X12_ID_98_11), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string LaboratoryorFacilityName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_11
    {
        
        public List<string> Codes = new List<string> {"77"};
    }
    
    public class Loop_2420B_2
    {
        
        [S("NM1", 1)]
        public NM1_PurchasedServiceProviderName_2 NM1_PurchasedServiceProviderName_2 { get; set; }
        [S("REF", 2)]
        public List<REF_PurchasedServiceProviderSecondaryIdentification_2> REF_PurchasedServiceProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_PurchasedServiceProviderSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_25), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_96 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_96
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_PurchasedServiceProviderName_2
    {
        
        [D(1, typeof(X12_ID_98_15), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_15
    {
        
        public List<string> Codes = new List<string> {"QB"};
    }
    
    public class X12_ID_1065
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class Loop_2420A_2
    {
        
        [S("NM1", 1)]
        public NM1_RenderingProviderName_4 NM1_RenderingProviderName_4 { get; set; }
        [S("PRV", 2)]
        public PRV_RenderingProviderSpecialtyInformation_4 PRV_RenderingProviderSpecialtyInformation_4 { get; set; }
        [S("REF", 3)]
        public List<REF_RenderingProviderSecondaryIdentification_4> REF_RenderingProviderSecondaryIdentification_4 { get; set; }
    }
    
    public class REF_RenderingProviderSecondaryIdentification_4
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_95 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_95
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class PRV_RenderingProviderSpecialtyInformation_4
    {
        
        [D(1, typeof(X12_ID_1221_2), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128), "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, typeof(X12_ID), "156")]
        public string StateorProvinceCode_04 { get; set; }
        [C(5)]
        public C035_ProviderSpecialtyInformation_5 ProviderSpecialtyInformation_05 { get; set; }
        [D(6, typeof(X12_ID_1223), "1223")]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    public class X12_ID_1221_2
    {
        
        public List<string> Codes = new List<string> {"PE"};
    }
    
    public class X12_ID_128
    {
        
        public List<string> Codes = new List<string> {"PXC"};
    }
    
    public class X12_ID_1223
    {
        
        public List<string> Codes = new List<string> {"001","002","003","004","005","006","007","008"};
    }
    
    public class C035_ProviderSpecialtyInformation_5
    {
        
        [D(1, typeof(X12_ID_1222), "1222")]
        public string ProviderSpecialtyCode_01 { get; set; }
        [D(2, typeof(X12_ID_559), "559")]
        public string AgencyQualifierCode_02 { get; set; }
        [D(3, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public class X12_ID_1222
    {
        
        public List<string> Codes = new List<string> {"DEN","DGP","END","IHG","OPY","ORT","OSY","PDT","PED","PHD","PST"};
    }
    
    public class X12_ID_559
    {
        
        public List<string> Codes = new List<string> {"10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","64","65","66","93","94","A1","A2","A3","A4","AA","AB","AC","AD","AE","AF","AG","AH","AJ","AL","AM","AP","AQ","AR","AS","AT","AW","AX","AY","BA","BE","BF","BI","CA","CB","CC","CE","CI","CL","CM","CO","CP","CR","CS","CU","CX","DA","DD","DE","DF","DH","DI","DL","DN","DO","DR","DS","DX","DY","DZ","EI","EP","ES","ET","EU","EX","FA","FC","FD","FG","FH","FI","GC","GI","GS","GU","HC","HF","HI","HS","HU","IA","IB","IC","IM","IN","IS","JA","LA","LB","LI","MA","MB","MC","ME","MI","MP","MS","MV","NA","NB","NC","NE","NF","NG","NI","NP","NR","NS","NT","NU","NW","OI","OP","OS","PA","PC","PI","RN","SA","SE","SL","SP","ST","TA","TB","TC","TD","TI","TM","TP","TR","TX","UA","UC","UI","UL","UN","UT","VI","WH","ZZ"};
    }
    
    public class X12_ID_1073
    {
        
        public List<string> Codes = new List<string> {"N","U","W","Y"};
    }
    
    public class NM1_RenderingProviderName_4
    {
        
        [D(1, typeof(X12_ID_98_10), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string RenderingProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_10
    {
        
        public List<string> Codes = new List<string> {"82"};
    }
    
    public class Loop_2410_2
    {
        
        [S("LIN", 1)]
        public LIN_DrugIdentification_2 LIN_DrugIdentification_2 { get; set; }
        [S("CTP", 2)]
        public CTP_DrugQuantity_2 CTP_DrugQuantity_2 { get; set; }
        [S("REF", 3)]
        public REF_PrescriptionorCompoundDrugAssociationNumber_2 REF_PrescriptionorCompoundDrugAssociationNumber_2 { get; set; }
    }
    
    public class REF_PrescriptionorCompoundDrugAssociationNumber_2
    {
        
        [D(1, typeof(X12_ID_128_35), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PrescriptionNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_94 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_35
    {
        
        public List<string> Codes = new List<string> {"VY","XZ"};
    }
    
    public class C040_ReferenceIdentifier_94
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class CTP_DrugQuantity_2
    {
        
        [D(1, typeof(X12_ID_687), "687")]
        public string ClassofTradeCode_01 { get; set; }
        [D(2, typeof(X12_ID_236), "236")]
        public string PriceIdentifierCode_02 { get; set; }
        [D(3, typeof(X12_R), "212")]
        public string UnitPrice_03 { get; set; }
        [D(4, typeof(X12_R), "380")]
        public string NationalDrugUnitCount_04 { get; set; }
        [C(5)]
        public C001_CompositeUnitofMeasure_12 CompositeUnitofMeasure_05 { get; set; }
        [D(6, typeof(X12_ID_648), "648")]
        public string PriceMultiplierQualifier_06 { get; set; }
        [D(7, typeof(X12_R), "649")]
        public string Multiplier_07 { get; set; }
        [D(8, typeof(X12_R), "782")]
        public string MonetaryAmount_08 { get; set; }
        [D(9, typeof(X12_ID_639), "639")]
        public string BasisofUnitPriceCode_09 { get; set; }
        [D(10, typeof(X12_AN), "499")]
        public string ConditionValue_10 { get; set; }
        [D(11, typeof(X12_N0), "289")]
        public string MultiplePriceQuantity_11 { get; set; }
    }
    
    public class X12_ID_687
    {
        
        public List<string> Codes = new List<string> {"AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AL","AM","AN","AO","AP","AQ","AR","AS","BG","BR","CB","CN","CO","CR","CX","CY","DE","DF","DI","DR","EX","FS","GA","GM","GR","GV","HS","ID","IN","IR","JB","LC","MC","MF","ML","OE","OF","ON","PF","PH","PT","PY","RS","SA","SB","SE","ST","TR","WA","WC","WH","WS"};
    }
    
    public class X12_ID_236
    {
        
        public List<string> Codes = new List<string> {"ACT","AGC","ALT","AWP","BBP","BCH","BID","C01","C02","C03","C04","C05","C06","C07","C08","C09","C10","C11","C12","C13","C14","C15","C16","C17","C18","C19","C20","C21","C22","C23","C24","C25","C26","C27","C28","C29","C30","CAN","CAT","CDF","CDV","CHG","CON","CUP","CUS","D01","D02","D03","DAP","DIS","DPR","DSC","DSD","DSP","EDM","EDP","EDS","EDW","ELC","EST","EUP","FCH","FCP","FDS","FET","FGP","FOR","FSP","FUL","FUP","GAP","GDP","GOV","GSP","GTP","ICL","IND","INS","INV","LAR","LCP","LPP","LPR","MAP","MAS","MAX","MIN","MNC","MNR","MOD","MPR","MSR","MXR","N01","N02","N03","N04","N05","N06","N07","N08","N09","N10","N11","N12","N13","N14","N15","N16","N17","N18","N19","N20","N21","N22","N23","N24","N25","N26","N27","N28","N29","N30","N31","NET","OAP","OPP","PAP","PAQ","PBQ","PBR","PHS","PIE","PLT","PPA","PPD","PRF","PRO","PRP","PUR","QTE","REG","RES","RPA","RPM","RPP","RSH","RTL","SAC","SDP","SFP","SHD","SLP","SPC","SPE","SSP","STA","SUM","SWP","THP","TOT","TRF","UCP","ULC","WAR","WHL","WSP","ZNP"};
    }
    
    public class X12_ID_648
    {
        
        public List<string> Codes = new List<string> {"CSD","CSR","DIS","ILP","PSP","SEL"};
    }
    
    public class X12_ID_639
    {
        
        public List<string> Codes = new List<string> {"AA","AB","AP","AW","BD","BR","BW","CA","CP","CR","CT","DI","DP","DR","DS","EC","EH","ES","FB","FO","FX","HF","HP","HT","KA","KP","KR","LC","LD","LE","LM","LR","ME","ML","NC","NE","NQ","NS","NT","PA","PB","PD","PE","PF","PG","PK","PL","PM","PN","PO","PP","PQ","PR","PS","PT","PU","PV","PY","QE","QH","QR","QS","QT","RC","RD","RE","RM","RS","RT","SA","SC","SM","SR","ST","SW","TB","TC","TD","TE","TF","TM","TP","TT","UM","VQ","WC","WD","WE","WH","WI","WM"};
    }
    
    public class C001_CompositeUnitofMeasure_12
    {
        
        [D(1, typeof(X12_ID_355_8), "355")]
        public string CodeQualifier_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class X12_ID_355_8
    {
        
        public List<string> Codes = new List<string> {"F2","GR","ME","ML","UN"};
    }
    
    public class X12_ID_355_2
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","1A","1B","1C","1D","1E","1F","1G","1H","1I","1J","1K","1L","1M","1N","1O","1P","1Q","1R","1T","1X","20","21","22","23","24","25","26","27","28","29","2A","2B","2C","2D","2F","2G","2H","2I","2J","2K","2L","2M","2N","2P","2Q","2R","2U","2V","2W","2X","2Y","2Z","30","31","32","33","34","35","36","37","38","39","3B","3C","3E","3F","3G","3H","3I","40","41","43","44","45","46","47","48","4A","4B","4C","4D","4E","4F","4G","4I","4J","4K","4L","4M","4N","4O","4P","4Q","4R","4S","4T","4U","4V","4W","4X","50","51","52","53","54","56","57","58","59","5A","5B","5C","5D","5E","5F","5G","5H","5I","5J","5K","5P","5Q","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","76","77","78","79","80","81","82","83","84","85","86","87","89","8C","8D","8P","8R","8S","8U","90","91","92","93","94","95","96","97","98","99","A8","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","B0","B1","B2","B3","B4","B5","B6","B7","B8","B9","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ","C0","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CQ","CR","CS","CT","CU","CV","CW","CX","CY","CZ","D1","D2","D3","D5","D8","D9","DA","DB","DC","DD","DE","DF","DG","DH","DI","DJ","DK","DL","DM","DN","DO","DP","DQ","DR","DS","DT","DU","DW","DX","DY","DZ","E1","E3","E4","E5","E7","E8","E9","EA","EB","EC","ED","EE","EF","EG","EH","EJ","EM","EP","EQ","EV","EX","EY","EZ","F1","F2","F3","F4","F5","F6","F9","FA","FB","FD","FE","FF","FG","FH","FJ","FK","FL","FM","FO","FP","FR","FS","FT","FZ","G2","G3","G4","G5","G6","G7","G8","G9","GA","GB","GC","GD","GE","GF","GG","GH","GI","GJ","GK","GL","GM","GN","GO","GP","GQ","GR","GS","GT","GU","GV","GW","GX","GY","GZ","H1","H2","H3","H4","H5","H6","H7","H8","H9","HA","HB","HC","HD","HE","HF","HG","HH","HI","HJ","HK","HL","HM","HN","HO","HP","HQ","HR","HS","HT","HU","HV","HW","HY","HZ","IA","IB","IC","IE","IF","IG","IH","II","IK","IL","IM","IN","IP","IS","IT","IU","IV","IW","J1","J2","J3","J4","J5","J6","J7","J8","J9","JA","JB","JC","JE","JG","JK","JL","JM","JN","JO","JP","JR","JS","JT","JU","JV","JX","K1","K2","K3","K4","K5","K6","K7","K9","KA","KB","KC","KD","KE","KF","KG","KH","KI","KJ","KK","KL","KM","KO","KP","KQ","KR","KT","KU","KV","KW","KX","L1","L2","LA","LB","LC","LE","LF","LG","LH","LI","LJ","LK","LL","LM","LN","LO","LP","LQ","LR","LS","LT","LX","LY","M0","M1","M2","M3","M4","M5","M6","M7","M8","M9","MA","MB","MC","MD","ME","MF","MG","MH","MI","MJ","MK","ML","MM","MN","MO","MP","MQ","MR","MS","MT","MU","MV","MW","MX","MY","MZ","N1","N2","N3","N4","N6","N7","N9","NA","NB","NC","ND","NE","NF","NG","NH","NI","NJ","NK","NL","NM","NN","NQ","NR","NS","NT","NU","NV","NW","NX","NY","OA","OC","ON","OP","OT","OZ","P0","P1","P2","P3","P4","P5","P6","P7","P8","P9","PA","PB","PC","PD","PE","PF","PG","PH","PI","PJ","PK","PL","PM","PN","PO","PP","PQ","PR","PS","PT","PU","PV","PW","PX","PY","PZ","Q1","Q2","Q3","Q4","Q5","Q6","Q7","QA","QB","QC","QD","QE","QH","QK","QR","QS","QT","QU","R1","R2","R3","R4","R5","R6","R7","R8","R9","RA","RB","RC","RD","RE","RG","RH","RK","RL","RM","RN","RO","RP","RS","RT","RU","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SF","SG","SH","SI","SJ","SK","SL","SM","SN","SO","SP","SQ","SR","SS","ST","SV","SW","SX","SY","SZ","T0","T1","T2","T3","T4","T5","T6","T7","T8","T9","TA","TB","TC","TD","TE","TF","TG","TH","TI","TJ","TK","TL","TM","TN","TO","TP","TQ","TR","TS","TT","TU","TV","TW","TX","TY","TZ","U1","U2","U3","U5","UA","UB","UC","UD","UE","UF","UH","UL","UM","UN","UP","UQ","UR","US","UT","UU","UV","UW","UX","UY","UZ","V1","V2","VA","VC","VI","VP","VR","VS","W2","WA","WB","WD","WE","WG","WH","WI","WK","WM","WP","WR","WW","X1","X2","X3","X4","X5","X6","X7","X8","X9","XP","Y1","Y2","Y3","Y4","YD","YL","YR","YT","Z1","Z2","Z3","Z4","Z5","Z6","Z7","Z8","Z9","ZA","ZB","ZC","ZD","ZE","ZF","ZG","ZH","ZI","ZJ","ZK","ZL","ZM","ZN","ZO","ZP","ZQ","ZR","ZS","ZW","ZX","ZY","ZZ"};
    }
    
    public class LIN_DrugIdentification_2
    {
        
        [D(1, typeof(X12_AN), "350")]
        public string AssignedIdentification_01 { get; set; }
        [D(2, typeof(X12_ID_235_4), "235")]
        public string ProductorServiceIDQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "234")]
        public string NationalDrugCodeorUniversalProductNumber_03 { get; set; }
        [D(4, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_04 { get; set; }
        [D(5, typeof(X12_AN), "234")]
        public string ProductServiceID_05 { get; set; }
        [D(6, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_06 { get; set; }
        [D(7, typeof(X12_AN), "234")]
        public string ProductServiceID_07 { get; set; }
        [D(8, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "234")]
        public string ProductServiceID_09 { get; set; }
        [D(10, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_10 { get; set; }
        [D(11, typeof(X12_AN), "234")]
        public string ProductServiceID_11 { get; set; }
        [D(12, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_12 { get; set; }
        [D(13, typeof(X12_AN), "234")]
        public string ProductServiceID_13 { get; set; }
        [D(14, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_14 { get; set; }
        [D(15, typeof(X12_AN), "234")]
        public string ProductServiceID_15 { get; set; }
        [D(16, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_16 { get; set; }
        [D(17, typeof(X12_AN), "234")]
        public string ProductServiceID_17 { get; set; }
        [D(18, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_18 { get; set; }
        [D(19, typeof(X12_AN), "234")]
        public string ProductServiceID_19 { get; set; }
        [D(20, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_20 { get; set; }
        [D(21, typeof(X12_AN), "234")]
        public string ProductServiceID_21 { get; set; }
        [D(22, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_22 { get; set; }
        [D(23, typeof(X12_AN), "234")]
        public string ProductServiceID_23 { get; set; }
        [D(24, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_24 { get; set; }
        [D(25, typeof(X12_AN), "234")]
        public string ProductServiceID_25 { get; set; }
        [D(26, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_26 { get; set; }
        [D(27, typeof(X12_AN), "234")]
        public string ProductServiceID_27 { get; set; }
        [D(28, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_28 { get; set; }
        [D(29, typeof(X12_AN), "234")]
        public string ProductServiceID_29 { get; set; }
        [D(30, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_30 { get; set; }
        [D(31, typeof(X12_AN), "234")]
        public string ProductServiceID_31 { get; set; }
    }
    
    public class X12_ID_235_4
    {
        
        public List<string> Codes = new List<string> {"EN","EO","HI","N4","ON","UK","UP"};
    }
    
    public class X12_ID_235
    {
        
        public List<string> Codes = new List<string> {"00","A1","A2","A3","A4","A5","A6","A7","A8","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","B1","B2","B3","B4","B5","B6","B7","B8","B9","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CQ","CR","CS","CT","CU","CV","CW","CX","CY","CZ","D1","D2","D3","D4","D5","D6","D7","D8","DA","DD","DE","DF","DG","DH","DI","DL","DM","DN","DO","DP","DQ","DR","DS","DT","DU","DV","DW","DX","DY","DZ","E1","E2","E3","E4","E5","E6","EA","EB","EC","ED","EE","EF","EG","EH","EI","EJ","EK","EL","EM","EN","EO","EP","EQ","ER","ES","EU","EX","EZ","F1","F2","F3","F4","F5","F6","F7","F8","F9","FA","FB","FC","FD","FE","FF","FG","FH","FI","FJ","FK","FL","FM","FN","FP","FQ","FR","FS","FT","FU","FV","FW","FX","GA","GC","GD","GE","GI","GK","GM","GN","GQ","GR","GS","GU","HC","HD","HI","HN","HP","IA","IB","IC","ID","IE","IF","IG","II","IM","IN","IQ","IR","IS","IT","IV","IW","IZ","JA","JB","JC","JD","JN","JP","JS","KA","KB","KD","KE","KF","KG","KI","KJ","KK","KL","KM","KN","KP","L1","L2","L3","L4","L5","L6","LA","LB","LC","LD","LG","LM","LN","LP","LR","LS","LT","LU","MA","MB","MC","MD","ME","MF","MG","MH","MI","MJ","MK","MM","MN","MO","MP","MQ","MR","MS","MT","MU","MV","MW","MX","N1","N2","N3","N4","N5","N6","ND","NE","NG","NH","NM","NR","NU","NW","NZ","O0","O7","O8","O9","OA","OB","OC","OD","OE","OF","OG","OH","OI","OL","ON","OO","OP","OR","OT","OU","P1","P2","P3","P4","P5","P6","P7","P8","P9","PA","PB","PC","PD","PE","PF","PG","PH","PI","PJ","PK","PL","PM","PN","PO","PP","PQ","PR","PS","PT","PU","PV","PW","PX","PY","PZ","R0","R1","R2","R3","R4","R5","R6","R7","R8","R9","RA","RB","RC","RD","RE","RF","RG","RH","RI","RJ","RK","RL","RM","RN","RO","RP","RQ","RR","RS","RT","RU","RV","RW","RY","RZ","S1","S2","S3","S4","S5","S6","S7","S8","SA","SB","SC","SD","SE","SF","SG","SH","SI","SJ","SK","SL","SM","SN","SO","SP","SQ","SR","SS","ST","SU","SV","SW","SX","SY","SZ","T2","T3","TA","TB","TC","TD","TE","TF","TG","TH","TI","TJ","TK","TM","TN","TP","TR","TS","TT","TU","TV","TW","TX","TY","TZ","U2","U3","U5","U6","UA","UB","UC","UD","UE","UF","UG","UH","UI","UJ","UK","UL","UM","UN","UO","UP","UQ","UR","US","UT","UV","UX","VA","VB","VC","VE","VI","VM","VN","VO","VP","VS","VT","VU","VV","VX","W1","W2","W5","W6","W7","WA","WB","WC","WD","WE","WF","WG","WJ","WK","WL","WR","WS","XA","XC","XP","XQ","XZ","YP","ZB","ZR","ZZ"};
    }
    
    public class HCP_LinePricing_RepricingInformation_2
    {
        
        [D(1, typeof(X12_ID_1473_2), "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3, typeof(X12_R), "782")]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5, typeof(X12_R), "118")]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7, typeof(X12_R), "782")]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8, typeof(X12_AN), "234")]
        public string ProductServiceID_08 { get; set; }
        [D(9, typeof(X12_ID_235_2), "235")]
        public string ProductorServiceIDQualifier_09 { get; set; }
        [D(10, typeof(X12_AN), "234")]
        public string RepricedApprovedHCPCSCode_10 { get; set; }
        [D(11, typeof(X12_ID_355_5), "355")]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [D(12, typeof(X12_R), "380")]
        public string RepricedApprovedServiceUnitCount_12 { get; set; }
        [D(13, typeof(X12_ID_901), "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, typeof(X12_ID_1526), "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, typeof(X12_ID_1527), "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class X12_ID_1473_2
    {
        
        public List<string> Codes = new List<string> {"00","01","02","03","04","05","06","07","08","09","10","11","12","13","14"};
    }
    
    public class X12_ID_355_5
    {
        
        public List<string> Codes = new List<string> {"MJ","UN"};
    }
    
    public class X12_ID_901
    {
        
        public List<string> Codes = new List<string> {"T1","T2","T3","T4","T5","T6"};
    }
    
    public class X12_ID_1526
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5"};
    }
    
    public class X12_ID_1527
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6"};
    }
    
    public class PS1_PurchasedServiceInformation_2
    {
        
        [D(1, typeof(X12_AN), "127")]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID), "156")]
        public string StateorProvinceCode_03 { get; set; }
    }
    
    public class All_NTE_2
    {
        
        [S("NTE", 1)]
        public NTE_LineNote_2 NTE_LineNote_2 { get; set; }
        [S("NTE", 2)]
        public NTE_ThirdPartyOrganizationNotes_2 NTE_ThirdPartyOrganizationNotes_2 { get; set; }
    }
    
    public class NTE_ThirdPartyOrganizationNotes_2
    {
        
        [D(1, typeof(X12_ID_363_3), "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, typeof(X12_AN), "352")]
        public string LineNoteText_02 { get; set; }
    }
    
    public class X12_ID_363_3
    {
        
        public List<string> Codes = new List<string> {"TPO"};
    }
    
    public class NTE_LineNote_2
    {
        
        [D(1, typeof(X12_ID_363_2), "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, typeof(X12_AN), "352")]
        public string LineNoteText_02 { get; set; }
    }
    
    public class X12_ID_363_2
    {
        
        public List<string> Codes = new List<string> {"ADD","DCP"};
    }
    
    public class K3_FileInformation_4
    {
        
        [D(1, typeof(X12_AN), "449")]
        public string FixedFormatInformation_01 { get; set; }
        [D(2, typeof(X12_ID_1333), "1333")]
        public string RecordFormatCode_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_11 CompositeUnitofMeasure_03 { get; set; }
    }
    
    public class X12_ID_1333
    {
        
        public List<string> Codes = new List<string> {"C","D","E","F","P","S"};
    }
    
    public class C001_CompositeUnitofMeasure_11
    {
        
        [D(1, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_AMT_4
    {
        
        [S("AMT", 1)]
        public AMT_SalesTaxAmount_2 AMT_SalesTaxAmount_2 { get; set; }
        [S("AMT", 2)]
        public AMT_PostageClaimedAmount_2 AMT_PostageClaimedAmount_2 { get; set; }
    }
    
    public class AMT_PostageClaimedAmount_2
    {
        
        [D(1, typeof(X12_ID_522_6), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string PostageClaimedAmount_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class X12_ID_522_6
    {
        
        public List<string> Codes = new List<string> {"F4"};
    }
    
    public class AMT_SalesTaxAmount_2
    {
        
        [D(1, typeof(X12_ID_522_5), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string SalesTaxAmount_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class X12_ID_522_5
    {
        
        public List<string> Codes = new List<string> {"T"};
    }
    
    public class All_REF_11
    {
        
        [S("REF", 1)]
        public REF_RepricedLineItemReferenceNumber_2 REF_RepricedLineItemReferenceNumber_2 { get; set; }
        [S("REF", 2)]
        public REF_AdjustedRepricedLineItemReferenceNumber_2 REF_AdjustedRepricedLineItemReferenceNumber_2 { get; set; }
        [S("REF", 3)]
        public List<REF_PriorAuthorization_4> REF_PriorAuthorization_4 { get; set; }
        [S("REF", 4)]
        public REF_LineItemControlNumber_2 REF_LineItemControlNumber_2 { get; set; }
        [S("REF", 5)]
        public REF_MammographyCertificationNumber_4 REF_MammographyCertificationNumber_4 { get; set; }
        [S("REF", 6)]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4 REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4 { get; set; }
        [S("REF", 7)]
        public REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2 REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2 { get; set; }
        [S("REF", 8)]
        public REF_ImmunizationBatchNumber_2 REF_ImmunizationBatchNumber_2 { get; set; }
        [S("REF", 9)]
        public List<REF_ReferralNumber_4> REF_ReferralNumber_4 { get; set; }
    }
    
    public class REF_ReferralNumber_4
    {
        
        [D(1, typeof(X12_ID_128_14), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_93 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_14
    {
        
        public List<string> Codes = new List<string> {"9F"};
    }
    
    public class C040_ReferenceIdentifier_93
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ImmunizationBatchNumber_2
    {
        
        [D(1, typeof(X12_ID_128_34), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ImmunizationBatchNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_92 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_34
    {
        
        public List<string> Codes = new List<string> {"BT"};
    }
    
    public class C040_ReferenceIdentifier_92
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_33), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferringCLIANumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_91 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_33
    {
        
        public List<string> Codes = new List<string> {"F4"};
    }
    
    public class C040_ReferenceIdentifier_91
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4
    {
        
        [D(1, typeof(X12_ID_128_17), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_90 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_17
    {
        
        public List<string> Codes = new List<string> {"X4"};
    }
    
    public class C040_ReferenceIdentifier_90
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MammographyCertificationNumber_4
    {
        
        [D(1, typeof(X12_ID_128_13), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_89 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_13
    {
        
        public List<string> Codes = new List<string> {"EW"};
    }
    
    public class C040_ReferenceIdentifier_89
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_LineItemControlNumber_2
    {
        
        [D(1, typeof(X12_ID_128_32), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string LineItemControlNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_88 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_32
    {
        
        public List<string> Codes = new List<string> {"6R"};
    }
    
    public class C040_ReferenceIdentifier_88
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PriorAuthorization_4
    {
        
        [D(1, typeof(X12_ID_128_15), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PriorAuthorizationorReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_87 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_15
    {
        
        public List<string> Codes = new List<string> {"G1"};
    }
    
    public class C040_ReferenceIdentifier_87
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_AdjustedRepricedLineItemReferenceNumber_2
    {
        
        [D(1, typeof(X12_ID_128_30), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string AdjustedRepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_86 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_30
    {
        
        public List<string> Codes = new List<string> {"9D"};
    }
    
    public class C040_ReferenceIdentifier_86
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_RepricedLineItemReferenceNumber_2
    {
        
        [D(1, typeof(X12_ID_128_29), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string RepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_85 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_29
    {
        
        public List<string> Codes = new List<string> {"9B"};
    }
    
    public class C040_ReferenceIdentifier_85
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class CN1_ContractInformation_4
    {
        
        [D(1, typeof(X12_ID_1166), "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string ContractAmount_02 { get; set; }
        [D(3, typeof(X12_R), "332")]
        public string ContractPercentage_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ContractCode_04 { get; set; }
        [D(5, typeof(X12_R), "338")]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6, typeof(X12_AN), "799")]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class X12_ID_1166
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","09"};
    }
    
    public class MEA_TestResult_2
    {
        
        [D(1, typeof(X12_ID_737), "737")]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        [D(2, typeof(X12_ID_738), "738")]
        public string MeasurementQualifier_02 { get; set; }
        [D(3, typeof(X12_R), "739")]
        public string TestResults_03 { get; set; }
        [C(4)]
        public C001_CompositeUnitofMeasure_10 CompositeUnitofMeasure_04 { get; set; }
        [D(5, typeof(X12_R), "740")]
        public string RangeMinimum_05 { get; set; }
        [D(6, typeof(X12_R), "741")]
        public string RangeMaximum_06 { get; set; }
        [D(7, typeof(X12_ID_935), "935")]
        public string MeasurementSignificanceCode_07 { get; set; }
        [D(8, typeof(X12_ID_936), "936")]
        public string MeasurementAttributeCode_08 { get; set; }
        [D(9, typeof(X12_ID_752), "752")]
        public string SurfaceLayerPositionCode_09 { get; set; }
        [D(10, typeof(X12_ID_1373), "1373")]
        public string MeasurementMethodorDevice_10 { get; set; }
        [D(11, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1271")]
        public string IndustryCode_12 { get; set; }
    }
    
    public class X12_ID_737
    {
        
        public List<string> Codes = new List<string> {"OG","TR"};
    }
    
    public class X12_ID_738
    {
        
        public List<string> Codes = new List<string> {"HT","R1","R2","R3","R4"};
    }
    
    public class X12_ID_935
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","34","35","36","37","38","39","40","41","42","43","44","45","46","47","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97","98","99","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","BA","BB","BC","BD","BE","BF","ZZ"};
    }
    
    public class X12_ID_936
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","40","41","42","44","45","46","48","49","50","51","52","53","54","56","BA","FL","NA","ND","NS","PR","Q1","Q2","TA","TB","WS","ZZ"};
    }
    
    public class X12_ID_752
    {
        
        public List<string> Codes = new List<string> {"1S","2S","A1","A2","A3","A4","A5","A6","A7","A8","A9","AL","AO","AS","B1","BC","BI","BK","BL","BR","BS","BT","CH","CT","DO","DT","DU","EX","FR","FS","GF","IN","IT","KB","LC","LO","LT","M1","MC","MD","NS","NT","OA","OS","OT","R0","R1","R2","R3","R4","R5","R6","R7","R8","R9","RA","RB","RC","RD","RE","RF","RG","RH","RI","RJ","RK","RL","RM","RN","RO","RP","RQ","RR","RS","RT","RU","RV","RW","RX","RY","RZ","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SF","SN","SP","SS","ST","SU","TB","TP","TS","UC","UN","UP","UT","WF"};
    }
    
    public class X12_ID_1373
    {
        
        public List<string> Codes = new List<string> {"BM","BO","DM","FT","HN","MA","MM","OM","OU","PT","TM","VA","VB","VC"};
    }
    
    public class X12_ID_1270
    {
        
        public List<string> Codes = new List<string> {"0","1","10","100","101","102","103","104","105","106","107","108","109","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","3","30","31","32","33","34","35","36","37","38","39","4","40","41","42","43","44","45","46","47","48","49","5","50","52","53","54","55","56","57","58","59","60","61","62","63","65","66","67","68","69","7","71","72","73","74","75","78","79","8","80","81","82","83","84","85","87","88","89","90","91","92","93","94","95","96","97","98","99","A","A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","AAA","AAD","AAE","AAF","AAG","AAH","AAI","AAJ","AAK","AAL","AAM","AAN","AAO","AAP","AAQ","AAR","AAS","AAT","AAU","AAV","AAW","AAX","AAY","AB","ABF","ABJ","ABK","ABN","ABR","ABS","ABU","ABV","AC","ACR","AD","ADD","ADJ","AE","AF","AG","AH","AI","AJ","AJT","AK","AL","ALM","ALP","AM","AN","AO","APE","APR","AQ","AR","ARI","AS","ASD","AT","ATD","ATT","AU","AV","AW","AX","AY","AZ","B","BA","BB","BBQ","BBR","BC","BCC","BCR","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BN","BO","BP","BPL","BQ","BR","BRL","BS","BSL","BSP","BT","BTC","BU","BUI","BV","BW","BX","BY","BZ","C","C1","C2","C3","CA","CAH","CB","CC","CD","CE","CF","CFI","CG","CH","CHG","CI","CIE","CJ","CK","CL","CLP","CM","CML","CN","CNC","CO","COG","CP","CPS","CQ","CR","CRC","CS","CSD","CSF","CT","CU","CV","CW","CZ","D","D1","D2","D3","D4","D5","DA","DAC","DB","DBS","DC","DD","DE","DF","DG","DGO","DH","DI","DJ","DK","DL","DLO","DLP","DM","DN","DO","DOF","DP","DPE","DPL","DQ","DR","DRL","DS","DSR","DSS","DT","DU","DW","DX","DY","DZ","E","EA","EAA","EAB","EAC","EAD","EAE","EAF","EAG","EAH","EAI","EAJ","EAK","EAL","EAM","EAN","EAO","EAP","EAQ","EAR","EAS","EAT","EAU","EAV","EAW","EAX","EAY","EAZ","EB","EBA","EBB","EBC","EBD","EBE","EBF","EBG","EBH","EBI","EBJ","EBK","EBL","EBM","EBN","EBO","EBP","EBQ","EBR","EBS","EBT","EBU","EBV","EBW","EBX","EBY","EBZ","EC","ECA","ECB","ECC","ECD","ECE","ECF","ECG","ECH","ECI","ECJ","ECK","ECL","ECM","ECN","ECO","ECP","ECQ","ECR","ECS","ECT","ECU","ECV","ECW","ECX","ECY","ECZ","ED","EDA","EDB","EDC","EDD","EDE","EDF","EDG","EDH","EDI","EDJ","EDK","EDL","EDM","EDN","EDO","EDP","EDQ","EDR","EDS","EDT","EDU","EDV","EDW","EDX","EDY","EDZ","EE","EEA","EEB","EEC","EED","EEE","EEF","EEG","EEH","EEI","EEJ","EEK","EEL","EEM","EEN","EEO","EEP","EEQ","EER","EES","EF","EG","EH","EI","EJ","EK","EL","EM","EMC","EN","EO","EQ","EQR","ER","ES","ESC","ESL","ET","ETL","EU","EV","EW","EWC","EWR","EX","EXD","EY","EZ","F","FA","FAP","FB","FC","FC1","FD","FE","FF","FF1","FG","FH","FH1","FI","FIR","FJ","FK","FL","FL1","FM","FMO","FMS","FN","FO","FP","FP1","FQ","FR","FRP","FS","FT","FT1","FU","FV","FW","FX","FZ","G","G1","GA","GB","GC","GD","GE","GF","GG","GI","GJ","GK","GQ","GR","GS","GT","GU","GV","GW","GX","GY","GZ","H","HA","HB","HC","HD","HE","HF","HG","HI","HJ","HK","HL","HM","HO","HRC","HS","HZR","I","IBP","IC","ID","IF","IMC","IMP","IND","IPA","IQ","IRR","IRT","IT","J","J0","J1","J2","J3","J4","J5","J6","J7","J8","J9","JA","JB","JC","JCL","JD","JE","JF","JG","JH","JI","JK","JL","JM","JN","JO","JOL","JP","K","KA","KB","KC","KD","KE","KF","KG","KH","KI","KJ","KK","KL","KM","KO","KP","KQ","KS","KT","KU","KW","KYL","KZ","L","LA","LB","LC","LD","LE","LF","LG","LH","LIN","LJ","LK","LM","LN","LO","LOC","LOI","LP","LQ","LR","LS","LSC","LT","LZ","M","MA","MAC","MB","MC","MCC","MCD","ME","MEC","MI","MJ","MK","ML","MN","MOC","MOE","MRI","MS","MT","N","NA","NAC","NAF","NAN","NAS","NB","NC","ND","NDC","NE","NF","NH","NI","NIR","NJ","NK","NP","NPC","NR","NS","NT","NUB","O","O1","O2","O3","O4","OC","P","PA","PB","PC","PCR","PD","PDA","PGS","PHC","PI","PIT","PL","PLC","PLS","POB","PPD","PPP","PPS","PPV","PQA","PR","PRA","PRC","PRI","PRR","PRT","PS","PT","PWA","PWI","PWR","PWS","PWT","Q","QA","QB","QC","QDR","QE","QF","QG","QH","QI","QJ","QK","QS","QT","R","R1","R2","R3","R4","RA","RAS","RC","RCA","RD","RE","REC","RED","REN","RET","RFC","RI","RJC","RQ","RSS","RT","RTC","RUM","RVC","RX","S","SA","SAT","SB","SBA","SC","SCI","SD","SE","SEC","SET","SF","SG","SH","SHL","SHM","SHN","SHO","SHP","SHQ","SHR","SHS","SHT","SHU","SHV","SHW","SHX","SHY","SHZ","SI","SIA","SIB","SIC","SID","SIE","SIF","SIG","SIH","SII","SIJ","SIK","SIL","SIM","SIN","SIO","SIP","SIQ","SIR","SIS","SIT","SIU","SIV","SIW","SIX","SIY","SIZ","SJ","SJA","SJB","SJC","SJD","SJE","SJF","SJG","SJH","SJI","SJJ","SJK","SJL","SJM","SJN","SJO","SJP","SJQ","SJR","SJS","SJT","SJU","SJV","SJW","SJX","SJY","SJZ","SKA","SKB","SKC","SKD","SKE","SKF","SKG","SKH","SKI","SKJ","SKK","SKL","SKM","SKN","SKO","SKP","SKQ","SKR","SKS","SKT","SKU","SKV","SKW","SKX","SKY","SKZ","SL","SLA","SLS","SMB","SMC","SMD","SMI","SMT","SO","SP","SPE","SR","SRL","SRR","SRT","SS","SSC","ST","STC","STF","SUI","SVC","SWR","T","T00","T01","T02","T03","T04","T05","T06","T07","T08","T09","T10","T11","T12","T13","T14","T15","T16","T17","T18","T19","T20","T21","T22","T23","T24","T25","T26","T27","T28","T29","T30","T31","T32","T33","T34","T35","TB","TC","TCD","TCL","TD","TE","TF","TFR","TG","TL","TOL","TP","TQ","TR","TT","TTL","TX","TY","U","UER","UJC","UNP","UPC","UPT","UR","US","UT","UTC","UU","V","VAL","VP","W","WDL","WRC","WSD","X","XD","Y","Z","ZZ"};
    }
    
    public class C001_CompositeUnitofMeasure_10
    {
        
        [D(1, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_QTY_2
    {
        
        [S("QTY", 1)]
        public QTY_AmbulancePatientCount_2 QTY_AmbulancePatientCount_2 { get; set; }
        [S("QTY", 2)]
        public QTY_ObstetricAnesthesiaAdditionalUnits_2 QTY_ObstetricAnesthesiaAdditionalUnits_2 { get; set; }
    }
    
    public class QTY_ObstetricAnesthesiaAdditionalUnits_2
    {
        
        [D(1, typeof(X12_ID_673_2), "673")]
        public string QuantityQualifier_01 { get; set; }
        [D(2, typeof(X12_R), "380")]
        public string ObstetricAdditionalUnits_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_9 CompositeUnitofMeasure_03 { get; set; }
        [D(4, typeof(X12_AN), "61")]
        public string FreeformInformation_04 { get; set; }
    }
    
    public class X12_ID_673_2
    {
        
        public List<string> Codes = new List<string> {"FL"};
    }
    
    public class C001_CompositeUnitofMeasure_9
    {
        
        [D(1, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class QTY_AmbulancePatientCount_2
    {
        
        [D(1, typeof(X12_ID_673), "673")]
        public string QuantityQualifier_01 { get; set; }
        [D(2, typeof(X12_R), "380")]
        public string AmbulancePatientCount_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_8 CompositeUnitofMeasure_03 { get; set; }
        [D(4, typeof(X12_AN), "61")]
        public string FreeformInformation_04 { get; set; }
    }
    
    public class X12_ID_673
    {
        
        public List<string> Codes = new List<string> {"PT"};
    }
    
    public class C001_CompositeUnitofMeasure_8
    {
        
        [D(1, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_DTP_4
    {
        
        [S("DTP", 1)]
        public DTP_Date_ServiceDate_2 DTP_Date_ServiceDate_2 { get; set; }
        [S("DTP", 2)]
        public DTP_Date_PrescriptionDate_2 DTP_Date_PrescriptionDate_2 { get; set; }
        [S("DTP", 3)]
        public DTP_DATE_CertificationRevision_RecertificationDate_2 DTP_DATE_CertificationRevision_RecertificationDate_2 { get; set; }
        [S("DTP", 4)]
        public DTP_Date_BeginTherapyDate_2 DTP_Date_BeginTherapyDate_2 { get; set; }
        [S("DTP", 5)]
        public DTP_Date_LastCertificationDate_2 DTP_Date_LastCertificationDate_2 { get; set; }
        [S("DTP", 6)]
        public DTP_Date_LastSeenDate_4 DTP_Date_LastSeenDate_4 { get; set; }
        [S("DTP", 7)]
        public List<DTP_Date_TestDate_2> DTP_Date_TestDate_2 { get; set; }
        [S("DTP", 8)]
        public DTP_Date_ShippedDate_2 DTP_Date_ShippedDate_2 { get; set; }
        [S("DTP", 9)]
        public DTP_Date_LastX_rayDate_4 DTP_Date_LastX_rayDate_4 { get; set; }
        [S("DTP", 10)]
        public DTP_Date_InitialTreatmentDate_4 DTP_Date_InitialTreatmentDate_4 { get; set; }
    }
    
    public class DTP_Date_InitialTreatmentDate_4
    {
        
        [D(1, typeof(X12_ID_374_3), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class X12_ID_374_3
    {
        
        public List<string> Codes = new List<string> {"454"};
    }
    
    public class DTP_Date_LastX_rayDate_4
    {
        
        [D(1, typeof(X12_ID_374_8), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class X12_ID_374_8
    {
        
        public List<string> Codes = new List<string> {"455"};
    }
    
    public class DTP_Date_ShippedDate_2
    {
        
        [D(1, typeof(X12_ID_374_24), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string ShippedDate_03 { get; set; }
    }
    
    public class X12_ID_374_24
    {
        
        public List<string> Codes = new List<string> {"011"};
    }
    
    public class DTP_Date_TestDate_2
    {
        
        [D(1, typeof(X12_ID_374_23), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string TestPerformedDate_03 { get; set; }
    }
    
    public class X12_ID_374_23
    {
        
        public List<string> Codes = new List<string> {"738","739"};
    }
    
    public class DTP_Date_LastSeenDate_4
    {
        
        [D(1, typeof(X12_ID_374_4), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string TreatmentorTherapyDate_03 { get; set; }
    }
    
    public class X12_ID_374_4
    {
        
        public List<string> Codes = new List<string> {"304"};
    }
    
    public class DTP_Date_LastCertificationDate_2
    {
        
        [D(1, typeof(X12_ID_374_22), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastCertificationDate_03 { get; set; }
    }
    
    public class X12_ID_374_22
    {
        
        public List<string> Codes = new List<string> {"461"};
    }
    
    public class DTP_Date_BeginTherapyDate_2
    {
        
        [D(1, typeof(X12_ID_374_21), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string BeginTherapyDate_03 { get; set; }
    }
    
    public class X12_ID_374_21
    {
        
        public List<string> Codes = new List<string> {"463"};
    }
    
    public class DTP_DATE_CertificationRevision_RecertificationDate_2
    {
        
        [D(1, typeof(X12_ID_374_20), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string CertificationRevisionorRecertificationDate_03 { get; set; }
    }
    
    public class X12_ID_374_20
    {
        
        public List<string> Codes = new List<string> {"607"};
    }
    
    public class DTP_Date_PrescriptionDate_2
    {
        
        [D(1, typeof(X12_ID_374_9), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string PrescriptionDate_03 { get; set; }
    }
    
    public class X12_ID_374_9
    {
        
        public List<string> Codes = new List<string> {"471"};
    }
    
    public class DTP_Date_ServiceDate_2
    {
        
        [D(1, typeof(X12_ID_374_19), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_2), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string ServiceDate_03 { get; set; }
    }
    
    public class X12_ID_374_19
    {
        
        public List<string> Codes = new List<string> {"472"};
    }
    
    public class X12_ID_1250_2
    {
        
        public List<string> Codes = new List<string> {"D8","RD8"};
    }
    
    public class All_CRC_4
    {
        
        [S("CRC", 1)]
        public List<CRC_AmbulanceCertification_4> CRC_AmbulanceCertification_4 { get; set; }
        [S("CRC", 2)]
        public CRC_HospiceEmployeeIndicator_2 CRC_HospiceEmployeeIndicator_2 { get; set; }
        [S("CRC", 3)]
        public CRC_ConditionIndicator_DurableMedicalEquipment_2 CRC_ConditionIndicator_DurableMedicalEquipment_2 { get; set; }
    }
    
    public class CRC_ConditionIndicator_DurableMedicalEquipment_2
    {
        
        [D(1, typeof(X12_ID_1136_6), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_7), "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1321_7), "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class X12_ID_1136_6
    {
        
        public List<string> Codes = new List<string> {"09"};
    }
    
    public class X12_ID_1073_3
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1321_7
    {
        
        public List<string> Codes = new List<string> {"38","ZV"};
    }
    
    public class X12_ID_1321_4
    {
        
        public List<string> Codes = new List<string> {"00","000","01","02","03","04","05","06","07","08","09","0A","0B","0C","0D","0E","0F","0G","0H","0I","0J","0K","0L","0M","0N","0O","0P","0Q","0R","0S","0T","0U","0V","0W","0X","0Y","0Z","10","11","12","13","14","15","16","17","18","19","1A","1B","1C","1D","1E","1F","1G","1H","1I","1J","1K","1L","1M","1N","1O","1P","1Q","1R","1S","1T","1U","1V","1W","1X","1Y","1Z","20","21","22","23","24","25","26","27","28","29","2A","2B","2C","2D","2E","2F","2G","2H","2I","2J","2K","2L","2M","2N","2O","2P","2Q","2R","2S","2T","2U","2V","2W","2X","2Y","2Z","30","31","32","33","34","35","36","37","38","39","3A","3B","3C","3D","3E","3F","3G","3H","3I","3J","3K","3L","3M","3N","3O","3P","3Q","3R","3S","3T","3U","3V","3W","3X","3Y","3Z","40","41","42","43","44","45","46","47","48","49","4A","4B","4C","4D","4E","4F","4G","4H","4I","4J","4K","4L","4M","4N","4O","4P","4Q","4R","4S","4T","4U","4V","4W","4X","4Y","4Z","50","51","52","53","54","55","56","57","58","59","5A","5B","5C","5D","5E","5F","5G","5H","5I","5J","5K","5L","5M","5N","5O","5P","5Q","5R","5S","5T","5U","5V","5W","5X","5Y","5Z","60","61","62","63","64","65","66","67","68","69","6A","6B","6C","6D","6E","6F","6G","6H","6I","6J","6K","6L","6M","6N","6O","6P","6Q","6R","6S","6T","6U","6V","6W","6X","6Y","6Z","70","71","72","73","74","75","76","77","78","79","7A","7B","7C","7D","7E","7F","7G","7H","7I","7J","7K","7L","7M","7N","7O","7P","7Q","7R","7S","7T","7U","7V","7W","7X","7Y","7Z","80","81","82","83","84","85","86","87","88","89","8A","8B","8C","8D","8E","8F","8G","8H","8I","8J","8K","8L","8M","8N","8O","8P","8Q","8R","8S","8T","8U","8V","8W","8X","8Y","8Z","90","91","92","93","94","95","96","97","98","99","9A","9B","9C","9D","9E","9F","9G","9H","9I","9J","9K","9L","9M","9N","9O","9P","9Q","9R","9S","9T","9U","9V","9W","9X","9Y","9Z","A0","A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","AB","AC","AD","AE","AF","AFM","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","B0","B1","B2","B3","B4","B5","B6","B7","B8","B9","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BPD","BQ","BR","BS","BT","BTD","BU","BV","BW","BX","BY","BZ","C0","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CB","CC","CD","CE","CF","CFD","CG","CH","CI","CJ","CK","CL","CM","CN","CNJ","CO","CP","CQ","CR","CS","CT","CU","CV","CW","CX","CY","CZ","D0","D1","D2","D3","D4","D5","D6","D7","D8","D9","DA","DB","DC","DD","DE","DF","DFR","DG","DH","DI","DJ","DK","DL","DM","DN","DNR","DO","DP","DQ","DR","DS","DT","DU","DV","DW","DX","DY","DZ","E0","E1","E2","E3","E4","E5","E6","E7","E8","E9","EA","EB","EC","ED","EE","EF","EG","EH","EI","EJ","EK","EL","EM","EN","EO","EP","EQ","ER","ES","ET","EU","EV","EW","EX","EY","EZ","F0","F1","F2","F3","F4","F5","F6","F7","F8","F9","FA","FB","FC","FD","FE","FF","FG","FH","FI","FJ","FK","FL","FM","FN","FO","FP","FQ","FR","FS","FT","FU","FV","FW","FX","FY","FZ","G0","G1","G2","G3","G4","G5","G6","G7","G8","G9","GA","GB","GC","GD","GE","GF","GG","GH","GI","GJ","GK","GL","GM","GN","GO","GP","GQ","GR","GS","GT","GU","GV","GW","GX","GY","GZ","H0","H1","H2","H3","H4","H5","H6","H7","H8","H9","HA","HB","HC","HD","HE","HF","HG","HH","HI","HJ","HK","HL","HM","HN","HO","HP","HQ","HR","HS","HT","HU","HV","HW","HX","HY","HZ","I0","I1","I2","I3","I4","I5","I6","I7","I8","I9","IA","IB","IC","ID","IE","IF","IG","IH","II","IJ","IK","IL","IM","IN","IO","IP","IQ","IR","IS","IT","IU","IV","IW","IX","IY","IZ","J0","J1","J2","J3","J4","J5","J6","J7","J8","J9","JA","JB","JC","JCA","JD","JE","JF","JG","JH","JI","JJ","JK","JL","JM","JN","JO","JP","JQ","JR","JS","JT","JU","JV","JW","JX","JY","JZ","K0","K1","K2","K3","K4","K5","K6","K7","K8","K9","KA","KB","KC","KD","KE","KF","KG","KH","KI","KJ","KK","KL","KM","KN","KO","KP","KQ","KR","KS","KT","KU","KV","KW","KX","KY","KZ","L0","L1","L2","L3","L4","L5","L6","L7","L8","L9","LA","LB","LC","LD","LE","LF","LG","LH","LI","LJ","LK","LL","LM","LN","LO","LP","LQ","LR","LS","LSD","LT","LU","LV","LW","LX","LY","LZ","M0","M1","M2","M3","M4","M5","M6","M7","M8","M9","MA","MB","MC","MD","ME","MF","MG","MH","MI","MJ","MK","ML","MM","MN","MO","MP","MQ","MR","MS","MT","MU","MV","MW","MX","MY","MZ","N0","N1","N2","N3","N4","N5","N6","N7","N8","N9","NA","NB","NC","ND","NDP","NE","NF","NG","NH","NI","NJ","NK","NL","NM","NN","NO","NP","NQ","NR","NS","NT","NU","NV","NW","NX","NY","NZ","O0","O1","O2","O3","O4","O5","O6","O7","O8","O9","OA","OB","OC","OD","ODZ","OE","OF","OG","OH","OI","OJ","OK","OL","OM","ON","OO","OP","OQ","OR","OS","OT","OU","OV","OW","OX","OY","OZ","P0","P1","P2","P3","P4","P5","P6","P7","P8","P9","PA","PB","PC","PD","PE","PF","PFB","PG","PH","PI","PJ","PK","PL","PM","PN","PO","PP","PQ","PR","PRD","PS","PT","PU","PV","PW","PX","PY","PZ","Q0","Q1","Q2","Q3","Q4","Q5","Q6","Q7","Q8","Q9","QA","QB","QC","QD","QE","QF","QG","QH","QI","QJ","QK","QL","QM","QN","QO","QP","QQ","QR","QS","QT","QU","QV","QW","QX","QY","QZ","R0","R1","R2","R3","R4","R5","R6","R7","R8","R9","RA","RB","RC","RCA","RD","RE","RF","RG","RH","RI","RJ","RK","RL","RM","RN","RO","RP","RQ","RR","RS","RT","RU","RV","RW","RX","RY","RZ","S0","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SF","SG","SH","SI","SJ","SK","SL","SM","SN","SO","SP","SPP","SPS","SQ","SR","SS","ST","SU","SUB","SV","SW","SX","SY","SZ","T0","T1","T2","T3","T4","T5","T6","T7","T8","T9","TA","TB","TC","TD","TE","TF","TG","TH","TI","TJ","TK","TL","TM","TN","TNJ","TO","TP","TQ","TR","TS","TT","TU","TV","TW","TX","TY","TZ","U0","U1","U2","U3","U4","U5","U6","U7","U8","U9","UA","UB","UC","UD","UE","UF","UG","UH","UI","UJ","UK","UL","UM","UN","UO","UP","UQ","UR","US","UT","UU","UV","UW","UX","UY","UZ","V0","V1","V2","V3","V4","V5","V6","V7","V8","V9","VA","VB","VC","VD","VE","VF","VG","VH","VI","VJ","VK","VL","VM","VN","VO","VP","VQ","VR","VS","VT","VTL","VU","VV","VW","VX","VY","VZ","W0","W1","W2","W3","W4","W5","W6","W7","W8","W9","WA","WB","WC","WD","WE","WF","WG","WH","WI","WJ","WK","WL","WM","WN","WO","WP","WQ","WR","WS","WT","WU","WV","WW","WX","WY","WZ","X0","X1","X2","X3","X4","X5","X6","X7","X8","X9","XA","XB","XC","XD","XE","XF","XG","XH","XI","XJ","XK","XL","XM","XN","XO","XP","XQ","XR","XS","XT","XU","XV","XW","XX","XY","XZ","Y0","Y1","Y2","Y3","Y4","Y5","Y6","Y7","Y8","Y9","YA","YB","YC","YD","YE","YF","YG","YH","YI","YJ","YK","YL","YM","YN","YO","YP","YQ","YR","YS","YT","YU","YV","YW","YX","YY","YZ","Z0","Z1","Z2","Z3","Z4","Z5","Z6","Z7","Z8","Z9","ZA","ZB","ZC","ZD","ZE","ZF","ZG","ZH","ZI","ZJ","ZK","ZL","ZM","ZN","ZO","ZP","ZQ","ZR","ZS","ZT","ZU","ZV","ZW","ZX","ZY","ZZ"};
    }
    
    public class CRC_HospiceEmployeeIndicator_2
    {
        
        [D(1, typeof(X12_ID_1136_5), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string HospiceEmployedProviderIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_6), "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class X12_ID_1136_5
    {
        
        public List<string> Codes = new List<string> {"70"};
    }
    
    public class X12_ID_1321_6
    {
        
        public List<string> Codes = new List<string> {"65"};
    }
    
    public class CRC_AmbulanceCertification_4
    {
        
        [D(1, typeof(X12_ID_1136), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class X12_ID_1136
    {
        
        public List<string> Codes = new List<string> {"07"};
    }
    
    public class X12_ID_1321
    {
        
        public List<string> Codes = new List<string> {"01","04","05","06","07","08","09","12"};
    }
    
    public class CR3_DurableMedicalEquipmentCertification_2
    {
        
        [D(1, typeof(X12_ID_1322), "1322")]
        public string CertificationTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_355_7), "355")]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [D(3, typeof(X12_R), "380")]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        [D(4, typeof(X12_ID_1335), "1335")]
        public string InsulinDependentCode_04 { get; set; }
        [D(5, typeof(X12_AN), "352")]
        public string Description_05 { get; set; }
    }
    
    public class X12_ID_1322
    {
        
        public List<string> Codes = new List<string> {"I","R","S"};
    }
    
    public class X12_ID_355_7
    {
        
        public List<string> Codes = new List<string> {"MO"};
    }
    
    public class X12_ID_1335
    {
        
        public List<string> Codes = new List<string> {"1","2","3","N"};
    }
    
    public class CR1_AmbulanceTransportInformation_4
    {
        
        [D(1, typeof(X12_ID_355_3), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "81")]
        public string PatientWeight_02 { get; set; }
        [D(3, typeof(X12_ID_1316), "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, typeof(X12_ID_1317), "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, typeof(X12_ID_355_4), "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string TransportDistance_06 { get; set; }
        [D(7, typeof(X12_AN), "166")]
        public string AddressInformation_07 { get; set; }
        [D(8, typeof(X12_AN), "166")]
        public string AddressInformation_08 { get; set; }
        [D(9, typeof(X12_AN), "352")]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10, typeof(X12_AN), "352")]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class X12_ID_355_3
    {
        
        public List<string> Codes = new List<string> {"LB"};
    }
    
    public class X12_ID_1316
    {
        
        public List<string> Codes = new List<string> {"I","R","T","X"};
    }
    
    public class X12_ID_1317
    {
        
        public List<string> Codes = new List<string> {"A","B","C","D","E"};
    }
    
    public class X12_ID_355_4
    {
        
        public List<string> Codes = new List<string> {"DH"};
    }
    
    public class All_PWK_2
    {
        
        [S("PWK", 1)]
        public List<PWK_LineSupplementalInformation_2> PWK_LineSupplementalInformation_2 { get; set; }
        [S("PWK", 2)]
        public PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2 PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2 { get; set; }
    }
    
    public class PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2
    {
        
        [D(1, typeof(X12_ID_755_3), "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_756_2), "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, typeof(X12_N0), "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "67")]
        public string IdentificationCode_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated_6 ActionsIndicated_08 { get; set; }
        [D(9, typeof(X12_ID_1525), "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class X12_ID_755_3
    {
        
        public List<string> Codes = new List<string> {"CT"};
    }
    
    public class X12_ID_756_2
    {
        
        public List<string> Codes = new List<string> {"AB","AD","AF","AG","NS"};
    }
    
    public class X12_ID_1525
    {
        
        public List<string> Codes = new List<string> {"AR","BA","HS","IN","PR","RE","SC"};
    }
    
    public class C002_ActionsIndicated_6
    {
        
        [D(1, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class X12_ID_704
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6","CH","CO","DM","NT","ON","OR","PV","SG"};
    }
    
    public class PWK_LineSupplementalInformation_2
    {
        
        [D(1, typeof(X12_ID_755_2), "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_756), "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, typeof(X12_N0), "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, typeof(X12_ID_66_6), "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "67")]
        public string AttachmentControlNumber_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated_5 ActionsIndicated_08 { get; set; }
        [D(9, typeof(X12_ID_1525), "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class X12_ID_755_2
    {
        
        public List<string> Codes = new List<string> {"03","04","05","06","07","08","09","10","11","13","15","21","A3","A4","AM","AS","B2","B3","B4","BR","BS","BT","CB","CK","CT","D2","DA","DB","DG","DJ","DS","EB","HC","HR","I5","IR","LA","M1","MT","NN","OB","OC","OD","OE","OX","OZ","P4","P5","PE","PN","PO","PQ","PY","PZ","RB","RR","RT","RX","SG","V5","XP"};
    }
    
    public class X12_ID_756
    {
        
        public List<string> Codes = new List<string> {"AA","BM","EL","EM","FT","FX"};
    }
    
    public class X12_ID_66_6
    {
        
        public List<string> Codes = new List<string> {"AC"};
    }
    
    public class C002_ActionsIndicated_5
    {
        
        [D(1, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class SV5_DurableMedicalEquipmentService_2
    {
        
        [C(1)]
        public C003_CompositeMedicalProcedureIdentifier_5 CompositeMedicalProcedureIdentifier_01 { get; set; }
        [D(2, typeof(X12_ID_355_6), "355")]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [D(3, typeof(X12_R), "380")]
        public string LengthofMedicalNecessity_03 { get; set; }
        [D(4, typeof(X12_R), "782")]
        public string DMERentalPrice_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string DMEPurchasePrice_05 { get; set; }
        [D(6, typeof(X12_ID_594), "594")]
        public string RentalUnitPriceIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_923), "923")]
        public string PrognosisCode_07 { get; set; }
    }
    
    public class X12_ID_355_6
    {
        
        public List<string> Codes = new List<string> {"DA"};
    }
    
    public class X12_ID_594
    {
        
        public List<string> Codes = new List<string> {"1","4","6"};
    }
    
    public class X12_ID_923
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6","7","8"};
    }
    
    public class C003_CompositeMedicalProcedureIdentifier_5
    {
        
        [D(1, typeof(X12_ID_235_3), "235")]
        public string ProcedureIdentifier_01 { get; set; }
        [D(2, typeof(X12_AN), "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, typeof(X12_AN), "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, typeof(X12_AN), "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, typeof(X12_AN), "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string Description_07 { get; set; }
        [D(8, typeof(X12_AN), "234")]
        public string ProductServiceID_08 { get; set; }
    }
    
    public class X12_ID_235_3
    {
        
        public List<string> Codes = new List<string> {"HC"};
    }
    
    public class SV1_ProfessionalService_2
    {
        
        [C(1)]
        public C003_CompositeMedicalProcedureIdentifier_4 CompositeMedicalProcedureIdentifier_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string LineItemChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID_355_5), "355")]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        [D(4, typeof(X12_R), "380")]
        public string ServiceUnitCount_04 { get; set; }
        [D(5, typeof(X12_AN), "1331")]
        public string PlaceofServiceCode_05 { get; set; }
        [D(6, typeof(X12_ID_1365), "1365")]
        public string ServiceTypeCode_06 { get; set; }
        [C(7)]
        public C004_CompositeDiagnosisCodePointer_2 CompositeDiagnosisCodePointer_07 { get; set; }
        [D(8, typeof(X12_R), "782")]
        public string MonetaryAmount_08 { get; set; }
        [D(9, typeof(X12_ID_1073_2), "1073")]
        public string EmergencyIndicator_09 { get; set; }
        [D(10, typeof(X12_ID_1340), "1340")]
        public string MultipleProcedureCode_10 { get; set; }
        [D(11, typeof(X12_ID_1073_2), "1073")]
        public string EPSDTIndicator_11 { get; set; }
        [D(12, typeof(X12_ID_1073_2), "1073")]
        public string FamilyPlanningIndicator_12 { get; set; }
        [D(13, typeof(X12_ID_1364), "1364")]
        public string ReviewCode_13 { get; set; }
        [D(14, typeof(X12_AN), "1341")]
        public string NationalorLocalAssignedReviewValue_14 { get; set; }
        [D(15, typeof(X12_ID_1327), "1327")]
        public string CoPayStatusCode_15 { get; set; }
        [D(16, typeof(X12_ID), "1334")]
        public string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        [D(17, typeof(X12_AN), "127")]
        public string ReferenceIdentification_17 { get; set; }
        [D(18, typeof(X12_ID), "116")]
        public string PostalCode_18 { get; set; }
        [D(19, typeof(X12_R), "782")]
        public string MonetaryAmount_19 { get; set; }
        [D(20, typeof(X12_ID_1337), "1337")]
        public string LevelofCareCode_20 { get; set; }
        [D(21, typeof(X12_ID_1360), "1360")]
        public string ProviderAgreementCode_21 { get; set; }
    }
    
    public class X12_ID_1365
    {
        
        public List<string> Codes = new List<string> {"1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","3","30","31","32","33","34","35","36","37","38","39","4","40","41","42","43","44","45","46","47","48","49","5","50","51","52","53","54","55","56","57","58","59","6","60","61","62","63","64","65","66","67","68","69","7","70","71","72","73","74","75","76","77","78","79","8","80","81","82","83","84","85","86","87","88","89","9","90","91","92","93","94","95","96","97","98","99","A0","A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AQ","AR","B","B1","B2","B3","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ","C","C1","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CQ","DG","DM","DS","GF","GN","GY","IC","MH","NI","ON","PT","PU","RN","RT","TC","TN","UC"};
    }
    
    public class X12_ID_1073_2
    {
        
        public List<string> Codes = new List<string> {"Y"};
    }
    
    public class X12_ID_1340
    {
        
        public List<string> Codes = new List<string> {"N","P","S"};
    }
    
    public class X12_ID_1364
    {
        
        public List<string> Codes = new List<string> {"A","B","C","D","E","F","L","N"};
    }
    
    public class X12_ID_1327
    {
        
        public List<string> Codes = new List<string> {"0"};
    }
    
    public class X12_ID_1337
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6","7","8"};
    }
    
    public class X12_ID_1360
    {
        
        public List<string> Codes = new List<string> {"D","E","H","I","N","P","Y"};
    }
    
    public class C004_CompositeDiagnosisCodePointer_2
    {
        
        [D(1, typeof(X12_N0), "1328")]
        public string DiagnosisCodePointer_01 { get; set; }
        [D(2, typeof(X12_N0), "1328")]
        public string DiagnosisCodePointer_02 { get; set; }
        [D(3, typeof(X12_N0), "1328")]
        public string DiagnosisCodePointer_03 { get; set; }
        [D(4, typeof(X12_N0), "1328")]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    public class C003_CompositeMedicalProcedureIdentifier_4
    {
        
        [D(1, typeof(X12_ID_235_2), "235")]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, typeof(X12_AN), "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, typeof(X12_AN), "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, typeof(X12_AN), "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string Description_07 { get; set; }
        [D(8, typeof(X12_AN), "234")]
        public string ProductServiceID_08 { get; set; }
    }
    
    public class LX_ServiceLineNumber_2
    {
        
        [D(1, typeof(X12_N0), "554")]
        public string AssignedNumber_01 { get; set; }
    }
    
    public class Loop_2320_2
    {
        
        [S("SBR", 1)]
        public SBR_OtherSubscriberInformation_2 SBR_OtherSubscriberInformation_2 { get; set; }
        [S("CAS", 2)]
        public List<CAS_ClaimLevelAdjustments_2> CAS_ClaimLevelAdjustments_2 { get; set; }
        [A(3)]
        public All_AMT_3 All_AMT_3 { get; set; }
        [S("OI", 4)]
        public OI_OtherInsuranceCoverageInformation_2 OI_OtherInsuranceCoverageInformation_2 { get; set; }
        [S("MOA", 5)]
        public MOA_OutpatientAdjudicationInformation_2 MOA_OutpatientAdjudicationInformation_2 { get; set; }
        [A(6)]
        public All_NM1_8 All_NM1_8 { get; set; }
    }
    
    public class All_NM1_8
    {
        
        [G(1)]
        public Loop_2330A_2 Loop_2330A_2 { get; set; }
        [G(2)]
        public Loop_2330B_2 Loop_2330B_2 { get; set; }
        [G(3)]
        public List<Loop_2330C_2> Loop_2330C_2 { get; set; }
        [G(4)]
        public Loop_2330D_2 Loop_2330D_2 { get; set; }
        [G(5)]
        public Loop_2330E_2 Loop_2330E_2 { get; set; }
        [G(6)]
        public Loop_2330F_2 Loop_2330F_2 { get; set; }
        [G(7)]
        public Loop_2330G_2 Loop_2330G_2 { get; set; }
    }
    
    public class Loop_2330G_2
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerBillingProvider_2 NM1_OtherPayerBillingProvider_2 { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerBillingProviderSecondaryIdentification_2> REF_OtherPayerBillingProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_OtherPayerBillingProviderSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_10), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerBillingProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_84 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_84
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerBillingProvider_2
    {
        
        [D(1, typeof(X12_ID_98_4), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_4
    {
        
        public List<string> Codes = new List<string> {"85"};
    }
    
    public class Loop_2330F_2
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerSupervisingProvider_2 NM1_OtherPayerSupervisingProvider_2 { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerSupervisingProviderSecondaryIdentification_2> REF_OtherPayerSupervisingProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_OtherPayerSupervisingProviderSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerSupervisingProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_83 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_83
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerSupervisingProvider_2
    {
        
        [D(1, typeof(X12_ID_98_12), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330E_2
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerServiceFacilityLocation_2 NM1_OtherPayerServiceFacilityLocation_2 { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2> REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_27), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_82 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_27
    {
        
        public List<string> Codes = new List<string> {"0B","G2","LU"};
    }
    
    public class C040_ReferenceIdentifier_82
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerServiceFacilityLocation_2
    {
        
        [D(1, typeof(X12_ID_98_11), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330D_2
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerRenderingProvider_2 NM1_OtherPayerRenderingProvider_2 { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerRenderingProviderSecondaryIdentification_2> REF_OtherPayerRenderingProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_OtherPayerRenderingProviderSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerRenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_81 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_81
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerRenderingProvider_2
    {
        
        [D(1, typeof(X12_ID_98_10), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330C_2
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerReferringProvider_2 NM1_OtherPayerReferringProvider_2 { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerReferringProviderSecondaryIdentification_2> REF_OtherPayerReferringProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_OtherPayerReferringProviderSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_25), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerReferringProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_80 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_80
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerReferringProvider_2
    {
        
        [D(1, typeof(X12_ID_98_9), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330B_2
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerName_2 NM1_OtherPayerName_2 { get; set; }
        [S("N3", 2)]
        public N3_OtherPayerAddress_2 N3_OtherPayerAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_OtherPayerCity_State_ZIPCode_2 N4_OtherPayerCity_State_ZIPCode_2 { get; set; }
        [S("DTP", 4)]
        public DTP_ClaimCheckorRemittanceDate_2 DTP_ClaimCheckorRemittanceDate_2 { get; set; }
        [A(5)]
        public All_REF_10 All_REF_10 { get; set; }
    }
    
    public class All_REF_10
    {
        
        [S("REF", 1)]
        public List<REF_OtherPayerSecondaryIdentifier_2> REF_OtherPayerSecondaryIdentifier_2 { get; set; }
        [S("REF", 2)]
        public REF_OtherPayerPriorAuthorizationNumber_2 REF_OtherPayerPriorAuthorizationNumber_2 { get; set; }
        [S("REF", 3)]
        public REF_OtherPayerReferralNumber_2 REF_OtherPayerReferralNumber_2 { get; set; }
        [S("REF", 4)]
        public REF_OtherPayerClaimAdjustmentIndicator_2 REF_OtherPayerClaimAdjustmentIndicator_2 { get; set; }
        [S("REF", 5)]
        public REF_OtherPayerClaimControlNumber_2 REF_OtherPayerClaimControlNumber_2 { get; set; }
    }
    
    public class REF_OtherPayerClaimControlNumber_2
    {
        
        [D(1, typeof(X12_ID_128_16), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayersClaimControlNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_79 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_16
    {
        
        public List<string> Codes = new List<string> {"F8"};
    }
    
    public class C040_ReferenceIdentifier_79
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerClaimAdjustmentIndicator_2
    {
        
        [D(1, typeof(X12_ID_128_28), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerClaimAdjustmentIndicator_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_78 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_28
    {
        
        public List<string> Codes = new List<string> {"T4"};
    }
    
    public class C040_ReferenceIdentifier_78
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerReferralNumber_2
    {
        
        [D(1, typeof(X12_ID_128_14), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPriorAuthorizationorReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_77 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_77
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerPriorAuthorizationNumber_2
    {
        
        [D(1, typeof(X12_ID_128_15), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPriorAuthorizationNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_76 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_76
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerSecondaryIdentifier_2
    {
        
        [D(1, typeof(X12_ID_128_9), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_75 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_9
    {
        
        public List<string> Codes = new List<string> {"2U","EI","FY","NF"};
    }
    
    public class C040_ReferenceIdentifier_75
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class DTP_ClaimCheckorRemittanceDate_2
    {
        
        [D(1, typeof(X12_ID_374_18), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    public class N4_OtherPayerCity_State_ZIPCode_2
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string OtherPayerCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string OtherPayerStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string OtherPayerPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OtherPayerAddress_2
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string OtherPayerAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string OtherPayerAddressLine_02 { get; set; }
    }
    
    public class NM1_OtherPayerName_2
    {
        
        [D(1, typeof(X12_ID_98_8), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string OtherPayerOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_4), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string OtherPayerPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_8
    {
        
        public List<string> Codes = new List<string> {"PR"};
    }
    
    public class X12_ID_66_4
    {
        
        public List<string> Codes = new List<string> {"PI","XV"};
    }
    
    public class Loop_2330A_2
    {
        
        [S("NM1", 1)]
        public NM1_OtherSubscriberName_2 NM1_OtherSubscriberName_2 { get; set; }
        [S("N3", 2)]
        public N3_OtherSubscriberAddress_2 N3_OtherSubscriberAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_OtherSubscriberCity_State_ZIPCode_2 N4_OtherSubscriberCity_State_ZIPCode_2 { get; set; }
        [S("REF", 4)]
        public REF_OtherSubscriberSecondaryIdentification_2 REF_OtherSubscriberSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_OtherSubscriberSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_7), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherInsuredAdditionalIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_74 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_7
    {
        
        public List<string> Codes = new List<string> {"SY"};
    }
    
    public class C040_ReferenceIdentifier_74
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_OtherSubscriberCity_State_ZIPCode_2
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string OtherSubscriberCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string OtherSubscriberStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string OtherSubscriberPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OtherSubscriberAddress_2
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string OtherInsuredAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string OtherInsuredAddressLine_02 { get; set; }
    }
    
    public class NM1_OtherSubscriberName_2
    {
        
        [D(1, typeof(X12_ID_98_7), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string OtherInsuredLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string OtherInsuredFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string OtherInsuredMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string OtherInsuredNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_5), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string OtherInsuredIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_7
    {
        
        public List<string> Codes = new List<string> {"IL"};
    }
    
    public class X12_ID_66_5
    {
        
        public List<string> Codes = new List<string> {"II","MI"};
    }
    
    public class MOA_OutpatientAdjudicationInformation_2
    {
        
        [D(1, typeof(X12_R), "954")]
        public string ReimbursementRate_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string HCPCSPayableAmount_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string ClaimPaymentRemarkCode_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ClaimPaymentRemarkCode_04 { get; set; }
        [D(5, typeof(X12_AN), "127")]
        public string ClaimPaymentRemarkCode_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ClaimPaymentRemarkCode_06 { get; set; }
        [D(7, typeof(X12_AN), "127")]
        public string ClaimPaymentRemarkCode_07 { get; set; }
        [D(8, typeof(X12_R), "782")]
        public string EndStageRenalDiseasePaymentAmount_08 { get; set; }
        [D(9, typeof(X12_R), "782")]
        public string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    public class OI_OtherInsuranceCoverageInformation_2
    {
        
        [D(1, typeof(X12_ID_1032_2), "1032")]
        public string ClaimFilingIndicatorCode_01 { get; set; }
        [D(2, typeof(X12_ID_1383), "1383")]
        public string ClaimSubmissionReasonCode_02 { get; set; }
        [D(3, typeof(X12_ID_1073_4), "1073")]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1351), "1351")]
        public string PatientSignatureSourceCode_04 { get; set; }
        [D(5, typeof(X12_ID_1360), "1360")]
        public string ProviderAgreementCode_05 { get; set; }
        [D(6, typeof(X12_ID_1363), "1363")]
        public string ReleaseofInformationCode_06 { get; set; }
    }
    
    public class X12_ID_1032_2
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","31","32","33","AM","BL","CH","CI","CN","DS","FI","HM","LI","LM","MA","MB","MC","MH","OF","SA","TV","VA","WB","WC","WD","WE","ZZ"};
    }
    
    public class X12_ID_1383
    {
        
        public List<string> Codes = new List<string> {"00","01","02","03","05","07","08","09","15","16","17","18","20","22","27","28","29","PB"};
    }
    
    public class X12_ID_1351
    {
        
        public List<string> Codes = new List<string> {"P"};
    }
    
    public class X12_ID_1363
    {
        
        public List<string> Codes = new List<string> {"I","Y"};
    }
    
    public class All_AMT_3
    {
        
        [S("AMT", 1)]
        public AMT_CoordinationofBenefits_COB_PayerPaidAmount_2 AMT_CoordinationofBenefits_COB_PayerPaidAmount_2 { get; set; }
        [S("AMT", 2)]
        public AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2 AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2 { get; set; }
        [S("AMT", 3)]
        public AMT_RemainingPatientLiability_3 AMT_RemainingPatientLiability_3 { get; set; }
    }
    
    public class AMT_RemainingPatientLiability_3
    {
        
        [D(1, typeof(X12_ID_522_4), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string RemainingPatientLiability_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2
    {
        
        [D(1, typeof(X12_ID_522_3), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string NonCoveredChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class X12_ID_522_3
    {
        
        public List<string> Codes = new List<string> {"A8"};
    }
    
    public class AMT_CoordinationofBenefits_COB_PayerPaidAmount_2
    {
        
        [D(1, typeof(X12_ID_522_2), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string PayerPaidAmount_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class X12_ID_522_2
    {
        
        public List<string> Codes = new List<string> {"D"};
    }
    
    public class CAS_ClaimLevelAdjustments_2
    {
        
        [D(1, typeof(X12_ID_1033), "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3, typeof(X12_R), "782")]
        public string AdjustmentAmount_03 { get; set; }
        [D(4, typeof(X12_R), "380")]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6, typeof(X12_R), "782")]
        public string AdjustmentAmount_06 { get; set; }
        [D(7, typeof(X12_R), "380")]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9, typeof(X12_R), "782")]
        public string AdjustmentAmount_09 { get; set; }
        [D(10, typeof(X12_R), "380")]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12, typeof(X12_R), "782")]
        public string AdjustmentAmount_12 { get; set; }
        [D(13, typeof(X12_R), "380")]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15, typeof(X12_R), "782")]
        public string AdjustmentAmount_15 { get; set; }
        [D(16, typeof(X12_R), "380")]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18, typeof(X12_R), "782")]
        public string AdjustmentAmount_18 { get; set; }
        [D(19, typeof(X12_R), "380")]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class SBR_OtherSubscriberInformation_2
    {
        
        [D(1, typeof(X12_ID_1138), "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, typeof(X12_ID_1069_3), "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string InsuredGrouporPolicyNumber_03 { get; set; }
        [D(4, typeof(X12_AN), "93")]
        public string OtherInsuredGroupName_04 { get; set; }
        [D(5, typeof(X12_ID_1336), "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6, typeof(X12_ID_1143), "1143")]
        public string CoordinationofBenefitsCode_06 { get; set; }
        [D(7, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_07 { get; set; }
        [D(8, typeof(X12_ID_584), "584")]
        public string EmploymentStatusCode_08 { get; set; }
        [D(9, typeof(X12_ID_1032), "1032")]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public class X12_ID_1138
    {
        
        public List<string> Codes = new List<string> {"A","B","C","D","E","F","G","H","P","S","T","U"};
    }
    
    public class X12_ID_1069_3
    {
        
        public List<string> Codes = new List<string> {"01","18","19","20","21","39","40","53","G8"};
    }
    
    public class X12_ID_1336
    {
        
        public List<string> Codes = new List<string> {"12","13","14","15","16","41","42","43","47"};
    }
    
    public class X12_ID_1143
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6","7","8","9"};
    }
    
    public class X12_ID_584
    {
        
        public List<string> Codes = new List<string> {"00","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AO","AP","AQ","AS","AT","AU","CA","CC","CO","CT","DC","DD","DI","DQ","DR","DS","EO","FA","FB","FC","FO","FT","HD","IA","IR","L1","L2","L3","L4","L5","L6","L7","LA","LE","LF","LM","LO","LS","LU","LW","LX","NE","OS","OT","PA","PC","PE","PM","PN","PR","PT","PV","PW","RA","RB","RC","RD","RE","RI","RM","RP","RR","RT","RU","RW","SA","SB","SE","SL","SU","TE","TF","TM","TN","TP","TR","UK","VO","XD","ZZ"};
    }
    
    public class X12_ID_1032
    {
        
        public List<string> Codes = new List<string> {"11","12","13","14","15","16","17","AM","BL","CH","CI","DS","FI","HM","LM","MA","MB","MC","OF","TV","VA","WC","ZZ"};
    }
    
    public class All_NM1_7
    {
        
        [G(1)]
        public List<Loop_2310A_2> Loop_2310A_2 { get; set; }
        [G(2)]
        public Loop_2310B_2 Loop_2310B_2 { get; set; }
        [G(3)]
        public Loop_2310C_2 Loop_2310C_2 { get; set; }
        [G(4)]
        public Loop_2310D_2 Loop_2310D_2 { get; set; }
        [G(5)]
        public Loop_2310E_2 Loop_2310E_2 { get; set; }
        [G(6)]
        public Loop_2310F_2 Loop_2310F_2 { get; set; }
    }
    
    public class Loop_2310F_2
    {
        
        [S("NM1", 1)]
        public NM1_AmbulanceDrop_offLocation_3 NM1_AmbulanceDrop_offLocation_3 { get; set; }
        [S("N3", 2)]
        public N3_AmbulanceDrop_offLocationAddress_3 N3_AmbulanceDrop_offLocationAddress_3 { get; set; }
        [S("N4", 3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode_3 N4_AmbulanceDrop_offLocationCity_State_ZipCode_3 { get; set; }
    }
    
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode_3
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulanceDrop_offLocationAddress_3
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulanceDrop_offLocation_3
    {
        
        [D(1, typeof(X12_ID_98_14), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string AmbulanceDropoffLocation_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310E_2
    {
        
        [S("NM1", 1)]
        public NM1_AmbulancePick_upLocation_3 NM1_AmbulancePick_upLocation_3 { get; set; }
        [S("N3", 2)]
        public N3_AmbulancePick_upLocationAddress_3 N3_AmbulancePick_upLocationAddress_3 { get; set; }
        [S("N4", 3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode_3 N4_AmbulancePick_upLocationCity_State_ZipCode_3 { get; set; }
    }
    
    public class N4_AmbulancePick_upLocationCity_State_ZipCode_3
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string AmbulancePickupCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulancePick_upLocationAddress_3
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulancePick_upLocation_3
    {
        
        [D(1, typeof(X12_ID_98_13), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310D_2
    {
        
        [S("NM1", 1)]
        public NM1_SupervisingProviderName_3 NM1_SupervisingProviderName_3 { get; set; }
        [S("REF", 2)]
        public List<REF_SupervisingProviderSecondaryIdentification_3> REF_SupervisingProviderSecondaryIdentification_3 { get; set; }
    }
    
    public class REF_SupervisingProviderSecondaryIdentification_3
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_73 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_73
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_SupervisingProviderName_3
    {
        
        [D(1, typeof(X12_ID_98_12), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310C_2
    {
        
        [S("NM1", 1)]
        public NM1_ServiceFacilityLocationName_2 NM1_ServiceFacilityLocationName_2 { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress_3 N3_ServiceFacilityLocationAddress_3 { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode_3 N4_ServiceFacilityLocationCity_State_ZIPCode_3 { get; set; }
        [S("REF", 4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_3> REF_ServiceFacilityLocationSecondaryIdentification_3 { get; set; }
        [S("PER", 5)]
        public PER_ServiceFacilityContactInformation_2 PER_ServiceFacilityContactInformation_2 { get; set; }
    }
    
    public class PER_ServiceFacilityContactInformation_2
    {
        
        [D(1, typeof(X12_ID_366), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN), "93")]
        public string Name_02 { get; set; }
        [D(3, typeof(X12_ID_365_3), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_4), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_5), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN), "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN), "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class X12_ID_365_3
    {
        
        public List<string> Codes = new List<string> {"TE"};
    }
    
    public class X12_ID_365_4
    {
        
        public List<string> Codes = new List<string> {"EX"};
    }
    
    public class X12_ID_365_5
    {
        
        public List<string> Codes = new List<string> {"AA","AB","AC","AD","AE","AP","AS","AU","BN","BT","CA","CP","DN","EA","ED","EM","EX","FT","FU","FX","HF","HP","IT","MN","NP","OF","OT","PA","PC","PP","PS","SP","TE","TL","TM","TN","TX","UR","VM","WC","WF","WP"};
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification_3
    {
        
        [D(1, typeof(X12_ID_128_27), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string LaboratoryorFacilitySecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_72 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_72
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_ServiceFacilityLocationCity_State_ZIPCode_3
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress_3
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocationName_2
    {
        
        [D(1, typeof(X12_ID_98_11), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string LaboratoryorFacilityName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310B_2
    {
        
        [S("NM1", 1)]
        public NM1_RenderingProviderName_3 NM1_RenderingProviderName_3 { get; set; }
        [S("PRV", 2)]
        public PRV_RenderingProviderSpecialtyInformation_3 PRV_RenderingProviderSpecialtyInformation_3 { get; set; }
        [S("REF", 3)]
        public List<REF_RenderingProviderSecondaryIdentification_3> REF_RenderingProviderSecondaryIdentification_3 { get; set; }
    }
    
    public class REF_RenderingProviderSecondaryIdentification_3
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_71 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_71
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class PRV_RenderingProviderSpecialtyInformation_3
    {
        
        [D(1, typeof(X12_ID_1221_2), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128), "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, typeof(X12_ID), "156")]
        public string StateorProvinceCode_04 { get; set; }
        [C(5)]
        public C035_ProviderSpecialtyInformation_4 ProviderSpecialtyInformation_05 { get; set; }
        [D(6, typeof(X12_ID_1223), "1223")]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    public class C035_ProviderSpecialtyInformation_4
    {
        
        [D(1, typeof(X12_ID_1222), "1222")]
        public string ProviderSpecialtyCode_01 { get; set; }
        [D(2, typeof(X12_ID_559), "559")]
        public string AgencyQualifierCode_02 { get; set; }
        [D(3, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public class NM1_RenderingProviderName_3
    {
        
        [D(1, typeof(X12_ID_98_10), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string RenderingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310A_2
    {
        
        [S("NM1", 1)]
        public NM1_ReferringProviderName_3 NM1_ReferringProviderName_3 { get; set; }
        [S("REF", 2)]
        public List<REF_ReferringProviderSecondaryIdentification_3> REF_ReferringProviderSecondaryIdentification_3 { get; set; }
    }
    
    public class REF_ReferringProviderSecondaryIdentification_3
    {
        
        [D(1, typeof(X12_ID_128_25), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_70 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_70
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_ReferringProviderName_3
    {
        
        [D(1, typeof(X12_ID_98_9), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class HCP_ClaimPricing_RepricingInformation_2
    {
        
        [D(1, typeof(X12_ID_1473), "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3, typeof(X12_R), "782")]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5, typeof(X12_R), "118")]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7, typeof(X12_R), "782")]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8, typeof(X12_AN), "234")]
        public string ProductServiceID_08 { get; set; }
        [D(9, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_09 { get; set; }
        [D(10, typeof(X12_AN), "234")]
        public string ProductServiceID_10 { get; set; }
        [D(11, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [D(12, typeof(X12_R), "380")]
        public string Quantity_12 { get; set; }
        [D(13, typeof(X12_ID_901), "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, typeof(X12_ID_1526), "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, typeof(X12_ID_1527), "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class X12_ID_1473
    {
        
        public List<string> Codes = new List<string> {"00","01","02","03","04","05","07","08","09","10","11","12","13","14"};
    }
    
    public class All_HI_2
    {
        
        [S("HI", 1)]
        public HI_HealthCareDiagnosisCode_2 HI_HealthCareDiagnosisCode_2 { get; set; }
        [S("HI", 2)]
        public HI_AnesthesiaRelatedProcedure_2 HI_AnesthesiaRelatedProcedure_2 { get; set; }
        [S("HI", 3)]
        public List<HI_ConditionInformation_2> HI_ConditionInformation_2 { get; set; }
    }
    
    public class HI_ConditionInformation_2
    {
        
        [C(1)]
        public C022_HealthCareCodeInformation_61 HealthCareCodeInformation_01 { get; set; }
        [C(2)]
        public C022_HealthCareCodeInformation_62 HealthCareCodeInformation_02 { get; set; }
        [C(3)]
        public C022_HealthCareCodeInformation_63 HealthCareCodeInformation_03 { get; set; }
        [C(4)]
        public C022_HealthCareCodeInformation_64 HealthCareCodeInformation_04 { get; set; }
        [C(5)]
        public C022_HealthCareCodeInformation_65 HealthCareCodeInformation_05 { get; set; }
        [C(6)]
        public C022_HealthCareCodeInformation_66 HealthCareCodeInformation_06 { get; set; }
        [C(7)]
        public C022_HealthCareCodeInformation_67 HealthCareCodeInformation_07 { get; set; }
        [C(8)]
        public C022_HealthCareCodeInformation_68 HealthCareCodeInformation_08 { get; set; }
        [C(9)]
        public C022_HealthCareCodeInformation_69 HealthCareCodeInformation_09 { get; set; }
        [C(10)]
        public C022_HealthCareCodeInformation_70 HealthCareCodeInformation_10 { get; set; }
        [C(11)]
        public C022_HealthCareCodeInformation_71 HealthCareCodeInformation_11 { get; set; }
        [C(12)]
        public C022_HealthCareCodeInformation_72 HealthCareCodeInformation_12 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_72
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class X12_ID_1270_6
    {
        
        public List<string> Codes = new List<string> {"BG"};
    }
    
    public class X12_ID_1250_3
    {
        
        public List<string> Codes = new List<string> {"CC","CD","CM","CQ","CY","D6","D8","DA","DB","DD","DDT","DT","DTD","DTS","EH","KA","MCY","MD","MM","RD","RD2","RD4","RD5","RD6","RD8","RDM","RDT","RMD","RMY","RTM","RTS","TC","TM","TQ","TR","TS","TT","TU","UN","YM","YMM","YY"};
    }
    
    public class C022_HealthCareCodeInformation_71
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_70
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_69
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_68
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_67
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_66
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_65
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_64
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_63
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_62
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_61
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class HI_AnesthesiaRelatedProcedure_2
    {
        
        [C(1)]
        public C022_HealthCareCodeInformation_49 HealthCareCodeInformation_01 { get; set; }
        [C(2)]
        public C022_HealthCareCodeInformation_50 HealthCareCodeInformation_02 { get; set; }
        [C(3)]
        public C022_HealthCareCodeInformation_51 HealthCareCodeInformation_03 { get; set; }
        [C(4)]
        public C022_HealthCareCodeInformation_52 HealthCareCodeInformation_04 { get; set; }
        [C(5)]
        public C022_HealthCareCodeInformation_53 HealthCareCodeInformation_05 { get; set; }
        [C(6)]
        public C022_HealthCareCodeInformation_54 HealthCareCodeInformation_06 { get; set; }
        [C(7)]
        public C022_HealthCareCodeInformation_55 HealthCareCodeInformation_07 { get; set; }
        [C(8)]
        public C022_HealthCareCodeInformation_56 HealthCareCodeInformation_08 { get; set; }
        [C(9)]
        public C022_HealthCareCodeInformation_57 HealthCareCodeInformation_09 { get; set; }
        [C(10)]
        public C022_HealthCareCodeInformation_58 HealthCareCodeInformation_10 { get; set; }
        [C(11)]
        public C022_HealthCareCodeInformation_59 HealthCareCodeInformation_11 { get; set; }
        [C(12)]
        public C022_HealthCareCodeInformation_60 HealthCareCodeInformation_12 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_60
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_59
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_58
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_57
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_56
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_55
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_54
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_53
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_52
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_51
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_50
    {
        
        [D(1, typeof(X12_ID_1270_5), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class X12_ID_1270_5
    {
        
        public List<string> Codes = new List<string> {"BO"};
    }
    
    public class C022_HealthCareCodeInformation_49
    {
        
        [D(1, typeof(X12_ID_1270_4), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string AnesthesiaRelatedSurgicalProcedure_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class X12_ID_1270_4
    {
        
        public List<string> Codes = new List<string> {"BP"};
    }
    
    public class HI_HealthCareDiagnosisCode_2
    {
        
        [C(1)]
        public C022_HealthCareCodeInformation_37 HealthCareCodeInformation_01 { get; set; }
        [C(2)]
        public C022_HealthCareCodeInformation_38 HealthCareCodeInformation_02 { get; set; }
        [C(3)]
        public C022_HealthCareCodeInformation_39 HealthCareCodeInformation_03 { get; set; }
        [C(4)]
        public C022_HealthCareCodeInformation_40 HealthCareCodeInformation_04 { get; set; }
        [C(5)]
        public C022_HealthCareCodeInformation_41 HealthCareCodeInformation_05 { get; set; }
        [C(6)]
        public C022_HealthCareCodeInformation_42 HealthCareCodeInformation_06 { get; set; }
        [C(7)]
        public C022_HealthCareCodeInformation_43 HealthCareCodeInformation_07 { get; set; }
        [C(8)]
        public C022_HealthCareCodeInformation_44 HealthCareCodeInformation_08 { get; set; }
        [C(9)]
        public C022_HealthCareCodeInformation_45 HealthCareCodeInformation_09 { get; set; }
        [C(10)]
        public C022_HealthCareCodeInformation_46 HealthCareCodeInformation_10 { get; set; }
        [C(11)]
        public C022_HealthCareCodeInformation_47 HealthCareCodeInformation_11 { get; set; }
        [C(12)]
        public C022_HealthCareCodeInformation_48 HealthCareCodeInformation_12 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_48
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class X12_ID_1270_3
    {
        
        public List<string> Codes = new List<string> {"ABF","BF"};
    }
    
    public class C022_HealthCareCodeInformation_47
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_46
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_45
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_44
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_43
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_42
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_41
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_40
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_39
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_38
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_37
    {
        
        [D(1, typeof(X12_ID_1270_2), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class X12_ID_1270_2
    {
        
        public List<string> Codes = new List<string> {"ABK","BK"};
    }
    
    public class All_CRC_3
    {
        
        [S("CRC", 1)]
        public List<CRC_AmbulanceCertification_3> CRC_AmbulanceCertification_3 { get; set; }
        [S("CRC", 2)]
        public List<CRC_PatientConditionInformation_Vision_2> CRC_PatientConditionInformation_Vision_2 { get; set; }
        [S("CRC", 3)]
        public CRC_HomeboundIndicator_2 CRC_HomeboundIndicator_2 { get; set; }
        [S("CRC", 4)]
        public CRC_EPSDTReferral_2 CRC_EPSDTReferral_2 { get; set; }
    }
    
    public class CRC_EPSDTReferral_2
    {
        
        [D(1, typeof(X12_ID_1136_4), "1136")]
        public string CodeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string CertificationConditionCodeAppliesIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_5), "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1321_5), "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, typeof(X12_ID_1321_5), "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class X12_ID_1136_4
    {
        
        public List<string> Codes = new List<string> {"ZZ"};
    }
    
    public class X12_ID_1321_5
    {
        
        public List<string> Codes = new List<string> {"AV","NU","S2","ST"};
    }
    
    public class CRC_HomeboundIndicator_2
    {
        
        [D(1, typeof(X12_ID_1136_3), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_2), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_3), "1321")]
        public string HomeboundIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class X12_ID_1136_3
    {
        
        public List<string> Codes = new List<string> {"75"};
    }
    
    public class X12_ID_1321_3
    {
        
        public List<string> Codes = new List<string> {"IH"};
    }
    
    public class CRC_PatientConditionInformation_Vision_2
    {
        
        [D(1, typeof(X12_ID_1136_2), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_2), "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, typeof(X12_ID_1321_2), "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, typeof(X12_ID_1321_2), "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, typeof(X12_ID_1321_2), "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, typeof(X12_ID_1321_2), "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class X12_ID_1136_2
    {
        
        public List<string> Codes = new List<string> {"E1","E2","E3"};
    }
    
    public class X12_ID_1321_2
    {
        
        public List<string> Codes = new List<string> {"L1","L2","L3","L4","L5"};
    }
    
    public class CRC_AmbulanceCertification_3
    {
        
        [D(1, typeof(X12_ID_1136), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class CR2_SpinalManipulationServiceInformation_2
    {
        
        [D(1, typeof(X12_N0), "609")]
        public string Count_01 { get; set; }
        [D(2, typeof(X12_R), "380")]
        public string Quantity_02 { get; set; }
        [D(3, typeof(X12_ID_1367), "1367")]
        public string SubluxationLevelCode_03 { get; set; }
        [D(4, typeof(X12_ID_1367), "1367")]
        public string SubluxationLevelCode_04 { get; set; }
        [D(5, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_R), "380")]
        public string Quantity_07 { get; set; }
        [D(8, typeof(X12_ID_1342), "1342")]
        public string PatientConditionCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
        [D(10, typeof(X12_AN), "352")]
        public string PatientConditionDescription_10 { get; set; }
        [D(11, typeof(X12_AN), "352")]
        public string PatientConditionDescription_11 { get; set; }
        [D(12, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    public class X12_ID_1367
    {
        
        public List<string> Codes = new List<string> {"C1","C2","C3","C4","C5","C6","C7","CO","IL","L1","L2","L3","L4","L5","OC","SA","T1","T10","T11","T12","T2","T3","T4","T5","T6","T7","T8","T9"};
    }
    
    public class X12_ID_1342
    {
        
        public List<string> Codes = new List<string> {"A","C","D","E","F","G","M"};
    }
    
    public class CR1_AmbulanceTransportInformation_3
    {
        
        [D(1, typeof(X12_ID_355_3), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "81")]
        public string PatientWeight_02 { get; set; }
        [D(3, typeof(X12_ID_1316), "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, typeof(X12_ID_1317), "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, typeof(X12_ID_355_4), "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string TransportDistance_06 { get; set; }
        [D(7, typeof(X12_AN), "166")]
        public string AddressInformation_07 { get; set; }
        [D(8, typeof(X12_AN), "166")]
        public string AddressInformation_08 { get; set; }
        [D(9, typeof(X12_AN), "352")]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10, typeof(X12_AN), "352")]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class NTE_ClaimNote_2
    {
        
        [D(1, typeof(X12_ID_363), "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, typeof(X12_AN), "352")]
        public string ClaimNoteText_02 { get; set; }
    }
    
    public class X12_ID_363
    {
        
        public List<string> Codes = new List<string> {"ADD","CER","DCP","DGN","TPO"};
    }
    
    public class K3_FileInformation_3
    {
        
        [D(1, typeof(X12_AN), "449")]
        public string FixedFormatInformation_01 { get; set; }
        [D(2, typeof(X12_ID_1333), "1333")]
        public string RecordFormatCode_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_7 CompositeUnitofMeasure_03 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_7
    {
        
        [D(1, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_REF_9
    {
        
        [S("REF", 1)]
        public REF_ServiceAuthorizationExceptionCode_2 REF_ServiceAuthorizationExceptionCode_2 { get; set; }
        [S("REF", 2)]
        public REF_MandatoryMedicare_Section4081_CrossoverIndicator_2 REF_MandatoryMedicare_Section4081_CrossoverIndicator_2 { get; set; }
        [S("REF", 3)]
        public REF_MammographyCertificationNumber_3 REF_MammographyCertificationNumber_3 { get; set; }
        [S("REF", 4)]
        public REF_ReferralNumber_3 REF_ReferralNumber_3 { get; set; }
        [S("REF", 5)]
        public REF_PriorAuthorization_3 REF_PriorAuthorization_3 { get; set; }
        [S("REF", 6)]
        public REF_PayerClaimControlNumber_2 REF_PayerClaimControlNumber_2 { get; set; }
        [S("REF", 7)]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3 REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3 { get; set; }
        [S("REF", 8)]
        public REF_RepricedClaimNumber_2 REF_RepricedClaimNumber_2 { get; set; }
        [S("REF", 9)]
        public REF_AdjustedRepricedClaimNumber_2 REF_AdjustedRepricedClaimNumber_2 { get; set; }
        [S("REF", 10)]
        public REF_InvestigationalDeviceExemptionNumber_2 REF_InvestigationalDeviceExemptionNumber_2 { get; set; }
        [S("REF", 11)]
        public REF_ClaimIdentifierForTransmissionIntermediaries_2 REF_ClaimIdentifierForTransmissionIntermediaries_2 { get; set; }
        [S("REF", 12)]
        public REF_MedicalRecordNumber_2 REF_MedicalRecordNumber_2 { get; set; }
        [S("REF", 13)]
        public REF_DemonstrationProjectIdentifier_2 REF_DemonstrationProjectIdentifier_2 { get; set; }
        [S("REF", 14)]
        public REF_CarePlanOversight_2 REF_CarePlanOversight_2 { get; set; }
    }
    
    public class REF_CarePlanOversight_2
    {
        
        [D(1, typeof(X12_ID_128_24), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string CarePlanOversightNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_69 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_24
    {
        
        public List<string> Codes = new List<string> {"1J"};
    }
    
    public class C040_ReferenceIdentifier_69
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_DemonstrationProjectIdentifier_2
    {
        
        [D(1, typeof(X12_ID_128_23), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string DemonstrationProjectIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_68 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_23
    {
        
        public List<string> Codes = new List<string> {"P4"};
    }
    
    public class C040_ReferenceIdentifier_68
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MedicalRecordNumber_2
    {
        
        [D(1, typeof(X12_ID_128_22), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string MedicalRecordNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_67 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_22
    {
        
        public List<string> Codes = new List<string> {"EA"};
    }
    
    public class C040_ReferenceIdentifier_67
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClaimIdentifierForTransmissionIntermediaries_2
    {
        
        [D(1, typeof(X12_ID_128_21), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ValueAddedNetworkTraceNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_66 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_21
    {
        
        public List<string> Codes = new List<string> {"D9"};
    }
    
    public class C040_ReferenceIdentifier_66
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_InvestigationalDeviceExemptionNumber_2
    {
        
        [D(1, typeof(X12_ID_128_20), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string InvestigationalDeviceExemptionIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_65 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_20
    {
        
        public List<string> Codes = new List<string> {"LX"};
    }
    
    public class C040_ReferenceIdentifier_65
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_AdjustedRepricedClaimNumber_2
    {
        
        [D(1, typeof(X12_ID_128_19), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string AdjustedRepricedClaimReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_64 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_19
    {
        
        public List<string> Codes = new List<string> {"9C"};
    }
    
    public class C040_ReferenceIdentifier_64
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_RepricedClaimNumber_2
    {
        
        [D(1, typeof(X12_ID_128_18), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string RepricedClaimReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_63 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_18
    {
        
        public List<string> Codes = new List<string> {"9A"};
    }
    
    public class C040_ReferenceIdentifier_63
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3
    {
        
        [D(1, typeof(X12_ID_128_17), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_62 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_62
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PayerClaimControlNumber_2
    {
        
        [D(1, typeof(X12_ID_128_16), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PayerClaimControlNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_61 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_61
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PriorAuthorization_3
    {
        
        [D(1, typeof(X12_ID_128_15), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PriorAuthorizationNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_60 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_60
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ReferralNumber_3
    {
        
        [D(1, typeof(X12_ID_128_14), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_59 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_59
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MammographyCertificationNumber_3
    {
        
        [D(1, typeof(X12_ID_128_13), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_58 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_58
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MandatoryMedicare_Section4081_CrossoverIndicator_2
    {
        
        [D(1, typeof(X12_ID_128_12), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_127_2), "127")]
        public string MedicareSection4081Indicator_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_57 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_12
    {
        
        public List<string> Codes = new List<string> {"F5"};
    }
    
    public class X12_ID_127_2
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class C040_ReferenceIdentifier_57
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ServiceAuthorizationExceptionCode_2
    {
        
        [D(1, typeof(X12_ID_128_11), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_127_1), "127")]
        public string ServiceAuthorizationExceptionCode_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_56 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_11
    {
        
        public List<string> Codes = new List<string> {"4N"};
    }
    
    public class X12_ID_127_1
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6","7"};
    }
    
    public class C040_ReferenceIdentifier_56
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class AMT_PatientAmountPaid_2
    {
        
        [D(1, typeof(X12_ID_522), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string PatientAmountPaid_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class X12_ID_522
    {
        
        public List<string> Codes = new List<string> {"F5"};
    }
    
    public class CN1_ContractInformation_3
    {
        
        [D(1, typeof(X12_ID_1166), "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string ContractAmount_02 { get; set; }
        [D(3, typeof(X12_R), "332")]
        public string ContractPercentage_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ContractCode_04 { get; set; }
        [D(5, typeof(X12_R), "338")]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6, typeof(X12_AN), "799")]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class PWK_ClaimSupplementalInformation_2
    {
        
        [D(1, typeof(X12_ID_755), "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_756), "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, typeof(X12_N0), "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, typeof(X12_ID_66_6), "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "67")]
        public string AttachmentControlNumber_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated_4 ActionsIndicated_08 { get; set; }
        [D(9, typeof(X12_ID_1525), "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class X12_ID_755
    {
        
        public List<string> Codes = new List<string> {"03","04","05","06","07","08","09","10","11","13","15","21","77","A3","A4","AM","AS","B2","B3","B4","BR","BS","BT","CB","CK","CT","D2","DA","DB","DG","DJ","DS","EB","HC","HR","I5","IR","LA","M1","MT","NN","OB","OC","OD","OE","OX","OZ","P4","P5","PE","PN","PO","PQ","PY","PZ","RB","RR","RT","RX","SG","V5","XP"};
    }
    
    public class C002_ActionsIndicated_4
    {
        
        [D(1, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class All_DTP_3
    {
        
        [S("DTP", 1)]
        public DTP_Date_OnsetofCurrentIllnessorSymptom_2 DTP_Date_OnsetofCurrentIllnessorSymptom_2 { get; set; }
        [S("DTP", 2)]
        public DTP_Date_InitialTreatmentDate_3 DTP_Date_InitialTreatmentDate_3 { get; set; }
        [S("DTP", 3)]
        public DTP_Date_LastSeenDate_3 DTP_Date_LastSeenDate_3 { get; set; }
        [S("DTP", 4)]
        public DTP_Date_AcuteManifestation_2 DTP_Date_AcuteManifestation_2 { get; set; }
        [S("DTP", 5)]
        public DTP_Date_Accident_2 DTP_Date_Accident_2 { get; set; }
        [S("DTP", 6)]
        public DTP_Date_LastMenstrualPeriod_2 DTP_Date_LastMenstrualPeriod_2 { get; set; }
        [S("DTP", 7)]
        public DTP_Date_LastX_rayDate_3 DTP_Date_LastX_rayDate_3 { get; set; }
        [S("DTP", 8)]
        public DTP_Date_HearingandVisionPrescriptionDate_2 DTP_Date_HearingandVisionPrescriptionDate_2 { get; set; }
        [S("DTP", 9)]
        public DTP_Date_DisabilityDates_2 DTP_Date_DisabilityDates_2 { get; set; }
        [S("DTP", 10)]
        public DTP_Date_LastWorked_2 DTP_Date_LastWorked_2 { get; set; }
        [S("DTP", 11)]
        public DTP_Date_AuthorizedReturntoWork_2 DTP_Date_AuthorizedReturntoWork_2 { get; set; }
        [S("DTP", 12)]
        public DTP_Date_Admission_2 DTP_Date_Admission_2 { get; set; }
        [S("DTP", 13)]
        public DTP_Date_Discharge_2 DTP_Date_Discharge_2 { get; set; }
        [S("DTP", 14)]
        public List<DTP_Date_AssumedandRelinquishedCareDates_2> DTP_Date_AssumedandRelinquishedCareDates_2 { get; set; }
        [S("DTP", 15)]
        public DTP_PropertyandCasualtyDateofFirstContact_2 DTP_PropertyandCasualtyDateofFirstContact_2 { get; set; }
        [S("DTP", 16)]
        public DTP_Date_RepricerReceivedDate_2 DTP_Date_RepricerReceivedDate_2 { get; set; }
    }
    
    public class DTP_Date_RepricerReceivedDate_2
    {
        
        [D(1, typeof(X12_ID_374_17), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string RepricerReceivedDate_03 { get; set; }
    }
    
    public class X12_ID_374_17
    {
        
        public List<string> Codes = new List<string> {"050"};
    }
    
    public class DTP_PropertyandCasualtyDateofFirstContact_2
    {
        
        [D(1, typeof(X12_ID_374_16), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string DateTimePeriod_03 { get; set; }
    }
    
    public class X12_ID_374_16
    {
        
        public List<string> Codes = new List<string> {"444"};
    }
    
    public class DTP_Date_AssumedandRelinquishedCareDates_2
    {
        
        [D(1, typeof(X12_ID_374_15), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string AssumedorRelinquishedCareDate_03 { get; set; }
    }
    
    public class X12_ID_374_15
    {
        
        public List<string> Codes = new List<string> {"090","091"};
    }
    
    public class DTP_Date_Discharge_2
    {
        
        [D(1, typeof(X12_ID_374_14), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string RelatedHospitalizationDischargeDate_03 { get; set; }
    }
    
    public class X12_ID_374_14
    {
        
        public List<string> Codes = new List<string> {"096"};
    }
    
    public class DTP_Date_Admission_2
    {
        
        [D(1, typeof(X12_ID_374_13), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string RelatedHospitalizationAdmissionDate_03 { get; set; }
    }
    
    public class X12_ID_374_13
    {
        
        public List<string> Codes = new List<string> {"435"};
    }
    
    public class DTP_Date_AuthorizedReturntoWork_2
    {
        
        [D(1, typeof(X12_ID_374_12), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string WorkReturnDate_03 { get; set; }
    }
    
    public class X12_ID_374_12
    {
        
        public List<string> Codes = new List<string> {"296"};
    }
    
    public class DTP_Date_LastWorked_2
    {
        
        [D(1, typeof(X12_ID_374_11), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastWorkedDate_03 { get; set; }
    }
    
    public class X12_ID_374_11
    {
        
        public List<string> Codes = new List<string> {"297"};
    }
    
    public class DTP_Date_DisabilityDates_2
    {
        
        [D(1, typeof(X12_ID_374_10), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_2), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string DisabilityFromDate_03 { get; set; }
    }
    
    public class X12_ID_374_10
    {
        
        public List<string> Codes = new List<string> {"314","360","361"};
    }
    
    public class DTP_Date_HearingandVisionPrescriptionDate_2
    {
        
        [D(1, typeof(X12_ID_374_9), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string PrescriptionDate_03 { get; set; }
    }
    
    public class DTP_Date_LastX_rayDate_3
    {
        
        [D(1, typeof(X12_ID_374_8), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class DTP_Date_LastMenstrualPeriod_2
    {
        
        [D(1, typeof(X12_ID_374_7), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastMenstrualPeriodDate_03 { get; set; }
    }
    
    public class X12_ID_374_7
    {
        
        public List<string> Codes = new List<string> {"484"};
    }
    
    public class DTP_Date_Accident_2
    {
        
        [D(1, typeof(X12_ID_374_6), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string AccidentDate_03 { get; set; }
    }
    
    public class X12_ID_374_6
    {
        
        public List<string> Codes = new List<string> {"439"};
    }
    
    public class DTP_Date_AcuteManifestation_2
    {
        
        [D(1, typeof(X12_ID_374_5), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    public class X12_ID_374_5
    {
        
        public List<string> Codes = new List<string> {"453"};
    }
    
    public class DTP_Date_LastSeenDate_3
    {
        
        [D(1, typeof(X12_ID_374_4), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastSeenDate_03 { get; set; }
    }
    
    public class DTP_Date_InitialTreatmentDate_3
    {
        
        [D(1, typeof(X12_ID_374_3), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class DTP_Date_OnsetofCurrentIllnessorSymptom_2
    {
        
        [D(1, typeof(X12_ID_374_2), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string OnsetofCurrentIllnessorInjuryDate_03 { get; set; }
    }
    
    public class X12_ID_374_2
    {
        
        public List<string> Codes = new List<string> {"431"};
    }
    
    public class CLM_ClaimInformation_2
    {
        
        [D(1, typeof(X12_AN), "1028")]
        public string PatientControlNumber_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string TotalClaimChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID_1032_2), "1032")]
        public string ClaimFilingIndicatorCode_03 { get; set; }
        [D(4, typeof(X12_ID_1343), "1343")]
        public string NonInstitutionalClaimTypeCode_04 { get; set; }
        [C(5)]
        public C023_HealthCareServiceLocationInformation_2 HealthCareServiceLocationInformation_05 { get; set; }
        [D(6, typeof(X12_ID_1073_3), "1073")]
        public string ProviderorSupplierSignatureIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1359), "1359")]
        public string AssignmentorPlanParticipationCode_07 { get; set; }
        [D(8, typeof(X12_ID_1073_4), "1073")]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        [D(9, typeof(X12_ID_1363), "1363")]
        public string ReleaseofInformationCode_09 { get; set; }
        [D(10, typeof(X12_ID_1351), "1351")]
        public string PatientSignatureSourceCode_10 { get; set; }
        [C(11)]
        public C024_RelatedCausesInformation_2 RelatedCausesInformation_11 { get; set; }
        [D(12, typeof(X12_ID_1366), "1366")]
        public string SpecialProgramIndicator_12 { get; set; }
        [D(13, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_13 { get; set; }
        [D(14, typeof(X12_ID_1338), "1338")]
        public string LevelofServiceCode_14 { get; set; }
        [D(15, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_15 { get; set; }
        [D(16, typeof(X12_ID_1360), "1360")]
        public string ProviderAgreementCode_16 { get; set; }
        [D(17, typeof(X12_ID_1029), "1029")]
        public string ClaimStatusCode_17 { get; set; }
        [D(18, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_18 { get; set; }
        [D(19, typeof(X12_ID_1383), "1383")]
        public string ClaimSubmissionReasonCode_19 { get; set; }
        [D(20, typeof(X12_ID_1514), "1514")]
        public string DelayReasonCode_20 { get; set; }
    }
    
    public class X12_ID_1343
    {
        
        public List<string> Codes = new List<string> {"A","AA","AM","AN","CF","CH","CS","DA","DD","DM","DN","ER","HH","HS","IF","IL","L","LT","MD","MF","MH","MI","MO","MS","NM","NP","NS","O","OC","OP","OT","OX","P","PA","PD","PE","PF","PS","PT","RX","S","SC","SN","ST","T","TX","V"};
    }
    
    public class X12_ID_1359
    {
        
        public List<string> Codes = new List<string> {"A","B","C"};
    }
    
    public class X12_ID_1366
    {
        
        public List<string> Codes = new List<string> {"02","03","05","09"};
    }
    
    public class X12_ID_1338
    {
        
        public List<string> Codes = new List<string> {"00","01","02","03","04","05","06","09","10","11","E","F1","F2","I","L","NBC","R","U"};
    }
    
    public class X12_ID_1029
    {
        
        public List<string> Codes = new List<string> {"1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","29","3","30","4","5","6","7","8","9","AD","AP","CC","CL","CP","I","RA","RB","RC","RD","RO"};
    }
    
    public class X12_ID_1514
    {
        
        public List<string> Codes = new List<string> {"1","10","11","15","2","3","4","5","6","7","8","9"};
    }
    
    public class C024_RelatedCausesInformation_2
    {
        
        [D(1, typeof(X12_ID_1362), "1362")]
        public string RelatedCausesCode_01 { get; set; }
        [D(2, typeof(X12_ID_1362), "1362")]
        public string RelatedCausesCode_02 { get; set; }
        [D(3, typeof(X12_ID_1362_2), "1362")]
        public string RelatedCausesCode_03 { get; set; }
        [D(4, typeof(X12_ID), "156")]
        public string AutoAccidentStateorProvinceCode_04 { get; set; }
        [D(5, typeof(X12_ID), "26")]
        public string CountryCode_05 { get; set; }
    }
    
    public class X12_ID_1362
    {
        
        public List<string> Codes = new List<string> {"AA","EM","OA"};
    }
    
    public class X12_ID_1362_2
    {
        
        public List<string> Codes = new List<string> {"AA","AB","AP","EM","OA","ZZ"};
    }
    
    public class C023_HealthCareServiceLocationInformation_2
    {
        
        [D(1, typeof(X12_AN), "1331")]
        public string PlaceofServiceCode_01 { get; set; }
        [D(2, typeof(X12_ID_1332), "1332")]
        public string FacilityCodeQualifier_02 { get; set; }
        [D(3, typeof(X12_ID), "1325")]
        public string ClaimFrequencyCode_03 { get; set; }
    }
    
    public class X12_ID_1332
    {
        
        public List<string> Codes = new List<string> {"B"};
    }
    
    public class Loop_2010CA
    {
        
        [S("NM1", 1)]
        public NM1_PatientName NM1_PatientName { get; set; }
        [S("N3", 2)]
        public N3_PatientAddress N3_PatientAddress { get; set; }
        [S("N4", 3)]
        public N4_PatientCity_State_ZIPCode N4_PatientCity_State_ZIPCode { get; set; }
        [S("DMG", 4)]
        public DMG_PatientDemographicInformation DMG_PatientDemographicInformation { get; set; }
        [A(5)]
        public All_REF_8 All_REF_8 { get; set; }
        [S("PER", 6)]
        public PER_PropertyandCasualtyPatientContactInformation PER_PropertyandCasualtyPatientContactInformation { get; set; }
    }
    
    public class PER_PropertyandCasualtyPatientContactInformation
    {
        
        [D(1, typeof(X12_ID_366), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN), "93")]
        public string Name_02 { get; set; }
        [D(3, typeof(X12_ID_365_3), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_4), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_5), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN), "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN), "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class All_REF_8
    {
        
        [S("REF", 1)]
        public REF_PropertyandCasualtyClaimNumber_2 REF_PropertyandCasualtyClaimNumber_2 { get; set; }
        [S("REF", 2)]
        public REF_PropertyandCasualtyPatientIdentifier REF_PropertyandCasualtyPatientIdentifier { get; set; }
    }
    
    public class REF_PropertyandCasualtyPatientIdentifier
    {
        
        [D(1, typeof(X12_ID_128_36), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PropertyandCasualtyPatientIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_55 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_36
    {
        
        public List<string> Codes = new List<string> {"1W","SY"};
    }
    
    public class C040_ReferenceIdentifier_55
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PropertyandCasualtyClaimNumber_2
    {
        
        [D(1, typeof(X12_ID_128_8), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_54 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_8
    {
        
        public List<string> Codes = new List<string> {"Y4"};
    }
    
    public class C040_ReferenceIdentifier_54
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class DMG_PatientDemographicInformation
    {
        
        [D(1, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "1251")]
        public string PatientBirthDate_02 { get; set; }
        [D(3, typeof(X12_ID_1068), "1068")]
        public string PatientGenderCode_03 { get; set; }
        [D(4, typeof(X12_ID_1067), "1067")]
        public string MaritalStatusCode_04 { get; set; }
        [C(5)]
        public List<C056_CompositeRaceorEthnicityInformation_2> CompositeRaceorEthnicityInformation_05 { get; set; }
        [D(6, typeof(X12_ID_1066), "1066")]
        public string CitizenshipStatusCode_06 { get; set; }
        [D(7, typeof(X12_ID), "26")]
        public string CountryCode_07 { get; set; }
        [D(8, typeof(X12_ID_659), "659")]
        public string BasisofVerificationCode_08 { get; set; }
        [D(9, typeof(X12_R), "380")]
        public string Quantity_09 { get; set; }
        [D(10, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_10 { get; set; }
        [D(11, typeof(X12_AN), "1271")]
        public string IndustryCode_11 { get; set; }
    }
    
    public class X12_ID_1068
    {
        
        public List<string> Codes = new List<string> {"F","M","U"};
    }
    
    public class X12_ID_1067
    {
        
        public List<string> Codes = new List<string> {"A","B","C","D","I","K","M","R","S","U","W","X"};
    }
    
    public class X12_ID_1066
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","G","H","I"};
    }
    
    public class X12_ID_659
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","G","H","I","J","K"};
    }
    
    public class C056_CompositeRaceorEthnicityInformation_2
    {
        
        [D(1, typeof(X12_ID_1109), "1109")]
        public string RaceorEthnicityCode_01 { get; set; }
        [D(2, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_02 { get; set; }
        [D(3, typeof(X12_AN), "1271")]
        public string IndustryCode_03 { get; set; }
    }
    
    public class X12_ID_1109
    {
        
        public List<string> Codes = new List<string> {"7","8","A","B","C","D","E","F","G","H","I","J","N","O","P","Q","R","S","T","U","V","W","Z"};
    }
    
    public class N4_PatientCity_State_ZIPCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string PatientCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string PatientStateCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string PatientPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_PatientAddress
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string PatientAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string PatientAddressLine_02 { get; set; }
    }
    
    public class NM1_PatientName
    {
        
        [D(1, typeof(X12_ID_98_17), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string PatientLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string PatientFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string PatientMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string PatientNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_17
    {
        
        public List<string> Codes = new List<string> {"QC"};
    }
    
    public class PAT_PatientInformation_2
    {
        
        [D(1, typeof(X12_ID_1069_4), "1069")]
        public string IndividualRelationshipCode_01 { get; set; }
        [D(2, typeof(X12_ID_1384), "1384")]
        public string PatientLocationCode_02 { get; set; }
        [D(3, typeof(X12_ID_584), "584")]
        public string EmploymentStatusCode_03 { get; set; }
        [D(4, typeof(X12_ID_1220), "1220")]
        public string StudentStatusCode_04 { get; set; }
        [D(5, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "1251")]
        public string PatientDeathDate_06 { get; set; }
        [D(7, typeof(X12_ID_355), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "81")]
        public string PatientWeight_08 { get; set; }
        [D(9, typeof(X12_ID_1073_2), "1073")]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    public class X12_ID_1069_4
    {
        
        public List<string> Codes = new List<string> {"01","19","20","21","39","40","53","G8"};
    }
    
    public class X12_ID_1384
    {
        
        public List<string> Codes = new List<string> {"A","B","C","D","E","F","G","H","L","M","O","P","R","S","T"};
    }
    
    public class X12_ID_1220
    {
        
        public List<string> Codes = new List<string> {"F","N","P"};
    }
    
    public class X12_ID_355
    {
        
        public List<string> Codes = new List<string> {"01"};
    }
    
    public class HL_PatientHierarchicalLevel
    {
        
        [D(1, typeof(X12_AN), "628")]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, typeof(X12_AN), "734")]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, typeof(X12_ID_735_3), "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, typeof(X12_ID_736_3), "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class X12_ID_735_3
    {
        
        public List<string> Codes = new List<string> {"23"};
    }
    
    public class X12_ID_736_3
    {
        
        public List<string> Codes = new List<string> {"0"};
    }
    
    public class Loop_2300
    {
        
        [S("CLM", 1)]
        public CLM_ClaimInformation CLM_ClaimInformation { get; set; }
        [A(2)]
        public All_DTP All_DTP { get; set; }
        [S("PWK", 3)]
        public List<PWK_ClaimSupplementalInformation> PWK_ClaimSupplementalInformation { get; set; }
        [S("CN1", 4)]
        public CN1_ContractInformation CN1_ContractInformation { get; set; }
        [S("AMT", 5)]
        public AMT_PatientAmountPaid AMT_PatientAmountPaid { get; set; }
        [A(6)]
        public All_REF_5 All_REF_5 { get; set; }
        [S("K3", 7)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        [S("NTE", 8)]
        public NTE_ClaimNote NTE_ClaimNote { get; set; }
        [S("CR1", 9)]
        public CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation { get; set; }
        [S("CR2", 10)]
        public CR2_SpinalManipulationServiceInformation CR2_SpinalManipulationServiceInformation { get; set; }
        [A(11)]
        public All_CRC All_CRC { get; set; }
        [A(12)]
        public All_HI All_HI { get; set; }
        [S("HCP", 13)]
        public HCP_ClaimPricing_RepricingInformation HCP_ClaimPricing_RepricingInformation { get; set; }
        [A(14)]
        public All_NM1_4 All_NM1_4 { get; set; }
        [G(15)]
        public List<Loop_2320> Loop_2320 { get; set; }
        [G(16)]
        public List<Loop_2400> Loop_2400 { get; set; }
    }
    
    public class Loop_2400
    {
        
        [S("LX", 1)]
        public LX_ServiceLineNumber LX_ServiceLineNumber { get; set; }
        [S("SV1", 2)]
        public SV1_ProfessionalService SV1_ProfessionalService { get; set; }
        [S("SV5", 3)]
        public SV5_DurableMedicalEquipmentService SV5_DurableMedicalEquipmentService { get; set; }
        [A(4)]
        public All_PWK All_PWK { get; set; }
        [S("CR1", 5)]
        public CR1_AmbulanceTransportInformation_2 CR1_AmbulanceTransportInformation_2 { get; set; }
        [S("CR3", 6)]
        public CR3_DurableMedicalEquipmentCertification CR3_DurableMedicalEquipmentCertification { get; set; }
        [A(7)]
        public All_CRC_2 All_CRC_2 { get; set; }
        [A(8)]
        public All_DTP_2 All_DTP_2 { get; set; }
        [A(9)]
        public All_QTY All_QTY { get; set; }
        [S("MEA", 10)]
        public List<MEA_TestResult> MEA_TestResult { get; set; }
        [S("CN1", 11)]
        public CN1_ContractInformation_2 CN1_ContractInformation_2 { get; set; }
        [A(12)]
        public All_REF_7 All_REF_7 { get; set; }
        [A(13)]
        public All_AMT_2 All_AMT_2 { get; set; }
        [S("K3", 14)]
        public List<K3_FileInformation_2> K3_FileInformation_2 { get; set; }
        [A(15)]
        public All_NTE All_NTE { get; set; }
        [S("PS1", 16)]
        public PS1_PurchasedServiceInformation PS1_PurchasedServiceInformation { get; set; }
        [S("HCP", 17)]
        public HCP_LinePricing_RepricingInformation HCP_LinePricing_RepricingInformation { get; set; }
        [G(18)]
        public Loop_2410 Loop_2410 { get; set; }
        [A(19)]
        public All_NM1_6 All_NM1_6 { get; set; }
        [G(20)]
        public List<Loop_2430> Loop_2430 { get; set; }
        [G(21)]
        public List<Loop_2440> Loop_2440 { get; set; }
    }
    
    public class Loop_2440
    {
        
        [S("LQ", 1)]
        public LQ_FormIdentificationCode LQ_FormIdentificationCode { get; set; }
        [S("FRM", 2)]
        public List<FRM_SupportingDocumentation> FRM_SupportingDocumentation { get; set; }
    }
    
    public class FRM_SupportingDocumentation
    {
        
        [D(1, typeof(X12_AN), "350")]
        public string QuestionNumberLetter_01 { get; set; }
        [D(2, typeof(X12_ID_1073_4), "1073")]
        public string QuestionResponse_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string QuestionResponse_03 { get; set; }
        [D(4, typeof(X12_DT), "373")]
        public string QuestionResponse_04 { get; set; }
        [D(5, typeof(X12_R), "332")]
        public string QuestionResponse_05 { get; set; }
    }
    
    public class LQ_FormIdentificationCode
    {
        
        [D(1, typeof(X12_ID_1270_7), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string FormIdentifier_02 { get; set; }
    }
    
    public class Loop_2430
    {
        
        [S("SVD", 1)]
        public SVD_LineAdjudicationInformation SVD_LineAdjudicationInformation { get; set; }
        [S("CAS", 2)]
        public List<CAS_LineAdjustment> CAS_LineAdjustment { get; set; }
        [S("DTP", 3)]
        public DTP_LineCheckorRemittanceDate DTP_LineCheckorRemittanceDate { get; set; }
        [S("AMT", 4)]
        public AMT_RemainingPatientLiability_2 AMT_RemainingPatientLiability_2 { get; set; }
    }
    
    public class AMT_RemainingPatientLiability_2
    {
        
        [D(1, typeof(X12_ID_522_4), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string RemainingPatientLiability_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class DTP_LineCheckorRemittanceDate
    {
        
        [D(1, typeof(X12_ID_374_18), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    public class CAS_LineAdjustment
    {
        
        [D(1, typeof(X12_ID_1033), "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3, typeof(X12_R), "782")]
        public string AdjustmentAmount_03 { get; set; }
        [D(4, typeof(X12_R), "380")]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6, typeof(X12_R), "782")]
        public string AdjustmentAmount_06 { get; set; }
        [D(7, typeof(X12_R), "380")]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9, typeof(X12_R), "782")]
        public string AdjustmentAmount_09 { get; set; }
        [D(10, typeof(X12_R), "380")]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12, typeof(X12_R), "782")]
        public string AdjustmentAmount_12 { get; set; }
        [D(13, typeof(X12_R), "380")]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15, typeof(X12_R), "782")]
        public string AdjustmentAmount_15 { get; set; }
        [D(16, typeof(X12_R), "380")]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18, typeof(X12_R), "782")]
        public string AdjustmentAmount_18 { get; set; }
        [D(19, typeof(X12_R), "380")]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class SVD_LineAdjudicationInformation
    {
        
        [D(1, typeof(X12_AN), "67")]
        public string OtherPayerPrimaryIdentifier_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string ServiceLinePaidAmount_02 { get; set; }
        [C(3)]
        public C003_CompositeMedicalProcedureIdentifier_3 CompositeMedicalProcedureIdentifier_03 { get; set; }
        [D(4, typeof(X12_AN), "234")]
        public string ProductServiceID_04 { get; set; }
        [D(5, typeof(X12_R), "380")]
        public string PaidServiceUnitCount_05 { get; set; }
        [D(6, typeof(X12_N0), "554")]
        public string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    public class C003_CompositeMedicalProcedureIdentifier_3
    {
        
        [D(1, typeof(X12_ID_235_2), "235")]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, typeof(X12_AN), "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, typeof(X12_AN), "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, typeof(X12_AN), "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string ProcedureCodeDescription_07 { get; set; }
        [D(8, typeof(X12_AN), "234")]
        public string ProductServiceID_08 { get; set; }
    }
    
    public class All_NM1_6
    {
        
        [G(1)]
        public Loop_2420A Loop_2420A { get; set; }
        [G(2)]
        public Loop_2420B Loop_2420B { get; set; }
        [G(3)]
        public Loop_2420C Loop_2420C { get; set; }
        [G(4)]
        public Loop_2420D Loop_2420D { get; set; }
        [G(5)]
        public Loop_2420E Loop_2420E { get; set; }
        [G(6)]
        public List<Loop_2420F> Loop_2420F { get; set; }
        [G(7)]
        public Loop_2420G Loop_2420G { get; set; }
        [G(8)]
        public Loop_2420H Loop_2420H { get; set; }
    }
    
    public class Loop_2420H
    {
        
        [S("NM1", 1)]
        public NM1_AmbulanceDrop_offLocation_2 NM1_AmbulanceDrop_offLocation_2 { get; set; }
        [S("N3", 2)]
        public N3_AmbulanceDrop_offLocationAddress_2 N3_AmbulanceDrop_offLocationAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode_2 N4_AmbulanceDrop_offLocationCity_State_ZipCode_2 { get; set; }
    }
    
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode_2
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulanceDrop_offLocationAddress_2
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulanceDrop_offLocation_2
    {
        
        [D(1, typeof(X12_ID_98_14), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string AmbulanceDropoffLocation_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420G
    {
        
        [S("NM1", 1)]
        public NM1_AmbulancePick_upLocation_2 NM1_AmbulancePick_upLocation_2 { get; set; }
        [S("N3", 2)]
        public N3_AmbulancePick_upLocationAddress_2 N3_AmbulancePick_upLocationAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode_2 N4_AmbulancePick_upLocationCity_State_ZipCode_2 { get; set; }
    }
    
    public class N4_AmbulancePick_upLocationCity_State_ZipCode_2
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string AmbulancePickupCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulancePick_upLocationAddress_2
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulancePick_upLocation_2
    {
        
        [D(1, typeof(X12_ID_98_13), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420F
    {
        
        [S("NM1", 1)]
        public NM1_ReferringProviderName_2 NM1_ReferringProviderName_2 { get; set; }
        [S("REF", 2)]
        public List<REF_ReferringProviderSecondaryIdentification_2> REF_ReferringProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_ReferringProviderSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_25), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_53 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_53
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_ReferringProviderName_2
    {
        
        [D(1, typeof(X12_ID_98_9), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420E
    {
        
        [S("NM1", 1)]
        public NM1_OrderingProviderName NM1_OrderingProviderName { get; set; }
        [S("N3", 2)]
        public N3_OrderingProviderAddress N3_OrderingProviderAddress { get; set; }
        [S("N4", 3)]
        public N4_OrderingProviderCity_State_ZIPCode N4_OrderingProviderCity_State_ZIPCode { get; set; }
        [S("REF", 4)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_OrderingProviderSecondaryIdentification { get; set; }
        [S("PER", 5)]
        public PER_OrderingProviderContactInformation PER_OrderingProviderContactInformation { get; set; }
    }
    
    public class PER_OrderingProviderContactInformation
    {
        
        [D(1, typeof(X12_ID_366), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN), "93")]
        public string OrderingProviderContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_2), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_2), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN), "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN), "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class REF_OrderingProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_25), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OrderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_52 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_52
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_OrderingProviderCity_State_ZIPCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string OrderingProviderCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string OrderingProviderStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string OrderingProviderPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OrderingProviderAddress
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string OrderingProviderAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string OrderingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_OrderingProviderName
    {
        
        [D(1, typeof(X12_ID_98_16), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string OrderingProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string OrderingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string OrderingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string OrderingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string OrderingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420D
    {
        
        [S("NM1", 1)]
        public NM1_SupervisingProviderName_2 NM1_SupervisingProviderName_2 { get; set; }
        [S("REF", 2)]
        public List<REF_SupervisingProviderSecondaryIdentification_2> REF_SupervisingProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_SupervisingProviderSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_51 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_51
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_SupervisingProviderName_2
    {
        
        [D(1, typeof(X12_ID_98_12), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420C
    {
        
        [S("NM1", 1)]
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocation { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress_2 N3_ServiceFacilityLocationAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode_2 N4_ServiceFacilityLocationCity_State_ZIPCode_2 { get; set; }
        [S("REF", 4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_2> REF_ServiceFacilityLocationSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_10), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_50 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_50
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_ServiceFacilityLocationCity_State_ZIPCode_2
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress_2
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocation
    {
        
        [D(1, typeof(X12_ID_98_11), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string LaboratoryorFacilityName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420B
    {
        
        [S("NM1", 1)]
        public NM1_PurchasedServiceProviderName NM1_PurchasedServiceProviderName { get; set; }
        [S("REF", 2)]
        public List<REF_PurchasedServiceProviderSecondaryIdentification> REF_PurchasedServiceProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_PurchasedServiceProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_25), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_49 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_49
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_PurchasedServiceProviderName
    {
        
        [D(1, typeof(X12_ID_98_15), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420A
    {
        
        [S("NM1", 1)]
        public NM1_RenderingProviderName_2 NM1_RenderingProviderName_2 { get; set; }
        [S("PRV", 2)]
        public PRV_RenderingProviderSpecialtyInformation_2 PRV_RenderingProviderSpecialtyInformation_2 { get; set; }
        [S("REF", 3)]
        public List<REF_RenderingProviderSecondaryIdentification_2> REF_RenderingProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_RenderingProviderSecondaryIdentification_2
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_48 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_48
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class PRV_RenderingProviderSpecialtyInformation_2
    {
        
        [D(1, typeof(X12_ID_1221_2), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128), "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, typeof(X12_ID), "156")]
        public string StateorProvinceCode_04 { get; set; }
        [C(5)]
        public C035_ProviderSpecialtyInformation_3 ProviderSpecialtyInformation_05 { get; set; }
        [D(6, typeof(X12_ID_1223), "1223")]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    public class C035_ProviderSpecialtyInformation_3
    {
        
        [D(1, typeof(X12_ID_1222), "1222")]
        public string ProviderSpecialtyCode_01 { get; set; }
        [D(2, typeof(X12_ID_559), "559")]
        public string AgencyQualifierCode_02 { get; set; }
        [D(3, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public class NM1_RenderingProviderName_2
    {
        
        [D(1, typeof(X12_ID_98_10), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string RenderingProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2410
    {
        
        [S("LIN", 1)]
        public LIN_DrugIdentification LIN_DrugIdentification { get; set; }
        [S("CTP", 2)]
        public CTP_DrugQuantity CTP_DrugQuantity { get; set; }
        [S("REF", 3)]
        public REF_PrescriptionorCompoundDrugAssociationNumber REF_PrescriptionorCompoundDrugAssociationNumber { get; set; }
    }
    
    public class REF_PrescriptionorCompoundDrugAssociationNumber
    {
        
        [D(1, typeof(X12_ID_128_35), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PrescriptionNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_47 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_47
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class CTP_DrugQuantity
    {
        
        [D(1, typeof(X12_ID_687), "687")]
        public string ClassofTradeCode_01 { get; set; }
        [D(2, typeof(X12_ID_236), "236")]
        public string PriceIdentifierCode_02 { get; set; }
        [D(3, typeof(X12_R), "212")]
        public string UnitPrice_03 { get; set; }
        [D(4, typeof(X12_R), "380")]
        public string NationalDrugUnitCount_04 { get; set; }
        [C(5)]
        public C001_CompositeUnitofMeasure_6 CompositeUnitofMeasure_05 { get; set; }
        [D(6, typeof(X12_ID_648), "648")]
        public string PriceMultiplierQualifier_06 { get; set; }
        [D(7, typeof(X12_R), "649")]
        public string Multiplier_07 { get; set; }
        [D(8, typeof(X12_R), "782")]
        public string MonetaryAmount_08 { get; set; }
        [D(9, typeof(X12_ID_639), "639")]
        public string BasisofUnitPriceCode_09 { get; set; }
        [D(10, typeof(X12_AN), "499")]
        public string ConditionValue_10 { get; set; }
        [D(11, typeof(X12_N0), "289")]
        public string MultiplePriceQuantity_11 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_6
    {
        
        [D(1, typeof(X12_ID_355_8), "355")]
        public string CodeQualifier_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class LIN_DrugIdentification
    {
        
        [D(1, typeof(X12_AN), "350")]
        public string AssignedIdentification_01 { get; set; }
        [D(2, typeof(X12_ID_235_4), "235")]
        public string ProductorServiceIDQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "234")]
        public string NationalDrugCodeorUniversalProductNumber_03 { get; set; }
        [D(4, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_04 { get; set; }
        [D(5, typeof(X12_AN), "234")]
        public string ProductServiceID_05 { get; set; }
        [D(6, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_06 { get; set; }
        [D(7, typeof(X12_AN), "234")]
        public string ProductServiceID_07 { get; set; }
        [D(8, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "234")]
        public string ProductServiceID_09 { get; set; }
        [D(10, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_10 { get; set; }
        [D(11, typeof(X12_AN), "234")]
        public string ProductServiceID_11 { get; set; }
        [D(12, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_12 { get; set; }
        [D(13, typeof(X12_AN), "234")]
        public string ProductServiceID_13 { get; set; }
        [D(14, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_14 { get; set; }
        [D(15, typeof(X12_AN), "234")]
        public string ProductServiceID_15 { get; set; }
        [D(16, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_16 { get; set; }
        [D(17, typeof(X12_AN), "234")]
        public string ProductServiceID_17 { get; set; }
        [D(18, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_18 { get; set; }
        [D(19, typeof(X12_AN), "234")]
        public string ProductServiceID_19 { get; set; }
        [D(20, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_20 { get; set; }
        [D(21, typeof(X12_AN), "234")]
        public string ProductServiceID_21 { get; set; }
        [D(22, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_22 { get; set; }
        [D(23, typeof(X12_AN), "234")]
        public string ProductServiceID_23 { get; set; }
        [D(24, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_24 { get; set; }
        [D(25, typeof(X12_AN), "234")]
        public string ProductServiceID_25 { get; set; }
        [D(26, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_26 { get; set; }
        [D(27, typeof(X12_AN), "234")]
        public string ProductServiceID_27 { get; set; }
        [D(28, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_28 { get; set; }
        [D(29, typeof(X12_AN), "234")]
        public string ProductServiceID_29 { get; set; }
        [D(30, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_30 { get; set; }
        [D(31, typeof(X12_AN), "234")]
        public string ProductServiceID_31 { get; set; }
    }
    
    public class HCP_LinePricing_RepricingInformation
    {
        
        [D(1, typeof(X12_ID_1473_2), "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3, typeof(X12_R), "782")]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5, typeof(X12_R), "118")]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7, typeof(X12_R), "782")]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8, typeof(X12_AN), "234")]
        public string ProductServiceID_08 { get; set; }
        [D(9, typeof(X12_ID_235_2), "235")]
        public string ProductorServiceIDQualifier_09 { get; set; }
        [D(10, typeof(X12_AN), "234")]
        public string RepricedApprovedHCPCSCode_10 { get; set; }
        [D(11, typeof(X12_ID_355_5), "355")]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [D(12, typeof(X12_R), "380")]
        public string RepricedApprovedServiceUnitCount_12 { get; set; }
        [D(13, typeof(X12_ID_901), "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, typeof(X12_ID_1526), "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, typeof(X12_ID_1527), "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class PS1_PurchasedServiceInformation
    {
        
        [D(1, typeof(X12_AN), "127")]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID), "156")]
        public string StateorProvinceCode_03 { get; set; }
    }
    
    public class All_NTE
    {
        
        [S("NTE", 1)]
        public NTE_LineNote NTE_LineNote { get; set; }
        [S("NTE", 2)]
        public NTE_ThirdPartyOrganizationNotes NTE_ThirdPartyOrganizationNotes { get; set; }
    }
    
    public class NTE_ThirdPartyOrganizationNotes
    {
        
        [D(1, typeof(X12_ID_363_3), "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, typeof(X12_AN), "352")]
        public string LineNoteText_02 { get; set; }
    }
    
    public class NTE_LineNote
    {
        
        [D(1, typeof(X12_ID_363_2), "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, typeof(X12_AN), "352")]
        public string LineNoteText_02 { get; set; }
    }
    
    public class K3_FileInformation_2
    {
        
        [D(1, typeof(X12_AN), "449")]
        public string FixedFormatInformation_01 { get; set; }
        [D(2, typeof(X12_ID_1333), "1333")]
        public string RecordFormatCode_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_5 CompositeUnitofMeasure_03 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_5
    {
        
        [D(1, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_AMT_2
    {
        
        [S("AMT", 1)]
        public AMT_SalesTaxAmount AMT_SalesTaxAmount { get; set; }
        [S("AMT", 2)]
        public AMT_PostageClaimedAmount AMT_PostageClaimedAmount { get; set; }
    }
    
    public class AMT_PostageClaimedAmount
    {
        
        [D(1, typeof(X12_ID_522_6), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string PostageClaimedAmount_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class AMT_SalesTaxAmount
    {
        
        [D(1, typeof(X12_ID_522_5), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string SalesTaxAmount_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class All_REF_7
    {
        
        [S("REF", 1)]
        public REF_RepricedLineItemReferenceNumber REF_RepricedLineItemReferenceNumber { get; set; }
        [S("REF", 2)]
        public REF_AdjustedRepricedLineItemReferenceNumber REF_AdjustedRepricedLineItemReferenceNumber { get; set; }
        [S("REF", 3)]
        public List<REF_PriorAuthorization_2> REF_PriorAuthorization_2 { get; set; }
        [S("REF", 4)]
        public REF_LineItemControlNumber REF_LineItemControlNumber { get; set; }
        [S("REF", 5)]
        public REF_MammographyCertificationNumber_2 REF_MammographyCertificationNumber_2 { get; set; }
        [S("REF", 6)]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2 REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2 { get; set; }
        [S("REF", 7)]
        public REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification { get; set; }
        [S("REF", 8)]
        public REF_ImmunizationBatchNumber REF_ImmunizationBatchNumber { get; set; }
        [S("REF", 9)]
        public List<REF_ReferralNumber_2> REF_ReferralNumber_2 { get; set; }
    }
    
    public class REF_ReferralNumber_2
    {
        
        [D(1, typeof(X12_ID_128_14), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_46 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_46
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ImmunizationBatchNumber
    {
        
        [D(1, typeof(X12_ID_128_34), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ImmunizationBatchNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_45 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_45
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification
    {
        
        [D(1, typeof(X12_ID_128_33), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferringCLIANumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_44 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_44
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2
    {
        
        [D(1, typeof(X12_ID_128_17), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_43 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_43
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MammographyCertificationNumber_2
    {
        
        [D(1, typeof(X12_ID_128_13), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_42 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_42
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_LineItemControlNumber
    {
        
        [D(1, typeof(X12_ID_128_32), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string LineItemControlNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_41 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_41
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PriorAuthorization_2
    {
        
        [D(1, typeof(X12_ID_128_15), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PriorAuthorizationorReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_40 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_40
    {
        
        [D(1, typeof(X12_ID_128_31), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_AdjustedRepricedLineItemReferenceNumber
    {
        
        [D(1, typeof(X12_ID_128_30), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string AdjustedRepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_39 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_39
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_RepricedLineItemReferenceNumber
    {
        
        [D(1, typeof(X12_ID_128_29), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string RepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_38 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_38
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class CN1_ContractInformation_2
    {
        
        [D(1, typeof(X12_ID_1166), "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string ContractAmount_02 { get; set; }
        [D(3, typeof(X12_R), "332")]
        public string ContractPercentage_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ContractCode_04 { get; set; }
        [D(5, typeof(X12_R), "338")]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6, typeof(X12_AN), "799")]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class MEA_TestResult
    {
        
        [D(1, typeof(X12_ID_737), "737")]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        [D(2, typeof(X12_ID_738), "738")]
        public string MeasurementQualifier_02 { get; set; }
        [D(3, typeof(X12_R), "739")]
        public string TestResults_03 { get; set; }
        [C(4)]
        public C001_CompositeUnitofMeasure_4 CompositeUnitofMeasure_04 { get; set; }
        [D(5, typeof(X12_R), "740")]
        public string RangeMinimum_05 { get; set; }
        [D(6, typeof(X12_R), "741")]
        public string RangeMaximum_06 { get; set; }
        [D(7, typeof(X12_ID_935), "935")]
        public string MeasurementSignificanceCode_07 { get; set; }
        [D(8, typeof(X12_ID_936), "936")]
        public string MeasurementAttributeCode_08 { get; set; }
        [D(9, typeof(X12_ID_752), "752")]
        public string SurfaceLayerPositionCode_09 { get; set; }
        [D(10, typeof(X12_ID_1373), "1373")]
        public string MeasurementMethodorDevice_10 { get; set; }
        [D(11, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1271")]
        public string IndustryCode_12 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_4
    {
        
        [D(1, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_QTY
    {
        
        [S("QTY", 1)]
        public QTY_AmbulancePatientCount QTY_AmbulancePatientCount { get; set; }
        [S("QTY", 2)]
        public QTY_ObstetricAnesthesiaAdditionalUnits QTY_ObstetricAnesthesiaAdditionalUnits { get; set; }
    }
    
    public class QTY_ObstetricAnesthesiaAdditionalUnits
    {
        
        [D(1, typeof(X12_ID_673_2), "673")]
        public string QuantityQualifier_01 { get; set; }
        [D(2, typeof(X12_R), "380")]
        public string ObstetricAdditionalUnits_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_3 CompositeUnitofMeasure_03 { get; set; }
        [D(4, typeof(X12_AN), "61")]
        public string FreeformInformation_04 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_3
    {
        
        [D(1, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class QTY_AmbulancePatientCount
    {
        
        [D(1, typeof(X12_ID_673), "673")]
        public string QuantityQualifier_01 { get; set; }
        [D(2, typeof(X12_R), "380")]
        public string AmbulancePatientCount_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_2 CompositeUnitofMeasure_03 { get; set; }
        [D(4, typeof(X12_AN), "61")]
        public string FreeformInformation_04 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_2
    {
        
        [D(1, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_DTP_2
    {
        
        [S("DTP", 1)]
        public DTP_Date_ServiceDate DTP_Date_ServiceDate { get; set; }
        [S("DTP", 2)]
        public DTP_Date_PrescriptionDate DTP_Date_PrescriptionDate { get; set; }
        [S("DTP", 3)]
        public DTP_DATE_CertificationRevision_RecertificationDate DTP_DATE_CertificationRevision_RecertificationDate { get; set; }
        [S("DTP", 4)]
        public DTP_Date_BeginTherapyDate DTP_Date_BeginTherapyDate { get; set; }
        [S("DTP", 5)]
        public DTP_Date_LastCertificationDate DTP_Date_LastCertificationDate { get; set; }
        [S("DTP", 6)]
        public DTP_Date_LastSeenDate_2 DTP_Date_LastSeenDate_2 { get; set; }
        [S("DTP", 7)]
        public List<DTP_Date_TestDate> DTP_Date_TestDate { get; set; }
        [S("DTP", 8)]
        public DTP_Date_ShippedDate DTP_Date_ShippedDate { get; set; }
        [S("DTP", 9)]
        public DTP_Date_LastX_rayDate_2 DTP_Date_LastX_rayDate_2 { get; set; }
        [S("DTP", 10)]
        public DTP_Date_InitialTreatmentDate_2 DTP_Date_InitialTreatmentDate_2 { get; set; }
    }
    
    public class DTP_Date_InitialTreatmentDate_2
    {
        
        [D(1, typeof(X12_ID_374_3), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class DTP_Date_LastX_rayDate_2
    {
        
        [D(1, typeof(X12_ID_374_8), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class DTP_Date_ShippedDate
    {
        
        [D(1, typeof(X12_ID_374_24), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string ShippedDate_03 { get; set; }
    }
    
    public class DTP_Date_TestDate
    {
        
        [D(1, typeof(X12_ID_374_23), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string TestPerformedDate_03 { get; set; }
    }
    
    public class DTP_Date_LastSeenDate_2
    {
        
        [D(1, typeof(X12_ID_374_4), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string TreatmentorTherapyDate_03 { get; set; }
    }
    
    public class DTP_Date_LastCertificationDate
    {
        
        [D(1, typeof(X12_ID_374_22), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastCertificationDate_03 { get; set; }
    }
    
    public class DTP_Date_BeginTherapyDate
    {
        
        [D(1, typeof(X12_ID_374_21), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string BeginTherapyDate_03 { get; set; }
    }
    
    public class DTP_DATE_CertificationRevision_RecertificationDate
    {
        
        [D(1, typeof(X12_ID_374_20), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string CertificationRevisionorRecertificationDate_03 { get; set; }
    }
    
    public class DTP_Date_PrescriptionDate
    {
        
        [D(1, typeof(X12_ID_374_9), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string PrescriptionDate_03 { get; set; }
    }
    
    public class DTP_Date_ServiceDate
    {
        
        [D(1, typeof(X12_ID_374_19), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_2), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string ServiceDate_03 { get; set; }
    }
    
    public class All_CRC_2
    {
        
        [S("CRC", 1)]
        public List<CRC_AmbulanceCertification_2> CRC_AmbulanceCertification_2 { get; set; }
        [S("CRC", 2)]
        public CRC_HospiceEmployeeIndicator CRC_HospiceEmployeeIndicator { get; set; }
        [S("CRC", 3)]
        public CRC_ConditionIndicator_DurableMedicalEquipment CRC_ConditionIndicator_DurableMedicalEquipment { get; set; }
    }
    
    public class CRC_ConditionIndicator_DurableMedicalEquipment
    {
        
        [D(1, typeof(X12_ID_1136_6), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_7), "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1321_7), "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_HospiceEmployeeIndicator
    {
        
        [D(1, typeof(X12_ID_1136_5), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string HospiceEmployedProviderIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_6), "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_AmbulanceCertification_2
    {
        
        [D(1, typeof(X12_ID_1136), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class CR3_DurableMedicalEquipmentCertification
    {
        
        [D(1, typeof(X12_ID_1322), "1322")]
        public string CertificationTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_355_7), "355")]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [D(3, typeof(X12_R), "380")]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        [D(4, typeof(X12_ID_1335), "1335")]
        public string InsulinDependentCode_04 { get; set; }
        [D(5, typeof(X12_AN), "352")]
        public string Description_05 { get; set; }
    }
    
    public class CR1_AmbulanceTransportInformation_2
    {
        
        [D(1, typeof(X12_ID_355_3), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "81")]
        public string PatientWeight_02 { get; set; }
        [D(3, typeof(X12_ID_1316), "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, typeof(X12_ID_1317), "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, typeof(X12_ID_355_4), "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string TransportDistance_06 { get; set; }
        [D(7, typeof(X12_AN), "166")]
        public string AddressInformation_07 { get; set; }
        [D(8, typeof(X12_AN), "166")]
        public string AddressInformation_08 { get; set; }
        [D(9, typeof(X12_AN), "352")]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10, typeof(X12_AN), "352")]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class All_PWK
    {
        
        [S("PWK", 1)]
        public List<PWK_LineSupplementalInformation> PWK_LineSupplementalInformation { get; set; }
        [S("PWK", 2)]
        public PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator { get; set; }
    }
    
    public class PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator
    {
        
        [D(1, typeof(X12_ID_755_3), "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_756_2), "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, typeof(X12_N0), "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "67")]
        public string IdentificationCode_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated_3 ActionsIndicated_08 { get; set; }
        [D(9, typeof(X12_ID_1525), "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class C002_ActionsIndicated_3
    {
        
        [D(1, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class PWK_LineSupplementalInformation
    {
        
        [D(1, typeof(X12_ID_755_2), "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_756), "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, typeof(X12_N0), "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, typeof(X12_ID_66_6), "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "67")]
        public string AttachmentControlNumber_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated_2 ActionsIndicated_08 { get; set; }
        [D(9, typeof(X12_ID_1525), "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class C002_ActionsIndicated_2
    {
        
        [D(1, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class SV5_DurableMedicalEquipmentService
    {
        
        [C(1)]
        public C003_CompositeMedicalProcedureIdentifier_2 CompositeMedicalProcedureIdentifier_01 { get; set; }
        [D(2, typeof(X12_ID_355_6), "355")]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [D(3, typeof(X12_R), "380")]
        public string LengthofMedicalNecessity_03 { get; set; }
        [D(4, typeof(X12_R), "782")]
        public string DMERentalPrice_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string DMEPurchasePrice_05 { get; set; }
        [D(6, typeof(X12_ID_594), "594")]
        public string RentalUnitPriceIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_923), "923")]
        public string PrognosisCode_07 { get; set; }
    }
    
    public class C003_CompositeMedicalProcedureIdentifier_2
    {
        
        [D(1, typeof(X12_ID_235_3), "235")]
        public string ProcedureIdentifier_01 { get; set; }
        [D(2, typeof(X12_AN), "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, typeof(X12_AN), "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, typeof(X12_AN), "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, typeof(X12_AN), "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string Description_07 { get; set; }
        [D(8, typeof(X12_AN), "234")]
        public string ProductServiceID_08 { get; set; }
    }
    
    public class SV1_ProfessionalService
    {
        
        [C(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string LineItemChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID_355_5), "355")]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        [D(4, typeof(X12_R), "380")]
        public string ServiceUnitCount_04 { get; set; }
        [D(5, typeof(X12_AN), "1331")]
        public string PlaceofServiceCode_05 { get; set; }
        [D(6, typeof(X12_ID_1365), "1365")]
        public string ServiceTypeCode_06 { get; set; }
        [C(7)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_07 { get; set; }
        [D(8, typeof(X12_R), "782")]
        public string MonetaryAmount_08 { get; set; }
        [D(9, typeof(X12_ID_1073_2), "1073")]
        public string EmergencyIndicator_09 { get; set; }
        [D(10, typeof(X12_ID_1340), "1340")]
        public string MultipleProcedureCode_10 { get; set; }
        [D(11, typeof(X12_ID_1073_2), "1073")]
        public string EPSDTIndicator_11 { get; set; }
        [D(12, typeof(X12_ID_1073_2), "1073")]
        public string FamilyPlanningIndicator_12 { get; set; }
        [D(13, typeof(X12_ID_1364), "1364")]
        public string ReviewCode_13 { get; set; }
        [D(14, typeof(X12_AN), "1341")]
        public string NationalorLocalAssignedReviewValue_14 { get; set; }
        [D(15, typeof(X12_ID_1327), "1327")]
        public string CoPayStatusCode_15 { get; set; }
        [D(16, typeof(X12_ID), "1334")]
        public string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        [D(17, typeof(X12_AN), "127")]
        public string ReferenceIdentification_17 { get; set; }
        [D(18, typeof(X12_ID), "116")]
        public string PostalCode_18 { get; set; }
        [D(19, typeof(X12_R), "782")]
        public string MonetaryAmount_19 { get; set; }
        [D(20, typeof(X12_ID_1337), "1337")]
        public string LevelofCareCode_20 { get; set; }
        [D(21, typeof(X12_ID_1360), "1360")]
        public string ProviderAgreementCode_21 { get; set; }
    }
    
    public class C004_CompositeDiagnosisCodePointer
    {
        
        [D(1, typeof(X12_N0), "1328")]
        public string DiagnosisCodePointer_01 { get; set; }
        [D(2, typeof(X12_N0), "1328")]
        public string DiagnosisCodePointer_02 { get; set; }
        [D(3, typeof(X12_N0), "1328")]
        public string DiagnosisCodePointer_03 { get; set; }
        [D(4, typeof(X12_N0), "1328")]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    public class C003_CompositeMedicalProcedureIdentifier
    {
        
        [D(1, typeof(X12_ID_235_2), "235")]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, typeof(X12_AN), "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, typeof(X12_AN), "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, typeof(X12_AN), "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string Description_07 { get; set; }
        [D(8, typeof(X12_AN), "234")]
        public string ProductServiceID_08 { get; set; }
    }
    
    public class LX_ServiceLineNumber
    {
        
        [D(1, typeof(X12_N0), "554")]
        public string AssignedNumber_01 { get; set; }
    }
    
    public class Loop_2320
    {
        
        [S("SBR", 1)]
        public SBR_OtherSubscriberInformation SBR_OtherSubscriberInformation { get; set; }
        [S("CAS", 2)]
        public List<CAS_ClaimLevelAdjustments> CAS_ClaimLevelAdjustments { get; set; }
        [A(3)]
        public All_AMT All_AMT { get; set; }
        [S("OI", 4)]
        public OI_OtherInsuranceCoverageInformation OI_OtherInsuranceCoverageInformation { get; set; }
        [S("MOA", 5)]
        public MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation { get; set; }
        [A(6)]
        public All_NM1_5 All_NM1_5 { get; set; }
    }
    
    public class All_NM1_5
    {
        
        [G(1)]
        public Loop_2330A Loop_2330A { get; set; }
        [G(2)]
        public Loop_2330B Loop_2330B { get; set; }
        [G(3)]
        public List<Loop_2330C> Loop_2330C { get; set; }
        [G(4)]
        public Loop_2330D Loop_2330D { get; set; }
        [G(5)]
        public Loop_2330E Loop_2330E { get; set; }
        [G(6)]
        public Loop_2330F Loop_2330F { get; set; }
        [G(7)]
        public Loop_2330G Loop_2330G { get; set; }
    }
    
    public class Loop_2330G
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerBillingProvider NM1_OtherPayerBillingProvider { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerBillingProviderSecondaryIdentification> REF_OtherPayerBillingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherPayerBillingProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_10), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerBillingProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_37 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_37
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerBillingProvider
    {
        
        [D(1, typeof(X12_ID_98_4), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330F
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerSupervisingProvider NM1_OtherPayerSupervisingProvider { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerSupervisingProviderSecondaryIdentification> REF_OtherPayerSupervisingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherPayerSupervisingProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerSupervisingProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_36 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_36
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerSupervisingProvider
    {
        
        [D(1, typeof(X12_ID_98_12), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330E
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerServiceFacilityLocation NM1_OtherPayerServiceFacilityLocation { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_OtherPayerServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherPayerServiceFacilityLocationSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_27), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_35 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_35
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerServiceFacilityLocation
    {
        
        [D(1, typeof(X12_ID_98_11), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330D
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProvider { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerRenderingProviderSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherPayerRenderingProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerRenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_34 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_34
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerRenderingProvider
    {
        
        [D(1, typeof(X12_ID_98_10), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330C
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerReferringProvider NM1_OtherPayerReferringProvider { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerReferringProviderSecondaryIdentification> REF_OtherPayerReferringProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherPayerReferringProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_25), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerReferringProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_33 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_33
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerReferringProvider
    {
        
        [D(1, typeof(X12_ID_98_9), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330B
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerName NM1_OtherPayerName { get; set; }
        [S("N3", 2)]
        public N3_OtherPayerAddress N3_OtherPayerAddress { get; set; }
        [S("N4", 3)]
        public N4_OtherPayerCity_State_ZIPCode N4_OtherPayerCity_State_ZIPCode { get; set; }
        [S("DTP", 4)]
        public DTP_ClaimCheckorRemittanceDate DTP_ClaimCheckorRemittanceDate { get; set; }
        [A(5)]
        public All_REF_6 All_REF_6 { get; set; }
    }
    
    public class All_REF_6
    {
        
        [S("REF", 1)]
        public List<REF_OtherPayerSecondaryIdentifier> REF_OtherPayerSecondaryIdentifier { get; set; }
        [S("REF", 2)]
        public REF_OtherPayerPriorAuthorizationNumber REF_OtherPayerPriorAuthorizationNumber { get; set; }
        [S("REF", 3)]
        public REF_OtherPayerReferralNumber REF_OtherPayerReferralNumber { get; set; }
        [S("REF", 4)]
        public REF_OtherPayerClaimAdjustmentIndicator REF_OtherPayerClaimAdjustmentIndicator { get; set; }
        [S("REF", 5)]
        public REF_OtherPayerClaimControlNumber REF_OtherPayerClaimControlNumber { get; set; }
    }
    
    public class REF_OtherPayerClaimControlNumber
    {
        
        [D(1, typeof(X12_ID_128_16), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayersClaimControlNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_32 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_32
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerClaimAdjustmentIndicator
    {
        
        [D(1, typeof(X12_ID_128_28), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerClaimAdjustmentIndicator_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_31 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_31
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerReferralNumber
    {
        
        [D(1, typeof(X12_ID_128_14), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPriorAuthorizationorReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_30 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_30
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerPriorAuthorizationNumber
    {
        
        [D(1, typeof(X12_ID_128_15), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerPriorAuthorizationNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_29 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_29
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerSecondaryIdentifier
    {
        
        [D(1, typeof(X12_ID_128_9), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherPayerSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_28 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_28
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class DTP_ClaimCheckorRemittanceDate
    {
        
        [D(1, typeof(X12_ID_374_18), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    public class N4_OtherPayerCity_State_ZIPCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string OtherPayerCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string OtherPayerStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string OtherPayerPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OtherPayerAddress
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string OtherPayerAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string OtherPayerAddressLine_02 { get; set; }
    }
    
    public class NM1_OtherPayerName
    {
        
        [D(1, typeof(X12_ID_98_8), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string OtherPayerOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_4), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string OtherPayerPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330A
    {
        
        [S("NM1", 1)]
        public NM1_OtherSubscriberName NM1_OtherSubscriberName { get; set; }
        [S("N3", 2)]
        public N3_OtherSubscriberAddress N3_OtherSubscriberAddress { get; set; }
        [S("N4", 3)]
        public N4_OtherSubscriberCity_State_ZIPCode N4_OtherSubscriberCity_State_ZIPCode { get; set; }
        [S("REF", 4)]
        public REF_OtherSubscriberSecondaryIdentification REF_OtherSubscriberSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherSubscriberSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_7), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string OtherInsuredAdditionalIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_27 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_27
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_OtherSubscriberCity_State_ZIPCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string OtherSubscriberCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string OtherSubscriberStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string OtherSubscriberPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OtherSubscriberAddress
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string OtherInsuredAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string OtherInsuredAddressLine_02 { get; set; }
    }
    
    public class NM1_OtherSubscriberName
    {
        
        [D(1, typeof(X12_ID_98_7), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string OtherInsuredLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string OtherInsuredFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string OtherInsuredMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string OtherInsuredNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_5), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string OtherInsuredIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class MOA_OutpatientAdjudicationInformation
    {
        
        [D(1, typeof(X12_R), "954")]
        public string ReimbursementRate_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string HCPCSPayableAmount_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string ClaimPaymentRemarkCode_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ClaimPaymentRemarkCode_04 { get; set; }
        [D(5, typeof(X12_AN), "127")]
        public string ClaimPaymentRemarkCode_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ClaimPaymentRemarkCode_06 { get; set; }
        [D(7, typeof(X12_AN), "127")]
        public string ClaimPaymentRemarkCode_07 { get; set; }
        [D(8, typeof(X12_R), "782")]
        public string EndStageRenalDiseasePaymentAmount_08 { get; set; }
        [D(9, typeof(X12_R), "782")]
        public string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    public class OI_OtherInsuranceCoverageInformation
    {
        
        [D(1, typeof(X12_ID_1032_2), "1032")]
        public string ClaimFilingIndicatorCode_01 { get; set; }
        [D(2, typeof(X12_ID_1383), "1383")]
        public string ClaimSubmissionReasonCode_02 { get; set; }
        [D(3, typeof(X12_ID_1073_4), "1073")]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1351), "1351")]
        public string PatientSignatureSourceCode_04 { get; set; }
        [D(5, typeof(X12_ID_1360), "1360")]
        public string ProviderAgreementCode_05 { get; set; }
        [D(6, typeof(X12_ID_1363), "1363")]
        public string ReleaseofInformationCode_06 { get; set; }
    }
    
    public class All_AMT
    {
        
        [S("AMT", 1)]
        public AMT_CoordinationofBenefits_COB_PayerPaidAmount AMT_CoordinationofBenefits_COB_PayerPaidAmount { get; set; }
        [S("AMT", 2)]
        public AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount { get; set; }
        [S("AMT", 3)]
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability { get; set; }
    }
    
    public class AMT_RemainingPatientLiability
    {
        
        [D(1, typeof(X12_ID_522_4), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string RemainingPatientLiability_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount
    {
        
        [D(1, typeof(X12_ID_522_3), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string NonCoveredChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class AMT_CoordinationofBenefits_COB_PayerPaidAmount
    {
        
        [D(1, typeof(X12_ID_522_2), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string PayerPaidAmount_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class CAS_ClaimLevelAdjustments
    {
        
        [D(1, typeof(X12_ID_1033), "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3, typeof(X12_R), "782")]
        public string AdjustmentAmount_03 { get; set; }
        [D(4, typeof(X12_R), "380")]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6, typeof(X12_R), "782")]
        public string AdjustmentAmount_06 { get; set; }
        [D(7, typeof(X12_R), "380")]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9, typeof(X12_R), "782")]
        public string AdjustmentAmount_09 { get; set; }
        [D(10, typeof(X12_R), "380")]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12, typeof(X12_R), "782")]
        public string AdjustmentAmount_12 { get; set; }
        [D(13, typeof(X12_R), "380")]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15, typeof(X12_R), "782")]
        public string AdjustmentAmount_15 { get; set; }
        [D(16, typeof(X12_R), "380")]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17, typeof(X12_ID), "1034")]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18, typeof(X12_R), "782")]
        public string AdjustmentAmount_18 { get; set; }
        [D(19, typeof(X12_R), "380")]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class SBR_OtherSubscriberInformation
    {
        
        [D(1, typeof(X12_ID_1138), "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, typeof(X12_ID_1069_3), "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string InsuredGrouporPolicyNumber_03 { get; set; }
        [D(4, typeof(X12_AN), "93")]
        public string OtherInsuredGroupName_04 { get; set; }
        [D(5, typeof(X12_ID_1336), "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6, typeof(X12_ID_1143), "1143")]
        public string CoordinationofBenefitsCode_06 { get; set; }
        [D(7, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_07 { get; set; }
        [D(8, typeof(X12_ID_584), "584")]
        public string EmploymentStatusCode_08 { get; set; }
        [D(9, typeof(X12_ID_1032), "1032")]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public class All_NM1_4
    {
        
        [G(1)]
        public List<Loop_2310A> Loop_2310A { get; set; }
        [G(2)]
        public Loop_2310B Loop_2310B { get; set; }
        [G(3)]
        public Loop_2310C Loop_2310C { get; set; }
        [G(4)]
        public Loop_2310D Loop_2310D { get; set; }
        [G(5)]
        public Loop_2310E Loop_2310E { get; set; }
        [G(6)]
        public Loop_2310F Loop_2310F { get; set; }
    }
    
    public class Loop_2310F
    {
        
        [S("NM1", 1)]
        public NM1_AmbulanceDrop_offLocation NM1_AmbulanceDrop_offLocation { get; set; }
        [S("N3", 2)]
        public N3_AmbulanceDrop_offLocationAddress N3_AmbulanceDrop_offLocationAddress { get; set; }
        [S("N4", 3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode N4_AmbulanceDrop_offLocationCity_State_ZipCode { get; set; }
    }
    
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulanceDrop_offLocationAddress
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulanceDrop_offLocation
    {
        
        [D(1, typeof(X12_ID_98_14), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string AmbulanceDropoffLocation_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310E
    {
        
        [S("NM1", 1)]
        public NM1_AmbulancePick_upLocation NM1_AmbulancePick_upLocation { get; set; }
        [S("N3", 2)]
        public N3_AmbulancePick_upLocationAddress N3_AmbulancePick_upLocationAddress { get; set; }
        [S("N4", 3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode N4_AmbulancePick_upLocationCity_State_ZipCode { get; set; }
    }
    
    public class N4_AmbulancePick_upLocationCity_State_ZipCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string AmbulancePickupCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulancePick_upLocationAddress
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulancePick_upLocation
    {
        
        [D(1, typeof(X12_ID_98_13), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310D
    {
        
        [S("NM1", 1)]
        public NM1_SupervisingProviderName NM1_SupervisingProviderName { get; set; }
        [S("REF", 2)]
        public List<REF_SupervisingProviderSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_SupervisingProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_26 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_26
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_SupervisingProviderName
    {
        
        [D(1, typeof(X12_ID_98_12), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310C
    {
        
        [S("NM1", 1)]
        public NM1_ServiceFacilityLocationName NM1_ServiceFacilityLocationName { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress N3_ServiceFacilityLocationAddress { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode N4_ServiceFacilityLocationCity_State_ZIPCode { get; set; }
        [S("REF", 4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
        [S("PER", 5)]
        public PER_ServiceFacilityContactInformation PER_ServiceFacilityContactInformation { get; set; }
    }
    
    public class PER_ServiceFacilityContactInformation
    {
        
        [D(1, typeof(X12_ID_366), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN), "93")]
        public string Name_02 { get; set; }
        [D(3, typeof(X12_ID_365_3), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_4), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_5), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN), "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN), "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_27), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string LaboratoryorFacilitySecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_25 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_25
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_ServiceFacilityLocationCity_State_ZIPCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocationName
    {
        
        [D(1, typeof(X12_ID_98_11), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string LaboratoryorFacilityName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310B
    {
        
        [S("NM1", 1)]
        public NM1_RenderingProviderName NM1_RenderingProviderName { get; set; }
        [S("PRV", 2)]
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation { get; set; }
        [S("REF", 3)]
        public List<REF_RenderingProviderSecondaryIdentification> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_RenderingProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_26), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_24 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_24
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class PRV_RenderingProviderSpecialtyInformation
    {
        
        [D(1, typeof(X12_ID_1221_2), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128), "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, typeof(X12_ID), "156")]
        public string StateorProvinceCode_04 { get; set; }
        [C(5)]
        public C035_ProviderSpecialtyInformation_2 ProviderSpecialtyInformation_05 { get; set; }
        [D(6, typeof(X12_ID_1223), "1223")]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    public class C035_ProviderSpecialtyInformation_2
    {
        
        [D(1, typeof(X12_ID_1222), "1222")]
        public string ProviderSpecialtyCode_01 { get; set; }
        [D(2, typeof(X12_ID_559), "559")]
        public string AgencyQualifierCode_02 { get; set; }
        [D(3, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public class NM1_RenderingProviderName
    {
        
        [D(1, typeof(X12_ID_98_10), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string RenderingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310A
    {
        
        [S("NM1", 1)]
        public NM1_ReferringProviderName NM1_ReferringProviderName { get; set; }
        [S("REF", 2)]
        public List<REF_ReferringProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_ReferringProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_25), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_23 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_23
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_ReferringProviderName
    {
        
        [D(1, typeof(X12_ID_98_9), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_3), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class HCP_ClaimPricing_RepricingInformation
    {
        
        [D(1, typeof(X12_ID_1473), "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3, typeof(X12_R), "782")]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5, typeof(X12_R), "118")]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7, typeof(X12_R), "782")]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8, typeof(X12_AN), "234")]
        public string ProductServiceID_08 { get; set; }
        [D(9, typeof(X12_ID_235), "235")]
        public string ProductServiceIDQualifier_09 { get; set; }
        [D(10, typeof(X12_AN), "234")]
        public string ProductServiceID_10 { get; set; }
        [D(11, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [D(12, typeof(X12_R), "380")]
        public string Quantity_12 { get; set; }
        [D(13, typeof(X12_ID_901), "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, typeof(X12_ID_1526), "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, typeof(X12_ID_1527), "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class All_HI
    {
        
        [S("HI", 1)]
        public HI_HealthCareDiagnosisCode HI_HealthCareDiagnosisCode { get; set; }
        [S("HI", 2)]
        public HI_AnesthesiaRelatedProcedure HI_AnesthesiaRelatedProcedure { get; set; }
        [S("HI", 3)]
        public List<HI_ConditionInformation> HI_ConditionInformation { get; set; }
    }
    
    public class HI_ConditionInformation
    {
        
        [C(1)]
        public C022_HealthCareCodeInformation_25 HealthCareCodeInformation_01 { get; set; }
        [C(2)]
        public C022_HealthCareCodeInformation_26 HealthCareCodeInformation_02 { get; set; }
        [C(3)]
        public C022_HealthCareCodeInformation_27 HealthCareCodeInformation_03 { get; set; }
        [C(4)]
        public C022_HealthCareCodeInformation_28 HealthCareCodeInformation_04 { get; set; }
        [C(5)]
        public C022_HealthCareCodeInformation_29 HealthCareCodeInformation_05 { get; set; }
        [C(6)]
        public C022_HealthCareCodeInformation_30 HealthCareCodeInformation_06 { get; set; }
        [C(7)]
        public C022_HealthCareCodeInformation_31 HealthCareCodeInformation_07 { get; set; }
        [C(8)]
        public C022_HealthCareCodeInformation_32 HealthCareCodeInformation_08 { get; set; }
        [C(9)]
        public C022_HealthCareCodeInformation_33 HealthCareCodeInformation_09 { get; set; }
        [C(10)]
        public C022_HealthCareCodeInformation_34 HealthCareCodeInformation_10 { get; set; }
        [C(11)]
        public C022_HealthCareCodeInformation_35 HealthCareCodeInformation_11 { get; set; }
        [C(12)]
        public C022_HealthCareCodeInformation_36 HealthCareCodeInformation_12 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_36
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_35
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_34
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_33
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_32
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_31
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_30
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_29
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_28
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_27
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_26
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_25
    {
        
        [D(1, typeof(X12_ID_1270_6), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class HI_AnesthesiaRelatedProcedure
    {
        
        [C(1)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_01 { get; set; }
        [C(2)]
        public C022_HealthCareCodeInformation_14 HealthCareCodeInformation_02 { get; set; }
        [C(3)]
        public C022_HealthCareCodeInformation_15 HealthCareCodeInformation_03 { get; set; }
        [C(4)]
        public C022_HealthCareCodeInformation_16 HealthCareCodeInformation_04 { get; set; }
        [C(5)]
        public C022_HealthCareCodeInformation_17 HealthCareCodeInformation_05 { get; set; }
        [C(6)]
        public C022_HealthCareCodeInformation_18 HealthCareCodeInformation_06 { get; set; }
        [C(7)]
        public C022_HealthCareCodeInformation_19 HealthCareCodeInformation_07 { get; set; }
        [C(8)]
        public C022_HealthCareCodeInformation_20 HealthCareCodeInformation_08 { get; set; }
        [C(9)]
        public C022_HealthCareCodeInformation_21 HealthCareCodeInformation_09 { get; set; }
        [C(10)]
        public C022_HealthCareCodeInformation_22 HealthCareCodeInformation_10 { get; set; }
        [C(11)]
        public C022_HealthCareCodeInformation_23 HealthCareCodeInformation_11 { get; set; }
        [C(12)]
        public C022_HealthCareCodeInformation_24 HealthCareCodeInformation_12 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_24
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_23
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_22
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_21
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_20
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_19
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_18
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_17
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_16
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_15
    {
        
        [D(1, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_14
    {
        
        [D(1, typeof(X12_ID_1270_5), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_13
    {
        
        [D(1, typeof(X12_ID_1270_4), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string AnesthesiaRelatedSurgicalProcedure_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class HI_HealthCareDiagnosisCode
    {
        
        [C(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        [C(2)]
        public C022_HealthCareCodeInformation_2 HealthCareCodeInformation_02 { get; set; }
        [C(3)]
        public C022_HealthCareCodeInformation_3 HealthCareCodeInformation_03 { get; set; }
        [C(4)]
        public C022_HealthCareCodeInformation_4 HealthCareCodeInformation_04 { get; set; }
        [C(5)]
        public C022_HealthCareCodeInformation_5 HealthCareCodeInformation_05 { get; set; }
        [C(6)]
        public C022_HealthCareCodeInformation_6 HealthCareCodeInformation_06 { get; set; }
        [C(7)]
        public C022_HealthCareCodeInformation_7 HealthCareCodeInformation_07 { get; set; }
        [C(8)]
        public C022_HealthCareCodeInformation_8 HealthCareCodeInformation_08 { get; set; }
        [C(9)]
        public C022_HealthCareCodeInformation_9 HealthCareCodeInformation_09 { get; set; }
        [C(10)]
        public C022_HealthCareCodeInformation_10 HealthCareCodeInformation_10 { get; set; }
        [C(11)]
        public C022_HealthCareCodeInformation_11 HealthCareCodeInformation_11 { get; set; }
        [C(12)]
        public C022_HealthCareCodeInformation_12 HealthCareCodeInformation_12 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_12
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_11
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_10
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_9
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_8
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_7
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_6
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_5
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_4
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_3
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_2
    {
        
        [D(1, typeof(X12_ID_1270_3), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation
    {
        
        [D(1, typeof(X12_ID_1270_2), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN), "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID_1250_3), "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, typeof(X12_R), "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_AN), "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, typeof(X12_AN), "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class All_CRC
    {
        
        [S("CRC", 1)]
        public List<CRC_AmbulanceCertification> CRC_AmbulanceCertification { get; set; }
        [S("CRC", 2)]
        public List<CRC_PatientConditionInformation_Vision> CRC_PatientConditionInformation_Vision { get; set; }
        [S("CRC", 3)]
        public CRC_HomeboundIndicator CRC_HomeboundIndicator { get; set; }
        [S("CRC", 4)]
        public CRC_EPSDTReferral CRC_EPSDTReferral { get; set; }
    }
    
    public class CRC_EPSDTReferral
    {
        
        [D(1, typeof(X12_ID_1136_4), "1136")]
        public string CodeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string CertificationConditionCodeAppliesIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_5), "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1321_5), "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, typeof(X12_ID_1321_5), "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_HomeboundIndicator
    {
        
        [D(1, typeof(X12_ID_1136_3), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_2), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_3), "1321")]
        public string HomeboundIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1321_4), "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_PatientConditionInformation_Vision
    {
        
        [D(1, typeof(X12_ID_1136_2), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_2), "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, typeof(X12_ID_1321_2), "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, typeof(X12_ID_1321_2), "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, typeof(X12_ID_1321_2), "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, typeof(X12_ID_1321_2), "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class CRC_AmbulanceCertification
    {
        
        [D(1, typeof(X12_ID_1136), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_3), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, typeof(X12_ID_1321), "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class CR2_SpinalManipulationServiceInformation
    {
        
        [D(1, typeof(X12_N0), "609")]
        public string Count_01 { get; set; }
        [D(2, typeof(X12_R), "380")]
        public string Quantity_02 { get; set; }
        [D(3, typeof(X12_ID_1367), "1367")]
        public string SubluxationLevelCode_03 { get; set; }
        [D(4, typeof(X12_ID_1367), "1367")]
        public string SubluxationLevelCode_04 { get; set; }
        [D(5, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string Quantity_06 { get; set; }
        [D(7, typeof(X12_R), "380")]
        public string Quantity_07 { get; set; }
        [D(8, typeof(X12_ID_1342), "1342")]
        public string PatientConditionCode_08 { get; set; }
        [D(9, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
        [D(10, typeof(X12_AN), "352")]
        public string PatientConditionDescription_10 { get; set; }
        [D(11, typeof(X12_AN), "352")]
        public string PatientConditionDescription_11 { get; set; }
        [D(12, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    public class CR1_AmbulanceTransportInformation
    {
        
        [D(1, typeof(X12_ID_355_3), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "81")]
        public string PatientWeight_02 { get; set; }
        [D(3, typeof(X12_ID_1316), "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, typeof(X12_ID_1317), "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, typeof(X12_ID_355_4), "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, typeof(X12_R), "380")]
        public string TransportDistance_06 { get; set; }
        [D(7, typeof(X12_AN), "166")]
        public string AddressInformation_07 { get; set; }
        [D(8, typeof(X12_AN), "166")]
        public string AddressInformation_08 { get; set; }
        [D(9, typeof(X12_AN), "352")]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10, typeof(X12_AN), "352")]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class NTE_ClaimNote
    {
        
        [D(1, typeof(X12_ID_363), "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, typeof(X12_AN), "352")]
        public string ClaimNoteText_02 { get; set; }
    }
    
    public class K3_FileInformation
    {
        
        [D(1, typeof(X12_AN), "449")]
        public string FixedFormatInformation_01 { get; set; }
        [D(2, typeof(X12_ID_1333), "1333")]
        public string RecordFormatCode_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure
    {
        
        [D(1, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R), "1018")]
        public string Exponent_02 { get; set; }
        [D(3, typeof(X12_R), "649")]
        public string Multiplier_03 { get; set; }
        [D(4, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, typeof(X12_R), "1018")]
        public string Exponent_05 { get; set; }
        [D(6, typeof(X12_R), "649")]
        public string Multiplier_06 { get; set; }
        [D(7, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "1018")]
        public string Exponent_08 { get; set; }
        [D(9, typeof(X12_R), "649")]
        public string Multiplier_09 { get; set; }
        [D(10, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, typeof(X12_R), "1018")]
        public string Exponent_11 { get; set; }
        [D(12, typeof(X12_R), "649")]
        public string Multiplier_12 { get; set; }
        [D(13, typeof(X12_ID_355_2), "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, typeof(X12_R), "1018")]
        public string Exponent_14 { get; set; }
        [D(15, typeof(X12_R), "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_REF_5
    {
        
        [S("REF", 1)]
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode { get; set; }
        [S("REF", 2)]
        public REF_MandatoryMedicare_Section4081_CrossoverIndicator REF_MandatoryMedicare_Section4081_CrossoverIndicator { get; set; }
        [S("REF", 3)]
        public REF_MammographyCertificationNumber REF_MammographyCertificationNumber { get; set; }
        [S("REF", 4)]
        public REF_ReferralNumber REF_ReferralNumber { get; set; }
        [S("REF", 5)]
        public REF_PriorAuthorization REF_PriorAuthorization { get; set; }
        [S("REF", 6)]
        public REF_PayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
        [S("REF", 7)]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number { get; set; }
        [S("REF", 8)]
        public REF_RepricedClaimNumber REF_RepricedClaimNumber { get; set; }
        [S("REF", 9)]
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber { get; set; }
        [S("REF", 10)]
        public REF_InvestigationalDeviceExemptionNumber REF_InvestigationalDeviceExemptionNumber { get; set; }
        [S("REF", 11)]
        public REF_ClaimIdentifierForTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries { get; set; }
        [S("REF", 12)]
        public REF_MedicalRecordNumber REF_MedicalRecordNumber { get; set; }
        [S("REF", 13)]
        public REF_DemonstrationProjectIdentifier REF_DemonstrationProjectIdentifier { get; set; }
        [S("REF", 14)]
        public REF_CarePlanOversight REF_CarePlanOversight { get; set; }
    }
    
    public class REF_CarePlanOversight
    {
        
        [D(1, typeof(X12_ID_128_24), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string CarePlanOversightNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_22 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_22
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_DemonstrationProjectIdentifier
    {
        
        [D(1, typeof(X12_ID_128_23), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string DemonstrationProjectIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_21 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_21
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MedicalRecordNumber
    {
        
        [D(1, typeof(X12_ID_128_22), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string MedicalRecordNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_20 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_20
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClaimIdentifierForTransmissionIntermediaries
    {
        
        [D(1, typeof(X12_ID_128_21), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ValueAddedNetworkTraceNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_19 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_19
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_InvestigationalDeviceExemptionNumber
    {
        
        [D(1, typeof(X12_ID_128_20), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string InvestigationalDeviceExemptionIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_18 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_18
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_AdjustedRepricedClaimNumber
    {
        
        [D(1, typeof(X12_ID_128_19), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string AdjustedRepricedClaimReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_17 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_17
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_RepricedClaimNumber
    {
        
        [D(1, typeof(X12_ID_128_18), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string RepricedClaimReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_16 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_16
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number
    {
        
        [D(1, typeof(X12_ID_128_17), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_15 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_15
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PayerClaimControlNumber
    {
        
        [D(1, typeof(X12_ID_128_16), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PayerClaimControlNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_14 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_14
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PriorAuthorization
    {
        
        [D(1, typeof(X12_ID_128_15), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PriorAuthorizationNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_13 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_13
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ReferralNumber
    {
        
        [D(1, typeof(X12_ID_128_14), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_12 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_12
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MammographyCertificationNumber
    {
        
        [D(1, typeof(X12_ID_128_13), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_11 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_11
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MandatoryMedicare_Section4081_CrossoverIndicator
    {
        
        [D(1, typeof(X12_ID_128_12), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_127_2), "127")]
        public string MedicareSection4081Indicator_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_10 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_10
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ServiceAuthorizationExceptionCode
    {
        
        [D(1, typeof(X12_ID_128_11), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_127_1), "127")]
        public string ServiceAuthorizationExceptionCode_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_9 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_9
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class AMT_PatientAmountPaid
    {
        
        [D(1, typeof(X12_ID_522), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string PatientAmountPaid_02 { get; set; }
        [D(3, typeof(X12_ID_478), "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class CN1_ContractInformation
    {
        
        [D(1, typeof(X12_ID_1166), "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string ContractAmount_02 { get; set; }
        [D(3, typeof(X12_R), "332")]
        public string ContractPercentage_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ContractCode_04 { get; set; }
        [D(5, typeof(X12_R), "338")]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6, typeof(X12_AN), "799")]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class PWK_ClaimSupplementalInformation
    {
        
        [D(1, typeof(X12_ID_755), "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_756), "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, typeof(X12_N0), "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, typeof(X12_ID_66_6), "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "67")]
        public string AttachmentControlNumber_06 { get; set; }
        [D(7, typeof(X12_AN), "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated ActionsIndicated_08 { get; set; }
        [D(9, typeof(X12_ID_1525), "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class C002_ActionsIndicated
    {
        
        [D(1, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, typeof(X12_ID_704), "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class All_DTP
    {
        
        [S("DTP", 1)]
        public DTP_Date_OnsetofCurrentIllnessorSymptom DTP_Date_OnsetofCurrentIllnessorSymptom { get; set; }
        [S("DTP", 2)]
        public DTP_Date_InitialTreatmentDate DTP_Date_InitialTreatmentDate { get; set; }
        [S("DTP", 3)]
        public DTP_Date_LastSeenDate DTP_Date_LastSeenDate { get; set; }
        [S("DTP", 4)]
        public DTP_Date_AcuteManifestation DTP_Date_AcuteManifestation { get; set; }
        [S("DTP", 5)]
        public DTP_Date_Accident DTP_Date_Accident { get; set; }
        [S("DTP", 6)]
        public DTP_Date_LastMenstrualPeriod DTP_Date_LastMenstrualPeriod { get; set; }
        [S("DTP", 7)]
        public DTP_Date_LastX_rayDate DTP_Date_LastX_rayDate { get; set; }
        [S("DTP", 8)]
        public DTP_Date_HearingandVisionPrescriptionDate DTP_Date_HearingandVisionPrescriptionDate { get; set; }
        [S("DTP", 9)]
        public DTP_Date_DisabilityDates DTP_Date_DisabilityDates { get; set; }
        [S("DTP", 10)]
        public DTP_Date_LastWorked DTP_Date_LastWorked { get; set; }
        [S("DTP", 11)]
        public DTP_Date_AuthorizedReturntoWork DTP_Date_AuthorizedReturntoWork { get; set; }
        [S("DTP", 12)]
        public DTP_Date_Admission DTP_Date_Admission { get; set; }
        [S("DTP", 13)]
        public DTP_Date_Discharge DTP_Date_Discharge { get; set; }
        [S("DTP", 14)]
        public List<DTP_Date_AssumedandRelinquishedCareDates> DTP_Date_AssumedandRelinquishedCareDates { get; set; }
        [S("DTP", 15)]
        public DTP_PropertyandCasualtyDateofFirstContact DTP_PropertyandCasualtyDateofFirstContact { get; set; }
        [S("DTP", 16)]
        public DTP_Date_RepricerReceivedDate DTP_Date_RepricerReceivedDate { get; set; }
    }
    
    public class DTP_Date_RepricerReceivedDate
    {
        
        [D(1, typeof(X12_ID_374_17), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string RepricerReceivedDate_03 { get; set; }
    }
    
    public class DTP_PropertyandCasualtyDateofFirstContact
    {
        
        [D(1, typeof(X12_ID_374_16), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string DateTimePeriod_03 { get; set; }
    }
    
    public class DTP_Date_AssumedandRelinquishedCareDates
    {
        
        [D(1, typeof(X12_ID_374_15), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string AssumedorRelinquishedCareDate_03 { get; set; }
    }
    
    public class DTP_Date_Discharge
    {
        
        [D(1, typeof(X12_ID_374_14), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string RelatedHospitalizationDischargeDate_03 { get; set; }
    }
    
    public class DTP_Date_Admission
    {
        
        [D(1, typeof(X12_ID_374_13), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string RelatedHospitalizationAdmissionDate_03 { get; set; }
    }
    
    public class DTP_Date_AuthorizedReturntoWork
    {
        
        [D(1, typeof(X12_ID_374_12), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string WorkReturnDate_03 { get; set; }
    }
    
    public class DTP_Date_LastWorked
    {
        
        [D(1, typeof(X12_ID_374_11), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastWorkedDate_03 { get; set; }
    }
    
    public class DTP_Date_DisabilityDates
    {
        
        [D(1, typeof(X12_ID_374_10), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_2), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string DisabilityFromDate_03 { get; set; }
    }
    
    public class DTP_Date_HearingandVisionPrescriptionDate
    {
        
        [D(1, typeof(X12_ID_374_9), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string PrescriptionDate_03 { get; set; }
    }
    
    public class DTP_Date_LastX_rayDate
    {
        
        [D(1, typeof(X12_ID_374_8), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class DTP_Date_LastMenstrualPeriod
    {
        
        [D(1, typeof(X12_ID_374_7), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastMenstrualPeriodDate_03 { get; set; }
    }
    
    public class DTP_Date_Accident
    {
        
        [D(1, typeof(X12_ID_374_6), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string AccidentDate_03 { get; set; }
    }
    
    public class DTP_Date_AcuteManifestation
    {
        
        [D(1, typeof(X12_ID_374_5), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    public class DTP_Date_LastSeenDate
    {
        
        [D(1, typeof(X12_ID_374_4), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string LastSeenDate_03 { get; set; }
    }
    
    public class DTP_Date_InitialTreatmentDate
    {
        
        [D(1, typeof(X12_ID_374_3), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class DTP_Date_OnsetofCurrentIllnessorSymptom
    {
        
        [D(1, typeof(X12_ID_374_2), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1251")]
        public string OnsetofCurrentIllnessorInjuryDate_03 { get; set; }
    }
    
    public class CLM_ClaimInformation
    {
        
        [D(1, typeof(X12_AN), "1028")]
        public string PatientControlNumber_01 { get; set; }
        [D(2, typeof(X12_R), "782")]
        public string TotalClaimChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID_1032_2), "1032")]
        public string ClaimFilingIndicatorCode_03 { get; set; }
        [D(4, typeof(X12_ID_1343), "1343")]
        public string NonInstitutionalClaimTypeCode_04 { get; set; }
        [C(5)]
        public C023_HealthCareServiceLocationInformation HealthCareServiceLocationInformation_05 { get; set; }
        [D(6, typeof(X12_ID_1073_3), "1073")]
        public string ProviderorSupplierSignatureIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1359), "1359")]
        public string AssignmentorPlanParticipationCode_07 { get; set; }
        [D(8, typeof(X12_ID_1073_4), "1073")]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        [D(9, typeof(X12_ID_1363), "1363")]
        public string ReleaseofInformationCode_09 { get; set; }
        [D(10, typeof(X12_ID_1351), "1351")]
        public string PatientSignatureSourceCode_10 { get; set; }
        [C(11)]
        public C024_RelatedCausesInformation RelatedCausesInformation_11 { get; set; }
        [D(12, typeof(X12_ID_1366), "1366")]
        public string SpecialProgramIndicator_12 { get; set; }
        [D(13, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_13 { get; set; }
        [D(14, typeof(X12_ID_1338), "1338")]
        public string LevelofServiceCode_14 { get; set; }
        [D(15, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_15 { get; set; }
        [D(16, typeof(X12_ID_1360), "1360")]
        public string ProviderAgreementCode_16 { get; set; }
        [D(17, typeof(X12_ID_1029), "1029")]
        public string ClaimStatusCode_17 { get; set; }
        [D(18, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_18 { get; set; }
        [D(19, typeof(X12_ID_1383), "1383")]
        public string ClaimSubmissionReasonCode_19 { get; set; }
        [D(20, typeof(X12_ID_1514), "1514")]
        public string DelayReasonCode_20 { get; set; }
    }
    
    public class C024_RelatedCausesInformation
    {
        
        [D(1, typeof(X12_ID_1362), "1362")]
        public string RelatedCausesCode_01 { get; set; }
        [D(2, typeof(X12_ID_1362), "1362")]
        public string RelatedCausesCode_02 { get; set; }
        [D(3, typeof(X12_ID_1362_2), "1362")]
        public string RelatedCausesCode_03 { get; set; }
        [D(4, typeof(X12_ID), "156")]
        public string AutoAccidentStateorProvinceCode_04 { get; set; }
        [D(5, typeof(X12_ID), "26")]
        public string CountryCode_05 { get; set; }
    }
    
    public class C023_HealthCareServiceLocationInformation
    {
        
        [D(1, typeof(X12_AN), "1331")]
        public string PlaceofServiceCode_01 { get; set; }
        [D(2, typeof(X12_ID_1332), "1332")]
        public string FacilityCodeQualifier_02 { get; set; }
        [D(3, typeof(X12_ID), "1325")]
        public string ClaimFrequencyCode_03 { get; set; }
    }
    
    public class All_NM1_3
    {
        
        [G(1)]
        public Loop_2010BA Loop_2010BA { get; set; }
        [G(2)]
        public Loop_2010BB Loop_2010BB { get; set; }
    }
    
    public class Loop_2010BB
    {
        
        [S("NM1", 1)]
        public NM1_PayerName NM1_PayerName { get; set; }
        [S("N3", 2)]
        public N3_PayerAddress N3_PayerAddress { get; set; }
        [S("N4", 3)]
        public N4_PayerCity_State_ZIPCode N4_PayerCity_State_ZIPCode { get; set; }
        [A(4)]
        public All_REF_4 All_REF_4 { get; set; }
    }
    
    public class All_REF_4
    {
        
        [S("REF", 1)]
        public List<REF_PayerSecondaryIdentification> REF_PayerSecondaryIdentification { get; set; }
        [S("REF", 2)]
        public List<REF_BillingProviderSecondaryIdentification> REF_BillingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_BillingProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_10), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string BillingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_8 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_8
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PayerSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_9), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PayerSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_7 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_7
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_PayerCity_State_ZIPCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string PayerCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string PayerStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string PayerPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_PayerAddress
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string PayerAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string PayerAddressLine_02 { get; set; }
    }
    
    public class NM1_PayerName
    {
        
        [D(1, typeof(X12_ID_98_8), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string PayerName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_4), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string PayerIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2010BA
    {
        
        [S("NM1", 1)]
        public NM1_SubscriberName NM1_SubscriberName { get; set; }
        [S("N3", 2)]
        public N3_SubscriberAddress N3_SubscriberAddress { get; set; }
        [S("N4", 3)]
        public N4_SubscriberCity_State_ZIPCode N4_SubscriberCity_State_ZIPCode { get; set; }
        [S("DMG", 4)]
        public DMG_SubscriberDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        [A(5)]
        public All_REF_3 All_REF_3 { get; set; }
        [S("PER", 6)]
        public PER_PropertyandCasualtySubscriberContactInformation PER_PropertyandCasualtySubscriberContactInformation { get; set; }
    }
    
    public class PER_PropertyandCasualtySubscriberContactInformation
    {
        
        [D(1, typeof(X12_ID_366), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN), "93")]
        public string Name_02 { get; set; }
        [D(3, typeof(X12_ID_365_3), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_4), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_5), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN), "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN), "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class All_REF_3
    {
        
        [S("REF", 1)]
        public REF_SubscriberSecondaryIdentification REF_SubscriberSecondaryIdentification { get; set; }
        [S("REF", 2)]
        public REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber { get; set; }
    }
    
    public class REF_PropertyandCasualtyClaimNumber
    {
        
        [D(1, typeof(X12_ID_128_8), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_6 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_6
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_SubscriberSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_7), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string SubscriberSupplementalIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_5 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_5
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class DMG_SubscriberDemographicInformation
    {
        
        [D(1, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "1251")]
        public string SubscriberBirthDate_02 { get; set; }
        [D(3, typeof(X12_ID_1068), "1068")]
        public string SubscriberGenderCode_03 { get; set; }
        [D(4, typeof(X12_ID_1067), "1067")]
        public string MaritalStatusCode_04 { get; set; }
        [C(5)]
        public List<C056_CompositeRaceorEthnicityInformation> CompositeRaceorEthnicityInformation_05 { get; set; }
        [D(6, typeof(X12_ID_1066), "1066")]
        public string CitizenshipStatusCode_06 { get; set; }
        [D(7, typeof(X12_ID), "26")]
        public string CountryCode_07 { get; set; }
        [D(8, typeof(X12_ID_659), "659")]
        public string BasisofVerificationCode_08 { get; set; }
        [D(9, typeof(X12_R), "380")]
        public string Quantity_09 { get; set; }
        [D(10, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_10 { get; set; }
        [D(11, typeof(X12_AN), "1271")]
        public string IndustryCode_11 { get; set; }
    }
    
    public class C056_CompositeRaceorEthnicityInformation
    {
        
        [D(1, typeof(X12_ID_1109), "1109")]
        public string RaceorEthnicityCode_01 { get; set; }
        [D(2, typeof(X12_ID_1270), "1270")]
        public string CodeListQualifierCode_02 { get; set; }
        [D(3, typeof(X12_AN), "1271")]
        public string IndustryCode_03 { get; set; }
    }
    
    public class N4_SubscriberCity_State_ZIPCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string SubscriberCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string SubscriberStateCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string SubscriberPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_SubscriberAddress
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string SubscriberAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string SubscriberAddressLine_02 { get; set; }
    }
    
    public class NM1_SubscriberName
    {
        
        [D(1, typeof(X12_ID_98_7), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string SubscriberLastName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string SubscriberFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string SubscriberMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string SubscriberNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_5), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string SubscriberPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class PAT_PatientInformation
    {
        
        [D(1, typeof(X12_ID_1069_2), "1069")]
        public string IndividualRelationshipCode_01 { get; set; }
        [D(2, typeof(X12_ID_1384), "1384")]
        public string PatientLocationCode_02 { get; set; }
        [D(3, typeof(X12_ID_584), "584")]
        public string EmploymentStatusCode_03 { get; set; }
        [D(4, typeof(X12_ID_1220), "1220")]
        public string StudentStatusCode_04 { get; set; }
        [D(5, typeof(X12_ID_1250), "1250")]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "1251")]
        public string PatientDeathDate_06 { get; set; }
        [D(7, typeof(X12_ID_355), "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R), "81")]
        public string PatientWeight_08 { get; set; }
        [D(9, typeof(X12_ID_1073_2), "1073")]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    public class X12_ID_1069_2
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","36","37","38","39","40","41","43","45","46","47","48","49","50","51","52","53","55","56","57","58","59","60","61","62","63","64","65","66","67","68","70","71","72","73","74","75","76","78","79","80","81","82","83","84","86","87","88","90","91","92","93","94","95","96","97","98","99","A1","A2","A3","A4","A5","A6","A7","A8","A9","B1","B2","B3","B4","B5","B6","B7","B8","B9","C1","C2","C3","C4","C5","C8","C9","D1","D2","D3","D4","D5","D6","D7","D8","D9","E1","E2","E3","E4","E5","E6","E7","E8","E9","F1","F2","F3","F6","F7","F8","F9","G2","G3","G4","G5","G6","G7","G8","G9","H1","H4","N1","OT","ZZ"};
    }
    
    public class SBR_SubscriberInformation
    {
        
        [D(1, typeof(X12_ID_1138), "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, typeof(X12_ID_1069), "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string SubscriberGrouporPolicyNumber_03 { get; set; }
        [D(4, typeof(X12_AN), "93")]
        public string SubscriberGroupName_04 { get; set; }
        [D(5, typeof(X12_ID_1336), "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6, typeof(X12_ID_1143), "1143")]
        public string CoordinationofBenefitsCode_06 { get; set; }
        [D(7, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_07 { get; set; }
        [D(8, typeof(X12_ID_584), "584")]
        public string EmploymentStatusCode_08 { get; set; }
        [D(9, typeof(X12_ID_1032), "1032")]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public class X12_ID_1069
    {
        
        public List<string> Codes = new List<string> {"18"};
    }
    
    public class HL_SubscriberHierarchicalLevel
    {
        
        [D(1, typeof(X12_AN), "628")]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, typeof(X12_AN), "734")]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, typeof(X12_ID_735_2), "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, typeof(X12_ID_736_2), "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class X12_ID_735_2
    {
        
        public List<string> Codes = new List<string> {"22"};
    }
    
    public class X12_ID_736_2
    {
        
        public List<string> Codes = new List<string> {"0","1"};
    }
    
    public class All_NM1_2
    {
        
        [G(1)]
        public Loop_2010AA Loop_2010AA { get; set; }
        [G(2)]
        public Loop_2010AB Loop_2010AB { get; set; }
        [G(3)]
        public Loop_2010AC Loop_2010AC { get; set; }
    }
    
    public class Loop_2010AC
    {
        
        [S("NM1", 1)]
        public NM1_Pay_ToPlanName NM1_Pay_ToPlanName { get; set; }
        [S("N3", 2)]
        public N3_Pay_ToPlanAddress N3_Pay_ToPlanAddress { get; set; }
        [S("N4", 3)]
        public N4_Pay_ToPlanCity_State_ZIPCode N4_Pay_ToPlanCity_State_ZIPCode { get; set; }
        [A(4)]
        public All_REF_2 All_REF_2 { get; set; }
    }
    
    public class All_REF_2
    {
        
        [S("REF", 1)]
        public REF_Pay_ToPlanSecondaryIdentification REF_Pay_ToPlanSecondaryIdentification { get; set; }
        [S("REF", 2)]
        public REF_Pay_ToPlanTaxIdentificationNumber REF_Pay_ToPlanTaxIdentificationNumber { get; set; }
    }
    
    public class REF_Pay_ToPlanTaxIdentificationNumber
    {
        
        [D(1, typeof(X12_ID_128_6), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PayToPlanTaxIdentificationNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_4 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_6
    {
        
        public List<string> Codes = new List<string> {"EI"};
    }
    
    public class C040_ReferenceIdentifier_4
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_Pay_ToPlanSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_5), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string PaytoPlanSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_3 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_5
    {
        
        public List<string> Codes = new List<string> {"2U","FY","NF"};
    }
    
    public class C040_ReferenceIdentifier_3
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_Pay_ToPlanCity_State_ZIPCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string PaytoPlanCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string PaytoPlanStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string PaytoPlanPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_Pay_ToPlanAddress
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string PaytoPlanAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string PaytoPlanAddressLine_02 { get; set; }
    }
    
    public class NM1_Pay_ToPlanName
    {
        
        [D(1, typeof(X12_ID_98_6), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string PaytoPlanOrganizationalName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_4), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string PaytoPlanPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_6
    {
        
        public List<string> Codes = new List<string> {"PE"};
    }
    
    public class Loop_2010AB
    {
        
        [S("NM1", 1)]
        public NM1_Pay_toAddressName NM1_Pay_toAddressName { get; set; }
        [S("N3", 2)]
        public N3_Pay_ToAddress_ADDRESS N3_Pay_ToAddress_ADDRESS { get; set; }
        [S("N4", 3)]
        public N4_Pay_toAddressCity_State_ZIPCode N4_Pay_toAddressCity_State_ZIPCode { get; set; }
    }
    
    public class N4_Pay_toAddressCity_State_ZIPCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string PaytoAddressCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string PaytoAddressStateCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string PaytoAddressPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_Pay_ToAddress_ADDRESS
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string PaytoAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string PaytoAddressLine_02 { get; set; }
    }
    
    public class NM1_Pay_toAddressName
    {
        
        [D(1, typeof(X12_ID_98_5), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string PaytoLastorOrganizationalName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_3), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_5
    {
        
        public List<string> Codes = new List<string> {"87"};
    }
    
    public class Loop_2010AA
    {
        
        [S("NM1", 1)]
        public NM1_BillingProviderName NM1_BillingProviderName { get; set; }
        [S("N3", 2)]
        public N3_BillingProviderAddress N3_BillingProviderAddress { get; set; }
        [S("N4", 3)]
        public N4_BillingProviderCity_State_ZIPCode N4_BillingProviderCity_State_ZIPCode { get; set; }
        [A(4)]
        public All_REF All_REF { get; set; }
        [S("PER", 5)]
        public List<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation { get; set; }
    }
    
    public class PER_BillingProviderContactInformation
    {
        
        [D(1, typeof(X12_ID_366), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN), "93")]
        public string BillingProviderContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_2), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_2), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN), "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN), "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class All_REF
    {
        
        [S("REF", 1)]
        public REF_BillingProviderTaxIdentification REF_BillingProviderTaxIdentification { get; set; }
        [S("REF", 2)]
        public List<REF_BillingProviderUPIN_LicenseInformation> REF_BillingProviderUPIN_LicenseInformation { get; set; }
    }
    
    public class REF_BillingProviderUPIN_LicenseInformation
    {
        
        [D(1, typeof(X12_ID_128_4), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string BillingProviderLicenseandorUPINInformation_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_2 ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_4
    {
        
        public List<string> Codes = new List<string> {"0B","1G"};
    }
    
    public class C040_ReferenceIdentifier_2
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_BillingProviderTaxIdentification
    {
        
        [D(1, typeof(X12_ID_128_2), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string BillingProviderTaxIdentificationNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    public class X12_ID_128_2
    {
        
        public List<string> Codes = new List<string> {"EI","SY"};
    }
    
    public class C040_ReferenceIdentifier
    {
        
        [D(1, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN), "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, typeof(X12_ID_128_3), "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_BillingProviderCity_State_ZIPCode
    {
        
        [D(1, typeof(X12_AN), "19")]
        public string BillingProviderCityName_01 { get; set; }
        [D(2, typeof(X12_ID), "156")]
        public string BillingProviderStateorProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID), "116")]
        public string BillingProviderPostalZoneorZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID), "26")]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID_309), "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, typeof(X12_ID), "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_BillingProviderAddress
    {
        
        [D(1, typeof(X12_AN), "166")]
        public string BillingProviderAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN), "166")]
        public string BillingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_BillingProviderName
    {
        
        [D(1, typeof(X12_ID_98_4), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string BillingProviderLastorOrganizationalName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string BillingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string BillingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string BillingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_2), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string BillingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class CUR_ForeignCurrencyInformation
    {
        
        [D(1, typeof(X12_ID_98_4), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID), "100")]
        public string CurrencyCode_02 { get; set; }
        [D(3, typeof(X12_R), "280")]
        public string ExchangeRate_03 { get; set; }
        [D(4, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, typeof(X12_ID), "100")]
        public string CurrencyCode_05 { get; set; }
        [D(6, typeof(X12_ID_669), "669")]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        [D(7, typeof(X12_ID_374), "374")]
        public string DateTimeQualifier_07 { get; set; }
        [D(8, typeof(X12_DT), "373")]
        public string Date_08 { get; set; }
        [D(9, typeof(X12_TM), "337")]
        public string Time_09 { get; set; }
        [D(10, typeof(X12_ID_374), "374")]
        public string DateTimeQualifier_10 { get; set; }
        [D(11, typeof(X12_DT), "373")]
        public string Date_11 { get; set; }
        [D(12, typeof(X12_TM), "337")]
        public string Time_12 { get; set; }
        [D(13, typeof(X12_ID_374), "374")]
        public string DateTimeQualifier_13 { get; set; }
        [D(14, typeof(X12_DT), "373")]
        public string Date_14 { get; set; }
        [D(15, typeof(X12_TM), "337")]
        public string Time_15 { get; set; }
        [D(16, typeof(X12_ID_374), "374")]
        public string DateTimeQualifier_16 { get; set; }
        [D(17, typeof(X12_DT), "373")]
        public string Date_17 { get; set; }
        [D(18, typeof(X12_TM), "337")]
        public string Time_18 { get; set; }
        [D(19, typeof(X12_ID_374), "374")]
        public string DateTimeQualifier_19 { get; set; }
        [D(20, typeof(X12_DT), "373")]
        public string Date_20 { get; set; }
        [D(21, typeof(X12_TM), "337")]
        public string Time_21 { get; set; }
    }
    
    public class X12_ID_669
    {
        
        public List<string> Codes = new List<string> {"IMF","LNF","LNS","NYC","PHI","ZUR"};
    }
    
    public class X12_ID_374
    {
        
        public List<string> Codes = new List<string> {"001","002","003","004","005","006","007","008","009","010","011","012","013","014","015","016","017","018","019","020","021","022","023","024","025","026","027","028","029","030","031","032","033","034","035","036","037","038","039","040","041","042","043","044","045","046","047","048","049","050","051","052","053","054","055","056","057","058","059","060","061","062","063","064","065","066","067","068","069","070","071","072","073","074","075","076","077","078","079","080","081","082","083","084","085","086","087","088","089","090","091","092","093","094","095","096","097","098","099","100","101","102","103","104","105","106","107","108","109","110","111","112","113","114","115","116","118","119","120","121","122","124","125","126","127","128","129","130","131","132","133","134","135","136","137","138","139","140","141","142","143","144","145","146","147","148","149","150","151","152","153","154","155","156","157","158","159","160","161","162","163","164","165","166","167","168","169","170","171","172","173","174","175","176","177","178","179","180","181","182","183","184","185","186","187","188","189","190","191","192","193","194","195","196","197","198","199","200","201","202","203","204","205","206","207","208","209","210","211","212","213","214","215","216","217","218","219","220","221","222","223","224","225","226","227","228","229","230","231","232","233","234","235","236","237","238","239","240","241","242","243","244","245","246","247","248","249","250","251","252","253","254","255","256","257","258","259","260","261","262","263","264","265","266","267","268","269","270","271","272","273","274","275","276","277","278","279","280","281","282","283","284","285","286","287","288","289","290","291","292","293","294","295","296","297","298","299","300","301","302","303","304","305","306","307","308","309","310","311","312","313","314","315","316","317","318","319","320","321","322","323","324","325","326","327","328","329","330","331","332","333","334","335","336","337","338","339","340","341","342","343","344","345","346","347","348","349","350","351","352","353","354","355","356","357","358","359","360","361","362","363","364","365","366","367","368","369","370","371","372","373","374","375","376","377","378","379","380","381","382","383","384","385","386","387","388","389","390","391","392","393","394","395","396","397","398","399","400","401","402","403","404","405","406","408","409","410","411","412","413","414","415","416","417","418","419","420","421","422","423","424","425","426","427","428","429","430","431","432","433","434","435","436","437","438","439","440","441","442","443","444","445","446","447","448","449","450","451","452","453","454","455","456","457","458","459","460","461","462","463","464","465","466","467","468","469","470","471","472","473","474","475","476","477","478","479","480","481","482","483","484","485","486","487","488","489","490","491","492","493","494","495","496","497","498","499","500","501","502","503","504","505","506","507","508","509","510","511","512","513","514","515","516","517","518","519","520","521","522","523","524","525","526","527","528","529","530","531","532","533","534","535","536","537","538","539","540","541","542","543","544","545","546","547","548","549","550","551","552","553","554","555","556","557","558","559","560","561","562","563","564","565","566","567","568","569","570","571","572","573","574","575","576","577","578","579","580","581","582","583","584","585","586","587","589","590","591","592","593","594","595","596","597","598","599","600","601","602","603","604","606","607","608","609","610","611","612","613","614","615","616","617","618","619","620","621","622","623","624","625","626","627","629","630","631","632","633","634","635","636","637","638","640","641","642","643","644","646","647","648","649","650","651","652","653","655","656","657","658","659","660","661","662","663","664","665","666","667","668","669","670","671","672","673","674","675","681","682","683","684","685","686","687","688","689","690","691","692","693","694","695","696","697","699","700","701","702","703","704","705","706","707","708","709","710","711","712","713","714","715","716","717","718","719","720","721","722","723","724","725","726","727","728","729","730","731","732","733","734","736","737","738","739","740","741","742","743","744","745","746","747","748","749","750","751","752","753","754","755","756","757","758","759","760","761","762","764","765","766","769","770","771","772","773","774","775","776","777","778","779","780","781","782","783","784","785","786","787","788","789","790","791","792","793","794","795","796","797","798","799","800","801","802","803","804","805","806","807","808","809","810","811","812","813","814","815","816","817","818","819","820","821","822","823","824","825","826","827","828","830","831","832","840","841","842","843","844","845","846","847","848","849","850","851","853","854","855","856","857","858","859","860","861","862","863","864","865","866","867","868","869","870","871","872","873","874","875","876","877","878","879","880","881","882","883","884","885","900","901","903","904","905","906","907","908","909","910","911","912","913","914","915","916","917","918","919","920","921","922","923","924","925","926","927","928","930","931","932","933","934","935","936","937","938","939","940","941","942","943","944","945","946","947","948","949","950","951","952","953","954","955","956","957","960","961","962","963","964","965","966","967","968","969","970","971","972","973","974","975","976","977","978","979","980","981","982","983","984","985","986","987","988","989","990","992","993","994","995","996","997","998","999","AA1","AA2","AA3","AA4","AA5","AA6","AA7","AA8","AA9","AAA","AAB","AAC","AAD","AAE","AAF","AAG","AAH","AAI","AAJ","AAK","AAL","AAM","AAN","AAO","AAP","AAQ","AAR","AAS","AAT","AAU","AAV","AAW","AAX","AAY","AAZ","AB1","AB2","AB3","AB4","AB5","AB6","AB7","AB8","AB9","ABA","ABB","ABC","ABD","ABE","ABF","ABG","ABH","ABI","ABK","ABL","ABM","ABN","ABO","ABP","ABQ","ABR","ABS","ABT","ABU","ABV","ABW","ABX","ABY","ACA","ACB","ACC","ACD","ACE","ACF","ACG","ACH","ACI","ACJ","ACK","ACL","ACM","ACN","ACO","ACP","ACQ","ACR","ACS","ACT","ACU","ACV","ACW","ACX","ACZ","ADA","ADB","ADC","ADD","ADE","ADF","ADG","ADH","ADI","ADJ","ADK","ADL","ADM","ADN","ADR","ADS","ADT","ADU","ADV","ADW","ADX","ADY","AEA","AEB","AEC","AED","AEE","AEF","AEG","AEH","AEI","AEK","AEL","AEM","AEN","AEO","AEP","AEQ","AER","AES","AET","AEU","AEV","AEW","AEX","AEY","ARD","AWH","BAA","BAB","BAC","BAD","BAE","BAF","BAG","BAH","BAI","BAJ","BAK","BAL","BAM","BAN","BAO","BAP","BAQ","BAR","BIP","CAD","CCR","CDD","CDT","CEA","CEB","CEC","CED","CEE","CEF","CEH","CEJ","CEK","CEL","CEM","CEN","CEO","CLO","CLU","COM","CON","CRV","CUR","DAF","DDO","DEE","DEL","DET","DFF","DFS","DIL","DIP","DIS","DLC","DOA","DOD","DOI","DOR","DSP","DTC","DTQ","E01","E02","E03","E04","E05","E06","E07","ECD","ECF","ECS","ECT","EDA","EDB","EDC","EDD","EDE","EDF","EDG","EDH","EDI","EDJ","EDK","EDL","EDM","EDN","EDO","EDP","EKD","EPP","ESC","ESF","ESS","EST","ETP","EXO","EXP","FFI","FFO","FIA","FPE","FPS","GRD","ICF","IDG","IFH","III","IMP","INC","INT","IPS","IVA","KEV","KEW","LAM","LAS","LCC","LEA","LEL","LIQ","LLP","LOG","LPC","LSC","LTP","MRR","MSD","NAM","NFD","NOD","NRG","NSD","ORG","PBC","PCP","PCS","PDE","PDR","PDV","PLS","PPC","PPD","PPP","PRD","PRR","PSA","PSC","PSF","PTD","PTO","RAP","RES","RFD","RFF","RFO","RNT","RRM","RRT","RSD","RSS","RTO","SCV","SDD","SFH","STN","SVA","TSR","TSS","TST","VAT","VLU","W01","W02","W03","W05","W06","W07","W08","W09","W10","W11","W12","W13","WAA","WAY","YXX","YXY","ZZZ"};
    }
    
    public class X12_TM
    {
    }
    
    public class PRV_BillingProviderSpecialtyInformation
    {
        
        [D(1, typeof(X12_ID_1221), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128), "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, typeof(X12_ID), "156")]
        public string StateorProvinceCode_04 { get; set; }
        [C(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        [D(6, typeof(X12_ID_1223), "1223")]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    public class X12_ID_1221
    {
        
        public List<string> Codes = new List<string> {"BI"};
    }
    
    public class C035_ProviderSpecialtyInformation
    {
        
        [D(1, typeof(X12_ID_1222), "1222")]
        public string ProviderSpecialtyCode_01 { get; set; }
        [D(2, typeof(X12_ID_559), "559")]
        public string AgencyQualifierCode_02 { get; set; }
        [D(3, typeof(X12_ID_1073), "1073")]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public class HL_BillingProviderHierarchicalLevel
    {
        
        [D(1, typeof(X12_AN), "628")]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, typeof(X12_AN), "734")]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, typeof(X12_ID_735), "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, typeof(X12_ID_736), "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class X12_ID_735
    {
        
        public List<string> Codes = new List<string> {"20"};
    }
    
    public class X12_ID_736
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class All_NM1
    {
        
        [G(1)]
        public Loop_1000A Loop_1000A { get; set; }
        [G(2)]
        public Loop_1000B Loop_1000B { get; set; }
    }
    
    public class Loop_1000B
    {
        
        [S("NM1", 1)]
        public NM1_ReceiverName NM1_ReceiverName { get; set; }
    }
    
    public class NM1_ReceiverName
    {
        
        [D(1, typeof(X12_ID_98_3), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_2), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string ReceiverName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string ReceiverPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98_3
    {
        
        public List<string> Codes = new List<string> {"40"};
    }
    
    public class X12_ID_66
    {
        
        public List<string> Codes = new List<string> {"46"};
    }
    
    public class Loop_1000A
    {
        
        [S("NM1", 1)]
        public NM1_SubmitterName NM1_SubmitterName { get; set; }
        [S("PER", 2)]
        public List<PER_SubmitterEDIContactInformation> PER_SubmitterEDIContactInformation { get; set; }
    }
    
    public class PER_SubmitterEDIContactInformation
    {
        
        [D(1, typeof(X12_ID_366), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN), "93")]
        public string SubmitterContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN), "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_2), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN), "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_2), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN), "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN), "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class NM1_SubmitterName
    {
        
        [D(1, typeof(X12_ID_98), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN), "1035")]
        public string SubmitterLastorOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN), "1036")]
        public string SubmitterFirstName_04 { get; set; }
        [D(5, typeof(X12_AN), "1037")]
        public string SubmitterMiddleNameorInitial_05 { get; set; }
        [D(6, typeof(X12_AN), "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, typeof(X12_AN), "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN), "67")]
        public string SubmitterIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID_706), "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, typeof(X12_ID_98_2), "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, typeof(X12_AN), "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class X12_ID_98
    {
        
        public List<string> Codes = new List<string> {"41"};
    }
    
    public class BHT_BeginningofHierarchicalTransaction
    {
        
        [D(1, typeof(X12_ID_1005), "1005")]
        public string HierarchicalStructureCode_01 { get; set; }
        [D(2, typeof(X12_ID_353), "353")]
        public string TransactionSetPurposeCode_02 { get; set; }
        [D(3, typeof(X12_AN), "127")]
        public string OriginatorApplicationTransactionIdentifier_03 { get; set; }
        [D(4, typeof(X12_DT), "373")]
        public string TransactionSetCreationDate_04 { get; set; }
        [D(5, typeof(X12_TM), "337")]
        public string TransactionSetCreationTime_05 { get; set; }
        [D(6, typeof(X12_ID_640), "640")]
        public string ClaimorEncounterIdentifier_06 { get; set; }
    }
    
    public class X12_ID_1005
    {
        
        public List<string> Codes = new List<string> {"0019"};
    }
    
    public class X12_ID_353
    {
        
        public List<string> Codes = new List<string> {"00","18"};
    }
    
    public class X12_ID_640
    {
        
        public List<string> Codes = new List<string> {"31","CH","RP"};
    }
    
    public class ST
    {
        
        [D(1, typeof(X12_ID_143), "143")]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "329")]
        public string TransactionSetControlNumber_02 { get; set; }
        [D(3, typeof(X12_ID_1705), "1705")]
        public string ImplementationGuideVersionName_03 { get; set; }
    }
    
    public class X12_ID_143
    {
        
        public List<string> Codes = new List<string> {"837"};
    }
    
    public class X12_ID_1705
    {
        
        public List<string> Codes = new List<string> {"005010X222A1"};
    }
}
